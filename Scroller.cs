using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000241 RID: 577
[Token(Token = "0x2000241")]
public class Scroller : PassiveUiElement
{
	// Token: 0x170001E2 RID: 482
	// (get) Token: 0x06000CDD RID: 3293 RVA: 0x00005118 File Offset: 0x00003318
	[Token(Token = "0x170001E2")]
	public override bool HandleUp
	{
		[Token(Token = "0x6000CDD")]
		[Address(RVA = "0x2EDC10", Offset = "0x2ED010", VA = "0x102EDC10", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001E3 RID: 483
	// (get) Token: 0x06000CDE RID: 3294 RVA: 0x00005130 File Offset: 0x00003330
	[Token(Token = "0x170001E3")]
	public override bool HandleDown
	{
		[Token(Token = "0x6000CDE")]
		[Address(RVA = "0x2EDC10", Offset = "0x2ED010", VA = "0x102EDC10", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001E4 RID: 484
	// (get) Token: 0x06000CDF RID: 3295 RVA: 0x00005148 File Offset: 0x00003348
	[Token(Token = "0x170001E4")]
	public override bool HandleDrag
	{
		[Token(Token = "0x6000CDF")]
		[Address(RVA = "0x2EDC10", Offset = "0x2ED010", VA = "0x102EDC10", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001E5 RID: 485
	// (get) Token: 0x06000CE0 RID: 3296 RVA: 0x00005160 File Offset: 0x00003360
	[Token(Token = "0x170001E5")]
	public override bool HandleOverOut
	{
		[Token(Token = "0x6000CE0")]
		[Address(RVA = "0x2D7E70", Offset = "0x2D7270", VA = "0x102D7E70", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001E6 RID: 486
	// (get) Token: 0x06000CE1 RID: 3297 RVA: 0x00005178 File Offset: 0x00003378
	[Token(Token = "0x170001E6")]
	public bool AtTop
	{
		[Token(Token = "0x6000CE1")]
		[Address(RVA = "0x58DCB0", Offset = "0x58D0B0", VA = "0x1058DCB0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001E7 RID: 487
	// (get) Token: 0x06000CE2 RID: 3298 RVA: 0x00005190 File Offset: 0x00003390
	[Token(Token = "0x170001E7")]
	public bool AtBottom
	{
		[Token(Token = "0x6000CE2")]
		[Address(RVA = "0x58DBB0", Offset = "0x58CFB0", VA = "0x1058DBB0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001E8 RID: 488
	// (get) Token: 0x06000CE3 RID: 3299 RVA: 0x000051A8 File Offset: 0x000033A8
	[Token(Token = "0x170001E8")]
	public bool AtLeft
	{
		[Token(Token = "0x6000CE3")]
		[Address(RVA = "0x58DC10", Offset = "0x58D010", VA = "0x1058DC10")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001E9 RID: 489
	// (get) Token: 0x06000CE4 RID: 3300 RVA: 0x000051C0 File Offset: 0x000033C0
	[Token(Token = "0x170001E9")]
	public bool AtRight
	{
		[Token(Token = "0x6000CE4")]
		[Address(RVA = "0x58DC60", Offset = "0x58D060", VA = "0x1058DC60")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001EA RID: 490
	// (get) Token: 0x06000CE5 RID: 3301 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001EA")]
	public Collider2D Hitbox
	{
		[Token(Token = "0x6000CE5")]
		[Address(RVA = "0x58DD00", Offset = "0x58D100", VA = "0x1058DD00")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000CE6 RID: 3302 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CE6")]
	[Address(RVA = "0x58D930", Offset = "0x58CD30", VA = "0x1058D930")]
	public void Update()
	{
	}

	// Token: 0x06000CE7 RID: 3303 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CE7")]
	[Address(RVA = "0x58CEB0", Offset = "0x58C2B0", VA = "0x1058CEB0")]
	public void ScrollDown()
	{
	}

	// Token: 0x06000CE8 RID: 3304 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CE8")]
	[Address(RVA = "0x58D4F0", Offset = "0x58C8F0", VA = "0x1058D4F0")]
	public void ScrollUp()
	{
	}

	// Token: 0x06000CE9 RID: 3305 RVA: 0x000051D8 File Offset: 0x000033D8
	[Token(Token = "0x6000CE9")]
	[Address(RVA = "0x58CDA0", Offset = "0x58C1A0", VA = "0x1058CDA0")]
	public float GetScrollPercY()
	{
		return 0f;
	}

	// Token: 0x06000CEA RID: 3306 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CEA")]
	[Address(RVA = "0x58D050", Offset = "0x58C450", VA = "0x1058D050")]
	public void ScrollPercentY(float p)
	{
	}

	// Token: 0x06000CEB RID: 3307 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CEB")]
	[Address(RVA = "0x58CFA0", Offset = "0x58C3A0", VA = "0x1058CFA0")]
	public void ScrollPercentX(float p)
	{
	}

	// Token: 0x06000CEC RID: 3308 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CEC")]
	[Address(RVA = "0x58CE30", Offset = "0x58C230", VA = "0x1058CE30", Slot = "11")]
	public override void ReceiveClickDown()
	{
	}

	// Token: 0x06000CED RID: 3309 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CED")]
	[Address(RVA = "0x58CEA0", Offset = "0x58C2A0", VA = "0x1058CEA0", Slot = "13")]
	public override void ReceiveClickUp()
	{
	}

	// Token: 0x06000CEE RID: 3310 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CEE")]
	[Address(RVA = "0x58CE40", Offset = "0x58C240", VA = "0x1058CE40", Slot = "14")]
	public override void ReceiveClickDrag(Vector2 dragDelta)
	{
	}

	// Token: 0x06000CEF RID: 3311 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CEF")]
	[Address(RVA = "0x58D3E0", Offset = "0x58C7E0", VA = "0x1058D3E0")]
	public void ScrollToScrollbarPositionY(Vector3 newScrollbarPosition)
	{
	}

	// Token: 0x06000CF0 RID: 3312 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CF0")]
	[Address(RVA = "0x58D2E0", Offset = "0x58C6E0", VA = "0x1058D2E0")]
	public void ScrollToScrollbarPositionX(Vector3 newScrollbarPosition)
	{
	}

	// Token: 0x06000CF1 RID: 3313 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CF1")]
	[Address(RVA = "0x58D100", Offset = "0x58C500", VA = "0x1058D100")]
	public void ScrollRelative(Vector2 dragDelta)
	{
	}

	// Token: 0x06000CF2 RID: 3314 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CF2")]
	[Address(RVA = "0x58D5E0", Offset = "0x58C9E0", VA = "0x1058D5E0")]
	public void UpdateScrollBars()
	{
	}

	// Token: 0x06000CF3 RID: 3315 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CF3")]
	[Address(RVA = "0x58D450", Offset = "0x58C850", VA = "0x1058D450")]
	public void ScrollToTop()
	{
	}

	// Token: 0x06000CF4 RID: 3316 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CF4")]
	[Address(RVA = "0x58DB10", Offset = "0x58CF10", VA = "0x1058DB10")]
	public Scroller()
	{
	}

	// Token: 0x04000CBF RID: 3263
	[Token(Token = "0x4000CBF")]
	[FieldOffset(Offset = "0x34")]
	public Transform Inner;

	// Token: 0x04000CC0 RID: 3264
	[Token(Token = "0x4000CC0")]
	[FieldOffset(Offset = "0x38")]
	public bool allowY;

	// Token: 0x04000CC1 RID: 3265
	[Token(Token = "0x4000CC1")]
	[FieldOffset(Offset = "0x3C")]
	[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0xE2CE0", Offset = "0xE20E0")]
	public FloatRange ContentYBounds;

	// Token: 0x04000CC2 RID: 3266
	[Token(Token = "0x4000CC2")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0xE2D90", Offset = "0xE2190")]
	public FloatRange ScrollbarYBounds;

	// Token: 0x04000CC3 RID: 3267
	[Token(Token = "0x4000CC3")]
	[FieldOffset(Offset = "0x44")]
	[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0xE2DF0", Offset = "0xE21F0")]
	public Scrollbar ScrollbarY;

	// Token: 0x04000CC4 RID: 3268
	[Token(Token = "0x4000CC4")]
	[FieldOffset(Offset = "0x48")]
	public bool allowX;

	// Token: 0x04000CC5 RID: 3269
	[Token(Token = "0x4000CC5")]
	[FieldOffset(Offset = "0x4C")]
	[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0xE2E20", Offset = "0xE2220")]
	public FloatRange ContentXBounds;

	// Token: 0x04000CC6 RID: 3270
	[Token(Token = "0x4000CC6")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0xE2E50", Offset = "0xE2250")]
	public FloatRange ScrollbarXBounds;

	// Token: 0x04000CC7 RID: 3271
	[Token(Token = "0x4000CC7")]
	[FieldOffset(Offset = "0x54")]
	[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0xE2E80", Offset = "0xE2280")]
	public Scrollbar ScrollbarX;

	// Token: 0x04000CC8 RID: 3272
	[Token(Token = "0x4000CC8")]
	[FieldOffset(Offset = "0x58")]
	public float DragScrollSpeed;

	// Token: 0x04000CC9 RID: 3273
	[Token(Token = "0x4000CC9")]
	[FieldOffset(Offset = "0x5C")]
	public float ScrollWheelSpeed;

	// Token: 0x04000CCA RID: 3274
	[Token(Token = "0x4000CCA")]
	[FieldOffset(Offset = "0x60")]
	private Vector2 velocity;

	// Token: 0x04000CCB RID: 3275
	[Token(Token = "0x4000CCB")]
	[FieldOffset(Offset = "0x68")]
	private bool active;
}
