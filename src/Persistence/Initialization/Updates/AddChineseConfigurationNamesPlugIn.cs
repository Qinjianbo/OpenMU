// <copyright file="AddChineseConfigurationNamesPlugIn.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Updates;

using System.Runtime.InteropServices;
using MUnique.OpenMU.DataModel.Configuration;
using MUnique.OpenMU.Persistence.Initialization.VersionSeasonSix;
using MUnique.OpenMU.PlugIns;

/// <summary>Adds Simplified Chinese names to common game configuration entries.</summary>
[PlugIn]
[Guid("E3B7A4D2-6F91-4C8E-A5B0-2D7F9C1E6843")]
public sealed class AddChineseConfigurationNamesPlugIn : UpdatePlugInBase
{
    public override UpdateVersion Version => UpdateVersion.AddChineseConfigurationNames;
    public override string DataInitializationKey => DataInitialization.Id;
    public override string Name => "Add Simplified Chinese configuration names";
    public override string Description => "Adds Simplified Chinese names to character classes, monsters, merchants, drop groups, events and warp entries.";
    public override DateTime CreatedAt => new(2026, 8, 31, 0, 0, 0, DateTimeKind.Utc);
    public override bool IsMandatory => false;

    protected override ValueTask ApplyAsync(IContext context, GameConfiguration gameConfiguration)
    {
        foreach (var characterClass in gameConfiguration.CharacterClasses) characterClass.Name = ConfigurationNameTranslations.Localize(characterClass.Name.Value);
        foreach (var monster in gameConfiguration.Monsters) monster.Designation = ConfigurationNameTranslations.Localize(monster.Designation.Value);
        foreach (var group in gameConfiguration.DropItemGroups) group.Description = ConfigurationNameTranslations.Localize(group.Description.Value);
        foreach (var miniGame in gameConfiguration.MiniGameDefinitions)
        {
            miniGame.Name = ConfigurationNameTranslations.Localize(miniGame.Name.Value);
            miniGame.Description = ConfigurationNameTranslations.Localize(miniGame.Description.Value);
        }
        foreach (var warp in gameConfiguration.WarpList) warp.Name = ConfigurationNameTranslations.Localize(warp.Name.Value);
        return ValueTask.CompletedTask;
    }
}
