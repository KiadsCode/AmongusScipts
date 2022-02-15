using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000117 RID: 279
[Token(Token = "0x2000117")]
[ExecuteInEditMode]
public class CosmicubeBuildHelper : MonoBehaviour
{
	// Token: 0x06000690 RID: 1680 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000690")]
	[Address(RVA = "0x7FDDF0", Offset = "0x7FD1F0", VA = "0x107FDDF0")]
	public void AnimateUnlock(float duration)
	{
	}

	// Token: 0x06000691 RID: 1681 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000691")]
	[Address(RVA = "0x7FDE60", Offset = "0x7FD260", VA = "0x107FDE60")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDE260", Offset = "0xDD660")]
	private IEnumerator CoAnimateUnlock(float duration)
	{
		return null;
	}

	// Token: 0x06000692 RID: 1682 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000692")]
	[Address(RVA = "0x7FDEC0", Offset = "0x7FD2C0", VA = "0x107FDEC0")]
	private void Update()
	{
	}

	// Token: 0x06000693 RID: 1683 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000693")]
	[Address(RVA = "0x47A3E0", Offset = "0x4797E0", VA = "0x1047A3E0")]
	public void Show()
	{
	}

	// Token: 0x06000694 RID: 1684 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000694")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public CosmicubeBuildHelper()
	{
	}

	// Token: 0x0400067A RID: 1658
	[Token(Token = "0x400067A")]
	[FieldOffset(Offset = "0xC")]
	public CosmicubeCell cell;

	// Token: 0x0400067B RID: 1659
	[Token(Token = "0x400067B")]
	[FieldOffset(Offset = "0x10")]
	public CosmicubeBuildHelper.CubeSide cubeSide;

	// Token: 0x0400067C RID: 1660
	[Token(Token = "0x400067C")]
	[FieldOffset(Offset = "0x14")]
	public GameObject connector;

	// Token: 0x0400067D RID: 1661
	[Token(Token = "0x400067D")]
	[FieldOffset(Offset = "0x18")]
	private bool childOwned;

	// Token: 0x0400067E RID: 1662
	[Token(Token = "0x400067E")]
	[FieldOffset(Offset = "0x19")]
	private bool animating;

	// Token: 0x02000118 RID: 280
	[Token(Token = "0x2000118")]
	public enum CubeSide
	{
		// Token: 0x04000680 RID: 1664
		[Token(Token = "0x4000680")]
		East,
		// Token: 0x04000681 RID: 1665
		[Token(Token = "0x4000681")]
		West,
		// Token: 0x04000682 RID: 1666
		[Token(Token = "0x4000682")]
		North,
		// Token: 0x04000683 RID: 1667
		[Token(Token = "0x4000683")]
		South
	}

	// Token: 0x02000119 RID: 281
	[Token(Token = "0x2000119")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass7_0
	{
		// Token: 0x06000695 RID: 1685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000695")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass7_0()
		{
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000696")]
		[Address(RVA = "0x78D810", Offset = "0x78CC10", VA = "0x1078D810")]
		internal void <CoAnimateUnlock>b__0(float t)
		{
		}

		// Token: 0x04000684 RID: 1668
		[Token(Token = "0x4000684")]
		[FieldOffset(Offset = "0x8")]
		public Transform green;

		// Token: 0x04000685 RID: 1669
		[Token(Token = "0x4000685")]
		[FieldOffset(Offset = "0xC")]
		public Vector3 startScale;

		// Token: 0x04000686 RID: 1670
		[Token(Token = "0x4000686")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 endScale;

		// Token: 0x04000687 RID: 1671
		[Token(Token = "0x4000687")]
		[FieldOffset(Offset = "0x24")]
		public Vector3 startPosition;

		// Token: 0x04000688 RID: 1672
		[Token(Token = "0x4000688")]
		[FieldOffset(Offset = "0x30")]
		public Vector3 endPosition;
	}

	// Token: 0x0200011A RID: 282
	[Token(Token = "0x200011A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoAnimateUnlock>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000697 RID: 1687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000697")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoAnimateUnlock>d__7(int <>1__state)
		{
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000698")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x00003C00 File Offset: 0x00001E00
		[Token(Token = "0x6000699")]
		[Address(RVA = "0x783F30", Offset = "0x783330", VA = "0x10783F30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x0600069A RID: 1690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000FC")]
		private object Current
		{
			[Token(Token = "0x600069A")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600069B")]
		[Address(RVA = "0x784190", Offset = "0x783590", VA = "0x10784190", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x0600069C RID: 1692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000FD")]
		private object Current
		{
			[Token(Token = "0x600069C")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000689 RID: 1673
		[Token(Token = "0x4000689")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x0400068A RID: 1674
		[Token(Token = "0x400068A")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x0400068B RID: 1675
		[Token(Token = "0x400068B")]
		[FieldOffset(Offset = "0x10")]
		public CosmicubeBuildHelper <>4__this;

		// Token: 0x0400068C RID: 1676
		[Token(Token = "0x400068C")]
		[FieldOffset(Offset = "0x14")]
		public float duration;
	}
}
