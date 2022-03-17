using System;
using System.IO;
using Microsoft.VisualBasic.CompilerServices;

namespace Stub
{
	// Token: 0x0200004B RID: 75
	public class GClass1
	{
		// Token: 0x060000FB RID: 251 RVA: 0x0000222D File Offset: 0x0000042D
		public GClass1()
		{
			this.long_0 = 0L;
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00006744 File Offset: 0x00004944
		public long method_0(string String_0)
		{
			int num = 0;
			checked
			{
				long result;
				try
				{
					ProjectData.ClearProjectError();
					DirectoryInfo directoryInfo = new DirectoryInfo(String_0);
					foreach (FileInfo fileInfo in directoryInfo.GetFiles())
					{
						this.long_0 += fileInfo.Length;
					}
					foreach (DirectoryInfo directoryInfo2 in directoryInfo.GetDirectories())
					{
						this.method_0(directoryInfo2.FullName);
					}
					result = this.long_0;
				}
				catch (Exception ex)
				{
					result = 0L;
				}
				if (num != 0)
				{
					ProjectData.ClearProjectError();
				}
				return result;
			}
		}

		// Token: 0x040000AA RID: 170
		public long long_0;
	}
}
