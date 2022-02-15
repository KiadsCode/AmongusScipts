using System;
using Il2CppDummyDll;

namespace Assets.InnerNet
{
	// Token: 0x0200068B RID: 1675
	[Token(Token = "0x200068B")]
	public class SteamTxnInit
	{
		// Token: 0x0600285F RID: 10335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600285F")]
		[Address(RVA = "0x75BF20", Offset = "0x75B320", VA = "0x1075BF20")]
		public static Request<SteamTxnInit> Create(SteamTxnInit payloadData)
		{
			return null;
		}

		// Token: 0x06002860 RID: 10336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002860")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public SteamTxnInit()
		{
		}

		// Token: 0x04002866 RID: 10342
		[Token(Token = "0x4002866")]
		[FieldOffset(Offset = "0x8")]
		[Attribute(Name = "JsonPropertyAttribute", RVA = "0xDF400", Offset = "0xDE800")]
		public string steamId;

		// Token: 0x04002867 RID: 10343
		[Token(Token = "0x4002867")]
		[FieldOffset(Offset = "0xC")]
		[Attribute(Name = "JsonPropertyAttribute", RVA = "0xDF430", Offset = "0xDE830")]
		public string currencyCode;

		// Token: 0x04002868 RID: 10344
		[Token(Token = "0x4002868")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "JsonPropertyAttribute", RVA = "0xDF460", Offset = "0xDE860")]
		public uint languageCode;

		// Token: 0x04002869 RID: 10345
		[Token(Token = "0x4002869")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "JsonPropertyAttribute", RVA = "0xDF100", Offset = "0xDE500")]
		public int itemId;
	}
}
