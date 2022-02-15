using System;
using System.Collections.Generic;
using Hazel;
using Il2CppDummyDll;

// Token: 0x02000421 RID: 1057
[Token(Token = "0x2000421")]
public class LifeSuppSystemType : ISystemType, IActivatable
{
	// Token: 0x1700031F RID: 799
	// (get) Token: 0x06001635 RID: 5685 RVA: 0x00007008 File Offset: 0x00005208
	// (set) Token: 0x06001636 RID: 5686 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700031F")]
	public bool IsDirty
	{
		[Token(Token = "0x6001635")]
		[Address(RVA = "0x280880", Offset = "0x27FC80", VA = "0x10280880", Slot = "4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001636")]
		[Address(RVA = "0x280890", Offset = "0x27FC90", VA = "0x10280890")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private set
		{
		}
	}

	// Token: 0x06001637 RID: 5687 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001637")]
	[Address(RVA = "0x6DC3D0", Offset = "0x6DB7D0", VA = "0x106DC3D0")]
	public LifeSuppSystemType(float duration)
	{
	}

	// Token: 0x17000320 RID: 800
	// (get) Token: 0x06001638 RID: 5688 RVA: 0x00007020 File Offset: 0x00005220
	[Token(Token = "0x17000320")]
	public int UserCount
	{
		[Token(Token = "0x6001638")]
		[Address(RVA = "0x6DC450", Offset = "0x6DB850", VA = "0x106DC450")]
		get
		{
			return 0;
		}
	}

	// Token: 0x06001639 RID: 5689 RVA: 0x00007038 File Offset: 0x00005238
	[Token(Token = "0x6001639")]
	[Address(RVA = "0x6DC130", Offset = "0x6DB530", VA = "0x106DC130")]
	public bool GetConsoleComplete(int consoleId)
	{
		return default(bool);
	}

	// Token: 0x17000321 RID: 801
	// (get) Token: 0x0600163A RID: 5690 RVA: 0x00007050 File Offset: 0x00005250
	[Token(Token = "0x17000321")]
	public bool IsActive
	{
		[Token(Token = "0x600163A")]
		[Address(RVA = "0x4F2E60", Offset = "0x4F2260", VA = "0x104F2E60", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600163B RID: 5691 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600163B")]
	[Address(RVA = "0x6DC180", Offset = "0x6DB580", VA = "0x106DC180", Slot = "6")]
	public void RepairDamage(PlayerControl player, byte opCode)
	{
	}

	// Token: 0x0600163C RID: 5692 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600163C")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "7")]
	public void UpdateSystem(PlayerControl player, MessageReader msgReader)
	{
	}

	// Token: 0x0600163D RID: 5693 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600163D")]
	[Address(RVA = "0x6DBFE0", Offset = "0x6DB3E0", VA = "0x106DBFE0", Slot = "5")]
	public void Detoriorate(float deltaTime)
	{
	}

	// Token: 0x0600163E RID: 5694 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600163E")]
	[Address(RVA = "0x6DC270", Offset = "0x6DB670", VA = "0x106DC270", Slot = "8")]
	public void Serialize(MessageWriter writer, bool initialState)
	{
	}

	// Token: 0x0600163F RID: 5695 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600163F")]
	[Address(RVA = "0x6DBF30", Offset = "0x6DB330", VA = "0x106DBF30", Slot = "9")]
	public void Deserialize(MessageReader reader, bool initialState)
	{
	}

	// Token: 0x04001696 RID: 5782
	[Token(Token = "0x4001696")]
	private const float SyncRate = 2f;

	// Token: 0x04001697 RID: 5783
	[Token(Token = "0x4001697")]
	[FieldOffset(Offset = "0x8")]
	private float timer;

	// Token: 0x04001698 RID: 5784
	[Token(Token = "0x4001698")]
	public const byte StartCountdown = 128;

	// Token: 0x04001699 RID: 5785
	[Token(Token = "0x4001699")]
	public const byte AddUserOp = 64;

	// Token: 0x0400169A RID: 5786
	[Token(Token = "0x400169A")]
	public const byte ClearCountdown = 16;

	// Token: 0x0400169B RID: 5787
	[Token(Token = "0x400169B")]
	public const float CountdownStopped = 10000f;

	// Token: 0x0400169C RID: 5788
	[Token(Token = "0x400169C")]
	[FieldOffset(Offset = "0xC")]
	public readonly float LifeSuppDuration;

	// Token: 0x0400169D RID: 5789
	[Token(Token = "0x400169D")]
	public const byte ConsoleIdMask = 3;

	// Token: 0x0400169E RID: 5790
	[Token(Token = "0x400169E")]
	public const byte RequiredUserCount = 2;

	// Token: 0x0400169F RID: 5791
	[Token(Token = "0x400169F")]
	[FieldOffset(Offset = "0x10")]
	public float Countdown;

	// Token: 0x040016A0 RID: 5792
	[Token(Token = "0x40016A0")]
	[FieldOffset(Offset = "0x14")]
	private HashSet<int> CompletedConsoles;

	// Token: 0x040016A1 RID: 5793
	[Token(Token = "0x40016A1")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private bool <IsDirty>k__BackingField;
}
