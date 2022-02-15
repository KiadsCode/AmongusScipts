using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200023F RID: 575
[Token(Token = "0x200023F")]
public abstract class PassiveUiElement : UiElement
{
	// Token: 0x170001DB RID: 475
	// (get) Token: 0x06000CCA RID: 3274 RVA: 0x00005070 File Offset: 0x00003270
	[Token(Token = "0x170001DB")]
	public virtual bool HandleUp
	{
		[Token(Token = "0x6000CCA")]
		[Address(RVA = "0x2D7E70", Offset = "0x2D7270", VA = "0x102D7E70", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001DC RID: 476
	// (get) Token: 0x06000CCB RID: 3275 RVA: 0x00005088 File Offset: 0x00003288
	[Token(Token = "0x170001DC")]
	public virtual bool HandleDown
	{
		[Token(Token = "0x6000CCB")]
		[Address(RVA = "0x2D7E70", Offset = "0x2D7270", VA = "0x102D7E70", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001DD RID: 477
	// (get) Token: 0x06000CCC RID: 3276 RVA: 0x000050A0 File Offset: 0x000032A0
	[Token(Token = "0x170001DD")]
	public virtual bool HandleRepeat
	{
		[Token(Token = "0x6000CCC")]
		[Address(RVA = "0x2D7E70", Offset = "0x2D7270", VA = "0x102D7E70", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001DE RID: 478
	// (get) Token: 0x06000CCD RID: 3277 RVA: 0x000050B8 File Offset: 0x000032B8
	[Token(Token = "0x170001DE")]
	public virtual bool HandleDrag
	{
		[Token(Token = "0x6000CCD")]
		[Address(RVA = "0x2D7E70", Offset = "0x2D7270", VA = "0x102D7E70", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001DF RID: 479
	// (get) Token: 0x06000CCE RID: 3278 RVA: 0x000050D0 File Offset: 0x000032D0
	[Token(Token = "0x170001DF")]
	public virtual bool HandleOverOut
	{
		[Token(Token = "0x6000CCE")]
		[Address(RVA = "0x2EDC10", Offset = "0x2ED010", VA = "0x102EDC10", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001E0 RID: 480
	// (get) Token: 0x06000CCF RID: 3279 RVA: 0x000050E8 File Offset: 0x000032E8
	// (set) Token: 0x06000CD0 RID: 3280 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001E0")]
	public float CachedZ
	{
		[Token(Token = "0x6000CCF")]
		[Address(RVA = "0x3BEE50", Offset = "0x3BE250", VA = "0x103BEE50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000CD0")]
		[Address(RVA = "0x327F10", Offset = "0x327310", VA = "0x10327F10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		set
		{
		}
	}

	// Token: 0x06000CD1 RID: 3281 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CD1")]
	[Address(RVA = "0x659060", Offset = "0x658460", VA = "0x10659060")]
	public void Start()
	{
	}

	// Token: 0x06000CD2 RID: 3282 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CD2")]
	[Address(RVA = "0x658FD0", Offset = "0x6583D0", VA = "0x10658FD0")]
	public void OnDestroy()
	{
	}

	// Token: 0x06000CD3 RID: 3283 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CD3")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "11")]
	public virtual void ReceiveClickDown()
	{
	}

	// Token: 0x06000CD4 RID: 3284 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CD4")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "12")]
	public virtual void ReceiveRepeatDown()
	{
	}

	// Token: 0x06000CD5 RID: 3285 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CD5")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "13")]
	public virtual void ReceiveClickUp()
	{
	}

	// Token: 0x06000CD6 RID: 3286 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CD6")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "14")]
	public virtual void ReceiveClickDrag(Vector2 dragDelta)
	{
	}

	// Token: 0x06000CD7 RID: 3287 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CD7")]
	[Address(RVA = "0x659100", Offset = "0x658500", VA = "0x10659100")]
	protected PassiveUiElement()
	{
	}

	// Token: 0x04000CB8 RID: 3256
	[Token(Token = "0x4000CB8")]
	[FieldOffset(Offset = "0x28")]
	public Collider2D ClickMask;

	// Token: 0x04000CB9 RID: 3257
	[Token(Token = "0x4000CB9")]
	[FieldOffset(Offset = "0x2C")]
	public Collider2D[] Colliders;

	// Token: 0x04000CBA RID: 3258
	[Token(Token = "0x4000CBA")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private float <CachedZ>k__BackingField;
}
