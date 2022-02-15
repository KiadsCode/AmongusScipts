using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200025F RID: 607
[Token(Token = "0x200025F")]
public class VerticalGauge : MonoBehaviour
{
	// Token: 0x06000D9A RID: 3482 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D9A")]
	[Address(RVA = "0x7AEDB0", Offset = "0x7AE1B0", VA = "0x107AEDB0")]
	public void Update()
	{
	}

	// Token: 0x06000D9B RID: 3483 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D9B")]
	[Address(RVA = "0x3E8D00", Offset = "0x3E8100", VA = "0x103E8D00")]
	public VerticalGauge()
	{
	}

	// Token: 0x04000D72 RID: 3442
	[Token(Token = "0x4000D72")]
	[FieldOffset(Offset = "0xC")]
	public float value;

	// Token: 0x04000D73 RID: 3443
	[Token(Token = "0x4000D73")]
	[FieldOffset(Offset = "0x10")]
	public float MaxValue;

	// Token: 0x04000D74 RID: 3444
	[Token(Token = "0x4000D74")]
	[FieldOffset(Offset = "0x14")]
	public float maskScale;

	// Token: 0x04000D75 RID: 3445
	[Token(Token = "0x4000D75")]
	[FieldOffset(Offset = "0x18")]
	public SpriteMask Mask;

	// Token: 0x04000D76 RID: 3446
	[Token(Token = "0x4000D76")]
	[FieldOffset(Offset = "0x1C")]
	private float lastValue;
}
