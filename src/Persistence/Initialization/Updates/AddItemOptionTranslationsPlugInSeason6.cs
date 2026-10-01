// <copyright file="AddItemOptionTranslationsPlugInSeason6.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Updates;

using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using MUnique.OpenMU.Persistence.Initialization.Properties;
using MUnique.OpenMU.PlugIns;

/// <summary>Adds resource translations of item option types, options, sets and descriptions for Season6 configurations.</summary>
[PlugIn]
[Display(Name = nameof(PlugInResources.AddItemOptionTranslations_Name), Description = nameof(PlugInResources.AddItemOptionTranslations_Description), ResourceType = typeof(PlugInResources))]
[Guid("66f9b92f-e12b-480c-b284-45a34646e2a4")]
public class AddItemOptionTranslationsPlugInSeason6 : AddItemOptionTranslationsPlugInBase
{
    /// <inheritdoc />
    public override string DataInitializationKey => VersionSeasonSix.DataInitialization.Id;
}
