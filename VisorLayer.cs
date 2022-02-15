using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000419 RID: 1049
[Token(Token = "0x2000419")]
public class VisorLayer : MonoBehaviour
{
	// Token: 0x17000319 RID: 793
	// (set) Token: 0x06001616 RID: 5654 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000319")]
	public Color color
	{
		[Token(Token = "0x6001616")]
		[Address(RVA = "0x540D50", Offset = "0x540150", VA = "0x10540D50")]
		set
		{
		}
	}

	// Token: 0x06001617 RID: 5655 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001617")]
	[Address(RVA = "0x7B2860", Offset = "0x7B1C60", VA = "0x107B2860")]
	public void SetVisor(string visorId)
	{
	}

	// Token: 0x06001618 RID: 5656 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001618")]
	[Address(RVA = "0x7B2820", Offset = "0x7B1C20", VA = "0x107B2820")]
	public void SetVisor(VisorData data)
	{
	}

	// Token: 0x06001619 RID: 5657 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001619")]
	[Address(RVA = "0x7B26B0", Offset = "0x7B1AB0", VA = "0x107B26B0")]
	public void SetFlipX(bool flipX)
	{
	}

	// Token: 0x0600161A RID: 5658 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600161A")]
	[Address(RVA = "0x7B27A0", Offset = "0x7B1BA0", VA = "0x107B27A0")]
	public void SetFloorAnim()
	{
	}

	// Token: 0x0600161B RID: 5659 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600161B")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public VisorLayer()
	{
	}

	// Token: 0x04001671 RID: 5745
	[Token(Token = "0x4001671")]
	[FieldOffset(Offset = "0xC")]
	public SpriteRenderer Image;

	// Token: 0x04001672 RID: 5746
	[Token(Token = "0x4001672")]
	[FieldOffset(Offset = "0x10")]
	private VisorData currentVisor;
}
