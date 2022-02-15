using System;
using Il2CppDummyDll;

// Token: 0x02000105 RID: 261
[Token(Token = "0x2000105")]
[Serializable]
public class KerningPair
{
	// Token: 0x0600064C RID: 1612 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600064C")]
	[Address(RVA = "0x6D3B50", Offset = "0x6D2F50", VA = "0x106D3B50")]
	public KerningPair()
	{
	}

	// Token: 0x04000646 RID: 1606
	[Token(Token = "0x4000646")]
	[FieldOffset(Offset = "0x8")]
	public char First;

	// Token: 0x04000647 RID: 1607
	[Token(Token = "0x4000647")]
	[FieldOffset(Offset = "0xA")]
	public char Second;

	// Token: 0x04000648 RID: 1608
	[Token(Token = "0x4000648")]
	[FieldOffset(Offset = "0xC")]
	public int Pixels;
}
