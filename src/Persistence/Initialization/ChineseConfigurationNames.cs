// <copyright file="ChineseConfigurationNames.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization;

using System.Globalization;
using MUnique.OpenMU.DataModel.Configuration;
using MUnique.OpenMU.Interfaces;

/// <summary>Supplies Chinese names for the built-in jewels and golden invasion monsters.</summary>
public static class ChineseConfigurationNames
{
    private static readonly CultureInfo Chinese = CultureInfo.GetCultureInfo("zh-CN");
    private static readonly IReadOnlyDictionary<string, string> Names = new Dictionary<string, string>(StringComparer.Ordinal)
    {
            ["Jewel of Chaos"] = "玛雅宝石",
            ["Jewel of Bless"] = "祝福宝石",
            ["Jewel of Soul"] = "灵魂宝石",
            ["Jewel of Life"] = "生命宝石",
            ["Jewel of Creation"] = "创造宝石",
            ["Jewel of Guardian"] = "守护宝石",
            ["Gemstone"] = "再生原石",
            ["Jewel of Harmony"] = "再生宝石",
            ["Lower refine stone"] = "低级进化宝石",
            ["Higher refine stone"] = "高级进化宝石",
            ["Packed Jewel of Chaos"] = "玛雅宝石组合",
            ["Packed Jewel of Bless"] = "祝福宝石组合",
            ["Packed Jewel of Soul"] = "灵魂宝石组合",
            ["Packed Jewel of Life"] = "生命宝石组合",
            ["Packed Jewel of Creation"] = "创造宝石组合",
            ["Packed Jewel of Guardian"] = "守护宝石组合",
            ["Packed Gemstone"] = "再生原石组合",
            ["Packed Jewel of Harmony"] = "再生宝石组合",
            ["Packed Lower refine stone"] = "低级进化宝石组合",
            ["Packed Higher refine stone"] = "高级进化宝石组合",
            ["Golden Budge Dragon"] = "黄金幼龙",
            ["Golden Titan"] = "黄金泰坦",
            ["Golden Soldier"] = "黄金士兵",
            ["Golden Goblin"] = "黄金哥布林",
            ["Golden Dragon"] = "黄金火龙王",
            ["Golden Lizard King"] = "黄金巫师王",
            ["Golden Vepar"] = "黄金美人鱼",
            ["Golden Tantallos"] = "黄金破坏骑士",
            ["Golden Wheel"] = "黄金铁轮战士",
            ["Golden Compensation Box"] = "黄金奖励宝箱",
    };

    /// <summary>Completes known names after initialization, preserving custom Chinese translations.</summary>
    /// <param name="configuration">The initialized game configuration.</param>
    public static void Apply(GameConfiguration configuration)
    {
        foreach (var item in configuration.Items)
        {
            item.Name = Complete(item.Name);
        }

        foreach (var monster in configuration.Monsters)
        {
            monster.Designation = Complete(monster.Designation);
        }
    }

    /// <summary>Completes a known missing or mixed-language Chinese name.</summary>
    /// <param name="name">The stored multilingual name.</param>
    /// <returns>The name with its Chinese segment completed when required.</returns>
    public static LocalizedString Complete(LocalizedString name)
    {
        var chinese = name.GetTranslation(Chinese, fallbackToNeutral: false);
        if (Names.TryGetValue(name.ValueInNeutralLanguage, out var translated)
            && (string.IsNullOrEmpty(chinese) || chinese.Any(char.IsAsciiLetter)))
        {
            return name.WithTranslation(Chinese, translated);
        }

        return name;
    }
}
