// <copyright file="CleanInvalidChineseTranslationsPlugIn.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Updates;

using System.Runtime.InteropServices;
using MUnique.OpenMU.DataModel.Configuration;
using MUnique.OpenMU.Persistence.Initialization.VersionSeasonSix;
using MUnique.OpenMU.PlugIns;

/// <summary>Rebuilds monster and item translations from their English names.</summary>
[PlugIn]
[Guid("C2F8A6D1-9B43-4E75-A0C6-5D1F7B8E2394")]
public sealed class CleanInvalidChineseTranslationsPlugIn : UpdatePlugInBase
{
    public override UpdateVersion Version => UpdateVersion.CleanInvalidChineseTranslations;
    public override string DataInitializationKey => DataInitialization.Id;
    public override string Name => "Clean invalid Simplified Chinese translations";
    public override string Description => "Rebuilds incomplete monster and item translations from their English names.";
    public override DateTime CreatedAt => new(2026, 8, 31, 0, 0, 0, DateTimeKind.Utc);
    public override bool IsMandatory => false;

    protected override ValueTask ApplyAsync(IContext context, GameConfiguration gameConfiguration)
    {
        foreach (var monster in gameConfiguration.Monsters)
        {
            monster.Designation = CompleteChineseTranslations.Repair(monster.Designation.Value ?? string.Empty, CompleteChineseTranslations.LocalizeMonster);
        }

        foreach (var item in gameConfiguration.Items)
        {
            item.Name = CompleteChineseTranslations.Repair(item.Name.Value ?? string.Empty, CompleteChineseTranslations.LocalizeItem);
        }

        return ValueTask.CompletedTask;
    }
}
