using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

// Token: 0x020000C3 RID: 195
[Token(Token = "0x20000C3")]
public class CircleBuffer<T> : IEnumerable<T>, IEnumerable where T : class
{
	// Token: 0x0600048F RID: 1167 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600048F")]
	public CircleBuffer(int size)
	{
	}

	// Token: 0x06000490 RID: 1168 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000490")]
	public void Sort(IComparer<T> comparer)
	{
	}

	// Token: 0x06000491 RID: 1169 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000491")]
	public void Add(T item)
	{
	}

	// Token: 0x06000492 RID: 1170 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000492")]
	public void Clear()
	{
	}

	// Token: 0x06000493 RID: 1171 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000493")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE63C0", Offset = "0xE57C0")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	// Token: 0x06000494 RID: 1172 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000494")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE6410", Offset = "0xE5810")]
	private IEnumerator GetEnumerator()
	{
		return null;
	}

	// Token: 0x06000495 RID: 1173 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000495")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x04000517 RID: 1303
	[Token(Token = "0x4000517")]
	[FieldOffset(Offset = "0x0")]
	private T[] data;

	// Token: 0x04000518 RID: 1304
	[Token(Token = "0x4000518")]
	[FieldOffset(Offset = "0x0")]
	private int idx;

	// Token: 0x04000519 RID: 1305
	[Token(Token = "0x4000519")]
	[FieldOffset(Offset = "0x0")]
	private int count;

	// Token: 0x020000C4 RID: 196
	[Token(Token = "0x20000C4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <GetEnumerator>d__7 : IEnumerator<T>, IEnumerator, IDisposable
	{
		// Token: 0x06000496 RID: 1174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000496")]
		[DebuggerHidden]
		public <GetEnumerator>d__7(int <>1__state)
		{
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000497")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x00002E50 File Offset: 0x00001050
		[Token(Token = "0x6000498")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000499 RID: 1177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000AC")]
		private T Current
		{
			[Token(Token = "0x6000499")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600049A")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600049B RID: 1179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000AD")]
		private object Current
		{
			[Token(Token = "0x600049B")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400051A RID: 1306
		[Token(Token = "0x400051A")]
		[FieldOffset(Offset = "0x0")]
		private int <>1__state;

		// Token: 0x0400051B RID: 1307
		[Token(Token = "0x400051B")]
		[FieldOffset(Offset = "0x0")]
		private T <>2__current;

		// Token: 0x0400051C RID: 1308
		[Token(Token = "0x400051C")]
		[FieldOffset(Offset = "0x0")]
		public CircleBuffer<T> <>4__this;

		// Token: 0x0400051D RID: 1309
		[Token(Token = "0x400051D")]
		[FieldOffset(Offset = "0x0")]
		private int <i>5__2;
	}

	// Token: 0x020000C5 RID: 197
	[Token(Token = "0x20000C5")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <System-Collections-IEnumerable-GetEnumerator>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600049C RID: 1180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600049C")]
		[DebuggerHidden]
		public <System-Collections-IEnumerable-GetEnumerator>d__8(int <>1__state)
		{
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600049D")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00002E68 File Offset: 0x00001068
		[Token(Token = "0x600049E")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000AE")]
		private object Current
		{
			[Token(Token = "0x600049F")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004A0")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000AF")]
		private object Current
		{
			[Token(Token = "0x60004A1")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400051E RID: 1310
		[Token(Token = "0x400051E")]
		[FieldOffset(Offset = "0x0")]
		private int <>1__state;

		// Token: 0x0400051F RID: 1311
		[Token(Token = "0x400051F")]
		[FieldOffset(Offset = "0x0")]
		private object <>2__current;

		// Token: 0x04000520 RID: 1312
		[Token(Token = "0x4000520")]
		[FieldOffset(Offset = "0x0")]
		public CircleBuffer<T> <>4__this;

		// Token: 0x04000521 RID: 1313
		[Token(Token = "0x4000521")]
		[FieldOffset(Offset = "0x0")]
		private int <i>5__2;
	}
}
