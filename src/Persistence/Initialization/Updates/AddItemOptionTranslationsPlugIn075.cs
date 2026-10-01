// <copyright file="AddItemOptionTranslationsPlugIn075.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Updates;

using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using MUnique.OpenMU.Persistence.Initialization.Properties;
using MUnique.OpenMU.PlugIns;

/// <summary>Adds resource translations of item option types, options, sets and descriptions for 075 configurations.</summary>
[PlugIn]
[Display(Name = nameof(PlugInResources.AddItemOptionTranslations_Name), Description = nameof(PlugInResources.AddItemOptionTranslations_Description), ResourceType = typeof(PlugInResources))]
[Guid("030d507a-a9ec-4ba3-907d-744e7c399319")]
public class AddItemOptionTranslationsPlugIn075 : AddItemOptionTranslationsPlugInBase
{
    /// <inheritdoc />
    public override string DataInitializationKey => Version075.DataInitialization.Id;
}
