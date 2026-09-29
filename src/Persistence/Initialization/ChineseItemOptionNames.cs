// <copyright file="ChineseItemOptionNames.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization;

using System.Globalization;
using MUnique.OpenMU.DataModel.Configuration;
using MUnique.OpenMU.Interfaces;

/// <summary>Adds Chinese names for built-in item options and ancient sets.</summary>
internal static class ChineseItemOptionNames
{
    private static readonly CultureInfo Chinese = CultureInfo.GetCultureInfo("zh-CN");
    private static readonly IReadOnlyDictionary<string, string> TypeNames = new Dictionary<string, string>(StringComparer.Ordinal)
    {
        ["Ancient Bonus Option"] = "套装额外属性",
        ["Ancient Option"] = "套装属性",
        ["Black Fenrir Option"] = "黑色炎狼兽属性",
        ["Blue Fenrir Option"] = "蓝色炎狼兽属性",
        ["Dark Horse Option"] = "黑王马属性",
        ["Excellent Option"] = "卓越属性",
        ["Gold Fenrir Option"] = "金色炎狼兽属性",
        ["Guardian Option"] = "380级装备属性",
        ["Jewel of Harmony Option"] = "再生属性",
        ["Luck (Critical Damage Chance 5%)"] = "幸运（幸运一击概率 5%）",
        ["Option"] = "追加属性",
        ["Socket Bonus Option"] = "镶嵌奖励属性",
        ["Socket Option"] = "镶嵌属性",
        ["Wing Option"] = "翅膀属性",
    };

    private static readonly IReadOnlyDictionary<string, string> OptionNames = new Dictionary<string, string>(StringComparer.Ordinal)
    {
        ["2nd Wing Options"] = "二代翅膀属性",
        ["3rd Wing Options"] = "三代翅膀属性",
        ["Agnis (Ancient Set)"] = "阿莱斯的圣魂套装属性",
        ["Ancient Bonus of Total Agility"] = "套装敏捷总值加成",
        ["Ancient Bonus of Total Energy"] = "套装智力总值加成",
        ["Ancient Bonus of Total Strength"] = "套装力量总值加成",
        ["Ancient Bonus of Total Vitality"] = "套装体力总值加成",
        ["Anonymous (Ancient Set)"] = "哈德的强化皮套装属性",
        ["Anubis (Ancient Set)"] = "帕希的传说套装属性",
        ["Apollo (Ancient Set)"] = "奥维兰的革套装属性",
        ["Argo (Ancient Set)"] = "玫菲尔的精灵套装属性",
        ["Aruan (Ancient Set)"] = "安吉拉的强化女神套装属性",
        ["Barnake (Ancient Set)"] = "奥维兰的强化革套装属性",
        ["Base Damage Bonus (physical and wizardry, min and max) Option"] = "基础伤害追加属性（物理及魔法，最小值和最大值）",
        ["Base Defense Option"] = "基础防御力追加属性",
        ["Berserker (Ancient Set)"] = "赫兰德的强化翡翠套装属性",
        ["Broy (Ancient Set)"] = "阿莱斯的强化圣魂套装属性",
        ["Cape of Emperor Options"] = "帝王披风属性",
        ["Cape of Fighter Options"] = "武者披风属性",
        ["Cape of Lord Options"] = "王者披风属性",
        ["Cape of Overrule Options"] = "斗皇披风属性",
        ["Ceto (Ancient Set)"] = "希尔芙的藤套装属性",
        ["Chrono (Ancient Set)"] = "露茜的红翼套装属性",
        ["Cloud (Ancient Set)"] = "海德拉的强化黄金套装属性",
        ["Complete Set Bonus (Level 10)"] = "全套装备奖励属性（强化 +10）",
        ["Complete Set Bonus (Level 11)"] = "全套装备奖励属性（强化 +11）",
        ["Complete Set Bonus (Level 12)"] = "全套装备奖励属性（强化 +12）",
        ["Complete Set Bonus (Level 13)"] = "全套装备奖励属性（强化 +13）",
        ["Complete Set Bonus (Level 14)"] = "全套装备奖励属性（强化 +14）",
        ["Complete Set Bonus (Level 15)"] = "全套装备奖励属性（强化 +15）",
        ["Complete Set Bonus (any level)"] = "全套装备奖励属性（任意强化等级）",
        ["Curse Base Damage (min and max) Option"] = "基础诅咒攻击力追加属性（最小值和最大值）",
        ["Dark Horse Options"] = "黑王马属性",
        ["Defense Rate (PvM) Option"] = "对怪物防御成功率追加属性",
        ["Dinorant Options"] = "彩云兽属性",
        ["Drake (Ancient Set)"] = "希尔芙的强化藤套装属性",
        ["Elite Skeleton Transformation Ring"] = "骷髅战士变身指环属性",
        ["Elvian (Ancient Set)"] = "罗拉娜的强化风套装属性",
        ["Enis (Ancient Set)"] = "帕希的强化传说套装属性",
        ["Eplete (Ancient Set)"] = "赫兰德的翡翠套装属性",
        ["Evis (Ancient Set)"] = "索尔思的骷髅套装属性",
        ["Excellent Defense Options"] = "卓越防御属性",
        ["Excellent Physical Attack Options"] = "卓越物理攻击属性",
        ["Excellent Wizardry Attack Options"] = "卓越魔法攻击属性",
        ["Fase (Ancient Set)"] = "洛迪丝的强化天蚕套装属性",
        ["Fenrir Options"] = "炎狼兽属性",
        ["Gaia (Ancient Set)"] = "洛迪丝的天蚕套装属性",
        ["Gaion (Ancient Set)"] = "凯文的亚特兰蒂斯套装属性",
        ["Garuda (Ancient Set)"] = "海德拉的黄金套装属性",
        ["Guardian Option (Armor)"] = "380级装备属性（铠）",
        ["Guardian Option (Boots)"] = "380级装备属性（靴）",
        ["Guardian Option (Gloves)"] = "380级装备属性（护手）",
        ["Guardian Option (Helm)"] = "380级装备属性（盔）",
        ["Guardian Option (Pants)"] = "380级装备属性（护腿）",
        ["Guardian Option (Weapon)"] = "380级装备属性（武器）",
        ["Gywen (Ancient Set)"] = "安吉拉的女神套装属性",
        ["Harmony Defense Options"] = "再生防御属性",
        ["Harmony Physical Attack Options"] = "再生物理攻击属性",
        ["Harmony Wizardry Attack Options"] = "再生魔法攻击属性",
        ["Health recover for jewelery"] = "首饰生命恢复属性",
        ["Heras (Ancient Set)"] = "安东尼斯的魔王套装属性",
        ["Hyon (Ancient Set)"] = "汉斯的龙王套装属性",
        ["Hyperion (Ancient Set)"] = "瑞恩的青铜套装属性",
        ["Jewelery option Maximum Ability"] = "首饰最大技能值属性",
        ["Jewelery option Maximum Mana"] = "首饰最大魔法值属性",
        ["Kantata (Ancient Set)"] = "菲斯特的白金套装属性",
        ["Karis (Ancient Set)"] = "玫菲尔的强化精灵套装属性",
        ["Luck"] = "幸运属性",
        ["Minet (Ancient Set)"] = "安东尼斯的强化魔王套装属性",
        ["Mist (Ancient Set)"] = "瑞恩的强化青铜套装属性",
        ["Muren (Ancient Set)"] = "凯文的强化亚特兰蒂斯套装属性",
        ["Odin (Ancient Set)"] = "罗拉娜的风套装属性",
        ["Physical Base Damage (min and max) Option"] = "基础物理攻击力追加属性（最小值和最大值）",
        ["Rave (Ancient Set)"] = "菲斯特的强化白金套装属性",
        ["Semeden (Ancient Set)"] = "露茜的强化红翼套装属性",
        ["Skeleton Transformation Ring"] = "骨架变身指环属性",
        ["Socket Bonus Options (Armors)"] = "镶嵌奖励属性（防具）",
        ["Socket Bonus Options (Physical)"] = "镶嵌奖励属性（物理攻击）",
        ["Socket Bonus Options (Wizardry)"] = "镶嵌奖励属性（魔法攻击）",
        ["Socket Options (Earth)"] = "镶嵌属性（土）",
        ["Socket Options (Fire)"] = "镶嵌属性（火）",
        ["Socket Options (Ice)"] = "镶嵌属性（冰）",
        ["Socket Options (Lightning)"] = "镶嵌属性（雷）",
        ["Socket Options (Water)"] = "镶嵌属性（水）",
        ["Socket Options (Wind)"] = "镶嵌属性（风）",
        ["Sylion (Ancient Set)"] = "索尔思的强化骷髅套装属性",
        ["Vicious (Ancient Set)"] = "汉斯的强化龙王套装属性",
        ["Warrior (Ancient Set)"] = "哈德的皮套装属性",
        ["Wing of Dimension Options"] = "次元之翼属性",
        ["Wing of Eternal Options"] = "时空之翼属性",
        ["Wing of Illusion Options"] = "幻影之翼属性",
        ["Wing of Ruin Options"] = "破灭之翼属性",
        ["Wing of Storm Options"] = "暴风之翼属性",
        ["Wings of Curse Options"] = "灾难之翼属性",
        ["Wings of Darkness Options"] = "暗黑之翼属性",
        ["Wings of Despair Options"] = "绝望之翼属性",
        ["Wings of Dragon Options"] = "飞龙之翼属性",
        ["Wings of Elf Options"] = "精灵翅膀属性",
        ["Wings of Heaven Options"] = "天使翅膀属性",
        ["Wings of Satan Options"] = "恶魔翅膀属性",
        ["Wings of Soul Options"] = "魔魂之翼属性",
        ["Wings of Spirits Options"] = "圣灵之翼属性",
        ["Wizardry Base Damage (min and max) Option"] = "基础魔法攻击力追加属性（最小值和最大值）",
    };

    private static readonly IReadOnlyDictionary<string, string> SetNames = new Dictionary<string, string>(StringComparer.Ordinal)
    {
        ["Agnis"] = "阿莱斯的圣魂套装",
        ["Anonymous"] = "哈德的强化皮套装",
        ["Anubis"] = "帕希的传说套装",
        ["Apollo"] = "奥维兰的革套装",
        ["Argo"] = "玫菲尔的精灵套装",
        ["Aruan"] = "安吉拉的强化女神套装",
        ["Barnake"] = "奥维兰的强化革套装",
        ["Berserker"] = "赫兰德的强化翡翠套装",
        ["Broy"] = "阿莱斯的强化圣魂套装",
        ["Ceto"] = "希尔芙的藤套装",
        ["Chrono"] = "露茜的红翼套装",
        ["Cloud"] = "海德拉的强化黄金套装",
        ["Drake"] = "希尔芙的强化藤套装",
        ["Elvian"] = "罗拉娜的强化风套装",
        ["Enis"] = "帕希的强化传说套装",
        ["Eplete"] = "赫兰德的翡翠套装",
        ["Evis"] = "索尔思的骷髅套装",
        ["Fase"] = "洛迪丝的强化天蚕套装",
        ["Gaia"] = "洛迪丝的天蚕套装",
        ["Gaion"] = "凯文的亚特兰蒂斯套装",
        ["Garuda"] = "海德拉的黄金套装",
        ["Gywen"] = "安吉拉的女神套装",
        ["Heras"] = "安东尼斯的魔王套装",
        ["Hyon"] = "汉斯的龙王套装",
        ["Hyperion"] = "瑞恩的青铜套装",
        ["Kantata"] = "菲斯特的白金套装",
        ["Karis"] = "玫菲尔的强化精灵套装",
        ["Minet"] = "安东尼斯的强化魔王套装",
        ["Mist"] = "瑞恩的强化青铜套装",
        ["Muren"] = "凯文的强化亚特兰蒂斯套装",
        ["Odin"] = "罗拉娜的风套装",
        ["Rave"] = "菲斯特的强化白金套装",
        ["Semeden"] = "露茜的强化红翼套装",
        ["Sylion"] = "索尔思的强化骷髅套装",
        ["Vicious"] = "汉斯的强化龙王套装",
        ["Warrior"] = "哈德的皮套装",
    };

    private static readonly IReadOnlyDictionary<string, string> Descriptions = new Dictionary<string, string>(StringComparer.Ordinal)
    {
        ["This option is added by the chaos machine with a jewel of guardian on level 380 items."] = "用于380级装备的特殊属性，通过玛雅合成使用守护宝石追加。",
    };

    /// <summary>Fills missing translations without replacing custom text or other languages.</summary>
    /// <param name="configuration">The configuration to update.</param>
    public static void Apply(GameConfiguration configuration)
    {
        foreach (var type in configuration.ItemOptionTypes)
        {
            type.Name = Translate(type.Name, TypeNames);
            type.Description = Translate(type.Description, Descriptions);
        }

        foreach (var option in configuration.ItemOptions)
        {
            option.Name = Translate(option.Name, OptionNames);
        }

        foreach (var set in configuration.ItemSetGroups)
        {
            set.Name = Translate(set.Name, SetNames);
        }
    }

    private static LocalizedString Translate(LocalizedString value, IReadOnlyDictionary<string, string> translations)
    {
        if (!translations.TryGetValue(value.ValueInNeutralLanguage, out var translated))
        {
            return value;
        }

        var current = value.GetTranslation(Chinese, fallbackToNeutral: false);
        return string.IsNullOrEmpty(current) || current == value.ValueInNeutralLanguage
            ? value.WithTranslation(Chinese, translated)
            : value;
    }
}
