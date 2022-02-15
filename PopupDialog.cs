using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x0200039A RID: 922
[Token(Token = "0x200039A")]
public class PopupDialog : MonoBehaviour
{
	// Token: 0x060013A6 RID: 5030 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013A6")]
	[Address(RVA = "0x50D270", Offset = "0x50C670", VA = "0x1050D270")]
	public static void Display()
	{
	}

	// Token: 0x060013A7 RID: 5031 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013A7")]
	[Address(RVA = "0x50D360", Offset = "0x50C760", VA = "0x1050D360")]
	public static void Dispose()
	{
	}

	// Token: 0x060013A8 RID: 5032 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013A8")]
	[Address(RVA = "0x50D460", Offset = "0x50C860", VA = "0x1050D460")]
	private void Start()
	{
	}

	// Token: 0x060013A9 RID: 5033 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013A9")]
	[Address(RVA = "0x50D400", Offset = "0x50C800", VA = "0x1050D400")]
	private void OnDestroy()
	{
	}

	// Token: 0x060013AA RID: 5034 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013AA")]
	[Address(RVA = "0x50D4C0", Offset = "0x50C8C0", VA = "0x1050D4C0")]
	public void Update()
	{
	}

	// Token: 0x060013AB RID: 5035 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013AB")]
	[Address(RVA = "0x50D580", Offset = "0x50C980", VA = "0x1050D580")]
	public PopupDialog()
	{
	}

	// Token: 0x040013ED RID: 5101
	[Token(Token = "0x40013ED")]
	[FieldOffset(Offset = "0xC")]
	public TextMeshPro workingText;

	// Token: 0x040013EE RID: 5102
	[Token(Token = "0x40013EE")]
	[FieldOffset(Offset = "0x10")]
	public float secondsBetweenDots;

	// Token: 0x040013EF RID: 5103
	[Token(Token = "0x40013EF")]
	[FieldOffset(Offset = "0x14")]
	public int maxDots;

	// Token: 0x040013F0 RID: 5104
	[Token(Token = "0x40013F0")]
	[FieldOffset(Offset = "0x18")]
	public string currentProgressText;

	// Token: 0x040013F1 RID: 5105
	[Token(Token = "0x40013F1")]
	[FieldOffset(Offset = "0x1C")]
	private float textUpdateTimer;

	// Token: 0x040013F2 RID: 5106
	[Token(Token = "0x40013F2")]
	[FieldOffset(Offset = "0x0")]
	private static PopupDialog instance;
}
