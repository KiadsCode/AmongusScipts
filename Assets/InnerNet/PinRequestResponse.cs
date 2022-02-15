using System;
using Il2CppDummyDll;

namespace Assets.InnerNet
{
	// Token: 0x02000676 RID: 1654
	[Token(Token = "0x2000676")]
	public class PinRequestResponse
	{
		// Token: 0x06002847 RID: 10311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002847")]
		[Address(RVA = "0x65D110", Offset = "0x65C510", VA = "0x1065D110")]
		public PinRequestResponse()
		{
		}

		// Token: 0x0400282F RID: 10287
		[Token(Token = "0x400282F")]
		[FieldOffset(Offset = "0x8")]
		public string Pin;

		// Token: 0x04002830 RID: 10288
		[Token(Token = "0x4002830")]
		[FieldOffset(Offset = "0xC")]
		public string Url;

		// Token: 0x04002831 RID: 10289
		[Token(Token = "0x4002831")]
		[FieldOffset(Offset = "0x10")]
		public PinRequestError[] Errors;
	}
}
