// <copyright file="AlignChineseCharacterClassNamesPlugIn075.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Updates;

using System.Runtime.InteropServices;
using MUnique.OpenMU.Persistence.Initialization.Properties;
using MUnique.OpenMU.PlugIns;

/// <summary>
/// Aligns Chinese character class names for 075 configurations.
/// </summary>
[PlugIn]
[Display(Name = nameof(PlugInResources.AlignChineseCharacterClassNames_Name), Description = nameof(PlugInResources.AlignChineseCharacterClassNames_Description), ResourceType = typeof(PlugInResources))]
[Guid("075b0252-a700-4154-b836-08351c473508")]
public class AlignChineseCharacterClassNamesPlugIn075 : AlignChineseCharacterClassNamesPlugInBase
{
    /// <inheritdoc />
    public override string DataInitializationKey => Version075.DataInitialization.Id;
}
