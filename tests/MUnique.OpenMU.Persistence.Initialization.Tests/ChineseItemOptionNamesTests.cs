// <copyright file="ChineseItemOptionNamesTests.cs" company="MUnique">
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

/// <summary>Tests fresh initialization and safe optional updates of item option names.</summary>
[TestFixture]
[NonParallelizable]
public class ChineseItemOptionNamesTests
{
    private static readonly CultureInfo Chinese = CultureInfo.GetCultureInfo("zh-CN");

    /// <summary>New configurations contain translated types, option groups and sets.</summary>
    /// <param name="version">The configuration version.</param>
    [TestCase("075")]
    [TestCase("095d")]
    [TestCase("Season6")]
    public async Task FreshOptionsAreTranslatedAsync(string version)
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
        Assert.That(configuration.ItemOptionTypes.Single(type => type.Name.ValueInNeutralLanguage == "Option").Name.GetTranslation(Chinese), Is.EqualTo("追加属性"));
        Assert.That(configuration.ItemOptions, Is.Not.Empty);
        foreach (var option in configuration.ItemOptions)
        {
            Assert.That(option.Name.GetTranslation(Chinese, false), Is.Not.Null.And.Not.Empty, option.Name.ValueInNeutralLanguage);
        }

        if (version == "Season6")
        {
            Assert.That(configuration.ItemSetGroups.Single(set => set.Name.ValueInNeutralLanguage == "Hyon").Name.GetTranslation(Chinese), Is.EqualTo("汉斯的龙王套装"));
        }

        var updates = await context.GetAsync<ConfigurationUpdate>().ConfigureAwait(false);
        Assert.That(updates.Any(update => update.Key == CreateUpdate(version).Key && update.InstalledAt is not null), Is.True);
    }

    /// <summary>Updates preserve custom translations, other languages and gameplay values.</summary>
    /// <param name="version">The configuration version.</param>
    [TestCase("075")]
    [TestCase("095d")]
    [TestCase("Season6")]
    public async Task UpgradePreservesCustomDataAsync(string version)
    {
        var provider = new InMemoryPersistenceContextProvider();
        using var context = provider.CreateNewContext();
        var configuration = context.CreateNew<GameConfiguration>();
        var update = CreateUpdate(version);
        context.CreateNew<ConfigurationUpdateState>().InitializationKey = update.DataInitializationKey;
        var option = context.CreateNew<ItemOptionDefinition>();
        option.Name = new LocalizedString("Excellent Defense Options||de=Verteidigung");
        option.AddChance = 0.125f;
        option.MaximumOptionsPerItem = 3;
        configuration.ItemOptions.Add(option);
        var custom = context.CreateNew<ItemOptionDefinition>();
        custom.Name = new LocalizedString("Luck||zh=自定义幸运");
        configuration.ItemOptions.Add(custom);
        var unknown = context.CreateNew<ItemOptionDefinition>();
        unknown.Name = "Unknown custom option";
        configuration.ItemOptions.Add(unknown);
        var type = context.CreateNew<ItemOptionType>();
        type.Name = new LocalizedString("Excellent Option||zh=Excellent Option");
        type.IsVisible = true;
        configuration.ItemOptionTypes.Add(type);
        var id = option.GetId();
        await context.SaveChangesAsync().ConfigureAwait(false);
        var manager = new PlugInManager(null, NullLoggerFactory.Instance, null, null);
        manager.DiscoverAndRegisterPlugInsOf<IConfigurationUpdatePlugIn>();
        var service = new DataUpdateService(provider, manager);
        var available = (await service.DetermineAvailableUpdatesAsync().ConfigureAwait(false)).OfType<AlignChineseItemOptionNamesPlugInBase>().ToList();
        Assert.That(available.Select(item => item.Key), Is.EqualTo(new[] { update.Key }));
        Assert.That(available.Single().IsMandatory, Is.False);
        await service.ApplyUpdatesAsync(available, new Progress<(Guid, bool)>()).ConfigureAwait(false);
        Assert.That(option.Name.ValueInNeutralLanguage, Is.EqualTo("Excellent Defense Options"));
        Assert.That(option.Name.GetTranslation(Chinese), Is.EqualTo("卓越防御属性"));
        Assert.That(option.Name.GetTranslation(CultureInfo.GetCultureInfo("de")), Is.EqualTo("Verteidigung"));
        Assert.That(custom.Name.GetTranslation(Chinese), Is.EqualTo("自定义幸运"));
        Assert.That(unknown.Name.Value, Is.EqualTo("Unknown custom option"));
        Assert.That(type.Name.GetTranslation(Chinese), Is.EqualTo("卓越属性"));
        Assert.That(type.IsVisible, Is.True);
        Assert.That(option.GetId(), Is.EqualTo(id));
        Assert.That(option.AddChance, Is.EqualTo(0.125f));
        Assert.That(option.MaximumOptionsPerItem, Is.EqualTo(3));
        Assert.That((await service.DetermineAvailableUpdatesAsync().ConfigureAwait(false)).OfType<AlignChineseItemOptionNamesPlugInBase>(), Is.Empty);
        var stored = option.Name.Value;
        await update.ApplyUpdateAsync(context, configuration).ConfigureAwait(false);
        Assert.That(option.Name.Value, Is.EqualTo(stored));
    }

    private static AlignChineseItemOptionNamesPlugInBase CreateUpdate(string version) => version switch
    {
        "075" => new AlignChineseItemOptionNamesPlugIn075(),
        "095d" => new AlignChineseItemOptionNamesPlugIn095d(),
        _ => new AlignChineseItemOptionNamesPlugInSeason6(),
    };
}
