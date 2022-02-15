using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000317 RID: 791
[Token(Token = "0x2000317")]
public class SampleMinigame : Minigame
{
	// Token: 0x17000299 RID: 665
	// (get) Token: 0x06001162 RID: 4450 RVA: 0x000061B0 File Offset: 0x000043B0
	// (set) Token: 0x06001163 RID: 4451 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000299")]
	private SampleMinigame.States State
	{
		[Token(Token = "0x6001162")]
		[Address(RVA = "0x582DA0", Offset = "0x5821A0", VA = "0x10582DA0")]
		get
		{
			return SampleMinigame.States.PrepareSample;
		}
		[Token(Token = "0x6001163")]
		[Address(RVA = "0x49B300", Offset = "0x49A700", VA = "0x1049B300")]
		set
		{
		}
	}

	// Token: 0x1700029A RID: 666
	// (get) Token: 0x06001164 RID: 4452 RVA: 0x000061C8 File Offset: 0x000043C8
	// (set) Token: 0x06001165 RID: 4453 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700029A")]
	private int AnomalyId
	{
		[Token(Token = "0x6001164")]
		[Address(RVA = "0x582D60", Offset = "0x582160", VA = "0x10582D60")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001165")]
		[Address(RVA = "0x582DE0", Offset = "0x5821E0", VA = "0x10582DE0")]
		set
		{
		}
	}

	// Token: 0x06001166 RID: 4454 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001166")]
	[Address(RVA = "0x581740", Offset = "0x580B40", VA = "0x10581740")]
	public void Awake()
	{
	}

	// Token: 0x06001167 RID: 4455 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001167")]
	[Address(RVA = "0x581820", Offset = "0x580C20", VA = "0x10581820", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x06001168 RID: 4456 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001168")]
	[Address(RVA = "0x582730", Offset = "0x581B30", VA = "0x10582730")]
	private void SetPlatformBottom()
	{
	}

	// Token: 0x06001169 RID: 4457 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001169")]
	[Address(RVA = "0x5827C0", Offset = "0x581BC0", VA = "0x105827C0")]
	private void SetPlatformTop()
	{
	}

	// Token: 0x0600116A RID: 4458 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600116A")]
	[Address(RVA = "0x582850", Offset = "0x581C50", VA = "0x10582850")]
	public void Update()
	{
	}

	// Token: 0x0600116B RID: 4459 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600116B")]
	[Address(RVA = "0x581EF0", Offset = "0x5812F0", VA = "0x10581EF0")]
	public void FixedUpdate()
	{
	}

	// Token: 0x0600116C RID: 4460 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600116C")]
	[Address(RVA = "0x581D30", Offset = "0x581130", VA = "0x10581D30")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE6FB0", Offset = "0xE63B0")]
	public IEnumerator BringPanelUp(bool isBeginning)
	{
		return null;
	}

	// Token: 0x0600116D RID: 4461 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600116D")]
	[Address(RVA = "0x581CE0", Offset = "0x5810E0", VA = "0x10581CE0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE7000", Offset = "0xE6400")]
	public IEnumerator BringPanelDown()
	{
		return null;
	}

	// Token: 0x0600116E RID: 4462 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600116E")]
	[Address(RVA = "0x581E90", Offset = "0x581290", VA = "0x10581E90")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE7050", Offset = "0xE6450")]
	private IEnumerator DropTube(int id)
	{
		return null;
	}

	// Token: 0x0600116F RID: 4463 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600116F")]
	[Address(RVA = "0x5825E0", Offset = "0x5819E0", VA = "0x105825E0")]
	public void SelectTube(int tubeId)
	{
	}

	// Token: 0x06001170 RID: 4464 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001170")]
	[Address(RVA = "0x581D90", Offset = "0x581190", VA = "0x10581D90")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE70A0", Offset = "0xE64A0")]
	private IEnumerator CoSelectTube(int correctTube, int selectedTube)
	{
		return null;
	}

	// Token: 0x06001171 RID: 4465 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001171")]
	[Address(RVA = "0x582420", Offset = "0x581820", VA = "0x10582420")]
	public void NextStep()
	{
	}

	// Token: 0x06001172 RID: 4466 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001172")]
	[Address(RVA = "0x581DF0", Offset = "0x5811F0", VA = "0x10581DF0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE7160", Offset = "0xE6560")]
	private IEnumerator CoStartProcessing()
	{
		return null;
	}

	// Token: 0x06001173 RID: 4467 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001173")]
	[Address(RVA = "0x581E40", Offset = "0x581240", VA = "0x10581E40")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE71B0", Offset = "0xE65B0")]
	private IEnumerator DropLiquid()
	{
		return null;
	}

	// Token: 0x06001174 RID: 4468 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001174")]
	[Address(RVA = "0x582CC0", Offset = "0x5820C0", VA = "0x10582CC0")]
	public SampleMinigame()
	{
	}

	// Token: 0x04001135 RID: 4405
	[Token(Token = "0x4001135")]
	[FieldOffset(Offset = "0x0")]
	private static StringNames[] ProcessingStrings;

	// Token: 0x04001136 RID: 4406
	[Token(Token = "0x4001136")]
	private const float PanelMoveDuration = 0.75f;

	// Token: 0x04001137 RID: 4407
	[Token(Token = "0x4001137")]
	private const byte TubeMask = 15;

	// Token: 0x04001138 RID: 4408
	[Token(Token = "0x4001138")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshPro UpperText;

	// Token: 0x04001139 RID: 4409
	[Token(Token = "0x4001139")]
	[FieldOffset(Offset = "0x34")]
	public TextMeshPro LowerText;

	// Token: 0x0400113A RID: 4410
	[Token(Token = "0x400113A")]
	[FieldOffset(Offset = "0x38")]
	public float TimePerStep;

	// Token: 0x0400113B RID: 4411
	[Token(Token = "0x400113B")]
	[FieldOffset(Offset = "0x3C")]
	public FloatRange platformY;

	// Token: 0x0400113C RID: 4412
	[Token(Token = "0x400113C")]
	[FieldOffset(Offset = "0x40")]
	public FloatRange dropperX;

	// Token: 0x0400113D RID: 4413
	[Token(Token = "0x400113D")]
	[FieldOffset(Offset = "0x44")]
	public SpriteRenderer CenterPanel;

	// Token: 0x0400113E RID: 4414
	[Token(Token = "0x400113E")]
	[FieldOffset(Offset = "0x48")]
	public SpriteRenderer Dropper;

	// Token: 0x0400113F RID: 4415
	[Token(Token = "0x400113F")]
	[FieldOffset(Offset = "0x4C")]
	public SpriteRenderer[] Tubes;

	// Token: 0x04001140 RID: 4416
	[Token(Token = "0x4001140")]
	[FieldOffset(Offset = "0x50")]
	public SpriteRenderer[] Buttons;

	// Token: 0x04001141 RID: 4417
	[Token(Token = "0x4001141")]
	[FieldOffset(Offset = "0x54")]
	public SpriteRenderer[] LowerButtons;

	// Token: 0x04001142 RID: 4418
	[Token(Token = "0x4001142")]
	[FieldOffset(Offset = "0x58")]
	public AudioClip ButtonSound;

	// Token: 0x04001143 RID: 4419
	[Token(Token = "0x4001143")]
	[FieldOffset(Offset = "0x5C")]
	public AudioClip PanelMoveSound;

	// Token: 0x04001144 RID: 4420
	[Token(Token = "0x4001144")]
	[FieldOffset(Offset = "0x60")]
	public AudioClip FailSound;

	// Token: 0x04001145 RID: 4421
	[Token(Token = "0x4001145")]
	[FieldOffset(Offset = "0x64")]
	public AudioClip[] DropSounds;

	// Token: 0x04001146 RID: 4422
	[Token(Token = "0x4001146")]
	[FieldOffset(Offset = "0x68")]
	private RandomFill<AudioClip> dropSounds;

	// Token: 0x04001147 RID: 4423
	[Token(Token = "0x4001147")]
	[FieldOffset(Offset = "0x6C")]
	public Transform whichButtonSelector;

	// Token: 0x04001148 RID: 4424
	[Token(Token = "0x4001148")]
	[FieldOffset(Offset = "0x70")]
	public int whichButtonSelected;

	// Token: 0x04001149 RID: 4425
	[Token(Token = "0x4001149")]
	[FieldOffset(Offset = "0x74")]
	private float selectMoveCooldown;

	// Token: 0x02000318 RID: 792
	[Token(Token = "0x2000318")]
	public enum States : byte
	{
		// Token: 0x0400114B RID: 4427
		[Token(Token = "0x400114B")]
		PrepareSample,
		// Token: 0x0400114C RID: 4428
		[Token(Token = "0x400114C")]
		Complete = 16,
		// Token: 0x0400114D RID: 4429
		[Token(Token = "0x400114D")]
		AwaitingStart = 32,
		// Token: 0x0400114E RID: 4430
		[Token(Token = "0x400114E")]
		Selection = 64,
		// Token: 0x0400114F RID: 4431
		[Token(Token = "0x400114F")]
		Processing = 128
	}

	// Token: 0x02000319 RID: 793
	[Token(Token = "0x2000319")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <BringPanelUp>d__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001176 RID: 4470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001176")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <BringPanelUp>d__34(int <>1__state)
		{
		}

		// Token: 0x06001177 RID: 4471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001177")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001178 RID: 4472 RVA: 0x000061E0 File Offset: 0x000043E0
		[Token(Token = "0x6001178")]
		[Address(RVA = "0x366BB0", Offset = "0x365FB0", VA = "0x10366BB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06001179 RID: 4473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700029B")]
		private object Current
		{
			[Token(Token = "0x6001179")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600117A RID: 4474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600117A")]
		[Address(RVA = "0x366EB0", Offset = "0x3662B0", VA = "0x10366EB0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x0600117B RID: 4475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700029C")]
		private object Current
		{
			[Token(Token = "0x600117B")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04001150 RID: 4432
		[Token(Token = "0x4001150")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04001151 RID: 4433
		[Token(Token = "0x4001151")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04001152 RID: 4434
		[Token(Token = "0x4001152")]
		[FieldOffset(Offset = "0x10")]
		public SampleMinigame <>4__this;

		// Token: 0x04001153 RID: 4435
		[Token(Token = "0x4001153")]
		[FieldOffset(Offset = "0x14")]
		public bool isBeginning;

		// Token: 0x04001154 RID: 4436
		[Token(Token = "0x4001154")]
		[FieldOffset(Offset = "0x18")]
		private WaitForFixedUpdate <wait>5__2;

		// Token: 0x04001155 RID: 4437
		[Token(Token = "0x4001155")]
		[FieldOffset(Offset = "0x1C")]
		private Vector3 <pos>5__3;

		// Token: 0x04001156 RID: 4438
		[Token(Token = "0x4001156")]
		[FieldOffset(Offset = "0x28")]
		private float <i>5__4;
	}

	// Token: 0x0200031A RID: 794
	[Token(Token = "0x200031A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <BringPanelDown>d__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600117C RID: 4476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600117C")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <BringPanelDown>d__35(int <>1__state)
		{
		}

		// Token: 0x0600117D RID: 4477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600117D")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600117E RID: 4478 RVA: 0x000061F8 File Offset: 0x000043F8
		[Token(Token = "0x600117E")]
		[Address(RVA = "0x366930", Offset = "0x365D30", VA = "0x10366930", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x0600117F RID: 4479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700029D")]
		private object Current
		{
			[Token(Token = "0x600117F")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001180 RID: 4480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001180")]
		[Address(RVA = "0x366B80", Offset = "0x365F80", VA = "0x10366B80", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06001181 RID: 4481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700029E")]
		private object Current
		{
			[Token(Token = "0x6001181")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04001157 RID: 4439
		[Token(Token = "0x4001157")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04001158 RID: 4440
		[Token(Token = "0x4001158")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04001159 RID: 4441
		[Token(Token = "0x4001159")]
		[FieldOffset(Offset = "0x10")]
		public SampleMinigame <>4__this;

		// Token: 0x0400115A RID: 4442
		[Token(Token = "0x400115A")]
		[FieldOffset(Offset = "0x14")]
		private WaitForFixedUpdate <wait>5__2;

		// Token: 0x0400115B RID: 4443
		[Token(Token = "0x400115B")]
		[FieldOffset(Offset = "0x18")]
		private Vector3 <pos>5__3;

		// Token: 0x0400115C RID: 4444
		[Token(Token = "0x400115C")]
		[FieldOffset(Offset = "0x24")]
		private float <i>5__4;
	}

	// Token: 0x0200031B RID: 795
	[Token(Token = "0x200031B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <DropTube>d__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001182 RID: 4482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001182")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <DropTube>d__36(int <>1__state)
		{
		}

		// Token: 0x06001183 RID: 4483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001183")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001184 RID: 4484 RVA: 0x00006210 File Offset: 0x00004410
		[Token(Token = "0x6001184")]
		[Address(RVA = "0x36B3F0", Offset = "0x36A7F0", VA = "0x1036B3F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06001185 RID: 4485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700029F")]
		private object Current
		{
			[Token(Token = "0x6001185")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001186 RID: 4486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001186")]
		[Address(RVA = "0x36B530", Offset = "0x36A930", VA = "0x1036B530", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06001187 RID: 4487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002A0")]
		private object Current
		{
			[Token(Token = "0x6001187")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400115D RID: 4445
		[Token(Token = "0x400115D")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x0400115E RID: 4446
		[Token(Token = "0x400115E")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x0400115F RID: 4447
		[Token(Token = "0x400115F")]
		[FieldOffset(Offset = "0x10")]
		public SampleMinigame <>4__this;

		// Token: 0x04001160 RID: 4448
		[Token(Token = "0x4001160")]
		[FieldOffset(Offset = "0x14")]
		public int id;
	}

	// Token: 0x0200031C RID: 796
	[Token(Token = "0x200031C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoSelectTube>d__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001188 RID: 4488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001188")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoSelectTube>d__38(int <>1__state)
		{
		}

		// Token: 0x06001189 RID: 4489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001189")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600118A RID: 4490 RVA: 0x00006228 File Offset: 0x00004428
		[Token(Token = "0x600118A")]
		[Address(RVA = "0x368D60", Offset = "0x368160", VA = "0x10368D60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x0600118B RID: 4491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002A1")]
		private object Current
		{
			[Token(Token = "0x600118B")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600118C RID: 4492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600118C")]
		[Address(RVA = "0x369530", Offset = "0x368930", VA = "0x10369530", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x0600118D RID: 4493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002A2")]
		private object Current
		{
			[Token(Token = "0x600118D")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04001161 RID: 4449
		[Token(Token = "0x4001161")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04001162 RID: 4450
		[Token(Token = "0x4001162")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04001163 RID: 4451
		[Token(Token = "0x4001163")]
		[FieldOffset(Offset = "0x10")]
		public int selectedTube;

		// Token: 0x04001164 RID: 4452
		[Token(Token = "0x4001164")]
		[FieldOffset(Offset = "0x14")]
		public int correctTube;

		// Token: 0x04001165 RID: 4453
		[Token(Token = "0x4001165")]
		[FieldOffset(Offset = "0x18")]
		public SampleMinigame <>4__this;
	}

	// Token: 0x0200031D RID: 797
	[Token(Token = "0x200031D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoStartProcessing>d__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600118E RID: 4494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600118E")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoStartProcessing>d__40(int <>1__state)
		{
		}

		// Token: 0x0600118F RID: 4495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600118F")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001190 RID: 4496 RVA: 0x00006240 File Offset: 0x00004440
		[Token(Token = "0x6001190")]
		[Address(RVA = "0x36A360", Offset = "0x369760", VA = "0x1036A360", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06001191 RID: 4497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002A3")]
		private object Current
		{
			[Token(Token = "0x6001191")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001192 RID: 4498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001192")]
		[Address(RVA = "0x36A500", Offset = "0x369900", VA = "0x1036A500", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06001193 RID: 4499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002A4")]
		private object Current
		{
			[Token(Token = "0x6001193")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04001166 RID: 4454
		[Token(Token = "0x4001166")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04001167 RID: 4455
		[Token(Token = "0x4001167")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04001168 RID: 4456
		[Token(Token = "0x4001168")]
		[FieldOffset(Offset = "0x10")]
		public SampleMinigame <>4__this;
	}

	// Token: 0x0200031E RID: 798
	[Token(Token = "0x200031E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <DropLiquid>d__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001194 RID: 4500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001194")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <DropLiquid>d__41(int <>1__state)
		{
		}

		// Token: 0x06001195 RID: 4501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001195")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001196 RID: 4502 RVA: 0x00006258 File Offset: 0x00004458
		[Token(Token = "0x6001196")]
		[Address(RVA = "0x36ADE0", Offset = "0x36A1E0", VA = "0x1036ADE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06001197 RID: 4503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002A5")]
		private object Current
		{
			[Token(Token = "0x6001197")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001198 RID: 4504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001198")]
		[Address(RVA = "0x36B3C0", Offset = "0x36A7C0", VA = "0x1036B3C0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06001199 RID: 4505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002A6")]
		private object Current
		{
			[Token(Token = "0x6001199")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04001169 RID: 4457
		[Token(Token = "0x4001169")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x0400116A RID: 4458
		[Token(Token = "0x400116A")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x0400116B RID: 4459
		[Token(Token = "0x400116B")]
		[FieldOffset(Offset = "0x10")]
		public SampleMinigame <>4__this;

		// Token: 0x0400116C RID: 4460
		[Token(Token = "0x400116C")]
		[FieldOffset(Offset = "0x14")]
		private WaitForSeconds <dropWait>5__2;

		// Token: 0x0400116D RID: 4461
		[Token(Token = "0x400116D")]
		[FieldOffset(Offset = "0x18")]
		private WaitForFixedUpdate <wait>5__3;

		// Token: 0x0400116E RID: 4462
		[Token(Token = "0x400116E")]
		[FieldOffset(Offset = "0x1C")]
		private Vector3 <pos>5__4;

		// Token: 0x0400116F RID: 4463
		[Token(Token = "0x400116F")]
		[FieldOffset(Offset = "0x28")]
		private Vector2 <vPositionDelta>5__5;

		// Token: 0x04001170 RID: 4464
		[Token(Token = "0x4001170")]
		[FieldOffset(Offset = "0x30")]
		private Vector2 <vPosition>5__6;

		// Token: 0x04001171 RID: 4465
		[Token(Token = "0x4001171")]
		[FieldOffset(Offset = "0x38")]
		private int <step>5__7;

		// Token: 0x04001172 RID: 4466
		[Token(Token = "0x4001172")]
		[FieldOffset(Offset = "0x3C")]
		private float <start>5__8;

		// Token: 0x04001173 RID: 4467
		[Token(Token = "0x4001173")]
		[FieldOffset(Offset = "0x40")]
		private float <xTarg>5__9;

		// Token: 0x04001174 RID: 4468
		[Token(Token = "0x4001174")]
		[FieldOffset(Offset = "0x44")]
		private float <i>5__10;
	}
}
