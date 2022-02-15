using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200041A RID: 1050
[Token(Token = "0x200041A")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x952B0", Offset = "0x946B0")]
public class VisorData : CosmeticData
{
	// Token: 0x0600161C RID: 5660 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600161C")]
	[Address(RVA = "0x7B2600", Offset = "0x7B1A00", VA = "0x107B2600", Slot = "10")]
	public override string GetItemCategory()
	{
		return null;
	}

	// Token: 0x0600161D RID: 5661 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600161D")]
	[Address(RVA = "0x7B2660", Offset = "0x7B1A60", VA = "0x107B2660", Slot = "9")]
	public override void PreviewOnPlayer(PoolablePlayer p)
	{
	}

	// Token: 0x0600161E RID: 5662 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600161E")]
	[Address(RVA = "0x3B9FA0", Offset = "0x3B93A0", VA = "0x103B9FA0")]
	public VisorData()
	{
	}

	// Token: 0x04001673 RID: 5747
	[Token(Token = "0x4001673")]
	[FieldOffset(Offset = "0x2C")]
	public Sprite IdleFrame;

	// Token: 0x04001674 RID: 5748
	[Token(Token = "0x4001674")]
	[FieldOffset(Offset = "0x30")]
	public Sprite LeftIdleFrame;

	// Token: 0x04001675 RID: 5749
	[Token(Token = "0x4001675")]
	[FieldOffset(Offset = "0x34")]
	public Sprite ClimbFrame;

	// Token: 0x04001676 RID: 5750
	[Token(Token = "0x4001676")]
	[FieldOffset(Offset = "0x38")]
	public Sprite FloorFrame;

	// Token: 0x04001677 RID: 5751
	[Token(Token = "0x4001677")]
	[FieldOffset(Offset = "0x3C")]
	public int Order;

	// Token: 0x04001678 RID: 5752
	[Token(Token = "0x4001678")]
	[FieldOffset(Offset = "0x40")]
	public bool Free;

	// Token: 0x04001679 RID: 5753
	[Token(Token = "0x4001679")]
	[FieldOffset(Offset = "0x41")]
	public bool NotInStore;
}
