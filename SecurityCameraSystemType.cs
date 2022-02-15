using System;
using System.Collections.Generic;
using Hazel;
using Il2CppDummyDll;

// Token: 0x02000455 RID: 1109
[Token(Token = "0x2000455")]
public class SecurityCameraSystemType : ISystemType
{
	// Token: 0x1700036E RID: 878
	// (get) Token: 0x060017A2 RID: 6050 RVA: 0x00007818 File Offset: 0x00005A18
	[Token(Token = "0x1700036E")]
	public bool InUse
	{
		[Token(Token = "0x60017A2")]
		[Address(RVA = "0x58ECF0", Offset = "0x58E0F0", VA = "0x1058ECF0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700036F RID: 879
	// (get) Token: 0x060017A3 RID: 6051 RVA: 0x00007830 File Offset: 0x00005A30
	// (set) Token: 0x060017A4 RID: 6052 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700036F")]
	public bool IsDirty
	{
		[Token(Token = "0x60017A3")]
		[Address(RVA = "0x2D4E40", Offset = "0x2D4240", VA = "0x102D4E40", Slot = "4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60017A4")]
		[Address(RVA = "0x2D4E60", Offset = "0x2D4260", VA = "0x102D4E60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private set
		{
		}
	}

	// Token: 0x060017A5 RID: 6053 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017A5")]
	[Address(RVA = "0x58E760", Offset = "0x58DB60", VA = "0x1058E760", Slot = "5")]
	public void Detoriorate(float deltaTime)
	{
	}

	// Token: 0x060017A6 RID: 6054 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017A6")]
	[Address(RVA = "0x58E9A0", Offset = "0x58DDA0", VA = "0x1058E9A0", Slot = "6")]
	public void RepairDamage(PlayerControl player, byte amount)
	{
	}

	// Token: 0x060017A7 RID: 6055 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017A7")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "7")]
	public void UpdateSystem(PlayerControl player, MessageReader msgReader)
	{
	}

	// Token: 0x060017A8 RID: 6056 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017A8")]
	[Address(RVA = "0x58EB80", Offset = "0x58DF80", VA = "0x1058EB80")]
	private void UpdateCameras()
	{
	}

	// Token: 0x060017A9 RID: 6057 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017A9")]
	[Address(RVA = "0x58EA30", Offset = "0x58DE30", VA = "0x1058EA30", Slot = "8")]
	public void Serialize(MessageWriter writer, bool initialState)
	{
	}

	// Token: 0x060017AA RID: 6058 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017AA")]
	[Address(RVA = "0x58E6B0", Offset = "0x58DAB0", VA = "0x1058E6B0", Slot = "9")]
	public void Deserialize(MessageReader reader, bool initialState)
	{
	}

	// Token: 0x060017AB RID: 6059 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017AB")]
	[Address(RVA = "0x58EC70", Offset = "0x58E070", VA = "0x1058EC70")]
	public SecurityCameraSystemType()
	{
	}

	// Token: 0x040017B3 RID: 6067
	[Token(Token = "0x40017B3")]
	public const byte IncrementOp = 1;

	// Token: 0x040017B4 RID: 6068
	[Token(Token = "0x40017B4")]
	public const byte DecrementOp = 2;

	// Token: 0x040017B5 RID: 6069
	[Token(Token = "0x40017B5")]
	[FieldOffset(Offset = "0x8")]
	private HashSet<byte> PlayersUsing;

	// Token: 0x040017B6 RID: 6070
	[Token(Token = "0x40017B6")]
	[FieldOffset(Offset = "0xC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private bool <IsDirty>k__BackingField;

	// Token: 0x040017B7 RID: 6071
	[Token(Token = "0x40017B7")]
	[FieldOffset(Offset = "0x10")]
	private HashSet<byte> ToRemove;
}
