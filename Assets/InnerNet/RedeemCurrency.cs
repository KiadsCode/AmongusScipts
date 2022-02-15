using System;
using Il2CppDummyDll;

namespace Assets.InnerNet
{
	// Token: 0x02000684 RID: 1668
	[Token(Token = "0x2000684")]
	public class RedeemCurrency
	{
		// Token: 0x06002854 RID: 10324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002854")]
		[Address(RVA = "0x4F4200", Offset = "0x4F3600", VA = "0x104F4200")]
		public static Request<RedeemCurrency> ForNonCubePurchase(string productId, CurrencyTypes currencyType)
		{
			return null;
		}

		// Token: 0x06002855 RID: 10325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002855")]
		[Address(RVA = "0x4F4040", Offset = "0x4F3440", VA = "0x104F4040")]
		public static Request<RedeemCurrency> ForCubePurchase(string productId, string cubeName)
		{
			return null;
		}

		// Token: 0x06002856 RID: 10326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002856")]
		[Address(RVA = "0x4F4400", Offset = "0x4F3800", VA = "0x104F4400")]
		public static string ProductIdToItemId(string productId)
		{
			return null;
		}

		// Token: 0x06002857 RID: 10327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002857")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public RedeemCurrency()
		{
		}

		// Token: 0x04002856 RID: 10326
		[Token(Token = "0x4002856")]
		[FieldOffset(Offset = "0x8")]
		[Attribute(Name = "JsonPropertyAttribute", RVA = "0xDF100", Offset = "0xDE500")]
		public string ItemId;

		// Token: 0x04002857 RID: 10327
		[Token(Token = "0x4002857")]
		[FieldOffset(Offset = "0xC")]
		[Attribute(Name = "JsonPropertyAttribute", RVA = "0xDF180", Offset = "0xDE580")]
		public string CurrencyType;

		// Token: 0x04002858 RID: 10328
		[Token(Token = "0x4002858")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "JsonPropertyAttribute", RVA = "0xDF1B0", Offset = "0xDE5B0")]
		public string Platform;
	}
}
