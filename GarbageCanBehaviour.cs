using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200007D RID: 125
[Token(Token = "0x200007D")]
public class GarbageCanBehaviour : MonoBehaviour
{
	// Token: 0x0600032C RID: 812 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600032C")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public GarbageCanBehaviour()
	{
	}

	// Token: 0x040002F7 RID: 759
	[Token(Token = "0x40002F7")]
	[FieldOffset(Offset = "0xC")]
	public SpriteRenderer Handle;

	// Token: 0x040002F8 RID: 760
	[Token(Token = "0x40002F8")]
	[FieldOffset(Offset = "0x10")]
	public Rigidbody2D Body;

	// Token: 0x040002F9 RID: 761
	[Token(Token = "0x40002F9")]
	[FieldOffset(Offset = "0x14")]
	public Collider2D Success;

	// Token: 0x040002FA RID: 762
	[Token(Token = "0x40002FA")]
	[FieldOffset(Offset = "0x18")]
	public Collider2D Hitbox;
}
