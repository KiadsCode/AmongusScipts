using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000422 RID: 1058
[Token(Token = "0x2000422")]
public class ReactorMinigame : Minigame
{
	// Token: 0x06001640 RID: 5696 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001640")]
	[Address(RVA = "0x4F12A0", Offset = "0x4F06A0", VA = "0x104F12A0", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x06001641 RID: 5697 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001641")]
	[Address(RVA = "0x4F13A0", Offset = "0x4F07A0", VA = "0x104F13A0")]
	public void ButtonDown()
	{
	}

	// Token: 0x06001642 RID: 5698 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001642")]
	[Address(RVA = "0x4F1750", Offset = "0x4F0B50", VA = "0x104F1750")]
	public void FixedUpdate()
	{
	}

	// Token: 0x06001643 RID: 5699 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001643")]
	[Address(RVA = "0x4F1650", Offset = "0x4F0A50", VA = "0x104F1650", Slot = "5")]
	public override void Close()
	{
	}

	// Token: 0x06001644 RID: 5700 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001644")]
	[Address(RVA = "0x4F1AE0", Offset = "0x4F0EE0", VA = "0x104F1AE0")]
	public ReactorMinigame()
	{
	}

	// Token: 0x040016A2 RID: 5794
	[Token(Token = "0x40016A2")]
	[FieldOffset(Offset = "0x30")]
	private Color bad;

	// Token: 0x040016A3 RID: 5795
	[Token(Token = "0x40016A3")]
	[FieldOffset(Offset = "0x40")]
	private Color good;

	// Token: 0x040016A4 RID: 5796
	[Token(Token = "0x40016A4")]
	[FieldOffset(Offset = "0x50")]
	private ReactorSystemType reactor;

	// Token: 0x040016A5 RID: 5797
	[Token(Token = "0x40016A5")]
	[FieldOffset(Offset = "0x54")]
	public TextMeshPro statusText;

	// Token: 0x040016A6 RID: 5798
	[Token(Token = "0x40016A6")]
	[FieldOffset(Offset = "0x58")]
	public SpriteRenderer hand;

	// Token: 0x040016A7 RID: 5799
	[Token(Token = "0x40016A7")]
	[FieldOffset(Offset = "0x5C")]
	private FloatRange YSweep;

	// Token: 0x040016A8 RID: 5800
	[Token(Token = "0x40016A8")]
	[FieldOffset(Offset = "0x60")]
	public SpriteRenderer sweeper;

	// Token: 0x040016A9 RID: 5801
	[Token(Token = "0x40016A9")]
	[FieldOffset(Offset = "0x64")]
	public AudioClip HandSound;

	// Token: 0x040016AA RID: 5802
	[Token(Token = "0x40016AA")]
	[FieldOffset(Offset = "0x68")]
	private bool isButtonDown;
}
