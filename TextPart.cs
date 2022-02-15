using System;
using Il2CppDummyDll;

// Token: 0x020002A5 RID: 677
[Token(Token = "0x20002A5")]
internal class TextPart : ITextPart
{
	// Token: 0x06000EFB RID: 3835 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EFB")]
	[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
	public TextPart(string text)
	{
	}

	// Token: 0x06000EFC RID: 3836 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EFC")]
	[Address(RVA = "0x273EB0", Offset = "0x2732B0", VA = "0x10273EB0", Slot = "4")]
	public string GetText()
	{
		return null;
	}

	// Token: 0x04000F03 RID: 3843
	[Token(Token = "0x4000F03")]
	[FieldOffset(Offset = "0x8")]
	private string m_text;
}
