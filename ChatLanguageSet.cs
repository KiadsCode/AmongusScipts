using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000268 RID: 616
[Token(Token = "0x2000268")]
public class ChatLanguageSet
{
	// Token: 0x06000DC9 RID: 3529 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DC9")]
	[Address(RVA = "0x8349A0", Offset = "0x833DA0", VA = "0x108349A0")]
	public ChatLanguageSet()
	{
	}

	// Token: 0x06000DCA RID: 3530 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DCA")]
	[Address(RVA = "0x834380", Offset = "0x833780", VA = "0x10834380")]
	public void Load()
	{
	}

	// Token: 0x06000DCB RID: 3531 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DCB")]
	[Address(RVA = "0x834630", Offset = "0x833A30", VA = "0x10834630")]
	public void Save()
	{
	}

	// Token: 0x06000DCC RID: 3532 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DCC")]
	[Address(RVA = "0x8341F0", Offset = "0x8335F0", VA = "0x108341F0")]
	public string GetString(uint flag)
	{
		return null;
	}

	// Token: 0x04000DBF RID: 3519
	[Token(Token = "0x4000DBF")]
	[FieldOffset(Offset = "0x0")]
	public static readonly ChatLanguageSet Instance;

	// Token: 0x04000DC0 RID: 3520
	[Token(Token = "0x4000DC0")]
	[FieldOffset(Offset = "0x8")]
	public readonly Dictionary<string, uint> Languages;
}
