// <copyright file="AlignChineseMapNamesPlugInSeason6.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Updates;

using System.Runtime.InteropServices;
using MUnique.OpenMU.Persistence.Initialization.Properties;
using MUnique.OpenMU.PlugIns;

/// <summary>
/// Aligns Chinese map names for Season6 configurations.
/// </summary>
[PlugIn]
[Display(Name = nameof(PlugInResources.AlignChineseMapNames_Name), Description = nameof(PlugInResources.AlignChineseMapNames_Description), ResourceType = typeof(PlugInResources))]
[Guid("03f2f527-71b6-4638-8cc2-a9a793d510d5")]
public class AlignChineseMapNamesPlugInSeason6 : AlignChineseMapNamesPlugInBase
{
    /// <inheritdoc />
    public override UpdateVersion Version => UpdateVersion.AlignChineseMapNamesSeason6;

    /// <inheritdoc />
    public override string DataInitializationKey => VersionSeasonSix.DataInitialization.Id;
}
