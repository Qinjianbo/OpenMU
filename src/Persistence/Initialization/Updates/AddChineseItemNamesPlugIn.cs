// <copyright file="AddChineseItemNamesPlugIn.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Updates;

using System.Runtime.InteropServices;
using MUnique.OpenMU.DataModel.Configuration;
using MUnique.OpenMU.Persistence.Initialization.VersionSeasonSix;
using MUnique.OpenMU.PlugIns;

/// <summary>
/// Adds Simplified Chinese translations to built-in item names.
/// </summary>
[PlugIn]
[Guid("A8C4E2F1-1C0D-4B1F-9B7E-6D4A2F8C3E11")]
public sealed class AddChineseItemNamesPlugIn : UpdatePlugInBase
{
    /// <inheritdoc />
    public override UpdateVersion Version => UpdateVersion.AddChineseItemNames;

    /// <inheritdoc />
    public override string DataInitializationKey => DataInitialization.Id;

    /// <inheritdoc />
    public override string Name => "Add Simplified Chinese item names";

    /// <inheritdoc />
    public override string Description => "Adds Simplified Chinese translations to built-in item names.";

    /// <inheritdoc />
    public override DateTime CreatedAt => new(2026, 8, 31, 0, 0, 0, DateTimeKind.Utc);

    /// <inheritdoc />
    public override bool IsMandatory => false;

    /// <inheritdoc />
    protected override ValueTask ApplyAsync(IContext context, GameConfiguration gameConfiguration)
    {
        foreach (var item in gameConfiguration.Items)
        {
            if (item.Name.Value is { } name)
            {
                item.Name = ItemNameTranslations.Localize(name);
            }
        }

        return ValueTask.CompletedTask;
    }
}
