using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000356 RID: 854
[Token(Token = "0x2000356")]
public class WifiGame : Minigame
{
	// Token: 0x0600129F RID: 4767 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600129F")]
	[Address(RVA = "0x7BAF50", Offset = "0x7BA350", VA = "0x107BAF50", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x060012A0 RID: 4768 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012A0")]
	[Address(RVA = "0x7BB480", Offset = "0x7BA880", VA = "0x107BB480")]
	public void Update()
	{
	}

	// Token: 0x060012A1 RID: 4769 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012A1")]
	[Address(RVA = "0x7BB2D0", Offset = "0x7BA6D0", VA = "0x107BB2D0")]
	private void TurnOn(bool first = false)
	{
	}

	// Token: 0x060012A2 RID: 4770 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012A2")]
	[Address(RVA = "0x7BB090", Offset = "0x7BA490", VA = "0x107BB090")]
	private void TurnOff(bool first = false)
	{
	}

	// Token: 0x060012A3 RID: 4771 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012A3")]
	[Address(RVA = "0x7BB030", Offset = "0x7BA430", VA = "0x107BB030")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE8040", Offset = "0xE7440")]
	private IEnumerator RunLights(bool finishing)
	{
		return null;
	}

	// Token: 0x060012A4 RID: 4772 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012A4")]
	[Address(RVA = "0x7BAFD0", Offset = "0x7BA3D0", VA = "0x107BAFD0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE80D0", Offset = "0xE74D0")]
	private IEnumerator CoBlinkLight(SpriteRenderer light, float delay)
	{
		return null;
	}

	// Token: 0x060012A5 RID: 4773 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012A5")]
	[Address(RVA = "0x7BB8C0", Offset = "0x7BACC0", VA = "0x107BB8C0")]
	public WifiGame()
	{
	}

	// Token: 0x060012A6 RID: 4774 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012A6")]
	[Address(RVA = "0x7BB450", Offset = "0x7BA850", VA = "0x107BB450")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private void <TurnOff>b__14_0(SpriteRenderer s)
	{
	}

	// Token: 0x060012A7 RID: 4775 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012A7")]
	[Address(RVA = "0x7BB420", Offset = "0x7BA820", VA = "0x107BB420")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private void <RunLights>b__15_0(SpriteRenderer s)
	{
	}

	// Token: 0x060012A8 RID: 4776 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012A8")]
	[Address(RVA = "0x7BB420", Offset = "0x7BA820", VA = "0x107BB420")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private void <RunLights>b__15_1(SpriteRenderer s)
	{
	}

	// Token: 0x040012E5 RID: 4837
	[Token(Token = "0x40012E5")]
	private const int WaitDuration = 60;

	// Token: 0x040012E6 RID: 4838
	[Token(Token = "0x40012E6")]
	[FieldOffset(Offset = "0x30")]
	public SlideBar Slider;

	// Token: 0x040012E7 RID: 4839
	[Token(Token = "0x40012E7")]
	[FieldOffset(Offset = "0x34")]
	public TextMeshPro StatusText;

	// Token: 0x040012E8 RID: 4840
	[Token(Token = "0x40012E8")]
	[FieldOffset(Offset = "0x38")]
	public SpriteRenderer[] Lights;

	// Token: 0x040012E9 RID: 4841
	[Token(Token = "0x40012E9")]
	[FieldOffset(Offset = "0x3C")]
	public Sprite LightOn;

	// Token: 0x040012EA RID: 4842
	[Token(Token = "0x40012EA")]
	[FieldOffset(Offset = "0x40")]
	public Sprite LightOff;

	// Token: 0x040012EB RID: 4843
	[Token(Token = "0x40012EB")]
	[FieldOffset(Offset = "0x44")]
	public AudioClip SliderClick;

	// Token: 0x040012EC RID: 4844
	[Token(Token = "0x40012EC")]
	[FieldOffset(Offset = "0x48")]
	private bool WifiOff;

	// Token: 0x040012ED RID: 4845
	[Token(Token = "0x40012ED")]
	[FieldOffset(Offset = "0x4C")]
	private TouchpadBehavior touchpad;

	// Token: 0x040012EE RID: 4846
	[Token(Token = "0x40012EE")]
	[FieldOffset(Offset = "0x50")]
	private float initialSlider;

	// Token: 0x040012EF RID: 4847
	[Token(Token = "0x40012EF")]
	[FieldOffset(Offset = "0x54")]
	private Controller controller;

	// Token: 0x02000357 RID: 855
	[Token(Token = "0x2000357")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <RunLights>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060012A9 RID: 4777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012A9")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <RunLights>d__15(int <>1__state)
		{
		}

		// Token: 0x060012AA RID: 4778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012AA")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060012AB RID: 4779 RVA: 0x00006528 File Offset: 0x00004728
		[Token(Token = "0x60012AB")]
		[Address(RVA = "0x1300ED0", Offset = "0x13002D0", VA = "0x11300ED0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x060012AC RID: 4780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002C6")]
		private object Current
		{
			[Token(Token = "0x60012AC")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060012AD RID: 4781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012AD")]
		[Address(RVA = "0x13016E0", Offset = "0x1300AE0", VA = "0x113016E0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x060012AE RID: 4782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002C7")]
		private object Current
		{
			[Token(Token = "0x60012AE")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040012F0 RID: 4848
		[Token(Token = "0x40012F0")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040012F1 RID: 4849
		[Token(Token = "0x40012F1")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040012F2 RID: 4850
		[Token(Token = "0x40012F2")]
		[FieldOffset(Offset = "0x10")]
		public bool finishing;

		// Token: 0x040012F3 RID: 4851
		[Token(Token = "0x40012F3")]
		[FieldOffset(Offset = "0x14")]
		public WifiGame <>4__this;

		// Token: 0x040012F4 RID: 4852
		[Token(Token = "0x40012F4")]
		[FieldOffset(Offset = "0x18")]
		private float <timer>5__2;
	}

	// Token: 0x02000358 RID: 856
	[Token(Token = "0x2000358")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoBlinkLight>d__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060012AF RID: 4783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012AF")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoBlinkLight>d__16(int <>1__state)
		{
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012B0")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060012B1 RID: 4785 RVA: 0x00006540 File Offset: 0x00004740
		[Token(Token = "0x60012B1")]
		[Address(RVA = "0x12FD510", Offset = "0x12FC910", VA = "0x112FD510", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x060012B2 RID: 4786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002C8")]
		private object Current
		{
			[Token(Token = "0x60012B2")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060012B3 RID: 4787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012B3")]
		[Address(RVA = "0x12FD640", Offset = "0x12FCA40", VA = "0x112FD640", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x060012B4 RID: 4788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002C9")]
		private object Current
		{
			[Token(Token = "0x60012B4")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040012F5 RID: 4853
		[Token(Token = "0x40012F5")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040012F6 RID: 4854
		[Token(Token = "0x40012F6")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040012F7 RID: 4855
		[Token(Token = "0x40012F7")]
		[FieldOffset(Offset = "0x10")]
		public SpriteRenderer light;

		// Token: 0x040012F8 RID: 4856
		[Token(Token = "0x40012F8")]
		[FieldOffset(Offset = "0x14")]
		public WifiGame <>4__this;

		// Token: 0x040012F9 RID: 4857
		[Token(Token = "0x40012F9")]
		[FieldOffset(Offset = "0x18")]
		public float delay;
	}
}
