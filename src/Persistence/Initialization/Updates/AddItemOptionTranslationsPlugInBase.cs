// <copyright file="AddItemOptionTranslationsPlugInBase.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Updates;

using System.Globalization;
using MUnique.OpenMU.DataModel.Configuration;
using MUnique.OpenMU.Persistence.Initialization.Properties;

/// <summary>Adds available translations of item option types, options, sets and descriptions without overwriting custom text.</summary>
public abstract class AddItemOptionTranslationsPlugInBase : UpdatePlugInBase
{
    /// <inheritdoc />
    public override string Name => PlugInResources.ResourceManager.GetString(nameof(PlugInResources.AddItemOptionTranslations_Name), CultureInfo.InvariantCulture)!;

    /// <inheritdoc />
    public override string Description => PlugInResources.ResourceManager.GetString(nameof(PlugInResources.AddItemOptionTranslations_Description), CultureInfo.InvariantCulture)!;

    /// <inheritdoc />
    public override bool IsMandatory => false;

    /// <inheritdoc />
    public override DateTime CreatedAt => new(2026, 10, 1, 0, 0, 0, DateTimeKind.Utc);

    /// <inheritdoc />
    protected override ValueTask ApplyAsync(IContext context, GameConfiguration gameConfiguration)
    {
        ItemNameTranslations.ApplyOptions(gameConfiguration);
        return default;
    }
}
