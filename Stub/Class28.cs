using System;
using System.IO;

namespace Stub
{
	// Token: 0x02000023 RID: 35
	public sealed class Class28
	{
		// Token: 0x06000063 RID: 99 RVA: 0x00004B4C File Offset: 0x00002D4C
		public static Class27 smethod_0(string String_0, string String_1)
		{
			if (!File.Exists(String_0))
			{
				return null;
			}
			string text = Path.GetTempFileName() + ".dat";
			File.Copy(String_0, text);
			Class27 @class = new Class27(text);
			@class.method_4(String_1);
			File.Delete(text);
			if (@class.method_1() == 65536)
			{
				return null;
			}
			return @class;
		}
	}
}
