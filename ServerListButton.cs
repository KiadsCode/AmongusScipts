using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020002FA RID: 762
[Token(Token = "0x20002FA")]
public class ServerListButton : PoolableBehavior
{
	// Token: 0x060010BD RID: 4285 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010BD")]
	[Address(RVA = "0x591120", Offset = "0x590520", VA = "0x10591120")]
	public void SetSelected(bool selected)
	{
	}

	// Token: 0x060010BE RID: 4286 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010BE")]
	[Address(RVA = "0x5911B0", Offset = "0x5905B0", VA = "0x105911B0")]
	public void SetTextTranslationId(StringNames id, string defaultStr)
	{
	}

	// Token: 0x060010BF RID: 4287 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010BF")]
	[Address(RVA = "0x3AC2A0", Offset = "0x3AB6A0", VA = "0x103AC2A0")]
	public ServerListButton()
	{
	}

	// Token: 0x04001072 RID: 4210
	[Token(Token = "0x4001072")]
	[FieldOffset(Offset = "0x14")]
	public TextMeshPro Text;

	// Token: 0x04001073 RID: 4211
	[Token(Token = "0x4001073")]
	[FieldOffset(Offset = "0x18")]
	public PassiveButton Button;

	// Token: 0x04001074 RID: 4212
	[Token(Token = "0x4001074")]
	[FieldOffset(Offset = "0x1C")]
	public SpriteRenderer Background;

	// Token: 0x04001075 RID: 4213
	[Token(Token = "0x4001075")]
	[FieldOffset(Offset = "0x20")]
	public TextTranslatorTMP textTranslator;
}
