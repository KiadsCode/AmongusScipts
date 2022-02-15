using System;
using Il2CppDummyDll;
using PowerTools;
using UnityEngine;

// Token: 0x02000418 RID: 1048
[Token(Token = "0x2000418")]
public class SkinLayer : MonoBehaviour
{
	// Token: 0x17000317 RID: 791
	// (set) Token: 0x06001609 RID: 5641 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000317")]
	public bool Flipped
	{
		[Token(Token = "0x6001609")]
		[Address(RVA = "0x49F940", Offset = "0x49ED40", VA = "0x1049F940")]
		set
		{
		}
	}

	// Token: 0x17000318 RID: 792
	// (set) Token: 0x0600160A RID: 5642 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000318")]
	public bool Visible
	{
		[Token(Token = "0x600160A")]
		[Address(RVA = "0x49FB70", Offset = "0x49EF70", VA = "0x1049FB70")]
		set
		{
		}
	}

	// Token: 0x0600160B RID: 5643 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600160B")]
	[Address(RVA = "0x49F550", Offset = "0x49E950", VA = "0x1049F550")]
	public void SetMaskLayer(int layer)
	{
	}

	// Token: 0x0600160C RID: 5644 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600160C")]
	[Address(RVA = "0x49F5B0", Offset = "0x49E9B0", VA = "0x1049F5B0")]
	public void SetRun(bool isLeft)
	{
	}

	// Token: 0x0600160D RID: 5645 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600160D")]
	[Address(RVA = "0x49F7F0", Offset = "0x49EBF0", VA = "0x1049F7F0")]
	public void SetSpawn(bool isLeft, float time = 0f)
	{
	}

	// Token: 0x0600160E RID: 5646 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600160E")]
	[Address(RVA = "0x49EFD0", Offset = "0x49E3D0", VA = "0x1049EFD0")]
	internal void SetClimb(bool down)
	{
	}

	// Token: 0x0600160F RID: 5647 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600160F")]
	[Address(RVA = "0x49F200", Offset = "0x49E600", VA = "0x1049F200")]
	public void SetExitVent(bool isLeft)
	{
	}

	// Token: 0x06001610 RID: 5648 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001610")]
	[Address(RVA = "0x49F0C0", Offset = "0x49E4C0", VA = "0x1049F0C0")]
	public void SetEnterVent(bool isLeft)
	{
	}

	// Token: 0x06001611 RID: 5649 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001611")]
	[Address(RVA = "0x49F3D0", Offset = "0x49E7D0", VA = "0x1049F3D0")]
	public void SetIdle(bool isLeft)
	{
	}

	// Token: 0x06001612 RID: 5650 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001612")]
	[Address(RVA = "0x49F340", Offset = "0x49E740", VA = "0x1049F340")]
	public void SetGhost()
	{
	}

	// Token: 0x06001613 RID: 5651 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001613")]
	[Address(RVA = "0x49F790", Offset = "0x49EB90", VA = "0x1049F790")]
	internal void SetSkin(string skinId, bool isLeft)
	{
	}

	// Token: 0x06001614 RID: 5652 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001614")]
	[Address(RVA = "0x49F770", Offset = "0x49EB70", VA = "0x1049F770")]
	internal void SetSkin(SkinData skin, bool isLeft)
	{
	}

	// Token: 0x06001615 RID: 5653 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001615")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public SkinLayer()
	{
	}

	// Token: 0x0400166E RID: 5742
	[Token(Token = "0x400166E")]
	[FieldOffset(Offset = "0xC")]
	public SpriteRenderer layer;

	// Token: 0x0400166F RID: 5743
	[Token(Token = "0x400166F")]
	[FieldOffset(Offset = "0x10")]
	public SpriteAnim animator;

	// Token: 0x04001670 RID: 5744
	[Token(Token = "0x4001670")]
	[FieldOffset(Offset = "0x14")]
	public SkinData skin;
}
