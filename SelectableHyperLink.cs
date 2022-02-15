using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002A6 RID: 678
[Token(Token = "0x20002A6")]
internal class SelectableHyperLink : MonoBehaviour, ITextPart
{
	// Token: 0x06000EFD RID: 3837 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EFD")]
	[Address(RVA = "0x277A50", Offset = "0x276E50", VA = "0x10277A50")]
	public void SetSelectionCallback(Action _onNewSelection)
	{
	}

	// Token: 0x17000244 RID: 580
	// (get) Token: 0x06000EFE RID: 3838 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000EFF RID: 3839 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000244")]
	public string LinkText
	{
		[Token(Token = "0x6000EFE")]
		[Address(RVA = "0x292AA0", Offset = "0x291EA0", VA = "0x10292AA0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000EFF")]
		[Address(RVA = "0x5904D0", Offset = "0x58F8D0", VA = "0x105904D0")]
		set
		{
		}
	}

	// Token: 0x17000245 RID: 581
	// (get) Token: 0x06000F00 RID: 3840 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000245")]
	public string TaglessLinkText
	{
		[Token(Token = "0x6000F00")]
		[Address(RVA = "0x277A40", Offset = "0x276E40", VA = "0x10277A40")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000246 RID: 582
	// (get) Token: 0x06000F01 RID: 3841 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000246")]
	public UiElement SelectableObject
	{
		[Token(Token = "0x6000F01")]
		[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000F02 RID: 3842 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F02")]
	[Address(RVA = "0x590030", Offset = "0x58F430", VA = "0x10590030")]
	private static void ExtractUrl(string fullText, out string url, out string visibleTextPart)
	{
	}

	// Token: 0x06000F03 RID: 3843 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F03")]
	[Address(RVA = "0x292AA0", Offset = "0x291EA0", VA = "0x10292AA0", Slot = "4")]
	public string GetText()
	{
		return null;
	}

	// Token: 0x06000F04 RID: 3844 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F04")]
	[Address(RVA = "0x590460", Offset = "0x58F860", VA = "0x10590460")]
	public void RemoveUiElement(ControllerUiElementsState menu)
	{
	}

	// Token: 0x06000F05 RID: 3845 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F05")]
	[Address(RVA = "0x58FC10", Offset = "0x58F010", VA = "0x1058FC10")]
	public void AddUiElement(ControllerUiElementsState menu)
	{
	}

	// Token: 0x06000F06 RID: 3846 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F06")]
	[Address(RVA = "0x5903E0", Offset = "0x58F7E0", VA = "0x105903E0")]
	public void OnSelection()
	{
	}

	// Token: 0x06000F07 RID: 3847 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F07")]
	[Address(RVA = "0x590420", Offset = "0x58F820", VA = "0x10590420")]
	public void OnUnselection()
	{
	}

	// Token: 0x06000F08 RID: 3848 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F08")]
	[Address(RVA = "0x58FC80", Offset = "0x58F080", VA = "0x1058FC80")]
	public void Clicked()
	{
	}

	// Token: 0x06000F09 RID: 3849 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F09")]
	[Address(RVA = "0x58FCA0", Offset = "0x58F0A0", VA = "0x1058FCA0")]
	public static void DecomposeHyperlinkText(string textToDecompose, List<ITextPart> textConstituents, List<SelectableHyperLink> selectableHyperLinks)
	{
	}

	// Token: 0x06000F0A RID: 3850 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F0A")]
	[Address(RVA = "0x590280", Offset = "0x58F680", VA = "0x10590280")]
	private static void GetFirstUrl(string textToDecompose, out string nonUrlPart, out string urlPart)
	{
	}

	// Token: 0x06000F0B RID: 3851 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F0B")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public SelectableHyperLink()
	{
	}

	// Token: 0x04000F04 RID: 3844
	[Token(Token = "0x4000F04")]
	[FieldOffset(Offset = "0xC")]
	[SerializeField]
	private UiElement HyperLink;

	// Token: 0x04000F05 RID: 3845
	[Token(Token = "0x4000F05")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private string selectedColor;

	// Token: 0x04000F06 RID: 3846
	[Token(Token = "0x4000F06")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	private string unselectedColor;

	// Token: 0x04000F07 RID: 3847
	[Token(Token = "0x4000F07")]
	[FieldOffset(Offset = "0x18")]
	private Action onNewSelection;

	// Token: 0x04000F08 RID: 3848
	[Token(Token = "0x4000F08")]
	[FieldOffset(Offset = "0x1C")]
	private string hyperLinkText;

	// Token: 0x04000F09 RID: 3849
	[Token(Token = "0x4000F09")]
	[FieldOffset(Offset = "0x20")]
	private string hyperLinkUrl;

	// Token: 0x04000F0A RID: 3850
	[Token(Token = "0x4000F0A")]
	[FieldOffset(Offset = "0x24")]
	private string fullHyperLinkText;
}
