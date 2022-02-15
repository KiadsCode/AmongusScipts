using System;
using Il2CppDummyDll;

// Token: 0x020002DF RID: 735
[Token(Token = "0x20002DF")]
public class NameplatesTab : InventoryTab
{
	// Token: 0x06001033 RID: 4147 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001033")]
	[Address(RVA = "0x7763C0", Offset = "0x7757C0", VA = "0x107763C0", Slot = "5")]
	public override void OnEnable()
	{
	}

	// Token: 0x06001034 RID: 4148 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001034")]
	[Address(RVA = "0x776AF0", Offset = "0x775EF0", VA = "0x10776AF0")]
	public void Update()
	{
	}

	// Token: 0x06001035 RID: 4149 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001035")]
	[Address(RVA = "0x7760B0", Offset = "0x7754B0", VA = "0x107760B0", Slot = "4")]
	public override void ClickEquip()
	{
	}

	// Token: 0x06001036 RID: 4150 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001036")]
	[Address(RVA = "0x776900", Offset = "0x775D00", VA = "0x10776900")]
	private void SelectNameplate(NamePlateData plate)
	{
	}

	// Token: 0x06001037 RID: 4151 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001037")]
	[Address(RVA = "0x776170", Offset = "0x775570", VA = "0x10776170", Slot = "7")]
	public override ColorChip GetDefaultSelectable()
	{
		return null;
	}

	// Token: 0x06001038 RID: 4152 RVA: 0x00005CA0 File Offset: 0x00003EA0
	[Token(Token = "0x6001038")]
	[Address(RVA = "0x2D9A20", Offset = "0x2D8E20", VA = "0x102D9A20", Slot = "8")]
	public override bool IsSelectedItemEquipped()
	{
		return default(bool);
	}

	// Token: 0x06001039 RID: 4153 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001039")]
	[Address(RVA = "0x3BC630", Offset = "0x3BBA30", VA = "0x103BC630")]
	public NameplatesTab()
	{
	}

	// Token: 0x0600103A RID: 4154 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600103A")]
	[Address(RVA = "0x7769C0", Offset = "0x775DC0", VA = "0x107769C0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private void <OnEnable>b__3_1()
	{
	}

	// Token: 0x0600103B RID: 4155 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600103B")]
	[Address(RVA = "0x3BC350", Offset = "0x3BB750", VA = "0x103BC350")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private void <OnEnable>b__3_2()
	{
	}

	// Token: 0x04000FFC RID: 4092
	[Token(Token = "0x4000FFC")]
	[FieldOffset(Offset = "0x2C")]
	public PlayerVoteArea previewArea;

	// Token: 0x04000FFD RID: 4093
	[Token(Token = "0x4000FFD")]
	[FieldOffset(Offset = "0x30")]
	private string plateId;

	// Token: 0x04000FFE RID: 4094
	[Token(Token = "0x4000FFE")]
	[FieldOffset(Offset = "0x34")]
	private bool currentNameplateIsEquipped;

	// Token: 0x020002E0 RID: 736
	[Token(Token = "0x20002E0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass3_0
	{
		// Token: 0x0600103C RID: 4156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600103C")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass3_0()
		{
		}

		// Token: 0x0600103D RID: 4157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600103D")]
		[Address(RVA = "0x79AAA0", Offset = "0x799EA0", VA = "0x1079AAA0")]
		internal void <OnEnable>b__0()
		{
		}

		// Token: 0x0600103E RID: 4158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600103E")]
		[Address(RVA = "0x79AAA0", Offset = "0x799EA0", VA = "0x1079AAA0")]
		internal void <OnEnable>b__3()
		{
		}

		// Token: 0x04000FFF RID: 4095
		[Token(Token = "0x4000FFF")]
		[FieldOffset(Offset = "0x8")]
		public NamePlateData plate;

		// Token: 0x04001000 RID: 4096
		[Token(Token = "0x4001000")]
		[FieldOffset(Offset = "0xC")]
		public NameplatesTab <>4__this;
	}
}
