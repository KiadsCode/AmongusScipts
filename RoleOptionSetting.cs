using System;
using Il2CppDummyDll;
using TMPro;

// Token: 0x0200046F RID: 1135
[Token(Token = "0x200046F")]
public class RoleOptionSetting : OptionBehaviour
{
	// Token: 0x17000377 RID: 887
	// (get) Token: 0x06001839 RID: 6201 RVA: 0x000079B0 File Offset: 0x00005BB0
	[Token(Token = "0x17000377")]
	private int RoleMax
	{
		[Token(Token = "0x6001839")]
		[Address(RVA = "0x57CA20", Offset = "0x57BE20", VA = "0x1057CA20")]
		get
		{
			return 0;
		}
	}

	// Token: 0x0600183A RID: 6202 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600183A")]
	[Address(RVA = "0x57C6C0", Offset = "0x57BAC0", VA = "0x1057C6C0")]
	public void SetRole(RoleOptionsData options)
	{
	}

	// Token: 0x0600183B RID: 6203 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600183B")]
	[Address(RVA = "0x57C8C0", Offset = "0x57BCC0", VA = "0x1057C8C0")]
	public void UpdateValuesAndText(RoleOptionsData options)
	{
	}

	// Token: 0x0600183C RID: 6204 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600183C")]
	[Address(RVA = "0x57C630", Offset = "0x57BA30", VA = "0x1057C630")]
	public void IncreaseCount()
	{
	}

	// Token: 0x0600183D RID: 6205 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600183D")]
	[Address(RVA = "0x57C540", Offset = "0x57B940", VA = "0x1057C540")]
	public void DecreaseCount()
	{
	}

	// Token: 0x0600183E RID: 6206 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600183E")]
	[Address(RVA = "0x57C5C0", Offset = "0x57B9C0", VA = "0x1057C5C0")]
	public void IncreaseChance()
	{
	}

	// Token: 0x0600183F RID: 6207 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600183F")]
	[Address(RVA = "0x57C4D0", Offset = "0x57B8D0", VA = "0x1057C4D0")]
	public void DecreaseChance()
	{
	}

	// Token: 0x06001840 RID: 6208 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001840")]
	[Address(RVA = "0x57C770", Offset = "0x57BB70", VA = "0x1057C770")]
	public void ShowRoleDetails()
	{
	}

	// Token: 0x06001841 RID: 6209 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001841")]
	[Address(RVA = "0x57C710", Offset = "0x57BB10", VA = "0x1057C710")]
	public void ShowAdvancedOptions()
	{
	}

	// Token: 0x06001842 RID: 6210 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001842")]
	[Address(RVA = "0x3AC2A0", Offset = "0x3AB6A0", VA = "0x103AC2A0")]
	public RoleOptionSetting()
	{
	}

	// Token: 0x0400185C RID: 6236
	[Token(Token = "0x400185C")]
	[FieldOffset(Offset = "0x14")]
	public TextMeshPro TitleText;

	// Token: 0x0400185D RID: 6237
	[Token(Token = "0x400185D")]
	[FieldOffset(Offset = "0x18")]
	public TextMeshPro CountText;

	// Token: 0x0400185E RID: 6238
	[Token(Token = "0x400185E")]
	[FieldOffset(Offset = "0x1C")]
	public TextMeshPro ChanceText;

	// Token: 0x0400185F RID: 6239
	[Token(Token = "0x400185F")]
	[FieldOffset(Offset = "0x20")]
	public RoleBehaviour Role;

	// Token: 0x04001860 RID: 6240
	[Token(Token = "0x4001860")]
	[FieldOffset(Offset = "0x24")]
	public int RoleMaxCount;

	// Token: 0x04001861 RID: 6241
	[Token(Token = "0x4001861")]
	[FieldOffset(Offset = "0x28")]
	public int RoleChance;
}
