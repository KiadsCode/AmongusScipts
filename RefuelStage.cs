using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000180 RID: 384
[Token(Token = "0x2000180")]
public class RefuelStage : Minigame
{
	// Token: 0x060008C4 RID: 2244 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008C4")]
	[Address(RVA = "0x4F4770", Offset = "0x4F3B70", VA = "0x104F4770", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x060008C5 RID: 2245 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008C5")]
	[Address(RVA = "0x4F48C0", Offset = "0x4F3CC0", VA = "0x104F48C0")]
	public void FixedUpdate()
	{
	}

	// Token: 0x060008C6 RID: 2246 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008C6")]
	[Address(RVA = "0x4F4CC0", Offset = "0x4F40C0", VA = "0x104F4CC0")]
	public void Refuel()
	{
	}

	// Token: 0x060008C7 RID: 2247 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008C7")]
	[Address(RVA = "0x4F4C50", Offset = "0x4F4050", VA = "0x104F4C50")]
	private void GetRefuelDynamics(AudioSource player, float dt)
	{
	}

	// Token: 0x060008C8 RID: 2248 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008C8")]
	[Address(RVA = "0x4F47E0", Offset = "0x4F3BE0", VA = "0x104F47E0", Slot = "5")]
	public override void Close()
	{
	}

	// Token: 0x060008C9 RID: 2249 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008C9")]
	[Address(RVA = "0x4F4ED0", Offset = "0x4F42D0", VA = "0x104F4ED0")]
	public RefuelStage()
	{
	}

	// Token: 0x040008CA RID: 2250
	[Token(Token = "0x40008CA")]
	[FieldOffset(Offset = "0x30")]
	public float RefuelDuration;

	// Token: 0x040008CB RID: 2251
	[Token(Token = "0x40008CB")]
	[FieldOffset(Offset = "0x34")]
	private Color darkRed;

	// Token: 0x040008CC RID: 2252
	[Token(Token = "0x40008CC")]
	[FieldOffset(Offset = "0x44")]
	private Color red;

	// Token: 0x040008CD RID: 2253
	[Token(Token = "0x40008CD")]
	[FieldOffset(Offset = "0x54")]
	private Color green;

	// Token: 0x040008CE RID: 2254
	[Token(Token = "0x40008CE")]
	[FieldOffset(Offset = "0x64")]
	public SpriteRenderer redLight;

	// Token: 0x040008CF RID: 2255
	[Token(Token = "0x40008CF")]
	[FieldOffset(Offset = "0x68")]
	public SpriteRenderer greenLight;

	// Token: 0x040008D0 RID: 2256
	[Token(Token = "0x40008D0")]
	[FieldOffset(Offset = "0x6C")]
	public VerticalGauge srcGauge;

	// Token: 0x040008D1 RID: 2257
	[Token(Token = "0x40008D1")]
	[FieldOffset(Offset = "0x70")]
	public VerticalGauge destGauge;

	// Token: 0x040008D2 RID: 2258
	[Token(Token = "0x40008D2")]
	[FieldOffset(Offset = "0x74")]
	public AudioClip RefuelSound;

	// Token: 0x040008D3 RID: 2259
	[Token(Token = "0x40008D3")]
	[FieldOffset(Offset = "0x78")]
	private float timer;

	// Token: 0x040008D4 RID: 2260
	[Token(Token = "0x40008D4")]
	[FieldOffset(Offset = "0x7C")]
	private bool isDown;

	// Token: 0x040008D5 RID: 2261
	[Token(Token = "0x40008D5")]
	[FieldOffset(Offset = "0x7D")]
	private bool complete;

	// Token: 0x040008D6 RID: 2262
	[Token(Token = "0x40008D6")]
	[FieldOffset(Offset = "0x7E")]
	private bool usingController;
}
