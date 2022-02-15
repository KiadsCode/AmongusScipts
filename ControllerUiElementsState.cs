using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000374 RID: 884
[Token(Token = "0x2000374")]
[Serializable]
public class ControllerUiElementsState
{
	// Token: 0x06001302 RID: 4866 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001302")]
	[Address(RVA = "0x7FC850", Offset = "0x7FBC50", VA = "0x107FC850")]
	public void Reset()
	{
	}

	// Token: 0x06001303 RID: 4867 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001303")]
	[Address(RVA = "0x7FC8D0", Offset = "0x7FBCD0", VA = "0x107FC8D0")]
	public ControllerUiElementsState()
	{
	}

	// Token: 0x0400134F RID: 4943
	[Token(Token = "0x400134F")]
	[FieldOffset(Offset = "0x8")]
	public string MenuName;

	// Token: 0x04001350 RID: 4944
	[Token(Token = "0x4001350")]
	[FieldOffset(Offset = "0xC")]
	public UiElement CurrentSelection;

	// Token: 0x04001351 RID: 4945
	[Token(Token = "0x4001351")]
	[FieldOffset(Offset = "0x10")]
	public List<UiElement> SelectableUiElements;

	// Token: 0x04001352 RID: 4946
	[Token(Token = "0x4001352")]
	[FieldOffset(Offset = "0x14")]
	public UiElement BackButton;

	// Token: 0x04001353 RID: 4947
	[Token(Token = "0x4001353")]
	[FieldOffset(Offset = "0x18")]
	public bool EnforceGridNavigation;

	// Token: 0x04001354 RID: 4948
	[Token(Token = "0x4001354")]
	[FieldOffset(Offset = "0x1C")]
	public float zPos;

	// Token: 0x04001355 RID: 4949
	[Token(Token = "0x4001355")]
	[FieldOffset(Offset = "0x20")]
	public bool IsScene;
}
