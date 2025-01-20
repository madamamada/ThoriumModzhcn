using ThoriumModzhcn.Systems;
using System.Collections.Generic;
using Terraria.ModLoader;
namespace ThoriumModzhcn.ThoriumModTranslator
{
	internal class SoulLink0 : ModSystem
	{
		private class ThoriumMod{}
		[ExtendsFromMod("ThoriumMod"), JITWhenModsEnabled("ThoriumMod")]
		private class TranslatorLoad : ForceLocalizeSystem<ThoriumMod, TranslatorLoad>{}
		public override void PostSetupContent()
		{
			if(ModLoader.TryGetMod("ThoriumMod",out var mod))
			{
				TranslatorLoad.LocalizeByTypeFullName("ThoriumMod.Items.TransformItems.SoulLink", "ModifyTooltips", new ()
				{
					{"-Early Testing-","-早期测试物品-"},
					{"Allows you to use unique abilities while transformed","允许你在化形时使用独特的能力"},
				});
			}
			base.PostSetupContent();
		}
	}
}
