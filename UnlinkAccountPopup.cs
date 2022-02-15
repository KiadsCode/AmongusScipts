using System;
using Epic.OnlineServices.Connect;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000042 RID: 66
[Token(Token = "0x2000042")]
public class UnlinkAccountPopup : MonoBehaviour
{
	// Token: 0x060001F4 RID: 500 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x4B7440", Offset = "0x4B6840", VA = "0x104B7440")]
	public void Close()
	{
	}

	// Token: 0x060001F5 RID: 501 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x4B78A0", Offset = "0x4B6CA0", VA = "0x104B78A0")]
	public void StartUnlinkProcess()
	{
	}

	// Token: 0x060001F6 RID: 502 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x4B74E0", Offset = "0x4B68E0", VA = "0x104B74E0")]
	public void ConfirmUnlinkProcess()
	{
	}

	// Token: 0x060001F7 RID: 503 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001F7")]
	[Address(RVA = "0x4B7200", Offset = "0x4B6600", VA = "0x104B7200")]
	public void ActuallyUnlinkAccount()
	{
	}

	// Token: 0x060001F8 RID: 504 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001F8")]
	[Address(RVA = "0x4B7F70", Offset = "0x4B7370", VA = "0x104B7F70")]
	public void Update()
	{
	}

	// Token: 0x060001F9 RID: 505 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001F9")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public UnlinkAccountPopup()
	{
	}

	// Token: 0x060001FA RID: 506 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x4B7CF0", Offset = "0x4B70F0", VA = "0x104B7CF0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private void <ActuallyUnlinkAccount>b__12_0(UnlinkAccountCallbackInfo result)
	{
	}

	// Token: 0x04000165 RID: 357
	[Token(Token = "0x4000165")]
	[FieldOffset(Offset = "0xC")]
	public SpriteRenderer background;

	// Token: 0x04000166 RID: 358
	[Token(Token = "0x4000166")]
	[FieldOffset(Offset = "0x10")]
	public TextMeshPro titleText;

	// Token: 0x04000167 RID: 359
	[Token(Token = "0x4000167")]
	[FieldOffset(Offset = "0x14")]
	public TextMeshPro bodyText;

	// Token: 0x04000168 RID: 360
	[Token(Token = "0x4000168")]
	[FieldOffset(Offset = "0x18")]
	public TextMeshPro button1Text;

	// Token: 0x04000169 RID: 361
	[Token(Token = "0x4000169")]
	[FieldOffset(Offset = "0x1C")]
	public TextMeshPro button2Text;

	// Token: 0x0400016A RID: 362
	[Token(Token = "0x400016A")]
	[FieldOffset(Offset = "0x20")]
	public PassiveButton button1;

	// Token: 0x0400016B RID: 363
	[Token(Token = "0x400016B")]
	[FieldOffset(Offset = "0x24")]
	public PassiveButton button2;

	// Token: 0x0400016C RID: 364
	[Token(Token = "0x400016C")]
	[FieldOffset(Offset = "0x28")]
	public Transform button1Pos;

	// Token: 0x0400016D RID: 365
	[Token(Token = "0x400016D")]
	[FieldOffset(Offset = "0x2C")]
	private Vector3 prevButton1Pos;
}
