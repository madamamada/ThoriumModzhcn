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
                // 英灵的爆轰法杖
                tooltipLine.Text = tooltipLine.Text.Replace("Shoots a magical burster missile that repeatedly attacks hit targets", "发射一枚神奇的导弹，反复攻击敌人");
                tooltipLine.Text = tooltipLine.Text.Replace("Bombarding doesn't necessarily mean blowing them up", "攻击并不一定意味着要打死他们");
                // 英灵的迅捷锋刃
                tooltipLine.Text = tooltipLine.Text.Replace("Shoots a powerful shockwave that deals 50% damage", "释放强力冲击波，对敌人造成50%的伤害");
                tooltipLine.Text = tooltipLine.Text.Replace("Every 3rd and 4th attack summons sword apparitions", "每次挥舞的第三和四次会召唤剑魂");
                // 泯灭者
                tooltipLine.Text = tooltipLine.Text.Replace("Left Click to shoot a non-piercing laser beam", "鼠标左键射出非穿透激光");
                tooltipLine.Text = tooltipLine.Text.Replace("Right Click to shoot a ball that shoots bullets at neaby targets that deal 60% damage", "鼠标右键释放光球，向附近的目标发射子弹，造成60%的伤害");
                tooltipLine.Text = tooltipLine.Text.Replace("Shooting the ball with the laser will cause it to bounce towards nearby targets and deal 500% damage", "用激光射击光球，让激光反弹到附近的目标，并造成500%的伤害");
                // 火山碎屑法杖
                tooltipLine.Text = tooltipLine.Text.Replace("Shoots a pattern of 1 to 5 pyroclastic fireballs", "发射出1到5个火焰光束");
                tooltipLine.Text = tooltipLine.Text.Replace("Pyroclastic fireballs split into submunitions on impact", "火焰光束撞击方块和击中敌人时会让其分裂");
                // 钯金冲锋枪
                tooltipLine.Text = tooltipLine.Text.Replace("Increases life regeneration over time while being used", "使用过程中，增加生命再生");
                // 钴蓝枪
                tooltipLine.Text = tooltipLine.Text.Replace("Increases defense over time while being used", "使用过程中，增加防御力");
                // 钛金来福枪
                tooltipLine.Text = tooltipLine.Text.Replace("Increases armor penetration over time while being used", "使用过程中，增加护甲穿透");
                // 秘银手枪
                tooltipLine.Text = tooltipLine.Text.Replace("Eventually doubles in attack speed while being used", "使用过一段时间后，攻击速度会翻倍");
                // 精金卡宾枪
                tooltipLine.Text = tooltipLine.Text.Replace("Increases crit chance over time while being used", "使用过程中，增加暴击率");
                // 山铜手枪
                tooltipLine.Text = tooltipLine.Text.Replace("Gradually increases attack speed over time while being used", "随着时间的推移逐渐增加攻击速度");
                // 花岗岩弩
                tooltipLine.Text = tooltipLine.Text.Replace("Every 3 shots, a volley of 3 granite arrows are shot which overflow enemies", "每3次射击发射3个花岗岩箭，会用能量溢向被击中的敌怪");
                tooltipLine.Text = tooltipLine.Text.Replace("Overflowed enemies take 5% more damage", "被溢散的敌怪多受5%伤害");
                tooltipLine.Text = tooltipLine.Text.Replace("Right click to heal all nearby allies equal to the weapon's holy charges at twice the mana cost", "右键会消耗所有当前的神圣充能治疗队友，治疗量为神圣充能的数量，但需要消耗两倍的魔力。");
                // 虚金弓，虚金破敌枪，虚金矛
                tooltipLine.Text = tooltipLine.Text.Replace("Damage will blast enemies with interdimensional energy", "武器攻击会用异次元能量诅咒敌人");
                tooltipLine.Text = tooltipLine.Text.Replace("Every 3rd attack smites the closest light accursed enemy with void light", "每3次攻击使用用虚空激光攻击，诅咒的敌人");
                tooltipLine.Text = tooltipLine.Text.Replace("Damage also spawns a flurry void light that slashes enemies quickly", "右击攻击对敌人产生多数攻击，并快速攻击面前敌人");
                // 奥米茄爆破枪
                tooltipLine.Text = tooltipLine.Text.Replace("Tap fire to shoot a triple burst of energy blasts, charge to empower the burst", "发射三个能量子弹，小幅度蓄力射出能量魔法阵（需要攻击在敌人身上，否则还是发射三个能量子弹）");
                tooltipLine.Text = tooltipLine.Text.Replace("Fully charge the weapon to fire a powerful energy beam that deal 800% damage", "大幅度蓄力后，发射能量光束，造成800%的伤害");
                tooltipLine.Text = tooltipLine.Text.Replace("Dealing damage with energy blasts build up a meter", "对敌人使用能量子弹造成伤害时会积累能量值");
                tooltipLine.Text = tooltipLine.Text.Replace("When the meter is full, Right Click to unleash a powerful beam saber that deals 1100% damage", "能量值充满后，右键释放一个的瞬移光剑，对敌人造成1100%的伤害");
                tooltipLine.Text = tooltipLine.Text.Replace("After beam saber is used, the energy gauge cannot build up for 10 second", "瞬移光剑使用后，能量值在10秒内不能充能");
                tooltipLine.Text = tooltipLine.Text.Replace("However, the weapon will cost no mana", "但是，该武器不消耗法力值");
                tooltipLine.Text = tooltipLine.Text.Replace("Become Heavenhold's greatest guardian", "成为天界最伟大的守护者");
                // 荧光矛
                tooltipLine.Text = tooltipLine.Text.Replace("Every 3rd attack, shoot out an illumite spear image", "每3次攻击发射荧光矛尖");
                tooltipLine.Text = tooltipLine.Text.Replace("The image shoots illuminating beams at nearby targets", "路过敌人时，额外发射荧光束");
                // 荧光弩，荧光炮，荧光冲击枪
                tooltipLine.Text = tooltipLine.Text.Replace("Every 6th attack summons a portal that shoots nearby enemies", "每射击6次攻击召唤一个传送门，攻击附近的敌人");
                // 荧光矛，荧光炮，荧光冲击枪，荧光弩
                tooltipLine.Text = tooltipLine.Text.Replace("Hit enemies will be illuminated and take 10% more damage", "被击中的敌人赋予荧光效果，并受到10%的伤害");
                // 荧光刃
                tooltipLine.Text = tooltipLine.Text.Replace("Dual wield two illumite blades", "挥舞两把荧光刃");
                tooltipLine.Text = tooltipLine.Text.Replace("Blasts nearby illuminated targets with illuminating beams", "挥舞时，对附近敌人发射荧光束");
                // 泰坦剑
                tooltipLine.Text = tooltipLine.Text.Replace("Dual wield two, titanic blades", "挥舞两把泰坦剑");
                tooltipLine.Text = tooltipLine.Text.Replace("Critical strikes will deal additional damage", "暴击会造成额外伤害");
                // 肉食者之牙，血肉串叉
                tooltipLine.Text = tooltipLine.Text.Replace("Dual wield two, life-stealing daggers", "挥舞两把肉食者之牙");
                tooltipLine.Text = tooltipLine.Text.Replace("Attacks have a chance to steal life, but briefly prevent life regeneration", "攻击有概率汲取生命，但会短暂禁用生命再生");
                tooltipLine.Text = tooltipLine.Text.Replace("Critical strikes have a guaranteed chance to return life and will not prevent life regeneration", "暴击有几率回复生命值");
                tooltipLine.Text = tooltipLine.Text.Replace("Right Click to release grasping blood at the cost of 1 life", "右键消耗1点生命值释放鲜血");
                // 灵魂镰刃
                tooltipLine.Text = tooltipLine.Text.Replace("Every 3rd and 4th attack, the scythe is spun, releasing volatile soul blades that deal 40% damage", "每次挥舞的第三和四次会释放旋转的灵魂之刃，造成40%的伤害");
                tooltipLine.Text = tooltipLine.Text.Replace("Volatile soul blades deal more damage the higher your attack speed is to compensate with reduced projectiles shot", "攻击速度越高，灵魂之刃造成的伤害就越高");
                // 地脉弓，地脉速射枪
                tooltipLine.Text = tooltipLine.Text.Replace("Damage will sunder enemies, increasing the damage they take by ", "对敌怪造成伤害会剥离它们，它们所受伤害增加");
                tooltipLine.Text = tooltipLine.Text.Replace("Every 3rd attack shoots magnetic payloads that home into sundered enemies", "每3次攻击都会向剥离的敌人发射地脉箭（若没有剥离状态敌人，发射五个地脉箭）");
                // 绿龙爪
                tooltipLine.Text = tooltipLine.Text.Replace("Attacking releases a breath of cursed inferno at the spear's tip", "攻击时会用诅咒焰束点燃受击敌怪");
                // 绿龙之牙
                tooltipLine.Text = tooltipLine.Text.Replace("Every 4th attack releases a breath of cursed inferno", "每次挥舞4次会释放诅咒焰");
                tooltipLine.Text = tooltipLine.Text.Replace("Critical strikes create a ring of cursed inferno", "对敌人攻击产生暴击时，从敌人身上释放多束诅咒焰");
                // 至尊之怒
                tooltipLine.Text = tooltipLine.Text.Replace("Every 4th attack shoots a powerful beam dealing triple damage", "每次挥舞4次会释放红色光束，造成三倍伤害");
                tooltipLine.Text = tooltipLine.Text.Replace("Right Click to unleash a flurry of attacks that deal half damage", "右击释放一连串攻击，造成一半伤害");
                tooltipLine.Text = tooltipLine.Text.Replace("We have a chainsaw sword at home", "我们家里有一把至尊之怒");
                // 元素誓约之剑
                tooltipLine.Text = tooltipLine.Text.Replace("Dual wield two Terrarium sabers", "挥舞两把元素誓约之剑");
                tooltipLine.Text = tooltipLine.Text.Replace("Releases homing Terrarium energy on hit", "攻击敌人后，释放追踪的元素能量");
                // 末日预言者硬币
                tooltipLine.Text = tooltipLine.Text.Replace("Inflicts Terminal Lucidity in phase 2, boss cannot be damaged until it is removed", "在第二阶段造成终极清醒减益，减益存在时噬梦者boss不会受到伤害");
                tooltipLine.Text = tooltipLine.Text.Replace("Fly into purple circles you see if you want to live and remove Terminal Lucidity", "触碰到紫色光环后，移除终极清醒减益");
                tooltipLine.Text = tooltipLine.Text.Replace("When Terminal Lucidity is removed, DPS phase begins and lasts for 15", "当终极清醒减益被移除后，进行伤害输出阶段并持续15");
                tooltipLine.Text = tooltipLine.Text.Replace("If Terminal Lucidity timer runs out, you will die instantly", "如果终极清醒减益倒计时结束，你会立即死亡");
                tooltipLine.Text = tooltipLine.Text.Replace("Dream Eater is permanently damageable during rematch fights", "击败一次始生灾灵后，拥有终极清醒减益不需要触碰到紫色法阵，也可以一直对噬梦者造成伤害");
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
