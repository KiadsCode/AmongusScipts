using System;
using Il2CppDummyDll;

// Token: 0x020004FE RID: 1278
[Token(Token = "0x20004FE")]
public class WinningPlayerData : GameData.PlayerOutfit
{
	// Token: 0x06001B4C RID: 6988 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B4C")]
	[Address(RVA = "0x7BD370", Offset = "0x7BC770", VA = "0x107BD370")]
	public WinningPlayerData(GameData.PlayerInfo player)
	{
	}

	// Token: 0x04001B66 RID: 7014
	[Token(Token = "0x4001B66")]
	[FieldOffset(Offset = "0x30")]
	public bool IsYou;

	// Token: 0x04001B67 RID: 7015
	[Token(Token = "0x4001B67")]
	[FieldOffset(Offset = "0x31")]
	public bool IsImpostor;

	// Token: 0x04001B68 RID: 7016
	[Token(Token = "0x4001B68")]
	[FieldOffset(Offset = "0x32")]
	public bool IsDead;
}
