using System;
using Il2CppDummyDll;

namespace Assets.InnerNet
{
	// Token: 0x02000677 RID: 1655
	[Token(Token = "0x2000677")]
	public class PinRequestError
	{
		// Token: 0x06002848 RID: 10312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002848")]
		[Address(RVA = "0x65D0B0", Offset = "0x65C4B0", VA = "0x1065D0B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002849 RID: 10313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002849")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public PinRequestError()
		{
		}

		// Token: 0x04002832 RID: 10290
		[Token(Token = "0x4002832")]
		[FieldOffset(Offset = "0x8")]
		public int Code;

		// Token: 0x04002833 RID: 10291
		[Token(Token = "0x4002833")]
		[FieldOffset(Offset = "0xC")]
		public string Title;

		// Token: 0x04002834 RID: 10292
		[Token(Token = "0x4002834")]
		[FieldOffset(Offset = "0x10")]
		public string Detail;
	}
}
