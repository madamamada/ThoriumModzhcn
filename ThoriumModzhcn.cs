using System.Linq;
using System.Reflection;
using System.Threading;
using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ThoriumModzhcn
{
	public class ThoriumModzhcn : Mod
	{
		public override void Load()
		{
			Translator.ThoriumModTranslator.LoadTranslator();
			Translator.ThoriumClassTagsConsistencyTranslator.LoadTranslator();
			Translator.CalamityBardHealerTranslator.LoadTranslator();
			Translator.SpookyBardHealerTranslator.LoadTranslator();
			base.Load();
		}
	}
	public class ThoriumModzhcnPlayer : ModPlayer
	{
		public override void OnEnterWorld()
		{
			Main.NewText("瑟银简中汉化完成98%，有bug或掉帧行为在评论区告诉我，禁止催更\n部分获取方法已标注，仅加载合成表和boss手册没有的。如不知道怎么获得的方式在评论区告诉我\n乐器种类在设置 -> ThoriumMod -> 客户端配置 -> 吟游诗人选项 -> 显示乐器类型标签选择项目打开", Color.Orange);
		}
	}
}

