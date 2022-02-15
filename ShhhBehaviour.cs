using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x0200024E RID: 590
[Token(Token = "0x200024E")]
public class ShhhBehaviour : MonoBehaviour
{
	// Token: 0x06000D27 RID: 3367 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D27")]
	[Address(RVA = "0x494A90", Offset = "0x493E90", VA = "0x10494A90")]
	public void OnEnable()
	{
	}

	// Token: 0x06000D28 RID: 3368 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D28")]
	[Address(RVA = "0x494CC0", Offset = "0x4940C0", VA = "0x10494CC0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE3160", Offset = "0xE2560")]
	public IEnumerator PlayAnimation()
	{
		return null;
	}

	// Token: 0x06000D29 RID: 3369 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D29")]
	[Address(RVA = "0x494EB0", Offset = "0x4942B0", VA = "0x10494EB0")]
	public void Update()
	{
	}

	// Token: 0x06000D2A RID: 3370 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D2A")]
	[Address(RVA = "0x494A30", Offset = "0x493E30", VA = "0x10494A30")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE31F0", Offset = "0xE25F0")]
	private IEnumerator AnimateText()
	{
		return null;
	}

	// Token: 0x06000D2B RID: 3371 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D2B")]
	[Address(RVA = "0x4949E0", Offset = "0x493DE0", VA = "0x104949E0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE3280", Offset = "0xE2680")]
	private IEnumerator AnimateHand()
	{
		return null;
	}

	// Token: 0x06000D2C RID: 3372 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D2C")]
	[Address(RVA = "0x494D10", Offset = "0x494110", VA = "0x10494D10")]
	private void UpdateHand(ref Vector3 vec, float p)
	{
	}

	// Token: 0x06000D2D RID: 3373 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D2D")]
	[Address(RVA = "0x494E40", Offset = "0x494240", VA = "0x10494E40")]
	private void UpdateText(ref Vector3 vec, float p)
	{
	}

	// Token: 0x06000D2E RID: 3374 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D2E")]
	[Address(RVA = "0x494F20", Offset = "0x494320", VA = "0x10494F20")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE32D0", Offset = "0xE26D0")]
	public static IEnumerator WaitWithInterrupt(float duration)
	{
		return null;
	}

	// Token: 0x06000D2F RID: 3375 RVA: 0x00005280 File Offset: 0x00003480
	[Token(Token = "0x6000D2F")]
	[Address(RVA = "0x494A80", Offset = "0x493E80", VA = "0x10494A80")]
	public static bool CheckForInterrupt()
	{
		return default(bool);
	}

	// Token: 0x06000D30 RID: 3376 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D30")]
	[Address(RVA = "0x494F80", Offset = "0x494380", VA = "0x10494F80")]
	public ShhhBehaviour()
	{
	}

	// Token: 0x04000D03 RID: 3331
	[Token(Token = "0x4000D03")]
	[FieldOffset(Offset = "0xC")]
	public SpriteRenderer Background;

	// Token: 0x04000D04 RID: 3332
	[Token(Token = "0x4000D04")]
	[FieldOffset(Offset = "0x10")]
	public SpriteRenderer Body;

	// Token: 0x04000D05 RID: 3333
	[Token(Token = "0x4000D05")]
	[FieldOffset(Offset = "0x14")]
	public SpriteRenderer Hand;

	// Token: 0x04000D06 RID: 3334
	[Token(Token = "0x4000D06")]
	[FieldOffset(Offset = "0x18")]
	public TextMeshPro TextImage;

	// Token: 0x04000D07 RID: 3335
	[Token(Token = "0x4000D07")]
	[FieldOffset(Offset = "0x1C")]
	public float RotateSpeed;

	// Token: 0x04000D08 RID: 3336
	[Token(Token = "0x4000D08")]
	[FieldOffset(Offset = "0x20")]
	public Vector2Range HandTarget;

	// Token: 0x04000D09 RID: 3337
	[Token(Token = "0x4000D09")]
	[FieldOffset(Offset = "0x30")]
	public AnimationCurve PositionEasing;

	// Token: 0x04000D0A RID: 3338
	[Token(Token = "0x4000D0A")]
	[FieldOffset(Offset = "0x34")]
	public FloatRange HandRotate;

	// Token: 0x04000D0B RID: 3339
	[Token(Token = "0x4000D0B")]
	[FieldOffset(Offset = "0x38")]
	public AnimationCurve RotationEasing;

	// Token: 0x04000D0C RID: 3340
	[Token(Token = "0x4000D0C")]
	[FieldOffset(Offset = "0x3C")]
	public Vector2Range TextTarget;

	// Token: 0x04000D0D RID: 3341
	[Token(Token = "0x4000D0D")]
	[FieldOffset(Offset = "0x4C")]
	public AnimationCurve TextEasing;

	// Token: 0x04000D0E RID: 3342
	[Token(Token = "0x4000D0E")]
	[FieldOffset(Offset = "0x50")]
	public float Duration;

	// Token: 0x04000D0F RID: 3343
	[Token(Token = "0x4000D0F")]
	[FieldOffset(Offset = "0x54")]
	public float Delay;

	// Token: 0x04000D10 RID: 3344
	[Token(Token = "0x4000D10")]
	[FieldOffset(Offset = "0x58")]
	public float TextDuration;

	// Token: 0x04000D11 RID: 3345
	[Token(Token = "0x4000D11")]
	[FieldOffset(Offset = "0x5C")]
	public float PulseDuration;

	// Token: 0x04000D12 RID: 3346
	[Token(Token = "0x4000D12")]
	[FieldOffset(Offset = "0x60")]
	public float PulseSize;

	// Token: 0x04000D13 RID: 3347
	[Token(Token = "0x4000D13")]
	[FieldOffset(Offset = "0x64")]
	public float HoldDuration;

	// Token: 0x04000D14 RID: 3348
	[Token(Token = "0x4000D14")]
	[FieldOffset(Offset = "0x68")]
	public bool Autoplay;

	// Token: 0x0200024F RID: 591
	[Token(Token = "0x200024F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <PlayAnimation>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000D31 RID: 3377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D31")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <PlayAnimation>d__19(int <>1__state)
		{
		}

		// Token: 0x06000D32 RID: 3378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D32")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000D33 RID: 3379 RVA: 0x00005298 File Offset: 0x00003498
		[Token(Token = "0x6000D33")]
		[Address(RVA = "0x36D2C0", Offset = "0x36C6C0", VA = "0x1036D2C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000D34 RID: 3380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001F3")]
		private object Current
		{
			[Token(Token = "0x6000D34")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000D35 RID: 3381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D35")]
		[Address(RVA = "0x36D360", Offset = "0x36C760", VA = "0x1036D360", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000D36 RID: 3382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001F4")]
		private object Current
		{
			[Token(Token = "0x6000D36")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000D15 RID: 3349
		[Token(Token = "0x4000D15")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000D16 RID: 3350
		[Token(Token = "0x4000D16")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000D17 RID: 3351
		[Token(Token = "0x4000D17")]
		[FieldOffset(Offset = "0x10")]
		public ShhhBehaviour <>4__this;
	}

	// Token: 0x02000250 RID: 592
	[Token(Token = "0x2000250")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <AnimateText>d__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000D37 RID: 3383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D37")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <AnimateText>d__21(int <>1__state)
		{
		}

		// Token: 0x06000D38 RID: 3384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D38")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x000052B0 File Offset: 0x000034B0
		[Token(Token = "0x6000D39")]
		[Address(RVA = "0x366430", Offset = "0x365830", VA = "0x10366430", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000D3A RID: 3386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001F5")]
		private object Current
		{
			[Token(Token = "0x6000D3A")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000D3B RID: 3387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D3B")]
		[Address(RVA = "0x366720", Offset = "0x365B20", VA = "0x10366720", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000D3C RID: 3388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001F6")]
		private object Current
		{
			[Token(Token = "0x6000D3C")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000D18 RID: 3352
		[Token(Token = "0x4000D18")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000D19 RID: 3353
		[Token(Token = "0x4000D19")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000D1A RID: 3354
		[Token(Token = "0x4000D1A")]
		[FieldOffset(Offset = "0x10")]
		public ShhhBehaviour <>4__this;

		// Token: 0x04000D1B RID: 3355
		[Token(Token = "0x4000D1B")]
		[FieldOffset(Offset = "0x14")]
		private Vector3 <vec>5__2;

		// Token: 0x04000D1C RID: 3356
		[Token(Token = "0x4000D1C")]
		[FieldOffset(Offset = "0x20")]
		private float <t>5__3;
	}

	// Token: 0x02000251 RID: 593
	[Token(Token = "0x2000251")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <AnimateHand>d__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000D3D RID: 3389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D3D")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <AnimateHand>d__22(int <>1__state)
		{
		}

		// Token: 0x06000D3E RID: 3390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D3E")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000D3F RID: 3391 RVA: 0x000052C8 File Offset: 0x000034C8
		[Token(Token = "0x6000D3F")]
		[Address(RVA = "0x365FF0", Offset = "0x3653F0", VA = "0x10365FF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000D40 RID: 3392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001F7")]
		private object Current
		{
			[Token(Token = "0x6000D40")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000D41 RID: 3393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D41")]
		[Address(RVA = "0x366110", Offset = "0x365510", VA = "0x10366110", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000D42 RID: 3394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001F8")]
		private object Current
		{
			[Token(Token = "0x6000D42")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000D1D RID: 3357
		[Token(Token = "0x4000D1D")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000D1E RID: 3358
		[Token(Token = "0x4000D1E")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000D1F RID: 3359
		[Token(Token = "0x4000D1F")]
		[FieldOffset(Offset = "0x10")]
		public ShhhBehaviour <>4__this;

		// Token: 0x04000D20 RID: 3360
		[Token(Token = "0x4000D20")]
		[FieldOffset(Offset = "0x14")]
		private Vector3 <vec>5__2;

		// Token: 0x04000D21 RID: 3361
		[Token(Token = "0x4000D21")]
		[FieldOffset(Offset = "0x20")]
		private float <t>5__3;
	}

	// Token: 0x02000252 RID: 594
	[Token(Token = "0x2000252")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <WaitWithInterrupt>d__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000D43 RID: 3395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D43")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <WaitWithInterrupt>d__25(int <>1__state)
		{
		}

		// Token: 0x06000D44 RID: 3396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D44")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000D45 RID: 3397 RVA: 0x000052E0 File Offset: 0x000034E0
		[Token(Token = "0x6000D45")]
		[Address(RVA = "0x3729F0", Offset = "0x371DF0", VA = "0x103729F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000D46 RID: 3398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001F9")]
		private object Current
		{
			[Token(Token = "0x6000D46")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000D47 RID: 3399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D47")]
		[Address(RVA = "0x372A70", Offset = "0x371E70", VA = "0x10372A70", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000D48 RID: 3400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001FA")]
		private object Current
		{
			[Token(Token = "0x6000D48")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000D22 RID: 3362
		[Token(Token = "0x4000D22")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000D23 RID: 3363
		[Token(Token = "0x4000D23")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000D24 RID: 3364
		[Token(Token = "0x4000D24")]
		[FieldOffset(Offset = "0x10")]
		public float duration;

		// Token: 0x04000D25 RID: 3365
		[Token(Token = "0x4000D25")]
		[FieldOffset(Offset = "0x14")]
		private float <timer>5__2;
	}
}
