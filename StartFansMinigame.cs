using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020000A0 RID: 160
[Token(Token = "0x20000A0")]
public class StartFansMinigame : Minigame
{
	// Token: 0x060003E8 RID: 1000 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003E8")]
	[Address(RVA = "0x756D70", Offset = "0x756170", VA = "0x10756D70", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x060003E9 RID: 1001 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003E9")]
	[Address(RVA = "0x7570D0", Offset = "0x7564D0", VA = "0x107570D0", Slot = "5")]
	public override void Close()
	{
	}

	// Token: 0x060003EA RID: 1002 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003EA")]
	[Address(RVA = "0x757150", Offset = "0x756550", VA = "0x10757150")]
	public void RevealCode()
	{
	}

	// Token: 0x060003EB RID: 1003 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003EB")]
	[Address(RVA = "0x757380", Offset = "0x756780", VA = "0x10757380")]
	public void RotateImage(SpriteRenderer target)
	{
	}

	// Token: 0x060003EC RID: 1004 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003EC")]
	[Address(RVA = "0x3AC2A0", Offset = "0x3AB6A0", VA = "0x103AC2A0")]
	public StartFansMinigame()
	{
	}

	// Token: 0x0400040A RID: 1034
	[Token(Token = "0x400040A")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshPro ActionText;

	// Token: 0x0400040B RID: 1035
	[Token(Token = "0x400040B")]
	[FieldOffset(Offset = "0x34")]
	public SpriteRenderer[] CodeIcons;

	// Token: 0x0400040C RID: 1036
	[Token(Token = "0x400040C")]
	[FieldOffset(Offset = "0x38")]
	public Sprite[] IconSprites;

	// Token: 0x0400040D RID: 1037
	[Token(Token = "0x400040D")]
	[FieldOffset(Offset = "0x3C")]
	public AudioClip revealSound;

	// Token: 0x0400040E RID: 1038
	[Token(Token = "0x400040E")]
	[FieldOffset(Offset = "0x40")]
	public AudioClip cycleSound;

	// Token: 0x0400040F RID: 1039
	[Token(Token = "0x400040F")]
	[FieldOffset(Offset = "0x44")]
	public AudioClip completeSound;

	// Token: 0x04000410 RID: 1040
	[Token(Token = "0x4000410")]
	[FieldOffset(Offset = "0x48")]
	public PassiveButton mainCodeButton;

	// Token: 0x04000411 RID: 1041
	[Token(Token = "0x4000411")]
	[FieldOffset(Offset = "0x4C")]
	public PassiveButton closeButton;

	// Token: 0x04000412 RID: 1042
	[Token(Token = "0x4000412")]
	[FieldOffset(Offset = "0x50")]
	public List<UiElement> codeButtons;

	// Token: 0x04000413 RID: 1043
	[Token(Token = "0x4000413")]
	[FieldOffset(Offset = "0x54")]
	public ControllerButtonBehavior enterCodeHotkey;

	// Token: 0x020000A1 RID: 161
	[Token(Token = "0x20000A1")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass10_0
	{
		// Token: 0x060003ED RID: 1005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass10_0()
		{
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x370D00", Offset = "0x370100", VA = "0x10370D00")]
		internal void <Begin>b__0()
		{
		}

		// Token: 0x04000414 RID: 1044
		[Token(Token = "0x4000414")]
		[FieldOffset(Offset = "0x8")]
		public SpriteRenderer target;

		// Token: 0x04000415 RID: 1045
		[Token(Token = "0x4000415")]
		[FieldOffset(Offset = "0xC")]
		public StartFansMinigame <>4__this;
	}
}
