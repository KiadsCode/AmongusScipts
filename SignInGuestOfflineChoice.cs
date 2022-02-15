using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x0200003B RID: 59
[Token(Token = "0x200003B")]
public class SignInGuestOfflineChoice : MonoBehaviour
{
	// Token: 0x060001DA RID: 474 RVA: 0x00002538 File Offset: 0x00000738
	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x499D10", Offset = "0x499110", VA = "0x10499D10")]
	public bool IsOpen()
	{
		return default(bool);
	}

	// Token: 0x060001DB RID: 475 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x499D70", Offset = "0x499170", VA = "0x10499D70")]
	public void Open()
	{
	}

	// Token: 0x060001DC RID: 476 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x499D40", Offset = "0x499140", VA = "0x10499D40")]
	public void OnClose()
	{
	}

	// Token: 0x060001DD RID: 477 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public SignInGuestOfflineChoice()
	{
	}

	// Token: 0x04000156 RID: 342
	[Token(Token = "0x4000156")]
	[FieldOffset(Offset = "0xC")]
	public PassiveButton signInButton;

	// Token: 0x04000157 RID: 343
	[Token(Token = "0x4000157")]
	[FieldOffset(Offset = "0x10")]
	public PassiveButton continueGuestButton;

	// Token: 0x04000158 RID: 344
	[Token(Token = "0x4000158")]
	[FieldOffset(Offset = "0x14")]
	public PassiveButton continueOfflineButton;

	// Token: 0x04000159 RID: 345
	[Token(Token = "0x4000159")]
	[FieldOffset(Offset = "0x18")]
	public TextMeshPro signInButtonText;

	// Token: 0x0400015A RID: 346
	[Token(Token = "0x400015A")]
	[FieldOffset(Offset = "0x1C")]
	public TextMeshPro mainTextText;
}
