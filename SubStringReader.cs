using System;
using Il2CppDummyDll;

// Token: 0x020000E6 RID: 230
[Token(Token = "0x20000E6")]
public class SubStringReader
{
	// Token: 0x060005A5 RID: 1445 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005A5")]
	[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
	public SubStringReader(string source)
	{
	}

	// Token: 0x060005A6 RID: 1446 RVA: 0x000034B0 File Offset: 0x000016B0
	[Token(Token = "0x60005A6")]
	[Address(RVA = "0x764340", Offset = "0x763740", VA = "0x10764340")]
	public SubString ReadLine()
	{
		return default(SubString);
	}

	// Token: 0x040005C1 RID: 1473
	[Token(Token = "0x40005C1")]
	[FieldOffset(Offset = "0x8")]
	private readonly string Source;

	// Token: 0x040005C2 RID: 1474
	[Token(Token = "0x40005C2")]
	[FieldOffset(Offset = "0xC")]
	private int Position;
}
