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
using MUnique.OpenMU.DataModel;
using MUnique.OpenMU.DataModel.Attributes;
using MUnique.OpenMU.DataModel.Configuration;
using MUnique.OpenMU.Interfaces;
using MUnique.OpenMU.Persistence;
using MUnique.OpenMU.Persistence.InMemory;
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
            Assert.That(typeof(AttributeDefinition).GetTypeCaption(), Is.EqualTo("属性"));
            Assert.That(component.Find("label").TextContent, Does.StartWith("名称"));
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

    /// <summary>Nested configuration captions render text for the current UI language without leaking serialized metadata.</summary>
    [Test]
    public void NestedConfigurationTextUsesTheDisplayLanguage()
    {
        var previous = CultureInfo.CurrentUICulture;
        var previousFormattingCulture = CultureInfo.CurrentCulture;
        try
        {
            CultureInfo.CurrentUICulture = CultureInfo.GetCultureInfo("zh-CN");
            CultureInfo.CurrentCulture = CultureInfo.CurrentUICulture;
            var caption = new LocalizedString("English caption").WithTranslation(CultureInfo.CurrentUICulture, "中文名称").WithSourceKey("Test/Caption");
            Assert.That(new DropItemGroup { Description = caption }.ToString(), Is.EqualTo("中文名称"));
            Assert.That(new CharacterClass { Name = caption }.ToString(), Is.EqualTo("中文名称"));
            Assert.That(new MiniGameDefinition { Name = caption }.ToString(), Is.EqualTo("中文名称"));
            var attribute = new AttributeDefinition(Guid.NewGuid(), "Base Strength", string.Empty);
            var provider = new InMemoryPersistenceContextProvider();
            using var dataContext = provider.CreateNewContext();
            var powerUp = new PowerUpDefinition { TargetAttribute = attribute, Boost = dataContext.CreateNew<PowerUpDefinitionValue>() };
            powerUp.Boost.ConstantValue.Value = 5;
            Assert.That(powerUp.ToString(), Is.EqualTo("5 基础力量"));
            var constant = new ConstValueAttribute(5, attribute);
            Assert.That(constant.GetName(), Is.EqualTo("基础力量: 5 (基础值相加)"));
            Assert.That(constant.ToString(), Is.EqualTo("Base Strength: 5 (AddRaw)"));
            Assert.That(attribute.Designation, Is.EqualTo("Base Strength"));
            Assert.That(caption.Value, Does.Contain("@src=Test/Caption"));
        }
        finally
        {
            CultureInfo.CurrentUICulture = previous;
            CultureInfo.CurrentCulture = previousFormattingCulture;
        }
    }

}
