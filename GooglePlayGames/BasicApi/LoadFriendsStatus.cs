using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi
{
	// Token: 0x0200064B RID: 1611
	[Token(Token = "0x200064B")]
	public enum LoadFriendsStatus
	{
		// Token: 0x040027A0 RID: 10144
		[Token(Token = "0x40027A0")]
		Unknown,
		// Token: 0x040027A1 RID: 10145
		[Token(Token = "0x40027A1")]
		Completed,
		// Token: 0x040027A2 RID: 10146
		[Token(Token = "0x40027A2")]
		LoadMore,
		// Token: 0x040027A3 RID: 10147
		[Token(Token = "0x40027A3")]
		ResolutionRequired = -3,
		// Token: 0x040027A4 RID: 10148
		[Token(Token = "0x40027A4")]
		InternalError = -4,
		// Token: 0x040027A5 RID: 10149
		[Token(Token = "0x40027A5")]
		NotAuthorized = -5,
		// Token: 0x040027A6 RID: 10150
		[Token(Token = "0x40027A6")]
		NetworkError = -6
	}
}
