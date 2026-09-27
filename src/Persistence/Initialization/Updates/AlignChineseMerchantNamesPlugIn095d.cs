// <copyright file="AlignChineseMerchantNamesPlugIn095d.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Updates;

using System.Runtime.InteropServices;
using MUnique.OpenMU.Persistence.Initialization.Properties;
using MUnique.OpenMU.PlugIns;

/// <summary>
/// Aligns Chinese merchant names for 095d configurations.
/// </summary>
[PlugIn]
[Display(Name = nameof(PlugInResources.AlignChineseMerchantNames_Name), Description = nameof(PlugInResources.AlignChineseMerchantNames_Description), ResourceType = typeof(PlugInResources))]
[Guid("891a6f79-727d-4b05-ad35-3fafca92d513")]
public class AlignChineseMerchantNamesPlugIn095d : AlignChineseMerchantNamesPlugInBase
{
    /// <inheritdoc />
    public override UpdateVersion Version => UpdateVersion.AlignChineseMerchantNames095d;

    /// <inheritdoc />
    public override string DataInitializationKey => Version095d.DataInitialization.Id;
}
