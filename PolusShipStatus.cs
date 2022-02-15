using System;
using Il2CppDummyDll;

// Token: 0x0200032C RID: 812
[Token(Token = "0x200032C")]
public class PolusShipStatus : ShipStatus
{
	// Token: 0x060011C9 RID: 4553 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011C9")]
	[Address(RVA = "0x50BD60", Offset = "0x50B160", VA = "0x1050BD60", Slot = "11")]
	protected override void OnEnable()
	{
	}

	// Token: 0x060011CA RID: 4554 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011CA")]
	[Address(RVA = "0x50C200", Offset = "0x50B600", VA = "0x1050C200", Slot = "14")]
	public override void SpawnPlayer(PlayerControl player, int numPlayers, bool initialSpawn)
	{
	}

	// Token: 0x060011CB RID: 4555 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011CB")]
	[Address(RVA = "0x50C320", Offset = "0x50B720", VA = "0x1050C320")]
	public PolusShipStatus()
	{
	}

	// Token: 0x0200032D RID: 813
	[Token(Token = "0x200032D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060011CD RID: 4557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011CD")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x060011CE RID: 4558 RVA: 0x000062D0 File Offset: 0x000044D0
		[Token(Token = "0x60011CE")]
		[Address(RVA = "0x7997C0", Offset = "0x798BC0", VA = "0x107997C0")]
		internal bool <OnEnable>b__0_0(ISystemType i)
		{
			return default(bool);
		}

		// Token: 0x040011B4 RID: 4532
		[Token(Token = "0x40011B4")]
		[FieldOffset(Offset = "0x0")]
		public static readonly PolusShipStatus.<>c <>9;

		// Token: 0x040011B5 RID: 4533
		[Token(Token = "0x40011B5")]
		[FieldOffset(Offset = "0x4")]
		public static Func<ISystemType, bool> <>9__0_0;
	}
}
