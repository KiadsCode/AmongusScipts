using System;
using Il2CppDummyDll;

// Token: 0x0200015A RID: 346
[Token(Token = "0x200015A")]
public class DivertPowerMetagame : Minigame
{
	// Token: 0x060007F0 RID: 2032 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007F0")]
	[Address(RVA = "0x5C95E0", Offset = "0x5C89E0", VA = "0x105C95E0", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x060007F1 RID: 2033 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007F1")]
	[Address(RVA = "0x3AC2A0", Offset = "0x3AB6A0", VA = "0x103AC2A0")]
	public DivertPowerMetagame()
	{
	}

	// Token: 0x040007D2 RID: 2002
	[Token(Token = "0x40007D2")]
	[FieldOffset(Offset = "0x30")]
	public Minigame DistributePrefab;

	// Token: 0x040007D3 RID: 2003
	[Token(Token = "0x40007D3")]
	[FieldOffset(Offset = "0x34")]
	public Minigame ReceivePrefab;
}
