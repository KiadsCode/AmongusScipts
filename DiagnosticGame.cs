using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x0200028C RID: 652
[Token(Token = "0x200028C")]
public class DiagnosticGame : Minigame
{
	// Token: 0x06000E6D RID: 3693 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E6D")]
	[Address(RVA = "0x5C5E60", Offset = "0x5C5260", VA = "0x105C5E60")]
	private void OnDisable()
	{
	}

	// Token: 0x06000E6E RID: 3694 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E6E")]
	[Address(RVA = "0x5C5CC0", Offset = "0x5C50C0", VA = "0x105C5CC0", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x06000E6F RID: 3695 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E6F")]
	[Address(RVA = "0x5C5E10", Offset = "0x5C5210", VA = "0x105C5E10")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE4EE0", Offset = "0xE42E0")]
	private IEnumerator BlinkButton()
	{
		return null;
	}

	// Token: 0x06000E70 RID: 3696 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E70")]
	[Address(RVA = "0x5C5ED0", Offset = "0x5C52D0", VA = "0x105C5ED0")]
	public void PickAnomaly(int num)
	{
	}

	// Token: 0x06000E71 RID: 3697 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E71")]
	[Address(RVA = "0x5C6010", Offset = "0x5C5410", VA = "0x105C6010")]
	public void StartDiagnostic()
	{
	}

	// Token: 0x06000E72 RID: 3698 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E72")]
	[Address(RVA = "0x5C61B0", Offset = "0x5C55B0", VA = "0x105C61B0")]
	public void Update()
	{
	}

	// Token: 0x06000E73 RID: 3699 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E73")]
	[Address(RVA = "0x5C66A0", Offset = "0x5C5AA0", VA = "0x105C66A0")]
	public DiagnosticGame()
	{
	}

	// Token: 0x06000E74 RID: 3700 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E74")]
	[Address(RVA = "0x5C6160", Offset = "0x5C5560", VA = "0x105C6160")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private void <Update>b__19_2(SpriteRenderer f)
	{
	}

	// Token: 0x04000E7C RID: 3708
	[Token(Token = "0x4000E7C")]
	[FieldOffset(Offset = "0x30")]
	public VerticalGauge Gauge;

	// Token: 0x04000E7D RID: 3709
	[Token(Token = "0x4000E7D")]
	[FieldOffset(Offset = "0x34")]
	public SpriteRenderer StartButton;

	// Token: 0x04000E7E RID: 3710
	[Token(Token = "0x4000E7E")]
	[FieldOffset(Offset = "0x38")]
	public float TimePerStep;

	// Token: 0x04000E7F RID: 3711
	[Token(Token = "0x4000E7F")]
	[FieldOffset(Offset = "0x3C")]
	public TextMeshPro Text;

	// Token: 0x04000E80 RID: 3712
	[Token(Token = "0x4000E80")]
	[FieldOffset(Offset = "0x40")]
	private int TargetNum;

	// Token: 0x04000E81 RID: 3713
	[Token(Token = "0x4000E81")]
	[FieldOffset(Offset = "0x44")]
	public SpriteRenderer[] Targets;

	// Token: 0x04000E82 RID: 3714
	[Token(Token = "0x4000E82")]
	[FieldOffset(Offset = "0x48")]
	private Color goodBarColor;

	// Token: 0x04000E83 RID: 3715
	[Token(Token = "0x4000E83")]
	[FieldOffset(Offset = "0x58")]
	public AudioClip StartSound;

	// Token: 0x04000E84 RID: 3716
	[Token(Token = "0x4000E84")]
	[FieldOffset(Offset = "0x5C")]
	public AudioClip CorrectSound;

	// Token: 0x04000E85 RID: 3717
	[Token(Token = "0x4000E85")]
	[FieldOffset(Offset = "0x60")]
	public AudioClip TickSound;

	// Token: 0x04000E86 RID: 3718
	[Token(Token = "0x4000E86")]
	[FieldOffset(Offset = "0x64")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xDD8F0", Offset = "0xDCCF0")]
	public UiElement BackButton;

	// Token: 0x04000E87 RID: 3719
	[Token(Token = "0x4000E87")]
	[FieldOffset(Offset = "0x68")]
	public UiElement DefaultButtonSelected;

	// Token: 0x04000E88 RID: 3720
	[Token(Token = "0x4000E88")]
	[FieldOffset(Offset = "0x6C")]
	public List<UiElement> ControllerSelectable;

	// Token: 0x04000E89 RID: 3721
	[Token(Token = "0x4000E89")]
	[FieldOffset(Offset = "0x70")]
	private int lastPercent;

	// Token: 0x0200028D RID: 653
	[Token(Token = "0x200028D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <BlinkButton>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000E75 RID: 3701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E75")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <BlinkButton>d__15(int <>1__state)
		{
		}

		// Token: 0x06000E76 RID: 3702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E76")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000E77 RID: 3703 RVA: 0x000058E0 File Offset: 0x00003AE0
		[Token(Token = "0x6000E77")]
		[Address(RVA = "0x7834D0", Offset = "0x7828D0", VA = "0x107834D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000E78 RID: 3704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000231")]
		private object Current
		{
			[Token(Token = "0x6000E78")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000E79 RID: 3705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E79")]
		[Address(RVA = "0x783620", Offset = "0x782A20", VA = "0x10783620", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000E7A RID: 3706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000232")]
		private object Current
		{
			[Token(Token = "0x6000E7A")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000E8A RID: 3722
		[Token(Token = "0x4000E8A")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000E8B RID: 3723
		[Token(Token = "0x4000E8B")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000E8C RID: 3724
		[Token(Token = "0x4000E8C")]
		[FieldOffset(Offset = "0x10")]
		public DiagnosticGame <>4__this;
	}

	// Token: 0x0200028E RID: 654
	[Token(Token = "0x200028E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000E7C RID: 3708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E7C")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x06000E7D RID: 3709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E7D")]
		[Address(RVA = "0x78D5B0", Offset = "0x78C9B0", VA = "0x1078D5B0")]
		internal void <Update>b__19_0(SpriteRenderer f)
		{
		}

		// Token: 0x06000E7E RID: 3710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E7E")]
		[Address(RVA = "0x78D5B0", Offset = "0x78C9B0", VA = "0x1078D5B0")]
		internal void <Update>b__19_1(SpriteRenderer f)
		{
		}

		// Token: 0x04000E8D RID: 3725
		[Token(Token = "0x4000E8D")]
		[FieldOffset(Offset = "0x0")]
		public static readonly DiagnosticGame.<>c <>9;

		// Token: 0x04000E8E RID: 3726
		[Token(Token = "0x4000E8E")]
		[FieldOffset(Offset = "0x4")]
		public static Action<SpriteRenderer> <>9__19_0;

		// Token: 0x04000E8F RID: 3727
		[Token(Token = "0x4000E8F")]
		[FieldOffset(Offset = "0x8")]
		public static Action<SpriteRenderer> <>9__19_1;
	}
}
