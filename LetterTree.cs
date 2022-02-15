using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Il2CppDummyDll;

// Token: 0x02000214 RID: 532
[Token(Token = "0x2000214")]
public class LetterTree
{
	// Token: 0x06000BDC RID: 3036 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BDC")]
	[Address(RVA = "0x6DBAD0", Offset = "0x6DAED0", VA = "0x106DBAD0")]
	public void Clear()
	{
	}

	// Token: 0x06000BDD RID: 3037 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BDD")]
	[Address(RVA = "0x6DBA00", Offset = "0x6DAE00", VA = "0x106DBA00")]
	public void AddWord(string word)
	{
	}

	// Token: 0x06000BDE RID: 3038 RVA: 0x00004C50 File Offset: 0x00002E50
	[Token(Token = "0x6000BDE")]
	[Address(RVA = "0x6DBBE0", Offset = "0x6DAFE0", VA = "0x106DBBE0")]
	public bool IsFiller(char l)
	{
		return default(bool);
	}

	// Token: 0x06000BDF RID: 3039 RVA: 0x00004C68 File Offset: 0x00002E68
	[Token(Token = "0x6000BDF")]
	[Address(RVA = "0x6DBCD0", Offset = "0x6DB0D0", VA = "0x106DBCD0")]
	public int Search(StringBuilder input, int start)
	{
		return 0;
	}

	// Token: 0x06000BE0 RID: 3040 RVA: 0x00004C80 File Offset: 0x00002E80
	[Token(Token = "0x6000BE0")]
	[Address(RVA = "0x6DBC00", Offset = "0x6DB000", VA = "0x106DBC00")]
	public int Search(string inputStr, int start)
	{
		return 0;
	}

	// Token: 0x06000BE1 RID: 3041 RVA: 0x00004C98 File Offset: 0x00002E98
	[Token(Token = "0x6000BE1")]
	[Address(RVA = "0x6DBD60", Offset = "0x6DB160", VA = "0x106DBD60")]
	private int SubSearchRec(StringBuilder input, int start, LetterTree.LetterNode previous, bool postDupes, bool postBreak, bool exactStart)
	{
		return 0;
	}

	// Token: 0x06000BE2 RID: 3042 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BE2")]
	[Address(RVA = "0x6DBB20", Offset = "0x6DAF20", VA = "0x106DBB20")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE1CD0", Offset = "0xE10D0")]
	public IEnumerable<string> GetWords()
	{
		return null;
	}

	// Token: 0x06000BE3 RID: 3043 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BE3")]
	[Address(RVA = "0x6DBB70", Offset = "0x6DAF70", VA = "0x106DBB70")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE1D70", Offset = "0xE1170")]
	private IEnumerable<string> GetWords(StringBuilder b, int i, LetterTree.LetterNode node)
	{
		return null;
	}

	// Token: 0x06000BE4 RID: 3044 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BE4")]
	[Address(RVA = "0x6DBED0", Offset = "0x6DB2D0", VA = "0x106DBED0")]
	public LetterTree()
	{
	}

	// Token: 0x04000BD8 RID: 3032
	[Token(Token = "0x4000BD8")]
	[FieldOffset(Offset = "0x8")]
	private LetterTree.LetterNode root;

	// Token: 0x02000215 RID: 533
	[Token(Token = "0x2000215")]
	private enum NodeTypes : byte
	{
		// Token: 0x04000BDA RID: 3034
		[Token(Token = "0x4000BDA")]
		NonTerm,
		// Token: 0x04000BDB RID: 3035
		[Token(Token = "0x4000BDB")]
		Terminal,
		// Token: 0x04000BDC RID: 3036
		[Token(Token = "0x4000BDC")]
		TerminalStrict,
		// Token: 0x04000BDD RID: 3037
		[Token(Token = "0x4000BDD")]
		TerminalExact,
		// Token: 0x04000BDE RID: 3038
		[Token(Token = "0x4000BDE")]
		TerminalUnbroken
	}

	// Token: 0x02000216 RID: 534
	[Token(Token = "0x2000216")]
	private class LetterNode
	{
		// Token: 0x06000BE5 RID: 3045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BE5")]
		[Address(RVA = "0x5A6D80", Offset = "0x5A6180", VA = "0x105A6D80")]
		public LetterNode(char l)
		{
		}

		// Token: 0x06000BE6 RID: 3046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BE6")]
		[Address(RVA = "0x5A6AE0", Offset = "0x5A5EE0", VA = "0x105A6AE0")]
		public LetterTree.LetterNode CreateChild(char l)
		{
			return null;
		}

		// Token: 0x06000BE7 RID: 3047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BE7")]
		[Address(RVA = "0x5A6BD0", Offset = "0x5A5FD0", VA = "0x105A6BD0")]
		public LetterTree.LetterNode FindChild(char l)
		{
			return null;
		}

		// Token: 0x06000BE8 RID: 3048 RVA: 0x00004CB0 File Offset: 0x00002EB0
		[Token(Token = "0x6000BE8")]
		[Address(RVA = "0x5A6C10", Offset = "0x5A6010", VA = "0x105A6C10")]
		public static int ToIndex(char c)
		{
			return 0;
		}

		// Token: 0x04000BDF RID: 3039
		[Token(Token = "0x4000BDF")]
		[FieldOffset(Offset = "0x8")]
		public char Letter;

		// Token: 0x04000BE0 RID: 3040
		[Token(Token = "0x4000BE0")]
		[FieldOffset(Offset = "0xA")]
		public LetterTree.NodeTypes Terminal;

		// Token: 0x04000BE1 RID: 3041
		[Token(Token = "0x4000BE1")]
		[FieldOffset(Offset = "0xC")]
		public LetterTree.LetterNode[] Children;
	}

	// Token: 0x02000217 RID: 535
	[Token(Token = "0x2000217")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <GetWords>d__9 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
	{
		// Token: 0x06000BE9 RID: 3049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BE9")]
		[Address(RVA = "0x5B1500", Offset = "0x5B0900", VA = "0x105B1500")]
		[DebuggerHidden]
		public <GetWords>d__9(int <>1__state)
		{
		}

		// Token: 0x06000BEA RID: 3050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BEA")]
		[Address(RVA = "0x5B1820", Offset = "0x5B0C20", VA = "0x105B1820", Slot = "7")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000BEB RID: 3051 RVA: 0x00004CC8 File Offset: 0x00002EC8
		[Token(Token = "0x6000BEB")]
		[Address(RVA = "0x5B1530", Offset = "0x5B0930", VA = "0x105B1530", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x06000BEC RID: 3052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BEC")]
		[Address(RVA = "0x5B1880", Offset = "0x5B0C80", VA = "0x105B1880")]
		private void <>m__Finally1()
		{
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000BED RID: 3053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001C4")]
		private string Current
		{
			[Token(Token = "0x6000BED")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000BEE RID: 3054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BEE")]
		[Address(RVA = "0x5B17F0", Offset = "0x5B0BF0", VA = "0x105B17F0", Slot = "10")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000BEF RID: 3055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001C5")]
		private object Current
		{
			[Token(Token = "0x6000BEF")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000BF0 RID: 3056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BF0")]
		[Address(RVA = "0x5B1770", Offset = "0x5B0B70", VA = "0x105B1770", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<string> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000BF1 RID: 3057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BF1")]
		[Address(RVA = "0x5B1770", Offset = "0x5B0B70", VA = "0x105B1770", Slot = "5")]
		[DebuggerHidden]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x04000BE2 RID: 3042
		[Token(Token = "0x4000BE2")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000BE3 RID: 3043
		[Token(Token = "0x4000BE3")]
		[FieldOffset(Offset = "0xC")]
		private string <>2__current;

		// Token: 0x04000BE4 RID: 3044
		[Token(Token = "0x4000BE4")]
		[FieldOffset(Offset = "0x10")]
		private int <>l__initialThreadId;

		// Token: 0x04000BE5 RID: 3045
		[Token(Token = "0x4000BE5")]
		[FieldOffset(Offset = "0x14")]
		public LetterTree <>4__this;

		// Token: 0x04000BE6 RID: 3046
		[Token(Token = "0x4000BE6")]
		[FieldOffset(Offset = "0x18")]
		private StringBuilder <b>5__2;

		// Token: 0x04000BE7 RID: 3047
		[Token(Token = "0x4000BE7")]
		[FieldOffset(Offset = "0x1C")]
		private LetterTree.LetterNode[] <>7__wrap2;

		// Token: 0x04000BE8 RID: 3048
		[Token(Token = "0x4000BE8")]
		[FieldOffset(Offset = "0x20")]
		private int <>7__wrap3;

		// Token: 0x04000BE9 RID: 3049
		[Token(Token = "0x4000BE9")]
		[FieldOffset(Offset = "0x24")]
		private IEnumerator<string> <>7__wrap4;
	}

	// Token: 0x02000218 RID: 536
	[Token(Token = "0x2000218")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <GetWords>d__10 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
	{
		// Token: 0x06000BF2 RID: 3058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BF2")]
		[Address(RVA = "0x5B1500", Offset = "0x5B0900", VA = "0x105B1500")]
		[DebuggerHidden]
		public <GetWords>d__10(int <>1__state)
		{
		}

		// Token: 0x06000BF3 RID: 3059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BF3")]
		[Address(RVA = "0x5B1450", Offset = "0x5B0850", VA = "0x105B1450", Slot = "7")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000BF4 RID: 3060 RVA: 0x00004CE0 File Offset: 0x00002EE0
		[Token(Token = "0x6000BF4")]
		[Address(RVA = "0x5B0FF0", Offset = "0x5B03F0", VA = "0x105B0FF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x06000BF5 RID: 3061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BF5")]
		[Address(RVA = "0x5B14B0", Offset = "0x5B08B0", VA = "0x105B14B0")]
		private void <>m__Finally1()
		{
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000BF6 RID: 3062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001C6")]
		private string Current
		{
			[Token(Token = "0x6000BF6")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BF7")]
		[Address(RVA = "0x5B1420", Offset = "0x5B0820", VA = "0x105B1420", Slot = "10")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000BF8 RID: 3064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001C7")]
		private object Current
		{
			[Token(Token = "0x6000BF8")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000BF9 RID: 3065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BF9")]
		[Address(RVA = "0x5B1380", Offset = "0x5B0780", VA = "0x105B1380", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<string> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000BFA RID: 3066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BFA")]
		[Address(RVA = "0x5B1380", Offset = "0x5B0780", VA = "0x105B1380", Slot = "5")]
		[DebuggerHidden]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x04000BEA RID: 3050
		[Token(Token = "0x4000BEA")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000BEB RID: 3051
		[Token(Token = "0x4000BEB")]
		[FieldOffset(Offset = "0xC")]
		private string <>2__current;

		// Token: 0x04000BEC RID: 3052
		[Token(Token = "0x4000BEC")]
		[FieldOffset(Offset = "0x10")]
		private int <>l__initialThreadId;

		// Token: 0x04000BED RID: 3053
		[Token(Token = "0x4000BED")]
		[FieldOffset(Offset = "0x14")]
		private LetterTree.LetterNode node;

		// Token: 0x04000BEE RID: 3054
		[Token(Token = "0x4000BEE")]
		[FieldOffset(Offset = "0x18")]
		public LetterTree.LetterNode <>3__node;

		// Token: 0x04000BEF RID: 3055
		[Token(Token = "0x4000BEF")]
		[FieldOffset(Offset = "0x1C")]
		private StringBuilder b;

		// Token: 0x04000BF0 RID: 3056
		[Token(Token = "0x4000BF0")]
		[FieldOffset(Offset = "0x20")]
		public StringBuilder <>3__b;

		// Token: 0x04000BF1 RID: 3057
		[Token(Token = "0x4000BF1")]
		[FieldOffset(Offset = "0x24")]
		private int i;

		// Token: 0x04000BF2 RID: 3058
		[Token(Token = "0x4000BF2")]
		[FieldOffset(Offset = "0x28")]
		public int <>3__i;

		// Token: 0x04000BF3 RID: 3059
		[Token(Token = "0x4000BF3")]
		[FieldOffset(Offset = "0x2C")]
		public LetterTree <>4__this;

		// Token: 0x04000BF4 RID: 3060
		[Token(Token = "0x4000BF4")]
		[FieldOffset(Offset = "0x30")]
		private LetterTree.LetterNode[] <>7__wrap1;

		// Token: 0x04000BF5 RID: 3061
		[Token(Token = "0x4000BF5")]
		[FieldOffset(Offset = "0x34")]
		private int <>7__wrap2;

		// Token: 0x04000BF6 RID: 3062
		[Token(Token = "0x4000BF6")]
		[FieldOffset(Offset = "0x38")]
		private IEnumerator<string> <>7__wrap3;
	}
}
