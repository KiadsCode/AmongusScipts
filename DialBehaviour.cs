using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000B7 RID: 183
[Token(Token = "0x20000B7")]
public class DialBehaviour : MonoBehaviour
{
	// Token: 0x06000453 RID: 1107 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000453")]
	[Address(RVA = "0x5C6780", Offset = "0x5C5B80", VA = "0x105C6780")]
	public void Update()
	{
	}

	// Token: 0x06000454 RID: 1108 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000454")]
	[Address(RVA = "0x5C6700", Offset = "0x5C5B00", VA = "0x105C6700")]
	public void SetValue(float angle)
	{
	}

	// Token: 0x06000455 RID: 1109 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000455")]
	[Address(RVA = "0x5C6940", Offset = "0x5C5D40", VA = "0x105C6940")]
	public DialBehaviour()
	{
	}

	// Token: 0x040004B0 RID: 1200
	[Token(Token = "0x40004B0")]
	[FieldOffset(Offset = "0xC")]
	public FloatRange DialRange;

	// Token: 0x040004B1 RID: 1201
	[Token(Token = "0x40004B1")]
	[FieldOffset(Offset = "0x10")]
	public Collider2D collider;

	// Token: 0x040004B2 RID: 1202
	[Token(Token = "0x40004B2")]
	[FieldOffset(Offset = "0x14")]
	public Controller myController;

	// Token: 0x040004B3 RID: 1203
	[Token(Token = "0x40004B3")]
	[FieldOffset(Offset = "0x18")]
	public float Value;

	// Token: 0x040004B4 RID: 1204
	[Token(Token = "0x40004B4")]
	[FieldOffset(Offset = "0x1C")]
	public bool Engaged;

	// Token: 0x040004B5 RID: 1205
	[Token(Token = "0x40004B5")]
	[FieldOffset(Offset = "0x20")]
	public Transform DialTrans;

	// Token: 0x040004B6 RID: 1206
	[Token(Token = "0x40004B6")]
	[FieldOffset(Offset = "0x24")]
	public Transform DialShadTrans;
}
