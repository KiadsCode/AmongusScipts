using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200015F RID: 351
[Token(Token = "0x200015F")]
public class SwitchMinigame : Minigame
{
	// Token: 0x06000802 RID: 2050 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000802")]
	[Address(RVA = "0x765A70", Offset = "0x764E70", VA = "0x10765A70", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x06000803 RID: 2051 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000803")]
	[Address(RVA = "0x765C60", Offset = "0x765060", VA = "0x10765C60")]
	public void FixedUpdate()
	{
	}

	// Token: 0x06000804 RID: 2052 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000804")]
	[Address(RVA = "0x7661A0", Offset = "0x7655A0", VA = "0x107661A0")]
	public void FlipSwitch(int switchIdx)
	{
	}

	// Token: 0x06000805 RID: 2053 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000805")]
	[Address(RVA = "0x766460", Offset = "0x765860", VA = "0x10766460")]
	public SwitchMinigame()
	{
	}

	// Token: 0x040007F7 RID: 2039
	[Token(Token = "0x40007F7")]
	[FieldOffset(Offset = "0x30")]
	public Color OnColor;

	// Token: 0x040007F8 RID: 2040
	[Token(Token = "0x40007F8")]
	[FieldOffset(Offset = "0x40")]
	public Color OffColor;

	// Token: 0x040007F9 RID: 2041
	[Token(Token = "0x40007F9")]
	[FieldOffset(Offset = "0x50")]
	private ShipStatus ship;

	// Token: 0x040007FA RID: 2042
	[Token(Token = "0x40007FA")]
	[FieldOffset(Offset = "0x54")]
	public SpriteRenderer[] switches;

	// Token: 0x040007FB RID: 2043
	[Token(Token = "0x40007FB")]
	[FieldOffset(Offset = "0x58")]
	public SpriteRenderer[] lights;

	// Token: 0x040007FC RID: 2044
	[Token(Token = "0x40007FC")]
	[FieldOffset(Offset = "0x5C")]
	public RadioWaveBehaviour top;

	// Token: 0x040007FD RID: 2045
	[Token(Token = "0x40007FD")]
	[FieldOffset(Offset = "0x60")]
	public HorizontalGauge middle;

	// Token: 0x040007FE RID: 2046
	[Token(Token = "0x40007FE")]
	[FieldOffset(Offset = "0x64")]
	public FlatWaveBehaviour bottom;

	// Token: 0x040007FF RID: 2047
	[Token(Token = "0x40007FF")]
	[FieldOffset(Offset = "0x68")]
	public AudioClip FlipSound;

	// Token: 0x04000800 RID: 2048
	[Token(Token = "0x4000800")]
	[FieldOffset(Offset = "0x6C")]
	public Transform selectorHighlight;

	// Token: 0x04000801 RID: 2049
	[Token(Token = "0x4000801")]
	[FieldOffset(Offset = "0x70")]
	private int selectedIndex;

	// Token: 0x04000802 RID: 2050
	[Token(Token = "0x4000802")]
	[FieldOffset(Offset = "0x74")]
	private float selectorCooldown;

	// Token: 0x04000803 RID: 2051
	[Token(Token = "0x4000803")]
	[FieldOffset(Offset = "0x78")]
	private bool prevHadVerticalInput;
}
