using System;
using Il2CppDummyDll;

// Token: 0x020003AD RID: 941
[Token(Token = "0x20003AD")]
[Attribute(Name = "AttributeUsageAttribute", RVA = "0xDE300", Offset = "0xDD700")]
public class QuickChatMenuDisplayAttribute : Attribute
{
	// Token: 0x060013E4 RID: 5092 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013E4")]
	[Address(RVA = "0x285610", Offset = "0x284A10", VA = "0x10285610")]
	public QuickChatMenuDisplayAttribute(QuickChatMenuItem.QuickChatMenuItemType displayType)
	{
	}

	// Token: 0x0400144C RID: 5196
	[Token(Token = "0x400144C")]
	[FieldOffset(Offset = "0x8")]
	public QuickChatMenuItem.QuickChatMenuItemType propertyMenuType;
}
