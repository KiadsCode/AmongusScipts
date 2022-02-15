using System;
using Il2CppDummyDll;

// Token: 0x02000435 RID: 1077
[Token(Token = "0x2000435")]
public class EngineerRole : RoleBehaviour
{
	// Token: 0x17000336 RID: 822
	// (get) Token: 0x060016AC RID: 5804 RVA: 0x00007200 File Offset: 0x00005400
	[Token(Token = "0x17000336")]
	private bool IsCoolingDown
	{
		[Token(Token = "0x60016AC")]
		[Address(RVA = "0x3B8470", Offset = "0x3B7870", VA = "0x103B8470")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060016AD RID: 5805 RVA: 0x00007218 File Offset: 0x00005418
	[Token(Token = "0x60016AD")]
	[Address(RVA = "0x47AF70", Offset = "0x47A370", VA = "0x1047AF70", Slot = "4")]
	public override bool CanUse(IUsable console)
	{
		return default(bool);
	}

	// Token: 0x060016AE RID: 5806 RVA: 0x00007230 File Offset: 0x00005430
	[Token(Token = "0x60016AE")]
	[Address(RVA = "0x47B060", Offset = "0x47A460", VA = "0x1047B060", Slot = "5")]
	public override bool DidWin(GameOverReason gameOverReason)
	{
		return default(bool);
	}

	// Token: 0x060016AF RID: 5807 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016AF")]
	[Address(RVA = "0x47B5B0", Offset = "0x47A9B0", VA = "0x1047B5B0", Slot = "12")]
	public override void SetUsableTarget(IUsable target)
	{
	}

	// Token: 0x060016B0 RID: 5808 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016B0")]
	[Address(RVA = "0x47B6B0", Offset = "0x47AAB0", VA = "0x1047B6B0", Slot = "8")]
	public override void UseAbility()
	{
	}

	// Token: 0x060016B1 RID: 5809 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016B1")]
	[Address(RVA = "0x47B4E0", Offset = "0x47A8E0", VA = "0x1047B4E0", Slot = "14")]
	public override void SetCooldown()
	{
	}

	// Token: 0x060016B2 RID: 5810 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016B2")]
	[Address(RVA = "0x47B3B0", Offset = "0x47A7B0", VA = "0x1047B3B0", Slot = "10")]
	public override void OnVotingComplete()
	{
	}

	// Token: 0x060016B3 RID: 5811 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016B3")]
	[Address(RVA = "0x47B0B0", Offset = "0x47A4B0", VA = "0x1047B0B0")]
	private void FixedUpdate()
	{
	}

	// Token: 0x060016B4 RID: 5812 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016B4")]
	[Address(RVA = "0x3B8460", Offset = "0x3B7860", VA = "0x103B8460")]
	public EngineerRole()
	{
	}

	// Token: 0x0400170F RID: 5903
	[Token(Token = "0x400170F")]
	[FieldOffset(Offset = "0x50")]
	private Vent currentTarget;

	// Token: 0x04001710 RID: 5904
	[Token(Token = "0x4001710")]
	[FieldOffset(Offset = "0x54")]
	private float cooldownSecondsRemaining;

	// Token: 0x04001711 RID: 5905
	[Token(Token = "0x4001711")]
	[FieldOffset(Offset = "0x58")]
	private float inVentTimeRemaining;
}
