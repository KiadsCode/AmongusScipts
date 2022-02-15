using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x0200043A RID: 1082
[Token(Token = "0x200043A")]
public class RoleManager : DestroyableSingleton<RoleManager>
{
	// Token: 0x060016DC RID: 5852 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016DC")]
	[Address(RVA = "0x57BEF0", Offset = "0x57B2F0", VA = "0x1057BEF0")]
	public void SetRole(PlayerControl targetPlayer, RoleTypes roleType)
	{
	}

	// Token: 0x060016DD RID: 5853 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016DD")]
	[Address(RVA = "0x57BC20", Offset = "0x57B020", VA = "0x1057BC20")]
	public void SelectRoles()
	{
	}

	// Token: 0x060016DE RID: 5854 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016DE")]
	[Address(RVA = "0x57C1B0", Offset = "0x57B5B0", VA = "0x1057C1B0")]
	public void TryAssignRoleOnDeath(PlayerControl player)
	{
	}

	// Token: 0x060016DF RID: 5855 RVA: 0x00007380 File Offset: 0x00005580
	[Token(Token = "0x60016DF")]
	[Address(RVA = "0x57BA90", Offset = "0x57AE90", VA = "0x1057BA90")]
	public static bool IsGhostRole(RoleTypes role)
	{
		return default(bool);
	}

	// Token: 0x060016E0 RID: 5856 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016E0")]
	[Address(RVA = "0x57B150", Offset = "0x57A550", VA = "0x1057B150")]
	private static void AssignRolesForTeam(List<GameData.PlayerInfo> players, RoleOptionsData opts, RoleTeamTypes team, int teamMax, RoleTypes? defaultRole)
	{
	}

	// Token: 0x060016E1 RID: 5857 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016E1")]
	[Address(RVA = "0x57B940", Offset = "0x57AD40", VA = "0x1057B940")]
	private static void AssignRolesFromList(List<GameData.PlayerInfo> players, int teamMax, List<RoleTypes> roleList, ref int rolesAssigned)
	{
	}

	// Token: 0x060016E2 RID: 5858 RVA: 0x00007398 File Offset: 0x00005598
	[Token(Token = "0x60016E2")]
	[Address(RVA = "0x57BB00", Offset = "0x57AF00", VA = "0x1057BB00")]
	private static bool IsImpostorRole(RoleTypes roleType)
	{
		return default(bool);
	}

	// Token: 0x060016E3 RID: 5859 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016E3")]
	[Address(RVA = "0x57C490", Offset = "0x57B890", VA = "0x1057C490")]
	public RoleManager()
	{
	}

	// Token: 0x04001727 RID: 5927
	[Token(Token = "0x4001727")]
	[FieldOffset(Offset = "0x0")]
	private static readonly HashSet<RoleTypes> GhostRoles;

	// Token: 0x04001728 RID: 5928
	[Token(Token = "0x4001728")]
	[FieldOffset(Offset = "0x10")]
	public RoleBehaviour[] AllRoles;

	// Token: 0x04001729 RID: 5929
	[Token(Token = "0x4001729")]
	[FieldOffset(Offset = "0x14")]
	public RoleEffectAnimation shapeshiftAnim;

	// Token: 0x0400172A RID: 5930
	[Token(Token = "0x400172A")]
	[FieldOffset(Offset = "0x18")]
	public RoleEffectAnimation protectAnim;

	// Token: 0x0400172B RID: 5931
	[Token(Token = "0x400172B")]
	[FieldOffset(Offset = "0x1C")]
	public RoleEffectAnimation protectLoopAnim;

	// Token: 0x0200043B RID: 1083
	[Token(Token = "0x200043B")]
	private class RoleAssignmentData
	{
		// Token: 0x060016E5 RID: 5861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016E5")]
		[Address(RVA = "0x3195E0", Offset = "0x3189E0", VA = "0x103195E0")]
		public RoleAssignmentData(RoleBehaviour role, int count, int chance)
		{
		}

		// Token: 0x0400172C RID: 5932
		[Token(Token = "0x400172C")]
		[FieldOffset(Offset = "0x8")]
		public RoleBehaviour Role;

		// Token: 0x0400172D RID: 5933
		[Token(Token = "0x400172D")]
		[FieldOffset(Offset = "0xC")]
		public int Count;

		// Token: 0x0400172E RID: 5934
		[Token(Token = "0x400172E")]
		[FieldOffset(Offset = "0x10")]
		public int Chance;
	}

	// Token: 0x0200043C RID: 1084
	[Token(Token = "0x200043C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass5_0
	{
		// Token: 0x060016E6 RID: 5862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016E6")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass5_0()
		{
		}

		// Token: 0x060016E7 RID: 5863 RVA: 0x000073B0 File Offset: 0x000055B0
		[Token(Token = "0x60016E7")]
		[Address(RVA = "0x370DF0", Offset = "0x3701F0", VA = "0x10370DF0")]
		internal bool <SetRole>b__0(RoleBehaviour r)
		{
			return default(bool);
		}

		// Token: 0x0400172F RID: 5935
		[Token(Token = "0x400172F")]
		[FieldOffset(Offset = "0x8")]
		public RoleTypes roleType;
	}

	// Token: 0x0200043D RID: 1085
	[Token(Token = "0x200043D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060016E9 RID: 5865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016E9")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x060016EA RID: 5866 RVA: 0x000073C8 File Offset: 0x000055C8
		[Token(Token = "0x60016EA")]
		[Address(RVA = "0x370940", Offset = "0x36FD40", VA = "0x10370940")]
		internal bool <SelectRoles>b__6_0(GameData.PlayerInfo pcd)
		{
			return default(bool);
		}

		// Token: 0x060016EB RID: 5867 RVA: 0x000073E0 File Offset: 0x000055E0
		[Token(Token = "0x60016EB")]
		[Address(RVA = "0x370960", Offset = "0x36FD60", VA = "0x10370960")]
		internal bool <SelectRoles>b__6_1(GameData.PlayerInfo pc)
		{
			return default(bool);
		}

		// Token: 0x060016EC RID: 5868 RVA: 0x000073F8 File Offset: 0x000055F8
		[Token(Token = "0x60016EC")]
		[Address(RVA = "0x3709A0", Offset = "0x36FDA0", VA = "0x103709A0")]
		internal bool <TryAssignRoleOnDeath>b__7_0(PlayerControl pc)
		{
			return default(bool);
		}

		// Token: 0x060016ED RID: 5869 RVA: 0x00007410 File Offset: 0x00005610
		[Token(Token = "0x60016ED")]
		[Address(RVA = "0x36FFB0", Offset = "0x36F3B0", VA = "0x1036FFB0")]
		internal bool <AssignRolesForTeam>b__9_2(<>f__AnonymousType0<RoleBehaviour, int> <>h__TransparentIdentifier0)
		{
			return default(bool);
		}

		// Token: 0x04001730 RID: 5936
		[Token(Token = "0x4001730")]
		[FieldOffset(Offset = "0x0")]
		public static readonly RoleManager.<>c <>9;

		// Token: 0x04001731 RID: 5937
		[Token(Token = "0x4001731")]
		[FieldOffset(Offset = "0x4")]
		public static Func<GameData.PlayerInfo, bool> <>9__6_0;

		// Token: 0x04001732 RID: 5938
		[Token(Token = "0x4001732")]
		[FieldOffset(Offset = "0x8")]
		public static Func<GameData.PlayerInfo, bool> <>9__6_1;

		// Token: 0x04001733 RID: 5939
		[Token(Token = "0x4001733")]
		[FieldOffset(Offset = "0xC")]
		public static Func<PlayerControl, bool> <>9__7_0;

		// Token: 0x04001734 RID: 5940
		[Token(Token = "0x4001734")]
		[FieldOffset(Offset = "0x10")]
		public static Func<<>f__AnonymousType0<RoleBehaviour, int>, bool> <>9__9_2;
	}

	// Token: 0x0200043E RID: 1086
	[Token(Token = "0x200043E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass9_0
	{
		// Token: 0x060016EE RID: 5870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016EE")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass9_0()
		{
		}

		// Token: 0x060016EF RID: 5871 RVA: 0x00007428 File Offset: 0x00005628
		[Token(Token = "0x60016EF")]
		[Address(RVA = "0x371A40", Offset = "0x370E40", VA = "0x10371A40")]
		internal bool <AssignRolesForTeam>b__0(RoleBehaviour role)
		{
			return default(bool);
		}

		// Token: 0x060016F0 RID: 5872 RVA: 0x00007440 File Offset: 0x00005640
		[Token(Token = "0x60016F0")]
		[Address(RVA = "0x371BE0", Offset = "0x370FE0", VA = "0x10371BE0")]
		internal bool <AssignRolesForTeam>b__4(RoleBehaviour role)
		{
			return default(bool);
		}

		// Token: 0x060016F1 RID: 5873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016F1")]
		[Address(RVA = "0x371C20", Offset = "0x371020", VA = "0x10371C20")]
		internal RoleManager.RoleAssignmentData <AssignRolesForTeam>b__5(RoleBehaviour role)
		{
			return null;
		}

		// Token: 0x060016F2 RID: 5874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016F2")]
		[Address(RVA = "0x371AC0", Offset = "0x370EC0", VA = "0x10371AC0")]
		internal <>f__AnonymousType0<RoleBehaviour, int> <AssignRolesForTeam>b__1(RoleBehaviour role)
		{
			return null;
		}

		// Token: 0x060016F3 RID: 5875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016F3")]
		[Address(RVA = "0x371B40", Offset = "0x370F40", VA = "0x10371B40")]
		internal RoleManager.RoleAssignmentData <AssignRolesForTeam>b__3(<>f__AnonymousType0<RoleBehaviour, int> <>h__TransparentIdentifier0)
		{
			return null;
		}

		// Token: 0x04001735 RID: 5941
		[Token(Token = "0x4001735")]
		[FieldOffset(Offset = "0x8")]
		public RoleTeamTypes team;

		// Token: 0x04001736 RID: 5942
		[Token(Token = "0x4001736")]
		[FieldOffset(Offset = "0xC")]
		public RoleOptionsData opts;

		// Token: 0x04001737 RID: 5943
		[Token(Token = "0x4001737")]
		[FieldOffset(Offset = "0x10")]
		public Func<RoleBehaviour, bool> <>9__4;

		// Token: 0x04001738 RID: 5944
		[Token(Token = "0x4001738")]
		[FieldOffset(Offset = "0x14")]
		public Func<RoleBehaviour, RoleManager.RoleAssignmentData> <>9__5;
	}

	// Token: 0x0200043F RID: 1087
	[Token(Token = "0x200043F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass11_0
	{
		// Token: 0x060016F4 RID: 5876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016F4")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass11_0()
		{
		}

		// Token: 0x060016F5 RID: 5877 RVA: 0x00007458 File Offset: 0x00005658
		[Token(Token = "0x60016F5")]
		[Address(RVA = "0x370DF0", Offset = "0x3701F0", VA = "0x10370DF0")]
		internal bool <IsImpostorRole>b__0(RoleBehaviour r)
		{
			return default(bool);
		}

		// Token: 0x04001739 RID: 5945
		[Token(Token = "0x4001739")]
		[FieldOffset(Offset = "0x8")]
		public RoleTypes roleType;
	}
}
