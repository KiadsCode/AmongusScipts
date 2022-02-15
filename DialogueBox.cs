using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020001EC RID: 492
[Token(Token = "0x20001EC")]
public class DialogueBox : MonoBehaviour
{
	// Token: 0x06000AFF RID: 2815 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AFF")]
	[Address(RVA = "0x5C6AE0", Offset = "0x5C5EE0", VA = "0x105C6AE0")]
	private void OnEnable()
	{
	}

	// Token: 0x06000B00 RID: 2816 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B00")]
	[Address(RVA = "0x5C6A70", Offset = "0x5C5E70", VA = "0x105C6A70")]
	private void OnDisable()
	{
	}

	// Token: 0x06000B01 RID: 2817 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B01")]
	[Address(RVA = "0x5C6B60", Offset = "0x5C5F60", VA = "0x105C6B60")]
	public void Show(string dialogue)
	{
	}

	// Token: 0x06000B02 RID: 2818 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B02")]
	[Address(RVA = "0x5C6990", Offset = "0x5C5D90", VA = "0x105C6990")]
	public void Hide()
	{
	}

	// Token: 0x06000B03 RID: 2819 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B03")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public DialogueBox()
	{
	}

	// Token: 0x04000B0E RID: 2830
	[Token(Token = "0x4000B0E")]
	[FieldOffset(Offset = "0xC")]
	public TextMeshPro target;

	// Token: 0x04000B0F RID: 2831
	[Token(Token = "0x4000B0F")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xDD8F0", Offset = "0xDCCF0")]
	public UiElement BackButton;
}
