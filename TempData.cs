using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000501 RID: 1281
[Token(Token = "0x2000501")]
public static class TempData
{
	// Token: 0x06001B4D RID: 6989 RVA: 0x00008AD8 File Offset: 0x00006CD8
	[Token(Token = "0x6001B4D")]
	[Address(RVA = "0x4A9EE0", Offset = "0x4A92E0", VA = "0x104A9EE0")]
	public static bool DidHumansWin(GameOverReason reason)
	{
		return default(bool);
	}

	// Token: 0x06001B4E RID: 6990 RVA: 0x00008AF0 File Offset: 0x00006CF0
	[Token(Token = "0x6001B4E")]
	[Address(RVA = "0x4A9F00", Offset = "0x4A9300", VA = "0x104A9F00")]
	public static bool DidImpostorsWin(GameOverReason reason)
	{
		return default(bool);
	}

	// Token: 0x06001B4F RID: 6991 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B4F")]
	[Address(RVA = "0x4A9F20", Offset = "0x4A9320", VA = "0x104A9F20")]
	public static void Reset()
	{
	}

	// Token: 0x04001B74 RID: 7028
	[Token(Token = "0x4001B74")]
	[FieldOffset(Offset = "0x0")]
	public static DeathReason LastDeathReason;

	// Token: 0x04001B75 RID: 7029
	[Token(Token = "0x4001B75")]
	[FieldOffset(Offset = "0x4")]
	public static GameOverReason EndReason;

	// Token: 0x04001B76 RID: 7030
	[Token(Token = "0x4001B76")]
	[FieldOffset(Offset = "0x8")]
	public static bool showAd;

	// Token: 0x04001B77 RID: 7031
	[Token(Token = "0x4001B77")]
	[FieldOffset(Offset = "0xC")]
	public static List<WinningPlayerData> winners;

	// Token: 0x04001B78 RID: 7032
	[Token(Token = "0x4001B78")]
	[FieldOffset(Offset = "0x10")]
	public static ProgressionManager.XpGrantResult XpGrantedResult;

	// Token: 0x04001B79 RID: 7033
	[Token(Token = "0x4001B79")]
	[FieldOffset(Offset = "0x14")]
	public static ProgressionManager.CurrencyGrantResult PodsGrantResult;

	// Token: 0x04001B7A RID: 7034
	[Token(Token = "0x4001B7A")]
	[FieldOffset(Offset = "0x18")]
	public static ProgressionManager.CurrencyGrantResult BeansGrantResult;
}
