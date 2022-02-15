using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003E4 RID: 996
[Token(Token = "0x20003E4")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x952B0", Offset = "0x946B0")]
public class HatBehaviour : CosmeticData
{
	// Token: 0x060014AA RID: 5290 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014AA")]
	[Address(RVA = "0x3B9F50", Offset = "0x3B9350", VA = "0x103B9F50", Slot = "9")]
	public override void PreviewOnPlayer(PoolablePlayer p)
	{
	}

	// Token: 0x060014AB RID: 5291 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014AB")]
	[Address(RVA = "0x3B9EF0", Offset = "0x3B92F0", VA = "0x103B9EF0", Slot = "10")]
	public override string GetItemCategory()
	{
		return null;
	}

	// Token: 0x060014AC RID: 5292 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014AC")]
	[Address(RVA = "0x3B9FA0", Offset = "0x3B93A0", VA = "0x103B9FA0")]
	public HatBehaviour()
	{
	}

	// Token: 0x04001545 RID: 5445
	[Token(Token = "0x4001545")]
	[FieldOffset(Offset = "0x2C")]
	public Sprite MainImage;

	// Token: 0x04001546 RID: 5446
	[Token(Token = "0x4001546")]
	[FieldOffset(Offset = "0x30")]
	public Sprite BackImage;

	// Token: 0x04001547 RID: 5447
	[Token(Token = "0x4001547")]
	[FieldOffset(Offset = "0x34")]
	public Sprite LeftMainImage;

	// Token: 0x04001548 RID: 5448
	[Token(Token = "0x4001548")]
	[FieldOffset(Offset = "0x38")]
	public Sprite LeftBackImage;

	// Token: 0x04001549 RID: 5449
	[Token(Token = "0x4001549")]
	[FieldOffset(Offset = "0x3C")]
	public Sprite ClimbImage;

	// Token: 0x0400154A RID: 5450
	[Token(Token = "0x400154A")]
	[FieldOffset(Offset = "0x40")]
	public Sprite FloorImage;

	// Token: 0x0400154B RID: 5451
	[Token(Token = "0x400154B")]
	[FieldOffset(Offset = "0x44")]
	public Sprite LeftClimbImage;

	// Token: 0x0400154C RID: 5452
	[Token(Token = "0x400154C")]
	[FieldOffset(Offset = "0x48")]
	public Sprite LeftFloorImage;

	// Token: 0x0400154D RID: 5453
	[Token(Token = "0x400154D")]
	[FieldOffset(Offset = "0x4C")]
	public bool InFront;

	// Token: 0x0400154E RID: 5454
	[Token(Token = "0x400154E")]
	[FieldOffset(Offset = "0x0")]
	public bool NoBounce;

	// Token: 0x0400154F RID: 5455
	[Token(Token = "0x400154F")]
	[FieldOffset(Offset = "0x0")]
	public bool BlocksVisors;

	// Token: 0x04001550 RID: 5456
	[Token(Token = "0x4001550")]
	[FieldOffset(Offset = "0x0")]
	public bool NotInStore;

	// Token: 0x04001551 RID: 5457
	[Token(Token = "0x4001551")]
	[FieldOffset(Offset = "0x0")]
	public bool Free;

	// Token: 0x04001552 RID: 5458
	[Token(Token = "0x4001552")]
	[FieldOffset(Offset = "0x54")]
	public Material AltShader;

	// Token: 0x04001553 RID: 5459
	[Token(Token = "0x4001553")]
	[FieldOffset(Offset = "0x58")]
	public SkinData RelatedSkin;

	// Token: 0x04001554 RID: 5460
	[Token(Token = "0x4001554")]
	[FieldOffset(Offset = "0x5C")]
	public string StoreName;

	// Token: 0x04001555 RID: 5461
	[Token(Token = "0x4001555")]
	[FieldOffset(Offset = "0x60")]
	public int Order;
}
