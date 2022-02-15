using System;
using Il2CppDummyDll;

namespace Assets.InnerNet
{
	// Token: 0x02000679 RID: 1657
	[Token(Token = "0x2000679")]
	public class LinkStatusResponse
	{
		// Token: 0x0600284C RID: 10316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600284C")]
		[Address(RVA = "0x6E2460", Offset = "0x6E1860", VA = "0x106E2460")]
		public LinkStatusResponse()
		{
		}

		// Token: 0x04002837 RID: 10295
		[Token(Token = "0x4002837")]
		[FieldOffset(Offset = "0x8")]
		public LinkStatusResponse.LinkStatus Status;

		// Token: 0x04002838 RID: 10296
		[Token(Token = "0x4002838")]
		[FieldOffset(Offset = "0xC")]
		public PinRequestError[] Errors;

		// Token: 0x0200067A RID: 1658
		[Token(Token = "0x200067A")]
		public enum LinkStatus
		{
			// Token: 0x0400283A RID: 10298
			[Token(Token = "0x400283A")]
			Pending,
			// Token: 0x0400283B RID: 10299
			[Token(Token = "0x400283B")]
			Success,
			// Token: 0x0400283C RID: 10300
			[Token(Token = "0x400283C")]
			Error
		}
	}
}
