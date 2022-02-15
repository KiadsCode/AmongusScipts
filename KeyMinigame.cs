using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200033D RID: 829
[Token(Token = "0x200033D")]
public class KeyMinigame : Minigame
{
	// Token: 0x0600121C RID: 4636 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600121C")]
	[Address(RVA = "0x6D3B70", Offset = "0x6D2F70", VA = "0x106D3B70")]
	public void Start()
	{
	}

	// Token: 0x0600121D RID: 4637 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600121D")]
	[Address(RVA = "0x6D3CD0", Offset = "0x6D30D0", VA = "0x106D3CD0")]
	public void Update()
	{
	}

	// Token: 0x0600121E RID: 4638 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600121E")]
	[Address(RVA = "0x6D4FE0", Offset = "0x6D43E0", VA = "0x106D4FE0")]
	public KeyMinigame()
	{
	}

	// Token: 0x04001220 RID: 4640
	[Token(Token = "0x4001220")]
	[FieldOffset(Offset = "0x30")]
	public KeySlotBehaviour[] Slots;

	// Token: 0x04001221 RID: 4641
	[Token(Token = "0x4001221")]
	[FieldOffset(Offset = "0x34")]
	private int keyState;

	// Token: 0x04001222 RID: 4642
	[Token(Token = "0x4001222")]
	[FieldOffset(Offset = "0x38")]
	public SpriteRenderer KeyImage;

	// Token: 0x04001223 RID: 4643
	[Token(Token = "0x4001223")]
	[FieldOffset(Offset = "0x3C")]
	public Sprite normalImage;

	// Token: 0x04001224 RID: 4644
	[Token(Token = "0x4001224")]
	[FieldOffset(Offset = "0x40")]
	public Sprite insertImage;

	// Token: 0x04001225 RID: 4645
	[Token(Token = "0x4001225")]
	[FieldOffset(Offset = "0x44")]
	public BoxCollider2D key;

	// Token: 0x04001226 RID: 4646
	[Token(Token = "0x4001226")]
	[FieldOffset(Offset = "0x48")]
	private int targetSlotId;

	// Token: 0x04001227 RID: 4647
	[Token(Token = "0x4001227")]
	[FieldOffset(Offset = "0x4C")]
	private Controller controller;

	// Token: 0x04001228 RID: 4648
	[Token(Token = "0x4001228")]
	[FieldOffset(Offset = "0x50")]
	public AudioClip KeyGrab;

	// Token: 0x04001229 RID: 4649
	[Token(Token = "0x4001229")]
	[FieldOffset(Offset = "0x54")]
	public AudioClip KeyInsert;

	// Token: 0x0400122A RID: 4650
	[Token(Token = "0x400122A")]
	[FieldOffset(Offset = "0x58")]
	public AudioClip KeyOpen;

	// Token: 0x0400122B RID: 4651
	[Token(Token = "0x400122B")]
	[FieldOffset(Offset = "0x5C")]
	public AudioClip KeyTurn;

	// Token: 0x0400122C RID: 4652
	[Token(Token = "0x400122C")]
	[FieldOffset(Offset = "0x60")]
	private TouchpadBehavior touchpad;

	// Token: 0x0400122D RID: 4653
	[Token(Token = "0x400122D")]
	[FieldOffset(Offset = "0x64")]
	private Vector3 initialPos;

	// Token: 0x0400122E RID: 4654
	[Token(Token = "0x400122E")]
	[FieldOffset(Offset = "0x70")]
	private bool prevHadInput;

	// Token: 0x0400122F RID: 4655
	[Token(Token = "0x400122F")]
	[FieldOffset(Offset = "0x74")]
	private Vector2 prevInputDir;

	// Token: 0x04001230 RID: 4656
	[Token(Token = "0x4001230")]
	[FieldOffset(Offset = "0x7C")]
	private float currentAngle;

	// Token: 0x04001231 RID: 4657
	[Token(Token = "0x4001231")]
	[FieldOffset(Offset = "0x80")]
	public GameObject moveKeyGlyph;

	// Token: 0x04001232 RID: 4658
	[Token(Token = "0x4001232")]
	[FieldOffset(Offset = "0x84")]
	public GameObject turnKeyGlyph;
}
