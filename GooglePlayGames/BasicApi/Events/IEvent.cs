using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Events
{
	// Token: 0x0200066D RID: 1645
	[Token(Token = "0x200066D")]
	public interface IEvent
	{
		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x0600280D RID: 10253
		[Token(Token = "0x17000861")]
		string Id { [Token(Token = "0x600280D")] get; }

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x0600280E RID: 10254
		[Token(Token = "0x17000862")]
		string Name { [Token(Token = "0x600280E")] get; }

		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x0600280F RID: 10255
		[Token(Token = "0x17000863")]
		string Description { [Token(Token = "0x600280F")] get; }

		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x06002810 RID: 10256
		[Token(Token = "0x17000864")]
		string ImageUrl { [Token(Token = "0x6002810")] get; }

		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x06002811 RID: 10257
		[Token(Token = "0x17000865")]
		ulong CurrentCount { [Token(Token = "0x6002811")] get; }

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x06002812 RID: 10258
		[Token(Token = "0x17000866")]
		EventVisibility Visibility { [Token(Token = "0x6002812")] get; }
	}
}
