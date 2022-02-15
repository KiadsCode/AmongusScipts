using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002D8 RID: 728
[Token(Token = "0x20002D8")]
public class RolesSettingsMenu : MonoBehaviour
{
	// Token: 0x0600100E RID: 4110 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600100E")]
	[Address(RVA = "0x57DC70", Offset = "0x57D070", VA = "0x1057DC70")]
	private void Start()
	{
	}

	// Token: 0x0600100F RID: 4111 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600100F")]
	[Address(RVA = "0x57DE20", Offset = "0x57D220", VA = "0x1057DE20")]
	private void Update()
	{
	}

	// Token: 0x06001010 RID: 4112 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001010")]
	[Address(RVA = "0x57D620", Offset = "0x57CA20", VA = "0x1057D620")]
	private void OnEnable()
	{
	}

	// Token: 0x06001011 RID: 4113 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001011")]
	[Address(RVA = "0x57D7F0", Offset = "0x57CBF0", VA = "0x1057D7F0")]
	private void RefreshChildren()
	{
	}

	// Token: 0x06001012 RID: 4114 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001012")]
	[Address(RVA = "0x57DEC0", Offset = "0x57D2C0", VA = "0x1057DEC0")]
	private void ValueChanged(OptionBehaviour obj)
	{
	}

	// Token: 0x06001013 RID: 4115 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001013")]
	[Address(RVA = "0x57DB80", Offset = "0x57CF80", VA = "0x1057DB80")]
	public void ShowAdvancedSettings(RoleBehaviour role)
	{
	}

	// Token: 0x06001014 RID: 4116 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001014")]
	[Address(RVA = "0x57D5E0", Offset = "0x57C9E0", VA = "0x1057D5E0")]
	public void CloseAdvancedSettings()
	{
	}

	// Token: 0x06001015 RID: 4117 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001015")]
	[Address(RVA = "0x57E380", Offset = "0x57D780", VA = "0x1057E380")]
	public RolesSettingsMenu()
	{
	}

	// Token: 0x04000FDD RID: 4061
	[Token(Token = "0x4000FDD")]
	[FieldOffset(Offset = "0xC")]
	public List<RoleOptionSetting> AllRoleSettings;

	// Token: 0x04000FDE RID: 4062
	[Token(Token = "0x4000FDE")]
	[FieldOffset(Offset = "0x10")]
	public Transform ItemParent;

	// Token: 0x04000FDF RID: 4063
	[Token(Token = "0x4000FDF")]
	[FieldOffset(Offset = "0x14")]
	public List<AdvancedRoleSettingsButton> AllAdvancedSettingTabs;

	// Token: 0x04000FE0 RID: 4064
	[Token(Token = "0x4000FE0")]
	[FieldOffset(Offset = "0x18")]
	private OptionBehaviour[] Children;

	// Token: 0x04000FE1 RID: 4065
	[Token(Token = "0x4000FE1")]
	[FieldOffset(Offset = "0x1C")]
	public RoleOptionSetting SettingPrefab;

	// Token: 0x04000FE2 RID: 4066
	[Token(Token = "0x4000FE2")]
	[FieldOffset(Offset = "0x20")]
	public GameObject AdvancedRolesSettings;

	// Token: 0x04000FE3 RID: 4067
	[Token(Token = "0x4000FE3")]
	[FieldOffset(Offset = "0x24")]
	public GameObject RoleChancesSettings;

	// Token: 0x04000FE4 RID: 4068
	[Token(Token = "0x4000FE4")]
	[FieldOffset(Offset = "0x28")]
	private RoleOptionsData cachedData;

	// Token: 0x04000FE5 RID: 4069
	[Token(Token = "0x4000FE5")]
	[FieldOffset(Offset = "0x2C")]
	public float YStart;

	// Token: 0x04000FE6 RID: 4070
	[Token(Token = "0x4000FE6")]
	[FieldOffset(Offset = "0x30")]
	public float YOffset;

	// Token: 0x020002D9 RID: 729
	[Token(Token = "0x20002D9")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass15_0
	{
		// Token: 0x06001016 RID: 4118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001016")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass15_0()
		{
		}

		// Token: 0x06001017 RID: 4119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001017")]
		[Address(RVA = "0x370F50", Offset = "0x370350", VA = "0x10370F50")]
		internal void <ShowAdvancedSettings>b__0(AdvancedRoleSettingsButton t)
		{
		}

		// Token: 0x04000FE7 RID: 4071
		[Token(Token = "0x4000FE7")]
		[FieldOffset(Offset = "0x8")]
		public RoleBehaviour role;
	}
}
