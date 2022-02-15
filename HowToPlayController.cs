using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001B8 RID: 440
[Token(Token = "0x20001B8")]
public class HowToPlayController : MonoBehaviour
{
	// Token: 0x060009F7 RID: 2551 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009F7")]
	[Address(RVA = "0x3E9510", Offset = "0x3E8910", VA = "0x103E9510")]
	public void Start()
	{
	}

	// Token: 0x060009F8 RID: 2552 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009F8")]
	[Address(RVA = "0x3E9740", Offset = "0x3E8B40", VA = "0x103E9740")]
	public void Update()
	{
	}

	// Token: 0x060009F9 RID: 2553 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009F9")]
	[Address(RVA = "0x3E94D0", Offset = "0x3E88D0", VA = "0x103E94D0")]
	public void NextScene()
	{
	}

	// Token: 0x060009FA RID: 2554 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009FA")]
	[Address(RVA = "0x3E94F0", Offset = "0x3E88F0", VA = "0x103E94F0")]
	public void PreviousScene()
	{
	}

	// Token: 0x060009FB RID: 2555 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009FB")]
	[Address(RVA = "0x3E9420", Offset = "0x3E8820", VA = "0x103E9420")]
	public void Close()
	{
	}

	// Token: 0x060009FC RID: 2556 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009FC")]
	[Address(RVA = "0x3E9230", Offset = "0x3E8630", VA = "0x103E9230")]
	private void ChangeScene(int del)
	{
	}

	// Token: 0x060009FD RID: 2557 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009FD")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public HowToPlayController()
	{
	}

	// Token: 0x04000A10 RID: 2576
	[Token(Token = "0x4000A10")]
	[FieldOffset(Offset = "0xC")]
	public Transform DotParent;

	// Token: 0x04000A11 RID: 2577
	[Token(Token = "0x4000A11")]
	[FieldOffset(Offset = "0x10")]
	public SpriteRenderer leftButton;

	// Token: 0x04000A12 RID: 2578
	[Token(Token = "0x4000A12")]
	[FieldOffset(Offset = "0x14")]
	public SpriteRenderer rightButton;

	// Token: 0x04000A13 RID: 2579
	[Token(Token = "0x4000A13")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xDD8F0", Offset = "0xDCCF0")]
	public UiElement CloseButton;

	// Token: 0x04000A14 RID: 2580
	[Token(Token = "0x4000A14")]
	[FieldOffset(Offset = "0x1C")]
	public UiElement DefaultButtonSelected;

	// Token: 0x04000A15 RID: 2581
	[Token(Token = "0x4000A15")]
	[FieldOffset(Offset = "0x20")]
	public List<UiElement> ControllerSelectable;

	// Token: 0x04000A16 RID: 2582
	[Token(Token = "0x4000A16")]
	[FieldOffset(Offset = "0x24")]
	public ConditionalSceneController PCMove;

	// Token: 0x04000A17 RID: 2583
	[Token(Token = "0x4000A17")]
	[FieldOffset(Offset = "0x28")]
	public SceneController[] Scenes;

	// Token: 0x04000A18 RID: 2584
	[Token(Token = "0x4000A18")]
	[FieldOffset(Offset = "0x2C")]
	public int SceneNum;
}
