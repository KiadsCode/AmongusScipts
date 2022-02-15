using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200047F RID: 1151
[Token(Token = "0x200047F")]
public class ShieldMinigame : Minigame
{
	// Token: 0x06001886 RID: 6278 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001886")]
	[Address(RVA = "0x494FD0", Offset = "0x4943D0", VA = "0x10494FD0", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x06001887 RID: 6279 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001887")]
	[Address(RVA = "0x495040", Offset = "0x494440", VA = "0x10495040")]
	public void ToggleShield(int i)
	{
	}

	// Token: 0x06001888 RID: 6280 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001888")]
	[Address(RVA = "0x495470", Offset = "0x494870", VA = "0x10495470")]
	private void Update()
	{
	}

	// Token: 0x06001889 RID: 6281 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001889")]
	[Address(RVA = "0x495030", Offset = "0x494430", VA = "0x10495030")]
	public void FixedUpdate()
	{
	}

	// Token: 0x0600188A RID: 6282 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600188A")]
	[Address(RVA = "0x495290", Offset = "0x494690", VA = "0x10495290")]
	private void UpdateButtons()
	{
	}

	// Token: 0x0600188B RID: 6283 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600188B")]
	[Address(RVA = "0x495870", Offset = "0x494C70", VA = "0x10495870")]
	public ShieldMinigame()
	{
	}

	// Token: 0x040018AC RID: 6316
	[Token(Token = "0x40018AC")]
	[FieldOffset(Offset = "0x30")]
	public Color OnColor;

	// Token: 0x040018AD RID: 6317
	[Token(Token = "0x40018AD")]
	[FieldOffset(Offset = "0x40")]
	public Color OffColor;

	// Token: 0x040018AE RID: 6318
	[Token(Token = "0x40018AE")]
	[FieldOffset(Offset = "0x50")]
	public SpriteRenderer[] Shields;

	// Token: 0x040018AF RID: 6319
	[Token(Token = "0x40018AF")]
	[FieldOffset(Offset = "0x54")]
	public SpriteRenderer Gauge;

	// Token: 0x040018B0 RID: 6320
	[Token(Token = "0x40018B0")]
	[FieldOffset(Offset = "0x58")]
	private byte shields;

	// Token: 0x040018B1 RID: 6321
	[Token(Token = "0x40018B1")]
	[FieldOffset(Offset = "0x5C")]
	public AudioClip ShieldOnSound;

	// Token: 0x040018B2 RID: 6322
	[Token(Token = "0x40018B2")]
	[FieldOffset(Offset = "0x60")]
	public AudioClip ShieldOffSound;

	// Token: 0x040018B3 RID: 6323
	[Token(Token = "0x40018B3")]
	[FieldOffset(Offset = "0x64")]
	public Transform selectedButtonHighlight;

	// Token: 0x040018B4 RID: 6324
	[Token(Token = "0x40018B4")]
	[FieldOffset(Offset = "0x68")]
	private Controller controller;

	// Token: 0x040018B5 RID: 6325
	[Token(Token = "0x40018B5")]
	[FieldOffset(Offset = "0x6C")]
	private int oldSelectedIndex;
}
