// <copyright file="AlignChineseItemOptionNamesPlugIn075.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Updates;

using System.Runtime.InteropServices;
using MUnique.OpenMU.Persistence.Initialization.Properties;
using MUnique.OpenMU.PlugIns;

/// <summary>
/// Aligns Chinese item option names for 075 configurations.
/// </summary>
[PlugIn]
[Display(Name = nameof(PlugInResources.AlignChineseItemOptionNames_Name), Description = nameof(PlugInResources.AlignChineseItemOptionNames_Description), ResourceType = typeof(PlugInResources))]
[Guid("e0a02266-d9dc-4af3-a7b8-f8be36452498")]
public class AlignChineseItemOptionNamesPlugIn075 : AlignChineseItemOptionNamesPlugInBase
{
    /// <inheritdoc />
    public override string DataInitializationKey => Version075.DataInitialization.Id;
}
