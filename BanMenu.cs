using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using InnerNet;
using UnityEngine;

// Token: 0x020001CA RID: 458
[Token(Token = "0x20001CA")]
public class BanMenu : MonoBehaviour
{
	// Token: 0x06000A5A RID: 2650 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A5A")]
	[Address(RVA = "0x550840", Offset = "0x54FC40", VA = "0x10550840")]
	public void SetVisible(bool show)
	{
	}

	// Token: 0x06000A5B RID: 2651 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A5B")]
	[Address(RVA = "0x550FF0", Offset = "0x5503F0", VA = "0x10550FF0")]
	private void Update()
	{
	}

	// Token: 0x06000A5C RID: 2652 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A5C")]
	[Address(RVA = "0x550AA0", Offset = "0x54FEA0", VA = "0x10550AA0")]
	public void Show()
	{
	}

	// Token: 0x06000A5D RID: 2653 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A5D")]
	[Address(RVA = "0x54FD90", Offset = "0x54F190", VA = "0x1054FD90")]
	[Attribute(Name = "ContextMenu", RVA = "0xE1160", Offset = "0xE0560")]
	private void AlignAllButtons()
	{
	}

	// Token: 0x06000A5E RID: 2654 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A5E")]
	[Address(RVA = "0x5501F0", Offset = "0x54F5F0", VA = "0x105501F0")]
	public void Hide()
	{
	}

	// Token: 0x06000A5F RID: 2655 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A5F")]
	[Address(RVA = "0x550580", Offset = "0x54F980", VA = "0x10550580")]
	public void Select(int clientId)
	{
	}

	// Token: 0x06000A60 RID: 2656 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A60")]
	[Address(RVA = "0x5503A0", Offset = "0x54F7A0", VA = "0x105503A0")]
	public void Kick(bool ban)
	{
	}

	// Token: 0x06000A61 RID: 2657 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A61")]
	[Address(RVA = "0x550460", Offset = "0x54F860", VA = "0x10550460")]
	public void PickReportReason()
	{
	}

	// Token: 0x06000A62 RID: 2658 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A62")]
	[Address(RVA = "0x5504F0", Offset = "0x54F8F0", VA = "0x105504F0")]
	public void ReportPlayer(ReportReasons reason)
	{
	}

	// Token: 0x06000A63 RID: 2659 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A63")]
	[Address(RVA = "0x551420", Offset = "0x550820", VA = "0x10551420")]
	public BanMenu()
	{
	}

	// Token: 0x04000A75 RID: 2677
	[Token(Token = "0x4000A75")]
	[FieldOffset(Offset = "0xC")]
	public BanButton BanButtonPrefab;

	// Token: 0x04000A76 RID: 2678
	[Token(Token = "0x4000A76")]
	[FieldOffset(Offset = "0x10")]
	public SpriteRenderer Background;

	// Token: 0x04000A77 RID: 2679
	[Token(Token = "0x4000A77")]
	[FieldOffset(Offset = "0x14")]
	public SpriteRenderer MenuButtonSprite;

	// Token: 0x04000A78 RID: 2680
	[Token(Token = "0x4000A78")]
	[FieldOffset(Offset = "0x18")]
	public PassiveButton MenuButton;

	// Token: 0x04000A79 RID: 2681
	[Token(Token = "0x4000A79")]
	[FieldOffset(Offset = "0x1C")]
	public SpriteRenderer BanButton;

	// Token: 0x04000A7A RID: 2682
	[Token(Token = "0x4000A7A")]
	[FieldOffset(Offset = "0x20")]
	public SpriteRenderer KickButton;

	// Token: 0x04000A7B RID: 2683
	[Token(Token = "0x4000A7B")]
	[FieldOffset(Offset = "0x24")]
	public SpriteRenderer ReportButton;

	// Token: 0x04000A7C RID: 2684
	[Token(Token = "0x4000A7C")]
	[FieldOffset(Offset = "0x28")]
	public GameObject hotkeyGlyph;

	// Token: 0x04000A7D RID: 2685
	[Token(Token = "0x4000A7D")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject ContentParent;

	// Token: 0x04000A7E RID: 2686
	[Token(Token = "0x4000A7E")]
	[FieldOffset(Offset = "0x30")]
	public ReportReasonScreen ReportReason;

	// Token: 0x04000A7F RID: 2687
	[Token(Token = "0x4000A7F")]
	[FieldOffset(Offset = "0x34")]
	public int selectedClientId;

	// Token: 0x04000A80 RID: 2688
	[Token(Token = "0x4000A80")]
	[FieldOffset(Offset = "0x38")]
	public List<BanButton> allButtons;

	// Token: 0x04000A81 RID: 2689
	[Token(Token = "0x4000A81")]
	[FieldOffset(Offset = "0x3C")]
	private List<ClientData> recentClients;

	// Token: 0x04000A82 RID: 2690
	[Token(Token = "0x4000A82")]
	private const float BackgroundTailWidth = 0.4f;

	// Token: 0x04000A83 RID: 2691
	[Token(Token = "0x4000A83")]
	private const float BorderPadding = 0.15f;

	// Token: 0x04000A84 RID: 2692
	[Token(Token = "0x4000A84")]
	private const float HeightPerButton = 0.4f;

	// Token: 0x04000A85 RID: 2693
	[Token(Token = "0x4000A85")]
	private const float WidthPerButton = 3f;

	// Token: 0x04000A86 RID: 2694
	[Token(Token = "0x4000A86")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xDD8F0", Offset = "0xDCCF0")]
	public UiElement BackButton;

	// Token: 0x04000A87 RID: 2695
	[Token(Token = "0x4000A87")]
	[FieldOffset(Offset = "0x44")]
	public UiElement DefaultButtonSelected;

	// Token: 0x04000A88 RID: 2696
	[Token(Token = "0x4000A88")]
	[FieldOffset(Offset = "0x48")]
	public List<UiElement> ControllerSelectable;

	// Token: 0x020001CB RID: 459
	[Token(Token = "0x20001CB")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass21_0
	{
		// Token: 0x06000A64 RID: 2660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A64")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass21_0()
		{
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x00004890 File Offset: 0x00002A90
		[Token(Token = "0x6000A65")]
		[Address(RVA = "0x3CA360", Offset = "0x3C9760", VA = "0x103CA360")]
		internal bool <Update>b__1(BanButton b)
		{
			return default(bool);
		}

		// Token: 0x04000A89 RID: 2697
		[Token(Token = "0x4000A89")]
		[FieldOffset(Offset = "0x8")]
		public ClientData client;
	}

	// Token: 0x020001CC RID: 460
	[Token(Token = "0x20001CC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000A67 RID: 2663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A67")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x000048A8 File Offset: 0x00002AA8
		[Token(Token = "0x6000A68")]
		[Address(RVA = "0x3CA290", Offset = "0x3C9690", VA = "0x103CA290")]
		internal bool <Update>b__21_0(int c)
		{
			return default(bool);
		}

		// Token: 0x04000A8A RID: 2698
		[Token(Token = "0x4000A8A")]
		[FieldOffset(Offset = "0x0")]
		public static readonly BanMenu.<>c <>9;

		// Token: 0x04000A8B RID: 2699
		[Token(Token = "0x4000A8B")]
		[FieldOffset(Offset = "0x4")]
		public static Func<int, bool> <>9__21_0;
	}
}
