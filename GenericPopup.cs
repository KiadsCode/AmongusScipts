using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000516 RID: 1302
[Token(Token = "0x2000516")]
public class GenericPopup : MonoBehaviour
{
	// Token: 0x06001BA9 RID: 7081 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BA9")]
	[Address(RVA = "0x3B69C0", Offset = "0x3B5DC0", VA = "0x103B69C0")]
	public void Show(string text = "")
	{
	}

	// Token: 0x06001BAA RID: 7082 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BAA")]
	[Address(RVA = "0x3B6930", Offset = "0x3B5D30", VA = "0x103B6930")]
	public void Close()
	{
	}

	// Token: 0x06001BAB RID: 7083 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BAB")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public GenericPopup()
	{
	}

	// Token: 0x04001F71 RID: 8049
	[Token(Token = "0x4001F71")]
	[FieldOffset(Offset = "0xC")]
	public TextMeshPro TextAreaTMP;

	// Token: 0x04001F72 RID: 8050
	[Token(Token = "0x4001F72")]
	[FieldOffset(Offset = "0x10")]
	public bool destroyOnClose;
}
