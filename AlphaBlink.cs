using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020000C1 RID: 193
[Token(Token = "0x20000C1")]
public class AlphaBlink : MonoBehaviour
{
	// Token: 0x06000487 RID: 1159 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000487")]
	[Address(RVA = "0x547490", Offset = "0x546890", VA = "0x10547490")]
	public void SetColor(Color c)
	{
	}

	// Token: 0x06000488 RID: 1160 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000488")]
	[Address(RVA = "0x547580", Offset = "0x546980", VA = "0x10547580")]
	private void Start()
	{
	}

	// Token: 0x06000489 RID: 1161 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000489")]
	[Address(RVA = "0x547660", Offset = "0x546A60", VA = "0x10547660")]
	public void Update()
	{
	}

	// Token: 0x0600048A RID: 1162 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600048A")]
	[Address(RVA = "0x5479B0", Offset = "0x546DB0", VA = "0x105479B0")]
	public AlphaBlink()
	{
	}

	// Token: 0x0400050A RID: 1290
	[Token(Token = "0x400050A")]
	[FieldOffset(Offset = "0xC")]
	public float Period;

	// Token: 0x0400050B RID: 1291
	[Token(Token = "0x400050B")]
	[FieldOffset(Offset = "0x10")]
	public float Ratio;

	// Token: 0x0400050C RID: 1292
	[Token(Token = "0x400050C")]
	[FieldOffset(Offset = "0x14")]
	private SpriteRenderer rend;

	// Token: 0x0400050D RID: 1293
	[Token(Token = "0x400050D")]
	[FieldOffset(Offset = "0x18")]
	private MeshRenderer mesh;

	// Token: 0x0400050E RID: 1294
	[Token(Token = "0x400050E")]
	[FieldOffset(Offset = "0x1C")]
	private TextMeshPro tmPro;

	// Token: 0x0400050F RID: 1295
	[Token(Token = "0x400050F")]
	[FieldOffset(Offset = "0x20")]
	public FloatRange AlphaRange;

	// Token: 0x04000510 RID: 1296
	[Token(Token = "0x4000510")]
	[FieldOffset(Offset = "0x24")]
	public Color baseColor;
}
