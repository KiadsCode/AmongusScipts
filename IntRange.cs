using System;
using Il2CppDummyDll;

// Token: 0x020000F6 RID: 246
[Token(Token = "0x20000F6")]
[Serializable]
public class IntRange
{
	// Token: 0x060005E3 RID: 1507 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005E3")]
	[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
	public IntRange()
	{
	}

	// Token: 0x060005E4 RID: 1508 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005E4")]
	[Address(RVA = "0x399E90", Offset = "0x399290", VA = "0x10399E90")]
	public IntRange(int min, int max)
	{
	}

	// Token: 0x060005E5 RID: 1509 RVA: 0x00003690 File Offset: 0x00001890
	[Token(Token = "0x60005E5")]
	[Address(RVA = "0x3FAB60", Offset = "0x3F9F60", VA = "0x103FAB60")]
	public int Next()
	{
		return 0;
	}

	// Token: 0x060005E6 RID: 1510 RVA: 0x000036A8 File Offset: 0x000018A8
	[Token(Token = "0x60005E6")]
	[Address(RVA = "0x3FAA30", Offset = "0x3F9E30", VA = "0x103FAA30")]
	public bool Contains(int value)
	{
		return default(bool);
	}

	// Token: 0x060005E7 RID: 1511 RVA: 0x000036C0 File Offset: 0x000018C0
	[Token(Token = "0x60005E7")]
	[Address(RVA = "0x3FAB90", Offset = "0x3F9F90", VA = "0x103FAB90")]
	public static int Next(int max)
	{
		return 0;
	}

	// Token: 0x060005E8 RID: 1512 RVA: 0x000036D8 File Offset: 0x000018D8
	[Token(Token = "0x60005E8")]
	[Address(RVA = "0x3FAB80", Offset = "0x3F9F80", VA = "0x103FAB80")]
	internal static int Next(int min, int max)
	{
		return 0;
	}

	// Token: 0x060005E9 RID: 1513 RVA: 0x000036F0 File Offset: 0x000018F0
	[Token(Token = "0x60005E9")]
	[Address(RVA = "0x3FAB40", Offset = "0x3F9F40", VA = "0x103FAB40")]
	internal static byte NextByte(byte min, byte max)
	{
		return 0;
	}

	// Token: 0x060005EA RID: 1514 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005EA")]
	[Address(RVA = "0x3FAAE0", Offset = "0x3F9EE0", VA = "0x103FAAE0")]
	public static void FillRandom(sbyte min, sbyte max, sbyte[] array)
	{
	}

	// Token: 0x060005EB RID: 1515 RVA: 0x00003708 File Offset: 0x00001908
	[Token(Token = "0x60005EB")]
	[Address(RVA = "0x3FABC0", Offset = "0x3F9FC0", VA = "0x103FABC0")]
	public static int RandomSign()
	{
		return 0;
	}

	// Token: 0x060005EC RID: 1516 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005EC")]
	[Address(RVA = "0x3FAA50", Offset = "0x3F9E50", VA = "0x103FAA50")]
	public static void FillRandomRange(sbyte[] array)
	{
	}

	// Token: 0x040005FE RID: 1534
	[Token(Token = "0x40005FE")]
	[FieldOffset(Offset = "0x8")]
	public int min;

	// Token: 0x040005FF RID: 1535
	[Token(Token = "0x40005FF")]
	[FieldOffset(Offset = "0xC")]
	public int max;
}
