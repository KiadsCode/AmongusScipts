using System;
using Il2CppDummyDll;

// Token: 0x02000436 RID: 1078
[Token(Token = "0x2000436")]
public class GuardianAngelRole : RoleBehaviour
{
	// Token: 0x17000337 RID: 823
	// (get) Token: 0x060016B5 RID: 5813 RVA: 0x00007248 File Offset: 0x00005448
	[Token(Token = "0x17000337")]
	private bool IsCoolingDown
	{
		[Token(Token = "0x60016B5")]
		[Address(RVA = "0x3B8470", Offset = "0x3B7870", VA = "0x103B8470")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060016B6 RID: 5814 RVA: 0x00007260 File Offset: 0x00005460
	[Token(Token = "0x60016B6")]
	[Address(RVA = "0x3B7D90", Offset = "0x3B7190", VA = "0x103B7D90", Slot = "4")]
	public override bool CanUse(IUsable console)
	{
		return default(bool);
	}

	// Token: 0x060016B7 RID: 5815 RVA: 0x00007278 File Offset: 0x00005478
	[Token(Token = "0x60016B7")]
	[Address(RVA = "0x3B7E10", Offset = "0x3B7210", VA = "0x103B7E10", Slot = "5")]
	public override bool DidWin(GameOverReason gameOverReason)
	{
		return default(bool);
	}

	// Token: 0x060016B8 RID: 5816 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016B8")]
	[Address(RVA = "0x3B8290", Offset = "0x3B7690", VA = "0x103B8290", Slot = "8")]
	public override void UseAbility()
	{
	}

	// Token: 0x060016B9 RID: 5817 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016B9")]
	[Address(RVA = "0x3B80B0", Offset = "0x3B74B0", VA = "0x103B80B0", Slot = "13")]
	public override void SetPlayerTarget(PlayerControl target)
	{
	}

	// Token: 0x060016BA RID: 5818 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016BA")]
	[Address(RVA = "0x3B7FE0", Offset = "0x3B73E0", VA = "0x103B7FE0", Slot = "14")]
	public override void SetCooldown()
	{
	}

	// Token: 0x060016BB RID: 5819 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016BB")]
	[Address(RVA = "0x3B7E60", Offset = "0x3B7260", VA = "0x103B7E60")]
	private void FixedUpdate()
	{
	}

	// Token: 0x060016BC RID: 5820 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016BC")]
	[Address(RVA = "0x3B8460", Offset = "0x3B7860", VA = "0x103B8460")]
	public GuardianAngelRole()
	{
	}

	// Token: 0x04001712 RID: 5906
	[Token(Token = "0x4001712")]
	[FieldOffset(Offset = "0x50")]
	private PlayerControl currentTarget;

	// Token: 0x04001713 RID: 5907
	[Token(Token = "0x4001713")]
	[FieldOffset(Offset = "0x54")]
	private float cooldownSecondsRemaining;
}
