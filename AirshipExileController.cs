using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200012F RID: 303
[Token(Token = "0x200012F")]
public class AirshipExileController : ExileController
{
	// Token: 0x06000709 RID: 1801 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000709")]
	[Address(RVA = "0x5444C0", Offset = "0x5438C0", VA = "0x105444C0", Slot = "4")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDE950", Offset = "0xDDD50")]
	protected override IEnumerator Animate()
	{
		return null;
	}

	// Token: 0x0600070A RID: 1802 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600070A")]
	[Address(RVA = "0x5445B0", Offset = "0x5439B0", VA = "0x105445B0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDE9A0", Offset = "0xDDDA0")]
	private IEnumerator SlowMoSlide2D(Transform target, Vector2 source, Vector2 dest, float duration)
	{
		return null;
	}

	// Token: 0x0600070B RID: 1803 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600070B")]
	[Address(RVA = "0x544640", Offset = "0x543A40", VA = "0x10544640")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDEA40", Offset = "0xDDE40")]
	protected IEnumerator WrapUpAndSpawn()
	{
		return null;
	}

	// Token: 0x0600070C RID: 1804 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600070C")]
	[Address(RVA = "0x544510", Offset = "0x543910", VA = "0x10544510")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDEA90", Offset = "0xDDE90")]
	private IEnumerator HandleText()
	{
		return null;
	}

	// Token: 0x0600070D RID: 1805 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600070D")]
	[Address(RVA = "0x544560", Offset = "0x543960", VA = "0x10544560")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDEAE0", Offset = "0xDDEE0")]
	private IEnumerator PlayerFall()
	{
		return null;
	}

	// Token: 0x0600070E RID: 1806 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600070E")]
	[Address(RVA = "0x544690", Offset = "0x543A90", VA = "0x10544690")]
	public AirshipExileController()
	{
	}

	// Token: 0x04000706 RID: 1798
	[Token(Token = "0x4000706")]
	[FieldOffset(Offset = "0x34")]
	public SpriteRenderer ForegroundCloud;

	// Token: 0x04000707 RID: 1799
	[Token(Token = "0x4000707")]
	[FieldOffset(Offset = "0x38")]
	public SpriteRenderer BackgroundCloud;

	// Token: 0x04000708 RID: 1800
	[Token(Token = "0x4000708")]
	[FieldOffset(Offset = "0x3C")]
	public SpriteRenderer Cloud1;

	// Token: 0x04000709 RID: 1801
	[Token(Token = "0x4000709")]
	[FieldOffset(Offset = "0x40")]
	public SpriteRenderer Cloud2;

	// Token: 0x0400070A RID: 1802
	[Token(Token = "0x400070A")]
	[FieldOffset(Offset = "0x44")]
	public SpriteRenderer Cloud3;

	// Token: 0x0400070B RID: 1803
	[Token(Token = "0x400070B")]
	[FieldOffset(Offset = "0x48")]
	public SpriteRenderer HandSlot;

	// Token: 0x0400070C RID: 1804
	[Token(Token = "0x400070C")]
	[FieldOffset(Offset = "0x4C")]
	public AudioClip Stinger;

	// Token: 0x0400070D RID: 1805
	[Token(Token = "0x400070D")]
	[FieldOffset(Offset = "0x50")]
	private float CloudSlowMo;

	// Token: 0x0400070E RID: 1806
	[Token(Token = "0x400070E")]
	[FieldOffset(Offset = "0x54")]
	private float PlayerSlowMo;

	// Token: 0x02000130 RID: 304
	[Token(Token = "0x2000130")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <Animate>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600070F RID: 1807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600070F")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <Animate>d__9(int <>1__state)
		{
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000710")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x00003DC8 File Offset: 0x00001FC8
		[Token(Token = "0x6000711")]
		[Address(RVA = "0x3C25F0", Offset = "0x3C19F0", VA = "0x103C25F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000712 RID: 1810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000110")]
		private object Current
		{
			[Token(Token = "0x6000712")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000713")]
		[Address(RVA = "0x3C2D00", Offset = "0x3C2100", VA = "0x103C2D00", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000714 RID: 1812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000111")]
		private object Current
		{
			[Token(Token = "0x6000714")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400070F RID: 1807
		[Token(Token = "0x400070F")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000710 RID: 1808
		[Token(Token = "0x4000710")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000711 RID: 1809
		[Token(Token = "0x4000711")]
		[FieldOffset(Offset = "0x10")]
		public AirshipExileController <>4__this;
	}

	// Token: 0x02000131 RID: 305
	[Token(Token = "0x2000131")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <SlowMoSlide2D>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000715 RID: 1813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000715")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <SlowMoSlide2D>d__10(int <>1__state)
		{
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000716")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x00003DE0 File Offset: 0x00001FE0
		[Token(Token = "0x6000717")]
		[Address(RVA = "0x3CA030", Offset = "0x3C9430", VA = "0x103CA030", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000718 RID: 1816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000112")]
		private object Current
		{
			[Token(Token = "0x6000718")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000719")]
		[Address(RVA = "0x3CA1C0", Offset = "0x3C95C0", VA = "0x103CA1C0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x0600071A RID: 1818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000113")]
		private object Current
		{
			[Token(Token = "0x600071A")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000712 RID: 1810
		[Token(Token = "0x4000712")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000713 RID: 1811
		[Token(Token = "0x4000713")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000714 RID: 1812
		[Token(Token = "0x4000714")]
		[FieldOffset(Offset = "0x10")]
		public Transform target;

		// Token: 0x04000715 RID: 1813
		[Token(Token = "0x4000715")]
		[FieldOffset(Offset = "0x14")]
		public float duration;

		// Token: 0x04000716 RID: 1814
		[Token(Token = "0x4000716")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 source;

		// Token: 0x04000717 RID: 1815
		[Token(Token = "0x4000717")]
		[FieldOffset(Offset = "0x20")]
		public Vector2 dest;

		// Token: 0x04000718 RID: 1816
		[Token(Token = "0x4000718")]
		[FieldOffset(Offset = "0x28")]
		public AirshipExileController <>4__this;

		// Token: 0x04000719 RID: 1817
		[Token(Token = "0x4000719")]
		[FieldOffset(Offset = "0x2C")]
		private Vector3 <temp>5__2;

		// Token: 0x0400071A RID: 1818
		[Token(Token = "0x400071A")]
		[FieldOffset(Offset = "0x38")]
		private float <time>5__3;
	}

	// Token: 0x02000132 RID: 306
	[Token(Token = "0x2000132")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <WrapUpAndSpawn>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600071B RID: 1819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600071B")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <WrapUpAndSpawn>d__11(int <>1__state)
		{
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600071C")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x00003DF8 File Offset: 0x00001FF8
		[Token(Token = "0x600071D")]
		[Address(RVA = "0x3CAF70", Offset = "0x3CA370", VA = "0x103CAF70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x0600071E RID: 1822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000114")]
		private object Current
		{
			[Token(Token = "0x600071E")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600071F")]
		[Address(RVA = "0x3CB0F0", Offset = "0x3CA4F0", VA = "0x103CB0F0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000720 RID: 1824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000115")]
		private object Current
		{
			[Token(Token = "0x6000720")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400071B RID: 1819
		[Token(Token = "0x400071B")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x0400071C RID: 1820
		[Token(Token = "0x400071C")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x0400071D RID: 1821
		[Token(Token = "0x400071D")]
		[FieldOffset(Offset = "0x10")]
		public AirshipExileController <>4__this;
	}

	// Token: 0x02000133 RID: 307
	[Token(Token = "0x2000133")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <HandleText>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000721 RID: 1825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000721")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <HandleText>d__12(int <>1__state)
		{
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000722")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x00003E10 File Offset: 0x00002010
		[Token(Token = "0x6000723")]
		[Address(RVA = "0x3C7A70", Offset = "0x3C6E70", VA = "0x103C7A70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000724 RID: 1828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000116")]
		private object Current
		{
			[Token(Token = "0x6000724")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000725")]
		[Address(RVA = "0x3C7ED0", Offset = "0x3C72D0", VA = "0x103C7ED0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000726 RID: 1830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000117")]
		private object Current
		{
			[Token(Token = "0x6000726")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400071E RID: 1822
		[Token(Token = "0x400071E")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x0400071F RID: 1823
		[Token(Token = "0x400071F")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000720 RID: 1824
		[Token(Token = "0x4000720")]
		[FieldOffset(Offset = "0x10")]
		public AirshipExileController <>4__this;

		// Token: 0x04000721 RID: 1825
		[Token(Token = "0x4000721")]
		[FieldOffset(Offset = "0x14")]
		private float <newDur>5__2;

		// Token: 0x04000722 RID: 1826
		[Token(Token = "0x4000722")]
		[FieldOffset(Offset = "0x18")]
		private float <t>5__3;
	}

	// Token: 0x02000134 RID: 308
	[Token(Token = "0x2000134")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <PlayerFall>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000727 RID: 1831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000727")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <PlayerFall>d__13(int <>1__state)
		{
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000728")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x00003E28 File Offset: 0x00002028
		[Token(Token = "0x6000729")]
		[Address(RVA = "0x3C9050", Offset = "0x3C8450", VA = "0x103C9050", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x0600072A RID: 1834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000118")]
		private object Current
		{
			[Token(Token = "0x600072A")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600072B")]
		[Address(RVA = "0x3C9480", Offset = "0x3C8880", VA = "0x103C9480", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x0600072C RID: 1836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000119")]
		private object Current
		{
			[Token(Token = "0x600072C")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000723 RID: 1827
		[Token(Token = "0x4000723")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000724 RID: 1828
		[Token(Token = "0x4000724")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000725 RID: 1829
		[Token(Token = "0x4000725")]
		[FieldOffset(Offset = "0x10")]
		public AirshipExileController <>4__this;

		// Token: 0x04000726 RID: 1830
		[Token(Token = "0x4000726")]
		[FieldOffset(Offset = "0x14")]
		private Vector2 <sourcePos>5__2;

		// Token: 0x04000727 RID: 1831
		[Token(Token = "0x4000727")]
		[FieldOffset(Offset = "0x1C")]
		private Vector2 <targetPos>5__3;

		// Token: 0x04000728 RID: 1832
		[Token(Token = "0x4000728")]
		[FieldOffset(Offset = "0x24")]
		private Vector2 <anchor>5__4;

		// Token: 0x04000729 RID: 1833
		[Token(Token = "0x4000729")]
		[FieldOffset(Offset = "0x2C")]
		private float <d>5__5;

		// Token: 0x0400072A RID: 1834
		[Token(Token = "0x400072A")]
		[FieldOffset(Offset = "0x30")]
		private float <t>5__6;
	}
}
