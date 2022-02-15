using System;
using Il2CppDummyDll;

// Token: 0x0200022A RID: 554
[Token(Token = "0x200022A")]
public class MeetingRoomManager : IDisconnectHandler
{
	// Token: 0x06000C5B RID: 3163 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C5B")]
	[Address(RVA = "0x7724C0", Offset = "0x7718C0", VA = "0x107724C0")]
	public void AssignSelf(PlayerControl reporter, GameData.PlayerInfo target)
	{
	}

	// Token: 0x06000C5C RID: 3164 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C5C")]
	[Address(RVA = "0x7725B0", Offset = "0x7719B0", VA = "0x107725B0")]
	public void RemoveSelf()
	{
	}

	// Token: 0x06000C5D RID: 3165 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C5D")]
	[Address(RVA = "0x772550", Offset = "0x771950", VA = "0x10772550", Slot = "4")]
	public void HandleDisconnect(PlayerControl pc, DisconnectReasons reason)
	{
	}

	// Token: 0x06000C5E RID: 3166 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C5E")]
	[Address(RVA = "0x772550", Offset = "0x771950", VA = "0x10772550", Slot = "5")]
	public void HandleDisconnect()
	{
	}

	// Token: 0x06000C5F RID: 3167 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C5F")]
	[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
	public MeetingRoomManager()
	{
	}

	// Token: 0x04000C55 RID: 3157
	[Token(Token = "0x4000C55")]
	[FieldOffset(Offset = "0x0")]
	public static readonly MeetingRoomManager Instance;

	// Token: 0x04000C56 RID: 3158
	[Token(Token = "0x4000C56")]
	[FieldOffset(Offset = "0x8")]
	private PlayerControl reporter;

	// Token: 0x04000C57 RID: 3159
	[Token(Token = "0x4000C57")]
	[FieldOffset(Offset = "0xC")]
	private GameData.PlayerInfo target;
}
