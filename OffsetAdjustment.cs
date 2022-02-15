using System;
using Il2CppDummyDll;

// Token: 0x02000106 RID: 262
[Token(Token = "0x2000106")]
[Serializable]
public class OffsetAdjustment
{
	// Token: 0x0600064D RID: 1613 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600064D")]
	[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
	public OffsetAdjustment()
	{
	}

	// Token: 0x04000649 RID: 1609
	[Token(Token = "0x4000649")]
	[FieldOffset(Offset = "0x8")]
	public char Char;

	// Token: 0x0400064A RID: 1610
	[Token(Token = "0x400064A")]
	[FieldOffset(Offset = "0xC")]
	public int OffsetX;

	// Token: 0x0400064B RID: 1611
	[Token(Token = "0x400064B")]
	[FieldOffset(Offset = "0x10")]
	public int OffsetY;
}
