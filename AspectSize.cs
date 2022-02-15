using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001C6 RID: 454
[Token(Token = "0x20001C6")]
public class AspectSize : MonoBehaviour
{
	// Token: 0x06000A45 RID: 2629 RVA: 0x00004860 File Offset: 0x00002A60
	[Token(Token = "0x6000A45")]
	[Address(RVA = "0x54CBC0", Offset = "0x54BFC0", VA = "0x1054CBC0")]
	public static float CalculateSize(Vector3 parentPos, Sprite sprite, float percentWidth)
	{
		return 0f;
	}

	// Token: 0x06000A46 RID: 2630 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A46")]
	[Address(RVA = "0x54CCE0", Offset = "0x54C0E0", VA = "0x1054CCE0")]
	private void OnEnable()
	{
	}

	// Token: 0x06000A47 RID: 2631 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A47")]
	[Address(RVA = "0x54CC70", Offset = "0x54C070", VA = "0x1054CC70")]
	private void OnDisable()
	{
	}

	// Token: 0x06000A48 RID: 2632 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A48")]
	[Address(RVA = "0x54C960", Offset = "0x54BD60", VA = "0x1054C960")]
	private void AdjustScale(float aspect)
	{
	}

	// Token: 0x06000A49 RID: 2633 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A49")]
	[Address(RVA = "0x54CD80", Offset = "0x54C180", VA = "0x1054CD80")]
	public AspectSize()
	{
	}

	// Token: 0x04000A63 RID: 2659
	[Token(Token = "0x4000A63")]
	[FieldOffset(Offset = "0xC")]
	public Sprite Background;

	// Token: 0x04000A64 RID: 2660
	[Token(Token = "0x4000A64")]
	[FieldOffset(Offset = "0x10")]
	public SpriteRenderer Renderer;

	// Token: 0x04000A65 RID: 2661
	[Token(Token = "0x4000A65")]
	[FieldOffset(Offset = "0x14")]
	public float PercentWidth;
}
