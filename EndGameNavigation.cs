using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200016C RID: 364
[Token(Token = "0x200016C")]
public class EndGameNavigation : MonoBehaviour
{
	// Token: 0x06000855 RID: 2133 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000855")]
	[Address(RVA = "0x47A410", Offset = "0x479810", VA = "0x1047A410")]
	public void ShowProgression()
	{
	}

	// Token: 0x06000856 RID: 2134 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000856")]
	[Address(RVA = "0x47A380", Offset = "0x479780", VA = "0x1047A380")]
	public void ShowDefaultNavigation()
	{
	}

	// Token: 0x06000857 RID: 2135 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000857")]
	[Address(RVA = "0x47A3E0", Offset = "0x4797E0", VA = "0x1047A3E0")]
	public void ShowNavigationToProgressionScreen()
	{
	}

	// Token: 0x06000858 RID: 2136 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000858")]
	[Address(RVA = "0x47A200", Offset = "0x479600", VA = "0x1047A200")]
	public void HideButtons()
	{
	}

	// Token: 0x06000859 RID: 2137 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000859")]
	[Address(RVA = "0x47A230", Offset = "0x479630", VA = "0x1047A230")]
	public void NextGame()
	{
	}

	// Token: 0x0600085A RID: 2138 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600085A")]
	[Address(RVA = "0x47A170", Offset = "0x479570", VA = "0x1047A170")]
	public void Exit()
	{
	}

	// Token: 0x0600085B RID: 2139 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600085B")]
	[Address(RVA = "0x47A4C0", Offset = "0x4798C0", VA = "0x1047A4C0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDFCD0", Offset = "0xDF0D0")]
	private static IEnumerator WaitWithTimeout(Func<bool> success)
	{
		return null;
	}

	// Token: 0x0600085C RID: 2140 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600085C")]
	[Address(RVA = "0x47A130", Offset = "0x479530", VA = "0x1047A130")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDFD20", Offset = "0xDF120")]
	private IEnumerator CoJoinGame()
	{
		return null;
	}

	// Token: 0x0600085D RID: 2141 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600085D")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public EndGameNavigation()
	{
	}

	// Token: 0x04000868 RID: 2152
	[Token(Token = "0x4000868")]
	[FieldOffset(Offset = "0xC")]
	public ProgressionScreen ProgressionScreen;

	// Token: 0x04000869 RID: 2153
	[Token(Token = "0x4000869")]
	[FieldOffset(Offset = "0x10")]
	public EndGameManager EndGameManager;

	// Token: 0x0400086A RID: 2154
	[Token(Token = "0x400086A")]
	[FieldOffset(Offset = "0x14")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xDFCA0", Offset = "0xDF0A0")]
	public GameObject ContinueButton;

	// Token: 0x0400086B RID: 2155
	[Token(Token = "0x400086B")]
	[FieldOffset(Offset = "0x18")]
	public SpriteRenderer PlayAgainButton;

	// Token: 0x0400086C RID: 2156
	[Token(Token = "0x400086C")]
	[FieldOffset(Offset = "0x1C")]
	public SpriteRenderer ExitButton;

	// Token: 0x0200016D RID: 365
	[Token(Token = "0x200016D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <WaitWithTimeout>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600085E RID: 2142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600085E")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <WaitWithTimeout>d__11(int <>1__state)
		{
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600085F")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x00004218 File Offset: 0x00002418
		[Token(Token = "0x6000860")]
		[Address(RVA = "0x78E170", Offset = "0x78D570", VA = "0x1078E170", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000861 RID: 2145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000144")]
		private object Current
		{
			[Token(Token = "0x6000861")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000862")]
		[Address(RVA = "0x78E220", Offset = "0x78D620", VA = "0x1078E220", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000863 RID: 2147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000145")]
		private object Current
		{
			[Token(Token = "0x6000863")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400086D RID: 2157
		[Token(Token = "0x400086D")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x0400086E RID: 2158
		[Token(Token = "0x400086E")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x0400086F RID: 2159
		[Token(Token = "0x400086F")]
		[FieldOffset(Offset = "0x10")]
		public Func<bool> success;

		// Token: 0x04000870 RID: 2160
		[Token(Token = "0x4000870")]
		[FieldOffset(Offset = "0x14")]
		private float <timer>5__2;
	}

	// Token: 0x0200016E RID: 366
	[Token(Token = "0x200016E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000865 RID: 2149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000865")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x00004230 File Offset: 0x00002430
		[Token(Token = "0x6000866")]
		[Address(RVA = "0x78D2B0", Offset = "0x78C6B0", VA = "0x1078D2B0")]
		internal bool <CoJoinGame>b__12_0()
		{
			return default(bool);
		}

		// Token: 0x04000871 RID: 2161
		[Token(Token = "0x4000871")]
		[FieldOffset(Offset = "0x0")]
		public static readonly EndGameNavigation.<>c <>9;

		// Token: 0x04000872 RID: 2162
		[Token(Token = "0x4000872")]
		[FieldOffset(Offset = "0x4")]
		public static Func<bool> <>9__12_0;
	}

	// Token: 0x0200016F RID: 367
	[Token(Token = "0x200016F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoJoinGame>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000867 RID: 2151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000867")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoJoinGame>d__12(int <>1__state)
		{
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000868")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x00004248 File Offset: 0x00002448
		[Token(Token = "0x6000869")]
		[Address(RVA = "0x784FB0", Offset = "0x7843B0", VA = "0x10784FB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x0600086A RID: 2154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000146")]
		private object Current
		{
			[Token(Token = "0x600086A")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600086B")]
		[Address(RVA = "0x785110", Offset = "0x784510", VA = "0x10785110", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x0600086C RID: 2156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000147")]
		private object Current
		{
			[Token(Token = "0x600086C")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000873 RID: 2163
		[Token(Token = "0x4000873")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000874 RID: 2164
		[Token(Token = "0x4000874")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;
	}
}
