using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020001D3 RID: 467
[Token(Token = "0x20001D3")]
public abstract class ActionButton : MonoBehaviour
{
	// Token: 0x06000A83 RID: 2691 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A83")]
	[Address(RVA = "0x541390", Offset = "0x540790", VA = "0x10541390")]
	private void Start()
	{
	}

	// Token: 0x06000A84 RID: 2692
	[Token(Token = "0x6000A84")]
	public abstract void DoClick();

	// Token: 0x06000A85 RID: 2693 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A85")]
	[Address(RVA = "0x540DB0", Offset = "0x5401B0", VA = "0x10540DB0")]
	public void SetCoolDown(float timer, float maxTimer)
	{
	}

	// Token: 0x06000A86 RID: 2694 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A86")]
	[Address(RVA = "0x541170", Offset = "0x540570", VA = "0x10541170")]
	public void SetFillUp(float timer, float maxTimer)
	{
	}

	// Token: 0x06000A87 RID: 2695 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A87")]
	[Address(RVA = "0x541060", Offset = "0x540460", VA = "0x10541060")]
	public void SetEnabled()
	{
	}

	// Token: 0x06000A88 RID: 2696 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A88")]
	[Address(RVA = "0x540F50", Offset = "0x540350", VA = "0x10540F50")]
	public void SetDisabled()
	{
	}

	// Token: 0x06000A89 RID: 2697 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A89")]
	[Address(RVA = "0x5413E0", Offset = "0x5407E0", VA = "0x105413E0")]
	public void ToggleVisible(bool visible)
	{
	}

	// Token: 0x06000A8A RID: 2698 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A8A")]
	[Address(RVA = "0x499D40", Offset = "0x499140", VA = "0x10499D40")]
	public void Hide()
	{
	}

	// Token: 0x06000A8B RID: 2699 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A8B")]
	[Address(RVA = "0x499D70", Offset = "0x499170", VA = "0x10499D70")]
	public void Show()
	{
	}

	// Token: 0x06000A8C RID: 2700 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A8C")]
	[Address(RVA = "0x540EF0", Offset = "0x5402F0", VA = "0x10540EF0")]
	public void SetCooldownFill(float percentCool)
	{
	}

	// Token: 0x06000A8D RID: 2701 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A8D")]
	[Address(RVA = "0x540D80", Offset = "0x540180", VA = "0x10540D80")]
	public void OverrideText(string text)
	{
	}

	// Token: 0x06000A8E RID: 2702 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A8E")]
	[Address(RVA = "0x540D50", Offset = "0x540150", VA = "0x10540D50")]
	public void OverrideColor(Color color)
	{
	}

	// Token: 0x06000A8F RID: 2703 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A8F")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	protected ActionButton()
	{
	}

	// Token: 0x04000AA5 RID: 2725
	[Token(Token = "0x4000AA5")]
	[FieldOffset(Offset = "0xC")]
	[SerializeField]
	protected SpriteRenderer graphic;

	// Token: 0x04000AA6 RID: 2726
	[Token(Token = "0x4000AA6")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	protected TextMeshPro buttonLabelText;

	// Token: 0x04000AA7 RID: 2727
	[Token(Token = "0x4000AA7")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	protected TextMeshPro cooldownTimerText;

	// Token: 0x04000AA8 RID: 2728
	[Token(Token = "0x4000AA8")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ActionMapGlyphDisplay glyph;

	// Token: 0x04000AA9 RID: 2729
	[Token(Token = "0x4000AA9")]
	[FieldOffset(Offset = "0x1C")]
	protected bool isCoolingDown;

	// Token: 0x04000AAA RID: 2730
	[Token(Token = "0x4000AAA")]
	[FieldOffset(Offset = "0x20")]
	private Vector3 position;
}
