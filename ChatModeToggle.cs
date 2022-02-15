using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x0200045E RID: 1118
[Token(Token = "0x200045E")]
public class ChatModeToggle : MonoBehaviour, IChatModeDisplay
{
	// Token: 0x060017D1 RID: 6097 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017D1")]
	[Address(RVA = "0x41E950", Offset = "0x41DD50", VA = "0x1041E950")]
	public void Awake()
	{
	}

	// Token: 0x060017D2 RID: 6098 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017D2")]
	[Address(RVA = "0x41EB70", Offset = "0x41DF70", VA = "0x1041EB70")]
	public void OnEnable()
	{
	}

	// Token: 0x060017D3 RID: 6099 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017D3")]
	[Address(RVA = "0x41EDD0", Offset = "0x41E1D0", VA = "0x1041EDD0")]
	private void Update()
	{
	}

	// Token: 0x060017D4 RID: 6100 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017D4")]
	[Address(RVA = "0x41EAE0", Offset = "0x41DEE0", VA = "0x1041EAE0")]
	public void ClickQuickChat()
	{
	}

	// Token: 0x060017D5 RID: 6101 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017D5")]
	[Address(RVA = "0x41E990", Offset = "0x41DD90", VA = "0x1041E990")]
	public void ClickFreeChat()
	{
	}

	// Token: 0x060017D6 RID: 6102 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017D6")]
	[Address(RVA = "0x41EB80", Offset = "0x41DF80", VA = "0x1041EB80", Slot = "4")]
	public void UpdateDisplay()
	{
	}

	// Token: 0x060017D7 RID: 6103 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017D7")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public ChatModeToggle()
	{
	}

	// Token: 0x040017D3 RID: 6099
	[Token(Token = "0x40017D3")]
	[FieldOffset(Offset = "0xC")]
	public SpriteRenderer quickChatBackgroundSprite;

	// Token: 0x040017D4 RID: 6100
	[Token(Token = "0x40017D4")]
	[FieldOffset(Offset = "0x10")]
	public SpriteRenderer freeChatBackgroundSprite;

	// Token: 0x040017D5 RID: 6101
	[Token(Token = "0x40017D5")]
	[FieldOffset(Offset = "0x14")]
	public TextMeshPro infoText;

	// Token: 0x040017D6 RID: 6102
	[Token(Token = "0x40017D6")]
	[FieldOffset(Offset = "0x18")]
	public TextMeshPro warningText;

	// Token: 0x040017D7 RID: 6103
	[Token(Token = "0x40017D7")]
	[FieldOffset(Offset = "0x1C")]
	private float warningTimer;
}
