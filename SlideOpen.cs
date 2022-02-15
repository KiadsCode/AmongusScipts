using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000253 RID: 595
[Token(Token = "0x2000253")]
public class SlideOpen : MonoBehaviour
{
	// Token: 0x06000D49 RID: 3401 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D49")]
	[Address(RVA = "0x4A1070", Offset = "0x4A0470", VA = "0x104A1070")]
	public void Awake()
	{
	}

	// Token: 0x06000D4A RID: 3402 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D4A")]
	[Address(RVA = "0x4A1450", Offset = "0x4A0850", VA = "0x104A1450")]
	public void Toggle()
	{
	}

	// Token: 0x06000D4B RID: 3403 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D4B")]
	[Address(RVA = "0x4A1250", Offset = "0x4A0650", VA = "0x104A1250")]
	public void Close()
	{
	}

	// Token: 0x06000D4C RID: 3404 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D4C")]
	[Address(RVA = "0x4A13A0", Offset = "0x4A07A0", VA = "0x104A13A0")]
	public void Open()
	{
	}

	// Token: 0x06000D4D RID: 3405 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D4D")]
	[Address(RVA = "0x4A0EC0", Offset = "0x4A02C0", VA = "0x104A0EC0")]
	private void AdjustPosition(float aspect)
	{
	}

	// Token: 0x06000D4E RID: 3406 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D4E")]
	[Address(RVA = "0x4A0FD0", Offset = "0x4A03D0", VA = "0x104A0FD0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE3720", Offset = "0xE2B20")]
	private IEnumerator AnimateClose()
	{
		return null;
	}

	// Token: 0x06000D4F RID: 3407 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D4F")]
	[Address(RVA = "0x4A1020", Offset = "0x4A0420", VA = "0x104A1020")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE37B0", Offset = "0xE2BB0")]
	private IEnumerator AnimateOpen()
	{
		return null;
	}

	// Token: 0x06000D50 RID: 3408 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D50")]
	[Address(RVA = "0x4A1410", Offset = "0x4A0810", VA = "0x104A1410")]
	private void SetPositionVector(Vector3 pos)
	{
	}

	// Token: 0x06000D51 RID: 3409 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D51")]
	[Address(RVA = "0x4A1330", Offset = "0x4A0730", VA = "0x104A1330")]
	private void OnEnable()
	{
	}

	// Token: 0x06000D52 RID: 3410 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D52")]
	[Address(RVA = "0x4A12C0", Offset = "0x4A06C0", VA = "0x104A12C0")]
	private void OnDisable()
	{
	}

	// Token: 0x06000D53 RID: 3411 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D53")]
	[Address(RVA = "0x4A1500", Offset = "0x4A0900", VA = "0x104A1500")]
	public SlideOpen()
	{
	}

	// Token: 0x04000D26 RID: 3366
	[Token(Token = "0x4000D26")]
	[FieldOffset(Offset = "0xC")]
	public float duration;

	// Token: 0x04000D27 RID: 3367
	[Token(Token = "0x4000D27")]
	[FieldOffset(Offset = "0x10")]
	public Button.ButtonClickedEvent OnClose;

	// Token: 0x04000D28 RID: 3368
	[Token(Token = "0x4000D28")]
	[FieldOffset(Offset = "0x14")]
	public Camera parentCam;

	// Token: 0x04000D29 RID: 3369
	[Token(Token = "0x4000D29")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 openPosition;

	// Token: 0x04000D2A RID: 3370
	[Token(Token = "0x4000D2A")]
	[FieldOffset(Offset = "0x24")]
	public Vector3 closedPosition;

	// Token: 0x04000D2B RID: 3371
	[Token(Token = "0x4000D2B")]
	[FieldOffset(Offset = "0x30")]
	public bool isOpen;

	// Token: 0x04000D2C RID: 3372
	[Token(Token = "0x4000D2C")]
	[FieldOffset(Offset = "0x34")]
	private Vector3 computedClosedPosition;

	// Token: 0x02000254 RID: 596
	[Token(Token = "0x2000254")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <AnimateClose>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000D54 RID: 3412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D54")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <AnimateClose>d__12(int <>1__state)
		{
		}

		// Token: 0x06000D55 RID: 3413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D55")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000D56 RID: 3414 RVA: 0x000052F8 File Offset: 0x000034F8
		[Token(Token = "0x6000D56")]
		[Address(RVA = "0x365CE0", Offset = "0x3650E0", VA = "0x10365CE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000D57 RID: 3415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001FB")]
		private object Current
		{
			[Token(Token = "0x6000D57")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D58")]
		[Address(RVA = "0x365E30", Offset = "0x365230", VA = "0x10365E30", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000D59 RID: 3417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001FC")]
		private object Current
		{
			[Token(Token = "0x6000D59")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000D2D RID: 3373
		[Token(Token = "0x4000D2D")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000D2E RID: 3374
		[Token(Token = "0x4000D2E")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000D2F RID: 3375
		[Token(Token = "0x4000D2F")]
		[FieldOffset(Offset = "0x10")]
		public SlideOpen <>4__this;

		// Token: 0x04000D30 RID: 3376
		[Token(Token = "0x4000D30")]
		[FieldOffset(Offset = "0x14")]
		private float <t>5__2;
	}

	// Token: 0x02000255 RID: 597
	[Token(Token = "0x2000255")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <AnimateOpen>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000D5A RID: 3418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D5A")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <AnimateOpen>d__13(int <>1__state)
		{
		}

		// Token: 0x06000D5B RID: 3419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D5B")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000D5C RID: 3420 RVA: 0x00005310 File Offset: 0x00003510
		[Token(Token = "0x6000D5C")]
		[Address(RVA = "0x366140", Offset = "0x365540", VA = "0x10366140", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000D5D RID: 3421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001FD")]
		private object Current
		{
			[Token(Token = "0x6000D5D")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000D5E RID: 3422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D5E")]
		[Address(RVA = "0x366290", Offset = "0x365690", VA = "0x10366290", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000D5F RID: 3423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001FE")]
		private object Current
		{
			[Token(Token = "0x6000D5F")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000D31 RID: 3377
		[Token(Token = "0x4000D31")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000D32 RID: 3378
		[Token(Token = "0x4000D32")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000D33 RID: 3379
		[Token(Token = "0x4000D33")]
		[FieldOffset(Offset = "0x10")]
		public SlideOpen <>4__this;

		// Token: 0x04000D34 RID: 3380
		[Token(Token = "0x4000D34")]
		[FieldOffset(Offset = "0x14")]
		private float <t>5__2;
	}
}
