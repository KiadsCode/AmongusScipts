using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x020003B4 RID: 948
[Token(Token = "0x20003B4")]
public class QuickChatSentenceVariantSet
{
	// Token: 0x060013F4 RID: 5108 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013F4")]
	[Address(RVA = "0x4EAB00", Offset = "0x4E9F00", VA = "0x104EAB00")]
	public QuickChatSentenceVariant GetMatchingVariant(List<StringNames> currentKeys)
	{
		return null;
	}

	// Token: 0x060013F5 RID: 5109 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013F5")]
	[Address(RVA = "0x4EA8F0", Offset = "0x4E9CF0", VA = "0x104EA8F0")]
	public void AddVariant(StringNames[] keys, string value, bool hasAny)
	{
	}

	// Token: 0x060013F6 RID: 5110 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013F6")]
	[Address(RVA = "0x4EAC90", Offset = "0x4EA090", VA = "0x104EAC90")]
	public QuickChatSentenceVariantSet()
	{
	}

	// Token: 0x0400145D RID: 5213
	[Token(Token = "0x400145D")]
	[FieldOffset(Offset = "0x8")]
	public StringNames baseToken;

	// Token: 0x0400145E RID: 5214
	[Token(Token = "0x400145E")]
	[FieldOffset(Offset = "0xC")]
	private List<QuickChatSentenceVariant> variants;
}
