-- Adds missing Chinese translations; preserves custom translations and all gameplay fields.
-- See docs/ChineseAttributeNames.md. Stop the service and take a backup first.
BEGIN;
CREATE TEMP TABLE chinese_option_texts (category text, neutral text, chinese text, PRIMARY KEY(category, neutral)) ON COMMIT DROP;
INSERT INTO chinese_option_texts VALUES
('types', 'Ancient Bonus Option', '套装额外属性'),
('types', 'Ancient Option', '套装属性'),
('types', 'Black Fenrir Option', '黑色炎狼兽属性'),
('types', 'Blue Fenrir Option', '蓝色炎狼兽属性'),
('types', 'Dark Horse Option', '黑王马属性'),
('types', 'Excellent Option', '卓越属性'),
('types', 'Gold Fenrir Option', '金色炎狼兽属性'),
('types', 'Guardian Option', '380级装备属性'),
('types', 'Jewel of Harmony Option', '再生属性'),
('types', 'Luck (Critical Damage Chance 5%)', '幸运（幸运一击概率 5%）'),
('types', 'Option', '追加属性'),
('types', 'Socket Bonus Option', '镶嵌奖励属性'),
('types', 'Socket Option', '镶嵌属性'),
('types', 'Wing Option', '翅膀属性'),
('options', 'Warrior (Ancient Set)', '哈德的皮套装属性'),
('options', 'Anonymous (Ancient Set)', '哈德的强化皮套装属性'),
('options', 'Hyperion (Ancient Set)', '瑞恩的青铜套装属性'),
('options', 'Mist (Ancient Set)', '瑞恩的强化青铜套装属性'),
('options', 'Eplete (Ancient Set)', '赫兰德的翡翠套装属性'),
('options', 'Berserker (Ancient Set)', '赫兰德的强化翡翠套装属性'),
('options', 'Garuda (Ancient Set)', '海德拉的黄金套装属性'),
('options', 'Cloud (Ancient Set)', '海德拉的强化黄金套装属性'),
('options', 'Kantata (Ancient Set)', '菲斯特的白金套装属性'),
('options', 'Rave (Ancient Set)', '菲斯特的强化白金套装属性'),
('options', 'Hyon (Ancient Set)', '汉斯的龙王套装属性'),
('options', 'Vicious (Ancient Set)', '汉斯的强化龙王套装属性'),
('options', 'Apollo (Ancient Set)', '奥维兰的革套装属性'),
('options', 'Barnake (Ancient Set)', '奥维兰的强化革套装属性'),
('options', 'Evis (Ancient Set)', '索尔思的骷髅套装属性'),
('options', 'Sylion (Ancient Set)', '索尔思的强化骷髅套装属性'),
('options', 'Heras (Ancient Set)', '安东尼斯的魔王套装属性'),
('options', 'Minet (Ancient Set)', '安东尼斯的强化魔王套装属性'),
('options', 'Anubis (Ancient Set)', '帕希的传说套装属性'),
('options', 'Enis (Ancient Set)', '帕希的强化传说套装属性'),
('options', 'Ceto (Ancient Set)', '希尔芙的藤套装属性'),
('options', 'Drake (Ancient Set)', '希尔芙的强化藤套装属性'),
('options', 'Gaia (Ancient Set)', '洛迪丝的天蚕套装属性'),
('options', 'Fase (Ancient Set)', '洛迪丝的强化天蚕套装属性'),
('options', 'Odin (Ancient Set)', '罗拉娜的风套装属性'),
('options', 'Elvian (Ancient Set)', '罗拉娜的强化风套装属性'),
('options', 'Argo (Ancient Set)', '玫菲尔的精灵套装属性'),
('options', 'Karis (Ancient Set)', '玫菲尔的强化精灵套装属性'),
('options', 'Gywen (Ancient Set)', '安吉拉的女神套装属性'),
('options', 'Aruan (Ancient Set)', '安吉拉的强化女神套装属性'),
('options', 'Gaion (Ancient Set)', '凯文的亚特兰蒂斯套装属性'),
('options', 'Muren (Ancient Set)', '凯文的强化亚特兰蒂斯套装属性'),
('options', 'Agnis (Ancient Set)', '阿莱斯的圣魂套装属性'),
('options', 'Broy (Ancient Set)', '阿莱斯的强化圣魂套装属性'),
('options', 'Chrono (Ancient Set)', '露茜的红翼套装属性'),
('options', 'Semeden (Ancient Set)', '露茜的强化红翼套装属性'),
('options', '2nd Wing Options', '二代翅膀属性'),
('options', '3rd Wing Options', '三代翅膀属性'),
('options', 'Base Damage Bonus (physical and wizardry, min and max) Option', '基础伤害追加属性（物理及魔法，最小值和最大值）'),
('options', 'Base Defense Option', '基础防御力追加属性'),
('options', 'Curse Base Damage (min and max) Option', '基础诅咒攻击力追加属性（最小值和最大值）'),
('options', 'Dark Horse Options', '黑王马属性'),
('options', 'Defense Rate (PvM) Option', '对怪物防御成功率追加属性'),
('options', 'Dinorant Options', '彩云兽属性'),
('options', 'Elite Skeleton Transformation Ring', '骷髅战士变身指环属性'),
('options', 'Excellent Defense Options', '卓越防御属性'),
('options', 'Excellent Physical Attack Options', '卓越物理攻击属性'),
('options', 'Excellent Wizardry Attack Options', '卓越魔法攻击属性'),
('options', 'Fenrir Options', '炎狼兽属性'),
('options', 'Harmony Defense Options', '再生防御属性'),
('options', 'Harmony Physical Attack Options', '再生物理攻击属性'),
('options', 'Harmony Wizardry Attack Options', '再生魔法攻击属性'),
('options', 'Health recover for jewelery', '首饰生命恢复属性'),
('options', 'Jewelery option Maximum Ability', '首饰最大技能值属性'),
('options', 'Jewelery option Maximum Mana', '首饰最大魔法值属性'),
('options', 'Luck', '幸运属性'),
('options', 'Physical Base Damage (min and max) Option', '基础物理攻击力追加属性（最小值和最大值）'),
('options', 'Skeleton Transformation Ring', '骨架变身指环属性'),
('options', 'Wizardry Base Damage (min and max) Option', '基础魔法攻击力追加属性（最小值和最大值）'),
('options', 'Complete Set Bonus (any level)', '全套装备奖励属性（任意强化等级）'),
('options', 'Ancient Bonus of Total Agility', '套装敏捷总值加成'),
('options', 'Ancient Bonus of Total Energy', '套装智力总值加成'),
('options', 'Ancient Bonus of Total Strength', '套装力量总值加成'),
('options', 'Ancient Bonus of Total Vitality', '套装体力总值加成'),
('options', 'Complete Set Bonus (Level 10)', '全套装备奖励属性（强化 +10）'),
('options', 'Complete Set Bonus (Level 11)', '全套装备奖励属性（强化 +11）'),
('options', 'Complete Set Bonus (Level 12)', '全套装备奖励属性（强化 +12）'),
('options', 'Complete Set Bonus (Level 13)', '全套装备奖励属性（强化 +13）'),
('options', 'Complete Set Bonus (Level 14)', '全套装备奖励属性（强化 +14）'),
('options', 'Complete Set Bonus (Level 15)', '全套装备奖励属性（强化 +15）'),
('options', 'Guardian Option (Armor)', '380级装备属性（铠）'),
('options', 'Guardian Option (Boots)', '380级装备属性（靴）'),
('options', 'Guardian Option (Gloves)', '380级装备属性（护手）'),
('options', 'Guardian Option (Helm)', '380级装备属性（盔）'),
('options', 'Guardian Option (Pants)', '380级装备属性（护腿）'),
('options', 'Guardian Option (Weapon)', '380级装备属性（武器）'),
('options', 'Socket Options (Earth)', '镶嵌属性（土）'),
('options', 'Socket Options (Fire)', '镶嵌属性（火）'),
('options', 'Socket Options (Ice)', '镶嵌属性（冰）'),
('options', 'Socket Options (Lightning)', '镶嵌属性（雷）'),
('options', 'Socket Options (Water)', '镶嵌属性（水）'),
('options', 'Socket Options (Wind)', '镶嵌属性（风）'),
('options', 'Socket Bonus Options (Armors)', '镶嵌奖励属性（防具）'),
('options', 'Socket Bonus Options (Physical)', '镶嵌奖励属性（物理攻击）'),
('options', 'Socket Bonus Options (Wizardry)', '镶嵌奖励属性（魔法攻击）'),
('options', 'Cape of Emperor Options', '帝王披风属性'),
('options', 'Cape of Fighter Options', '武者披风属性'),
('options', 'Cape of Lord Options', '王者披风属性'),
('options', 'Cape of Overrule Options', '斗皇披风属性'),
('options', 'Wing of Dimension Options', '次元之翼属性'),
('options', 'Wing of Eternal Options', '时空之翼属性'),
('options', 'Wing of Illusion Options', '幻影之翼属性'),
('options', 'Wing of Ruin Options', '破灭之翼属性'),
('options', 'Wing of Storm Options', '暴风之翼属性'),
('options', 'Wings of Curse Options', '灾难之翼属性'),
('options', 'Wings of Darkness Options', '暗黑之翼属性'),
('options', 'Wings of Despair Options', '绝望之翼属性'),
('options', 'Wings of Dragon Options', '飞龙之翼属性'),
('options', 'Wings of Elf Options', '精灵翅膀属性'),
('options', 'Wings of Heaven Options', '天使翅膀属性'),
('options', 'Wings of Satan Options', '恶魔翅膀属性'),
('options', 'Wings of Soul Options', '魔魂之翼属性'),
('options', 'Wings of Spirits Options', '圣灵之翼属性'),
('sets', 'Warrior', '哈德的皮套装'),
('sets', 'Anonymous', '哈德的强化皮套装'),
('sets', 'Hyperion', '瑞恩的青铜套装'),
('sets', 'Mist', '瑞恩的强化青铜套装'),
('sets', 'Eplete', '赫兰德的翡翠套装'),
('sets', 'Berserker', '赫兰德的强化翡翠套装'),
('sets', 'Garuda', '海德拉的黄金套装'),
('sets', 'Cloud', '海德拉的强化黄金套装'),
('sets', 'Kantata', '菲斯特的白金套装'),
('sets', 'Rave', '菲斯特的强化白金套装'),
('sets', 'Hyon', '汉斯的龙王套装'),
('sets', 'Vicious', '汉斯的强化龙王套装'),
('sets', 'Apollo', '奥维兰的革套装'),
('sets', 'Barnake', '奥维兰的强化革套装'),
('sets', 'Evis', '索尔思的骷髅套装'),
('sets', 'Sylion', '索尔思的强化骷髅套装'),
('sets', 'Heras', '安东尼斯的魔王套装'),
('sets', 'Minet', '安东尼斯的强化魔王套装'),
('sets', 'Anubis', '帕希的传说套装'),
('sets', 'Enis', '帕希的强化传说套装'),
('sets', 'Ceto', '希尔芙的藤套装'),
('sets', 'Drake', '希尔芙的强化藤套装'),
('sets', 'Gaia', '洛迪丝的天蚕套装'),
('sets', 'Fase', '洛迪丝的强化天蚕套装'),
('sets', 'Odin', '罗拉娜的风套装'),
('sets', 'Elvian', '罗拉娜的强化风套装'),
('sets', 'Argo', '玫菲尔的精灵套装'),
('sets', 'Karis', '玫菲尔的强化精灵套装'),
('sets', 'Gywen', '安吉拉的女神套装'),
('sets', 'Aruan', '安吉拉的强化女神套装'),
('sets', 'Gaion', '凯文的亚特兰蒂斯套装'),
('sets', 'Muren', '凯文的强化亚特兰蒂斯套装'),
('sets', 'Agnis', '阿莱斯的圣魂套装'),
('sets', 'Broy', '阿莱斯的强化圣魂套装'),
('sets', 'Chrono', '露茜的红翼套装'),
('sets', 'Semeden', '露茜的强化红翼套装'),
('descriptions', 'This option is added by the chaos machine with a jewel of guardian on level 380 items.', '用于380级装备的特殊属性，通过玛雅合成使用守护宝石追加。');
UPDATE config."ItemOptionType" m
SET "Name" = CASE
    WHEN m."Name" ~ '\|\|zh='
    THEN regexp_replace(m."Name", '\|\|zh=[^|]*', '||zh=' || n.chinese, 'g')
    ELSE m."Name" || '||zh=' || n.chinese
END
FROM chinese_option_texts n
WHERE n.category = 'types'
  AND split_part(m."Name", '||', 1) = n.neutral
  AND COALESCE(substring(m."Name" FROM '\|\|zh=([^|]*)'), '') IN ('', n.neutral)
  AND substring(m."Name" FROM '\|\|zh=([^|]*)') IS DISTINCT FROM n.chinese;
UPDATE config."ItemOptionType" m
SET "Description" = CASE
    WHEN m."Description" ~ '\|\|zh='
    THEN regexp_replace(m."Description", '\|\|zh=[^|]*', '||zh=' || n.chinese, 'g')
    ELSE m."Description" || '||zh=' || n.chinese
END
FROM chinese_option_texts n
WHERE n.category = 'descriptions'
  AND split_part(m."Description", '||', 1) = n.neutral
  AND COALESCE(substring(m."Description" FROM '\|\|zh=([^|]*)'), '') IN ('', n.neutral)
  AND substring(m."Description" FROM '\|\|zh=([^|]*)') IS DISTINCT FROM n.chinese;
UPDATE config."ItemOptionDefinition" m
SET "Name" = CASE
    WHEN m."Name" ~ '\|\|zh='
    THEN regexp_replace(m."Name", '\|\|zh=[^|]*', '||zh=' || n.chinese, 'g')
    ELSE m."Name" || '||zh=' || n.chinese
END
FROM chinese_option_texts n
WHERE n.category = 'options'
  AND split_part(m."Name", '||', 1) = n.neutral
  AND COALESCE(substring(m."Name" FROM '\|\|zh=([^|]*)'), '') IN ('', n.neutral)
  AND substring(m."Name" FROM '\|\|zh=([^|]*)') IS DISTINCT FROM n.chinese;
UPDATE config."ItemSetGroup" m
SET "Name" = CASE
    WHEN m."Name" ~ '\|\|zh='
    THEN regexp_replace(m."Name", '\|\|zh=[^|]*', '||zh=' || n.chinese, 'g')
    ELSE m."Name" || '||zh=' || n.chinese
END
FROM chinese_option_texts n
WHERE n.category = 'sets'
  AND split_part(m."Name", '||', 1) = n.neutral
  AND COALESCE(substring(m."Name" FROM '\|\|zh=([^|]*)'), '') IN ('', n.neutral)
  AND substring(m."Name" FROM '\|\|zh=([^|]*)') IS DISTINCT FROM n.chinese;
COMMIT;
