using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002FC RID: 764
[Token(Token = "0x20002FC")]
public class BundleData : ScriptableObject, IBuyable
{
	// Token: 0x1700027F RID: 639
	// (get) Token: 0x060010C7 RID: 4295 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700027F")]
	public string ProdId
	{
		[Token(Token = "0x60010C7")]
		[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000280 RID: 640
	// (get) Token: 0x060010C8 RID: 4296 RVA: 0x00005E80 File Offset: 0x00004080
	[Token(Token = "0x17000280")]
	public int BeanCost
	{
		[Token(Token = "0x60010C8")]
		[Address(RVA = "0x273EC0", Offset = "0x2732C0", VA = "0x10273EC0", Slot = "5")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000281 RID: 641
	// (get) Token: 0x060010C9 RID: 4297 RVA: 0x00005E98 File Offset: 0x00004098
	[Token(Token = "0x17000281")]
	public int StarCost
	{
		[Token(Token = "0x60010C9")]
		[Address(RVA = "0x273EA0", Offset = "0x2732A0", VA = "0x10273EA0", Slot = "6")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000282 RID: 642
	// (get) Token: 0x060010CA RID: 4298 RVA: 0x00005EB0 File Offset: 0x000040B0
	[Token(Token = "0x17000282")]
	public bool PaidOnMobile
	{
		[Token(Token = "0x60010CA")]
		[Address(RVA = "0x328180", Offset = "0x327580", VA = "0x10328180", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000283 RID: 643
	// (get) Token: 0x060010CB RID: 4299 RVA: 0x00005EC8 File Offset: 0x000040C8
	[Token(Token = "0x17000283")]
	public LimitedTimeStartEnd LimitedTimeAvailable
	{
		[Token(Token = "0x60010CB")]
		[Address(RVA = "0x3E2CE0", Offset = "0x3E20E0", VA = "0x103E2CE0", Slot = "8")]
		get
		{
			return default(LimitedTimeStartEnd);
		}
	}

	// Token: 0x060010CC RID: 4300 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010CC")]
	[Address(RVA = "0x829EB0", Offset = "0x8292B0", VA = "0x10829EB0")]
	public string GetItemName()
	{
		return null;
	}

	// Token: 0x060010CD RID: 4301 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010CD")]
	[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90")]
	public string GetPurchasingProductId()
	{
		return null;
	}

	// Token: 0x060010CE RID: 4302 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010CE")]
	[Address(RVA = "0x4A2960", Offset = "0x4A1D60", VA = "0x104A2960")]
	public BundleData()
	{
	}

	// Token: 0x04001076 RID: 4214
	[Token(Token = "0x4001076")]
	public const string TranslationPrefix = "Bundle.";

	// Token: 0x04001077 RID: 4215
	[Token(Token = "0x4001077")]
	[FieldOffset(Offset = "0xC")]
	public string productId;

	// Token: 0x04001078 RID: 4216
	[Token(Token = "0x4001078")]
	[FieldOffset(Offset = "0x10")]
	public int beanCost;

	// Token: 0x04001079 RID: 4217
	[Token(Token = "0x4001079")]
	[FieldOffset(Offset = "0x14")]
	public int starCost;

	// Token: 0x0400107A RID: 4218
	[Token(Token = "0x400107A")]
	[FieldOffset(Offset = "0x18")]
	public CosmeticData[] cosmetics;

	// Token: 0x0400107B RID: 4219
	[Token(Token = "0x400107B")]
	[FieldOffset(Offset = "0x1C")]
	public Sprite StoreImage;

	// Token: 0x0400107C RID: 4220
	[Token(Token = "0x400107C")]
	[FieldOffset(Offset = "0x20")]
	public bool NotInStore;

	// Token: 0x0400107D RID: 4221
	[Token(Token = "0x400107D")]
	[FieldOffset(Offset = "0x21")]
	public bool Free;

	// Token: 0x0400107E RID: 4222
	[Token(Token = "0x400107E")]
	[FieldOffset(Offset = "0x22")]
	public bool paidOnMobile;
}
