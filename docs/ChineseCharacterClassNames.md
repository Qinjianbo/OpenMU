# Deploying official Chinese character class names

The class names follow the Taren-operated MU website:

- [Class advancement](https://mu.zhaouc.com/Guide/GameSystem/08_quest.html)
- [Master classes](https://mu.zhaouc.com/Guide/GameSystem/09_master.html)

This change is maintained in this fork separately from the upstream UI
localization PR. It covers the built-in 0.75, 0.95d, and Season 6 configurations.

## New databases

Build and deploy this revision, then run normal database initialization.
The initialization process fills the Chinese names after creating the complete
configuration and records the corresponding configuration update as installed.
No separate SQL patch is required.

## Existing databases

1. Back up the database and deploy a build containing this revision.
2. Open the admin panel configuration updates page (`/config-updates`).
3. Select **对齐官方简体中文职业名称** (English:
   **Align Simplified Chinese character class names**) and apply it.
4. Restart the application to ensure all running servers reload the configuration.

The update is optional; deploying the application alone does not automatically
apply it to existing data. Each supported initialization version has its own
update plugin (versions 116, 117, and 118). The normal update service records
installation and removes the installed update from the available updates list.

Only missing Chinese translations and known legacy mistranslations are changed.
The class number and neutral English name must both match a built-in class.
Other languages, custom Chinese names, identifiers, advancement relationships,
and gameplay values are preserved. Reapplying the name mapping is harmless.
For example, `Rage Fighter` changes from `圣导师` to `格斗家`, while `Dark Lord`
changes from `黑暗领主` to `圣导师`; matching by class number prevents ambiguity.

The earlier local SQL repair and these plugins are alternative ways to repair
the known names. Databases already repaired by SQL keep the same names when the
plugin is applied; the plugin additionally records the update as installed.
