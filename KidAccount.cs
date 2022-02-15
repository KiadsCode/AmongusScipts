using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000029 RID: 41
[Token(Token = "0x2000029")]
public class KidAccount : MonoBehaviour
{
	// Token: 0x06000172 RID: 370 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000172")]
	[Address(RVA = "0x6D6680", Offset = "0x6D5A80", VA = "0x106D6680")]
	public void CanSetCustomName(bool canSetName)
	{
	}

	// Token: 0x06000173 RID: 371 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000173")]
	[Address(RVA = "0x6D66C0", Offset = "0x6D5AC0", VA = "0x106D66C0")]
	public void CanSignIntoAccount(bool canSignIn)
	{
	}

	// Token: 0x06000174 RID: 372 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000174")]
	[Address(RVA = "0x6D6720", Offset = "0x6D5B20", VA = "0x106D6720")]
	public void HasSignedIntoAccount(bool hasSignedIn)
	{
	}

	// Token: 0x06000175 RID: 373 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000175")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public KidAccount()
	{
	}

	// Token: 0x04000107 RID: 263
	[Token(Token = "0x4000107")]
	[FieldOffset(Offset = "0xC")]
	[SerializeField]
	private GameObject signInButton;

	// Token: 0x04000108 RID: 264
	[Token(Token = "0x4000108")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private GameObject createAccountButton;

	// Token: 0x04000109 RID: 265
	[Token(Token = "0x4000109")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	private GameObject randomizeNameButton;

	// Token: 0x0400010A RID: 266
	[Token(Token = "0x400010A")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject editNameButton;

	// Token: 0x0400010B RID: 267
	[Token(Token = "0x400010B")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private GameObject requestPermission;

	// Token: 0x0400010C RID: 268
	[Token(Token = "0x400010C")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject logOutButton;
}
