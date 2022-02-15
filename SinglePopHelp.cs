using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004C4 RID: 1220
[Token(Token = "0x20004C4")]
public class SinglePopHelp : MonoBehaviour
{
	// Token: 0x060019EE RID: 6638 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019EE")]
	[Address(RVA = "0x49DDE0", Offset = "0x49D1E0", VA = "0x1049DDE0")]
	public void OnEnable()
	{
	}

	// Token: 0x060019EF RID: 6639 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019EF")]
	[Address(RVA = "0x49DD70", Offset = "0x49D170", VA = "0x1049DD70")]
	public void OnDisable()
	{
	}

	// Token: 0x060019F0 RID: 6640 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019F0")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public SinglePopHelp()
	{
	}

	// Token: 0x04001A25 RID: 6693
	[Token(Token = "0x4001A25")]
	[FieldOffset(Offset = "0xC")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xDD8F0", Offset = "0xDCCF0")]
	public UiElement BackButton;

	// Token: 0x04001A26 RID: 6694
	[Token(Token = "0x4001A26")]
	[FieldOffset(Offset = "0x10")]
	public UiElement DefaultButtonSelected;

	// Token: 0x04001A27 RID: 6695
	[Token(Token = "0x4001A27")]
	[FieldOffset(Offset = "0x14")]
	public List<UiElement> ControllerSelectable;

	// Token: 0x04001A28 RID: 6696
	[Token(Token = "0x4001A28")]
	[FieldOffset(Offset = "0x18")]
	public bool GridNav;
}
