using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000260 RID: 608
[Token(Token = "0x2000260")]
public class VerticalSpriteGauge : MonoBehaviour
{
	// Token: 0x17000206 RID: 518
	// (get) Token: 0x06000D9C RID: 3484 RVA: 0x000053B8 File Offset: 0x000035B8
	// (set) Token: 0x06000D9D RID: 3485 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000206")]
	public float TopY
	{
		[Token(Token = "0x6000D9C")]
		[Address(RVA = "0x365CD0", Offset = "0x3650D0", VA = "0x10365CD0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000D9D")]
		[Address(RVA = "0x7AF160", Offset = "0x7AE560", VA = "0x107AF160")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private set
		{
		}
	}

	// Token: 0x06000D9E RID: 3486 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D9E")]
	[Address(RVA = "0x7AEF60", Offset = "0x7AE360", VA = "0x107AEF60")]
	public void Update()
	{
	}

	// Token: 0x06000D9F RID: 3487 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D9F")]
	[Address(RVA = "0x7AF130", Offset = "0x7AE530", VA = "0x107AF130")]
	public VerticalSpriteGauge()
	{
	}

	// Token: 0x04000D77 RID: 3447
	[Token(Token = "0x4000D77")]
	[FieldOffset(Offset = "0xC")]
	public float Value;

	// Token: 0x04000D78 RID: 3448
	[Token(Token = "0x4000D78")]
	[FieldOffset(Offset = "0x10")]
	public float MaxValue;

	// Token: 0x04000D79 RID: 3449
	[Token(Token = "0x4000D79")]
	[FieldOffset(Offset = "0x14")]
	public FloatRange YRange;

	// Token: 0x04000D7A RID: 3450
	[Token(Token = "0x4000D7A")]
	[FieldOffset(Offset = "0x18")]
	public SpriteRenderer Mask;

	// Token: 0x04000D7B RID: 3451
	[Token(Token = "0x4000D7B")]
	[FieldOffset(Offset = "0x1C")]
	private float lastValue;

	// Token: 0x04000D7C RID: 3452
	[Token(Token = "0x4000D7C")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private float <TopY>k__BackingField;
}
