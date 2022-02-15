using System;
using Il2CppDummyDll;

// Token: 0x0200049A RID: 1178
[Token(Token = "0x200049A")]
public interface ICriticalSabotage
{
	// Token: 0x17000391 RID: 913
	// (get) Token: 0x0600190A RID: 6410
	[Token(Token = "0x17000391")]
	bool IsActive { [Token(Token = "0x600190A")] get; }

	// Token: 0x17000392 RID: 914
	// (get) Token: 0x0600190B RID: 6411
	[Token(Token = "0x17000392")]
	float Countdown { [Token(Token = "0x600190B")] get; }

	// Token: 0x17000393 RID: 915
	// (get) Token: 0x0600190C RID: 6412
	[Token(Token = "0x17000393")]
	int UserCount { [Token(Token = "0x600190C")] get; }

	// Token: 0x0600190D RID: 6413
	[Token(Token = "0x600190D")]
	void ClearSabotage();
}
