using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020002B4 RID: 692
[Token(Token = "0x20002B4")]
public class ChatLanguageButton : PoolableBehavior
{
	// Token: 0x06000F62 RID: 3938 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F62")]
	[Address(RVA = "0x833AC0", Offset = "0x832EC0", VA = "0x10833AC0")]
	public void SetSelected(bool selected)
	{
	}

	// Token: 0x06000F63 RID: 3939 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F63")]
	[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00", Slot = "4")]
	public override void Reset()
	{
	}

	// Token: 0x06000F64 RID: 3940 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F64")]
	[Address(RVA = "0x3AC2A0", Offset = "0x3AB6A0", VA = "0x103AC2A0")]
	public ChatLanguageButton()
	{
	}

	// Token: 0x04000F43 RID: 3907
	[Token(Token = "0x4000F43")]
	[FieldOffset(Offset = "0x14")]
	public TextMeshPro Text;

	// Token: 0x04000F44 RID: 3908
	[Token(Token = "0x4000F44")]
	[FieldOffset(Offset = "0x18")]
	public PassiveButton Button;

	// Token: 0x04000F45 RID: 3909
	[Token(Token = "0x4000F45")]
	[FieldOffset(Offset = "0x1C")]
	public SpriteRenderer Background;
}
