using System;
using System.Collections.Generic;
using Hazel;
using Il2CppDummyDll;
using InnerNet;

// Token: 0x020001CF RID: 463
[Token(Token = "0x20001CF")]
public class VoteBanSystem : InnerNetObject
{
	// Token: 0x06000A71 RID: 2673 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A71")]
	[Address(RVA = "0x7B4220", Offset = "0x7B3620", VA = "0x107B4220")]
	public void Awake()
	{
	}

	// Token: 0x06000A72 RID: 2674 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A72")]
	[Address(RVA = "0x7B4250", Offset = "0x7B3650", VA = "0x107B4250")]
	public void CmdAddVote(int clientId)
	{
	}

	// Token: 0x06000A73 RID: 2675 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A73")]
	[Address(RVA = "0x7B40E0", Offset = "0x7B34E0", VA = "0x107B40E0")]
	private void AddVote(int srcClient, int clientId)
	{
	}

	// Token: 0x06000A74 RID: 2676 RVA: 0x000048C0 File Offset: 0x00002AC0
	[Token(Token = "0x6000A74")]
	[Address(RVA = "0x7B4460", Offset = "0x7B3860", VA = "0x107B4460")]
	public bool HasMyVote(int clientId)
	{
		return default(bool);
	}

	// Token: 0x06000A75 RID: 2677 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A75")]
	[Address(RVA = "0x7B4420", Offset = "0x7B3820", VA = "0x107B4420", Slot = "8")]
	public override void HandleRpc(byte callId, MessageReader reader)
	{
	}

	// Token: 0x06000A76 RID: 2678 RVA: 0x000048D8 File Offset: 0x00002AD8
	[Token(Token = "0x6000A76")]
	[Address(RVA = "0x7B4500", Offset = "0x7B3900", VA = "0x107B4500", Slot = "9")]
	public override bool Serialize(MessageWriter writer, bool initialState)
	{
		return default(bool);
	}

	// Token: 0x06000A77 RID: 2679 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A77")]
	[Address(RVA = "0x7B4300", Offset = "0x7B3700", VA = "0x107B4300", Slot = "10")]
	public override void Deserialize(MessageReader reader, bool initialState)
	{
	}

	// Token: 0x06000A78 RID: 2680 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A78")]
	[Address(RVA = "0x7B46A0", Offset = "0x7B3AA0", VA = "0x107B46A0")]
	public VoteBanSystem()
	{
	}

	// Token: 0x04000A96 RID: 2710
	[Token(Token = "0x4000A96")]
	[FieldOffset(Offset = "0x0")]
	public static VoteBanSystem Instance;

	// Token: 0x04000A97 RID: 2711
	[Token(Token = "0x4000A97")]
	[FieldOffset(Offset = "0x24")]
	public Dictionary<int, int[]> Votes;
}
