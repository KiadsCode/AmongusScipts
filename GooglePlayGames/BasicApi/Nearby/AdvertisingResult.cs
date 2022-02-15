using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Nearby
{
	// Token: 0x02000662 RID: 1634
	[Token(Token = "0x2000662")]
	public struct AdvertisingResult
	{
		// Token: 0x060027E8 RID: 10216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E8")]
		[Address(RVA = "0x543700", Offset = "0x542B00", VA = "0x10543700")]
		public AdvertisingResult(ResponseStatus status, string localEndpointName)
		{
		}

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x060027E9 RID: 10217 RVA: 0x0000BCA0 File Offset: 0x00009EA0
		[Token(Token = "0x1700084D")]
		public bool Succeeded
		{
			[Token(Token = "0x60027E9")]
			[Address(RVA = "0x543740", Offset = "0x542B40", VA = "0x10543740")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x060027EA RID: 10218 RVA: 0x0000BCB8 File Offset: 0x00009EB8
		[Token(Token = "0x1700084E")]
		public ResponseStatus Status
		{
			[Token(Token = "0x60027EA")]
			[Address(RVA = "0x273B70", Offset = "0x272F70", VA = "0x10273B70")]
			get
			{
				return (ResponseStatus)0;
			}
		}

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x060027EB RID: 10219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700084F")]
		public string LocalEndpointName
		{
			[Token(Token = "0x60027EB")]
			[Address(RVA = "0x273A70", Offset = "0x272E70", VA = "0x10273A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x040027FA RID: 10234
		[Token(Token = "0x40027FA")]
		[FieldOffset(Offset = "0x0")]
		private readonly ResponseStatus mStatus;

		// Token: 0x040027FB RID: 10235
		[Token(Token = "0x40027FB")]
		[FieldOffset(Offset = "0x4")]
		private readonly string mLocalEndpointName;
	}
}
