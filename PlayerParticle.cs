using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002F4 RID: 756
[Token(Token = "0x20002F4")]
public class PlayerParticle : PoolableBehavior
{
	// Token: 0x17000277 RID: 631
	// (get) Token: 0x060010A1 RID: 4257 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060010A2 RID: 4258 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000277")]
	public Camera FollowCamera
	{
		[Token(Token = "0x60010A1")]
		[Address(RVA = "0x2D5F80", Offset = "0x2D5380", VA = "0x102D5F80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60010A2")]
		[Address(RVA = "0x2D5FB0", Offset = "0x2D53B0", VA = "0x102D5FB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		set
		{
		}
	}

	// Token: 0x060010A3 RID: 4259 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010A3")]
	[Address(RVA = "0x502010", Offset = "0x501410", VA = "0x10502010")]
	public void Update()
	{
	}

	// Token: 0x060010A4 RID: 4260 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010A4")]
	[Address(RVA = "0x502320", Offset = "0x501720", VA = "0x10502320")]
	public PlayerParticle()
	{
	}

	// Token: 0x04001049 RID: 4169
	[Token(Token = "0x4001049")]
	[FieldOffset(Offset = "0x14")]
	public SpriteRenderer myRend;

	// Token: 0x0400104A RID: 4170
	[Token(Token = "0x400104A")]
	[FieldOffset(Offset = "0x18")]
	public float maxDistance;

	// Token: 0x0400104B RID: 4171
	[Token(Token = "0x400104B")]
	[FieldOffset(Offset = "0x1C")]
	public Vector2 velocity;

	// Token: 0x0400104C RID: 4172
	[Token(Token = "0x400104C")]
	[FieldOffset(Offset = "0x24")]
	public float angularVelocity;

	// Token: 0x0400104D RID: 4173
	[Token(Token = "0x400104D")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private Camera <FollowCamera>k__BackingField;

	// Token: 0x0400104E RID: 4174
	[Token(Token = "0x400104E")]
	[FieldOffset(Offset = "0x2C")]
	private Vector3 lastCamera;
}
