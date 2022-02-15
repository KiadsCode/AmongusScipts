using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x0200045D RID: 1117
[Token(Token = "0x200045D")]
public class ChatModeCycle : MonoBehaviour, IChatModeDisplay
{
	// Token: 0x060017CC RID: 6092 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017CC")]
	[Address(RVA = "0x41E4F0", Offset = "0x41D8F0", VA = "0x1041E4F0")]
	public void Awake()
	{
	}

	// Token: 0x060017CD RID: 6093 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017CD")]
	[Address(RVA = "0x41E620", Offset = "0x41DA20", VA = "0x1041E620")]
	public void OnEnable()
	{
	}

	// Token: 0x060017CE RID: 6094 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017CE")]
	[Address(RVA = "0x41E630", Offset = "0x41DA30", VA = "0x1041E630", Slot = "4")]
	public void UpdateDisplay()
	{
	}

	// Token: 0x060017CF RID: 6095 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017CF")]
	[Address(RVA = "0x41E530", Offset = "0x41D930", VA = "0x1041E530")]
	public void CycleChatMode()
	{
	}

	// Token: 0x060017D0 RID: 6096 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017D0")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public ChatModeCycle()
	{
	}

	// Token: 0x040017D0 RID: 6096
	[Token(Token = "0x40017D0")]
	[FieldOffset(Offset = "0xC")]
	public CycleButtonBehaviour chatMode;

	// Token: 0x040017D1 RID: 6097
	[Token(Token = "0x40017D1")]
	[FieldOffset(Offset = "0x10")]
	public TextMeshPro chatModeText;

	// Token: 0x040017D2 RID: 6098
	[Token(Token = "0x40017D2")]
	[FieldOffset(Offset = "0x14")]
	public SpriteRenderer backgroundSprite;
}
