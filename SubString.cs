using System;
using Il2CppDummyDll;

// Token: 0x020000E7 RID: 231
[Token(Token = "0x20000E7")]
public struct SubString
{
	// Token: 0x060005A7 RID: 1447 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005A7")]
	[Address(RVA = "0x7645E0", Offset = "0x7639E0", VA = "0x107645E0")]
	public SubString(string source, int start, int length)
	{
	}

	// Token: 0x060005A8 RID: 1448 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005A8")]
	[Address(RVA = "0x7645B0", Offset = "0x7639B0", VA = "0x107645B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x060005A9 RID: 1449 RVA: 0x000034C8 File Offset: 0x000016C8
	[Token(Token = "0x60005A9")]
	[Address(RVA = "0x764420", Offset = "0x763820", VA = "0x10764420")]
	public int GetKvpValue()
	{
		return 0;
	}

	// Token: 0x060005AA RID: 1450 RVA: 0x000034E0 File Offset: 0x000016E0
	[Token(Token = "0x60005AA")]
	[Address(RVA = "0x764530", Offset = "0x763930", VA = "0x10764530")]
	public int ToInt()
	{
		return 0;
	}

	// Token: 0x060005AB RID: 1451 RVA: 0x000034F8 File Offset: 0x000016F8
	[Token(Token = "0x60005AB")]
	[Address(RVA = "0x7644C0", Offset = "0x7638C0", VA = "0x107644C0")]
	public bool StartsWith(string v)
	{
		return default(bool);
	}

	// Token: 0x040005C3 RID: 1475
	[Token(Token = "0x40005C3")]
	[FieldOffset(Offset = "0x0")]
	public readonly int Start;

	// Token: 0x040005C4 RID: 1476
	[Token(Token = "0x40005C4")]
	[FieldOffset(Offset = "0x4")]
	public readonly int Length;

	// Token: 0x040005C5 RID: 1477
	[Token(Token = "0x40005C5")]
	[FieldOffset(Offset = "0x8")]
	public readonly string Source;
}
