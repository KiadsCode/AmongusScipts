using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

// Token: 0x0200026F RID: 623
[Token(Token = "0x200026F")]
public class SequenceBuffer<T>
{
	// Token: 0x1700020F RID: 527
	// (get) Token: 0x06000DD8 RID: 3544 RVA: 0x000054D8 File Offset: 0x000036D8
	// (set) Token: 0x06000DD9 RID: 3545 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700020F")]
	public ushort LastSid
	{
		[Token(Token = "0x6000DD8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000DD9")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		set
		{
		}
	}

	// Token: 0x06000DDA RID: 3546 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DDA")]
	public SequenceBuffer(ushort sidStart = 0)
	{
	}

	// Token: 0x06000DDB RID: 3547 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DDB")]
	public void Add(ushort sid, T info)
	{
	}

	// Token: 0x06000DDC RID: 3548 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DDC")]
	public void BumpSid()
	{
	}

	// Token: 0x06000DDD RID: 3549 RVA: 0x000054F0 File Offset: 0x000036F0
	[Token(Token = "0x6000DDD")]
	public bool IsInvalidSid(ushort sid)
	{
		return default(bool);
	}

	// Token: 0x06000DDE RID: 3550 RVA: 0x00005508 File Offset: 0x00003708
	[Token(Token = "0x6000DDE")]
	public bool IsNextSid(ushort sid)
	{
		return default(bool);
	}

	// Token: 0x06000DDF RID: 3551 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DDF")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE4620", Offset = "0xE3A20")]
	public IEnumerable<T> SubsequentObjs()
	{
		return null;
	}

	// Token: 0x06000DE0 RID: 3552 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DE0")]
	private void Sort()
	{
	}

	// Token: 0x06000DE1 RID: 3553 RVA: 0x00005520 File Offset: 0x00003720
	[Token(Token = "0x6000DE1")]
	private bool HasElements()
	{
		return default(bool);
	}

	// Token: 0x06000DE2 RID: 3554 RVA: 0x00005538 File Offset: 0x00003738
	[Token(Token = "0x6000DE2")]
	private SequenceBuffer<T>.SequencedData<T> Pop()
	{
		return default(SequenceBuffer<T>.SequencedData<T>);
	}

	// Token: 0x06000DE3 RID: 3555 RVA: 0x00005550 File Offset: 0x00003750
	[Token(Token = "0x6000DE3")]
	private SequenceBuffer<T>.SequencedData<T> Peek()
	{
		return default(SequenceBuffer<T>.SequencedData<T>);
	}

	// Token: 0x04000E04 RID: 3588
	[Token(Token = "0x4000E04")]
	[FieldOffset(Offset = "0x0")]
	private readonly List<SequenceBuffer<T>.SequencedData<T>> buffer;

	// Token: 0x04000E05 RID: 3589
	[Token(Token = "0x4000E05")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private ushort <LastSid>k__BackingField;

	// Token: 0x02000270 RID: 624
	[Token(Token = "0x2000270")]
	private struct SequencedData<T> : IComparable<SequenceBuffer<T>.SequencedData<T>>
	{
		// Token: 0x06000DE4 RID: 3556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DE4")]
		public SequencedData(ushort sid, T data)
		{
		}

		// Token: 0x06000DE5 RID: 3557 RVA: 0x00005568 File Offset: 0x00003768
		[Token(Token = "0x6000DE5")]
		public int CompareTo(SequenceBuffer<T>.SequencedData<T> other)
		{
			return 0;
		}

		// Token: 0x04000E06 RID: 3590
		[Token(Token = "0x4000E06")]
		[FieldOffset(Offset = "0x0")]
		public readonly ushort Sid;

		// Token: 0x04000E07 RID: 3591
		[Token(Token = "0x4000E07")]
		[FieldOffset(Offset = "0x0")]
		public readonly T Data;
	}

	// Token: 0x02000271 RID: 625
	[Token(Token = "0x2000271")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <SubsequentObjs>d__11 : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		// Token: 0x06000DE6 RID: 3558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DE6")]
		[DebuggerHidden]
		public <SubsequentObjs>d__11(int <>1__state)
		{
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DE7")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x00005580 File Offset: 0x00003780
		[Token(Token = "0x6000DE8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000DE9 RID: 3561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000210")]
		private T Current
		{
			[Token(Token = "0x6000DE9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DEA")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000DEB RID: 3563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000211")]
		private object Current
		{
			[Token(Token = "0x6000DEB")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DEC")]
		[DebuggerHidden]
		private IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DED")]
		[DebuggerHidden]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x04000E08 RID: 3592
		[Token(Token = "0x4000E08")]
		[FieldOffset(Offset = "0x0")]
		private int <>1__state;

		// Token: 0x04000E09 RID: 3593
		[Token(Token = "0x4000E09")]
		[FieldOffset(Offset = "0x0")]
		private T <>2__current;

		// Token: 0x04000E0A RID: 3594
		[Token(Token = "0x4000E0A")]
		[FieldOffset(Offset = "0x0")]
		private int <>l__initialThreadId;

		// Token: 0x04000E0B RID: 3595
		[Token(Token = "0x4000E0B")]
		[FieldOffset(Offset = "0x0")]
		public SequenceBuffer<T> <>4__this;
	}
}
