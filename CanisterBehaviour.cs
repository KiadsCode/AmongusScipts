using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000339 RID: 825
[Token(Token = "0x2000339")]
public class CanisterBehaviour : MonoBehaviour
{
	// Token: 0x0600120A RID: 4618 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600120A")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public CanisterBehaviour()
	{
	}

	// Token: 0x040011FE RID: 4606
	[Token(Token = "0x40011FE")]
	[FieldOffset(Offset = "0xC")]
	public Collider2D Hitbox;

	// Token: 0x040011FF RID: 4607
	[Token(Token = "0x40011FF")]
	[FieldOffset(Offset = "0x10")]
	public HorizontalSpriteGauge Gauge;
}
