// <copyright file="AlignChineseCharacterClassNamesPlugInSeason6.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Updates;

using System.Runtime.InteropServices;
using MUnique.OpenMU.Persistence.Initialization.Properties;
using MUnique.OpenMU.PlugIns;

/// <summary>
/// Aligns Chinese character class names for Season6 configurations.
/// </summary>
[PlugIn]
[Display(Name = nameof(PlugInResources.AlignChineseCharacterClassNames_Name), Description = nameof(PlugInResources.AlignChineseCharacterClassNames_Description), ResourceType = typeof(PlugInResources))]
[Guid("69358dc9-bac8-4214-9fb8-b28be18f1647")]
public class AlignChineseCharacterClassNamesPlugInSeason6 : AlignChineseCharacterClassNamesPlugInBase
{
    /// <inheritdoc />
    public override UpdateVersion Version => UpdateVersion.AlignChineseCharacterClassNamesSeason6;

    /// <inheritdoc />
    public override string DataInitializationKey => VersionSeasonSix.DataInitialization.Id;
}
