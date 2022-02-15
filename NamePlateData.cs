using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003F8 RID: 1016
[Token(Token = "0x20003F8")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x952B0", Offset = "0x946B0")]
public class NamePlateData : CosmeticData
{
	// Token: 0x060014F7 RID: 5367 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014F7")]
	[Address(RVA = "0x775A10", Offset = "0x774E10", VA = "0x10775A10", Slot = "10")]
	public override string GetItemCategory()
	{
		return null;
	}

	// Token: 0x060014F8 RID: 5368 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014F8")]
	[Address(RVA = "0x3B9FA0", Offset = "0x3B93A0", VA = "0x103B9FA0")]
	public NamePlateData()
	{
	}

	// Token: 0x0400159A RID: 5530
	[Token(Token = "0x400159A")]
	[FieldOffset(Offset = "0x2C")]
	public Sprite Image;

	// Token: 0x0400159B RID: 5531
	[Token(Token = "0x400159B")]
	[FieldOffset(Offset = "0x30")]
	public bool Free;

	// Token: 0x0400159C RID: 5532
	[Token(Token = "0x400159C")]
	[FieldOffset(Offset = "0x34")]
	public int Order;

	// Token: 0x0400159D RID: 5533
	[Token(Token = "0x400159D")]
	[FieldOffset(Offset = "0x38")]
	public bool NotInStore;
}
