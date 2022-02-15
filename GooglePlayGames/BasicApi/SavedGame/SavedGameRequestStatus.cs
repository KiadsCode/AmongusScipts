using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.SavedGame
{
	// Token: 0x0200065A RID: 1626
	[Token(Token = "0x200065A")]
	public enum SavedGameRequestStatus
	{
		// Token: 0x040027E3 RID: 10211
		[Token(Token = "0x40027E3")]
		Success = 1,
		// Token: 0x040027E4 RID: 10212
		[Token(Token = "0x40027E4")]
		TimeoutError = -1,
		// Token: 0x040027E5 RID: 10213
		[Token(Token = "0x40027E5")]
		InternalError = -2,
		// Token: 0x040027E6 RID: 10214
		[Token(Token = "0x40027E6")]
		AuthenticationError = -3,
		// Token: 0x040027E7 RID: 10215
		[Token(Token = "0x40027E7")]
		BadInputError = -4
	}
}
