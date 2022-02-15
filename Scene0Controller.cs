using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001BB RID: 443
[Token(Token = "0x20001BB")]
public class Scene0Controller : SceneController
{
	// Token: 0x06000A09 RID: 2569 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A09")]
	[Address(RVA = "0x58A0A0", Offset = "0x5894A0", VA = "0x1058A0A0")]
	public void OnEnable()
	{
	}

	// Token: 0x06000A0A RID: 2570 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A0A")]
	[Address(RVA = "0x58A030", Offset = "0x589430", VA = "0x1058A030")]
	public void OnDisable()
	{
	}

	// Token: 0x06000A0B RID: 2571 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A0B")]
	[Address(RVA = "0x58A1C0", Offset = "0x5895C0", VA = "0x1058A1C0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE0DC0", Offset = "0xE01C0")]
	private IEnumerator Run()
	{
		return null;
	}

	// Token: 0x06000A0C RID: 2572 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A0C")]
	[Address(RVA = "0x58A100", Offset = "0x589500", VA = "0x1058A100")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE0E10", Offset = "0xE0210")]
	private IEnumerator PopIn(SpriteRenderer boy)
	{
		return null;
	}

	// Token: 0x06000A0D RID: 2573 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A0D")]
	[Address(RVA = "0x58A160", Offset = "0x589560", VA = "0x1058A160")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE0EB0", Offset = "0xE02B0")]
	private IEnumerator PopOut(SpriteRenderer boy)
	{
		return null;
	}

	// Token: 0x06000A0E RID: 2574 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A0E")]
	[Address(RVA = "0x58A210", Offset = "0x589610", VA = "0x1058A210")]
	public Scene0Controller()
	{
	}

	// Token: 0x04000A29 RID: 2601
	[Token(Token = "0x4000A29")]
	[FieldOffset(Offset = "0xC")]
	public float Duration;

	// Token: 0x04000A2A RID: 2602
	[Token(Token = "0x4000A2A")]
	[FieldOffset(Offset = "0x10")]
	public SpriteRenderer[] ExtraBoys;

	// Token: 0x04000A2B RID: 2603
	[Token(Token = "0x4000A2B")]
	[FieldOffset(Offset = "0x14")]
	public AnimationCurve PopInCurve;

	// Token: 0x04000A2C RID: 2604
	[Token(Token = "0x4000A2C")]
	[FieldOffset(Offset = "0x18")]
	public AnimationCurve PopOutCurve;

	// Token: 0x04000A2D RID: 2605
	[Token(Token = "0x4000A2D")]
	[FieldOffset(Offset = "0x1C")]
	public float OutDuration;

	// Token: 0x020001BC RID: 444
	[Token(Token = "0x20001BC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <Run>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000A0F RID: 2575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A0F")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <Run>d__7(int <>1__state)
		{
		}

		// Token: 0x06000A10 RID: 2576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A10")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000A11 RID: 2577 RVA: 0x00004788 File Offset: 0x00002988
		[Token(Token = "0x6000A11")]
		[Address(RVA = "0x36F3C0", Offset = "0x36E7C0", VA = "0x1036F3C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000A12 RID: 2578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700018A")]
		private object Current
		{
			[Token(Token = "0x6000A12")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A13")]
		[Address(RVA = "0x36F790", Offset = "0x36EB90", VA = "0x1036F790", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000A14 RID: 2580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700018B")]
		private object Current
		{
			[Token(Token = "0x6000A14")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000A2E RID: 2606
		[Token(Token = "0x4000A2E")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000A2F RID: 2607
		[Token(Token = "0x4000A2F")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000A30 RID: 2608
		[Token(Token = "0x4000A30")]
		[FieldOffset(Offset = "0x10")]
		public Scene0Controller <>4__this;

		// Token: 0x04000A31 RID: 2609
		[Token(Token = "0x4000A31")]
		[FieldOffset(Offset = "0x14")]
		private int <lastBoy>5__2;

		// Token: 0x04000A32 RID: 2610
		[Token(Token = "0x4000A32")]
		[FieldOffset(Offset = "0x18")]
		private float <start>5__3;
	}

	// Token: 0x020001BD RID: 445
	[Token(Token = "0x20001BD")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <PopIn>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000A15 RID: 2581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A15")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <PopIn>d__8(int <>1__state)
		{
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A16")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x000047A0 File Offset: 0x000029A0
		[Token(Token = "0x6000A17")]
		[Address(RVA = "0x36D390", Offset = "0x36C790", VA = "0x1036D390", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000A18 RID: 2584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700018C")]
		private object Current
		{
			[Token(Token = "0x6000A18")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A19")]
		[Address(RVA = "0x36D4F0", Offset = "0x36C8F0", VA = "0x1036D4F0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000A1A RID: 2586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700018D")]
		private object Current
		{
			[Token(Token = "0x6000A1A")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000A33 RID: 2611
		[Token(Token = "0x4000A33")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000A34 RID: 2612
		[Token(Token = "0x4000A34")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000A35 RID: 2613
		[Token(Token = "0x4000A35")]
		[FieldOffset(Offset = "0x10")]
		public SpriteRenderer boy;

		// Token: 0x04000A36 RID: 2614
		[Token(Token = "0x4000A36")]
		[FieldOffset(Offset = "0x14")]
		public Scene0Controller <>4__this;

		// Token: 0x04000A37 RID: 2615
		[Token(Token = "0x4000A37")]
		[FieldOffset(Offset = "0x18")]
		private float <timer>5__2;
	}

	// Token: 0x020001BE RID: 446
	[Token(Token = "0x20001BE")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <PopOut>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000A1B RID: 2587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <PopOut>d__9(int <>1__state)
		{
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x000047B8 File Offset: 0x000029B8
		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0x36D520", Offset = "0x36C920", VA = "0x1036D520", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000A1E RID: 2590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700018E")]
		private object Current
		{
			[Token(Token = "0x6000A1E")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A1F")]
		[Address(RVA = "0x36D6A0", Offset = "0x36CAA0", VA = "0x1036D6A0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000A20 RID: 2592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700018F")]
		private object Current
		{
			[Token(Token = "0x6000A20")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000A38 RID: 2616
		[Token(Token = "0x4000A38")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000A39 RID: 2617
		[Token(Token = "0x4000A39")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000A3A RID: 2618
		[Token(Token = "0x4000A3A")]
		[FieldOffset(Offset = "0x10")]
		public SpriteRenderer boy;

		// Token: 0x04000A3B RID: 2619
		[Token(Token = "0x4000A3B")]
		[FieldOffset(Offset = "0x14")]
		public Scene0Controller <>4__this;

		// Token: 0x04000A3C RID: 2620
		[Token(Token = "0x4000A3C")]
		[FieldOffset(Offset = "0x18")]
		private float <timer>5__2;
	}
}
