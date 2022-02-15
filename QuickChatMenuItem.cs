using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020003A9 RID: 937
[Token(Token = "0x20003A9")]
[Serializable]
public class QuickChatMenuItem
{
	// Token: 0x170002DC RID: 732
	// (get) Token: 0x060013DD RID: 5085 RVA: 0x00006840 File Offset: 0x00004A40
	[Token(Token = "0x170002DC")]
	public bool ShouldDisplay
	{
		[Token(Token = "0x60013DD")]
		[Address(RVA = "0x4E9940", Offset = "0x4E8D40", VA = "0x104E9940")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060013DE RID: 5086 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013DE")]
	[Address(RVA = "0x4E9090", Offset = "0x4E8490", VA = "0x104E9090")]
	public void CreateFillInFromRegularText()
	{
	}

	// Token: 0x060013DF RID: 5087 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013DF")]
	[Address(RVA = "0x4E92E0", Offset = "0x4E86E0", VA = "0x104E92E0")]
	private string GeneratePreviewText(string formatStr)
	{
		return null;
	}

	// Token: 0x060013E0 RID: 5088 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013E0")]
	[Address(RVA = "0x4E97A0", Offset = "0x4E8BA0", VA = "0x104E97A0")]
	public void InitLocKeys()
	{
	}

	// Token: 0x060013E1 RID: 5089 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013E1")]
	[Address(RVA = "0x4E98E0", Offset = "0x4E8CE0", VA = "0x104E98E0")]
	public QuickChatMenuItem()
	{
	}

	// Token: 0x0400142F RID: 5167
	[Token(Token = "0x400142F")]
	[FieldOffset(Offset = "0x8")]
	public Sprite icon;

	// Token: 0x04001430 RID: 5168
	[Token(Token = "0x4001430")]
	[FieldOffset(Offset = "0xC")]
	public string text;

	// Token: 0x04001431 RID: 5169
	[Token(Token = "0x4001431")]
	[FieldOffset(Offset = "0x10")]
	public byte playerID;

	// Token: 0x04001432 RID: 5170
	[Token(Token = "0x4001432")]
	[FieldOffset(Offset = "0x11")]
	public byte alternatePlayerID;

	// Token: 0x04001433 RID: 5171
	[Token(Token = "0x4001433")]
	[FieldOffset(Offset = "0x14")]
	public QuickChatMenuItem.QuickChatMenuItemDisplayType displayType;

	// Token: 0x04001434 RID: 5172
	[Token(Token = "0x4001434")]
	[FieldOffset(Offset = "0x18")]
	public QuickChatMenuItem.QuickChatMenuItemType itemType;

	// Token: 0x04001435 RID: 5173
	[Token(Token = "0x4001435")]
	[FieldOffset(Offset = "0x1C")]
	public StringNames locStringKey;

	// Token: 0x04001436 RID: 5174
	[Token(Token = "0x4001436")]
	[FieldOffset(Offset = "0x20")]
	public StringNames locStringAltKey;

	// Token: 0x04001437 RID: 5175
	[Token(Token = "0x4001437")]
	[FieldOffset(Offset = "0x24")]
	public string alternateText;

	// Token: 0x04001438 RID: 5176
	[Token(Token = "0x4001438")]
	[FieldOffset(Offset = "0x28")]
	public QuickChatSubmenu targetSubmenu;

	// Token: 0x04001439 RID: 5177
	[Token(Token = "0x4001439")]
	[FieldOffset(Offset = "0x2C")]
	public string fillInText;

	// Token: 0x0400143A RID: 5178
	[Token(Token = "0x400143A")]
	[FieldOffset(Offset = "0x30")]
	public string alternateFillInText;

	// Token: 0x0400143B RID: 5179
	[Token(Token = "0x400143B")]
	[FieldOffset(Offset = "0x34")]
	public QuickChatSubmenu[] fillBlankSelectionsInOder;

	// Token: 0x0400143C RID: 5180
	[Token(Token = "0x400143C")]
	[FieldOffset(Offset = "0x38")]
	public QuickChatSubmenu[] alternateFillBlankSelectionsInOder;

	// Token: 0x0400143D RID: 5181
	[Token(Token = "0x400143D")]
	[FieldOffset(Offset = "0x3C")]
	public Button.ButtonClickedEvent OnClick;

	// Token: 0x0400143E RID: 5182
	[Token(Token = "0x400143E")]
	[FieldOffset(Offset = "0x40")]
	[HideInInspector]
	public bool initialized;

	// Token: 0x020003AA RID: 938
	[Token(Token = "0x20003AA")]
	public enum QuickChatMenuItemType
	{
		// Token: 0x04001440 RID: 5184
		[Token(Token = "0x4001440")]
		Text,
		// Token: 0x04001441 RID: 5185
		[Token(Token = "0x4001441")]
		GoToSubmenu,
		// Token: 0x04001442 RID: 5186
		[Token(Token = "0x4001442")]
		FillInBlank,
		// Token: 0x04001443 RID: 5187
		[Token(Token = "0x4001443")]
		CustomButton
	}

	// Token: 0x020003AB RID: 939
	[Token(Token = "0x20003AB")]
	public enum QuickChatMenuItemDisplayType
	{
		// Token: 0x04001445 RID: 5189
		[Token(Token = "0x4001445")]
		Always,
		// Token: 0x04001446 RID: 5190
		[Token(Token = "0x4001446")]
		OnlyLobby,
		// Token: 0x04001447 RID: 5191
		[Token(Token = "0x4001447")]
		OnlyInGame,
		// Token: 0x04001448 RID: 5192
		[Token(Token = "0x4001448")]
		OnlyAliveInGame,
		// Token: 0x04001449 RID: 5193
		[Token(Token = "0x4001449")]
		OnlyDeadInGame
	}

	// Token: 0x020003AC RID: 940
	[Token(Token = "0x20003AC")]
	private class TempReplaceBit : IComparable
	{
		// Token: 0x060013E2 RID: 5090 RVA: 0x00006858 File Offset: 0x00004A58
		[Token(Token = "0x60013E2")]
		[Address(RVA = "0x78F400", Offset = "0x78E800", VA = "0x1078F400", Slot = "4")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x060013E3 RID: 5091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013E3")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public TempReplaceBit()
		{
		}

		// Token: 0x0400144A RID: 5194
		[Token(Token = "0x400144A")]
		[FieldOffset(Offset = "0x8")]
		public int location;

		// Token: 0x0400144B RID: 5195
		[Token(Token = "0x400144B")]
		[FieldOffset(Offset = "0xC")]
		public int originalStrIndex;
	}
}
