using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200025A RID: 602
[Token(Token = "0x200025A")]
public class TransitionFade : DestroyableSingleton<TransitionFade>
{
	// Token: 0x06000D7F RID: 3455 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D7F")]
	[Address(RVA = "0x4B1A40", Offset = "0x4B0E40", VA = "0x104B1A40")]
	public void DoTransitionFade(GameObject transitionFrom, GameObject transitionTo, Action callback)
	{
	}

	// Token: 0x06000D80 RID: 3456 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D80")]
	[Address(RVA = "0x4B19D0", Offset = "0x4B0DD0", VA = "0x104B19D0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE3CD0", Offset = "0xE30D0")]
	private IEnumerator CoShow(GameObject transitionFrom, GameObject transitionTo, Action callback)
	{
		return null;
	}

	// Token: 0x06000D81 RID: 3457 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D81")]
	[Address(RVA = "0x4B1AC0", Offset = "0x4B0EC0", VA = "0x104B1AC0")]
	public TransitionFade()
	{
	}

	// Token: 0x04000D5F RID: 3423
	[Token(Token = "0x4000D5F")]
	[FieldOffset(Offset = "0x10")]
	public SpriteRenderer overlay;

	// Token: 0x0200025B RID: 603
	[Token(Token = "0x200025B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoShow>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000D82 RID: 3458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D82")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoShow>d__2(int <>1__state)
		{
		}

		// Token: 0x06000D83 RID: 3459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D83")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000D84 RID: 3460 RVA: 0x00005370 File Offset: 0x00003570
		[Token(Token = "0x6000D84")]
		[Address(RVA = "0x369A50", Offset = "0x368E50", VA = "0x10369A50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000D85 RID: 3461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000200")]
		private object Current
		{
			[Token(Token = "0x6000D85")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D86")]
		[Address(RVA = "0x369D50", Offset = "0x369150", VA = "0x10369D50", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000D87 RID: 3463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000201")]
		private object Current
		{
			[Token(Token = "0x6000D87")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000D60 RID: 3424
		[Token(Token = "0x4000D60")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000D61 RID: 3425
		[Token(Token = "0x4000D61")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000D62 RID: 3426
		[Token(Token = "0x4000D62")]
		[FieldOffset(Offset = "0x10")]
		public TransitionFade <>4__this;

		// Token: 0x04000D63 RID: 3427
		[Token(Token = "0x4000D63")]
		[FieldOffset(Offset = "0x14")]
		public GameObject transitionFrom;

		// Token: 0x04000D64 RID: 3428
		[Token(Token = "0x4000D64")]
		[FieldOffset(Offset = "0x18")]
		public GameObject transitionTo;

		// Token: 0x04000D65 RID: 3429
		[Token(Token = "0x4000D65")]
		[FieldOffset(Offset = "0x1C")]
		public Action callback;
	}
}
