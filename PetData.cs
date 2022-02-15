using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000128 RID: 296
[Token(Token = "0x2000128")]
public class PetData : CosmeticData
{
	// Token: 0x1700010F RID: 271
	// (get) Token: 0x060006F8 RID: 1784 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700010F")]
	public Sprite Sprite
	{
		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x65A4A0", Offset = "0x6598A0", VA = "0x1065A4A0")]
		get
		{
			return null;
		}
	}

	// Token: 0x060006F9 RID: 1785 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006F9")]
	[Address(RVA = "0x65A2B0", Offset = "0x6596B0", VA = "0x1065A2B0", Slot = "10")]
	public override string GetItemCategory()
	{
		return null;
	}

	// Token: 0x060006FA RID: 1786 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006FA")]
	[Address(RVA = "0x65A310", Offset = "0x659710", VA = "0x1065A310", Slot = "9")]
	public override void PreviewOnPlayer(PoolablePlayer p)
	{
	}

	// Token: 0x060006FB RID: 1787 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006FB")]
	[Address(RVA = "0x3B9FA0", Offset = "0x3B93A0", VA = "0x103B9FA0")]
	public PetData()
	{
	}

	// Token: 0x040006E9 RID: 1769
	[Token(Token = "0x40006E9")]
	[FieldOffset(Offset = "0x2C")]
	public bool Free;

	// Token: 0x040006EA RID: 1770
	[Token(Token = "0x40006EA")]
	[FieldOffset(Offset = "0x2D")]
	public bool NotInStore;

	// Token: 0x040006EB RID: 1771
	[Token(Token = "0x40006EB")]
	[FieldOffset(Offset = "0x30")]
	public StringNames StoreName;

	// Token: 0x040006EC RID: 1772
	[Token(Token = "0x40006EC")]
	[FieldOffset(Offset = "0x34")]
	public PetBehaviour PetPrefab;
}
