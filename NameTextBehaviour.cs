using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000230 RID: 560
[Token(Token = "0x2000230")]
public class NameTextBehaviour : MonoBehaviour
{
	// Token: 0x06000C89 RID: 3209 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C89")]
	[Address(RVA = "0x775CC0", Offset = "0x7750C0", VA = "0x10775CC0")]
	public void Start()
	{
	}

	// Token: 0x06000C8A RID: 3210 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C8A")]
	[Address(RVA = "0x775DF0", Offset = "0x7751F0", VA = "0x10775DF0")]
	public void UpdateName()
	{
	}

	// Token: 0x06000C8B RID: 3211 RVA: 0x00004F50 File Offset: 0x00003150
	[Token(Token = "0x6000C8B")]
	[Address(RVA = "0x775A70", Offset = "0x774E70", VA = "0x10775A70")]
	public static bool IsValidName(string text)
	{
		return default(bool);
	}

	// Token: 0x06000C8C RID: 3212 RVA: 0x00004F68 File Offset: 0x00003168
	[Token(Token = "0x6000C8C")]
	[Address(RVA = "0x775BE0", Offset = "0x774FE0", VA = "0x10775BE0")]
	public bool ShakeIfInvalid()
	{
		return default(bool);
	}

	// Token: 0x06000C8D RID: 3213 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C8D")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public NameTextBehaviour()
	{
	}

	// Token: 0x04000C80 RID: 3200
	[Token(Token = "0x4000C80")]
	[FieldOffset(Offset = "0x0")]
	public static readonly HashSet<char> SymbolChars;

	// Token: 0x04000C81 RID: 3201
	[Token(Token = "0x4000C81")]
	[FieldOffset(Offset = "0x4")]
	public static NameTextBehaviour Instance;

	// Token: 0x04000C82 RID: 3202
	[Token(Token = "0x4000C82")]
	[FieldOffset(Offset = "0xC")]
	public TextBoxTMP nameSource;
}
