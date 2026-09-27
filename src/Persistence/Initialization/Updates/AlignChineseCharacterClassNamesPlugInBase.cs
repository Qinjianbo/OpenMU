// <copyright file="AlignChineseCharacterClassNamesPlugInBase.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Updates;

using MUnique.OpenMU.DataModel.Configuration;
using MUnique.OpenMU.Persistence.Initialization.CharacterClasses;

/// <summary>
/// Adds official Chinese class names to existing configurations without changing identifiers.
/// </summary>
public abstract class AlignChineseCharacterClassNamesPlugInBase : UpdatePlugInBase
{
    /// <inheritdoc />
    public override string Name => "Align Simplified Chinese character class names";

    /// <inheritdoc />
    public override string Description => "Adds missing official Chinese class names and corrects known mistranslations while preserving customized names and other languages.";

    /// <inheritdoc />
    public override bool IsMandatory => false;

    /// <inheritdoc />
    public override DateTime CreatedAt => new(2026, 9, 27, 0, 0, 0, DateTimeKind.Utc);

    /// <inheritdoc />
    protected override ValueTask ApplyAsync(IContext context, GameConfiguration gameConfiguration)
    {
        ChineseCharacterClassNames.Apply(gameConfiguration);
        return default;
    }
}
