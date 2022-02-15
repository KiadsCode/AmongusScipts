using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000FC RID: 252
[Token(Token = "0x20000FC")]
[Serializable]
public struct Vector2Range
{
	// Token: 0x170000F0 RID: 240
	// (get) Token: 0x06000628 RID: 1576 RVA: 0x000039A8 File Offset: 0x00001BA8
	[Token(Token = "0x170000F0")]
	public float Width
	{
		[Token(Token = "0x6000628")]
		[Address(RVA = "0x7A8D30", Offset = "0x7A8130", VA = "0x107A8D30")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170000F1 RID: 241
	// (get) Token: 0x06000629 RID: 1577 RVA: 0x000039C0 File Offset: 0x00001BC0
	[Token(Token = "0x170000F1")]
	public float Height
	{
		[Token(Token = "0x6000629")]
		[Address(RVA = "0x7A8D20", Offset = "0x7A8120", VA = "0x107A8D20")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x0600062A RID: 1578 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600062A")]
	[Address(RVA = "0x7A8D00", Offset = "0x7A8100", VA = "0x107A8D00")]
	public Vector2Range(Vector2 min, Vector2 max)
	{
	}

	// Token: 0x0600062B RID: 1579 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600062B")]
	[Address(RVA = "0x7A8B20", Offset = "0x7A7F20", VA = "0x107A8B20")]
	public void LerpUnclamped(ref Vector3 output, float t, float z)
	{
	}

	// Token: 0x0600062C RID: 1580 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600062C")]
	[Address(RVA = "0x7A8BB0", Offset = "0x7A7FB0", VA = "0x107A8BB0")]
	public void Lerp(ref Vector3 output, float t, float z)
	{
	}

	// Token: 0x0600062D RID: 1581 RVA: 0x000039D8 File Offset: 0x00001BD8
	[Token(Token = "0x600062D")]
	[Address(RVA = "0x7A8C90", Offset = "0x7A8090", VA = "0x107A8C90")]
	public Vector2 Next()
	{
		return default(Vector2);
	}

	// Token: 0x0600062E RID: 1582 RVA: 0x000039F0 File Offset: 0x00001BF0
	[Token(Token = "0x600062E")]
	[Address(RVA = "0x7A8C40", Offset = "0x7A8040", VA = "0x107A8C40")]
	public static Vector2 NextEdge()
	{
		return default(Vector2);
	}

	// Token: 0x04000626 RID: 1574
	[Token(Token = "0x4000626")]
	[FieldOffset(Offset = "0x0")]
	public Vector2 min;

	// Token: 0x04000627 RID: 1575
	[Token(Token = "0x4000627")]
	[FieldOffset(Offset = "0x8")]
	public Vector2 max;
}
