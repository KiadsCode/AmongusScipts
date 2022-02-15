using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000420 RID: 1056
[Token(Token = "0x2000420")]
public class QuadGen : MonoBehaviour
{
	// Token: 0x06001633 RID: 5683 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001633")]
	[Address(RVA = "0x514DA0", Offset = "0x5141A0", VA = "0x10514DA0")]
	[Attribute(Name = "ContextMenu", RVA = "0xDF950", Offset = "0xDED50")]
	public void Generate()
	{
	}

	// Token: 0x06001634 RID: 5684 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001634")]
	[Address(RVA = "0x515130", Offset = "0x514530", VA = "0x10515130")]
	public QuadGen()
	{
	}

	// Token: 0x04001691 RID: 5777
	[Token(Token = "0x4001691")]
	[FieldOffset(Offset = "0xC")]
	public float Width;

	// Token: 0x04001692 RID: 5778
	[Token(Token = "0x4001692")]
	[FieldOffset(Offset = "0x10")]
	public float Height;

	// Token: 0x04001693 RID: 5779
	[Token(Token = "0x4001693")]
	[FieldOffset(Offset = "0x14")]
	public int WidthSubdivisions;

	// Token: 0x04001694 RID: 5780
	[Token(Token = "0x4001694")]
	[FieldOffset(Offset = "0x18")]
	public int HeightSubdivisions;

	// Token: 0x04001695 RID: 5781
	[Token(Token = "0x4001695")]
	[FieldOffset(Offset = "0x1C")]
	public float PerlinFreqX;
}
