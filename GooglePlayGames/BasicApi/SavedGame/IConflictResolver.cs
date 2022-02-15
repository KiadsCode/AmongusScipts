using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.SavedGame
{
	// Token: 0x0200065E RID: 1630
	[Token(Token = "0x200065E")]
	public interface IConflictResolver
	{
		// Token: 0x060027D5 RID: 10197
		[Token(Token = "0x60027D5")]
		void ChooseMetadata(ISavedGameMetadata chosenMetadata);

		// Token: 0x060027D6 RID: 10198
		[Token(Token = "0x60027D6")]
		void ResolveConflict(ISavedGameMetadata chosenMetadata, SavedGameMetadataUpdate metadataUpdate, byte[] updatedData);
	}
}
