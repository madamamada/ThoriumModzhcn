using System;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using MonoMod.RuntimeDetour;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI.Chat;
using Microsoft.Xna.Framework.Graphics;
using MonoMod.Cil;
using ThoriumMod.Tiles;
using ThoriumMod.UI.ResourceBars;



namespace ThoriumModzhcn.GlobalTranslation
{
    //世界引擎
    public class WorldEngineTranslation : GlobalTile
    {
        public override void MouseOver(int i, int j, int type)
        {
            if (type == ModContent.TileType<WorldEngineTile>())
            {
                Player localPlayer = Main.LocalPlayer;
                if (Main.GameModeInfo.IsJourneyMode)
                {
                    localPlayer.cursorItemIconText = "\n\n你无法在旅行模式使用它，请使用旅行模式的难度滑块";
                    return;
                }
                localPlayer.cursorItemIconText = $"\n\n消耗 [i/s{5}:{75}] 来改变世界的难度";
                int num = Main.tile[i, j].TileFrameX / 18;
                if (Main.getGoodWorld) num++;
                var name = num switch
                {
                    1 => $"[c/FF9900:{Language.GetTextValue("UI.Expert")}]",
                    2 => $"[c/FF2619:{Language.GetTextValue("UI.Master")}]",
                    3 => $"[c/32CD32:{Language.GetTextValue("UI.Legendary")}]",
                    _ => $"[c/FFFFFF:{Language.GetTextValue("UI.Normal")}]",
                };
                localPlayer.cursorItemIconText += $"\n切换到 {name} 模式";
            }
        }
    }
    public class StatsTranslate : ModSystem
    {
	    private Hook _hookDisplayIconNearEquips;
        private ILHook _hookOnEnterWorld;

		public override void Load()
		{
			var methodDisplayIconNearEquips = typeof(InformationalIcons).GetMethod("DisplayIconNearEquips", BindingFlags.Static | BindingFlags.NonPublic);
			if (methodDisplayIconNearEquips is not null)
			{
				_hookDisplayIconNearEquips = new Hook(methodDisplayIconNearEquips, DisplayIconNearEquips);
				_hookDisplayIconNearEquips.Apply();
			}

            if (ModLoader.TryGetMod("ThoriumRework", out Mod thoriumRework))
            {
	            var methodOnEnterWorld = thoriumRework.GetType().Assembly.GetTypes().First(type => type.Name == "ThoriumPlayer").GetMethod("OnEnterWorld", BindingFlags.Instance | BindingFlags.Public);
	            if (methodOnEnterWorld is not null)
	            {
		            _hookOnEnterWorld = new ILHook(methodOnEnterWorld, OnEnterWorld);
                    _hookOnEnterWorld.Apply();
				}
            }

            // On_ChatManager.ParseMessage += Translate;
        }
        public override void Unload()
        {
            if (_hookDisplayIconNearEquips is not null)
            {
                _hookDisplayIconNearEquips.Dispose();
                _hookDisplayIconNearEquips = null;
            }

            if (_hookOnEnterWorld is not null)
            {
                _hookOnEnterWorld.Dispose();
                _hookOnEnterWorld = null;
			}
			// On_ChatManager.ParseMessage -= Translate;
		}

		private delegate void DisplayIconNearEquipsDelegate(SpriteBatch spriteBatch, Texture2D tex, int yOffDefault, float yOffFactor, string iconText, string iconTextSuf, Vector2 iconTextOffset, string mouseText);

		private static void DisplayIconNearEquips(DisplayIconNearEquipsDelegate orig, SpriteBatch spriteBatch, Texture2D tex, int yOffDefault, float yOffFactor, string iconText, string iconTextSuf, Vector2 iconTextOffset, string mouseText)
		{
			if (iconTextSuf == " sec")
				iconTextSuf = " 秒";

			mouseText = Regex.Replace(mouseText, "Healer Stats", "牧师属性");
			mouseText = Regex.Replace(mouseText, "(Current Bonus Healing: )([0-9]+)\n(Best Heal Streak: )([0-9]+)\n(Healing done: )([0-9]+)\n(Damage mitigated: )([0-9]+)\n(Lives saved: )([0-9]+)\n(Close calls: )([0-9]+)", "当前额外治疗量: $2\n最大连击治疗量: $4\n治疗量: $6\n伤害减缓: $8\n救死扶伤: $10\n死里逃生: $12");
			mouseText = Regex.Replace(mouseText, "Bard Stats", "吟游诗人属性");
			mouseText = Regex.Replace(mouseText, "Bonus Duration", "咒音增幅持续时间");
			mouseText = Regex.Replace(mouseText, "sec\\(s\\)", "秒  ");
			mouseText = Regex.Replace(mouseText, "Max-Use Duration", "最大使用时间");
			mouseText = Regex.Replace(mouseText, "(Base Inspiration: )([0-9]+)( / )([0-9]+)\n(Bonus Inspiration: )([0-9]+)\n(Timed Hits: )([0-9]+)", "基础灵感值: $2 / $4\n额外灵感值: $6\n抓住节拍次数: $8");
			mouseText = Regex.Replace(mouseText, "(Total: )([0-9]+)(% Damage Reduction\nVanilla: )([0-9]+)(%\nThorium: )([0-9]+)(%)", "合计: $2% 伤害减免\n原版: $4%\n瑟银: $6%");

			orig.Invoke(spriteBatch, tex, yOffDefault, yOffFactor, iconText, iconTextSuf, iconTextOffset, mouseText);
        }

        private static void OnEnterWorld(ILContext ilContext)
        {
	        var cursor = new ILCursor(ilContext);

            if (!cursor.TryGotoNext(i => i.MatchLdstr("PHOTOSENSITIVITY WARNING: \"Thorium Bosses Rework\" mod adds a lot of flashy effects! Especially in boss fights!\nIf you are photosensitive, go to Settings -> Mod Configuration -> Thorium Bosses Rework -> Visual Settings and set all the sliders to 0!\nYou can turn off this warning in the config as well if you do not want to keep seeing it!")))
				return;
            cursor.Index++;
            cursor.EmitDelegate<Func<string, string>>((eng) => "光 敏 警 告：“Thorium Bosses Rework”模组增加了很多华丽的效果！尤其是在boss战中！\n如果你感觉到不适，请转到设置 -> 模组配置 -> Thorium Bosses Rework -> 视觉设置，并将所有设置调整为0！\n如果你不想看到这个警告，也可以在配置中关闭它！");
        }


		private static List<TextSnippet> Translate(On_ChatManager.orig_ParseMessage orig, string text, Color baseColor)
        {
            //原瑟银
            text = Regex.Replace(text, "Healer Stats", "牧师属性");
            text = Regex.Replace(text, "(Current Bonus Healing: )([0-9]+)\n(Best Heal Streak: )([0-9]+)\n(Healing done: )([0-9]+)\n(Damage mitigated: )([0-9]+)\n(Lives saved: )([0-9]+)\n(Close calls: )([0-9]+)", "当前额外治疗量: $2\n最大连击治疗量: $4\n治疗量: $6\n伤害减缓: $8\n救死扶伤: $10\n死里逃生: $12");
            text = Regex.Replace(text, "Bard Stats", "吟游诗人属性");
            text = Regex.Replace(text, "Bonus Duration", "咒音增幅持续时间");
            text = Regex.Replace(text, "sec\\(s\\)", "秒");
            text = Regex.Replace(text, "Max-Use Duration", "最大使用时间");
            text = Regex.Replace(text, "(Base Inspiration: )([0-9]+)( / )([0-9]+)\n(Bonus Inspiration: )([0-9]+)\n(Timed Hits: )([0-9]+)", "基础灵感值: $2 / $4\n额外灵感值: $6\n抓住节拍次数: $8");
            text = Regex.Replace(text, "(Total: )([0-9]+)(% Damage Reduction\nVanilla: )([0-9]+)(%\nThorium: )([0-9]+)(%)", "合计: $2% 伤害减免\n原版: $4%\n瑟银: $6%");


            //瑟银重置
            text = Regex.Replace(text, "PHOTOSENSITIVITY WARNING: ", "光 敏 警 告：" ); 
            text = Regex.Replace(text, "mod adds a lot of flashy effects! Especially in boss fights!", "模组增加了很多华丽的效果！尤其是在boss战中！");  
            text = Regex.Replace(text, "If you are photosensitive, go to Settings -> Mod Configuration -> Thorium Bosses Rework -> Visual Settings and set all the sliders to 0!", "如果你感觉到不适，请转到设置 -> 模组配置 -> Thorium Bosses Rework -> 视觉设置，并将所有设置调整为0！");  
            text = Regex.Replace(text, "You can turn off this warning in the config as well if you do not want to keep seeing it!", "如果你不想看到这个警告，也可以在配置中关闭它！");      
            return orig.Invoke(text, baseColor);
        }
    }
}