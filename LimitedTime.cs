using System;
using Il2CppDummyDll;

// Token: 0x020003EE RID: 1006
[Token(Token = "0x20003EE")]
[Serializable]
public struct LimitedTime
{
	// Token: 0x060014D1 RID: 5329 RVA: 0x00006AE0 File Offset: 0x00004CE0
	[Token(Token = "0x60014D1")]
	[Address(RVA = "0x6E0610", Offset = "0x6DFA10", VA = "0x106E0610")]
	public bool IsNowAfterThisTime(bool isEndOfDay)
	{
		return default(bool);
	}

	// Token: 0x060014D2 RID: 5330 RVA: 0x00006AF8 File Offset: 0x00004CF8
	[Token(Token = "0x60014D2")]
	[Address(RVA = "0x6E06A0", Offset = "0x6DFAA0", VA = "0x106E06A0")]
	public bool IsNowBeforeThisTime(bool isEndOfDay)
	{
		return default(bool);
	}

	// Token: 0x060014D3 RID: 5331 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014D3")]
	[Address(RVA = "0x6E0730", Offset = "0x6DFB30", VA = "0x106E0730")]
	public string TimeUntilTime(bool isEndOfDay)
	{
		return null;
	}

	// Token: 0x060014D4 RID: 5332 RVA: 0x00006B10 File Offset: 0x00004D10
	[Token(Token = "0x60014D4")]
	[Address(RVA = "0x6E0420", Offset = "0x6DF820", VA = "0x106E0420")]
	private DateTime GetDateTime(bool isEndOfDay)
	{
		return default(DateTime);
	}

	// Token: 0x0400156B RID: 5483
	[Token(Token = "0x400156B")]
	[FieldOffset(Offset = "0x0")]
	public int limitedDay;

	// Token: 0x0400156C RID: 5484
	[Token(Token = "0x400156C")]
	[FieldOffset(Offset = "0x4")]
	public int limitedMonth;

	// Token: 0x0400156D RID: 5485
	[Token(Token = "0x400156D")]
	[FieldOffset(Offset = "0x8")]
	public int limitedYear;

	// Token: 0x0400156E RID: 5486
	[Token(Token = "0x400156E")]
	[FieldOffset(Offset = "0xC")]
	public int limitedHour;

	// Token: 0x0400156F RID: 5487
	[Token(Token = "0x400156F")]
	[FieldOffset(Offset = "0x10")]
	public int limitedMinute;
}
