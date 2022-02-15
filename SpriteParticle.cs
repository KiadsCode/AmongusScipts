using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000102 RID: 258
[Token(Token = "0x2000102")]
[Attribute(Name = "RequireComponent", RVA = "0xDDCA0", Offset = "0xDD0A0")]
[Attribute(Name = "RequireComponent", RVA = "0xDDCA0", Offset = "0xDD0A0")]
public class SpriteParticle : MonoBehaviour
{
	// Token: 0x06000643 RID: 1603 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000643")]
	[Address(RVA = "0x4A89B0", Offset = "0x4A7DB0", VA = "0x104A89B0")]
	public void OnDrawGizmos()
	{
	}

	// Token: 0x06000644 RID: 1604 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000644")]
	[Address(RVA = "0x4A8C20", Offset = "0x4A8020", VA = "0x104A8C20")]
	public void Start()
	{
	}

	// Token: 0x06000645 RID: 1605 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000645")]
	[Address(RVA = "0x4A9110", Offset = "0x4A8510", VA = "0x104A9110")]
	public void Update()
	{
	}

	// Token: 0x06000646 RID: 1606 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000646")]
	[Address(RVA = "0x4A94A0", Offset = "0x4A88A0", VA = "0x104A94A0")]
	public SpriteParticle()
	{
	}

	// Token: 0x04000633 RID: 1587
	[Token(Token = "0x4000633")]
	private const float FrameRate = 24f;

	// Token: 0x04000634 RID: 1588
	[Token(Token = "0x4000634")]
	[FieldOffset(Offset = "0xC")]
	public Sprite[] Sprites;

	// Token: 0x04000635 RID: 1589
	[Token(Token = "0x4000635")]
	[FieldOffset(Offset = "0x10")]
	public ParticleInfo[] Particles;

	// Token: 0x04000636 RID: 1590
	[Token(Token = "0x4000636")]
	[FieldOffset(Offset = "0x14")]
	public ushort[][] TriangleCache;

	// Token: 0x04000637 RID: 1591
	[Token(Token = "0x4000637")]
	[FieldOffset(Offset = "0x18")]
	private Vector3[] verts;

	// Token: 0x04000638 RID: 1592
	[Token(Token = "0x4000638")]
	[FieldOffset(Offset = "0x1C")]
	private Vector2[] uvs;

	// Token: 0x04000639 RID: 1593
	[Token(Token = "0x4000639")]
	[FieldOffset(Offset = "0x20")]
	private List<int> tris;

	// Token: 0x0400063A RID: 1594
	[Token(Token = "0x400063A")]
	[FieldOffset(Offset = "0x24")]
	private Mesh mesh;

	// Token: 0x0400063B RID: 1595
	[Token(Token = "0x400063B")]
	[FieldOffset(Offset = "0x28")]
	private int MaxVerts;

	// Token: 0x0400063C RID: 1596
	[Token(Token = "0x400063C")]
	[FieldOffset(Offset = "0x2C")]
	private Dictionary<int, Vector2[]> VertCache;

	// Token: 0x0400063D RID: 1597
	[Token(Token = "0x400063D")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<int, Vector2[]> UvCache;
}
