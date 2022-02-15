using System;
using System.Threading;
using Il2CppDummyDll;

// Token: 0x020000BC RID: 188
[Token(Token = "0x20000BC")]
public static class Constants
{
	// Token: 0x170000A2 RID: 162
	// (get) Token: 0x06000465 RID: 1125 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000A2")]
	public static Thread MainThread
	{
		[Token(Token = "0x6000465")]
		[Address(RVA = "0x426630", Offset = "0x425A30", VA = "0x10426630")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000466 RID: 1126 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000466")]
	[Address(RVA = "0x4259E0", Offset = "0x424DE0", VA = "0x104259E0")]
	public static void SetMainThread()
	{
	}

	// Token: 0x06000467 RID: 1127 RVA: 0x00002CE8 File Offset: 0x00000EE8
	[Token(Token = "0x6000467")]
	[Address(RVA = "0x425510", Offset = "0x424910", VA = "0x10425510")]
	internal static int GetBroadcastVersion()
	{
		return 0;
	}

	// Token: 0x06000468 RID: 1128 RVA: 0x00002D00 File Offset: 0x00000F00
	[Token(Token = "0x6000468")]
	[Address(RVA = "0x4259C0", Offset = "0x424DC0", VA = "0x104259C0")]
	internal static int GetVersion(int year, int month, int day, int rev)
	{
		return 0;
	}

	// Token: 0x06000469 RID: 1129 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000469")]
	[Address(RVA = "0x425490", Offset = "0x424890", VA = "0x10425490")]
	internal static byte[] GetBroadcastVersionBytes()
	{
		return null;
	}

	// Token: 0x0600046A RID: 1130 RVA: 0x00002D18 File Offset: 0x00000F18
	[Token(Token = "0x600046A")]
	[Address(RVA = "0x425BD0", Offset = "0x424FD0", VA = "0x10425BD0")]
	public static bool ShouldPlaySfx()
	{
		return default(bool);
	}

	// Token: 0x0600046B RID: 1131 RVA: 0x00002D30 File Offset: 0x00000F30
	[Token(Token = "0x600046B")]
	[Address(RVA = "0x425A40", Offset = "0x424E40", VA = "0x10425A40")]
	internal static bool ShouldFlipSkeld()
	{
		return default(bool);
	}

	// Token: 0x0600046C RID: 1132 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600046C")]
	[Address(RVA = "0x425550", Offset = "0x424950", VA = "0x10425550")]
	public static PlatformSpecificData GetPlatformData()
	{
		return null;
	}

	// Token: 0x0600046D RID: 1133 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600046D")]
	[Address(RVA = "0x425C60", Offset = "0x425060", VA = "0x10425C60")]
	public static void UpdateCachedPlatformName()
	{
	}

	// Token: 0x0600046E RID: 1134 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600046E")]
	[Address(RVA = "0x425770", Offset = "0x424B70", VA = "0x10425770")]
	public static string GetPlatformName()
	{
		return null;
	}

	// Token: 0x0600046F RID: 1135 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600046F")]
	[Address(RVA = "0x425920", Offset = "0x424D20", VA = "0x10425920")]
	public static string GetPurchasingPlatformType()
	{
		return null;
	}

	// Token: 0x06000470 RID: 1136 RVA: 0x00002D48 File Offset: 0x00000F48
	[Token(Token = "0x6000470")]
	[Address(RVA = "0x425910", Offset = "0x424D10", VA = "0x10425910")]
	public static Platforms GetPlatformType()
	{
		return Platforms.Unknown;
	}

	// Token: 0x06000471 RID: 1137 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000471")]
	[Address(RVA = "0x425520", Offset = "0x424920", VA = "0x10425520")]
	public static string GetCurrentPlatformName()
	{
		return null;
	}

	// Token: 0x040004D0 RID: 1232
	[Token(Token = "0x40004D0")]
	public const int MinNumPlayers = 4;

	// Token: 0x040004D1 RID: 1233
	[Token(Token = "0x40004D1")]
	public const int MaxNumPlayers = 15;

	// Token: 0x040004D2 RID: 1234
	[Token(Token = "0x40004D2")]
	public const string LocalNetAddress = "127.0.0.1";

	// Token: 0x040004D3 RID: 1235
	[Token(Token = "0x40004D3")]
	public const ushort GamePlayPort = 22023;

	// Token: 0x040004D4 RID: 1236
	[Token(Token = "0x40004D4")]
	public const ushort AnnouncementPort = 22024;

	// Token: 0x040004D5 RID: 1237
	[Token(Token = "0x40004D5")]
	public const string InfinitySymbol = "∞";

	// Token: 0x040004D6 RID: 1238
	[Token(Token = "0x40004D6")]
	[FieldOffset(Offset = "0x0")]
	public static readonly int ShipOnlyMask;

	// Token: 0x040004D7 RID: 1239
	[Token(Token = "0x40004D7")]
	[FieldOffset(Offset = "0x4")]
	public static readonly int ShipAndObjectsMask;

	// Token: 0x040004D8 RID: 1240
	[Token(Token = "0x40004D8")]
	[FieldOffset(Offset = "0x8")]
	public static readonly int ShipAndAllObjectsMask;

	// Token: 0x040004D9 RID: 1241
	[Token(Token = "0x40004D9")]
	[FieldOffset(Offset = "0xC")]
	public static readonly int NotShipMask;

	// Token: 0x040004DA RID: 1242
	[Token(Token = "0x40004DA")]
	[FieldOffset(Offset = "0x10")]
	public static readonly int Usables;

	// Token: 0x040004DB RID: 1243
	[Token(Token = "0x40004DB")]
	[FieldOffset(Offset = "0x14")]
	public static readonly int PlayersOnlyMask;

	// Token: 0x040004DC RID: 1244
	[Token(Token = "0x40004DC")]
	[FieldOffset(Offset = "0x18")]
	public static readonly int ShadowMask;

	// Token: 0x040004DD RID: 1245
	[Token(Token = "0x40004DD")]
	[FieldOffset(Offset = "0x1C")]
	public static readonly string[] MapNames;

	// Token: 0x040004DE RID: 1246
	[Token(Token = "0x40004DE")]
	[FieldOffset(Offset = "0x20")]
	public static readonly string Beans;

	// Token: 0x040004DF RID: 1247
	[Token(Token = "0x40004DF")]
	[FieldOffset(Offset = "0x24")]
	public static readonly string[] PlayStationControllers;

	// Token: 0x040004E0 RID: 1248
	[Token(Token = "0x40004E0")]
	[FieldOffset(Offset = "0x28")]
	public static readonly string BaseEndpoint;

	// Token: 0x040004E1 RID: 1249
	[Token(Token = "0x40004E1")]
	[FieldOffset(Offset = "0x2C")]
	public static readonly string BaseAccountsEndpoint;

	// Token: 0x040004E2 RID: 1250
	[Token(Token = "0x40004E2")]
	[FieldOffset(Offset = "0x30")]
	public static readonly string PrivacyPolicyURL;

	// Token: 0x040004E3 RID: 1251
	[Token(Token = "0x40004E3")]
	[FieldOffset(Offset = "0x34")]
	public static readonly string TermsOfUseURL;

	// Token: 0x040004E4 RID: 1252
	[Token(Token = "0x40004E4")]
	[FieldOffset(Offset = "0x38")]
	public static readonly int[] CompatVersions;

	// Token: 0x040004E5 RID: 1253
	[Token(Token = "0x40004E5")]
	public const int Year = 2021;

	// Token: 0x040004E6 RID: 1254
	[Token(Token = "0x40004E6")]
	public const int Month = 12;

	// Token: 0x040004E7 RID: 1255
	[Token(Token = "0x40004E7")]
	public const int Day = 14;

	// Token: 0x040004E8 RID: 1256
	[Token(Token = "0x40004E8")]
	public const int Revision = 0;

	// Token: 0x040004E9 RID: 1257
	[Token(Token = "0x40004E9")]
	public const int VisualRevision = 0;

	// Token: 0x040004EA RID: 1258
	[Token(Token = "0x40004EA")]
	public const int PrivacyPolicyVersion = 2;

	// Token: 0x040004EB RID: 1259
	[Token(Token = "0x40004EB")]
	public const string extraBuildVersionInfo = "(build num: 1421)";

	// Token: 0x040004EC RID: 1260
	[Token(Token = "0x40004EC")]
	public const int pipelineBuildNumber = 1421;

	// Token: 0x040004ED RID: 1261
	[Token(Token = "0x40004ED")]
	[FieldOffset(Offset = "0x3C")]
	private static Thread _MainThread;

	// Token: 0x040004EE RID: 1262
	[Token(Token = "0x40004EE")]
	[FieldOffset(Offset = "0x40")]
	private static string cachedPlatformName;
}
