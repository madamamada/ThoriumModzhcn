using System.Text.RegularExpressions;
using Terraria;
using Terraria.ModLoader;
using ThoriumMod;
using ThoriumMod.Buffs.Healer;
using ThoriumMod.Utilities;

namespace ThoriumModzhcn.GlobalTranslation
{
    public class BuffTrans : GlobalBuff
    {
        public override void ModifyBuffText(int type, ref string buffName, ref string tip, ref int rare)
        {
            if (type == ModContent.BuffType<SoulEssence>())
            {
                ThoriumPlayer thoriumPlayer = Main.LocalPlayer.GetThoriumPlayer();
                tip = $"每获得5点灵魂精华，恢复（{1 + thoriumPlayer.healBonus}）生命和（{3 + thoriumPlayer.healBonus * 3}）魔力";
            }
        }
    }
}