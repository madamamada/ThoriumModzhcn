using Terraria.Localization;
using Terraria.ModLoader;

namespace ThoriumModzhcn
{
	internal static class ModsCall
	{
		internal static Mod Thorium
		{
			get
			{
				if (!ModLoader.TryGetMod("ThoriumMod", out Mod thorium))
				{
					return null;
				}
				return thorium;
			}
		}
	}
}