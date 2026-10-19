# Pull request preflight checklist

This is our working checklist for contributions to MUnique/OpenMU. Read it before
opening or updating an upstream PR. Record evidence for applicable checks; mark
others `N/A` with a reason. A checked box means verified, not merely intended.

The authoritative baseline remains [coding rules](CODING_RULES.md),
[contributing guidelines](../CONTRIBUTING.md) and [agent instructions](../AGENTS.md).
This checklist summarizes maintainer feedback and our verification procedure; it
is not a claim that every suggestion below is an upstream blocking requirement.

Last reviewed: 2026-10-19. Sources: reviews on our PRs #981, #1014, #1059, #1071,
#1124, #1179, #1181 and #1182. Check newer feedback when preparing the next PR.

## 1. Scope and current upstream

- [ ] Fetch upstream and compare the complete PR diff with current `master`.
  Resolve conflicts without dropping either side's resource entries. Verify the
  resolved result, not only the pre-merge branch.
- [ ] Keep one concern per PR. Exclude local deployment settings, credentials,
  build output, scratch scripts and unrelated formatting or generated changes.
- [ ] For a non-small change, reference an existing issue or open one first.
  Target `master` and use an English conventional-commit title and description.
- [ ] Read new maintainer comments, reviews and inline comments on the relevant
  PRs. Distinguish final decisions from superseded proposals and optional advice.

Evidence: [#981 conflict resolution](https://github.com/MUnique/OpenMU/pull/981#pullrequestreview-5355727088),
[#1182 latest-master review](https://github.com/MUnique/OpenMU/pull/1182#issuecomment-6106543489).
Scope and issue requirements come from the repository rules.

## 2. Localized strings: storage, comparison and display

- [ ] Audit every consumer when changing a property from `string` to
  `LocalizedString`, including helper parameters, initializers, update plugins,
  tests, serialization, search, editors and `ToString()`.
- [ ] Use `ValueInNeutralLanguage` for stable English matching and for composing
  neutral initialization values. Check under a non-English culture too.
- [ ] Do not pass `LocalizedString` implicitly to a `string` parameter and then
  concatenate it: the conversion exposes serialized `Value`, including source
  metadata. Do not use that representation for display.
- [ ] Resolve display text for the intended culture explicitly (admin UI or
  player culture). String interpolation can call culture-dependent `ToString()`;
  it must not accidentally determine persisted neutral text.
- [ ] Preserve identifiers that are still plain English update keys, such as
  attribute `Designation`. A translated hint must not silently change what an
  editor writes. Exact neutral matching must guard display-only translations.
- [ ] Check for raw `||zh-CN=`, `@src=` and `@stamp=` leaking into rendered text,
  or concatenation corrupting source keys/stamps. Consider log output when
  changing `ToString()`; the maintainer noted this as a caveat, not a blanket ban.

Evidence: [#1071 implicit conversion](https://github.com/MUnique/OpenMU/pull/1071#discussion_r4177033822),
[#1071 culture-dependent initialization](https://github.com/MUnique/OpenMU/pull/1071#discussion_r4177033967),
[#1124 broken ancient-item tests](https://github.com/MUnique/OpenMU/pull/1124#pullrequestreview-5438116218),
[#1179 stable designation and editor behavior](https://github.com/MUnique/OpenMU/pull/1179#issuecomment-6106585363).

## 3. Resources and fallback

- [ ] Use neutral `.resx` plus language-specific resources and the existing
  `LocalizedString.FromResource(() => ...)` mechanism. Do not add per-language
  dictionaries, duplicate number-to-resource catalogs or custom metadata parsers.
- [ ] Use descriptive keys tied to the entity/member, not numbered `Display1`,
  `Display2`, etc. Review string-key lookups for typos and key collisions.
- [ ] Register new resource managers through `ConfigurationNameSources` so stored
  source keys resolve in a fresh process without running data initialization.
- [ ] Preserve full culture names (`zh-CN` and `zh-TW` are distinct). Reuse existing
  fallback/discovery helpers. If changing discovery, require a real own resource
  set, not merely a directory accepted as a culture or a cached parent resource.
- [ ] Validate satellite keys against neutral keys, placeholders and meaningful
  separators/level lists. Missing translations must fall back to English.
  **Do not require every future neutral key/entity to have a Chinese translation.**
- [ ] Preserve exact neutral strings and gameplay parameters when extracting
  resource data. Document translation sources and identify descriptive or
  provisional names rather than presenting them as verified client terminology.

Evidence: [#981 mandatory-Chinese tests and numbered keys](https://github.com/MUnique/OpenMU/pull/981#pullrequestreview-5330799958),
[#1014 final resource architecture](https://github.com/MUnique/OpenMU/pull/1014#pullrequestreview-5384042763),
[#1059 actual satellite resource sets](https://github.com/MUnique/OpenMU/pull/1059#pullrequestreview-5400388238),
[#1071 resource consistency](https://github.com/MUnique/OpenMU/pull/1071#pullrequestreview-5405425478).
Translation provenance is also covered by the repository's source-evidence rules.

## 4. Existing installations and owner customizations

- [ ] For configuration-name translations, use the existing Configuration names
  link → review → apply workflow. Do not add a new update plugin per language or
  translation batch. This does not replace update plugins for gameplay/config
  changes that require them under coding rule 4.
- [ ] Limit fallback matching to the intended owner types and stable identity.
  Require exact neutral text and apply the relevant ambiguity checks to both
  reference and target. Do not broaden another entity type's stricter safeguards.
- [ ] Preserve custom neutral text and custom translations. Test fresh data,
  existing plain names, custom values, ambiguous matches and repeated application.
- [ ] Keep linking separate from applying text changes. Bulk selection affects
  the filtered rows, is disabled while busy and does not save until explicit apply.
- [ ] Verify the stored column/converter and legacy-value round trip when changing
  a model property. Check migrations and regenerate affected models/loaders. If
  EF reports no schema changes, record that evidence rather than add an empty
  migration. This is our verification practice for schema-preserving conversions.

The initial proposal in #1014 included update plugins. It was explicitly
superseded by the source-key/Configuration names design; do not revive it based
on the earlier review alone. Evidence:
[#1014 final workflow](https://github.com/MUnique/OpenMU/pull/1014#issuecomment-5940009739),
[#1014 removal of plugins/catalog/custom generator](https://github.com/MUnique/OpenMU/pull/1014#issuecomment-5957737357),
[#1182 scoped and unambiguous matching](https://github.com/MUnique/OpenMU/pull/1182#issuecomment-6106543489),
[#1181 filtered selection and explicit apply](https://github.com/MUnique/OpenMU/pull/1181#issuecomment-6106584738).

## 5. Generated files and diagnostics

- [ ] Generate resource accessors with standard tools and normal project wiring;
  do not handwrite accessors or introduce a custom generator to imitate them.
- [ ] Regenerate affected EF compiled models and configuration loaders through
  their documented tools. Change generator inputs rather than generated logic.
- [ ] Inspect generated diffs. Avoid unrelated BOM, `global::`, documentation,
  generator-version or formatting churn in existing files. Do not change source
  behavior or remove documentation just to make the output smaller.
- [ ] Check compiler/analyzer warnings in changed files and run `git diff --check`.
  Existing unrelated warnings are not permission to introduce new ones.

Evidence: [#1014 standard generated accessors](https://github.com/MUnique/OpenMU/pull/1014#pullrequestreview-5384042763),
[#1182 non-blocking generated-file churn](https://github.com/MUnique/OpenMU/pull/1182#issuecomment-6106543489).
See [compiled models](../src/Persistence/EntityFramework/CompiledModels/Readme.md)
and [configuration loader](../src/Persistence/EntityFramework/Loading/Readme.md).

## 6. Verification before submission

- [ ] Build the current revision, then run affected test projects with matching
  configuration and `--no-build`. Rebuild after code or generator-input changes.
- [ ] Run full affected test projects, not only newly added tests. A configuration
  name/type change normally needs initialization, Web and main tests, including
  existing serializer tests. Broaden to the full solution for cross-cutting changes.
- [ ] Exercise changed user-visible behavior. For localization, check display,
  neutral/translated search, editing, fallback and custom-value preservation.
  Follow the repository's client-testing rules for gameplay/protocol changes.
- [ ] Record exact commands, revision/base, pass/fail/skip counts and why tests
  were skipped. Do not treat an unrun database/client test as passed.
- [ ] Inspect which CI checks actually ran. Green PR checks do not prove all .NET
  tests ran. If a check fails, inspect the logs and baseline before attributing it
  to infrastructure; an old infrastructure incident is not evidence for today.
- [ ] Review the final diff and PR description after fixes. State the actual
  behavior, compatibility, validation and remaining limitations; link the issue.

Evidence: [#1124 tests missed by PR CI](https://github.com/MUnique/OpenMU/pull/1124#pullrequestreview-5438116218),
[#981 verified infrastructure failure](https://github.com/MUnique/OpenMU/pull/981#pullrequestreview-5330799958),
[#1182 rerun after resolving conflicts](https://github.com/MUnique/OpenMU/pull/1182#issuecomment-6107736359).
Historical test counts and CI trigger behavior are not current acceptance criteria.

## Review record for each PR

Copy this into the working PR notes. Summarize the relevant evidence in the public
PR description; do not include local secrets or irrelevant machine details.

```text
PR / issue:
Head revision / upstream base:
Applicable checklist sections:
Historical feedback checked (links, including newer feedback):
Findings and fixes:
N/A checks and reasons:
Build/test commands and results (including skipped tests):
Manual verification and environment:
Generated files / persistence compatibility evidence:
CI checks actually run / pending:
Remaining limitations:
```

When a new review identifies a reusable issue, add the failure mode, a concrete
check and the original link here. Mark superseded advice explicitly. Keep optional
suggestions separate from required fixes, and avoid turning a one-off comment
into a universal rule without evidence.
