using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000509 RID: 1289
[Token(Token = "0x2000509")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x952B0", Offset = "0x946B0")]
public class TranslatedImageSet : ScriptableObject
{
	// Token: 0x06001B6B RID: 7019 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B6B")]
	[Address(RVA = "0x4A2960", Offset = "0x4A1D60", VA = "0x104A2960")]
	public TranslatedImageSet()
	{
	}

	// Token: 0x04001F29 RID: 7977
	[Token(Token = "0x4001F29")]
	[FieldOffset(Offset = "0xC")]
	public string Name;

	// Token: 0x04001F2A RID: 7978
	[Token(Token = "0x4001F2A")]
	[FieldOffset(Offset = "0x10")]
	public SupportedLangs languageID;

	// Token: 0x04001F2B RID: 7979
	[Token(Token = "0x4001F2B")]
	[FieldOffset(Offset = "0x14")]
	public TextAsset Data;

	// Token: 0x04001F2C RID: 7980
	[Token(Token = "0x4001F2C")]
	[FieldOffset(Offset = "0x18")]
	public ImageData[] Images;
}
