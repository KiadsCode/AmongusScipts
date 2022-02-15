using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000038 RID: 56
[Token(Token = "0x2000038")]
public class RedeemDLCChoice : MonoBehaviour
{
	// Token: 0x060001CF RID: 463 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x4F4540", Offset = "0x4F3940", VA = "0x104F4540")]
	public void OnClose()
	{
	}

	// Token: 0x060001D0 RID: 464 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x4F4570", Offset = "0x4F3970", VA = "0x104F4570")]
	public void ToggleAccountId()
	{
	}

	// Token: 0x060001D1 RID: 465 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x4F4590", Offset = "0x4F3990", VA = "0x104F4590")]
	public void UpdateAccountText()
	{
	}

	// Token: 0x060001D2 RID: 466 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public RedeemDLCChoice()
	{
	}

	// Token: 0x0400014A RID: 330
	[Token(Token = "0x400014A")]
	[FieldOffset(Offset = "0xC")]
	public PassiveButton goAheadButton;

	// Token: 0x0400014B RID: 331
	[Token(Token = "0x400014B")]
	[FieldOffset(Offset = "0x10")]
	public PassiveButton notRightNowButton;

	// Token: 0x0400014C RID: 332
	[Token(Token = "0x400014C")]
	[FieldOffset(Offset = "0x14")]
	public PassiveButton noAskAgain;

	// Token: 0x0400014D RID: 333
	[Token(Token = "0x400014D")]
	[FieldOffset(Offset = "0x18")]
	public TextMeshPro showAccountButtonText;

	// Token: 0x0400014E RID: 334
	[Token(Token = "0x400014E")]
	[FieldOffset(Offset = "0x1C")]
	public TextMeshPro infoText;

	// Token: 0x0400014F RID: 335
	[Token(Token = "0x400014F")]
	[FieldOffset(Offset = "0x20")]
	public bool menuDismissed;

	// Token: 0x04000150 RID: 336
	[Token(Token = "0x4000150")]
	[FieldOffset(Offset = "0x21")]
	private bool accountIDShow;
}
