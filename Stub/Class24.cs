using System;
using System.Text.RegularExpressions;

namespace Stub
{
	// Token: 0x0200001C RID: 28
	public sealed class Class24
	{
		// Token: 0x0600004C RID: 76 RVA: 0x00002155 File Offset: 0x00000355
		public Class24(string String_1)
		{
			this.String_0 = String_1;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00003A1C File Offset: 0x00001C1C
		public string method_0(string String_1)
		{
			string empty = string.Empty;
			Match match = new Regex("\"" + String_1 + "\":\"([^\"]+)\"").Match(this.String_0);
			if (!match.Success)
			{
				return empty;
			}
			return Regex.Split(match.Value, "\"")[3];
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00003A6C File Offset: 0x00001C6C
		public void method_1(string[] String_1)
		{
			foreach (string oldValue in String_1)
			{
				this.String_0 = this.String_0.Replace(oldValue, "");
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002164 File Offset: 0x00000364
		public string[] method_2(string String_1 = "},")
		{
			return Regex.Split(this.String_0, String_1);
		}

		// Token: 0x04000013 RID: 19
		public string String_0;
	}
}
