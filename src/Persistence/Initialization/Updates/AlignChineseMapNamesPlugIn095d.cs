// <copyright file="AlignChineseMapNamesPlugIn095d.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Updates;

using System.Runtime.InteropServices;
using MUnique.OpenMU.Persistence.Initialization.Properties;
using MUnique.OpenMU.PlugIns;

/// <summary>
/// Aligns Chinese map names for 095d configurations.
/// </summary>
[PlugIn]
[Display(Name = nameof(PlugInResources.AlignChineseMapNames_Name), Description = nameof(PlugInResources.AlignChineseMapNames_Description), ResourceType = typeof(PlugInResources))]
[Guid("7d3f207f-d083-4c62-b030-b31ee1d96d77")]
public class AlignChineseMapNamesPlugIn095d : AlignChineseMapNamesPlugInBase
{
    /// <inheritdoc />
    public override string DataInitializationKey => Version095d.DataInitialization.Id;
}
