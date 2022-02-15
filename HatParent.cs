using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003E3 RID: 995
[Token(Token = "0x20003E3")]
public class HatParent : MonoBehaviour
{
	// Token: 0x170002E7 RID: 743
	// (get) Token: 0x0600149C RID: 5276 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600149D RID: 5277 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002E7")]
	public HatBehaviour Hat
	{
		[Token(Token = "0x600149C")]
		[Address(RVA = "0x277A30", Offset = "0x276E30", VA = "0x10277A30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600149D")]
		[Address(RVA = "0x277A50", Offset = "0x276E50", VA = "0x10277A50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		set
		{
		}
	}

	// Token: 0x170002E8 RID: 744
	// (set) Token: 0x0600149E RID: 5278 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002E8")]
	public Color color
	{
		[Token(Token = "0x600149E")]
		[Address(RVA = "0x3BB570", Offset = "0x3BA970", VA = "0x103BB570")]
		set
		{
		}
	}

	// Token: 0x170002E9 RID: 745
	// (set) Token: 0x0600149F RID: 5279 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002E9")]
	public bool flipX
	{
		[Token(Token = "0x600149F")]
		[Address(RVA = "0x3BB5C0", Offset = "0x3BA9C0", VA = "0x103BB5C0")]
		set
		{
		}
	}

	// Token: 0x060014A0 RID: 5280 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014A0")]
	[Address(RVA = "0x3BB1F0", Offset = "0x3BA5F0", VA = "0x103BB1F0")]
	public void SetHat(HatBehaviour hat, int color)
	{
	}

	// Token: 0x060014A1 RID: 5281 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014A1")]
	[Address(RVA = "0x3BB100", Offset = "0x3BA500", VA = "0x103BB100")]
	public void SetHat(int color)
	{
	}

	// Token: 0x060014A2 RID: 5282 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014A2")]
	[Address(RVA = "0x3BB210", Offset = "0x3BA610", VA = "0x103BB210")]
	public void SetIdleAnim()
	{
	}

	// Token: 0x060014A3 RID: 5283 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014A3")]
	[Address(RVA = "0x3BB170", Offset = "0x3BA570", VA = "0x103BB170")]
	public void SetHat(string hatId, int color)
	{
	}

	// Token: 0x060014A4 RID: 5284 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014A4")]
	[Address(RVA = "0x3BB0A0", Offset = "0x3BA4A0", VA = "0x103BB0A0")]
	internal void SetFloorAnim()
	{
	}

	// Token: 0x060014A5 RID: 5285 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014A5")]
	[Address(RVA = "0x3BAFD0", Offset = "0x3BA3D0", VA = "0x103BAFD0")]
	internal void SetClimbAnim()
	{
	}

	// Token: 0x060014A6 RID: 5286 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014A6")]
	[Address(RVA = "0x3BAC10", Offset = "0x3BA010", VA = "0x103BAC10")]
	public void LateUpdate()
	{
	}

	// Token: 0x060014A7 RID: 5287 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014A7")]
	[Address(RVA = "0x3BB030", Offset = "0x3BA430", VA = "0x103BB030")]
	internal void SetColor(int color)
	{
	}

	// Token: 0x060014A8 RID: 5288 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014A8")]
	[Address(RVA = "0x3BB4E0", Offset = "0x3BA8E0", VA = "0x103BB4E0")]
	internal void SetMaskLayer(int layer)
	{
	}

	// Token: 0x060014A9 RID: 5289 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014A9")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public HatParent()
	{
	}

	// Token: 0x04001541 RID: 5441
	[Token(Token = "0x4001541")]
	[FieldOffset(Offset = "0xC")]
	public SpriteRenderer BackLayer;

	// Token: 0x04001542 RID: 5442
	[Token(Token = "0x4001542")]
	[FieldOffset(Offset = "0x10")]
	public SpriteRenderer FrontLayer;

	// Token: 0x04001543 RID: 5443
	[Token(Token = "0x4001543")]
	[FieldOffset(Offset = "0x14")]
	public SpriteRenderer Parent;

	// Token: 0x04001544 RID: 5444
	[Token(Token = "0x4001544")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private HatBehaviour <Hat>k__BackingField;
}
