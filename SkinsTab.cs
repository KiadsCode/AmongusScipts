using System;
using Il2CppDummyDll;

// Token: 0x020002E8 RID: 744
[Token(Token = "0x20002E8")]
public class SkinsTab : InventoryTab
{
	// Token: 0x0600106B RID: 4203 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600106B")]
	[Address(RVA = "0x49FE30", Offset = "0x49F230", VA = "0x1049FE30", Slot = "5")]
	public override void OnEnable()
	{
	}

	// Token: 0x0600106C RID: 4204 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600106C")]
	[Address(RVA = "0x4A0520", Offset = "0x49F920", VA = "0x104A0520")]
	public void Update()
	{
	}

	// Token: 0x0600106D RID: 4205 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600106D")]
	[Address(RVA = "0x49FBA0", Offset = "0x49EFA0", VA = "0x1049FBA0", Slot = "4")]
	public override void ClickEquip()
	{
	}

	// Token: 0x0600106E RID: 4206 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600106E")]
	[Address(RVA = "0x4A02D0", Offset = "0x49F6D0", VA = "0x104A02D0")]
	private void SelectSkin(SkinData skin)
	{
	}

	// Token: 0x0600106F RID: 4207 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600106F")]
	[Address(RVA = "0x49FC60", Offset = "0x49F060", VA = "0x1049FC60", Slot = "7")]
	public override ColorChip GetDefaultSelectable()
	{
		return null;
	}

	// Token: 0x06001070 RID: 4208 RVA: 0x00005D60 File Offset: 0x00003F60
	[Token(Token = "0x6001070")]
	[Address(RVA = "0x2D8E10", Offset = "0x2D8210", VA = "0x102D8E10", Slot = "8")]
	public override bool IsSelectedItemEquipped()
	{
		return default(bool);
	}

	// Token: 0x06001071 RID: 4209 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001071")]
	[Address(RVA = "0x3BC630", Offset = "0x3BBA30", VA = "0x103BC630")]
	public SkinsTab()
	{
	}

	// Token: 0x06001072 RID: 4210 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001072")]
	[Address(RVA = "0x4A03C0", Offset = "0x49F7C0", VA = "0x104A03C0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private void <OnEnable>b__2_1()
	{
	}

	// Token: 0x06001073 RID: 4211 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001073")]
	[Address(RVA = "0x3BC350", Offset = "0x3BB750", VA = "0x103BC350")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private void <OnEnable>b__2_2()
	{
	}

	// Token: 0x04001026 RID: 4134
	[Token(Token = "0x4001026")]
	[FieldOffset(Offset = "0x2C")]
	private string skinId;

	// Token: 0x04001027 RID: 4135
	[Token(Token = "0x4001027")]
	[FieldOffset(Offset = "0x30")]
	private bool currentSkinIsEquipped;

	// Token: 0x020002E9 RID: 745
	[Token(Token = "0x20002E9")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass2_0
	{
		// Token: 0x06001074 RID: 4212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001074")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass2_0()
		{
		}

		// Token: 0x06001075 RID: 4213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001075")]
		[Address(RVA = "0x371360", Offset = "0x370760", VA = "0x10371360")]
		internal void <OnEnable>b__0()
		{
		}

		// Token: 0x06001076 RID: 4214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001076")]
		[Address(RVA = "0x371360", Offset = "0x370760", VA = "0x10371360")]
		internal void <OnEnable>b__3()
		{
		}

		// Token: 0x04001028 RID: 4136
		[Token(Token = "0x4001028")]
		[FieldOffset(Offset = "0x8")]
		public SkinData skin;

		// Token: 0x04001029 RID: 4137
		[Token(Token = "0x4001029")]
		[FieldOffset(Offset = "0xC")]
		public SkinsTab <>4__this;
	}
}
