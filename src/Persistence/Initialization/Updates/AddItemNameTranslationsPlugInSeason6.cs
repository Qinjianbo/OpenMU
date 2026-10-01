// <copyright file="AddItemNameTranslationsPlugInSeason6.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Updates;

using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using MUnique.OpenMU.Persistence.Initialization.Properties;
using MUnique.OpenMU.PlugIns;

/// <summary>Adds resource translations of item names for Season6 configurations.</summary>
[PlugIn]
[Display(Name = nameof(PlugInResources.AddItemNameTranslations_Name), Description = nameof(PlugInResources.AddItemNameTranslations_Description), ResourceType = typeof(PlugInResources))]
[Guid("8e112413-0385-488a-8bb8-0fb252ebb1bd")]
public class AddItemNameTranslationsPlugInSeason6 : AddItemNameTranslationsPlugInBase
{
    /// <inheritdoc />
    public override string DataInitializationKey => VersionSeasonSix.DataInitialization.Id;
}
