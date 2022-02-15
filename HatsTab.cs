using System;
using Il2CppDummyDll;

// Token: 0x020002DA RID: 730
[Token(Token = "0x20002DA")]
public class HatsTab : InventoryTab
{
	// Token: 0x06001018 RID: 4120 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001018")]
	[Address(RVA = "0x3BB920", Offset = "0x3BAD20", VA = "0x103BB920", Slot = "5")]
	public override void OnEnable()
	{
	}

	// Token: 0x06001019 RID: 4121 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001019")]
	[Address(RVA = "0x3BC370", Offset = "0x3BB770", VA = "0x103BC370")]
	public void Update()
	{
	}

	// Token: 0x0600101A RID: 4122 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600101A")]
	[Address(RVA = "0x3BC000", Offset = "0x3BB400", VA = "0x103BC000")]
	private void SelectHat(HatBehaviour hat)
	{
	}

	// Token: 0x0600101B RID: 4123 RVA: 0x00005C40 File Offset: 0x00003E40
	[Token(Token = "0x600101B")]
	[Address(RVA = "0x2D8E10", Offset = "0x2D8210", VA = "0x102D8E10", Slot = "8")]
	public override bool IsSelectedItemEquipped()
	{
		return default(bool);
	}

	// Token: 0x0600101C RID: 4124 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600101C")]
	[Address(RVA = "0x3BB600", Offset = "0x3BAA00", VA = "0x103BB600", Slot = "4")]
	public override void ClickEquip()
	{
	}

	// Token: 0x0600101D RID: 4125 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600101D")]
	[Address(RVA = "0x3BB760", Offset = "0x3BAB60", VA = "0x103BB760", Slot = "7")]
	public override ColorChip GetDefaultSelectable()
	{
		return null;
	}

	// Token: 0x0600101E RID: 4126 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600101E")]
	[Address(RVA = "0x3BC630", Offset = "0x3BBA30", VA = "0x103BC630")]
	public HatsTab()
	{
	}

	// Token: 0x0600101F RID: 4127 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600101F")]
	[Address(RVA = "0x3BC2C0", Offset = "0x3BB6C0", VA = "0x103BC2C0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private void <OnEnable>b__2_1()
	{
	}

	// Token: 0x06001020 RID: 4128 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001020")]
	[Address(RVA = "0x3BC350", Offset = "0x3BB750", VA = "0x103BC350")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private void <OnEnable>b__2_2()
	{
	}

	// Token: 0x04000FE8 RID: 4072
	[Token(Token = "0x4000FE8")]
	[FieldOffset(Offset = "0x2C")]
	private HatBehaviour currentHat;

	// Token: 0x04000FE9 RID: 4073
	[Token(Token = "0x4000FE9")]
	[FieldOffset(Offset = "0x30")]
	private bool currentHatIsEquipped;

	// Token: 0x020002DB RID: 731
	[Token(Token = "0x20002DB")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass2_0
	{
		// Token: 0x06001021 RID: 4129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001021")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass2_0()
		{
		}

		// Token: 0x06001022 RID: 4130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001022")]
		[Address(RVA = "0x5B5750", Offset = "0x5B4B50", VA = "0x105B5750")]
		internal void <OnEnable>b__0()
		{
		}

		// Token: 0x06001023 RID: 4131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001023")]
		[Address(RVA = "0x5B5750", Offset = "0x5B4B50", VA = "0x105B5750")]
		internal void <OnEnable>b__3()
		{
		}

		// Token: 0x04000FEA RID: 4074
		[Token(Token = "0x4000FEA")]
		[FieldOffset(Offset = "0x8")]
		public HatBehaviour hat;

		// Token: 0x04000FEB RID: 4075
		[Token(Token = "0x4000FEB")]
		[FieldOffset(Offset = "0xC")]
		public HatsTab <>4__this;
	}
}
