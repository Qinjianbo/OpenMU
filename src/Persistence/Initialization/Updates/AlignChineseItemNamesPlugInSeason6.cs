// <copyright file="AlignChineseItemNamesPlugInSeason6.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Updates;

using System.Runtime.InteropServices;
using MUnique.OpenMU.Persistence.Initialization.Properties;
using MUnique.OpenMU.PlugIns;

/// <summary>
/// Aligns Chinese item names for Season6 configurations.
/// </summary>
[PlugIn]
[Display(Name = nameof(PlugInResources.AlignChineseItemNames_Name), Description = nameof(PlugInResources.AlignChineseItemNames_Description), ResourceType = typeof(PlugInResources))]
[Guid("a7702ccb-0cda-4680-a478-fab11b123081")]
public class AlignChineseItemNamesPlugInSeason6 : AlignChineseItemNamesPlugInBase
{
    /// <inheritdoc />
    public override UpdateVersion Version => UpdateVersion.AlignChineseItemNamesSeason6;

    /// <inheritdoc />
    public override string DataInitializationKey => VersionSeasonSix.DataInitialization.Id;
}
