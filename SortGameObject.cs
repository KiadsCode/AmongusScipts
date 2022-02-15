using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000287 RID: 647
[Token(Token = "0x2000287")]
public class SortGameObject : MonoBehaviour
{
	// Token: 0x06000E5A RID: 3674 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E5A")]
	[Address(RVA = "0x4A1880", Offset = "0x4A0C80", VA = "0x104A1880")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE4E40", Offset = "0xE4240")]
	public IEnumerator CoShadowRise()
	{
		return null;
	}

	// Token: 0x06000E5B RID: 3675 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E5B")]
	[Address(RVA = "0x4A1820", Offset = "0x4A0C20", VA = "0x104A1820")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE4E90", Offset = "0xE4290")]
	public IEnumerator CoShadowFall(bool inBox, AudioClip dropSound)
	{
		return null;
	}

	// Token: 0x06000E5C RID: 3676 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E5C")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public SortGameObject()
	{
	}

	// Token: 0x04000E5E RID: 3678
	[Token(Token = "0x4000E5E")]
	[FieldOffset(Offset = "0xC")]
	public SortGameObject.ObjType MyType;

	// Token: 0x04000E5F RID: 3679
	[Token(Token = "0x4000E5F")]
	[FieldOffset(Offset = "0x10")]
	public Collider2D Collider;

	// Token: 0x04000E60 RID: 3680
	[Token(Token = "0x4000E60")]
	[FieldOffset(Offset = "0x14")]
	public SpriteRenderer Image;

	// Token: 0x04000E61 RID: 3681
	[Token(Token = "0x4000E61")]
	[FieldOffset(Offset = "0x18")]
	public SpriteRenderer Shadow;

	// Token: 0x04000E62 RID: 3682
	[Token(Token = "0x4000E62")]
	private const float ShadowTime = 0.15f;

	// Token: 0x02000288 RID: 648
	[Token(Token = "0x2000288")]
	public enum ObjType
	{
		// Token: 0x04000E64 RID: 3684
		[Token(Token = "0x4000E64")]
		Plant,
		// Token: 0x04000E65 RID: 3685
		[Token(Token = "0x4000E65")]
		Mineral,
		// Token: 0x04000E66 RID: 3686
		[Token(Token = "0x4000E66")]
		Animal
	}

	// Token: 0x02000289 RID: 649
	[Token(Token = "0x2000289")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoShadowRise>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000E5D RID: 3677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E5D")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoShadowRise>d__6(int <>1__state)
		{
		}

		// Token: 0x06000E5E RID: 3678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E5E")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000E5F RID: 3679 RVA: 0x00005898 File Offset: 0x00003A98
		[Token(Token = "0x6000E5F")]
		[Address(RVA = "0x369890", Offset = "0x368C90", VA = "0x10369890", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000E60 RID: 3680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700022D")]
		private object Current
		{
			[Token(Token = "0x6000E60")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000E61 RID: 3681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E61")]
		[Address(RVA = "0x369A20", Offset = "0x368E20", VA = "0x10369A20", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000E62 RID: 3682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700022E")]
		private object Current
		{
			[Token(Token = "0x6000E62")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000E67 RID: 3687
		[Token(Token = "0x4000E67")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000E68 RID: 3688
		[Token(Token = "0x4000E68")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000E69 RID: 3689
		[Token(Token = "0x4000E69")]
		[FieldOffset(Offset = "0x10")]
		public SortGameObject <>4__this;

		// Token: 0x04000E6A RID: 3690
		[Token(Token = "0x4000E6A")]
		[FieldOffset(Offset = "0x14")]
		private float <timer>5__2;
	}

	// Token: 0x0200028A RID: 650
	[Token(Token = "0x200028A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoShadowFall>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000E63 RID: 3683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E63")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoShadowFall>d__7(int <>1__state)
		{
		}

		// Token: 0x06000E64 RID: 3684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E64")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000E65 RID: 3685 RVA: 0x000058B0 File Offset: 0x00003AB0
		[Token(Token = "0x6000E65")]
		[Address(RVA = "0x369560", Offset = "0x368960", VA = "0x10369560", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000E66 RID: 3686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700022F")]
		private object Current
		{
			[Token(Token = "0x6000E66")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000E67 RID: 3687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E67")]
		[Address(RVA = "0x369860", Offset = "0x368C60", VA = "0x10369860", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000E68 RID: 3688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000230")]
		private object Current
		{
			[Token(Token = "0x6000E68")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000E6B RID: 3691
		[Token(Token = "0x4000E6B")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000E6C RID: 3692
		[Token(Token = "0x4000E6C")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000E6D RID: 3693
		[Token(Token = "0x4000E6D")]
		[FieldOffset(Offset = "0x10")]
		public bool inBox;

		// Token: 0x04000E6E RID: 3694
		[Token(Token = "0x4000E6E")]
		[FieldOffset(Offset = "0x14")]
		public SortGameObject <>4__this;

		// Token: 0x04000E6F RID: 3695
		[Token(Token = "0x4000E6F")]
		[FieldOffset(Offset = "0x18")]
		public AudioClip dropSound;

		// Token: 0x04000E70 RID: 3696
		[Token(Token = "0x4000E70")]
		[FieldOffset(Offset = "0x1C")]
		private float <timer>5__2;
	}
}
