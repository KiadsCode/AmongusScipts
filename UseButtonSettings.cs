using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001DB RID: 475
[Token(Token = "0x20001DB")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x952B0", Offset = "0x946B0")]
public class UseButtonSettings : ScriptableObject
{
	// Token: 0x06000AA7 RID: 2727 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AA7")]
	[Address(RVA = "0x4A2960", Offset = "0x4A1D60", VA = "0x104A2960")]
	public UseButtonSettings()
	{
	}

	// Token: 0x04000AB3 RID: 2739
	[Token(Token = "0x4000AB3")]
	[FieldOffset(Offset = "0xC")]
	public ImageNames ButtonType;

	// Token: 0x04000AB4 RID: 2740
	[Token(Token = "0x4000AB4")]
	[FieldOffset(Offset = "0x10")]
	public Sprite Image;

	// Token: 0x04000AB5 RID: 2741
	[Token(Token = "0x4000AB5")]
	[FieldOffset(Offset = "0x14")]
	public StringNames Text;

	// Token: 0x04000AB6 RID: 2742
	[Token(Token = "0x4000AB6")]
	[FieldOffset(Offset = "0x18")]
	public Material FontMaterial;
}
