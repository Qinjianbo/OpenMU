// <copyright file="MapNameTranslations.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization;

using MUnique.OpenMU.Interfaces;

/// <summary>
/// Provides Simplified Chinese translations for the built-in map names.
/// </summary>
internal static class MapNameTranslations
{
    private static readonly IReadOnlyDictionary<string, string> Translations = new Dictionary<string, string>(StringComparer.Ordinal)
    {
        ["Lorencia"] = "洛兰", ["Noria"] = "诺利亚", ["Devias"] = "冰风谷", ["Dungeon"] = "地下城",
        ["Lost Tower"] = "失落之塔", ["Atlans"] = "亚特兰蒂斯", ["Tarkan"] = "塔克", ["Icarus"] = "天空之城",
        ["Arena"] = "竞技场", ["Exile"] = "流放地", ["Elvenland"] = "幻术园", ["Aida"] = "艾迪亚",
        ["Vulcanus"] = "坎特鲁废墟", ["Kanturu Event"] = "坎特鲁核心", ["Karutan 1"] = "卡伦特 1",
        ["Karutan 2"] = "卡伦特 2",
        ["Crywolf Fortress"] = "狼魂要塞", ["Land_of_Trials"] = "试炼之地", ["LorenMarket"] = "罗伦市场",
        ["Santa Village"] = "圣诞村", ["Valley of Loren"] = "罗伦峡谷", ["Barracks of Balgass"] = "巴尔加斯兵营",
        ["Balgass Refuge"] = "巴尔加斯休息处", ["Swamp Of Calmness"] = "宁静沼泽", ["Duel Arena"] = "决斗场",
        ["Kanturu_I"] = "坎特鲁遗址", ["Kanturu_III"] = "坎特鲁遗迹", ["LaCleon"] = "狼魂要塞",
        ["LaCleon Boss"] = "狼魂要塞首领房", ["Silent Map?"] = "未知地图",
    };

    /// <summary>
    /// Adds the Simplified Chinese translation to a map name when available.
    /// </summary>
    public static string Localize(string name)
    {
        var translation = Translations.TryGetValue(name, out var value)
            ? value
            : GetNumberedTranslation(name);
        return translation is null ? name : $"{name}{LocalizedString.Separator}zh={translation}";
    }

    private static string? GetNumberedTranslation(string name)
    {
        var separator = name.LastIndexOf(' ');
        if (separator <= 0 || !int.TryParse(name.AsSpan(separator + 1), out _))
        {
            return null;
        }

        var prefix = name[..separator];
        var translation = prefix switch
        {
            "Blood Castle" => "血色城堡",
            "Devil Square" => "恶魔广场",
            "Chaos Castle" => "赤色要塞",
            "Illusion Temple" => "幻影寺院",
            "Kalima" => "卡利玛",
            "Doppelgaenger" => "幽灵神殿",
            "Fortress of Imperial Guardian" => "帝国守护者要塞",
            _ => null,
        };
        return translation is null ? null : $"{translation} {name[(separator + 1)..]}";
    }
}
