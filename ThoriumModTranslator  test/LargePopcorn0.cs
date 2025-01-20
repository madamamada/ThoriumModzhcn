using ThoriumModzhcn.Systems;
using System.Collections.Generic;
using Terraria.ModLoader;
namespace ThoriumModzhcn.ThoriumModTranslator
{
	internal class LargePopcorn0 : ModSystem
	{
		private class ThoriumMod{}
		[ExtendsFromMod("ThoriumMod"), JITWhenModsEnabled("ThoriumMod")]
		private class TranslatorLoad : ForceLocalizeSystem<ThoriumMod, TranslatorLoad>{}
		public override void PostSetupContent()
		{
			if(ModLoader.TryGetMod("ThoriumMod",out var mod))
			{
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.HealerItems.LargePopcorn", "ModifyTooltips", new ()
				{
					{"Throws out (","扔出("},
					{") eatable popcorn kernels",")个可食用的爆米花粒"},
					{"Up to (","同时可以扔出至多("},
					{") kernels may be out at once",")个爆米花粒"},
					{"Popcorn does not apply on heal effects when consumed","爆米花消耗时不会施加治疗效果"},
				});
			}
			base.PostSetupContent();
		}
	}
}
