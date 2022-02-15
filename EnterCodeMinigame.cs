using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x0200004C RID: 76
[Token(Token = "0x200004C")]
public class EnterCodeMinigame : Minigame
{
	// Token: 0x0600022C RID: 556 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600022C")]
	[Address(RVA = "0x47BDF0", Offset = "0x47B1F0", VA = "0x1047BDF0")]
	private void OnDisable()
	{
	}

	// Token: 0x0600022D RID: 557 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600022D")]
	[Address(RVA = "0x47BE60", Offset = "0x47B260", VA = "0x1047BE60")]
	public void ShowCard()
	{
	}

	// Token: 0x0600022E RID: 558 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600022E")]
	[Address(RVA = "0x47BB90", Offset = "0x47AF90", VA = "0x1047BB90")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE4740", Offset = "0xE3B40")]
	private IEnumerator CoShowCard()
	{
		return null;
	}

	// Token: 0x0600022F RID: 559 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600022F")]
	[Address(RVA = "0x47BBE0", Offset = "0x47AFE0", VA = "0x1047BBE0")]
	public void EnterDigit(int i)
	{
	}

	// Token: 0x06000230 RID: 560 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000230")]
	[Address(RVA = "0x47BA90", Offset = "0x47AE90", VA = "0x1047BA90")]
	public void ClearDigits()
	{
	}

	// Token: 0x06000231 RID: 561 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000231")]
	[Address(RVA = "0x47B800", Offset = "0x47AC00", VA = "0x1047B800")]
	public void AcceptDigits()
	{
	}

	// Token: 0x06000232 RID: 562 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000232")]
	[Address(RVA = "0x47B950", Offset = "0x47AD50", VA = "0x1047B950", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x06000233 RID: 563 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000233")]
	[Address(RVA = "0x47B900", Offset = "0x47AD00", VA = "0x1047B900")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE47D0", Offset = "0xE3BD0")]
	private IEnumerator Animate()
	{
		return null;
	}

	// Token: 0x06000234 RID: 564 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000234")]
	[Address(RVA = "0x47BEC0", Offset = "0x47B2C0", VA = "0x1047BEC0")]
	public EnterCodeMinigame()
	{
	}

	// Token: 0x040001B3 RID: 435
	[Token(Token = "0x40001B3")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshPro NumberText;

	// Token: 0x040001B4 RID: 436
	[Token(Token = "0x40001B4")]
	[FieldOffset(Offset = "0x34")]
	public TextMeshPro TargetText;

	// Token: 0x040001B5 RID: 437
	[Token(Token = "0x40001B5")]
	[FieldOffset(Offset = "0x38")]
	public SpriteRenderer Card;

	// Token: 0x040001B6 RID: 438
	[Token(Token = "0x40001B6")]
	[FieldOffset(Offset = "0x3C")]
	public int number;

	// Token: 0x040001B7 RID: 439
	[Token(Token = "0x40001B7")]
	[FieldOffset(Offset = "0x40")]
	public string numString;

	// Token: 0x040001B8 RID: 440
	[Token(Token = "0x40001B8")]
	[FieldOffset(Offset = "0x44")]
	private bool animating;

	// Token: 0x040001B9 RID: 441
	[Token(Token = "0x40001B9")]
	[FieldOffset(Offset = "0x45")]
	private bool cardOut;

	// Token: 0x040001BA RID: 442
	[Token(Token = "0x40001BA")]
	[FieldOffset(Offset = "0x46")]
	private bool done;

	// Token: 0x040001BB RID: 443
	[Token(Token = "0x40001BB")]
	[FieldOffset(Offset = "0x48")]
	private int targetNumber;

	// Token: 0x040001BC RID: 444
	[Token(Token = "0x40001BC")]
	[FieldOffset(Offset = "0x4C")]
	public AudioClip WalletOut;

	// Token: 0x040001BD RID: 445
	[Token(Token = "0x40001BD")]
	[FieldOffset(Offset = "0x50")]
	public AudioClip NumberSound;

	// Token: 0x040001BE RID: 446
	[Token(Token = "0x40001BE")]
	[FieldOffset(Offset = "0x54")]
	public AudioClip AcceptSound;

	// Token: 0x040001BF RID: 447
	[Token(Token = "0x40001BF")]
	[FieldOffset(Offset = "0x58")]
	public AudioClip RejectSound;

	// Token: 0x040001C0 RID: 448
	[Token(Token = "0x40001C0")]
	[FieldOffset(Offset = "0x5C")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xDD8F0", Offset = "0xDCCF0")]
	public UiElement BackButton;

	// Token: 0x040001C1 RID: 449
	[Token(Token = "0x40001C1")]
	[FieldOffset(Offset = "0x60")]
	public UiElement DefaultButtonSelected;

	// Token: 0x040001C2 RID: 450
	[Token(Token = "0x40001C2")]
	[FieldOffset(Offset = "0x64")]
	public List<UiElement> ControllerSelectable;

	// Token: 0x0200004D RID: 77
	[Token(Token = "0x200004D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoShowCard>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000235 RID: 565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000235")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoShowCard>d__18(int <>1__state)
		{
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000236")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000237 RID: 567 RVA: 0x000025C8 File Offset: 0x000007C8
		[Token(Token = "0x6000237")]
		[Address(RVA = "0x786660", Offset = "0x785A60", VA = "0x10786660", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000238 RID: 568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004C")]
		private object Current
		{
			[Token(Token = "0x6000238")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000239")]
		[Address(RVA = "0x786A00", Offset = "0x785E00", VA = "0x10786A00", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600023A RID: 570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004D")]
		private object Current
		{
			[Token(Token = "0x600023A")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040001C3 RID: 451
		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040001C4 RID: 452
		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040001C5 RID: 453
		[Token(Token = "0x40001C5")]
		[FieldOffset(Offset = "0x10")]
		public EnterCodeMinigame <>4__this;

		// Token: 0x040001C6 RID: 454
		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0x14")]
		private Vector3 <pos>5__2;

		// Token: 0x040001C7 RID: 455
		[Token(Token = "0x40001C7")]
		[FieldOffset(Offset = "0x20")]
		private Vector3 <targ>5__3;

		// Token: 0x040001C8 RID: 456
		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0x2C")]
		private float <time>5__4;
	}

	// Token: 0x0200004E RID: 78
	[Token(Token = "0x200004E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <Animate>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600023B RID: 571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600023B")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <Animate>d__23(int <>1__state)
		{
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600023C")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600023D RID: 573 RVA: 0x000025E0 File Offset: 0x000007E0
		[Token(Token = "0x600023D")]
		[Address(RVA = "0x782710", Offset = "0x781B10", VA = "0x10782710", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600023E RID: 574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004E")]
		private object Current
		{
			[Token(Token = "0x600023E")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600023F")]
		[Address(RVA = "0x782BB0", Offset = "0x781FB0", VA = "0x10782BB0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000240 RID: 576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004F")]
		private object Current
		{
			[Token(Token = "0x6000240")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040001C9 RID: 457
		[Token(Token = "0x40001C9")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040001CA RID: 458
		[Token(Token = "0x40001CA")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040001CB RID: 459
		[Token(Token = "0x40001CB")]
		[FieldOffset(Offset = "0x10")]
		public EnterCodeMinigame <>4__this;

		// Token: 0x040001CC RID: 460
		[Token(Token = "0x40001CC")]
		[FieldOffset(Offset = "0x14")]
		private WaitForSeconds <wait>5__2;

		// Token: 0x040001CD RID: 461
		[Token(Token = "0x40001CD")]
		[FieldOffset(Offset = "0x18")]
		private string <okStr>5__3;
	}
}
