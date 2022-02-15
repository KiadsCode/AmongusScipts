using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Assets.InnerNet;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000124 RID: 292
[Token(Token = "0x2000124")]
public class CosmicubeMenu : MonoBehaviour
{
	// Token: 0x060006DD RID: 1757 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006DD")]
	[Address(RVA = "0x800F50", Offset = "0x800350", VA = "0x10800F50")]
	private void OnDisable()
	{
	}

	// Token: 0x060006DE RID: 1758 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006DE")]
	[Address(RVA = "0x802620", Offset = "0x801A20", VA = "0x10802620")]
	public void ZoomIn()
	{
	}

	// Token: 0x060006DF RID: 1759 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006DF")]
	[Address(RVA = "0x802640", Offset = "0x801A40", VA = "0x10802640")]
	public void ZoomOut()
	{
	}

	// Token: 0x060006E0 RID: 1760 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006E0")]
	[Address(RVA = "0x801C30", Offset = "0x801030", VA = "0x10801C30")]
	public void Show(string cubeID, bool previewMode = false)
	{
	}

	// Token: 0x060006E1 RID: 1761 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006E1")]
	[Address(RVA = "0x800B80", Offset = "0x7FFF80", VA = "0x10800B80")]
	public void Close()
	{
	}

	// Token: 0x060006E2 RID: 1762 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006E2")]
	[Address(RVA = "0x800C70", Offset = "0x800070", VA = "0x10800C70")]
	public void EquipSelectedItem()
	{
	}

	// Token: 0x060006E3 RID: 1763 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006E3")]
	[Address(RVA = "0x800FE0", Offset = "0x8003E0", VA = "0x10800FE0")]
	public void SelectItem(CosmicubeCell cell)
	{
	}

	// Token: 0x060006E4 RID: 1764 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006E4")]
	[Address(RVA = "0x800D80", Offset = "0x800180", VA = "0x10800D80")]
	private void LoadCube()
	{
	}

	// Token: 0x060006E5 RID: 1765 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006E5")]
	[Address(RVA = "0x800A00", Offset = "0x7FFE00", VA = "0x10800A00")]
	public void ClickPurchase()
	{
	}

	// Token: 0x060006E6 RID: 1766 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006E6")]
	[Address(RVA = "0x800C20", Offset = "0x800020", VA = "0x10800C20")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDE7E0", Offset = "0xDDBE0")]
	private IEnumerator CoAnimatePurchase()
	{
		return null;
	}

	// Token: 0x060006E7 RID: 1767 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006E7")]
	[Address(RVA = "0x801B50", Offset = "0x800F50", VA = "0x10801B50")]
	public void ShowConfirmPurchase()
	{
	}

	// Token: 0x060006E8 RID: 1768 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006E8")]
	[Address(RVA = "0x802310", Offset = "0x801710", VA = "0x10802310")]
	private void Update()
	{
	}

	// Token: 0x060006E9 RID: 1769 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006E9")]
	[Address(RVA = "0x800720", Offset = "0x7FFB20", VA = "0x10800720")]
	private void AdjustZoom(float amount)
	{
	}

	// Token: 0x060006EA RID: 1770 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006EA")]
	[Address(RVA = "0x802690", Offset = "0x801A90", VA = "0x10802690")]
	public CosmicubeMenu()
	{
	}

	// Token: 0x060006EC RID: 1772 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006EC")]
	[Address(RVA = "0x802280", Offset = "0x801680", VA = "0x10802280")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private void <ClickPurchase>b__42_0(ResponseState cb, Response<ResponsePurchase> response)
	{
	}

	// Token: 0x040006C1 RID: 1729
	[Token(Token = "0x40006C1")]
	[FieldOffset(Offset = "0xC")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xDD8F0", Offset = "0xDCCF0")]
	public UiElement BackButton;

	// Token: 0x040006C2 RID: 1730
	[Token(Token = "0x40006C2")]
	[FieldOffset(Offset = "0x10")]
	public GameObject zoomInGlyph;

	// Token: 0x040006C3 RID: 1731
	[Token(Token = "0x40006C3")]
	[FieldOffset(Offset = "0x14")]
	public GameObject zoomOutGlyph;

	// Token: 0x040006C4 RID: 1732
	[Token(Token = "0x40006C4")]
	[FieldOffset(Offset = "0x18")]
	public TextMeshPro cubeTitle;

	// Token: 0x040006C5 RID: 1733
	[Token(Token = "0x40006C5")]
	[FieldOffset(Offset = "0x1C")]
	public TextMeshPro selectedItemName;

	// Token: 0x040006C6 RID: 1734
	[Token(Token = "0x40006C6")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshPro selectedItemCategory;

	// Token: 0x040006C7 RID: 1735
	[Token(Token = "0x40006C7")]
	[FieldOffset(Offset = "0x24")]
	public TextMeshPro[] selectedItemPrice;

	// Token: 0x040006C8 RID: 1736
	[Token(Token = "0x40006C8")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshPro confirmPurchaseText;

	// Token: 0x040006C9 RID: 1737
	[Token(Token = "0x40006C9")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject confirmWindow;

	// Token: 0x040006CA RID: 1738
	[Token(Token = "0x40006CA")]
	[FieldOffset(Offset = "0x30")]
	public GameObject equipButton;

	// Token: 0x040006CB RID: 1739
	[Token(Token = "0x40006CB")]
	[FieldOffset(Offset = "0x34")]
	public GameObject equippedText;

	// Token: 0x040006CC RID: 1740
	[Token(Token = "0x40006CC")]
	[FieldOffset(Offset = "0x38")]
	public SpriteRenderer podConfirmIcon;

	// Token: 0x040006CD RID: 1741
	[Token(Token = "0x40006CD")]
	[FieldOffset(Offset = "0x3C")]
	public CubeCellPurchaseButton purchaseButton;

	// Token: 0x040006CE RID: 1742
	[Token(Token = "0x40006CE")]
	[FieldOffset(Offset = "0x40")]
	public GameObject lockedButton;

	// Token: 0x040006CF RID: 1743
	[Token(Token = "0x40006CF")]
	[FieldOffset(Offset = "0x44")]
	public PoolablePlayer dressMeUp;

	// Token: 0x040006D0 RID: 1744
	[Token(Token = "0x40006D0")]
	[FieldOffset(Offset = "0x48")]
	public PlayerVoteArea nameplatePreview;

	// Token: 0x040006D1 RID: 1745
	[Token(Token = "0x40006D1")]
	[FieldOffset(Offset = "0x4C")]
	public StoreMannequin storeMannequin;

	// Token: 0x040006D2 RID: 1746
	[Token(Token = "0x40006D2")]
	[FieldOffset(Offset = "0x50")]
	public SpriteRenderer nameplateConfirmPreview;

	// Token: 0x040006D3 RID: 1747
	[Token(Token = "0x40006D3")]
	[FieldOffset(Offset = "0x54")]
	public SpriteRenderer podIcon;

	// Token: 0x040006D4 RID: 1748
	[Token(Token = "0x40006D4")]
	[FieldOffset(Offset = "0x58")]
	public TextMeshPro podAmount;

	// Token: 0x040006D5 RID: 1749
	[Token(Token = "0x40006D5")]
	[FieldOffset(Offset = "0x5C")]
	public Scroller scroller;

	// Token: 0x040006D6 RID: 1750
	[Token(Token = "0x40006D6")]
	[FieldOffset(Offset = "0x60")]
	public GameObject cubeHolder;

	// Token: 0x040006D7 RID: 1751
	[Token(Token = "0x40006D7")]
	[FieldOffset(Offset = "0x64")]
	public SpriteRenderer zoomOutButton;

	// Token: 0x040006D8 RID: 1752
	[Token(Token = "0x40006D8")]
	[FieldOffset(Offset = "0x68")]
	public SpriteRenderer zoomInButton;

	// Token: 0x040006D9 RID: 1753
	[Token(Token = "0x40006D9")]
	[FieldOffset(Offset = "0x6C")]
	public AudioClip cubeCellUnlockSound;

	// Token: 0x040006DA RID: 1754
	[Token(Token = "0x40006DA")]
	[FieldOffset(Offset = "0x70")]
	public PurchasePopUp plsWaitModal;

	// Token: 0x040006DB RID: 1755
	[Token(Token = "0x40006DB")]
	[FieldOffset(Offset = "0x74")]
	private Cosmicube currentCube;

	// Token: 0x040006DC RID: 1756
	[Token(Token = "0x40006DC")]
	[FieldOffset(Offset = "0x78")]
	private CosmicubeCell currentCell;

	// Token: 0x040006DD RID: 1757
	[Token(Token = "0x40006DD")]
	[FieldOffset(Offset = "0x0")]
	public static int CellMaskLayer;

	// Token: 0x040006DE RID: 1758
	[Token(Token = "0x40006DE")]
	[FieldOffset(Offset = "0x7C")]
	private float zoomLevel;

	// Token: 0x040006DF RID: 1759
	[Token(Token = "0x40006DF")]
	[FieldOffset(Offset = "0x80")]
	private float minZoom;

	// Token: 0x040006E0 RID: 1760
	[Token(Token = "0x40006E0")]
	[FieldOffset(Offset = "0x84")]
	private float maxZoom;

	// Token: 0x040006E1 RID: 1761
	[Token(Token = "0x40006E1")]
	[FieldOffset(Offset = "0x88")]
	private bool previewMode;

	// Token: 0x040006E2 RID: 1762
	[Token(Token = "0x40006E2")]
	[FieldOffset(Offset = "0x89")]
	private bool animatingPurchase;

	// Token: 0x02000125 RID: 293
	[Token(Token = "0x2000125")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass40_0
	{
		// Token: 0x060006ED RID: 1773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass40_0()
		{
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x78D750", Offset = "0x78CB50", VA = "0x1078D750")]
		internal void <SelectItem>b__0(TextMeshPro t)
		{
		}

		// Token: 0x040006E3 RID: 1763
		[Token(Token = "0x40006E3")]
		[FieldOffset(Offset = "0x8")]
		public CosmicubeCell cell;
	}

	// Token: 0x02000126 RID: 294
	[Token(Token = "0x2000126")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoAnimatePurchase>d__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060006EF RID: 1775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoAnimatePurchase>d__43(int <>1__state)
		{
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x00003DB0 File Offset: 0x00001FB0
		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x783D70", Offset = "0x783170", VA = "0x10783D70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060006F2 RID: 1778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700010D")]
		private object Current
		{
			[Token(Token = "0x60006F2")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x783F00", Offset = "0x783300", VA = "0x10783F00", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060006F4 RID: 1780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700010E")]
		private object Current
		{
			[Token(Token = "0x60006F4")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040006E4 RID: 1764
		[Token(Token = "0x40006E4")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040006E5 RID: 1765
		[Token(Token = "0x40006E5")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040006E6 RID: 1766
		[Token(Token = "0x40006E6")]
		[FieldOffset(Offset = "0x10")]
		public CosmicubeMenu <>4__this;
	}
}
