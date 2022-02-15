using System;
using System.Collections.Generic;
using Hazel;
using Il2CppDummyDll;

// Token: 0x020003AF RID: 943
[Token(Token = "0x20003AF")]
[Serializable]
public class QuickChatNetData
{
	// Token: 0x060013E5 RID: 5093 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013E5")]
	[Address(RVA = "0x4EA3A0", Offset = "0x4E97A0", VA = "0x104EA3A0")]
	public QuickChatNetData()
	{
	}

	// Token: 0x060013E6 RID: 5094 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013E6")]
	[Address(RVA = "0x4EA0F0", Offset = "0x4E94F0", VA = "0x104EA0F0")]
	public void SetSentence(StringNames key, List<StringNames> names, List<byte> players)
	{
	}

	// Token: 0x060013E7 RID: 5095 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013E7")]
	[Address(RVA = "0x4EA0D0", Offset = "0x4E94D0", VA = "0x104EA0D0")]
	public void SetPhrase(StringNames key)
	{
	}

	// Token: 0x060013E8 RID: 5096 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013E8")]
	[Address(RVA = "0x4EA0B0", Offset = "0x4E94B0", VA = "0x104EA0B0")]
	public void SetName(byte player)
	{
	}

	// Token: 0x060013E9 RID: 5097 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013E9")]
	[Address(RVA = "0x4E9F60", Offset = "0x4E9360", VA = "0x104E9F60")]
	public void Serialize(MessageWriter writer)
	{
	}

	// Token: 0x060013EA RID: 5098 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013EA")]
	[Address(RVA = "0x4E9BD0", Offset = "0x4E8FD0", VA = "0x104E9BD0")]
	public static string Deserialize(MessageReader reader)
	{
		return null;
	}

	// Token: 0x060013EB RID: 5099 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013EB")]
	[Address(RVA = "0x4EA250", Offset = "0x4E9650", VA = "0x104EA250")]
	private static Tuple<StringNames, byte>[] ToProtocolArray(List<StringNames> names, List<byte> players)
	{
		return null;
	}

	// Token: 0x04001452 RID: 5202
	[Token(Token = "0x4001452")]
	[FieldOffset(Offset = "0x8")]
	public QuickChatNetType qcType;

	// Token: 0x04001453 RID: 5203
	[Token(Token = "0x4001453")]
	[FieldOffset(Offset = "0xC")]
	private StringNames qcKey;

	// Token: 0x04001454 RID: 5204
	[Token(Token = "0x4001454")]
	[FieldOffset(Offset = "0x10")]
	private byte qcPlayer;

	// Token: 0x04001455 RID: 5205
	[Token(Token = "0x4001455")]
	[FieldOffset(Offset = "0x14")]
	private Tuple<StringNames, byte>[] qcEntries;
}
