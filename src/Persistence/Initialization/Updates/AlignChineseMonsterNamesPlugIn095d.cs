// <copyright file="AlignChineseMonsterNamesPlugIn095d.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Updates;

using System.Runtime.InteropServices;
using MUnique.OpenMU.Persistence.Initialization.Properties;
using MUnique.OpenMU.PlugIns;

/// <summary>
/// Aligns Chinese monster and NPC names for 095d configurations.
/// </summary>
[PlugIn]
[Display(Name = nameof(PlugInResources.AlignChineseMonsterNames_Name), Description = nameof(PlugInResources.AlignChineseMonsterNames_Description), ResourceType = typeof(PlugInResources))]
[Guid("882c9a85-1541-4337-928f-88f66ad1fef1")]
public class AlignChineseMonsterNamesPlugIn095d : AlignChineseMonsterNamesPlugInBase
{
    /// <inheritdoc />
    public override string DataInitializationKey => Version095d.DataInitialization.Id;
}
