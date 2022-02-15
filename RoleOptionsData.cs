using System;
using System.Collections.Generic;
using System.IO;
using Hazel;
using Il2CppDummyDll;

// Token: 0x02000470 RID: 1136
[Token(Token = "0x2000470")]
public class RoleOptionsData
{
	// Token: 0x06001843 RID: 6211 RVA: 0x000079C8 File Offset: 0x00005BC8
	[Token(Token = "0x6001843")]
	[Address(RVA = "0x57CEA0", Offset = "0x57C2A0", VA = "0x1057CEA0")]
	public int GetNumPerGame(RoleTypes role)
	{
		return 0;
	}

	// Token: 0x06001844 RID: 6212 RVA: 0x000079E0 File Offset: 0x00005BE0
	[Token(Token = "0x6001844")]
	[Address(RVA = "0x57CE30", Offset = "0x57C230", VA = "0x1057CE30")]
	public int GetChancePerGame(RoleTypes role)
	{
		return 0;
	}

	// Token: 0x06001845 RID: 6213 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001845")]
	[Address(RVA = "0x57D410", Offset = "0x57C810", VA = "0x1057D410")]
	public void SetRoleRate(RoleTypes role, int maxCount, int chance)
	{
	}

	// Token: 0x06001846 RID: 6214 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001846")]
	[Address(RVA = "0x57CC00", Offset = "0x57C000", VA = "0x1057CC00")]
	public static RoleOptionsData Deserialize(BinaryReader reader)
	{
		return null;
	}

	// Token: 0x06001847 RID: 6215 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001847")]
	[Address(RVA = "0x57CA50", Offset = "0x57BE50", VA = "0x1057CA50")]
	public static RoleOptionsData Deserialize(MessageReader reader)
	{
		return null;
	}

	// Token: 0x06001848 RID: 6216 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001848")]
	[Address(RVA = "0x57CF10", Offset = "0x57C310", VA = "0x1057CF10")]
	public void Serialize(MessageWriter writer)
	{
	}

	// Token: 0x06001849 RID: 6217 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001849")]
	[Address(RVA = "0x57D150", Offset = "0x57C550", VA = "0x1057D150")]
	public void Serialize(BinaryWriter writer)
	{
	}

	// Token: 0x0600184A RID: 6218 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600184A")]
	[Address(RVA = "0x57D460", Offset = "0x57C860", VA = "0x1057D460")]
	public RoleOptionsData()
	{
	}

	// Token: 0x04001862 RID: 6242
	[Token(Token = "0x4001862")]
	[FieldOffset(Offset = "0x8")]
	public bool ShapeshifterLeaveSkin;

	// Token: 0x04001863 RID: 6243
	[Token(Token = "0x4001863")]
	[FieldOffset(Offset = "0xC")]
	public float ShapeshifterCooldown;

	// Token: 0x04001864 RID: 6244
	[Token(Token = "0x4001864")]
	[FieldOffset(Offset = "0x10")]
	public float ShapeshifterDuration;

	// Token: 0x04001865 RID: 6245
	[Token(Token = "0x4001865")]
	[FieldOffset(Offset = "0x14")]
	public float ScientistCooldown;

	// Token: 0x04001866 RID: 6246
	[Token(Token = "0x4001866")]
	[FieldOffset(Offset = "0x18")]
	public float ScientistBatteryCharge;

	// Token: 0x04001867 RID: 6247
	[Token(Token = "0x4001867")]
	[FieldOffset(Offset = "0x1C")]
	public float GuardianAngelCooldown;

	// Token: 0x04001868 RID: 6248
	[Token(Token = "0x4001868")]
	[FieldOffset(Offset = "0x20")]
	public bool ImpostorsCanSeeProtect;

	// Token: 0x04001869 RID: 6249
	[Token(Token = "0x4001869")]
	[FieldOffset(Offset = "0x24")]
	public float ProtectionDurationSeconds;

	// Token: 0x0400186A RID: 6250
	[Token(Token = "0x400186A")]
	[FieldOffset(Offset = "0x28")]
	public float EngineerCooldown;

	// Token: 0x0400186B RID: 6251
	[Token(Token = "0x400186B")]
	[FieldOffset(Offset = "0x2C")]
	public float EngineerInVentMaxTime;

	// Token: 0x0400186C RID: 6252
	[Token(Token = "0x400186C")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<RoleTypes, RoleOptionsData.RoleRate> roleRates;

	// Token: 0x02000471 RID: 1137
	[Token(Token = "0x2000471")]
	private struct RoleRate
	{
		// Token: 0x0400186D RID: 6253
		[Token(Token = "0x400186D")]
		[FieldOffset(Offset = "0x0")]
		public int MaxCount;

		// Token: 0x0400186E RID: 6254
		[Token(Token = "0x400186E")]
		[FieldOffset(Offset = "0x4")]
		public int Chance;
	}
}
