using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000346 RID: 838
[Token(Token = "0x2000346")]
public class SpecimenGame : Minigame
{
	// Token: 0x0600124D RID: 4685 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600124D")]
	[Address(RVA = "0x4A5000", Offset = "0x4A4400", VA = "0x104A5000", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x0600124E RID: 4686 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600124E")]
	[Address(RVA = "0x4A52E0", Offset = "0x4A46E0", VA = "0x104A52E0")]
	public void Update()
	{
	}

	// Token: 0x0600124F RID: 4687 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600124F")]
	[Address(RVA = "0x4A5110", Offset = "0x4A4510", VA = "0x104A5110")]
	private void CheckForWin()
	{
	}

	// Token: 0x06001250 RID: 4688 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001250")]
	[Address(RVA = "0x4A6150", Offset = "0x4A5550", VA = "0x104A6150")]
	public SpecimenGame()
	{
	}

	// Token: 0x04001269 RID: 4713
	[Token(Token = "0x4001269")]
	[FieldOffset(Offset = "0x30")]
	public Collider2D[] Specimens;

	// Token: 0x0400126A RID: 4714
	[Token(Token = "0x400126A")]
	[FieldOffset(Offset = "0x34")]
	public Transform[] Slots;

	// Token: 0x0400126B RID: 4715
	[Token(Token = "0x400126B")]
	[FieldOffset(Offset = "0x38")]
	private Controller cont;

	// Token: 0x0400126C RID: 4716
	[Token(Token = "0x400126C")]
	[FieldOffset(Offset = "0x3C")]
	public AudioClip[] PlaceSounds;

	// Token: 0x0400126D RID: 4717
	[Token(Token = "0x400126D")]
	[FieldOffset(Offset = "0x40")]
	private SpriteRenderer[] SpecimenSprites;

	// Token: 0x0400126E RID: 4718
	[Token(Token = "0x400126E")]
	[FieldOffset(Offset = "0x44")]
	public Color highlightColor;

	// Token: 0x0400126F RID: 4719
	[Token(Token = "0x400126F")]
	[FieldOffset(Offset = "0x54")]
	private bool prevHadStick;

	// Token: 0x04001270 RID: 4720
	[Token(Token = "0x4001270")]
	[FieldOffset(Offset = "0x55")]
	private bool prevHadButton;

	// Token: 0x04001271 RID: 4721
	[Token(Token = "0x4001271")]
	[FieldOffset(Offset = "0x58")]
	private int prevSelectedSpecimen;

	// Token: 0x04001272 RID: 4722
	[Token(Token = "0x4001272")]
	[FieldOffset(Offset = "0x5C")]
	private int selectedSpecimen;
}
