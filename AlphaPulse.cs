using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000C2 RID: 194
[Token(Token = "0x20000C2")]
public class AlphaPulse : MonoBehaviour
{
	// Token: 0x0600048B RID: 1163 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600048B")]
	[Address(RVA = "0x547A40", Offset = "0x546E40", VA = "0x10547A40")]
	public void SetColor(Color c)
	{
	}

	// Token: 0x0600048C RID: 1164 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600048C")]
	[Address(RVA = "0x547AB0", Offset = "0x546EB0", VA = "0x10547AB0")]
	private void Start()
	{
	}

	// Token: 0x0600048D RID: 1165 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600048D")]
	[Address(RVA = "0x547B10", Offset = "0x546F10", VA = "0x10547B10")]
	public void Update()
	{
	}

	// Token: 0x0600048E RID: 1166 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600048E")]
	[Address(RVA = "0x547D60", Offset = "0x547160", VA = "0x10547D60")]
	public AlphaPulse()
	{
	}

	// Token: 0x04000511 RID: 1297
	[Token(Token = "0x4000511")]
	[FieldOffset(Offset = "0xC")]
	public float Offset;

	// Token: 0x04000512 RID: 1298
	[Token(Token = "0x4000512")]
	[FieldOffset(Offset = "0x10")]
	public float Duration;

	// Token: 0x04000513 RID: 1299
	[Token(Token = "0x4000513")]
	[FieldOffset(Offset = "0x14")]
	private SpriteRenderer rend;

	// Token: 0x04000514 RID: 1300
	[Token(Token = "0x4000514")]
	[FieldOffset(Offset = "0x18")]
	private MeshRenderer mesh;

	// Token: 0x04000515 RID: 1301
	[Token(Token = "0x4000515")]
	[FieldOffset(Offset = "0x1C")]
	public FloatRange AlphaRange;

	// Token: 0x04000516 RID: 1302
	[Token(Token = "0x4000516")]
	[FieldOffset(Offset = "0x20")]
	public Color baseColor;
}
