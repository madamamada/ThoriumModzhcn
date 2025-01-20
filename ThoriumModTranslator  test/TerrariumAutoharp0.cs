using ThoriumModzhcn.Systems;
using System.Collections.Generic;
using Terraria.ModLoader;
namespace ThoriumModzhcn.ThoriumModTranslator
{
	internal class TerrariumAutoharp0 : ModSystem
	{
		private class ThoriumMod{}
		[ExtendsFromMod("ThoriumMod"), JITWhenModsEnabled("ThoriumMod")]
		private class TranslatorLoad : ForceLocalizeSystem<ThoriumMod, TranslatorLoad>{}
		public override void PostSetupContent()
		{
			if(ModLoader.TryGetMod("ThoriumMod",out var mod))
			{
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.BardItems.TerrariumAutoharp", "BardModifyTooltips", new ()
				{
					{"Playing empowers players with bonus:","演奏会提供玩家以下加成"},
				});
			}
			base.PostSetupContent();
		}
	}
}
