using System;
using Il2CppDummyDll;

// Token: 0x020000E3 RID: 227
[Token(Token = "0x20000E3")]
public static class HashRandom
{
	// Token: 0x06000594 RID: 1428 RVA: 0x00003438 File Offset: 0x00001638
	[Token(Token = "0x6000594")]
	[Address(RVA = "0x3B9DD0", Offset = "0x3B91D0", VA = "0x103B9DD0")]
	public static uint Next()
	{
		return 0U;
	}

	// Token: 0x06000595 RID: 1429 RVA: 0x00003450 File Offset: 0x00001650
	[Token(Token = "0x6000595")]
	[Address(RVA = "0x3B9B70", Offset = "0x3B8F70", VA = "0x103B9B70")]
	public static int FastNext(int maxInt)
	{
		return 0;
	}

	// Token: 0x06000596 RID: 1430 RVA: 0x00003468 File Offset: 0x00001668
	[Token(Token = "0x6000596")]
	[Address(RVA = "0x3B9BD0", Offset = "0x3B8FD0", VA = "0x103B9BD0")]
	public static int Next(int maxInt)
	{
		return 0;
	}

	// Token: 0x06000597 RID: 1431 RVA: 0x00003480 File Offset: 0x00001680
	[Token(Token = "0x6000597")]
	[Address(RVA = "0x3B9CB0", Offset = "0x3B90B0", VA = "0x103B9CB0")]
	public static int Next(int minInt, int maxInt)
	{
		return 0;
	}

	// Token: 0x040005BE RID: 1470
	[Token(Token = "0x40005BE")]
	[FieldOffset(Offset = "0x0")]
	private static XXHash src;

	// Token: 0x040005BF RID: 1471
	[Token(Token = "0x40005BF")]
	[FieldOffset(Offset = "0x4")]
	private static int cnt;
}
