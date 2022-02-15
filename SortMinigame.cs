using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200028B RID: 651
[Token(Token = "0x200028B")]
public class SortMinigame : Minigame
{
	// Token: 0x06000E69 RID: 3689 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E69")]
	[Address(RVA = "0x4A1AC0", Offset = "0x4A0EC0", VA = "0x104A1AC0")]
	public void Start()
	{
	}

	// Token: 0x06000E6A RID: 3690 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E6A")]
	[Address(RVA = "0x4A1CA0", Offset = "0x4A10A0", VA = "0x104A1CA0")]
	public void Update()
	{
	}

	// Token: 0x06000E6B RID: 3691 RVA: 0x000058C8 File Offset: 0x00003AC8
	[Token(Token = "0x6000E6B")]
	[Address(RVA = "0x4A18D0", Offset = "0x4A0CD0", VA = "0x104A18D0")]
	private bool CheckBox(SortGameObject obj, bool dropped)
	{
		return default(bool);
	}

	// Token: 0x06000E6C RID: 3692 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E6C")]
	[Address(RVA = "0x4A28A0", Offset = "0x4A1CA0", VA = "0x104A28A0")]
	public SortMinigame()
	{
	}

	// Token: 0x04000E71 RID: 3697
	[Token(Token = "0x4000E71")]
	[FieldOffset(Offset = "0x30")]
	public SortGameObject[] Objects;

	// Token: 0x04000E72 RID: 3698
	[Token(Token = "0x4000E72")]
	[FieldOffset(Offset = "0x34")]
	public BoxCollider2D AnimalBox;

	// Token: 0x04000E73 RID: 3699
	[Token(Token = "0x4000E73")]
	[FieldOffset(Offset = "0x38")]
	public BoxCollider2D PlantBox;

	// Token: 0x04000E74 RID: 3700
	[Token(Token = "0x4000E74")]
	[FieldOffset(Offset = "0x3C")]
	public BoxCollider2D MineralBox;

	// Token: 0x04000E75 RID: 3701
	[Token(Token = "0x4000E75")]
	[FieldOffset(Offset = "0x40")]
	public AudioClip[] PickUpSounds;

	// Token: 0x04000E76 RID: 3702
	[Token(Token = "0x4000E76")]
	[FieldOffset(Offset = "0x44")]
	public AudioClip[] DropSounds;

	// Token: 0x04000E77 RID: 3703
	[Token(Token = "0x4000E77")]
	[FieldOffset(Offset = "0x48")]
	private Controller myController;

	// Token: 0x04000E78 RID: 3704
	[Token(Token = "0x4000E78")]
	[FieldOffset(Offset = "0x4C")]
	public Transform selectorObject;

	// Token: 0x04000E79 RID: 3705
	[Token(Token = "0x4000E79")]
	[FieldOffset(Offset = "0x50")]
	public SpriteRenderer selectorHand;

	// Token: 0x04000E7A RID: 3706
	[Token(Token = "0x4000E7A")]
	[FieldOffset(Offset = "0x54")]
	private bool prevHadButton;

	// Token: 0x04000E7B RID: 3707
	[Token(Token = "0x4000E7B")]
	[FieldOffset(Offset = "0x58")]
	private int currentlyGrabbedObject;
}
