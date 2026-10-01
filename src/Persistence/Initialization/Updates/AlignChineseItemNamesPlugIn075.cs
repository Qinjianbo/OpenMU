// <copyright file="AlignChineseItemNamesPlugIn075.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Updates;

using System.Runtime.InteropServices;
using MUnique.OpenMU.Persistence.Initialization.Properties;
using MUnique.OpenMU.PlugIns;

/// <summary>
/// Aligns Chinese item names for 075 configurations.
/// </summary>
[PlugIn]
[Display(Name = nameof(PlugInResources.AlignChineseItemNames_Name), Description = nameof(PlugInResources.AlignChineseItemNames_Description), ResourceType = typeof(PlugInResources))]
[Guid("cb9c67a4-e784-47df-b022-76608c75aa1a")]
public class AlignChineseItemNamesPlugIn075 : AlignChineseItemNamesPlugInBase
{
    /// <inheritdoc />
    public override string DataInitializationKey => Version075.DataInitialization.Id;
}
