// <copyright file="ItemNameResourcesTests.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Tests;

using System.Collections;
using System.Globalization;
using Microsoft.Extensions.Logging.Abstractions;
using MUnique.OpenMU.DataModel.Configuration;
using MUnique.OpenMU.DataModel.Configuration.Items;
using MUnique.OpenMU.Interfaces;
using MUnique.OpenMU.Persistence.Initialization.Properties;
using MUnique.OpenMU.Persistence.Initialization.Updates;
using MUnique.OpenMU.Persistence.InMemory;

/// <summary>Verifies resource coverage and non-destructive updates for item configuration.</summary>
[TestFixture]
[NonParallelizable]
internal class ItemNameResourcesTests
{
    /// <summary>Every resource is initialized directly, and optional updates restore missing translations.</summary>
    [Test]
    public async Task InitializationAndUpdatesUseAllResourcesAsync()
    {
        var categories = new[]
        {
            ItemNames.ResourceManager,
            ItemOptionTypeNames.ResourceManager,
            ItemOptionNames.ResourceManager,
            ItemSetNames.ResourceManager,
            ItemOptionDescriptions.ResourceManager,
        };
        var used = categories.Select(_ => new HashSet<string>(StringComparer.Ordinal)).ToArray();
        foreach (var version in new[] { "075", "095d", "Season6" })
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
            var entities = new[]
            {
                configuration.Items.Select(i => i.Name),
                configuration.ItemOptionTypes.Select(i => i.Name),
                configuration.ItemOptions.Select(i => i.Name),
                configuration.ItemSetGroups.Select(i => i.Name),
                configuration.ItemOptionTypes.Select(i => i.Description),
            };
            for (var category = 0; category < categories.Length; category++)
            {
                var resources = categories[category];
                foreach (DictionaryEntry entry in resources.GetResourceSet(CultureInfo.InvariantCulture, true, false)!)
                {
                    var key = (string)entry.Key;
                    foreach (var actual in entities[category].Where(n => n.ValueInNeutralLanguage == (string)entry.Value!))
                    {
                        used[category].Add(key);
                        Assert.That(actual.Value, Is.EqualTo(resources.GetLocalizedString(key).Value), $"{version}: {resources.BaseName}.{key}");
                    }
                }
            }

            UpdatePlugInBase[] updates = version switch
            {
                "075" => [new AddItemNameTranslationsPlugIn075(), new AddItemOptionTranslationsPlugIn075()],
                "095d" => [new AddItemNameTranslationsPlugIn095D(), new AddItemOptionTranslationsPlugIn095D()],
                _ => [new AddItemNameTranslationsPlugInSeason6(), new AddItemOptionTranslationsPlugInSeason6()],
            };
            var installed = await context.GetAsync<ConfigurationUpdate>().ConfigureAwait(false);
            foreach (var update in updates)
            {
                Assert.That(update.IsMandatory, Is.False);
                Assert.That(installed.Any(entry => entry.Key == update.Key && entry.InstalledAt is not null), Is.True);
            }

            var expected = configuration.Items.Select(i => i.Name.Value)
                .Concat(configuration.ItemOptions.Select(i => i.Name.Value)).ToArray();
            foreach (var item in configuration.Items)
            {
                item.Name = item.Name.ValueInNeutralLanguage;
            }

            foreach (var option in configuration.ItemOptions)
            {
                option.Name = option.Name.ValueInNeutralLanguage;
            }

            for (var iteration = 0; iteration < 2; iteration++)
            {
                foreach (var update in updates)
                {
                    await update.ApplyUpdateAsync(context, configuration).ConfigureAwait(false);
                }
                Assert.That(configuration.Items.Select(i => i.Name.Value)
                    .Concat(configuration.ItemOptions.Select(i => i.Name.Value)), Is.EqualTo(expected));
            }
        }

        for (var category = 0; category < categories.Length; category++)
        {
            var keys = categories[category].GetResourceSet(CultureInfo.InvariantCulture, true, false)!
                .Cast<DictionaryEntry>().Select(e => (string)e.Key).ToArray();
            Assert.That(used[category], Is.EquivalentTo(keys), categories[category].BaseName);
            foreach (var culture in categories[category].AvailableCultures)
            {
                Assert.That(categories[category].GetResourceSet(culture, true, false)!
                    .Cast<DictionaryEntry>().Select(e => (string)e.Key), Is.SubsetOf(keys));
            }
        }
    }

    /// <summary>Translations preserve customized text and require the original item identity.</summary>
    [Test]
    public void UpdatesPreserveCustomNames()
    {
        var provider = new InMemoryPersistenceContextProvider();
        using var context = provider.CreateNewContext();
        var configuration = context.CreateNew<GameConfiguration>();
        var custom = AddItem(0, "Kris||zh-CN=自定义||de=Dolch");
        var parent = AddItem(0, "Kris||zh=旧中文");
        var sibling = AddItem(0, "Kris||zh-TW=自訂");
        var renamed = AddItem(0, "Custom Kris");
        var unknown = AddItem(255, "Kris");
        var option = context.CreateNew<ItemOptionDefinition>();
        option.Name = "Luck||zh-CN=自定义幸运";
        configuration.ItemOptions.Add(option);
        ItemNameTranslations.ApplyOptions(configuration);
        Assert.That(option.Name.Value, Is.EqualTo("Luck||zh-CN=自定义幸运"));
        ItemNameTranslations.ApplyItems(configuration);
        ItemNameTranslations.ApplyItems(configuration);
        Assert.That(custom.Name.Value, Is.EqualTo("Kris||zh-CN=自定义||de=Dolch"));
        Assert.That(parent.Name.Value, Is.EqualTo("Kris||zh=旧中文"));
        Assert.That(sibling.Name.GetTranslation(CultureInfo.GetCultureInfo("zh-TW"), false), Is.EqualTo("自訂"));
        Assert.That(sibling.Name.GetTranslation(CultureInfo.GetCultureInfo("zh-CN"), false), Is.EqualTo(ItemNames.ResourceManager.GetLocalizedString(nameof(ItemNames.Kris)).GetTranslation(CultureInfo.GetCultureInfo("zh-CN"), false)));
        Assert.That(renamed.Name.Value, Is.EqualTo("Custom Kris"));
        Assert.That(unknown.Name.Value, Is.EqualTo("Kris"));

        ItemDefinition AddItem(short number, LocalizedString name)
        {
            var item = context.CreateNew<ItemDefinition>();
            item.Group = 0;
            item.Number = number;
            item.Name = name;
            configuration.Items.Add(item);
            return item;
        }
    }
}
