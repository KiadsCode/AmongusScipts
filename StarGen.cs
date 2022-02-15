using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004D2 RID: 1234
[Token(Token = "0x20004D2")]
[Attribute(Name = "RequireComponent", RVA = "0xE0B60", Offset = "0xDFF60")]
[Attribute(Name = "RequireComponent", RVA = "0xE0B60", Offset = "0xDFF60")]
public class StarGen : MonoBehaviour
{
	// Token: 0x06001A44 RID: 6724 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A44")]
	[Address(RVA = "0x756340", Offset = "0x755740", VA = "0x10756340")]
	public void Start()
	{
	}

	// Token: 0x06001A45 RID: 6725 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A45")]
	[Address(RVA = "0x756950", Offset = "0x755D50", VA = "0x10756950")]
	private void Update()
	{
	}

	// Token: 0x06001A46 RID: 6726 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A46")]
	[Address(RVA = "0x756220", Offset = "0x755620", VA = "0x10756220")]
	public void SetDirection(Vector2 dir)
	{
	}

	// Token: 0x06001A47 RID: 6727 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A47")]
	[Address(RVA = "0x756120", Offset = "0x755520", VA = "0x10756120")]
	public void RegenPositions()
	{
	}

	// Token: 0x06001A48 RID: 6728 RVA: 0x00008310 File Offset: 0x00006510
	[Token(Token = "0x6001A48")]
	[Address(RVA = "0x7560F0", Offset = "0x7554F0", VA = "0x107560F0")]
	private float OrthoDistance(float pointx, float pointy)
	{
		return 0f;
	}

	// Token: 0x06001A49 RID: 6729 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A49")]
	[Address(RVA = "0x756CD0", Offset = "0x7560D0", VA = "0x10756CD0")]
	public StarGen()
	{
	}

	// Token: 0x04001A67 RID: 6759
	[Token(Token = "0x4001A67")]
	private const float MaxStarRadius = 0.05f;

	// Token: 0x04001A68 RID: 6760
	[Token(Token = "0x4001A68")]
	[FieldOffset(Offset = "0xC")]
	public int NumStars;

	// Token: 0x04001A69 RID: 6761
	[Token(Token = "0x4001A69")]
	[FieldOffset(Offset = "0x10")]
	public float Length;

	// Token: 0x04001A6A RID: 6762
	[Token(Token = "0x4001A6A")]
	[FieldOffset(Offset = "0x14")]
	public float Width;

	// Token: 0x04001A6B RID: 6763
	[Token(Token = "0x4001A6B")]
	[FieldOffset(Offset = "0x18")]
	public Vector2 Direction;

	// Token: 0x04001A6C RID: 6764
	[Token(Token = "0x4001A6C")]
	[FieldOffset(Offset = "0x20")]
	private Vector2 NormDir;

	// Token: 0x04001A6D RID: 6765
	[Token(Token = "0x4001A6D")]
	[FieldOffset(Offset = "0x28")]
	private Vector2 Tangent;

	// Token: 0x04001A6E RID: 6766
	[Token(Token = "0x4001A6E")]
	[FieldOffset(Offset = "0x30")]
	private float tanLen;

	// Token: 0x04001A6F RID: 6767
	[Token(Token = "0x4001A6F")]
	[FieldOffset(Offset = "0x34")]
	public FloatRange Rates;

	// Token: 0x04001A70 RID: 6768
	[Token(Token = "0x4001A70")]
	[FieldOffset(Offset = "0x38")]
	[HideInInspector]
	private StarGen.Stars[] stars;

	// Token: 0x04001A71 RID: 6769
	[Token(Token = "0x4001A71")]
	[FieldOffset(Offset = "0x3C")]
	[HideInInspector]
	private Vector3[] verts;

	// Token: 0x04001A72 RID: 6770
	[Token(Token = "0x4001A72")]
	[FieldOffset(Offset = "0x40")]
	[HideInInspector]
	private Mesh mesh;

	// Token: 0x020004D3 RID: 1235
	[Token(Token = "0x20004D3")]
	[Serializable]
	private struct Stars
	{
		// Token: 0x04001A73 RID: 6771
		[Token(Token = "0x4001A73")]
		[FieldOffset(Offset = "0x0")]
		public float Size;

		// Token: 0x04001A74 RID: 6772
		[Token(Token = "0x4001A74")]
		[FieldOffset(Offset = "0x4")]
		public float Rate;

		// Token: 0x04001A75 RID: 6773
		[Token(Token = "0x4001A75")]
		[FieldOffset(Offset = "0x8")]
		public float PositionX;

		// Token: 0x04001A76 RID: 6774
		[Token(Token = "0x4001A76")]
		[FieldOffset(Offset = "0xC")]
		public float PositionY;
	}
}
