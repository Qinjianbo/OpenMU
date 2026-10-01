# 简体中文物品名称

覆盖本地 Season 6 配置中的 677 条物品定义。仅更新 `ItemDefinition.Name` 的
`zh-CN` 翻译，保留英文、其他语言、编号、属性、掉落、合成和玩家持有物品。
按组别、编号和原始英文名精确匹配；已有自定义中文不会被覆盖。
新更新仅补充缺失翻译或替换英文副本，已有译文（包括旧译）保留。
同一配置按物品等级区分的名称保留分号及排列顺序。

## 部署

新初始化的 075、095d、Season 6 配置自动包含适用条目的翻译。
名称来源为 `Properties/ItemNames.resx` 和 `ItemNames.zh-CN.resx`，初始化时直接读取全部可用语言。
已有数据库可以在管理后台执行可选更新“补充物品名称翻译”。
旧的中文纠错插件及其安装记录保留；旧 SQL 脚本仅用于历史本地维护，不替代新资源更新。
更新可重复执行。自定义名称需要手工核对，不强行覆盖。
这是服务端配置名称；客户端自身的物品文本文件不会因此改变。

## 来源与限制

核对日期：2026-09-29。道具词典的数组索引是官网词条编号，
并非游戏物品编号；武器按攻击力、速度、掉落等级与职业对应。
防具按套装和部位对应。括号内属性、阶数为后台识别标签。
其中 69 条未查到可靠对应名称的条目明确标为暂译，
不能视为已经确认的官方名称。
官网存在旧版差异及笔误：统一使用简体“冻”和法“杖”；
Phantom 套装采用道具词典的“破灭”，旧 Season 4 页面也出现“破坏”。
大天使权杖、Frost Mace 等名称仍待客户端物品表进一步确认。

- [官方道具词典](https://mu.zhaouc.com/Guide/M_Guide/S_Dictionary/DefaultUnit.html)
- [武器数据](https://mu.zhaouc.com/Guide/M_Guide/S_Dictionary/js/item_attack.js)
- [防具数据](https://mu.zhaouc.com/Guide/M_Guide/S_Dictionary/js/item_defend.js)
- [翅膀、首饰、技能数据](https://mu.zhaouc.com/Guide/M_Guide/S_Dictionary/js/item_property.js)
- [其他道具数据](https://mu.zhaouc.com/Guide/M_Guide/S_Dictionary/js/item_other.js)
- [Season 4 镶宝系统](https://mu.zhaouc.com/player/event/season4/index_3.html)
- [Season 4 镶宝装备](https://mu.zhaouc.com/player/event/season4/index_2.html)
- [召唤术师职业资料](https://mu.zhaouc.com/Guide/GameIntro/01_character06.html)
- [格斗家职业资料](https://mu.zhaouc.com/Guide/GameIntro/01_character07.html)
- [圣导师职业资料](https://mu.zhaouc.com/Guide/GameIntro/01_character05.html)
- [坎特鲁遗址](https://mu.zhaouc.com/Guide/GameIntro/02_area16.html)
- [三转任务](https://mu.zhaouc.com/player/event/jzhysy/3zhuan.html)

- [魔法师职业资料](https://mu.zhaouc.com/Guide/GameIntro/01_character02.html)
- [弓箭手职业资料](https://mu.zhaouc.com/Guide/GameIntro/01_character03.html)
- [魔剑士职业资料](https://mu.zhaouc.com/Guide/GameIntro/01_character04.html)
- [第三代翅膀](https://mu.zhaouc.com/player/event/jzhysy/index.html)
- [Season 5 稀有道具](https://mu.zhaouc.com/01_news/updatecn/s5/s5_4.htm)

## 对照表

<!-- markdownlint-disable MD013 -->
| 组别/编号 | 原始名称 | 中文 | 依据或待核对说明 |
| --- | --- | --- | --- |
| 0/0 | Kris | 波刃剑 | 道具词典 attack #1 |
| 0/1 | Short Sword | 短剑 | 道具词典 attack #0 |
| 0/2 | Rapier | 西洋剑 | 道具词典 attack #2 |
| 0/3 | Katache | 东洋刀 | 道具词典 attack #4 |
| 0/4 | Sword of Assassin | 暗杀者 | 道具词典 attack #3 |
| 0/5 | Blade | 极光刀 | 道具词典 attack #9 |
| 0/6 | Gladius | 拉丁剑 | 道具词典 attack #5 |
| 0/7 | Falchion | 偃月刀 | 道具词典 attack #6 |
| 0/8 | Serpent Sword | 巨蛇魔剑 | 道具词典 attack #7 |
| 0/9 | Sword of Salamander | 背叛者 | 道具词典 attack #8 |
| 0/10 | Light Saber | 天行者 | 道具词典 attack #10 |
| 0/11 | Legendary Sword | 传说之剑 | 道具词典 attack #11 |
| 0/12 | Heliacal Sword | 太阳之剑 | 道具词典 attack #14 |
| 0/13 | Double Blade | 真红之剑 | 道具词典 attack #12 |
| 0/14 | Lighting Sword | 雷神之剑 | 道具词典 attack #15 |
| 0/15 | Giant Sword | 帝王之剑 | 道具词典 attack #13 |
| 0/16 | Sword of Destruction | 破坏之剑 | 道具词典 attack #17 |
| 0/17 | Dark Breaker | 屠龙刀 | 道具词典 attack #21 |
| 0/18 | Thunder Blade | 奔雷剑 | 道具词典 attack #22 |
| 0/19 | Divine Sword of Archangel | 大天使之剑 | 道具词典 attack #18 |
| 0/20 | Knight Blade | 断月之光 | 道具词典 attack #23 |
| 0/21 | Dark Reign Blade | 魔神剑 | 道具词典 attack #24 |
| 0/22 | Bone Blade | 龙骨巨晶剑 | 道具词典 attack #25 |
| 0/23 | Explosion Blade | 傲天魔剑 | 道具词典 attack #26 |
| 0/24 | Daybreak | 暴风锯齿 | 道具词典 attack #114 |
| 0/25 | Sword Dancer | 烈火巨刃 | 道具词典 attack #115 |
| 0/26 | Flamberge | 虚伪之剑 | 道具词典 attack #116 |
| 0/27 | Sword Breaker | 杀戮之剑 | 道具词典 attack #117 |
| 0/28 | Imperial Sword | 双子之剑 | 道具词典 attack #118 |
| 0/31 | Rune Blade | 天雷剑 | 道具词典 attack #20 |
| 0/32 | Sacred Glove | 神圣火焰拳刃 | 道具词典 attack #110 |
| 0/33 | Storm Hard Glove | 暴风毁灭拳刃 | 道具词典 attack #111 |
| 0/34 | Piercing Blade Glove | 刀锋拳刃 | 道具词典 attack #112 |
| 0/35 | Phoenix Soul Star | 凤魂之星 | 道具词典 attack #113 |
| 1/0 | Small Axe | 短斧 | 道具词典 attack #27 |
| 1/1 | Hand Axe | 手斧 | 道具词典 attack #28 |
| 1/2 | Double Axe | 双刃斧 | 道具词典 attack #29 |
| 1/3 | Tomahawk | 飞翔斧 | 道具词典 attack #30 |
| 1/4 | Elven Axe | 精灵之斧 | 道具词典 attack #31 |
| 1/5 | Battle Axe | 战士之斧 | 道具词典 attack #32 |
| 1/6 | Nikkea Axe | 斗士之斧 | 道具词典 attack #33 |
| 1/7 | Larkan Axe | 斗神之斧 | 道具词典 attack #34 |
| 1/8 | Crescent Axe | 末日之斧 | 道具词典 attack #35 |
| 2/0 | Mace | 石槌 | 道具词典 attack #37 |
| 2/1 | Morning Star | 流星槌 | 道具词典 attack #38 |
| 2/2 | Flail | 破坏之槌 | 道具词典 attack #39 |
| 2/3 | Great Hammer | 白金之槌 | 道具词典 attack #40 |
| 2/4 | Crystal Morning Star | 水晶流星 | 道具词典 attack #41 |
| 2/5 | Crystal Sword | 玄冰剑 | 道具词典 attack #16 |
| 2/6 | Chaos Dragon Axe | 玛雅龙斧 | 道具词典 attack #36 |
| 2/7 | Elemental Mace | 精灵之槌 | 道具词典 attack #42 |
| 2/8 | Battle Scepter | 战斗权杖 | 道具词典 attack #86 |
| 2/9 | Master Scepter | 征服权杖 | 道具词典 attack #87 |
| 2/10 | Great Scepter | 圣剑权杖 | 道具词典 attack #88 |
| 2/11 | Lord Scepter | 王者权杖 | 道具词典 attack #89 |
| 2/12 | Great Lord Scepter | 至尊权杖 | 道具词典 attack #90 |
| 2/13 | Divine Scepter of Archangel | 大天使之杖（圣导师） | 暂译：按英文名和适用职业；词典中的巨电权杖属性重合，待核对 |
| 2/14 | Soleil Scepter | 圣尊天使之杖 | 道具词典 attack #91 |
| 2/15 | Shining Scepter | 弹奏权杖 | 道具词典 attack #153 |
| 2/16 | Frost Mace | 寒冰之槌 | 暂译：尚未确认国服对应名称 |
| 2/17 | Absolute Scepter | 独裁权杖 | 道具词典 attack #154 |
| 2/18 | Stryker Scepter | 圣光权杖 | 道具词典 attack #155 |
| 3/0 | Light Spear | 黑武士 | 道具词典 attack #69 |
| 3/1 | Spear | 鹤嘴矛 | 道具词典 attack #66 |
| 3/2 | Dragon Lance | 战矛 | 道具词典 attack #64 |
| 3/3 | Giant Trident | 双鹤矛 | 道具词典 attack #67 |
| 3/4 | Serpent Spear | 巨蛇镰刀 | 道具词典 attack #70 |
| 3/5 | Double Poleaxe | 双刃矛 | 道具词典 attack #63 |
| 3/6 | Halberd | 斧刃矛 | 道具词典 attack #65 |
| 3/7 | Berdysh | 巴迪之矛 | 道具词典 attack #68 |
| 3/8 | Great Scythe | 帝王镰刀 | 道具词典 attack #71 |
| 3/9 | Bill of Balrog | 死神镰刀 | 道具词典 attack #72 |
| 3/10 | Dragon Spear | 青龙刀 | 道具词典 attack #109 |
| 3/11 | Beuroba | 铰刀 | 道具词典 attack #128 |
| 4/0 | Short Bow | 短弓 | 道具词典 attack #43 |
| 4/1 | Bow | 长弓 | 道具词典 attack #45 |
| 4/2 | Elven Bow | 精灵之弓 | 道具词典 attack #47 |
| 4/3 | Battle Bow | 巴特之弓 | 道具词典 attack #49 |
| 4/4 | Tiger Bow | 黄金之虎 | 道具词典 attack #51 |
| 4/5 | Silver Bow | 银翼之弓 | 道具词典 attack #53 |
| 4/6 | Chaos Nature Bow | 玛雅神弓 | 道具词典 attack #56 |
| 4/7 | Bolt | 弩箭 | 道具词典 other #24 |
| 4/8 | Crossbow | 石弩 | 道具词典 attack #44 |
| 4/9 | Golden Crossbow | 黄金石弩 | 道具词典 attack #46 |
| 4/10 | Arquebus | 火神弩 | 道具词典 attack #48 |
| 4/11 | Light Crossbow | 巨人弩 | 道具词典 attack #50 |
| 4/12 | Serpent Crossbow | 诱惑之弩 | 道具词典 attack #52 |
| 4/13 | Bluewing Crossbow | 蓝翎弩 | 道具词典 attack #54 |
| 4/14 | Aquagold Crossbow | 温蒂妮 | 道具词典 attack #55 |
| 4/15 | Arrows | 弓箭 | 道具词典 other #25 |
| 4/16 | Saint Crossbow | 圣者之弩 | 道具词典 attack #57 |
| 4/17 | Celestial Bow | 圣灵之弓 | 道具词典 attack #58 |
| 4/18 | Divine Crossbow of Archangel | 大天使之弓 | 道具词典 attack #59 |
| 4/19 | Great Reign Crossbow | 追月神弩 | 道具词典 attack #60 |
| 4/20 | Arrow Viper Bow | 红羽神弓 | 道具词典 attack #61 |
| 4/21 | Sylph Wind Bow | 紫焰之弓 | 道具词典 attack #62 |
| 4/22 | Albatross Bow | 神羽之弓 | 道具词典 attack #124 |
| 4/23 | Stinger Bow | 傲视魔弓 | 道具词典 attack #125 |
| 4/24 | Air Lyn Bow | 圣天使之弓 | 道具词典 attack #126 |
| 5/0 | Skull Staff | 骷髅杖 | 道具词典 attack #73 |
| 5/1 | Angelic Staff | 天使杖 | 道具词典 attack #74 |
| 5/2 | Serpent Staff | 毒蛇杖 | 道具词典 attack #75 |
| 5/3 | Thunder Staff | 闪电杖 | 道具词典 attack #76 |
| 5/4 | Gorgon Staff | 戈登之杖 | 道具词典 attack #77 |
| 5/5 | Legendary Staff | 传说之杖 | 道具词典 attack #78 |
| 5/6 | Staff of Resurrection | 复活之杖 | 道具词典 attack #79 |
| 5/7 | Chaos Lightning Staff | 玛雅雷杖 | 道具词典 attack #80 |
| 5/8 | Staff of Destruction | 毁灭之杖 | 道具词典 attack #81 |
| 5/9 | Dragon Soul Staff | 麒麟之杖 | 道具词典 attack #82 |
| 5/10 | Divine Staff of Archangel | 大天使之杖 | 道具词典 attack #83 |
| 5/11 | Staff of Kundun | 昆顿之杖 | 道具词典 attack #84 |
| 5/12 | Grand Viper Staff | 死神之杖 | 道具词典 attack #85 |
| 5/13 | Platina Staff | 幻月雷杖 | 道具词典 attack #136 |
| 5/14 | Mistery Stick | 迷之杖 | 道具词典 attack #137 |
| 5/15 | Violent Wind Stick | 飓风之杖 | 道具词典 attack #138 |
| 5/16 | Red Wing Stick | 红翼之杖 | 道具词典 attack #139 |
| 5/17 | Ancient Stick | 远古之杖 | 道具词典 attack #140 |
| 5/18 | Demonic Stick | 魔灵之杖 | 道具词典 attack #141 |
| 5/19 | Storm Blitz Stick | 风影之杖 | 道具词典 attack #142 |
| 5/20 | Eternal Wing Stick | 恒翼之杖 | 道具词典 attack #143 |
| 5/21 | Book of Sahamutt | 火龙兽之书 | 召唤术师职业资料 |
| 5/22 | Book of Neil | 异灵之书 | 召唤术师职业资料 |
| 5/23 | Book of Lagle | 污灵之书 | 召唤术师职业资料 |
| 5/30 | Deadly Staff | 致命魔杖 | 道具词典 attack #144 |
| 5/31 | Imperial Staff | 魔狱之杖 | 道具词典 attack #145 |
| 5/33 | Chromatic Staff | 多彩魔杖 | 道具词典 attack #147 |
| 5/34 | Raven Stick | 乌鸦之杖 | 道具词典 attack #148 |
| 5/36 | Divine Stick of Archangel | 大天使之杖（召唤术师） | 暂译：按英文名和适用职业；不与词典的绝对魔杖混同 |
| 6/0 | Small Shield | 圆盾 | 道具词典 attack #92 |
| 6/1 | Horn Shield | 战士之盾 | 道具词典 attack #94 |
| 6/2 | Kite Shield | 风之盾 | 道具词典 attack #95 |
| 6/3 | Elven Shield | 魔法之盾 | 道具词典 attack #98 |
| 6/4 | Buckler | 钢铁之盾 | 道具词典 attack #93 |
| 6/5 | Dragon Slayer Shield | 龙之盾 | 道具词典 attack #101 |
| 6/6 | Skull Shield | 骷髅之盾 | 道具词典 attack #96 |
| 6/7 | Spiked Shield | 尖刺之盾 | 道具词典 attack #100 |
| 6/8 | Tower Shield | 失落之盾 | 道具词典 attack #102 |
| 6/9 | Plate Shield | 远古之盾 | 道具词典 attack #99 |
| 6/10 | Big Round Shield | 自由之盾 | 道具词典 attack #97 |
| 6/11 | Serpent Shield | 毒蛇之盾 | 道具词典 attack #103 |
| 6/12 | Bronze Shield | 布朗司 | 道具词典 attack #105 |
| 6/13 | Dragon Shield | 火龙之盾 | 道具词典 attack #106 |
| 6/14 | Legendary Shield | 传说之盾 | 道具词典 attack #104 |
| 6/15 | Grand Soul Shield | 麒麟之盾 | 道具词典 attack #108 |
| 6/16 | Elemental Shield | 精灵之盾 | 道具词典 attack #107 |
| 6/17 | Crimson Glory | 荣誉之盾 | 道具词典 attack #157 |
| 6/18 | Salamander Shield | 火蛇之盾 | 道具词典 attack #158 |
| 6/19 | Frost Barrier | 寒冰之盾 | 道具词典 attack #159 |
| 6/20 | Guardian Shield | 亡魂之盾 | 道具词典 attack #160 |
| 6/21 | Cross Shield | 十字架之盾 | 道具词典 attack #161 |
| 7/0 | Bronze Helm | 青铜盔 | 道具词典 defend #3 |
| 7/1 | Dragon Helm | 龙王之盔 | 道具词典 defend #15 |
| 7/2 | Pad Helm | 革盔 | 道具词典 defend #0 |
| 7/3 | Legendary Helm | 传说之盔 | 道具词典 defend #13 |
| 7/4 | Bone Helm | 骷髅之盔 | 道具词典 defend #5 |
| 7/5 | Leather Helm | 皮盔 | 道具词典 defend #2 |
| 7/6 | Scale Helm | 翡翠盔 | 道具词典 defend #6 |
| 7/7 | Sphinx Mask | 魔王之盔 | 道具词典 defend #8 |
| 7/8 | Brass Helm | 黄金盔 | 道具词典 defend #9 |
| 7/9 | Plate Helm | 白金盔 | 道具词典 defend #11 |
| 7/10 | Vine Helm | 藤盔 | 道具词典 defend #1 |
| 7/11 | Silk Helm | 天蚕之盔 | 道具词典 defend #4 |
| 7/12 | Wind Helm | 风之盔 | 道具词典 defend #7 |
| 7/13 | Spirit Helm | 精灵之盔 | 道具词典 defend #10 |
| 7/14 | Guardian Helm | 女神之盔 | 道具词典 defend #14 |
| 7/16 | Black Dragon Helm | 黑龙王之盔 | 道具词典 defend #18 |
| 7/17 | Dark Phoenix Helm | 黑凤凰之盔 | 道具词典 defend #21 |
| 7/18 | Grand Soul Helm | 火麒麟之盔 | 道具词典 defend #17 |
| 7/19 | Divine Helm | 圣灵之盔 | 道具词典 defend #19 |
| 7/21 | Great Dragon Helm | 龙炎之盔 | 道具词典 defend #23 |
| 7/22 | Dark Soul Helm | 黑炎之盔 | 道具词典 defend #25 |
| 7/24 | Red Spirit Helm | 红羽之盔 | 道具词典 defend #22 |
| 7/25 | Light Plate Mask | 圣元之盔 | 道具词典 defend #12 |
| 7/26 | Adamantine Mask | 圣魂之盔 | 道具词典 defend #16 |
| 7/27 | Dark Steel Mask | 神圣之盔 | 道具词典 defend #20 |
| 7/28 | Dark Master Mask | 至尊之盔 | 道具词典 defend #24 |
| 7/29 | Dragon Knight Helm | 暗黑斗神之盔 | 道具词典 defend #29 |
| 7/30 | Venom Mist Helm | 法魂玄灵之盔 | 道具词典 defend #26 |
| 7/31 | Sylphid Ray Helm | 紫灵之盔 | 道具词典 defend #27 |
| 7/33 | Sunlight Mask | 宙斯之盔 | 道具词典 defend #28 |
| 7/34 | Ashcrow Helm | 暴风之盔 | 道具词典 defend #170 |
| 7/35 | Eclipse Helm | 幻月之盔 | 道具词典 defend #167 |
| 7/36 | Iris Helm | 碧影之盔 | 道具词典 defend #168 |
| 7/38 | Glorious Mask | 圣光之盔 | 道具词典 defend #169 |
| 7/39 | Mistery Helm | 飓风之盔 | 道具词典 defend #171 |
| 7/40 | Red Wing Helm | 红翼之盔 | 道具词典 defend #172 |
| 7/41 | Ancient Helm | 远古之盔 | 道具词典 defend #173 |
| 7/42 | Black Rose Helm | 魔灵之盔 | 道具词典 defend #174 |
| 7/43 | Aura Helm | 风影之盔 | 道具词典 defend #175 |
| 7/44 | Lilium Helm | 恒翼之盔 | 道具词典 defend #176 |
| 7/45 | Titan Helm | 泰坦之盔 | 道具词典 defend #177 |
| 7/46 | Brave Helm | 勇气之盔 | 道具词典 defend #178 |
| 7/49 | Seraphim Helm | 恐惧之盔 | 道具词典 defend #179 |
| 7/50 | Faith Helm | 灵光之盔 | 道具词典 defend #180 |
| 7/51 | Paewang Mask | 霸王之盔 | 道具词典 defend #181 |
| 7/52 | Hades Helm | 冥王之盔 | 道具词典 defend #182 |
| 7/59 | Sacred Helm | 神圣火焰之盔 | 道具词典 defend #190 |
| 7/60 | Storm Hard Helm | 暴风毁灭之盔 | 道具词典 defend #191 |
| 7/61 | Piercing Helm | 刀锋之盔 | 道具词典 defend #192 |
| 7/73 | Phoenix Soul Helmet | 凤魂之盔 | 道具词典 defend #193 |
| 8/0 | Bronze Armor | 青铜铠 | 道具词典 defend #33 |
| 8/1 | Dragon Armor | 龙王之铠 | 道具词典 defend #44 |
| 8/2 | Pad Armor | 革铠 | 道具词典 defend #31 |
| 8/3 | Legendary Armor | 传说之铠 | 道具词典 defend #42 |
| 8/4 | Bone Armor | 骷髅铠 | 道具词典 defend #35 |
| 8/5 | Leather Armor | 皮铠 | 道具词典 defend #30 |
| 8/6 | Scale Armor | 翡翠铠 | 道具词典 defend #36 |
| 8/7 | Sphinx Armor | 魔王铠 | 道具词典 defend #38 |
| 8/8 | Brass Armor | 黄金铠 | 道具词典 defend #39 |
| 8/9 | Plate Armor | 白金铠 | 道具词典 defend #41 |
| 8/10 | Vine Armor | 藤铠 | 道具词典 defend #32 |
| 8/11 | Silk Armor | 天蚕铠 | 道具词典 defend #34 |
| 8/12 | Wind Armor | 风之铠 | 道具词典 defend #37 |
| 8/13 | Spirit Armor | 精灵之铠 | 道具词典 defend #40 |
| 8/14 | Guardian Armor | 女神之铠 | 道具词典 defend #43 |
| 8/15 | Storm Crow Armor | 亚特兰蒂斯之铠 | 道具词典 defend #47 |
| 8/16 | Black Dragon Armor | 黑龙王铠 | 道具词典 defend #48 |
| 8/17 | Dark Phoenix Armor | 黑凤凰之铠 | 道具词典 defend #52 |
| 8/18 | Grand Soul Armor | 火麒麟之铠 | 道具词典 defend #49 |
| 8/19 | Divine Armor | 圣灵之铠 | 道具词典 defend #50 |
| 8/20 | Thunder Hawk Armor | 奔雷之铠 | 道具词典 defend #53 |
| 8/21 | Great Dragon Armor | 龙炎之铠 | 道具词典 defend #57 |
| 8/22 | Dark Soul Armor | 黑炎之铠 | 道具词典 defend #56 |
| 8/23 | Hurricane Armor | 魔神之铠 | 道具词典 defend #58 |
| 8/24 | Red Sprit Armor | 红羽之铠 | 道具词典 defend #54 |
| 8/25 | Light Plate Armor | 圣元之铠 | 道具词典 defend #45 |
| 8/26 | Adamantine Armor | 圣魂之铠 | 道具词典 defend #46 |
| 8/27 | Dark Steel Armor | 神圣之铠 | 道具词典 defend #51 |
| 8/28 | Dark Master Armor | 至尊之铠 | 道具词典 defend #55 |
| 8/29 | Dragon Knight Armor | 暗黑斗神之铠 | 道具词典 defend #59 |
| 8/30 | Venom Mist Armor | 法魂玄灵之铠 | 道具词典 defend #60 |
| 8/31 | Sylphid Ray Armor | 紫灵之铠 | 道具词典 defend #61 |
| 8/32 | Volcano Armor | 天魔斗神之铠 | 道具词典 defend #62 |
| 8/33 | Sunlight Armor | 宙斯之铠 | 道具词典 defend #63 |
| 8/34 | Ashcrow Armor | 暴风之铠 | 道具词典 defend #199 |
| 8/35 | Eclipse Armor | 幻月之铠 | 道具词典 defend #200 |
| 8/36 | Iris Armor | 碧影之铠 | 道具词典 defend #201 |
| 8/37 | Valiant Armor | 烈火之铠 | 道具词典 defend #202 |
| 8/38 | Glorious Armor | 圣光之铠 | 道具词典 defend #203 |
| 8/39 | Mistery Armor | 飓风之铠 | 道具词典 defend #204 |
| 8/40 | Red Wing Armor | 红翼之铠 | 道具词典 defend #206 |
| 8/41 | Ancient Armor | 远古之铠 | 道具词典 defend #205 |
| 8/42 | Black Rose Armor | 魔灵之铠 | 道具词典 defend #207 |
| 8/43 | Aura Armor | 风影之铠 | 道具词典 defend #208 |
| 8/44 | Lilium Armor | 恒翼之铠 | 道具词典 defend #209 |
| 8/45 | Titan Armor | 泰坦之铠 | 道具词典 defend #210 |
| 8/46 | Brave Armor | 勇气之铠 | 道具词典 defend #211 |
| 8/47 | Destory Armor | 巨石之铠 | 道具词典 defend #212 |
| 8/48 | Phantom Armor | 破灭之铠 | 道具词典 defend #213 |
| 8/49 | Seraphim Armor | 恐惧之铠 | 道具词典 defend #214 |
| 8/50 | Faith Armor | 灵光之铠 | 道具词典 defend #215 |
| 8/51 | Paewang Armor | 霸王之铠 | 道具词典 defend #216 |
| 8/52 | Hades Armor | 冥王之铠 | 道具词典 defend #217 |
| 8/59 | Sacred Armor | 神圣火焰之铠 | 道具词典 defend #224 |
| 8/60 | Storm Hard Armor | 暴风毁灭之铠 | 道具词典 defend #225 |
| 8/61 | Piercing Armor | 刀锋之铠 | 道具词典 defend #226 |
| 8/73 | Phoenix Soul Armor | 凤魂之铠 | 道具词典 defend #230 |
| 9/0 | Bronze Pants | 青铜护腿 | 道具词典 defend #101 |
| 9/1 | Dragon Pants | 龙王护腿 | 道具词典 defend #113 |
| 9/2 | Pad Pants | 革护腿 | 道具词典 defend #99 |
| 9/3 | Legendary Pants | 传说护腿 | 道具词典 defend #111 |
| 9/4 | Bone Pants | 骷髅护腿 | 道具词典 defend #103 |
| 9/5 | Leather Pants | 皮护腿 | 道具词典 defend #98 |
| 9/6 | Scale Pants | 翡翠护腿 | 道具词典 defend #104 |
| 9/7 | Sphinx Pants | 魔王护腿 | 道具词典 defend #106 |
| 9/8 | Brass Pants | 黄金护腿 | 道具词典 defend #107 |
| 9/9 | Plate Pants | 白金护腿 | 道具词典 defend #109 |
| 9/10 | Vine Pants | 藤护腿 | 道具词典 defend #100 |
| 9/11 | Silk Pants | 天蚕护腿 | 道具词典 defend #102 |
| 9/12 | Wind Pants | 风之护腿 | 道具词典 defend #105 |
| 9/13 | Spirit Pants | 精灵之护腿 | 道具词典 defend #108 |
| 9/14 | Guardian Pants | 女神护腿 | 道具词典 defend #112 |
| 9/15 | Storm Crow Pants | 亚特兰蒂斯之护腿 | 道具词典 defend #115 |
| 9/16 | Black Dragon Pants | 黑龙王护腿 | 道具词典 defend #116 |
| 9/17 | Dark Phoenix Pants | 黑凤凰护腿 | 道具词典 defend #120 |
| 9/18 | Grand Soul Pants | 火麒麟护腿 | 道具词典 defend #117 |
| 9/19 | Divine Pants | 圣灵护腿 | 道具词典 defend #118 |
| 9/20 | Thunder Hawk Pants | 奔雷护腿 | 道具词典 defend #121 |
| 9/21 | Great Dragon Pants | 龙炎护腿 | 道具词典 defend #124 |
| 9/22 | Dark Soul Pants | 黑炎护腿 | 道具词典 defend #125 |
| 9/23 | Hurricane Pants | 魔神护腿 | 道具词典 defend #126 |
| 9/24 | Red Spirit Pants | 红羽护腿 | 道具词典 defend #122 |
| 9/25 | Light Plate Pants | 圣元护腿 | 道具词典 defend #110 |
| 9/26 | Adamantine Pants | 圣魂护腿 | 道具词典 defend #114 |
| 9/27 | Dark Steel Pants | 神圣护腿 | 道具词典 defend #119 |
| 9/28 | Dark Master Pants | 至尊护腿 | 道具词典 defend #123 |
| 9/29 | Dragon Knight Pants | 暗黑斗神护腿 | 道具词典 defend #127 |
| 9/30 | Venom Mist Pants | 法魂玄灵护腿 | 道具词典 defend #128 |
| 9/31 | Sylphid Ray Pants | 紫灵护腿 | 道具词典 defend #129 |
| 9/32 | Volcano Pants | 天魔斗神护腿 | 道具词典 defend #130 |
| 9/33 | Sunlight Pants | 宙斯护腿 | 道具词典 defend #131 |
| 9/34 | Ashcrow Pants | 暴风护腿 | 道具词典 defend #269 |
| 9/35 | Eclipse Pants | 幻月护腿 | 道具词典 defend #270 |
| 9/36 | Iris Pants | 碧影护腿 | 道具词典 defend #271 |
| 9/37 | Valiant Pants | 烈火护腿 | 道具词典 defend #272 |
| 9/38 | Glorious Pants | 圣光护腿 | 道具词典 defend #273 |
| 9/39 | Mistery Pants | 飓风之护腿 | 道具词典 defend #274 |
| 9/40 | Red Wing Pants | 红翼之护腿 | 道具词典 defend #275 |
| 9/41 | Ancient Pants | 远古之护腿 | 道具词典 defend #276 |
| 9/42 | Black Rose Pants | 魔灵护腿 | 道具词典 defend #277 |
| 9/43 | Aura Pants | 风影护腿 | 道具词典 defend #278 |
| 9/44 | Lilium Pants | 恒翼护腿 | 道具词典 defend #279 |
| 9/45 | Titan Pants | 泰坦之护腿 | 道具词典 defend #280 |
| 9/46 | Brave Pants | 勇气之护腿 | 道具词典 defend #281 |
| 9/47 | Destory Pants | 巨石之护腿 | 道具词典 defend #282 |
| 9/48 | Phantom Pants | 破灭之护腿 | 道具词典 defend #283 |
| 9/49 | Seraphim Pants | 恐惧之护腿 | 道具词典 defend #284 |
| 9/50 | Faith Pants | 灵光之护腿 | 道具词典 defend #285 |
| 9/51 | Paewang Pants | 霸王之护腿 | 道具词典 defend #286 |
| 9/52 | Hades Pants | 冥王之护腿 | 道具词典 defend #287 |
| 9/59 | Sacred Pants | 神圣火焰护腿 | 道具词典 defend #288 |
| 9/60 | Storm Hard Pants | 暴风毁灭护腿 | 道具词典 defend #289 |
| 9/61 | Piercing Pants | 刀锋护腿 | 道具词典 defend #290 |
| 9/73 | Phoenix Soul Pants | 凤魂护腿 | 道具词典 defend #291 |
| 10/0 | Bronze Gloves | 青铜护手 | 道具词典 defend #67 |
| 10/1 | Dragon Gloves | 龙王护手 | 道具词典 defend #79 |
| 10/2 | Pad Gloves | 革护手 | 道具词典 defend #64 |
| 10/3 | Legendary Gloves | 传说护手 | 道具词典 defend #77 |
| 10/4 | Bone Gloves | 骷髅护手 | 道具词典 defend #69 |
| 10/5 | Leather Gloves | 皮护手 | 道具词典 defend #65 |
| 10/6 | Scale Gloves | 翡翠护手 | 道具词典 defend #70 |
| 10/7 | Sphinx Gloves | 魔王护手 | 道具词典 defend #72 |
| 10/8 | Brass Gloves | 黄金护手 | 道具词典 defend #73 |
| 10/9 | Plate Gloves | 白金护手 | 道具词典 defend #75 |
| 10/10 | Vine Gloves | 藤护手 | 道具词典 defend #66 |
| 10/11 | Silk Gloves | 天蚕护手 | 道具词典 defend #68 |
| 10/12 | Wind Gloves | 风之护手 | 道具词典 defend #71 |
| 10/13 | Spirit Gloves | 精灵之护手 | 道具词典 defend #74 |
| 10/14 | Guardian Gloves | 女神护手 | 道具词典 defend #78 |
| 10/15 | Storm Crow Gloves | 亚特兰蒂斯之护手 | 道具词典 defend #81 |
| 10/16 | Black Dragon Gloves | 黑龙王护手 | 道具词典 defend #85 |
| 10/17 | Dark Phoenix Gloves | 黑凤凰护手 | 道具词典 defend #87 |
| 10/18 | Grand Soul Gloves | 火麒麟护手 | 道具词典 defend #82 |
| 10/19 | Divine Gloves | 圣灵护手 | 道具词典 defend #83 |
| 10/20 | Thunder Hawk Gloves | 奔雷护手 | 道具词典 defend #89 |
| 10/21 | Great Dragon Gloves | 龙炎护手 | 道具词典 defend #91 |
| 10/22 | Dark Soul Gloves | 黑炎护手 | 道具词典 defend #88 |
| 10/23 | Hurricane Gloves | 魔神护手 | 道具词典 defend #92 |
| 10/24 | Red Spirit Gloves | 红羽护手 | 道具词典 defend #86 |
| 10/25 | Light Plate Gloves | 圣元护手 | 道具词典 defend #76 |
| 10/26 | Adamantine Gloves | 圣魂护手 | 道具词典 defend #80 |
| 10/27 | Dark Steel Gloves | 神圣护手 | 道具词典 defend #84 |
| 10/28 | Dark Master Gloves | 至尊护手 | 道具词典 defend #90 |
| 10/29 | Dragon Knight Gloves | 暗黑斗神护手 | 道具词典 defend #96 |
| 10/30 | Venom Mist Gloves | 法魂玄灵护手 | 道具词典 defend #94 |
| 10/31 | Sylphid Ray Gloves | 紫灵护手 | 道具词典 defend #95 |
| 10/32 | Volcano Gloves | 天魔斗神护手 | 道具词典 defend #97 |
| 10/33 | Sunlight Gloves | 宙斯护手 | 道具词典 defend #93 |
| 10/34 | Ashcrow Gloves | 暴风护手 | 道具词典 defend #236 |
| 10/35 | Eclipse Gloves | 幻月护手 | 道具词典 defend #237 |
| 10/36 | Iris Gloves | 碧影护手 | 道具词典 defend #238 |
| 10/37 | Valiant Gloves | 烈火护手 | 道具词典 defend #239 |
| 10/38 | Glorious Gloves | 圣光护手 | 道具词典 defend #240 |
| 10/39 | Mistery Gloves | 飓风之护手 | 道具词典 defend #241 |
| 10/40 | Red Wing Gloves | 红翼之护手 | 道具词典 defend #242 |
| 10/41 | Ancient Gloves | 远古之护手 | 道具词典 defend #243 |
| 10/42 | Black Rose Gloves | 魔灵之护手 | 道具词典 defend #244 |
| 10/43 | Aura Gloves | 风影护手 | 道具词典 defend #245 |
| 10/44 | Lilium Gloves | 恒翼护手 | 道具词典 defend #246 |
| 10/45 | Titan Gloves | 泰坦之护手 | 道具词典 defend #247 |
| 10/46 | Brave Gloves | 勇气之护手 | 道具词典 defend #248 |
| 10/47 | Destroy Gloves | 巨石之护手 | 道具词典 defend #249 |
| 10/48 | Phantom Gloves | 破灭之护手 | 道具词典 defend #250 |
| 10/49 | Seraphim Gloves | 恐惧之护手 | 道具词典 defend #251 |
| 10/50 | Faith Gloves | 灵光之护手 | 道具词典 defend #252 |
| 10/51 | Paewang Gloves | 霸王之护手 | 道具词典 defend #253 |
| 10/52 | Hades Gloves | 冥王之护手 | 道具词典 defend #254 |
| 11/0 | Bronze Boots | 青铜靴 | 道具词典 defend #135 |
| 11/1 | Dragon Boots | 龙王之靴 | 道具词典 defend #147 |
| 11/2 | Pad Boots | 革靴 | 道具词典 defend #132 |
| 11/3 | Legendary Boots | 传说之靴 | 道具词典 defend #145 |
| 11/4 | Bone Boots | 骷髅靴 | 道具词典 defend #137 |
| 11/5 | Leather Boots | 皮靴 | 道具词典 defend #134 |
| 11/6 | Scale Boots | 翡翠靴 | 道具词典 defend #138 |
| 11/7 | Sphinx Boots | 魔王靴 | 道具词典 defend #140 |
| 11/8 | Brass Boots | 黄金靴 | 道具词典 defend #141 |
| 11/9 | Plate Boots | 白金靴 | 道具词典 defend #143 |
| 11/10 | Vine Boots | 藤靴 | 道具词典 defend #133 |
| 11/11 | Silk Boots | 天蚕之靴 | 道具词典 defend #136 |
| 11/12 | Wind Boots | 风之靴 | 道具词典 defend #139 |
| 11/13 | Spirit Boots | 精灵之靴 | 道具词典 defend #142 |
| 11/14 | Guardian Boots | 女神之靴 | 道具词典 defend #146 |
| 11/15 | Storm Crow Boots | 亚特兰蒂斯之靴 | 道具词典 defend #149 |
| 11/16 | Black Dragon Boots | 黑龙王之靴 | 道具词典 defend #151 |
| 11/17 | Dark Phoenix Boots | 黑凤凰之靴 | 道具词典 defend #156 |
| 11/18 | Grand Soul Boots | 火麒麟靴 | 道具词典 defend #150 |
| 11/19 | Divine Boots | 圣灵之靴 | 道具词典 defend #152 |
| 11/20 | Thunder Hawk Boots | 奔雷之靴 | 道具词典 defend #155 |
| 11/21 | Great Dragon Boots | 龙炎之靴 | 道具词典 defend #159 |
| 11/22 | Dark Soul Boots | 黑炎之靴 | 道具词典 defend #157 |
| 11/23 | Hurricane Boots | 魔神之靴 | 道具词典 defend #160 |
| 11/24 | Red Spirit Boots | 红羽之靴 | 道具词典 defend #154 |
| 11/25 | Light Plate Boots | 圣元之靴 | 道具词典 defend #144 |
| 11/26 | Adamantine Boots | 圣魂之靴 | 道具词典 defend #148 |
| 11/27 | Dark Steel Boots | 神圣之靴 | 道具词典 defend #153 |
| 11/28 | Dark Master Boots | 至尊之靴 | 道具词典 defend #158 |
| 11/29 | Dragon Knight Boots | 暗黑斗神之靴 | 道具词典 defend #161 |
| 11/30 | Venom Mist Boots | 法魂玄灵之靴 | 道具词典 defend #162 |
| 11/31 | Sylphid Ray Boots | 紫灵之靴 | 道具词典 defend #163 |
| 11/32 | Volcano Boots | 天魔斗神之靴 | 道具词典 defend #165 |
| 11/33 | Sunlight Boots | 宙斯之靴 | 道具词典 defend #164 |
| 11/34 | Ashcrow Boots | 暴风之靴 | 道具词典 defend #306 |
| 11/35 | Eclipse Boots | 幻月之靴 | 道具词典 defend #307 |
| 11/36 | Iris Boots | 碧影之靴 | 道具词典 defend #308 |
| 11/37 | Valiant Boots | 烈火之靴 | 道具词典 defend #309 |
| 11/38 | Glorious Boots | 圣光之靴 | 道具词典 defend #310 |
| 11/39 | Mistery Boots | 飓风之靴 | 道具词典 defend #311 |
| 11/40 | Red Wing Boots | 红翼之靴 | 道具词典 defend #312 |
| 11/41 | Ancient Boots | 远古之靴 | 道具词典 defend #313 |
| 11/42 | Black Rose Boots | 魔灵之靴 | 道具词典 defend #314 |
| 11/43 | Aura Boots | 风影之靴 | 道具词典 defend #315 |
| 11/44 | Lilium Boots | 恒翼之靴 | 道具词典 defend #316 |
| 11/45 | Titan Boots | 泰坦之靴 | 道具词典 defend #317 |
| 11/46 | Brave Boots | 勇气之靴 | 道具词典 defend #318 |
| 11/47 | Destory Boots | 巨石之靴 | 道具词典 defend #319 |
| 11/48 | Phantom Boots | 破灭之靴 | 道具词典 defend #320 |
| 11/49 | Seraphim Boots | 恐惧之靴 | 道具词典 defend #321 |
| 11/50 | Faith Boots | 灵光之靴 | 道具词典 defend #322 |
| 11/51 | Phaewang Boots | 霸王之靴 | 道具词典 defend #323 |
| 11/52 | Hades Boots | 冥王之靴 | 道具词典 defend #324 |
| 11/59 | Sacred Boots | 神圣火焰之靴 | 道具词典 defend #331 |
| 11/60 | Storm Hard Boots | 暴风毁灭之靴 | 道具词典 defend #332 |
| 11/61 | Piercing Boots | 刀锋之靴 | 道具词典 defend #333 |
| 11/73 | Phoenix Soul Boots | 凤魂之靴 | 道具词典 defend #334 |
| 12/0 | Wings of Elf | 精灵翅膀 | 道具词典 property #7 |
| 12/1 | Wings of Heaven | 天使翅膀 | 道具词典 property #5 |
| 12/2 | Wings of Satan | 恶魔翅膀 | 道具词典 property #6 |
| 12/3 | Wings of Spirits | 圣灵之翼 | 道具词典 property #2 |
| 12/4 | Wings of Soul | 魔魂之翼 | 道具词典 property #0 |
| 12/5 | Wings of Dragon | 飞龙之翼 | 道具词典 property #1 |
| 12/6 | Wings of Darkness | 暗黑之翼 | 道具词典 property #3 |
| 12/7 | Orb of Twisting Slash | 玄月斩之石 | 道具词典 property #39 |
| 12/8 | Orb of Healing | 治疗之石 | 道具词典 property #30 |
| 12/9 | Orb of Greater Defense | 防御之石 | 道具词典 property #32 |
| 12/10 | Orb of Greater Damage | 攻击之石 | 道具词典 property #34 |
| 12/11 | Orb of Summoning | 召唤魔石 | 暂译：技能及活动道具，待核对国服物品全名 |
| 12/12 | Orb of Rageful Blow | 霹雳回旋斩之石 | 道具词典 property #60 |
| 12/13 | Orb of Impale | 钻云枪之石 | 道具词典 property #59 |
| 12/14 | Orb of Greater Fortitude | 生命之光之石 | 道具词典 property #61 |
| 12/15 | Jewel of Chaos | 玛雅宝石 | 保留已校正的宝石及组合名称 |
| 12/16 | Orb of Fire Slash | 天雷闪之石 | 暂译：技能及活动道具，待核对国服物品全名 |
| 12/17 | Orb of Penetration | 穿透箭之石 | 道具词典 property #63 |
| 12/18 | Orb of Ice Arrow | 冰封箭之石 | 弓箭手职业资料 |
| 12/19 | Orb of Death Stab | 袭风刺之石 | 道具词典 property #62 |
| 12/21 | Scroll of FireBurst | 星云火链卷轴 | 圣导师职业资料 |
| 12/22 | Scroll of Summon | 星云召唤卷轴 | 圣导师职业资料 |
| 12/23 | Scroll of Critical Damage | 致命圣印卷轴 | 圣导师职业资料 |
| 12/24 | Scroll of Electric Spark | 圣极光卷轴 | 圣导师职业资料 |
| 12/30 | Packed Jewel of Bless | 祝福宝石组合 | 保留已校正的宝石及组合名称 |
| 12/31 | Packed Jewel of Soul | 灵魂宝石组合 | 保留已校正的宝石及组合名称 |
| 12/32 | Red Ribbon Box | 红色缎带宝箱 | 暂译：技能及活动道具，待核对国服物品全名 |
| 12/33 | Green Ribbon Box | 绿色缎带宝箱 | 暂译：技能及活动道具，待核对国服物品全名 |
| 12/34 | Blue Ribbon Box | 蓝色缎带宝箱 | 暂译：技能及活动道具，待核对国服物品全名 |
| 12/35 | Scroll of Fire Scream | 火舞旋风卷轴 | 圣导师职业资料 |
| 12/36 | Wing of Storm | 暴风之翼 | 道具词典 property #79 |
| 12/37 | Wing of Eternal | 时空之翼 | 道具词典 property #78 |
| 12/38 | Wing of Illusion | 幻影之翼 | 道具词典 property #76 |
| 12/39 | Wing of Ruin | 破灭之翼 | 道具词典 property #77 |
| 12/40 | Cape of Emperor | 帝王披风 | 道具词典 property #75 |
| 12/41 | Wings of Curse | 灾难之翼 | 道具词典 property #74 |
| 12/42 | Wings of Despair | 绝望之翼 | 道具词典 property #73 |
| 12/43 | Wing of Dimension | 次元之翼 | 道具词典 property #72 |
| 12/44 | Crystal of Destruction | 破坏一击之石 | 暂译：技能及活动道具，待核对国服物品全名 |
| 12/45 | Crystal of Multi-Shot | 五重箭之石 | 弓箭手职业资料 |
| 12/46 | Crystal of Recovery | 防护值恢复之石 | 弓箭手职业资料 |
| 12/47 | Crystal of Flame Strike | 火剑袭之石 | 魔剑士职业资料 |
| 12/48 | Scroll of Chaotic Diseier | 黑暗之力卷轴 | 圣导师职业资料 |
| 12/49 | Cape of Fighter | 武者披风 | 道具词典 property #71 |
| 12/50 | Cape of Overrule | 斗皇披风 | 道具词典 property #70 |
| 12/60 | Seed (Fire) | 荧之石（火） | Season 4 镶宝系统；括号属性为后台区分标签 |
| 12/61 | Seed (Water) | 荧之石（水） | Season 4 镶宝系统；括号属性为后台区分标签 |
| 12/62 | Seed (Ice) | 荧之石（冰） | Season 4 镶宝系统；括号属性为后台区分标签 |
| 12/63 | Seed (Wind) | 荧之石（风） | Season 4 镶宝系统；括号属性为后台区分标签 |
| 12/64 | Seed (Lightning) | 荧之石（雷） | Season 4 镶宝系统；括号属性为后台区分标签 |
| 12/65 | Seed (Earth) | 荧之石（土） | Season 4 镶宝系统；括号属性为后台区分标签 |
| 12/70 | Sphere (Mono) | 光之石（1阶） | Season 4 镶宝系统；括号阶数为后台区分标签 |
| 12/71 | Sphere (Di) | 光之石（2阶） | Season 4 镶宝系统；括号阶数为后台区分标签 |
| 12/72 | Sphere (Tri) | 光之石（3阶） | Season 4 镶宝系统；括号阶数为后台区分标签 |
| 12/73 | Sphere (4) | 光之石（4阶） | Season 4 镶宝系统；括号阶数为后台区分标签 |
| 12/74 | Sphere (5) | 光之石（5阶） | Season 4 镶宝系统；括号阶数为后台区分标签 |
| 12/100 | Seed Sphere (Fire) (1) | 荧光宝石（火，1阶） | Season 4 镶宝系统；括号属性与阶数为后台区分标签 |
| 12/101 | Seed Sphere (Water) (1) | 荧光宝石（水，1阶） | Season 4 镶宝系统；括号属性与阶数为后台区分标签 |
| 12/102 | Seed Sphere (Ice) (1) | 荧光宝石（冰，1阶） | Season 4 镶宝系统；括号属性与阶数为后台区分标签 |
| 12/103 | Seed Sphere (Wind) (1) | 荧光宝石（风，1阶） | Season 4 镶宝系统；括号属性与阶数为后台区分标签 |
| 12/104 | Seed Sphere (Lightning) (1) | 荧光宝石（雷，1阶） | Season 4 镶宝系统；括号属性与阶数为后台区分标签 |
| 12/105 | Seed Sphere (Earth) (1) | 荧光宝石（土，1阶） | Season 4 镶宝系统；括号属性与阶数为后台区分标签 |
| 12/106 | Seed Sphere (Fire) (2) | 荧光宝石（火，2阶） | Season 4 镶宝系统；括号属性与阶数为后台区分标签 |
| 12/107 | Seed Sphere (Water) (2) | 荧光宝石（水，2阶） | Season 4 镶宝系统；括号属性与阶数为后台区分标签 |
| 12/108 | Seed Sphere (Ice) (2) | 荧光宝石（冰，2阶） | Season 4 镶宝系统；括号属性与阶数为后台区分标签 |
| 12/109 | Seed Sphere (Wind) (2) | 荧光宝石（风，2阶） | Season 4 镶宝系统；括号属性与阶数为后台区分标签 |
| 12/110 | Seed Sphere (Lightning) (2) | 荧光宝石（雷，2阶） | Season 4 镶宝系统；括号属性与阶数为后台区分标签 |
| 12/111 | Seed Sphere (Earth) (2) | 荧光宝石（土，2阶） | Season 4 镶宝系统；括号属性与阶数为后台区分标签 |
| 12/112 | Seed Sphere (Fire) (3) | 荧光宝石（火，3阶） | Season 4 镶宝系统；括号属性与阶数为后台区分标签 |
| 12/113 | Seed Sphere (Water) (3) | 荧光宝石（水，3阶） | Season 4 镶宝系统；括号属性与阶数为后台区分标签 |
| 12/114 | Seed Sphere (Ice) (3) | 荧光宝石（冰，3阶） | Season 4 镶宝系统；括号属性与阶数为后台区分标签 |
| 12/115 | Seed Sphere (Wind) (3) | 荧光宝石（风，3阶） | Season 4 镶宝系统；括号属性与阶数为后台区分标签 |
| 12/116 | Seed Sphere (Lightning) (3) | 荧光宝石（雷，3阶） | Season 4 镶宝系统；括号属性与阶数为后台区分标签 |
| 12/117 | Seed Sphere (Earth) (3) | 荧光宝石（土，3阶） | Season 4 镶宝系统；括号属性与阶数为后台区分标签 |
| 12/118 | Seed Sphere (Fire) (4) | 荧光宝石（火，4阶） | Season 4 镶宝系统；括号属性与阶数为后台区分标签 |
| 12/119 | Seed Sphere (Water) (4) | 荧光宝石（水，4阶） | Season 4 镶宝系统；括号属性与阶数为后台区分标签 |
| 12/120 | Seed Sphere (Ice) (4) | 荧光宝石（冰，4阶） | Season 4 镶宝系统；括号属性与阶数为后台区分标签 |
| 12/121 | Seed Sphere (Wind) (4) | 荧光宝石（风，4阶） | Season 4 镶宝系统；括号属性与阶数为后台区分标签 |
| 12/122 | Seed Sphere (Lightning) (4) | 荧光宝石（雷，4阶） | Season 4 镶宝系统；括号属性与阶数为后台区分标签 |
| 12/123 | Seed Sphere (Earth) (4) | 荧光宝石（土，4阶） | Season 4 镶宝系统；括号属性与阶数为后台区分标签 |
| 12/124 | Seed Sphere (Fire) (5) | 荧光宝石（火，5阶） | Season 4 镶宝系统；括号属性与阶数为后台区分标签 |
| 12/125 | Seed Sphere (Water) (5) | 荧光宝石（水，5阶） | Season 4 镶宝系统；括号属性与阶数为后台区分标签 |
| 12/126 | Seed Sphere (Ice) (5) | 荧光宝石（冰，5阶） | Season 4 镶宝系统；括号属性与阶数为后台区分标签 |
| 12/127 | Seed Sphere (Wind) (5) | 荧光宝石（风，5阶） | Season 4 镶宝系统；括号属性与阶数为后台区分标签 |
| 12/128 | Seed Sphere (Lightning) (5) | 荧光宝石（雷，5阶） | Season 4 镶宝系统；括号属性与阶数为后台区分标签 |
| 12/129 | Seed Sphere (Earth) (5) | 荧光宝石（土，5阶） | Season 4 镶宝系统；括号属性与阶数为后台区分标签 |
| 12/136 | Packed Jewel of Life | 生命宝石组合 | 保留已校正的宝石及组合名称 |
| 12/137 | Packed Jewel of Creation | 创造宝石组合 | 保留已校正的宝石及组合名称 |
| 12/138 | Packed Jewel of Guardian | 守护宝石组合 | 保留已校正的宝石及组合名称 |
| 12/139 | Packed Gemstone | 再生原石组合 | 保留已校正的宝石及组合名称 |
| 12/140 | Packed Jewel of Harmony | 再生宝石组合 | 保留已校正的宝石及组合名称 |
| 12/141 | Packed Jewel of Chaos | 玛雅宝石组合 | 保留已校正的宝石及组合名称 |
| 12/142 | Packed Lower refine stone | 低级进化宝石组合 | 保留已校正的宝石及组合名称 |
| 12/143 | Packed Higher refine stone | 高级进化宝石组合 | 保留已校正的宝石及组合名称 |
| 13/0 | Guardian Angel | 守护天使 | 道具词典 other #37 |
| 13/1 | Imp | 小恶魔 | 道具词典 other #39 |
| 13/2 | Horn of Uniria | 兽角 | 道具词典 other #38 |
| 13/3 | Horn of Dinorant | 彩云兽 | 道具词典 other #41 |
| 13/4 | Dark Horse | 黑王马 | 道具词典 property #66 |
| 13/5 | Dark Raven | 天鹰 | 道具词典 property #65 |
| 13/8 | Ring of Ice | 冰之指环 | 道具词典 property #13 |
| 13/9 | Ring of Poison | 毒之指环 | 道具词典 property #9 |
| 13/10 | Transformation Ring | 变身指环 | 暂译/通用名称；参见词典具体覆盖项 |
| 13/11 | Life Stone | 生命之石 | 暂译/通用名称；参见词典具体覆盖项 |
| 13/12 | Pendant of Lighting | 雷之项链 | 道具词典 property #14 |
| 13/13 | Pendant of Fire | 火之项链 | 道具词典 property #8 |
| 13/14 | Loch's Feather | 洛克之羽 | 道具词典 other #40 |
| 13/15 | Fruits | 果实 | 暂译/通用名称；参见词典具体覆盖项 |
| 13/16 | Scroll of Archangel | 血灵之书 | 暂译/通用名称；参见词典具体覆盖项 |
| 13/17 | Blood Bone | 血灵之骷 | 暂译/通用名称；参见词典具体覆盖项 |
| 13/18 | Invisibility Cloak | 透明披风 | 暂译/通用名称；参见词典具体覆盖项 |
| 13/19 | Weapon of Archangel | 大天使武器 | 暂译/通用名称；参见词典具体覆盖项 |
| 13/20 | Wizard's Ring | 战士指环 | 道具词典 property #27 |
| 13/21 | Ring of Fire | 火之指环 | 道具词典 property #15 |
| 13/22 | Ring of Earth | 地之指环 | 道具词典 property #17 |
| 13/23 | Ring of Wind | 风之指环 | 道具词典 property #20 |
| 13/24 | Ring of Magic | 魔法戒指 | 道具词典 property #22 |
| 13/25 | Pendant of Ice | 冰之项链 | 道具词典 property #16 |
| 13/26 | Pendant of Wind | 风之项链 | 道具词典 property #19 |
| 13/27 | Pendant of Water | 水之项链 | 道具词典 property #21 |
| 13/28 | Pendant of Ability | 紫晶项链 | 道具词典 property #26 |
| 13/29 | Armor of Guardsman | 卫兵铠甲 | 暂译/通用名称；参见词典具体覆盖项 |
| 13/30 | Cape of Lord | 王者披风 | 道具词典 property #4 |
| 13/31 | Spirit | 宠物灵魂 | 暂译/通用名称；参见词典具体覆盖项 |
| 13/32 | Splinter of Armor | 破烂的铠甲片 | 道具词典 other #31 |
| 13/33 | Bless of Guardian | 女神的智慧 | 道具词典 other #32 |
| 13/34 | Claw of Beast | 猛兽的脚甲 | 道具词典 other #33 |
| 13/35 | Fragment of Horn | 碎角片 | 道具词典 other #34 |
| 13/36 | Broken Horn | 折断的角 | 道具词典 other #35 |
| 13/37 | Horn of Fenrir | 炎狼兽的角 | 道具词典 other #36 |
| 13/38 | Moonstone Pendant | 悬石 | 官方坎特鲁遗址地图资料 |
| 13/39 | Elite Skeleton Transformation Ring | 骷髅战士变身指环 | 暂译：活动/特殊道具，待核对国服物品全名 |
| 13/40 | Jack O'lantern Transformation Ring | 南瓜变身指环 | 暂译：活动/特殊道具，待核对国服物品全名 |
| 13/41 | Christmas Transformation Ring | 圣诞变身指环 | 暂译：活动/特殊道具，待核对国服物品全名 |
| 13/42 | Game Master Transformation Ring | 管理员变身指环 | 暂译：活动/特殊道具，待核对国服物品全名 |
| 13/49 | Old Scroll | 旧卷轴 | 暂译：活动/特殊道具，待核对国服物品全名 |
| 13/50 | Illusion Sorcerer Covenant | 幻影教主的血书 | 暂译：活动/特殊道具，待核对国服物品全名 |
| 13/51 | Scroll of Blood | 血的卷轴 | 暂译：活动/特殊道具，待核对国服物品全名 |
| 13/52 | Flame of Condor | 神鹰火种 | 官方第三代翅膀资料 |
| 13/53 | Feather of Condor | 神鹰之羽 | 官方第三代翅膀资料 |
| 13/64 | Demon | 恶魔 | 暂译：活动/特殊道具，待核对国服物品全名 |
| 13/65 | Spirit of Guardian | 守护精灵 | 暂译：活动/特殊道具，待核对国服物品全名 |
| 13/67 | Pet Rudolf | 鲁道夫 | 暂译：活动/特殊道具，待核对国服物品全名 |
| 13/68 | Snowman Transformation Ring | 雪人变身指环 | 暂译：活动/特殊道具，待核对国服物品全名 |
| 13/76 | Panda Transformation Ring | 熊猫变身指环 | 暂译：活动/特殊道具，待核对国服物品全名 |
| 13/80 | Pet Panda | 熊猫 | 暂译：活动/特殊道具，待核对国服物品全名 |
| 13/106 | Pet Unicorn | 独角兽 | 官方 Season 5 稀有道具资料 |
| 13/122 | Skeleton Transformation Ring | 骨架变身指环 | 官方 Season 5 稀有道具资料 |
| 13/123 | Pet Skeleton | 幼龙骨架 | 官方 Season 5 稀有道具资料 |
| 14/0 | Apple | 苹果 | 道具词典 other #14 |
| 14/1 | Small Healing Potion | 小瓶治疗药水 | 道具词典 other #15 |
| 14/2 | Medium Healing Potion | 中瓶治疗药水 | 道具词典 other #16 |
| 14/3 | Large Healing Potion | 大瓶治疗药水 | 道具词典 other #17 |
| 14/4 | Small Mana Potion | 小瓶魔力药水 | 道具词典 other #18 |
| 14/5 | Medium Mana Potion | 中瓶魔力药水 | 道具词典 other #19 |
| 14/6 | Large Mana Potion | 大瓶魔力药水 | 道具词典 other #20 |
| 14/7 | Potion of Bless;Potion of Soul | 祝福药水;灵魂药水 | 道具词典 other；保持原有分号与顺序 |
| 14/8 | Antidote | 解毒剂 | 道具词典 other #21 |
| 14/9 | Ale | 酒 | 道具词典 other #22 |
| 14/10 | Town Portal Scroll | 回城卷轴 | 道具词典 other #23 |
| 14/11 | Box of Luck | 幸运宝箱 | 道具词典 other #42 |
| 14/13 | Jewel of Bless | 祝福宝石 | 保留已校正的宝石及组合名称 |
| 14/14 | Jewel of Soul | 灵魂宝石 | 保留已校正的宝石及组合名称 |
| 14/16 | Jewel of Life | 生命宝石 | 保留已校正的宝石及组合名称 |
| 14/17 | Devil's Eye | 恶魔之眼 | 暂译：活动/任务道具，待核对国服物品全名 |
| 14/18 | Devil's Key | 恶魔之钥 | 暂译：活动/任务道具，待核对国服物品全名 |
| 14/19 | Devil's Invitation | 恶魔广场通行证 | 暂译：活动/任务道具，待核对国服物品全名 |
| 14/21 | Rena | 蕾娜 | 暂译：活动/任务道具，待核对国服物品全名 |
| 14/22 | Jewel of Creation | 创造宝石 | 保留已校正的宝石及组合名称 |
| 14/23 | Scroll of Emperor;Ring of Honor | 帝王之书;荣誉戒指 | 道具词典 other；保持原有分号与顺序 |
| 14/24 | Broken Sword;Dark Stone | 断魂之剑;暗黑之石 | 道具词典 other；保持原有分号与顺序 |
| 14/25 | Tear of Elf | 精灵之泪 | 道具词典 other #44 |
| 14/26 | Soul Shard of Wizard | 先知之魂 | 道具词典 other #46 |
| 14/28 | Lost Map | 失落地图 | 道具词典 other #28 |
| 14/29 | Symbol of Kundun | 昆顿印记 | 道具词典 other #27 |
| 14/31 | Jewel of Guardian | 守护宝石 | 保留已校正的宝石及组合名称 |
| 14/32 | Pink Chocolate Box | 粉色巧克力盒 | 暂译：活动/任务道具，待核对国服物品全名 |
| 14/33 | Red Chocolate Box | 红色巧克力盒 | 暂译：活动/任务道具，待核对国服物品全名 |
| 14/34 | Blue Chocolate Box | 蓝色巧克力盒 | 暂译：活动/任务道具，待核对国服物品全名 |
| 14/35 | Small Shield Potion | 小瓶护盾药水 | 暂译：活动/任务道具，待核对国服物品全名 |
| 14/36 | Medium Shield Potion | 中瓶护盾药水 | 暂译：活动/任务道具，待核对国服物品全名 |
| 14/37 | Large Shield Potion | 大瓶护盾药水 | 暂译：活动/任务道具，待核对国服物品全名 |
| 14/38 | Small Complex Potion | 小瓶复合药水 | 暂译：活动/任务道具，待核对国服物品全名 |
| 14/39 | Medium Complex Potion | 中瓶复合药水 | 暂译：活动/任务道具，待核对国服物品全名 |
| 14/40 | Large Complex Potion | 大瓶复合药水 | 暂译：活动/任务道具，待核对国服物品全名 |
| 14/41 | Gemstone | 再生原石 | 保留已校正的宝石及组合名称 |
| 14/42 | Jewel of Harmony | 再生宝石 | 保留已校正的宝石及组合名称 |
| 14/43 | Lower refine stone | 低级进化宝石 | 保留已校正的宝石及组合名称 |
| 14/44 | Higher refine stone | 高级进化宝石 | 保留已校正的宝石及组合名称 |
| 14/45 | Pumpkin of Luck | 幸运南瓜 | 暂译：活动/任务道具，待核对国服物品全名 |
| 14/46 | Jack O'Lantern Blessings | 南瓜祝福 | 暂译：活动/任务道具，待核对国服物品全名 |
| 14/47 | Jack O'Lantern Wrath | 南瓜愤怒 | 暂译：活动/任务道具，待核对国服物品全名 |
| 14/48 | Jack O'Lantern Cry | 南瓜哭泣 | 暂译：活动/任务道具，待核对国服物品全名 |
| 14/49 | Jack O'Lantern Food | 南瓜食物 | 暂译：活动/任务道具，待核对国服物品全名 |
| 14/50 | Jack O'Lantern Drink | 南瓜饮料 | 暂译：活动/任务道具，待核对国服物品全名 |
| 14/51 | Christmas Star | 圣诞之星 | 暂译：活动/任务道具，待核对国服物品全名 |
| 14/52 | GM Gift | 管理员礼物 | 暂译：活动/任务道具，待核对国服物品全名 |
| 14/63 | Firecracker | 烟花 | 暂译：活动/任务道具，待核对国服物品全名 |
| 14/65 | Flame of Death Beam Knight | 天魔菲尼斯的火种 | 官方三转任务资料 |
| 14/66 | Horn of Hell Maine | 炽炎魔的角 | 官方三转任务资料 |
| 14/67 | Feather of Dark Phoenix | 丛林召唤者的羽毛 | 官方三转任务资料 |
| 14/68 | Eye of Abyssal | 深渊之眼 | 暂译：活动/任务道具，待核对国服物品全名 |
| 14/84 | Cherry Blossom Play-Box | 樱花礼盒 | 暂译：活动/任务道具，待核对国服物品全名 |
| 14/85 | Cherry Blossom Wine | 樱花酒 | 暂译：活动/任务道具，待核对国服物品全名 |
| 14/86 | Cherry Blossom Rice Cake | 樱花年糕 | 暂译：活动/任务道具，待核对国服物品全名 |
| 14/87 | Cherry Blossom Flower Petal | 樱花花瓣 | 暂译：活动/任务道具，待核对国服物品全名 |
| 14/90 | Golden Cherry Blossom Branch | 金色樱花树枝 | 暂译：活动/任务道具，待核对国服物品全名 |
| 14/99 | Christmas Firecracker | 圣诞烟花 | 暂译：活动/任务道具，待核对国服物品全名 |
| 14/101 | Suspicious Scrap of Paper | 可疑的纸片 | 暂译：活动/任务道具，待核对国服物品全名 |
| 14/102 | Gaion's Order | 凯文的指令 | 暂译：活动/任务道具，待核对国服物品全名 |
| 14/103 | First Secromicon Fragment | 第一块西克罗米昆碎片 | 暂译：活动/任务道具，待核对国服物品全名 |
| 14/104 | Second Secromicon Fragment | 第二块西克罗米昆碎片 | 暂译：活动/任务道具，待核对国服物品全名 |
| 14/105 | Third Secromicon Fragment | 第三块西克罗米昆碎片 | 暂译：活动/任务道具，待核对国服物品全名 |
| 14/106 | Fourth Secromicon Fragment | 第四块西克罗米昆碎片 | 暂译：活动/任务道具，待核对国服物品全名 |
| 14/107 | Fifth Secromicon Fragment | 第五块西克罗米昆碎片 | 暂译：活动/任务道具，待核对国服物品全名 |
| 14/108 | Sixth Secromicon Fragment | 第六块西克罗米昆碎片 | 暂译：活动/任务道具，待核对国服物品全名 |
| 14/109 | Complete Secromicon | 完整的西克罗米昆 | 暂译：活动/任务道具，待核对国服物品全名 |
| 15/0 | Scroll of Poison | 毒咒术 | 道具词典 property #46 |
| 15/1 | Scroll of Meteorite | 陨石术 | 道具词典 property #44 |
| 15/2 | Scroll of Lighting | 掌心雷术 | 道具词典 property #42 |
| 15/3 | Scroll of Fire Ball | 火球术 | 道具词典 property #40 |
| 15/4 | Scroll of Flame | 火龙术 | 道具词典 property #47 |
| 15/5 | Scroll of Teleport | 瞬间移动术 | 道具词典 property #43 |
| 15/6 | Scroll of Ice | 冰封术 | 道具词典 property #45 |
| 15/7 | Scroll of Twister | 龙卷风术 | 道具词典 property #48 |
| 15/8 | Scroll of Evil Spirit | 黑龙波术 | 道具词典 property #49 |
| 15/9 | Scroll of Hellfire | 地狱火术 | 道具词典 property #50 |
| 15/10 | Scroll of Power Wave | 真空波术 | 道具词典 property #41 |
| 15/11 | Scroll of Aqua Beam | 极光术 | 道具词典 property #51 |
| 15/12 | Scroll of Cometfall | 爆炎术 | 道具词典 property #52 |
| 15/13 | Scroll of Inferno | 毁灭烈焰术 | 道具词典 property #55 |
| 15/14 | Scroll of Teleport Ally | 小挪移术 | 道具词典 property #54 |
| 15/15 | Scroll of Soul Barrier | 守护之魂术 | 道具词典 property #53 |
| 15/16 | Scroll of Decay | 单毒炎术 | 魔法师职业资料 |
| 15/17 | Scroll of Ice Storm | 暴风雪术 | 魔法师职业资料 |
| 15/18 | Scroll of Nova | 星辰一怒术 | 魔法师职业资料 |
| 15/19 | Chain Lightning Parchment | 链雷咒羊皮纸 | 召唤术师职业资料 |
| 15/20 | Drain Life Parchment | 摄魂咒羊皮纸 | 召唤术师职业资料 |
| 15/21 | Lightning Shock Parchment | 烈光闪羊皮纸 | 召唤术师职业资料 |
| 15/22 | Damage Reflection Parchment | 伤害反射羊皮纸 | 召唤术师职业资料 |
| 15/23 | Berserker Parchment | 狂暴术羊皮纸 | 召唤术师职业资料 |
| 15/24 | Sleep Parchment | 昏睡术羊皮纸 | 召唤术师职业资料 |
| 15/26 | Weakness Parchment | 虚弱阵羊皮纸 | 召唤术师职业资料 |
| 15/27 | Innovation Parchment | 破御阵羊皮纸 | 召唤术师职业资料 |
| 15/28 | Scroll of Wizardry Enhance | 法神附体术 | 魔法师职业资料 |
| 15/29 | Scroll of Gigantic Storm | 闪电轰顶术 | 魔剑士职业资料 |
| 15/30 | Chain Drive Parchment | 回旋踢羊皮纸 | 格斗家职业资料 |
| 15/31 | Dark Side Parchment | 幽冥光速拳羊皮纸 | 格斗家职业资料 |
| 15/32 | Dragon Roar Parchment | 炎龙拳羊皮纸 | 格斗家职业资料 |
| 15/33 | Dragon Slasher Parchment | 嗜血之龙羊皮纸 | 格斗家职业资料 |
| 15/34 | Ignore Defense Parchment | 斗神-破羊皮纸 | 格斗家职业资料 |
| 15/35 | Increase Health Parchment | 斗神-命羊皮纸 | 格斗家职业资料 |
| 15/36 | Increase Block Parchment | 斗神-御羊皮纸 | 格斗家职业资料 |
