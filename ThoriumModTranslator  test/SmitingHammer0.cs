using ThoriumModzhcn.Systems;
using System.Collections.Generic;
using Terraria.ModLoader;
namespace ThoriumModzhcn.ThoriumModTranslator
{
	internal class SmitingHammer0 : ModSystem
	{
		private class ThoriumMod{}
		[ExtendsFromMod("ThoriumMod"), JITWhenModsEnabled("ThoriumMod")]
		private class TranslatorLoad : ForceLocalizeSystem<ThoriumMod, TranslatorLoad>{}
		public override void PostSetupContent()
		{
			if(ModLoader.TryGetMod("ThoriumMod",out var mod))
			{
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.Donate.SmitingHammer", "ModifyTooltips", new ()
				{
					{"Right click to heal all nearby allies equal to the weapon's holy charges at twice the mana cost","右键以两倍的法力消耗治疗附近队友，治疗量等同于该武器的神圣充能。"},
				});
			}
			base.PostSetupContent();
		}
	}
}
