using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x0200014F RID: 335
[Token(Token = "0x200014F")]
public class ThreadSafeActionQueue
{
	// Token: 0x060007BE RID: 1982 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007BE")]
	[Address(RVA = "0x4ADF50", Offset = "0x4AD350", VA = "0x104ADF50")]
	public void Enqueue(Action action)
	{
	}

	// Token: 0x060007BF RID: 1983 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007BF")]
	[Address(RVA = "0x4ADE60", Offset = "0x4AD260", VA = "0x104ADE60")]
	public void Drain()
	{
	}

	// Token: 0x060007C0 RID: 1984 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007C0")]
	[Address(RVA = "0x4AE020", Offset = "0x4AD420", VA = "0x104AE020")]
	public ThreadSafeActionQueue()
	{
	}

	// Token: 0x040007A7 RID: 1959
	[Token(Token = "0x40007A7")]
	[FieldOffset(Offset = "0x8")]
	private readonly Queue<Action> pendingCallbacks;
}
