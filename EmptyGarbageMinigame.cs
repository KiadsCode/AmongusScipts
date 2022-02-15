using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004DB RID: 1243
[Token(Token = "0x20004DB")]
public class EmptyGarbageMinigame : Minigame
{
	// Token: 0x06001A8D RID: 6797 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A8D")]
	[Address(RVA = "0x477C80", Offset = "0x477080", VA = "0x10477C80", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x06001A8E RID: 6798 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A8E")]
	[Address(RVA = "0x478340", Offset = "0x477740", VA = "0x10478340")]
	private void StopCoroutines()
	{
	}

	// Token: 0x06001A8F RID: 6799 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A8F")]
	[Address(RVA = "0x478390", Offset = "0x477790", VA = "0x10478390")]
	public void Update()
	{
	}

	// Token: 0x06001A90 RID: 6800 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A90")]
	[Address(RVA = "0x4782F0", Offset = "0x4776F0", VA = "0x104782F0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE0CD0", Offset = "0xE00D0")]
	private IEnumerator PopObjects()
	{
		return null;
	}

	// Token: 0x06001A91 RID: 6801 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A91")]
	[Address(RVA = "0x477C30", Offset = "0x477030", VA = "0x10477C30")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE0D20", Offset = "0xE0120")]
	private IEnumerator AnimateObjects()
	{
		return null;
	}

	// Token: 0x06001A92 RID: 6802 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A92")]
	[Address(RVA = "0x478160", Offset = "0x477560", VA = "0x10478160", Slot = "5")]
	public override void Close()
	{
	}

	// Token: 0x06001A93 RID: 6803 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A93")]
	[Address(RVA = "0x478F30", Offset = "0x478330", VA = "0x10478F30")]
	public EmptyGarbageMinigame()
	{
	}

	// Token: 0x04001AA0 RID: 6816
	[Token(Token = "0x4001AA0")]
	private const float GrinderVolume = 0.8f;

	// Token: 0x04001AA1 RID: 6817
	[Token(Token = "0x4001AA1")]
	[FieldOffset(Offset = "0x30")]
	public FloatRange HandleRange;

	// Token: 0x04001AA2 RID: 6818
	[Token(Token = "0x4001AA2")]
	[FieldOffset(Offset = "0x34")]
	public Vector2Range SpawnRange;

	// Token: 0x04001AA3 RID: 6819
	[Token(Token = "0x4001AA3")]
	[FieldOffset(Offset = "0x44")]
	public Collider2D Blocker;

	// Token: 0x04001AA4 RID: 6820
	[Token(Token = "0x4001AA4")]
	[FieldOffset(Offset = "0x48")]
	public AreaEffector2D Popper;

	// Token: 0x04001AA5 RID: 6821
	[Token(Token = "0x4001AA5")]
	[FieldOffset(Offset = "0x4C")]
	public Collider2D Handle;

	// Token: 0x04001AA6 RID: 6822
	[Token(Token = "0x4001AA6")]
	[FieldOffset(Offset = "0x50")]
	public SpriteRenderer Bars;

	// Token: 0x04001AA7 RID: 6823
	[Token(Token = "0x4001AA7")]
	[FieldOffset(Offset = "0x54")]
	public Transform VibratePivot;

	// Token: 0x04001AA8 RID: 6824
	[Token(Token = "0x4001AA8")]
	[FieldOffset(Offset = "0x58")]
	private Controller controller;

	// Token: 0x04001AA9 RID: 6825
	[Token(Token = "0x4001AA9")]
	[FieldOffset(Offset = "0x5C")]
	private bool finished;

	// Token: 0x04001AAA RID: 6826
	[Token(Token = "0x4001AAA")]
	[FieldOffset(Offset = "0x60")]
	public int NumObjects;

	// Token: 0x04001AAB RID: 6827
	[Token(Token = "0x4001AAB")]
	[FieldOffset(Offset = "0x64")]
	private SpriteRenderer[] Objects;

	// Token: 0x04001AAC RID: 6828
	[Token(Token = "0x4001AAC")]
	[FieldOffset(Offset = "0x68")]
	public SpriteRenderer[] GarbagePrefabs;

	// Token: 0x04001AAD RID: 6829
	[Token(Token = "0x4001AAD")]
	[FieldOffset(Offset = "0x6C")]
	public SpriteRenderer[] LeafPrefabs;

	// Token: 0x04001AAE RID: 6830
	[Token(Token = "0x4001AAE")]
	[FieldOffset(Offset = "0x70")]
	public SpriteRenderer[] SpecialObjectPrefabs;

	// Token: 0x04001AAF RID: 6831
	[Token(Token = "0x4001AAF")]
	[FieldOffset(Offset = "0x74")]
	public AudioClip LeverDown;

	// Token: 0x04001AB0 RID: 6832
	[Token(Token = "0x4001AB0")]
	[FieldOffset(Offset = "0x78")]
	public AudioClip LeverUp;

	// Token: 0x04001AB1 RID: 6833
	[Token(Token = "0x4001AB1")]
	[FieldOffset(Offset = "0x7C")]
	public AudioClip GrinderStart;

	// Token: 0x04001AB2 RID: 6834
	[Token(Token = "0x4001AB2")]
	[FieldOffset(Offset = "0x80")]
	public AudioClip GrinderLoop;

	// Token: 0x04001AB3 RID: 6835
	[Token(Token = "0x4001AB3")]
	[FieldOffset(Offset = "0x84")]
	public AudioClip GrinderEnd;

	// Token: 0x04001AB4 RID: 6836
	[Token(Token = "0x4001AB4")]
	[FieldOffset(Offset = "0x88")]
	private TouchpadBehavior touchpad;

	// Token: 0x04001AB5 RID: 6837
	[Token(Token = "0x4001AB5")]
	[FieldOffset(Offset = "0x8C")]
	private bool hadInput;

	// Token: 0x04001AB6 RID: 6838
	[Token(Token = "0x4001AB6")]
	[FieldOffset(Offset = "0x90")]
	private float leverInput;

	// Token: 0x04001AB7 RID: 6839
	[Token(Token = "0x4001AB7")]
	[FieldOffset(Offset = "0x94")]
	private Coroutine popCoroutine;

	// Token: 0x04001AB8 RID: 6840
	[Token(Token = "0x4001AB8")]
	[FieldOffset(Offset = "0x98")]
	private Coroutine animateCoroutine;

	// Token: 0x020004DC RID: 1244
	[Token(Token = "0x20004DC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06001A95 RID: 6805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A95")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x06001A96 RID: 6806 RVA: 0x00008538 File Offset: 0x00006738
		[Token(Token = "0x6001A96")]
		[Address(RVA = "0x78D5F0", Offset = "0x78C9F0", VA = "0x1078D5F0")]
		internal bool <Update>b__27_0(SpriteRenderer o)
		{
			return default(bool);
		}

		// Token: 0x06001A97 RID: 6807 RVA: 0x00008550 File Offset: 0x00006750
		[Token(Token = "0x6001A97")]
		[Address(RVA = "0x78D650", Offset = "0x78CA50", VA = "0x1078D650")]
		internal bool <Update>b__27_1(SpriteRenderer o)
		{
			return default(bool);
		}

		// Token: 0x04001AB9 RID: 6841
		[Token(Token = "0x4001AB9")]
		[FieldOffset(Offset = "0x0")]
		public static readonly EmptyGarbageMinigame.<>c <>9;

		// Token: 0x04001ABA RID: 6842
		[Token(Token = "0x4001ABA")]
		[FieldOffset(Offset = "0x4")]
		public static Func<SpriteRenderer, bool> <>9__27_0;

		// Token: 0x04001ABB RID: 6843
		[Token(Token = "0x4001ABB")]
		[FieldOffset(Offset = "0x8")]
		public static Func<SpriteRenderer, bool> <>9__27_1;
	}

	// Token: 0x020004DD RID: 1245
	[Token(Token = "0x20004DD")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <PopObjects>d__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001A98 RID: 6808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A98")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <PopObjects>d__28(int <>1__state)
		{
		}

		// Token: 0x06001A99 RID: 6809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A99")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001A9A RID: 6810 RVA: 0x00008568 File Offset: 0x00006768
		[Token(Token = "0x6001A9A")]
		[Address(RVA = "0x7893B0", Offset = "0x7887B0", VA = "0x107893B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06001A9B RID: 6811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003E0")]
		private object Current
		{
			[Token(Token = "0x6001A9B")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001A9C RID: 6812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A9C")]
		[Address(RVA = "0x789470", Offset = "0x788870", VA = "0x10789470", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06001A9D RID: 6813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003E1")]
		private object Current
		{
			[Token(Token = "0x6001A9D")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04001ABC RID: 6844
		[Token(Token = "0x4001ABC")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04001ABD RID: 6845
		[Token(Token = "0x4001ABD")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04001ABE RID: 6846
		[Token(Token = "0x4001ABE")]
		[FieldOffset(Offset = "0x10")]
		public EmptyGarbageMinigame <>4__this;
	}

	// Token: 0x020004DE RID: 1246
	[Token(Token = "0x20004DE")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <AnimateObjects>d__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001A9E RID: 6814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A9E")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <AnimateObjects>d__29(int <>1__state)
		{
		}

		// Token: 0x06001A9F RID: 6815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A9F")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001AA0 RID: 6816 RVA: 0x00008580 File Offset: 0x00006780
		[Token(Token = "0x6001AA0")]
		[Address(RVA = "0x781B30", Offset = "0x780F30", VA = "0x10781B30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06001AA1 RID: 6817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003E2")]
		private object Current
		{
			[Token(Token = "0x6001AA1")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001AA2 RID: 6818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AA2")]
		[Address(RVA = "0x781D30", Offset = "0x781130", VA = "0x10781D30", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06001AA3 RID: 6819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003E3")]
		private object Current
		{
			[Token(Token = "0x6001AA3")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04001ABF RID: 6847
		[Token(Token = "0x4001ABF")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04001AC0 RID: 6848
		[Token(Token = "0x4001AC0")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04001AC1 RID: 6849
		[Token(Token = "0x4001AC1")]
		[FieldOffset(Offset = "0x10")]
		public EmptyGarbageMinigame <>4__this;

		// Token: 0x04001AC2 RID: 6850
		[Token(Token = "0x4001AC2")]
		[FieldOffset(Offset = "0x14")]
		private Vector3 <pos>5__2;

		// Token: 0x04001AC3 RID: 6851
		[Token(Token = "0x4001AC3")]
		[FieldOffset(Offset = "0x20")]
		private float <t>5__3;
	}
}
