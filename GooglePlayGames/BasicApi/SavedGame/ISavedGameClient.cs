using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.SavedGame
{
	// Token: 0x0200065D RID: 1629
	[Token(Token = "0x200065D")]
	public interface ISavedGameClient
	{
		// Token: 0x060027CE RID: 10190
		[Token(Token = "0x60027CE")]
		void OpenWithAutomaticConflictResolution(string filename, DataSource source, ConflictResolutionStrategy resolutionStrategy, Action<SavedGameRequestStatus, ISavedGameMetadata> callback);

		// Token: 0x060027CF RID: 10191
		[Token(Token = "0x60027CF")]
		void OpenWithManualConflictResolution(string filename, DataSource source, bool prefetchDataOnConflict, ConflictCallback conflictCallback, Action<SavedGameRequestStatus, ISavedGameMetadata> completedCallback);

		// Token: 0x060027D0 RID: 10192
		[Token(Token = "0x60027D0")]
		void ReadBinaryData(ISavedGameMetadata metadata, Action<SavedGameRequestStatus, byte[]> completedCallback);

		// Token: 0x060027D1 RID: 10193
		[Token(Token = "0x60027D1")]
		void ShowSelectSavedGameUI(string uiTitle, uint maxDisplayedSavedGames, bool showCreateSaveUI, bool showDeleteSaveUI, Action<SelectUIStatus, ISavedGameMetadata> callback);

		// Token: 0x060027D2 RID: 10194
		[Token(Token = "0x60027D2")]
		void CommitUpdate(ISavedGameMetadata metadata, SavedGameMetadataUpdate updateForMetadata, byte[] updatedBinaryData, Action<SavedGameRequestStatus, ISavedGameMetadata> callback);

		// Token: 0x060027D3 RID: 10195
		[Token(Token = "0x60027D3")]
		void FetchAllSavedGames(DataSource source, Action<SavedGameRequestStatus, List<ISavedGameMetadata>> callback);

		// Token: 0x060027D4 RID: 10196
		[Token(Token = "0x60027D4")]
		void Delete(ISavedGameMetadata metadata);
	}
}
