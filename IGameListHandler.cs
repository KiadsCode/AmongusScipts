using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using InnerNet;

// Token: 0x020002D0 RID: 720
[Token(Token = "0x20002D0")]
public interface IGameListHandler
{
	// Token: 0x06000FE8 RID: 4072
	[Token(Token = "0x6000FE8")]
	void HandleList(InnerNetClient.TotalGameData totalGames, List<GameListing> availableGames);
}
