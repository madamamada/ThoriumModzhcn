using ThoriumModzhcn.Systems;
using System.Collections.Generic;
using Terraria.ModLoader;
namespace ThoriumModzhcn.ThoriumModTranslator
{
	internal class ThoriumItem0 : ModSystem
	{
		private class ThoriumMod{}
		[ExtendsFromMod("ThoriumMod"), JITWhenModsEnabled("ThoriumMod")]
		private class TranslatorLoad : ForceLocalizeSystem<ThoriumMod, TranslatorLoad>{}
		public override void PostSetupContent()
		{
			if(ModLoader.TryGetMod("ThoriumMod",out var mod))
			{
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.ThoriumItem", "ModifyTooltips", new ()
				{
					{"-Transformation-","-化形-"},
					{"-Thrower Class-","-投手职业-"},
					{"-Healer Class-","-牧师职业-"},
				});
			}
			base.PostSetupContent();
		}
	}
}
