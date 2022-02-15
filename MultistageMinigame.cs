using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x0200017F RID: 383
[Token(Token = "0x200017F")]
public class MultistageMinigame : Minigame
{
	// Token: 0x060008C1 RID: 2241 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008C1")]
	[Address(RVA = "0x7756D0", Offset = "0x774AD0", VA = "0x107756D0", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x060008C2 RID: 2242 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008C2")]
	[Address(RVA = "0x775960", Offset = "0x774D60", VA = "0x10775960", Slot = "5")]
	public override void Close()
	{
	}

	// Token: 0x060008C3 RID: 2243 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008C3")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public MultistageMinigame()
	{
	}

	// Token: 0x040008C6 RID: 2246
	[Token(Token = "0x40008C6")]
	[FieldOffset(Offset = "0x30")]
	public Minigame[] Stages;

	// Token: 0x040008C7 RID: 2247
	[Token(Token = "0x40008C7")]
	[FieldOffset(Offset = "0x34")]
	private Minigame stage;

	// Token: 0x040008C8 RID: 2248
	[Token(Token = "0x40008C8")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xDD8F0", Offset = "0xDCCF0")]
	public UiElement BackButton;

	// Token: 0x040008C9 RID: 2249
	[Token(Token = "0x40008C9")]
	[FieldOffset(Offset = "0x3C")]
	public List<UiElement> ControllerSelectable;
}
