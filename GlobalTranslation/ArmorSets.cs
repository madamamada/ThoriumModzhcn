using Terraria;
using Terraria.ModLoader;
using ThoriumMod.Items.ArcaneArmor;
using ThoriumMod.Items.BardItems;
using ThoriumMod.Items.BossForgottenOne;
using ThoriumMod.Items.BossLich;
using ThoriumMod.Items.BossThePrimordials.Aqua;
using ThoriumMod.Items.BossThePrimordials.Dream;
using ThoriumMod.Items.BossThePrimordials.Omni;
using ThoriumMod.Items.BossThePrimordials.Rhapsodist;
using ThoriumMod.Items.BossThePrimordials.Slag;
using ThoriumMod.Items.Bronze;
using ThoriumMod.Items.Coral;
using ThoriumMod.Items.Darksteel;
using ThoriumMod.Items.DemonBlood;
using ThoriumMod.Items.Depths;
using ThoriumMod.Items.Dragon;
using ThoriumMod.Items.Dread;
using ThoriumMod.Items.EarlyMagic;
using ThoriumMod.Items.Flesh;
using ThoriumMod.Items.Geode;
using ThoriumMod.Items.Granite;
using ThoriumMod.Items.HealerItems;
using ThoriumMod.Items.Icy;
using ThoriumMod.Items.Illumite;
using ThoriumMod.Items.Lodestone;
using ThoriumMod.Items.MagicItems;
using ThoriumMod.Items.Misc;
using ThoriumMod.Items.Sandstone;
using ThoriumMod.Items.Steel;
using ThoriumMod.Items.SummonItems;
using ThoriumMod.Items.Terrarium;
using ThoriumMod.Items.Thorium;
using ThoriumMod.Items.ThrownItems;
using ThoriumMod.Items.Titan;
using ThoriumMod.Items.Valadium;

namespace ThoriumModzhcn.GlobalTranslation
{
    public class ArmorSets : GlobalItem
    {
        #region UpdateArmorSet
        public override void UpdateArmorSet(Player player, string set)
        {
            if (set == "FlightMaskSet")
            {
                player.setBonus = "你可以短暂飞行";
            }
            else if (set == "LichCowlSet")
            {
                player.setBonus = "击杀敌怪会释放一道灵魂碎片\n接触灵魂碎片会短暂地大幅增加你的移动速度和投掷速度";
            }
            else if (set == "TideTurnersGazeSet")
            {
                player.setBonus = "投掷伤害有20%概率在你周围释放追踪海潮飞刀";
            }
            else if (set == "BronzeHelmetSet")
            {
                player.setBonus = "投掷伤害有20%概率释放一道穿透性闪电";
            }
            else if (set == "AncientHallowedChapeauSet")
            {
                player.setBonus = "击中敌怪后进入免疫状态且增加8秒你音波咒音增幅的持续时间";
            }
            else if (set == "AncientHallowedCowlSet")
            {
                player.setBonus = "击中敌怪后进入免疫状态且治疗法术会额外治疗6点生命值";
            }
            else if (set == "AncientHallowedGuiseSet")
            {
                player.setBonus = "击中敌怪后进入免疫状态并增加2点最大技巧值";
            }
            else if (set == "HallowedGuiseSet")
            {
                player.setBonus = "击中敌怪后进入免疫状态并增加2点最大技巧值";
            }
            else if (set == "SandStoneHelmetSet")
            {
                player.setBonus = "沙漠之风为你提供了一次沙质二段跳";
            }
            else if (set == "FungusHatSet")
            {
                player.setBonus = "对受真菌影响的敌怪造成的伤害增加10%\n对受真菌影响的敌怪造成伤害时会短暂增加10%投掷速度";
            }
            else if (set == "PlagueDoctorsMaskSet")
            {
                player.setBonus = "你的瘟疫云在空中的滞留时间翻倍且你的瘟疫连锁反应多造成20%伤害";
            }
            else if (set == "ShadeMasterMaskSet")
            {
                player.setBonus = "你所受伤害的50%会束缚在接下来的10秒内";
            }
            else if (set == "WhiteDwarfMaskSet")
            {
                player.setBonus = "暴击会从星宇释放象牙状火焰\n象牙状火焰会造成被击中目标0.1%生命值的伤害";
            }
        }
        #endregion
        #region IsArmorSet
        public override string IsArmorSet(Item head, Item body, Item legs)
        {
            bool ArmorSetCheck<T>() where T : ModItem => head.type == ModContent.ItemType<T>() && head.ModItem.IsArmorSet(head, body, legs);
            if (ArmorSetCheck<FlightMask>()) return "FlightMaskSet";
            if (ArmorSetCheck<LichCowl>()) return "LichCowlSet";
            if (ArmorSetCheck<TideTurnersGaze>()) return "TideTurnersGazeSet";
            if (ArmorSetCheck<BronzeHelmet>()) return "BronzeHelmetSet";
            if (ArmorSetCheck<AncientHallowedChapeau>()) return "AncientHallowedChapeauSet";
            if (ArmorSetCheck<AncientHallowedCowl>()) return "AncientHallowedCowlSet";
            if (ArmorSetCheck<AncientHallowedGuise>()) return "AncientHallowedGuiseSet";
            if (ArmorSetCheck<HallowedGuise>()) return "HallowedGuiseSet";
            if (ArmorSetCheck<SandStoneHelmet>()) return "SandStoneHelmetSet";
            if (ArmorSetCheck<FungusHat>()) return "FungusHatSet";
            if (ArmorSetCheck<PlagueDoctorsMask>()) return "PlagueDoctorsMaskSet";
            if (ArmorSetCheck<ShadeMasterMask>()) return "ShadeMasterMaskSet";
            if (ArmorSetCheck<WhiteDwarfMask>()) return "WhiteDwarfMaskSet";
            return string.Empty;
        }
        #endregion
    }
}
