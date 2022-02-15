using System;
using System.Collections.Generic;
using Hazel;
using Il2CppDummyDll;

// Token: 0x02000495 RID: 1173
[Token(Token = "0x2000495")]
internal class HqHudSystemType : ISystemType, IActivatable
{
	// Token: 0x1700038C RID: 908
	// (get) Token: 0x060018F9 RID: 6393 RVA: 0x00007CF8 File Offset: 0x00005EF8
	[Token(Token = "0x1700038C")]
	public bool IsActive
	{
		[Token(Token = "0x60018F9")]
		[Address(RVA = "0x3EA5A0", Offset = "0x3E99A0", VA = "0x103EA5A0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700038D RID: 909
	// (get) Token: 0x060018FA RID: 6394 RVA: 0x00007D10 File Offset: 0x00005F10
	[Token(Token = "0x1700038D")]
	public float NumComplete
	{
		[Token(Token = "0x60018FA")]
		[Address(RVA = "0x3EA5E0", Offset = "0x3E99E0", VA = "0x103EA5E0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700038E RID: 910
	// (get) Token: 0x060018FB RID: 6395 RVA: 0x00007D28 File Offset: 0x00005F28
	[Token(Token = "0x1700038E")]
	public float PercentActive
	{
		[Token(Token = "0x60018FB")]
		[Address(RVA = "0x3EA630", Offset = "0x3E9A30", VA = "0x103EA630")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700038F RID: 911
	// (get) Token: 0x060018FC RID: 6396 RVA: 0x00007D40 File Offset: 0x00005F40
	// (set) Token: 0x060018FD RID: 6397 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700038F")]
	public bool IsDirty
	{
		[Token(Token = "0x60018FC")]
		[Address(RVA = "0x280880", Offset = "0x27FC80", VA = "0x10280880", Slot = "4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60018FD")]
		[Address(RVA = "0x280890", Offset = "0x27FC90", VA = "0x10280890")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private set
		{
		}
	}

	// Token: 0x060018FE RID: 6398 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018FE")]
	[Address(RVA = "0x3EA4D0", Offset = "0x3E98D0", VA = "0x103EA4D0")]
	public HqHudSystemType()
	{
	}

	// Token: 0x060018FF RID: 6399 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018FF")]
	[Address(RVA = "0x3E9E60", Offset = "0x3E9260", VA = "0x103E9E60", Slot = "5")]
	public void Detoriorate(float deltaTime)
	{
	}

	// Token: 0x06001900 RID: 6400 RVA: 0x00007D58 File Offset: 0x00005F58
	[Token(Token = "0x6001900")]
	[Address(RVA = "0x3E9FA0", Offset = "0x3E93A0", VA = "0x103E9FA0")]
	internal bool IsConsoleActive(int consoleId)
	{
		return default(bool);
	}

	// Token: 0x06001901 RID: 6401 RVA: 0x00007D70 File Offset: 0x00005F70
	[Token(Token = "0x6001901")]
	[Address(RVA = "0x3EA050", Offset = "0x3E9450", VA = "0x103EA050")]
	internal bool IsConsoleOkay(int consoleId)
	{
		return default(bool);
	}

	// Token: 0x06001902 RID: 6402 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001902")]
	[Address(RVA = "0x3EA0A0", Offset = "0x3E94A0", VA = "0x103EA0A0", Slot = "6")]
	public void RepairDamage(PlayerControl player, byte amount)
	{
	}

	// Token: 0x06001903 RID: 6403 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001903")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "7")]
	public void UpdateSystem(PlayerControl player, MessageReader msgReader)
	{
	}

	// Token: 0x06001904 RID: 6404 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001904")]
	[Address(RVA = "0x3EA260", Offset = "0x3E9660", VA = "0x103EA260", Slot = "8")]
	public void Serialize(MessageWriter writer, bool initialState)
	{
	}

	// Token: 0x06001905 RID: 6405 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001905")]
	[Address(RVA = "0x3E9D00", Offset = "0x3E9100", VA = "0x103E9D00", Slot = "9")]
	public void Deserialize(MessageReader reader, bool initialState)
	{
	}

	// Token: 0x04001913 RID: 6419
	[Token(Token = "0x4001913")]
	public const byte TagMask = 240;

	// Token: 0x04001914 RID: 6420
	[Token(Token = "0x4001914")]
	public const byte IdMask = 15;

	// Token: 0x04001915 RID: 6421
	[Token(Token = "0x4001915")]
	[FieldOffset(Offset = "0x8")]
	private HashSet<Tuple<byte, byte>> ActiveConsoles;

	// Token: 0x04001916 RID: 6422
	[Token(Token = "0x4001916")]
	[FieldOffset(Offset = "0xC")]
	private HashSet<byte> CompletedConsoles;

	// Token: 0x04001917 RID: 6423
	[Token(Token = "0x4001917")]
	private const float ActiveTime = 10f;

	// Token: 0x04001918 RID: 6424
	[Token(Token = "0x4001918")]
	[FieldOffset(Offset = "0x10")]
	private float Timer;

	// Token: 0x04001919 RID: 6425
	[Token(Token = "0x4001919")]
	[FieldOffset(Offset = "0x14")]
	public int TargetNumber;

	// Token: 0x0400191A RID: 6426
	[Token(Token = "0x400191A")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private bool <IsDirty>k__BackingField;

	// Token: 0x02000496 RID: 1174
	[Token(Token = "0x2000496")]
	public enum Tags
	{
		// Token: 0x0400191C RID: 6428
		[Token(Token = "0x400191C")]
		DamageBit = 128,
		// Token: 0x0400191D RID: 6429
		[Token(Token = "0x400191D")]
		ActiveBit = 64,
		// Token: 0x0400191E RID: 6430
		[Token(Token = "0x400191E")]
		DeactiveBit = 32,
		// Token: 0x0400191F RID: 6431
		[Token(Token = "0x400191F")]
		FixBit = 16
	}

	// Token: 0x02000497 RID: 1175
	[Token(Token = "0x2000497")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass20_0
	{
		// Token: 0x06001906 RID: 6406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001906")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass20_0()
		{
		}

		// Token: 0x06001907 RID: 6407 RVA: 0x00007D88 File Offset: 0x00005F88
		[Token(Token = "0x6001907")]
		[Address(RVA = "0x5B5530", Offset = "0x5B4930", VA = "0x105B5530")]
		internal bool <IsConsoleActive>b__0(Tuple<byte, byte> s)
		{
			return default(bool);
		}

		// Token: 0x04001920 RID: 6432
		[Token(Token = "0x4001920")]
		[FieldOffset(Offset = "0x8")]
		public int consoleId;
	}
}
