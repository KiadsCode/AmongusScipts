using System;
using Il2CppDummyDll;

// Token: 0x0200041B RID: 1051
[Token(Token = "0x200041B")]
public class ProgressionManager
{
	// Token: 0x1700031A RID: 794
	// (get) Token: 0x0600161F RID: 5663 RVA: 0x00006FA8 File Offset: 0x000051A8
	// (set) Token: 0x06001620 RID: 5664 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700031A")]
	public uint CurrentLevel
	{
		[Token(Token = "0x600161F")]
		[Address(RVA = "0x5118D0", Offset = "0x510CD0", VA = "0x105118D0")]
		get
		{
			return 0U;
		}
		[Token(Token = "0x6001620")]
		[Address(RVA = "0x511A20", Offset = "0x510E20", VA = "0x10511A20")]
		set
		{
		}
	}

	// Token: 0x1700031B RID: 795
	// (get) Token: 0x06001621 RID: 5665 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700031B")]
	public string CurrentVisualLevel
	{
		[Token(Token = "0x6001621")]
		[Address(RVA = "0x511920", Offset = "0x510D20", VA = "0x10511920")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700031C RID: 796
	// (get) Token: 0x06001622 RID: 5666 RVA: 0x00006FC0 File Offset: 0x000051C0
	// (set) Token: 0x06001623 RID: 5667 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700031C")]
	public uint CurrentXp
	{
		[Token(Token = "0x6001622")]
		[Address(RVA = "0x511980", Offset = "0x510D80", VA = "0x10511980")]
		get
		{
			return 0U;
		}
		[Token(Token = "0x6001623")]
		[Address(RVA = "0x511A70", Offset = "0x510E70", VA = "0x10511A70")]
		set
		{
		}
	}

	// Token: 0x1700031D RID: 797
	// (get) Token: 0x06001624 RID: 5668 RVA: 0x00006FD8 File Offset: 0x000051D8
	// (set) Token: 0x06001625 RID: 5669 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700031D")]
	public uint XpRequiredForNextLevel
	{
		[Token(Token = "0x6001624")]
		[Address(RVA = "0x5119D0", Offset = "0x510DD0", VA = "0x105119D0")]
		get
		{
			return 0U;
		}
		[Token(Token = "0x6001625")]
		[Address(RVA = "0x511AC0", Offset = "0x510EC0", VA = "0x10511AC0")]
		set
		{
		}
	}

	// Token: 0x06001626 RID: 5670 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001626")]
	[Address(RVA = "0x511840", Offset = "0x510C40", VA = "0x10511840")]
	public static string FormatVisualLevel(uint playerLevel)
	{
		return null;
	}

	// Token: 0x06001627 RID: 5671 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001627")]
	[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
	public ProgressionManager()
	{
	}

	// Token: 0x0400167A RID: 5754
	[Token(Token = "0x400167A")]
	public const int FirstLevel = 0;

	// Token: 0x0400167B RID: 5755
	[Token(Token = "0x400167B")]
	[FieldOffset(Offset = "0x340533F5")]
	public static ProgressionManager Instance;

	// Token: 0x0400167C RID: 5756
	[Token(Token = "0x400167C")]
	private const uint MaxLevel = 99U;

	// Token: 0x0200041C RID: 1052
	[Token(Token = "0x200041C")]
	public class XpGrantResult
	{
		// Token: 0x06001629 RID: 5673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001629")]
		[Address(RVA = "0x79DCE0", Offset = "0x79D0E0", VA = "0x1079DCE0")]
		public XpGrantResult(uint grantedXp, uint oldXpAmount, uint xpRequiredToLevelUp, uint xpRequiredToLevelUpNextLevel, bool levelledUp, uint oldLevel, uint newLevel, uint maxLevel)
		{
		}

		// Token: 0x0600162A RID: 5674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600162A")]
		[Address(RVA = "0x79DBA0", Offset = "0x79CFA0", VA = "0x1079DBA0")]
		public static ProgressionManager.XpGrantResult Default()
		{
			return null;
		}

		// Token: 0x0400167D RID: 5757
		[Token(Token = "0x400167D")]
		[FieldOffset(Offset = "0x8")]
		public readonly uint GrantedXp;

		// Token: 0x0400167E RID: 5758
		[Token(Token = "0x400167E")]
		[FieldOffset(Offset = "0xC")]
		public readonly uint OldXpAmount;

		// Token: 0x0400167F RID: 5759
		[Token(Token = "0x400167F")]
		[FieldOffset(Offset = "0x10")]
		public readonly uint XpRequiredToLevelUp;

		// Token: 0x04001680 RID: 5760
		[Token(Token = "0x4001680")]
		[FieldOffset(Offset = "0x14")]
		public readonly uint XpRequiredToLevelUpNextLevel;

		// Token: 0x04001681 RID: 5761
		[Token(Token = "0x4001681")]
		[FieldOffset(Offset = "0x18")]
		public readonly uint OldLevel;

		// Token: 0x04001682 RID: 5762
		[Token(Token = "0x4001682")]
		[FieldOffset(Offset = "0x1C")]
		public readonly uint NewLevel;

		// Token: 0x04001683 RID: 5763
		[Token(Token = "0x4001683")]
		[FieldOffset(Offset = "0x20")]
		public readonly uint MaxLevel;

		// Token: 0x04001684 RID: 5764
		[Token(Token = "0x4001684")]
		[FieldOffset(Offset = "0x24")]
		public readonly bool LevelledUp;
	}

	// Token: 0x0200041D RID: 1053
	[Token(Token = "0x200041D")]
	public class CurrencyGrantResult
	{
		// Token: 0x0600162B RID: 5675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600162B")]
		[Address(RVA = "0x78E580", Offset = "0x78D980", VA = "0x1078E580")]
		public CurrencyGrantResult(string podId, uint oldPodAmount, uint grantedPodsWithMultiplierApplied, float multiplier)
		{
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x0600162C RID: 5676 RVA: 0x00006FF0 File Offset: 0x000051F0
		[Token(Token = "0x1700031E")]
		public uint GrantedPodsPreMultiplier
		{
			[Token(Token = "0x600162C")]
			[Address(RVA = "0x78E5C0", Offset = "0x78D9C0", VA = "0x1078E5C0")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x0600162D RID: 5677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600162D")]
		[Address(RVA = "0x78E510", Offset = "0x78D910", VA = "0x1078E510")]
		public static ProgressionManager.CurrencyGrantResult Default()
		{
			return null;
		}

		// Token: 0x04001685 RID: 5765
		[Token(Token = "0x4001685")]
		[FieldOffset(Offset = "0x8")]
		public readonly string PodId;

		// Token: 0x04001686 RID: 5766
		[Token(Token = "0x4001686")]
		[FieldOffset(Offset = "0xC")]
		public readonly uint OldPodAmount;

		// Token: 0x04001687 RID: 5767
		[Token(Token = "0x4001687")]
		[FieldOffset(Offset = "0x10")]
		public readonly uint GrantedPodsWithMultiplierApplied;

		// Token: 0x04001688 RID: 5768
		[Token(Token = "0x4001688")]
		[FieldOffset(Offset = "0x14")]
		public readonly float Multiplier;
	}
}
