// <copyright file="AlignChineseMerchantNamesPlugInSeason6.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Updates;

using System.Runtime.InteropServices;
using MUnique.OpenMU.Persistence.Initialization.Properties;
using MUnique.OpenMU.PlugIns;

/// <summary>
/// Aligns Chinese merchant names for Season6 configurations.
/// </summary>
[PlugIn]
[Display(Name = nameof(PlugInResources.AlignChineseMerchantNames_Name), Description = nameof(PlugInResources.AlignChineseMerchantNames_Description), ResourceType = typeof(PlugInResources))]
[Guid("60f617f9-b06e-4a8a-978d-368905479d70")]
public class AlignChineseMerchantNamesPlugInSeason6 : AlignChineseMerchantNamesPlugInBase
{
    /// <inheritdoc />
    public override string DataInitializationKey => VersionSeasonSix.DataInitialization.Id;
}
