using System;
using Il2CppDummyDll;
using InnerNet;
using TMPro;
using UnityEngine;

// Token: 0x020001CE RID: 462
[Token(Token = "0x20001CE")]
public class ReportReasonScreen : MonoBehaviour
{
	// Token: 0x06000A6C RID: 2668 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A6C")]
	[Address(RVA = "0x4F5CE0", Offset = "0x4F50E0", VA = "0x104F5CE0")]
	public void Show(string playerName, int colorId)
	{
	}

	// Token: 0x06000A6D RID: 2669 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A6D")]
	[Address(RVA = "0x4F5BF0", Offset = "0x4F4FF0", VA = "0x104F5BF0")]
	public void SelectReason(int reason)
	{
	}

	// Token: 0x06000A6E RID: 2670 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A6E")]
	[Address(RVA = "0x4F5F20", Offset = "0x4F5320", VA = "0x104F5F20")]
	public void Submit()
	{
	}

	// Token: 0x06000A6F RID: 2671 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A6F")]
	[Address(RVA = "0x499D40", Offset = "0x499140", VA = "0x10499D40")]
	public void Hide()
	{
	}

	// Token: 0x06000A70 RID: 2672 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A70")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public ReportReasonScreen()
	{
	}

	// Token: 0x04000A8E RID: 2702
	[Token(Token = "0x4000A8E")]
	[FieldOffset(Offset = "0xC")]
	public BanMenu Parent;

	// Token: 0x04000A8F RID: 2703
	[Token(Token = "0x4000A8F")]
	[FieldOffset(Offset = "0x10")]
	public ButtonRolloverHandler[] Buttons;

	// Token: 0x04000A90 RID: 2704
	[Token(Token = "0x4000A90")]
	[FieldOffset(Offset = "0x14")]
	public TextMeshPro NameText;

	// Token: 0x04000A91 RID: 2705
	[Token(Token = "0x4000A91")]
	[FieldOffset(Offset = "0x18")]
	public SpriteRenderer PlayerIcon;

	// Token: 0x04000A92 RID: 2706
	[Token(Token = "0x4000A92")]
	[FieldOffset(Offset = "0x1C")]
	private ReportReasons? currentReason;

	// Token: 0x04000A93 RID: 2707
	[Token(Token = "0x4000A93")]
	[FieldOffset(Offset = "0x24")]
	public ReportConfirmScreen ConfirmScreen;

	// Token: 0x04000A94 RID: 2708
	[Token(Token = "0x4000A94")]
	[FieldOffset(Offset = "0x28")]
	private string playerName;

	// Token: 0x04000A95 RID: 2709
	[Token(Token = "0x4000A95")]
	[FieldOffset(Offset = "0x2C")]
	private int colorId;
}
