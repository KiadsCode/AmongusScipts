using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001EF RID: 495
[Token(Token = "0x20001EF")]
public class HorizontalSpriteGauge : MonoBehaviour
{
	// Token: 0x06000B0C RID: 2828 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B0C")]
	[Address(RVA = "0x3E8B40", Offset = "0x3E7F40", VA = "0x103E8B40")]
	public void Update()
	{
	}

	// Token: 0x06000B0D RID: 2829 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B0D")]
	[Address(RVA = "0x3E8D00", Offset = "0x3E8100", VA = "0x103E8D00")]
	public HorizontalSpriteGauge()
	{
	}

	// Token: 0x04000B18 RID: 2840
	[Token(Token = "0x4000B18")]
	[FieldOffset(Offset = "0xC")]
	public float Value;

	// Token: 0x04000B19 RID: 2841
	[Token(Token = "0x4000B19")]
	[FieldOffset(Offset = "0x10")]
	public float MaxValue;

	// Token: 0x04000B1A RID: 2842
	[Token(Token = "0x4000B1A")]
	[FieldOffset(Offset = "0x14")]
	public float maskScale;

	// Token: 0x04000B1B RID: 2843
	[Token(Token = "0x4000B1B")]
	[FieldOffset(Offset = "0x18")]
	public SpriteRenderer Mask;

	// Token: 0x04000B1C RID: 2844
	[Token(Token = "0x4000B1C")]
	[FieldOffset(Offset = "0x1C")]
	private float lastValue;
}
