using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x0200028F RID: 655
[Token(Token = "0x200028F")]
public class KeypadGame : Minigame
{
	// Token: 0x06000E7F RID: 3711 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E7F")]
	[Address(RVA = "0x6D65D0", Offset = "0x6D59D0", VA = "0x106D65D0")]
	private void OnDisable()
	{
	}

	// Token: 0x06000E80 RID: 3712 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E80")]
	[Address(RVA = "0x6D6150", Offset = "0x6D5550", VA = "0x106D6150", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x06000E81 RID: 3713 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E81")]
	[Address(RVA = "0x6D6470", Offset = "0x6D5870", VA = "0x106D6470")]
	public void ClickNumber(int i)
	{
	}

	// Token: 0x06000E82 RID: 3714 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E82")]
	[Address(RVA = "0x6D63B0", Offset = "0x6D57B0", VA = "0x106D63B0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE4FD0", Offset = "0xE43D0")]
	private IEnumerator BlinkAccept()
	{
		return null;
	}

	// Token: 0x06000E83 RID: 3715 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E83")]
	[Address(RVA = "0x6D6400", Offset = "0x6D5800", VA = "0x106D6400")]
	public void ClearEntry()
	{
	}

	// Token: 0x06000E84 RID: 3716 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E84")]
	[Address(RVA = "0x6D6560", Offset = "0x6D5960", VA = "0x106D6560")]
	public void Enter()
	{
	}

	// Token: 0x06000E85 RID: 3717 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E85")]
	[Address(RVA = "0x6D6100", Offset = "0x6D5500", VA = "0x106D6100")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE5020", Offset = "0xE4420")]
	private IEnumerator Animate()
	{
		return null;
	}

	// Token: 0x06000E86 RID: 3718 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E86")]
	[Address(RVA = "0x6D6640", Offset = "0x6D5A40", VA = "0x106D6640")]
	public KeypadGame()
	{
	}

	// Token: 0x04000E90 RID: 3728
	[Token(Token = "0x4000E90")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshPro TargetText;

	// Token: 0x04000E91 RID: 3729
	[Token(Token = "0x4000E91")]
	[FieldOffset(Offset = "0x34")]
	public TextMeshPro NumberText;

	// Token: 0x04000E92 RID: 3730
	[Token(Token = "0x4000E92")]
	[FieldOffset(Offset = "0x38")]
	public int number;

	// Token: 0x04000E93 RID: 3731
	[Token(Token = "0x4000E93")]
	[FieldOffset(Offset = "0x3C")]
	public string numString;

	// Token: 0x04000E94 RID: 3732
	[Token(Token = "0x4000E94")]
	[FieldOffset(Offset = "0x40")]
	private bool animating;

	// Token: 0x04000E95 RID: 3733
	[Token(Token = "0x4000E95")]
	[FieldOffset(Offset = "0x44")]
	public SpriteRenderer AcceptButton;

	// Token: 0x04000E96 RID: 3734
	[Token(Token = "0x4000E96")]
	[FieldOffset(Offset = "0x48")]
	private LifeSuppSystemType system;

	// Token: 0x04000E97 RID: 3735
	[Token(Token = "0x4000E97")]
	[FieldOffset(Offset = "0x4C")]
	private NoOxyTask oxyTask;

	// Token: 0x04000E98 RID: 3736
	[Token(Token = "0x4000E98")]
	[FieldOffset(Offset = "0x50")]
	private bool done;

	// Token: 0x04000E99 RID: 3737
	[Token(Token = "0x4000E99")]
	[FieldOffset(Offset = "0x54")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xDD8F0", Offset = "0xDCCF0")]
	public UiElement BackButton;

	// Token: 0x04000E9A RID: 3738
	[Token(Token = "0x4000E9A")]
	[FieldOffset(Offset = "0x58")]
	public UiElement DefaultButtonSelected;

	// Token: 0x04000E9B RID: 3739
	[Token(Token = "0x4000E9B")]
	[FieldOffset(Offset = "0x5C")]
	public List<UiElement> ControllerSelectable;

	// Token: 0x02000290 RID: 656
	[Token(Token = "0x2000290")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <BlinkAccept>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000E87 RID: 3719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E87")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <BlinkAccept>d__15(int <>1__state)
		{
		}

		// Token: 0x06000E88 RID: 3720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E88")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000E89 RID: 3721 RVA: 0x000058F8 File Offset: 0x00003AF8
		[Token(Token = "0x6000E89")]
		[Address(RVA = "0x5A8A40", Offset = "0x5A7E40", VA = "0x105A8A40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000E8A RID: 3722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000233")]
		private object Current
		{
			[Token(Token = "0x6000E8A")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000E8B RID: 3723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E8B")]
		[Address(RVA = "0x5A8B70", Offset = "0x5A7F70", VA = "0x105A8B70", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000E8C RID: 3724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000234")]
		private object Current
		{
			[Token(Token = "0x6000E8C")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000E9C RID: 3740
		[Token(Token = "0x4000E9C")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000E9D RID: 3741
		[Token(Token = "0x4000E9D")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000E9E RID: 3742
		[Token(Token = "0x4000E9E")]
		[FieldOffset(Offset = "0x10")]
		public KeypadGame <>4__this;

		// Token: 0x04000E9F RID: 3743
		[Token(Token = "0x4000E9F")]
		[FieldOffset(Offset = "0x14")]
		private int <i>5__2;
	}

	// Token: 0x02000291 RID: 657
	[Token(Token = "0x2000291")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <Animate>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000E8D RID: 3725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E8D")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <Animate>d__18(int <>1__state)
		{
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E8E")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x00005910 File Offset: 0x00003B10
		[Token(Token = "0x6000E8F")]
		[Address(RVA = "0x5A84E0", Offset = "0x5A78E0", VA = "0x105A84E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000E90 RID: 3728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000235")]
		private object Current
		{
			[Token(Token = "0x6000E90")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000E91 RID: 3729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E91")]
		[Address(RVA = "0x5A8A10", Offset = "0x5A7E10", VA = "0x105A8A10", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000E92 RID: 3730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000236")]
		private object Current
		{
			[Token(Token = "0x6000E92")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000EA0 RID: 3744
		[Token(Token = "0x4000EA0")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000EA1 RID: 3745
		[Token(Token = "0x4000EA1")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000EA2 RID: 3746
		[Token(Token = "0x4000EA2")]
		[FieldOffset(Offset = "0x10")]
		public KeypadGame <>4__this;

		// Token: 0x04000EA3 RID: 3747
		[Token(Token = "0x4000EA3")]
		[FieldOffset(Offset = "0x14")]
		private WaitForSeconds <wait>5__2;

		// Token: 0x04000EA4 RID: 3748
		[Token(Token = "0x4000EA4")]
		[FieldOffset(Offset = "0x18")]
		private string <okStr>5__3;
	}
}
