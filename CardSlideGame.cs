using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x0200005C RID: 92
[Token(Token = "0x200005C")]
public class CardSlideGame : Minigame
{
	// Token: 0x06000289 RID: 649 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000289")]
	[Address(RVA = "0x82F2B0", Offset = "0x82E6B0", VA = "0x1082F2B0", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x0600028A RID: 650 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600028A")]
	[Address(RVA = "0x82F420", Offset = "0x82E820", VA = "0x1082F420")]
	public void Update()
	{
	}

	// Token: 0x0600028B RID: 651 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600028B")]
	[Address(RVA = "0x82F3C0", Offset = "0x82E7C0", VA = "0x1082F3C0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE4F30", Offset = "0xE4330")]
	private IEnumerator PutCardBack()
	{
		return null;
	}

	// Token: 0x0600028C RID: 652 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600028C")]
	[Address(RVA = "0x82F370", Offset = "0x82E770", VA = "0x1082F370")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE4F80", Offset = "0xE4380")]
	private IEnumerator InsertCard()
	{
		return null;
	}

	// Token: 0x0600028D RID: 653 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600028D")]
	[Address(RVA = "0x8306D0", Offset = "0x82FAD0", VA = "0x108306D0")]
	public CardSlideGame()
	{
	}

	// Token: 0x04000225 RID: 549
	[Token(Token = "0x4000225")]
	[FieldOffset(Offset = "0x30")]
	private Color gray;

	// Token: 0x04000226 RID: 550
	[Token(Token = "0x4000226")]
	[FieldOffset(Offset = "0x40")]
	private Color green;

	// Token: 0x04000227 RID: 551
	[Token(Token = "0x4000227")]
	[FieldOffset(Offset = "0x50")]
	private CardSlideGame.TaskStages State;

	// Token: 0x04000228 RID: 552
	[Token(Token = "0x4000228")]
	[FieldOffset(Offset = "0x54")]
	private Controller myController;

	// Token: 0x04000229 RID: 553
	[Token(Token = "0x4000229")]
	[FieldOffset(Offset = "0x58")]
	private FloatRange XRange;

	// Token: 0x0400022A RID: 554
	[Token(Token = "0x400022A")]
	[FieldOffset(Offset = "0x5C")]
	public FloatRange AcceptedTime;

	// Token: 0x0400022B RID: 555
	[Token(Token = "0x400022B")]
	[FieldOffset(Offset = "0x60")]
	public Collider2D col;

	// Token: 0x0400022C RID: 556
	[Token(Token = "0x400022C")]
	[FieldOffset(Offset = "0x64")]
	public SpriteRenderer redLight;

	// Token: 0x0400022D RID: 557
	[Token(Token = "0x400022D")]
	[FieldOffset(Offset = "0x68")]
	public SpriteRenderer greenLight;

	// Token: 0x0400022E RID: 558
	[Token(Token = "0x400022E")]
	[FieldOffset(Offset = "0x6C")]
	public TextMeshPro StatusText;

	// Token: 0x0400022F RID: 559
	[Token(Token = "0x400022F")]
	[FieldOffset(Offset = "0x70")]
	public AudioClip AcceptSound;

	// Token: 0x04000230 RID: 560
	[Token(Token = "0x4000230")]
	[FieldOffset(Offset = "0x74")]
	public AudioClip DenySound;

	// Token: 0x04000231 RID: 561
	[Token(Token = "0x4000231")]
	[FieldOffset(Offset = "0x78")]
	public AudioClip[] CardMove;

	// Token: 0x04000232 RID: 562
	[Token(Token = "0x4000232")]
	[FieldOffset(Offset = "0x7C")]
	public AudioClip WalletOut;

	// Token: 0x04000233 RID: 563
	[Token(Token = "0x4000233")]
	[FieldOffset(Offset = "0x80")]
	public float dragTime;

	// Token: 0x04000234 RID: 564
	[Token(Token = "0x4000234")]
	[FieldOffset(Offset = "0x84")]
	private bool moving;

	// Token: 0x04000235 RID: 565
	[Token(Token = "0x4000235")]
	[FieldOffset(Offset = "0x88")]
	private TouchpadBehavior touchpad;

	// Token: 0x04000236 RID: 566
	[Token(Token = "0x4000236")]
	[FieldOffset(Offset = "0x8C")]
	private Vector2 prevStickInput;

	// Token: 0x04000237 RID: 567
	[Token(Token = "0x4000237")]
	[FieldOffset(Offset = "0x94")]
	private float xPos;

	// Token: 0x04000238 RID: 568
	[Token(Token = "0x4000238")]
	[FieldOffset(Offset = "0x98")]
	private bool hadPrev;

	// Token: 0x0200005D RID: 93
	[Token(Token = "0x200005D")]
	private enum TaskStages
	{
		// Token: 0x0400023A RID: 570
		[Token(Token = "0x400023A")]
		Before,
		// Token: 0x0400023B RID: 571
		[Token(Token = "0x400023B")]
		Animating,
		// Token: 0x0400023C RID: 572
		[Token(Token = "0x400023C")]
		Inserted,
		// Token: 0x0400023D RID: 573
		[Token(Token = "0x400023D")]
		After
	}

	// Token: 0x0200005E RID: 94
	[Token(Token = "0x200005E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <PutCardBack>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600028E RID: 654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600028E")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <PutCardBack>d__23(int <>1__state)
		{
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600028F")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000290 RID: 656 RVA: 0x000026B8 File Offset: 0x000008B8
		[Token(Token = "0x6000290")]
		[Address(RVA = "0x3C9640", Offset = "0x3C8A40", VA = "0x103C9640", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000291 RID: 657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000060")]
		private object Current
		{
			[Token(Token = "0x6000291")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000292")]
		[Address(RVA = "0x3C99E0", Offset = "0x3C8DE0", VA = "0x103C99E0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000293 RID: 659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000061")]
		private object Current
		{
			[Token(Token = "0x6000293")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400023E RID: 574
		[Token(Token = "0x400023E")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x0400023F RID: 575
		[Token(Token = "0x400023F")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000240 RID: 576
		[Token(Token = "0x4000240")]
		[FieldOffset(Offset = "0x10")]
		public CardSlideGame <>4__this;

		// Token: 0x04000241 RID: 577
		[Token(Token = "0x4000241")]
		[FieldOffset(Offset = "0x14")]
		private Vector3 <pos>5__2;

		// Token: 0x04000242 RID: 578
		[Token(Token = "0x4000242")]
		[FieldOffset(Offset = "0x20")]
		private Vector3 <targ>5__3;

		// Token: 0x04000243 RID: 579
		[Token(Token = "0x4000243")]
		[FieldOffset(Offset = "0x2C")]
		private float <time>5__4;
	}

	// Token: 0x0200005F RID: 95
	[Token(Token = "0x200005F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <InsertCard>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000294 RID: 660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000294")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <InsertCard>d__24(int <>1__state)
		{
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000295")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000296 RID: 662 RVA: 0x000026D0 File Offset: 0x000008D0
		[Token(Token = "0x6000296")]
		[Address(RVA = "0x3C8860", Offset = "0x3C7C60", VA = "0x103C8860", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000297 RID: 663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000062")]
		private object Current
		{
			[Token(Token = "0x6000297")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000298")]
		[Address(RVA = "0x3C8CA0", Offset = "0x3C80A0", VA = "0x103C8CA0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000299 RID: 665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000063")]
		private object Current
		{
			[Token(Token = "0x6000299")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000244 RID: 580
		[Token(Token = "0x4000244")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000245 RID: 581
		[Token(Token = "0x4000245")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000246 RID: 582
		[Token(Token = "0x4000246")]
		[FieldOffset(Offset = "0x10")]
		public CardSlideGame <>4__this;

		// Token: 0x04000247 RID: 583
		[Token(Token = "0x4000247")]
		[FieldOffset(Offset = "0x14")]
		private Vector3 <pos>5__2;

		// Token: 0x04000248 RID: 584
		[Token(Token = "0x4000248")]
		[FieldOffset(Offset = "0x20")]
		private Vector3 <targ>5__3;

		// Token: 0x04000249 RID: 585
		[Token(Token = "0x4000249")]
		[FieldOffset(Offset = "0x2C")]
		private float <time>5__4;
	}
}
