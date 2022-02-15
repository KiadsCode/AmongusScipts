using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x0200034A RID: 842
[Token(Token = "0x200034A")]
public class TempMinigame : Minigame
{
	// Token: 0x06001263 RID: 4707 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001263")]
	[Address(RVA = "0x4AA040", Offset = "0x4A9440", VA = "0x104AA040", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x06001264 RID: 4708 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001264")]
	[Address(RVA = "0x4AA0D0", Offset = "0x4A94D0", VA = "0x104AA0D0")]
	public void ChangeNumber(int dir)
	{
	}

	// Token: 0x06001265 RID: 4709 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001265")]
	[Address(RVA = "0x4AA200", Offset = "0x4A9600", VA = "0x104AA200")]
	private void Update()
	{
	}

	// Token: 0x06001266 RID: 4710 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001266")]
	[Address(RVA = "0x3AC2A0", Offset = "0x3AB6A0", VA = "0x103AC2A0")]
	public TempMinigame()
	{
	}

	// Token: 0x04001287 RID: 4743
	[Token(Token = "0x4001287")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshPro LogText;

	// Token: 0x04001288 RID: 4744
	[Token(Token = "0x4001288")]
	[FieldOffset(Offset = "0x34")]
	public TextMeshPro ReadingText;

	// Token: 0x04001289 RID: 4745
	[Token(Token = "0x4001289")]
	[FieldOffset(Offset = "0x38")]
	public IntRange LogRange;

	// Token: 0x0400128A RID: 4746
	[Token(Token = "0x400128A")]
	[FieldOffset(Offset = "0x3C")]
	public IntRange ReadingRange;

	// Token: 0x0400128B RID: 4747
	[Token(Token = "0x400128B")]
	[FieldOffset(Offset = "0x40")]
	private int logValue;

	// Token: 0x0400128C RID: 4748
	[Token(Token = "0x400128C")]
	[FieldOffset(Offset = "0x44")]
	private int readingValue;

	// Token: 0x0400128D RID: 4749
	[Token(Token = "0x400128D")]
	[FieldOffset(Offset = "0x48")]
	public AudioClip ButtonSound;

	// Token: 0x0400128E RID: 4750
	[Token(Token = "0x400128E")]
	[FieldOffset(Offset = "0x4C")]
	private float deltaSinceLastChangeNumber;

	// Token: 0x0400128F RID: 4751
	[Token(Token = "0x400128F")]
	public const float CHANGE_NUMBER_UPDATE_THRESHOLD_MIN = 0.05f;
}
