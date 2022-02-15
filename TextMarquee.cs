using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x0200010A RID: 266
[Token(Token = "0x200010A")]
public class TextMarquee : MonoBehaviour
{
	// Token: 0x06000656 RID: 1622 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000656")]
	[Address(RVA = "0x4AC0B0", Offset = "0x4AB4B0", VA = "0x104AC0B0")]
	public void Start()
	{
	}

	// Token: 0x06000657 RID: 1623 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000657")]
	[Address(RVA = "0x4AC110", Offset = "0x4AB510", VA = "0x104AC110")]
	private void UpdateRendererList()
	{
	}

	// Token: 0x06000658 RID: 1624 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000658")]
	[Address(RVA = "0x4AC290", Offset = "0x4AB690", VA = "0x104AC290")]
	private void Update()
	{
	}

	// Token: 0x06000659 RID: 1625 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000659")]
	[Address(RVA = "0x4AC060", Offset = "0x4AB460", VA = "0x104AC060")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDDE20", Offset = "0xDD220")]
	private IEnumerator Run()
	{
		return null;
	}

	// Token: 0x0600065A RID: 1626 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600065A")]
	[Address(RVA = "0x4AC440", Offset = "0x4AB840", VA = "0x104AC440")]
	public TextMarquee()
	{
	}

	// Token: 0x04000652 RID: 1618
	[Token(Token = "0x4000652")]
	[FieldOffset(Offset = "0xC")]
	public TextMeshPro Target;

	// Token: 0x04000653 RID: 1619
	[Token(Token = "0x4000653")]
	[FieldOffset(Offset = "0x10")]
	private MeshRenderer[] allRenderers;

	// Token: 0x04000654 RID: 1620
	[Token(Token = "0x4000654")]
	[FieldOffset(Offset = "0x14")]
	private int lastChildCount;

	// Token: 0x04000655 RID: 1621
	[Token(Token = "0x4000655")]
	[FieldOffset(Offset = "0x18")]
	private string targetText;

	// Token: 0x04000656 RID: 1622
	[Token(Token = "0x4000656")]
	[FieldOffset(Offset = "0x1C")]
	public float ScrollSpeed;

	// Token: 0x04000657 RID: 1623
	[Token(Token = "0x4000657")]
	[FieldOffset(Offset = "0x20")]
	public float PauseTime;

	// Token: 0x04000658 RID: 1624
	[Token(Token = "0x4000658")]
	[FieldOffset(Offset = "0x24")]
	public float AreaWidth;

	// Token: 0x04000659 RID: 1625
	[Token(Token = "0x4000659")]
	[FieldOffset(Offset = "0x28")]
	public bool IgnoreTextChanges;

	// Token: 0x0200010B RID: 267
	[Token(Token = "0x200010B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x0600065C RID: 1628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600065C")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600065D")]
		[Address(RVA = "0x370A30", Offset = "0x36FE30", VA = "0x10370A30")]
		internal void <UpdateRendererList>b__9_0(MeshRenderer render)
		{
		}

		// Token: 0x0400065A RID: 1626
		[Token(Token = "0x400065A")]
		[FieldOffset(Offset = "0x0")]
		public static readonly TextMarquee.<>c <>9;

		// Token: 0x0400065B RID: 1627
		[Token(Token = "0x400065B")]
		[FieldOffset(Offset = "0x4")]
		public static Action<MeshRenderer> <>9__9_0;
	}

	// Token: 0x0200010C RID: 268
	[Token(Token = "0x200010C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass11_0
	{
		// Token: 0x0600065E RID: 1630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600065E")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass11_0()
		{
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600065F")]
		[Address(RVA = "0x370E10", Offset = "0x370210", VA = "0x10370E10")]
		internal void <Run>b__0(MeshRenderer render)
		{
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000660")]
		[Address(RVA = "0x370EB0", Offset = "0x3702B0", VA = "0x10370EB0")]
		internal void <Run>b__1(MeshRenderer render)
		{
		}

		// Token: 0x0400065C RID: 1628
		[Token(Token = "0x400065C")]
		[FieldOffset(Offset = "0x8")]
		public Vector4 temp;

		// Token: 0x0400065D RID: 1629
		[Token(Token = "0x400065D")]
		[FieldOffset(Offset = "0x18")]
		public Action<MeshRenderer> <>9__1;
	}

	// Token: 0x0200010D RID: 269
	[Token(Token = "0x200010D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <Run>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000661 RID: 1633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000661")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <Run>d__11(int <>1__state)
		{
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000662")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x00003A50 File Offset: 0x00001C50
		[Token(Token = "0x6000663")]
		[Address(RVA = "0x36E850", Offset = "0x36DC50", VA = "0x1036E850", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000664 RID: 1636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000F2")]
		private object Current
		{
			[Token(Token = "0x6000664")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000665")]
		[Address(RVA = "0x36ECD0", Offset = "0x36E0D0", VA = "0x1036ECD0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000666 RID: 1638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000F3")]
		private object Current
		{
			[Token(Token = "0x6000666")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400065E RID: 1630
		[Token(Token = "0x400065E")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x0400065F RID: 1631
		[Token(Token = "0x400065F")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000660 RID: 1632
		[Token(Token = "0x4000660")]
		[FieldOffset(Offset = "0x10")]
		public TextMarquee <>4__this;

		// Token: 0x04000661 RID: 1633
		[Token(Token = "0x4000661")]
		[FieldOffset(Offset = "0x14")]
		private TextMarquee.<>c__DisplayClass11_0 <>8__1;

		// Token: 0x04000662 RID: 1634
		[Token(Token = "0x4000662")]
		[FieldOffset(Offset = "0x18")]
		private int <i>5__2;

		// Token: 0x04000663 RID: 1635
		[Token(Token = "0x4000663")]
		[FieldOffset(Offset = "0x1C")]
		private float <timer>5__3;
	}
}
