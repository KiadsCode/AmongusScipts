using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Nearby
{
	// Token: 0x02000663 RID: 1635
	[Token(Token = "0x2000663")]
	public struct ConnectionRequest
	{
		// Token: 0x060027EC RID: 10220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027EC")]
		[Address(RVA = "0x4211B0", Offset = "0x4205B0", VA = "0x104211B0")]
		public ConnectionRequest(string remoteEndpointId, string remoteEndpointName, string serviceId, byte[] payload)
		{
		}

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x060027ED RID: 10221 RVA: 0x0000BCD0 File Offset: 0x00009ED0
		[Token(Token = "0x17000850")]
		public EndpointDetails RemoteEndpoint
		{
			[Token(Token = "0x60027ED")]
			[Address(RVA = "0x406740", Offset = "0x405B40", VA = "0x10406740")]
			get
			{
				return default(EndpointDetails);
			}
		}

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x060027EE RID: 10222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000851")]
		public byte[] Payload
		{
			[Token(Token = "0x60027EE")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90")]
			get
			{
				return null;
			}
		}

		// Token: 0x040027FC RID: 10236
		[Token(Token = "0x40027FC")]
		[FieldOffset(Offset = "0x0")]
		private readonly EndpointDetails mRemoteEndpoint;

		// Token: 0x040027FD RID: 10237
		[Token(Token = "0x40027FD")]
		[FieldOffset(Offset = "0xC")]
		private readonly byte[] mPayload;
	}
}
