using System;

namespace Stub
{
	// Token: 0x02000026 RID: 38
	public class Class30
	{
		// Token: 0x04000026 RID: 38
		public static readonly string String_0 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

		// Token: 0x04000027 RID: 39
		public static string[] String_1 = new string[]
		{
			Class30.String_0
		};

		// Token: 0x04000028 RID: 40
		public static string String_2 = Class30.String_1[new Random().Next(0, Class30.String_1.Length)];

		// Token: 0x04000029 RID: 41
		public static string String_3 = string.Concat(new string[]
		{
			Class30.String_2,
			"\\",
			Class29.smethod_0(),
			Class11.String_1,
			".",
			Class11.String_0
		});
	}
}
