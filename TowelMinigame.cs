using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000A6 RID: 166
[Token(Token = "0x20000A6")]
public class TowelMinigame : Minigame
{
	// Token: 0x06000404 RID: 1028 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000404")]
	[Address(RVA = "0x4B0220", Offset = "0x4AF620", VA = "0x104B0220", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x06000405 RID: 1029 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000405")]
	[Address(RVA = "0x4B0320", Offset = "0x4AF720", VA = "0x104B0320")]
	private void Update()
	{
	}

	// Token: 0x06000406 RID: 1030 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000406")]
	[Address(RVA = "0x4B0F50", Offset = "0x4B0350", VA = "0x104B0F50")]
	public TowelMinigame()
	{
	}

	// Token: 0x0400043C RID: 1084
	[Token(Token = "0x400043C")]
	[FieldOffset(Offset = "0x30")]
	private FloatRange towelRange;

	// Token: 0x0400043D RID: 1085
	[Token(Token = "0x400043D")]
	[FieldOffset(Offset = "0x34")]
	public SpriteRenderer BasketGauge;

	// Token: 0x0400043E RID: 1086
	[Token(Token = "0x400043E")]
	[FieldOffset(Offset = "0x38")]
	public Collider2D BasketHitbox;

	// Token: 0x0400043F RID: 1087
	[Token(Token = "0x400043F")]
	[FieldOffset(Offset = "0x3C")]
	public Collider2D[] Towels;

	// Token: 0x04000440 RID: 1088
	[Token(Token = "0x4000440")]
	[FieldOffset(Offset = "0x40")]
	private Controller controller;

	// Token: 0x04000441 RID: 1089
	[Token(Token = "0x4000441")]
	[FieldOffset(Offset = "0x44")]
	private int towelsDone;

	// Token: 0x04000442 RID: 1090
	[Token(Token = "0x4000442")]
	[FieldOffset(Offset = "0x48")]
	public AudioClip TowelGrab;

	// Token: 0x04000443 RID: 1091
	[Token(Token = "0x4000443")]
	[FieldOffset(Offset = "0x4C")]
	public AudioClip TowelLand;

	// Token: 0x04000444 RID: 1092
	[Token(Token = "0x4000444")]
	[FieldOffset(Offset = "0x50")]
	public Transform interactionCursor;

	// Token: 0x04000445 RID: 1093
	[Token(Token = "0x4000445")]
	[FieldOffset(Offset = "0x54")]
	public SpriteRenderer openHand;

	// Token: 0x04000446 RID: 1094
	[Token(Token = "0x4000446")]
	[FieldOffset(Offset = "0x58")]
	public SpriteRenderer holdingHand;

	// Token: 0x04000447 RID: 1095
	[Token(Token = "0x4000447")]
	[FieldOffset(Offset = "0x5C")]
	public Vector2Range ValidArea;

	// Token: 0x04000448 RID: 1096
	[Token(Token = "0x4000448")]
	[FieldOffset(Offset = "0x6C")]
	public float stickMoveSpeed;

	// Token: 0x04000449 RID: 1097
	[Token(Token = "0x4000449")]
	[FieldOffset(Offset = "0x70")]
	public float stickHeldSpeed;

	// Token: 0x0400044A RID: 1098
	[Token(Token = "0x400044A")]
	[FieldOffset(Offset = "0x74")]
	public float towelDragSpeed;

	// Token: 0x0400044B RID: 1099
	[Token(Token = "0x400044B")]
	[FieldOffset(Offset = "0x78")]
	private Collider2D[] overlapResults;

	// Token: 0x0400044C RID: 1100
	[Token(Token = "0x400044C")]
	[FieldOffset(Offset = "0x7C")]
	private bool isHolding;

	// Token: 0x0400044D RID: 1101
	[Token(Token = "0x400044D")]
	[FieldOffset(Offset = "0x80")]
	private GameObject heldTowel;
}
