using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Il2CppDummyDll;
using PowerTools;
using TMPro;
using UnityEngine;

// Token: 0x02000054 RID: 84
[Token(Token = "0x2000054")]
public class UploadDataGame : Minigame
{
	// Token: 0x0600025C RID: 604 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600025C")]
	[Address(RVA = "0x4B8D70", Offset = "0x4B8170", VA = "0x104B8D70")]
	private void OnDisable()
	{
	}

	// Token: 0x0600025D RID: 605 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600025D")]
	[Address(RVA = "0x4B8930", Offset = "0x4B7D30", VA = "0x104B8930", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x0600025E RID: 606 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600025E")]
	[Address(RVA = "0x4B8C20", Offset = "0x4B8020", VA = "0x104B8C20")]
	public void Click()
	{
	}

	// Token: 0x0600025F RID: 607 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600025F")]
	[Address(RVA = "0x4B8E30", Offset = "0x4B8230", VA = "0x104B8E30")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE4C60", Offset = "0xE4060")]
	private IEnumerator Transition()
	{
		return null;
	}

	// Token: 0x06000260 RID: 608 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000260")]
	[Address(RVA = "0x4B8DE0", Offset = "0x4B81E0", VA = "0x104B8DE0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE4CB0", Offset = "0xE40B0")]
	private IEnumerator PulseText()
	{
		return null;
	}

	// Token: 0x06000261 RID: 609 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000261")]
	[Address(RVA = "0x4B8C80", Offset = "0x4B8080", VA = "0x104B8C80")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE4D00", Offset = "0xE4100")]
	private IEnumerator DoPercent()
	{
		return null;
	}

	// Token: 0x06000262 RID: 610 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000262")]
	[Address(RVA = "0x4B8D20", Offset = "0x4B8120", VA = "0x104B8D20")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE4D50", Offset = "0xE4150")]
	private IEnumerator DoText()
	{
		return null;
	}

	// Token: 0x06000263 RID: 611 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000263")]
	[Address(RVA = "0x4B8CD0", Offset = "0x4B80D0", VA = "0x104B8CD0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE4DA0", Offset = "0xE41A0")]
	private IEnumerator DoRun()
	{
		return null;
	}

	// Token: 0x06000264 RID: 612 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000264")]
	[Address(RVA = "0x4B8E80", Offset = "0x4B8280", VA = "0x104B8E80")]
	public UploadDataGame()
	{
	}

	// Token: 0x040001F5 RID: 501
	[Token(Token = "0x40001F5")]
	[FieldOffset(Offset = "0x30")]
	public SpriteAnim LeftFolder;

	// Token: 0x040001F6 RID: 502
	[Token(Token = "0x40001F6")]
	[FieldOffset(Offset = "0x34")]
	public SpriteAnim RightFolder;

	// Token: 0x040001F7 RID: 503
	[Token(Token = "0x40001F7")]
	[FieldOffset(Offset = "0x38")]
	public AnimationClip FolderOpen;

	// Token: 0x040001F8 RID: 504
	[Token(Token = "0x40001F8")]
	[FieldOffset(Offset = "0x3C")]
	public AnimationClip FolderClose;

	// Token: 0x040001F9 RID: 505
	[Token(Token = "0x40001F9")]
	[FieldOffset(Offset = "0x40")]
	public SpriteRenderer Runner;

	// Token: 0x040001FA RID: 506
	[Token(Token = "0x40001FA")]
	[FieldOffset(Offset = "0x44")]
	public HorizontalGauge Gauge;

	// Token: 0x040001FB RID: 507
	[Token(Token = "0x40001FB")]
	[FieldOffset(Offset = "0x48")]
	public TextMeshPro PercentText;

	// Token: 0x040001FC RID: 508
	[Token(Token = "0x40001FC")]
	[FieldOffset(Offset = "0x4C")]
	public TextMeshPro EstimatedText;

	// Token: 0x040001FD RID: 509
	[Token(Token = "0x40001FD")]
	[FieldOffset(Offset = "0x50")]
	public TextMeshPro SourceText;

	// Token: 0x040001FE RID: 510
	[Token(Token = "0x40001FE")]
	[FieldOffset(Offset = "0x54")]
	public TextMeshPro TargetText;

	// Token: 0x040001FF RID: 511
	[Token(Token = "0x40001FF")]
	[FieldOffset(Offset = "0x58")]
	public SpriteRenderer Button;

	// Token: 0x04000200 RID: 512
	[Token(Token = "0x4000200")]
	[FieldOffset(Offset = "0x5C")]
	public TextTranslatorTMP translator;

	// Token: 0x04000201 RID: 513
	[Token(Token = "0x4000201")]
	[FieldOffset(Offset = "0x60")]
	public GameObject Status;

	// Token: 0x04000202 RID: 514
	[Token(Token = "0x4000202")]
	[FieldOffset(Offset = "0x64")]
	public GameObject Tower;

	// Token: 0x04000203 RID: 515
	[Token(Token = "0x4000203")]
	[FieldOffset(Offset = "0x68")]
	private int count;

	// Token: 0x04000204 RID: 516
	[Token(Token = "0x4000204")]
	[FieldOffset(Offset = "0x6C")]
	private float timer;

	// Token: 0x04000205 RID: 517
	[Token(Token = "0x4000205")]
	public const float RandomChunks = 5f;

	// Token: 0x04000206 RID: 518
	[Token(Token = "0x4000206")]
	public const float ConstantTime = 3f;

	// Token: 0x04000207 RID: 519
	[Token(Token = "0x4000207")]
	[FieldOffset(Offset = "0x70")]
	private bool running;

	// Token: 0x04000208 RID: 520
	[Token(Token = "0x4000208")]
	[FieldOffset(Offset = "0x74")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xDD8F0", Offset = "0xDCCF0")]
	public UiElement BackButton;

	// Token: 0x04000209 RID: 521
	[Token(Token = "0x4000209")]
	[FieldOffset(Offset = "0x78")]
	public UiElement DefaultButtonSelected;

	// Token: 0x02000055 RID: 85
	[Token(Token = "0x2000055")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <Transition>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000265 RID: 613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000265")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <Transition>d__24(int <>1__state)
		{
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000266")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00002640 File Offset: 0x00000840
		[Token(Token = "0x6000267")]
		[Address(RVA = "0x1301DB0", Offset = "0x13011B0", VA = "0x11301DB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000268 RID: 616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000056")]
		private object Current
		{
			[Token(Token = "0x6000268")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000269")]
		[Address(RVA = "0x1301F70", Offset = "0x1301370", VA = "0x11301F70", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600026A RID: 618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000057")]
		private object Current
		{
			[Token(Token = "0x600026A")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400020A RID: 522
		[Token(Token = "0x400020A")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x0400020B RID: 523
		[Token(Token = "0x400020B")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x0400020C RID: 524
		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0x10")]
		public UploadDataGame <>4__this;

		// Token: 0x0400020D RID: 525
		[Token(Token = "0x400020D")]
		[FieldOffset(Offset = "0x14")]
		private float <target>5__2;

		// Token: 0x0400020E RID: 526
		[Token(Token = "0x400020E")]
		[FieldOffset(Offset = "0x18")]
		private float <t>5__3;
	}

	// Token: 0x02000056 RID: 86
	[Token(Token = "0x2000056")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass25_0
	{
		// Token: 0x0600026B RID: 619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600026B")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass25_0()
		{
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600026C")]
		[Address(RVA = "0x13023B0", Offset = "0x13017B0", VA = "0x113023B0")]
		internal void <PulseText>b__0(float t)
		{
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600026D")]
		[Address(RVA = "0x1302490", Offset = "0x1301890", VA = "0x11302490")]
		internal void <PulseText>b__1(float t)
		{
		}

		// Token: 0x0400020F RID: 527
		[Token(Token = "0x400020F")]
		[FieldOffset(Offset = "0x8")]
		public Color gray;

		// Token: 0x04000210 RID: 528
		[Token(Token = "0x4000210")]
		[FieldOffset(Offset = "0x18")]
		public MeshRenderer rend2;

		// Token: 0x04000211 RID: 529
		[Token(Token = "0x4000211")]
		[FieldOffset(Offset = "0x1C")]
		public MeshRenderer rend1;
	}

	// Token: 0x02000057 RID: 87
	[Token(Token = "0x2000057")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <PulseText>d__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600026E RID: 622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600026E")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <PulseText>d__25(int <>1__state)
		{
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600026F")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00002658 File Offset: 0x00000858
		[Token(Token = "0x6000270")]
		[Address(RVA = "0x1300830", Offset = "0x12FFC30", VA = "0x11300830", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000271 RID: 625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000058")]
		private object Current
		{
			[Token(Token = "0x6000271")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000272")]
		[Address(RVA = "0x1300B00", Offset = "0x12FFF00", VA = "0x11300B00", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000273 RID: 627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000059")]
		private object Current
		{
			[Token(Token = "0x6000273")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000212 RID: 530
		[Token(Token = "0x4000212")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000213 RID: 531
		[Token(Token = "0x4000213")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000214 RID: 532
		[Token(Token = "0x4000214")]
		[FieldOffset(Offset = "0x10")]
		public UploadDataGame <>4__this;

		// Token: 0x04000215 RID: 533
		[Token(Token = "0x4000215")]
		[FieldOffset(Offset = "0x14")]
		private UploadDataGame.<>c__DisplayClass25_0 <>8__1;
	}

	// Token: 0x02000058 RID: 88
	[Token(Token = "0x2000058")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <DoPercent>d__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000274 RID: 628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000274")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <DoPercent>d__26(int <>1__state)
		{
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000275")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00002670 File Offset: 0x00000870
		[Token(Token = "0x6000276")]
		[Address(RVA = "0x12FF500", Offset = "0x12FE900", VA = "0x112FF500", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000277 RID: 631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005A")]
		private object Current
		{
			[Token(Token = "0x6000277")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000278")]
		[Address(RVA = "0x12FF640", Offset = "0x12FEA40", VA = "0x112FF640", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000279 RID: 633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005B")]
		private object Current
		{
			[Token(Token = "0x6000279")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000216 RID: 534
		[Token(Token = "0x4000216")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000217 RID: 535
		[Token(Token = "0x4000217")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000218 RID: 536
		[Token(Token = "0x4000218")]
		[FieldOffset(Offset = "0x10")]
		public UploadDataGame <>4__this;
	}

	// Token: 0x02000059 RID: 89
	[Token(Token = "0x2000059")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <DoText>d__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600027A RID: 634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600027A")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <DoText>d__27(int <>1__state)
		{
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600027B")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00002688 File Offset: 0x00000888
		[Token(Token = "0x600027C")]
		[Address(RVA = "0x12FF9C0", Offset = "0x12FEDC0", VA = "0x112FF9C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600027D RID: 637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005C")]
		private object Current
		{
			[Token(Token = "0x600027D")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600027E")]
		[Address(RVA = "0x13001D0", Offset = "0x12FF5D0", VA = "0x113001D0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600027F RID: 639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005D")]
		private object Current
		{
			[Token(Token = "0x600027F")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000219 RID: 537
		[Token(Token = "0x4000219")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x0400021A RID: 538
		[Token(Token = "0x400021A")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x0400021B RID: 539
		[Token(Token = "0x400021B")]
		[FieldOffset(Offset = "0x10")]
		public UploadDataGame <>4__this;

		// Token: 0x0400021C RID: 540
		[Token(Token = "0x400021C")]
		[FieldOffset(Offset = "0x14")]
		private StringBuilder <txt>5__2;

		// Token: 0x0400021D RID: 541
		[Token(Token = "0x400021D")]
		[FieldOffset(Offset = "0x18")]
		private int <baselen>5__3;

		// Token: 0x0400021E RID: 542
		[Token(Token = "0x400021E")]
		[FieldOffset(Offset = "0x1C")]
		private int <max>5__4;
	}

	// Token: 0x0200005A RID: 90
	[Token(Token = "0x200005A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass28_0
	{
		// Token: 0x06000280 RID: 640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000280")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass28_0()
		{
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000281")]
		[Address(RVA = "0x13025B0", Offset = "0x13019B0", VA = "0x113025B0")]
		internal void <DoRun>b__0(float t)
		{
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000282")]
		[Address(RVA = "0x1302630", Offset = "0x1301A30", VA = "0x11302630")]
		internal void <DoRun>b__1(float t)
		{
		}

		// Token: 0x0400021F RID: 543
		[Token(Token = "0x400021F")]
		[FieldOffset(Offset = "0x8")]
		public Vector3 pos;

		// Token: 0x04000220 RID: 544
		[Token(Token = "0x4000220")]
		[FieldOffset(Offset = "0x14")]
		public UploadDataGame <>4__this;
	}

	// Token: 0x0200005B RID: 91
	[Token(Token = "0x200005B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <DoRun>d__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000283 RID: 643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000283")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <DoRun>d__28(int <>1__state)
		{
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000284")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000285 RID: 645 RVA: 0x000026A0 File Offset: 0x000008A0
		[Token(Token = "0x6000285")]
		[Address(RVA = "0x12FF670", Offset = "0x12FEA70", VA = "0x112FF670", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000286 RID: 646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005E")]
		private object Current
		{
			[Token(Token = "0x6000286")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000287")]
		[Address(RVA = "0x12FF990", Offset = "0x12FED90", VA = "0x112FF990", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000288 RID: 648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005F")]
		private object Current
		{
			[Token(Token = "0x6000288")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000221 RID: 545
		[Token(Token = "0x4000221")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000222 RID: 546
		[Token(Token = "0x4000222")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000223 RID: 547
		[Token(Token = "0x4000223")]
		[FieldOffset(Offset = "0x10")]
		public UploadDataGame <>4__this;

		// Token: 0x04000224 RID: 548
		[Token(Token = "0x4000224")]
		[FieldOffset(Offset = "0x14")]
		private UploadDataGame.<>c__DisplayClass28_0 <>8__1;
	}
}
