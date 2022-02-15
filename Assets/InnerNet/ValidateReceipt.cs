using System;
using Il2CppDummyDll;

namespace Assets.InnerNet
{
	// Token: 0x02000686 RID: 1670
	[Token(Token = "0x2000686")]
	public class ValidateReceipt
	{
		// Token: 0x0600285B RID: 10331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600285B")]
		[Address(RVA = "0x7A8A40", Offset = "0x7A7E40", VA = "0x107A8A40")]
		public static Request<ValidateReceipt> Create(string entitlementType, string receipt)
		{
			return null;
		}

		// Token: 0x0600285C RID: 10332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600285C")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public ValidateReceipt()
		{
		}

		// Token: 0x0400285A RID: 10330
		[Token(Token = "0x400285A")]
		public const string IapEntitlementType = "in-app-purchase";

		// Token: 0x0400285B RID: 10331
		[Token(Token = "0x400285B")]
		public const string DlcEntitlementType = "dlc";

		// Token: 0x0400285C RID: 10332
		[Token(Token = "0x400285C")]
		public const string InnerslothEntitlementType = "innersloth-receipt";

		// Token: 0x0400285D RID: 10333
		[Token(Token = "0x400285D")]
		[FieldOffset(Offset = "0x8")]
		[Attribute(Name = "JsonPropertyAttribute", RVA = "0xDF2E0", Offset = "0xDE6E0")]
		public string EntitlementType;

		// Token: 0x0400285E RID: 10334
		[Token(Token = "0x400285E")]
		[FieldOffset(Offset = "0xC")]
		[Attribute(Name = "JsonPropertyAttribute", RVA = "0xDF310", Offset = "0xDE710")]
		public string Receipt;
	}
}
