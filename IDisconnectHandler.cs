using System;
using Il2CppDummyDll;

// Token: 0x02000261 RID: 609
[Token(Token = "0x2000261")]
public interface IDisconnectHandler
{
	// Token: 0x06000DA0 RID: 3488
	[Token(Token = "0x6000DA0")]
	void HandleDisconnect(PlayerControl pc, DisconnectReasons reason);

	// Token: 0x06000DA1 RID: 3489
	[Token(Token = "0x6000DA1")]
	void HandleDisconnect();
}
