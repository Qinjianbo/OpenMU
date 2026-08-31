// <copyright file="FixChineseDropItemGroupNamesPlugIn.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Updates;

using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using MUnique.OpenMU.DataModel.Configuration;
using MUnique.OpenMU.Interfaces;
using MUnique.OpenMU.Persistence.Initialization.VersionSeasonSix;
using MUnique.OpenMU.PlugIns;

/// <summary>Repairs incomplete Simplified Chinese drop item group descriptions.</summary>
[PlugIn]
[Guid("B7D4E2A9-6C31-4F85-9E20-3A7B1D8C5406")]
public sealed class FixChineseDropItemGroupNamesPlugIn : UpdatePlugInBase
{
    public override UpdateVersion Version => UpdateVersion.FixChineseDropItemGroupNames;
    public override string DataInitializationKey => DataInitialization.Id;
    public override string Name => "Fix Simplified Chinese drop item group names";
    public override string Description => "Repairs incomplete Chinese names in drop item groups.";
    public override DateTime CreatedAt => new(2026, 8, 31, 0, 0, 0, DateTimeKind.Utc);
    public override bool IsMandatory => false;

    protected override ValueTask ApplyAsync(IContext context, GameConfiguration gameConfiguration)
    {
        foreach (var group in gameConfiguration.DropItemGroups)
        {
            var english = group.Description.Value?.Split(LocalizedString.Separator, 2, StringSplitOptions.None)[0];
            if (english is null) continue;
            var chinese = Translate(english);
            if (chinese is not null) group.Description = $"{english}{LocalizedString.Separator}zh={chinese}";
        }

        return ValueTask.CompletedTask;
    }

    private static string? Translate(string value)
    {
        if (value.StartsWith("Scroll of Archangel+", StringComparison.OrdinalIgnoreCase)) return $"大天使卷轴+{value[20..]}";
        if (value.StartsWith("Box of Kundun +", StringComparison.OrdinalIgnoreCase)) return $"昆顿之盒 +{value[15..]}";
        if (value.StartsWith("Blood Bone+", StringComparison.OrdinalIgnoreCase)) return $"血骨+{value[11..]}";
        if (value.StartsWith("Devil's Eye+", StringComparison.OrdinalIgnoreCase)) return $"恶魔之眼+{value[12..]}";
        if (value.StartsWith("Devil's Key+", StringComparison.OrdinalIgnoreCase)) return $"恶魔之钥+{value[12..]}";
        if (value.StartsWith("Old Scroll+", StringComparison.OrdinalIgnoreCase)) return $"远古卷轴+{value[11..]}";
        if (value.StartsWith("Illusion Sorcerer Covenant+", StringComparison.OrdinalIgnoreCase)) return $"幻影术士契约+{value[26..]}";
        if (Regex.IsMatch(value, @"^Rewarded items for Blood Castle \d+$", RegexOptions.IgnoreCase)) return $"血色城堡奖励物品 {value[^1]}";
        if (Regex.IsMatch(value, @"^Rewarded jewels for Chaos Castle \d+$", RegexOptions.IgnoreCase)) return $"赤色要塞奖励宝石 {value[^1]}";
        if (Regex.IsMatch(value, @"^Rewarded ancient items for Chaos Castle \d+$", RegexOptions.IgnoreCase)) return $"赤色要塞奖励远古物品 {value[^1]}";
        if (Regex.IsMatch(value, @"^The drop item group for Symbol of Kundun \(Level \d+\)$", RegexOptions.IgnoreCase)) return $"昆顿之符掉落组（等级 {value[^2]}）";
        return value switch
        {
            "Archangel Weapon (Blood Castle)" => "大天使武器（血色城堡）",
            "Box of Luck" => "幸运之箱",
            "Crest of Monarch" => "帝王之冠",
            "Dark Horse Spirit" => "黑王马灵魂",
            "Dark Raven Spirit" => "黑暗之鸦灵魂",
            "Flame of Condor" => "凤凰之炎",
            "Items from red dragon" => "红龙掉落物品",
            "Loch's Feather" => "洛克之羽",
            "Jewel of Bless from White Wizard" => "白巫师掉落的祝福宝石",
            "Quest Item 'Eye of Abyssal' (Summoner)" => "任务物品：深渊之眼（召唤术士）",
            "Quest Item 'Soul Shard of Wizard' (Dark Wizard)" => "任务物品：巫师灵魂碎片（黑暗巫师）",
            "Quest Item 'Tear of Elf' (Fairy Elf)" => "任务物品：精灵之泪（圣射手）",
            "Quest Item 'Horn of Hell Maine' ()" => "任务物品：地狱犬王之角",
            "Quest Item 'Feather of Dark Phoenix' ()" => "任务物品：黑凤凰之羽",
            "Quest Item 'Flame of Death Beam Knight' ()" => "任务物品：死亡光束骑士之炎",
            "The common money drop item group (50 % drop chance)" => "普通金币掉落组（50%掉落率）",
            "The common drop item group for random items (30 % drop chance)" => "普通随机物品掉落组（30%掉落率）",
            "The common drop item group for random excellent items (0.01 % drop chance)" => "随机卓越物品掉落组（0.01%掉落率）",
            "The jewels drop item group (0.1 % drop chance)" => "宝石掉落组（0.1%掉落率）",
            "The drop item group for Rena" => "雷纳掉落组",
            _ when value.StartsWith("Quest Item 'Scroll of Emperor;Ring of Honor' (", StringComparison.OrdinalIgnoreCase) => "任务物品：帝王卷轴、荣誉之戒",
            _ when value.StartsWith("Quest Item 'Broken Sword;Dark Stone' (", StringComparison.OrdinalIgnoreCase) => "任务物品：断剑、黑暗之石",
            _ when value.StartsWith("Wizard's Ring from Destructive Ogre", StringComparison.OrdinalIgnoreCase) => "毁灭食人魔掉落的巫师之戒",
            _ => null,
        };
    }
}
