using System;
using System.Runtime.InteropServices;

namespace Stub
{
	// Token: 0x02000016 RID: 22
	public sealed class Class22
	{
		// Token: 0x0600003B RID: 59
		[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern IntPtr LoadLibrary(string String_0);

		// Token: 0x0600003C RID: 60
		[DllImport("kernel32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool FreeLibrary(IntPtr intptr_0);

		// Token: 0x0600003D RID: 61
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
		public static extern IntPtr GetProcAddress(IntPtr intptr_0, string String_0);
	}
}
