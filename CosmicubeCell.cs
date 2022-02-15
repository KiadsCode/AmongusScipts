using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using PowerTools;
using TMPro;
using UnityEngine;

// Token: 0x0200011B RID: 283
[Token(Token = "0x200011B")]
public class CosmicubeCell : MonoBehaviour
{
	// Token: 0x170000FE RID: 254
	// (get) Token: 0x0600069D RID: 1693 RVA: 0x00003C18 File Offset: 0x00001E18
	[Token(Token = "0x170000FE")]
	public bool HasEastCell
	{
		[Token(Token = "0x600069D")]
		[Address(RVA = "0x7FFA50", Offset = "0x7FEE50", VA = "0x107FFA50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170000FF RID: 255
	// (get) Token: 0x0600069E RID: 1694 RVA: 0x00003C30 File Offset: 0x00001E30
	[Token(Token = "0x170000FF")]
	public bool HasWestCell
	{
		[Token(Token = "0x600069E")]
		[Address(RVA = "0x7FFCC0", Offset = "0x7FF0C0", VA = "0x107FFCC0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000100 RID: 256
	// (get) Token: 0x0600069F RID: 1695 RVA: 0x00003C48 File Offset: 0x00001E48
	[Token(Token = "0x17000100")]
	public bool HasNorthCell
	{
		[Token(Token = "0x600069F")]
		[Address(RVA = "0x7FFB20", Offset = "0x7FEF20", VA = "0x107FFB20")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000101 RID: 257
	// (get) Token: 0x060006A0 RID: 1696 RVA: 0x00003C60 File Offset: 0x00001E60
	[Token(Token = "0x17000101")]
	public bool HasSouthCell
	{
		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x7FFBF0", Offset = "0x7FEFF0", VA = "0x107FFBF0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000102 RID: 258
	// (get) Token: 0x060006A1 RID: 1697 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000102")]
	public UnlockableCosmetic CosmeticData
	{
		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x3C1650", Offset = "0x3C0A50", VA = "0x103C1650")]
		get
		{
			return null;
		}
	}

	// Token: 0x060006A2 RID: 1698 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006A2")]
	[Address(RVA = "0x7FF530", Offset = "0x7FE930", VA = "0x107FF530")]
	private void Start()
	{
	}

	// Token: 0x060006A3 RID: 1699 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006A3")]
	[Address(RVA = "0x7FF690", Offset = "0x7FEA90", VA = "0x107FF690")]
	private void Update()
	{
	}

	// Token: 0x060006A4 RID: 1700 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006A4")]
	[Address(RVA = "0x5D0FA0", Offset = "0x5D03A0", VA = "0x105D0FA0")]
	public void SetMenu(CosmicubeMenu menu)
	{
	}

	// Token: 0x060006A5 RID: 1701 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006A5")]
	[Address(RVA = "0x273ED0", Offset = "0x2732D0", VA = "0x10273ED0")]
	public void SetParent(CosmicubeCell parent)
	{
	}

	// Token: 0x060006A6 RID: 1702 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006A6")]
	[Address(RVA = "0x7FEF90", Offset = "0x7FE390", VA = "0x107FEF90")]
	public void SetEastChild(CosmicubeCell c, UnlockableCosmetic data)
	{
	}

	// Token: 0x060006A7 RID: 1703 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006A7")]
	[Address(RVA = "0x7FF440", Offset = "0x7FE840", VA = "0x107FF440")]
	public void SetWestChild(CosmicubeCell c, UnlockableCosmetic data)
	{
	}

	// Token: 0x060006A8 RID: 1704 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006A8")]
	[Address(RVA = "0x7FF080", Offset = "0x7FE480", VA = "0x107FF080")]
	public void SetNorthChild(CosmicubeCell c, UnlockableCosmetic data)
	{
	}

	// Token: 0x060006A9 RID: 1705 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006A9")]
	[Address(RVA = "0x7FF1A0", Offset = "0x7FE5A0", VA = "0x107FF1A0")]
	public void SetSouthChild(CosmicubeCell c, UnlockableCosmetic data)
	{
	}

	// Token: 0x060006AA RID: 1706 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006AA")]
	[Address(RVA = "0x7FE610", Offset = "0x7FDA10", VA = "0x107FE610")]
	public void SetData(UnlockableCosmetic cosmetic)
	{
	}

	// Token: 0x060006AB RID: 1707 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006AB")]
	[Address(RVA = "0x7FE340", Offset = "0x7FD740", VA = "0x107FE340")]
	public void ChooseCell()
	{
	}

	// Token: 0x060006AC RID: 1708 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006AC")]
	[Address(RVA = "0x7FF170", Offset = "0x7FE570", VA = "0x107FF170")]
	public void SetSelected()
	{
	}

	// Token: 0x060006AD RID: 1709 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006AD")]
	[Address(RVA = "0x7FEF60", Offset = "0x7FE360", VA = "0x107FEF60")]
	public void SetDeselected()
	{
	}

	// Token: 0x060006AE RID: 1710 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006AE")]
	[Address(RVA = "0x7FE5A0", Offset = "0x7FD9A0", VA = "0x107FE5A0")]
	public void SetCellPurchased()
	{
	}

	// Token: 0x060006AF RID: 1711 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006AF")]
	[Address(RVA = "0x7FF290", Offset = "0x7FE690", VA = "0x107FF290")]
	public void SetUnavailable()
	{
	}

	// Token: 0x060006B0 RID: 1712 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006B0")]
	[Address(RVA = "0x7FE400", Offset = "0x7FD800", VA = "0x107FE400")]
	public void SetAvailable()
	{
	}

	// Token: 0x060006B1 RID: 1713 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006B1")]
	[Address(RVA = "0x7FE3B0", Offset = "0x7FD7B0", VA = "0x107FE3B0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDE370", Offset = "0xDD770")]
	public IEnumerator CoPurchase()
	{
		return null;
	}

	// Token: 0x060006B2 RID: 1714 RVA: 0x00003C78 File Offset: 0x00001E78
	[Token(Token = "0x60006B2")]
	[Address(RVA = "0x7FE2C0", Offset = "0x7FD6C0", VA = "0x107FE2C0")]
	public bool CanBePurchased()
	{
		return default(bool);
	}

	// Token: 0x060006B3 RID: 1715 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006B3")]
	[Address(RVA = "0x7FE360", Offset = "0x7FD760", VA = "0x107FE360")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDE410", Offset = "0xDD810")]
	private IEnumerator CoPurchaseAnimation()
	{
		return null;
	}

	// Token: 0x060006B4 RID: 1716 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006B4")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public CosmicubeCell()
	{
	}

	// Token: 0x0400068D RID: 1677
	[Token(Token = "0x400068D")]
	private const float cellSpacing = 0.74f;

	// Token: 0x0400068E RID: 1678
	[Token(Token = "0x400068E")]
	private const float cellUnlockGlowDuration = 0.9f;

	// Token: 0x0400068F RID: 1679
	[Token(Token = "0x400068F")]
	[FieldOffset(Offset = "0xC")]
	public CosmicubeCell parent;

	// Token: 0x04000690 RID: 1680
	[Token(Token = "0x4000690")]
	[FieldOffset(Offset = "0x10")]
	public CosmicubeCell northChild;

	// Token: 0x04000691 RID: 1681
	[Token(Token = "0x4000691")]
	[FieldOffset(Offset = "0x14")]
	public CosmicubeCell southChild;

	// Token: 0x04000692 RID: 1682
	[Token(Token = "0x4000692")]
	[FieldOffset(Offset = "0x18")]
	public CosmicubeCell eastChild;

	// Token: 0x04000693 RID: 1683
	[Token(Token = "0x4000693")]
	[FieldOffset(Offset = "0x1C")]
	public CosmicubeCell westChild;

	// Token: 0x04000694 RID: 1684
	[Token(Token = "0x4000694")]
	[FieldOffset(Offset = "0x20")]
	public SpriteRenderer icon;

	// Token: 0x04000695 RID: 1685
	[Token(Token = "0x4000695")]
	[FieldOffset(Offset = "0x24")]
	public SpriteRenderer iconBack;

	// Token: 0x04000696 RID: 1686
	[Token(Token = "0x4000696")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshPro costText;

	// Token: 0x04000697 RID: 1687
	[Token(Token = "0x4000697")]
	[FieldOffset(Offset = "0x2C")]
	public SpriteRenderer cellSprite;

	// Token: 0x04000698 RID: 1688
	[Token(Token = "0x4000698")]
	[FieldOffset(Offset = "0x30")]
	public SpriteRenderer qualitySprite;

	// Token: 0x04000699 RID: 1689
	[Token(Token = "0x4000699")]
	[FieldOffset(Offset = "0x34")]
	public SpriteRenderer glowSprite;

	// Token: 0x0400069A RID: 1690
	[Token(Token = "0x400069A")]
	[FieldOffset(Offset = "0x38")]
	public SpriteRenderer MaskArea;

	// Token: 0x0400069B RID: 1691
	[Token(Token = "0x400069B")]
	[FieldOffset(Offset = "0x3C")]
	public SpriteRenderer SelectionHighlight;

	// Token: 0x0400069C RID: 1692
	[Token(Token = "0x400069C")]
	[FieldOffset(Offset = "0x40")]
	public GameObject data;

	// Token: 0x0400069D RID: 1693
	[Token(Token = "0x400069D")]
	[FieldOffset(Offset = "0x44")]
	public bool unlocked;

	// Token: 0x0400069E RID: 1694
	[Token(Token = "0x400069E")]
	[FieldOffset(Offset = "0x48")]
	public SpriteAnim Animator;

	// Token: 0x0400069F RID: 1695
	[Token(Token = "0x400069F")]
	[FieldOffset(Offset = "0x4C")]
	public AnimationClip PurchaseAnimation;

	// Token: 0x040006A0 RID: 1696
	[Token(Token = "0x40006A0")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private UnlockableCosmetic cosmetic;

	// Token: 0x040006A1 RID: 1697
	[Token(Token = "0x40006A1")]
	[FieldOffset(Offset = "0x54")]
	private CosmicubeMenu menu;

	// Token: 0x0200011C RID: 284
	[Token(Token = "0x200011C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060006B6 RID: 1718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x78D2F0", Offset = "0x78C6F0", VA = "0x1078D2F0")]
		internal void <CoPurchase>b__46_0(CosmicubeBuildHelper h)
		{
		}

		// Token: 0x040006A2 RID: 1698
		[Token(Token = "0x40006A2")]
		[FieldOffset(Offset = "0x0")]
		public static readonly CosmicubeCell.<>c <>9;

		// Token: 0x040006A3 RID: 1699
		[Token(Token = "0x40006A3")]
		[FieldOffset(Offset = "0x4")]
		public static Action<CosmicubeBuildHelper> <>9__46_0;
	}

	// Token: 0x0200011D RID: 285
	[Token(Token = "0x200011D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoPurchase>d__46 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060006B8 RID: 1720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoPurchase>d__46(int <>1__state)
		{
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x00003C90 File Offset: 0x00001E90
		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x785900", Offset = "0x784D00", VA = "0x10785900", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060006BB RID: 1723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000103")]
		private object Current
		{
			[Token(Token = "0x60006BB")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x785BC0", Offset = "0x784FC0", VA = "0x10785BC0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060006BD RID: 1725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000104")]
		private object Current
		{
			[Token(Token = "0x60006BD")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040006A4 RID: 1700
		[Token(Token = "0x40006A4")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040006A5 RID: 1701
		[Token(Token = "0x40006A5")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040006A6 RID: 1702
		[Token(Token = "0x40006A6")]
		[FieldOffset(Offset = "0x10")]
		public CosmicubeCell <>4__this;
	}

	// Token: 0x0200011E RID: 286
	[Token(Token = "0x200011E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoPurchaseAnimation>d__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060006BE RID: 1726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoPurchaseAnimation>d__48(int <>1__state)
		{
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x00003CA8 File Offset: 0x00001EA8
		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x7856C0", Offset = "0x784AC0", VA = "0x107856C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060006C1 RID: 1729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000105")]
		private object Current
		{
			[Token(Token = "0x60006C1")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x7858D0", Offset = "0x784CD0", VA = "0x107858D0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060006C3 RID: 1731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000106")]
		private object Current
		{
			[Token(Token = "0x60006C3")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040006A7 RID: 1703
		[Token(Token = "0x40006A7")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040006A8 RID: 1704
		[Token(Token = "0x40006A8")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040006A9 RID: 1705
		[Token(Token = "0x40006A9")]
		[FieldOffset(Offset = "0x10")]
		public CosmicubeCell <>4__this;
	}
}
