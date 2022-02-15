using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020001AA RID: 426
[Token(Token = "0x20001AA")]
public class VendingMinigame : Minigame
{
	// Token: 0x060009A7 RID: 2471 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009A7")]
	[Address(RVA = "0x7A94C0", Offset = "0x7A88C0", VA = "0x107A94C0")]
	private void OnDisable()
	{
	}

	// Token: 0x060009A8 RID: 2472 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009A8")]
	[Address(RVA = "0x7A8EF0", Offset = "0x7A82F0", VA = "0x107A8EF0", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x060009A9 RID: 2473 RVA: 0x00004668 File Offset: 0x00002868
	[Token(Token = "0x60009A9")]
	[Address(RVA = "0x7A9690", Offset = "0x7A8A90", VA = "0x107A9690")]
	private static int StringToSlotId(string code)
	{
		return 0;
	}

	// Token: 0x060009AA RID: 2474 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009AA")]
	[Address(RVA = "0x7A95E0", Offset = "0x7A89E0", VA = "0x107A95E0")]
	private static string SlotIdToString(int slotId)
	{
		return null;
	}

	// Token: 0x060009AB RID: 2475 RVA: 0x00004680 File Offset: 0x00002880
	[Token(Token = "0x60009AB")]
	[Address(RVA = "0x7A9530", Offset = "0x7A8930", VA = "0x107A9530")]
	private bool PickARandomSlot(Sprite drink, out int slotId)
	{
		return default(bool);
	}

	// Token: 0x060009AC RID: 2476 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009AC")]
	[Address(RVA = "0x7A9320", Offset = "0x7A8720", VA = "0x107A9320")]
	public void EnterDigit(string s)
	{
	}

	// Token: 0x060009AD RID: 2477 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009AD")]
	[Address(RVA = "0x7A91A0", Offset = "0x7A85A0", VA = "0x107A91A0")]
	public void ClearDigits()
	{
	}

	// Token: 0x060009AE RID: 2478 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009AE")]
	[Address(RVA = "0x7A8D40", Offset = "0x7A8140", VA = "0x107A8D40")]
	public void AcceptDigits()
	{
	}

	// Token: 0x060009AF RID: 2479 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009AF")]
	[Address(RVA = "0x7A9150", Offset = "0x7A8550", VA = "0x107A9150")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE08C0", Offset = "0xDFCC0")]
	private IEnumerator BlinkAccept()
	{
		return null;
	}

	// Token: 0x060009B0 RID: 2480 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009B0")]
	[Address(RVA = "0x7A8EA0", Offset = "0x7A82A0", VA = "0x107A8EA0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE0910", Offset = "0xDFD10")]
	private IEnumerator Animate()
	{
		return null;
	}

	// Token: 0x060009B1 RID: 2481 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009B1")]
	[Address(RVA = "0x7A92D0", Offset = "0x7A86D0", VA = "0x107A92D0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE0960", Offset = "0xDFD60")]
	private IEnumerator CoBlinkVend()
	{
		return null;
	}

	// Token: 0x060009B2 RID: 2482 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009B2")]
	[Address(RVA = "0x7A99B0", Offset = "0x7A8DB0", VA = "0x107A99B0")]
	public VendingMinigame()
	{
	}

	// Token: 0x040009C5 RID: 2501
	[Token(Token = "0x40009C5")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string[] Letters;

	// Token: 0x040009C6 RID: 2502
	[Token(Token = "0x40009C6")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshPro NumberText;

	// Token: 0x040009C7 RID: 2503
	[Token(Token = "0x40009C7")]
	[FieldOffset(Offset = "0x34")]
	public SpriteRenderer TargetImage;

	// Token: 0x040009C8 RID: 2504
	[Token(Token = "0x40009C8")]
	[FieldOffset(Offset = "0x38")]
	public string enteredCode;

	// Token: 0x040009C9 RID: 2505
	[Token(Token = "0x40009C9")]
	[FieldOffset(Offset = "0x3C")]
	private bool animating;

	// Token: 0x040009CA RID: 2506
	[Token(Token = "0x40009CA")]
	[FieldOffset(Offset = "0x3D")]
	private bool done;

	// Token: 0x040009CB RID: 2507
	[Token(Token = "0x40009CB")]
	[FieldOffset(Offset = "0x40")]
	private string targetCode;

	// Token: 0x040009CC RID: 2508
	[Token(Token = "0x40009CC")]
	[FieldOffset(Offset = "0x44")]
	public SpriteRenderer AcceptButton;

	// Token: 0x040009CD RID: 2509
	[Token(Token = "0x40009CD")]
	[FieldOffset(Offset = "0x48")]
	public VendingSlot[] Slots;

	// Token: 0x040009CE RID: 2510
	[Token(Token = "0x40009CE")]
	[FieldOffset(Offset = "0x4C")]
	public Sprite[] Drinks;

	// Token: 0x040009CF RID: 2511
	[Token(Token = "0x40009CF")]
	[FieldOffset(Offset = "0x50")]
	public Sprite[] DrawnDrinks;

	// Token: 0x040009D0 RID: 2512
	[Token(Token = "0x40009D0")]
	[FieldOffset(Offset = "0x54")]
	public AudioClip Ambience;

	// Token: 0x040009D1 RID: 2513
	[Token(Token = "0x40009D1")]
	[FieldOffset(Offset = "0x58")]
	public AudioClip Button;

	// Token: 0x040009D2 RID: 2514
	[Token(Token = "0x40009D2")]
	[FieldOffset(Offset = "0x5C")]
	public AudioClip Error;

	// Token: 0x040009D3 RID: 2515
	[Token(Token = "0x40009D3")]
	[FieldOffset(Offset = "0x60")]
	public AudioClip SliderOpen;

	// Token: 0x040009D4 RID: 2516
	[Token(Token = "0x40009D4")]
	[FieldOffset(Offset = "0x64")]
	public AudioClip DrinkShake;

	// Token: 0x040009D5 RID: 2517
	[Token(Token = "0x40009D5")]
	[FieldOffset(Offset = "0x68")]
	public AudioClip DrinkLand;

	// Token: 0x040009D6 RID: 2518
	[Token(Token = "0x40009D6")]
	[FieldOffset(Offset = "0x6C")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xDD8F0", Offset = "0xDCCF0")]
	public UiElement BackButton;

	// Token: 0x040009D7 RID: 2519
	[Token(Token = "0x40009D7")]
	[FieldOffset(Offset = "0x70")]
	public UiElement DefaultButtonSelected;

	// Token: 0x040009D8 RID: 2520
	[Token(Token = "0x40009D8")]
	[FieldOffset(Offset = "0x74")]
	public List<UiElement> ControllerSelectable;

	// Token: 0x020001AB RID: 427
	[Token(Token = "0x20001AB")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <BlinkAccept>d__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060009B4 RID: 2484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009B4")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <BlinkAccept>d__28(int <>1__state)
		{
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009B5")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x00004698 File Offset: 0x00002898
		[Token(Token = "0x60009B6")]
		[Address(RVA = "0x5A8A40", Offset = "0x5A7E40", VA = "0x105A8A40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060009B7 RID: 2487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000178")]
		private object Current
		{
			[Token(Token = "0x60009B7")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009B8")]
		[Address(RVA = "0x12FD0E0", Offset = "0x12FC4E0", VA = "0x112FD0E0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060009B9 RID: 2489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000179")]
		private object Current
		{
			[Token(Token = "0x60009B9")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040009D9 RID: 2521
		[Token(Token = "0x40009D9")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040009DA RID: 2522
		[Token(Token = "0x40009DA")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040009DB RID: 2523
		[Token(Token = "0x40009DB")]
		[FieldOffset(Offset = "0x10")]
		public VendingMinigame <>4__this;

		// Token: 0x040009DC RID: 2524
		[Token(Token = "0x40009DC")]
		[FieldOffset(Offset = "0x14")]
		private int <i>5__2;
	}

	// Token: 0x020001AC RID: 428
	[Token(Token = "0x20001AC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <Animate>d__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060009BA RID: 2490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009BA")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <Animate>d__29(int <>1__state)
		{
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009BB")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x000046B0 File Offset: 0x000028B0
		[Token(Token = "0x60009BC")]
		[Address(RVA = "0x12FCC50", Offset = "0x12FC050", VA = "0x112FCC50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060009BD RID: 2493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700017A")]
		private object Current
		{
			[Token(Token = "0x60009BD")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009BE")]
		[Address(RVA = "0x12FD0B0", Offset = "0x12FC4B0", VA = "0x112FD0B0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060009BF RID: 2495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700017B")]
		private object Current
		{
			[Token(Token = "0x60009BF")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040009DD RID: 2525
		[Token(Token = "0x40009DD")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040009DE RID: 2526
		[Token(Token = "0x40009DE")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040009DF RID: 2527
		[Token(Token = "0x40009DF")]
		[FieldOffset(Offset = "0x10")]
		public VendingMinigame <>4__this;

		// Token: 0x040009E0 RID: 2528
		[Token(Token = "0x40009E0")]
		[FieldOffset(Offset = "0x14")]
		private int <slotId>5__2;

		// Token: 0x040009E1 RID: 2529
		[Token(Token = "0x40009E1")]
		[FieldOffset(Offset = "0x18")]
		private WaitForSeconds <wait>5__3;
	}

	// Token: 0x020001AD RID: 429
	[Token(Token = "0x20001AD")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoBlinkVend>d__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060009C0 RID: 2496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009C0")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoBlinkVend>d__30(int <>1__state)
		{
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009C1")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x000046C8 File Offset: 0x000028C8
		[Token(Token = "0x60009C2")]
		[Address(RVA = "0x12FD670", Offset = "0x12FCA70", VA = "0x112FD670", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060009C3 RID: 2499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700017C")]
		private object Current
		{
			[Token(Token = "0x60009C3")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009C4")]
		[Address(RVA = "0x12FD810", Offset = "0x12FCC10", VA = "0x112FD810", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060009C5 RID: 2501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700017D")]
		private object Current
		{
			[Token(Token = "0x60009C5")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040009E2 RID: 2530
		[Token(Token = "0x40009E2")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040009E3 RID: 2531
		[Token(Token = "0x40009E3")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040009E4 RID: 2532
		[Token(Token = "0x40009E4")]
		[FieldOffset(Offset = "0x10")]
		public VendingMinigame <>4__this;

		// Token: 0x040009E5 RID: 2533
		[Token(Token = "0x40009E5")]
		[FieldOffset(Offset = "0x14")]
		private int <i>5__2;
	}
}
