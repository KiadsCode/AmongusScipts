using System;
using Hazel;
using Il2CppDummyDll;

// Token: 0x02000170 RID: 368
[Token(Token = "0x2000170")]
public class EndGameResult
{
	// Token: 0x0600086D RID: 2157 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600086D")]
	[Address(RVA = "0x47A800", Offset = "0x479C00", VA = "0x1047A800")]
	public EndGameResult(GameOverReason gameOverReason, bool showAd, ProgressionManager.XpGrantResult xpGrantResult, ProgressionManager.CurrencyGrantResult podsGrantResult, ProgressionManager.CurrencyGrantResult beansGrantResult)
	{
	}

	// Token: 0x0600086E RID: 2158 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600086E")]
	[Address(RVA = "0x47A840", Offset = "0x479C40", VA = "0x1047A840")]
	public EndGameResult(GameOverReason gameOverReason, bool showAd)
	{
	}

	// Token: 0x0600086F RID: 2159 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600086F")]
	[Address(RVA = "0x47A510", Offset = "0x479910", VA = "0x1047A510")]
	public static EndGameResult Create(MessageReader reader)
	{
		return null;
	}

	// Token: 0x04000875 RID: 2165
	[Token(Token = "0x4000875")]
	[FieldOffset(Offset = "0x8")]
	public readonly GameOverReason GameOverReason;

	// Token: 0x04000876 RID: 2166
	[Token(Token = "0x4000876")]
	[FieldOffset(Offset = "0xC")]
	public readonly bool ShowAd;

	// Token: 0x04000877 RID: 2167
	[Token(Token = "0x4000877")]
	[FieldOffset(Offset = "0x10")]
	public readonly ProgressionManager.XpGrantResult XpGrantResult;

	// Token: 0x04000878 RID: 2168
	[Token(Token = "0x4000878")]
	[FieldOffset(Offset = "0x14")]
	public readonly ProgressionManager.CurrencyGrantResult BeansGrantResult;

	// Token: 0x04000879 RID: 2169
	[Token(Token = "0x4000879")]
	[FieldOffset(Offset = "0x18")]
	public readonly ProgressionManager.CurrencyGrantResult PodsGrantResult;
}
