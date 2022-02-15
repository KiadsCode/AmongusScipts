using System;
using Assets.InnerNet;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x0200041E RID: 1054
[Token(Token = "0x200041E")]
public class PurchasePopUp : MonoBehaviour
{
	// Token: 0x0600162E RID: 5678 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600162E")]
	[Address(RVA = "0x514BB0", Offset = "0x513FB0", VA = "0x10514BB0")]
	public void Show(PurchasePopUp.PurchasePopUpMode mode = PurchasePopUp.PurchasePopUpMode.PurchaseItem)
	{
	}

	// Token: 0x0600162F RID: 5679 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600162F")]
	[Address(RVA = "0x514B30", Offset = "0x513F30", VA = "0x10514B30")]
	public void SetResponse(ResponseState responseSate, ResponseError[] errors)
	{
	}

	// Token: 0x06001630 RID: 5680 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001630")]
	[Address(RVA = "0x5149B0", Offset = "0x513DB0", VA = "0x105149B0")]
	public void SetResponse(ResponseState responseSate, string error)
	{
	}

	// Token: 0x06001631 RID: 5681 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001631")]
	[Address(RVA = "0x5147F0", Offset = "0x513BF0", VA = "0x105147F0")]
	private string GetErrorString(ResponseError error)
	{
		return null;
	}

	// Token: 0x06001632 RID: 5682 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001632")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public PurchasePopUp()
	{
	}

	// Token: 0x04001689 RID: 5769
	[Token(Token = "0x4001689")]
	[FieldOffset(Offset = "0xC")]
	public GameObject waitingText;

	// Token: 0x0400168A RID: 5770
	[Token(Token = "0x400168A")]
	[FieldOffset(Offset = "0x10")]
	public TextMeshPro titleText;

	// Token: 0x0400168B RID: 5771
	[Token(Token = "0x400168B")]
	[FieldOffset(Offset = "0x14")]
	public TextMeshPro infoText;

	// Token: 0x0400168C RID: 5772
	[Token(Token = "0x400168C")]
	[FieldOffset(Offset = "0x18")]
	public GameObject closeButton;

	// Token: 0x0400168D RID: 5773
	[Token(Token = "0x400168D")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject controllerFocusHolder;

	// Token: 0x0200041F RID: 1055
	[Token(Token = "0x200041F")]
	public enum PurchasePopUpMode
	{
		// Token: 0x0400168F RID: 5775
		[Token(Token = "0x400168F")]
		PurchaseItem,
		// Token: 0x04001690 RID: 5776
		[Token(Token = "0x4001690")]
		CheckingPurchases
	}
}
