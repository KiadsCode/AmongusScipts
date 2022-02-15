using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.SavedGame
{
	// Token: 0x0200065B RID: 1627
	[Token(Token = "0x200065B")]
	public enum SelectUIStatus
	{
		// Token: 0x040027E9 RID: 10217
		[Token(Token = "0x40027E9")]
		SavedGameSelected = 1,
		// Token: 0x040027EA RID: 10218
		[Token(Token = "0x40027EA")]
		UserClosedUI,
		// Token: 0x040027EB RID: 10219
		[Token(Token = "0x40027EB")]
		InternalError = -1,
		// Token: 0x040027EC RID: 10220
		[Token(Token = "0x40027EC")]
		TimeoutError = -2,
		// Token: 0x040027ED RID: 10221
		[Token(Token = "0x40027ED")]
		AuthenticationError = -3,
		// Token: 0x040027EE RID: 10222
		[Token(Token = "0x40027EE")]
		BadInputError = -4,
		// Token: 0x040027EF RID: 10223
		[Token(Token = "0x40027EF")]
		UiBusy = -5
	}
}
