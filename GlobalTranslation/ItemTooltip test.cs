using System.Collections.Generic;
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
using ThoriumMod.Items.Donate;

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
                }
                // 伤害标签
                tooltipLine.Text = tooltipLine.Text.Replace("-Reality Breaker-", "-现实破坏者-");
                tooltipLine.Text = tooltipLine.Text.Replace("-Early Testing-", "-早期测试物品-");

                // 救赎伤害标签
                tooltipLine.Text = tooltipLine.Text.Replace("-Donator Item-", "-捐赠者项目-");

                // 瑟银额外模组伤害标签
                tooltipLine.Text = tooltipLine.Text.Replace("-Warrior Class-", "-近战职业-");
                tooltipLine.Text = tooltipLine.Text.Replace("-Sorcerer Class-", "-魔法师职业-");
                tooltipLine.Text = tooltipLine.Text.Replace("-Ranger Class-", "-远程职业-");
                tooltipLine.Text = tooltipLine.Text.Replace("-Summoner Class-", "-召唤师职业-");

                // 重售吟游诗人武器伤害加成
                tooltipLine.Text = tooltipLine.Text.Replace("s empowerment duration", "s咒音增幅时间");

                //牧师链球
                tooltipLine.Text = tooltipLine.Text.Replace("Heals ally and player life equal to your bonus healing", "治疗队友和玩家等同于治疗加成的生命值");
                tooltipLine.Text = tooltipLine.Text.Replace("Heals ally life equal to your bonus healing", "治疗队友等同于治疗加成的生命值");

                //牧师武器加成
                tooltipLine.Text = Regex.Replace(tooltipLine.Text, "(Uses )([0-9]+)( mana & )([0-9]+)( life)", "使用$2魔力和$4生命值");
                tooltipLine.Text = Regex.Replace(tooltipLine.Text, "( & )([0-9]+)( life)", "和$2生命值");
                tooltipLine.Text = Regex.Replace(tooltipLine.Text, "(Grants )([0-9]+)( soul essence on direct hit)", "直接命中会获得$2层灵魂精华");
                tooltipLine.Text = Regex.Replace(tooltipLine.Text, "(Shields ally life by )([0-9]+)( up to 50)", "为队友施加$2点生命护盾，至多50点");
                tooltipLine.Text = Regex.Replace(tooltipLine.Text, "(Heals ally and player life by )([0-9]+)", "治疗队友和玩家$2点生命值");
                tooltipLine.Text = Regex.Replace(tooltipLine.Text, "(Steals )([0-9]+)( life)", "汲取$2点生命值");
                tooltipLine.Text = Regex.Replace(tooltipLine.Text, "(Right click to heal all nearby allies by )([0-9]+)( life)", "右键单击治疗附近所有队友$2生命值");
                tooltipLine.Text = Regex.Replace(tooltipLine.Text, "(Heals ally life by )([0-9]+)( every second)", "每秒治疗队友$2生命值");
                tooltipLine.Text = Regex.Replace(tooltipLine.Text, "(Heals ally life by )([0-9]+)", "治疗队友$2点生命值");
                tooltipLine.Text = tooltipLine.Text.Replace("Heals player life equal to (", "治疗玩家等同于上次受到伤害(");
                tooltipLine.Text = tooltipLine.Text.Replace(") of the last damage they took", ")的生命值");
                tooltipLine.Text = Regex.Replace(tooltipLine.Text, "(Instantly recovers )([0-9]+)( life)", "立刻恢复$2生命值");
                tooltipLine.Text = tooltipLine.Text.Replace("Sacrifices your own life to heal all allies in the world for ", "牺牲自身生命治疗世界中所有队友");
                tooltipLine.Text = tooltipLine.Text.Replace("Uses 2.5% of your maximum life", "消耗自身2.5%最大生命值，治疗队友7.5%最大生命值");
                tooltipLine.Text = Regex.Replace(tooltipLine.Text, "(Channel the tome, turning )([0-9]+)( mana into )([0-9]+)( life every second)", "持续使用法术书，每秒将$2魔力转化为$4生命值");
                tooltipLine.Text = tooltipLine.Text.Replace("After popping, all nearby allies are healed by ", "爆炸后治疗附近所有队友");
                tooltipLine.Text = Regex.Replace(tooltipLine.Text, "(Shields ally and player life by )([0-9]+)( up to 25)", "为玩家和队友施加$2点生命护盾，至多25点");
                tooltipLine.Text = tooltipLine.Text.Replace("You can taste the energy in every bite", "每一口都充满力量");
                tooltipLine.Text = tooltipLine.Text.Replace("Heals (20) ally life over 5 seconds", "在5秒内治疗(20)点队友生命");
                tooltipLine.Text = tooltipLine.Text.Replace("Increases the damage of all nearby allies by 20% for ", "增加附近所有队友20%伤害，持续");


                // 钱袋子等等
                tooltipLine.Text = tooltipLine.Text.Replace("Money Generated: ", "额外掉落钱币: ");
                tooltipLine.Text = tooltipLine.Text.Replace("Duplicated Items: ", "复制物品数量: ");
                tooltipLine.Text = tooltipLine.Text.Replace(" coins", " 钱币");
                tooltipLine.Text = tooltipLine.Text.Replace(" items", " 物品");

                // 元素自动竖琴1
                tooltipLine.Text = tooltipLine.Text.Replace("Variety ", "多种音波脉冲 ");

                // forgos
                tooltipLine.Text = tooltipLine.Text.Replace("After the boss has been defeated", "在boss打败之后");
                tooltipLine.Text = tooltipLine.Text.Replace(" An Ogre", " 食人魔");

                // 暗影之门
                tooltipLine.Text = Regex.Replace(tooltipLine.Text, "(The gateways can only be used by players every )([0-9]+)( second)", "传送门只能每过$2秒使用");

                // 平平无奇的紫色石头
                tooltipLine.Text = tooltipLine.Text.Replace("1% of targets health as true damage", "1%目标最大生命值的真实伤害");
            }
        }
    }
}