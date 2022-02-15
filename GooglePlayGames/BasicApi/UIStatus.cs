using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi
{
	// Token: 0x02000646 RID: 1606
	[Token(Token = "0x2000646")]
	public enum UIStatus
	{
		// Token: 0x04002786 RID: 10118
		[Token(Token = "0x4002786")]
		Valid = 1,
		// Token: 0x04002787 RID: 10119
		[Token(Token = "0x4002787")]
		InternalError = -2,
		// Token: 0x04002788 RID: 10120
		[Token(Token = "0x4002788")]
		NotAuthorized = -3,
		// Token: 0x04002789 RID: 10121
		[Token(Token = "0x4002789")]
		VersionUpdateRequired = -4,
		// Token: 0x0400278A RID: 10122
		[Token(Token = "0x400278A")]
		Timeout = -5,
		// Token: 0x0400278B RID: 10123
		[Token(Token = "0x400278B")]
		UserClosedUI = -6,
		// Token: 0x0400278C RID: 10124
		[Token(Token = "0x400278C")]
		UiBusy = -12,
		// Token: 0x0400278D RID: 10125
		[Token(Token = "0x400278D")]
		NetworkError = -20
	}
}
