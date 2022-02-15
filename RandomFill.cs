using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x020000EE RID: 238
[Token(Token = "0x20000EE")]
public class RandomFill<T>
{
	// Token: 0x060005C8 RID: 1480 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005C8")]
	public RandomFill()
	{
	}

	// Token: 0x060005C9 RID: 1481 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005C9")]
	public RandomFill(IEnumerable<T> set)
	{
	}

	// Token: 0x060005CA RID: 1482 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005CA")]
	public void Set(IEnumerable<T> values)
	{
	}

	// Token: 0x060005CB RID: 1483 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005CB")]
	public T Get()
	{
		return null;
	}

	// Token: 0x040005F0 RID: 1520
	[Token(Token = "0x40005F0")]
	[FieldOffset(Offset = "0x0")]
	private T[] values;

	// Token: 0x040005F1 RID: 1521
	[Token(Token = "0x40005F1")]
	[FieldOffset(Offset = "0x0")]
	private int idx;
}
