using System;
using System.Collections.Generic;
using Hazel;
using Il2CppDummyDll;

// Token: 0x0200048B RID: 1163
[Token(Token = "0x200048B")]
public class DoorsSystemType : ISystemType, IActivatable, RunTimer, IDoorSystem
{
	// Token: 0x17000382 RID: 898
	// (get) Token: 0x060018BC RID: 6332 RVA: 0x00007C08 File Offset: 0x00005E08
	[Token(Token = "0x17000382")]
	public bool IsActive
	{
		[Token(Token = "0x60018BC")]
		[Address(RVA = "0x2D7E70", Offset = "0x2D7270", VA = "0x102D7E70", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000383 RID: 899
	// (get) Token: 0x060018BD RID: 6333 RVA: 0x00007C20 File Offset: 0x00005E20
	// (set) Token: 0x060018BE RID: 6334 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000383")]
	public bool IsDirty
	{
		[Token(Token = "0x60018BD")]
		[Address(RVA = "0x2D4E40", Offset = "0x2D4240", VA = "0x102D4E40", Slot = "4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60018BE")]
		[Address(RVA = "0x2D4E60", Offset = "0x2D4260", VA = "0x102D4E60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private set
		{
		}
	}

	// Token: 0x060018BF RID: 6335 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018BF")]
	[Address(RVA = "0x469890", Offset = "0x468C90", VA = "0x10469890", Slot = "5")]
	public void Detoriorate(float deltaTime)
	{
	}

	// Token: 0x060018C0 RID: 6336 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018C0")]
	[Address(RVA = "0x469A40", Offset = "0x468E40", VA = "0x10469A40", Slot = "6")]
	public void RepairDamage(PlayerControl player, byte amount)
	{
	}

	// Token: 0x060018C1 RID: 6337 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018C1")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "7")]
	public void UpdateSystem(PlayerControl player, MessageReader msgReader)
	{
	}

	// Token: 0x060018C2 RID: 6338 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018C2")]
	[Address(RVA = "0x469B50", Offset = "0x468F50", VA = "0x10469B50", Slot = "8")]
	public void Serialize(MessageWriter writer, bool initialState)
	{
	}

	// Token: 0x060018C3 RID: 6339 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018C3")]
	[Address(RVA = "0x469770", Offset = "0x468B70", VA = "0x10469770", Slot = "9")]
	public void Deserialize(MessageReader reader, bool initialState)
	{
	}

	// Token: 0x060018C4 RID: 6340 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018C4")]
	[Address(RVA = "0x469680", Offset = "0x468A80", VA = "0x10469680", Slot = "12")]
	public void CloseDoorsOfType(SystemTypes room)
	{
	}

	// Token: 0x060018C5 RID: 6341 RVA: 0x00007C38 File Offset: 0x00005E38
	[Token(Token = "0x60018C5")]
	[Address(RVA = "0x4699E0", Offset = "0x468DE0", VA = "0x104699E0", Slot = "13")]
	public virtual float GetTimer(SystemTypes room)
	{
		return 0f;
	}

	// Token: 0x060018C6 RID: 6342 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018C6")]
	[Address(RVA = "0x469D70", Offset = "0x469170", VA = "0x10469D70")]
	public DoorsSystemType()
	{
	}

	// Token: 0x040018D8 RID: 6360
	[Token(Token = "0x40018D8")]
	public const byte CloseDoors = 128;

	// Token: 0x040018D9 RID: 6361
	[Token(Token = "0x40018D9")]
	public const byte OpenDoor = 64;

	// Token: 0x040018DA RID: 6362
	[Token(Token = "0x40018DA")]
	private const byte ActionMask = 192;

	// Token: 0x040018DB RID: 6363
	[Token(Token = "0x40018DB")]
	private const byte IdMask = 31;

	// Token: 0x040018DC RID: 6364
	[Token(Token = "0x40018DC")]
	[FieldOffset(Offset = "0x8")]
	private Dictionary<SystemTypes, float> timers;

	// Token: 0x040018DD RID: 6365
	[Token(Token = "0x40018DD")]
	[FieldOffset(Offset = "0xC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private bool <IsDirty>k__BackingField;
}
