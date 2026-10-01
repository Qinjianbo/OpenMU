// <copyright file="AddItemNameTranslationsPlugIn075.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Updates;

using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using MUnique.OpenMU.Persistence.Initialization.Properties;
using MUnique.OpenMU.PlugIns;

/// <summary>Adds resource translations of item names for 075 configurations.</summary>
[PlugIn]
[Display(Name = nameof(PlugInResources.AddItemNameTranslations_Name), Description = nameof(PlugInResources.AddItemNameTranslations_Description), ResourceType = typeof(PlugInResources))]
[Guid("87f1554f-d154-4e35-a987-438d8c89edb7")]
public class AddItemNameTranslationsPlugIn075 : AddItemNameTranslationsPlugInBase
{
    /// <inheritdoc />
    public override string DataInitializationKey => Version075.DataInitialization.Id;
}
