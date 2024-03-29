﻿using System.Collections.Generic;
using System.Text.RegularExpressions;
using Terraria;
using Terraria.ModLoader;
using ThoriumMod.Items;
using ThoriumRework.Items;
using ThoriumMod.Items.Donate;
using ThoriumMod.Items.MagicItems;
using ThoriumMod.Items.MeleeItems;
using ThoriumMod.Items.HealerItems;
using ThoriumMod.Items.RangedItems;
using ThoriumMod.Items.ThrownItems;
using ThoriumMod.Items.BardItems;
using ThoriumMod.Items.SummonItems;

namespace ThoriumModzhcn.Items
{
    public class ItemTooltips : GlobalItem
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            foreach (TooltipLine tooltipLine in tooltips)
            {
                if (item.type == ModContent.ItemType<ProofAvarice>())
                {
                    tooltipLine.Text = tooltipLine.Text.Replace(", and", "");
                    tooltipLine.Text = tooltipLine.Text.Replace("gold", "金");
                    tooltipLine.Text = tooltipLine.Text.Replace("silver", "银");
                    tooltipLine.Text = tooltipLine.Text.Replace("copper", "铜");
                }
                tooltipLine.Text = tooltipLine.Text.Replace("-Bard Class-", "-吟游诗人-");
                tooltipLine.Text = tooltipLine.Text.Replace("-Healer Class-", "-牧师-");
                tooltipLine.Text = tooltipLine.Text.Replace("-Thrower Class-", "-投手-");
                tooltipLine.Text = tooltipLine.Text.Replace("-Reality Breaker-", "-现实破坏者-");
                tooltipLine.Text = tooltipLine.Text.Replace("-Transformation-", "-化形-");
                tooltipLine.Text = tooltipLine.Text.Replace("-Early Testing-", "-早期测试物品-");
                tooltipLine.Text = tooltipLine.Text.Replace("-铜管 Instrument-", "-铜管乐器-");
                tooltipLine.Text = tooltipLine.Text.Replace("-管 Instrument-", "-管乐器-");
                tooltipLine.Text = tooltipLine.Text.Replace("-弦 Instrument-", "-弦乐器-");
                tooltipLine.Text = tooltipLine.Text.Replace("-打击 Instrument-", "-打击乐器-");
                tooltipLine.Text = tooltipLine.Text.Replace("-电子 Instrument-", "-电子乐器-");
                // 原瑟银
                tooltipLine.Text = tooltipLine.Text.Replace("Allows you to use unique abilities while transformed", "允许你在化形时使用独特的能力");
                tooltipLine.Text = tooltipLine.Text.Replace("Playing empowers players with bonus", "演奏会提供玩家以下加成");
                tooltipLine.Text = tooltipLine.Text.Replace("The cook might be interested in this", "厨师可能对此感兴趣");
                tooltipLine.Text = tooltipLine.Text.Replace("Heals ally and player life equal to your bonus healing", "治疗队友和玩家等同于治疗加成的生命值");
                tooltipLine.Text = tooltipLine.Text.Replace("Heals ally life equal to your bonus healing", "治疗队友等同于治疗加成的生命值");
                tooltipLine.Text = tooltipLine.Text.Replace("Increases the damage of all nearby allies by 20% for ", "增加附近所有队友20%伤害，持续");
                tooltipLine.Text = tooltipLine.Text.Replace("Heals player life equal to (", "治疗玩家等同于上次受到伤害(");
                tooltipLine.Text = tooltipLine.Text.Replace(") of the last damage they took", ")的生命值");
                tooltipLine.Text = Regex.Replace(tooltipLine.Text, "(Uses )([0-9]+)( inspiration)", "使用$2灵感值");
                tooltipLine.Text = Regex.Replace(tooltipLine.Text, "(Uses )([0-9]+)( mana & )([0-9]+)( life)", "使用$2魔力和$4生命值");
                tooltipLine.Text = Regex.Replace(tooltipLine.Text, "( & )([0-9]+)( life)", "和$2生命值");
                tooltipLine.Text = Regex.Replace(tooltipLine.Text, "(Grants )([0-9]+)( soul essence on direct hit)", "直接命中会获得$2层灵魂精华");
                tooltipLine.Text = Regex.Replace(tooltipLine.Text, "(Shields ally life by )([0-9]+)( up to 50)", "为队友施加$2点生命护盾，至多50点");
                tooltipLine.Text = Regex.Replace(tooltipLine.Text, "(Heals ally life by )([0-9]+)", "治疗队友$2点生命值");
                tooltipLine.Text = Regex.Replace(tooltipLine.Text, "(Heals ally and player life by )([0-9]+)", "治疗队友和玩家$2点生命值");
                tooltipLine.Text = Regex.Replace(tooltipLine.Text, "(Steals )([0-9]+)( life)", "偷取$2点生命值");
                tooltipLine.Text = tooltipLine.Text.Replace("Right click to heal all nearby allies equal to your bonus healing", "右键单击治疗附近所有队友，治疗量等于治疗加成");
                tooltipLine.Text = Regex.Replace(tooltipLine.Text, "(Right click to heal all nearby allies by )([0-9]+)( life)", "右键单击治疗附近所有队友$2生命值");
                // 爆米花
                tooltipLine.Text = tooltipLine.Text.Replace("Throws out (", "扔出(");
                tooltipLine.Text = tooltipLine.Text.Replace(") eatable popcorn kernels", ")个可食用的爆米花粒");
                tooltipLine.Text = tooltipLine.Text.Replace("Up to (", "同时可以扔出至多(");
                tooltipLine.Text = tooltipLine.Text.Replace(") kernels may be out at once", ")个爆米花粒");
                tooltipLine.Text = tooltipLine.Text.Replace("Popcorn does not apply on heal effects when consumed", "爆米花消耗时不会施加治疗效果");
                tooltipLine.Text = Regex.Replace(tooltipLine.Text, "(Instantly recovers )([0-9]+)( life)", "立刻恢复$2生命值");
                tooltipLine.Text = tooltipLine.Text.Replace("Sacrifices your own life to heal all allies in the world for ", "牺牲自身生命治疗世界中所有队友");
                tooltipLine.Text = tooltipLine.Text.Replace("Uses 2.5% of your maximum life", "消耗自身2.5%最大生命值，治疗队友7.5%最大生命值");
                tooltipLine.Text = Regex.Replace(tooltipLine.Text, "(Channel the tome, turning )([0-9]+)( mana into )([0-9]+)( life every second)", "持续使用法术书，每秒将$2魔力转化为$4生命值");
                tooltipLine.Text = Regex.Replace(tooltipLine.Text, "(Your instruments play )([0-9]+)(% faster)", "你的乐器演奏速度快$2%");
                tooltipLine.Text = tooltipLine.Text.Replace("After popping, all nearby allies are healed by ", "爆炸后治疗附近所有队友");
                tooltipLine.Text = Regex.Replace(tooltipLine.Text, "(Heals ally life by )([0-9]+)( every second)", "每秒治疗队友$2生命值");
                tooltipLine.Text = Regex.Replace(tooltipLine.Text, "(Shields ally and player life by )([0-9]+)( up to 25)", "为玩家和队友施加$2点生命护盾，至多25点");
                tooltipLine.Text = tooltipLine.Text.Replace("You can taste the energy in every bite", "每一口都充满力量");
                tooltipLine.Text = tooltipLine.Text.Replace("Heals (20) ally life over 5", "治疗(20)队友生命超过5点");
                tooltipLine.Text = tooltipLine.Text.Replace(" empowerment duration", " 咒音增幅持续时间");
                tooltipLine.Text = tooltipLine.Text.Replace("Money Generated: ", "额外掉落钱币: ");
                tooltipLine.Text = tooltipLine.Text.Replace(" coins", " 金币");
                tooltipLine.Text = tooltipLine.Text.Replace("Duplicated Items: ", "复制物品数量: ");
                tooltipLine.Text = tooltipLine.Text.Replace(" items", " 物品");
                tooltipLine.Text = tooltipLine.Text.Replace(" base damage", " 基础伤害");
                tooltipLine.Text = tooltipLine.Text.Replace(" basic damage", " 基本伤害");
                tooltipLine.Text = tooltipLine.Text.Replace(" seconds", "秒");
                tooltipLine.Text = tooltipLine.Text.Replace("Variety ", "多种音波脉冲 ");
                tooltipLine.Text = tooltipLine.Text.Replace("After the boss has been defeated", "在boss打败之后");
                tooltipLine.Text = tooltipLine.Text.Replace("(Max)", "(已达最大值)");
                tooltipLine.Text = tooltipLine.Text.Replace("(4 Max)", "(4点最大生命值)");
                tooltipLine.Text = tooltipLine.Text.Replace("(5 Max)", "(5点最大生命值)");
                tooltipLine.Text = tooltipLine.Text.Replace(" An Ogre", " 食人魔");
                tooltipLine.Text = tooltipLine.Text.Replace("The gateways can only be used by players every ", "传送门只能每过 ");
                tooltipLine.Text = tooltipLine.Text.Replace(" second(s)", "秒使用");
                tooltipLine.Text = tooltipLine.Text.Replace("1% of targets health as true damage", "1%目标最大生命值的真实伤害");
            }
        }
    }
}
