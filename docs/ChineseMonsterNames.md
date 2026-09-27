# 怪物列表中文名称对照

本次补齐怪物列表中的怪物、NPC、机关及活动对象。保留中立英文名称，中文存于
`config."MonsterDefinition"."Designation"` 的 `||zh=` 段。
当前数据库的 468 条记录包括上一批已处理的 22 位商人；本次另覆盖新版初始化中的
11 条生魂广场怪物和 4 条坎特鲁事件对象，因此对照表包含 461 条非商人记录。
商人名称及其来源见 [商人对照表](ChineseMerchantNames.md)。

## 来源与准确性

- 来源为官方链接：按地图、外形、等级或用途对应官网名称。
- `派生`：基础名称有官方依据，层数、序号、训练兵、强化变体等后缀按项目配置保留；
  不表示完整字符串是官方原文。
- `既有`：保留已有中文名称，本轮未取得独立官方名称证据。
- `暂译`：按英文含义或音译补齐，尚未核实国服官方名称，后续可继续校准。
- 数字后缀是配置中的活动层数或变体编号，不是怪物等级。
- `{0}` 等格式占位符原样保留，避免影响动态名称生成。
- 本轮只改服务端配置名称，不修改客户端语言文件。

## 部署与更新

新数据库初始化自动带上中文。已有数据库部署新版后，在 `/config-updates` 应用
**对齐简体中文怪物及NPC名称**，然后重启服务。
更新版本：0.75 为 122，0.95d 为 123，Season 6 为 124。该更新为可选项。
需要商人翻译的旧库还应应用上一批商人名称更新。

更新仅匹配内置编号和中立英文名称，只补齐空白翻译、中立英文副本或本项目已知旧译。
任意自定义中文（包括带英文的自定义名称）不会被批量覆盖。
不修改怪物属性、掉落、刷新位置、刷新间隔、商店商品及其他语言。
可重复执行；后台更新成功后会记录安装状态。

也可备份数据库、停止应用后执行
`scripts/localization/align-monster-names.sql`，执行时使用 `psql -v ON_ERROR_STOP=1`，
完成后重启应用。SQL 不登记插件安装状态，之后应用插件仍然安全。

## 完整对照

| 编号 | 中立英文名称 | 中文名称 | 依据 |
| --- | --- | --- | --- |
| 0 | Bull Fighter | 牛怪 | [A01](https://mu.zhaouc.com/Guide/GameIntro/02_area01.html) |
| 1 | Hound | 猎犬怪 | [A01](https://mu.zhaouc.com/Guide/GameIntro/02_area01.html) |
| 2 | Budge Dragon | 幼龙 | [A01](https://mu.zhaouc.com/Guide/GameIntro/02_area01.html) |
| 3 | Spider | 蜘蛛 | [A01](https://mu.zhaouc.com/Guide/GameIntro/02_area01.html) |
| 4 | Elite Bull Fighter | 蛮牛怪 | [A01](https://mu.zhaouc.com/Guide/GameIntro/02_area01.html) |
| 5 | Hell Hound | 地狱猎犬怪 | [A05](https://mu.zhaouc.com/Guide/GameIntro/02_area05.html) |
| 6 | Lich | 黑巫师 | [A01](https://mu.zhaouc.com/Guide/GameIntro/02_area01.html) |
| 7 | Giant | 巨人 | [A01](https://mu.zhaouc.com/Guide/GameIntro/02_area01.html) |
| 8 | Poison Bull | 毒牛怪 | [A05](https://mu.zhaouc.com/Guide/GameIntro/02_area05.html) |
| 9 | Thunder Lich | 死灵巫师 | [A05](https://mu.zhaouc.com/Guide/GameIntro/02_area05.html) |
| 10 | Dark Knight | 暗黑骑士 | [A05](https://mu.zhaouc.com/Guide/GameIntro/02_area05.html) |
| 11 | Ghost | 幽灵 | [A05](https://mu.zhaouc.com/Guide/GameIntro/02_area05.html) |
| 12 | Larva | 毒虫 | [A05](https://mu.zhaouc.com/Guide/GameIntro/02_area05.html) |
| 13 | Hell Spider | 地狱蜘蛛 | [A05](https://mu.zhaouc.com/Guide/GameIntro/02_area05.html) |
| 14 | Skeleton Warrior | 骷髅兵 | [A01](https://mu.zhaouc.com/Guide/GameIntro/02_area01.html) |
| 15 | Skeleton Archer | 骷髅弓箭手 | [A05](https://mu.zhaouc.com/Guide/GameIntro/02_area05.html) |
| 16 | Elite Skeleton | 骷髅战士 | [A05](https://mu.zhaouc.com/Guide/GameIntro/02_area05.html) |
| 17 | Cyclops | 独眼巨人 | [A05](https://mu.zhaouc.com/Guide/GameIntro/02_area05.html) |
| 18 | Gorgon | 魔鬼戈登 | [A05](https://mu.zhaouc.com/Guide/GameIntro/02_area05.html) |
| 19 | Yeti | 雪人 | [A04](https://mu.zhaouc.com/Guide/GameIntro/02_area04.html) |
| 20 | Elite Yeti | 雪人王 | [A04](https://mu.zhaouc.com/Guide/GameIntro/02_area04.html) |
| 21 | Assassin | 暗杀者 | [A04](https://mu.zhaouc.com/Guide/GameIntro/02_area04.html) |
| 22 | Ice Monster | 寒冰魔 | [A04](https://mu.zhaouc.com/Guide/GameIntro/02_area04.html) |
| 23 | Hommerd | 蓝魔怪 | [A04](https://mu.zhaouc.com/Guide/GameIntro/02_area04.html) |
| 24 | Worm | 雪虫 | [A04](https://mu.zhaouc.com/Guide/GameIntro/02_area04.html) |
| 25 | Ice Queen | 冰后 | [A04](https://mu.zhaouc.com/Guide/GameIntro/02_area04.html) |
| 26 | Goblin | 小哥布林 | [A02](https://mu.zhaouc.com/Guide/GameIntro/02_area02.html) |
| 27 | Chain Scorpion | 勾尾蝎 | [A02](https://mu.zhaouc.com/Guide/GameIntro/02_area02.html) |
| 28 | Beetle Monster | 瓢虫怪 | [A02](https://mu.zhaouc.com/Guide/GameIntro/02_area02.html) |
| 29 | Hunter | 偷猎者 | [A02](https://mu.zhaouc.com/Guide/GameIntro/02_area02.html) |
| 30 | Forest Monster | 树妖 | [A02](https://mu.zhaouc.com/Guide/GameIntro/02_area02.html) |
| 31 | Agon | 亚昆 | [A02](https://mu.zhaouc.com/Guide/GameIntro/02_area02.html) |
| 32 | Stone Golem | 石巨人 | [A02](https://mu.zhaouc.com/Guide/GameIntro/02_area02.html) |
| 33 | Elite Goblin | 大哥布林 | [A02](https://mu.zhaouc.com/Guide/GameIntro/02_area02.html) |
| 34 | Cursed Wizard | 诅咒巫师 | [A06](https://mu.zhaouc.com/Guide/GameIntro/02_area06.html) |
| 35 | Death Gorgon | 死神戈登 | [A06](https://mu.zhaouc.com/Guide/GameIntro/02_area06.html) |
| 36 | Shadow | 鬼魅 | [A06](https://mu.zhaouc.com/Guide/GameIntro/02_area06.html) |
| 37 | Devil | 恶魔 | [A06](https://mu.zhaouc.com/Guide/GameIntro/02_area06.html) |
| 38 | Balrog | 魔王巴洛克 | [A06](https://mu.zhaouc.com/Guide/GameIntro/02_area06.html) |
| 39 | Poison Shadow | 剧毒鬼魅 | [A06](https://mu.zhaouc.com/Guide/GameIntro/02_area06.html) |
| 40 | Death Knight | 死神骑士 | [A06](https://mu.zhaouc.com/Guide/GameIntro/02_area06.html) |
| 41 | Death Cow | 牛魔王 | [A06](https://mu.zhaouc.com/Guide/GameIntro/02_area06.html) |
| 43 | Golden Budge Dragon | 黄金幼龙 | 既有 |
| 44 | Red Dragon | 火龙王 | 暂译 |
| 45 | Bahamut | 小巴哈姆特 | [A07](https://mu.zhaouc.com/Guide/GameIntro/02_area07.html) |
| 46 | Vepar | 死亡美人鱼 | [A07](https://mu.zhaouc.com/Guide/GameIntro/02_area07.html) |
| 47 | Valkyrie | 蓝翼海怪 | [A07](https://mu.zhaouc.com/Guide/GameIntro/02_area07.html) |
| 48 | Lizard King | 巫师王 | [A07](https://mu.zhaouc.com/Guide/GameIntro/02_area07.html) |
| 49 | Hydra | 海魔希特拉 | [A07](https://mu.zhaouc.com/Guide/GameIntro/02_area07.html) |
| 50 | Sea Worm | 海虫 | 暂译 |
| 51 | Great Bahamut | 大巴哈姆特 | [A07](https://mu.zhaouc.com/Guide/GameIntro/02_area07.html) |
| 52 | Silver Valkyrie | 银弓海怪 | [A07](https://mu.zhaouc.com/Guide/GameIntro/02_area07.html) |
| 53 | Golden Titan | 黄金泰坦 | 既有 |
| 54 | Golden Soldier | 黄金士兵 | 既有 |
| 57 | Iron Wheel | 铁轮战士 | [A08](https://mu.zhaouc.com/Guide/GameIntro/02_area08.html) |
| 58 | Tantallos | 破坏骑士 | [A08](https://mu.zhaouc.com/Guide/GameIntro/02_area08.html) |
| 59 | Zaikan | 魔王扎坎 | [A08](https://mu.zhaouc.com/Guide/GameIntro/02_area08.html) |
| 60 | Bloody Wolf | 铁脊怪 | [A08](https://mu.zhaouc.com/Guide/GameIntro/02_area08.html) |
| 61 | Beam Knight | 黑炎魔 | [A08](https://mu.zhaouc.com/Guide/GameIntro/02_area08.html) |
| 62 | Mutant | 巨齿兽 | [A08](https://mu.zhaouc.com/Guide/GameIntro/02_area08.html) |
| 63 | Death Beam Knight | 炽炎魔 | [A08](https://mu.zhaouc.com/Guide/GameIntro/02_area08.html) |
| 64 | Orc Archer | 兽人弓箭手 | 暂译 |
| 65 | Elite Orc | 精英兽人 | 暂译 |
| 66 | Cursed King | 骷髅王 | 暂译 |
| 67 | Metal Balrog | 金属巴洛克 | 暂译 |
| 69 | Alquamos | 阿卡摩斯 | [A09](https://mu.zhaouc.com/Guide/GameIntro/02_area09.html) |
| 70 | Queen Rainer | 风后 | [A09](https://mu.zhaouc.com/Guide/GameIntro/02_area09.html) |
| 71 | Mega Crust | 恶灵 | [A09](https://mu.zhaouc.com/Guide/GameIntro/02_area09.html) |
| 72 | Phantom Knight | 幻影骑士 | [A09](https://mu.zhaouc.com/Guide/GameIntro/02_area09.html) |
| 73 | Drakan | 蓝魔龙 | [A09](https://mu.zhaouc.com/Guide/GameIntro/02_area09.html) |
| 74 | Alpha Crust | 恶灵王 | [A09](https://mu.zhaouc.com/Guide/GameIntro/02_area09.html) |
| 75 | Great Drakan | 红魔龙 | [A09](https://mu.zhaouc.com/Guide/GameIntro/02_area09.html) |
| 76 | Dark Phoenix Shield | 天魔菲尼斯（护盾阶段） | [派生:A09](https://mu.zhaouc.com/Guide/GameIntro/02_area09.html) |
| 77 | Dark Phoenix | 天魔菲尼斯 | [A09](https://mu.zhaouc.com/Guide/GameIntro/02_area09.html) |
| 78 | Golden Goblin | 黄金哥布林 | 既有 |
| 79 | Golden Dragon | 黄金火龙王 | 既有 |
| 80 | Golden Lizard King | 黄金巫师王 | 既有 |
| 81 | Golden Vepar | 黄金美人鱼 | 既有 |
| 82 | Golden Tantallos | 黄金破坏骑士 | 既有 |
| 83 | Golden Wheel | 黄金铁轮战士 | 既有 |
| 84 | Chief Skeleton Warrior 1 | 骷髅战士队长 1 | 暂译 |
| 85 | Chief Skeleton Archer 1 | 骷髅弓箭手队长 1 | 暂译 |
| 86 | Dark Skull Soldier 1 | 暗黑骷髅士兵 1 | 暂译 |
| 87 | Giant Ogre 1 | 巨型食人魔 1 | 暂译 |
| 88 | Red Skeleton Knight 1 | 红骷髅骑士 1 | 暂译 |
| 89 | Magic Skeleton 1 | 骷髅巫师 1 | 暂译 |
| 90 | Chief Skeleton Warrior 2 | 骷髅战士队长 2 | 暂译 |
| 91 | Chief Skeleton Archer 2 | 骷髅弓箭手队长 2 | 暂译 |
| 92 | Dark Skull Soldier 2 | 暗黑骷髅士兵 2 | 暂译 |
| 93 | Giant Ogre 2 | 巨型食人魔 2 | 暂译 |
| 94 | Red Skeleton Knight 2 | 红骷髅骑士 2 | 暂译 |
| 95 | Magic Skeleton 2 | 骷髅巫师 2 | 暂译 |
| 96 | Chief Skeleton Warrior 3 | 骷髅战士队长 3 | 暂译 |
| 97 | Chief Skeleton Archer 3 | 骷髅弓箭手队长 3 | 暂译 |
| 98 | Dark Skull Soldier 3 | 暗黑骷髅士兵 3 | 暂译 |
| 99 | Giant Ogre 3 | 巨型食人魔 3 | 暂译 |
| 100 | Lance Trap | 长矛陷阱 | 暂译 |
| 101 | Iron Stick Trap | 铁棒陷阱 | 暂译 |
| 102 | Fire Trap | 火焰陷阱 | 暂译 |
| 103 | Meteorite Trap | 陨石陷阱 | 暂译 |
| 105 | Canon Trap | 火炮陷阱 | 暂译 |
| 106 | Laser Trap | 激光陷阱 | 暂译 |
| 111 | Red Skeleton Knight 3 | 红骷髅骑士 3 | 暂译 |
| 112 | Magic Skeleton 3 | 骷髅巫师 3 | 暂译 |
| 113 | Chief Skeleton Warrior 4 | 骷髅战士队长 4 | 暂译 |
| 114 | Chief Skeleton Archer 4 | 骷髅弓箭手队长 4 | 暂译 |
| 115 | Dark Skull Soldier 4 | 暗黑骷髅士兵 4 | 暂译 |
| 116 | Giant Ogre 4 | 巨型食人魔 4 | 暂译 |
| 117 | Red Skeleton Knight 4 | 红骷髅骑士 4 | 暂译 |
| 118 | Magic Skeleton 4 | 骷髅巫师 4 | 暂译 |
| 119 | Chief Skeleton Warrior 5 | 骷髅战士队长 5 | 暂译 |
| 120 | Chief Skeleton Archer 5 | 骷髅弓箭手队长 5 | 暂译 |
| 121 | Dark Skull Soldier 5 | 暗黑骷髅士兵 5 | 暂译 |
| 122 | Giant Ogre 5 | 巨型食人魔 5 | 暂译 |
| 123 | Red Skeleton Knight 5 | 红骷髅骑士 5 | 暂译 |
| 124 | Magic Skeleton 5 | 骷髅巫师 5 | 暂译 |
| 125 | Chief Skeleton Warrior 6 | 骷髅战士队长 6 | 暂译 |
| 126 | Chief Skeleton Archer 6 | 骷髅弓箭手队长 6 | 暂译 |
| 127 | Dark Skull Soldier 6 | 暗黑骷髅士兵 6 | 暂译 |
| 128 | Giant Ogre 6 | 巨型食人魔 6 | 暂译 |
| 129 | Red Skeleton Knight 6 | 红骷髅骑士 6 | 暂译 |
| 130 | Magic Skeleton 6 | 骷髅巫师 6 | 暂译 |
| 131 | Castle Gate | 城门 | 暂译 |
| 132 | Statue of Saint | 圣天使雕像 | 暂译 |
| 133 | Statue of Saint | 圣天使雕像 | 暂译 |
| 134 | Statue of Saint | 圣天使雕像 | 暂译 |
| 135 | White Wizard | 白魔法师 | 暂译 |
| 136 | Destructive Ogre Soldier | 破坏兽人士兵 | 暂译 |
| 137 | Destructive Ogre Archer | 破坏兽人弓箭手 | 暂译 |
| 138 | Chief Skeleton Warrior 7 | 骷髅战士队长 7 | 暂译 |
| 139 | Chief Skeleton Archer 7 | 骷髅弓箭手队长 7 | 暂译 |
| 140 | Dark Skull Soldier 7 | 暗黑骷髅士兵 7 | 暂译 |
| 141 | Giant Ogre 7 | 巨型食人魔 7 | 暂译 |
| 142 | Red Skeleton Knight 7 | 红骷髅骑士 7 | 暂译 |
| 143 | Magic Skeleton 7 | 骷髅巫师 7 | 暂译 |
| 144 | Death Angel 1 | 死亡天使 1 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 145 | Death Centurion 1 | 狂武士 1 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 146 | Blood Soldier 1 | 龙虾守卫 1 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 147 | Aegis 1 | 阿卡斯 1 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 148 | Rogue Centurion 1 | 武士 1 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 149 | Necron 1 | 暗黑巫师 1 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 150 | Bali | 巴里 | 暂译 |
| 151 | Soldier | 士兵 | 暂译 |
| 152 | Gate to Kalima 1 of {0} | {0}的卡利玛1入口 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 153 | Gate to Kalima 2 of {0} | {0}的卡利玛2入口 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 154 | Gate to Kalima 3 of {0} | {0}的卡利玛3入口 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 155 | Gate to Kalima 4 of {0} | {0}的卡利玛4入口 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 156 | Gate to Kalima 5 of {0} | {0}的卡利玛5入口 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 157 | Gate to Kalima 6 of {0} | {0}的卡利玛6入口 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 158 | Gate to Kalima 7 of {0} | {0}的卡利玛7入口 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 160 | Schriker 1 | 暗黑傀儡 1 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 161 | Illusion of Kundun 1 | 昆顿幻影 1 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 162 | Chaos Castle 1 | 赤色要塞怪物 1 | 暂译 |
| 163 | Chaos Castle 2 | 赤色要塞怪物 2 | 暂译 |
| 164 | Chaos Castle 3 | 赤色要塞怪物 3 | 暂译 |
| 165 | Chaos Castle 4 | 赤色要塞怪物 4 | 暂译 |
| 166 | Chaos Castle 5 | 赤色要塞怪物 5 | 暂译 |
| 167 | Chaos Castle 6 | 赤色要塞怪物 6 | 暂译 |
| 168 | Chaos Castle 7 | 赤色要塞怪物 7 | 暂译 |
| 169 | Chaos Castle 8 | 赤色要塞怪物 8 | 暂译 |
| 170 | Chaos Castle 9 | 赤色要塞怪物 9 | 暂译 |
| 171 | Chaos Castle 10 | 赤色要塞怪物 10 | 暂译 |
| 172 | Chaos Castle 11 | 赤色要塞怪物 11 | 暂译 |
| 173 | Chaos Castle 12 | 赤色要塞怪物 12 | 暂译 |
| 174 | Death Angel 2 | 死亡天使 2 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 175 | Death Centurion 2 | 狂武士 2 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 176 | Blood Soldier 2 | 龙虾守卫 2 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 177 | Aegis 2 | 阿卡斯 2 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 178 | Rogue Centurion 2 | 武士 2 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 179 | Necron 2 | 暗黑巫师 2 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 180 | Schriker 2 | 暗黑傀儡 2 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 181 | Illusion of Kundun 2 | 昆顿幻影 2 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 182 | Death Angel 3 | 死亡天使 3 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 183 | Death Centurion 3 | 狂武士 3 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 184 | Blood Soldier 3 | 龙虾守卫 3 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 185 | Aegis 3 | 阿卡斯 3 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 186 | Rogue Centurion 3 | 武士 3 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 187 | Necron 3 | 暗黑巫师 3 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 188 | Schriker 3 | 暗黑傀儡 3 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 189 | Illusion of Kundun 3 | 昆顿幻影 3 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 190 | Death Angel 4 | 死亡天使 4 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 191 | Death Centurion 4 | 狂武士 4 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 192 | Blood Soldier 4 | 龙虾守卫 4 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 193 | Aegis 4 | 阿卡斯 4 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 194 | Rogue Centurion 4 | 武士 4 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 195 | Necron 4 | 暗黑巫师 4 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 196 | Schriker 4 | 暗黑傀儡 4 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 197 | Illusion of Kundun 4 | 昆顿幻影 4 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 200 | Soccerball | 足球 | 既有 |
| 204 | Wolf Status | 神狼雕像 | [狼魂](https://mu.zhaouc.com/news/Update/203.html) |
| 205 | Wolf Altar1 | 神狼护台1 | [派生:狼魂](https://mu.zhaouc.com/news/Update/203.html) |
| 206 | Wolf Altar2 | 神狼护台2 | [派生:狼魂](https://mu.zhaouc.com/news/Update/203.html) |
| 207 | Wolf Altar3 | 神狼护台3 | [派生:狼魂](https://mu.zhaouc.com/news/Update/203.html) |
| 208 | Wolf Altar4 | 神狼护台4 | [派生:狼魂](https://mu.zhaouc.com/news/Update/203.html) |
| 209 | Wolf Altar5 | 神狼护台5 | [派生:狼魂](https://mu.zhaouc.com/news/Update/203.html) |
| 215 | Shield | 防护盾 | 暂译 |
| 216 | Crown | 王座 | 暂译 |
| 217 | Crown Switch1 | 王座开关1 | 暂译 |
| 218 | Crown Switch2 | 王座开关2 | 暂译 |
| 219 | Castle Gate Switch | 城门开关 | 暂译 |
| 220 | Guard | 守卫 | 既有 |
| 221 | Slingshot Attack | 攻城投石车 | 暂译 |
| 222 | Slingshot Defense | 守城投石车 | 暂译 |
| 223 | Senior | 长老 | [NPC](https://mu.zhaouc.com/Guide/npc/NPC.html) |
| 224 | Guardsman | 攻城卫兵 | [A11](https://mu.zhaouc.com/Guide/GameIntro/02_area11.html) |
| 226 | Pet Trainer | 驯兽师 | [NPC](https://mu.zhaouc.com/Guide/npc/NPC.html) |
| 229 | Marlon | 警卫队长摩伦 | [NPC](https://mu.zhaouc.com/Guide/npc/NPC.html) |
| 232 | Archangel | 大天使 | 既有 |
| 233 | Messenger of Arch. | 大天使的使者 | [NPC](https://mu.zhaouc.com/Guide/npc/NPC.html) |
| 235 | Sevina the Priestess | 圣导士塞维娜 | [NPC](https://mu.zhaouc.com/Guide/npc/NPC.html) |
| 236 | Golden Archer | 黄金弓箭手 | 既有 |
| 237 | Charon | 卡隆 | [NPC](https://mu.zhaouc.com/Guide/npc/NPC.html) |
| 238 | Chaos Goblin | 玛雅哥布林 | [NPC](https://mu.zhaouc.com/Guide/npc/NPC.html) |
| 239 | Arena Guard | 竞技场守卫 | 既有 |
| 240 | Baz The Vault Keeper | 仓库使者赛佛特 | [A01](https://mu.zhaouc.com/Guide/GameIntro/02_area01.html) |
| 241 | Guild Master | 战盟使者罗兰斯 | [NPC](https://mu.zhaouc.com/Guide/npc/NPC.html) |
| 247 | Crossbow Guard | 弩箭守卫 | 既有 |
| 249 | Berdysh Guard | 长柄斧守卫 | 既有 |
| 256 | Lahap | 赛尔维斯 | [A03](https://mu.zhaouc.com/Guide/GameIntro/02_area03.html) |
| 257 | Elf Soldier | 幻影导师 | [NPC](https://mu.zhaouc.com/Guide/npc/NPC.html) |
| 260 | Death Angel 5 | 死亡天使 5 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 261 | Death Centurion 5 | 狂武士 5 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 262 | Blood Soldier 5 | 龙虾守卫 5 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 263 | Aegis 5 | 阿卡斯 5 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 264 | Rogue Centurion 5 | 武士 5 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 265 | Necron 5 | 暗黑巫师 5 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 266 | Schriker 5 | 暗黑傀儡 5 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 267 | Illusion of Kundun 5 | 昆顿幻影 5 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 268 | Death Angel 6 | 死亡天使 6 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 269 | Death Centurion 6 | 狂武士 6 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 270 | Blood Soldier 6 | 龙虾守卫 6 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 271 | Aegis 6 | 阿卡斯 6 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 272 | Rogue Centurion 6 | 武士 6 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 273 | Necron 6 | 暗黑巫师 6 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 274 | Schriker 6 | 暗黑傀儡 6 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 275 | Illusion of Kundun 7 | 昆顿幻影 7 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 277 | Castle Gate1 | 城门1 | [派生:攻城](https://mu.zhaouc.com/Guide/GameFeature/06_feature.html) |
| 278 | Life Stone | 生命之石 | [攻城](https://mu.zhaouc.com/Guide/GameFeature/06_feature.html) |
| 283 | Guardian Statue | 守护石像 | [攻城](https://mu.zhaouc.com/Guide/GameFeature/06_feature.html) |
| 285 | Guardian | 守护者 | 既有 |
| 286 | Battle Guard1 | 战斗守卫1 | 暂译 |
| 287 | Battle Guard2 | 战斗守卫2 | 暂译 |
| 288 | Canon Tower | 巨弩发射器 | [A14](https://mu.zhaouc.com/Guide/GameIntro/02_area14.html) |
| 290 | Lizard Warrior | 冷血变异者 | [A12](https://mu.zhaouc.com/Guide/GameIntro/02_area12.html) |
| 291 | Fire Golem | 熔岩巨魔 | [A12](https://mu.zhaouc.com/Guide/GameIntro/02_area12.html) |
| 292 | Queen Bee | 嗜血蜂后 | [A12](https://mu.zhaouc.com/Guide/GameIntro/02_area12.html) |
| 293 | Poison Golem | 毒巨魔 | [A12](https://mu.zhaouc.com/Guide/GameIntro/02_area12.html) |
| 294 | Axe Warrior | 巨斧战士 | [A12](https://mu.zhaouc.com/Guide/GameIntro/02_area12.html) |
| 295 | Erohim | 炼狱魔王 | [A12](https://mu.zhaouc.com/Guide/GameIntro/02_area12.html) |
| 304 | Witch Queen | 丛林女巫师 | [A13](https://mu.zhaouc.com/Guide/GameIntro/02_area13.html) |
| 305 | Blue Golem | 丛林残暴者 | [A13](https://mu.zhaouc.com/Guide/GameIntro/02_area13.html) |
| 306 | Death Rider | 丛林暗杀者 | [A13](https://mu.zhaouc.com/Guide/GameIntro/02_area13.html) |
| 307 | Forest Orc | 丛林生命体 | [A13](https://mu.zhaouc.com/Guide/GameIntro/02_area13.html) |
| 308 | Death Tree | 丛林树精灵 | [A13](https://mu.zhaouc.com/Guide/GameIntro/02_area13.html) |
| 309 | Hell Maine | 丛林召唤者 | [A13](https://mu.zhaouc.com/Guide/GameIntro/02_area13.html) |
| 310 | Hammer Scout | 刺锤侦察兵 | [A14](https://mu.zhaouc.com/Guide/GameIntro/02_area14.html) |
| 311 | Lance Scout | 长矛侦察兵 | [A14](https://mu.zhaouc.com/Guide/GameIntro/02_area14.html) |
| 312 | Bow Scout | 魔弓侦察兵 | [A14](https://mu.zhaouc.com/Guide/GameIntro/02_area14.html) |
| 313 | Werewolf | 暗黑血狼人 | [A14](https://mu.zhaouc.com/Guide/GameIntro/02_area14.html) |
| 314 | Scout(Hero) | 英雄侦察兵 | [A14](https://mu.zhaouc.com/Guide/GameIntro/02_area14.html) |
| 315 | Werewolf(Hero) | 英雄血狼人 | [A14](https://mu.zhaouc.com/Guide/GameIntro/02_area14.html) |
| 316 | Balram | 暗黑防御者 | [A14](https://mu.zhaouc.com/Guide/GameIntro/02_area14.html) |
| 317 | Soram | 暗黑扫荡者 | [A14](https://mu.zhaouc.com/Guide/GameIntro/02_area14.html) |
| 331 | Aegis 7 | 阿卡斯 7 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 332 | Rogue Centurion 7 | 武士 7 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 333 | Blood Soldier 7 | 龙虾守卫 7 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 334 | Death Angel 7 | 死亡天使 7 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 335 | Necron 7 | 暗黑巫师 7 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 336 | Death Centurion 7 | 狂武士 7 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 337 | Schriker 7 | 暗黑傀儡 7 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 338 | Illusion of Kundun 6 | 昆顿幻影 6 | [派生:A10](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html) |
| 350 | Berserker | 疯魔 | [A15](https://mu.zhaouc.com/Guide/GameIntro/02_area15.html) |
| 351 | Splinter Wolf | 裂角狼 | [A15](https://mu.zhaouc.com/Guide/GameIntro/02_area15.html) |
| 352 | Iron Rider | 金甲兽 | [A15](https://mu.zhaouc.com/Guide/GameIntro/02_area15.html) |
| 353 | Satyros | 半兽人 | [A15](https://mu.zhaouc.com/Guide/GameIntro/02_area15.html) |
| 354 | Blade Hunter | 刀刃猎手 | [A15](https://mu.zhaouc.com/Guide/GameIntro/02_area15.html) |
| 355 | Kentauros | 寒冰刺客 | [A15](https://mu.zhaouc.com/Guide/GameIntro/02_area15.html) |
| 356 | Gigantis | 狂巨人 | [A15](https://mu.zhaouc.com/Guide/GameIntro/02_area15.html) |
| 357 | Genocider | 屠杀者 | [A15](https://mu.zhaouc.com/Guide/GameIntro/02_area15.html) |
| 358 | Persona | 假面巫 | [A16](https://mu.zhaouc.com/Guide/GameIntro/02_area16.html) |
| 359 | Twin Tale | 毒步妖 | [A16](https://mu.zhaouc.com/Guide/GameIntro/02_area16.html) |
| 360 | Dreadfear | 恐惧天使 | [A16](https://mu.zhaouc.com/Guide/GameIntro/02_area16.html) |
| 361 | Nightmare | 咒怨魔王 | [A16](https://mu.zhaouc.com/Guide/GameIntro/02_area16.html) |
| 362 | Maya (Hand Left) | 玛雅左手 | [A16](https://mu.zhaouc.com/Guide/GameIntro/02_area16.html) |
| 363 | Maya (Hand Right) | 玛雅右手 | [A16](https://mu.zhaouc.com/Guide/GameIntro/02_area16.html) |
| 364 | Maya | 玛雅 | [A16](https://mu.zhaouc.com/Guide/GameIntro/02_area16.html) |
| 367 | Gateway Machine | 传送台 | [NPC](https://mu.zhaouc.com/Guide/npc/NPC.html) |
| 368 | Elphis | 艾尔菲丝 | [NPC](https://mu.zhaouc.com/Guide/npc/NPC.html) |
| 369 | Osbourne | 奥斯本 | [NPC](https://mu.zhaouc.com/Guide/npc/NPC.html) |
| 370 | Jerridon | 杰瑞敦 | [NPC](https://mu.zhaouc.com/Guide/npc/NPC.html) |
| 371 | Leo The Helper | 助手里奥 | 暂译 |
| 372 | Elite Skill Soldier | 精英技能士兵 | 暂译 |
| 375 | Chaos Card Master | 玛雅使者 | [A01](https://mu.zhaouc.com/Guide/GameIntro/02_area01.html) |
| 378 | GameMaster | 游戏管理员 | 既有 |
| 379 | Fireworks Girl | 烟花少女 | 既有 |
| 380 | Stone Statue | 石像 | 既有 |
| 381 | MU Allies General | 奇迹盟军将军 | 暂译 |
| 382 | Illusion Elder | 幻影长老 | 既有 |
| 383 | Alliance Item Storage | 盟军物品仓库 | 暂译 |
| 384 | Illusion Item Storage | 幻影物品仓库 | 既有 |
| 385 | Mirage | 弥拉邱 | [A03](https://mu.zhaouc.com/Guide/GameIntro/02_area03.html) |
| 404 | MU Allies | 奇迹盟军 | 暂译 |
| 405 | Illusion Sorcerer | 幻影术士 | 既有 |
| 406 | Priest Devin | 弟子黛彬 | [A14](https://mu.zhaouc.com/Guide/GameIntro/02_area14.html) |
| 407 | Werewolf Quarrel | 暗黑血狼人扩雷 | [A14](https://mu.zhaouc.com/Guide/GameIntro/02_area14.html) |
| 408 | Gatekeeper | 守门人 | 暂译 |
| 409 | Balram (Trainee Soldier) | 暗黑防御者（训练兵） | [派生:A14](https://mu.zhaouc.com/Guide/GameIntro/02_area14.html) |
| 410 | Death Spirit (Trainee Soldier) | 暗黑咒术师（训练兵） | [派生:A14](https://mu.zhaouc.com/Guide/GameIntro/02_area14.html) |
| 411 | Soram (Trainee Soldier) | 暗黑扫荡者（训练兵） | [派生:A14](https://mu.zhaouc.com/Guide/GameIntro/02_area14.html) |
| 412 | Dark Elf (Trainee Soldier) | 暗黑指挥官（训练兵） | [派生:A14](https://mu.zhaouc.com/Guide/GameIntro/02_area14.html) |
| 418 | Strange Rabbit | 怪异的兔子 | [A03](https://mu.zhaouc.com/Guide/GameIntro/02_area03.html) |
| 419 | Polluted Butterfly | 污染之蝶 | [A03](https://mu.zhaouc.com/Guide/GameIntro/02_area03.html) |
| 420 | Hideous Rabbit | 疯狂的兔子 | [A03](https://mu.zhaouc.com/Guide/GameIntro/02_area03.html) |
| 421 | Werewolf | 狼人 | [A03](https://mu.zhaouc.com/Guide/GameIntro/02_area03.html) |
| 422 | Cursed Lich | 诅咒巫师 | [A03](https://mu.zhaouc.com/Guide/GameIntro/02_area03.html) |
| 423 | Totem Golem | 图腾树人 | [A03](https://mu.zhaouc.com/Guide/GameIntro/02_area03.html) |
| 424 | Grizzly | 灰熊 | [A03](https://mu.zhaouc.com/Guide/GameIntro/02_area03.html) |
| 425 | Captain Grizzly | 残暴的灰熊 | [A03](https://mu.zhaouc.com/Guide/GameIntro/02_area03.html) |
| 426 | Chaos Castle 13 | 赤色要塞怪物 13 | 暂译 |
| 427 | Chaos Castle 14 | 赤色要塞怪物 14 | 暂译 |
| 428 | Chief Skeleton Warrior 8 | 骷髅战士队长 8 | 暂译 |
| 429 | Chief Skeleton Archer 8 | 骷髅弓箭手队长 8 | 暂译 |
| 430 | Dark Skull Soldier 8 | 暗黑骷髅士兵 8 | 暂译 |
| 431 | Giant Ogre 8 | 巨型食人魔 8 | 暂译 |
| 432 | Red Skeleton Knight 8 | 红骷髅骑士 8 | 暂译 |
| 433 | Magic Skeleton 8 | 骷髅巫师 8 | 暂译 |
| 434 | Gigantis | 狂巨人 | [派生:A15](https://mu.zhaouc.com/Guide/GameIntro/02_area15.html) |
| 435 | Berserk | 疯魔 | [派生:A15](https://mu.zhaouc.com/Guide/GameIntro/02_area15.html) |
| 436 | Balram (Trainee) | 暗黑防御者（训练兵） | [派生:A14](https://mu.zhaouc.com/Guide/GameIntro/02_area14.html) |
| 437 | Soram (Trainee) | 暗黑扫荡者（训练兵） | [派生:A14](https://mu.zhaouc.com/Guide/GameIntro/02_area14.html) |
| 438 | Persona | 假面巫 | [派生:A16](https://mu.zhaouc.com/Guide/GameIntro/02_area16.html) |
| 439 | Dreadfear | 恐惧天使 | [派生:A16](https://mu.zhaouc.com/Guide/GameIntro/02_area16.html) |
| 440 | Dark_Elf | 暗黑指挥官 | [派生:A14](https://mu.zhaouc.com/Guide/GameIntro/02_area14.html) |
| 441 | Sapi-Unus | 树妖 | [A17](https://mu.zhaouc.com/Guide/GameIntro/02_area17.html) |
| 442 | Sapi-Duo | 毒树妖 | [A17](https://mu.zhaouc.com/Guide/GameIntro/02_area17.html) |
| 443 | Sapi-Tres | 残忍的树妖 | [A17](https://mu.zhaouc.com/Guide/GameIntro/02_area17.html) |
| 444 | Shadow Pawn | 暗影爪牙 | [A17](https://mu.zhaouc.com/Guide/GameIntro/02_area17.html) |
| 445 | Shadow Knight | 暗影骑士 | [A17](https://mu.zhaouc.com/Guide/GameIntro/02_area17.html) |
| 446 | Shadow Look | 暗影武士 | [A17](https://mu.zhaouc.com/Guide/GameIntro/02_area17.html) |
| 447 | Thunder Napin | 闪电巨人 | [A17](https://mu.zhaouc.com/Guide/GameIntro/02_area17.html) |
| 448 | Ghost Napin | 幽灵巨人 | [A17](https://mu.zhaouc.com/Guide/GameIntro/02_area17.html) |
| 449 | Blaze Napin | 寒冰巨人 | [A17](https://mu.zhaouc.com/Guide/GameIntro/02_area17.html) |
| 450 | Cherry Blossom Spirit | 樱花精灵 | 既有 |
| 451 | Cherry Blossom Tree | 樱花树 | 既有 |
| 452 | Seed Master | 萤之石管理员 | [镶嵌](https://mu.zhaouc.com/Guide/ItemSystem/02_itemSys.html) |
| 453 | Seed Researcher | 萤之石研究员 | [派生:A03](https://mu.zhaouc.com/Guide/GameIntro/02_area03.html) |
| 454 | Ice Walker | 冰之魔犬 | [A18](https://mu.zhaouc.com/Guide/GameIntro/02_area18.html) |
| 455 | Giant Mammoth | 冰之魔象 | [A18](https://mu.zhaouc.com/Guide/GameIntro/02_area18.html) |
| 456 | Ice Giant | 冰之巨魔 | [A18](https://mu.zhaouc.com/Guide/GameIntro/02_area18.html) |
| 457 | Coolutin | 冰之魔蛛 | [A18](https://mu.zhaouc.com/Guide/GameIntro/02_area18.html) |
| 458 | Iron Knight | 冰铁剑魂 | [A18](https://mu.zhaouc.com/Guide/GameIntro/02_area18.html) |
| 459 | Selupan | 冰霜巨蛛 | [A18](https://mu.zhaouc.com/Guide/GameIntro/02_area18.html) |
| 460 | Spider Eggs 1 | 蜘蛛卵 1 | 暂译 |
| 461 | Spider Eggs 2 | 蜘蛛卵 2 | 暂译 |
| 462 | Spider Eggs 3 | 蜘蛛卵 3 | 暂译 |
| 467 | Snowman | 雪人 | 既有 |
| 468 | Little Santa Yellow | 黄色小圣诞老人 | 暂译 |
| 469 | Little Santa Green | 绿色小圣诞老人 | 暂译 |
| 470 | Little Santa Red | 红色小圣诞老人 | 暂译 |
| 471 | Little Santa Blue | 蓝色小圣诞老人 | 暂译 |
| 472 | Little Santa White | 白色小圣诞老人 | 暂译 |
| 473 | Little Santa Black | 黑色小圣诞老人 | 暂译 |
| 474 | Little Santa Orange | 橙色小圣诞老人 | 暂译 |
| 475 | Little Santa Pink | 粉色小圣诞老人 | 暂译 |
| 476 | Cursed Santa | 诅咒圣诞老人 | 既有 |
| 477 | Transformed Snowman | 变异雪人 | 既有 |
| 478 | Delgado - Lucky Coins | 幸运币兑换员德尔加多 | 暂译 |
| 479 | Gatekeeper Titus | 角斗场守卫提图斯 | 暂译 |
| 480 | Zombie Fighter | 幽灵斗士 | [囚禁](https://mu.zhaouc.com/01_news/updatecn/S5/S5_1.htm) |
| 481 | Zombie Fighter | 幽灵斗士 | [囚禁](https://mu.zhaouc.com/01_news/updatecn/S5/S5_1.htm) |
| 482 | Resurrected Gladiator | 幽灵角斗士 | [囚禁](https://mu.zhaouc.com/01_news/updatecn/S5/S5_1.htm) |
| 483 | Resurrected Gladiator | 幽灵角斗士 | [囚禁](https://mu.zhaouc.com/01_news/updatecn/S5/S5_1.htm) |
| 484 | Ash Slaughterer | 幽灵屠杀者 | [囚禁](https://mu.zhaouc.com/01_news/updatecn/S5/S5_1.htm) |
| 485 | Ash Slaughterer | 幽灵屠杀者 | [囚禁](https://mu.zhaouc.com/01_news/updatecn/S5/S5_1.htm) |
| 486 | Blood Assassin | 幽灵暗杀者 | [囚禁](https://mu.zhaouc.com/01_news/updatecn/S5/S5_1.htm) |
| 487 | Cruel Blood Assassin | 幽灵残酷暗杀者 | [囚禁](https://mu.zhaouc.com/01_news/updatecn/S5/S5_1.htm) |
| 488 | Cruel Blood Assassin | 幽灵残酷暗杀者 | [囚禁](https://mu.zhaouc.com/01_news/updatecn/S5/S5_1.htm) |
| 489 | Burning Lava Giant | 幽灵巨人 | [囚禁](https://mu.zhaouc.com/01_news/updatecn/S5/S5_1.htm) |
| 490 | Ruthless Lava Giant | 幽灵残酷巨人 | [囚禁](https://mu.zhaouc.com/01_news/updatecn/S5/S5_1.htm) |
| 491 | Ruthless Lava Giant | 幽灵残酷巨人 | [囚禁](https://mu.zhaouc.com/01_news/updatecn/S5/S5_1.htm) |
| 492 | Moss The Merchant | 摩斯 | [摩斯](https://mu.zhaouc.com/01_news/updatecn/s5/s5_4.htm) |
| 504 | Gayion The Gladiator | 角斗士盖伊昂 | 暂译 |
| 505 | Jerry | 杰瑞 | 暂译 |
| 506 | Raymond | 雷蒙德 | 暂译 |
| 507 | Lucas | 卢卡斯 | 暂译 |
| 508 | Fred | 弗雷德 | 暂译 |
| 509 | Hammerize | 重锤战士 | 暂译 |
| 510 | Dual Berserker | 双刃狂战士 | 暂译 |
| 511 | Devil Lord | 恶魔领主 | 暂译 |
| 512 | Quarter Master | 军需官 | 既有 |
| 513 | Combat Instructor | 战斗教官 | 既有 |
| 514 | Aticle's Head | 阿提克尔首领 | 暂译 |
| 515 | Dark Ghost | 黑暗幽灵 | 暂译 |
| 516 | Banshee | 女妖 | 暂译 |
| 517 | Head Mounter | 骑兵首领 | 暂译 |
| 518 | Defender | 防御者 | 既有 |
| 519 | Forsaker | 弃誓者 | 既有 |
| 520 | Ocelot the Lord | 领主奥赛洛特 | 暂译 |
| 521 | Eric the Guard | 守卫埃里克 | 暂译 |
| 522 | Adviser Jerinteu | 辅佐官杰林特 | [活动](https://mu.zhaouc.com/News/Update/151125_event/index3.html) |
| 523 | Trap | 陷阱 | 既有 |
| 524 | Evil Gate | 邪恶之门 | 既有 |
| 525 | Lion Gate | 狮门 | 既有 |
| 526 | Statue | 雕像 | 既有 |
| 527 | Star Gate | 星门 | 既有 |
| 528 | Rush Gate | 冲锋门 | 既有 |
| 529 | Terrible Butcher | 愤怒的屠夫 | [生魂](https://mu.zhaouc.com/Guide/GameFeature/08_feature.html) |
| 530 | Mad Butcher | 屠夫 | [生魂](https://mu.zhaouc.com/Guide/GameFeature/08_feature.html) |
| 531 | Ice Walker | 冰之魔犬 | [生魂](https://mu.zhaouc.com/Guide/GameFeature/08_feature.html) |
| 532 | Larva | 毒虫（生魂广场） | [派生:A05](https://mu.zhaouc.com/Guide/GameIntro/02_area05.html) |
| 533 | Doppelganger | 生魂分身 | 暂译 |
| 534 | Doppelganger Elf | 生魂弓箭手 | [派生:生魂](https://mu.zhaouc.com/Guide/GameFeature/08_feature.html) |
| 535 | Doppelganger Knight | 生魂剑士 | [生魂](https://mu.zhaouc.com/Guide/GameFeature/08_feature.html) |
| 536 | Doppelganger Wizard | 生魂魔法师 | [生魂](https://mu.zhaouc.com/Guide/GameFeature/08_feature.html) |
| 537 | Doppelganger Magic Gladiator | 生魂魔剑士 | [生魂](https://mu.zhaouc.com/Guide/GameFeature/08_feature.html) |
| 538 | Doppelganger Dark Lord | 生魂圣导师 | [生魂](https://mu.zhaouc.com/Guide/GameFeature/08_feature.html) |
| 539 | Doppelganger Summoner | 生魂召唤术师 | [生魂](https://mu.zhaouc.com/Guide/GameFeature/08_feature.html) |
| 540 | Lugard | 陆迦德 | [生魂](https://mu.zhaouc.com/Guide/GameFeature/08_feature.html) |
| 541 | Compensation Box | 奖励宝箱 | 暂译 |
| 542 | Golden Compensation Box | 黄金奖励宝箱 | 既有 |
| 543 | Gens Duprian | 多普瑞恩家族管家 | 暂译 |
| 544 | Gens Vanert | 巴内尔特家族管家 | 暂译 |
| 546 | Jeweler Raul | 宝石商人劳尔 | 暂译 |
| 547 | Market Union Member Julia | 市场传送师朱丽亚 | 暂译 |
| 549 | Bloody Orc | 血腥丛林生命体 | [派生:A13](https://mu.zhaouc.com/Guide/GameIntro/02_area13.html) |
| 550 | Bloody Death Rider | 血腥丛林暗杀者 | [派生:A13](https://mu.zhaouc.com/Guide/GameIntro/02_area13.html) |
| 551 | Bloody Golem | 血腥丛林残暴者 | [派生:A13](https://mu.zhaouc.com/Guide/GameIntro/02_area13.html) |
| 552 | Bloody Witch Queen | 血腥丛林女巫师 | [派生:A13](https://mu.zhaouc.com/Guide/GameIntro/02_area13.html) |
| 553 | Berserker Warrior | 疯魔战士 | [派生:A15](https://mu.zhaouc.com/Guide/GameIntro/02_area15.html) |
| 554 | Kentauros Warrior | 寒冰刺客战士 | [派生:A15](https://mu.zhaouc.com/Guide/GameIntro/02_area15.html) |
| 555 | Gigantis Warrior | 狂巨人战士 | [派生:A15](https://mu.zhaouc.com/Guide/GameIntro/02_area15.html) |
| 556 | Genocider Warrior | 屠杀者战士 | [派生:A15](https://mu.zhaouc.com/Guide/GameIntro/02_area15.html) |
| 557 | Sapi Queen | 树妖女王 | [派生:A17](https://mu.zhaouc.com/Guide/GameIntro/02_area17.html) |
| 558 | Ice Napin | 冰巨人 | 暂译 |
| 559 | Shadow Master | 暗影大师 | 既有 |
| 562 | Dark Mammoth | 黑暗冰之魔象 | [派生:A18](https://mu.zhaouc.com/Guide/GameIntro/02_area18.html) |
| 563 | Dark Giant | 黑暗冰之巨魔 | [派生:A18](https://mu.zhaouc.com/Guide/GameIntro/02_area18.html) |
| 564 | Dark Coolutin | 黑暗冰之魔蛛 | [派生:A18](https://mu.zhaouc.com/Guide/GameIntro/02_area18.html) |
| 565 | Dark Iron Knight | 黑暗冰铁剑魂 | [派生:A18](https://mu.zhaouc.com/Guide/GameIntro/02_area18.html) |
| 566 | Mercenary Guild Felicia | 佣兵公会菲莉西亚 | 暂译 |
| 568 | Wandering Merchant Zyro | 流浪商人杰罗 | 暂译 |
| 569 | Venomous Chain Scorpion | 剧毒勾尾蝎 | [A19](https://mu.zhaouc.com/Guide/GameIntro/02_area19.html) |
| 570 | Bone Scorpion | 白骨勾尾蝎 | [A19](https://mu.zhaouc.com/Guide/GameIntro/02_area19.html) |
| 571 | Orcus | 黑暗独角猿 | [A19](https://mu.zhaouc.com/Guide/GameIntro/02_area19.html) |
| 572 | Gollock | 黑暗四臂猿 | [A19](https://mu.zhaouc.com/Guide/GameIntro/02_area19.html) |
| 573 | Crypta | 金甲勇士 | [A19](https://mu.zhaouc.com/Guide/GameIntro/02_area19.html) |
| 574 | Crypos | 黄蜂女王 | [A19](https://mu.zhaouc.com/Guide/GameIntro/02_area19.html) |
| 575 | Condra | 幽灵石巨人 | [A19](https://mu.zhaouc.com/Guide/GameIntro/02_area19.html) |
| 576 | Narcondra | 邪灵石巨人 | [A19](https://mu.zhaouc.com/Guide/GameIntro/02_area19.html) |
| 579 | David | 戴彼得 | [幸运](https://mu.zhaouc.com/news/Update/214.html) |
| 658 | Cursed Statue | 诅咒雕像 | 既有 |
| 659 | Captured Stone Statue (1) | 已占领石像（1） | 暂译 |
| 660 | Captured Stone Statue (2) | 已占领石像（2） | 暂译 |
| 661 | Captured Stone Statue (3) | 已占领石像（3） | 暂译 |
| 662 | Captured Stone Statue (4) | 已占领石像（4） | 暂译 |
| 663 | Captured Stone Statue (5) | 已占领石像（5） | 暂译 |
| 664 | Captured Stone Statue (6) | 已占领石像（6） | 暂译 |
| 665 | Captured Stone Statue (7) | 已占领石像（7） | 暂译 |
| 666 | Captured Stone Statue (8) | 已占领石像（8） | 暂译 |
| 667 | Captured Stone Statue (9) | 已占领石像（9） | 暂译 |
| 668 | Captured Stone Statue (10) | 已占领石像（10） | 暂译 |
