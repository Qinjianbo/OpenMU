// <copyright file="AddChineseMapNamesPlugIn.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Updates;

using System.Runtime.InteropServices;
using MUnique.OpenMU.DataModel.Configuration;
using MUnique.OpenMU.Persistence.Initialization.VersionSeasonSix;
using MUnique.OpenMU.PlugIns;

/// <summary>
/// Adds Simplified Chinese translations to existing built-in map names.
/// </summary>
[PlugIn]
[Guid("4D6E8B5A-6F1B-4A8E-9D33-2D3C8D2A6F10")]
public sealed class AddChineseMapNamesPlugIn : UpdatePlugInBase
{
    /// <inheritdoc />
    public override UpdateVersion Version => UpdateVersion.AddChineseMapNames;

    /// <inheritdoc />
    public override string DataInitializationKey => DataInitialization.Id;

    /// <inheritdoc />
    public override string Name => "Add Simplified Chinese map names";

    /// <inheritdoc />
    public override string Description => "Adds Simplified Chinese translations to built-in map names.";

    /// <inheritdoc />
    public override DateTime CreatedAt => new(2026, 8, 30, 0, 0, 0, DateTimeKind.Utc);

    /// <inheritdoc />
    public override bool IsMandatory => false;

    /// <inheritdoc />
    protected override ValueTask ApplyAsync(IContext context, GameConfiguration gameConfiguration)
    {
        foreach (var map in gameConfiguration.Maps)
        {
            var name = map.Name.Value;
            if (name?.Contains("||zh-CN=", StringComparison.OrdinalIgnoreCase) is true)
            {
                map.Name = name.Replace("||zh-CN=", "||zh=", StringComparison.OrdinalIgnoreCase);
            }
            else if (name is not null && !name.Contains("||zh=", StringComparison.OrdinalIgnoreCase))
            {
                map.Name = MapNameTranslations.Localize(name);
            }
        }

        return ValueTask.CompletedTask;
    }
}
