using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000465 RID: 1125
[Token(Token = "0x2000465")]
public class LanguageButton : MonoBehaviour
{
	// Token: 0x06001804 RID: 6148 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001804")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public LanguageButton()
	{
	}

	// Token: 0x04001818 RID: 6168
	[Token(Token = "0x4001818")]
	[FieldOffset(Offset = "0xC")]
	public TextMeshPro Title;

	// Token: 0x04001819 RID: 6169
	[Token(Token = "0x4001819")]
	[FieldOffset(Offset = "0x10")]
	public PassiveButton Button;

	// Token: 0x0400181A RID: 6170
	[Token(Token = "0x400181A")]
	[FieldOffset(Offset = "0x14")]
	[HideInInspector]
	public TranslatedImageSet Language;
}
