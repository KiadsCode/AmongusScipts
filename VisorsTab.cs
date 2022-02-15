using System;
using Il2CppDummyDll;

// Token: 0x020002EB RID: 747
[Token(Token = "0x20002EB")]
public class VisorsTab : InventoryTab
{
	// Token: 0x0600107A RID: 4218 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600107A")]
	[Address(RVA = "0x7B2CE0", Offset = "0x7B20E0", VA = "0x107B2CE0", Slot = "5")]
	public override void OnEnable()
	{
	}

	// Token: 0x0600107B RID: 4219 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600107B")]
	[Address(RVA = "0x7B34F0", Offset = "0x7B28F0", VA = "0x107B34F0")]
	public void Update()
	{
	}

	// Token: 0x0600107C RID: 4220 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600107C")]
	[Address(RVA = "0x7B3290", Offset = "0x7B2690", VA = "0x107B3290")]
	private void SelectVisor(ColorChip chip, VisorData visor)
	{
	}

	// Token: 0x0600107D RID: 4221 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600107D")]
	[Address(RVA = "0x7B28F0", Offset = "0x7B1CF0", VA = "0x107B28F0", Slot = "4")]
	public override void ClickEquip()
	{
	}

	// Token: 0x0600107E RID: 4222 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600107E")]
	[Address(RVA = "0x7B2AF0", Offset = "0x7B1EF0", VA = "0x107B2AF0", Slot = "7")]
	public override ColorChip GetDefaultSelectable()
	{
		return null;
	}

	// Token: 0x0600107F RID: 4223 RVA: 0x00005D78 File Offset: 0x00003F78
	[Token(Token = "0x600107F")]
	[Address(RVA = "0x2D8E10", Offset = "0x2D8210", VA = "0x102D8E10", Slot = "8")]
	public override bool IsSelectedItemEquipped()
	{
		return default(bool);
	}

	// Token: 0x06001080 RID: 4224 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001080")]
	[Address(RVA = "0x3BC630", Offset = "0x3BBA30", VA = "0x103BC630")]
	public VisorsTab()
	{
	}

	// Token: 0x06001081 RID: 4225 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001081")]
	[Address(RVA = "0x3BC350", Offset = "0x3BB750", VA = "0x103BC350")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private void <OnEnable>b__2_2()
	{
	}

	// Token: 0x0400102D RID: 4141
	[Token(Token = "0x400102D")]
	[FieldOffset(Offset = "0x2C")]
	private string visorId;

	// Token: 0x0400102E RID: 4142
	[Token(Token = "0x400102E")]
	[FieldOffset(Offset = "0x30")]
	private bool currentVisorIsEquipped;

	// Token: 0x020002EC RID: 748
	[Token(Token = "0x20002EC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass2_0
	{
		// Token: 0x06001082 RID: 4226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001082")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass2_0()
		{
		}

		// Token: 0x06001083 RID: 4227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001083")]
		[Address(RVA = "0x1302730", Offset = "0x1301B30", VA = "0x11302730")]
		internal void <OnEnable>b__0()
		{
		}

		// Token: 0x06001084 RID: 4228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001084")]
		[Address(RVA = "0x1302760", Offset = "0x1301B60", VA = "0x11302760")]
		internal void <OnEnable>b__1()
		{
		}

		// Token: 0x06001085 RID: 4229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001085")]
		[Address(RVA = "0x1302730", Offset = "0x1301B30", VA = "0x11302730")]
		internal void <OnEnable>b__3()
		{
		}

		// Token: 0x0400102F RID: 4143
		[Token(Token = "0x400102F")]
		[FieldOffset(Offset = "0x8")]
		public ColorChip chip;

		// Token: 0x04001030 RID: 4144
		[Token(Token = "0x4001030")]
		[FieldOffset(Offset = "0xC")]
		public VisorData visor;

		// Token: 0x04001031 RID: 4145
		[Token(Token = "0x4001031")]
		[FieldOffset(Offset = "0x10")]
		public VisorsTab <>4__this;
	}
}
