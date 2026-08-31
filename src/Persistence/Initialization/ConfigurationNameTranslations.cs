// <copyright file="ConfigurationNameTranslations.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization;

using MUnique.OpenMU.Interfaces;

/// <summary>Provides conservative Simplified Chinese translations for configuration names.</summary>
internal static class ConfigurationNameTranslations
{
    private static readonly IReadOnlyDictionary<string, string> MerchantNames = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
    {
        ["Alex"] = "亚历克斯", ["Angela the Supplier"] = "补给商安琪拉", ["Caren the Barmaid"] = "酒吧老板娘卡伦", ["Christine the General Goods Merchant"] = "杂货商克里斯蒂娜", ["Elf Lala"] = "精灵拉拉", ["Eo the Craftsman"] = "工匠艾欧", ["Hanzo The Blacksmith"] = "铁匠汉斯", ["Izabel The Wizard"] = "巫师伊莎贝尔", ["Zienna The Weapons Merchant"] = "武器商人齐娜", ["Potion Girl Amy"] = "药水少女艾米", ["Pasi The Mage"] = "魔法师帕西", ["Lumen the Barmaid"] = "酒吧老板娘露蒙", ["Moss The Merchant"] = "商人莫斯", ["Leina the General Goods Merchant"] = "杂货商莱娜", ["Weapons Merchant Bolo"] = "武器商人博罗", ["Thompson the Merchant"] = "商人汤普森", ["Wandering Merchant Martin"] = "流浪商人马丁", ["Wandering Merchant Harold"] = "流浪商人哈罗德", ["Pamela the Supplier"] = "补给商帕梅拉", ["Christine the General Goods Merchant"] = "杂货商克里斯蒂娜", ["Jeweler Raul"] = "珠宝商拉乌尔", ["Market Union Member Julia"] = "市场联盟成员朱莉娅", ["Elf Soldier"] = "精灵战士", ["Lahap"] = "拉哈普", ["Rhea"] = "莉亚", ["Marce"] = "玛尔斯",
    };

    private static readonly IReadOnlyDictionary<string, string> Exact = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
    {
        ["Dark Wizard"] = "黑暗巫师", ["Soul Master"] = "灵魂大师", ["Grand Master"] = "至尊大师", ["Dark Knight"] = "黑暗骑士", ["Blade Knight"] = "剑圣", ["Blade Master"] = "剑魂", ["Fairy Elf"] = "圣射手", ["Muse Elf"] = "精灵导师", ["High Elf"] = "高阶精灵", ["Magic Gladiator"] = "魔剑士", ["Duel Master"] = "决战骑士", ["Dark Lord"] = "黑暗领主", ["Lord Emperor"] = "帝王", ["Summoner"] = "召唤术士", ["Bloody Summoner"] = "血召唤", ["Dimension Master"] = "次元大师", ["Rage Fighter"] = "圣导师", ["Fist Master"] = "拳术大师",
        ["Devil Square"] = "恶魔广场", ["Blood Castle"] = "血色城堡", ["Chaos Castle"] = "赤色要塞", ["Illusion Temple"] = "幻影寺院", ["Golden Invasion"] = "黄金入侵", ["Event definition for devil square event, level 1."] = "恶魔广场活动定义，等级 1。", ["Event definition for blood castle event, level 1."] = "血色城堡活动定义，等级 1。", ["Event definition for chaos castle event, level 1."] = "赤色要塞活动定义，等级 1。",
        ["Bull Fighter"] = "牛魔王", ["Hound"] = "地狱犬", ["Budge Dragon"] = "幼龙", ["Spider"] = "蜘蛛", ["Elite Bull Fighter"] = "精英牛魔王", ["Hell Hound"] = "地狱猎犬", ["Lich"] = "巫师王", ["Giant"] = "巨人", ["Poison Bull"] = "毒牛", ["Thunder Lich"] = "雷巫师", ["Ghost"] = "幽灵", ["Hell Spider"] = "地狱蜘蛛", ["Skeleton Warrior"] = "骷髅战士", ["Skeleton Archer"] = "骷髅弓箭手", ["Cyclops"] = "独眼巨人", ["Gorgon"] = "戈耳工", ["Yeti"] = "雪人", ["Elite Yeti"] = "雪人王", ["Assassin"] = "刺客", ["Ice Monster"] = "冰后", ["Worm"] = "蠕虫", ["Ice Queen"] = "冰后", ["Goblin"] = "哥布林", ["Stone Golem"] = "石巨人", ["Cursed Wizard"] = "诅咒巫师", ["Death Gorgon"] = "死亡戈耳工", ["Shadow"] = "暗影", ["Devil"] = "恶魔", ["Balrog"] = "巴洛克", ["Death Knight"] = "死亡骑士", ["Red Dragon"] = "红龙", ["Bahamut"] = "巴哈姆特", ["Valkyrie"] = "瓦尔基里", ["Lizard King"] = "蜥蜴王", ["Hydra"] = "九头蛇", ["Iron Wheel"] = "铁轮", ["Bloody Wolf"] = "血狼", ["Dark Phoenix"] = "黑凤凰", ["Golden Goblin"] = "黄金哥布林", ["Golden Dragon"] = "黄金龙", ["Golden Titan"] = "黄金泰坦", ["White Wizard"] = "白巫师", ["Bali"] = "巴里", ["Soldier"] = "士兵", ["Chaos Castle"] = "赤色要塞", ["Berserker"] = "狂战士", ["Iron Rider"] = "铁骑士", ["Spider Eggs"] = "蜘蛛卵", ["Snowman"] = "雪人", ["Cursed Santa"] = "诅咒圣诞老人", ["Gateway Machine"] = "传送机器", ["Chaos Goblin"] = "哥布林合成大师", ["Pet Trainer"] = "宠物训练师", ["Marlon"] = "马隆", ["Charon"] = "卡隆", ["Lugard"] = "卢加德", ["Gatekeeper"] = "守门人", ["Chaos Card Master"] = "混沌卡片大师", ["Hanzo The Blacksmith"] = "铁匠汉斯", ["Zienna The Weapons Merchant"] = "武器商人齐娜", ["Potion Girl Amy"] = "药水少女艾米", ["Lahap"] = "拉哈普", ["Moss The Merchant"] = "商人莫斯", ["Weapons Merchant Bolo"] = "武器商人博罗",
        ["The common drop item group for random items (30 % drop chance)"] = "普通随机物品掉落组（30% 掉落率）", ["The common money drop item group (50 % drop chance)"] = "普通金币掉落组（50% 掉落率）", ["The jewels drop item group (0.1 % drop chance)"] = "宝石掉落组（0.1% 掉落率）", ["The common drop item group for random excellent items (0.01 % drop chance)"] = "随机卓越物品掉落组（0.01% 掉落率）", ["The drop item group for Rena"] = "雷纳掉落组", ["Jewel of Guardian"] = "守护宝石",
        ["Arena"] = "竞技场", ["Lorencia"] = "洛兰", ["Noria"] = "诺利亚", ["Devias"] = "冰风谷", ["Dungeon"] = "地下城", ["Atlans"] = "亚特兰蒂斯", ["LostTower"] = "失落之塔", ["Tarkan"] = "塔克", ["Icarus"] = "天空之城", ["Aida"] = "艾迪亚", ["KanturuRuins"] = "坎特鲁遗址", ["KanturuRelics"] = "坎特鲁遗迹", ["Elveland"] = "幻术园", ["PeaceSwamp"] = "宁静沼泽", ["Raklion"] = "冰霜之城", ["Vulcanus"] = "坎特鲁废墟", ["Karutan"] = "卡伦特", ["LaCleon"] = "狼魂要塞",
    };

    private static readonly (string From, string To)[] Replacements =
    {
        ("Chief Skeleton Warrior", "骷髅队长"), ("Chief Skeleton Archer", "骷髅弓箭队长"), ("Dark Skull Soldier", "黑暗骷髅士兵"), ("Giant Ogre", "巨型食人魔"), ("Red Skeleton Knight", "红色骷髅骑士"), ("Magic Skeleton", "魔法骷髅"), ("Death Angel", "死亡天使"), ("Death Centurion", "死亡百夫长"), ("Blood Soldier", "血腥士兵"), ("Rogue Centurion", "流浪百夫长"), ("Illusion of Kundun", "昆顿幻影"), ("Chaos Castle", "赤色要塞"), ("Gate to Kalima", "卡利玛之门"), ("Castle Gate", "城堡大门"), ("Guardian Statue", "守护雕像"), ("Statue of Saint", "圣者雕像"), ("Golden ", "黄金"), ("Elite ", "精英"), ("Dark ", "黑暗"), ("Bloody ", "血腥"), ("Poison ", "剧毒"), ("Fire ", "火焰"), ("Ice ", "冰霜"), ("Shadow ", "暗影"), ("Soldier", "士兵"), ("Warrior", "战士"), ("Archer", "弓箭手"), ("Knight", "骑士"), ("Wizard", "巫师"), ("Merchant", "商人"), ("Guard", "守卫"), ("Gate", "大门"), ("Trap", "陷阱"), ("Statue", "雕像"), ("Tower", "塔"), ("Wolf", "狼"), ("Tree", "树"), ("Rabbit", "兔子"), ("Golem", "石魔"), ("Queen", "女王"), ("Spirit", "精灵"), ("The ", ""),
    };

    public static string Localize(string? value)
    {
        if (string.IsNullOrWhiteSpace(value) || value.Contains("||zh=", StringComparison.OrdinalIgnoreCase)) return value ?? string.Empty;
        if (Exact.TryGetValue(value, out var exact)) return $"{value}{LocalizedString.Separator}zh={exact}";
        var number = string.Empty;
        var baseValue = value;
        var match = System.Text.RegularExpressions.Regex.Match(value, @"\s*\((\d+)\)$");
        if (match.Success) { number = $" {match.Groups[1].Value}"; baseValue = value[..match.Index]; }
        foreach (var (from, to) in Replacements) baseValue = baseValue.Replace(from, to, StringComparison.OrdinalIgnoreCase);
        return baseValue == value ? value : $"{value}{LocalizedString.Separator}zh={baseValue}{number}";
    }

    /// <summary>Replaces a merchant designation with a complete, human-reviewed translation.</summary>
    public static string LocalizeMerchant(string? value)
    {
        if (string.IsNullOrWhiteSpace(value)) return value ?? string.Empty;
        var english = value.Split(LocalizedString.Separator, 2, StringSplitOptions.None)[0];
        return MerchantNames.TryGetValue(english, out var chinese)
            ? $"{english}{LocalizedString.Separator}zh={chinese}"
            : value;
    }
}
