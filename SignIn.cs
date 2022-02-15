using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200003A RID: 58
[Token(Token = "0x200003A")]
public class SignIn : MonoBehaviour
{
	// Token: 0x060001D7 RID: 471 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x49A8C0", Offset = "0x499CC0", VA = "0x1049A8C0")]
	public void Close()
	{
	}

	// Token: 0x060001D8 RID: 472 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x49A910", Offset = "0x499D10", VA = "0x1049A910")]
	public void Open()
	{
	}

	// Token: 0x060001D9 RID: 473 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public SignIn()
	{
	}

	// Token: 0x04000153 RID: 339
	[Token(Token = "0x4000153")]
	[FieldOffset(Offset = "0xC")]
	[SerializeField]
	private GameObject mainScreen;

	// Token: 0x04000154 RID: 340
	[Token(Token = "0x4000154")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private GameObject signInScreen;

	// Token: 0x04000155 RID: 341
	[Token(Token = "0x4000155")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	private GameObject createAccountScreen;
}
