// <copyright file="AlignChineseMonsterNamesPlugInBase.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Updates;

using MUnique.OpenMU.DataModel.Configuration;

/// <summary>
/// Adds Chinese monster and NPC names to existing configurations without changing identifiers.
/// </summary>
public abstract class AlignChineseMonsterNamesPlugInBase : UpdatePlugInBase
{
    /// <inheritdoc />
    public override string Name => "Align Simplified Chinese monster and NPC names";

    /// <inheritdoc />
    public override string Description => "Adds missing Chinese monster and NPC names and corrects known mistranslations while preserving customized names and other languages.";

    /// <inheritdoc />
    public override bool IsMandatory => false;

    /// <inheritdoc />
    public override DateTime CreatedAt => new(2026, 9, 27, 0, 0, 0, DateTimeKind.Utc);

    /// <inheritdoc />
    protected override ValueTask ApplyAsync(IContext context, GameConfiguration gameConfiguration)
    {
        ChineseMonsterNames.Apply(gameConfiguration);
        return default;
    }
}
