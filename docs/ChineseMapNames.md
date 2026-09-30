# 简体中文地图名称核对

核对日期：2026-09-29。当前数据库共 73 条地图配置，修正 31 条中文名称；保留英文原名和所有地图配置。

地图编号可能重复（恶魔广场多个等级共用编号 9 或 32），因此匹配条件为 **地图编号 + 英文原名**，不能只按编号替换。

## 部署与旧数据库

- 新建 075、095d、Season6 配置会自动补齐中文名称。
- 已有数据库：部署新版本后，在配置更新页面执行「对齐简体中文地图名称」，三个版本对应更新编号 100125、100126、100127。该更新不是强制更新，不会在启动时自动覆盖已有名称。
- 也可停止服务并备份数据库后，执行 `scripts/localization/align-map-names.sql`，随后重启服务以重新载入配置。不要重新初始化已有数据库。
- 只填补缺失中文或替换下表的已知旧译；保留自定义中文、英文原名和其他语言。重复执行不会继续改变数据。
- SQL 和更新插件修改 `config."GameMapDefinition"."Name"` 的 `||zh=` 部分，不修改地图编号、传送点、地形、刷怪、掉落或角色位置。

## 名称依据与边界

采用塔人国服官网的地区资料与版本公告。数字后缀用于保留 OpenMU 原有地图实例区分，并非新增官方地名。

- 37 对应 Kanturu_I，采用现行公告中金甲兽、裂角狼、疯魔所在地图名「坎特鲁废墟」；38 对应 Kanturu_III，采用地区资料「坎特鲁遗址」。官方部分早年攻略曾混用两者，不能据此对调。
- 39 包含玛雅战斗及提炼区域，采用相邻入口与官网公告中的「提炼之塔」。
- 69～72 采用官方使用的「帝国要塞」，官网也使用「帝国军要塞」。
- 卡利玛采用正文全称「卡利玛神庙」；官网导航简写为「卡利玛」。
- 5（Exile）、6（Arena）、40（Silent Map?）、62（Santa Village）未查到足够的官方地图名称依据，保留现有中文并明确标注，**不宣称已核实为官方名称**。尤其 40 不推测为其他正式地图。

## 全量对照

| 编号 | 英文原名 | 原中文 | 核对后中文 | 依据 |
|---|---|---|---|---|
| 0 | Lorencia | 洛兰 | 勇者大陆 | [国服官网](https://mu.zhaouc.com/Guide/GameIntro/02_area01.html) |
| 1 | Dungeon | 地下城 | 地下城 | [国服官网](https://mu.zhaouc.com/Guide/GameIntro/02_area05.html) |
| 2 | Devias | 冰风谷 | 冰风谷 | [国服官网](https://mu.zhaouc.com/Guide/GameIntro/02_area04.html) |
| 3 | Noria | 诺利亚 | 仙踪林 | [国服官网](https://mu.zhaouc.com/Guide/GameIntro/02_area02.html) |
| 4 | Lost Tower | 失落之塔 | 失落之塔 | [国服官网](https://mu.zhaouc.com/Guide/GameIntro/02_area06.html) |
| 5 | Exile | 流放地 | 流放地 | 保留旧译，待核实 |
| 6 | Arena | 竞技场 | 竞技场 | 保留旧译，待核实 |
| 7 | Atlans | 亚特兰蒂斯 | 亚特兰蒂斯 | [国服官网](https://mu.zhaouc.com/Guide/GameIntro/02_area07.html) |
| 8 | Tarkan | 塔克 | 死亡沙漠 | [国服官网](https://mu.zhaouc.com/Guide/GameIntro/02_area08.html) |
| 9 | Devil Square 1 | 恶魔广场 1 | 恶魔广场 1 | [国服官网](https://mu.zhaouc.com/Guide/GameFeature/01_feature.html) |
| 9 | Devil Square 2 | 恶魔广场 2 | 恶魔广场 2 | [国服官网](https://mu.zhaouc.com/Guide/GameFeature/01_feature.html) |
| 9 | Devil Square 3 | 恶魔广场 3 | 恶魔广场 3 | [国服官网](https://mu.zhaouc.com/Guide/GameFeature/01_feature.html) |
| 9 | Devil Square 4 | 恶魔广场 4 | 恶魔广场 4 | [国服官网](https://mu.zhaouc.com/Guide/GameFeature/01_feature.html) |
| 10 | Icarus | 天空之城 | 天空之城 | [国服官网](https://mu.zhaouc.com/Guide/GameIntro/02_area09.html) |
| 11 | Blood Castle 1 | 血色城堡 1 | 血色城堡 1 | [国服官网](https://mu.zhaouc.com/Guide/GameFeature/03_feature.html) |
| 12 | Blood Castle 2 | 血色城堡 2 | 血色城堡 2 | [国服官网](https://mu.zhaouc.com/Guide/GameFeature/03_feature.html) |
| 13 | Blood Castle 3 | 血色城堡 3 | 血色城堡 3 | [国服官网](https://mu.zhaouc.com/Guide/GameFeature/03_feature.html) |
| 14 | Blood Castle 4 | 血色城堡 4 | 血色城堡 4 | [国服官网](https://mu.zhaouc.com/Guide/GameFeature/03_feature.html) |
| 15 | Blood Castle 5 | 血色城堡 5 | 血色城堡 5 | [国服官网](https://mu.zhaouc.com/Guide/GameFeature/03_feature.html) |
| 16 | Blood Castle 6 | 血色城堡 6 | 血色城堡 6 | [国服官网](https://mu.zhaouc.com/Guide/GameFeature/03_feature.html) |
| 17 | Blood Castle 7 | 血色城堡 7 | 血色城堡 7 | [国服官网](https://mu.zhaouc.com/Guide/GameFeature/03_feature.html) |
| 18 | Chaos Castle 1 | 赤色要塞 1 | 赤色要塞 1 | [国服官网](https://mu.zhaouc.com/Guide/GameFeature/02_feature.html) |
| 19 | Chaos Castle 2 | 赤色要塞 2 | 赤色要塞 2 | [国服官网](https://mu.zhaouc.com/Guide/GameFeature/02_feature.html) |
| 20 | Chaos Castle 3 | 赤色要塞 3 | 赤色要塞 3 | [国服官网](https://mu.zhaouc.com/Guide/GameFeature/02_feature.html) |
| 21 | Chaos Castle 4 | 赤色要塞 4 | 赤色要塞 4 | [国服官网](https://mu.zhaouc.com/Guide/GameFeature/02_feature.html) |
| 22 | Chaos Castle 5 | 赤色要塞 5 | 赤色要塞 5 | [国服官网](https://mu.zhaouc.com/Guide/GameFeature/02_feature.html) |
| 23 | Chaos Castle 6 | 赤色要塞 6 | 赤色要塞 6 | [国服官网](https://mu.zhaouc.com/Guide/GameFeature/02_feature.html) |
| 24 | Kalima 1 | 卡利玛 1 | 卡利玛神庙 1 | [国服官网](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 25 | Kalima 2 | 卡利玛 2 | 卡利玛神庙 2 | [国服官网](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 26 | Kalima 3 | 卡利玛 3 | 卡利玛神庙 3 | [国服官网](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 27 | Kalima 4 | 卡利玛 4 | 卡利玛神庙 4 | [国服官网](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 28 | Kalima 5 | 卡利玛 5 | 卡利玛神庙 5 | [国服官网](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 29 | Kalima 6 | 卡利玛 6 | 卡利玛神庙 6 | [国服官网](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 30 | Valley of Loren | 罗兰峡谷 | 罗兰峡谷 | [国服官网](https://mu.zhaouc.com/Guide/GameIntro/02_area11.html) |
| 31 | Land_of_Trials | 试炼之地 | 魔炼之地 | [国服官网](https://mu.zhaouc.com/Guide/GameIntro/02_area12.html) |
| 32 | Devil Square 5 | 恶魔广场 5 | 恶魔广场 5 | [国服官网](https://mu.zhaouc.com/Guide/GameFeature/01_feature.html) |
| 32 | Devil Square 6 | 恶魔广场 6 | 恶魔广场 6 | [国服官网](https://mu.zhaouc.com/Guide/GameFeature/01_feature.html) |
| 32 | Devil Square 7 | 恶魔广场 7 | 恶魔广场 7 | [国服官网](https://mu.zhaouc.com/Guide/GameFeature/01_feature.html) |
| 33 | Aida | 艾迪亚 | 幽暗森林 | [国服官网](https://mu.zhaouc.com/Guide/GameIntro/02_area13.html) |
| 34 | Crywolf Fortress | 狼魂要塞 | 狼魂要塞 | [国服官网](https://mu.zhaouc.com/Guide/GameIntro/02_area14.html) |
| 36 | Kalima 7 | 卡利玛 7 | 卡利玛神庙 7 | [国服官网](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 37 | Kanturu_I | 坎特鲁遗址 | 坎特鲁废墟 | [国服官网](https://mu.zhaouc.com/news/Notice/12776.html) |
| 38 | Kanturu_III | 坎特鲁遗迹 | 坎特鲁遗址 | [国服官网](https://mu.zhaouc.com/Guide/GameIntro/02_area16.html) |
| 39 | Kanturu Event | 坎特鲁核心 | 提炼之塔 | [国服官网](https://mu.zhaouc.com/Guide/GameIntro/02_area16.html) |
| 40 | Silent Map? | 未知地图 | 未知地图 | 保留旧译，待核实 |
| 41 | Barracks of Balgass | 巴尔加斯兵营 | 巴卡斯兵营 | [国服官网](https://mu.zhaouc.com/Guide/GameSystem/08_quest.html) |
| 42 | Balgass Refuge | 巴尔加斯休息处 | 巴卡斯休息室 | [国服官网](https://mu.zhaouc.com/Guide/GameSystem/08_quest.html) |
| 45 | Illusion Temple 1 | 幻影寺院 1 | 幻影寺院 1 | [国服官网](https://mu.zhaouc.com/Guide/GameFeature/07_feature.html) |
| 46 | Illusion Temple 2 | 幻影寺院 2 | 幻影寺院 2 | [国服官网](https://mu.zhaouc.com/Guide/GameFeature/07_feature.html) |
| 47 | Illusion Temple 3 | 幻影寺院 3 | 幻影寺院 3 | [国服官网](https://mu.zhaouc.com/Guide/GameFeature/07_feature.html) |
| 48 | Illusion Temple 4 | 幻影寺院 4 | 幻影寺院 4 | [国服官网](https://mu.zhaouc.com/Guide/GameFeature/07_feature.html) |
| 49 | Illusion Temple 5 | 幻影寺院 5 | 幻影寺院 5 | [国服官网](https://mu.zhaouc.com/Guide/GameFeature/07_feature.html) |
| 50 | Illusion Temple 6 | 幻影寺院 6 | 幻影寺院 6 | [国服官网](https://mu.zhaouc.com/Guide/GameFeature/07_feature.html) |
| 51 | Elvenland | 幻术园 | 幻术园 | [国服官网](https://mu.zhaouc.com/Guide/GameIntro/02_area03.html) |
| 52 | Blood Castle 8 | 血色城堡 8 | 血色城堡 8 | [国服官网](https://mu.zhaouc.com/Guide/GameFeature/03_feature.html) |
| 53 | Chaos Castle 7 | 赤色要塞 7 | 赤色要塞 7 | [国服官网](https://mu.zhaouc.com/Guide/GameFeature/02_feature.html) |
| 56 | Swamp Of Calmness | 宁静沼泽 | 安宁池 | [国服官网](https://mu.zhaouc.com/Guide/GameIntro/02_area17.html) |
| 57 | LaCleon | 狼魂要塞 | 冰霜之城 | [国服官网](https://mu.zhaouc.com/Guide/GameIntro/02_area18.html) |
| 58 | LaCleon Boss | 狼魂要塞首领房 | 孵化魔地 | [国服官网](https://mu.zhaouc.com/Guide/GameIntro/02_area18.html) |
| 62 | Santa Village | 圣诞村 | 圣诞村 | 保留旧译，待核实 |
| 63 | Vulcanus | 坎特鲁废墟 | 囚禁之岛 | [国服官网](https://mu.zhaouc.com/01_news/updatecn/S5/S5_1.htm) |
| 64 | Duel Arena | 决斗场 | 角斗场 | [国服官网](https://mu.zhaouc.com/01_news/updatecn/S5/S5_1.htm) |
| 65 | Doppelgaenger 1 | 幽灵神殿 1 | 生魂广场 1 | [国服官网](https://mu.zhaouc.com/Guide/GameFeature/08_feature.html) |
| 66 | Doppelgaenger 2 | 幽灵神殿 2 | 生魂广场 2 | [国服官网](https://mu.zhaouc.com/Guide/GameFeature/08_feature.html) |
| 67 | Doppelgaenger 3 | 幽灵神殿 3 | 生魂广场 3 | [国服官网](https://mu.zhaouc.com/Guide/GameFeature/08_feature.html) |
| 68 | Doppelgaenger 4 | 幽灵神殿 4 | 生魂广场 4 | [国服官网](https://mu.zhaouc.com/Guide/GameFeature/08_feature.html) |
| 69 | Fortress of Imperial Guardian 1 | 帝国守护者要塞 1 | 帝国要塞 1 | [国服官网](https://mu.zhaouc.com/News/Update/151125_event/index3.html) |
| 70 | Fortress of Imperial Guardian 2 | 帝国守护者要塞 2 | 帝国要塞 2 | [国服官网](https://mu.zhaouc.com/News/Update/151125_event/index3.html) |
| 71 | Fortress of Imperial Guardian 3 | 帝国守护者要塞 3 | 帝国要塞 3 | [国服官网](https://mu.zhaouc.com/News/Update/151125_event/index3.html) |
| 72 | Fortress of Imperial Guardian 4 | 帝国守护者要塞 4 | 帝国要塞 4 | [国服官网](https://mu.zhaouc.com/News/Update/151125_event/index3.html) |
| 79 | LorenMarket | 罗伦市场 | 罗兰市集 | [国服官网](https://mu.zhaouc.com/news/Update/225.html) |
| 80 | Karutan 1 | 卡伦特 1 | 卡伦特 1 | [国服官网](https://mu.zhaouc.com/Guide/GameIntro/02_area19.html) |
| 81 | Karutan 2 | 卡伦特 2 | 卡伦特 2 | [国服官网](https://mu.zhaouc.com/Guide/GameIntro/02_area19.html) |
