// <copyright file="AddItemOptionTranslationsPlugIn095D.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Updates;

using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using MUnique.OpenMU.Persistence.Initialization.Properties;
using MUnique.OpenMU.PlugIns;

/// <summary>Adds resource translations of item option types, options, sets and descriptions for 095D configurations.</summary>
[PlugIn]
[Display(Name = nameof(PlugInResources.AddItemOptionTranslations_Name), Description = nameof(PlugInResources.AddItemOptionTranslations_Description), ResourceType = typeof(PlugInResources))]
[Guid("cf316bf9-2860-44a2-9038-00cdbf559189")]
public class AddItemOptionTranslationsPlugIn095D : AddItemOptionTranslationsPlugInBase
{
    /// <inheritdoc />
    public override string DataInitializationKey => Version095d.DataInitialization.Id;
}
