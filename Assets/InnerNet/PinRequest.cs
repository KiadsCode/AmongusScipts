using System;
using Il2CppDummyDll;

namespace Assets.InnerNet
{
	// Token: 0x02000678 RID: 1656
	[Token(Token = "0x2000678")]
	public class PinRequest
	{
		// Token: 0x0600284A RID: 10314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600284A")]
		[Address(RVA = "0x65D160", Offset = "0x65C560", VA = "0x1065D160")]
		public static PinRequest RequestPin(string continuanceToken)
		{
			return null;
		}

		// Token: 0x0600284B RID: 10315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600284B")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public PinRequest()
		{
		}

		// Token: 0x04002835 RID: 10293
		[Token(Token = "0x4002835")]
		[FieldOffset(Offset = "0x8")]
		[Attribute(Name = "JsonPropertyAttribute", RVA = "0xDEFC0", Offset = "0xDE3C0")]
		public string ContinuanceToken;

		// Token: 0x04002836 RID: 10294
		[Token(Token = "0x4002836")]
		[FieldOffset(Offset = "0xC")]
		[Attribute(Name = "JsonPropertyAttribute", RVA = "0xDEFF0", Offset = "0xDE3F0")]
		public string Language;
	}
}
