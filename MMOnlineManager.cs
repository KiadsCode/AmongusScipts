using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002ED RID: 749
[Token(Token = "0x20002ED")]
public class MMOnlineManager : DestroyableSingleton<MMOnlineManager>
{
	// Token: 0x06001086 RID: 4230 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001086")]
	[Address(RVA = "0x6E3480", Offset = "0x6E2880", VA = "0x106E3480")]
	public void Start()
	{
	}

	// Token: 0x06001087 RID: 4231 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001087")]
	[Address(RVA = "0x6E37B0", Offset = "0x6E2BB0", VA = "0x106E37B0")]
	private void Update()
	{
	}

	// Token: 0x06001088 RID: 4232 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001088")]
	[Address(RVA = "0x6E3340", Offset = "0x6E2740", VA = "0x106E3340")]
	public void CheckAndShowGuestWarning()
	{
	}

	// Token: 0x06001089 RID: 4233 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001089")]
	[Address(RVA = "0x6E37F0", Offset = "0x6E2BF0", VA = "0x106E37F0")]
	public MMOnlineManager()
	{
	}

	// Token: 0x04001032 RID: 4146
	[Token(Token = "0x4001032")]
	[FieldOffset(Offset = "0x10")]
	public GameObject HelpMenu;

	// Token: 0x04001033 RID: 4147
	[Token(Token = "0x4001033")]
	[FieldOffset(Offset = "0x14")]
	public GameObject GuestProgressionWarning;

	// Token: 0x04001034 RID: 4148
	[Token(Token = "0x4001034")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xDD8F0", Offset = "0xDCCF0")]
	public UiElement BackButton;

	// Token: 0x04001035 RID: 4149
	[Token(Token = "0x4001035")]
	[FieldOffset(Offset = "0x1C")]
	public UiElement DefaultButtonSelected;

	// Token: 0x04001036 RID: 4150
	[Token(Token = "0x4001036")]
	[FieldOffset(Offset = "0x20")]
	public List<UiElement> ControllerSelectable;

	// Token: 0x04001037 RID: 4151
	[Token(Token = "0x4001037")]
	[FieldOffset(Offset = "0x24")]
	public bool IsControllerManagerSceneInit;
}
