using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001BF RID: 447
[Token(Token = "0x20001BF")]
public class Scene1Controller : SceneController
{
	// Token: 0x06000A21 RID: 2593 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A21")]
	[Address(RVA = "0x58A360", Offset = "0x589760", VA = "0x1058A360")]
	public void OnDrawGizmos()
	{
	}

	// Token: 0x06000A22 RID: 2594 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A22")]
	[Address(RVA = "0x58A430", Offset = "0x589830", VA = "0x1058A430")]
	public void OnEnable()
	{
	}

	// Token: 0x06000A23 RID: 2595 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A23")]
	[Address(RVA = "0x58A2A0", Offset = "0x5896A0", VA = "0x1058A2A0")]
	public void OnDisable()
	{
	}

	// Token: 0x06000A24 RID: 2596 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A24")]
	[Address(RVA = "0x58A4D0", Offset = "0x5898D0", VA = "0x1058A4D0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE0F50", Offset = "0xE0350")]
	private IEnumerator RunPlayer(int idx)
	{
		return null;
	}

	// Token: 0x06000A25 RID: 2597 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A25")]
	[Address(RVA = "0x58A240", Offset = "0x589640", VA = "0x1058A240")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE0FA0", Offset = "0xE03A0")]
	private IEnumerator DoUse(int idx, int consoleid)
	{
		return null;
	}

	// Token: 0x06000A26 RID: 2598 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A26")]
	[Address(RVA = "0x58A530", Offset = "0x589930", VA = "0x1058A530")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE1000", Offset = "0xE0400")]
	public static IEnumerator WaitForSeconds(float duration)
	{
		return null;
	}

	// Token: 0x06000A27 RID: 2599 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A27")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public Scene1Controller()
	{
	}

	// Token: 0x04000A3D RID: 2621
	[Token(Token = "0x4000A3D")]
	[FieldOffset(Offset = "0xC")]
	public PlayerAnimator[] players;

	// Token: 0x04000A3E RID: 2622
	[Token(Token = "0x4000A3E")]
	[FieldOffset(Offset = "0x10")]
	public DummyConsole[] Consoles;

	// Token: 0x04000A3F RID: 2623
	[Token(Token = "0x4000A3F")]
	[FieldOffset(Offset = "0x14")]
	public Vector2[] WayPoints;

	// Token: 0x04000A40 RID: 2624
	[Token(Token = "0x4000A40")]
	[FieldOffset(Offset = "0x18")]
	public Camera backupCam;

	// Token: 0x020001C0 RID: 448
	[Token(Token = "0x20001C0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <RunPlayer>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000A28 RID: 2600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A28")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <RunPlayer>d__7(int <>1__state)
		{
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A29")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x000047D0 File Offset: 0x000029D0
		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0x36DE90", Offset = "0x36D290", VA = "0x1036DE90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000A2B RID: 2603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000190")]
		private object Current
		{
			[Token(Token = "0x6000A2B")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0x36DFF0", Offset = "0x36D3F0", VA = "0x1036DFF0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000A2D RID: 2605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000191")]
		private object Current
		{
			[Token(Token = "0x6000A2D")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000A41 RID: 2625
		[Token(Token = "0x4000A41")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000A42 RID: 2626
		[Token(Token = "0x4000A42")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000A43 RID: 2627
		[Token(Token = "0x4000A43")]
		[FieldOffset(Offset = "0x10")]
		public Scene1Controller <>4__this;

		// Token: 0x04000A44 RID: 2628
		[Token(Token = "0x4000A44")]
		[FieldOffset(Offset = "0x14")]
		public int idx;

		// Token: 0x04000A45 RID: 2629
		[Token(Token = "0x4000A45")]
		[FieldOffset(Offset = "0x18")]
		private PlayerAnimator <myPlayer>5__2;

		// Token: 0x04000A46 RID: 2630
		[Token(Token = "0x4000A46")]
		[FieldOffset(Offset = "0x1C")]
		private int <i>5__3;

		// Token: 0x04000A47 RID: 2631
		[Token(Token = "0x4000A47")]
		[FieldOffset(Offset = "0x20")]
		private bool <willInterrupt>5__4;
	}

	// Token: 0x020001C1 RID: 449
	[Token(Token = "0x20001C1")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <DoUse>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000A2E RID: 2606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <DoUse>d__8(int <>1__state)
		{
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x000047E8 File Offset: 0x000029E8
		[Token(Token = "0x6000A30")]
		[Address(RVA = "0x36A9F0", Offset = "0x369DF0", VA = "0x1036A9F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000A31 RID: 2609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000192")]
		private object Current
		{
			[Token(Token = "0x6000A31")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A32")]
		[Address(RVA = "0x36ADB0", Offset = "0x36A1B0", VA = "0x1036ADB0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000A33 RID: 2611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000193")]
		private object Current
		{
			[Token(Token = "0x6000A33")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000A48 RID: 2632
		[Token(Token = "0x4000A48")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000A49 RID: 2633
		[Token(Token = "0x4000A49")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000A4A RID: 2634
		[Token(Token = "0x4000A4A")]
		[FieldOffset(Offset = "0x10")]
		public Scene1Controller <>4__this;

		// Token: 0x04000A4B RID: 2635
		[Token(Token = "0x4000A4B")]
		[FieldOffset(Offset = "0x14")]
		public int idx;

		// Token: 0x04000A4C RID: 2636
		[Token(Token = "0x4000A4C")]
		[FieldOffset(Offset = "0x18")]
		public int consoleid;

		// Token: 0x04000A4D RID: 2637
		[Token(Token = "0x4000A4D")]
		[FieldOffset(Offset = "0x1C")]
		private PlayerAnimator <myPlayer>5__2;
	}

	// Token: 0x020001C2 RID: 450
	[Token(Token = "0x20001C2")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <WaitForSeconds>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000A34 RID: 2612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A34")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <WaitForSeconds>d__9(int <>1__state)
		{
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A35")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x00004800 File Offset: 0x00002A00
		[Token(Token = "0x6000A36")]
		[Address(RVA = "0x3728D0", Offset = "0x371CD0", VA = "0x103728D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000A37 RID: 2615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000194")]
		private object Current
		{
			[Token(Token = "0x6000A37")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A38")]
		[Address(RVA = "0x372940", Offset = "0x371D40", VA = "0x10372940", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000A39 RID: 2617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000195")]
		private object Current
		{
			[Token(Token = "0x6000A39")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000A4E RID: 2638
		[Token(Token = "0x4000A4E")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000A4F RID: 2639
		[Token(Token = "0x4000A4F")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000A50 RID: 2640
		[Token(Token = "0x4000A50")]
		[FieldOffset(Offset = "0x10")]
		public float duration;

		// Token: 0x04000A51 RID: 2641
		[Token(Token = "0x4000A51")]
		[FieldOffset(Offset = "0x14")]
		private float <time>5__2;
	}
}
