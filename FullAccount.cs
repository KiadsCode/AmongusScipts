using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200001B RID: 27
[Token(Token = "0x200001B")]
public class FullAccount : MonoBehaviour
{
	// Token: 0x060000FB RID: 251 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x3AAE80", Offset = "0x3AA280", VA = "0x103AAE80")]
	public void CanSetCustomName(bool canSetName)
	{
	}

	// Token: 0x060000FC RID: 252 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x3AAF00", Offset = "0x3AA300", VA = "0x103AAF00")]
	public void UpdateLoggedInAccountVisuals()
	{
	}

	// Token: 0x060000FD RID: 253 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public FullAccount()
	{
	}

	// Token: 0x040000B2 RID: 178
	[Token(Token = "0x40000B2")]
	[FieldOffset(Offset = "0xC")]
	[SerializeField]
	private GameObject randomizeNameButton;

	// Token: 0x040000B3 RID: 179
	[Token(Token = "0x40000B3")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private GameObject editNameButton;

	// Token: 0x040000B4 RID: 180
	[Token(Token = "0x40000B4")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	private PassiveButton linkUnlinkAccountsButton;

	// Token: 0x040000B5 RID: 181
	[Token(Token = "0x40000B5")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject goOfflineButton;
}
