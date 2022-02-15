using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.SavedGame
{
	// Token: 0x0200065F RID: 1631
	[Token(Token = "0x200065F")]
	public interface ISavedGameMetadata
	{
		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x060027D7 RID: 10199
		[Token(Token = "0x17000841")]
		bool IsOpen { [Token(Token = "0x60027D7")] get; }

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x060027D8 RID: 10200
		[Token(Token = "0x17000842")]
		string Filename { [Token(Token = "0x60027D8")] get; }

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x060027D9 RID: 10201
		[Token(Token = "0x17000843")]
		string Description { [Token(Token = "0x60027D9")] get; }

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x060027DA RID: 10202
		[Token(Token = "0x17000844")]
		string CoverImageURL { [Token(Token = "0x60027DA")] get; }

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x060027DB RID: 10203
		[Token(Token = "0x17000845")]
		TimeSpan TotalTimePlayed { [Token(Token = "0x60027DB")] get; }

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x060027DC RID: 10204
		[Token(Token = "0x17000846")]
		DateTime LastModifiedTimestamp { [Token(Token = "0x60027DC")] get; }
	}
}
