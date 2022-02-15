using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Nearby
{
	// Token: 0x02000668 RID: 1640
	[Token(Token = "0x2000668")]
	public interface IDiscoveryListener
	{
		// Token: 0x06002801 RID: 10241
		[Token(Token = "0x6002801")]
		void OnEndpointFound(EndpointDetails discoveredEndpoint);

		// Token: 0x06002802 RID: 10242
		[Token(Token = "0x6002802")]
		void OnEndpointLost(string lostEndpointId);
	}
}
