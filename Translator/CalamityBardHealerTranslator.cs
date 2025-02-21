using ThoriumModzhcn.Systems;
using System.Collections.Generic;
using Terraria.ModLoader;
namespace ThoriumModzhcn.Translator
{
	public class CalamityBardHealerTranslator
	{
		private class CalamityBardHealer{}
		[ExtendsFromMod("CalamityBardHealer"), JITWhenModsEnabled("CalamityBardHealer")]
		private class TranslatorLoad : ForceLocalizeSystem<CalamityBardHealer, TranslatorLoad>{}
		public static void LoadTranslator()
		{
			if(ModLoader.TryGetMod("CalamityBardHealer",out var mod))
			{
				#region CalamityBardHealer.Items.SymphonicFabrications
				TranslatorLoad.LocalizeByTypeFullName("CalamityBardHealer.Items.SymphonicFabrications", "BardModifyTooltips", new ()
				{
					{"Variety IV","多种音波脉冲 IV"},
					{"Playing empowers players with bonus:","演奏会提供玩家以下加成："},
				});
				#endregion CalamityBardHealer.Items.SymphonicFabrications


			}
		}
	}
}
