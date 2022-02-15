using System;
using Il2CppDummyDll;

namespace InnerNet
{
	// Token: 0x02000638 RID: 1592
	[Token(Token = "0x2000638")]
	public enum ReportOutcome
	{
		// Token: 0x0400274B RID: 10059
		[Token(Token = "0x400274B")]
		NotReportedUnknown,
		// Token: 0x0400274C RID: 10060
		[Token(Token = "0x400274C")]
		NotReportedNoAccount,
		// Token: 0x0400274D RID: 10061
		[Token(Token = "0x400274D")]
		NotReportedNotFound,
		// Token: 0x0400274E RID: 10062
		[Token(Token = "0x400274E")]
		NotReportedRateLimit,
		// Token: 0x0400274F RID: 10063
		[Token(Token = "0x400274F")]
		Reported
	}
}
