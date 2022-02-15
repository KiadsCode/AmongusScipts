using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000372 RID: 882
[Token(Token = "0x2000372")]
public class ControllerDisconnectHandler : MonoBehaviour
{
	// Token: 0x060012FA RID: 4858 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012FA")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680")]
	private void Update()
	{
	}

	// Token: 0x060012FB RID: 4859 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012FB")]
	[Address(RVA = "0x7F5740", Offset = "0x7F4B40", VA = "0x107F5740")]
	public void Close()
	{
	}

	// Token: 0x060012FC RID: 4860 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012FC")]
	[Address(RVA = "0x7F58E0", Offset = "0x7F4CE0", VA = "0x107F58E0")]
	private void OnDisable()
	{
	}

	// Token: 0x060012FD RID: 4861 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012FD")]
	[Address(RVA = "0x7F5950", Offset = "0x7F4D50", VA = "0x107F5950")]
	private void OnStateChange(uint index, bool newIsConnected)
	{
	}

	// Token: 0x060012FE RID: 4862 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012FE")]
	[Address(RVA = "0x3E8790", Offset = "0x3E7B90", VA = "0x103E8790")]
	public ControllerDisconnectHandler()
	{
	}

	// Token: 0x04001344 RID: 4932
	[Token(Token = "0x4001344")]
	[FieldOffset(Offset = "0xC")]
	private bool isConnected;

	// Token: 0x04001345 RID: 4933
	[Token(Token = "0x4001345")]
	[FieldOffset(Offset = "0x10")]
	public GameObject ContinueBackground;

	// Token: 0x04001346 RID: 4934
	[Token(Token = "0x4001346")]
	[FieldOffset(Offset = "0x14")]
	public GameObject ContinueText;

	// Token: 0x04001347 RID: 4935
	[Token(Token = "0x4001347")]
	[FieldOffset(Offset = "0x18")]
	public GameObject obj;

	// Token: 0x04001348 RID: 4936
	[Token(Token = "0x4001348")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xDD8F0", Offset = "0xDCCF0")]
	public UiElement ContinueButton;
}
