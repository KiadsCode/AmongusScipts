using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020002D6 RID: 726
[Token(Token = "0x20002D6")]
public class GameSettingMenu : MonoBehaviour
{
	// Token: 0x06001004 RID: 4100 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001004")]
	[Address(RVA = "0x3B2190", Offset = "0x3B1590", VA = "0x103B2190")]
	public void Close()
	{
	}

	// Token: 0x06001005 RID: 4101 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001005")]
	[Address(RVA = "0x3B2A30", Offset = "0x3B1E30", VA = "0x103B2A30")]
	public void ToggleRoles()
	{
	}

	// Token: 0x06001006 RID: 4102 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001006")]
	[Address(RVA = "0x3B2870", Offset = "0x3B1C70", VA = "0x103B2870")]
	private void Start()
	{
	}

	// Token: 0x06001007 RID: 4103 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001007")]
	[Address(RVA = "0x3B2AC0", Offset = "0x3B1EC0", VA = "0x103B2AC0")]
	private void Update()
	{
	}

	// Token: 0x06001008 RID: 4104 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001008")]
	[Address(RVA = "0x3B2740", Offset = "0x3B1B40", VA = "0x103B2740")]
	private void OnDisable()
	{
	}

	// Token: 0x06001009 RID: 4105 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001009")]
	[Address(RVA = "0x3B2210", Offset = "0x3B1610", VA = "0x103B2210")]
	private void InitializeOptions()
	{
	}

	// Token: 0x0600100A RID: 4106 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600100A")]
	[Address(RVA = "0x3B27F0", Offset = "0x3B1BF0", VA = "0x103B27F0")]
	public void ShowAdvancedRoleOptions(RoleBehaviour r)
	{
	}

	// Token: 0x0600100B RID: 4107 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600100B")]
	[Address(RVA = "0x3B2110", Offset = "0x3B1510", VA = "0x103B2110")]
	public void CloseAdvancedSettings()
	{
	}

	// Token: 0x0600100C RID: 4108 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600100C")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public GameSettingMenu()
	{
	}

	// Token: 0x04000FCA RID: 4042
	[Token(Token = "0x4000FCA")]
	[FieldOffset(Offset = "0x0")]
	public static GameSettingMenu Instance;

	// Token: 0x04000FCB RID: 4043
	[Token(Token = "0x4000FCB")]
	[FieldOffset(Offset = "0xC")]
	public RolesSettingsMenu RolesSettings;

	// Token: 0x04000FCC RID: 4044
	[Token(Token = "0x4000FCC")]
	[FieldOffset(Offset = "0x10")]
	public GameObject RegularGameSettings;

	// Token: 0x04000FCD RID: 4045
	[Token(Token = "0x4000FCD")]
	[FieldOffset(Offset = "0x14")]
	public TextMeshPro RoleName;

	// Token: 0x04000FCE RID: 4046
	[Token(Token = "0x4000FCE")]
	[FieldOffset(Offset = "0x18")]
	public TextMeshPro RoleBlurb;

	// Token: 0x04000FCF RID: 4047
	[Token(Token = "0x4000FCF")]
	[FieldOffset(Offset = "0x1C")]
	public SpriteRenderer RoleIcon;

	// Token: 0x04000FD0 RID: 4048
	[Token(Token = "0x4000FD0")]
	[FieldOffset(Offset = "0x20")]
	public SpriteRenderer GameSettingsHightlight;

	// Token: 0x04000FD1 RID: 4049
	[Token(Token = "0x4000FD1")]
	[FieldOffset(Offset = "0x24")]
	public SpriteRenderer RolesSettingsHightlight;

	// Token: 0x04000FD2 RID: 4050
	[Token(Token = "0x4000FD2")]
	[FieldOffset(Offset = "0x28")]
	public Transform[] AllItems;

	// Token: 0x04000FD3 RID: 4051
	[Token(Token = "0x4000FD3")]
	[FieldOffset(Offset = "0x2C")]
	public Scroller Scroller;

	// Token: 0x04000FD4 RID: 4052
	[Token(Token = "0x4000FD4")]
	[FieldOffset(Offset = "0x30")]
	public float YStart;

	// Token: 0x04000FD5 RID: 4053
	[Token(Token = "0x4000FD5")]
	[FieldOffset(Offset = "0x34")]
	public float YOffset;

	// Token: 0x04000FD6 RID: 4054
	[Token(Token = "0x4000FD6")]
	[FieldOffset(Offset = "0x38")]
	public Transform[] HideForOnline;

	// Token: 0x04000FD7 RID: 4055
	[Token(Token = "0x4000FD7")]
	[FieldOffset(Offset = "0x3C")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xDD8F0", Offset = "0xDCCF0")]
	public UiElement BackButton;

	// Token: 0x04000FD8 RID: 4056
	[Token(Token = "0x4000FD8")]
	[FieldOffset(Offset = "0x40")]
	public UiElement AdvancedSettingsBackButton;

	// Token: 0x04000FD9 RID: 4057
	[Token(Token = "0x4000FD9")]
	[FieldOffset(Offset = "0x44")]
	public UiElement DefaultButtonSelected;

	// Token: 0x04000FDA RID: 4058
	[Token(Token = "0x4000FDA")]
	[FieldOffset(Offset = "0x48")]
	public List<UiElement> ControllerSelectable;
}
