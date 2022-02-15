using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000075 RID: 117
[Token(Token = "0x2000075")]
public class SpawnInMinigame : Minigame
{
	// Token: 0x0600030A RID: 778 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600030A")]
	[Address(RVA = "0x4A4480", Offset = "0x4A3880", VA = "0x104A4480", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x0600030B RID: 779 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600030B")]
	[Address(RVA = "0x4A4AC0", Offset = "0x4A3EC0", VA = "0x104A4AC0", Slot = "5")]
	public override void Close()
	{
	}

	// Token: 0x0600030C RID: 780 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600030C")]
	[Address(RVA = "0x4A4BA0", Offset = "0x4A3FA0", VA = "0x104A4BA0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE5390", Offset = "0xE4790")]
	private IEnumerator RunTimer()
	{
		return null;
	}

	// Token: 0x0600030D RID: 781 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600030D")]
	[Address(RVA = "0x4A4BF0", Offset = "0x4A3FF0", VA = "0x104A4BF0")]
	private void SpawnAt(Vector3 spawnAt)
	{
	}

	// Token: 0x0600030E RID: 782 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600030E")]
	[Address(RVA = "0x4A4D00", Offset = "0x4A4100", VA = "0x104A4D00")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE53E0", Offset = "0xE47E0")]
	public IEnumerator WaitForFinish()
	{
		return null;
	}

	// Token: 0x0600030F RID: 783 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600030F")]
	[Address(RVA = "0x3AC2A0", Offset = "0x3AB6A0", VA = "0x103AC2A0")]
	public SpawnInMinigame()
	{
	}

	// Token: 0x040002BC RID: 700
	[Token(Token = "0x40002BC")]
	[FieldOffset(Offset = "0x30")]
	public SpawnInMinigame.SpawnLocation[] Locations;

	// Token: 0x040002BD RID: 701
	[Token(Token = "0x40002BD")]
	[FieldOffset(Offset = "0x34")]
	public PassiveButton[] LocationButtons;

	// Token: 0x040002BE RID: 702
	[Token(Token = "0x40002BE")]
	[FieldOffset(Offset = "0x38")]
	public TextMeshPro Text;

	// Token: 0x040002BF RID: 703
	[Token(Token = "0x40002BF")]
	[FieldOffset(Offset = "0x3C")]
	public AudioClip DefaultRolloverSound;

	// Token: 0x040002C0 RID: 704
	[Token(Token = "0x40002C0")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xDD8F0", Offset = "0xDCCF0")]
	public UiElement DefaultButtonSelected;

	// Token: 0x040002C1 RID: 705
	[Token(Token = "0x40002C1")]
	[FieldOffset(Offset = "0x44")]
	public List<UiElement> ControllerSelectable;

	// Token: 0x040002C2 RID: 706
	[Token(Token = "0x40002C2")]
	[FieldOffset(Offset = "0x48")]
	private bool gotButton;

	// Token: 0x02000076 RID: 118
	[Token(Token = "0x2000076")]
	[Serializable]
	public struct SpawnLocation
	{
		// Token: 0x040002C3 RID: 707
		[Token(Token = "0x40002C3")]
		[FieldOffset(Offset = "0x0")]
		public StringNames Name;

		// Token: 0x040002C4 RID: 708
		[Token(Token = "0x40002C4")]
		[FieldOffset(Offset = "0x4")]
		public Sprite Image;

		// Token: 0x040002C5 RID: 709
		[Token(Token = "0x40002C5")]
		[FieldOffset(Offset = "0x8")]
		public AnimationClip Rollover;

		// Token: 0x040002C6 RID: 710
		[Token(Token = "0x40002C6")]
		[FieldOffset(Offset = "0xC")]
		public AudioClip RolloverSfx;

		// Token: 0x040002C7 RID: 711
		[Token(Token = "0x40002C7")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 Location;
	}

	// Token: 0x02000077 RID: 119
	[Token(Token = "0x2000077")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass8_0
	{
		// Token: 0x06000310 RID: 784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000310")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass8_0()
		{
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000311")]
		[Address(RVA = "0x371960", Offset = "0x370D60", VA = "0x10371960")]
		internal void <Begin>b__2()
		{
		}

		// Token: 0x040002C8 RID: 712
		[Token(Token = "0x40002C8")]
		[FieldOffset(Offset = "0x8")]
		public SpawnInMinigame.SpawnLocation pt;

		// Token: 0x040002C9 RID: 713
		[Token(Token = "0x40002C9")]
		[FieldOffset(Offset = "0x24")]
		public SpawnInMinigame <>4__this;
	}

	// Token: 0x02000078 RID: 120
	[Token(Token = "0x2000078")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000313 RID: 787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000313")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x06000314 RID: 788 RVA: 0x000028F8 File Offset: 0x00000AF8
		[Token(Token = "0x6000314")]
		[Address(RVA = "0x370100", Offset = "0x36F500", VA = "0x10370100")]
		internal float <Begin>b__8_0(SpawnInMinigame.SpawnLocation s)
		{
			return 0f;
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00002910 File Offset: 0x00000B10
		[Token(Token = "0x6000315")]
		[Address(RVA = "0x370110", Offset = "0x36F510", VA = "0x10370110")]
		internal float <Begin>b__8_1(SpawnInMinigame.SpawnLocation s)
		{
			return 0f;
		}

		// Token: 0x040002CA RID: 714
		[Token(Token = "0x40002CA")]
		[FieldOffset(Offset = "0x0")]
		public static readonly SpawnInMinigame.<>c <>9;

		// Token: 0x040002CB RID: 715
		[Token(Token = "0x40002CB")]
		[FieldOffset(Offset = "0x4")]
		public static Func<SpawnInMinigame.SpawnLocation, float> <>9__8_0;

		// Token: 0x040002CC RID: 716
		[Token(Token = "0x40002CC")]
		[FieldOffset(Offset = "0x8")]
		public static Func<SpawnInMinigame.SpawnLocation, float> <>9__8_1;
	}

	// Token: 0x02000079 RID: 121
	[Token(Token = "0x2000079")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <RunTimer>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000316 RID: 790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000316")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <RunTimer>d__10(int <>1__state)
		{
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000317")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00002928 File Offset: 0x00000B28
		[Token(Token = "0x6000318")]
		[Address(RVA = "0x36E020", Offset = "0x36D420", VA = "0x1036E020", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000319 RID: 793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000076")]
		private object Current
		{
			[Token(Token = "0x6000319")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600031A")]
		[Address(RVA = "0x36E220", Offset = "0x36D620", VA = "0x1036E220", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600031B RID: 795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000077")]
		private object Current
		{
			[Token(Token = "0x600031B")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040002CD RID: 717
		[Token(Token = "0x40002CD")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040002CE RID: 718
		[Token(Token = "0x40002CE")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040002CF RID: 719
		[Token(Token = "0x40002CF")]
		[FieldOffset(Offset = "0x10")]
		public SpawnInMinigame <>4__this;

		// Token: 0x040002D0 RID: 720
		[Token(Token = "0x40002D0")]
		[FieldOffset(Offset = "0x14")]
		private float <time>5__2;
	}

	// Token: 0x0200007A RID: 122
	[Token(Token = "0x200007A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <WaitForFinish>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600031C RID: 796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600031C")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <WaitForFinish>d__12(int <>1__state)
		{
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600031D")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00002940 File Offset: 0x00000B40
		[Token(Token = "0x600031E")]
		[Address(RVA = "0x3724D0", Offset = "0x3718D0", VA = "0x103724D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600031F RID: 799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000078")]
		private object Current
		{
			[Token(Token = "0x600031F")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000320")]
		[Address(RVA = "0x372530", Offset = "0x371930", VA = "0x10372530", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000321 RID: 801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000079")]
		private object Current
		{
			[Token(Token = "0x6000321")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040002D1 RID: 721
		[Token(Token = "0x40002D1")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040002D2 RID: 722
		[Token(Token = "0x40002D2")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040002D3 RID: 723
		[Token(Token = "0x40002D3")]
		[FieldOffset(Offset = "0x10")]
		public SpawnInMinigame <>4__this;
	}
}
