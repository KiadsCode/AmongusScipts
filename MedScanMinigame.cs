using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000310 RID: 784
[Token(Token = "0x2000310")]
public class MedScanMinigame : Minigame
{
	// Token: 0x06001141 RID: 4417 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001141")]
	[Address(RVA = "0x76C0E0", Offset = "0x76B4E0", VA = "0x1076C0E0", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x06001142 RID: 4418 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001142")]
	[Address(RVA = "0x76CF00", Offset = "0x76C300", VA = "0x1076CF00")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE6DC0", Offset = "0xE61C0")]
	private IEnumerator WalkToOffset()
	{
		return null;
	}

	// Token: 0x06001143 RID: 4419 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001143")]
	[Address(RVA = "0x76CF50", Offset = "0x76C350", VA = "0x1076CF50")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE6E10", Offset = "0xE6210")]
	private IEnumerator WalkToPad()
	{
		return null;
	}

	// Token: 0x06001144 RID: 4420 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001144")]
	[Address(RVA = "0x76C840", Offset = "0x76BC40", VA = "0x1076C840")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06001145 RID: 4421 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001145")]
	[Address(RVA = "0x76C6B0", Offset = "0x76BAB0", VA = "0x1076C6B0", Slot = "5")]
	public override void Close()
	{
	}

	// Token: 0x06001146 RID: 4422 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001146")]
	[Address(RVA = "0x76D2B0", Offset = "0x76C6B0", VA = "0x1076D2B0")]
	public MedScanMinigame()
	{
	}

	// Token: 0x04001115 RID: 4373
	[Token(Token = "0x4001115")]
	private const int SomeKindOfPrimeNumber = 7;

	// Token: 0x04001116 RID: 4374
	[Token(Token = "0x4001116")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string[] BloodTypes;

	// Token: 0x04001117 RID: 4375
	[Token(Token = "0x4001117")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshPro text;

	// Token: 0x04001118 RID: 4376
	[Token(Token = "0x4001118")]
	[FieldOffset(Offset = "0x34")]
	public TextMeshPro charStats;

	// Token: 0x04001119 RID: 4377
	[Token(Token = "0x4001119")]
	[FieldOffset(Offset = "0x38")]
	public HorizontalGauge gauge;

	// Token: 0x0400111A RID: 4378
	[Token(Token = "0x400111A")]
	[FieldOffset(Offset = "0x3C")]
	private MedScanSystem medscan;

	// Token: 0x0400111B RID: 4379
	[Token(Token = "0x400111B")]
	[FieldOffset(Offset = "0x40")]
	public float ScanDuration;

	// Token: 0x0400111C RID: 4380
	[Token(Token = "0x400111C")]
	[FieldOffset(Offset = "0x44")]
	public float ScanTimer;

	// Token: 0x0400111D RID: 4381
	[Token(Token = "0x400111D")]
	[FieldOffset(Offset = "0x48")]
	private string completeString;

	// Token: 0x0400111E RID: 4382
	[Token(Token = "0x400111E")]
	[FieldOffset(Offset = "0x4C")]
	public AudioClip ScanSound;

	// Token: 0x0400111F RID: 4383
	[Token(Token = "0x400111F")]
	[FieldOffset(Offset = "0x50")]
	public AudioClip TextSound;

	// Token: 0x04001120 RID: 4384
	[Token(Token = "0x4001120")]
	[FieldOffset(Offset = "0x54")]
	private Coroutine walking;

	// Token: 0x04001121 RID: 4385
	[Token(Token = "0x4001121")]
	[FieldOffset(Offset = "0x58")]
	private MedScanMinigame.PositionState state;

	// Token: 0x02000311 RID: 785
	[Token(Token = "0x2000311")]
	private enum PositionState
	{
		// Token: 0x04001123 RID: 4387
		[Token(Token = "0x4001123")]
		None,
		// Token: 0x04001124 RID: 4388
		[Token(Token = "0x4001124")]
		WalkingToPad,
		// Token: 0x04001125 RID: 4389
		[Token(Token = "0x4001125")]
		WalkingToOffset
	}

	// Token: 0x02000312 RID: 786
	[Token(Token = "0x2000312")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <WalkToOffset>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001148 RID: 4424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001148")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <WalkToOffset>d__15(int <>1__state)
		{
		}

		// Token: 0x06001149 RID: 4425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001149")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600114A RID: 4426 RVA: 0x00006120 File Offset: 0x00004320
		[Token(Token = "0x600114A")]
		[Address(RVA = "0x79C640", Offset = "0x79BA40", VA = "0x1079C640", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x0600114B RID: 4427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000292")]
		private object Current
		{
			[Token(Token = "0x600114B")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600114C RID: 4428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600114C")]
		[Address(RVA = "0x79C8D0", Offset = "0x79BCD0", VA = "0x1079C8D0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x0600114D RID: 4429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000293")]
		private object Current
		{
			[Token(Token = "0x600114D")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04001126 RID: 4390
		[Token(Token = "0x4001126")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04001127 RID: 4391
		[Token(Token = "0x4001127")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04001128 RID: 4392
		[Token(Token = "0x4001128")]
		[FieldOffset(Offset = "0x10")]
		public MedScanMinigame <>4__this;
	}

	// Token: 0x02000313 RID: 787
	[Token(Token = "0x2000313")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <WalkToPad>d__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600114E RID: 4430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600114E")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <WalkToPad>d__16(int <>1__state)
		{
		}

		// Token: 0x0600114F RID: 4431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600114F")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001150 RID: 4432 RVA: 0x00006138 File Offset: 0x00004338
		[Token(Token = "0x6001150")]
		[Address(RVA = "0x79C900", Offset = "0x79BD00", VA = "0x1079C900", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06001151 RID: 4433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000294")]
		private object Current
		{
			[Token(Token = "0x6001151")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001152 RID: 4434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001152")]
		[Address(RVA = "0x79CAF0", Offset = "0x79BEF0", VA = "0x1079CAF0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06001153 RID: 4435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000295")]
		private object Current
		{
			[Token(Token = "0x6001153")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04001129 RID: 4393
		[Token(Token = "0x4001129")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x0400112A RID: 4394
		[Token(Token = "0x400112A")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x0400112B RID: 4395
		[Token(Token = "0x400112B")]
		[FieldOffset(Offset = "0x10")]
		public MedScanMinigame <>4__this;
	}
}
