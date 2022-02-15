using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000B8 RID: 184
[Token(Token = "0x20000B8")]
[Attribute(Name = "RequireComponent", RVA = "0xE6340", Offset = "0xE5740")]
[Attribute(Name = "RequireComponent", RVA = "0xE6340", Offset = "0xE5740")]
public class RadioWaveBehaviour : MonoBehaviour
{
	// Token: 0x06000456 RID: 1110 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000456")]
	[Address(RVA = "0x4F00F0", Offset = "0x4EF4F0", VA = "0x104F00F0")]
	public void Start()
	{
	}

	// Token: 0x06000457 RID: 1111 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000457")]
	[Address(RVA = "0x4F02E0", Offset = "0x4EF6E0", VA = "0x104F02E0")]
	public void Update()
	{
	}

	// Token: 0x06000458 RID: 1112 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000458")]
	[Address(RVA = "0x4F04D0", Offset = "0x4EF8D0", VA = "0x104F04D0")]
	public RadioWaveBehaviour()
	{
	}

	// Token: 0x040004B7 RID: 1207
	[Token(Token = "0x40004B7")]
	[FieldOffset(Offset = "0xC")]
	public int NumPoints;

	// Token: 0x040004B8 RID: 1208
	[Token(Token = "0x40004B8")]
	[FieldOffset(Offset = "0x10")]
	public FloatRange Width;

	// Token: 0x040004B9 RID: 1209
	[Token(Token = "0x40004B9")]
	[FieldOffset(Offset = "0x14")]
	public FloatRange Height;

	// Token: 0x040004BA RID: 1210
	[Token(Token = "0x40004BA")]
	[FieldOffset(Offset = "0x18")]
	private Mesh mesh;

	// Token: 0x040004BB RID: 1211
	[Token(Token = "0x40004BB")]
	[FieldOffset(Offset = "0x1C")]
	private Vector3[] vecs;

	// Token: 0x040004BC RID: 1212
	[Token(Token = "0x40004BC")]
	[FieldOffset(Offset = "0x20")]
	public float TickRate;

	// Token: 0x040004BD RID: 1213
	[Token(Token = "0x40004BD")]
	[FieldOffset(Offset = "0x24")]
	private float timer;

	// Token: 0x040004BE RID: 1214
	[Token(Token = "0x40004BE")]
	[FieldOffset(Offset = "0x28")]
	public int Skip;

	// Token: 0x040004BF RID: 1215
	[Token(Token = "0x40004BF")]
	[FieldOffset(Offset = "0x2C")]
	public float Frequency;

	// Token: 0x040004C0 RID: 1216
	[Token(Token = "0x40004C0")]
	[FieldOffset(Offset = "0x30")]
	private int Tick;

	// Token: 0x040004C1 RID: 1217
	[Token(Token = "0x40004C1")]
	[FieldOffset(Offset = "0x34")]
	public bool Random;

	// Token: 0x040004C2 RID: 1218
	[Token(Token = "0x40004C2")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "RangeAttribute", RVA = "0xDF920", Offset = "0xDED20")]
	public float NoiseLevel;
}
