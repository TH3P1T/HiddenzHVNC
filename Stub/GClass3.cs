using System;
using System.Runtime.InteropServices;

namespace Stub
{
	// Token: 0x0200004D RID: 77
	public static class GClass3
	{
		// Token: 0x06000103 RID: 259
		[DllImport("bcrypt.dll")]
		public static extern uint BCryptOpenAlgorithmProvider(out IntPtr intptr_0, [MarshalAs(UnmanagedType.LPWStr)] string String_7, [MarshalAs(UnmanagedType.LPWStr)] string String_8, uint uint_4);

		// Token: 0x06000104 RID: 260
		[DllImport("bcrypt.dll")]
		public static extern uint BCryptCloseAlgorithmProvider(IntPtr intptr_0, uint uint_4);

		// Token: 0x06000105 RID: 261
		[DllImport("bcrypt.dll")]
		public static extern uint BCryptGetProperty(IntPtr intptr_0, [MarshalAs(UnmanagedType.LPWStr)] string String_7, byte[] byte_1, int int_2, ref int int_3, uint uint_4);

		// Token: 0x06000106 RID: 262
		[DllImport("bcrypt.dll")]
		public static extern uint BCryptSetProperty(IntPtr intptr_0, [MarshalAs(UnmanagedType.LPWStr)] string String_7, byte[] byte_1, int int_2, int int_3);

		// Token: 0x06000107 RID: 263
		[DllImport("bcrypt.dll")]
		public static extern uint BCryptImportKey(IntPtr intptr_0, IntPtr intptr_1, [MarshalAs(UnmanagedType.LPWStr)] string String_7, out IntPtr intptr_2, IntPtr intptr_3, int int_2, byte[] byte_1, int int_3, uint uint_4);

		// Token: 0x06000108 RID: 264
		[DllImport("bcrypt.dll")]
		public static extern uint BCryptDestroyKey(IntPtr intptr_0);

		// Token: 0x06000109 RID: 265
		[DllImport("bcrypt.dll")]
		public static extern uint BCryptEncrypt(IntPtr intptr_0, byte[] byte_1, int int_2, ref GClass3.GStruct2 gstruct2_0, byte[] byte_2, int int_3, byte[] byte_3, int int_4, ref int int_5, uint uint_4);

		// Token: 0x0600010A RID: 266
		[DllImport("bcrypt.dll")]
		public static extern uint BCryptDecrypt(IntPtr intptr_0, byte[] byte_1, int int_2, ref GClass3.GStruct2 gstruct2_0, byte[] byte_2, int int_3, byte[] byte_3, int int_4, ref int int_5, int int_6);

		// Token: 0x040000AC RID: 172
		public const uint uint_0 = 0U;

		// Token: 0x040000AD RID: 173
		public const uint uint_1 = 8U;

		// Token: 0x040000AE RID: 174
		public const uint uint_2 = 4U;

		// Token: 0x040000AF RID: 175
		public static readonly byte[] byte_0 = BitConverter.GetBytes(1296188491);

		// Token: 0x040000B0 RID: 176
		public static readonly string String_0 = "ObjectLength";

		// Token: 0x040000B1 RID: 177
		public static readonly string String_1 = "ChainingModeGCM";

		// Token: 0x040000B2 RID: 178
		public static readonly string String_2 = "AuthTagLength";

		// Token: 0x040000B3 RID: 179
		public static readonly string String_3 = "ChainingMode";

		// Token: 0x040000B4 RID: 180
		public static readonly string String_4 = "KeyDataBlob";

		// Token: 0x040000B5 RID: 181
		public static readonly string String_5 = "AES";

		// Token: 0x040000B6 RID: 182
		public static readonly string String_6 = "Microsoft Primitive Provider";

		// Token: 0x040000B7 RID: 183
		public static readonly int int_0 = 1;

		// Token: 0x040000B8 RID: 184
		public static readonly int int_1 = 1;

		// Token: 0x040000B9 RID: 185
		public static readonly uint uint_3 = 3221266434U;

		// Token: 0x0200004E RID: 78
		private struct GStruct1
		{
			// Token: 0x0600010C RID: 268 RVA: 0x00002295 File Offset: 0x00000495
			public GStruct1(string String_1, int int_1)
			{
				this.String_0 = String_1;
				this.int_0 = int_1;
			}

			// Token: 0x040000BA RID: 186
			[MarshalAs(UnmanagedType.LPWStr)]
			public string String_0;

			// Token: 0x040000BB RID: 187
			public int int_0;
		}

		// Token: 0x0200004F RID: 79
		public struct GStruct2 : IDisposable
		{
			// Token: 0x0600010D RID: 269 RVA: 0x000068E4 File Offset: 0x00004AE4
			public GStruct2(byte[] byte_0, byte[] byte_1, byte[] byte_2)
			{
				this = default(GClass3.GStruct2);
				this.int_1 = GClass3.int_1;
				this.int_0 = Marshal.SizeOf(typeof(GClass3.GStruct2));
				if (byte_0 != null)
				{
					this.int_2 = byte_0.Length;
					this.intptr_0 = Marshal.AllocHGlobal(this.int_2);
					Marshal.Copy(byte_0, 0, this.intptr_0, this.int_2);
				}
				if (byte_1 != null)
				{
					this.int_3 = byte_1.Length;
					this.intptr_1 = Marshal.AllocHGlobal(this.int_3);
					Marshal.Copy(byte_1, 0, this.intptr_1, this.int_3);
				}
				if (byte_2 != null)
				{
					this.int_4 = byte_2.Length;
					this.intptr_2 = Marshal.AllocHGlobal(this.int_4);
					Marshal.Copy(byte_2, 0, this.intptr_2, this.int_4);
					this.int_5 = byte_2.Length;
					this.intptr_3 = Marshal.AllocHGlobal(this.int_5);
				}
			}

			// Token: 0x0600010E RID: 270 RVA: 0x000069C4 File Offset: 0x00004BC4
			public void Dispose()
			{
				if (this.intptr_0 != IntPtr.Zero)
				{
					Marshal.FreeHGlobal(this.intptr_0);
				}
				if (this.intptr_2 != IntPtr.Zero)
				{
					Marshal.FreeHGlobal(this.intptr_2);
				}
				if (this.intptr_1 != IntPtr.Zero)
				{
					Marshal.FreeHGlobal(this.intptr_1);
				}
				if (this.intptr_3 != IntPtr.Zero)
				{
					Marshal.FreeHGlobal(this.intptr_3);
				}
			}

			// Token: 0x040000BC RID: 188
			public int int_0;

			// Token: 0x040000BD RID: 189
			public int int_1;

			// Token: 0x040000BE RID: 190
			public IntPtr intptr_0;

			// Token: 0x040000BF RID: 191
			public int int_2;

			// Token: 0x040000C0 RID: 192
			public IntPtr intptr_1;

			// Token: 0x040000C1 RID: 193
			public int int_3;

			// Token: 0x040000C2 RID: 194
			public IntPtr intptr_2;

			// Token: 0x040000C3 RID: 195
			public int int_4;

			// Token: 0x040000C4 RID: 196
			public IntPtr intptr_3;

			// Token: 0x040000C5 RID: 197
			public int int_5;

			// Token: 0x040000C6 RID: 198
			public int int_6;

			// Token: 0x040000C7 RID: 199
			public long long_0;

			// Token: 0x040000C8 RID: 200
			public int int_7;
		}

		// Token: 0x02000050 RID: 80
		private struct GStruct3
		{
			// Token: 0x040000C9 RID: 201
			public int int_0;

			// Token: 0x040000CA RID: 202
			public int int_1;

			// Token: 0x040000CB RID: 203
			public int int_2;
		}

		// Token: 0x02000051 RID: 81
		private struct GStruct4
		{
			// Token: 0x0600010F RID: 271 RVA: 0x000022A5 File Offset: 0x000004A5
			public GStruct4(string String_1)
			{
				this.String_0 = String_1;
				this.intptr_0 = IntPtr.Zero;
				this.int_0 = 0;
			}

			// Token: 0x040000CC RID: 204
			[MarshalAs(UnmanagedType.LPWStr)]
			public string String_0;

			// Token: 0x040000CD RID: 205
			public IntPtr intptr_0;

			// Token: 0x040000CE RID: 206
			public int int_0;
		}
	}
}
