using System;
using Il2CppDummyDll;

// Token: 0x020002E2 RID: 738
[Token(Token = "0x20002E2")]
public class PetsTab : InventoryTab
{
	// Token: 0x06001046 RID: 4166 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001046")]
	[Address(RVA = "0x65A730", Offset = "0x659B30", VA = "0x1065A730", Slot = "5")]
	public override void OnEnable()
	{
	}

	// Token: 0x06001047 RID: 4167 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001047")]
	[Address(RVA = "0x65AEC0", Offset = "0x65A2C0", VA = "0x1065AEC0")]
	public void Update()
	{
	}

	// Token: 0x06001048 RID: 4168 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001048")]
	[Address(RVA = "0x65AD60", Offset = "0x65A160", VA = "0x1065AD60")]
	private void SelectPet(ColorChip sender, PetData pet)
	{
	}

	// Token: 0x06001049 RID: 4169 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001049")]
	[Address(RVA = "0x65A4D0", Offset = "0x6598D0", VA = "0x1065A4D0", Slot = "4")]
	public override void ClickEquip()
	{
	}

	// Token: 0x0600104A RID: 4170 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600104A")]
	[Address(RVA = "0x65A590", Offset = "0x659990", VA = "0x1065A590", Slot = "7")]
	public override ColorChip GetDefaultSelectable()
	{
		return null;
	}

	// Token: 0x0600104B RID: 4171 RVA: 0x00005D18 File Offset: 0x00003F18
	[Token(Token = "0x600104B")]
	[Address(RVA = "0x2D8E10", Offset = "0x2D8210", VA = "0x102D8E10", Slot = "8")]
	public override bool IsSelectedItemEquipped()
	{
		return default(bool);
	}

	// Token: 0x0600104C RID: 4172 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600104C")]
	[Address(RVA = "0x3BC630", Offset = "0x3BBA30", VA = "0x103BC630")]
	public PetsTab()
	{
	}

	// Token: 0x0600104D RID: 4173 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600104D")]
	[Address(RVA = "0x3BC350", Offset = "0x3BB750", VA = "0x103BC350")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private void <OnEnable>b__2_2()
	{
	}

	// Token: 0x04001006 RID: 4102
	[Token(Token = "0x4001006")]
	[FieldOffset(Offset = "0x2C")]
	private string petId;

	// Token: 0x04001007 RID: 4103
	[Token(Token = "0x4001007")]
	[FieldOffset(Offset = "0x30")]
	private bool currentPetIsEquipped;

	// Token: 0x020002E3 RID: 739
	[Token(Token = "0x20002E3")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass2_0
	{
		// Token: 0x0600104E RID: 4174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600104E")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass2_0()
		{
		}

		// Token: 0x0600104F RID: 4175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600104F")]
		[Address(RVA = "0x79A950", Offset = "0x799D50", VA = "0x1079A950")]
		internal void <OnEnable>b__0()
		{
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001050")]
		[Address(RVA = "0x79A980", Offset = "0x799D80", VA = "0x1079A980")]
		internal void <OnEnable>b__1()
		{
		}

		// Token: 0x06001051 RID: 4177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001051")]
		[Address(RVA = "0x79A950", Offset = "0x799D50", VA = "0x1079A950")]
		internal void <OnEnable>b__3()
		{
		}

		// Token: 0x04001008 RID: 4104
		[Token(Token = "0x4001008")]
		[FieldOffset(Offset = "0x8")]
		public ColorChip chip;

		// Token: 0x04001009 RID: 4105
		[Token(Token = "0x4001009")]
		[FieldOffset(Offset = "0xC")]
		public PetData pet;

		// Token: 0x0400100A RID: 4106
		[Token(Token = "0x400100A")]
		[FieldOffset(Offset = "0x10")]
		public PetsTab <>4__this;
	}
}
