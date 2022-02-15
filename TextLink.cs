using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000109 RID: 265
[Token(Token = "0x2000109")]
public class TextLink : MonoBehaviour
{
	// Token: 0x06000653 RID: 1619 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000653")]
	[Address(RVA = "0x4ABF80", Offset = "0x4AB380", VA = "0x104ABF80")]
	public void Set(Vector2 from, Vector2 to, string target)
	{
	}

	// Token: 0x06000654 RID: 1620 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000654")]
	[Address(RVA = "0x4ABF00", Offset = "0x4AB300", VA = "0x104ABF00")]
	public void Click()
	{
	}

	// Token: 0x06000655 RID: 1621 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000655")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public TextLink()
	{
	}

	// Token: 0x0400064F RID: 1615
	[Token(Token = "0x400064F")]
	[FieldOffset(Offset = "0xC")]
	public BoxCollider2D boxCollider;

	// Token: 0x04000650 RID: 1616
	[Token(Token = "0x4000650")]
	[FieldOffset(Offset = "0x10")]
	public string targetUrl;

	// Token: 0x04000651 RID: 1617
	[Token(Token = "0x4000651")]
	[FieldOffset(Offset = "0x14")]
	public bool needed;
}
