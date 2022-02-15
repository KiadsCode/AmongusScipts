using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200019C RID: 412
[Token(Token = "0x200019C")]
public class CloudGenerator : MonoBehaviour
{
	// Token: 0x06000965 RID: 2405 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000965")]
	[Address(RVA = "0x41F8C0", Offset = "0x41ECC0", VA = "0x1041F8C0")]
	public void Start()
	{
	}

	// Token: 0x06000966 RID: 2406 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000966")]
	[Address(RVA = "0x420170", Offset = "0x41F570", VA = "0x10420170")]
	private void Update()
	{
	}

	// Token: 0x06000967 RID: 2407 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000967")]
	[Address(RVA = "0x41F820", Offset = "0x41EC20", VA = "0x1041F820")]
	public void SetDirection(Vector2 dir)
	{
	}

	// Token: 0x06000968 RID: 2408 RVA: 0x00004590 File Offset: 0x00002790
	[Token(Token = "0x6000968")]
	[Address(RVA = "0x41F7F0", Offset = "0x41EBF0", VA = "0x1041F7F0")]
	private float OrthoDistance(float pointx, float pointy)
	{
		return 0f;
	}

	// Token: 0x06000969 RID: 2409 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000969")]
	[Address(RVA = "0x420630", Offset = "0x41FA30", VA = "0x10420630")]
	public CloudGenerator()
	{
	}

	// Token: 0x0400095E RID: 2398
	[Token(Token = "0x400095E")]
	[FieldOffset(Offset = "0xC")]
	public Sprite[] CloudImages;

	// Token: 0x0400095F RID: 2399
	[Token(Token = "0x400095F")]
	[FieldOffset(Offset = "0x10")]
	private Vector2[] ExtentCache;

	// Token: 0x04000960 RID: 2400
	[Token(Token = "0x4000960")]
	[FieldOffset(Offset = "0x14")]
	public int NumClouds;

	// Token: 0x04000961 RID: 2401
	[Token(Token = "0x4000961")]
	[FieldOffset(Offset = "0x18")]
	public float Length;

	// Token: 0x04000962 RID: 2402
	[Token(Token = "0x4000962")]
	[FieldOffset(Offset = "0x1C")]
	public float Width;

	// Token: 0x04000963 RID: 2403
	[Token(Token = "0x4000963")]
	[FieldOffset(Offset = "0x20")]
	public Vector2 Direction;

	// Token: 0x04000964 RID: 2404
	[Token(Token = "0x4000964")]
	[FieldOffset(Offset = "0x28")]
	private Vector2 NormDir;

	// Token: 0x04000965 RID: 2405
	[Token(Token = "0x4000965")]
	[FieldOffset(Offset = "0x30")]
	private Vector2 Tangent;

	// Token: 0x04000966 RID: 2406
	[Token(Token = "0x4000966")]
	[FieldOffset(Offset = "0x38")]
	private float tanLen;

	// Token: 0x04000967 RID: 2407
	[Token(Token = "0x4000967")]
	[FieldOffset(Offset = "0x3C")]
	public FloatRange Rates;

	// Token: 0x04000968 RID: 2408
	[Token(Token = "0x4000968")]
	[FieldOffset(Offset = "0x40")]
	public FloatRange Sizes;

	// Token: 0x04000969 RID: 2409
	[Token(Token = "0x4000969")]
	[FieldOffset(Offset = "0x44")]
	public bool Depth;

	// Token: 0x0400096A RID: 2410
	[Token(Token = "0x400096A")]
	[FieldOffset(Offset = "0x48")]
	public float MaxDepth;

	// Token: 0x0400096B RID: 2411
	[Token(Token = "0x400096B")]
	[FieldOffset(Offset = "0x4C")]
	public float ParallaxOffset;

	// Token: 0x0400096C RID: 2412
	[Token(Token = "0x400096C")]
	[FieldOffset(Offset = "0x50")]
	public float ParallaxStrength;

	// Token: 0x0400096D RID: 2413
	[Token(Token = "0x400096D")]
	[FieldOffset(Offset = "0x54")]
	[HideInInspector]
	private CloudGenerator.Cloud[] clouds;

	// Token: 0x0400096E RID: 2414
	[Token(Token = "0x400096E")]
	[FieldOffset(Offset = "0x58")]
	[HideInInspector]
	private Vector3[] verts;

	// Token: 0x0400096F RID: 2415
	[Token(Token = "0x400096F")]
	[FieldOffset(Offset = "0x5C")]
	[HideInInspector]
	private Mesh mesh;

	// Token: 0x0200019D RID: 413
	[Token(Token = "0x200019D")]
	private struct Cloud
	{
		// Token: 0x04000970 RID: 2416
		[Token(Token = "0x4000970")]
		[FieldOffset(Offset = "0x0")]
		public int CloudIdx;

		// Token: 0x04000971 RID: 2417
		[Token(Token = "0x4000971")]
		[FieldOffset(Offset = "0x4")]
		public float Rate;

		// Token: 0x04000972 RID: 2418
		[Token(Token = "0x4000972")]
		[FieldOffset(Offset = "0x8")]
		public float Size;

		// Token: 0x04000973 RID: 2419
		[Token(Token = "0x4000973")]
		[FieldOffset(Offset = "0xC")]
		public float FlipX;

		// Token: 0x04000974 RID: 2420
		[Token(Token = "0x4000974")]
		[FieldOffset(Offset = "0x10")]
		public float PositionX;

		// Token: 0x04000975 RID: 2421
		[Token(Token = "0x4000975")]
		[FieldOffset(Offset = "0x14")]
		public float PositionY;

		// Token: 0x04000976 RID: 2422
		[Token(Token = "0x4000976")]
		[FieldOffset(Offset = "0x18")]
		public float PositionZ;
	}
}
