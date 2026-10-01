// <copyright file="AlignChineseMerchantNamesPlugIn075.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Updates;

using System.Runtime.InteropServices;
using MUnique.OpenMU.Persistence.Initialization.Properties;
using MUnique.OpenMU.PlugIns;

/// <summary>
/// Aligns Chinese merchant names for 075 configurations.
/// </summary>
[PlugIn]
[Display(Name = nameof(PlugInResources.AlignChineseMerchantNames_Name), Description = nameof(PlugInResources.AlignChineseMerchantNames_Description), ResourceType = typeof(PlugInResources))]
[Guid("b0e4b547-a957-47d5-af29-5c2527e43a0b")]
public class AlignChineseMerchantNamesPlugIn075 : AlignChineseMerchantNamesPlugInBase
{
    /// <inheritdoc />
    public override string DataInitializationKey => Version075.DataInitialization.Id;
}
