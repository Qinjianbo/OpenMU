// <copyright file="AlignChineseMonsterNamesPlugInSeason6.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Updates;

using System.Runtime.InteropServices;
using MUnique.OpenMU.Persistence.Initialization.Properties;
using MUnique.OpenMU.PlugIns;

/// <summary>
/// Aligns Chinese monster and NPC names for Season6 configurations.
/// </summary>
[PlugIn]
[Display(Name = nameof(PlugInResources.AlignChineseMonsterNames_Name), Description = nameof(PlugInResources.AlignChineseMonsterNames_Description), ResourceType = typeof(PlugInResources))]
[Guid("1292a716-7145-4c79-914a-c26509d5e57e")]
public class AlignChineseMonsterNamesPlugInSeason6 : AlignChineseMonsterNamesPlugInBase
{
    /// <inheritdoc />
    public override UpdateVersion Version => UpdateVersion.AlignChineseMonsterNamesSeason6;

    /// <inheritdoc />
    public override string DataInitializationKey => VersionSeasonSix.DataInitialization.Id;
}
