using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002B5 RID: 693
[Token(Token = "0x20002B5")]
public class ChatLanguageMenu : MonoBehaviour
{
	// Token: 0x06000F65 RID: 3941 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F65")]
	[Address(RVA = "0x833B50", Offset = "0x832F50", VA = "0x10833B50")]
	private void Awake()
	{
	}

	// Token: 0x06000F66 RID: 3942 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F66")]
	[Address(RVA = "0x833C90", Offset = "0x833090", VA = "0x10833C90")]
	public void OnEnable()
	{
	}

	// Token: 0x06000F67 RID: 3943 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F67")]
	[Address(RVA = "0x833C00", Offset = "0x833000", VA = "0x10833C00")]
	public void OnDisable()
	{
	}

	// Token: 0x06000F68 RID: 3944 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F68")]
	[Address(RVA = "0x499D70", Offset = "0x499170", VA = "0x10499D70")]
	public void Open()
	{
	}

	// Token: 0x06000F69 RID: 3945 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F69")]
	[Address(RVA = "0x833BB0", Offset = "0x832FB0", VA = "0x10833BB0")]
	public void ChooseOption(uint language)
	{
	}

	// Token: 0x06000F6A RID: 3946 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F6A")]
	[Address(RVA = "0x499D40", Offset = "0x499140", VA = "0x10499D40")]
	public void Close()
	{
	}

	// Token: 0x06000F6B RID: 3947 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F6B")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public ChatLanguageMenu()
	{
	}

	// Token: 0x04000F46 RID: 3910
	[Token(Token = "0x4000F46")]
	[FieldOffset(Offset = "0xC")]
	public CreateOptionsPicker Parent;

	// Token: 0x04000F47 RID: 3911
	[Token(Token = "0x4000F47")]
	[FieldOffset(Offset = "0x10")]
	public ObjectPoolBehavior ButtonPool;

	// Token: 0x04000F48 RID: 3912
	[Token(Token = "0x4000F48")]
	[FieldOffset(Offset = "0x14")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xDD8F0", Offset = "0xDCCF0")]
	public UiElement BackButton;

	// Token: 0x04000F49 RID: 3913
	[Token(Token = "0x4000F49")]
	[FieldOffset(Offset = "0x18")]
	private UiElement defaultButtonSelected;

	// Token: 0x04000F4A RID: 3914
	[Token(Token = "0x4000F4A")]
	[FieldOffset(Offset = "0x1C")]
	private List<UiElement> controllerSelectable;

	// Token: 0x020002B6 RID: 694
	[Token(Token = "0x20002B6")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass6_0
	{
		// Token: 0x06000F6C RID: 3948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F6C")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass6_0()
		{
		}

		// Token: 0x06000F6D RID: 3949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F6D")]
		[Address(RVA = "0x3CA8C0", Offset = "0x3C9CC0", VA = "0x103CA8C0")]
		internal void <OnEnable>b__0()
		{
		}

		// Token: 0x04000F4B RID: 3915
		[Token(Token = "0x4000F4B")]
		[FieldOffset(Offset = "0x8")]
		public uint lang;

		// Token: 0x04000F4C RID: 3916
		[Token(Token = "0x4000F4C")]
		[FieldOffset(Offset = "0xC")]
		public ChatLanguageMenu <>4__this;
	}
}
