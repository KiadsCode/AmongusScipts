using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000427 RID: 1063
[Token(Token = "0x2000427")]
[Attribute(Name = "DefaultMemberAttribute", RVA = "0xDF8F0", Offset = "0xDECF0")]
public class SimonSaysGame : Minigame
{
	// Token: 0x17000328 RID: 808
	// (get) Token: 0x06001660 RID: 5728 RVA: 0x00007110 File Offset: 0x00005310
	// (set) Token: 0x06001661 RID: 5729 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000328")]
	private int IndexCount
	{
		[Token(Token = "0x6001660")]
		[Address(RVA = "0x49B280", Offset = "0x49A680", VA = "0x1049B280")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001661")]
		[Address(RVA = "0x49B300", Offset = "0x49A700", VA = "0x1049B300")]
		set
		{
		}
	}

	// Token: 0x17000329 RID: 809
	// (get) Token: 0x06001662 RID: 5730 RVA: 0x00007128 File Offset: 0x00005328
	// (set) Token: 0x06001663 RID: 5731 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000329")]
	private byte Item
	{
		[Token(Token = "0x6001662")]
		[Address(RVA = "0x49B2C0", Offset = "0x49A6C0", VA = "0x1049B2C0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001663")]
		[Address(RVA = "0x49B340", Offset = "0x49A740", VA = "0x1049B340")]
		set
		{
		}
	}

	// Token: 0x06001664 RID: 5732 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001664")]
	[Address(RVA = "0x49A9E0", Offset = "0x499DE0", VA = "0x1049A9E0", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x06001665 RID: 5733 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001665")]
	[Address(RVA = "0x49ACC0", Offset = "0x49A0C0", VA = "0x1049ACC0")]
	public void HitButton(int bIdx)
	{
	}

	// Token: 0x06001666 RID: 5734 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001666")]
	[Address(RVA = "0x49AC00", Offset = "0x49A000", VA = "0x1049AC00")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDFAC0", Offset = "0xDEEC0")]
	private IEnumerator CoRun()
	{
		return null;
	}

	// Token: 0x06001667 RID: 5735 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001667")]
	[Address(RVA = "0x49A960", Offset = "0x499D60", VA = "0x1049A960")]
	private void AddIndex(int idxToAdd)
	{
	}

	// Token: 0x06001668 RID: 5736 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001668")]
	[Address(RVA = "0x49AB60", Offset = "0x499F60", VA = "0x1049AB60")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDFB10", Offset = "0xDEF10")]
	private IEnumerator CoAnimateNewLeftSide()
	{
		return null;
	}

	// Token: 0x06001669 RID: 5737 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001669")]
	[Address(RVA = "0x49ABB0", Offset = "0x499FB0", VA = "0x1049ABB0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDFB60", Offset = "0xDEF60")]
	private IEnumerator CoAnimateOldLeftSide()
	{
		return null;
	}

	// Token: 0x0600166A RID: 5738 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600166A")]
	[Address(RVA = "0x49AC50", Offset = "0x49A050", VA = "0x1049AC50")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDFC00", Offset = "0xDF000")]
	private IEnumerator FlashButton(int id, SpriteRenderer butt, float flashTime)
	{
		return null;
	}

	// Token: 0x0600166B RID: 5739 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600166B")]
	[Address(RVA = "0x49B0A0", Offset = "0x49A4A0", VA = "0x1049B0A0")]
	private void SetLights(SpriteRenderer[] lights, int num)
	{
	}

	// Token: 0x0600166C RID: 5740 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600166C")]
	[Address(RVA = "0x49AF70", Offset = "0x49A370", VA = "0x1049AF70")]
	private void SetAllColor(Color color)
	{
	}

	// Token: 0x0600166D RID: 5741 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600166D")]
	[Address(RVA = "0x49B050", Offset = "0x49A450", VA = "0x1049B050")]
	private void SetButtonColor(int i, Color color)
	{
	}

	// Token: 0x0600166E RID: 5742 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600166E")]
	[Address(RVA = "0x49B100", Offset = "0x49A500", VA = "0x1049B100")]
	public SimonSaysGame()
	{
	}

	// Token: 0x040016C6 RID: 5830
	[Token(Token = "0x40016C6")]
	[FieldOffset(Offset = "0x30")]
	private Queue<int> operations;

	// Token: 0x040016C7 RID: 5831
	[Token(Token = "0x40016C7")]
	private const int FlashOp = 256;

	// Token: 0x040016C8 RID: 5832
	[Token(Token = "0x40016C8")]
	private const int AnimateOp = 128;

	// Token: 0x040016C9 RID: 5833
	[Token(Token = "0x40016C9")]
	private const int ReAnimateOp = 32;

	// Token: 0x040016CA RID: 5834
	[Token(Token = "0x40016CA")]
	private const int FailOp = 64;

	// Token: 0x040016CB RID: 5835
	[Token(Token = "0x40016CB")]
	[FieldOffset(Offset = "0x34")]
	private Color gray;

	// Token: 0x040016CC RID: 5836
	[Token(Token = "0x40016CC")]
	[FieldOffset(Offset = "0x44")]
	private Color blue;

	// Token: 0x040016CD RID: 5837
	[Token(Token = "0x40016CD")]
	[FieldOffset(Offset = "0x54")]
	private Color red;

	// Token: 0x040016CE RID: 5838
	[Token(Token = "0x40016CE")]
	[FieldOffset(Offset = "0x64")]
	private Color green;

	// Token: 0x040016CF RID: 5839
	[Token(Token = "0x40016CF")]
	[FieldOffset(Offset = "0x74")]
	public SpriteRenderer[] LeftSide;

	// Token: 0x040016D0 RID: 5840
	[Token(Token = "0x40016D0")]
	[FieldOffset(Offset = "0x78")]
	public SpriteRenderer[] Buttons;

	// Token: 0x040016D1 RID: 5841
	[Token(Token = "0x40016D1")]
	[FieldOffset(Offset = "0x7C")]
	public SpriteRenderer[] LeftLights;

	// Token: 0x040016D2 RID: 5842
	[Token(Token = "0x40016D2")]
	[FieldOffset(Offset = "0x80")]
	public SpriteRenderer[] RightLights;

	// Token: 0x040016D3 RID: 5843
	[Token(Token = "0x40016D3")]
	[FieldOffset(Offset = "0x84")]
	private float flashTime;

	// Token: 0x040016D4 RID: 5844
	[Token(Token = "0x40016D4")]
	[FieldOffset(Offset = "0x88")]
	private float userButtonFlashTime;

	// Token: 0x040016D5 RID: 5845
	[Token(Token = "0x40016D5")]
	[FieldOffset(Offset = "0x8C")]
	public AudioClip ButtonPressSound;

	// Token: 0x040016D6 RID: 5846
	[Token(Token = "0x40016D6")]
	[FieldOffset(Offset = "0x90")]
	public AudioClip FailSound;

	// Token: 0x040016D7 RID: 5847
	[Token(Token = "0x40016D7")]
	[FieldOffset(Offset = "0x94")]
	public Transform selectorHighlightObject;

	// Token: 0x040016D8 RID: 5848
	[Token(Token = "0x40016D8")]
	[FieldOffset(Offset = "0x98")]
	public float diagonalRoundingWidth;

	// Token: 0x040016D9 RID: 5849
	[Token(Token = "0x40016D9")]
	[FieldOffset(Offset = "0x9C")]
	public float inputAngleIndex;

	// Token: 0x040016DA RID: 5850
	[Token(Token = "0x40016DA")]
	[FieldOffset(Offset = "0xA0")]
	public int roundDownIndex;

	// Token: 0x040016DB RID: 5851
	[Token(Token = "0x40016DB")]
	[FieldOffset(Offset = "0xA4")]
	public int roundUpIndex;

	// Token: 0x040016DC RID: 5852
	[Token(Token = "0x40016DC")]
	[FieldOffset(Offset = "0xA8")]
	private int[] orderedButtonIndices;

	// Token: 0x02000428 RID: 1064
	[Token(Token = "0x2000428")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoRun>d__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600166F RID: 5743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600166F")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoRun>d__31(int <>1__state)
		{
		}

		// Token: 0x06001670 RID: 5744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001670")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001671 RID: 5745 RVA: 0x00007140 File Offset: 0x00005340
		[Token(Token = "0x6001671")]
		[Address(RVA = "0x368500", Offset = "0x367900", VA = "0x10368500", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06001672 RID: 5746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700032A")]
		private object Current
		{
			[Token(Token = "0x6001672")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001673 RID: 5747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001673")]
		[Address(RVA = "0x368D30", Offset = "0x368130", VA = "0x10368D30", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06001674 RID: 5748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700032B")]
		private object Current
		{
			[Token(Token = "0x6001674")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040016DD RID: 5853
		[Token(Token = "0x40016DD")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040016DE RID: 5854
		[Token(Token = "0x40016DE")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040016DF RID: 5855
		[Token(Token = "0x40016DF")]
		[FieldOffset(Offset = "0x10")]
		public SimonSaysGame <>4__this;
	}

	// Token: 0x02000429 RID: 1065
	[Token(Token = "0x2000429")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoAnimateNewLeftSide>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001675 RID: 5749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001675")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoAnimateNewLeftSide>d__33(int <>1__state)
		{
		}

		// Token: 0x06001676 RID: 5750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001676")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001677 RID: 5751 RVA: 0x00007158 File Offset: 0x00005358
		[Token(Token = "0x6001677")]
		[Address(RVA = "0x367180", Offset = "0x366580", VA = "0x10367180", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06001678 RID: 5752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700032C")]
		private object Current
		{
			[Token(Token = "0x6001678")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001679 RID: 5753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001679")]
		[Address(RVA = "0x3672C0", Offset = "0x3666C0", VA = "0x103672C0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x0600167A RID: 5754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700032D")]
		private object Current
		{
			[Token(Token = "0x600167A")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040016E0 RID: 5856
		[Token(Token = "0x40016E0")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040016E1 RID: 5857
		[Token(Token = "0x40016E1")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040016E2 RID: 5858
		[Token(Token = "0x40016E2")]
		[FieldOffset(Offset = "0x10")]
		public SimonSaysGame <>4__this;
	}

	// Token: 0x0200042A RID: 1066
	[Token(Token = "0x200042A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoAnimateOldLeftSide>d__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600167B RID: 5755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600167B")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoAnimateOldLeftSide>d__34(int <>1__state)
		{
		}

		// Token: 0x0600167C RID: 5756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600167C")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600167D RID: 5757 RVA: 0x00007170 File Offset: 0x00005370
		[Token(Token = "0x600167D")]
		[Address(RVA = "0x3672F0", Offset = "0x3666F0", VA = "0x103672F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x0600167E RID: 5758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700032E")]
		private object Current
		{
			[Token(Token = "0x600167E")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600167F RID: 5759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600167F")]
		[Address(RVA = "0x3674F0", Offset = "0x3668F0", VA = "0x103674F0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06001680 RID: 5760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700032F")]
		private object Current
		{
			[Token(Token = "0x6001680")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040016E3 RID: 5859
		[Token(Token = "0x40016E3")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040016E4 RID: 5860
		[Token(Token = "0x40016E4")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040016E5 RID: 5861
		[Token(Token = "0x40016E5")]
		[FieldOffset(Offset = "0x10")]
		public SimonSaysGame <>4__this;

		// Token: 0x040016E6 RID: 5862
		[Token(Token = "0x40016E6")]
		[FieldOffset(Offset = "0x14")]
		private int <i>5__2;
	}

	// Token: 0x0200042B RID: 1067
	[Token(Token = "0x200042B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <FlashButton>d__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001681 RID: 5761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001681")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <FlashButton>d__35(int <>1__state)
		{
		}

		// Token: 0x06001682 RID: 5762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001682")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001683 RID: 5763 RVA: 0x00007188 File Offset: 0x00005388
		[Token(Token = "0x6001683")]
		[Address(RVA = "0x36C990", Offset = "0x36BD90", VA = "0x1036C990", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06001684 RID: 5764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000330")]
		private object Current
		{
			[Token(Token = "0x6001684")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001685 RID: 5765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001685")]
		[Address(RVA = "0x36CB90", Offset = "0x36BF90", VA = "0x1036CB90", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06001686 RID: 5766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000331")]
		private object Current
		{
			[Token(Token = "0x6001686")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040016E7 RID: 5863
		[Token(Token = "0x40016E7")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040016E8 RID: 5864
		[Token(Token = "0x40016E8")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040016E9 RID: 5865
		[Token(Token = "0x40016E9")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		// Token: 0x040016EA RID: 5866
		[Token(Token = "0x40016EA")]
		[FieldOffset(Offset = "0x14")]
		public SimonSaysGame <>4__this;

		// Token: 0x040016EB RID: 5867
		[Token(Token = "0x40016EB")]
		[FieldOffset(Offset = "0x18")]
		public SpriteRenderer butt;

		// Token: 0x040016EC RID: 5868
		[Token(Token = "0x40016EC")]
		[FieldOffset(Offset = "0x1C")]
		public float flashTime;

		// Token: 0x040016ED RID: 5869
		[Token(Token = "0x40016ED")]
		[FieldOffset(Offset = "0x20")]
		private Color <c>5__2;
	}
}
