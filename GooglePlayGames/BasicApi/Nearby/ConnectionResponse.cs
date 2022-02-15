using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Nearby
{
	// Token: 0x02000664 RID: 1636
	[Token(Token = "0x2000664")]
	public struct ConnectionResponse
	{
		// Token: 0x060027EF RID: 10223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027EF")]
		[Address(RVA = "0x421560", Offset = "0x420960", VA = "0x10421560")]
		private ConnectionResponse(long localClientId, string remoteEndpointId, ConnectionResponse.Status code, byte[] payload)
		{
		}

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x060027F0 RID: 10224 RVA: 0x0000BCE8 File Offset: 0x00009EE8
		[Token(Token = "0x17000852")]
		public long LocalClientId
		{
			[Token(Token = "0x60027F0")]
			[Address(RVA = "0x4158D0", Offset = "0x414CD0", VA = "0x104158D0")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x060027F1 RID: 10225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000853")]
		public string RemoteEndpointId
		{
			[Token(Token = "0x60027F1")]
			[Address(RVA = "0x273EB0", Offset = "0x2732B0", VA = "0x10273EB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x060027F2 RID: 10226 RVA: 0x0000BD00 File Offset: 0x00009F00
		[Token(Token = "0x17000854")]
		public ConnectionResponse.Status ResponseStatus
		{
			[Token(Token = "0x60027F2")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90")]
			get
			{
				return ConnectionResponse.Status.Accepted;
			}
		}

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x060027F3 RID: 10227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000855")]
		public byte[] Payload
		{
			[Token(Token = "0x60027F3")]
			[Address(RVA = "0x273EC0", Offset = "0x2732C0", VA = "0x10273EC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060027F4 RID: 10228 RVA: 0x0000BD18 File Offset: 0x00009F18
		[Token(Token = "0x60027F4")]
		[Address(RVA = "0x421490", Offset = "0x420890", VA = "0x10421490")]
		public static ConnectionResponse Rejected(long localClientId, string remoteEndpointId)
		{
			return default(ConnectionResponse);
		}

		// Token: 0x060027F5 RID: 10229 RVA: 0x0000BD30 File Offset: 0x00009F30
		[Token(Token = "0x60027F5")]
		[Address(RVA = "0x421410", Offset = "0x420810", VA = "0x10421410")]
		public static ConnectionResponse NetworkNotConnected(long localClientId, string remoteEndpointId)
		{
			return default(ConnectionResponse);
		}

		// Token: 0x060027F6 RID: 10230 RVA: 0x0000BD48 File Offset: 0x00009F48
		[Token(Token = "0x60027F6")]
		[Address(RVA = "0x421390", Offset = "0x420790", VA = "0x10421390")]
		public static ConnectionResponse InternalError(long localClientId, string remoteEndpointId)
		{
			return default(ConnectionResponse);
		}

		// Token: 0x060027F7 RID: 10231 RVA: 0x0000BD60 File Offset: 0x00009F60
		[Token(Token = "0x60027F7")]
		[Address(RVA = "0x421310", Offset = "0x420710", VA = "0x10421310")]
		public static ConnectionResponse EndpointNotConnected(long localClientId, string remoteEndpointId)
		{
			return default(ConnectionResponse);
		}

		// Token: 0x060027F8 RID: 10232 RVA: 0x0000BD78 File Offset: 0x00009F78
		[Token(Token = "0x60027F8")]
		[Address(RVA = "0x421260", Offset = "0x420660", VA = "0x10421260")]
		public static ConnectionResponse Accepted(long localClientId, string remoteEndpointId, byte[] payload)
		{
			return default(ConnectionResponse);
		}

		// Token: 0x060027F9 RID: 10233 RVA: 0x0000BD90 File Offset: 0x00009F90
		[Token(Token = "0x60027F9")]
		[Address(RVA = "0x421290", Offset = "0x420690", VA = "0x10421290")]
		public static ConnectionResponse AlreadyConnected(long localClientId, string remoteEndpointId)
		{
			return default(ConnectionResponse);
		}

		// Token: 0x040027FE RID: 10238
		[Token(Token = "0x40027FE")]
		[FieldOffset(Offset = "0x0")]
		private static readonly byte[] EmptyPayload;

		// Token: 0x040027FF RID: 10239
		[Token(Token = "0x40027FF")]
		[FieldOffset(Offset = "0x0")]
		private readonly long mLocalClientId;

		// Token: 0x04002800 RID: 10240
		[Token(Token = "0x4002800")]
		[FieldOffset(Offset = "0x8")]
		private readonly string mRemoteEndpointId;

		// Token: 0x04002801 RID: 10241
		[Token(Token = "0x4002801")]
		[FieldOffset(Offset = "0xC")]
		private readonly ConnectionResponse.Status mResponseStatus;

		// Token: 0x04002802 RID: 10242
		[Token(Token = "0x4002802")]
		[FieldOffset(Offset = "0x10")]
		private readonly byte[] mPayload;

		// Token: 0x02000665 RID: 1637
		[Token(Token = "0x2000665")]
		public enum Status
		{
			// Token: 0x04002804 RID: 10244
			[Token(Token = "0x4002804")]
			Accepted,
			// Token: 0x04002805 RID: 10245
			[Token(Token = "0x4002805")]
			Rejected,
			// Token: 0x04002806 RID: 10246
			[Token(Token = "0x4002806")]
			ErrorInternal,
			// Token: 0x04002807 RID: 10247
			[Token(Token = "0x4002807")]
			ErrorNetworkNotConnected,
			// Token: 0x04002808 RID: 10248
			[Token(Token = "0x4002808")]
			ErrorEndpointNotConnected,
			// Token: 0x04002809 RID: 10249
			[Token(Token = "0x4002809")]
			ErrorAlreadyConnected
		}
	}
}
