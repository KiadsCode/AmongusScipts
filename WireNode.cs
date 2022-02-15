using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000163 RID: 355
[Token(Token = "0x2000163")]
public class WireNode : MonoBehaviour
{
	// Token: 0x06000820 RID: 2080 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000820")]
	[Address(RVA = "0x3CDCF0", Offset = "0x3CD0F0", VA = "0x103CDCF0")]
	internal void SetColor(Color color, Sprite symbol)
	{
	}

	// Token: 0x06000821 RID: 2081 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000821")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public WireNode()
	{
	}

	// Token: 0x0400082A RID: 2090
	[Token(Token = "0x400082A")]
	[FieldOffset(Offset = "0xC")]
	public Collider2D hitbox;

	// Token: 0x0400082B RID: 2091
	[Token(Token = "0x400082B")]
	[FieldOffset(Offset = "0x10")]
	public SpriteRenderer[] WireColors;

	// Token: 0x0400082C RID: 2092
	[Token(Token = "0x400082C")]
	[FieldOffset(Offset = "0x14")]
	public SpriteRenderer BaseSymbol;

	// Token: 0x0400082D RID: 2093
	[Token(Token = "0x400082D")]
	[FieldOffset(Offset = "0x18")]
	public sbyte WireId;
}
