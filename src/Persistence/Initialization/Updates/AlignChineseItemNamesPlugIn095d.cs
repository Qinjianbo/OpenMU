// <copyright file="AlignChineseItemNamesPlugIn095d.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Updates;

using System.Runtime.InteropServices;
using MUnique.OpenMU.Persistence.Initialization.Properties;
using MUnique.OpenMU.PlugIns;

/// <summary>
/// Aligns Chinese item names for 095d configurations.
/// </summary>
[PlugIn]
[Display(Name = nameof(PlugInResources.AlignChineseItemNames_Name), Description = nameof(PlugInResources.AlignChineseItemNames_Description), ResourceType = typeof(PlugInResources))]
[Guid("755f80a7-ebee-428c-ac67-975ce3701ce1")]
public class AlignChineseItemNamesPlugIn095d : AlignChineseItemNamesPlugInBase
{
    /// <inheritdoc />
    public override UpdateVersion Version => UpdateVersion.AlignChineseItemNames095d;

    /// <inheritdoc />
    public override string DataInitializationKey => Version095d.DataInitialization.Id;
}
