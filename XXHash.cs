using System;
using Il2CppDummyDll;

// Token: 0x02000114 RID: 276
[Token(Token = "0x2000114")]
public class XXHash
{
	// Token: 0x06000678 RID: 1656 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000678")]
	[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
	public XXHash(int seed)
	{
	}

	// Token: 0x06000679 RID: 1657 RVA: 0x00003AF8 File Offset: 0x00001CF8
	[Token(Token = "0x6000679")]
	[Address(RVA = "0x3CE140", Offset = "0x3CD540", VA = "0x103CE140")]
	public uint GetHash(byte[] buf)
	{
		return 0U;
	}

	// Token: 0x0600067A RID: 1658 RVA: 0x00003B10 File Offset: 0x00001D10
	[Token(Token = "0x600067A")]
	[Address(RVA = "0x3CDFE0", Offset = "0x3CD3E0", VA = "0x103CDFE0")]
	public uint GetHash(params uint[] buf)
	{
		return 0U;
	}

	// Token: 0x0600067B RID: 1659 RVA: 0x00003B28 File Offset: 0x00001D28
	[Token(Token = "0x600067B")]
	[Address(RVA = "0x3CDFE0", Offset = "0x3CD3E0", VA = "0x103CDFE0")]
	public uint GetHash(params int[] buf)
	{
		return 0U;
	}

	// Token: 0x0600067C RID: 1660 RVA: 0x00003B40 File Offset: 0x00001D40
	[Token(Token = "0x600067C")]
	[Address(RVA = "0x3CE410", Offset = "0x3CD810", VA = "0x103CE410")]
	public uint GetHash(int buf)
	{
		return 0U;
	}

	// Token: 0x0600067D RID: 1661 RVA: 0x00003B58 File Offset: 0x00001D58
	[Token(Token = "0x600067D")]
	[Address(RVA = "0x3CDF70", Offset = "0x3CD370", VA = "0x103CDF70")]
	private static uint CalcSubHash(uint value, byte[] buf, int index)
	{
		return 0U;
	}

	// Token: 0x0600067E RID: 1662 RVA: 0x00003B70 File Offset: 0x00001D70
	[Token(Token = "0x600067E")]
	[Address(RVA = "0x3CDF50", Offset = "0x3CD350", VA = "0x103CDF50")]
	private static uint CalcSubHash(uint value, uint read_value)
	{
		return 0U;
	}

	// Token: 0x0600067F RID: 1663 RVA: 0x00003B88 File Offset: 0x00001D88
	[Token(Token = "0x600067F")]
	[Address(RVA = "0x3CE460", Offset = "0x3CD860", VA = "0x103CE460")]
	private static uint RotateLeft(uint value, int count)
	{
		return 0U;
	}

	// Token: 0x0400066B RID: 1643
	[Token(Token = "0x400066B")]
	[FieldOffset(Offset = "0x8")]
	private uint seed;

	// Token: 0x0400066C RID: 1644
	[Token(Token = "0x400066C")]
	private const uint PRIME32_1 = 2654435761U;

	// Token: 0x0400066D RID: 1645
	[Token(Token = "0x400066D")]
	private const uint PRIME32_2 = 2246822519U;

	// Token: 0x0400066E RID: 1646
	[Token(Token = "0x400066E")]
	private const uint PRIME32_3 = 3266489917U;

	// Token: 0x0400066F RID: 1647
	[Token(Token = "0x400066F")]
	private const uint PRIME32_4 = 668265263U;

	// Token: 0x04000670 RID: 1648
	[Token(Token = "0x4000670")]
	private const uint PRIME32_5 = 374761393U;
}
