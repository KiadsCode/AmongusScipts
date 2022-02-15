using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020001CD RID: 461
[Token(Token = "0x20001CD")]
public class ReportConfirmScreen : MonoBehaviour
{
	// Token: 0x06000A69 RID: 2665 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A69")]
	[Address(RVA = "0x4F5B50", Offset = "0x4F4F50", VA = "0x104F5B50")]
	public void Show(string playerName, int colorId)
	{
	}

	// Token: 0x06000A6A RID: 2666 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A6A")]
	[Address(RVA = "0x499D40", Offset = "0x499140", VA = "0x10499D40")]
	public void Hide()
	{
	}

	// Token: 0x06000A6B RID: 2667 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A6B")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public ReportConfirmScreen()
	{
	}

	// Token: 0x04000A8C RID: 2700
	[Token(Token = "0x4000A8C")]
	[FieldOffset(Offset = "0xC")]
	public TextMeshPro NameText;

	// Token: 0x04000A8D RID: 2701
	[Token(Token = "0x4000A8D")]
	[FieldOffset(Offset = "0x10")]
	public SpriteRenderer PlayerIcon;
}
