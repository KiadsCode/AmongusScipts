using System;
using Il2CppDummyDll;

// Token: 0x02000434 RID: 1076
[Token(Token = "0x2000434")]
public class CrewmateRole : RoleBehaviour
{
	// Token: 0x060016A8 RID: 5800 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016A8")]
	[Address(RVA = "0x5B9990", Offset = "0x5B8D90", VA = "0x105B9990", Slot = "11")]
	public override void Initialize(PlayerControl player)
	{
	}

	// Token: 0x060016A9 RID: 5801 RVA: 0x000071D0 File Offset: 0x000053D0
	[Token(Token = "0x60016A9")]
	[Address(RVA = "0x5B98C0", Offset = "0x5B8CC0", VA = "0x105B98C0", Slot = "4")]
	public override bool CanUse(IUsable console)
	{
		return default(bool);
	}

	// Token: 0x060016AA RID: 5802 RVA: 0x000071E8 File Offset: 0x000053E8
	[Token(Token = "0x60016AA")]
	[Address(RVA = "0x5B9940", Offset = "0x5B8D40", VA = "0x105B9940", Slot = "5")]
	public override bool DidWin(GameOverReason gameOverReason)
	{
		return default(bool);
	}

	// Token: 0x060016AB RID: 5803 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016AB")]
	[Address(RVA = "0x3B8460", Offset = "0x3B7860", VA = "0x103B8460")]
	public CrewmateRole()
	{
	}
}
