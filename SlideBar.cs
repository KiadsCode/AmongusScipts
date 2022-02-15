using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x020004C5 RID: 1221
[Token(Token = "0x20004C5")]
public class SlideBar : PassiveUiElement
{
	// Token: 0x170003C2 RID: 962
	// (get) Token: 0x060019F1 RID: 6641 RVA: 0x000082C8 File Offset: 0x000064C8
	[Token(Token = "0x170003C2")]
	public override bool HandleDrag
	{
		[Token(Token = "0x60019F1")]
		[Address(RVA = "0x2EDC10", Offset = "0x2ED010", VA = "0x102EDC10", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060019F2 RID: 6642 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019F2")]
	[Address(RVA = "0x4A0AF0", Offset = "0x49FEF0", VA = "0x104A0AF0")]
	public void OnEnable()
	{
	}

	// Token: 0x060019F3 RID: 6643 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019F3")]
	[Address(RVA = "0x4A09C0", Offset = "0x49FDC0", VA = "0x104A09C0")]
	public void OnDisable()
	{
	}

	// Token: 0x060019F4 RID: 6644 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019F4")]
	[Address(RVA = "0x4A0C30", Offset = "0x4A0030", VA = "0x104A0C30", Slot = "14")]
	public override void ReceiveClickDrag(Vector2 dragDelta)
	{
	}

	// Token: 0x060019F5 RID: 6645 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019F5")]
	[Address(RVA = "0x4A0DE0", Offset = "0x4A01E0", VA = "0x104A0DE0")]
	public void UpdateValue()
	{
	}

	// Token: 0x060019F6 RID: 6646 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019F6")]
	[Address(RVA = "0x4A0DB0", Offset = "0x4A01B0", VA = "0x104A0DB0")]
	public void SetValue(float newValue)
	{
	}

	// Token: 0x060019F7 RID: 6647 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019F7")]
	[Address(RVA = "0x4A08F0", Offset = "0x49FCF0", VA = "0x104A08F0")]
	public void ControllerIncrease()
	{
	}

	// Token: 0x060019F8 RID: 6648 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019F8")]
	[Address(RVA = "0x4A0820", Offset = "0x49FC20", VA = "0x104A0820")]
	public void ControllerDecrease()
	{
	}

	// Token: 0x060019F9 RID: 6649 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019F9")]
	[Address(RVA = "0x4A0C20", Offset = "0x4A0020", VA = "0x104A0C20")]
	private void OnValidate()
	{
	}

	// Token: 0x060019FA RID: 6650 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019FA")]
	[Address(RVA = "0x4A0EA0", Offset = "0x4A02A0", VA = "0x104A0EA0")]
	public SlideBar()
	{
	}

	// Token: 0x04001A29 RID: 6697
	[Token(Token = "0x4001A29")]
	[FieldOffset(Offset = "0x34")]
	[Attribute(Name = "SpaceAttribute", RVA = "0xE0A50", Offset = "0xDFE50")]
	public TextMeshPro Title;

	// Token: 0x04001A2A RID: 6698
	[Token(Token = "0x4001A2A")]
	[FieldOffset(Offset = "0x38")]
	public SpriteRenderer Bar;

	// Token: 0x04001A2B RID: 6699
	[Token(Token = "0x4001A2B")]
	[FieldOffset(Offset = "0x3C")]
	public SpriteRenderer Dot;

	// Token: 0x04001A2C RID: 6700
	[Token(Token = "0x4001A2C")]
	[FieldOffset(Offset = "0x40")]
	public FloatRange Range;

	// Token: 0x04001A2D RID: 6701
	[Token(Token = "0x4001A2D")]
	[FieldOffset(Offset = "0x44")]
	public bool Vertical;

	// Token: 0x04001A2E RID: 6702
	[Token(Token = "0x4001A2E")]
	[FieldOffset(Offset = "0x48")]
	public float Value;

	// Token: 0x04001A2F RID: 6703
	[Token(Token = "0x4001A2F")]
	[FieldOffset(Offset = "0x4C")]
	public UnityEvent OnValueChange;

	// Token: 0x04001A30 RID: 6704
	[Token(Token = "0x4001A30")]
	[FieldOffset(Offset = "0x50")]
	private float sliderSegmentIncrement;
}
