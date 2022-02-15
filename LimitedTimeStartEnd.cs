using System;
using Il2CppDummyDll;

// Token: 0x020003ED RID: 1005
[Token(Token = "0x20003ED")]
[Serializable]
public struct LimitedTimeStartEnd
{
	// Token: 0x060014CF RID: 5327 RVA: 0x00006AB0 File Offset: 0x00004CB0
	[Token(Token = "0x60014CF")]
	[Address(RVA = "0x6E0390", Offset = "0x6DF790", VA = "0x106E0390")]
	public bool IsAvailable()
	{
		return default(bool);
	}

	// Token: 0x060014D0 RID: 5328 RVA: 0x00006AC8 File Offset: 0x00004CC8
	[Token(Token = "0x60014D0")]
	[Address(RVA = "0x6E03D0", Offset = "0x6DF7D0", VA = "0x106E03D0")]
	public bool IsLimitedTime()
	{
		return default(bool);
	}

	// Token: 0x04001569 RID: 5481
	[Token(Token = "0x4001569")]
	[FieldOffset(Offset = "0x0")]
	public LimitedTime timeStart;

	// Token: 0x0400156A RID: 5482
	[Token(Token = "0x400156A")]
	[FieldOffset(Offset = "0x14")]
	public LimitedTime timeEnd;
}
