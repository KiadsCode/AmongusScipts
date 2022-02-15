using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200015D RID: 349
[Token(Token = "0x200015D")]
public class SweepMinigame : Minigame
{
	// Token: 0x060007F7 RID: 2039 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007F7")]
	[Address(RVA = "0x765830", Offset = "0x764C30", VA = "0x10765830")]
	private void OnDisable()
	{
	}

	// Token: 0x060007F8 RID: 2040 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007F8")]
	[Address(RVA = "0x765090", Offset = "0x764490", VA = "0x10765090", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x060007F9 RID: 2041 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007F9")]
	[Address(RVA = "0x7651F0", Offset = "0x7645F0", VA = "0x107651F0", Slot = "5")]
	public override void Close()
	{
	}

	// Token: 0x060007FA RID: 2042 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007FA")]
	[Address(RVA = "0x765260", Offset = "0x764660", VA = "0x10765260")]
	public void FixedUpdate()
	{
	}

	// Token: 0x060007FB RID: 2043 RVA: 0x00004080 File Offset: 0x00002280
	[Token(Token = "0x60007FB")]
	[Address(RVA = "0x7651B0", Offset = "0x7645B0", VA = "0x107651B0")]
	private float CalcXPerc()
	{
		return 0f;
	}

	// Token: 0x060007FC RID: 2044 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007FC")]
	[Address(RVA = "0x7655A0", Offset = "0x7649A0", VA = "0x107655A0")]
	public void HitButton(int i)
	{
	}

	// Token: 0x060007FD RID: 2045 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007FD")]
	[Address(RVA = "0x7658A0", Offset = "0x764CA0", VA = "0x107658A0")]
	private void ResetGauges()
	{
	}

	// Token: 0x060007FE RID: 2046 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007FE")]
	[Address(RVA = "0x765A50", Offset = "0x764E50", VA = "0x10765A50")]
	public SweepMinigame()
	{
	}

	// Token: 0x040007DF RID: 2015
	[Token(Token = "0x40007DF")]
	[FieldOffset(Offset = "0x30")]
	public SpriteRenderer[] Spinners;

	// Token: 0x040007E0 RID: 2016
	[Token(Token = "0x40007E0")]
	[FieldOffset(Offset = "0x34")]
	public SpriteRenderer[] Shadows;

	// Token: 0x040007E1 RID: 2017
	[Token(Token = "0x40007E1")]
	[FieldOffset(Offset = "0x38")]
	public SpriteRenderer[] Lights;

	// Token: 0x040007E2 RID: 2018
	[Token(Token = "0x40007E2")]
	[FieldOffset(Offset = "0x3C")]
	public HorizontalGauge[] Gauges;

	// Token: 0x040007E3 RID: 2019
	[Token(Token = "0x40007E3")]
	[FieldOffset(Offset = "0x40")]
	private int spinnerIdx;

	// Token: 0x040007E4 RID: 2020
	[Token(Token = "0x40007E4")]
	[FieldOffset(Offset = "0x44")]
	private float timer;

	// Token: 0x040007E5 RID: 2021
	[Token(Token = "0x40007E5")]
	[FieldOffset(Offset = "0x48")]
	public float SpinRate;

	// Token: 0x040007E6 RID: 2022
	[Token(Token = "0x40007E6")]
	[FieldOffset(Offset = "0x4C")]
	private float initialTimer;

	// Token: 0x040007E7 RID: 2023
	[Token(Token = "0x40007E7")]
	[FieldOffset(Offset = "0x50")]
	public AudioClip SpinningSound;

	// Token: 0x040007E8 RID: 2024
	[Token(Token = "0x40007E8")]
	[FieldOffset(Offset = "0x54")]
	public AudioClip AcceptSound;

	// Token: 0x040007E9 RID: 2025
	[Token(Token = "0x40007E9")]
	[FieldOffset(Offset = "0x58")]
	public AudioClip RejectSound;

	// Token: 0x040007EA RID: 2026
	[Token(Token = "0x40007EA")]
	[FieldOffset(Offset = "0x5C")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xDD8F0", Offset = "0xDCCF0")]
	public UiElement BackButton;

	// Token: 0x040007EB RID: 2027
	[Token(Token = "0x40007EB")]
	[FieldOffset(Offset = "0x60")]
	public UiElement DefaultButtonSelected;

	// Token: 0x040007EC RID: 2028
	[Token(Token = "0x40007EC")]
	[FieldOffset(Offset = "0x64")]
	public List<UiElement> ControllerSelectable;
}
