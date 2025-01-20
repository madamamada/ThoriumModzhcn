using ThoriumModzhcn.Systems;
using System.Collections.Generic;
using Terraria.ModLoader;
namespace ThoriumModzhcn.ThoriumModTranslator
{
	internal class ThoriumPlayer0 : ModSystem
	{
		private class ThoriumMod{}
		[ExtendsFromMod("ThoriumMod"), JITWhenModsEnabled("ThoriumMod")]
		private class TranslatorLoad : ForceLocalizeSystem<ThoriumMod, TranslatorLoad>{}
		public override void PostSetupContent()
		{
			if(ModLoader.TryGetMod("ThoriumMod",out var mod))
			{
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.ThoriumPlayer", "AddCoinTooltip", new ()
				{
					{"gold,","金币"},
					{"gold, and","金币和"},
					{"silver, and","银币和"},
					{"silver","银币"},
					{"copper","铜币"},
					{"Money Generated:","额外掉落钱币:"},
				});
			}
			base.PostSetupContent();
		}
	}
}
