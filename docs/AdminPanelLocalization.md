# Admin panel localization inventory

The Simplified Chinese resources use `zh-CN`. UI labels belong to the assembly
which owns the page or component. English remains the neutral resource language.

## Coverage

| Page or component | Localized content | Resource owner |
| --- | --- | --- |
| `/create-game-server` | All seven creation fields | AdminPanel |
| `/create-connect-server` | Server ID, description, client and listening port | AdminPanel |
| `/accounts`, account and character editors | Edit actions, model captions, enum choices, collection actions, creation/selection dialogs | AdminPanel, Shared, DataModel |
| `/edit-config-grid/...` | Entry names, create/duplicate dialog titles, delete confirmation and result messages | AdminPanel |
| `/merchants/...` | Name column, item collection caption and shared item editor | AdminPanel, Shared |
| Inventory, vault and item editors | Item fields, socket labels, extensions, personal store, create/duplicate/delete actions | Shared |
| System configuration editor | Setting names and descriptions, time zone and network observation settings | DataModel |
| Castle siege configuration and model editors | New configuration fields, upgrade settings, NPC state, registrations and reward captions | DataModel |
| IP resolver options | Resolver names and descriptions | Network |
| `/servers` | Server state captions | Interfaces |
| `/plugins` | Search placeholders | AdminPanel |
| `/logfiles` | Log read error message | AdminPanel |
| Connection recovery dialog | Reconnection, retry countdown, paused session and resume prompts | AdminPanel |
| Missing-page route | Missing-content heading and description | AdminPanel |
| Shared forms and dialogs | Save/cancel/create/edit/remove controls, password prompts, file loading, format errors and paging | Shared |
| Navigation and map editor | Home breadcrumb, previous/next labels, accessible control names and object selection | AdminPanel, Shared |

## Wording review

The September 25 review distinguishes account attributes from character attributes,
hero/PK state from character access status, and personal stores from NPC shops.
Account help text explains language codes, UTC offsets, shared vaults, templates,
and unlocked character creation options. Character fields identify unspent points,
cumulative fruit points, UTC creation time, and raw client configuration data.

Singular model captions no longer say “list”. Ranking and reward positions use
rank terminology. Two-factor authentication and duplicate-entry prompts use
consistent wording. Castle siege schedule, upgrade and coordinate summaries,
and inventory summaries now use resources instead of embedded English text.

## Resource files

### Official Chinese terminology review (2026-09-26)

The following resource captions were checked against the mainland MU website.
This review changes UI resources only; localized names stored in configuration
records are separate and were not updated by this review.

| Scope | Preferred wording | Official reference |
| --- | --- | --- |
| Jewel mix configuration and output | 宝石合成配置; 宝石组合 | [宝石合成系统](https://mu.zhaouc.com/Guide/ItemSystem/01_itemSys.html) |
| Jewel mix NPC window | 宝石合成（赛尔维斯） | Same system guide; the NPC directory also uses 塞尔维斯 |
| Castle senior NPC | 长老（罗兰峡谷） | [NPC directory](https://mu.zhaouc.com/Guide/npc/NPC.html) |
| Refining and restoration windows | 再生宝石提炼（艾尔菲丝）; 进化宝石提炼（奥斯本）; 强化还原（杰瑞敦） | [Official crafting table](https://mu.zhaouc.com/News/Update/151125_event/index2.html) |
| Socket NPC windows | 荧之石管理员; 荧之石研究员 | [Season 4 socket system](https://mu.zhaouc.com/player/event/season4/index_3.html) |
| Land of Trials captions and prompts | 魔炼之地 | [Official area guide](https://mu.zhaouc.com/Guide/GameIntro/02_area12.html) |

The menu label 宝石合成 and the input label 单颗宝石 already match the intended
terminology and remain unchanged. This is a targeted terminology review, not a
claim that every localized NPC, item or map name has been verified.

### Files

- `src/Web/AdminPanel/Properties/Resources.resx` and `Resources.zh-CN.resx`
- `src/Web/Shared/Properties/Resources.resx` and `Resources.zh-CN.resx`
- `src/DataModel/Properties/ModelResources.resx` and `ModelResources.zh-CN.resx`
- `src/DataModel/Properties/Resources.resx` and `Resources.zh-CN.resx`
- `src/Network/Properties/Resources.resx` and `Resources.zh-CN.resx`
- `src/Interfaces/Properties/ModelResources.resx` and `ModelResources.zh-CN.resx`

Page-specific view models use `DisplayAttribute` with `ResourceType` and a
strongly typed resource name. Shared field labels honor an explicitly supplied
non-empty caption, then display metadata, then model resources. Model resource lookup walks
base types so persistence-generated models can resolve DataModel translations.
Enum labels are localized independently of their submitted values. Weekdays use
the selected UI culture’s day names. The HTML language attribute also follows
the selected UI culture. Flag searches
accept both localized labels and the original enum names.

The checked-in generated model resource is behind some current model types.
Additional Chinese captions for these properties are kept in the localized file;
missing English entries continue to use the existing property-name fallback.
Do not modify generated model classes to add translated labels.

## Content which can still contain English

Configuration names such as `Default (1000 players)`, client names, item names,
map names and plugin metadata are data, not fixed page labels. They need their own
localized data or plugin resources. Technical identifiers, IP addresses, class
names, raw logs and exception details retain their original form. Framework
validation messages and plugin-owned forms may require separate localization.

This inventory covers the AdminPanel and its shared components. It does not claim
that every plugin, the standalone map application or every database record is
translated.

## Verification

- Parse resources as XML; check duplicate keys and format placeholders.
- Build the affected projects and run `MUnique.OpenMU.Web.Tests`.
- Check English and Chinese creation-field display metadata.
- Check inherited model captions, explicit field labels and enum binding values.
- Inspect the deployed connection-server creation page and representative shared
  forms without submitting changes to game data.

The Web test suite passed with 112 tests after a clean rebuild on 2026-09-25.
Resource validation passed for all six Chinese files, including duplicate-key
and placeholder checks.

## Translation maintenance

Chinese translations are optional. Missing keys fall back to English; tests check
placeholder consistency only where a Chinese translation exists. Property display
resources use `{Type}_{Property}_Name` / `_Description`, and type display resources
use `{Type}_Name` / `_Description`. English extension point text is its resource key;
changing that text requires a matching translation key update. Model `ToString()`
summaries can also appear localized in server logs.
