using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000178 RID: 376
[Token(Token = "0x2000178")]
public class AlignGame : Minigame
{
	// Token: 0x060008A1 RID: 2209 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008A1")]
	[Address(RVA = "0x5463E0", Offset = "0x5457E0", VA = "0x105463E0", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x060008A2 RID: 2210 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008A2")]
	[Address(RVA = "0x546800", Offset = "0x545C00", VA = "0x10546800")]
	public void Update()
	{
	}

	// Token: 0x060008A3 RID: 2211 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008A3")]
	[Address(RVA = "0x546760", Offset = "0x545B60", VA = "0x10546760")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE0210", Offset = "0xDF610")]
	private IEnumerator LockEngine()
	{
		return null;
	}

	// Token: 0x060008A4 RID: 2212 RVA: 0x000042F0 File Offset: 0x000024F0
	[Token(Token = "0x60008A4")]
	[Address(RVA = "0x546730", Offset = "0x545B30", VA = "0x10546730")]
	public static float FromByte(byte b)
	{
		return 0f;
	}

	// Token: 0x060008A5 RID: 2213 RVA: 0x00004308 File Offset: 0x00002508
	[Token(Token = "0x60008A5")]
	[Address(RVA = "0x5467E0", Offset = "0x545BE0", VA = "0x105467E0")]
	public static byte ToByte(float y)
	{
		return 0;
	}

	// Token: 0x060008A6 RID: 2214 RVA: 0x00004320 File Offset: 0x00002520
	[Token(Token = "0x60008A6")]
	[Address(RVA = "0x546750", Offset = "0x545B50", VA = "0x10546750")]
	public static bool IsSuccess(byte b)
	{
		return default(bool);
	}

	// Token: 0x060008A7 RID: 2215 RVA: 0x00004338 File Offset: 0x00002538
	[Token(Token = "0x60008A7")]
	[Address(RVA = "0x5467B0", Offset = "0x545BB0", VA = "0x105467B0")]
	public static bool ShouldComplete(byte b)
	{
		return default(bool);
	}

	// Token: 0x060008A8 RID: 2216 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008A8")]
	[Address(RVA = "0x547400", Offset = "0x546800", VA = "0x10547400")]
	public AlignGame()
	{
	}

	// Token: 0x040008A9 RID: 2217
	[Token(Token = "0x40008A9")]
	[FieldOffset(Offset = "0x30")]
	private Controller myController;

	// Token: 0x040008AA RID: 2218
	[Token(Token = "0x40008AA")]
	[FieldOffset(Offset = "0x34")]
	public FloatRange YRange;

	// Token: 0x040008AB RID: 2219
	[Token(Token = "0x40008AB")]
	[FieldOffset(Offset = "0x38")]
	public AnimationCurve curve;

	// Token: 0x040008AC RID: 2220
	[Token(Token = "0x40008AC")]
	[FieldOffset(Offset = "0x3C")]
	public LineRenderer centerline;

	// Token: 0x040008AD RID: 2221
	[Token(Token = "0x40008AD")]
	[FieldOffset(Offset = "0x40")]
	public LineRenderer[] guidelines;

	// Token: 0x040008AE RID: 2222
	[Token(Token = "0x40008AE")]
	[FieldOffset(Offset = "0x44")]
	public SpriteRenderer engine;

	// Token: 0x040008AF RID: 2223
	[Token(Token = "0x40008AF")]
	[FieldOffset(Offset = "0x48")]
	public Collider2D col;

	// Token: 0x040008B0 RID: 2224
	[Token(Token = "0x40008B0")]
	[FieldOffset(Offset = "0x4C")]
	private float pulseTimer;

	// Token: 0x040008B1 RID: 2225
	[Token(Token = "0x40008B1")]
	[FieldOffset(Offset = "0x50")]
	private bool wasPushingJoystick;

	// Token: 0x040008B2 RID: 2226
	[Token(Token = "0x40008B2")]
	[FieldOffset(Offset = "0x54")]
	private float initialY;

	// Token: 0x040008B3 RID: 2227
	[Token(Token = "0x40008B3")]
	[FieldOffset(Offset = "0x58")]
	private TouchpadBehavior touchpad;

	// Token: 0x02000179 RID: 377
	[Token(Token = "0x2000179")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass13_0
	{
		// Token: 0x060008A9 RID: 2217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass13_0()
		{
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x3CA2E0", Offset = "0x3C96E0", VA = "0x103CA2E0")]
		internal void <LockEngine>b__0(float t)
		{
		}

		// Token: 0x040008B4 RID: 2228
		[Token(Token = "0x40008B4")]
		[FieldOffset(Offset = "0x8")]
		public AlignGame <>4__this;

		// Token: 0x040008B5 RID: 2229
		[Token(Token = "0x40008B5")]
		[FieldOffset(Offset = "0xC")]
		public Color green;
	}

	// Token: 0x0200017A RID: 378
	[Token(Token = "0x200017A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <LockEngine>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060008AB RID: 2219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <LockEngine>d__13(int <>1__state)
		{
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x00004350 File Offset: 0x00002550
		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x3C8CD0", Offset = "0x3C80D0", VA = "0x103C8CD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060008AE RID: 2222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000153")]
		private object Current
		{
			[Token(Token = "0x60008AE")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x3C9020", Offset = "0x3C8420", VA = "0x103C9020", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060008B0 RID: 2224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000154")]
		private object Current
		{
			[Token(Token = "0x60008B0")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040008B6 RID: 2230
		[Token(Token = "0x40008B6")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040008B7 RID: 2231
		[Token(Token = "0x40008B7")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040008B8 RID: 2232
		[Token(Token = "0x40008B8")]
		[FieldOffset(Offset = "0x10")]
		public AlignGame <>4__this;

		// Token: 0x040008B9 RID: 2233
		[Token(Token = "0x40008B9")]
		[FieldOffset(Offset = "0x14")]
		private AlignGame.<>c__DisplayClass13_0 <>8__1;

		// Token: 0x040008BA RID: 2234
		[Token(Token = "0x40008BA")]
		[FieldOffset(Offset = "0x18")]
		private int <i>5__2;
	}
}
