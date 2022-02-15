using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004A1 RID: 1185
[Token(Token = "0x20004A1")]
public abstract class Minigame : MonoBehaviour
{
	// Token: 0x1700039D RID: 925
	// (get) Token: 0x0600192A RID: 6442 RVA: 0x00007E30 File Offset: 0x00006030
	[Token(Token = "0x1700039D")]
	public TaskTypes TaskType
	{
		[Token(Token = "0x600192A")]
		[Address(RVA = "0x773150", Offset = "0x772550", VA = "0x10773150")]
		get
		{
			return TaskTypes.SubmitScan;
		}
	}

	// Token: 0x1700039E RID: 926
	// (get) Token: 0x0600192B RID: 6443 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600192C RID: 6444 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700039E")]
	public global::Console Console
	{
		[Token(Token = "0x600192B")]
		[Address(RVA = "0x277A30", Offset = "0x276E30", VA = "0x10277A30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600192C")]
		[Address(RVA = "0x277A50", Offset = "0x276E50", VA = "0x10277A50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		set
		{
		}
	}

	// Token: 0x1700039F RID: 927
	// (get) Token: 0x0600192D RID: 6445 RVA: 0x00007E48 File Offset: 0x00006048
	[Token(Token = "0x1700039F")]
	protected int ConsoleId
	{
		[Token(Token = "0x600192D")]
		[Address(RVA = "0x7730E0", Offset = "0x7724E0", VA = "0x107730E0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x0600192E RID: 6446 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600192E")]
	[Address(RVA = "0x772AB0", Offset = "0x771EB0", VA = "0x10772AB0", Slot = "4")]
	public virtual void Begin(PlayerTask task)
	{
	}

	// Token: 0x0600192F RID: 6447 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600192F")]
	[Address(RVA = "0x772F00", Offset = "0x772300", VA = "0x10772F00")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE06A0", Offset = "0xDFAA0")]
	protected IEnumerator CoStartClose(float duration = 0.75f)
	{
		return null;
	}

	// Token: 0x06001930 RID: 6448 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001930")]
	[Address(RVA = "0x6125D0", Offset = "0x6119D0", VA = "0x106125D0")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0xE06F0", Offset = "0xDFAF0")]
	public void Close(bool allowMovement)
	{
	}

	// Token: 0x06001931 RID: 6449 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001931")]
	[Address(RVA = "0x772F60", Offset = "0x772360", VA = "0x10772F60")]
	public void ForceClose()
	{
	}

	// Token: 0x06001932 RID: 6450 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001932")]
	[Address(RVA = "0x772C60", Offset = "0x772060", VA = "0x10772C60", Slot = "5")]
	public virtual void Close()
	{
	}

	// Token: 0x06001933 RID: 6451 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001933")]
	[Address(RVA = "0x772E60", Offset = "0x772260", VA = "0x10772E60", Slot = "6")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE0720", Offset = "0xDFB20")]
	protected virtual IEnumerator CoAnimateOpen()
	{
		return null;
	}

	// Token: 0x06001934 RID: 6452 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001934")]
	[Address(RVA = "0x772EB0", Offset = "0x7722B0", VA = "0x10772EB0", Slot = "7")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE0770", Offset = "0xDFB70")]
	protected virtual IEnumerator CoDestroySelf()
	{
		return null;
	}

	// Token: 0x06001935 RID: 6453 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001935")]
	[Address(RVA = "0x772FD0", Offset = "0x7723D0", VA = "0x10772FD0")]
	public void SetupInput(bool disableCursor, bool suppressInGamePlayerList = false)
	{
	}

	// Token: 0x06001936 RID: 6454 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001936")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	protected Minigame()
	{
	}

	// Token: 0x0400192E RID: 6446
	[Token(Token = "0x400192E")]
	[FieldOffset(Offset = "0x0")]
	public static Minigame Instance;

	// Token: 0x0400192F RID: 6447
	[Token(Token = "0x400192F")]
	public const float Depth = -50f;

	// Token: 0x04001930 RID: 6448
	[Token(Token = "0x4001930")]
	[FieldOffset(Offset = "0xC")]
	public TransitionType TransType;

	// Token: 0x04001931 RID: 6449
	[Token(Token = "0x4001931")]
	[FieldOffset(Offset = "0x10")]
	protected PlayerTask MyTask;

	// Token: 0x04001932 RID: 6450
	[Token(Token = "0x4001932")]
	[FieldOffset(Offset = "0x14")]
	protected NormalPlayerTask MyNormTask;

	// Token: 0x04001933 RID: 6451
	[Token(Token = "0x4001933")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private global::Console <Console>k__BackingField;

	// Token: 0x04001934 RID: 6452
	[Token(Token = "0x4001934")]
	[FieldOffset(Offset = "0x1C")]
	protected Minigame.CloseState amClosing;

	// Token: 0x04001935 RID: 6453
	[Token(Token = "0x4001935")]
	[FieldOffset(Offset = "0x20")]
	protected bool amOpening;

	// Token: 0x04001936 RID: 6454
	[Token(Token = "0x4001936")]
	[FieldOffset(Offset = "0x24")]
	public AudioClip OpenSound;

	// Token: 0x04001937 RID: 6455
	[Token(Token = "0x4001937")]
	[FieldOffset(Offset = "0x28")]
	public AudioClip CloseSound;

	// Token: 0x04001938 RID: 6456
	[Token(Token = "0x4001938")]
	[FieldOffset(Offset = "0x2C")]
	[NonSerialized]
	public SpecialInputHandler inputHandler;

	// Token: 0x020004A2 RID: 1186
	[Token(Token = "0x20004A2")]
	protected enum CloseState
	{
		// Token: 0x0400193A RID: 6458
		[Token(Token = "0x400193A")]
		None,
		// Token: 0x0400193B RID: 6459
		[Token(Token = "0x400193B")]
		Waiting,
		// Token: 0x0400193C RID: 6460
		[Token(Token = "0x400193C")]
		Closing
	}

	// Token: 0x020004A3 RID: 1187
	[Token(Token = "0x20004A3")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoStartClose>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001937 RID: 6455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001937")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoStartClose>d__20(int <>1__state)
		{
		}

		// Token: 0x06001938 RID: 6456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001938")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001939 RID: 6457 RVA: 0x00007E60 File Offset: 0x00006060
		[Token(Token = "0x6001939")]
		[Address(RVA = "0x795770", Offset = "0x794B70", VA = "0x10795770", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x0600193A RID: 6458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A0")]
		private object Current
		{
			[Token(Token = "0x600193A")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600193B RID: 6459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600193B")]
		[Address(RVA = "0x795840", Offset = "0x794C40", VA = "0x10795840", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x0600193C RID: 6460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A1")]
		private object Current
		{
			[Token(Token = "0x600193C")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400193D RID: 6461
		[Token(Token = "0x400193D")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x0400193E RID: 6462
		[Token(Token = "0x400193E")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x0400193F RID: 6463
		[Token(Token = "0x400193F")]
		[FieldOffset(Offset = "0x10")]
		public Minigame <>4__this;

		// Token: 0x04001940 RID: 6464
		[Token(Token = "0x4001940")]
		[FieldOffset(Offset = "0x14")]
		public float duration;
	}

	// Token: 0x020004A4 RID: 1188
	[Token(Token = "0x20004A4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoAnimateOpen>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600193D RID: 6461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600193D")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoAnimateOpen>d__24(int <>1__state)
		{
		}

		// Token: 0x0600193E RID: 6462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600193E")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600193F RID: 6463 RVA: 0x00007E78 File Offset: 0x00006078
		[Token(Token = "0x600193F")]
		[Address(RVA = "0x791950", Offset = "0x790D50", VA = "0x10791950", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06001940 RID: 6464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A2")]
		private object Current
		{
			[Token(Token = "0x6001940")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001941 RID: 6465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001941")]
		[Address(RVA = "0x791E10", Offset = "0x791210", VA = "0x10791E10", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06001942 RID: 6466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A3")]
		private object Current
		{
			[Token(Token = "0x6001942")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04001941 RID: 6465
		[Token(Token = "0x4001941")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04001942 RID: 6466
		[Token(Token = "0x4001942")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04001943 RID: 6467
		[Token(Token = "0x4001943")]
		[FieldOffset(Offset = "0x10")]
		public Minigame <>4__this;

		// Token: 0x04001944 RID: 6468
		[Token(Token = "0x4001944")]
		[FieldOffset(Offset = "0x14")]
		private float <depth>5__2;

		// Token: 0x04001945 RID: 6469
		[Token(Token = "0x4001945")]
		[FieldOffset(Offset = "0x18")]
		private float <timer>5__3;

		// Token: 0x04001946 RID: 6470
		[Token(Token = "0x4001946")]
		[FieldOffset(Offset = "0x1C")]
		private SpriteRenderer[] <rends>5__4;
	}

	// Token: 0x020004A5 RID: 1189
	[Token(Token = "0x20004A5")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoDestroySelf>d__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001943 RID: 6467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001943")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoDestroySelf>d__25(int <>1__state)
		{
		}

		// Token: 0x06001944 RID: 6468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001944")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001945 RID: 6469 RVA: 0x00007E90 File Offset: 0x00006090
		[Token(Token = "0x6001945")]
		[Address(RVA = "0x792940", Offset = "0x791D40", VA = "0x10792940", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06001946 RID: 6470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A4")]
		private object Current
		{
			[Token(Token = "0x6001946")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001947 RID: 6471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001947")]
		[Address(RVA = "0x792C50", Offset = "0x792050", VA = "0x10792C50", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06001948 RID: 6472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A5")]
		private object Current
		{
			[Token(Token = "0x6001948")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04001947 RID: 6471
		[Token(Token = "0x4001947")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04001948 RID: 6472
		[Token(Token = "0x4001948")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04001949 RID: 6473
		[Token(Token = "0x4001949")]
		[FieldOffset(Offset = "0x10")]
		public Minigame <>4__this;

		// Token: 0x0400194A RID: 6474
		[Token(Token = "0x400194A")]
		[FieldOffset(Offset = "0x14")]
		private float <timer>5__2;

		// Token: 0x0400194B RID: 6475
		[Token(Token = "0x400194B")]
		[FieldOffset(Offset = "0x18")]
		private SpriteRenderer[] <rends>5__3;
	}
}
