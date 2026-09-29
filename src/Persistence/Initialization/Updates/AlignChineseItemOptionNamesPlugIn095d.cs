// <copyright file="AlignChineseItemOptionNamesPlugIn095d.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Updates;

using System.Runtime.InteropServices;
using MUnique.OpenMU.Persistence.Initialization.Properties;
using MUnique.OpenMU.PlugIns;

/// <summary>
/// Aligns Chinese item option names for 095d configurations.
/// </summary>
[PlugIn]
[Display(Name = nameof(PlugInResources.AlignChineseItemOptionNames_Name), Description = nameof(PlugInResources.AlignChineseItemOptionNames_Description), ResourceType = typeof(PlugInResources))]
[Guid("11ab227b-177b-4739-b912-891741d5ccea")]
public class AlignChineseItemOptionNamesPlugIn095d : AlignChineseItemOptionNamesPlugInBase
{
    /// <inheritdoc />
    public override UpdateVersion Version => UpdateVersion.AlignChineseItemOptionNames095d;

    /// <inheritdoc />
    public override string DataInitializationKey => Version095d.DataInitialization.Id;
}
