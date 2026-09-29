-- See docs/ChineseMapNames.md for sources and retained provisional names.
-- Stop the application and back up the database before applying.
-- Preserves custom translations, other languages, and all non-name columns.
BEGIN;
CREATE TEMP TABLE chinese_map_names(number integer, neutral text, chinese text, legacy text, PRIMARY KEY(number, neutral)) ON COMMIT DROP;
INSERT INTO chinese_map_names VALUES
(0, 'Lorencia', '勇者大陆', '洛兰'),
(1, 'Dungeon', '地下城', '地下城'),
(2, 'Devias', '冰风谷', '冰风谷'),
(3, 'Noria', '仙踪林', '诺利亚'),
(4, 'Lost Tower', '失落之塔', '失落之塔'),
(5, 'Exile', '流放地', '流放地'),
(6, 'Arena', '竞技场', '竞技场'),
(7, 'Atlans', '亚特兰蒂斯', '亚特兰蒂斯'),
(8, 'Tarkan', '死亡沙漠', '塔克'),
(9, 'Devil Square 1', '恶魔广场 1', '恶魔广场 1'),
(9, 'Devil Square 2', '恶魔广场 2', '恶魔广场 2'),
(9, 'Devil Square 3', '恶魔广场 3', '恶魔广场 3'),
(9, 'Devil Square 4', '恶魔广场 4', '恶魔广场 4'),
(10, 'Icarus', '天空之城', '天空之城'),
(11, 'Blood Castle 1', '血色城堡 1', '血色城堡 1'),
(12, 'Blood Castle 2', '血色城堡 2', '血色城堡 2'),
(13, 'Blood Castle 3', '血色城堡 3', '血色城堡 3'),
(14, 'Blood Castle 4', '血色城堡 4', '血色城堡 4'),
(15, 'Blood Castle 5', '血色城堡 5', '血色城堡 5'),
(16, 'Blood Castle 6', '血色城堡 6', '血色城堡 6'),
(17, 'Blood Castle 7', '血色城堡 7', '血色城堡 7'),
(18, 'Chaos Castle 1', '赤色要塞 1', '赤色要塞 1'),
(19, 'Chaos Castle 2', '赤色要塞 2', '赤色要塞 2'),
(20, 'Chaos Castle 3', '赤色要塞 3', '赤色要塞 3'),
(21, 'Chaos Castle 4', '赤色要塞 4', '赤色要塞 4'),
(22, 'Chaos Castle 5', '赤色要塞 5', '赤色要塞 5'),
(23, 'Chaos Castle 6', '赤色要塞 6', '赤色要塞 6'),
(24, 'Kalima 1', '卡利玛神庙 1', '卡利玛 1'),
(25, 'Kalima 2', '卡利玛神庙 2', '卡利玛 2'),
(26, 'Kalima 3', '卡利玛神庙 3', '卡利玛 3'),
(27, 'Kalima 4', '卡利玛神庙 4', '卡利玛 4'),
(28, 'Kalima 5', '卡利玛神庙 5', '卡利玛 5'),
(29, 'Kalima 6', '卡利玛神庙 6', '卡利玛 6'),
(30, 'Valley of Loren', '罗兰峡谷', '罗兰峡谷'),
(31, 'Land_of_Trials', '魔炼之地', '试炼之地'),
(32, 'Devil Square 5', '恶魔广场 5', '恶魔广场 5'),
(32, 'Devil Square 6', '恶魔广场 6', '恶魔广场 6'),
(32, 'Devil Square 7', '恶魔广场 7', '恶魔广场 7'),
(33, 'Aida', '幽暗森林', '艾迪亚'),
(34, 'Crywolf Fortress', '狼魂要塞', '狼魂要塞'),
(36, 'Kalima 7', '卡利玛神庙 7', '卡利玛 7'),
(37, 'Kanturu_I', '坎特鲁废墟', '坎特鲁遗址'),
(38, 'Kanturu_III', '坎特鲁遗址', '坎特鲁遗迹'),
(39, 'Kanturu Event', '提炼之塔', '坎特鲁核心'),
(40, 'Silent Map?', '未知地图', '未知地图'),
(41, 'Barracks of Balgass', '巴卡斯兵营', '巴尔加斯兵营'),
(42, 'Balgass Refuge', '巴卡斯休息室', '巴尔加斯休息处'),
(45, 'Illusion Temple 1', '幻影寺院 1', '幻影寺院 1'),
(46, 'Illusion Temple 2', '幻影寺院 2', '幻影寺院 2'),
(47, 'Illusion Temple 3', '幻影寺院 3', '幻影寺院 3'),
(48, 'Illusion Temple 4', '幻影寺院 4', '幻影寺院 4'),
(49, 'Illusion Temple 5', '幻影寺院 5', '幻影寺院 5'),
(50, 'Illusion Temple 6', '幻影寺院 6', '幻影寺院 6'),
(51, 'Elvenland', '幻术园', '幻术园'),
(52, 'Blood Castle 8', '血色城堡 8', '血色城堡 8'),
(53, 'Chaos Castle 7', '赤色要塞 7', '赤色要塞 7'),
(56, 'Swamp Of Calmness', '安宁池', '宁静沼泽'),
(57, 'LaCleon', '冰霜之城', '狼魂要塞'),
(58, 'LaCleon Boss', '孵化魔地', '狼魂要塞首领房'),
(62, 'Santa Village', '圣诞村', '圣诞村'),
(63, 'Vulcanus', '囚禁之岛', '坎特鲁废墟'),
(64, 'Duel Arena', '角斗场', '决斗场'),
(65, 'Doppelgaenger 1', '生魂广场 1', '幽灵神殿 1'),
(66, 'Doppelgaenger 2', '生魂广场 2', '幽灵神殿 2'),
(67, 'Doppelgaenger 3', '生魂广场 3', '幽灵神殿 3'),
(68, 'Doppelgaenger 4', '生魂广场 4', '幽灵神殿 4'),
(69, 'Fortress of Imperial Guardian 1', '帝国要塞 1', '帝国守护者要塞 1'),
(70, 'Fortress of Imperial Guardian 2', '帝国要塞 2', '帝国守护者要塞 2'),
(71, 'Fortress of Imperial Guardian 3', '帝国要塞 3', '帝国守护者要塞 3'),
(72, 'Fortress of Imperial Guardian 4', '帝国要塞 4', '帝国守护者要塞 4'),
(79, 'LorenMarket', '罗兰市集', '罗伦市场'),
(80, 'Karutan 1', '卡伦特 1', '卡伦特 1'),
(81, 'Karutan 2', '卡伦特 2', '卡伦特 2');
UPDATE config."GameMapDefinition" m
SET "Name" = CASE
    WHEN m."Name" ~ '\|\|zh='
    THEN regexp_replace(m."Name", '\|\|zh=[^|]*', '||zh=' || n.chinese, 'g')
    ELSE m."Name" || '||zh=' || n.chinese
END
FROM chinese_map_names n
WHERE m."Number" = n.number
  AND split_part(m."Name", '||', 1) = n.neutral
  AND COALESCE(substring(m."Name" FROM '\|\|zh=([^|]*)'), '') IN ('', n.legacy, n.neutral)
  AND substring(m."Name" FROM '\|\|zh=([^|]*)') IS DISTINCT FROM n.chinese
RETURNING m."Number", m."Name";
COMMIT;
