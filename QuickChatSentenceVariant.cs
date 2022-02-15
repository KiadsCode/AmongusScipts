using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x020003B5 RID: 949
[Token(Token = "0x20003B5")]
public class QuickChatSentenceVariant
{
	// Token: 0x060013F7 RID: 5111 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013F7")]
	[Address(RVA = "0x4EADF0", Offset = "0x4EA1F0", VA = "0x104EADF0")]
	public QuickChatSentenceVariant(StringNames[] Keys, string Value)
	{
	}

	// Token: 0x060013F8 RID: 5112 RVA: 0x00006870 File Offset: 0x00004A70
	[Token(Token = "0x60013F8")]
	[Address(RVA = "0x4EACF0", Offset = "0x4EA0F0", VA = "0x104EACF0")]
	public bool ShouldUse(List<StringNames> currentKeys)
	{
		return default(bool);
	}

	// Token: 0x0400145F RID: 5215
	[Token(Token = "0x400145F")]
	[FieldOffset(Offset = "0x8")]
	private StringNames[] requiredKeysInSlots;

	// Token: 0x04001460 RID: 5216
	[Token(Token = "0x4001460")]
	[FieldOffset(Offset = "0xC")]
	public string value;
}
