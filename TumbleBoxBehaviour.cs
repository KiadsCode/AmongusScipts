using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004C1 RID: 1217
[Token(Token = "0x20004C1")]
public class TumbleBoxBehaviour : MonoBehaviour
{
	// Token: 0x060019D9 RID: 6617 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019D9")]
	[Address(RVA = "0x4B2E70", Offset = "0x4B2270", VA = "0x104B2E70")]
	public void FixedUpdate()
	{
	}

	// Token: 0x060019DA RID: 6618 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019DA")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public TumbleBoxBehaviour()
	{
	}

	// Token: 0x04001A13 RID: 6675
	[Token(Token = "0x4001A13")]
	[FieldOffset(Offset = "0xC")]
	public FloatRange BoxHeight;

	// Token: 0x04001A14 RID: 6676
	[Token(Token = "0x4001A14")]
	[FieldOffset(Offset = "0x10")]
	public FloatRange shadowScale;

	// Token: 0x04001A15 RID: 6677
	[Token(Token = "0x4001A15")]
	[FieldOffset(Offset = "0x14")]
	public SpriteRenderer Shadow;

	// Token: 0x04001A16 RID: 6678
	[Token(Token = "0x4001A16")]
	[FieldOffset(Offset = "0x18")]
	public SpriteRenderer Box;
}
