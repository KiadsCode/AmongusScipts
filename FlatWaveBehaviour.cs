using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200015E RID: 350
[Token(Token = "0x200015E")]
[Attribute(Name = "RequireComponent", RVA = "0xDF870", Offset = "0xDEC70")]
[Attribute(Name = "RequireComponent", RVA = "0xDF870", Offset = "0xDEC70")]
public class FlatWaveBehaviour : MonoBehaviour
{
	// Token: 0x060007FF RID: 2047 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007FF")]
	[Address(RVA = "0x3A7970", Offset = "0x3A6D70", VA = "0x103A7970")]
	public void Start()
	{
	}

	// Token: 0x06000800 RID: 2048 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000800")]
	[Address(RVA = "0x3A7B90", Offset = "0x3A6F90", VA = "0x103A7B90")]
	public void Update()
	{
	}

	// Token: 0x06000801 RID: 2049 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000801")]
	[Address(RVA = "0x3A7CF0", Offset = "0x3A70F0", VA = "0x103A7CF0")]
	public FlatWaveBehaviour()
	{
	}

	// Token: 0x040007ED RID: 2029
	[Token(Token = "0x40007ED")]
	[FieldOffset(Offset = "0xC")]
	public int NumPoints;

	// Token: 0x040007EE RID: 2030
	[Token(Token = "0x40007EE")]
	[FieldOffset(Offset = "0x10")]
	public FloatRange Width;

	// Token: 0x040007EF RID: 2031
	[Token(Token = "0x40007EF")]
	[FieldOffset(Offset = "0x14")]
	public FloatRange Delta;

	// Token: 0x040007F0 RID: 2032
	[Token(Token = "0x40007F0")]
	[FieldOffset(Offset = "0x18")]
	public float Center;

	// Token: 0x040007F1 RID: 2033
	[Token(Token = "0x40007F1")]
	[FieldOffset(Offset = "0x1C")]
	private Mesh mesh;

	// Token: 0x040007F2 RID: 2034
	[Token(Token = "0x40007F2")]
	[FieldOffset(Offset = "0x20")]
	private Vector3[] vecs;

	// Token: 0x040007F3 RID: 2035
	[Token(Token = "0x40007F3")]
	[FieldOffset(Offset = "0x24")]
	public float TickRate;

	// Token: 0x040007F4 RID: 2036
	[Token(Token = "0x40007F4")]
	[FieldOffset(Offset = "0x28")]
	private float timer;

	// Token: 0x040007F5 RID: 2037
	[Token(Token = "0x40007F5")]
	[FieldOffset(Offset = "0x2C")]
	public int Skip;

	// Token: 0x040007F6 RID: 2038
	[Token(Token = "0x40007F6")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "RangeAttribute", RVA = "0xDF920", Offset = "0xDED20")]
	public float NoiseP;
}
