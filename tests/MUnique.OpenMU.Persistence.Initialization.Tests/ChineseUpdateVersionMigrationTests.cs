// <copyright file="ChineseUpdateVersionMigrationTests.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Tests;

using Microsoft.Extensions.Logging.Abstractions;
using MUnique.OpenMU.DataModel.Configuration;
using MUnique.OpenMU.Persistence.Initialization.Updates;
using MUnique.OpenMU.Persistence.InMemory;
using MUnique.OpenMU.PlugIns;

/// <summary>Protects installed translation records when upstream reuses their legacy numbers.</summary>
[TestFixture]
public class ChineseUpdateVersionMigrationTests
{
    /// <summary>Discovery migrates only known translation records and does not hide upstream updates.</summary>
    [Test]
    public async Task DiscoveryMigratesLegacyRecordsWithoutHidingUpstreamAsync()
    {
        var provider = new InMemoryPersistenceContextProvider();
        using var context = provider.CreateNewContext();
        var state = context.CreateNew<ConfigurationUpdateState>();
        state.InitializationKey = VersionSeasonSix.DataInitialization.Id;
        state.CurrentInstalledVersion = 133;
        var installedAt = new DateTime(2026, 9, 29, 0, 0, 0, DateTimeKind.Utc);
        string[] names =
        [
            new AlignChineseCharacterClassNamesPlugInSeason6().Name,
            new AlignChineseMerchantNamesPlugInSeason6().Name,
            new AlignChineseMonsterNamesPlugInSeason6().Name,
            new AlignChineseMapNamesPlugInSeason6().Name,
            new AlignChineseItemNamesPlugInSeason6().Name,
            new AlignChineseItemOptionNamesPlugInSeason6().Name,
        ];
        var legacy = new List<ConfigurationUpdate>();
        for (var version = 116; version <= 133; version++)
        {
            var record = context.CreateNew<ConfigurationUpdate>();
            record.Version = version;
            record.Name = names[(version - 116) / 3];
            record.InstalledAt = installedAt;
            legacy.Add(record);
        }

        var upstream = context.CreateNew<ConfigurationUpdate>();
        upstream.Version = (int)UpdateVersion.AddItemRuleFlags;
        upstream.Name = new AddItemRuleFlagsPlugIn().Name;
        upstream.InstalledAt = installedAt;
        var unknown = context.CreateNew<ConfigurationUpdate>();
        unknown.Version = 133;
        unknown.Name = "Custom update";
        await context.SaveChangesAsync().ConfigureAwait(false);
        var manager = new PlugInManager(null, NullLoggerFactory.Instance, null, null);
        manager.DiscoverAndRegisterPlugInsOf<IConfigurationUpdatePlugIn>();
        var service = new DataUpdateService(provider, manager);
        var available = await service.DetermineAvailableUpdatesAsync().ConfigureAwait(false);
        Assert.That(available.Select(update => update.Version), Does.Contain(UpdateVersion.AddDarkHorseCanFly));
        Assert.That(available.Select(update => update.Version), Does.Not.Contain(UpdateVersion.AddItemRuleFlags));
        Assert.That(available.Any(update => (int)update.Version >= 100000), Is.False);
        Assert.That(legacy.Select(record => record.Version), Is.EqualTo(Enumerable.Range(100116, 18)));
        Assert.That(legacy.All(record => record.InstalledAt == installedAt), Is.True);
        Assert.That(upstream.Version, Is.EqualTo(116));
        Assert.That(unknown.Version, Is.EqualTo(133));
        Assert.That(state.CurrentInstalledVersion, Is.EqualTo(100133));
        Assert.That(Enum.GetValues<UpdateVersion>(), Is.Unique);
        var repeated = await service.DetermineAvailableUpdatesAsync().ConfigureAwait(false);
        Assert.That(repeated.Select(update => update.Version), Is.EqualTo(available.Select(update => update.Version)));
        Assert.That((await context.GetAsync<ConfigurationUpdate>().ConfigureAwait(false)).Count(), Is.EqualTo(20));
    }
}
