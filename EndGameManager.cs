using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000168 RID: 360
[Token(Token = "0x2000168")]
public class EndGameManager : MonoBehaviour
{
	// Token: 0x0600083C RID: 2108 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600083C")]
	[Address(RVA = "0x479ED0", Offset = "0x4792D0", VA = "0x10479ED0")]
	public void Start()
	{
	}

	// Token: 0x0600083D RID: 2109 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600083D")]
	[Address(RVA = "0x479DB0", Offset = "0x4791B0", VA = "0x10479DB0")]
	private void ShowButtons()
	{
	}

	// Token: 0x0600083E RID: 2110 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600083E")]
	[Address(RVA = "0x4790A0", Offset = "0x4784A0", VA = "0x104790A0")]
	private void SetEverythingUp()
	{
	}

	// Token: 0x0600083F RID: 2111 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600083F")]
	[Address(RVA = "0x479020", Offset = "0x478420", VA = "0x10479020")]
	private void GetStingerVol(AudioSource source, float dt)
	{
	}

	// Token: 0x06000840 RID: 2112 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000840")]
	[Address(RVA = "0x478FD0", Offset = "0x4783D0", VA = "0x10478FD0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDFBB0", Offset = "0xDEFB0")]
	private IEnumerator CoBegin()
	{
		return null;
	}

	// Token: 0x06000841 RID: 2113 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000841")]
	[Address(RVA = "0x47A0E0", Offset = "0x4794E0", VA = "0x1047A0E0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDFC50", Offset = "0xDF050")]
	public static IEnumerator WaitWithTimeout(Func<bool> success)
	{
		return null;
	}

	// Token: 0x06000842 RID: 2114 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000842")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public EndGameManager()
	{
	}

	// Token: 0x0400084A RID: 2122
	[Token(Token = "0x400084A")]
	[FieldOffset(Offset = "0xC")]
	public TextMeshPro WinText;

	// Token: 0x0400084B RID: 2123
	[Token(Token = "0x400084B")]
	[FieldOffset(Offset = "0x10")]
	public MeshRenderer BackgroundBar;

	// Token: 0x0400084C RID: 2124
	[Token(Token = "0x400084C")]
	[FieldOffset(Offset = "0x14")]
	public MeshRenderer Foreground;

	// Token: 0x0400084D RID: 2125
	[Token(Token = "0x400084D")]
	[FieldOffset(Offset = "0x18")]
	public FloatRange ForegroundRadius;

	// Token: 0x0400084E RID: 2126
	[Token(Token = "0x400084E")]
	[FieldOffset(Offset = "0x1C")]
	public SpriteRenderer FrontMost;

	// Token: 0x0400084F RID: 2127
	[Token(Token = "0x400084F")]
	[FieldOffset(Offset = "0x20")]
	public PoolablePlayer PlayerPrefab;

	// Token: 0x04000850 RID: 2128
	[Token(Token = "0x4000850")]
	[FieldOffset(Offset = "0x24")]
	public Sprite GhostSprite;

	// Token: 0x04000851 RID: 2129
	[Token(Token = "0x4000851")]
	[FieldOffset(Offset = "0x28")]
	public AudioClip DisconnectStinger;

	// Token: 0x04000852 RID: 2130
	[Token(Token = "0x4000852")]
	[FieldOffset(Offset = "0x2C")]
	public AudioClip CrewStinger;

	// Token: 0x04000853 RID: 2131
	[Token(Token = "0x4000853")]
	[FieldOffset(Offset = "0x30")]
	public AudioClip ImpostorStinger;

	// Token: 0x04000854 RID: 2132
	[Token(Token = "0x4000854")]
	[FieldOffset(Offset = "0x34")]
	public EndGameNavigation Navigation;

	// Token: 0x04000855 RID: 2133
	[Token(Token = "0x4000855")]
	private const float ScaleAll = 0.9f;

	// Token: 0x04000856 RID: 2134
	[Token(Token = "0x4000856")]
	private const float OffsetWidth = 1f;

	// Token: 0x04000857 RID: 2135
	[Token(Token = "0x4000857")]
	[FieldOffset(Offset = "0x38")]
	private float stingerTime;

	// Token: 0x02000169 RID: 361
	[Token(Token = "0x2000169")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000844 RID: 2116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000844")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x00004188 File Offset: 0x00002388
		[Token(Token = "0x6000845")]
		[Address(RVA = "0x6C1DF0", Offset = "0x6C11F0", VA = "0x106C1DF0")]
		internal bool <Start>b__13_0(WinningPlayerData h)
		{
			return default(bool);
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x000041A0 File Offset: 0x000023A0
		[Token(Token = "0x6000846")]
		[Address(RVA = "0x6C1DF0", Offset = "0x6C11F0", VA = "0x106C1DF0")]
		internal bool <SetEverythingUp>b__15_1(WinningPlayerData h)
		{
			return default(bool);
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x000041B8 File Offset: 0x000023B8
		[Token(Token = "0x6000847")]
		[Address(RVA = "0x6C1DF0", Offset = "0x6C11F0", VA = "0x106C1DF0")]
		internal bool <SetEverythingUp>b__15_2(WinningPlayerData h)
		{
			return default(bool);
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x000041D0 File Offset: 0x000023D0
		[Token(Token = "0x6000848")]
		[Address(RVA = "0x78D590", Offset = "0x78C990", VA = "0x1078D590")]
		internal int <SetEverythingUp>b__15_0(WinningPlayerData b)
		{
			return 0;
		}

		// Token: 0x04000858 RID: 2136
		[Token(Token = "0x4000858")]
		[FieldOffset(Offset = "0x0")]
		public static readonly EndGameManager.<>c <>9;

		// Token: 0x04000859 RID: 2137
		[Token(Token = "0x4000859")]
		[FieldOffset(Offset = "0x4")]
		public static Func<WinningPlayerData, bool> <>9__13_0;

		// Token: 0x0400085A RID: 2138
		[Token(Token = "0x400085A")]
		[FieldOffset(Offset = "0x8")]
		public static Func<WinningPlayerData, bool> <>9__15_1;

		// Token: 0x0400085B RID: 2139
		[Token(Token = "0x400085B")]
		[FieldOffset(Offset = "0xC")]
		public static Func<WinningPlayerData, bool> <>9__15_2;

		// Token: 0x0400085C RID: 2140
		[Token(Token = "0x400085C")]
		[FieldOffset(Offset = "0x10")]
		public static Func<WinningPlayerData, int> <>9__15_0;
	}

	// Token: 0x0200016A RID: 362
	[Token(Token = "0x200016A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoBegin>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000849 RID: 2121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000849")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoBegin>d__18(int <>1__state)
		{
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600084A")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x000041E8 File Offset: 0x000023E8
		[Token(Token = "0x600084B")]
		[Address(RVA = "0x7841C0", Offset = "0x7835C0", VA = "0x107841C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x0600084C RID: 2124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000140")]
		private object Current
		{
			[Token(Token = "0x600084C")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600084D")]
		[Address(RVA = "0x7844F0", Offset = "0x7838F0", VA = "0x107844F0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x0600084E RID: 2126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000141")]
		private object Current
		{
			[Token(Token = "0x600084E")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400085D RID: 2141
		[Token(Token = "0x400085D")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x0400085E RID: 2142
		[Token(Token = "0x400085E")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x0400085F RID: 2143
		[Token(Token = "0x400085F")]
		[FieldOffset(Offset = "0x10")]
		public EndGameManager <>4__this;

		// Token: 0x04000860 RID: 2144
		[Token(Token = "0x4000860")]
		[FieldOffset(Offset = "0x14")]
		private Color <c>5__2;

		// Token: 0x04000861 RID: 2145
		[Token(Token = "0x4000861")]
		[FieldOffset(Offset = "0x24")]
		private Color <fade>5__3;

		// Token: 0x04000862 RID: 2146
		[Token(Token = "0x4000862")]
		[FieldOffset(Offset = "0x34")]
		private Vector3 <titlePos>5__4;

		// Token: 0x04000863 RID: 2147
		[Token(Token = "0x4000863")]
		[FieldOffset(Offset = "0x40")]
		private float <timer>5__5;
	}

	// Token: 0x0200016B RID: 363
	[Token(Token = "0x200016B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <WaitWithTimeout>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600084F RID: 2127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600084F")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <WaitWithTimeout>d__19(int <>1__state)
		{
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000850")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x00004200 File Offset: 0x00002400
		[Token(Token = "0x6000851")]
		[Address(RVA = "0x78E250", Offset = "0x78D650", VA = "0x1078E250", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000852 RID: 2130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000142")]
		private object Current
		{
			[Token(Token = "0x6000852")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000853")]
		[Address(RVA = "0x78E300", Offset = "0x78D700", VA = "0x1078E300", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000854 RID: 2132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000143")]
		private object Current
		{
			[Token(Token = "0x6000854")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000864 RID: 2148
		[Token(Token = "0x4000864")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000865 RID: 2149
		[Token(Token = "0x4000865")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000866 RID: 2150
		[Token(Token = "0x4000866")]
		[FieldOffset(Offset = "0x10")]
		public Func<bool> success;

		// Token: 0x04000867 RID: 2151
		[Token(Token = "0x4000867")]
		[FieldOffset(Offset = "0x14")]
		private float <timer>5__2;
	}
}
