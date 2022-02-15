using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000061 RID: 97
[Token(Token = "0x2000061")]
public class NumberMenu : MonoBehaviour
{
	// Token: 0x0600029D RID: 669 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600029D")]
	[Address(RVA = "0x77B0C0", Offset = "0x77A4C0", VA = "0x1077B0C0")]
	private void Awake()
	{
	}

	// Token: 0x0600029E RID: 670 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600029E")]
	[Address(RVA = "0x499D70", Offset = "0x499170", VA = "0x10499D70")]
	public void Open()
	{
	}

	// Token: 0x0600029F RID: 671 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600029F")]
	[Address(RVA = "0x77B120", Offset = "0x77A520", VA = "0x1077B120")]
	public void SetValue(string val)
	{
	}

	// Token: 0x060002A0 RID: 672 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002A0")]
	[Address(RVA = "0x499D40", Offset = "0x499140", VA = "0x10499D40")]
	public void Close()
	{
	}

	// Token: 0x060002A1 RID: 673 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002A1")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public NumberMenu()
	{
	}

	// Token: 0x0400024E RID: 590
	[Token(Token = "0x400024E")]
	[FieldOffset(Offset = "0xC")]
	public TextMeshPro text;

	// Token: 0x0400024F RID: 591
	[Token(Token = "0x400024F")]
	[FieldOffset(Offset = "0x10")]
	public NumberSetter numberSetter;

	// Token: 0x04000250 RID: 592
	[Token(Token = "0x4000250")]
	[FieldOffset(Offset = "0x14")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xDD8F0", Offset = "0xDCCF0")]
	public UiElement BackButton;

	// Token: 0x04000251 RID: 593
	[Token(Token = "0x4000251")]
	[FieldOffset(Offset = "0x18")]
	private UiElement defaultButtonSelected;

	// Token: 0x04000252 RID: 594
	[Token(Token = "0x4000252")]
	[FieldOffset(Offset = "0x1C")]
	private List<UiElement> controllerSelectable;
}
