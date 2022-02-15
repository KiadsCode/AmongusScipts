using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Nearby
{
	// Token: 0x0200066A RID: 1642
	[Token(Token = "0x200066A")]
	public struct NearbyConnectionConfiguration
	{
		// Token: 0x06002803 RID: 10243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002803")]
		[Address(RVA = "0x777B90", Offset = "0x776F90", VA = "0x10777B90")]
		public NearbyConnectionConfiguration(Action<InitializationStatus> callback, long localClientId)
		{
		}

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x06002804 RID: 10244 RVA: 0x0000BDA8 File Offset: 0x00009FA8
		[Token(Token = "0x17000859")]
		public long LocalClientId
		{
			[Token(Token = "0x6002804")]
			[Address(RVA = "0x28DA90", Offset = "0x28CE90", VA = "0x1028DA90")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x06002805 RID: 10245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700085A")]
		public Action<InitializationStatus> InitializationCallback
		{
			[Token(Token = "0x6002805")]
			[Address(RVA = "0x273B70", Offset = "0x272F70", VA = "0x10273B70")]
			get
			{
				return null;
			}
		}

		// Token: 0x04002811 RID: 10257
		[Token(Token = "0x4002811")]
		public const int MaxUnreliableMessagePayloadLength = 1168;

		// Token: 0x04002812 RID: 10258
		[Token(Token = "0x4002812")]
		public const int MaxReliableMessagePayloadLength = 4096;

		// Token: 0x04002813 RID: 10259
		[Token(Token = "0x4002813")]
		[FieldOffset(Offset = "0x0")]
		private readonly Action<InitializationStatus> mInitializationCallback;

		// Token: 0x04002814 RID: 10260
		[Token(Token = "0x4002814")]
		[FieldOffset(Offset = "0x8")]
		private readonly long mLocalClientId;
	}
}
