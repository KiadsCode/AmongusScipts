using System;
using Il2CppDummyDll;

// Token: 0x020004E3 RID: 1251
[Token(Token = "0x20004E3")]
public class StoreChip : ColorChip
{
	// Token: 0x170003E8 RID: 1000
	// (get) Token: 0x06001ABB RID: 6843 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001ABC RID: 6844 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003E8")]
	public StoreMenu Parent
	{
		[Token(Token = "0x6001ABB")]
		[Address(RVA = "0x292AA0", Offset = "0x291EA0", VA = "0x10292AA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001ABC")]
		[Address(RVA = "0x292AB0", Offset = "0x291EB0", VA = "0x10292AB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		set
		{
		}
	}

	// Token: 0x06001ABD RID: 6845 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001ABD")]
	[Address(RVA = "0x75C4C0", Offset = "0x75B8C0", VA = "0x1075C4C0")]
	public void SetData(CosmeticData prod)
	{
	}

	// Token: 0x06001ABE RID: 6846 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001ABE")]
	[Address(RVA = "0x3AC2A0", Offset = "0x3AB6A0", VA = "0x103AC2A0")]
	public StoreChip()
	{
	}

	// Token: 0x04001ADE RID: 6878
	[Token(Token = "0x4001ADE")]
	[FieldOffset(Offset = "0x24")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private StoreMenu <Parent>k__BackingField;

	// Token: 0x04001ADF RID: 6879
	[Token(Token = "0x4001ADF")]
	[FieldOffset(Offset = "0x28")]
	public CosmeticData product;

	// Token: 0x04001AE0 RID: 6880
	[Token(Token = "0x4001AE0")]
	[FieldOffset(Offset = "0x2C")]
	public StoreMannequin storeMannequin;
}
