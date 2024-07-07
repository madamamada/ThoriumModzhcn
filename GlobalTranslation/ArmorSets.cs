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
            if (set == "YewWoodHelmetSet")
            {
                player.setBonus = "4次非暴击攻击后下次远程攻击会是造成150%伤害的小暴击";
            }
            if (set == "CriersCapSet")
            {
                player.setBonus = "你的音波咒音增幅会额外持续 3 秒";
            }
            if (set == "SoloistHatSet")
            {
                player.setBonus = "按下“盔甲能力”键会让你获得无限的灵感值，大幅增加音波伤害和演奏速度\n此效果持续10秒并需要重新充能1分钟";
            }
            if (set == "CyberPunkHeadsetSet")
            {
                player.setBonus = "按下“盔甲能力”键会在 4 种状态间切换：\n红：玩家和附近队友获得固定伤害 II 和伤害 II\n绿：玩家和附近队友获得移动速度 II 和飞行时间 II\n紫：玩家和附近队友获得资源上限 II 和资源再生 II\n蓝：玩家和附近队友获得防御 II 和伤害减免 II";
            }
            if (set == "JestersMaskSet")
            {
                player.setBonus = "掉落的灵感音符效果翻倍且会短暂增加你的音波伤害";
            }
            if (set == "JestersMask2Set")
            {
                player.setBonus = "掉落的灵感音符效果翻倍且会短暂增加你的音波伤害";
            }
            if (set == "MaestroWigSet")
            {
                player.setBonus = "按下盔甲能力键时召唤一个持续 20 秒的陨落合唱团。\n陨落合唱团由四个鬼魂音乐家组成，分别使用铜管乐器，管乐器，弦乐器和打击乐器，会自动向附近敌怪发射弹幕。\n召唤陨落合唱团时会受到陨落合唱团减益。\n60 秒内无法再次召唤它们";
            }
            if (set == "MarchingBandCapSet")
            {
                player.setBonus = "战斗中，一个伤害性的彩虹音波符号会跟随你的移动并晕眩敌怪";
            }
            if (set == "NoblesHatSet")
            {
                player.setBonus = "掉落的灵感音符效果翻倍且会短暂增加你的音波伤害";
            }
            if (set == "OrnateHatSet")
            {
                player.setBonus = "音波暴击会使随机激活的咒音增幅提升到 IV 级强度";
            }
            if (set == "ShootingStarHatSet")
            {
                player.setBonus = "使咒音增幅持续时间延长 6 秒\n玩家拥有的每个独特的咒音增幅会\n增加5%音波伤害和2%灵感值再生";
            }
            if (set == "WhisperingHoodSet")
            {
                player.setBonus = "你会偶尔产生一根深渊能量触手攻击附近敌怪\n你可以拥有至多6根触手且它们的伤害会从被击中的敌怪吸取1点生命和魔力";
            }
            if (set == "LichCowlSet")
            {
                player.setBonus = "击杀敌怪会释放一道灵魂碎片\n接触灵魂碎片会短暂地大幅增加你的移动速度和投掷速度";
            }
            if (set == "TideTurnerHelmetSet")
            {
                player.setBonus = "按下“盔甲能力”键会将你包裹在密不透风的泡泡中，将所有受到的伤害转化为治疗";
            }
            if (set == "TideTurnersGazeSet")
            {
                player.setBonus = "投掷伤害有20%概率在你周围释放追踪海潮飞刀";
            }
            if (set == "DreamWeaversHoodSet")
            {
                player.setBonus = "按下“盔甲能力”键会消耗200魔力并将你放置在梦中\n在梦中时，被治疗的队友会变得短暂无敌且所有减益都会被治愈";
            }
            if (set == "DreamWeaversHelmetSet")
            {
                player.setBonus = "按下“盔甲能力”键会消耗200魔力并扭曲现实结构\n敌怪会被大幅减速且受到所有来源的伤害增加15%\n队友会大幅增加移动速度和攻击速度，并将到来的非致命伤害转化为治疗";
            }
            if (set == "MasterArbalestHoodSet")
            {
                player.setBonus = "你的伤害有10%概率完全复制自身并多造成15%伤害";
            }
            if (set == "MasterMarksmansScouterSet")
            {
                player.setBonus = "你的远程伤害有5%概率完全湮灭击中的目标\n此效果只能在Boss生命值低于5%时生效";
            }
            if (set == "InspiratorsHelmetSet")
            {
                player.setBonus = "按下“盔甲能力”键会用每种III级咒音增幅过载所有附近队友15秒\n使用此能力需要20点灵感值且必须重新充能1分钟";
            }
            if (set == "InspiratorsHelmetSet")
            {
                player.setBonus = "按下“盔甲能力”键会让你获得无限的灵感值，大幅增加音波伤害和演奏速度\n此效果持续10秒并需要重新充能1分钟";
            }
            if (set == "MagmaSeersMaskSet")
            {
                player.setBonus = "所有仆从伤害会滞留下造成大量伤害的灼烧";
            }
            if (set == "PyromancerCowlSet")
            {
                player.setBonus = "你的魔法伤害会造成严重烧伤并伤害所有附近敌怪";
            }
            if (set == "BronzeHelmetSet")
            {
                player.setBonus = "投掷伤害有20%概率释放一道穿透性闪电";
            }
            if (set == "CoralHelmetSet")
            {
                player.setBonus = "光辉伤害会建立至多20点生命护盾且你的生命护盾不会随时间衰减\n治疗队友会将生命护盾转移到他们身上";
            }
            if (set == "DarksteelFaceGuardSet")
            {
                player.setBonus = "没有什么能阻挡你的移动！双击来冲刺！";
            }
            if (set == "DemonBloodHelmetSet")
            {
                player.setBonus = "最大生命值增加100";
            }
            if (set == "DepthDiverHelmetSet")
            {
                player.setBonus = "你也会获得自身产生的效果";
            }
            if (set == "NagaSkinMaskSet")
            {
                player.setBonus = "每消耗75魔力会短暂地大幅增加你的魔法伤害和施法速度";
            }
            if (set == "TideHunterCapSet")
            {
                player.setBonus = "远程暴击会释放一堆泡沫，减速附近敌怪";
            }
            if (set == "DragonMaskSet")
            {
                player.setBonus = "攻击有概率释放龙焰爆炸";
            }
            if (set == "DreadSkullSet")
            {
                player.setBonus = "你的靴子以不真实的频率振动，大幅增加基础移动速度\n移动时，你的近战伤害和暴击率增加";
            }
            if (set == "FallenPaladinFaceguardSet")
            {
                player.setBonus = "受到伤害会治疗附近队友所受伤害15%的生命值";
            }
            if (set == "IridescentHelmetSet")
            {
                player.setBonus = "你的光辉伤害有15%概率释放一道致盲闪光\n闪光会以你的治疗加成治疗所有附近队友并困惑敌怪";
            }
            if (set == "LifeBinderMaskSet")
            {
                player.setBonus = "治疗法术会短暂增加被治疗玩家50点最大生命值";
            }
            if (set == "SilkHatSet")
            {
                player.setBonus = "高于90%魔力时增加12%魔法伤害";
            }
            if (set == "FleshMaskSet")
            {
                player.setBonus = "受伤时伤害敌怪有10%概率掉落肉\n收集肉会恢复生命并获得伤害加成";
            }
            if (set == "GeodeHelmetSet")
            {
                player.setBonus = "你现在可以一次挖掘整个矿脉";
            }
            if (set == "GraniteHelmetSet")
            {
                player.setBonus = "免疫高温和敌怪击退，但你的移动速度大幅降低";
            }
            if (set == "BioTechHoodSet")
            {
                player.setBonus = "一个生物工程探测器会协助你治疗队友\n治疗队友等同于你治疗加成的生命值";
            }
            if (set == "BloomingCrownSet")
            {
                player.setBonus = "你的治疗法术会增加被治疗目标的生命恢复和生命恢复速率";
            }
            if (set == "CelestialCrownSet")
            {
                player.setBonus = "按下盔甲能力键会消耗150魔力在你的光标周围召唤一个大型光环\n光环接触的队友会获得伤害，伤害减免，防御和生命恢复的提升\n光环接触的敌怪会受到神圣之怒且受到所有来源的伤害增加15%";
            }
            if (set == "EbonHoodSet")
            {
                player.setBonus = "腐化你的光辉能量，使它们呈现黑暗形态并造成额外效果";
            }
            if (set == "NoviceClericCowlSet")
            {
                player.setBonus = "每5秒你会生成至多3个神圣十字架\n在使用治疗法术时会消耗1个十字架而不是魔力";
            }
            if (set == "SacredHelmetSet")
            {
                player.setBonus = "治疗法术会额外治疗5点生命值";
            }
            if (set == "TemplarsCircletSet")
            {
                player.setBonus = "如果队友生命值低于一半，你会获得治疗能力提升";
            }
            if (set == "WarlockHoodSet")
            {
                player.setBonus = "光辉攻击会生成至多15颗暗影微粒\n按下“盔甲能力”键会向光标位置释放所有存储的暗影微粒";
            }
            if (set == "IcyHeadgearSet")
            {
                player.setBonus = "一个冰光环环绕着你，冻结待在其中太久的敌怪";
            }
            if (set == "IllumiteMaskSet")
            {
                player.setBonus = "你的弓，枪和发射器会定期发射额外弹幕";
            }
            if (set == "LodeStoneFaceGuardSet")
            {
                player.setBonus = "每失去25%生命值增加6%伤害减免\n低于25%生命值时伤害减免到达最大18%";
            }
            if (set == "CryomancersCrownSet")
            {
                player.setBonus = "你的魔法攻击会冻结敌怪2秒";
            }
            if (set == "WhiteKnightMaskSet")
            {
                player.setBonus = "你消耗魔力的40%会存储为能量，上限400\n按下“盔甲能力”键会消耗存储的能量回复至多200魔力和20生命";
            }
            if (set == "AncientHallowedChapeauSet")
            {
                player.setBonus = "击中敌怪后进入免疫状态且增加8秒你音波咒音增幅的持续时间";
            }
            if (set == "AncientHallowedCowlSet")
            {
                player.setBonus = "击中敌怪后进入免疫状态且治疗法术会额外治疗6点生命值";
            }
            if (set == "AncientHallowedGuiseSet")
            {
                player.setBonus = "击中敌怪后进入免疫状态并增加2点最大技巧值";
            }
            if (set == "ConduitHelmetSet")
            {
                player.setBonus = "不断移动会生成至多5个静态环，每个都会为你添加生命护盾\n满充能时，一个能量泡泡会保护你免受一次攻击\n泡泡阻挡攻击后会向附近敌怪释放电束";
            }
            if (set == "HallowedChapeauSet")
            {
                player.setBonus = "击中敌怪后进入免疫状态且增加8秒你音波咒音增幅的持续时间";
            }
            if (set == "HallowedCowlSet")
            {
                player.setBonus = "击中敌怪后进入免疫状态且治疗法术会额外治疗6点生命值";
            }
            if (set == "HallowedGuiseSet")
            {
                player.setBonus = "击中敌怪后进入免疫状态并增加2点最大技巧值";
            }
            if (set == "SandStoneHelmetSet")
            {
                player.setBonus = "沙漠之风为你提供了一次沙质二段跳";
            }
            if (set == "DurasteelHelmetSet")
            {
                player.setBonus = "受到的伤害降低10%";
            }
            if (set == "SteelHelmetSet")
            {
                player.setBonus = "+8% 伤害减免";
            }
            if (set == "AstroHelmetSet")
            {
                player.setBonus = "仆从伤害击中时有概率释放一场魔法脉冲爆发";
            }
            if (set == "LifeBloomMaskSet")
            {
                player.setBonus = "仆从攻击击中时有25%概率治疗你\n10秒内你无法治疗超过50点生命值";
            }
            if (set == "LivingWoodMaskSet")
            {
                player.setBonus = "最大仆从数量增加1\n生命木橡子的自动攻击会追踪敌怪";
            }
            if (set == "TerrariumHelmetSet")
            {
                player.setBonus = "当你在战斗中时泰拉瑞亚的能量会追寻并保护你";
            }
            if (set == "ThoriumHelmetSet")
            {
                player.setBonus = "造成的伤害增加10%";
            }
            if (set == "FungusHatSet")
            {
                player.setBonus = "对受真菌影响的敌怪造成的伤害增加10%\n对受真菌影响的敌怪造成伤害时会短暂增加10%投掷速度";
            }
            if (set == "PlagueDoctorsMaskSet")
            {
                player.setBonus = "你的瘟疫云在空中的滞留时间翻倍且你的瘟疫连锁反应多造成20%伤害";
            }
            if (set == "ShadeMasterMaskSet")
            {
                player.setBonus = "你所受伤害的50%会束缚在接下来的10秒内";
            }
            if (set == "WhiteDwarfMaskSet")
            {
                player.setBonus = "暴击会从星宇释放象牙状火焰\n象牙状火焰会造成被击中目标0.1%生命值的伤害";
            }
            if (set == "TitanMaskSet")
            {
                player.setBonus = "造成的伤害增加18%！";
            }
            if (set == "TitanHelmetSet")
            {
                player.setBonus = "造成的伤害增加18%！";
            }
            if (set == "ValadiumHelmetSet")
            {
                player.setBonus = "按下up翻转重力。翻转时，远程伤害增加15%！";
            }
        }
        #endregion
        #region IsArmorSet
        public override string IsArmorSet(Item head, Item body, Item legs)
        {
            ModItem item = ModContent.GetInstance<FlightMask>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "FlightMaskSet";
            }
            item = ModContent.GetInstance<YewWoodHelmet>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "YewWoodHelmetSet";
            }
            item = ModContent.GetInstance<CriersCap>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "CriersCapSet";
            }
            item = ModContent.GetInstance<CyberPunkHeadset>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "CyberPunkHeadsetSet";
            }
            item = ModContent.GetInstance<JestersMask>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "JestersMaskSet";
            }
            item = ModContent.GetInstance<JestersMask2>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "JestersMask2Set";
            }
            item = ModContent.GetInstance<MaestroWig>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "MaestroWigSet";
            }
            item = ModContent.GetInstance<MarchingBandCap>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "MarchingBandCapSet";
            }
            item = ModContent.GetInstance<NoblesHat>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "NoblesHatSet";
            }
            item = ModContent.GetInstance<OrnateHat>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "OrnateHatSet";
            }
            item = ModContent.GetInstance<ShootingStarHat>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "ShootingStarHatSet";
            }
            item = ModContent.GetInstance<WhisperingHood>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "WhisperingHoodSet";
            }
            item = ModContent.GetInstance<LichCowl>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "LichCowlSet";
            }
            item = ModContent.GetInstance<TideTurnerHelmet>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "TideTurnerHelmetSet";
            }
            item = ModContent.GetInstance<TideTurnersGaze>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "TideTurnersGazeSet";
            }
            item = ModContent.GetInstance<DreamWeaversHood>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "DreamWeaversHoodSet";
            }
            item = ModContent.GetInstance<DreamWeaversHelmet>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "DreamWeaversHelmetSet";
            }
            item = ModContent.GetInstance<MasterArbalestHood>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "MasterArbalestHoodSet";
            }
            item = ModContent.GetInstance<MasterMarksmansScouter>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "MasterMarksmansScouterSet";
            }
            item = ModContent.GetInstance<InspiratorsHelmet>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "InspiratorsHelmetSet";
            }
            item = ModContent.GetInstance<SoloistHat>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "SoloistHatSet";
            }
            item = ModContent.GetInstance<MagmaSeersMask>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "MagmaSeersMaskSet";
            }
            item = ModContent.GetInstance<PyromancerCowl>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "PyromancerCowlSet";
            }
            item = ModContent.GetInstance<BronzeHelmet>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "BronzeHelmetSet";
            }
            item = ModContent.GetInstance<CoralHelmet>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "CoralHelmetSet";
            }
            item = ModContent.GetInstance<DarksteelFaceGuard>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "DarksteelFaceGuardSet";
            }
            item = ModContent.GetInstance<DemonBloodHelmet>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "DemonBloodHelmetSet";
            }
            item = ModContent.GetInstance<DepthDiverHelmet>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "DepthDiverHelmetSet";
            }
            item = ModContent.GetInstance<NagaSkinMask>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "NagaSkinMaskSet";
            }
            item = ModContent.GetInstance<TideHunterCap>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "TideHunterCapSet";
            }
            item = ModContent.GetInstance<DragonMask>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "DragonMaskSet";
            }
            item = ModContent.GetInstance<DreadSkull>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "DreadSkullSet";
            }
            item = ModContent.GetInstance<FallenPaladinFaceguard>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "FallenPaladinFaceguardSet";
            }
            item = ModContent.GetInstance<IridescentHelmet>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "IridescentHelmetSet";
            }
            item = ModContent.GetInstance<LifeBinderMask>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "LifeBinderMaskSet";
            }
            item = ModContent.GetInstance<SilkHat>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "SilkHatSet";
            }
            item = ModContent.GetInstance<FleshMask>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "FleshMaskSet";
            }
            item = ModContent.GetInstance<GeodeHelmet>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "GeodeHelmetSet";
            }
            item = ModContent.GetInstance<GraniteHelmet>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "GraniteHelmetSet";
            }
            item = ModContent.GetInstance<BioTechHood>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "BioTechHoodSet";
            }
            item = ModContent.GetInstance<BloomingCrown>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "BloomingCrownSet";
            }
            item = ModContent.GetInstance<CelestialCrown>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "CelestialCrownSet";
            }
            item = ModContent.GetInstance<EbonHood>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "EbonHoodSet";
            }
            item = ModContent.GetInstance<NoviceClericCowl>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "NoviceClericCowlSet";
            }
            item = ModContent.GetInstance<SacredHelmet>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "SacredHelmetSet";
            }
            item = ModContent.GetInstance<TemplarsCirclet>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "TemplarsCircletSet";
            }
            item = ModContent.GetInstance<WarlockHood>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "WarlockHoodSet";
            }
            item = ModContent.GetInstance<IcyHeadgear>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "IcyHeadgearSet";
            }
            item = ModContent.GetInstance<IllumiteMask>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "IllumiteMaskSet";
            }
            item = ModContent.GetInstance<LodeStoneFaceGuard>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "LodeStoneFaceGuardSet";
            }
            item = ModContent.GetInstance<CryomancersCrown>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "CryomancersCrownSet";
            }
            item = ModContent.GetInstance<WhiteKnightMask>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "WhiteKnightMaskSet";
            }
            item = ModContent.GetInstance<AncientHallowedChapeau>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "AncientHallowedChapeauSet";
            }
            item = ModContent.GetInstance<AncientHallowedCowl>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "AncientHallowedCowlSet";
            }
            item = ModContent.GetInstance<AncientHallowedGuise>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "AncientHallowedGuiseSet";
            }
            item = ModContent.GetInstance<ConduitHelmet>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "ConduitHelmetSet";
            }
            item = ModContent.GetInstance<HallowedChapeau>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "HallowedChapeauSet";
            }
            item = ModContent.GetInstance<HallowedCowl>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "HallowedCowlSet";
            }
            item = ModContent.GetInstance<HallowedGuise>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "HallowedGuiseSet";
            }
            item = ModContent.GetInstance<SandStoneHelmet>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "SandStoneHelmetSet";
            }
            item = ModContent.GetInstance<DurasteelHelmet>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "DurasteelHelmetSet";
            }
            item = ModContent.GetInstance<SteelHelmet>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "SteelHelmetSet";
            }
            item = ModContent.GetInstance<AstroHelmet>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "AstroHelmetSet";
            }
            item = ModContent.GetInstance<LifeBloomMask>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "LifeBloomMaskSet";
            }
            item = ModContent.GetInstance<LivingWoodMask>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "LivingWoodMaskSet";
            }
            item = ModContent.GetInstance<SpiritTrapperCowl>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "SpiritTrapperCowlSet";
            }
            item = ModContent.GetInstance<SpiritTrapperMask>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "SpiritTrapperMaskSet";
            }
            item = ModContent.GetInstance<TerrariumHelmet>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "TerrariumHelmetSet";
            }
            item = ModContent.GetInstance<ThoriumHelmet>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "ThoriumHelmetSet";
            }
            item = ModContent.GetInstance<FungusHat>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "FungusHatSet";
            }
            item = ModContent.GetInstance<PlagueDoctorsMask>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "PlagueDoctorsMaskSet";
            }
            item = ModContent.GetInstance<ShadeMasterMask>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "ShadeMasterMaskSet";
            }
            item = ModContent.GetInstance<WhiteDwarfMask>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "WhiteDwarfMaskSet";
            }
            item = ModContent.GetInstance<TitanHeadgear>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "TitanHeadgearSet";
            }
            item = ModContent.GetInstance<TitanMask>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "TitanMaskSet";
            }
            item = ModContent.GetInstance<TitanHelmet>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "TitanHelmetSet";
            }
            item = ModContent.GetInstance<ValadiumHelmet>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "ValadiumHelmetSet";
            }
            return base.IsArmorSet(head, body, legs);
        }
        #endregion
    }
}
