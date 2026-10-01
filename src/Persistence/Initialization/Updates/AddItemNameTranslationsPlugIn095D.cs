// <copyright file="AddItemNameTranslationsPlugIn095D.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Updates;

using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using MUnique.OpenMU.Persistence.Initialization.Properties;
using MUnique.OpenMU.PlugIns;

/// <summary>Adds resource translations of item names for 095D configurations.</summary>
[PlugIn]
[Display(Name = nameof(PlugInResources.AddItemNameTranslations_Name), Description = nameof(PlugInResources.AddItemNameTranslations_Description), ResourceType = typeof(PlugInResources))]
[Guid("99b1bc73-a1f5-4f84-83f1-b13664a8b78e")]
public class AddItemNameTranslationsPlugIn095D : AddItemNameTranslationsPlugInBase
{
    /// <inheritdoc />
    public override string DataInitializationKey => Version095d.DataInitialization.Id;
}
