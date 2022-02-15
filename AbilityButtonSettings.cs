using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001D2 RID: 466
[Token(Token = "0x20001D2")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x952B0", Offset = "0x946B0")]
public class AbilityButtonSettings : ScriptableObject
{
	// Token: 0x06000A82 RID: 2690 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A82")]
	[Address(RVA = "0x4A2960", Offset = "0x4A1D60", VA = "0x104A2960")]
	public AbilityButtonSettings()
	{
	}

	// Token: 0x04000AA2 RID: 2722
	[Token(Token = "0x4000AA2")]
	[FieldOffset(Offset = "0xC")]
	public Sprite Image;

	// Token: 0x04000AA3 RID: 2723
	[Token(Token = "0x4000AA3")]
	[FieldOffset(Offset = "0x10")]
	public StringNames Text;

	// Token: 0x04000AA4 RID: 2724
	[Token(Token = "0x4000AA4")]
	[FieldOffset(Offset = "0x14")]
	public Material FontMaterial;
}
