using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020001D0 RID: 464
[Token(Token = "0x20001D0")]
public class ButtonBehavior : UiElement
{
	// Token: 0x06000A79 RID: 2681 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A79")]
	[Address(RVA = "0x82BBB0", Offset = "0x82AFB0", VA = "0x1082BBB0")]
	public void OnEnable()
	{
	}

	// Token: 0x06000A7A RID: 2682 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A7A")]
	[Address(RVA = "0x82BDB0", Offset = "0x82B1B0", VA = "0x1082BDB0")]
	public void Update()
	{
	}

	// Token: 0x06000A7B RID: 2683 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A7B")]
	[Address(RVA = "0x82BD80", Offset = "0x82B180", VA = "0x1082BD80")]
	public void ReceiveClick()
	{
	}

	// Token: 0x06000A7C RID: 2684 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A7C")]
	[Address(RVA = "0x82BEC0", Offset = "0x82B2C0", VA = "0x1082BEC0")]
	public ButtonBehavior()
	{
	}

	// Token: 0x04000A98 RID: 2712
	[Token(Token = "0x4000A98")]
	[FieldOffset(Offset = "0x28")]
	public bool OnUp;

	// Token: 0x04000A99 RID: 2713
	[Token(Token = "0x4000A99")]
	[FieldOffset(Offset = "0x29")]
	public bool OnDown;

	// Token: 0x04000A9A RID: 2714
	[Token(Token = "0x4000A9A")]
	[FieldOffset(Offset = "0x2A")]
	public bool Repeat;

	// Token: 0x04000A9B RID: 2715
	[Token(Token = "0x4000A9B")]
	[FieldOffset(Offset = "0x2C")]
	public Button.ButtonClickedEvent OnClick;

	// Token: 0x04000A9C RID: 2716
	[Token(Token = "0x4000A9C")]
	[FieldOffset(Offset = "0x30")]
	private Controller myController;

	// Token: 0x04000A9D RID: 2717
	[Token(Token = "0x4000A9D")]
	[FieldOffset(Offset = "0x34")]
	private Collider2D[] colliders;

	// Token: 0x04000A9E RID: 2718
	[Token(Token = "0x4000A9E")]
	[FieldOffset(Offset = "0x38")]
	private float downTime;

	// Token: 0x04000A9F RID: 2719
	[Token(Token = "0x4000A9F")]
	[FieldOffset(Offset = "0x3C")]
	public SpriteRenderer spriteRenderer;

	// Token: 0x04000AA0 RID: 2720
	[Token(Token = "0x4000AA0")]
	[FieldOffset(Offset = "0x40")]
	private bool checkedClickEvent;
}
