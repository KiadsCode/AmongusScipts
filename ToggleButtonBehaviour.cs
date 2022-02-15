using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000259 RID: 601
[Token(Token = "0x2000259")]
public class ToggleButtonBehaviour : MonoBehaviour, ITranslatedText
{
	// Token: 0x06000D7A RID: 3450 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D7A")]
	[Address(RVA = "0x4AE770", Offset = "0x4ADB70", VA = "0x104AE770")]
	public void Start()
	{
	}

	// Token: 0x06000D7B RID: 3451 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D7B")]
	[Address(RVA = "0x4AE590", Offset = "0x4AD990", VA = "0x104AE590")]
	public void OnDestroy()
	{
	}

	// Token: 0x06000D7C RID: 3452 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D7C")]
	[Address(RVA = "0x4AE610", Offset = "0x4ADA10", VA = "0x104AE610", Slot = "4")]
	public void ResetText()
	{
	}

	// Token: 0x06000D7D RID: 3453 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D7D")]
	[Address(RVA = "0x4AE7D0", Offset = "0x4ADBD0", VA = "0x104AE7D0")]
	public void UpdateText(bool on)
	{
	}

	// Token: 0x06000D7E RID: 3454 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D7E")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public ToggleButtonBehaviour()
	{
	}

	// Token: 0x04000D5A RID: 3418
	[Token(Token = "0x4000D5A")]
	[FieldOffset(Offset = "0xC")]
	public StringNames BaseText;

	// Token: 0x04000D5B RID: 3419
	[Token(Token = "0x4000D5B")]
	[FieldOffset(Offset = "0x10")]
	public TextMeshPro Text;

	// Token: 0x04000D5C RID: 3420
	[Token(Token = "0x4000D5C")]
	[FieldOffset(Offset = "0x14")]
	public SpriteRenderer Background;

	// Token: 0x04000D5D RID: 3421
	[Token(Token = "0x4000D5D")]
	[FieldOffset(Offset = "0x18")]
	public ButtonRolloverHandler Rollover;

	// Token: 0x04000D5E RID: 3422
	[Token(Token = "0x4000D5E")]
	[FieldOffset(Offset = "0x1C")]
	private bool onState;
}
