using System;
using Il2CppDummyDll;

namespace InnerNet
{
	// Token: 0x0200062D RID: 1581
	[Token(Token = "0x200062D")]
	public enum JoinFailureReasons : byte
	{
		// Token: 0x0400271D RID: 10013
		[Token(Token = "0x400271D")]
		TooManyPlayers = 1,
		// Token: 0x0400271E RID: 10014
		[Token(Token = "0x400271E")]
		GameStarted,
		// Token: 0x0400271F RID: 10015
		[Token(Token = "0x400271F")]
		GameNotFound,
		// Token: 0x04002720 RID: 10016
		[Token(Token = "0x4002720")]
		HostNotReady,
		// Token: 0x04002721 RID: 10017
		[Token(Token = "0x4002721")]
		IncorrectVersion,
		// Token: 0x04002722 RID: 10018
		[Token(Token = "0x4002722")]
		Banned,
		// Token: 0x04002723 RID: 10019
		[Token(Token = "0x4002723")]
		Kicked
	}
}
