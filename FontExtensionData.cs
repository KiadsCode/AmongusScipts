using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000107 RID: 263
[Token(Token = "0x2000107")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x952B0", Offset = "0x946B0")]
public class FontExtensionData : ScriptableObject
{
	// Token: 0x0600064E RID: 1614 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600064E")]
	[Address(RVA = "0x3A9A00", Offset = "0x3A8E00", VA = "0x103A9A00")]
	public void AdjustKernings(FontData target)
	{
	}

	// Token: 0x0600064F RID: 1615 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600064F")]
	[Address(RVA = "0x3A9BF0", Offset = "0x3A8FF0", VA = "0x103A9BF0")]
	public void AdjustOffsets(FontData target)
	{
	}

	// Token: 0x06000650 RID: 1616 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000650")]
	[Address(RVA = "0x3A9D70", Offset = "0x3A9170", VA = "0x103A9D70")]
	public FontExtensionData()
	{
	}

	// Token: 0x0400064C RID: 1612
	[Token(Token = "0x400064C")]
	[FieldOffset(Offset = "0xC")]
	public string FontName;

	// Token: 0x0400064D RID: 1613
	[Token(Token = "0x400064D")]
	[FieldOffset(Offset = "0x10")]
	public List<KerningPair> kernings;

	// Token: 0x0400064E RID: 1614
	[Token(Token = "0x400064E")]
	[FieldOffset(Offset = "0x14")]
	public List<OffsetAdjustment> Offsets;
}
