using System;
using Il2CppDummyDll;

namespace Assets.InnerNet
{
	// Token: 0x02000682 RID: 1666
	[Token(Token = "0x2000682")]
	public class ResponseError
	{
		// Token: 0x06002852 RID: 10322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002852")]
		[Address(RVA = "0x4F69E0", Offset = "0x4F5DE0", VA = "0x104F69E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002853 RID: 10323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002853")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public ResponseError()
		{
		}

		// Token: 0x04002850 RID: 10320
		[Token(Token = "0x4002850")]
		[FieldOffset(Offset = "0x8")]
		public int Code;

		// Token: 0x04002851 RID: 10321
		[Token(Token = "0x4002851")]
		[FieldOffset(Offset = "0xC")]
		public string Title;

		// Token: 0x04002852 RID: 10322
		[Token(Token = "0x4002852")]
		[FieldOffset(Offset = "0x10")]
		public string Keyword;

		// Token: 0x04002853 RID: 10323
		[Token(Token = "0x4002853")]
		[FieldOffset(Offset = "0x14")]
		public int Detail;
	}
}
