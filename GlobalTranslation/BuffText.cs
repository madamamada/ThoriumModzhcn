using System;
using System.Text.RegularExpressions;
using Terraria.ModLoader;
using ThoriumMod.Buffs.Healer;

namespace ThoriumModzhcn.GlobalTranslation
{
	public class BuffTrans : GlobalBuff
	{
		public override void ModifyBuffText(int type, ref string buffName, ref string tip, ref int rare)
		{
			tip = Regex.Replace(tip, "(Upon reaching 5 stacks of soul essence, you recover \\()([0-9]+)(\\) health and \\()([0-9]+)(\\) mana)", "每获得5点灵魂精华，回复$2生命值和$4魔力值");
		}
	}
}

