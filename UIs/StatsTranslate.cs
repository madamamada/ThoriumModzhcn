using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Terraria.ModLoader;
using Terraria.UI.Chat;
using ThoriumMod.UI;

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
            text = Regex.Replace(text, "Current Bonus Healing", "当前额外治疗量");
            text = Regex.Replace(text, "Best Heal Streak", "最大连击治疗量");
            text = Regex.Replace(text, "Healing done", "治疗量");
            text = Regex.Replace(text, "Damage mitigated", "伤害减缓");
            text = Regex.Replace(text, "Lives saved", "救死扶伤");
            text = Regex.Replace(text, "Close calls", "死里逃生");
            text = Regex.Replace(text, "Bard Stats", "吟游诗人属性");
            text = Regex.Replace(text, "Bonus Duration", "咒音增幅的持续时间");
            text = Regex.Replace(text, "sec\\(s\\)", "秒");
            text = Regex.Replace(text, "Max-Use Duration", "最大使用时间");
            text = Regex.Replace(text, "Base Inspiration", "基础灵感值");
            text = Regex.Replace(text, "Bonus Inspiration", "额外灵感值");
            text = Regex.Replace(text, "Timed Hits", "抓住节拍次数");
            text = Regex.Replace(text, "sec", "秒");   
            text = Regex.Replace(text, "Total:", "合计:");    
            text = Regex.Replace(text, " Damage Reduction", "伤害减免"); 
            text = Regex.Replace(text, "Vanilla:", "原版:"); 
            text = Regex.Replace(text, "Thorium:", "瑟银:");         
            return orig.Invoke(text, baseColor);
        }       
    }
}
