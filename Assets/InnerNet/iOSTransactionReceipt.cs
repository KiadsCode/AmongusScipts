using System;
using Il2CppDummyDll;

namespace Assets.InnerNet
{
	// Token: 0x0200068E RID: 1678
	[Token(Token = "0x200068E")]
	public class iOSTransactionReceipt
	{
		// Token: 0x06002864 RID: 10340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002864")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public iOSTransactionReceipt()
		{
		}

		// Token: 0x0400286D RID: 10349
		[Token(Token = "0x400286D")]
		[FieldOffset(Offset = "0x8")]
		[Attribute(Name = "JsonPropertyAttribute", RVA = "0xDF4C0", Offset = "0xDE8C0")]
		public string Store;

		// Token: 0x0400286E RID: 10350
		[Token(Token = "0x400286E")]
		[FieldOffset(Offset = "0xC")]
		[Attribute(Name = "JsonPropertyAttribute", RVA = "0xDF4F0", Offset = "0xDE8F0")]
		public string TransactionID;

		// Token: 0x0400286F RID: 10351
		[Token(Token = "0x400286F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "JsonPropertyAttribute", RVA = "0xDF520", Offset = "0xDE920")]
		public string Payload;
	}
}
