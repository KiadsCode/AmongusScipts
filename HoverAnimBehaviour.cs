using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001B2 RID: 434
[Token(Token = "0x20001B2")]
public class HoverAnimBehaviour : MonoBehaviour
{
	// Token: 0x060009DE RID: 2526 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009DE")]
	[Address(RVA = "0x3E9110", Offset = "0x3E8510", VA = "0x103E9110")]
	private void Start()
	{
	}

	// Token: 0x060009DF RID: 2527 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009DF")]
	[Address(RVA = "0x3E9140", Offset = "0x3E8540", VA = "0x103E9140")]
	private void Update()
	{
	}

	// Token: 0x060009E0 RID: 2528 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009E0")]
	[Address(RVA = "0x3E9200", Offset = "0x3E8600", VA = "0x103E9200")]
	public HoverAnimBehaviour()
	{
	}

	// Token: 0x040009F8 RID: 2552
	[Token(Token = "0x40009F8")]
	[FieldOffset(Offset = "0xC")]
	public FloatRange YMovement;

	// Token: 0x040009F9 RID: 2553
	[Token(Token = "0x40009F9")]
	[FieldOffset(Offset = "0x10")]
	public float Speed;

	// Token: 0x040009FA RID: 2554
	[Token(Token = "0x40009FA")]
	[FieldOffset(Offset = "0x14")]
	public float Shift;

	// Token: 0x040009FB RID: 2555
	[Token(Token = "0x40009FB")]
	[FieldOffset(Offset = "0x18")]
	private float offset;
}
