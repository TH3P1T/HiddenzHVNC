using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace Stub
{
	// Token: 0x02000010 RID: 16
	public class Class19
	{
		// Token: 0x06000027 RID: 39 RVA: 0x00003110 File Offset: 0x00001310
		public byte[] method_0(byte[] byte_0, byte[] byte_1, byte[] byte_2, byte[] byte_3, byte[] byte_4)
		{
			IntPtr intptr_ = this.method_2(GClass3.String_5, GClass3.String_6, GClass3.String_1);
			IntPtr intptr_2;
			IntPtr hglobal = this.method_3(intptr_, byte_0, out intptr_2);
			GClass3.GStruct2 gstruct = new GClass3.GStruct2(byte_1, byte_2, byte_4);
			byte[] array2;
			using (gstruct)
			{
				byte[] array = new byte[this.method_1(intptr_)];
				int num = 0;
				uint num2 = GClass3.BCryptDecrypt(intptr_2, byte_3, byte_3.Length, ref gstruct, array, array.Length, null, 0, ref num, 0);
				if (num2 != 0U)
				{
					throw new CryptographicException(string.Format("BCrypt.BCryptDecrypt() (get size) failed with status code: {0}", num2));
				}
				array2 = new byte[num];
				num2 = GClass3.BCryptDecrypt(intptr_2, byte_3, byte_3.Length, ref gstruct, array, array.Length, array2, array2.Length, ref num, 0);
				if (num2 == GClass3.uint_3)
				{
					throw new CryptographicException("BCrypt.BCryptDecrypt(): authentication tag mismatch");
				}
				if (num2 != 0U)
				{
					throw new CryptographicException(string.Format("BCrypt.BCryptDecrypt() failed with status code:{0}", num2));
				}
			}
			GClass3.BCryptDestroyKey(intptr_2);
			Marshal.FreeHGlobal(hglobal);
			GClass3.BCryptCloseAlgorithmProvider(intptr_, 0U);
			return array2;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00003224 File Offset: 0x00001424
		public int method_1(IntPtr intptr_0)
		{
			byte[] array = this.method_4(intptr_0, GClass3.String_2);
			return BitConverter.ToInt32(new byte[]
			{
				array[4],
				array[5],
				array[6],
				array[7]
			}, 0);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00003264 File Offset: 0x00001464
		public IntPtr method_2(string String_0, string String_1, string String_2)
		{
			IntPtr zero = IntPtr.Zero;
			uint num = GClass3.BCryptOpenAlgorithmProvider(out zero, String_0, String_1, 0U);
			if (num != 0U)
			{
				throw new CryptographicException(string.Format("BCrypt.BCryptOpenAlgorithmProvider() failed with status code:{0}", num));
			}
			byte[] bytes = Encoding.Unicode.GetBytes(String_2);
			num = GClass3.BCryptSetProperty(zero, GClass3.String_3, bytes, bytes.Length, 0);
			if (num != 0U)
			{
				throw new CryptographicException(string.Format("BCrypt.BCryptSetAlgorithmProperty(BCrypt.BCRYPT_CHAINING_MODE, BCrypt.BCRYPT_CHAIN_MODE_GCM) failed with status code:{0}", num));
			}
			return zero;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000032D4 File Offset: 0x000014D4
		public IntPtr method_3(IntPtr intptr_0, byte[] byte_0, out IntPtr intptr_1)
		{
			int num = BitConverter.ToInt32(this.method_4(intptr_0, GClass3.String_0), 0);
			IntPtr intPtr = Marshal.AllocHGlobal(num);
			byte[] array = this.method_5(new byte[][]
			{
				GClass3.byte_0,
				BitConverter.GetBytes(1),
				BitConverter.GetBytes(byte_0.Length),
				byte_0
			});
			uint num2 = GClass3.BCryptImportKey(intptr_0, IntPtr.Zero, GClass3.String_4, out intptr_1, intPtr, num, array, array.Length, 0U);
			if (num2 != 0U)
			{
				throw new CryptographicException(string.Format("BCrypt.BCryptImportKey() failed with status code:{0}", num2));
			}
			return intPtr;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x0000335C File Offset: 0x0000155C
		public byte[] method_4(IntPtr intptr_0, string String_0)
		{
			int num = 0;
			uint num2 = GClass3.BCryptGetProperty(intptr_0, String_0, null, 0, ref num, 0U);
			if (num2 != 0U)
			{
				throw new CryptographicException(string.Format("BCrypt.BCryptGetProperty() (get size) failed with status code:{0}", num2));
			}
			byte[] array = new byte[num];
			num2 = GClass3.BCryptGetProperty(intptr_0, String_0, array, array.Length, ref num, 0U);
			if (num2 != 0U)
			{
				throw new CryptographicException(string.Format("BCrypt.BCryptGetProperty() failed with status code:{0}", num2));
			}
			return array;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000033C4 File Offset: 0x000015C4
		public byte[] method_5(params byte[][] byte_0)
		{
			int num = 0;
			foreach (byte[] array in byte_0)
			{
				if (array != null)
				{
					num += array.Length;
				}
			}
			byte[] array2 = new byte[num - 1 + 1];
			int num2 = 0;
			foreach (byte[] array3 in byte_0)
			{
				if (array3 != null)
				{
					Buffer.BlockCopy(array3, 0, array2, num2, array3.Length);
					num2 += array3.Length;
				}
			}
			return array2;
		}
	}
}
