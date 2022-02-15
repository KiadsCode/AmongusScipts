using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200012C RID: 300
[Token(Token = "0x200012C")]
public class CrossFadeImages : MonoBehaviour
{
	// Token: 0x06000702 RID: 1794 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000702")]
	[Address(RVA = "0x5B9A50", Offset = "0x5B8E50", VA = "0x105B9A50")]
	private void Update()
	{
	}

	// Token: 0x06000703 RID: 1795 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000703")]
	[Address(RVA = "0x47AF50", Offset = "0x47A350", VA = "0x1047AF50")]
	public CrossFadeImages()
	{
	}

	// Token: 0x040006F9 RID: 1785
	[Token(Token = "0x40006F9")]
	[FieldOffset(Offset = "0xC")]
	public SpriteRenderer Image1;

	// Token: 0x040006FA RID: 1786
	[Token(Token = "0x40006FA")]
	[FieldOffset(Offset = "0x10")]
	public SpriteRenderer Image2;

	// Token: 0x040006FB RID: 1787
	[Token(Token = "0x40006FB")]
	[FieldOffset(Offset = "0x14")]
	public float Period;
}
