using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x0200020D RID: 525
[Token(Token = "0x200020D")]
public class MapCountOverlay : MonoBehaviour
{
	// Token: 0x06000BB4 RID: 2996 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BB4")]
	[Address(RVA = "0x6E5710", Offset = "0x6E4B10", VA = "0x106E5710")]
	public void Awake()
	{
	}

	// Token: 0x06000BB5 RID: 2997 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BB5")]
	[Address(RVA = "0x6E57F0", Offset = "0x6E4BF0", VA = "0x106E57F0")]
	public void OnEnable()
	{
	}

	// Token: 0x06000BB6 RID: 2998 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BB6")]
	[Address(RVA = "0x6E5780", Offset = "0x6E4B80", VA = "0x106E5780")]
	public void OnDisable()
	{
	}

	// Token: 0x06000BB7 RID: 2999 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BB7")]
	[Address(RVA = "0x6E58D0", Offset = "0x6E4CD0", VA = "0x106E58D0")]
	public void Update()
	{
	}

	// Token: 0x06000BB8 RID: 3000 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BB8")]
	[Address(RVA = "0x6E5E00", Offset = "0x6E5200", VA = "0x106E5E00")]
	public MapCountOverlay()
	{
	}

	// Token: 0x04000BBF RID: 3007
	[Token(Token = "0x4000BBF")]
	[FieldOffset(Offset = "0xC")]
	public AlphaPulse BackgroundColor;

	// Token: 0x04000BC0 RID: 3008
	[Token(Token = "0x4000BC0")]
	[FieldOffset(Offset = "0x10")]
	public TextMeshPro SabotageText;

	// Token: 0x04000BC1 RID: 3009
	[Token(Token = "0x4000BC1")]
	[FieldOffset(Offset = "0x14")]
	public CounterArea[] CountAreas;

	// Token: 0x04000BC2 RID: 3010
	[Token(Token = "0x4000BC2")]
	[FieldOffset(Offset = "0x18")]
	private Collider2D[] buffer;

	// Token: 0x04000BC3 RID: 3011
	[Token(Token = "0x4000BC3")]
	[FieldOffset(Offset = "0x1C")]
	private ContactFilter2D filter;

	// Token: 0x04000BC4 RID: 3012
	[Token(Token = "0x4000BC4")]
	[FieldOffset(Offset = "0x38")]
	private float timer;

	// Token: 0x04000BC5 RID: 3013
	[Token(Token = "0x4000BC5")]
	[FieldOffset(Offset = "0x3C")]
	private bool isSab;
}
