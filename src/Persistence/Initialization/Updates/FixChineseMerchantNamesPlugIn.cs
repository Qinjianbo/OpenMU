// <copyright file="FixChineseMerchantNamesPlugIn.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Updates;

using System.Runtime.InteropServices;
using MUnique.OpenMU.DataModel.Configuration;
using MUnique.OpenMU.Persistence.Initialization.VersionSeasonSix;
using MUnique.OpenMU.PlugIns;

/// <summary>Fixes and completes Simplified Chinese merchant names.</summary>
[PlugIn]
[Guid("F4C8B6A1-7D32-4E90-AB15-6F2C9D8E3047")]
public sealed class FixChineseMerchantNamesPlugIn : UpdatePlugInBase
{
    public override UpdateVersion Version => UpdateVersion.FixChineseMerchantNames;
    public override string DataInitializationKey => DataInitialization.Id;
    public override string Name => "Fix Simplified Chinese merchant names";
    public override string Description => "Fixes the Chinese names displayed in the merchant list.";
    public override DateTime CreatedAt => new(2026, 8, 31, 0, 0, 0, DateTimeKind.Utc);
    public override bool IsMandatory => false;

    protected override ValueTask ApplyAsync(IContext context, GameConfiguration gameConfiguration)
    {
        foreach (var monster in gameConfiguration.Monsters.Where(m => m.MerchantStore is not null))
        {
            monster.Designation = ConfigurationNameTranslations.LocalizeMerchant(monster.Designation.Value);
        }

        return ValueTask.CompletedTask;
    }
}
