using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

// Token: 0x02000263 RID: 611
[Token(Token = "0x2000263")]
public class CompletionToken<T>
{
	// Token: 0x17000207 RID: 519
	// (get) Token: 0x06000DA3 RID: 3491 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000207")]
	public static CompletionToken<T> Default
	{
		[Token(Token = "0x6000DA3")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000208 RID: 520
	// (get) Token: 0x06000DA4 RID: 3492 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000DA5 RID: 3493 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000208")]
	public T Value
	{
		[Token(Token = "0x6000DA4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000DA5")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private set
		{
		}
	}

	// Token: 0x06000DA6 RID: 3494 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DA6")]
	public CompletionToken(T defaultValue)
	{
	}

	// Token: 0x06000DA7 RID: 3495 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DA7")]
	public void MarkComplete(T resultValue)
	{
	}

	// Token: 0x06000DA8 RID: 3496 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DA8")]
	public void MarkComplete(T resultValue, string error)
	{
	}

	// Token: 0x06000DA9 RID: 3497 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DA9")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE42E0", Offset = "0xE36E0")]
	public IEnumerator WaitForCompletion()
	{
		return null;
	}

	// Token: 0x04000D7D RID: 3453
	[Token(Token = "0x4000D7D")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private T <Value>k__BackingField;

	// Token: 0x04000D7E RID: 3454
	[Token(Token = "0x4000D7E")]
	[FieldOffset(Offset = "0x0")]
	private bool complete;

	// Token: 0x04000D7F RID: 3455
	[Token(Token = "0x4000D7F")]
	[FieldOffset(Offset = "0x0")]
	public string errorStr;

	// Token: 0x02000264 RID: 612
	[Token(Token = "0x2000264")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <WaitForCompletion>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000DAA RID: 3498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DAA")]
		[DebuggerHidden]
		public <WaitForCompletion>d__11(int <>1__state)
		{
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DAB")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x000053D0 File Offset: 0x000035D0
		[Token(Token = "0x6000DAC")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000DAD RID: 3501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000209")]
		private object Current
		{
			[Token(Token = "0x6000DAD")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DAE")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000DAF RID: 3503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700020A")]
		private object Current
		{
			[Token(Token = "0x6000DAF")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000D80 RID: 3456
		[Token(Token = "0x4000D80")]
		[FieldOffset(Offset = "0x0")]
		private int <>1__state;

		// Token: 0x04000D81 RID: 3457
		[Token(Token = "0x4000D81")]
		[FieldOffset(Offset = "0x0")]
		private object <>2__current;

		// Token: 0x04000D82 RID: 3458
		[Token(Token = "0x4000D82")]
		[FieldOffset(Offset = "0x0")]
		public CompletionToken<T> <>4__this;
	}
}
