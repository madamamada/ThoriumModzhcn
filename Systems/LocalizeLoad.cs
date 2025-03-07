using System.Collections.Generic;
using System.Reflection;
using System.Text.RegularExpressions;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;
using Terraria.ModLoader.Core;

namespace ThoriumModzhcn.Systems
{
    public class LocalizeLoad : ModSystem
    {
        public static List<string> HKHJson { get; } =
         [
            "Localization/zh-HK/zh-hk.hjson",
            "Localization/zh-HK/zh-hk_Mods.CalamityBardHealer.hjson",
            "Localization/zh-HK/zh-hk_Mods.RedemptionBardHealer.hjson",
            "Localization/zh-HK/zh-hk_Mods.SOTSBardHealer.hjson",
            "Localization/zh-HK/zh-hk_Mods.SpiritBardHealer.hjson",
            "Localization/zh-HK/zh-hk_Mods.SpookyBardHealer.hjson",
            "Localization/zh-HK/zh-hk_Mods.TerrariumHacks.hjson",
            "Localization/zh-HK/zh-hk_Mods.ThoriumRework.hjson",
            "Localization/zh-HK/zh-hk_Mods.UnlimitedBardEnergy.hjson"
        ];
        public static List<string> TWHJson { get; } =
         [
            "Localization/zh-TW/zh-tw.hjson",
            "Localization/zh-TW/zh-tw_Mods.CalamityBardHealer.hjson",
            "Localization/zh-TW/zh-tw_Mods.RedemptionBardHealer.hjson",
            "Localization/zh-TW/zh-tw_Mods.SOTSBardHealer.hjson",
            "Localization/zh-TW/zh-tw_Mods.SpiritBardHealer.hjson",
            "Localization/zh-TW/zh-tw_Mods.SpookyBardHealer.hjson",
            "Localization/zh-TW/zh-tw_Mods.TerrariumHacks.hjson",
            "Localization/zh-TW/zh-tw_Mods.ThoriumRework.hjson",
            "Localization/zh-TW/zh-tw_Mods.UnlimitedBardEnergy.hjson"
        ];

        public static List<string> ZHHJson { get; } = 
        [
            "Localization/zh-Hans/zh-Hans.hjson",
            "Localization/zh-Hans/zh-Hans_Mods.CalamityBardHealer.hjson",
            "Localization/zh-Hans/zh-Hans_Mods.RedemptionBardHealer.hjson",
            "Localization/zh-Hans/zh-Hans_Mods.SOTSBardHealer.hjson",
            "Localization/zh-Hans/zh-Hans_Mods.SpiritBardHealer.hjson",
            "Localization/zh-Hans/zh-Hans_Mods.SpookyBardHealer.hjson",
            "Localization/zh-Hans/zh-Hans_Mods.TerrariumHacks.hjson",
            "Localization/zh-Hans/zh-Hans_Mods.ThoriumRework.hjson",
            "Localization/zh-Hans/zh-Hans_Mods.UnlimitedBardEnergy.hjson"
        ];

        public override void Load()
        {
            //var r = (TmodFile)typeof(Mod).GetProperty("File", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(Mod);
            //foreach (var item in r) {
            //    var file = item;
            //}

            Load(HKHJson, LocalizeUtil.Language.香港繁体);
            Load(TWHJson, LocalizeUtil.Language.台湾繁体);
            Load(ZHHJson, LocalizeUtil.Language.简体中文);
            base.Load();
        }

        static LocalizeLoad()
        {
        }

        private static void Load(List<string> paths, LocalizeUtil.Language language)
        {
            foreach (var hjson in paths) {
                LocalizeUtil.LoadLocalizedKey(hjson, language, GetStartChars(hjson));
            }
            Dictionary<string, string> localizeTests = LocalizeUtil.GetLocalizationDictionary(language);
            string regex = @"\{\$(.*?)\}";
            foreach (var kv in localizeTests) {
                MatchCollection matchs = Regex.Matches(kv.Value, regex);
                foreach (Match item in matchs) {
                    string @waibu = item.Groups[0].Value; //0是原始值，1是内部值
                    string @neibu = item.Groups[1].Value;
                    string[] start = kv.Key.Split(".");
                    string keyStart = start[0] + "." + start[1] + "."; //Key的开头
                    string key = keyStart + neibu;       //父字符串的本地化Key
                    if (localizeTests.TryGetValue(key, out string frstring)) {//父字符串({$})的值
                        localizeTests[kv.Key] = kv.Value.Replace(waibu, frstring);
                    }
                }
            }
        }

        private static string GetStartChars(string fileName)
        {
            var splitString = fileName.Split("_");
            if (splitString.Length == 1) return "";
            if (splitString[0] == "IL") return "";
            return splitString[1].Replace(".hjson", ".");
        }
    }

    public class 语言切换 : ModConfig
    {
        public LocalizeUtil.Language 语言;

        public override ConfigScope Mode => ConfigScope.ClientSide;

        public override void OnChanged()
        {
            LocalizeUtil.CutLanguage(语言);
            base.OnChanged();
        }
    }
}
