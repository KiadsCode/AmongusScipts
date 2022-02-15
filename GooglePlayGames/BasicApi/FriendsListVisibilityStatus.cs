using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi
{
	// Token: 0x0200064A RID: 1610
	[Token(Token = "0x200064A")]
	public enum FriendsListVisibilityStatus
	{
		// Token: 0x04002799 RID: 10137
		[Token(Token = "0x4002799")]
		Unknown,
		// Token: 0x0400279A RID: 10138
		[Token(Token = "0x400279A")]
		Visible,
		// Token: 0x0400279B RID: 10139
		[Token(Token = "0x400279B")]
		ResolutionRequired,
		// Token: 0x0400279C RID: 10140
		[Token(Token = "0x400279C")]
		Unavailable,
		// Token: 0x0400279D RID: 10141
		[Token(Token = "0x400279D")]
		NetworkError = -4,
		// Token: 0x0400279E RID: 10142
		[Token(Token = "0x400279E")]
		NotAuthorized = -5
	}
}
