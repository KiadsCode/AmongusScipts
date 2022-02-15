using System;
using Hazel;
using Il2CppDummyDll;

// Token: 0x0200026D RID: 621
[Token(Token = "0x200026D")]
public class PlatformSpecificData
{
	// Token: 0x06000DD5 RID: 3541 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DD5")]
	[Address(RVA = "0x65F1A0", Offset = "0x65E5A0", VA = "0x1065F1A0")]
	public void Deserialize(MessageReader reader)
	{
	}

	// Token: 0x06000DD6 RID: 3542 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DD6")]
	[Address(RVA = "0x65F210", Offset = "0x65E610", VA = "0x1065F210")]
	public void Serialize(MessageWriter writer)
	{
	}

	// Token: 0x06000DD7 RID: 3543 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DD7")]
	[Address(RVA = "0x65F280", Offset = "0x65E680", VA = "0x1065F280")]
	public PlatformSpecificData()
	{
	}

	// Token: 0x04000DCF RID: 3535
	[Token(Token = "0x4000DCF")]
	[FieldOffset(Offset = "0x8")]
	public Platforms Platform;

	// Token: 0x04000DD0 RID: 3536
	[Token(Token = "0x4000DD0")]
	[FieldOffset(Offset = "0xC")]
	public string PlatformName;

	// Token: 0x04000DD1 RID: 3537
	[Token(Token = "0x4000DD1")]
	[FieldOffset(Offset = "0x10")]
	public ulong XboxPlatformId;

	// Token: 0x04000DD2 RID: 3538
	[Token(Token = "0x4000DD2")]
	[FieldOffset(Offset = "0x18")]
	public ulong PsnPlatformId;
}
