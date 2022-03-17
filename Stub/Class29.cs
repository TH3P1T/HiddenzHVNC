using System;

namespace Stub
{
	// Token: 0x02000024 RID: 36
	public class Class29
	{
		// Token: 0x06000065 RID: 101 RVA: 0x00004BA0 File Offset: 0x00002DA0
		public static string smethod_0()
		{
			string text = "acegikmoqsuwyBDFHJLNPRTVXZ";
			string text2 = "";
			Random random = new Random();
			int num = random.Next(0, text.Length);
			for (int i = 0; i < num; i++)
			{
				text2 += text[random.Next(10, text.Length)].ToString();
			}
			return text2;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002186 File Offset: 0x00000386
		public static int smethod_1()
		{
			return new Random().Next(11, 99);
		}
	}
}
