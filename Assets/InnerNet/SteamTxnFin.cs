using System;
using Il2CppDummyDll;

namespace Assets.InnerNet
{
	// Token: 0x0200068C RID: 1676
	[Token(Token = "0x200068C")]
	public class SteamTxnFin
	{
		// Token: 0x06002861 RID: 10337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002861")]
		[Address(RVA = "0x75BE50", Offset = "0x75B250", VA = "0x1075BE50")]
		public static Request<SteamTxnFin> Create(string orderId)
		{
			return null;
		}

		// Token: 0x06002862 RID: 10338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002862")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public SteamTxnFin()
		{
		}

		// Token: 0x0400286A RID: 10346
		[Token(Token = "0x400286A")]
		[FieldOffset(Offset = "0x8")]
		[Attribute(Name = "JsonPropertyAttribute", RVA = "0xDF490", Offset = "0xDE890")]
		public string orderId;
	}
}
