using System;
using System.Collections.Generic;
using Hazel;
using Il2CppDummyDll;

// Token: 0x02000423 RID: 1059
[Token(Token = "0x2000423")]
public class ReactorSystemType : ISystemType, IActivatable, ICriticalSabotage
{
	// Token: 0x17000322 RID: 802
	// (get) Token: 0x06001645 RID: 5701 RVA: 0x00007068 File Offset: 0x00005268
	// (set) Token: 0x06001646 RID: 5702 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000322")]
	public float Countdown
	{
		[Token(Token = "0x6001645")]
		[Address(RVA = "0x273A10", Offset = "0x272E10", VA = "0x10273A10", Slot = "12")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6001646")]
		[Address(RVA = "0x273A30", Offset = "0x272E30", VA = "0x10273A30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private set
		{
		}
	}

	// Token: 0x17000323 RID: 803
	// (get) Token: 0x06001647 RID: 5703 RVA: 0x00007080 File Offset: 0x00005280
	// (set) Token: 0x06001648 RID: 5704 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000323")]
	public bool IsDirty
	{
		[Token(Token = "0x6001647")]
		[Address(RVA = "0x4F2E80", Offset = "0x4F2280", VA = "0x104F2E80", Slot = "4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001648")]
		[Address(RVA = "0x39BA70", Offset = "0x39AE70", VA = "0x1039BA70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private set
		{
		}
	}

	// Token: 0x06001649 RID: 5705 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001649")]
	[Address(RVA = "0x4F2DE0", Offset = "0x4F21E0", VA = "0x104F2DE0")]
	public ReactorSystemType(float duration, SystemTypes system)
	{
	}

	// Token: 0x17000324 RID: 804
	// (get) Token: 0x0600164A RID: 5706 RVA: 0x00007098 File Offset: 0x00005298
	[Token(Token = "0x17000324")]
	public int UserCount
	{
		[Token(Token = "0x600164A")]
		[Address(RVA = "0x4F2E90", Offset = "0x4F2290", VA = "0x104F2E90", Slot = "13")]
		get
		{
			return 0;
		}
	}

	// Token: 0x0600164B RID: 5707 RVA: 0x000070B0 File Offset: 0x000052B0
	[Token(Token = "0x600164B")]
	[Address(RVA = "0x4F29C0", Offset = "0x4F1DC0", VA = "0x104F29C0")]
	public bool GetConsoleComplete(int consoleId)
	{
		return default(bool);
	}

	// Token: 0x0600164C RID: 5708 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600164C")]
	[Address(RVA = "0x4F2790", Offset = "0x4F1B90", VA = "0x104F2790", Slot = "14")]
	public void ClearSabotage()
	{
	}

	// Token: 0x17000325 RID: 805
	// (get) Token: 0x0600164D RID: 5709 RVA: 0x000070C8 File Offset: 0x000052C8
	[Token(Token = "0x17000325")]
	public bool IsActive
	{
		[Token(Token = "0x600164D")]
		[Address(RVA = "0x4F2E60", Offset = "0x4F2260", VA = "0x104F2E60", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600164E RID: 5710 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600164E")]
	[Address(RVA = "0x4F2A70", Offset = "0x4F1E70", VA = "0x104F2A70", Slot = "6")]
	public void RepairDamage(PlayerControl player, byte opCode)
	{
	}

	// Token: 0x0600164F RID: 5711 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600164F")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "7")]
	public void UpdateSystem(PlayerControl player, MessageReader msgReader)
	{
	}

	// Token: 0x06001650 RID: 5712 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001650")]
	[Address(RVA = "0x4F28A0", Offset = "0x4F1CA0", VA = "0x104F28A0", Slot = "5")]
	public void Detoriorate(float deltaTime)
	{
	}

	// Token: 0x06001651 RID: 5713 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001651")]
	[Address(RVA = "0x4F2C50", Offset = "0x4F2050", VA = "0x104F2C50", Slot = "8")]
	public void Serialize(MessageWriter writer, bool initialState)
	{
	}

	// Token: 0x06001652 RID: 5714 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001652")]
	[Address(RVA = "0x4F27A0", Offset = "0x4F1BA0", VA = "0x104F27A0", Slot = "9")]
	public void Deserialize(MessageReader reader, bool initialState)
	{
	}

	// Token: 0x040016AB RID: 5803
	[Token(Token = "0x40016AB")]
	private const float SyncRate = 2f;

	// Token: 0x040016AC RID: 5804
	[Token(Token = "0x40016AC")]
	[FieldOffset(Offset = "0x8")]
	private float timer;

	// Token: 0x040016AD RID: 5805
	[Token(Token = "0x40016AD")]
	public const byte StartCountdown = 128;

	// Token: 0x040016AE RID: 5806
	[Token(Token = "0x40016AE")]
	public const byte AddUserOp = 64;

	// Token: 0x040016AF RID: 5807
	[Token(Token = "0x40016AF")]
	public const byte RemoveUserOp = 32;

	// Token: 0x040016B0 RID: 5808
	[Token(Token = "0x40016B0")]
	public const byte ClearCountdown = 16;

	// Token: 0x040016B1 RID: 5809
	[Token(Token = "0x40016B1")]
	public const float CountdownStopped = 10000f;

	// Token: 0x040016B2 RID: 5810
	[Token(Token = "0x40016B2")]
	[FieldOffset(Offset = "0xC")]
	public readonly float ReactorDuration;

	// Token: 0x040016B3 RID: 5811
	[Token(Token = "0x40016B3")]
	public const byte ConsoleIdMask = 3;

	// Token: 0x040016B4 RID: 5812
	[Token(Token = "0x40016B4")]
	public const byte RequiredUserCount = 2;

	// Token: 0x040016B5 RID: 5813
	[Token(Token = "0x40016B5")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private float <Countdown>k__BackingField;

	// Token: 0x040016B6 RID: 5814
	[Token(Token = "0x40016B6")]
	[FieldOffset(Offset = "0x14")]
	private HashSet<Tuple<byte, byte>> UserConsolePairs;

	// Token: 0x040016B7 RID: 5815
	[Token(Token = "0x40016B7")]
	[FieldOffset(Offset = "0x18")]
	private SystemTypes system;

	// Token: 0x040016B8 RID: 5816
	[Token(Token = "0x40016B8")]
	[FieldOffset(Offset = "0x19")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private bool <IsDirty>k__BackingField;

	// Token: 0x02000424 RID: 1060
	[Token(Token = "0x2000424")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass23_0
	{
		// Token: 0x06001653 RID: 5715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001653")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass23_0()
		{
		}

		// Token: 0x06001654 RID: 5716 RVA: 0x000070E0 File Offset: 0x000052E0
		[Token(Token = "0x6001654")]
		[Address(RVA = "0x371180", Offset = "0x370580", VA = "0x10371180")]
		internal bool <GetConsoleComplete>b__0(Tuple<byte, byte> kvp)
		{
			return default(bool);
		}

		// Token: 0x040016B9 RID: 5817
		[Token(Token = "0x40016B9")]
		[FieldOffset(Offset = "0x8")]
		public int consoleId;
	}
}
