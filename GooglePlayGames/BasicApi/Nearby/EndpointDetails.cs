using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Nearby
{
	// Token: 0x02000666 RID: 1638
	[Token(Token = "0x2000666")]
	public struct EndpointDetails
	{
		// Token: 0x060027FB RID: 10235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027FB")]
		[Address(RVA = "0x47A880", Offset = "0x479C80", VA = "0x1047A880")]
		public EndpointDetails(string endpointId, string name, string serviceId)
		{
		}

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x060027FC RID: 10236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000856")]
		public string EndpointId
		{
			[Token(Token = "0x60027FC")]
			[Address(RVA = "0x273B70", Offset = "0x272F70", VA = "0x10273B70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x060027FD RID: 10237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000857")]
		public string Name
		{
			[Token(Token = "0x60027FD")]
			[Address(RVA = "0x273A70", Offset = "0x272E70", VA = "0x10273A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x060027FE RID: 10238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000858")]
		public string ServiceId
		{
			[Token(Token = "0x60027FE")]
			[Address(RVA = "0x273EB0", Offset = "0x2732B0", VA = "0x10273EB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400280A RID: 10250
		[Token(Token = "0x400280A")]
		[FieldOffset(Offset = "0x0")]
		private readonly string mEndpointId;

		// Token: 0x0400280B RID: 10251
		[Token(Token = "0x400280B")]
		[FieldOffset(Offset = "0x4")]
		private readonly string mName;

		// Token: 0x0400280C RID: 10252
		[Token(Token = "0x400280C")]
		[FieldOffset(Offset = "0x8")]
		private readonly string mServiceId;
	}
}
