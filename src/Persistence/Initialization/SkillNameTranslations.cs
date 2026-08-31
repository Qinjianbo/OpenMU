// <copyright file="SkillNameTranslations.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization;

using MUnique.OpenMU.Interfaces;

/// <summary>
/// Provides Simplified Chinese names for the built-in skills.
/// </summary>
internal static class SkillNameTranslations
{
    private static readonly IReadOnlyDictionary<string, string> Exact = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
    {
        ["Abolish Magic"] = "解除魔法", ["Aqua Beam"] = "极光术", ["Attack Increase"] = "攻击力提升", ["Attack Succ Rate Inc"] = "攻击成功率提升", ["Automatic AG Rec Inc"] = "AG自动恢复提升", ["Automatic HP Rec Inc"] = "生命自动恢复提升", ["Automatic Mana Rec Inc"] = "魔法自动恢复提升",
        ["Beast Uppercut"] = "斗神冲击", ["Berserker"] = "狂暴", ["Blast"] = "爆裂", ["Blood Attack"] = "嗜血攻击", ["Bow"] = "弓", ["Cancel Invisibility"] = "解除隐身", ["Cancel Stun"] = "解除眩晕", ["Chain Drive"] = "回旋踢", ["Chain Lightning"] = "连锁雷电", ["Chaotic Diseier"] = "混沌灾厄", ["Charge"] = "冲锋", ["Command Attack Inc"] = "统率攻击力提升", ["Cometfall"] = "爆炎术", ["Crescent Moon Slash"] = "月牙斩", ["Crit DMG Inc PowUp"] = "会心伤害提升", ["Critical DMG Inc PowUp"] = "会心伤害提升", ["Crossbow"] = "弩", ["Cyclone"] = "旋风斩",
        ["Damage Reflection"] = "伤害反射", ["Dark Horse"] = "黑王马", ["Dark Side"] = "幽冥光速拳", ["Dark Spirit"] = "黑鹰", ["Death Stab"] = "牙突刺", ["Decay"] = "毒炎术", ["Decrease Mana"] = "魔法消耗降低", ["Defense"] = "防御", ["Defense Increase"] = "防御力提升", ["Defense Success Rate Inc"] = "防御成功率提升", ["DefSuccessRate IncMastery"] = "防御成功率精通", ["Def SuccessRate IncPowUp"] = "防御成功率强化", ["Doppelganger Self Explosion"] = "镜像自爆", ["Dragon Roar"] = "龙啸", ["Dragon Slasher"] = "龙破", ["Drain Life"] = "摄魂咒", ["Durability Reduction"] = "耐久度降低",
        ["Earthshake"] = "地裂", ["Electric Spike"] = "雷电冲击", ["Energy Ball"] = "能量球", ["Equipped Weapon"] = "装备武器", ["Evil Spirit"] = "黑龙波", ["Expansion of Wizardry"] = "魔力扩展", ["Expansion of Wiz"] = "魔力扩展", ["Explosion"] = "爆炸", ["Falling Slash"] = "地裂斩", ["Fire Ball"] = "火球术", ["Fire Blast"] = "火焰爆破", ["Fire Breath"] = "火焰吐息", ["Fire Burst"] = "火舞旋风", ["Fire Scream"] = "火链", ["Fire Slash"] = "火焰斩", ["Fire Tome"] = "火之书", ["Flame"] = "火龙术", ["Flame of Evil (Monster)"] = "邪恶火焰（怪物）", ["Flame Strike"] = "烈焰强击", ["Force"] = "斗气", ["Force Wave"] = "斗气波",
        ["Generic Monster Skill"] = "通用怪物技能", ["Gigantic Storm"] = "巨型风暴", ["Greater Damage"] = "战神之力", ["Greater Defense"] = "守护之光", ["Heal"] = "治疗术", ["Hellfire"] = "地狱火", ["Ice"] = "冰封术", ["Ice Arrow"] = "冰封箭", ["Ice Resistance Increase"] = "冰属性抗性提升", ["Ice Storm"] = "暴风雪", ["Ignore Defense"] = "无视防御", ["Impale"] = "骑乘突刺", ["Increase Attack Success Rate"] = "攻击成功率提升", ["Increase Block"] = "格挡率提升", ["Increase Critical Damage"] = "会心伤害提升", ["Increase Defense Success Rate"] = "防御成功率提升", ["Increase Health"] = "生命值提升", ["Increase HP Recovery Rate"] = "生命恢复率提升", ["Increase Ice Resistance"] = "冰属性抗性提升", ["Increase Lightning Resistance"] = "雷属性抗性提升", ["Increase Mana Recovery Rate"] = "魔法恢复率提升", ["Increase Maximum HP"] = "最大生命值提升", ["Increase Maximum Mana"] = "最大魔法值提升", ["Increase Maximum SD"] = "最大SD提升", ["Increase Minimum Attack Power"] = "最小攻击力提升", ["Increase Poison Resistance"] = "毒属性抗性提升", ["Increase PvP Attack Rate"] = "PvP攻击成功率提升", ["Increase PvP Defense Rate"] = "PvP防御成功率提升", ["Increases AG Recovery Rate"] = "AG恢复率提升", ["Increases Defense"] = "防御力提升", ["Increase SD Recovery Rate"] = "SD恢复率提升", ["Inferno"] = "毁灭烈焰", ["Infinity Arrow"] = "无限箭制", ["Innovation"] = "破御术", ["Invisibility"] = "隐身术",
        ["Killing Blow"] = "致命一击", ["Lance"] = "长枪突刺", ["Lightning"] = "闪电术", ["Lightning Resistance Inc"] = "雷属性抗性提升", ["Lightning Shock"] = "雷电轰顶", ["Lightning Tome"] = "雷之书", ["Lunge"] = "突刺", ["Mace"] = "锤", ["Magic Attack Immunity"] = "魔法攻击免疫", ["Magic"] = "魔法", ["Mana Rays"] = "魔力射线", ["Mana Reduction"] = "魔法消耗降低", ["Maximum Life Increase"] = "最大生命值提升", ["Maximum Mana Increase"] = "最大魔法值提升", ["Maximum SD increase"] = "最大SD提升", ["Meteorite"] = "陨石术", ["Minimum Attack Power Inc"] = "最小攻击力提升", ["Minimum Att Power Inc"] = "最小攻击力提升", ["Minimum Wizardry Inc"] = "最小魔法攻击力提升", ["Minimum Wiz/Curse Inc"] = "最小魔法/诅咒攻击力提升", ["Monster Attack Life Inc"] = "攻击怪物生命恢复", ["Monster Attack Mana Inc"] = "攻击怪物魔法恢复", ["Monster Attack SD Inc"] = "攻击怪物SD恢复", ["Multi-Shot"] = "多重射击",
        ["Nova"] = "星辰一怒", ["Nova (Start)"] = "星辰一怒（蓄力）", ["One-handed Staff"] = "单手杖", ["One-handed Sword"] = "单手剑", ["Other World Tome"] = "异界之书", ["Penetration"] = "穿透箭", ["Pet Durability"] = "宠物耐久", ["Phoenix Shot"] = "凤凰射击", ["Physical Attack Immunity"] = "物理攻击免疫", ["Plasma Storm"] = "等离子风暴", ["Poison"] = "毒咒术", ["Poison Resistance Inc"] = "毒属性抗性提升", ["Pollution"] = "污染", ["Potion of Bless"] = "祝福药水", ["Potion of Soul"] = "灵魂药水", ["Power Slash"] = "玄月斩", ["Power Wave"] = "掌心雷", ["PvP Attack Rate"] = "PvP攻击成功率", ["PvP Defence Rate Inc"] = "PvP防御成功率提升",
        ["Rageful Blow"] = "雷霆裂闪", ["Recover HP from Monster Kills"] = "击杀怪物恢复生命", ["Recover Mana Monster Kills"] = "击杀怪物恢复魔法", ["Recover SD from Monster Kills"] = "击杀怪物恢复SD", ["Recovery"] = "恢复", ["Requiem"] = "安魂曲", ["Scepter"] = "权杖", ["SD Recovery Speed Inc"] = "SD恢复速度提升", ["Shield-Burn"] = "护盾燃烧", ["Shield"] = "盾牌", ["Slash"] = "斩击", ["Sleep"] = "昏睡", ["Soul Barrier"] = "守护之魂", ["Spear"] = "矛", ["Spell of Protection"] = "守护符咒", ["Spell of Pursuit"] = "追击符咒", ["Spell of Restriction"] = "束缚符咒", ["Spiral Slash"] = "螺旋斩", ["Stamina Increase"] = "体力提升", ["Starfall"] = "星落", ["Stick"] = "法杖", ["Strike of Destruction"] = "毁灭一击", ["Strike of Destr"] = "毁灭一击", ["Stun"] = "眩晕",
        ["Summon"] = "召唤术", ["Summon Assassin"] = "召唤刺客", ["Summon Bali"] = "召唤巴里", ["Summon Dark Knight"] = "召唤暗黑骑士", ["Summoned Monster"] = "召唤兽", ["Summon Elite Yeti"] = "召唤雪人王", ["Summon Goblin"] = "召唤哥布林", ["Summon Monster"] = "召唤怪物", ["Summon Soldier"] = "召唤士兵", ["Summon Stone Golem"] = "召唤石巨人", ["Swell Life"] = "生命之光", ["Swell Mana"] = "魔力增幅", ["Teleport"] = "瞬间移动", ["Teleport Ally"] = "盟友瞬移", ["Triple Shot"] = "多重箭", ["Twister"] = "龙卷风", ["Twisting Slash"] = "霹雳回旋斩", ["Two-handed Staff"] = "双手杖", ["Two-handed Sword"] = "双手剑", ["Uppercut"] = "升龙击", ["Use Scepter : Pet"] = "权杖宠物强化", ["Weakness"] = "弱化术", ["Weapon"] = "武器", ["Wind Tome"] = "风之书",
    };

    private static readonly (string Suffix, string Translation)[] Suffixes =
    {
        (" Strengthener", "强化"), (" Strengthen", "强化"), (" Proficiency", "熟练"), (" Proficie", "熟练"),
        (" Mastery", "精通"), (" Strength", "强化"), (" Strengt", "强化"), (" Streng", "强化"), (" Stren", "强化"), (" Mast", "精通"), (" Mas", "精通"), (" Str", "强化"),
    };

    /// <summary>Returns the serialized English and Simplified Chinese skill name.</summary>
    public static string Localize(string name)
    {
        if (name.Contains("||zh=", StringComparison.OrdinalIgnoreCase))
        {
            return name;
        }

        var chineseName = Translate(name);
        return chineseName is null ? name : $"{name}{LocalizedString.Separator}zh={chineseName}";
    }

    private static string? Translate(string name)
    {
        if (Exact.TryGetValue(name, out var exact))
        {
            return exact;
        }

        var numberedSuffix = string.Empty;
        if (name.Length > 3 && name[^3] == '(' && char.IsDigit(name[^2]) && name[^1] == ')')
        {
            numberedSuffix = name[^3..];
            name = name[..^3].TrimEnd();
            if (Exact.TryGetValue(name, out exact))
            {
                return $"{exact}{numberedSuffix}";
            }
        }

        foreach (var (suffix, translation) in Suffixes)
        {
            if (!name.EndsWith(suffix, StringComparison.OrdinalIgnoreCase))
            {
                continue;
            }

            var baseName = name[..^suffix.Length];
            if (Exact.TryGetValue(baseName, out var translatedBase))
            {
                return $"{translatedBase}{translation}{numberedSuffix}";
            }
        }

        return null;
    }
}
