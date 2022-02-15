using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020001C8 RID: 456
[Token(Token = "0x20001C8")]
public class BanButton : MonoBehaviour
{
	// Token: 0x17000196 RID: 406
	// (get) Token: 0x06000A4C RID: 2636 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000A4D RID: 2637 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000196")]
	public BanMenu Parent
	{
		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0x273ED0", Offset = "0x2732D0", VA = "0x10273ED0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		set
		{
		}
	}

	// Token: 0x06000A4E RID: 2638 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A4E")]
	[Address(RVA = "0x54FD00", Offset = "0x54F100", VA = "0x1054FD00")]
	public void Start()
	{
	}

	// Token: 0x06000A4F RID: 2639 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A4F")]
	[Address(RVA = "0x54FBF0", Offset = "0x54EFF0", VA = "0x1054FBF0")]
	public void Select()
	{
	}

	// Token: 0x06000A50 RID: 2640 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A50")]
	[Address(RVA = "0x54FD20", Offset = "0x54F120", VA = "0x1054FD20")]
	public void Unselect()
	{
	}

	// Token: 0x06000A51 RID: 2641 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A51")]
	[Address(RVA = "0x54FC80", Offset = "0x54F080", VA = "0x1054FC80")]
	public void SetVotes(int newVotes)
	{
	}

	// Token: 0x06000A52 RID: 2642 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A52")]
	[Address(RVA = "0x54FB90", Offset = "0x54EF90", VA = "0x1054FB90")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE10A0", Offset = "0xE04A0")]
	private IEnumerator CoSetVotes(int oldNum, int newNum)
	{
		return null;
	}

	// Token: 0x06000A53 RID: 2643 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A53")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public BanButton()
	{
	}

	// Token: 0x04000A69 RID: 2665
	[Token(Token = "0x4000A69")]
	[FieldOffset(Offset = "0xC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private BanMenu <Parent>k__BackingField;

	// Token: 0x04000A6A RID: 2666
	[Token(Token = "0x4000A6A")]
	[FieldOffset(Offset = "0x10")]
	public TextMeshPro NameText;

	// Token: 0x04000A6B RID: 2667
	[Token(Token = "0x4000A6B")]
	[FieldOffset(Offset = "0x14")]
	public SpriteRenderer Background;

	// Token: 0x04000A6C RID: 2668
	[Token(Token = "0x4000A6C")]
	[FieldOffset(Offset = "0x18")]
	public int TargetClientId;

	// Token: 0x04000A6D RID: 2669
	[Token(Token = "0x4000A6D")]
	[FieldOffset(Offset = "0x1C")]
	public int numVotes;

	// Token: 0x020001C9 RID: 457
	[Token(Token = "0x20001C9")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoSetVotes>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000A54 RID: 2644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A54")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoSetVotes>d__12(int <>1__state)
		{
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A55")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x00004878 File Offset: 0x00002A78
		[Token(Token = "0x6000A56")]
		[Address(RVA = "0x3C5CD0", Offset = "0x3C50D0", VA = "0x103C5CD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000A57 RID: 2647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000197")]
		private object Current
		{
			[Token(Token = "0x6000A57")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A58")]
		[Address(RVA = "0x3C5E30", Offset = "0x3C5230", VA = "0x103C5E30", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000A59 RID: 2649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000198")]
		private object Current
		{
			[Token(Token = "0x6000A59")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000A6E RID: 2670
		[Token(Token = "0x4000A6E")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000A6F RID: 2671
		[Token(Token = "0x4000A6F")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000A70 RID: 2672
		[Token(Token = "0x4000A70")]
		[FieldOffset(Offset = "0x10")]
		public int oldNum;

		// Token: 0x04000A71 RID: 2673
		[Token(Token = "0x4000A71")]
		[FieldOffset(Offset = "0x14")]
		public int newNum;

		// Token: 0x04000A72 RID: 2674
		[Token(Token = "0x4000A72")]
		[FieldOffset(Offset = "0x18")]
		public BanButton <>4__this;

		// Token: 0x04000A73 RID: 2675
		[Token(Token = "0x4000A73")]
		[FieldOffset(Offset = "0x1C")]
		private float <end>5__2;

		// Token: 0x04000A74 RID: 2676
		[Token(Token = "0x4000A74")]
		[FieldOffset(Offset = "0x20")]
		private float <timer>5__3;
	}
}
