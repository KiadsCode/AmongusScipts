using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

// Token: 0x020002F1 RID: 753
[Token(Token = "0x20002F1")]
public class MatchmakerToken
{
	// Token: 0x17000276 RID: 630
	// (get) Token: 0x06001095 RID: 4245 RVA: 0x00005DA8 File Offset: 0x00003FA8
	[Token(Token = "0x17000276")]
	[JsonIgnore]
	public bool IsValid
	{
		[Token(Token = "0x6001095")]
		[Address(RVA = "0x76C020", Offset = "0x76B420", VA = "0x1076C020")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06001096 RID: 4246 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001096")]
	[Address(RVA = "0x399E90", Offset = "0x399290", VA = "0x10399E90")]
	[JsonConstructor]
	public MatchmakerToken(MatchmakerTokenPayload content, string hash)
	{
	}

	// Token: 0x06001097 RID: 4247 RVA: 0x00005DC0 File Offset: 0x00003FC0
	[Token(Token = "0x6001097")]
	[Address(RVA = "0x76BE70", Offset = "0x76B270", VA = "0x1076BE70")]
	public static bool TryParse(string base64Json, out MatchmakerToken token)
	{
		return default(bool);
	}

	// Token: 0x04001044 RID: 4164
	[Token(Token = "0x4001044")]
	[FieldOffset(Offset = "0x8")]
	public readonly MatchmakerTokenPayload Content;

	// Token: 0x04001045 RID: 4165
	[Token(Token = "0x4001045")]
	[FieldOffset(Offset = "0xC")]
	public readonly string Hash;
}
