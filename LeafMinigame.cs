using System;
using Il2CppDummyDll;
using PowerTools;
using UnityEngine;

// Token: 0x02000293 RID: 659
[Token(Token = "0x2000293")]
public class LeafMinigame : Minigame
{
	// Token: 0x06000E97 RID: 3735 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E97")]
	[Address(RVA = "0x6DA9A0", Offset = "0x6D9DA0", VA = "0x106DA9A0", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x06000E98 RID: 3736 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E98")]
	[Address(RVA = "0x6DABB0", Offset = "0x6D9FB0", VA = "0x106DABB0")]
	public void FixedUpdate()
	{
	}

	// Token: 0x06000E99 RID: 3737 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E99")]
	[Address(RVA = "0x6DB750", Offset = "0x6DAB50", VA = "0x106DB750")]
	public void LeafDone(LeafBehaviour leaf)
	{
	}

	// Token: 0x06000E9A RID: 3738 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E9A")]
	[Address(RVA = "0x6DB9B0", Offset = "0x6DADB0", VA = "0x106DB9B0")]
	public LeafMinigame()
	{
	}

	// Token: 0x04000EAD RID: 3757
	[Token(Token = "0x4000EAD")]
	[FieldOffset(Offset = "0x30")]
	public LeafBehaviour LeafPrefab;

	// Token: 0x04000EAE RID: 3758
	[Token(Token = "0x4000EAE")]
	[FieldOffset(Offset = "0x34")]
	public Vector2Range ValidArea;

	// Token: 0x04000EAF RID: 3759
	[Token(Token = "0x4000EAF")]
	[FieldOffset(Offset = "0x44")]
	public SpriteAnim[] Arrows;

	// Token: 0x04000EB0 RID: 3760
	[Token(Token = "0x4000EB0")]
	[FieldOffset(Offset = "0x48")]
	public AnimationClip[] Inactive;

	// Token: 0x04000EB1 RID: 3761
	[Token(Token = "0x4000EB1")]
	[FieldOffset(Offset = "0x4C")]
	public AnimationClip[] Active;

	// Token: 0x04000EB2 RID: 3762
	[Token(Token = "0x4000EB2")]
	[FieldOffset(Offset = "0x50")]
	public AnimationClip[] Complete;

	// Token: 0x04000EB3 RID: 3763
	[Token(Token = "0x4000EB3")]
	[FieldOffset(Offset = "0x54")]
	private Collider2D[] Leaves;

	// Token: 0x04000EB4 RID: 3764
	[Token(Token = "0x4000EB4")]
	[FieldOffset(Offset = "0x58")]
	public AudioClip[] LeaveSounds;

	// Token: 0x04000EB5 RID: 3765
	[Token(Token = "0x4000EB5")]
	[FieldOffset(Offset = "0x5C")]
	public AudioClip[] SuckSounds;

	// Token: 0x04000EB6 RID: 3766
	[Token(Token = "0x4000EB6")]
	[FieldOffset(Offset = "0x60")]
	private Controller myController;

	// Token: 0x04000EB7 RID: 3767
	[Token(Token = "0x4000EB7")]
	[FieldOffset(Offset = "0x64")]
	public Transform interactionCursor;

	// Token: 0x04000EB8 RID: 3768
	[Token(Token = "0x4000EB8")]
	[FieldOffset(Offset = "0x68")]
	public Transform interactionCursorCenterDot;

	// Token: 0x04000EB9 RID: 3769
	[Token(Token = "0x4000EB9")]
	[FieldOffset(Offset = "0x6C")]
	private Collider2D[] overlapResults;

	// Token: 0x04000EBA RID: 3770
	[Token(Token = "0x4000EBA")]
	[FieldOffset(Offset = "0x70")]
	private bool prevHadOverlaps;

	// Token: 0x04000EBB RID: 3771
	[Token(Token = "0x4000EBB")]
	[FieldOffset(Offset = "0x71")]
	private bool prevRightStickInput;
}
