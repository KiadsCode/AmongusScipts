using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000527 RID: 1319
[Token(Token = "0x2000527")]
public class WaitForHostPopup : DestroyableSingleton<WaitForHostPopup>
{
	// Token: 0x06001BEF RID: 7151 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BEF")]
	[Address(RVA = "0x7B4D90", Offset = "0x7B4190", VA = "0x107B4D90")]
	public void Show()
	{
	}

	// Token: 0x06001BF0 RID: 7152 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BF0")]
	[Address(RVA = "0x7B4C50", Offset = "0x7B4050", VA = "0x107B4C50")]
	public void ExitGame()
	{
	}

	// Token: 0x06001BF1 RID: 7153 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BF1")]
	[Address(RVA = "0x7B4D00", Offset = "0x7B4100", VA = "0x107B4D00")]
	public void Hide()
	{
	}

	// Token: 0x06001BF2 RID: 7154 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BF2")]
	[Address(RVA = "0x7B4E80", Offset = "0x7B4280", VA = "0x107B4E80")]
	public WaitForHostPopup()
	{
	}

	// Token: 0x04001FAB RID: 8107
	[Token(Token = "0x4001FAB")]
	[FieldOffset(Offset = "0x10")]
	public GameObject Content;

	// Token: 0x04001FAC RID: 8108
	[Token(Token = "0x4001FAC")]
	[FieldOffset(Offset = "0x14")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xDD8F0", Offset = "0xDCCF0")]
	public UiElement DefaultButtonSelected;
}
