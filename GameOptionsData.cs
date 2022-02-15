using System;
using System.IO;
using System.Text;
using Hazel;
using Il2CppDummyDll;
using InnerNet;

// Token: 0x02000462 RID: 1122
[Token(Token = "0x2000462")]
public class GameOptionsData
{
	// Token: 0x060017E6 RID: 6118 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017E6")]
	[Address(RVA = "0x3B1040", Offset = "0x3B0440", VA = "0x103B1040")]
	public void ToggleMapFilter(byte newId)
	{
	}

	// Token: 0x060017E7 RID: 6119 RVA: 0x000078A8 File Offset: 0x00005AA8
	[Token(Token = "0x60017E7")]
	[Address(RVA = "0x3AFB40", Offset = "0x3AEF40", VA = "0x103AFB40")]
	public bool FilterContainsMap(byte newId)
	{
		return default(bool);
	}

	// Token: 0x060017E8 RID: 6120 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017E8")]
	[Address(RVA = "0x3B12E0", Offset = "0x3B06E0", VA = "0x103B12E0")]
	public GameOptionsData()
	{
	}

	// Token: 0x060017E9 RID: 6121 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017E9")]
	[Address(RVA = "0x3B0140", Offset = "0x3AF540", VA = "0x103B0140")]
	public void SetRecommendations(int numPlayers, GameModes modes)
	{
	}

	// Token: 0x060017EA RID: 6122 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017EA")]
	[Address(RVA = "0x3AFEE0", Offset = "0x3AF2E0", VA = "0x103AFEE0")]
	public void Serialize(BinaryWriter writer, byte version)
	{
	}

	// Token: 0x060017EB RID: 6123 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017EB")]
	[Address(RVA = "0x3AF7B0", Offset = "0x3AEBB0", VA = "0x103AF7B0")]
	public static GameOptionsData Deserialize(BinaryReader reader)
	{
		return null;
	}

	// Token: 0x060017EC RID: 6124 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017EC")]
	[Address(RVA = "0x3AF4E0", Offset = "0x3AE8E0", VA = "0x103AF4E0")]
	public static GameOptionsData Deserialize(MessageReader reader)
	{
		return null;
	}

	// Token: 0x060017ED RID: 6125 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017ED")]
	[Address(RVA = "0x3B0320", Offset = "0x3AF720", VA = "0x103B0320")]
	public byte[] ToBytes(byte version)
	{
		return null;
	}

	// Token: 0x060017EE RID: 6126 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017EE")]
	[Address(RVA = "0x3AFB70", Offset = "0x3AEF70", VA = "0x103AFB70")]
	public static GameOptionsData FromBytes(byte[] bytes)
	{
		return null;
	}

	// Token: 0x060017EF RID: 6127 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017EF")]
	[Address(RVA = "0x3B1020", Offset = "0x3B0420", VA = "0x103B1020", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x060017F0 RID: 6128 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017F0")]
	[Address(RVA = "0x3B04D0", Offset = "0x3AF8D0", VA = "0x103B04D0")]
	public string ToHudString(int numPlayers)
	{
		return null;
	}

	// Token: 0x060017F1 RID: 6129 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017F1")]
	[Address(RVA = "0x3AF360", Offset = "0x3AE760", VA = "0x103AF360")]
	private void AppendItem(StringBuilder settings, StringNames stringName, bool value)
	{
	}

	// Token: 0x060017F2 RID: 6130 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017F2")]
	[Address(RVA = "0x3AF210", Offset = "0x3AE610", VA = "0x103AF210")]
	private void AppendItem(StringBuilder settings, StringNames stringName, float value, string secs)
	{
	}

	// Token: 0x060017F3 RID: 6131 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017F3")]
	[Address(RVA = "0x3AF430", Offset = "0x3AE830", VA = "0x103AF430")]
	private void AppendItem(StringBuilder settings, StringNames stringName, int value, string secs)
	{
	}

	// Token: 0x060017F4 RID: 6132 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017F4")]
	[Address(RVA = "0x3AF2C0", Offset = "0x3AE6C0", VA = "0x103AF2C0")]
	private void AppendItem(StringBuilder settings, StringNames stringName, string value)
	{
	}

	// Token: 0x060017F5 RID: 6133 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017F5")]
	[Address(RVA = "0x3AF140", Offset = "0x3AE540", VA = "0x103AF140")]
	private void AppendItem(StringBuilder settings, StringNames stringName, int value)
	{
	}

	// Token: 0x060017F6 RID: 6134 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017F6")]
	[Address(RVA = "0x3AF1E0", Offset = "0x3AE5E0", VA = "0x103AF1E0")]
	private void AppendItem(StringBuilder settings, string str)
	{
	}

	// Token: 0x060017F7 RID: 6135 RVA: 0x000078C0 File Offset: 0x00005AC0
	[Token(Token = "0x60017F7")]
	[Address(RVA = "0x3AFD20", Offset = "0x3AF120", VA = "0x103AFD20")]
	public int GetAdjustedNumImpostors(int playerCount)
	{
		return 0;
	}

	// Token: 0x040017E7 RID: 6119
	[Token(Token = "0x40017E7")]
	private const byte EmergencyCooldownSupportVersion = 1;

	// Token: 0x040017E8 RID: 6120
	[Token(Token = "0x40017E8")]
	private const byte VisualTaskOptionsSupportVersion = 2;

	// Token: 0x040017E9 RID: 6121
	[Token(Token = "0x40017E9")]
	private const byte ExtraVotingOptionsSupportVersion = 3;

	// Token: 0x040017EA RID: 6122
	[Token(Token = "0x40017EA")]
	private const byte RolesSupportVersion = 4;

	// Token: 0x040017EB RID: 6123
	[Token(Token = "0x40017EB")]
	public const byte ServerVersion = 2;

	// Token: 0x040017EC RID: 6124
	[Token(Token = "0x40017EC")]
	public const byte NewestVersion = 5;

	// Token: 0x040017ED RID: 6125
	[Token(Token = "0x40017ED")]
	private const byte SkeldBit = 1;

	// Token: 0x040017EE RID: 6126
	[Token(Token = "0x40017EE")]
	private const byte MiraBit = 2;

	// Token: 0x040017EF RID: 6127
	[Token(Token = "0x40017EF")]
	private const byte PolusBit = 4;

	// Token: 0x040017F0 RID: 6128
	[Token(Token = "0x40017F0")]
	private const byte AirshipBit = 16;

	// Token: 0x040017F1 RID: 6129
	[Token(Token = "0x40017F1")]
	private const byte MapMask = 23;

	// Token: 0x040017F2 RID: 6130
	[Token(Token = "0x40017F2")]
	[FieldOffset(Offset = "0x0")]
	public static readonly float[] KillDistances;

	// Token: 0x040017F3 RID: 6131
	[Token(Token = "0x40017F3")]
	[FieldOffset(Offset = "0x4")]
	public static readonly string[] KillDistanceStrings;

	// Token: 0x040017F4 RID: 6132
	[Token(Token = "0x40017F4")]
	[FieldOffset(Offset = "0x8")]
	public int MaxPlayers;

	// Token: 0x040017F5 RID: 6133
	[Token(Token = "0x40017F5")]
	[FieldOffset(Offset = "0xC")]
	public GameKeywords Keywords;

	// Token: 0x040017F6 RID: 6134
	[Token(Token = "0x40017F6")]
	[FieldOffset(Offset = "0x10")]
	public byte MapId;

	// Token: 0x040017F7 RID: 6135
	[Token(Token = "0x40017F7")]
	[FieldOffset(Offset = "0x14")]
	public float PlayerSpeedMod;

	// Token: 0x040017F8 RID: 6136
	[Token(Token = "0x40017F8")]
	[FieldOffset(Offset = "0x18")]
	public float CrewLightMod;

	// Token: 0x040017F9 RID: 6137
	[Token(Token = "0x40017F9")]
	[FieldOffset(Offset = "0x1C")]
	public float ImpostorLightMod;

	// Token: 0x040017FA RID: 6138
	[Token(Token = "0x40017FA")]
	[FieldOffset(Offset = "0x20")]
	public float KillCooldown;

	// Token: 0x040017FB RID: 6139
	[Token(Token = "0x40017FB")]
	[FieldOffset(Offset = "0x24")]
	public int NumCommonTasks;

	// Token: 0x040017FC RID: 6140
	[Token(Token = "0x40017FC")]
	[FieldOffset(Offset = "0x28")]
	public int NumLongTasks;

	// Token: 0x040017FD RID: 6141
	[Token(Token = "0x40017FD")]
	[FieldOffset(Offset = "0x2C")]
	public int NumShortTasks;

	// Token: 0x040017FE RID: 6142
	[Token(Token = "0x40017FE")]
	[FieldOffset(Offset = "0x30")]
	public int NumEmergencyMeetings;

	// Token: 0x040017FF RID: 6143
	[Token(Token = "0x40017FF")]
	[FieldOffset(Offset = "0x34")]
	public int EmergencyCooldown;

	// Token: 0x04001800 RID: 6144
	[Token(Token = "0x4001800")]
	[FieldOffset(Offset = "0x38")]
	public int NumImpostors;

	// Token: 0x04001801 RID: 6145
	[Token(Token = "0x4001801")]
	[FieldOffset(Offset = "0x3C")]
	public bool GhostsDoTasks;

	// Token: 0x04001802 RID: 6146
	[Token(Token = "0x4001802")]
	[FieldOffset(Offset = "0x40")]
	public int KillDistance;

	// Token: 0x04001803 RID: 6147
	[Token(Token = "0x4001803")]
	[FieldOffset(Offset = "0x44")]
	public int DiscussionTime;

	// Token: 0x04001804 RID: 6148
	[Token(Token = "0x4001804")]
	[FieldOffset(Offset = "0x48")]
	public int VotingTime;

	// Token: 0x04001805 RID: 6149
	[Token(Token = "0x4001805")]
	[FieldOffset(Offset = "0x4C")]
	public bool ConfirmImpostor;

	// Token: 0x04001806 RID: 6150
	[Token(Token = "0x4001806")]
	[FieldOffset(Offset = "0x4D")]
	public bool VisualTasks;

	// Token: 0x04001807 RID: 6151
	[Token(Token = "0x4001807")]
	[FieldOffset(Offset = "0x4E")]
	public bool AnonymousVotes;

	// Token: 0x04001808 RID: 6152
	[Token(Token = "0x4001808")]
	[FieldOffset(Offset = "0x50")]
	public TaskBarMode TaskBarMode;

	// Token: 0x04001809 RID: 6153
	[Token(Token = "0x4001809")]
	[FieldOffset(Offset = "0x54")]
	public RoleOptionsData RoleOptions;

	// Token: 0x0400180A RID: 6154
	[Token(Token = "0x400180A")]
	[FieldOffset(Offset = "0x58")]
	public bool isDefaults;

	// Token: 0x0400180B RID: 6155
	[Token(Token = "0x400180B")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int[] RecommendedKillCooldown;

	// Token: 0x0400180C RID: 6156
	[Token(Token = "0x400180C")]
	[FieldOffset(Offset = "0xC")]
	private static readonly int[] RecommendedImpostors;

	// Token: 0x0400180D RID: 6157
	[Token(Token = "0x400180D")]
	[FieldOffset(Offset = "0x10")]
	private static readonly int[] MaxImpostors;

	// Token: 0x0400180E RID: 6158
	[Token(Token = "0x400180E")]
	[FieldOffset(Offset = "0x14")]
	public static readonly int[] MinPlayers;

	// Token: 0x0400180F RID: 6159
	[Token(Token = "0x400180F")]
	[FieldOffset(Offset = "0x5C")]
	private StringBuilder settings;
}
