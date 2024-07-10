using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Terraria.ModLoader;
using Terraria.UI.Chat;

namespace ThoriumModzhcn.GlobalTranslation
{
    public class StatsTranslate : ModSystem
    {
        public override void Load()
        {
            On_ChatManager.ParseMessage += Translate;            
        }
        public override void Unload()
        {
            On_ChatManager.ParseMessage -= Translate;
        }

        private static readonly Dictionary<string, string> _replacements = new()
        {
            //原瑟银
            { "Healer Stats", "牧师属性" },
            { "(Current Bonus Healing: )([0-9]+)\n(Best Heal Streak: )([0-9]+)\n(Healing done: )([0-9]+)\n(Damage mitigated: )([0-9]+)\n(Lives saved: )([0-9]+)\n(Close calls: )([0-9]+)", "当前额外治疗量: $2\n最大连击治疗量: $4\n治疗量: $6\n伤害减缓: $8\n救死扶伤: $10\n死里逃生: $12" },
            { "Bard Stats", "吟游诗人属性" },
            { "Bonus Duration", "咒音增幅持续时间" },
            { "sec\\(s\\)", "秒" },
            { "Max-Use Duration", "最大使用时间" },
            { "(Base Inspiration: )([0-9]+)( / )([0-9]+)\n(Bonus Inspiration: )([0-9]+)\n(Timed Hits: )([0-9]+)", "基础灵感值: $2 / $4\n额外灵感值: $6\n抓住节拍次数: $8" },
            { "(Total: )([0-9]+)(% Damage Reduction\nVanilla: )([0-9]+)(%\nThorium: )([0-9]+)(%)", "合计: $2% 伤害减免\n原版: $4%\n瑟银: $6%" },
            
            //瑟银重置
            { "PHOTOSENSITIVITY WARNING: ", "光 敏 警 告: " },
            { "mod adds a lot of flashy effects! Especially in boss fights!", "模组增加了很多华丽的效果!尤其是在boss战中！" },
            { "If you are photosensitive, go to Settings -> Mod Configuration -> Thorium Bosses Rework -> Visual Settings and set all the sliders to 0!", "如果你感觉到不适，请转到设置 -> 模组配置 -> Thorium Bosses Rework -> 视觉设置，并将所有设置调整为0!" },
            { "You can turn off this warning in the config as well if you do not want to keep seeing it!", "如果你不想看到这个警告，也可以在配置中关闭它!" }
        };

        private static readonly string _pattern = string.Join("|", _replacements.Keys.Select(Regex.Escape));

        private static List<TextSnippet> Translate(On_ChatManager.orig_ParseMessage orig, string text, Color baseColor)
        {
            text = Regex.Replace(text, _pattern, match => _replacements[match.Value]);
            return orig.Invoke(text, baseColor);
        }
    }
}