using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;

// Token: 0x0200014A RID: 330
[Token(Token = "0x200014A")]
public class DisconnectPopup : DestroyableSingleton<DisconnectPopup>
{
	// Token: 0x0600078C RID: 1932 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600078C")]
	[Address(RVA = "0x5C7A40", Offset = "0x5C6E40", VA = "0x105C7A40")]
	public void Start()
	{
	}

	// Token: 0x0600078D RID: 1933 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600078D")]
	[Address(RVA = "0x5C7A00", Offset = "0x5C6E00", VA = "0x105C7A00")]
	public void Show()
	{
	}

	// Token: 0x0600078E RID: 1934 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600078E")]
	[Address(RVA = "0x5C7020", Offset = "0x5C6420", VA = "0x105C7020")]
	private void DoShow()
	{
	}

	// Token: 0x0600078F RID: 1935 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600078F")]
	[Address(RVA = "0x5C79B0", Offset = "0x5C6DB0", VA = "0x105C79B0")]
	public void ShowCustom(string message)
	{
	}

	// Token: 0x06000790 RID: 1936 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000790")]
	[Address(RVA = "0x499D40", Offset = "0x499140", VA = "0x10499D40")]
	public void Close()
	{
	}

	// Token: 0x06000791 RID: 1937 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000791")]
	[Address(RVA = "0x5C7CC0", Offset = "0x5C70C0", VA = "0x105C7CC0")]
	public DisconnectPopup()
	{
	}

	// Token: 0x04000792 RID: 1938
	[Token(Token = "0x4000792")]
	[FieldOffset(Offset = "0x10")]
	public TextMeshPro TextArea;

	// Token: 0x04000793 RID: 1939
	[Token(Token = "0x4000793")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Dictionary<DisconnectReasons, StringNames> ErrorMessages;

	// Token: 0x04000794 RID: 1940
	[Token(Token = "0x4000794")]
	[FieldOffset(Offset = "0x14")]
	private StringNames[] QuickChatNames;
}
