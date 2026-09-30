// <copyright file="ChineseUpdateVersionMigration.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Updates;

using MUnique.OpenMU.DataModel.Configuration;

/// <summary>Moves this fork's translation update records out of the upstream version range.</summary>
/// <remarks>
/// This metadata migration must run before installed updates are matched by number.
/// A normal update plugin would run too late: old translation records would hide
/// unrelated upstream updates which now use the same numbers. Neutral names guard
/// against modifying records belonging to upstream or another customization.
/// </remarks>
internal static class ChineseUpdateVersionMigration
{
    private static readonly string[] LegacyNames =
    [
        "Align Simplified Chinese character class names",
        "Align Simplified Chinese merchant names",
        "Align Simplified Chinese monster and NPC names",
        "Align Simplified Chinese map names",
        "Align Simplified Chinese item names",
        "Align Simplified Chinese item option names",
    ];

    /// <summary>Remaps recognized legacy records, preserving installation timestamps and text.</summary>
    /// <param name="updates">The stored update records.</param>
    /// <returns>Whether any record changed.</returns>
    public static bool Apply(IEnumerable<ConfigurationUpdate> updates)
    {
        var changed = false;
        foreach (var update in updates)
        {
            if (update.Version is >= 116 and <= 133
                && update.Name.ValueInNeutralLanguage == LegacyNames[(update.Version - 116) / 3])
            {
                update.Version += 100000;
                changed = true;
            }
        }

        return changed;
    }
}
