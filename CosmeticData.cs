using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000115 RID: 277
[Token(Token = "0x2000115")]
public class CosmeticData : ScriptableObject, IBuyable
{
	// Token: 0x170000F5 RID: 245
	// (get) Token: 0x06000680 RID: 1664 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000F5")]
	public string ProdId
	{
		[Token(Token = "0x6000680")]
		[Address(RVA = "0x273EA0", Offset = "0x2732A0", VA = "0x10273EA0", Slot = "4")]
		get
		{
			return null;
		}
	}

	// Token: 0x170000F6 RID: 246
	// (get) Token: 0x06000681 RID: 1665 RVA: 0x00003BA0 File Offset: 0x00001DA0
	[Token(Token = "0x170000F6")]
	public int BeanCost
	{
		[Token(Token = "0x6000681")]
		[Address(RVA = "0x287A00", Offset = "0x286E00", VA = "0x10287A00", Slot = "5")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170000F7 RID: 247
	// (get) Token: 0x06000682 RID: 1666 RVA: 0x00003BB8 File Offset: 0x00001DB8
	[Token(Token = "0x170000F7")]
	public int StarCost
	{
		[Token(Token = "0x6000682")]
		[Address(RVA = "0x292AA0", Offset = "0x291EA0", VA = "0x10292AA0", Slot = "6")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170000F8 RID: 248
	// (get) Token: 0x06000683 RID: 1667 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000F8")]
	public string EpicId
	{
		[Token(Token = "0x6000683")]
		[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90")]
		get
		{
			return null;
		}
	}

	// Token: 0x170000F9 RID: 249
	// (get) Token: 0x06000684 RID: 1668 RVA: 0x00003BD0 File Offset: 0x00001DD0
	[Token(Token = "0x170000F9")]
	public bool PaidOnMobile
	{
		[Token(Token = "0x6000684")]
		[Address(RVA = "0x2E91E0", Offset = "0x2E85E0", VA = "0x102E91E0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170000FA RID: 250
	// (get) Token: 0x06000685 RID: 1669 RVA: 0x00003BE8 File Offset: 0x00001DE8
	[Token(Token = "0x170000FA")]
	public LimitedTimeStartEnd LimitedTimeAvailable
	{
		[Token(Token = "0x6000685")]
		[Address(RVA = "0x3E2CE0", Offset = "0x3E20E0", VA = "0x103E2CE0", Slot = "8")]
		get
		{
			return default(LimitedTimeStartEnd);
		}
	}

	// Token: 0x06000686 RID: 1670 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000686")]
	[Address(RVA = "0x7FDD90", Offset = "0x7FD190", VA = "0x107FDD90", Slot = "9")]
	public virtual void PreviewOnPlayer(PoolablePlayer p)
	{
	}

	// Token: 0x06000687 RID: 1671 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000687")]
	[Address(RVA = "0x7FDD00", Offset = "0x7FD100", VA = "0x107FDD00")]
	public string GetItemName()
	{
		return null;
	}

	// Token: 0x06000688 RID: 1672 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000688")]
	[Address(RVA = "0x7FDCD0", Offset = "0x7FD0D0", VA = "0x107FDCD0", Slot = "10")]
	public virtual string GetItemCategory()
	{
		return null;
	}

	// Token: 0x06000689 RID: 1673 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000689")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "11")]
	public virtual void SetProdId()
	{
	}

	// Token: 0x0600068A RID: 1674 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600068A")]
	[Address(RVA = "0x7FDDB0", Offset = "0x7FD1B0", VA = "0x107FDDB0")]
	public CosmeticData()
	{
	}

	// Token: 0x04000671 RID: 1649
	[Token(Token = "0x4000671")]
	public const string TranslationPrefix = "Cosmetic.";

	// Token: 0x04000672 RID: 1650
	[Token(Token = "0x4000672")]
	[FieldOffset(Offset = "0xC")]
	public string epicId;

	// Token: 0x04000673 RID: 1651
	[Token(Token = "0x4000673")]
	[FieldOffset(Offset = "0x10")]
	public string BundleId;

	// Token: 0x04000674 RID: 1652
	[Token(Token = "0x4000674")]
	[FieldOffset(Offset = "0x14")]
	public string ProductId;

	// Token: 0x04000675 RID: 1653
	[Token(Token = "0x4000675")]
	[FieldOffset(Offset = "0x18")]
	public Vector2 ChipOffset;

	// Token: 0x04000676 RID: 1654
	[Token(Token = "0x4000676")]
	[FieldOffset(Offset = "0x20")]
	public int beanCost;

	// Token: 0x04000677 RID: 1655
	[Token(Token = "0x4000677")]
	[FieldOffset(Offset = "0x24")]
	public int starCost;

	// Token: 0x04000678 RID: 1656
	[Token(Token = "0x4000678")]
	[FieldOffset(Offset = "0x28")]
	public bool paidOnMobile;
}
