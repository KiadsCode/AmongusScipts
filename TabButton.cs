using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020002E4 RID: 740
[Token(Token = "0x20002E4")]
[Serializable]
public class TabButton
{
	// Token: 0x06001052 RID: 4178 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001052")]
	[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
	public TabButton()
	{
	}

	// Token: 0x0400100B RID: 4107
	[Token(Token = "0x400100B")]
	[FieldOffset(Offset = "0x8")]
	public TextMeshPro tabText;

	// Token: 0x0400100C RID: 4108
	[Token(Token = "0x400100C")]
	[FieldOffset(Offset = "0xC")]
	public SpriteRenderer Button;

	// Token: 0x0400100D RID: 4109
	[Token(Token = "0x400100D")]
	[FieldOffset(Offset = "0x10")]
	public InventoryTab Tab;
}
