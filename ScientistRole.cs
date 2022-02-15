using System;
using Il2CppDummyDll;

// Token: 0x02000444 RID: 1092
[Token(Token = "0x2000444")]
public class ScientistRole : RoleBehaviour
{
	// Token: 0x17000341 RID: 833
	// (get) Token: 0x060016F7 RID: 5879 RVA: 0x00007470 File Offset: 0x00005670
	[Token(Token = "0x17000341")]
	private bool IsCoolingDown
	{
		[Token(Token = "0x60016F7")]
		[Address(RVA = "0x58B4E0", Offset = "0x58A8E0", VA = "0x1058B4E0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060016F8 RID: 5880 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016F8")]
	[Address(RVA = "0x58ADA0", Offset = "0x58A1A0", VA = "0x1058ADA0", Slot = "11")]
	public override void Initialize(PlayerControl player)
	{
	}

	// Token: 0x060016F9 RID: 5881 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016F9")]
	[Address(RVA = "0x58ADC0", Offset = "0x58A1C0", VA = "0x1058ADC0", Slot = "10")]
	public override void OnVotingComplete()
	{
	}

	// Token: 0x060016FA RID: 5882 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016FA")]
	[Address(RVA = "0x58AFE0", Offset = "0x58A3E0", VA = "0x1058AFE0")]
	private void Update()
	{
	}

	// Token: 0x060016FB RID: 5883 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016FB")]
	[Address(RVA = "0x58AEC0", Offset = "0x58A2C0", VA = "0x1058AEC0")]
	public void Recharge()
	{
	}

	// Token: 0x060016FC RID: 5884 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016FC")]
	[Address(RVA = "0x58B2A0", Offset = "0x58A6A0", VA = "0x1058B2A0", Slot = "8")]
	public override void UseAbility()
	{
	}

	// Token: 0x060016FD RID: 5885 RVA: 0x00007488 File Offset: 0x00005688
	[Token(Token = "0x60016FD")]
	[Address(RVA = "0x58ACD0", Offset = "0x58A0D0", VA = "0x1058ACD0", Slot = "4")]
	public override bool CanUse(IUsable console)
	{
		return default(bool);
	}

	// Token: 0x060016FE RID: 5886 RVA: 0x000074A0 File Offset: 0x000056A0
	[Token(Token = "0x60016FE")]
	[Address(RVA = "0x58AD50", Offset = "0x58A150", VA = "0x1058AD50", Slot = "5")]
	public override bool DidWin(GameOverReason gameOverReason)
	{
		return default(bool);
	}

	// Token: 0x060016FF RID: 5887 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016FF")]
	[Address(RVA = "0x58AF40", Offset = "0x58A340", VA = "0x1058AF40")]
	private void RefreshAbilityButton()
	{
	}

	// Token: 0x06001700 RID: 5888 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001700")]
	[Address(RVA = "0x57A8D0", Offset = "0x579CD0", VA = "0x1057A8D0")]
	public ScientistRole()
	{
	}

	// Token: 0x04001745 RID: 5957
	[Token(Token = "0x4001745")]
	[FieldOffset(Offset = "0x50")]
	public VitalsMinigame VitalsPrefab;

	// Token: 0x04001746 RID: 5958
	[Token(Token = "0x4001746")]
	[FieldOffset(Offset = "0x54")]
	private VitalsMinigame minigame;

	// Token: 0x04001747 RID: 5959
	[Token(Token = "0x4001747")]
	[FieldOffset(Offset = "0x58")]
	private float currentCharge;

	// Token: 0x04001748 RID: 5960
	[Token(Token = "0x4001748")]
	[FieldOffset(Offset = "0x5C")]
	private float currentCooldown;
}
