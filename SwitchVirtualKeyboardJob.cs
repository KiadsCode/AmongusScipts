using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003D4 RID: 980
[Token(Token = "0x20003D4")]
public class SwitchVirtualKeyboardJob
{
	// Token: 0x06001458 RID: 5208 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001458")]
	[Address(RVA = "0x766800", Offset = "0x765C00", VA = "0x10766800")]
	public SwitchVirtualKeyboardJob()
	{
	}

	// Token: 0x040014F6 RID: 5366
	[Token(Token = "0x40014F6")]
	[FieldOffset(Offset = "0x8")]
	public string text;

	// Token: 0x040014F7 RID: 5367
	[Token(Token = "0x40014F7")]
	[FieldOffset(Offset = "0xC")]
	public bool active;

	// Token: 0x040014F8 RID: 5368
	[Token(Token = "0x40014F8")]
	[FieldOffset(Offset = "0x10")]
	public TouchScreenKeyboard.Status status;
}
