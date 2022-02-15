using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200011F RID: 287
[Token(Token = "0x200011F")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x952B0", Offset = "0x946B0")]
public class CosmicubeData : ScriptableObject, IBuyable
{
	// Token: 0x17000107 RID: 263
	// (get) Token: 0x060006C4 RID: 1732 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000107")]
	public string ProdId
	{
		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x328160", Offset = "0x327560", VA = "0x10328160", Slot = "4")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000108 RID: 264
	// (get) Token: 0x060006C5 RID: 1733 RVA: 0x00003CC0 File Offset: 0x00001EC0
	[Token(Token = "0x17000108")]
	public int BeanCost
	{
		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x277A30", Offset = "0x276E30", VA = "0x10277A30", Slot = "5")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000109 RID: 265
	// (get) Token: 0x060006C6 RID: 1734 RVA: 0x00003CD8 File Offset: 0x00001ED8
	[Token(Token = "0x17000109")]
	public int StarCost
	{
		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x273EA0", Offset = "0x2732A0", VA = "0x10273EA0", Slot = "6")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700010A RID: 266
	// (get) Token: 0x060006C7 RID: 1735 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700010A")]
	public string EpicId
	{
		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x328190", Offset = "0x327590", VA = "0x10328190")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700010B RID: 267
	// (get) Token: 0x060006C8 RID: 1736 RVA: 0x00003CF0 File Offset: 0x00001EF0
	[Token(Token = "0x1700010B")]
	public bool PaidOnMobile
	{
		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x2D7E70", Offset = "0x2D7270", VA = "0x102D7E70", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700010C RID: 268
	// (get) Token: 0x060006C9 RID: 1737 RVA: 0x00003D08 File Offset: 0x00001F08
	[Token(Token = "0x1700010C")]
	public LimitedTimeStartEnd LimitedTimeAvailable
	{
		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x7FFE50", Offset = "0x7FF250", VA = "0x107FFE50", Slot = "8")]
		get
		{
			return default(LimitedTimeStartEnd);
		}
	}

	// Token: 0x060006CA RID: 1738 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006CA")]
	[Address(RVA = "0x7FFD90", Offset = "0x7FF190", VA = "0x107FFD90")]
	public string GetCosmicubeName()
	{
		return null;
	}

	// Token: 0x060006CB RID: 1739 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006CB")]
	[Address(RVA = "0x7FFDD0", Offset = "0x7FF1D0", VA = "0x107FFDD0")]
	public string GetPodName()
	{
		return null;
	}

	// Token: 0x060006CC RID: 1740 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006CC")]
	[Address(RVA = "0x7FFE10", Offset = "0x7FF210", VA = "0x107FFE10")]
	public CosmicubeData()
	{
	}

	// Token: 0x040006AA RID: 1706
	[Token(Token = "0x40006AA")]
	[FieldOffset(Offset = "0xC")]
	public Sprite StoreImage;

	// Token: 0x040006AB RID: 1707
	[Token(Token = "0x40006AB")]
	[FieldOffset(Offset = "0x10")]
	public List<UnlockableCosmetic> allUnlockables;

	// Token: 0x040006AC RID: 1708
	[Token(Token = "0x40006AC")]
	[FieldOffset(Offset = "0x14")]
	public int starCost;

	// Token: 0x040006AD RID: 1709
	[Token(Token = "0x40006AD")]
	[FieldOffset(Offset = "0x18")]
	public int beanCost;

	// Token: 0x040006AE RID: 1710
	[Token(Token = "0x40006AE")]
	[FieldOffset(Offset = "0x1C")]
	public int Order;

	// Token: 0x040006AF RID: 1711
	[Token(Token = "0x40006AF")]
	[FieldOffset(Offset = "0x20")]
	public bool Free;

	// Token: 0x040006B0 RID: 1712
	[Token(Token = "0x40006B0")]
	[FieldOffset(Offset = "0x21")]
	public bool NotInStore;

	// Token: 0x040006B1 RID: 1713
	[Token(Token = "0x40006B1")]
	[FieldOffset(Offset = "0x24")]
	public FloatRange XRange;

	// Token: 0x040006B2 RID: 1714
	[Token(Token = "0x40006B2")]
	[FieldOffset(Offset = "0x28")]
	public FloatRange YRange;

	// Token: 0x040006B3 RID: 1715
	[Token(Token = "0x40006B3")]
	[FieldOffset(Offset = "0x2C")]
	public Sprite podIcon;

	// Token: 0x040006B4 RID: 1716
	[Token(Token = "0x40006B4")]
	[FieldOffset(Offset = "0x30")]
	public string podId;

	// Token: 0x040006B5 RID: 1717
	[Token(Token = "0x40006B5")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private string productId;

	// Token: 0x040006B6 RID: 1718
	[Token(Token = "0x40006B6")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private string cosmicubeName;

	// Token: 0x040006B7 RID: 1719
	[Token(Token = "0x40006B7")]
	[FieldOffset(Offset = "0x3C")]
	public string epicId;

	// Token: 0x040006B8 RID: 1720
	[Token(Token = "0x40006B8")]
	[FieldOffset(Offset = "0x40")]
	public LimitedTimeStartEnd limitedTime;
}
