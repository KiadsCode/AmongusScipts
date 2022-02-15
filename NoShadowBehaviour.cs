using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000326 RID: 806
[Token(Token = "0x2000326")]
public class NoShadowBehaviour : MonoBehaviour
{
	// Token: 0x060011B0 RID: 4528 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011B0")]
	[Address(RVA = "0x778DB0", Offset = "0x7781B0", VA = "0x10778DB0")]
	public void Start()
	{
	}

	// Token: 0x060011B1 RID: 4529 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011B1")]
	[Address(RVA = "0x778310", Offset = "0x777710", VA = "0x10778310")]
	private void CalculateBoxEdgeCheckPoints()
	{
	}

	// Token: 0x060011B2 RID: 4530 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011B2")]
	[Address(RVA = "0x778C70", Offset = "0x778070", VA = "0x10778C70")]
	public void OnDestroy()
	{
	}

	// Token: 0x060011B3 RID: 4531 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011B3")]
	[Address(RVA = "0x778AD0", Offset = "0x777ED0", VA = "0x10778AD0")]
	private void LateUpdate()
	{
	}

	// Token: 0x060011B4 RID: 4532 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011B4")]
	[Address(RVA = "0x778CF0", Offset = "0x7780F0", VA = "0x10778CF0")]
	private void SetMaskFunction(int func)
	{
	}

	// Token: 0x060011B5 RID: 4533 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011B5")]
	[Address(RVA = "0x7785B0", Offset = "0x7779B0", VA = "0x107785B0")]
	internal void CheckHit(float lightRadius, Vector2 lightPosition)
	{
	}

	// Token: 0x060011B6 RID: 4534 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011B6")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public NoShadowBehaviour()
	{
	}

	// Token: 0x040011A3 RID: 4515
	[Token(Token = "0x40011A3")]
	[FieldOffset(Offset = "0xC")]
	public Renderer rend;

	// Token: 0x040011A4 RID: 4516
	[Token(Token = "0x40011A4")]
	[FieldOffset(Offset = "0x10")]
	public bool didHit;

	// Token: 0x040011A5 RID: 4517
	[Token(Token = "0x40011A5")]
	[FieldOffset(Offset = "0x14")]
	public Renderer shadowChild;

	// Token: 0x040011A6 RID: 4518
	[Token(Token = "0x40011A6")]
	[FieldOffset(Offset = "0x18")]
	public Collider2D hitOverride;

	// Token: 0x040011A7 RID: 4519
	[Token(Token = "0x40011A7")]
	[FieldOffset(Offset = "0x1C")]
	private BoxCollider2D bc;

	// Token: 0x040011A8 RID: 4520
	[Token(Token = "0x40011A8")]
	[FieldOffset(Offset = "0x20")]
	private bool isBox;

	// Token: 0x040011A9 RID: 4521
	[Token(Token = "0x40011A9")]
	[FieldOffset(Offset = "0x21")]
	private bool verticalBox;

	// Token: 0x040011AA RID: 4522
	[Token(Token = "0x40011AA")]
	[FieldOffset(Offset = "0x24")]
	private Vector2[] boxCheckPoints;

	// Token: 0x040011AB RID: 4523
	[Token(Token = "0x40011AB")]
	private const int edgePoints = 4;

	// Token: 0x040011AC RID: 4524
	[Token(Token = "0x40011AC")]
	private const int totalPointsPerEdge = 6;
}
