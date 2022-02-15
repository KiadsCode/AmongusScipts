using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000B9 RID: 185
[Token(Token = "0x20000B9")]
public class TuneRadioMinigame : Minigame
{
	// Token: 0x06000459 RID: 1113 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000459")]
	[Address(RVA = "0x4B3020", Offset = "0x4B2420", VA = "0x104B3020", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x0600045A RID: 1114 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600045A")]
	[Address(RVA = "0x4B34A0", Offset = "0x4B28A0", VA = "0x104B34A0")]
	private void GetRadioVolume(AudioSource player, float dt)
	{
	}

	// Token: 0x0600045B RID: 1115 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600045B")]
	[Address(RVA = "0x4B34E0", Offset = "0x4B28E0", VA = "0x104B34E0")]
	private void GetStaticVolume(AudioSource player, float dt)
	{
	}

	// Token: 0x0600045C RID: 1116 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600045C")]
	[Address(RVA = "0x4B3520", Offset = "0x4B2920", VA = "0x104B3520")]
	public void Update()
	{
	}

	// Token: 0x0600045D RID: 1117 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600045D")]
	[Address(RVA = "0x4B3240", Offset = "0x4B2640", VA = "0x104B3240")]
	private void FinishGame()
	{
	}

	// Token: 0x0600045E RID: 1118 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600045E")]
	[Address(RVA = "0x4B31B0", Offset = "0x4B25B0", VA = "0x104B31B0", Slot = "5")]
	public override void Close()
	{
	}

	// Token: 0x0600045F RID: 1119 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600045F")]
	[Address(RVA = "0x4B3850", Offset = "0x4B2C50", VA = "0x104B3850")]
	public TuneRadioMinigame()
	{
	}

	// Token: 0x040004C3 RID: 1219
	[Token(Token = "0x40004C3")]
	[FieldOffset(Offset = "0x30")]
	public RadioWaveBehaviour actualSignal;

	// Token: 0x040004C4 RID: 1220
	[Token(Token = "0x40004C4")]
	[FieldOffset(Offset = "0x34")]
	public DialBehaviour dial;

	// Token: 0x040004C5 RID: 1221
	[Token(Token = "0x40004C5")]
	[FieldOffset(Offset = "0x38")]
	public SpriteRenderer redLight;

	// Token: 0x040004C6 RID: 1222
	[Token(Token = "0x40004C6")]
	[FieldOffset(Offset = "0x3C")]
	public SpriteRenderer greenLight;

	// Token: 0x040004C7 RID: 1223
	[Token(Token = "0x40004C7")]
	[FieldOffset(Offset = "0x40")]
	public float Tolerance;

	// Token: 0x040004C8 RID: 1224
	[Token(Token = "0x40004C8")]
	[FieldOffset(Offset = "0x44")]
	public float targetAngle;

	// Token: 0x040004C9 RID: 1225
	[Token(Token = "0x40004C9")]
	[FieldOffset(Offset = "0x48")]
	public bool finished;

	// Token: 0x040004CA RID: 1226
	[Token(Token = "0x40004CA")]
	[FieldOffset(Offset = "0x4C")]
	private float steadyTimer;

	// Token: 0x040004CB RID: 1227
	[Token(Token = "0x40004CB")]
	[FieldOffset(Offset = "0x50")]
	public AudioClip StaticSound;

	// Token: 0x040004CC RID: 1228
	[Token(Token = "0x40004CC")]
	[FieldOffset(Offset = "0x54")]
	public AudioClip RadioSound;
}
