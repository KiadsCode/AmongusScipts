using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.SavedGame
{
	// Token: 0x02000659 RID: 1625
	[Token(Token = "0x2000659")]
	public enum ConflictResolutionStrategy
	{
		// Token: 0x040027DC RID: 10204
		[Token(Token = "0x40027DC")]
		UseLongestPlaytime,
		// Token: 0x040027DD RID: 10205
		[Token(Token = "0x40027DD")]
		UseOriginal,
		// Token: 0x040027DE RID: 10206
		[Token(Token = "0x40027DE")]
		UseUnmerged,
		// Token: 0x040027DF RID: 10207
		[Token(Token = "0x40027DF")]
		UseManual,
		// Token: 0x040027E0 RID: 10208
		[Token(Token = "0x40027E0")]
		UseLastKnownGood,
		// Token: 0x040027E1 RID: 10209
		[Token(Token = "0x40027E1")]
		UseMostRecentlySaved
	}
}
