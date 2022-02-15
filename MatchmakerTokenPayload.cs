using System;
using Il2CppDummyDll;

// Token: 0x020002F2 RID: 754
[Token(Token = "0x20002F2")]
public class MatchmakerTokenPayload
{
	// Token: 0x06001098 RID: 4248 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001098")]
	[Address(RVA = "0x76BE40", Offset = "0x76B240", VA = "0x1076BE40")]
	public MatchmakerTokenPayload(string puid, int clientVersion, DateTime expiresAt)
	{
	}

	// Token: 0x04001046 RID: 4166
	[Token(Token = "0x4001046")]
	[FieldOffset(Offset = "0x8")]
	public readonly string Puid;

	// Token: 0x04001047 RID: 4167
	[Token(Token = "0x4001047")]
	[FieldOffset(Offset = "0xC")]
	public readonly int ClientVersion;

	// Token: 0x04001048 RID: 4168
	[Token(Token = "0x4001048")]
	[FieldOffset(Offset = "0x10")]
	public readonly DateTime ExpiresAt;
}
