using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000476 RID: 1142
[Token(Token = "0x2000476")]
public class LightAffector : MonoBehaviour
{
	// Token: 0x0600185C RID: 6236 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600185C")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public LightAffector()
	{
	}

	// Token: 0x0400187C RID: 6268
	[Token(Token = "0x400187C")]
	[FieldOffset(Offset = "0xC")]
	public float Multiplier;

	// Token: 0x0400187D RID: 6269
	[Token(Token = "0x400187D")]
	[FieldOffset(Offset = "0x10")]
	public Collider2D Hitbox;
}
