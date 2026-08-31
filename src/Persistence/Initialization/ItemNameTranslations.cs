// <copyright file="ItemNameTranslations.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization;

using MUnique.OpenMU.Interfaces;

/// <summary>
/// Provides commonly used Simplified Chinese names for built-in items.
/// </summary>
internal static class ItemNameTranslations
{
    private static readonly IReadOnlyDictionary<string, string> Exact = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
    {
        ["Jewel of Bless"] = "祝福宝石", ["Jewel of Soul"] = "灵魂宝石", ["Jewel of Chaos"] = "混沌宝石", ["Jewel of Life"] = "生命宝石", ["Jewel of Creation"] = "创造宝石", ["Jewel of Guardian"] = "守护宝石", ["Jewel of Harmony"] = "和谐宝石", ["Gemstone"] = "宝石",
        ["Lower refine stone"] = "低级精炼石", ["Higher refine stone"] = "高级精炼石", ["Packed Gemstone"] = "压缩宝石", ["Rena"] = "雷纳", ["Box of Luck"] = "幸运之箱", ["Lost Map"] = "失落的地图", ["Town Portal Scroll"] = "回城卷轴", ["Devil's Invitation"] = "恶魔邀请函", ["Devil's Key"] = "恶魔之钥", ["Devil's Eye"] = "恶魔之眼", ["Arrows"] = "箭矢", ["Bolt"] = "弩箭",
        ["Ale"] = "麦酒", ["Apple"] = "苹果", ["Antidote"] = "解毒剂", ["Small Healing Potion"] = "小型生命药水", ["Medium Healing Potion"] = "中型生命药水", ["Large Healing Potion"] = "大型生命药水", ["Small Mana Potion"] = "小型魔法药水", ["Medium Mana Potion"] = "中型魔法药水", ["Large Mana Potion"] = "大型魔法药水", ["Small Shield Potion"] = "小型护盾药水", ["Medium Shield Potion"] = "中型护盾药水", ["Large Shield Potion"] = "大型护盾药水", ["Small Complex Potion"] = "小型综合药水", ["Medium Complex Potion"] = "中型综合药水", ["Large Complex Potion"] = "大型综合药水",
        ["Small Shield"] = "小盾牌", ["Horn Shield"] = "角盾", ["Kite Shield"] = "风筝盾", ["Elven Shield"] = "精灵盾", ["Dragon Slayer Shield"] = "屠龙盾", ["Skull Shield"] = "骷髅盾", ["Spiked Shield"] = "尖刺盾", ["Tower Shield"] = "塔盾", ["Plate Shield"] = "板甲盾", ["Serpent Shield"] = "蛇盾", ["Bronze Shield"] = "青铜盾", ["Dragon Shield"] = "龙盾", ["Legendary Shield"] = "传说盾", ["Grand Soul Shield"] = "灵魂大师盾", ["Elemental Shield"] = "元素盾", ["Crimson Glory"] = "赤焰之盾", ["Salamander Shield"] = "火蜥蜴盾", ["Frost Barrier"] = "冰霜壁垒", ["Guardian Shield"] = "守护盾", ["Cross Shield"] = "十字盾",
        ["Wing of Dimension"] = "次元之翼", ["Wing of Eternal"] = "永恒之翼", ["Wing of Illusion"] = "幻影之翼", ["Wing of Ruin"] = "毁灭之翼", ["Wing of Storm"] = "风暴之翼", ["Wings of Elf"] = "精灵之翼", ["Wings of Heaven"] = "天堂之翼", ["Wings of Satan"] = "撒旦之翼", ["Wings of Soul"] = "灵魂之翼", ["Wings of Darkness"] = "黑暗之翼", ["Wings of Dragon"] = "龙之翼", ["Wings of Spirits"] = "精灵之翼", ["Wings of Despair"] = "绝望之翼", ["Wings of Curse"] = "诅咒之翼",
        ["Dark Horse"] = "黑暗之马", ["Dark Raven"] = "黑暗之鸦", ["Horn of Dinorant"] = "飞龙之角", ["Horn of Fenrir"] = "芬里尔之角", ["Horn of Uniria"] = "独角兽之角", ["Pet Panda"] = "熊猫宠物", ["Pet Rudolf"] = "鲁道夫宠物", ["Pet Skeleton"] = "骷髅宠物", ["Pet Unicorn"] = "独角兽宠物", ["Guardian Angel"] = "守护天使", ["Imp"] = "小恶魔",
        ["Moonstone Pendant"] = "月光石项链", ["Pendant of Ability"] = "能力项链", ["Ring of Earth"] = "大地之戒", ["Ring of Fire"] = "火之戒", ["Ring of Ice"] = "冰之戒", ["Ring of Magic"] = "魔法之戒", ["Ring of Poison"] = "毒之戒", ["Ring of Wind"] = "风之戒", ["Wizard's Ring"] = "巫师之戒",
    };

    private static readonly IReadOnlyDictionary<string, string> SetPrefixes = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
    {
        ["Bronze"] = "青铜", ["Dragon"] = "龙王", ["Pad"] = "皮", ["Leather"] = "皮革", ["Scale"] = "鳞片", ["Sphinx"] = "斯芬克斯", ["Brass"] = "黄铜", ["Plate"] = "白金", ["Vine"] = "藤", ["Silk"] = "丝绸", ["Wind"] = "风", ["Spirit"] = "精灵", ["Guardian"] = "守护", ["Black Dragon"] = "黑龙", ["Dark Phoenix"] = "黑凤凰", ["Grand Soul"] = "灵魂大师", ["Divine"] = "圣灵", ["Great Dragon"] = "巨龙", ["Dark Soul"] = "黑暗之魂", ["Red Spirit"] = "红色精灵", ["Light Plate"] = "轻型白金", ["Adamantine"] = "白金", ["Dark Steel"] = "黑钢", ["Dark Master"] = "黑暗领主", ["Dragon Knight"] = "龙骑士", ["Venom Mist"] = "毒雾", ["Sylphid Ray"] = "风精灵", ["Sunlight"] = "阳光", ["Ashcrow"] = "灰烬乌鸦", ["Eclipse"] = "日蚀", ["Iris"] = "艾丽丝", ["Glorious"] = "荣耀", ["Red Wing"] = "红翼", ["Aura"] = "光环", ["Hurricane"] = "飓风", ["Faith"] = "信仰", ["Titan"] = "泰坦", ["Phoenix Soul"] = "凤凰之魂", ["Storm Crow"] = "风暴乌鸦", ["Storm Hard"] = "风暴坚甲", ["Valiant"] = "勇者", ["Sacred"] = "神圣", ["Seraphim"] = "炽天使", ["Hades"] = "哈迪斯", ["Phantom"] = "幻影", ["Piercing"] = "穿透", ["Spirit"] = "精灵", ["Ancient"] = "远古", ["Aura"] = "光环",
    };

    private static readonly IReadOnlyDictionary<string, string> Parts = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
    {
        ["Armor"] = "铠甲", ["Boots"] = "靴子", ["Gloves"] = "护手", ["Helm"] = "头盔", ["Helmet"] = "头盔", ["Mask"] = "面具", ["Pants"] = "护腿", ["Stick"] = "法杖",
    };

    /// <summary>Returns the serialized English and Simplified Chinese item name.</summary>
    public static string Localize(string name)
    {
        if (name.Contains("||zh=", StringComparison.OrdinalIgnoreCase))
        {
            return name;
        }

        if (Exact.TryGetValue(name, out var exact))
        {
            return $"{name}{LocalizedString.Separator}zh={exact}";
        }

        foreach (var part in Parts)
        {
            if (!name.EndsWith($" {part.Key}", StringComparison.OrdinalIgnoreCase))
            {
                continue;
            }

            var prefix = name[..^(part.Key.Length + 1)];
            if (SetPrefixes.TryGetValue(prefix, out var translatedPrefix))
            {
                return $"{name}{LocalizedString.Separator}zh={translatedPrefix}{part.Value}";
            }
        }

        return name;
    }
}
