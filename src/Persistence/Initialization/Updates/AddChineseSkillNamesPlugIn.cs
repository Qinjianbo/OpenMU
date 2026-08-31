// <copyright file="AddChineseSkillNamesPlugIn.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Updates;

using System.Runtime.InteropServices;
using MUnique.OpenMU.DataModel.Configuration;
using MUnique.OpenMU.Persistence.Initialization.VersionSeasonSix;
using MUnique.OpenMU.PlugIns;

/// <summary>
/// Adds Simplified Chinese translations to built-in skill names.
/// </summary>
[PlugIn]
[Guid("D6A9C5B2-41E8-4F30-9237-7C1B8E5A2D90")]
public sealed class AddChineseSkillNamesPlugIn : UpdatePlugInBase
{
    /// <inheritdoc />
    public override UpdateVersion Version => UpdateVersion.AddChineseSkillNames;

    /// <inheritdoc />
    public override string DataInitializationKey => DataInitialization.Id;

    /// <inheritdoc />
    public override string Name => "Add Simplified Chinese skill names";

    /// <inheritdoc />
    public override string Description => "Adds Simplified Chinese translations to built-in skill names.";

    /// <inheritdoc />
    public override DateTime CreatedAt => new(2026, 8, 31, 0, 0, 0, DateTimeKind.Utc);

    /// <inheritdoc />
    public override bool IsMandatory => false;

    /// <inheritdoc />
    protected override ValueTask ApplyAsync(IContext context, GameConfiguration gameConfiguration)
    {
        foreach (var skill in gameConfiguration.Skills)
        {
            if (skill.Name.Value is { } name)
            {
                skill.Name = SkillNameTranslations.Localize(name);
            }
        }

        return ValueTask.CompletedTask;
    }
}
