using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Assets.InnerNet
{
	// Token: 0x02000687 RID: 1671
	[Token(Token = "0x2000687")]
	public class ValidateReceiptBatch
	{
		// Token: 0x0600285D RID: 10333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600285D")]
		[Address(RVA = "0x7A8750", Offset = "0x7A7B50", VA = "0x107A8750")]
		public static Request<ValidateReceiptBatch> Create(string entitlementType, List<string> receiptStrings)
		{
			return null;
		}

		// Token: 0x0600285E RID: 10334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600285E")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public ValidateReceiptBatch()
		{
		}

		// Token: 0x0400285F RID: 10335
		[Token(Token = "0x400285F")]
		[FieldOffset(Offset = "0x8")]
		[Attribute(Name = "JsonPropertyAttribute", RVA = "0xDF340", Offset = "0xDE740")]
		public List<Request<ValidateReceipt>.RequestData> receipts;
	}
}
