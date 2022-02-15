using System;
using Il2CppDummyDll;

namespace Assets.InnerNet
{
	// Token: 0x02000681 RID: 1665
	[Token(Token = "0x2000681")]
	public class ResponsePurchase
	{
		// Token: 0x06002851 RID: 10321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002851")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public ResponsePurchase()
		{
		}

		// Token: 0x0400284C RID: 10316
		[Token(Token = "0x400284C")]
		[FieldOffset(Offset = "0x8")]
		[Attribute(Name = "JsonPropertyAttribute", RVA = "0xDF100", Offset = "0xDE500")]
		public string ItemId;

		// Token: 0x0400284D RID: 10317
		[Token(Token = "0x400284D")]
		[FieldOffset(Offset = "0xC")]
		[Attribute(Name = "JsonPropertyAttribute", RVA = "0xDF180", Offset = "0xDE580")]
		public string CurrencyType;

		// Token: 0x0400284E RID: 10318
		[Token(Token = "0x400284E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "JsonPropertyAttribute", RVA = "0xDF1B0", Offset = "0xDE5B0")]
		public string Platform;

		// Token: 0x0400284F RID: 10319
		[Token(Token = "0x400284F")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "JsonPropertyAttribute", RVA = "0xDF230", Offset = "0xDE630")]
		public int ItemCost;
	}
}
