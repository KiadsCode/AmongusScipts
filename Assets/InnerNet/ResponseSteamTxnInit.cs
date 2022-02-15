using System;
using Il2CppDummyDll;

namespace Assets.InnerNet
{
	// Token: 0x0200068D RID: 1677
	[Token(Token = "0x200068D")]
	public class ResponseSteamTxnInit
	{
		// Token: 0x06002863 RID: 10339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002863")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public ResponseSteamTxnInit()
		{
		}

		// Token: 0x0400286B RID: 10347
		[Token(Token = "0x400286B")]
		[FieldOffset(Offset = "0x8")]
		[Attribute(Name = "JsonPropertyAttribute", RVA = "0xDF490", Offset = "0xDE890")]
		public string orderID;

		// Token: 0x0400286C RID: 10348
		[Token(Token = "0x400286C")]
		[FieldOffset(Offset = "0xC")]
		[Attribute(Name = "JsonPropertyAttribute", RVA = "0xDF400", Offset = "0xDE800")]
		public string steamID;
	}
}
