using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Il2CppDummyDll;
using PowerTools;
using TMPro;
using UnityEngine;

// Token: 0x0200004F RID: 79
[Token(Token = "0x200004F")]
public class ProcessDataMinigame : Minigame
{
	// Token: 0x06000241 RID: 577 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000241")]
	[Address(RVA = "0x50FAB0", Offset = "0x50EEB0", VA = "0x1050FAB0")]
	private void OnDisable()
	{
	}

	// Token: 0x06000242 RID: 578 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000242")]
	[Address(RVA = "0x50F940", Offset = "0x50ED40", VA = "0x1050F940", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x06000243 RID: 579 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000243")]
	[Address(RVA = "0x50FB20", Offset = "0x50EF20", VA = "0x1050FB20")]
	public void StartStopFill()
	{
	}

	// Token: 0x06000244 RID: 580 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000244")]
	[Address(RVA = "0x50FA10", Offset = "0x50EE10", VA = "0x1050FA10")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE4B30", Offset = "0xE3F30")]
	private IEnumerator CoDoAnimation()
	{
		return null;
	}

	// Token: 0x06000245 RID: 581 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000245")]
	[Address(RVA = "0x50FB90", Offset = "0x50EF90", VA = "0x1050FB90")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE4BC0", Offset = "0xE3FC0")]
	private IEnumerator Transition()
	{
		return null;
	}

	// Token: 0x06000246 RID: 582 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000246")]
	[Address(RVA = "0x50FA60", Offset = "0x50EE60", VA = "0x1050FA60")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE4C10", Offset = "0xE4010")]
	private IEnumerator DoText()
	{
		return null;
	}

	// Token: 0x06000247 RID: 583 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000247")]
	[Address(RVA = "0x50FBE0", Offset = "0x50EFE0", VA = "0x1050FBE0")]
	public ProcessDataMinigame()
	{
	}

	// Token: 0x040001CE RID: 462
	[Token(Token = "0x40001CE")]
	[FieldOffset(Offset = "0x30")]
	private string[] DocTopics;

	// Token: 0x040001CF RID: 463
	[Token(Token = "0x40001CF")]
	[FieldOffset(Offset = "0x34")]
	private string[] DocTypes;

	// Token: 0x040001D0 RID: 464
	[Token(Token = "0x40001D0")]
	[FieldOffset(Offset = "0x38")]
	private string[] DocExtensions;

	// Token: 0x040001D1 RID: 465
	[Token(Token = "0x40001D1")]
	[FieldOffset(Offset = "0x3C")]
	public float Duration;

	// Token: 0x040001D2 RID: 466
	[Token(Token = "0x40001D2")]
	[FieldOffset(Offset = "0x40")]
	public ParallaxController scenery;

	// Token: 0x040001D3 RID: 467
	[Token(Token = "0x40001D3")]
	[FieldOffset(Offset = "0x44")]
	public PassiveButton StartButton;

	// Token: 0x040001D4 RID: 468
	[Token(Token = "0x40001D4")]
	[FieldOffset(Offset = "0x48")]
	public TextMeshPro EstimatedText;

	// Token: 0x040001D5 RID: 469
	[Token(Token = "0x40001D5")]
	[FieldOffset(Offset = "0x4C")]
	public TextMeshPro PercentText;

	// Token: 0x040001D6 RID: 470
	[Token(Token = "0x40001D6")]
	[FieldOffset(Offset = "0x50")]
	public SpriteAnim LeftFolder;

	// Token: 0x040001D7 RID: 471
	[Token(Token = "0x40001D7")]
	[FieldOffset(Offset = "0x54")]
	public SpriteAnim RightFolder;

	// Token: 0x040001D8 RID: 472
	[Token(Token = "0x40001D8")]
	[FieldOffset(Offset = "0x58")]
	public AnimationClip OpenFolderClip;

	// Token: 0x040001D9 RID: 473
	[Token(Token = "0x40001D9")]
	[FieldOffset(Offset = "0x5C")]
	public AnimationClip CloseFolderClip;

	// Token: 0x040001DA RID: 474
	[Token(Token = "0x40001DA")]
	[FieldOffset(Offset = "0x60")]
	public GameObject Status;

	// Token: 0x040001DB RID: 475
	[Token(Token = "0x40001DB")]
	[FieldOffset(Offset = "0x64")]
	public SpriteRenderer Runner;

	// Token: 0x040001DC RID: 476
	[Token(Token = "0x40001DC")]
	[FieldOffset(Offset = "0x68")]
	public HorizontalGauge Gauge;

	// Token: 0x040001DD RID: 477
	[Token(Token = "0x40001DD")]
	[FieldOffset(Offset = "0x6C")]
	private bool running;

	// Token: 0x040001DE RID: 478
	[Token(Token = "0x40001DE")]
	[FieldOffset(Offset = "0x70")]
	public FloatRange SceneRange;

	// Token: 0x040001DF RID: 479
	[Token(Token = "0x40001DF")]
	[FieldOffset(Offset = "0x74")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xDD8F0", Offset = "0xDCCF0")]
	public UiElement BackButton;

	// Token: 0x040001E0 RID: 480
	[Token(Token = "0x40001E0")]
	[FieldOffset(Offset = "0x78")]
	public UiElement DefaultButtonSelected;

	// Token: 0x02000050 RID: 80
	[Token(Token = "0x2000050")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoDoAnimation>d__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000248 RID: 584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000248")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoDoAnimation>d__22(int <>1__state)
		{
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600024A RID: 586 RVA: 0x000025F8 File Offset: 0x000007F8
		[Token(Token = "0x600024A")]
		[Address(RVA = "0x792C80", Offset = "0x792080", VA = "0x10792C80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600024B RID: 587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000050")]
		private object Current
		{
			[Token(Token = "0x600024B")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600024C")]
		[Address(RVA = "0x792F30", Offset = "0x792330", VA = "0x10792F30", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600024D RID: 589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000051")]
		private object Current
		{
			[Token(Token = "0x600024D")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040001E1 RID: 481
		[Token(Token = "0x40001E1")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040001E2 RID: 482
		[Token(Token = "0x40001E2")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040001E3 RID: 483
		[Token(Token = "0x40001E3")]
		[FieldOffset(Offset = "0x10")]
		public ProcessDataMinigame <>4__this;

		// Token: 0x040001E4 RID: 484
		[Token(Token = "0x40001E4")]
		[FieldOffset(Offset = "0x14")]
		private float <timer>5__2;
	}

	// Token: 0x02000051 RID: 81
	[Token(Token = "0x2000051")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <Transition>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600024E RID: 590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600024E")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <Transition>d__23(int <>1__state)
		{
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600024F")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00002610 File Offset: 0x00000810
		[Token(Token = "0x6000250")]
		[Address(RVA = "0x7993F0", Offset = "0x7987F0", VA = "0x107993F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000251 RID: 593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000052")]
		private object Current
		{
			[Token(Token = "0x6000251")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000252")]
		[Address(RVA = "0x7995F0", Offset = "0x7989F0", VA = "0x107995F0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000253 RID: 595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000053")]
		private object Current
		{
			[Token(Token = "0x6000253")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040001E5 RID: 485
		[Token(Token = "0x40001E5")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040001E6 RID: 486
		[Token(Token = "0x40001E6")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040001E7 RID: 487
		[Token(Token = "0x40001E7")]
		[FieldOffset(Offset = "0x10")]
		public ProcessDataMinigame <>4__this;

		// Token: 0x040001E8 RID: 488
		[Token(Token = "0x40001E8")]
		[FieldOffset(Offset = "0x14")]
		private float <t>5__2;
	}

	// Token: 0x02000052 RID: 82
	[Token(Token = "0x2000052")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <DoText>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000254 RID: 596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000254")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <DoText>d__24(int <>1__state)
		{
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000255")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00002628 File Offset: 0x00000828
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x796C30", Offset = "0x796030", VA = "0x10796C30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000257 RID: 599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000054")]
		private object Current
		{
			[Token(Token = "0x6000257")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000258")]
		[Address(RVA = "0x796EB0", Offset = "0x7962B0", VA = "0x10796EB0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000259 RID: 601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000055")]
		private object Current
		{
			[Token(Token = "0x6000259")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040001E9 RID: 489
		[Token(Token = "0x40001E9")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040001EA RID: 490
		[Token(Token = "0x40001EA")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040001EB RID: 491
		[Token(Token = "0x40001EB")]
		[FieldOffset(Offset = "0x10")]
		public ProcessDataMinigame <>4__this;

		// Token: 0x040001EC RID: 492
		[Token(Token = "0x40001EC")]
		[FieldOffset(Offset = "0x14")]
		private StringBuilder <txt>5__2;

		// Token: 0x040001ED RID: 493
		[Token(Token = "0x40001ED")]
		[FieldOffset(Offset = "0x18")]
		private int <len>5__3;
	}
}
