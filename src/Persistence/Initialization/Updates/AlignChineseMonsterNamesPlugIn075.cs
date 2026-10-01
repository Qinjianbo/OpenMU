// <copyright file="AlignChineseMonsterNamesPlugIn075.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Updates;

using System.Runtime.InteropServices;
using MUnique.OpenMU.Persistence.Initialization.Properties;
using MUnique.OpenMU.PlugIns;

/// <summary>
/// Aligns Chinese monster and NPC names for 075 configurations.
/// </summary>
[PlugIn]
[Display(Name = nameof(PlugInResources.AlignChineseMonsterNames_Name), Description = nameof(PlugInResources.AlignChineseMonsterNames_Description), ResourceType = typeof(PlugInResources))]
[Guid("a4d9a5c8-0548-4d88-bc3d-91c4f6807441")]
public class AlignChineseMonsterNamesPlugIn075 : AlignChineseMonsterNamesPlugInBase
{
    /// <inheritdoc />
    public override string DataInitializationKey => Version075.DataInitialization.Id;
}
