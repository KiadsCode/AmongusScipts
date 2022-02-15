using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000087 RID: 135
[Token(Token = "0x2000087")]
public class DressUpCosmetic : MonoBehaviour
{
	// Token: 0x06000349 RID: 841 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000349")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public DressUpCosmetic()
	{
	}

	// Token: 0x0400032C RID: 812
	[Token(Token = "0x400032C")]
	[FieldOffset(Offset = "0xC")]
	public SpriteRenderer Rend;

	// Token: 0x0400032D RID: 813
	[Token(Token = "0x400032D")]
	[FieldOffset(Offset = "0x10")]
	public Collider2D Hitbox;

	// Token: 0x0400032E RID: 814
	[Token(Token = "0x400032E")]
	[FieldOffset(Offset = "0x14")]
	public CosmeticType Slot;
}
