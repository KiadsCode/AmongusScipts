using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001EE RID: 494
[Token(Token = "0x20001EE")]
public class HorizontalGauge : MonoBehaviour
{
	// Token: 0x06000B0A RID: 2826 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B0A")]
	[Address(RVA = "0x3E87B0", Offset = "0x3E7BB0", VA = "0x103E87B0")]
	public void Update()
	{
	}

	// Token: 0x06000B0B RID: 2827 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B0B")]
	[Address(RVA = "0x3E8B00", Offset = "0x3E7F00", VA = "0x103E8B00")]
	public HorizontalGauge()
	{
	}

	// Token: 0x04000B12 RID: 2834
	[Token(Token = "0x4000B12")]
	[FieldOffset(Offset = "0xC")]
	public float Value;

	// Token: 0x04000B13 RID: 2835
	[Token(Token = "0x4000B13")]
	[FieldOffset(Offset = "0x10")]
	public float MaxValue;

	// Token: 0x04000B14 RID: 2836
	[Token(Token = "0x4000B14")]
	[FieldOffset(Offset = "0x14")]
	public float maskScale;

	// Token: 0x04000B15 RID: 2837
	[Token(Token = "0x4000B15")]
	[FieldOffset(Offset = "0x18")]
	public SpriteMask Mask;

	// Token: 0x04000B16 RID: 2838
	[Token(Token = "0x4000B16")]
	[FieldOffset(Offset = "0x1C")]
	public SpriteRenderer MaskArea;

	// Token: 0x04000B17 RID: 2839
	[Token(Token = "0x4000B17")]
	[FieldOffset(Offset = "0x20")]
	private float lastValue;
}
