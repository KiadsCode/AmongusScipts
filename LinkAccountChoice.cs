using System;
using Assets.InnerNet;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x0200002A RID: 42
[Token(Token = "0x200002A")]
public class LinkAccountChoice : MonoBehaviour
{
	// Token: 0x06000176 RID: 374 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000176")]
	[Address(RVA = "0x6E0AC0", Offset = "0x6DFEC0", VA = "0x106E0AC0")]
	public void OnClose()
	{
	}

	// Token: 0x06000177 RID: 375 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000177")]
	[Address(RVA = "0x6E0AF0", Offset = "0x6DFEF0", VA = "0x106E0AF0")]
	public void RequestPin()
	{
	}

	// Token: 0x06000178 RID: 376 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000178")]
	[Address(RVA = "0x6E09B0", Offset = "0x6DFDB0", VA = "0x106E09B0")]
	private void AllowGuestMode()
	{
	}

	// Token: 0x06000179 RID: 377 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000179")]
	[Address(RVA = "0x6E0A80", Offset = "0x6DFE80", VA = "0x106E0A80")]
	public void CreateNewAccount()
	{
	}

	// Token: 0x0600017A RID: 378 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600017A")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public LinkAccountChoice()
	{
	}

	// Token: 0x0600017B RID: 379 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600017B")]
	[Address(RVA = "0x6E0BC0", Offset = "0x6DFFC0", VA = "0x106E0BC0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private void <RequestPin>b__6_0(PinRequestResponse result)
	{
	}

	// Token: 0x0600017C RID: 380 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600017C")]
	[Address(RVA = "0x6E0FB0", Offset = "0x6E03B0", VA = "0x106E0FB0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private void <RequestPin>b__6_1(LinkStatusResponse result)
	{
	}

	// Token: 0x0400010D RID: 269
	[Token(Token = "0x400010D")]
	[FieldOffset(Offset = "0xC")]
	public PassiveButton linkAccountButton;

	// Token: 0x0400010E RID: 270
	[Token(Token = "0x400010E")]
	[FieldOffset(Offset = "0x10")]
	public PassiveButton createNewAccountButton;

	// Token: 0x0400010F RID: 271
	[Token(Token = "0x400010F")]
	[FieldOffset(Offset = "0x14")]
	public PassiveButton continueAsGuestButton;

	// Token: 0x04000110 RID: 272
	[Token(Token = "0x4000110")]
	[FieldOffset(Offset = "0x18")]
	public TextMeshPro pinText;

	// Token: 0x04000111 RID: 273
	[Token(Token = "0x4000111")]
	[FieldOffset(Offset = "0x1C")]
	public bool menuDismissed;
}
