using System;
using Il2CppDummyDll;
using PowerTools;
using UnityEngine;

// Token: 0x020002C0 RID: 704
[Token(Token = "0x20002C0")]
public class FindGameButton : MonoBehaviour, IConnectButton
{
	// Token: 0x06000F9C RID: 3996 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F9C")]
	[Address(RVA = "0x3A6CA0", Offset = "0x3A60A0", VA = "0x103A6CA0")]
	public void OnClick()
	{
	}

	// Token: 0x06000F9D RID: 3997 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F9D")]
	[Address(RVA = "0x3A6E30", Offset = "0x3A6230", VA = "0x103A6E30", Slot = "4")]
	public void StartIcon()
	{
	}

	// Token: 0x06000F9E RID: 3998 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F9E")]
	[Address(RVA = "0x3A6E60", Offset = "0x3A6260", VA = "0x103A6E60", Slot = "5")]
	public void StopIcon()
	{
	}

	// Token: 0x06000F9F RID: 3999 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F9F")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public FindGameButton()
	{
	}

	// Token: 0x04000F72 RID: 3954
	[Token(Token = "0x4000F72")]
	[FieldOffset(Offset = "0xC")]
	public SpriteAnim connectIcon;

	// Token: 0x04000F73 RID: 3955
	[Token(Token = "0x4000F73")]
	[FieldOffset(Offset = "0x10")]
	public AnimationClip connectClip;
}
