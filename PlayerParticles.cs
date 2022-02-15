using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002A1 RID: 673
[Token(Token = "0x20002A1")]
public class PlayerParticles : MonoBehaviour
{
	// Token: 0x06000EE5 RID: 3813 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EE5")]
	[Address(RVA = "0x502780", Offset = "0x501B80", VA = "0x10502780")]
	public void Start()
	{
	}

	// Token: 0x06000EE6 RID: 3814 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EE6")]
	[Address(RVA = "0x5028D0", Offset = "0x501CD0", VA = "0x105028D0")]
	public void Update()
	{
	}

	// Token: 0x06000EE7 RID: 3815 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EE7")]
	[Address(RVA = "0x502340", Offset = "0x501740", VA = "0x10502340")]
	private void PlacePlayer(PlayerParticle part, bool initial)
	{
	}

	// Token: 0x06000EE8 RID: 3816 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EE8")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public PlayerParticles()
	{
	}

	// Token: 0x04000EF2 RID: 3826
	[Token(Token = "0x4000EF2")]
	[FieldOffset(Offset = "0xC")]
	public PlayerParticleInfo[] Sprites;

	// Token: 0x04000EF3 RID: 3827
	[Token(Token = "0x4000EF3")]
	[FieldOffset(Offset = "0x10")]
	public FloatRange velocity;

	// Token: 0x04000EF4 RID: 3828
	[Token(Token = "0x4000EF4")]
	[FieldOffset(Offset = "0x14")]
	public FloatRange scale;

	// Token: 0x04000EF5 RID: 3829
	[Token(Token = "0x4000EF5")]
	[FieldOffset(Offset = "0x18")]
	public ObjectPoolBehavior pool;

	// Token: 0x04000EF6 RID: 3830
	[Token(Token = "0x4000EF6")]
	[FieldOffset(Offset = "0x1C")]
	public float StartRadius;

	// Token: 0x04000EF7 RID: 3831
	[Token(Token = "0x4000EF7")]
	[FieldOffset(Offset = "0x20")]
	public Camera FollowCamera;

	// Token: 0x04000EF8 RID: 3832
	[Token(Token = "0x4000EF8")]
	[FieldOffset(Offset = "0x24")]
	private RandomFill<PlayerParticleInfo> fill;
}
