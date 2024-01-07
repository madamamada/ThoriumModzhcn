/*using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ThoriumMod.NPCs;

namespace ThoriumModzhcn.NPCs
{
    public class NPCNameTranslate : GlobalNPC
    {
        public override void GetChat(NPC npc, ref string chat)
        {
            int cobbler = NPC.FindFirstNPC(ModContent.NPCType<Cobbler>());
            int confusedZombie = NPC.FindFirstNPC(ModContent.NPCType<ConfusedZombie>());
            int cook = NPC.FindFirstNPC(ModContent.NPCType<Cook>());
            int desertAcolyte = NPC.FindFirstNPC(ModContent.NPCType<DesertAcolyte>());
            int diverman = NPC.FindFirstNPC(ModContent.NPCType<Diverman>());
            int druid = NPC.FindFirstNPC(ModContent.NPCType<Druid>());
            int spiritualist = NPC.FindFirstNPC(ModContent.NPCType<Spiritualist>());
            int tracker = NPC.FindFirstNPC(ModContent.NPCType<Tracker>());
            int weaponMaster = NPC.FindFirstNPC(ModContent.NPCType<WeaponMaster>());
            int demolitionist = NPC.FindFirstNPC(NPCID.Demolitionist);
            int partyGirl = NPC.FindFirstNPC(NPCID.PartyGirl);
            int merchant = NPC.FindFirstNPC(NPCID.Merchant);
            int guide = NPC.FindFirstNPC(NPCID.Guide);
            int wizard = NPC.FindFirstNPC(NPCID.Wizard);
            int angler = NPC.FindFirstNPC(NPCID.Angler);
            int dryad = NPC.FindFirstNPC(NPCID.Dryad);
            int witchDoctor = NPC.FindFirstNPC(NPCID.WitchDoctor);
            int armsDealer = NPC.FindFirstNPC(NPCID.ArmsDealer);
            int dyeTrader = NPC.FindFirstNPC(NPCID.DyeTrader);
            int pirate = NPC.FindFirstNPC(NPCID.Pirate);
            int taxCollector = NPC.FindFirstNPC(NPCID.TaxCollector);
            int stylist = NPC.FindFirstNPC(NPCID.Stylist);
            int tavernkeep = NPC.FindFirstNPC(NPCID.DD2Bartender);
            #region blacksmith
            if (npc.type == ModContent.NPCType<Blacksmith>())
                if (demolitionist != -1)
                {
                    if (chat == $"Me and {Main.npc[demolitionist].GivenName} have a little routine going: he delivers me metal to smith, and I give him a heart attack by smoking near his explosives on purpose.")
                        chat = $"你能去找{Main.npc[demolitionist].GivenName}有一些无聊的日常互动：他把金属交给我锻造，而我故意在他的爆炸物附近吸烟，吓他个心脏病发作.";
                }
            #endregion
        }
    }
}*/
