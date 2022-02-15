using System;
using Il2CppDummyDll;

// Token: 0x0200049D RID: 1181
[Token(Token = "0x200049D")]
public interface IUsable
{
	// Token: 0x17000397 RID: 919
	// (get) Token: 0x0600191A RID: 6426
	[Token(Token = "0x17000397")]
	float UsableDistance { [Token(Token = "0x600191A")] get; }

	// Token: 0x17000398 RID: 920
	// (get) Token: 0x0600191B RID: 6427
	[Token(Token = "0x17000398")]
	float PercentCool { [Token(Token = "0x600191B")] get; }

	// Token: 0x17000399 RID: 921
	// (get) Token: 0x0600191C RID: 6428
	[Token(Token = "0x17000399")]
	ImageNames UseIcon { [Token(Token = "0x600191C")] get; }

	// Token: 0x0600191D RID: 6429
	[Token(Token = "0x600191D")]
	void SetOutline(bool on, bool mainTarget);

	// Token: 0x0600191E RID: 6430
	[Token(Token = "0x600191E")]
	float CanUse(GameData.PlayerInfo pc, out bool canUse, out bool couldUse);

	// Token: 0x0600191F RID: 6431
	[Token(Token = "0x600191F")]
	void Use();
}
