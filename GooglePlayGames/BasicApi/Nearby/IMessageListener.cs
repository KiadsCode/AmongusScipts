using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Nearby
{
	// Token: 0x02000667 RID: 1639
	[Token(Token = "0x2000667")]
	public interface IMessageListener
	{
		// Token: 0x060027FF RID: 10239
		[Token(Token = "0x60027FF")]
		void OnMessageReceived(string remoteEndpointId, byte[] data, bool isReliableMessage);

		// Token: 0x06002800 RID: 10240
		[Token(Token = "0x6002800")]
		void OnRemoteEndpointDisconnected(string remoteEndpointId);
	}
}
