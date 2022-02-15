using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200025C RID: 604
[Token(Token = "0x200025C")]
public class TransitionOpen : MonoBehaviour
{
	// Token: 0x06000D88 RID: 3464 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D88")]
	[Address(RVA = "0x4B1C10", Offset = "0x4B1010", VA = "0x104B1C10")]
	public void OnEnable()
	{
	}

	// Token: 0x06000D89 RID: 3465 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D89")]
	[Address(RVA = "0x4B1C70", Offset = "0x4B1070", VA = "0x104B1C70")]
	public void Toggle()
	{
	}

	// Token: 0x06000D8A RID: 3466 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D8A")]
	[Address(RVA = "0x4B1BA0", Offset = "0x4B0FA0", VA = "0x104B1BA0")]
	public void Close()
	{
	}

	// Token: 0x06000D8B RID: 3467 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D8B")]
	[Address(RVA = "0x4B1B00", Offset = "0x4B0F00", VA = "0x104B1B00")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE3E60", Offset = "0xE3260")]
	private IEnumerator AnimateClose()
	{
		return null;
	}

	// Token: 0x06000D8C RID: 3468 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D8C")]
	[Address(RVA = "0x4B1B50", Offset = "0x4B0F50", VA = "0x104B1B50")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE3EF0", Offset = "0xE32F0")]
	private IEnumerator AnimateOpen()
	{
		return null;
	}

	// Token: 0x06000D8D RID: 3469 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D8D")]
	[Address(RVA = "0x4B1D10", Offset = "0x4B1110", VA = "0x104B1D10")]
	public TransitionOpen()
	{
	}

	// Token: 0x04000D66 RID: 3430
	[Token(Token = "0x4000D66")]
	[FieldOffset(Offset = "0xC")]
	public float duration;

	// Token: 0x04000D67 RID: 3431
	[Token(Token = "0x4000D67")]
	[FieldOffset(Offset = "0x10")]
	public Button.ButtonClickedEvent OnClose;

	// Token: 0x0200025D RID: 605
	[Token(Token = "0x200025D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <AnimateClose>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000D8E RID: 3470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D8E")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <AnimateClose>d__5(int <>1__state)
		{
		}

		// Token: 0x06000D8F RID: 3471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D8F")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000D90 RID: 3472 RVA: 0x00005388 File Offset: 0x00003588
		[Token(Token = "0x6000D90")]
		[Address(RVA = "0x365E60", Offset = "0x365260", VA = "0x10365E60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000D91 RID: 3473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000202")]
		private object Current
		{
			[Token(Token = "0x6000D91")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D92")]
		[Address(RVA = "0x365FC0", Offset = "0x3653C0", VA = "0x10365FC0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000D93 RID: 3475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000203")]
		private object Current
		{
			[Token(Token = "0x6000D93")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000D68 RID: 3432
		[Token(Token = "0x4000D68")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000D69 RID: 3433
		[Token(Token = "0x4000D69")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000D6A RID: 3434
		[Token(Token = "0x4000D6A")]
		[FieldOffset(Offset = "0x10")]
		public TransitionOpen <>4__this;

		// Token: 0x04000D6B RID: 3435
		[Token(Token = "0x4000D6B")]
		[FieldOffset(Offset = "0x14")]
		private Vector3 <vec>5__2;

		// Token: 0x04000D6C RID: 3436
		[Token(Token = "0x4000D6C")]
		[FieldOffset(Offset = "0x20")]
		private float <t>5__3;
	}

	// Token: 0x0200025E RID: 606
	[Token(Token = "0x200025E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <AnimateOpen>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000D94 RID: 3476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D94")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <AnimateOpen>d__6(int <>1__state)
		{
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D95")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000D96 RID: 3478 RVA: 0x000053A0 File Offset: 0x000035A0
		[Token(Token = "0x6000D96")]
		[Address(RVA = "0x3662C0", Offset = "0x3656C0", VA = "0x103662C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000D97 RID: 3479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000204")]
		private object Current
		{
			[Token(Token = "0x6000D97")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000D98 RID: 3480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D98")]
		[Address(RVA = "0x366400", Offset = "0x365800", VA = "0x10366400", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000D99 RID: 3481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000205")]
		private object Current
		{
			[Token(Token = "0x6000D99")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000D6D RID: 3437
		[Token(Token = "0x4000D6D")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000D6E RID: 3438
		[Token(Token = "0x4000D6E")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000D6F RID: 3439
		[Token(Token = "0x4000D6F")]
		[FieldOffset(Offset = "0x10")]
		public TransitionOpen <>4__this;

		// Token: 0x04000D70 RID: 3440
		[Token(Token = "0x4000D70")]
		[FieldOffset(Offset = "0x14")]
		private Vector3 <vec>5__2;

		// Token: 0x04000D71 RID: 3441
		[Token(Token = "0x4000D71")]
		[FieldOffset(Offset = "0x20")]
		private float <t>5__3;
	}
}
