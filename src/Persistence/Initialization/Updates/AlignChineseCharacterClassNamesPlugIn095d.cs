// <copyright file="AlignChineseCharacterClassNamesPlugIn095d.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Updates;

using System.Runtime.InteropServices;
using MUnique.OpenMU.Persistence.Initialization.Properties;
using MUnique.OpenMU.PlugIns;

/// <summary>
/// Aligns Chinese character class names for 095d configurations.
/// </summary>
[PlugIn]
[Display(Name = nameof(PlugInResources.AlignChineseCharacterClassNames_Name), Description = nameof(PlugInResources.AlignChineseCharacterClassNames_Description), ResourceType = typeof(PlugInResources))]
[Guid("85c26705-2f31-4614-8df7-a40ac55bfa54")]
public class AlignChineseCharacterClassNamesPlugIn095d : AlignChineseCharacterClassNamesPlugInBase
{
    /// <inheritdoc />
    public override UpdateVersion Version => UpdateVersion.AlignChineseCharacterClassNames095d;

    /// <inheritdoc />
    public override string DataInitializationKey => Version095d.DataInitialization.Id;
}
