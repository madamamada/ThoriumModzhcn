using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Terraria.ModLoader;
using Terraria.UI.Chat;
using ThoriumMod.UI;

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
        private static List<TextSnippet> Translate(On_ChatManager.orig_ParseMessage orig, string text, Color baseColor)
        {
            //原瑟银
           /* text = Regex.Replace(text, "Healer Stats", "牧师属性");
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
            text = Regex.Replace(text, "sec", "秒"); */


            //瑟银重置
            text = Regex.Replace(text, "PHOTOSENSITIVITY WARNING: ", "光 敏 警 告: " ); 
            text = Regex.Replace(text, "mod adds a lot of flashy effects! Especially in boss fights!", "模组增加了很多华丽的效果!尤其是在boss战中！");  
            text = Regex.Replace(text, "If you are photosensitive, go to Settings -> Mod Configuration -> Thorium Bosses Rework -> Visual Settings and set all the sliders to 0!", "如果你感觉到不适，请转到设置 -> 模组配置 -> Thorium Bosses Rework -> 视觉设置，并将所有设置调整为0!");  
            text = Regex.Replace(text, "You can turn off this warning in the config as well if you do not want to keep seeing it!", "如果你不想看到这个警告，也可以在配置中关闭它!");      
            return orig.Invoke(text, baseColor);
        }       
    }
}
