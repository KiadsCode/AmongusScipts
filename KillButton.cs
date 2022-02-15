using System;
using Il2CppDummyDll;

// Token: 0x020001D5 RID: 469
[Token(Token = "0x20001D5")]
public class KillButton : ActionButton
{
	// Token: 0x06000A91 RID: 2705 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A91")]
	[Address(RVA = "0x6D6860", Offset = "0x6D5C60", VA = "0x106D6860", Slot = "4")]
	public override void DoClick()
	{
	}

	// Token: 0x06000A92 RID: 2706 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A92")]
	[Address(RVA = "0x6D69B0", Offset = "0x6D5DB0", VA = "0x106D69B0")]
	public void SetTarget(PlayerControl target)
	{
	}

	// Token: 0x06000A93 RID: 2707 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A93")]
	[Address(RVA = "0x6D6C30", Offset = "0x6D6030", VA = "0x106D6C30")]
	private void Start()
	{
	}

	// Token: 0x06000A94 RID: 2708 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A94")]
	[Address(RVA = "0x3AC2A0", Offset = "0x3AB6A0", VA = "0x103AC2A0")]
	public KillButton()
	{
	}

	// Token: 0x04000AAB RID: 2731
	[Token(Token = "0x4000AAB")]
	[FieldOffset(Offset = "0x2C")]
	private PlayerControl currentTarget;
}
