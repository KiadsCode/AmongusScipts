using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000088 RID: 136
[Token(Token = "0x2000088")]
public class DressUpMinigame : Minigame
{
	// Token: 0x0600034A RID: 842 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600034A")]
	[Address(RVA = "0x46A080", Offset = "0x469480", VA = "0x1046A080", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x0600034B RID: 843 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600034B")]
	[Address(RVA = "0x46AA40", Offset = "0x469E40", VA = "0x1046AA40")]
	public void Update()
	{
	}

	// Token: 0x0600034C RID: 844 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600034C")]
	[Address(RVA = "0x46A820", Offset = "0x469C20", VA = "0x1046A820")]
	public void SetHat(int i)
	{
	}

	// Token: 0x0600034D RID: 845 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600034D")]
	[Address(RVA = "0x46A460", Offset = "0x469860", VA = "0x1046A460")]
	public void SetAccessory(int i)
	{
	}

	// Token: 0x0600034E RID: 846 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600034E")]
	[Address(RVA = "0x46A640", Offset = "0x469A40", VA = "0x1046A640")]
	public void SetClothes(int i)
	{
	}

	// Token: 0x0600034F RID: 847 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600034F")]
	[Address(RVA = "0x46A250", Offset = "0x469650", VA = "0x1046A250")]
	private void CheckOutfit()
	{
	}

	// Token: 0x06000350 RID: 848 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000350")]
	[Address(RVA = "0x46B590", Offset = "0x46A990", VA = "0x1046B590")]
	public DressUpMinigame()
	{
	}

	// Token: 0x0400032F RID: 815
	[Token(Token = "0x400032F")]
	[FieldOffset(Offset = "0x30")]
	public SpriteRenderer DummyHat;

	// Token: 0x04000330 RID: 816
	[Token(Token = "0x4000330")]
	[FieldOffset(Offset = "0x34")]
	public SpriteRenderer DummyAccessory;

	// Token: 0x04000331 RID: 817
	[Token(Token = "0x4000331")]
	[FieldOffset(Offset = "0x38")]
	public SpriteRenderer DummyClothes;

	// Token: 0x04000332 RID: 818
	[Token(Token = "0x4000332")]
	[FieldOffset(Offset = "0x3C")]
	public SpriteRenderer ActualHat;

	// Token: 0x04000333 RID: 819
	[Token(Token = "0x4000333")]
	[FieldOffset(Offset = "0x40")]
	public SpriteRenderer ActualAccessory;

	// Token: 0x04000334 RID: 820
	[Token(Token = "0x4000334")]
	[FieldOffset(Offset = "0x44")]
	public SpriteRenderer ActualClothes;

	// Token: 0x04000335 RID: 821
	[Token(Token = "0x4000335")]
	[FieldOffset(Offset = "0x48")]
	public DressUpCosmetic[] buttons;

	// Token: 0x04000336 RID: 822
	[Token(Token = "0x4000336")]
	[FieldOffset(Offset = "0x4C")]
	public Sprite[] Hats;

	// Token: 0x04000337 RID: 823
	[Token(Token = "0x4000337")]
	[FieldOffset(Offset = "0x50")]
	public Sprite[] Accessories;

	// Token: 0x04000338 RID: 824
	[Token(Token = "0x4000338")]
	[FieldOffset(Offset = "0x54")]
	public Sprite[] Clothes;

	// Token: 0x04000339 RID: 825
	[Token(Token = "0x4000339")]
	[FieldOffset(Offset = "0x58")]
	public Collider2D hatHitbox;

	// Token: 0x0400033A RID: 826
	[Token(Token = "0x400033A")]
	[FieldOffset(Offset = "0x5C")]
	public Collider2D faceHitbox;

	// Token: 0x0400033B RID: 827
	[Token(Token = "0x400033B")]
	[FieldOffset(Offset = "0x60")]
	public Collider2D bodyHitbox;

	// Token: 0x0400033C RID: 828
	[Token(Token = "0x400033C")]
	[FieldOffset(Offset = "0x64")]
	public SpriteRenderer draggable;

	// Token: 0x0400033D RID: 829
	[Token(Token = "0x400033D")]
	[FieldOffset(Offset = "0x68")]
	public AudioClip hatSound;

	// Token: 0x0400033E RID: 830
	[Token(Token = "0x400033E")]
	[FieldOffset(Offset = "0x6C")]
	public AudioClip faceSound;

	// Token: 0x0400033F RID: 831
	[Token(Token = "0x400033F")]
	[FieldOffset(Offset = "0x70")]
	public AudioClip clothesSound;

	// Token: 0x04000340 RID: 832
	[Token(Token = "0x4000340")]
	[FieldOffset(Offset = "0x74")]
	public AudioClip correctSound;

	// Token: 0x04000341 RID: 833
	[Token(Token = "0x4000341")]
	[FieldOffset(Offset = "0x78")]
	public AudioClip incorrectSound;

	// Token: 0x04000342 RID: 834
	[Token(Token = "0x4000342")]
	[FieldOffset(Offset = "0x7C")]
	public AudioClip finishedSound;

	// Token: 0x04000343 RID: 835
	[Token(Token = "0x4000343")]
	[FieldOffset(Offset = "0x80")]
	private Controller controller;

	// Token: 0x04000344 RID: 836
	[Token(Token = "0x4000344")]
	[FieldOffset(Offset = "0x84")]
	public SpriteRenderer grabbyHand;

	// Token: 0x04000345 RID: 837
	[Token(Token = "0x4000345")]
	[FieldOffset(Offset = "0x88")]
	public Transform cursorObject;
}
