// <copyright file="ChineseMapNamesTests.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Tests;

using System.Globalization;
using Microsoft.Extensions.Logging.Abstractions;
using MUnique.OpenMU.DataModel.Configuration;
using MUnique.OpenMU.DataModel.Configuration.Items;
using MUnique.OpenMU.Interfaces;
using MUnique.OpenMU.Persistence.Initialization.Updates;
using MUnique.OpenMU.Persistence.InMemory;
using MUnique.OpenMU.PlugIns;

/// <summary>Verifies item localization and safe optional upgrades.</summary>
[TestFixture]
[NonParallelizable]
internal class ChineseItemNamesTests
{
    private static readonly CultureInfo Chinese = CultureInfo.GetCultureInfo("zh-CN");

    /// <summary>Fresh configurations translate existing items and mark the update installed.</summary>
    /// <param name="version">The initialization version.</param>
    [TestCase("075")]
    [TestCase("095d")]
    [TestCase("Season6")]
    public async Task FreshItemsAreTranslatedAsync(string version)
    {
        var provider = new InMemoryPersistenceContextProvider();
        DataInitializationBase initializer = version switch
        {
            "075" => new Version075.DataInitialization(provider, NullLoggerFactory.Instance),
            "095d" => new Version095d.DataInitialization(provider, NullLoggerFactory.Instance),
            _ => new VersionSeasonSix.DataInitialization(provider, NullLoggerFactory.Instance),
        };
        await initializer.CreateInitialDataAsync(1, false).ConfigureAwait(false);
        using var context = provider.CreateNewContext();
        var configuration = (await context.GetAsync<GameConfiguration>().ConfigureAwait(false)).Single();
        Assert.That(configuration.Items.Single(item => item.Group == 0 && item.Number == 0).Name.GetTranslation(Chinese), Is.EqualTo("波刃剑"));
        Assert.That(configuration.Items.Single(item => item.Group == 0 && item.Number == 1).Name.GetTranslation(Chinese), Is.EqualTo("短剑"));
        Assert.That(configuration.Items.Single(item => item.Group == 6 && item.Number == 1).Name.GetTranslation(Chinese), Is.EqualTo("战士之盾"));
        if (version == "Season6")
        {
            Assert.That(configuration.Items.Single(item => item.Group == 14 && item.Number == 23).Name.GetTranslation(Chinese), Is.EqualTo("帝王之书;荣誉戒指"));
            Assert.That(configuration.Items.Single(item => item.Group == 13 && item.Number == 38).Name.GetTranslation(Chinese), Is.EqualTo("悬石"));
            Assert.That(configuration.Items.Single(item => item.Group == 8 && item.Number == 73).Name.GetTranslation(Chinese), Is.EqualTo("凤魂之铠"));
        }

        var updates = await context.GetAsync<ConfigurationUpdate>().ConfigureAwait(false);
        Assert.That(updates.Any(update => update.Version == (int)CreateUpdate(version).Version && update.InstalledAt is not null), Is.True);
    }

    /// <summary>Upgrades distinguish groups, preserve custom names and attributes, and are idempotent.</summary>
    /// <param name="version">The initialization version.</param>
    [TestCase("075")]
    [TestCase("095d")]
    [TestCase("Season6")]
    public async Task StoredItemsAreUpdatedSafelyAsync(string version)
    {
        var provider = new InMemoryPersistenceContextProvider();
        using var context = provider.CreateNewContext();
        var configuration = context.CreateNew<GameConfiguration>();
        var update = CreateUpdate(version);
        context.CreateNew<ConfigurationUpdateState>().InitializationKey = update.DataInitializationKey;
        var sword = AddItem(0, 1, "Short Sword||de=Kurzschwert||zh=Short 剑");
        var axe = AddItem(1, 1, "Hand Axe");
        var neutral = AddItem(0, 0, "Kris||zh=Kris");
        var custom = AddItem(0, 2, "Rapier||zh=自定义武器");
        var renamed = AddItem(0, 3, "Custom Weapon||zh=Katache");
        var unknown = AddItem(1, 99, "Hand Axe");
        var wrongGroup = AddItem(0, 1, "Hand Axe");
        var quest = AddItem(14, 24, "Broken Sword;Dark Stone||zh=Broken 剑;黑暗Stone");
        sword.DropLevel = 73;
        sword.Value = 12345;
        sword.Durability = 42;
        sword.MaximumSockets = 5;
        var id = sword.GetId();
        await context.SaveChangesAsync().ConfigureAwait(false);

        var manager = new PlugInManager(null, NullLoggerFactory.Instance, null, null);
        manager.DiscoverAndRegisterPlugInsOf<IConfigurationUpdatePlugIn>();
        var service = new DataUpdateService(provider, manager);
        var available = (await service.DetermineAvailableUpdatesAsync().ConfigureAwait(false)).OfType<AlignChineseItemNamesPlugInBase>().ToList();
        Assert.That(available.Select(item => item.Version), Is.EqualTo(new[] { update.Version }));
        Assert.That(available.Single().IsMandatory, Is.False);
        await service.ApplyUpdatesAsync(available, new Progress<(UpdateVersion, bool)>()).ConfigureAwait(false);

        Assert.That(sword.Name.ValueInNeutralLanguage, Is.EqualTo("Short Sword"));
        Assert.That(sword.Name.GetTranslation(Chinese), Is.EqualTo("短剑"));
        Assert.That(sword.Name.GetTranslation(CultureInfo.GetCultureInfo("de")), Is.EqualTo("Kurzschwert"));
        Assert.That(axe.Name.GetTranslation(Chinese), Is.EqualTo("手斧"));
        Assert.That(neutral.Name.GetTranslation(Chinese), Is.EqualTo("波刃剑"));
        Assert.That(custom.Name.GetTranslation(Chinese), Is.EqualTo("自定义武器"));
        Assert.That(renamed.Name.Value, Is.EqualTo("Custom Weapon||zh=Katache"));
        Assert.That(unknown.Name.Value, Is.EqualTo("Hand Axe"));
        Assert.That(wrongGroup.Name.Value, Is.EqualTo("Hand Axe"));
        Assert.That(quest.Name.GetTranslation(Chinese), Is.EqualTo("断魂之剑;暗黑之石"));
        Assert.That(sword.GetId(), Is.EqualTo(id));
        Assert.That(sword.Group, Is.Zero);
        Assert.That(sword.Number, Is.EqualTo(1));
        Assert.That(sword.DropLevel, Is.EqualTo(73));
        Assert.That(sword.Value, Is.EqualTo(12345));
        Assert.That(sword.Durability, Is.EqualTo(42));
        Assert.That(sword.MaximumSockets, Is.EqualTo(5));
        Assert.That(configuration.Items, Has.Count.EqualTo(8));
        Assert.That((await service.DetermineAvailableUpdatesAsync().ConfigureAwait(false)).OfType<AlignChineseItemNamesPlugInBase>(), Is.Empty);
        var names = configuration.Items.Select(item => item.Name).ToArray();
        await update.ApplyUpdateAsync(context, configuration).ConfigureAwait(false);
        Assert.That(configuration.Items.Select(item => item.Name), Is.EqualTo(names));

        ItemDefinition AddItem(byte group, short number, string name)
        {
            var item = context.CreateNew<ItemDefinition>();
            item.Group = group;
            item.Number = number;
            item.Name = new LocalizedString(name);
            configuration.Items.Add(item);
            return item;
        }
    }

    private static AlignChineseItemNamesPlugInBase CreateUpdate(string version) => version switch
    {
        "075" => new AlignChineseItemNamesPlugIn075(),
        "095d" => new AlignChineseItemNamesPlugIn095d(),
        _ => new AlignChineseItemNamesPlugInSeason6(),
    };
}
