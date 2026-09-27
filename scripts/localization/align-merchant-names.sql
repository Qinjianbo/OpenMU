-- See docs/ChineseMerchantNames.md for sources and provisional names.
-- Stop the application and back up the database before applying.
-- Preserves custom translations, other languages, and all non-name columns.
BEGIN;
CREATE TEMP TABLE chinese_merchant_names(number integer, neutral text, chinese text, legacy text) ON COMMIT DROP;
INSERT INTO chinese_merchant_names VALUES
(230, 'Alex', '流浪商人阿莱斯', ''),
(231, 'Thompson the Merchant', '武器商人托姆绅', ''),
(242, 'Elf Lala', '精灵安吉拉', ''),
(243, 'Eo the Craftsman', '工匠尤达', ''),
(244, 'Caren the Barmaid', '老板娘莉娜', ''),
(245, 'Izabel The Wizard', '魔导师露茜', ''),
(246, 'Zienna The Weapons Merchant', '武器商人苏菲', ''),
(248, 'Wandering Merchant Martin', '流浪商人马丁', ''),
(250, 'Wandering Merchant Harold', '流浪商人海罗德', ''),
(251, 'Hanzo The Blacksmith', '铁匠汉斯', ''),
(253, 'Potion Girl Amy', '少女安娜', ''),
(254, 'Pasi The Mage', '魔导师帕希', ''),
(255, 'Lumen the Barmaid', '老板娘莉雅', ''),
(259, 'Oracle Layla', '雷拉', '神谕者莱拉'),
(376, 'Pamela the Supplier', '物资管理员帕糜拉', ''),
(377, 'Angela the Supplier', '物资管理员安吉拉', ''),
(415, 'Silvia', '塞尔维亚', '西尔维娅'),
(416, 'Rhea', '雷亚', ''),
(417, 'Marce', '摩尔塞', ''),
(545, 'Christine the General Goods Merchant', '杂货商人克里斯丁', ''),
(577, 'Leina the General Goods Merchant', '蕾娜', ''),
(578, 'Weapons Merchant Bolo', '贝莱', '');
UPDATE config."MonsterDefinition" m
SET "Designation" = CASE
    WHEN m."Designation" ~ '\|\|zh='
    THEN regexp_replace(m."Designation", '\|\|zh=[^|]*', '||zh=' || n.chinese, 'g')
    ELSE m."Designation" || '||zh=' || n.chinese
END
FROM chinese_merchant_names n
WHERE m."MerchantStoreId" IS NOT NULL
  AND m."Number" = n.number
  AND split_part(m."Designation", '||', 1) = n.neutral
  AND COALESCE(substring(m."Designation" FROM '\|\|zh=([^|]*)'), '') IN ('', n.legacy, n.neutral)
  AND substring(m."Designation" FROM '\|\|zh=([^|]*)') IS DISTINCT FROM n.chinese
RETURNING m."Number", m."Designation";
COMMIT;
