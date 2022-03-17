using System;
using System.Runtime.InteropServices;

namespace Stub
{
	// Token: 0x02000017 RID: 23
	public sealed class Class23
	{
		// Token: 0x02000018 RID: 24
		public struct Struct9
		{
			// Token: 0x04000010 RID: 16
			public int int_0;

			// Token: 0x04000011 RID: 17
			public IntPtr intptr_0;

			// Token: 0x04000012 RID: 18
			public int int_1;
		}

		// Token: 0x02000019 RID: 25
		// (Invoke) Token: 0x06000041 RID: 65
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate long Delegate10(string sDirectory);

		// Token: 0x0200001A RID: 26
		// (Invoke) Token: 0x06000045 RID: 69
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate long Delegate11();

		// Token: 0x0200001B RID: 27
		// (Invoke) Token: 0x06000049 RID: 73
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate int Delegate12(ref Class23.Struct9 tsData, ref Class23.Struct9 tsResult, int iContent);
	}
}
