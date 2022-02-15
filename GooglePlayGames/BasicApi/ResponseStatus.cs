using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi
{
	// Token: 0x02000645 RID: 1605
	[Token(Token = "0x2000645")]
	public enum ResponseStatus
	{
		// Token: 0x0400277D RID: 10109
		[Token(Token = "0x400277D")]
		Success = 1,
		// Token: 0x0400277E RID: 10110
		[Token(Token = "0x400277E")]
		SuccessWithStale,
		// Token: 0x0400277F RID: 10111
		[Token(Token = "0x400277F")]
		LicenseCheckFailed = -1,
		// Token: 0x04002780 RID: 10112
		[Token(Token = "0x4002780")]
		InternalError = -2,
		// Token: 0x04002781 RID: 10113
		[Token(Token = "0x4002781")]
		NotAuthorized = -3,
		// Token: 0x04002782 RID: 10114
		[Token(Token = "0x4002782")]
		VersionUpdateRequired = -4,
		// Token: 0x04002783 RID: 10115
		[Token(Token = "0x4002783")]
		Timeout = -5,
		// Token: 0x04002784 RID: 10116
		[Token(Token = "0x4002784")]
		ResolutionRequired = -6
	}
}
