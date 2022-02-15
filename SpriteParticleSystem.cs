using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003D2 RID: 978
[Token(Token = "0x20003D2")]
[Attribute(Name = "RequireComponent", RVA = "0xDE900", Offset = "0xDDD00")]
public class SpriteParticleSystem : MonoBehaviour
{
	// Token: 0x06001453 RID: 5203 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001453")]
	[Address(RVA = "0x755D50", Offset = "0x755150", VA = "0x10755D50")]
	private void OnEnable()
	{
	}

	// Token: 0x06001454 RID: 5204 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001454")]
	[Address(RVA = "0x755DF0", Offset = "0x7551F0", VA = "0x10755DF0")]
	private void SetPropertyBlock()
	{
	}

	// Token: 0x06001455 RID: 5205 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001455")]
	[Address(RVA = "0x755DE0", Offset = "0x7551E0", VA = "0x10755DE0")]
	private void OnValidate()
	{
	}

	// Token: 0x06001456 RID: 5206 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001456")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public SpriteParticleSystem()
	{
	}

	// Token: 0x040014F3 RID: 5363
	[Token(Token = "0x40014F3")]
	[FieldOffset(Offset = "0xC")]
	public Sprite sprite;

	// Token: 0x040014F4 RID: 5364
	[Token(Token = "0x40014F4")]
	[FieldOffset(Offset = "0x10")]
	public ParticleSystemRenderer ren;

	// Token: 0x040014F5 RID: 5365
	[Token(Token = "0x40014F5")]
	[FieldOffset(Offset = "0x14")]
	private MaterialPropertyBlock block;
}
