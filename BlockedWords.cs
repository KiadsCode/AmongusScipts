using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

// Token: 0x02000211 RID: 529
[Token(Token = "0x2000211")]
public static class BlockedWords
{
	// Token: 0x06000BCE RID: 3022 RVA: 0x00004BF0 File Offset: 0x00002DF0
	[Token(Token = "0x6000BCE")]
	[Address(RVA = "0x81CC80", Offset = "0x81C080", VA = "0x1081CC80")]
	public static bool ContainsWord(string chatText)
	{
		return default(bool);
	}

	// Token: 0x06000BCF RID: 3023 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BCF")]
	[Address(RVA = "0x81CB90", Offset = "0x81BF90", VA = "0x1081CB90")]
	public static string CensorWords(string chatText)
	{
		return null;
	}

	// Token: 0x06000BD0 RID: 3024 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BD0")]
	[Address(RVA = "0x81CA70", Offset = "0x81BE70", VA = "0x1081CA70")]
	public static void CensorWordsAsync(string chatText, Action<string> onWordsCensoredCallback)
	{
	}

	// Token: 0x06000BD1 RID: 3025 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BD1")]
	[Address(RVA = "0x81CB30", Offset = "0x81BF30", VA = "0x1081CB30")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE1B10", Offset = "0xE0F10")]
	private static IEnumerator CensorWordsCo(string chatText, Action<string> onWordsCensoredCallback)
	{
		return null;
	}

	// Token: 0x06000BD2 RID: 3026 RVA: 0x00004C08 File Offset: 0x00002E08
	[Token(Token = "0x6000BD2")]
	[Address(RVA = "0x81CD10", Offset = "0x81C110", VA = "0x1081CD10")]
	private static bool IsLetter(char letter)
	{
		return default(bool);
	}

	// Token: 0x04000BD0 RID: 3024
	[Token(Token = "0x4000BD0")]
	[FieldOffset(Offset = "0x0")]
	public static readonly HashSet<char> SymbolChars;

	// Token: 0x04000BD1 RID: 3025
	[Token(Token = "0x4000BD1")]
	[FieldOffset(Offset = "0x4")]
	private static readonly LetterTree SkipList;

	// Token: 0x04000BD2 RID: 3026
	[Token(Token = "0x4000BD2")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string[] AllWords;

	// Token: 0x02000212 RID: 530
	[Token(Token = "0x2000212")]
	private class LengthCompare : IComparer<string>
	{
		// Token: 0x06000BD3 RID: 3027 RVA: 0x00004C20 File Offset: 0x00002E20
		[Token(Token = "0x6000BD3")]
		[Address(RVA = "0x3C0B20", Offset = "0x3BFF20", VA = "0x103C0B20", Slot = "4")]
		public int Compare(string x, string y)
		{
			return 0;
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BD4")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public LengthCompare()
		{
		}

		// Token: 0x04000BD3 RID: 3027
		[Token(Token = "0x4000BD3")]
		[FieldOffset(Offset = "0x32F932F3")]
		public static readonly BlockedWords.LengthCompare Instance;
	}

	// Token: 0x02000213 RID: 531
	[Token(Token = "0x2000213")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CensorWordsCo>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000BD6 RID: 3030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BD6")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CensorWordsCo>d__7(int <>1__state)
		{
		}

		// Token: 0x06000BD7 RID: 3031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BD7")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x00004C38 File Offset: 0x00002E38
		[Token(Token = "0x6000BD8")]
		[Address(RVA = "0x3C2E40", Offset = "0x3C2240", VA = "0x103C2E40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000BD9 RID: 3033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001C2")]
		private object Current
		{
			[Token(Token = "0x6000BD9")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000BDA RID: 3034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BDA")]
		[Address(RVA = "0x3C2F90", Offset = "0x3C2390", VA = "0x103C2F90", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000BDB RID: 3035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001C3")]
		private object Current
		{
			[Token(Token = "0x6000BDB")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000BD4 RID: 3028
		[Token(Token = "0x4000BD4")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000BD5 RID: 3029
		[Token(Token = "0x4000BD5")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000BD6 RID: 3030
		[Token(Token = "0x4000BD6")]
		[FieldOffset(Offset = "0x10")]
		public string chatText;

		// Token: 0x04000BD7 RID: 3031
		[Token(Token = "0x4000BD7")]
		[FieldOffset(Offset = "0x14")]
		public Action<string> onWordsCensoredCallback;
	}
}
