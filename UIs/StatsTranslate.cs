using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Terraria.ModLoader;
using Terraria.UI.Chat;

namespace ThoriumModzhcn.UIs
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
        private static List<TextSnippet> Translate(On_ChatManager.orig_ParseMessage orig, string text, Color baseColor)
        {
            text = Regex.Replace(text, "Healer Stats", "牧师属性");
            text = Regex.Replace(text, "Current Bonus Healing", "当前治疗增益");
            text = Regex.Replace(text, "Best Heal Streak", "最佳连续治疗");
            text = Regex.Replace(text, "Healing done", "完成治疗");
            text = Regex.Replace(text, "Damage mitigated", "伤害减免");
            text = Regex.Replace(text, "Lives saved", "拯救生命");
            text = Regex.Replace(text, "Close calls", "千钧一发");
            text = Regex.Replace(text, "Bard Stats", "吟游诗人属性");
            text = Regex.Replace(text, "Bonus Duration", "持续时间增益");
            text = Regex.Replace(text, "sec\\(s\\)", "秒");
            text = Regex.Replace(text, "Max-Use Duration", "满灵感时持续");
            text = Regex.Replace(text, "Base Inspiration", "基础灵感");
            text = Regex.Replace(text, "Bonus Inspiration", "额外灵感");
            text = Regex.Replace(text, "Timed Hits", "精准演奏");
            text = Regex.Replace(text, "sec", "秒");            
            return orig.Invoke(text, baseColor);
        }       
    }
}
