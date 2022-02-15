using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000380 RID: 896
[Token(Token = "0x2000380")]
public class DeferredSaveHandler : DestroyableSingleton<DeferredSaveHandler>
{
	// Token: 0x06001349 RID: 4937 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001349")]
	[Address(RVA = "0x5C5B20", Offset = "0x5C4F20", VA = "0x105C5B20")]
	public DeferredSaveHandler()
	{
	}

	// Token: 0x0400138D RID: 5005
	[Token(Token = "0x400138D")]
	[FieldOffset(Offset = "0x10")]
	public bool savePlayerPrefs;

	// Token: 0x0400138E RID: 5006
	[Token(Token = "0x400138E")]
	[FieldOffset(Offset = "0x11")]
	public bool saveSecureData;

	// Token: 0x0400138F RID: 5007
	[Token(Token = "0x400138F")]
	[FieldOffset(Offset = "0x12")]
	public bool saveAnnouncements;

	// Token: 0x04001390 RID: 5008
	[Token(Token = "0x4001390")]
	[FieldOffset(Offset = "0x13")]
	public bool saveQuickChatFavorites;

	// Token: 0x04001391 RID: 5009
	[Token(Token = "0x4001391")]
	[FieldOffset(Offset = "0x14")]
	public List<DeferredSaveHandler.GameOptionsSaveRequest> saveGameOptions;

	// Token: 0x02000381 RID: 897
	[Token(Token = "0x2000381")]
	public struct GameOptionsSaveRequest : IEquatable<DeferredSaveHandler.GameOptionsSaveRequest>
	{
		// Token: 0x0600134A RID: 4938 RVA: 0x000066F0 File Offset: 0x000048F0
		[Token(Token = "0x600134A")]
		[Address(RVA = "0x780CF0", Offset = "0x7800F0", VA = "0x10780CF0", Slot = "4")]
		public bool Equals(DeferredSaveHandler.GameOptionsSaveRequest other)
		{
			return default(bool);
		}

		// Token: 0x04001392 RID: 5010
		[Token(Token = "0x4001392")]
		[FieldOffset(Offset = "0x0")]
		public string filename;

		// Token: 0x04001393 RID: 5011
		[Token(Token = "0x4001393")]
		[FieldOffset(Offset = "0x4")]
		public GameOptionsData data;
	}
}
