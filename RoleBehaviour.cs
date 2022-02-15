using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000439 RID: 1081
[Token(Token = "0x2000439")]
public class RoleBehaviour : MonoBehaviour
{
	// Token: 0x17000338 RID: 824
	// (get) Token: 0x060016C6 RID: 5830 RVA: 0x000072D8 File Offset: 0x000054D8
	[Token(Token = "0x17000338")]
	public bool IsImpostor
	{
		[Token(Token = "0x60016C6")]
		[Address(RVA = "0x57ABB0", Offset = "0x579FB0", VA = "0x1057ABB0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000339 RID: 825
	// (get) Token: 0x060016C7 RID: 5831 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000339")]
	public string NiceName
	{
		[Token(Token = "0x60016C7")]
		[Address(RVA = "0x57ABE0", Offset = "0x579FE0", VA = "0x1057ABE0")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700033A RID: 826
	// (get) Token: 0x060016C8 RID: 5832 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700033A")]
	public string Blurb
	{
		[Token(Token = "0x60016C8")]
		[Address(RVA = "0x57AA10", Offset = "0x579E10", VA = "0x1057AA10")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700033B RID: 827
	// (get) Token: 0x060016C9 RID: 5833 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700033B")]
	public string BlurbMed
	{
		[Token(Token = "0x60016C9")]
		[Address(RVA = "0x57A9A0", Offset = "0x579DA0", VA = "0x1057A9A0")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700033C RID: 828
	// (get) Token: 0x060016CA RID: 5834 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700033C")]
	public string BlurbLong
	{
		[Token(Token = "0x60016CA")]
		[Address(RVA = "0x57A930", Offset = "0x579D30", VA = "0x1057A930")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700033D RID: 829
	// (get) Token: 0x060016CB RID: 5835 RVA: 0x000072F0 File Offset: 0x000054F0
	[Token(Token = "0x1700033D")]
	public bool IsSimpleRole
	{
		[Token(Token = "0x60016CB")]
		[Address(RVA = "0x57ABC0", Offset = "0x579FC0", VA = "0x1057ABC0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700033E RID: 830
	// (get) Token: 0x060016CC RID: 5836 RVA: 0x00007308 File Offset: 0x00005508
	[Token(Token = "0x1700033E")]
	public Color TeamColor
	{
		[Token(Token = "0x60016CC")]
		[Address(RVA = "0x57AC50", Offset = "0x57A050", VA = "0x1057AC50")]
		get
		{
			return default(Color);
		}
	}

	// Token: 0x1700033F RID: 831
	// (get) Token: 0x060016CD RID: 5837 RVA: 0x00007320 File Offset: 0x00005520
	[Token(Token = "0x1700033F")]
	public bool IsAffectedByComms
	{
		[Token(Token = "0x60016CD")]
		[Address(RVA = "0x57AB00", Offset = "0x579F00", VA = "0x1057AB00")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000340 RID: 832
	// (get) Token: 0x060016CE RID: 5838 RVA: 0x00007338 File Offset: 0x00005538
	[Token(Token = "0x17000340")]
	protected bool CommsSabotaged
	{
		[Token(Token = "0x60016CE")]
		[Address(RVA = "0x57AA80", Offset = "0x579E80", VA = "0x1057AA80")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060016CF RID: 5839 RVA: 0x00007350 File Offset: 0x00005550
	[Token(Token = "0x60016CF")]
	[Address(RVA = "0x2D7E70", Offset = "0x2D7270", VA = "0x102D7E70", Slot = "4")]
	public virtual bool CanUse(IUsable console)
	{
		return default(bool);
	}

	// Token: 0x060016D0 RID: 5840 RVA: 0x00007368 File Offset: 0x00005568
	[Token(Token = "0x60016D0")]
	[Address(RVA = "0x2D7E70", Offset = "0x2D7270", VA = "0x102D7E70", Slot = "5")]
	public virtual bool DidWin(GameOverReason gameOverReason)
	{
		return default(bool);
	}

	// Token: 0x060016D1 RID: 5841 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016D1")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "6")]
	public virtual void Deinitialize(PlayerControl targetPlayer)
	{
	}

	// Token: 0x060016D2 RID: 5842 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016D2")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "7")]
	public virtual void SpawnTaskHeader(PlayerControl playerControl)
	{
	}

	// Token: 0x060016D3 RID: 5843 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016D3")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "8")]
	public virtual void UseAbility()
	{
	}

	// Token: 0x060016D4 RID: 5844 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016D4")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "9")]
	public virtual void OnMeetingStart()
	{
	}

	// Token: 0x060016D5 RID: 5845 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016D5")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "10")]
	public virtual void OnVotingComplete()
	{
	}

	// Token: 0x060016D6 RID: 5846 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016D6")]
	[Address(RVA = "0x57A650", Offset = "0x579A50", VA = "0x1057A650", Slot = "11")]
	public virtual void Initialize(PlayerControl player)
	{
	}

	// Token: 0x060016D7 RID: 5847 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016D7")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "12")]
	public virtual void SetUsableTarget(IUsable target)
	{
	}

	// Token: 0x060016D8 RID: 5848 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016D8")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "13")]
	public virtual void SetPlayerTarget(PlayerControl target)
	{
	}

	// Token: 0x060016D9 RID: 5849 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016D9")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "14")]
	public virtual void SetCooldown()
	{
	}

	// Token: 0x060016DA RID: 5850 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016DA")]
	[Address(RVA = "0x57A550", Offset = "0x579950", VA = "0x1057A550")]
	private void InitializeAbilityButton()
	{
	}

	// Token: 0x060016DB RID: 5851 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016DB")]
	[Address(RVA = "0x57A8D0", Offset = "0x579CD0", VA = "0x1057A8D0")]
	public RoleBehaviour()
	{
	}

	// Token: 0x04001716 RID: 5910
	[Token(Token = "0x4001716")]
	[FieldOffset(Offset = "0xC")]
	public RoleTypes Role;

	// Token: 0x04001717 RID: 5911
	[Token(Token = "0x4001717")]
	[FieldOffset(Offset = "0x10")]
	public StringNames StringName;

	// Token: 0x04001718 RID: 5912
	[Token(Token = "0x4001718")]
	[FieldOffset(Offset = "0x14")]
	public StringNames BlurbName;

	// Token: 0x04001719 RID: 5913
	[Token(Token = "0x4001719")]
	[FieldOffset(Offset = "0x18")]
	public StringNames BlurbNameMed;

	// Token: 0x0400171A RID: 5914
	[Token(Token = "0x400171A")]
	[FieldOffset(Offset = "0x1C")]
	public StringNames BlurbNameLong;

	// Token: 0x0400171B RID: 5915
	[Token(Token = "0x400171B")]
	[FieldOffset(Offset = "0x20")]
	public Color NameColor;

	// Token: 0x0400171C RID: 5916
	[Token(Token = "0x400171C")]
	[FieldOffset(Offset = "0x30")]
	public bool TasksCountTowardProgress;

	// Token: 0x0400171D RID: 5917
	[Token(Token = "0x400171D")]
	[FieldOffset(Offset = "0x31")]
	public bool CanUseKillButton;

	// Token: 0x0400171E RID: 5918
	[Token(Token = "0x400171E")]
	[FieldOffset(Offset = "0x32")]
	public bool CanBeKilled;

	// Token: 0x0400171F RID: 5919
	[Token(Token = "0x400171F")]
	[FieldOffset(Offset = "0x33")]
	public bool CanVent;

	// Token: 0x04001720 RID: 5920
	[Token(Token = "0x4001720")]
	[FieldOffset(Offset = "0x34")]
	public bool AffectedByLightAffectors;

	// Token: 0x04001721 RID: 5921
	[Token(Token = "0x4001721")]
	[FieldOffset(Offset = "0x38")]
	public int MaxCount;

	// Token: 0x04001722 RID: 5922
	[Token(Token = "0x4001722")]
	[FieldOffset(Offset = "0x3C")]
	public RoleTeamTypes TeamType;

	// Token: 0x04001723 RID: 5923
	[Token(Token = "0x4001723")]
	[FieldOffset(Offset = "0x40")]
	public AbilityButtonSettings Ability;

	// Token: 0x04001724 RID: 5924
	[Token(Token = "0x4001724")]
	[FieldOffset(Offset = "0x44")]
	public AudioClip UseSound;

	// Token: 0x04001725 RID: 5925
	[Token(Token = "0x4001725")]
	[FieldOffset(Offset = "0x48")]
	public AudioClip IntroSound;

	// Token: 0x04001726 RID: 5926
	[Token(Token = "0x4001726")]
	[FieldOffset(Offset = "0x4C")]
	protected PlayerControl Player;
}
