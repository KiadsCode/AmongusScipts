using System;
using System.Collections.Generic;
using Hazel;
using Il2CppDummyDll;

// Token: 0x02000315 RID: 789
[Token(Token = "0x2000315")]
public class MedScanSystem : ISystemType
{
	// Token: 0x17000297 RID: 663
	// (get) Token: 0x06001156 RID: 4438 RVA: 0x00006168 File Offset: 0x00004368
	// (set) Token: 0x06001157 RID: 4439 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000297")]
	public byte CurrentUser
	{
		[Token(Token = "0x6001156")]
		[Address(RVA = "0x2D4E40", Offset = "0x2D4240", VA = "0x102D4E40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001157")]
		[Address(RVA = "0x2D4E60", Offset = "0x2D4260", VA = "0x102D4E60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private set
		{
		}
	}

	// Token: 0x17000298 RID: 664
	// (get) Token: 0x06001158 RID: 4440 RVA: 0x00006180 File Offset: 0x00004380
	// (set) Token: 0x06001159 RID: 4441 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000298")]
	public bool IsDirty
	{
		[Token(Token = "0x6001158")]
		[Address(RVA = "0x2D4E30", Offset = "0x2D4230", VA = "0x102D4E30", Slot = "4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001159")]
		[Address(RVA = "0x2D4E50", Offset = "0x2D4250", VA = "0x102D4E50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private set
		{
		}
	}

	// Token: 0x0600115A RID: 4442 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600115A")]
	[Address(RVA = "0x76D380", Offset = "0x76C780", VA = "0x1076D380", Slot = "5")]
	public void Detoriorate(float deltaTime)
	{
	}

	// Token: 0x0600115B RID: 4443 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600115B")]
	[Address(RVA = "0x76D520", Offset = "0x76C920", VA = "0x1076D520", Slot = "6")]
	public void RepairDamage(PlayerControl player, byte data)
	{
	}

	// Token: 0x0600115C RID: 4444 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600115C")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "7")]
	public void UpdateSystem(PlayerControl player, MessageReader msgReader)
	{
	}

	// Token: 0x0600115D RID: 4445 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600115D")]
	[Address(RVA = "0x76D6F0", Offset = "0x76CAF0", VA = "0x1076D6F0", Slot = "8")]
	public void Serialize(MessageWriter writer, bool initialState)
	{
	}

	// Token: 0x0600115E RID: 4446 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600115E")]
	[Address(RVA = "0x76D2D0", Offset = "0x76C6D0", VA = "0x1076D2D0", Slot = "9")]
	public void Deserialize(MessageReader reader, bool initialState)
	{
	}

	// Token: 0x0600115F RID: 4447 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600115F")]
	[Address(RVA = "0x76D7A0", Offset = "0x76CBA0", VA = "0x1076D7A0")]
	public MedScanSystem()
	{
	}

	// Token: 0x0400112D RID: 4397
	[Token(Token = "0x400112D")]
	public const byte Request = 128;

	// Token: 0x0400112E RID: 4398
	[Token(Token = "0x400112E")]
	public const byte Release = 64;

	// Token: 0x0400112F RID: 4399
	[Token(Token = "0x400112F")]
	public const byte NumMask = 31;

	// Token: 0x04001130 RID: 4400
	[Token(Token = "0x4001130")]
	public const byte NoPlayer = 255;

	// Token: 0x04001131 RID: 4401
	[Token(Token = "0x4001131")]
	[FieldOffset(Offset = "0x8")]
	public List<byte> UsersList;

	// Token: 0x04001132 RID: 4402
	[Token(Token = "0x4001132")]
	[FieldOffset(Offset = "0xC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private byte <CurrentUser>k__BackingField;

	// Token: 0x04001133 RID: 4403
	[Token(Token = "0x4001133")]
	[FieldOffset(Offset = "0xD")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private bool <IsDirty>k__BackingField;

	// Token: 0x02000316 RID: 790
	[Token(Token = "0x2000316")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass14_0
	{
		// Token: 0x06001160 RID: 4448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001160")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass14_0()
		{
		}

		// Token: 0x06001161 RID: 4449 RVA: 0x00006198 File Offset: 0x00004398
		[Token(Token = "0x6001161")]
		[Address(RVA = "0x79A780", Offset = "0x799B80", VA = "0x1079A780")]
		internal bool <RepairDamage>b__0(byte v)
		{
			return default(bool);
		}

		// Token: 0x04001134 RID: 4404
		[Token(Token = "0x4001134")]
		[FieldOffset(Offset = "0x8")]
		public byte playerId;
	}
}
