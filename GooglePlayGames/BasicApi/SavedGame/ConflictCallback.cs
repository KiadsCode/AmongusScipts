using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.SavedGame
{
	// Token: 0x0200065C RID: 1628
	// (Invoke) Token: 0x060027CB RID: 10187
	[Token(Token = "0x200065C")]
	public delegate void ConflictCallback(IConflictResolver resolver, ISavedGameMetadata original, byte[] originalData, ISavedGameMetadata unmerged, byte[] unmergedData);
}
