using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020002E5 RID: 741
[Token(Token = "0x20002E5")]
public class PlayerCustomizationMenu : MonoBehaviour
{
	// Token: 0x06001053 RID: 4179 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001053")]
	[Address(RVA = "0x66B6A0", Offset = "0x66AAA0", VA = "0x1066B6A0")]
	private void OnDisable()
	{
	}

	// Token: 0x06001054 RID: 4180 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001054")]
	[Address(RVA = "0x66C2F0", Offset = "0x66B6F0", VA = "0x1066C2F0")]
	public void Start()
	{
	}

	// Token: 0x06001055 RID: 4181 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001055")]
	[Address(RVA = "0x66B710", Offset = "0x66AB10", VA = "0x1066B710")]
	public void OpenTab(InventoryTab tab)
	{
	}

	// Token: 0x06001056 RID: 4182 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001056")]
	[Address(RVA = "0x66B5A0", Offset = "0x66A9A0", VA = "0x1066B5A0")]
	public void Close(bool canMove)
	{
	}

	// Token: 0x06001057 RID: 4183 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001057")]
	[Address(RVA = "0x66B640", Offset = "0x66AA40", VA = "0x1066B640")]
	private void DestroyObj()
	{
	}

	// Token: 0x06001058 RID: 4184 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001058")]
	[Address(RVA = "0x66C460", Offset = "0x66B860", VA = "0x1066C460")]
	private void Update()
	{
	}

	// Token: 0x06001059 RID: 4185 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001059")]
	[Address(RVA = "0x66C7D0", Offset = "0x66BBD0", VA = "0x1066C7D0")]
	public void ViewCube()
	{
	}

	// Token: 0x0600105A RID: 4186 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600105A")]
	[Address(RVA = "0x66C2C0", Offset = "0x66B6C0", VA = "0x1066C2C0")]
	public void SetItemName(string text)
	{
	}

	// Token: 0x0600105B RID: 4187 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600105B")]
	[Address(RVA = "0x66B500", Offset = "0x66A900", VA = "0x1066B500")]
	public void ClickEquip()
	{
	}

	// Token: 0x0600105C RID: 4188 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600105C")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public PlayerCustomizationMenu()
	{
	}

	// Token: 0x0400100E RID: 4110
	[Token(Token = "0x400100E")]
	[FieldOffset(Offset = "0x0")]
	public static PlayerCustomizationMenu Instance;

	// Token: 0x0400100F RID: 4111
	[Token(Token = "0x400100F")]
	[FieldOffset(Offset = "0xC")]
	public GameObject cosmicubeMenuTab;

	// Token: 0x04001010 RID: 4112
	[Token(Token = "0x4001010")]
	[FieldOffset(Offset = "0x10")]
	public CubesTab cubesTab;

	// Token: 0x04001011 RID: 4113
	[Token(Token = "0x4001011")]
	[FieldOffset(Offset = "0x14")]
	public TabButton[] Tabs;

	// Token: 0x04001012 RID: 4114
	[Token(Token = "0x4001012")]
	[FieldOffset(Offset = "0x18")]
	private int selectedTab;

	// Token: 0x04001013 RID: 4115
	[Token(Token = "0x4001013")]
	[FieldOffset(Offset = "0x1C")]
	private bool cubeTabSelected;

	// Token: 0x04001014 RID: 4116
	[Token(Token = "0x4001014")]
	[FieldOffset(Offset = "0x20")]
	public PoolablePlayer PreviewArea;

	// Token: 0x04001015 RID: 4117
	[Token(Token = "0x4001015")]
	[FieldOffset(Offset = "0x24")]
	public GameObject equipButton;

	// Token: 0x04001016 RID: 4118
	[Token(Token = "0x4001016")]
	[FieldOffset(Offset = "0x28")]
	public GameObject equippedText;

	// Token: 0x04001017 RID: 4119
	[Token(Token = "0x4001017")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject nameplateMaskArea;

	// Token: 0x04001018 RID: 4120
	[Token(Token = "0x4001018")]
	[FieldOffset(Offset = "0x30")]
	public GameObject cubeArea;

	// Token: 0x04001019 RID: 4121
	[Token(Token = "0x4001019")]
	[FieldOffset(Offset = "0x34")]
	public TextMeshPro itemName;

	// Token: 0x0400101A RID: 4122
	[Token(Token = "0x400101A")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xDD8F0", Offset = "0xDCCF0")]
	public UiElement BackButton;

	// Token: 0x0400101B RID: 4123
	[Token(Token = "0x400101B")]
	[FieldOffset(Offset = "0x3C")]
	public UiElement DefaultButtonSelected;

	// Token: 0x0400101C RID: 4124
	[Token(Token = "0x400101C")]
	[FieldOffset(Offset = "0x40")]
	public List<UiElement> ControllerSelectable;

	// Token: 0x0400101D RID: 4125
	[Token(Token = "0x400101D")]
	[FieldOffset(Offset = "0x44")]
	public GameObject glyphL;

	// Token: 0x0400101E RID: 4126
	[Token(Token = "0x400101E")]
	[FieldOffset(Offset = "0x48")]
	public GameObject glyphR;
}
