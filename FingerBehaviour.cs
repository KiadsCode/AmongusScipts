using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001B4 RID: 436
[Token(Token = "0x20001B4")]
public class FingerBehaviour : MonoBehaviour
{
	// Token: 0x060009E4 RID: 2532 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009E4")]
	[Address(RVA = "0x3A6F90", Offset = "0x3A6390", VA = "0x103A6F90")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE0BE0", Offset = "0xDFFE0")]
	public IEnumerator DoClick(float duration)
	{
		return null;
	}

	// Token: 0x060009E5 RID: 2533 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009E5")]
	[Address(RVA = "0x3A7070", Offset = "0x3A6470", VA = "0x103A7070")]
	private void SetFingerAngle(float angle)
	{
	}

	// Token: 0x060009E6 RID: 2534 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009E6")]
	[Address(RVA = "0x3A6ED0", Offset = "0x3A62D0", VA = "0x103A6ED0")]
	public void ClickOff()
	{
	}

	// Token: 0x060009E7 RID: 2535 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009E7")]
	[Address(RVA = "0x3A6F10", Offset = "0x3A6310", VA = "0x103A6F10")]
	public void ClickOn()
	{
	}

	// Token: 0x060009E8 RID: 2536 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009E8")]
	[Address(RVA = "0x3A7000", Offset = "0x3A6400", VA = "0x103A7000")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE0C30", Offset = "0xE0030")]
	public IEnumerator MoveTo(Vector2 target, float duration)
	{
		return null;
	}

	// Token: 0x060009E9 RID: 2537 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009E9")]
	[Address(RVA = "0x3A70E0", Offset = "0x3A64E0", VA = "0x103A70E0")]
	public FingerBehaviour()
	{
	}

	// Token: 0x04000A00 RID: 2560
	[Token(Token = "0x4000A00")]
	[FieldOffset(Offset = "0xC")]
	public SpriteRenderer Finger;

	// Token: 0x04000A01 RID: 2561
	[Token(Token = "0x4000A01")]
	[FieldOffset(Offset = "0x10")]
	public SpriteRenderer Click;

	// Token: 0x04000A02 RID: 2562
	[Token(Token = "0x4000A02")]
	[FieldOffset(Offset = "0x14")]
	public float liftedAngle;

	// Token: 0x020001B5 RID: 437
	[Token(Token = "0x20001B5")]
	public static class Quadratic
	{
		// Token: 0x060009EA RID: 2538 RVA: 0x00004728 File Offset: 0x00002928
		[Token(Token = "0x60009EA")]
		[Address(RVA = "0x781630", Offset = "0x780A30", VA = "0x10781630")]
		public static float InOut(float k)
		{
			return 0f;
		}
	}

	// Token: 0x020001B6 RID: 438
	[Token(Token = "0x20001B6")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <DoClick>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060009EB RID: 2539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009EB")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <DoClick>d__3(int <>1__state)
		{
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009EC")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x00004740 File Offset: 0x00002940
		[Token(Token = "0x60009ED")]
		[Address(RVA = "0x787AD0", Offset = "0x786ED0", VA = "0x10787AD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060009EE RID: 2542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000184")]
		private object Current
		{
			[Token(Token = "0x60009EE")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009EF")]
		[Address(RVA = "0x787C80", Offset = "0x787080", VA = "0x10787C80", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060009F0 RID: 2544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000185")]
		private object Current
		{
			[Token(Token = "0x60009F0")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000A03 RID: 2563
		[Token(Token = "0x4000A03")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000A04 RID: 2564
		[Token(Token = "0x4000A04")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000A05 RID: 2565
		[Token(Token = "0x4000A05")]
		[FieldOffset(Offset = "0x10")]
		public float duration;

		// Token: 0x04000A06 RID: 2566
		[Token(Token = "0x4000A06")]
		[FieldOffset(Offset = "0x14")]
		public FingerBehaviour <>4__this;

		// Token: 0x04000A07 RID: 2567
		[Token(Token = "0x4000A07")]
		[FieldOffset(Offset = "0x18")]
		private float <time>5__2;
	}

	// Token: 0x020001B7 RID: 439
	[Token(Token = "0x20001B7")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <MoveTo>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060009F1 RID: 2545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009F1")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <MoveTo>d__7(int <>1__state)
		{
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009F2")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x00004758 File Offset: 0x00002958
		[Token(Token = "0x60009F3")]
		[Address(RVA = "0x788CC0", Offset = "0x7880C0", VA = "0x10788CC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060009F4 RID: 2548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000186")]
		private object Current
		{
			[Token(Token = "0x60009F4")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009F5")]
		[Address(RVA = "0x788EB0", Offset = "0x7882B0", VA = "0x10788EB0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060009F6 RID: 2550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000187")]
		private object Current
		{
			[Token(Token = "0x60009F6")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000A08 RID: 2568
		[Token(Token = "0x4000A08")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000A09 RID: 2569
		[Token(Token = "0x4000A09")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000A0A RID: 2570
		[Token(Token = "0x4000A0A")]
		[FieldOffset(Offset = "0x10")]
		public FingerBehaviour <>4__this;

		// Token: 0x04000A0B RID: 2571
		[Token(Token = "0x4000A0B")]
		[FieldOffset(Offset = "0x14")]
		public Vector2 target;

		// Token: 0x04000A0C RID: 2572
		[Token(Token = "0x4000A0C")]
		[FieldOffset(Offset = "0x1C")]
		public float duration;

		// Token: 0x04000A0D RID: 2573
		[Token(Token = "0x4000A0D")]
		[FieldOffset(Offset = "0x20")]
		private Vector3 <startPos>5__2;

		// Token: 0x04000A0E RID: 2574
		[Token(Token = "0x4000A0E")]
		[FieldOffset(Offset = "0x2C")]
		private Vector3 <targetPos>5__3;

		// Token: 0x04000A0F RID: 2575
		[Token(Token = "0x4000A0F")]
		[FieldOffset(Offset = "0x38")]
		private float <time>5__4;
	}
}
