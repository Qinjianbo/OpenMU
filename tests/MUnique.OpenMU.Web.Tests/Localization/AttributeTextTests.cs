// <copyright file="AttributeTextTests.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Web.Tests.Localization;

using System.Globalization;
using Bunit;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.Extensions.DependencyInjection;
using MUnique.OpenMU.AttributeSystem;
using MUnique.OpenMU.Persistence;
using MUnique.OpenMU.Web.Shared.Components.Form;
using MUnique.OpenMU.Web.Shared.Services;

/// <summary>Verifies editable raw values remain separate from localized labels.</summary>
[TestFixture]
[NonParallelizable]
public class AttributeTextTests
{
    /// <summary>Lists use Chinese labels, while forms preserve the English update key.</summary>
    [Test]
    public void ChineseHintDoesNotReplaceTheStoredName()
    {
        var previous = CultureInfo.CurrentUICulture;
        try
        {
            CultureInfo.CurrentUICulture = CultureInfo.GetCultureInfo("zh-CN");
            using var context = new BunitContext();
            context.Services.AddSingleton<IChangeNotificationService, ChangeNotificationService>();
            var attribute = new AttributeDefinition(Guid.NewGuid(), "Base Strength", string.Empty);
            var component = context.Render<CascadingValue<EditContext>>(parameters => parameters
                .Add(cascade => cascade.Value, new EditContext(attribute))
                .AddChildContent<TextField>(fields => fields
                .Add(field => field.Value, attribute.Designation!)
                .Add(field => field.ValueExpression, () => attribute.Designation!)
                .Add(field => field.ValueChanged, value => attribute.Designation = value)));
            Assert.That(attribute.GetName(), Is.EqualTo("基础力量"));
            Assert.That(component.Find("input").GetAttribute("value"), Is.EqualTo("Base Strength"));
            Assert.That(component.Find(".form-text").TextContent, Is.EqualTo("基础力量"));
            Assert.That(attribute.Designation, Is.EqualTo("Base Strength"));
            component.Find("input").Change("Custom strength");
            Assert.That(attribute.Designation, Is.EqualTo("Custom strength"));
            Assert.That(attribute.GetName(), Is.EqualTo("Custom strength"));
            Assert.That(component.FindAll(".form-text"), Is.Empty);
        }
        finally
        {
            CultureInfo.CurrentUICulture = previous;
        }
    }
}
