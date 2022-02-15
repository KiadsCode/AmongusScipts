using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000258 RID: 600
[Token(Token = "0x2000258")]
[Attribute(Name = "RequireComponent", RVA = "0xE3B30", Offset = "0xE2F30")]
[Attribute(Name = "RequireComponent", RVA = "0xE3B30", Offset = "0xE2F30")]
public class TextController : MonoBehaviour
{
	// Token: 0x06000D78 RID: 3448 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D78")]
	[Address(RVA = "0x4AB610", Offset = "0x4AAA10", VA = "0x104AB610")]
	public void Update()
	{
	}

	// Token: 0x06000D79 RID: 3449 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D79")]
	[Address(RVA = "0x4ABE30", Offset = "0x4AB230", VA = "0x104ABE30")]
	public TextController()
	{
	}

	// Token: 0x04000D4F RID: 3407
	[Token(Token = "0x4000D4F")]
	[FieldOffset(Offset = "0xC")]
	public float Scale;

	// Token: 0x04000D50 RID: 3408
	[Token(Token = "0x4000D50")]
	[FieldOffset(Offset = "0x10")]
	[Multiline]
	public string Text;

	// Token: 0x04000D51 RID: 3409
	[Token(Token = "0x4000D51")]
	[FieldOffset(Offset = "0x14")]
	private string displaying;

	// Token: 0x04000D52 RID: 3410
	[Token(Token = "0x4000D52")]
	[FieldOffset(Offset = "0x18")]
	[HideInInspector]
	private Texture2D texture;

	// Token: 0x04000D53 RID: 3411
	[Token(Token = "0x4000D53")]
	[FieldOffset(Offset = "0x1C")]
	[HideInInspector]
	private Texture2D colorTexture;

	// Token: 0x04000D54 RID: 3412
	[Token(Token = "0x4000D54")]
	[FieldOffset(Offset = "0x20")]
	private MeshRenderer rend;

	// Token: 0x04000D55 RID: 3413
	[Token(Token = "0x4000D55")]
	[FieldOffset(Offset = "0x24")]
	private float _scale;

	// Token: 0x04000D56 RID: 3414
	[Token(Token = "0x4000D56")]
	[FieldOffset(Offset = "0x28")]
	public Color Color;

	// Token: 0x04000D57 RID: 3415
	[Token(Token = "0x4000D57")]
	[FieldOffset(Offset = "0x38")]
	private Color lastColor;

	// Token: 0x04000D58 RID: 3416
	[Token(Token = "0x4000D58")]
	[FieldOffset(Offset = "0x48")]
	public Vector3 Offset;

	// Token: 0x04000D59 RID: 3417
	[Token(Token = "0x4000D59")]
	[FieldOffset(Offset = "0x54")]
	public bool topAligned;
}
