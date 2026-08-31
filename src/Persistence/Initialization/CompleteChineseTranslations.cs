// <copyright file="CompleteChineseTranslations.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization;

using MUnique.OpenMU.Interfaces;

/// <summary>Normalizes the Chinese values for configuration entries after earlier partial translations.</summary>
internal static class CompleteChineseTranslations
{
    private static readonly IReadOnlyDictionary<string, string> Exact = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
    {
        ["Shadow Pawn"] = "暗影兵卒", ["Shadow Knight"] = "暗影骑士", ["Shadow Look"] = "暗影侦察者", ["Shadow Master"] = "暗影大师", ["Oracle Layla"] = "神谕者莱拉", ["Silvia"] = "西尔维娅", ["Larva"] = "幼虫", ["Hommerd"] = "霍默德", ["Chain Scorpion"] = "链蝎", ["Beetle Monster"] = "甲虫怪", ["Hunter"] = "猎人", ["Forest Monster"] = "森林怪", ["Agon"] = "阿贡", ["Vepar"] = "维帕", ["Sea Worm"] = "海虫", ["Great Bahamut"] = "巨型巴哈姆特", ["Tantallos"] = "坦塔罗斯", ["Zaikan"] = "扎伊坎", ["Beam Knight"] = "光束骑士", ["Death Beam Knight"] = "死亡光束骑士", ["Orc Archer"] = "兽人弓箭手", ["Elite Orc"] = "精英兽人", ["Cursed King"] = "诅咒之王", ["Metal Balrog"] = "金属巴洛克", ["Alquamos"] = "阿尔夸莫斯", ["Queen Rainer"] = "雷纳女王", ["Mega Crust"] = "巨型甲壳兽", ["Phantom Knight"] = "幻影骑士", ["Drakan"] = "德拉坎", ["Alpha Crust"] = "甲壳兽首领", ["Great Drakan"] = "巨型德拉坎", ["Aegis"] = "守护者阿基斯", ["Necron"] = "死灵", ["Schriker"] = "尖啸者", ["Soccerball"] = "足球", ["Wolf Status"] = "狼图腾", ["Wolf Altar"] = "狼祭坛", ["Shield"] = "盾牌", ["Crown"] = "王冠", ["Crown Switch"] = "王冠开关", ["Castle Gate Switch"] = "城门开关", ["Slingshot Attack"] = "弹弓攻击", ["Slingshot Defense"] = "弹弓防御", ["Senior"] = "城堡长老", ["Guardsman"] = "卫兵", ["Archangel"] = "大天使", ["Messenger of Arch."] = "大天使使者", ["Sevina the Priestess"] = "女祭司塞维娜", ["Arena Guard"] = "竞技场守卫", ["Baz The Vault Keeper"] = "仓库管理员巴兹", ["Guild Master"] = "公会会长", ["Crossbow Guard"] = "弩箭守卫", ["Berdysh Guard"] = "长柄斧守卫", ["Oracle Layla"] = "神谕者莱拉", ["Life Stone"] = "生命之石", ["Guardian"] = "守护者", ["Battle Guard"] = "战斗守卫", ["Canon Tower"] = "弩炮塔", ["Lizard Warrior"] = "蜥蜴战士", ["Fire Golem"] = "火焰石魔", ["Queen Bee"] = "蜂后", ["Poison Golem"] = "剧毒石魔", ["Axe Warrior"] = "斧战士", ["Erohim"] = "艾罗希姆", ["Witch Queen"] = "女巫王", ["Blue Golem"] = "蓝色石魔", ["Death Rider"] = "死亡骑士", ["Forest Orc"] = "森林兽人", ["Death Tree"] = "死亡之树", ["Hell Maine"] = "地狱犬王", ["Hammer Scout"] = "锤兵斥候", ["Lance Scout"] = "长枪斥候", ["Bow Scout"] = "弓兵斥候", ["Werewolf"] = "狼人", ["Balram"] = "巴拉姆", ["Soram"] = "索拉姆", ["Satyros"] = "萨提罗斯", ["Blade Hunter"] = "利刃猎手", ["Kentauros"] = "半人马", ["Gigantis"] = "巨人", ["Genocider"] = "屠杀者", ["Persona"] = "佩尔索纳", ["Twin Tale"] = "双尾兽", ["Dreadfear"] = "恐惧魔王", ["Elphis"] = "艾尔菲丝", ["Osbourne"] = "奥斯本", ["Jerridon"] = "杰里顿", ["Leo The Helper"] = "助手里奥", ["Elite Skill Soldier"] = "精英技能士兵", ["GameMaster"] = "游戏管理员", ["Fireworks Girl"] = "烟花少女", ["Stone Statue"] = "石像", ["MU Allies General"] = "MU盟军将军", ["Illusion Elder"] = "幻影长老", ["Alliance Item Storage"] = "联盟物品仓库", ["Illusion Item Storage"] = "幻影物品仓库", ["Mirage"] = "幻影", ["MU Allies"] = "MU盟军", ["Illusion Sorcerer"] = "幻影术士", ["Priest Devin"] = "牧师德文", ["Polluted Butterfly"] = "污染蝴蝶", ["Hideous Rabbit"] = "丑陋兔子", ["Cursed Lich"] = "诅咒巫师", ["Totem Golem"] = "图腾石魔", ["Grizzly"] = "灰熊", ["Captain Grizzly"] = "灰熊队长", ["Gigantis"] = "巨人", ["Berserk"] = "狂暴者", ["Dark_Elf"] = "暗精灵", ["Thunder Napin"] = "雷纳平", ["Ghost Napin"] = "幽灵纳平", ["Blaze Napin"] = "烈焰纳平", ["Cherry Blossom Spirit"] = "樱花精灵", ["Cherry Blossom Tree"] = "樱花树", ["Seed Master"] = "种子大师", ["Seed Researcher"] = "种子研究员", ["Ice Walker"] = "冰行者", ["Giant Mammoth"] = "巨型猛犸", ["Ice Giant"] = "冰巨人", ["Coolutin"] = "库鲁丁", ["Iron Knight"] = "铁甲骑士", ["Selupan"] = "塞尔潘", ["Snowman"] = "雪人", ["Cursed Santa"] = "诅咒圣诞老人", ["Transformed Snowman"] = "变异雪人", ["Zombie Fighter"] = "僵尸斗士", ["Resurrected Gladiator"] = "复活角斗士", ["Ash Slaughterer"] = "灰烬屠夫", ["Blood Assassin"] = "血刺客", ["Cruel Blood Assassin"] = "残酷血刺客", ["Burning Lava Giant"] = "燃烧熔岩巨人", ["Ruthless Lava Giant"] = "无情熔岩巨人", ["Jeweler Raul"] = "珠宝商拉乌尔", ["Market Union Member Julia"] = "市场联盟成员朱莉娅", ["David"] = "大卫", ["Quarter Master"] = "军需官", ["Combat Instructor"] = "战斗教官", ["Defender"] = "防御者", ["Forsaker"] = "弃誓者", ["Adviser Jerinteu"] = "顾问杰林特", ["Evil Gate"] = "邪恶之门", ["Lion Gate"] = "狮门", ["Star Gate"] = "星门", ["Rush Gate"] = "冲锋门", ["Cursed Statue"] = "诅咒雕像", ["Captured Stone Statue"] = "被俘石像",
    };

    private static string Base(string value) => value.Split(LocalizedString.Separator, 2, StringSplitOptions.None)[0];

    public static string Repair(string value, Func<string, string> localizer)
    {
        var english = Base(value);
        var localized = localizer(english);
        if (localized.Contains(LocalizedString.Separator, StringComparison.Ordinal)) return localized;
        return value.Contains(LocalizedString.Separator, StringComparison.Ordinal) ? english : value;
    }

    public static string LocalizeMonster(string value) => Localize(value, Exact, new[] { ("Wolf Altar", "狼祭坛"), ("Wolf Status", "狼图腾"), ("Shadow ", "暗影"), (" of ", " 的 "), ("Soldier", "士兵"), ("Warrior", "战士"), ("Archer", "弓箭手"), ("Knight", "骑士"), ("Guard", "守卫"), ("Gate", "大门"), ("Statue", "雕像"), ("Trap", "陷阱"), ("Spirit", "精灵"), ("Golem", "石魔"), ("Queen", "女王"), ("Wolf", "狼"), ("Tree", "树"), ("Rabbit", "兔子"), ("Golden ", "黄金"), ("Elite ", "精英"), ("Dark ", "黑暗"), ("Bloody ", "血腥"), ("Poison ", "剧毒") });

    public static string LocalizeItem(string value)
    {
        var replacements = new[] { (" Armor", " 铠甲"), (" Boots", " 靴子"), (" Gloves", " 护手"), (" Helm", " 头盔"), (" Helmet", " 头盔"), (" Pants", " 护腿"), (" Shield", " 盾牌"), (" Sword", " 剑"), (" Staff", " 法杖"), (" Stick", " 法杖"), (" Bow", " 弓"), (" Crossbow", " 弩"), (" Scepter", " 权杖"), (" Spear", " 长矛"), (" Axe", " 斧"), (" Ring", " 戒指"), (" Pendant", " 项链"), (" Parchment", " 卷轴"), (" Feather", " 羽毛"), (" Fragment", " 碎片"), (" Box", " 箱子"), (" Potion", "药水"), (" of ", "之"), ("Dark ", "黑暗"), ("Golden ", "黄金"), ("Black ", "黑色"), ("Blue ", "蓝色"), ("Green ", "绿色"), ("Red ", "红色"), ("Excellent ", "卓越") };
        return Localize(value, new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase), replacements);
    }

    public static string LocalizeDrop(string value) => Localize(value, new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase), new[] { ("Quest Item", "任务物品"), ("Rewarded items", "奖励物品"), ("Rewarded jewels", "奖励宝石"), ("Rewarded ancient items", "奖励远古物品"), ("drop item group", "掉落组"), ("Items from ", "来自"), (" from ", " 来自 "), ("Jewel of Bless", "祝福宝石"), ("Jewel of Guardian", "守护宝石"), ("Dark Horse", "黑王马"), ("Dark Raven", "黑暗之鸦"), ("Spirit", "精灵"), ("Wizard's Ring", "巫师之戒"), ("Ring of Honor", "荣誉之戒"), ("Broken Sword", "断剑"), ("Dark Stone", "黑暗之石"), ("Feather of ", "的羽毛"), ("Horn of ", "的角"), ("Scroll of ", "的卷轴"), ("Blood Bone", "血骨"), ("Devil's Key", "恶魔之钥"), ("Devil's Eye", "恶魔之眼"), ("Old Scroll", "远古卷轴"), ("Scroll of Archangel", "大天使卷轴"), ("Illusion Sorcerer Covenant", "幻影术士契约"), ("Chaos Castle", "赤色要塞") });

    public static string LocalizeMini(string value) => Localize(value, new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase), new[] { ("Devil Square", "恶魔广场"), ("Blood Castle", "血色城堡"), ("Chaos Castle", "赤色要塞"), ("Event definition for ", "活动定义："), (" event, level ", "，等级 ") });

    public static string LocalizeWarp(string value) => Localize(value, new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase), new[] { ("Arena", "竞技场"), ("Lorencia", "洛兰"), ("Noria", "诺利亚"), ("Devias", "冰风谷"), ("Dungeon", "地下城"), ("Atlans", "亚特兰蒂斯"), ("LostTower", "失落之塔"), ("Tarkan", "塔克"), ("Icarus", "天空之城"), ("Aida", "艾迪亚"), ("KanturuRuins", "坎特鲁遗址"), ("KanturuRelics", "坎特鲁遗迹"), ("Elveland", "幻术园"), ("PeaceSwamp", "宁静沼泽"), ("Raklion", "冰霜之城"), ("Vulcanus", "坎特鲁废墟"), ("Karutan", "卡伦特"), ("LaCleon", "狼魂要塞"), ("LorenMarket", "罗伦市场") });

    private static string Localize(string value, IReadOnlyDictionary<string, string> exact, IEnumerable<(string From, string To)> replacements)
    {
        var english = Base(value);
        if (exact.TryGetValue(english, out var translated)) return $"{english}{LocalizedString.Separator}zh={translated}";
        var result = english;
        foreach (var (from, to) in replacements) result = result.Replace(from, to, StringComparison.OrdinalIgnoreCase);
        return result == english ? value : $"{english}{LocalizedString.Separator}zh={result}";
    }
}
