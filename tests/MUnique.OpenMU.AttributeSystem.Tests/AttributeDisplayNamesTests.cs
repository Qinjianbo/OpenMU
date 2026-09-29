// <copyright file="AttributeDisplayNamesTests.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.AttributeSystem.Tests;

using System.Globalization;

/// <summary>Verifies display localization preserves the values used by configuration upgrades.</summary>
[TestFixture]
[NonParallelizable]
public class AttributeDisplayNamesTests
{
    /// <summary>Switching UI language never modifies persisted attribute data.</summary>
    /// <param name="culture">The requested UI culture.</param>
    /// <param name="expected">The expected display name.</param>
    [TestCase("zh-CN", "基础力量")]
    [TestCase("en", "Base Strength")]
    [TestCase("de", "Base Strength")]
    public void DisplayLeavesStoredValuesUnchanged(string culture, string expected)
    {
        var previous = CultureInfo.CurrentUICulture;
        try
        {
            CultureInfo.CurrentUICulture = CultureInfo.GetCultureInfo(culture);
            var id = Guid.NewGuid();
            var attribute = new AttributeDefinition(id, "Base Strength", "Custom description");
            Assert.That(attribute.GetDisplayName(), Is.EqualTo(expected));
            Assert.That(attribute.ToString(), Is.EqualTo(expected));
            Assert.That(attribute.Designation, Is.EqualTo("Base Strength"));
            Assert.That(attribute.Description, Is.EqualTo("Custom description"));
            Assert.That(attribute.GetDisplayDescription(), Is.EqualTo("Custom description"));
            Assert.That(attribute.Id, Is.EqualTo(id));
        }
        finally
        {
            CultureInfo.CurrentUICulture = previous;
        }
    }

    /// <summary>Descriptions translate only while they still match the built-in definition.</summary>
    [Test]
    public void CustomNamesAndDescriptionsArePreserved()
    {
        var previous = CultureInfo.CurrentUICulture;
        try
        {
            CultureInfo.CurrentUICulture = CultureInfo.GetCultureInfo("zh-CN");
            const string description = "Factor (0~1) which describes how much of required ability of a skill is not consumed.";
            var attribute = new AttributeDefinition(Guid.NewGuid(), "Ability Usage Reduction", description);
            Assert.That(attribute.GetDisplayDescription(), Is.EqualTo("技能所需技能值中不被消耗的比例，取值范围为 0～1。"));
            Assert.That(attribute.Description, Is.EqualTo(description));
            attribute.Description = "Customized formula";
            Assert.That(attribute.GetDisplayDescription(), Is.EqualTo("Customized formula"));
            attribute.Designation = "Ability-Usage-Reduction";
            attribute.Description = description;
            Assert.That(attribute.GetDisplayName(), Is.EqualTo("Ability-Usage-Reduction"));
            Assert.That(attribute.GetDisplayDescription(), Is.EqualTo(description));
            attribute.Designation = null;
            attribute.Description = null;
            Assert.That(attribute.GetDisplayName(), Is.Null);
            Assert.That(attribute.GetDisplayDescription(), Is.Null);
            Assert.That(AggregateType.Multiplicate.GetDisplayName(), Is.EqualTo("相乘"));
        }
        finally
        {
            CultureInfo.CurrentUICulture = previous;
        }
    }
}
