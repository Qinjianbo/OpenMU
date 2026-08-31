// <copyright file="AuditChineseConfigurationNamesPlugIn.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Updates;

using System.Runtime.InteropServices;
using MUnique.OpenMU.DataModel.Configuration;
using MUnique.OpenMU.Persistence.Initialization.VersionSeasonSix;
using MUnique.OpenMU.PlugIns;

/// <summary>Audits and repairs incomplete Chinese configuration translations.</summary>
[PlugIn]
[Guid("A1E7C9D4-5B62-4F80-93AC-7D2E6B8F1045")]
public sealed class AuditChineseConfigurationNamesPlugIn : UpdatePlugInBase
{
    public override UpdateVersion Version => UpdateVersion.AuditChineseConfigurationNames;
    public override string DataInitializationKey => DataInitialization.Id;
    public override string Name => "Audit Simplified Chinese configuration names";
    public override string Description => "Repairs incomplete Chinese names for monsters, merchants, items, drops, events and warp entries.";
    public override DateTime CreatedAt => new(2026, 8, 31, 0, 0, 0, DateTimeKind.Utc);
    public override bool IsMandatory => false;

    protected override ValueTask ApplyAsync(IContext context, GameConfiguration gameConfiguration)
    {
        foreach (var monster in gameConfiguration.Monsters) monster.Designation = CompleteChineseTranslations.Repair(monster.Designation.Value ?? string.Empty, CompleteChineseTranslations.LocalizeMonster);
        foreach (var item in gameConfiguration.Items) item.Name = CompleteChineseTranslations.Repair(item.Name.Value ?? string.Empty, CompleteChineseTranslations.LocalizeItem);
        foreach (var group in gameConfiguration.DropItemGroups) group.Description = CompleteChineseTranslations.LocalizeDrop(group.Description.Value ?? string.Empty);
        foreach (var miniGame in gameConfiguration.MiniGameDefinitions)
        {
            miniGame.Name = CompleteChineseTranslations.LocalizeMini(miniGame.Name.Value ?? string.Empty);
            miniGame.Description = CompleteChineseTranslations.LocalizeMini(miniGame.Description.Value ?? string.Empty);
        }
        foreach (var warp in gameConfiguration.WarpList) warp.Name = CompleteChineseTranslations.LocalizeWarp(warp.Name.Value ?? string.Empty);
        return ValueTask.CompletedTask;
    }
}
