// <copyright file="AlignChineseMapNamesPlugIn075.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Updates;

using System.Runtime.InteropServices;
using MUnique.OpenMU.Persistence.Initialization.Properties;
using MUnique.OpenMU.PlugIns;

/// <summary>
/// Aligns Chinese map names for 075 configurations.
/// </summary>
[PlugIn]
[Display(Name = nameof(PlugInResources.AlignChineseMapNames_Name), Description = nameof(PlugInResources.AlignChineseMapNames_Description), ResourceType = typeof(PlugInResources))]
[Guid("ed946a97-ee07-4132-b22b-43d1a1d978dd")]
public class AlignChineseMapNamesPlugIn075 : AlignChineseMapNamesPlugInBase
{
    /// <inheritdoc />
    public override UpdateVersion Version => UpdateVersion.AlignChineseMapNames075;

    /// <inheritdoc />
    public override string DataInitializationKey => Version075.DataInitialization.Id;
}
