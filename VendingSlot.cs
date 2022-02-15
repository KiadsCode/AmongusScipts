using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001AE RID: 430
[Token(Token = "0x20001AE")]
public class VendingSlot : MonoBehaviour
{
	// Token: 0x060009C6 RID: 2502 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009C6")]
	[Address(RVA = "0x7A9A50", Offset = "0x7A8E50", VA = "0x107A9A50")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE0A00", Offset = "0xDFE00")]
	public IEnumerator CoBuy(AudioClip sliderOpen, AudioClip drinkShake, AudioClip drinkLand)
	{
		return null;
	}

	// Token: 0x060009C7 RID: 2503 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009C7")]
	[Address(RVA = "0x7A99F0", Offset = "0x7A8DF0", VA = "0x107A99F0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE0A70", Offset = "0xDFE70")]
	public IEnumerator CloseSlider(AudioClip sliderOpen)
	{
		return null;
	}

	// Token: 0x060009C8 RID: 2504 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009C8")]
	[Address(RVA = "0x7A9AC0", Offset = "0x7A8EC0", VA = "0x107A9AC0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE0AC0", Offset = "0xDFEC0")]
	private IEnumerator PlayLand(AudioClip drinkLand)
	{
		return null;
	}

	// Token: 0x060009C9 RID: 2505 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009C9")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public VendingSlot()
	{
	}

	// Token: 0x060009CA RID: 2506 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009CA")]
	[Address(RVA = "0x7A9BF0", Offset = "0x7A8FF0", VA = "0x107A9BF0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private void <CoBuy>b__5_0(float v)
	{
	}

	// Token: 0x060009CB RID: 2507 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009CB")]
	[Address(RVA = "0x7A9B10", Offset = "0x7A8F10", VA = "0x107A9B10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private void <CloseSlider>b__6_0(float v)
	{
	}

	// Token: 0x040009E6 RID: 2534
	[Token(Token = "0x40009E6")]
	[FieldOffset(Offset = "0xC")]
	public SpriteRenderer DrinkImage;

	// Token: 0x040009E7 RID: 2535
	[Token(Token = "0x40009E7")]
	[FieldOffset(Offset = "0x10")]
	public SpriteRenderer GlassImage;

	// Token: 0x040009E8 RID: 2536
	[Token(Token = "0x40009E8")]
	private const float SlideDuration = 0.75f;

	// Token: 0x040009E9 RID: 2537
	[Token(Token = "0x40009E9")]
	private const float SlideVibrateIntensity = 0.05f;

	// Token: 0x040009EA RID: 2538
	[Token(Token = "0x40009EA")]
	private const float DrunkThunkVibrateIntensity = 0.4f;

	// Token: 0x020001AF RID: 431
	[Token(Token = "0x20001AF")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoBuy>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060009CC RID: 2508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009CC")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoBuy>d__5(int <>1__state)
		{
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009CD")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x000046E0 File Offset: 0x000028E0
		[Token(Token = "0x60009CE")]
		[Address(RVA = "0x12FD840", Offset = "0x12FCC40", VA = "0x112FD840", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060009CF RID: 2511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700017E")]
		private object Current
		{
			[Token(Token = "0x60009CF")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009D0")]
		[Address(RVA = "0x12FDEA0", Offset = "0x12FD2A0", VA = "0x112FDEA0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060009D1 RID: 2513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700017F")]
		private object Current
		{
			[Token(Token = "0x60009D1")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040009EB RID: 2539
		[Token(Token = "0x40009EB")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040009EC RID: 2540
		[Token(Token = "0x40009EC")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040009ED RID: 2541
		[Token(Token = "0x40009ED")]
		[FieldOffset(Offset = "0x10")]
		public AudioClip sliderOpen;

		// Token: 0x040009EE RID: 2542
		[Token(Token = "0x40009EE")]
		[FieldOffset(Offset = "0x14")]
		public VendingSlot <>4__this;

		// Token: 0x040009EF RID: 2543
		[Token(Token = "0x40009EF")]
		[FieldOffset(Offset = "0x18")]
		public AudioClip drinkShake;

		// Token: 0x040009F0 RID: 2544
		[Token(Token = "0x40009F0")]
		[FieldOffset(Offset = "0x1C")]
		public AudioClip drinkLand;
	}

	// Token: 0x020001B0 RID: 432
	[Token(Token = "0x20001B0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CloseSlider>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060009D2 RID: 2514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009D2")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CloseSlider>d__6(int <>1__state)
		{
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009D3")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x000046F8 File Offset: 0x000028F8
		[Token(Token = "0x60009D4")]
		[Address(RVA = "0x12FD110", Offset = "0x12FC510", VA = "0x112FD110", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060009D5 RID: 2517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000180")]
		private object Current
		{
			[Token(Token = "0x60009D5")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009D6")]
		[Address(RVA = "0x12FD2B0", Offset = "0x12FC6B0", VA = "0x112FD2B0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060009D7 RID: 2519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000181")]
		private object Current
		{
			[Token(Token = "0x60009D7")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040009F1 RID: 2545
		[Token(Token = "0x40009F1")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040009F2 RID: 2546
		[Token(Token = "0x40009F2")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040009F3 RID: 2547
		[Token(Token = "0x40009F3")]
		[FieldOffset(Offset = "0x10")]
		public AudioClip sliderOpen;

		// Token: 0x040009F4 RID: 2548
		[Token(Token = "0x40009F4")]
		[FieldOffset(Offset = "0x14")]
		public VendingSlot <>4__this;
	}

	// Token: 0x020001B1 RID: 433
	[Token(Token = "0x20001B1")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <PlayLand>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060009D8 RID: 2520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009D8")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <PlayLand>d__7(int <>1__state)
		{
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009D9")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x00004710 File Offset: 0x00002910
		[Token(Token = "0x60009DA")]
		[Address(RVA = "0x13006F0", Offset = "0x12FFAF0", VA = "0x113006F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060009DB RID: 2523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000182")]
		private object Current
		{
			[Token(Token = "0x60009DB")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009DC")]
		[Address(RVA = "0x1300800", Offset = "0x12FFC00", VA = "0x11300800", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060009DD RID: 2525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000183")]
		private object Current
		{
			[Token(Token = "0x60009DD")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040009F5 RID: 2549
		[Token(Token = "0x40009F5")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040009F6 RID: 2550
		[Token(Token = "0x40009F6")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040009F7 RID: 2551
		[Token(Token = "0x40009F7")]
		[FieldOffset(Offset = "0x10")]
		public AudioClip drinkLand;
	}
}
