using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000161 RID: 353
[Token(Token = "0x2000161")]
public class Wire : MonoBehaviour
{
	// Token: 0x17000139 RID: 313
	// (get) Token: 0x06000811 RID: 2065 RVA: 0x000040F8 File Offset: 0x000022F8
	// (set) Token: 0x06000812 RID: 2066 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000139")]
	public Vector2 BaseWorldPos
	{
		[Token(Token = "0x6000811")]
		[Address(RVA = "0x7BD990", Offset = "0x7BCD90", VA = "0x107BD990")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x6000812")]
		[Address(RVA = "0x2D84F0", Offset = "0x2D78F0", VA = "0x102D84F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		internal set
		{
		}
	}

	// Token: 0x06000813 RID: 2067 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000813")]
	[Address(RVA = "0x7BD930", Offset = "0x7BCD30", VA = "0x107BD930")]
	public void Start()
	{
	}

	// Token: 0x06000814 RID: 2068 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000814")]
	[Address(RVA = "0x7BD4F0", Offset = "0x7BC8F0", VA = "0x107BD4F0")]
	public void ResetLine(Vector3 targetWorldPos, bool reset = false)
	{
	}

	// Token: 0x06000815 RID: 2069 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000815")]
	[Address(RVA = "0x7BD490", Offset = "0x7BC890", VA = "0x107BD490")]
	public void ConnectRight(WireNode node)
	{
	}

	// Token: 0x06000816 RID: 2070 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000816")]
	[Address(RVA = "0x7BD870", Offset = "0x7BCC70", VA = "0x107BD870")]
	public void SetColor(Color color, Sprite symbol)
	{
	}

	// Token: 0x06000817 RID: 2071 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000817")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public Wire()
	{
	}

	// Token: 0x0400080E RID: 2062
	[Token(Token = "0x400080E")]
	private const int WireDepth = -14;

	// Token: 0x0400080F RID: 2063
	[Token(Token = "0x400080F")]
	[FieldOffset(Offset = "0xC")]
	public SpriteRenderer Liner;

	// Token: 0x04000810 RID: 2064
	[Token(Token = "0x4000810")]
	[FieldOffset(Offset = "0x10")]
	public SpriteRenderer ColorBase;

	// Token: 0x04000811 RID: 2065
	[Token(Token = "0x4000811")]
	[FieldOffset(Offset = "0x14")]
	public SpriteRenderer SymbolBase;

	// Token: 0x04000812 RID: 2066
	[Token(Token = "0x4000812")]
	[FieldOffset(Offset = "0x18")]
	public SpriteRenderer ColorEnd;

	// Token: 0x04000813 RID: 2067
	[Token(Token = "0x4000813")]
	[FieldOffset(Offset = "0x1C")]
	public Collider2D hitbox;

	// Token: 0x04000814 RID: 2068
	[Token(Token = "0x4000814")]
	[FieldOffset(Offset = "0x20")]
	public SpriteRenderer WireTip;

	// Token: 0x04000815 RID: 2069
	[Token(Token = "0x4000815")]
	[FieldOffset(Offset = "0x24")]
	public sbyte WireId;

	// Token: 0x04000816 RID: 2070
	[Token(Token = "0x4000816")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private Vector2 <BaseWorldPos>k__BackingField;
}
