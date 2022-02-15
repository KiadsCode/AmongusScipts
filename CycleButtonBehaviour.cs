using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020001EB RID: 491
[Token(Token = "0x20001EB")]
public class CycleButtonBehaviour : MonoBehaviour, ITranslatedText
{
	// Token: 0x06000AFA RID: 2810 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AFA")]
	[Address(RVA = "0x5C2910", Offset = "0x5C1D10", VA = "0x105C2910")]
	public void Start()
	{
	}

	// Token: 0x06000AFB RID: 2811 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AFB")]
	[Address(RVA = "0x5C2790", Offset = "0x5C1B90", VA = "0x105C2790")]
	public void OnDestroy()
	{
	}

	// Token: 0x06000AFC RID: 2812 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AFC")]
	[Address(RVA = "0x5C2810", Offset = "0x5C1C10", VA = "0x105C2810", Slot = "4")]
	public void ResetText()
	{
	}

	// Token: 0x06000AFD RID: 2813 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AFD")]
	[Address(RVA = "0x5C2970", Offset = "0x5C1D70", VA = "0x105C2970")]
	public void UpdateText(int selection)
	{
	}

	// Token: 0x06000AFE RID: 2814 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AFE")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public CycleButtonBehaviour()
	{
	}

	// Token: 0x04000B06 RID: 2822
	[Token(Token = "0x4000B06")]
	[FieldOffset(Offset = "0xC")]
	public StringNames[] options;

	// Token: 0x04000B07 RID: 2823
	[Token(Token = "0x4000B07")]
	[FieldOffset(Offset = "0x10")]
	public StringNames BaseText;

	// Token: 0x04000B08 RID: 2824
	[Token(Token = "0x4000B08")]
	[FieldOffset(Offset = "0x14")]
	public TextMeshPro Text;

	// Token: 0x04000B09 RID: 2825
	[Token(Token = "0x4000B09")]
	[FieldOffset(Offset = "0x18")]
	public SpriteRenderer Background;

	// Token: 0x04000B0A RID: 2826
	[Token(Token = "0x4000B0A")]
	[FieldOffset(Offset = "0x1C")]
	public ButtonRolloverHandler Rollover;

	// Token: 0x04000B0B RID: 2827
	[Token(Token = "0x4000B0B")]
	[FieldOffset(Offset = "0x20")]
	public GameObject helpButton;

	// Token: 0x04000B0C RID: 2828
	[Token(Token = "0x4000B0C")]
	[FieldOffset(Offset = "0x24")]
	private int curSelection;

	// Token: 0x04000B0D RID: 2829
	[Token(Token = "0x4000B0D")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshPro quickChatInstructions;
}
