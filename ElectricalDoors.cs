using System;
using Hazel;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200006A RID: 106
[Token(Token = "0x200006A")]
public class ElectricalDoors : MonoBehaviour, ISystemType
{
	// Token: 0x17000068 RID: 104
	// (get) Token: 0x060002C8 RID: 712 RVA: 0x00002748 File Offset: 0x00000948
	// (set) Token: 0x060002C9 RID: 713 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000068")]
	public bool IsDirty
	{
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x280880", Offset = "0x27FC80", VA = "0x10280880", Slot = "4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x280890", Offset = "0x27FC90", VA = "0x10280890")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private set
		{
		}
	}

	// Token: 0x060002CA RID: 714 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002CA")]
	[Address(RVA = "0x476890", Offset = "0x475C90", VA = "0x10476890")]
	[Attribute(Name = "ContextMenu", RVA = "0xE5200", Offset = "0xE4600")]
	public void Initialize()
	{
	}

	// Token: 0x060002CB RID: 715 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002CB")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
	public void Detoriorate(float deltaTime)
	{
	}

	// Token: 0x060002CC RID: 716 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002CC")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "6")]
	public void RepairDamage(PlayerControl player, byte amount)
	{
	}

	// Token: 0x060002CD RID: 717 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002CD")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "7")]
	public void UpdateSystem(PlayerControl player, MessageReader msgReader)
	{
	}

	// Token: 0x060002CE RID: 718 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002CE")]
	[Address(RVA = "0x476BD0", Offset = "0x475FD0", VA = "0x10476BD0", Slot = "8")]
	public void Serialize(MessageWriter writer, bool initialState)
	{
	}

	// Token: 0x060002CF RID: 719 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002CF")]
	[Address(RVA = "0x4767F0", Offset = "0x475BF0", VA = "0x104767F0", Slot = "9")]
	public void Deserialize(MessageReader reader, bool initialState)
	{
	}

	// Token: 0x060002D0 RID: 720 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002D0")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public ElectricalDoors()
	{
	}

	// Token: 0x04000283 RID: 643
	[Token(Token = "0x4000283")]
	[FieldOffset(Offset = "0xC")]
	public StaticDoor[] Doors;

	// Token: 0x04000284 RID: 644
	[Token(Token = "0x4000284")]
	[FieldOffset(Offset = "0x10")]
	public ElectricalDoors.DoorSet[] Rooms;

	// Token: 0x04000285 RID: 645
	[Token(Token = "0x4000285")]
	[FieldOffset(Offset = "0x14")]
	public ElectricalDoors.DoorSet LeftExits;

	// Token: 0x04000286 RID: 646
	[Token(Token = "0x4000286")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private bool <IsDirty>k__BackingField;

	// Token: 0x0200006B RID: 107
	[Token(Token = "0x200006B")]
	[Serializable]
	public class DoorSet
	{
		// Token: 0x060002D1 RID: 721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x273EB0", Offset = "0x2732B0", VA = "0x10273EB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public DoorSet()
		{
		}

		// Token: 0x04000287 RID: 647
		[Token(Token = "0x4000287")]
		[FieldOffset(Offset = "0x8")]
		public string Name;

		// Token: 0x04000288 RID: 648
		[Token(Token = "0x4000288")]
		[FieldOffset(Offset = "0xC")]
		public StaticDoor[] Doors;
	}

	// Token: 0x0200006C RID: 108
	[Token(Token = "0x200006C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass8_0
	{
		// Token: 0x060002D3 RID: 723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass8_0()
		{
		}

		// Token: 0x04000289 RID: 649
		[Token(Token = "0x4000289")]
		[FieldOffset(Offset = "0x8")]
		public ElectricalDoors.DoorSet room;
	}

	// Token: 0x0200006D RID: 109
	[Token(Token = "0x200006D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass8_1
	{
		// Token: 0x060002D4 RID: 724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass8_1()
		{
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00002760 File Offset: 0x00000960
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x78DA20", Offset = "0x78CE20", VA = "0x1078DA20")]
		internal bool <Initialize>b__0(ElectricalDoors.DoorSet r)
		{
			return default(bool);
		}

		// Token: 0x0400028A RID: 650
		[Token(Token = "0x400028A")]
		[FieldOffset(Offset = "0x8")]
		public StaticDoor door;

		// Token: 0x0400028B RID: 651
		[Token(Token = "0x400028B")]
		[FieldOffset(Offset = "0xC")]
		public ElectricalDoors.<>c__DisplayClass8_0 CS$<>8__locals1;
	}
}
