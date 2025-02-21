using ThoriumModzhcn.Systems;
using System.Collections.Generic;
using Terraria.ModLoader;
namespace ThoriumModzhcn.Translator
{
	public class SpookyBardHealerTranslator
	{
		private class SpookyBardHealer{}
		[ExtendsFromMod("SpookyBardHealer"), JITWhenModsEnabled("SpookyBardHealer")]
		private class TranslatorLoad : ForceLocalizeSystem<SpookyBardHealer, TranslatorLoad>{}
		public static void LoadTranslator()
		{
			if(ModLoader.TryGetMod("SpookyBardHealer",out var mod))
			{
				#region SpookyBardHealer.Tiles.SecretPainting
				TranslatorLoad.LocalizeByTypeFullName("SpookyBardHealer.Tiles.SecretPainting", "KillMultiTile", new ()
				{
					{"HEY! HEY! HEY!","嘿! 嘿! 嘿!"},
				});
				#endregion SpookyBardHealer.Tiles.SecretPainting


				#region SpookyBardHealer.Items.SecretPainting
				TranslatorLoad.LocalizeByTypeFullName("SpookyBardHealer.Items.SecretPainting", "UpdateInventory", new ()
				{
					{"P L A C E   M E","放  置  我"},
				});
				TranslatorLoad.LocalizeByTypeFullName("SpookyBardHealer.Items.SecretPainting", "OnConsumeItem", new ()
				{
					{"A mɒsʇǝɹpiɘce","绝无仅有"},
					{"Bɘɒutiful!","漂亮！"},
					{"1 pǝǝu ʏ0u","打你"},
					{"A finɘ ɒɹʇwork","精美的艺术物品"},
				});
				TranslatorLoad.LocalizeByTypeFullName("SpookyBardHealer.Items.SecretPainting", "OnSpawn", new ()
				{
					{"D0n't lɘɒvǝ me!!!","不要离开我!!!"},
					{"Why mnsʇ y0u foɹsɒkǝ mɘ","你为什么不需要"},
				});
				TranslatorLoad.LocalizeByTypeFullName("SpookyBardHealer.Items.SecretPainting", "OnStack", new ()
				{
					{"Яǝunion!!","连接！！"},
					{"t0gɘtheɹ, sʇrongǝr!","专辑，强烈！"},
					{"Wǝ. Aɹe. Ouɘ!","我们在一起！"},
				});
				TranslatorLoad.LocalizeByTypeFullName("SpookyBardHealer.Items.SecretPainting", "OnPickup", new ()
				{
					{"Ͷevɘɿ leɒvǝ mǝ agɒin!","让我再来一次！"},
					{"GoOd, g0od!!","很好，很好！！"},
					{"Яǝunitɘd 0ncɘ more...","再现重逢......"},
				});
				#endregion SpookyBardHealer.Items.SecretPainting


			}
		}
	}
}
