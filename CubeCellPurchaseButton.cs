using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x0200012D RID: 301
[Token(Token = "0x200012D")]
public class CubeCellPurchaseButton : MonoBehaviour
{
	// Token: 0x06000704 RID: 1796 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000704")]
	[Address(RVA = "0x5BBFD0", Offset = "0x5BB3D0", VA = "0x105BBFD0")]
	public void SetUseable()
	{
	}

	// Token: 0x06000705 RID: 1797 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000705")]
	[Address(RVA = "0x5BBF00", Offset = "0x5BB300", VA = "0x105BBF00")]
	public void SetInactive()
	{
	}

	// Token: 0x06000706 RID: 1798 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000706")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public CubeCellPurchaseButton()
	{
	}

	// Token: 0x040006FC RID: 1788
	[Token(Token = "0x40006FC")]
	[FieldOffset(Offset = "0xC")]
	public PassiveButton button;

	// Token: 0x040006FD RID: 1789
	[Token(Token = "0x40006FD")]
	[FieldOffset(Offset = "0x10")]
	public TextMeshPro text;

	// Token: 0x040006FE RID: 1790
	[Token(Token = "0x40006FE")]
	[FieldOffset(Offset = "0x14")]
	public SpriteRenderer podIcon;

	// Token: 0x040006FF RID: 1791
	[Token(Token = "0x40006FF")]
	[FieldOffset(Offset = "0x18")]
	public SpriteRenderer buttonBackground;
}
