using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000186 RID: 390
[Token(Token = "0x2000186")]
public class FreeplayPopover : MonoBehaviour
{
	// Token: 0x060008E0 RID: 2272 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008E0")]
	[Address(RVA = "0x3AABC0", Offset = "0x3A9FC0", VA = "0x103AABC0")]
	public void Show()
	{
	}

	// Token: 0x060008E1 RID: 2273 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008E1")]
	[Address(RVA = "0x3AAAD0", Offset = "0x3A9ED0", VA = "0x103AAAD0")]
	public void Close()
	{
	}

	// Token: 0x060008E2 RID: 2274 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008E2")]
	[Address(RVA = "0x3AAB60", Offset = "0x3A9F60", VA = "0x103AAB60")]
	public void PlayMap(int i)
	{
	}

	// Token: 0x060008E3 RID: 2275 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008E3")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public FreeplayPopover()
	{
	}

	// Token: 0x040008EA RID: 2282
	[Token(Token = "0x40008EA")]
	[FieldOffset(Offset = "0xC")]
	public GameObject Content;

	// Token: 0x040008EB RID: 2283
	[Token(Token = "0x40008EB")]
	[FieldOffset(Offset = "0x10")]
	public SpriteRenderer[] MapButtons;

	// Token: 0x040008EC RID: 2284
	[Token(Token = "0x40008EC")]
	[FieldOffset(Offset = "0x14")]
	public HostLocalGameButton HostGame;

	// Token: 0x040008ED RID: 2285
	[Token(Token = "0x40008ED")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xDD8F0", Offset = "0xDCCF0")]
	public UiElement BackButton;

	// Token: 0x040008EE RID: 2286
	[Token(Token = "0x40008EE")]
	[FieldOffset(Offset = "0x1C")]
	public UiElement DefaultButtonSelected;

	// Token: 0x040008EF RID: 2287
	[Token(Token = "0x40008EF")]
	[FieldOffset(Offset = "0x20")]
	public List<UiElement> ControllerSelectable;
}
