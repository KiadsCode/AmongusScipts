using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000A7 RID: 167
[Token(Token = "0x20000A7")]
public class AirshipUploadGame : Minigame
{
	// Token: 0x06000407 RID: 1031 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000407")]
	[Address(RVA = "0x545600", Offset = "0x544A00", VA = "0x10545600")]
	public void Start()
	{
	}

	// Token: 0x06000408 RID: 1032 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000408")]
	[Address(RVA = "0x545740", Offset = "0x544B40", VA = "0x10545740")]
	public void Update()
	{
	}

	// Token: 0x06000409 RID: 1033 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000409")]
	[Address(RVA = "0x545720", Offset = "0x544B20", VA = "0x10545720")]
	public void ToggleGrab()
	{
	}

	// Token: 0x0600040A RID: 1034 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600040A")]
	[Address(RVA = "0x5455A0", Offset = "0x5449A0", VA = "0x105455A0")]
	private void DeactivateIcons()
	{
	}

	// Token: 0x0600040B RID: 1035 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600040B")]
	[Address(RVA = "0x545E00", Offset = "0x545200", VA = "0x10545E00")]
	public AirshipUploadGame()
	{
	}

	// Token: 0x0400044E RID: 1102
	[Token(Token = "0x400044E")]
	[FieldOffset(Offset = "0x30")]
	public SpriteRenderer Phone;

	// Token: 0x0400044F RID: 1103
	[Token(Token = "0x400044F")]
	[FieldOffset(Offset = "0x34")]
	public Collider2D Hotspot;

	// Token: 0x04000450 RID: 1104
	[Token(Token = "0x4000450")]
	[FieldOffset(Offset = "0x38")]
	public Collider2D Perfect;

	// Token: 0x04000451 RID: 1105
	[Token(Token = "0x4000451")]
	[FieldOffset(Offset = "0x3C")]
	public Collider2D Good;

	// Token: 0x04000452 RID: 1106
	[Token(Token = "0x4000452")]
	[FieldOffset(Offset = "0x40")]
	public Collider2D Poor;

	// Token: 0x04000453 RID: 1107
	[Token(Token = "0x4000453")]
	[FieldOffset(Offset = "0x44")]
	public GameObject PerfectIcon;

	// Token: 0x04000454 RID: 1108
	[Token(Token = "0x4000454")]
	[FieldOffset(Offset = "0x48")]
	public GameObject GoodIcon;

	// Token: 0x04000455 RID: 1109
	[Token(Token = "0x4000455")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject PoorIcon;

	// Token: 0x04000456 RID: 1110
	[Token(Token = "0x4000456")]
	[FieldOffset(Offset = "0x50")]
	public GameObject NoneIcon;

	// Token: 0x04000457 RID: 1111
	[Token(Token = "0x4000457")]
	[FieldOffset(Offset = "0x54")]
	public HorizontalGauge gauge;

	// Token: 0x04000458 RID: 1112
	[Token(Token = "0x4000458")]
	[FieldOffset(Offset = "0x58")]
	public float moveSpeed;

	// Token: 0x04000459 RID: 1113
	[Token(Token = "0x4000459")]
	private const float MaxTimer = 20f;

	// Token: 0x0400045A RID: 1114
	[Token(Token = "0x400045A")]
	[FieldOffset(Offset = "0x5C")]
	private float timer;

	// Token: 0x0400045B RID: 1115
	[Token(Token = "0x400045B")]
	[FieldOffset(Offset = "0x60")]
	public AudioClip nearSound;

	// Token: 0x0400045C RID: 1116
	[Token(Token = "0x400045C")]
	[FieldOffset(Offset = "0x64")]
	public float BeepPeriod;

	// Token: 0x0400045D RID: 1117
	[Token(Token = "0x400045D")]
	[FieldOffset(Offset = "0x68")]
	private float beepTimer;

	// Token: 0x0400045E RID: 1118
	[Token(Token = "0x400045E")]
	[FieldOffset(Offset = "0x6C")]
	public Controller cont;

	// Token: 0x0400045F RID: 1119
	[Token(Token = "0x400045F")]
	[FieldOffset(Offset = "0x70")]
	public SpriteRenderer promptGlyph;

	// Token: 0x04000460 RID: 1120
	[Token(Token = "0x4000460")]
	[FieldOffset(Offset = "0x74")]
	private Color glyphColor;

	// Token: 0x04000461 RID: 1121
	[Token(Token = "0x4000461")]
	[FieldOffset(Offset = "0x84")]
	private float glyphDisappearDelay;

	// Token: 0x04000462 RID: 1122
	[Token(Token = "0x4000462")]
	[FieldOffset(Offset = "0x88")]
	private bool phoneGrabbed;
}
