using Terraria;
using Terraria.ModLoader;
using ThoriumMod.NPCs;

namespace ThoriumModzhcn.GlobalTranslation
{
	public class NPCText : GlobalNPC
	{
		public override void GetChat(NPC npc, ref string chat)
		{
			int Blacksmith = NPC.FindFirstNPC(ModContent.NPCType<Blacksmith>());
			int Cobbler = NPC.FindFirstNPC(ModContent.NPCType<Cobbler>());
			int ConfusedZombie = NPC.FindFirstNPC(ModContent.NPCType<ConfusedZombie>());
			int Cook = NPC.FindFirstNPC(ModContent.NPCType<Cook>());
			int DesertAcolyte = NPC.FindFirstNPC(ModContent.NPCType<DesertAcolyte>());
			int Diverman = NPC.FindFirstNPC(ModContent.NPCType<Diverman>());
			int Druid = NPC.FindFirstNPC(ModContent.NPCType<Druid>());
			int Spiritualist = NPC.FindFirstNPC(ModContent.NPCType<Spiritualist>());
			int Tracker = NPC.FindFirstNPC(ModContent.NPCType<Tracker>());
			int WeaponMaster = NPC.FindFirstNPC(ModContent.NPCType<WeaponMaster>());
			int Demolitionist = NPC.FindFirstNPC(38);
			int PartyGirl = NPC.FindFirstNPC(208);
			int Merchant = NPC.FindFirstNPC(17);
			int Guide = NPC.FindFirstNPC(22);
			int Wizard = NPC.FindFirstNPC(108);
			int Angler = NPC.FindFirstNPC(369);
			int Dryad = NPC.FindFirstNPC(20);
			int WitchDoctor = NPC.FindFirstNPC(228);
			int ArmsDealer = NPC.FindFirstNPC(19);
			int DyeTrader = NPC.FindFirstNPC(207);
			int Pirate = NPC.FindFirstNPC(229);
			int TaxCollector = NPC.FindFirstNPC(441);
			int Stylist = NPC.FindFirstNPC(353);
			int Tavernkeep = NPC.FindFirstNPC(550);

			if (npc.type == ModContent.NPCType<Blacksmith>())
			{
				if (Demolitionist >= 0 && chat == "Me and " + Main.npc[Demolitionist].GivenName + " have a little routine going: he delivers me metal to smith, and I give him a heart attack by smoking near his explosives on purpose.")
					chat = "你能去找" + Main.npc[Demolitionist].GivenName + "有一些无聊的日常互动：他把金属交给我锻造，而我故意在他的爆炸物附近吸烟，吓他个心脏病发作。";
				if (PartyGirl >= 0 && chat == "I just witnessed " + Main.npc[PartyGirl].GivenName + " make a knife out of chocolate that's better than half of my own blades...")
					chat = "就在刚刚我亲眼目睹" + Main.npc[PartyGirl].GivenName + "用巧克力造出了一把刀具，甚至比我一半的作品都要好……";
				if (Merchant >= 0 && chat == "What does that conman " + Main.npc[Merchant].GivenName + " think he's doing trying to offer his cheap trash he calls 'weapons'? If you want the real deal, you've come to the right place!")
					chat = "" + Main.npc[Merchant].GivenName + "那个江湖骗子，以为自己在卖什么所谓的“武器”？事实上那只是一些廉价垃圾罢了。如果你在找真正的武器，那你就来对地方了！";
				if (Tracker >= 0 && chat == "That brute " + Main.npc[Tracker].GivenName + " is more Barbarian than Tracker! Do you have any idea how many times the oaf asked me to fix that battleaxe of his?!")
					chat = "" + Main.npc[Tracker].GivenName + "那个野蛮人简直比暴君更加残暴！你知道那个混蛋叫我帮他修了多少次战斧吗？！";

					switch (chat)
					{
					case "'course I followed you here, brat. I crash-coursed you on how to forge and smith weapons for yourself before you arrived here, I'll be damned if I don't get to sit back and watch the ensuing fireworks.":
					chat = "我当然是跟着你到这儿来的，小子。在你抵达这里前，我给你上过锻造速成班，教你如何为自己打造武器，要是我不坐下来欣赏后续的烟火盛宴，那可太他妈的混账了。";
					break;
					case "You know all those special weapons you find scattered about the land? I've always wondered just how they were forged in the first place. I'm an old man now, but I've still got a long journey to mastery ahead of me...":
					chat = "你了解你找到的那些特殊武器吗？它们散落在这片土地的各处。我毕生的梦想就是搞清楚究它们最初是如何锻造的。现在我已经老了，但我还有很长的路要走……";
					break;
					case "Every blade's got its place in the world: a signature weapon for a hero, a beloved knife for a chef, or maybe just some gaudy piece of junk hanging from a wall.":
					chat = "这个世界上，任何一把刀都有属于自己的归宿：英雄的英勇之证，厨子心爱的菜刀，或者，仅仅是一些挂在墙上华而不实的垃圾。";
					break;
					case "Hey brat, corral some people into helping me out at the forge. Blacksmithing ain't a single-man task, and you'll just end up with second-rate junk if you try going solo!":
					chat = "嘿！小子，绑一些人到铁匠铺来给我打下手。锻造可不是什么能单干的活计，如果你试图独自搞定一切，那就只能得到一些二流的垃圾货！";
					break;
					case "Welcome! I'm busy workin' on a commission weapon, if you touch anything, consider it sold!":
					chat = "欢迎光临！我正忙着打造一件客户委托的武器，要是你碰坏了什么东西，那赔偿可就算你头上了！";
					break;
					case "Heh, I told you from day one, brat: I came here to watch the fireworks, and you sure delivered.":
					chat = "嘿，小子，我到这儿的第一天就和你说了：我来这儿是为了看一场烟火盛宴的，而你真的做到了.";
					break;
					}
			}
		}

	}
}


/*using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ThoriumMod.NPCs;

namespace ThoriumModzhcn.GlobalTranslation
{
    public class GlobalNPCTranslate : GlobalNPC
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
            {
                if (chat == "You know all those special weapons you find scattered about the land? I've always wondered just how they were forged in the first place. I'm an old man now, but I've still got a long journey to mastery ahead of me...")
                    chat = "你了解你找到的那些特殊武器吗？它们散落在这片土地的各处。我毕生的梦想就是搞清楚究它们最初是如何锻造的。现在我已经老了，但我还有很长的路要走……";
                else if (chat == "'course I followed you here, brat. I crash-coursed you on how to forge and smith weapons for yourself before you arrived here, I'll be damned if I don't get to sit back and watch the ensuing fireworks.")
                    chat = "我当然是跟着你到这儿来的，小子。在你抵达这里前，我给你上过锻造速成班，教你如何为自己打造武器，要是我不坐下来欣赏后续的烟火盛宴，那可太他妈的混账了。";
                else if (chat == "Every blade's got its place in the world: a signature weapon for a hero, a beloved knife for a chef, or maybe just some gaudy piece of junk hanging from a wall.")
                    chat = "这个世界上，任何一把刀都有属于自己的归宿：英雄的英勇之证，厨子心爱的菜刀，或者，仅仅是一些挂在墙上华而不实的垃圾。";
                else if (chat == "Hey brat, corral some people into helping me out at the forge. Blacksmithing ain't a single-man task, and you'll just end up with second-rate junk if you try going solo!")
                    chat = "嘿！小子，绑一些人到铁匠铺来给我打下手。锻造可不是什么能单干的活计，如果你试图独自搞定一切，那就只能得到一些二流的垃圾货！";
                else if (chat == "Welcome! I'm busy workin' on a commission weapon, if you touch anything, consider it sold!")
                    chat = "欢迎光临！我正忙着打造一件客户委托的武器，要是你碰坏了什么东西，那赔偿可就算你头上了！";
                else if (chat == "Heh, I told you from day one, brat: I came here to watch the fireworks, and you sure delivered.")
                    chat = "嘿，小子，我到这儿的第一天就和你说了：我来这儿是为了看一场烟火盛宴的，而你真的做到了.";
            		if (demolitionist >= 0 && chat == "Me and " + Main.npc[demolitionist].GivenName + " have a little routine going: he delivers me metal to smith, and I give him a heart attack by smoking near his explosives on purpose.")
            			chat = "你能去找" + Main.npc[demolitionist].GivenName + "有一些无聊的日常互动：他把金属交给我锻造，而我故意在他的爆炸物附近吸烟，吓他个心脏病发作。";
	if (partyGirl >= 0 && chat == "I just witnessed " + Main.npc[partyGirl].GivenName + " make a knife out of chocolate that's better than half of my own blades...")
			chat = "就在刚刚我亲眼目睹" + Main.npc[partyGirl].GivenName + "用巧克力造出了一把刀具，甚至比我一半的作品都要好……";
	if (merchant >= 0 && chat == "What does that conman " + Main.npc[merchant].GivenName + " think he's doing trying to offer his cheap trash he calls 'weapons'? If you want the real deal, you've come to the right place!")
			chat = "" + Main.npc[merchant].GivenName + "那个江湖骗子，以为自己在卖什么所谓的“武器”？事实上那只是一些廉价垃圾罢了。如果你在找真正的武器，那你就来对地方了！";
	if (tracker >= 0 && chat == "That brute " + Main.npc[tracker].GivenName + " is more Barbarian than Tracker! Do you have any idea how many times the oaf asked me to fix that battleaxe of his?!")
			chat = "" + Main.npc[tracker].GivenName + "那个野蛮人简直比暴君更加残暴！你知道那个混蛋叫我帮他修了多少次战斧吗？！";
            }
            #endregion
            #region cobbler
            else if (npc.type == ModContent.NPCType<Cobbler>())
            {
                if (chat == "In my younger years, I myself was a hero. But after a bad fall, I've since retired. Perhaps if I had better boots back then I would still be a hero today...")
                    chat = "年轻的时候，我自己就是一名英雄。不过摔了一跤后，我就退休了。如果我当时有一双更好的靴子的话，我现在仍是一名英雄吧……";
                else if (chat == "'Worry not young man. While the journey may be tough, I have full confidence in your ability!")
                    chat = "别担心，年轻人。纵使前路曲折，我仍对你的能力充满信心！";
                else if (chat == "You can learn a lot by walking a mile in someone else's boots. If only some of these townsfolk would walk a mile in yours, then they could understand...")
                    chat = "穿着别人的鞋子走一走，你就能从中学到很多东西。如果这些居民里有人能穿着你的鞋子走一走，他们会明白这个道理的……";
                else if (chat == "I can't believe it, never in a million years... But look at you, standing so triumphantly! Ha ha hah! Congratulations, but more importantly: thank you, from the bottom of my heart, hero. Thanks to your incredible bravery, an old friend of mine can rest easy now...")
                    chat = "我简直不敢相信，就算过了百万年也不敢……不过看看你，就站在我面前，如此欢欣鼓舞！哈哈哈！祝贺你，但更重要的是，衷心的感谢你，我的英雄。多亏了你那难以置信的无畏精神，我的一位老友终于可以放下心弦了……";
            		if (guide >= 0 && chat == "Ah, so " + Main.npc[guide].GivenName + " has been giving you advice this whole time? It's always nice to see a young man appreciate his studies.")
            			chat = "啊，所以是" + Main.npc[guide].GivenName + "一直在给你建议？看到年轻人欣赏他的才学真是令人欣慰";
	if (partyGirl >= 0 && chat == "Can you believe that " + Main.npc[partyGirl].GivenName + " wanted to throw me a birthday party? I haven't had one in so long!")
			chat = "你相信吗？" + Main.npc[partyGirl].GivenName + "想给我举办生日派对！我好久没有开过生日派对了！";
	if (wizard >= 0 && chat == "Oh my... I think " + Main.npc[wizard].GivenName + " might be even older than I am!")
			chat = "哦，天哪……我觉得" + Main.npc[wizard].GivenName + "可能比我还老！";
                // 带玩家名字的
	Having proper footwear is no joke," + Main.LocalPlayer.Name + ". Always make sure your shoes are polished and ready for adventure!")
			chat = "要有一双适合自己的鞋子，这可不是玩笑话，" + Main.LocalPlayer.Name + "你要时刻确保鞋子擦得锃亮，做好踏上冒险旅途的准备！";
	How are you doing, " + Main.LocalPlayer.Name + "? Are you staying safe out there in the wilds?
			chat = "最近如何，" + Main.LocalPlayer.Name + "？在野外待着安全吗？";
	There we go," + Main.LocalPlayer.Name + " good as new. It won't last long, but maybe you'll notice some more spring in your step. Make sure to stay safe out there, hero!
			chat = "好了，" + Main.LocalPlayer.Name + "，你的鞋子焕然如新。虽然不能保持太久，但也许你能感觉到你的脚步更加轻快自如了。在外一定要注意安全，英雄！";
            }
            #endregion
            #region confusedZombie
            else if (npc.type == ModContent.NPCType<ConfusedZombie>())
            {
                if (chat == "I can't remember much about my past life... Chemicals and the like were my passion I think; I only get fragments and pieces of the truth. It's saddening at times...")
                    chat = "我不太记得我过去的生活了…我应该非常热爱化学之类的东西吧；对于生前的情形我只能回想起一些片段。有时这挺让人难过的…";
                else if (chat == "Why am I not like the others...? Oh, I'm sorry, did you need something?")
                    chat = "为什么我这么与众不同…？哦，不好意思，你想要点什么？";
                else if (chat == "Most people don't have the stomach to handle the things I sell. The trick is to not have a stomach at all!")
                    chat = "大部分人都没胆买我的东西。克服这个的诀窍就是抛弃掉胆脏！";
                else if (chat == "I gotta thank you for letting me stick around. Only coming out at night is pretty boring...")
                    chat = "谢谢你让我留在这里。只能在夜晚外出是一件很无聊的事情…";
                else if (chat == "I just whipped up the perfect recipe to deter Bats from bothering you; no more tiny nibbles!")
                    chat = "我刚刚做出来一个完美的配方，能让蝙蝠不再骚扰你；这样就不会再被咬了！";
                else if (chat == "Getting this stuff to work underwater was a huge hassle... Either way, hungry fish shouldn't attempt to eat you with this.")
                    chat = "这群烦人的东西会给水下作业带来不小的麻烦…不管怎样，带上这个，饥饿的鱼类就不会再企图攻击你。";
                else if (chat == "With this nasty concoction, insects will associate your scent with their queen! Neat, huh?.")
                    chat = "用了这瓶恶心的混合物，昆虫就会把你和它们的女王联系起来！太精妙了，对吧？";
                else if (chat == "I'll be honest, this is just a bottle of pure liquid calcium. Don't question it, the skeletons surely wont either!")
                    chat = "其实，这就是一瓶高纯液体钙。不要质疑它的效果，骷髅也会对这瓶药剂深信不疑！";
                else if (chat == "If this turned out correctly, you'll smell just like a zombie. Hopefully your nights will be a tad more calm!")
                    chat = "正常生效的话，这瓶药剂会让你闻起来像一只僵尸。希望你今天能有个平静的夜晚！";
                else if (chat == "I'm afraid you'll have to give me some more time to prepare the next repellent. This stuff can get pretty complicated...")
                    chat = "恐怕你得多给我一点时间来准备下一瓶趋避剂。这东西还挺复杂的…";
                else if (chat == "Looks like you're a bit short on funds. Come back when you have a little more coin in your pocket!")
                    chat = "看来你手头有点紧。等兜里有一些钱了再来吧！";
                else if (chat == "I barely remember anything from before I died, but that doesn't mean I can't make new memories. I'll be sure to remember your victory for as long as this body can move!")
                    chat = "我几乎不记得生前的事情，但这不意味着我不能创造新的记忆。只要这具躯体还能动弹，我就永远不会忘记你的胜利！";
            		if (guide >= 0 && chat == "I bet " + Main.npc[guide].GivenName + " has a big juicy brain... not that I would wanna... uh... did you need something?")
            			chat = "我敢打赌" + Main.npc[guide].GivenName + "有一个鲜美多汁的大脑子…真是令人欲罢不能…你要买点什么？";
	if (partyGirl >= 0 && chat == "" + Main.npc[partyGirl].GivenName + "'s brain would surely taste like candy... Oh uh, hello there!")
			chat = "" + Main.npc[partyGirl].GivenName + "的脑子肯定尝起来像块蛋糕…哦，你好啊，买点什么！";
            }
            #endregion
            #region cook
             else if (npc.type == ModContent.NPCType<Cook>())
            {
                if (chat == "I've got a lot of orders from the other townsfolk right now, make it quick!")
                    chat = "我现在收到了很多其他住民的订单，快点！";
                else if (chat == "How did any of you survive before I arrived? What could you have possibly been eating, dirt?")
                    chat = "在我来之前你们是怎么活下来的？你们吃什么？吃土吗？";
                else if (chat == "I'm stuck with dull knives while you wield weapons of unimaginable power? Give me a break...")
                    chat = "凭什么我为这该死的钝刀头疼不已，你却能挥着锋利的武器所向披靡？饶了我吧…";
                else if (chat == "No one should go adventuring on an empty stomach. Eat well, hero!")
                    chat = "任何人都不该空着肚子去冒险。吃好点，英雄！";
                else if (chat == "Supply me with the proper ingredients, and I can make some truly powerful foods for you, hero!")
                    chat = "给我提供合适的食材，我就能给你做一些真正强而有力的食物，英雄";
                else if (chat == "Looks like you don't have any ingredients in your bag. If you can find enough of an ingredient I'm looking for, I can supply you with new purchasable foods. Some of these dishes will be far more powerful than my usual wares, so keep your eyes peeled for unique ingredients!")
                    chat = "你包里什么原料都没有啊。如果你能找到足够的我正在寻找的原料，我可以为你提供新的可购买的食物。有些食物会比我平时做的食物更加美味，所以你一定要留心寻找独特的食材!";
                else if (chat == "Leaves? You want me to cook some food... with leaves? Well, I don't think these would really work in a salad, so how about some tea instead? I'm sure it will calm you down if you're stressed")
                    chat = "生命之叶吗?你想让我做饭…用树叶吗?我觉得这些不适合做沙拉，所以用茶来代替怎么样?我相信你有压力，它会让你平静下来";
                else if (chat == "Lovely, just enough blueberries for the job! Thanks, and please enjoy,")
                    chat = "太好了，蓝浆果刚好够用!谢谢，请享受";
                else if (chat == "These were exactly what I was missing for my special hot chocolate recipe! If you're planning on going somewhere a little chilly, these will warm you right up for sure")
                    chat = "这些正是巧克力热饮食谱所缺少的东西!如果你打算去一个寒冷的地方，这些肯定会让你暖和起来";
                else if (chat == "This crisp morel was just asking to be put in a dish. I hope it's to your liking!")
                    chat = "这道酥脆的烤蘑菇放在盘子里。我希望你喜欢!";
                else if (chat == "Pink pears can be problematic if prepared improperly. Good thing I'm a professional pear pickler!")
                    chat = "如果处理不当，粉仙人掌果可能会有问题。还好我是专业的!";
                else if (chat == "Well uh... I DID cook it, though I'm not entirely sure you should eat this stuff")
                    chat = "嗯嗯…我确实做了，虽然我不确定你是否真的想吃这些东西";
                else if (chat == "With just the right amount of green, this dish gets real mean. Be careful eating it!")
                    chat = "只要加入适量的绿色，这道菜就会变得非常美味。吃的时候要小心!";
                else if (chat == "I had to visit a far away land to learn how to make this dish. Hopefully you'll appreciate it!")
                    chat = "我去了遥远的地方学习如何做这道菜。希望你会喜欢它!!";
                else if (chat == "When I was younger, my mother would always greet me with some mint tea after a long, hard day... I miss the simpler times.")
                    chat = "在我小的时候，我的母亲总是用薄荷茶来迎接我漫长而辛苦的一天……我怀念那些平淡的时光.";
                else if (chat == "Yunno, it's not just called a 'Sky Blue Flower' because of its color. Some say they've fallen from the sky islands themselves long ago.")
                    chat = "Yunno, 它被称为“天蓝花”不仅仅是因为它的颜色。有人说他们很久以前就从天上的岛屿上掉下来了.";
                else if (chat == "Last time I took a bite of this stuff, I started thinking everything was out to get me... but hey, maybe that's what you're looking for?")
                    chat = "上次我吃了一口这种东西，我开始觉得一切都是为了害我……但是，也许这就是你要的?";
                else if (chat == "Ah, just what I need to help ripen this cheese! Hopefully this'll offer a little more 'pizazz' to its taste.")
                    chat = "啊，正好是我用来做奶酪的东西!希望这能给你的口味带一点“活力”.";
                else if (chat == "I'm honored that you'd trust me with such rare commodities. Hopefully this new recipe suits your fancy!")
                    chat = "我能信任我真好，把这么稀有东西交给我。希望这个新食物符合你的喜好!";
                else if (chat == "I myself don't know much about the Hallow, it's a rather strange place... but berries are berries, right?")
                    chat = "我不太了解神圣之地，那是个相当奇怪的地方……但是浆果就是浆果，对吧?";
                else if (chat == "So the legends are true... The kitchen scholars thought this recipe was lost to time, but it's right in front of me. I can barely contain my excitement to try it out!")
                    chat = "所以传说是真的…很多厨师认为这个食谱已经失传了，但它就在我面前，我无法克制自己的兴奋感！";
                else if (chat == "I can tell this was written by an ogre... still, the pictures give me a clear idea on how to brew this. Be careful with this stuff, it's highly potent!")
                    chat = "我看得出这是食人魔写的……不过，这个食谱给了我一个关于如何酿造这款酒的想法，小心这东西，它的酒劲很大!";
                else if (chat == "I could see the battle from here. To think you would risk your life to save us from something as overwhelming as... that. Take a seat kid, I'll cook your favorite meal - it's on me")
                    chat = "我在这里看到了那场战斗。想到你能不顾生命危险救我们于水火之中……坐下吧，孩子，我做了你最爱的饭菜——我请客。";
                // 需测试
            		if (angler >= 0 && chat == "" + Main.npc[angler].GivenName + " can be a real brat at times, but as long as he keeps providing me with fresh fish, I won't complain.")
            			chat = "" + Main.npc[angler].GivenName + "有些时候真是顽劣，但只要他一直给我提供新鲜的鱼，我就不会抱怨的。";
	if (partyGirl >= 0 && chat == "Cooking for " + Main.npc[partyGirl].GivenName + " is no easy task. She simply refuses to eat any form of meat!")
			chat = "给" + Main.npc[partyGirl].GivenName + "做饭可真不简单。她完全不吃任何形式的肉类！";
	if (witchDoctor >= 0 && chat == "The last time " + Main.npc[witchDoctor].GivenName + " asked me to cook for him, he requested bugs! This truly is a strange place...")
			chat = "上一次" + Main.npc[witchDoctor].GivenName + "让我给他做饭的时候，他点了虫子！真是太奇怪了…";
            }
            #endregion
            #region desertAcolyte
            else if (npc.type == ModContent.NPCType<DesertAcolyte>())
            {
                if (chat == "We certainly have some strange people around this town, don't we...?")
                    chat = "这个镇上确实有一些奇怪的人，不是吗?";
                else if (chat == "You didn't see any giant bird shadows while you were out in the desert, did you?")
                    chat = "你在沙漠里的时候没有看到任何巨大的鸟影吧?";
                else if (chat == "I had originally stopped just to refill my canteen, but you seem like someone who can deal with a real threat!")
                    chat = "我本来只是停下来给我的水壶加满水，但你看起来像是一个能处理危险的人!";
                else if (chat == "Have you ever heard tale of the Thunder Birds? Legend says they had long protected our world from cataclysmic threats, before a disagreement between them and three individuals led to their disappearance...")
                    chat = "“你听说过惊雷王鹰的故事吗?”传说他们长期以来一直保护我们的世界免受灾难性的威胁，直到他和三之小雷鹰之间的分歧……";
                else if (chat == "If you're interested in the secrets of my people, be sure to purchase a 'Blank Technique Scroll'. They offer great power to those that utilize them well...")
                    chat = "“如果你对我的秘密感兴趣，请务必购买一个“空白秘技卷轴”。它们赐予人类很强大的力量……";
                else if (chat == "I have seen so much evil in my travels... I only hope someone can put a stop to them!")
                    chat = "“我在旅行中见过太多恶魔……我只希望有人能阻止他们!";
                else if (chat == "Although I'm only an acolyte, one of the first things we learn is how to create a sandstorm. Beware the creatures that lurk within however...")
                    chat = "“虽然我只是一名助手，但我们首先学会的一件事就是如何制造沙尘暴。小心潜伏在内部的生物……";
                else if (chat == "Creating a sandstorm is a very taxing job. I would prefer to have some compensation in the form of money, please")
                    chat = "“制造沙尘暴是一项非常费力的工作.我希望能得到金钱上的补偿";
                else if (chat == "It seems I was right to place my trust in you, my friend. You've protected us from every threat that arose, and for that, I'm truly grateful. Maybe now I can finally relax a little.")
                    chat = "“看来我相信你是对的，我的朋友，你保护我们不受任何威胁，为此，我真的很感激。也许现在我可以放松一下了。";
                // 需测试
            		if (armsDealer >= 0 && chat == "Look at " + Main.npc[armsDealer].GivenName + " over there! He's got an entire arsenal of guns, is that really safe?")
            			chat = "看" + Main.npc[armsDealer].GivenName + "那边！他有那么多枪，真的安全吗？";
	if (dyeTrader >= 0 && chat == "" + Main.npc[dyeTrader].GivenName + " was interested in dying my attire, but his choice of plant dye was 'strange' to say the least.")
			chat = "" + Main.npc[dyeTrader].GivenName + "对染我的衣服很感兴趣，但他选择的植物染料可以说是“奇怪”的。";
            }
            #endregion
            #region diverman
            else if (npc.type == ModContent.NPCType<Diverman>())
            {
                if (chat == "Have you adventured into the aquatic depths yet...? Its choking atmosphere prevents most explorers from entering, but I'm confident you'll find a way around it...")
                    chat = "你到深海探险过吗?它令人窒息的大气层阻止了大多数探险者进入，但我相信你会找到办法绕过它的……";
                else if (chat == "I've collected many marine items in my travels, hero. Would you like to purchase one?")
                    chat = "我在旅行中收集了很多海洋物品，英雄.你想买一个吗?";
                else if (chat == "Being at the bottom of the ocean for long periods of time has taught me one thing; Always come prepared!")
                    chat = "在海底深渊呆了很长一段时间教会了我一件事;要有备而来!";
                else if (chat == "You would think it gets hard to breath under this helmet, but really I'm just used to it now")
                    chat = "你可能会认为戴着头盔会呼吸困难，但实际上我现在已经习惯了";
                else if (chat == "You ever try to drink a bottle of water, while drowning, to save yourself? I know I have!")
                    chat = "你有没有试过在快溺水的时候喝一瓶水来救自己?我知道我有!";
                else if (chat == "Here you go friend! This air tank will automatically activate when your breath reaches critical level. Come visit me afterwards and I'll refill it free of charge!")
                    chat = "给你，朋友!当你的呼吸达到临界时，这个空气瓶会自行启动。以后来找我，我会免费的!";
                else if (chat == "Here you go friend! This air tank will automatically activate when your breath reaches critical level. Come visit me afterwards and I'll refill it free of charge!")
                    chat = "嗯，你的空气瓶看起来满了……你只是想聊聊吗?我有各种各样的故事!";
                else if (chat == "Not bad, kid... Not bad at all. Hopefully you've had fun during all of your adventures out there. I guess you could say I've always been keeping an eye on you.")
                    chat = "不错啊，孩子……还不错。希望你在所有的冒险中都玩得很开心。我想说我一直在看着你";
                // 需测试
            		if (angler >= 0 && chat == "That little twerp, " + Main.npc[angler].GivenName + ", thinks he knows so much about the sea...")
            			chat = "这个蠢蛋" + Main.npc[angler].GivenName + "，自以为很了解大海";
	if (pirate >= 0 && chat == "You wouldn't believe it, but " + Main.npc[pirate].GivenName + " and me go way back. He wasn't always a salt water scourge, yunno'.")
			chat = "你可能不会相信，我和" + Main.npc[pirate].GivenName + "老早以前就认识了，他并不会的海洋做出危险举动，不是吗？";
            }
            #endregion
            #region druid
            else if (npc.type == ModContent.NPCType<Druid>())
            {
                if (chat == "Getting these seeds is a bigger hassle than you would think. Nearly drowning, almost melting, freezing to- You get the idea.")
                    chat = "获取这些种子比你想象的要麻烦得多。差点淹死，差点融化，差点冻死-你懂的。";
                else if (chat == "I often take visits to the jungle. I can understand the aversion to the place, but the creatures within don't seem to hassle me...")
                    chat = "我经常参观丛林。我能理解对这个地方的厌恶，但里面的生物似乎不会打扰我……";
                else if (chat == "My mother was a well known herbalist back in the day. She doesn't talk about my father, though. I wonder why?")
                    chat = "我母亲以前是一位有名的草药医生.不过她没提过我父亲。我想知道为什么?";
                else if (chat == "The natural world is quite a wonder. Every little place has its own charm. Some more than others!")
                    chat = "自然界真是个奇迹。每个地方都有自己的魅力。有些人比其他人更厉害!";
                else if (chat == "Normally I'd say something like, 'nature finds a way', but I'm not even sure if Mother Nature could survive if you failed to stop those spirits' carnage... Please take these lilies, in gratitude for your courage!")
                    chat = "通常我会说“大自然会有办法的”，如果你不能阻止那些灵魂的厮杀，大自然母亲是否还能生存……请收下这些百合花，感谢你的勇气!";
                // 需测试
            		if (cook >= 0 && chat == "I wonder if I can convince " + Main.npc[cook].GivenName + ", to whip me up a salad.")
            			chat = "我想知道我可以让" + Main.npc[cook].GivenName + "给我做一份沙拉。";
	if (dryad >= 0 && chat == "Ever since I was a child, I've always wanted to meet a dryad. What luck it is to find " + Main.npc[dryad].GivenName + " here!")
			chat = "从我还是小孩子的时候，就一直想看看" + Main.npc[dryad].GivenName + "，没想到在这里看见了，真幸运！";
	if (witchDoctor >= 0 && chat == "Our friend there, " + Main.npc[witchDoctor].GivenName + ", is rather strange isn't he? He speaks in riddles...")
			chat = "我们的朋友" + Main.npc[witchDoctor].GivenName + "他很奇怪，不是吗?他说话和谜语人一样...";
            }
            #endregion
            #region spiritualist
            else if (npc.type == ModContent.NPCType<Spiritualist>())
            {
                if (chat == "Ah, it's been a while friend. It is good to see you are well after so long!")
                    chat = "啊，好久不见了，看到你身体好，真是太好了!";
                else if (chat == "Not all who wander are lost, remember this friend...")
                    chat = "不是所有流浪的人都迷路了，记住这位朋友……";
                else if (chat == "Energy, chi, spirit... it's all the same to me. There is power in all things.")
                    chat = "能量、气、精神……对我来说都一样。万物皆有力量";
                else if (chat == "I have no doubt of your physical power, hero. But sometimes hardship is fought in a battle of will, not strength.")
                    chat = "我对你的体力毫不怀疑，英雄.但有时需要的是艰难是意志的较量，而不是力量的较量";
                else if (chat == "Is- Is that my cross? How in the world did you manage to find it? It's been lost for so long....")
                    chat = "那是我的十字架吗?你到底是怎么找到它的?它已经丢失太久了……";
                else if (chat == "With these shards, I have imbued you with an incredibly potent shield. Should you take fatal damage, you shall receive my protection for as long as I can hold it. Stay safe out there, my friend")
                    chat = "有了这些碎片，我给你给你一个强大的护盾。如果你受到致命的伤害，你将得到我的保护，只要我能承受住它。注意安全，我的朋友";
                else if (chat == "I require no money to watch over you my friend, but my protection is limited without some Purified Shards. Once you acquire some, come visit me again")
                    chat = "我不需要钱来保护你，我的朋友，但没有净化碎片我的保护是有限的。等你有了，再来找我";
                else if (chat == "No need to fear my friend, my power is already protecting you. Come back when my power has faded")
                    chat = "不用害怕我的朋友，我的力量已经在保护你了。当我的力量消失后，再来找我";
                else if (chat == "I'm afraid I can't currently protect you, friend. Give your soul some time to heal, and then come speak to me again")
                    chat = "恐怕我现在不能保护你，朋友。给你的灵魂一些时间来愈合，然后再来找我";
                else if (chat == "From the moment we first spoke I sensed something special within you. Your spirit exudes an incredible energy, one that I'm honored to have witnessed. Stay golden my friend")
                    chat = "从我们第一次交谈的那一刻起，我就感觉到你身上有一种特别的东西。你的精神散发出一种不可思议的力量，我很荣幸目睹了这种力量。保持很好我的朋友";
            }
                // 需测试
            		if (angler >= 0 && chat == "" + Main.npc[angler].GivenName + ", often comes to me in private to discuss things that are bothering him. Such a young age to be in his position...")
            			chat = "" + Main.npc[angler].GivenName + "经常私下来找我谈论困扰他的事情。这么年轻就有了他现在的地位……";
	if (witchDoctor >= 0 && chat == "" + Main.npc[witchDoctor].GivenName + " and I spent all of last night discussing philosophy. That one has a wise head on his shoulders.")
			chat = "" + Main.npc[witchDoctor].GivenName + "昨天一整晚都在和我讨论人生观念，这个人很聪明。";
            #endregion
            #region tracker
            else if (npc.type == ModContent.NPCType<Tracker>())
            {
                if (chat == "Seen any interesting beasts lurking around lately? Minotaurs? Beholders? Gorgons?")
                    chat = "最近有没有看到什么有趣的怪物潜伏在附近?牛头怪?恶魔眼?蛇发女妖吗?";
                else if (chat == "Bear your scars with pride, as each one has a tale to tell... What do your scars say about you, hero?")
                    chat = "骄傲地承受你的伤痕，因为每个人都有一个故事要讲……你的伤疤说明了什么，英雄?";
                else if (chat == "Many beasts have fallen to me and my axe, but new ones are always on the prowl. Keep your eyes peeled, kid")
                    chat = "许多野兽倒在我和我的斧头下，但新的怪物一直在徘徊。擦亮眼睛，孩子";
                else if (chat == "You'd be surprised how effective a single shoulder pad can be")
                    chat = "你会惊讶一个单肩垫的多么有用";
                else if (chat == "A reality-ending nightmare entity, kid? You certainly don't cut corners, there's no way I can top that!")
                    chat = "一个终结现实的噩梦实体，孩子?你当然不会走捷径，我不可能超过你!";
                // 需测试
            		if (stylist >= 0 && chat == "Do you think " + Main.npc[stylist].GivenName + " would give a haircut even to a brute like me...?")
            			chat = "你认为" + Main.npc[stylist].GivenName + "会给我这样的野蛮人理发吗?";
	if (tavernkeep >= 0 && chat == "" + Main.npc[tavernkeep].GivenName + ", " + Main.npc[weaponMaster].GivenName + ", and I were gonna start a gym together. You want in?")
			chat = "" + Main.npc[tavernkeep].GivenName + ", " + Main.npc[weaponMaster].GivenName + "我们想开一家健身房。你想来吗?";
            }
            #endregion
            #region weaponMaster
            else if (npc.type == ModContent.NPCType<WeaponMaster>())
            {
                if (chat == "Long ago, when this world was first taking form, my race reigned supreme. That time has passed it seems..")
                    chat = "很久以前，当这个世界刚形成的时候，我的种族统治着世界。时间似乎已经过去了";
                else if (chat == "I'm not one for idle chatter. If you have need of me, make it quick.")
                    chat = "我不是一个喜欢闲聊的人。如果你需要我，就快点.";
                else if (chat == "My race's obsession with voodoo dolls has only become rampant just recently. It's truly a fad gone wrong...")
                    chat = "我的种族对巫毒娃娃的痴迷最近才开始变得猖獗。这真的是一种错误的时尚….";
                else if (chat == "Should you have the coin, I would be willing to accompany you in your endeavors...")
                    chat = "如果你有这个钱，我愿意陪你一起努力…";
                else if (chat == "I see you're lacking in coin. Remedy that and l may just help you out...")
                    chat = "我看你缺钱，去赚够钱，我也许会帮你";
                else if (chat == "A warrior without his weapon stands no chance against the ever-powering threats he must face...")
                    chat = "一个没有武器的战士在他必须面对的更强大威胁面前是毫无胜算…";
                // 需测试
            		if (guide >= 0 && chat == "That man over there, " + Main.npc[guide].GivenName + ", keeps giving me dirty looks...")
            			chat = "那边那个人" + Main.npc[guide].GivenName + "一直在恶狠狠的看着我.....";
	if (taxCollector >= 0 && chat == "I see we have another demon within our ranks. What was his name again? " + Main.npc[taxCollector].GivenName + " ?")
			chat = "看来我们又多了一个恶魔。他叫什么来着?" + Main.npc[taxCollector].GivenName + "？";
	if (weaponMaster >= 0 && chat == "" + Main.npc[weaponMaster].GivenName + " blankly stares through you, as though he's not entirely there...")
			chat = "" + Main.npc[weaponMaster].GivenName + "迷茫地凝视着你，仿佛他并不完全在那里……";
                // 需测试玩家信息
                                    *So... you've gained the ability to speak in tongues, <name of player>? Very fascinating...
                                    Ie... oep'wl vmnjld hrl mfnbnho he iwlmc nj hejvpli, <name of player>? Wlgo zmisnjmhnjv...
                else if (chat == "I was exiled from my people when I chose to side with your kind. They thought me foolish, placing faith in those that dwelled above. I'm sure they're feeling rather foolish themselves after what you've just accomplished. Well done, ")
                    chat = "当我选择站在你这一边时，我就被我的种族驱逐了。他们以为我愚蠢，相信天上的神。我敢肯定，在你刚刚完成的事情之后，他们自己也觉得很愚蠢。干得好，";
            }
            #endregion
        }
    }
}*/
