using System;
using Il2CppDummyDll;

// Token: 0x02000416 RID: 1046
[Token(Token = "0x2000416")]
[Attribute(Name = "DefaultMemberAttribute", RVA = "0xDF8F0", Offset = "0xDECF0")]
public class RingBuffer<T>
{
	// Token: 0x17000313 RID: 787
	// (get) Token: 0x060015FB RID: 5627 RVA: 0x00006F78 File Offset: 0x00005178
	// (set) Token: 0x060015FC RID: 5628 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000313")]
	public int Count
	{
		[Token(Token = "0x60015FB")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60015FC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private set
		{
		}
	}

	// Token: 0x17000314 RID: 788
	// (get) Token: 0x060015FD RID: 5629 RVA: 0x00006F90 File Offset: 0x00005190
	[Token(Token = "0x17000314")]
	public int Capacity
	{
		[Token(Token = "0x60015FD")]
		get
		{
			return 0;
		}
	}

	// Token: 0x060015FE RID: 5630 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015FE")]
	public RingBuffer(int size)
	{
	}

	// Token: 0x17000315 RID: 789
	// (get) Token: 0x060015FF RID: 5631 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000315")]
	public T Item
	{
		[Token(Token = "0x60015FF")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001600 RID: 5632 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001600")]
	public T First()
	{
		return null;
	}

	// Token: 0x06001601 RID: 5633 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001601")]
	public T Last()
	{
		return null;
	}

	// Token: 0x06001602 RID: 5634 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001602")]
	public void Add(T item)
	{
	}

	// Token: 0x06001603 RID: 5635 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001603")]
	public T RemoveFirst()
	{
		return null;
	}

	// Token: 0x06001604 RID: 5636 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001604")]
	public void Clear()
	{
	}

	// Token: 0x0400164D RID: 5709
	[Token(Token = "0x400164D")]
	[FieldOffset(Offset = "0x0")]
	private readonly T[] Data;

	// Token: 0x0400164E RID: 5710
	[Token(Token = "0x400164E")]
	[FieldOffset(Offset = "0x0")]
	private int startIdx;

	// Token: 0x0400164F RID: 5711
	[Token(Token = "0x400164F")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private int <Count>k__BackingField;
}
