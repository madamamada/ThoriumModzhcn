using ThoriumModzhcn.Systems;
using System.Collections.Generic;
using Terraria.ModLoader;
namespace ThoriumModzhcn.ThoriumModTranslator
{
	internal class BeeBooties0 : ModSystem
	{
		private class ThoriumMod{}
		[ExtendsFromMod("ThoriumMod"), JITWhenModsEnabled("ThoriumMod")]
		private class TranslatorLoad : ForceLocalizeSystem<ThoriumMod, TranslatorLoad>{}
		public override void PostSetupContent()
		{
			if(ModLoader.TryGetMod("ThoriumMod",out var mod))
			{
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.BasicAccessories.BeeBooties", "ModifyTooltips", new ()
				{
					{"35 basic damage","35 基本伤害"},
					{"20 basic damage","20 基本伤害"},
				});
			}
			base.PostSetupContent();
		}
	}
}
