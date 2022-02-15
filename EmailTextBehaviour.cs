using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001ED RID: 493
[Token(Token = "0x20001ED")]
public class EmailTextBehaviour : MonoBehaviour
{
	// Token: 0x06000B04 RID: 2820 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B04")]
	[Address(RVA = "0x476C60", Offset = "0x476060", VA = "0x10476C60")]
	public string GetEmailValidEmail()
	{
		return null;
	}

	// Token: 0x06000B05 RID: 2821 RVA: 0x00004998 File Offset: 0x00002B98
	[Token(Token = "0x6000B05")]
	[Address(RVA = "0x476CB0", Offset = "0x4760B0", VA = "0x10476CB0")]
	private bool IsValidEmail(string text)
	{
		return default(bool);
	}

	// Token: 0x06000B06 RID: 2822 RVA: 0x000049B0 File Offset: 0x00002BB0
	[Token(Token = "0x6000B06")]
	[Address(RVA = "0x476EB0", Offset = "0x4762B0", VA = "0x10476EB0")]
	public bool ShakeIfInvalid()
	{
		return default(bool);
	}

	// Token: 0x06000B07 RID: 2823 RVA: 0x000049C8 File Offset: 0x00002BC8
	[Token(Token = "0x6000B07")]
	[Address(RVA = "0x476DD0", Offset = "0x4761D0", VA = "0x10476DD0")]
	public bool ShakeIfDoesntMatch(string email1, string email2)
	{
		return default(bool);
	}

	// Token: 0x06000B08 RID: 2824 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B08")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public EmailTextBehaviour()
	{
	}

	// Token: 0x04000B10 RID: 2832
	[Token(Token = "0x4000B10")]
	[FieldOffset(Offset = "0x0")]
	public static readonly HashSet<char> SymbolChars;

	// Token: 0x04000B11 RID: 2833
	[Token(Token = "0x4000B11")]
	[FieldOffset(Offset = "0xC")]
	public TextBoxTMP nameSource;
}
