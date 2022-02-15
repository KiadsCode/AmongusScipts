using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000085 RID: 133
[Token(Token = "0x2000085")]
public class BurgerTopping : MonoBehaviour
{
	// Token: 0x06000348 RID: 840 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000348")]
	[Address(RVA = "0x82B980", Offset = "0x82AD80", VA = "0x1082B980")]
	public BurgerTopping()
	{
	}

	// Token: 0x04000323 RID: 803
	[Token(Token = "0x4000323")]
	[FieldOffset(Offset = "0xC")]
	public Collider2D Hitbox;

	// Token: 0x04000324 RID: 804
	[Token(Token = "0x4000324")]
	[FieldOffset(Offset = "0x10")]
	public AudioClip GrabSound;

	// Token: 0x04000325 RID: 805
	[Token(Token = "0x4000325")]
	[FieldOffset(Offset = "0x14")]
	public AudioClip DropSound;

	// Token: 0x04000326 RID: 806
	[Token(Token = "0x4000326")]
	[FieldOffset(Offset = "0x18")]
	public BurgerToppingTypes ToppingType;

	// Token: 0x04000327 RID: 807
	[Token(Token = "0x4000327")]
	[FieldOffset(Offset = "0x1C")]
	public float Offset;
}
