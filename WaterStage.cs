using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200033C RID: 828
[Token(Token = "0x200033C")]
public class WaterStage : Minigame
{
	// Token: 0x06001216 RID: 4630 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001216")]
	[Address(RVA = "0x7B5CD0", Offset = "0x7B50D0", VA = "0x107B5CD0", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x06001217 RID: 4631 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001217")]
	[Address(RVA = "0x7B5E10", Offset = "0x7B5210", VA = "0x107B5E10")]
	public void FixedUpdate()
	{
	}

	// Token: 0x06001218 RID: 4632 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001218")]
	[Address(RVA = "0x7B6240", Offset = "0x7B5640", VA = "0x107B6240")]
	public void Refuel()
	{
	}

	// Token: 0x06001219 RID: 4633 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001219")]
	[Address(RVA = "0x7B61B0", Offset = "0x7B55B0", VA = "0x107B61B0")]
	private void GetRefuelDynamics(AudioSource player, float dt)
	{
	}

	// Token: 0x0600121A RID: 4634 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600121A")]
	[Address(RVA = "0x7B5D30", Offset = "0x7B5130", VA = "0x107B5D30", Slot = "5")]
	public override void Close()
	{
	}

	// Token: 0x0600121B RID: 4635 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600121B")]
	[Address(RVA = "0x7B6400", Offset = "0x7B5800", VA = "0x107B6400")]
	public WaterStage()
	{
	}

	// Token: 0x04001216 RID: 4630
	[Token(Token = "0x4001216")]
	[FieldOffset(Offset = "0x30")]
	public float RefuelDuration;

	// Token: 0x04001217 RID: 4631
	[Token(Token = "0x4001217")]
	[FieldOffset(Offset = "0x34")]
	public SpriteRenderer waterButton;

	// Token: 0x04001218 RID: 4632
	[Token(Token = "0x4001218")]
	[FieldOffset(Offset = "0x38")]
	public Sprite buttonDownSprite;

	// Token: 0x04001219 RID: 4633
	[Token(Token = "0x4001219")]
	[FieldOffset(Offset = "0x3C")]
	public Sprite buttonUpSprite;

	// Token: 0x0400121A RID: 4634
	[Token(Token = "0x400121A")]
	[FieldOffset(Offset = "0x40")]
	public VerticalGauge srcGauge;

	// Token: 0x0400121B RID: 4635
	[Token(Token = "0x400121B")]
	[FieldOffset(Offset = "0x44")]
	public VerticalGauge destGauge;

	// Token: 0x0400121C RID: 4636
	[Token(Token = "0x400121C")]
	[FieldOffset(Offset = "0x48")]
	public AudioClip RefuelSound;

	// Token: 0x0400121D RID: 4637
	[Token(Token = "0x400121D")]
	[FieldOffset(Offset = "0x4C")]
	private float timer;

	// Token: 0x0400121E RID: 4638
	[Token(Token = "0x400121E")]
	[FieldOffset(Offset = "0x50")]
	private bool isDown;

	// Token: 0x0400121F RID: 4639
	[Token(Token = "0x400121F")]
	[FieldOffset(Offset = "0x51")]
	private bool complete;
}
