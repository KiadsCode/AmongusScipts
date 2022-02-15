using System;
using System.Collections.Generic;
using Hazel;
using Il2CppDummyDll;

// Token: 0x02000522 RID: 1314
[Token(Token = "0x2000522")]
public class VentilationSystem : ISystemType
{
	// Token: 0x17000407 RID: 1031
	// (get) Token: 0x06001BDB RID: 7131 RVA: 0x00008C40 File Offset: 0x00006E40
	// (set) Token: 0x06001BDC RID: 7132 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000407")]
	public bool IsDirty
	{
		[Token(Token = "0x6001BDB")]
		[Address(RVA = "0x280880", Offset = "0x27FC80", VA = "0x10280880", Slot = "4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001BDC")]
		[Address(RVA = "0x280890", Offset = "0x27FC90", VA = "0x10280890")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private set
		{
		}
	}

	// Token: 0x06001BDD RID: 7133 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BDD")]
	[Address(RVA = "0x7AE1D0", Offset = "0x7AD5D0", VA = "0x107AE1D0")]
	public static void Update(VentilationSystem.Operation op, int ventId)
	{
	}

	// Token: 0x06001BDE RID: 7134 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BDE")]
	[Address(RVA = "0x7AD050", Offset = "0x7AC450", VA = "0x107AD050", Slot = "5")]
	public void Detoriorate(float deltaTime)
	{
	}

	// Token: 0x06001BDF RID: 7135 RVA: 0x00008C58 File Offset: 0x00006E58
	[Token(Token = "0x6001BDF")]
	[Address(RVA = "0x7AD4F0", Offset = "0x7AC8F0", VA = "0x107AD4F0")]
	public bool IsVentCurrentlyBeingCleaned(int id)
	{
		return default(bool);
	}

	// Token: 0x06001BE0 RID: 7136 RVA: 0x00008C70 File Offset: 0x00006E70
	[Token(Token = "0x6001BE0")]
	[Address(RVA = "0x7AD370", Offset = "0x7AC770", VA = "0x107AD370")]
	public bool IsImpostorInsideVent(int ventId)
	{
		return default(bool);
	}

	// Token: 0x06001BE1 RID: 7137 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BE1")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "6")]
	public void RepairDamage(PlayerControl player, byte opCode)
	{
	}

	// Token: 0x06001BE2 RID: 7138 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BE2")]
	[Address(RVA = "0x7ADA70", Offset = "0x7ACE70", VA = "0x107ADA70", Slot = "7")]
	public void UpdateSystem(PlayerControl player, MessageReader msgReader)
	{
	}

	// Token: 0x06001BE3 RID: 7139 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BE3")]
	[Address(RVA = "0x7AD670", Offset = "0x7ACA70", VA = "0x107AD670")]
	private void PerformVentOp(byte playerId, VentilationSystem.Operation op, byte ventId, SequenceBuffer<VentilationSystem.VentMoveInfo> seqBuffer)
	{
	}

	// Token: 0x06001BE4 RID: 7140 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BE4")]
	[Address(RVA = "0x7AD820", Offset = "0x7ACC20", VA = "0x107AD820", Slot = "8")]
	public void Serialize(MessageWriter writer, bool initialState)
	{
	}

	// Token: 0x06001BE5 RID: 7141 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BE5")]
	[Address(RVA = "0x7ACF20", Offset = "0x7AC320", VA = "0x107ACF20", Slot = "9")]
	public void Deserialize(MessageReader reader, bool initialState)
	{
	}

	// Token: 0x06001BE6 RID: 7142 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BE6")]
	[Address(RVA = "0x7ACE40", Offset = "0x7AC240", VA = "0x107ACE40")]
	private void BootImpostorsFromVent(int ventId)
	{
	}

	// Token: 0x06001BE7 RID: 7143 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BE7")]
	[Address(RVA = "0x7ACCF0", Offset = "0x7AC0F0", VA = "0x107ACCF0")]
	private void BootImpostorFromVent(int ventId, byte playerId)
	{
	}

	// Token: 0x06001BE8 RID: 7144 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BE8")]
	[Address(RVA = "0x7AE140", Offset = "0x7AD540", VA = "0x107AE140")]
	private void UpdateVentArrows()
	{
	}

	// Token: 0x06001BE9 RID: 7145 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BE9")]
	[Address(RVA = "0x7AE470", Offset = "0x7AD870", VA = "0x107AE470")]
	public VentilationSystem()
	{
	}

	// Token: 0x04001F98 RID: 8088
	[Token(Token = "0x4001F98")]
	private const ushort OP_ID_START = 0;

	// Token: 0x04001F99 RID: 8089
	[Token(Token = "0x4001F99")]
	[FieldOffset(Offset = "0x8")]
	private readonly Dictionary<byte, SequenceBuffer<VentilationSystem.VentMoveInfo>> SeqBuffers;

	// Token: 0x04001F9A RID: 8090
	[Token(Token = "0x4001F9A")]
	[FieldOffset(Offset = "0xC")]
	private readonly Dictionary<byte, byte> PlayersCleaningVents;

	// Token: 0x04001F9B RID: 8091
	[Token(Token = "0x4001F9B")]
	[FieldOffset(Offset = "0x10")]
	private readonly Dictionary<byte, byte> PlayersInsideVents;

	// Token: 0x04001F9C RID: 8092
	[Token(Token = "0x4001F9C")]
	[FieldOffset(Offset = "0x14")]
	private readonly HashSet<byte> ToRemove;

	// Token: 0x04001F9D RID: 8093
	[Token(Token = "0x4001F9D")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private bool <IsDirty>k__BackingField;

	// Token: 0x02000523 RID: 1315
	[Token(Token = "0x2000523")]
	public struct VentMoveInfo
	{
		// Token: 0x04001F9E RID: 8094
		[Token(Token = "0x4001F9E")]
		[FieldOffset(Offset = "0x0")]
		public VentilationSystem.Operation Op;

		// Token: 0x04001F9F RID: 8095
		[Token(Token = "0x4001F9F")]
		[FieldOffset(Offset = "0x4")]
		public byte VentId;

		// Token: 0x04001FA0 RID: 8096
		[Token(Token = "0x4001FA0")]
		[FieldOffset(Offset = "0x5")]
		public byte PlayerId;
	}

	// Token: 0x02000524 RID: 1316
	[Token(Token = "0x2000524")]
	public enum Operation
	{
		// Token: 0x04001FA2 RID: 8098
		[Token(Token = "0x4001FA2")]
		StartCleaning,
		// Token: 0x04001FA3 RID: 8099
		[Token(Token = "0x4001FA3")]
		StopCleaning,
		// Token: 0x04001FA4 RID: 8100
		[Token(Token = "0x4001FA4")]
		Enter,
		// Token: 0x04001FA5 RID: 8101
		[Token(Token = "0x4001FA5")]
		Exit,
		// Token: 0x04001FA6 RID: 8102
		[Token(Token = "0x4001FA6")]
		Move,
		// Token: 0x04001FA7 RID: 8103
		[Token(Token = "0x4001FA7")]
		BootImpostors
	}

	// Token: 0x02000525 RID: 1317
	[Token(Token = "0x2000525")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06001BEB RID: 7147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BEB")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x06001BEC RID: 7148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BEC")]
		[Address(RVA = "0x13020C0", Offset = "0x13014C0", VA = "0x113020C0")]
		internal SequenceBuffer<VentilationSystem.VentMoveInfo> <Update>b__11_0()
		{
			return null;
		}

		// Token: 0x04001FA8 RID: 8104
		[Token(Token = "0x4001FA8")]
		[FieldOffset(Offset = "0x0")]
		public static readonly VentilationSystem.<>c <>9;

		// Token: 0x04001FA9 RID: 8105
		[Token(Token = "0x4001FA9")]
		[FieldOffset(Offset = "0x4")]
		public static Func<SequenceBuffer<VentilationSystem.VentMoveInfo>> <>9__11_0;
	}

	// Token: 0x02000526 RID: 1318
	[Token(Token = "0x2000526")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass16_0
	{
		// Token: 0x06001BED RID: 7149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BED")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass16_0()
		{
		}

		// Token: 0x06001BEE RID: 7150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BEE")]
		[Address(RVA = "0x13022C0", Offset = "0x13016C0", VA = "0x113022C0")]
		internal SequenceBuffer<VentilationSystem.VentMoveInfo> <UpdateSystem>b__0()
		{
			return null;
		}

		// Token: 0x04001FAA RID: 8106
		[Token(Token = "0x4001FAA")]
		[FieldOffset(Offset = "0x8")]
		public ushort opId;
	}
}
