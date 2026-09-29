// <copyright file="AlignChineseItemOptionNamesPlugInSeason6.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Updates;

using System.Runtime.InteropServices;
using MUnique.OpenMU.Persistence.Initialization.Properties;
using MUnique.OpenMU.PlugIns;

/// <summary>
/// Aligns Chinese item option names for Season6 configurations.
/// </summary>
[PlugIn]
[Display(Name = nameof(PlugInResources.AlignChineseItemOptionNames_Name), Description = nameof(PlugInResources.AlignChineseItemOptionNames_Description), ResourceType = typeof(PlugInResources))]
[Guid("ca7a08d5-10ee-42b0-8be6-8ed474a7967a")]
public class AlignChineseItemOptionNamesPlugInSeason6 : AlignChineseItemOptionNamesPlugInBase
{
    /// <inheritdoc />
    public override UpdateVersion Version => UpdateVersion.AlignChineseItemOptionNamesSeason6;

    /// <inheritdoc />
    public override string DataInitializationKey => VersionSeasonSix.DataInitialization.Id;
}
