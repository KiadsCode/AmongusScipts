using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020000A8 RID: 168
[Token(Token = "0x20000A8")]
public class ShowerMinigame : Minigame
{
	// Token: 0x0600040C RID: 1036 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600040C")]
	[Address(RVA = "0x499780", Offset = "0x498B80", VA = "0x10499780", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x0600040D RID: 1037 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600040D")]
	[Address(RVA = "0x499B60", Offset = "0x498F60", VA = "0x10499B60")]
	public void Update()
	{
	}

	// Token: 0x0600040E RID: 1038 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600040E")]
	[Address(RVA = "0x499A40", Offset = "0x498E40", VA = "0x10499A40", Slot = "5")]
	public override void Close()
	{
	}

	// Token: 0x0600040F RID: 1039 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600040F")]
	[Address(RVA = "0x499CF0", Offset = "0x4990F0", VA = "0x10499CF0")]
	public ShowerMinigame()
	{
	}

	// Token: 0x04000463 RID: 1123
	[Token(Token = "0x4000463")]
	[FieldOffset(Offset = "0x30")]
	public VerticalGauge Gauge;

	// Token: 0x04000464 RID: 1124
	[Token(Token = "0x4000464")]
	[FieldOffset(Offset = "0x34")]
	public TextMeshPro PercentText;

	// Token: 0x04000465 RID: 1125
	[Token(Token = "0x4000465")]
	[FieldOffset(Offset = "0x38")]
	private float timer;

	// Token: 0x04000466 RID: 1126
	[Token(Token = "0x4000466")]
	[FieldOffset(Offset = "0x3C")]
	public float MaxTime;

	// Token: 0x04000467 RID: 1127
	[Token(Token = "0x4000467")]
	[FieldOffset(Offset = "0x40")]
	public AudioClip washSound;
}
