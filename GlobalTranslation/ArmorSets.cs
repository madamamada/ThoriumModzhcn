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
            else if (set == "YewWoodHelmetSet")
            {
                player.setBonus = "4次非暴击攻击后下次远程攻击会是造成150%伤害的小暴击";
            }
            else if (set == "CriersCapSet")
            {
                player.setBonus = "你的音波咒音增幅会额外持续 3 秒";
            }
            else if (set == "SoloistHatSet")
            {
                player.setBonus = "按下“盔甲能力”键会让你获得无限的灵感值，大幅增加音波伤害和演奏速度\n此效果持续10秒并需要重新充能1分钟";
            }
            else if (set == "CyberPunkHeadsetSet")
            {
                player.setBonus = "按下“盔甲能力”键会在 4 种状态间切换：\n红：玩家和附近队友获得固定伤害 II 和伤害 II\n绿：玩家和附近队友获得移动速度 II 和飞行时间 II\n紫：玩家和附近队友获得资源上限 II 和资源再生 II\n蓝：玩家和附近队友获得防御 II 和伤害减免 II";
            }
            else if (set == "JestersMaskSet")
            {
                player.setBonus = "掉落的灵感音符效果翻倍且会短暂增加你的音波伤害";
            }
            else if (set == "JestersMask2Set")
            {
                player.setBonus = "掉落的灵感音符效果翻倍且会短暂增加你的音波伤害";
            }
            else if (set == "MaestroWigSet")
            {
                player.setBonus = "按下盔甲能力键时召唤一个持续 20 秒的陨落合唱团。\n陨落合唱团由四个鬼魂音乐家组成，分别使用铜管乐器，管乐器，弦乐器和打击乐器，会自动向附近敌怪发射弹幕。\n召唤陨落合唱团时会受到陨落合唱团减益。\n60 秒内无法再次召唤它们";
            }
            else if (set == "MarchingBandCapSet")
            {
                player.setBonus = "战斗中，一个伤害性的彩虹音波符号会跟随你的移动并晕眩敌怪";
            }
            else if (set == "NoblesHatSet")
            {
                player.setBonus = "掉落的灵感音符效果翻倍且会短暂增加你的音波伤害";
            }
            else if (set == "OrnateHatSet")
            {
                player.setBonus = "音波暴击会使随机激活的咒音增幅提升到 IV 级强度";
            }
            else if (set == "ShootingStarHatSet")
            {
                player.setBonus = "使咒音增幅持续时间延长 6 秒\n玩家拥有的每个独特的咒音增幅会\n增加5%音波伤害和2%灵感值再生";
            }
            else if (set == "WhisperingHoodSet")
            {
                player.setBonus = "你会偶尔产生一根深渊能量触手攻击附近敌怪\n你可以拥有至多6根触手且它们的伤害会从被击中的敌怪吸取1点生命和魔力";
            }
            else if (set == "LichCowlSet")
            {
                player.setBonus = "击杀敌怪会释放一道灵魂碎片\n接触灵魂碎片会短暂地大幅增加你的移动速度和投掷速度";
            }
            else if (set == "TideTurnerHelmetSet")
            {
                player.setBonus = "按下“盔甲能力”键会将你包裹在密不透风发泡泡中，将所有受到的伤害转化为治疗";
            }
            else if (set == "TideTurnersGazeSet")
            {
                player.setBonus = "投掷伤害有20%概率在你周围释放追踪海潮飞刀";
            }
            else if (set == "DreamWeaversHoodSet")
            {
                player.setBonus = "按下“盔甲能力”键会消耗200魔力并将你放置在梦中\n在梦中时，被治疗的队友会变得短暂无敌且所有减益都会被治愈";
            }
            else if (set == "DreamWeaversHelmetSet")
            {
                player.setBonus = "按下“盔甲能力”键会消耗200魔力并扭曲现实结构\n敌怪会被大幅减速且受到所有来源的伤害增加15%\n队友会大幅增加移动速度和攻击速度，并将到来的非致命伤害转化为治疗";
            }
            else if (set == "MasterArbalestHoodSet")
            {
                player.setBonus = "你的伤害有10%概率完全复制自身并多造成15%伤害";
            }
            else if (set == "MasterMarksmansScouterSet")
            {
                player.setBonus = "你的远程伤害有5%概率完全湮灭击中的目标\n此效果只能在Boss生命值低于5%时生效";
            }
            else if (set == "InspiratorsHelmetSet")
            {
                player.setBonus = "按下“盔甲能力”键会用每种III级咒音增幅过载所有附近队友15秒\n使用此能力需要20点灵感值且必须重新充能1分钟";
            }
            else if (set == "InspiratorsHelmetSet")
            {
                player.setBonus = "按下“盔甲能力”键会让你获得无限的灵感值，大幅增加音波伤害和演奏速度\n此效果持续10秒并需要重新充能1分钟";
            }
            else if (set == "MagmaSeersMaskSet")
            {
                player.setBonus = "所有仆从伤害会滞留下造成大量伤害的灼烧";
            }
            else if (set == "PyromancerCowlSet")
            {
                player.setBonus = "你的魔法伤害会造成严重烧伤并伤害所有附近敌怪";
            }
            else if (set == "BronzeHelmetSet")
            {
                player.setBonus = "投掷伤害有20%概率释放一道穿透性闪电";
            }
            else if (set == "CoralHelmetSet")
            {
                player.setBonus = "光辉伤害会建立至多20点生命护盾且你的生命护盾不会随时间衰减\n治疗队友会将生命护盾转移到他们身上";
            }
            else if (set == "DarksteelFaceGuardSet")
            {
                player.setBonus = "没有什么能阻挡你的移动！双击来冲刺！";
            }
            else if (set == "DemonBloodHelmetSet")
            {
                player.setBonus = "最大生命值增加100";
            }
            else if (set == "DepthDiverHelmetSet")
            {
                player.setBonus = "你也会获得自身产生的效果";
            }
            else if (set == "NagaSkinMaskSet")
            {
                player.setBonus = "每消耗75魔力会短暂地大幅增加你的魔法伤害和施法速度";
            }
            else if (set == "TideHunterCapSet")
            {
                player.setBonus = "远程暴击会释放一堆泡沫，减速附近敌怪";
            }
            else if (set == "DragonMaskSet")
            {
                player.setBonus = "攻击有概率释放龙焰爆炸";
            }
            else if (set == "DreadSkullSet")
            {
                player.setBonus = "你的靴子以不真实的频率振动，大幅增加基础移动速度\n移动时，你的近战伤害和暴击率增加";
            }
            else if (set == "FallenPaladinFaceguardSet")
            {
                player.setBonus = "受到伤害会治疗附近队友所受伤害15%的生命值";
            }
            else if (set == "IridescentHelmetSet")
            {
                player.setBonus = "你的光辉伤害有15%概率释放一道致盲闪光\n闪光会以你的治疗加成治疗所有附近队友并困惑敌怪";
            }
            else if (set == "Lelse ifeBinderMaskSet")
            {
                player.setBonus = "治疗法术会短暂增加被治疗玩家50点最大生命值";
            }
            else if (set == "SilkHatSet")
            {
                player.setBonus = "高于90%魔力时增加12%魔法伤害";
            }
            else if (set == "FleshMaskSet")
            {
                player.setBonus = "受伤时伤害敌怪有10%概率掉落肉\n收集肉会恢复生命并获得伤害加成";
            }
            else if (set == "GeodeHelmetSet")
            {
                player.setBonus = "你现在可以一次挖掘整个矿脉";
            }
            else if (set == "GraniteHelmetSet")
            {
                player.setBonus = "免疫高温和敌怪击退，但你的移动速度大幅降低";
            }
            else if (set == "BioTechHoodSet")
            {
                player.setBonus = "一个生物工程探测器会协助你治疗队友\n治疗队友等同于你治疗加成的生命值";
            }
            else if (set == "BloomingCrownSet")
            {
                player.setBonus = "你的治疗法术会增加被治疗目标的生命恢复和生命恢复速率";
            }
            else if (set == "CelestialCrownSet")
            {
                player.setBonus = "按下盔甲能力键会消耗150魔力在你的光标周围召唤一个大型光环\n光环接触的队友会获得伤害，伤害减免，防御和生命恢复的提升\n光环接触的敌怪会受到神圣之怒且受到所有来源的伤害增加15%";
            }
            else if (set == "EbonHoodSet")
            {
                player.setBonus = "腐化你的光辉能量，使它们呈现黑暗形态并造成额外效果";
            }
            else if (set == "NoviceClericCowlSet")
            {
                player.setBonus = "每5秒你会生成至多3个神圣十字架\n在使用治疗法术时会消耗1个十字架而不是魔力";
            }
            else if (set == "SacredHelmetSet")
            {
                player.setBonus = "治疗法术会额外治疗5点生命值";
            }
            else if (set == "TemplarsCircletSet")
            {
                player.setBonus = "如果队友生命值低于一半，你会获得治疗能力提升";
            }
            else if (set == "WarlockHoodSet")
            {
                player.setBonus = "光辉攻击会生成至多15颗暗影微粒\n按下“盔甲能力”键会向光标位置释放所有存储的暗影微粒";
            }
            else if (set == "IcyHeadgearSet")
            {
                player.setBonus = "一个冰光环环绕着你，冻结待在其中太久的敌怪";
            }
            else if (set == "IllumiteMaskSet")
            {
                player.setBonus = "你的弓，枪和发射器会定期发射额外弹幕";
            }
            else if (set == "LodeStoneFaceGuardSet")
            {
                player.setBonus = "每失去25%生命值增加6%伤害减免\n低于25%生命值时伤害减免到达最大18%";
            }
            else if (set == "CryomancersCrownSet")
            {
                player.setBonus = "你的魔法攻击会冻结敌怪2秒";
            }
            else if (set == "WhiteKnightMaskSet")
            {
                player.setBonus = "你消耗魔力的40%会存储为能量，上限400\n按下“盔甲能力”键会消耗存储的能量回复至多200魔力和20生命";
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
            else if (set == "ConduitHelmetSet")
            {
                player.setBonus = "不断移动会生成至多5个静态环，每个都会为你添加生命护盾\n满充能时，一个能量泡泡会保护你免受一次攻击\n泡泡阻挡攻击后会向附近敌怪释放电束";
            }
            else if (set == "HallowedChapeauSet")
            {
                player.setBonus = "击中敌怪后进入免疫状态且增加8秒你音波咒音增幅的持续时间";
            }
            else if (set == "HallowedCowlSet")
            {
                player.setBonus = "击中敌怪后进入免疫状态且治疗法术会额外治疗6点生命值";
            }
            else if (set == "HallowedGuiseSet")
            {
                player.setBonus = "击中敌怪后进入免疫状态并增加2点最大技巧值";
            }
            else if (set == "SandStoneHelmetSet")
            {
                player.setBonus = "沙漠之风为你提供了一次沙质二段跳";
            }
            else if (set == "DurasteelHelmetSet")
            {
                player.setBonus = "受到的伤害降低10%";
            }
            else if (set == "SteelHelmetSet")
            {
                player.setBonus = "+8% 伤害减免";
            }
            else if (set == "AstroHelmetSet")
            {
                player.setBonus = "仆从伤害击中时有概率释放一场魔法脉冲爆发";
            }
            else if (set == "Lelse ifeBloomMaskSet")
            {
                player.setBonus = "仆从攻击击中时有25%概率治疗你\n10秒内你无法治疗超过50点生命值";
            }
            else if (set == "LivingWoodMaskSet")
            {
                player.setBonus = "最大仆从数量增加1\n生命木橡子的自动攻击会追踪敌怪";
            }
            else if (set == "TerrariumHelmetSet")
            {
                player.setBonus = "当你在战斗中时泰拉瑞亚的能量会追寻并保护你";
            }
            else if (set == "ThoriumHelmetSet")
            {
                player.setBonus = "造成的伤害增加10%";
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
            else if (set == "TitanMaskSet")
            {
                player.setBonus = "造成的伤害增加18%！";
            }
            else if (set == "TitanHelmetSet")
            {
                player.setBonus = "造成的伤害增加18%！";
            }
            else if (set == "ValadiumHelmetSet")
            {
                player.setBonus = "按下up翻转重力。翻转时，远程伤害增加15%！";
            }
        }
        #endregion
        #region IsArmorSet
        public override string IsArmorSet(Item head, Item body, Item legs)
        {
            bool ArmorSetCheck<T>() where T : ModItem => head.type == ModContent.ItemType<T>() && head.ModItem.IsArmorSet(head, body, legs);
            if (ArmorSetCheck<FlightMask>()) return "FlightMaskSet";
            if (ArmorSetCheck<YewWoodHelmet>()) return "YewWoodHelmetSet";
            if (ArmorSetCheck<CriersCap>()) return "CriersCapSet";
            if (ArmorSetCheck<CyberPunkHeadset>()) return "CyberPunkHeadsetSet";
            if (ArmorSetCheck<JestersMask>()) return "JestersMaskSet";
            if (ArmorSetCheck<JestersMask2>()) return "JestersMask2Set";
            if (ArmorSetCheck<MaestroWig>()) return "MaestroWigSet";
            if (ArmorSetCheck<MarchingBandCap>()) return "MarchingBandCapSet";
            if (ArmorSetCheck<NoblesHat>()) return "NoblesHatSet";
            if (ArmorSetCheck<OrnateHat>()) return "OrnateHatSet";
            if (ArmorSetCheck<ShootingStarHat>()) return "ShootingStarHatSet";
            if (ArmorSetCheck<WhisperingHood>()) return "WhisperingHoodSet";
            if (ArmorSetCheck<LichCowl>()) return "LichCowlSet";
            if (ArmorSetCheck<TideTurnerHelmet>()) return "TideTurnerHelmetSet";
            if (ArmorSetCheck<TideTurnersGaze>()) return "TideTurnersGazeSet";
            if (ArmorSetCheck<DreamWeaversHood>()) return "DreamWeaversHoodSet";
            if (ArmorSetCheck<DreamWeaversHelmet>()) return "DreamWeaversHelmetSet";
            if (ArmorSetCheck<MasterArbalestHood>()) return "MasterArbalestHoodSet";
            if (ArmorSetCheck<MasterMarksmansScouter>()) return "MasterMarksmansScouterSet";
            if (ArmorSetCheck<InspiratorsHelmet>()) return "InspiratorsHelmetSet";
            if (ArmorSetCheck<SoloistHat>()) return "SoloistHatSet";
            if (ArmorSetCheck<MagmaSeersMask>()) return "MagmaSeersMaskSet";
            if (ArmorSetCheck<PyromancerCowl>()) return "PyromancerCowlSet";
            if (ArmorSetCheck<BronzeHelmet>()) return "BronzeHelmetSet";
            if (ArmorSetCheck<CoralHelmet>()) return "CoralHelmetSet";
            if (ArmorSetCheck<DarksteelFaceGuard>()) return "DarksteelFaceGuardSet";
            if (ArmorSetCheck<DemonBloodHelmet>()) return "DemonBloodHelmetSet";
            if (ArmorSetCheck<DepthDiverHelmet>()) return "DepthDiverHelmetSet";
            if (ArmorSetCheck<NagaSkinMask>()) return "NagaSkinMaskSet";
            if (ArmorSetCheck<TideHunterCap>()) return "TideHunterCapSet";
            if (ArmorSetCheck<DragonMask>()) return "DragonMaskSet";
            if (ArmorSetCheck<DreadSkull>()) return "DreadSkullSet";
            if (ArmorSetCheck<FallenPaladinFaceguard>()) return "FallenPaladinFaceguardSet";
            if (ArmorSetCheck<IridescentHelmet>()) return "IridescentHelmetSet";
            if (ArmorSetCheck<LifeBinderMask>()) return "LifeBinderMaskSet";
            if (ArmorSetCheck<SilkHat>()) return "SilkHatSet";
            if (ArmorSetCheck<FleshMask>()) return "FleshMaskSet";
            if (ArmorSetCheck<GeodeHelmet>()) return "GeodeHelmetSet";
            if (ArmorSetCheck<GraniteHelmet>()) return "GraniteHelmetSet";
            if (ArmorSetCheck<BioTechHood>()) return "BioTechHoodSet";
            if (ArmorSetCheck<BloomingCrown>()) return "BloomingCrownSet";
            if (ArmorSetCheck<CelestialCrown>()) return "CelestialCrownSet";
            if (ArmorSetCheck<EbonHood>()) return "EbonHoodSet";
            if (ArmorSetCheck<NoviceClericCowl>()) return "NoviceClericCowlSet";
            if (ArmorSetCheck<SacredHelmet>()) return "SacredHelmetSet";
            if (ArmorSetCheck<TemplarsCirclet>()) return "TemplarsCircletSet";
            if (ArmorSetCheck<WarlockHood>()) return "WarlockHoodSet";
            if (ArmorSetCheck<IcyHeadgear>()) return "IcyHeadgearSet";
            if (ArmorSetCheck<IllumiteMask>()) return "IllumiteMaskSet";
            if (ArmorSetCheck<LodeStoneFaceGuard>()) return "LodeStoneFaceGuardSet";
            if (ArmorSetCheck<CryomancersCrown>()) return "CryomancersCrownSet";
            if (ArmorSetCheck<WhiteKnightMask>()) return "WhiteKnightMaskSet";
            if (ArmorSetCheck<AncientHallowedChapeau>()) return "AncientHallowedChapeauSet";
            if (ArmorSetCheck<AncientHallowedCowl>()) return "AncientHallowedCowlSet";
            if (ArmorSetCheck<AncientHallowedGuise>()) return "AncientHallowedGuiseSet";
            if (ArmorSetCheck<ConduitHelmet>()) return "ConduitHelmetSet";
            if (ArmorSetCheck<HallowedChapeau>()) return "HallowedChapeauSet";
            if (ArmorSetCheck<HallowedCowl>()) return "HallowedCowlSet";
            if (ArmorSetCheck<HallowedGuise>()) return "HallowedGuiseSet";
            if (ArmorSetCheck<SandStoneHelmet>()) return "SandStoneHelmetSet";
            if (ArmorSetCheck<DurasteelHelmet>()) return "DurasteelHelmetSet";
            if (ArmorSetCheck<SteelHelmet>()) return "SteelHelmetSet";
            if (ArmorSetCheck<AstroHelmet>()) return "AstroHelmetSet";
            if (ArmorSetCheck<LifeBloomMask>()) return "LifeBloomMaskSet";
            if (ArmorSetCheck<LivingWoodMask>()) return "LivingWoodMaskSet";
            if (ArmorSetCheck<SpiritTrapperCowl>()) return "SpiritTrapperCowlSet";
            if (ArmorSetCheck<SpiritTrapperMask>()) return "SpiritTrapperMaskSet";
            if (ArmorSetCheck<TerrariumHelmet>()) return "TerrariumHelmetSet";
            if (ArmorSetCheck<ThoriumHelmet>()) return "ThoriumHelmetSet";
            if (ArmorSetCheck<FungusHat>()) return "FungusHatSet";
            if (ArmorSetCheck<PlagueDoctorsMask>()) return "PlagueDoctorsMaskSet";
            if (ArmorSetCheck<ShadeMasterMask>()) return "ShadeMasterMaskSet";
            if (ArmorSetCheck<WhiteDwarfMask>()) return "WhiteDwarfMaskSet";
            if (ArmorSetCheck<TitanHeadgear>()) return "TitanHeadgearSet";
            if (ArmorSetCheck<TitanMask>()) return "TitanMaskSet";
            if (ArmorSetCheck<TitanHelmet>()) return "TitanHelmetSet";
            if (ArmorSetCheck<ValadiumHelmet>()) return "ValadiumHelmetSet";
            return string.Empty;
        }
        #endregion
    }
}
