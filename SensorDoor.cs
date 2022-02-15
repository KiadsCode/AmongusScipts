using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001A9 RID: 425
[Token(Token = "0x20001A9")]
public class SensorDoor : MonoBehaviour
{
	// Token: 0x060009A2 RID: 2466 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009A2")]
	[Address(RVA = "0x590C20", Offset = "0x590020", VA = "0x10590C20")]
	public void OnEnable()
	{
	}

	// Token: 0x060009A3 RID: 2467 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009A3")]
	[Address(RVA = "0x590C80", Offset = "0x590080", VA = "0x10590C80")]
	[Attribute(Name = "ContextMenu", RVA = "0xE0890", Offset = "0xDFC90")]
	public void SetUvs()
	{
	}

	// Token: 0x060009A4 RID: 2468 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009A4")]
	[Address(RVA = "0x590CA0", Offset = "0x5900A0", VA = "0x10590CA0")]
	private void Update()
	{
	}

	// Token: 0x060009A5 RID: 2469 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009A5")]
	[Address(RVA = "0x5907A0", Offset = "0x58FBA0", VA = "0x105907A0")]
	private void CheckDoor()
	{
	}

	// Token: 0x060009A6 RID: 2470 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009A6")]
	[Address(RVA = "0x590DC0", Offset = "0x5901C0", VA = "0x10590DC0")]
	public SensorDoor()
	{
	}

	// Token: 0x040009BC RID: 2492
	[Token(Token = "0x40009BC")]
	[FieldOffset(Offset = "0xC")]
	public SpriteRenderer LeftSide;

	// Token: 0x040009BD RID: 2493
	[Token(Token = "0x40009BD")]
	[FieldOffset(Offset = "0x10")]
	public SpriteRenderer RightSide;

	// Token: 0x040009BE RID: 2494
	[Token(Token = "0x40009BE")]
	[FieldOffset(Offset = "0x14")]
	public float ActivationDistance;

	// Token: 0x040009BF RID: 2495
	[Token(Token = "0x40009BF")]
	[FieldOffset(Offset = "0x18")]
	public bool Opening;

	// Token: 0x040009C0 RID: 2496
	[Token(Token = "0x40009C0")]
	[FieldOffset(Offset = "0x1C")]
	public float OpenDuration;

	// Token: 0x040009C1 RID: 2497
	[Token(Token = "0x40009C1")]
	[FieldOffset(Offset = "0x20")]
	private float openTimer;

	// Token: 0x040009C2 RID: 2498
	[Token(Token = "0x40009C2")]
	[FieldOffset(Offset = "0x24")]
	public AudioClip OpenSound;

	// Token: 0x040009C3 RID: 2499
	[Token(Token = "0x40009C3")]
	[FieldOffset(Offset = "0x28")]
	public AudioClip CloseSound;

	// Token: 0x040009C4 RID: 2500
	[Token(Token = "0x40009C4")]
	private const float slideVibrationIntensity = 3f;
}
