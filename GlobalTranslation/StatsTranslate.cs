using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Terraria.ModLoader;
using Terraria.UI.Chat;
using ThoriumMod.UI;

namespace ThoriumModzhcn.GlobalTranslation
{
    public class StatsTranslate : ModSystem
    {
        public override void Load()
        {
            On_ChatManager.ParseMessage += Translate;            
        }
        public override void Unload()
        {
            On_ChatManager.ParseMessage -= Translate;
        }       
        private static List<TextSnippet> Translate(On_ChatManager.orig_ParseMessage orig, string text, Color baseColor)
        {
            //原瑟银
           /* text = Regex.Replace(text, "Healer Stats", "牧师属性");
            text = Regex.Replace(text, "Current Bonus Healing", "当前额外治疗量");
            text = Regex.Replace(text, "Best Heal Streak", "最大连击治疗量");
            text = Regex.Replace(text, "Healing done", "治疗量");
            text = Regex.Replace(text, "Damage mitigated", "伤害减缓");
            text = Regex.Replace(text, "Lives saved", "救死扶伤");
            text = Regex.Replace(text, "Close calls", "死里逃生");
            text = Regex.Replace(text, "Bard Stats", "吟游诗人属性");
            text = Regex.Replace(text, "Bonus Duration", "咒音增幅的持续时间");
            text = Regex.Replace(text, "sec\\(s\\)", "秒");
            text = Regex.Replace(text, "Max-Use Duration", "最大使用时间");
            text = Regex.Replace(text, "Base Inspiration", "基础灵感值");
            text = Regex.Replace(text, "Bonus Inspiration", "额外灵感值");
            text = Regex.Replace(text, "Timed Hits", "抓住节拍次数");
            text = Regex.Replace(text, "sec", "秒"); 
            //鞋匠	
            text = Regex.Replace(text, "There we go, ", "好了, ");
            text = Regex.Replace(text, "good as new. It won't last long, but maybe you'll notice some more spring in your step. Make sure to stay safe out there, hero!", "你的鞋子焕然如新. 虽然不能保持太久, 但也许你能感觉到你的脚步更加轻快自如了. 在外一定要注意安全，英雄！");

            //迷途僵尸
            text = Regex.Replace(text, "I just whipped up the perfect recipe to deter Bats from bothering you; no more tiny nibbles!", "我刚刚做出来一个完美的配方，能让蝙蝠不再骚扰你；这样就不会再被咬了！");
            text = Regex.Replace(text, "Getting this stuff to work underwater was a huge hassle... Either way, hungry fish shouldn't attempt to eat you with this.", "这群烦人的东西会给水下作业带来不小的麻烦…不管怎样，带上这个，饥饿的鱼类就不会再企图攻击你。");
            text = Regex.Replace(text, "With this nasty concoction, insects will associate your scent with their queen! Neat, huh?", "用了这瓶恶心的混合物，昆虫就会把你和它们的女王联系起来！太精妙了，对吧？");
            text = Regex.Replace(text, "I'll be honest, this is just a bottle of pure liquid calcium. Don't question it, the skeletons surely wont either!", "其实，这就是一瓶高纯液体钙。不要质疑它的效果，骷髅也会对这瓶药剂深信不疑！");
            text = Regex.Replace(text, "If this turned out correctly, you'll smell just like a zombie. Hopefully your nights will be a tad more calm!", "正常生效的话，这瓶药剂会让你闻起来像一只僵尸。希望你今天能有个平静的夜晚！");
            text = Regex.Replace(text, "I'm afraid you'll have to give me some more time to prepare the next repellent. This stuff can get pretty complicated...", "恐怕你得多给我一点时间来准备下一瓶趋避剂。这东西还挺复杂的…");
            text = Regex.Replace(text, "Looks like you're a bit short on funds. Come back when you have a little more coin in your pocket!", "看来你手头有点紧。等兜里有一些钱了再来吧！");

            //厨师
            text = Regex.Replace(text, "Looks like you don't have any ingredients in your bag. If you can find enough of an ingredient I'm looking for, I can supply you with new purchasable foods. Some of these dishes will be far more powerful than my usual wares, so keep your eyes peeled for unique ingredients!", "你包里什么原料都没有啊。如果你能找到足够的我正在寻找的原料，我可以为你提供新的可购买的食物。有些食物会比我平时做的食物更加美味，所以你一定要留心寻找独特的食材!");
            text = Regex.Replace(text, "Leaves? You want me to cook some food... with leaves? Well, I don't think these would really work in a salad, so how about some tea instead? I'm sure it will calm you down if you're stressed", "生命之叶?你想让我做饭…用树叶吗?我觉得这些不适合做沙拉，所以用茶来代替怎么样?我相信你有压力，它会让你平静下来");
            text = Regex.Replace(text, "Lovely, just enough blueberries for the job! Thanks, and please enjoy,", "太好了，蓝浆果刚好够用!谢谢，请享受，");
            text = Regex.Replace(text, "These were exactly what I was missing for my special hot chocolate recipe! If you're planning on going somewhere a little chilly, these will warm you right up for sure", "这些正是巧克力热饮食谱所缺少的东西!如果你打算去一个寒冷的地方，这些肯定会让你暖和起来");
            text = Regex.Replace(text, "This crisp morel was just asking to be put in a dish. I hope it's to your liking!", "这道酥脆的烤蘑菇放在盘子里。我希望你喜欢!");
            text = Regex.Replace(text, "Pink pears can be problematic if prepared improperly. Good thing I'm a professional pear pickler!", "如果处理不当，粉仙人掌果可能会有问题。还好我是专业的!");
            text = Regex.Replace(text, "Well uh... I DID cook it, though I'm not entirely sure you should eat this stuff", "嗯嗯…我确实做了，虽然我不确定你是否真的想吃这些东西");
            text = Regex.Replace(text, "With just the right amount of green, this dish gets real mean. Be careful eating it!", "只要加入适量的绿色，这道菜就会变得非常美味。吃的时候要小心!");
            text = Regex.Replace(text, "I had to visit a far away land to learn how to make this dish. Hopefully you'll appreciate it!", "我去了遥远的地方学习如何做这道菜。希望你会喜欢它!");
            text = Regex.Replace(text, "When I was younger, my mother would always greet me with some mint tea after a long, hard day... I miss the simpler times.", "在我小的时候，我的母亲总是用薄荷茶来迎接我漫长而辛苦的一天……我怀念那些平淡的时光.");
            text = Regex.Replace(text, "Yunno, it's not just called a 'Sky Blue Flower' because of its color. Some say they've fallen from the sky islands themselves long ago.", "Yunno, 它被称为“天蓝花”不仅仅是因为它的颜色。有人说他们很久以前就从天上的岛屿上掉下来了.");
            text = Regex.Replace(text, "Last time I took a bite of this stuff, I started thinking everything was out to get me... but hey, maybe that's what you're looking for?", "上次我吃了一口这种东西，我开始觉得一切都是为了害我……但是，也许这就是你要的?");
            text = Regex.Replace(text, "Ah, just what I need to help ripen this cheese! Hopefully this'll offer a little more 'pizazz' to its taste.", "啊，正好是我用来做奶酪的东西!希望这能给你的口味带一点“活力”.");
            text = Regex.Replace(text, "I'm honored that you'd trust me with such rare commodities. Hopefully this new recipe suits your fancy!", "我能信任我真好，把这么稀有东西交给我。希望这个新食物符合你的喜好!");
            text = Regex.Replace(text, "I myself don't know much about the Hallow, it's a rather strange place... but berries are berries, right?", "我不太了解神圣之地，那是个相当奇怪的地方……但是浆果就是浆果，对吧?");
            text = Regex.Replace(text, "So the legends are true... The kitchen scholars thought this recipe was lost to time, but it's right in front of me. I can barely contain my excitement to try it out!", "所以传说是真的…很多厨师认为这个食谱已经失传了，但它就在我面前，我无法克制自己的兴奋感！");
            text = Regex.Replace(text, "I can tell this was written by an ogre... still, the pictures give me a clear idea on how to brew this. Be careful with this stuff, it's highly potent!", "我看得出这是食人魔写的……不过，这个食谱给了我一个关于如何酿造这款酒的想法，小心这东西，它的酒劲很大!");

            //荒漠侍僧
            text = Regex.Replace(text, "Although I'm only an acolyte, one of the first things we learn is how to create a sandstorm. Beware the creatures that lurk within however...", "虽然我只是个侍僧，但我学的第一件事就是如何召唤沙尘暴。小心潜藏在风沙里的生物…");
            text = Regex.Replace(text, "Creating a sandstorm is a very taxing job. I would prefer to have some compensation in the form of money, please", "召唤沙尘暴是个相当繁重的工作。请给我一些金钱形式的补偿吧。");

            //潜水员
            text = Regex.Replace(text, "Here you go friend! This air tank will automatically activate when your breath reaches critical level. Come visit me afterwards and I'll refill it free of charge!", "给你，我的朋友!当你的呼吸达到临界时，这个空气瓶会自行启动。以后来找我，我会免费的!");
            text = Regex.Replace(text, "Hmm, your air tank looks full to me... Did you just want to chat? I have all manner of tales to tell!", "嗯，你的空气瓶看起来满了……你只是想聊聊吗?我有各种各样的故事!");

            //牧师
            text = Regex.Replace(text, "Is- Is that my cross? How in the world did you manage to find it? It's been lost for so long....", "那是我的十字架吗?你到底是怎么找到它的?它已经丢失太久了……");
            text = Regex.Replace(text, "With these shards, I have imbued you with an incredibly potent shield. Should you take fatal damage, you shall receive my protection for as long as I can hold it. Stay safe out there, my friend", "有了这些碎片，我给你给你一个强大的护盾。如果你受到致命的伤害，你将得到我的保护，只要我能承受住它。注意安全，我的朋友");
            text = Regex.Replace(text, "I require no money to watch over you my friend, but my protection is limited without some Purified Shards. Once you acquire some, come visit me again", "我不需要钱来保护你，我的朋友，但没有净化碎片我的保护是有限的。等你有了，再来找我");
            text = Regex.Replace(text, "No need to fear my friend, my power is already protecting you. Come back when my power has faded", "不用害怕我的朋友，我的力量已经在保护你了。当我的力量消失后，再来找我");
            text = Regex.Replace(text, "I'm afraid I can't currently protect you, friend. Give your soul some time to heal, and then come speak to me again", "恐怕我现在不能保护你，朋友。给你的灵魂需要一些时间来愈合，然后再来找我");

            //武器大师
            text = Regex.Replace(text, "blankly stares through you, as though he's not entirely there...", "迷茫地凝视着你，仿佛他并不完全在那里……");
            text = Regex.Replace(text, " *So... you've gained the ability to speak in tongues, ", "所以…你已经获得了能听懂我说话的能力，");
            text = Regex.Replace(text, "? Very fascinating...", "？太棒了....");*/


            //瑟银重置
            text = Regex.Replace(text, "PHOTOSENSITIVITY WARNING: ", "光 敏 警 告: " ); 
            text = Regex.Replace(text, "mod adds a lot of flashy effects! Especially in boss fights!", "模组增加了很多华丽的效果!尤其是在boss战中！");  
            text = Regex.Replace(text, "If you are photosensitive, go to Settings -> Mod Configuration -> Thorium Bosses Rework -> Visual Settings and set all the sliders to 0!", "如果你感觉到不适，请转到设置 -> 模组配置 -> Thorium Bosses Rework -> 视觉设置，并将所有设置调整为0!");  
            text = Regex.Replace(text, "You can turn off this warning in the config as well if you do not want to keep seeing it!", "如果你不想看到这个警告，也可以在配置中关闭它!");      
            return orig.Invoke(text, baseColor);
        }       
    }
}
