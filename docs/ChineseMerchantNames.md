# Chinese merchant names

The built-in 0.75, 0.95d, and Season 6 initializers include Chinese merchant names.
Existing databases can apply **对齐简体中文商人名称** on `/config-updates`
after deploying this revision, then restart the service. Back up the database first.
This optional update does not run automatically on deployment. Its version is
100119 (0.75), 100120 (0.95d), or 100121 (Season 6).

Only merchants with matching NPC numbers and neutral English names are changed.
Missing Chinese translations and the known legacy translations of Silvia and
Oracle Layla are corrected. Customized names, other languages, shop inventories,
prices, NPC identifiers, and spawn locations are preserved. Applying it again is safe.
These database changes are separate from upstream UI localization PR #981.
The server database names affect administration; names rendered by a game client
may come from that client's own language data.

## Name mapping and evidence

Official references:

- [A: NPC guide](https://mu.zhaouc.com/Guide/npc/NPC.html)
- [B: Devias](https://mu.zhaouc.com/Guide/GameIntro/02_area04.html)
- [C: Kalima](https://mu.zhaouc.com/Guide/GameIntro/02_area10.html)
- [D: Valley of Loren](https://mu.zhaouc.com/Guide/GameIntro/02_area11.html)
- [E: Elbeland](https://mu.zhaouc.com/Guide/GameIntro/02_area03.html)
- [F: Karutan](https://mu.zhaouc.com/Guide/GameIntro/02_area19.html)

The official Valley of Loren guide confirms the title 物资管理员 and both locations,
but omits personal names. Those names are supplemented by the non-official
[Chinese NPC database](https://mu.dvg.cn/npcshop.php).
Christine's Chinese name remains **provisional**, not verified as official:
杂货商人克里斯丁 is a transliteration used for this translation set.

| NPC | Neutral name | Chinese name | Evidence |
| --- | --- | --- | --- |
| 230 | Alex | 流浪商人阿莱斯 | A |
| 231 | Thompson the Merchant | 武器商人托姆绅 | A |
| 242 | Elf Lala | 精灵安吉拉 | A |
| 243 | Eo the Craftsman | 工匠尤达 | A |
| 244 | Caren the Barmaid | 老板娘莉娜 | B |
| 245 | Izabel The Wizard | 魔导师露茜 | A |
| 246 | Zienna The Weapons Merchant | 武器商人苏菲 | A |
| 248 | Wandering Merchant Martin | 流浪商人马丁 | A |
| 250 | Wandering Merchant Harold | 流浪商人海罗德 | A |
| 251 | Hanzo The Blacksmith | 铁匠汉斯 | A |
| 253 | Potion Girl Amy | 少女安娜 | A |
| 254 | Pasi The Mage | 魔导师帕希 | A |
| 255 | Lumen the Barmaid | 老板娘莉雅 | A |
| 259 | Oracle Layla | 雷拉 | C |
| 376 | Pamela the Supplier | 物资管理员帕糜拉 | D: title; community database: personal name |
| 377 | Angela the Supplier | 物资管理员安吉拉 | D: title; community database: personal name |
| 415 | Silvia | 塞尔维亚 | E |
| 416 | Rhea | 雷亚 | E |
| 417 | Marce | 摩尔塞 | E |
| 545 | Christine the General Goods Merchant | 杂货商人克里斯丁 | Provisional transliteration; official name unverified |
| 577 | Leina the General Goods Merchant | 蕾娜 | F |
| 578 | Weapons Merchant Bolo | 贝莱 | F |

## SQL alternative

`scripts/localization/align-merchant-names.sql` can update a PostgreSQL database
without deploying the new plugin. Stop the application, back up the affected rows,
run the script with `psql -v ON_ERROR_STOP=1`, and restart the application.
It uses the same number/name guards and translation policy as the plugin.
It does not mark the configuration update as installed; applying the plugin later
is safe and records installation without changing already-correct names.
