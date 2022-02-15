using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000030 RID: 48
[Token(Token = "0x2000030")]
public class PermissionsRequest : MonoBehaviour
{
	// Token: 0x0600019F RID: 415 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600019F")]
	[Address(RVA = "0x499D70", Offset = "0x499170", VA = "0x10499D70")]
	public void Show()
	{
	}

	// Token: 0x060001A0 RID: 416 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x6599A0", Offset = "0x658DA0", VA = "0x106599A0")]
	public void Close()
	{
	}

	// Token: 0x060001A1 RID: 417 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x6599F0", Offset = "0x658DF0", VA = "0x106599F0")]
	public void ContinueWithout()
	{
	}

	// Token: 0x060001A2 RID: 418 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x659A80", Offset = "0x658E80", VA = "0x10659A80")]
	public void SendEmail()
	{
	}

	// Token: 0x060001A3 RID: 419 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public PermissionsRequest()
	{
	}

	// Token: 0x0400012C RID: 300
	[Token(Token = "0x400012C")]
	[FieldOffset(Offset = "0xC")]
	public EmailTextBehaviour emailText;

	// Token: 0x0400012D RID: 301
	[Token(Token = "0x400012D")]
	[FieldOffset(Offset = "0x10")]
	public EmailTextBehaviour emailConfirmText;
}
