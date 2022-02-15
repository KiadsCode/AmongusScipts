using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000191 RID: 401
[Token(Token = "0x2000191")]
public class GaugeRandomizer : MonoBehaviour
{
	// Token: 0x06000931 RID: 2353 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000931")]
	[Address(RVA = "0x3B6700", Offset = "0x3B5B00", VA = "0x103B6700")]
	public void Start()
	{
	}

	// Token: 0x06000932 RID: 2354 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000932")]
	[Address(RVA = "0x3B6770", Offset = "0x3B5B70", VA = "0x103B6770")]
	private void Update()
	{
	}

	// Token: 0x06000933 RID: 2355 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000933")]
	[Address(RVA = "0x3B68D0", Offset = "0x3B5CD0", VA = "0x103B68D0")]
	public GaugeRandomizer()
	{
	}

	// Token: 0x0400092C RID: 2348
	[Token(Token = "0x400092C")]
	[FieldOffset(Offset = "0xC")]
	public FloatRange Range;

	// Token: 0x0400092D RID: 2349
	[Token(Token = "0x400092D")]
	[FieldOffset(Offset = "0x10")]
	public SpriteRenderer Gauge;

	// Token: 0x0400092E RID: 2350
	[Token(Token = "0x400092E")]
	[FieldOffset(Offset = "0x14")]
	public float Frequency;

	// Token: 0x0400092F RID: 2351
	[Token(Token = "0x400092F")]
	[FieldOffset(Offset = "0x18")]
	public float Offset;

	// Token: 0x04000930 RID: 2352
	[Token(Token = "0x4000930")]
	[FieldOffset(Offset = "0x1C")]
	private float naturalY;

	// Token: 0x04000931 RID: 2353
	[Token(Token = "0x4000931")]
	[FieldOffset(Offset = "0x20")]
	private float naturalSizeY;

	// Token: 0x04000932 RID: 2354
	[Token(Token = "0x4000932")]
	[FieldOffset(Offset = "0x24")]
	private Color goodLineColor;
}
