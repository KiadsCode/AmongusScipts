using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003B6 RID: 950
[Token(Token = "0x20003B6")]
public class QuickChatSubmenu : MonoBehaviour
{
	// Token: 0x060013F9 RID: 5113 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013F9")]
	[Address(RVA = "0x4EB300", Offset = "0x4EA700", VA = "0x104EB300")]
	public void UpdateActiveItems(bool doAlternate = false)
	{
	}

	// Token: 0x060013FA RID: 5114 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013FA")]
	[Address(RVA = "0x4EB150", Offset = "0x4EA550", VA = "0x104EB150")]
	public string[] GetMenuButtonStrings(bool doAlternate = false)
	{
		return null;
	}

	// Token: 0x060013FB RID: 5115 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013FB")]
	[Address(RVA = "0x4EAEB0", Offset = "0x4EA2B0", VA = "0x104EAEB0")]
	public void Awake()
	{
	}

	// Token: 0x060013FC RID: 5116 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013FC")]
	[Address(RVA = "0x4EB520", Offset = "0x4EA920", VA = "0x104EB520")]
	public QuickChatSubmenu()
	{
	}

	// Token: 0x04001461 RID: 5217
	[Token(Token = "0x4001461")]
	[FieldOffset(Offset = "0xC")]
	[HideInInspector]
	public QuickChatSubmenu parentMenu;

	// Token: 0x04001462 RID: 5218
	[Token(Token = "0x4001462")]
	[FieldOffset(Offset = "0x10")]
	public QuickChatMenu parentChatMenu;

	// Token: 0x04001463 RID: 5219
	[Token(Token = "0x4001463")]
	[FieldOffset(Offset = "0x14")]
	public bool allowBackspace;

	// Token: 0x04001464 RID: 5220
	[Token(Token = "0x4001464")]
	[FieldOffset(Offset = "0x15")]
	public bool hasAlternateSet;

	// Token: 0x04001465 RID: 5221
	[Token(Token = "0x4001465")]
	[FieldOffset(Offset = "0x18")]
	public StringNames primarySetName;

	// Token: 0x04001466 RID: 5222
	[Token(Token = "0x4001466")]
	[FieldOffset(Offset = "0x1C")]
	public StringNames alternateSetName;

	// Token: 0x04001467 RID: 5223
	[Token(Token = "0x4001467")]
	[FieldOffset(Offset = "0x20")]
	public QuickChatSubmenu.QuickChatColorSet alternateColorSet;

	// Token: 0x04001468 RID: 5224
	[Token(Token = "0x4001468")]
	[FieldOffset(Offset = "0x24")]
	public bool hasCustomColorSet;

	// Token: 0x04001469 RID: 5225
	[Token(Token = "0x4001469")]
	[FieldOffset(Offset = "0x28")]
	public QuickChatSubmenu.QuickChatColorSet customColorSet;

	// Token: 0x0400146A RID: 5226
	[Token(Token = "0x400146A")]
	[FieldOffset(Offset = "0x2C")]
	public List<QuickChatMenuItem> menuItems;

	// Token: 0x0400146B RID: 5227
	[Token(Token = "0x400146B")]
	[FieldOffset(Offset = "0x30")]
	[NonSerialized]
	public List<QuickChatMenuItem> activeMenuItems;

	// Token: 0x0400146C RID: 5228
	[Token(Token = "0x400146C")]
	[FieldOffset(Offset = "0x34")]
	public Action OnWillDisplay;

	// Token: 0x0400146D RID: 5229
	[Token(Token = "0x400146D")]
	[FieldOffset(Offset = "0x38")]
	private List<string> menuButtonStrings;

	// Token: 0x0400146E RID: 5230
	[Token(Token = "0x400146E")]
	[FieldOffset(Offset = "0x3C")]
	private List<string> altMenuButtonStrings;

	// Token: 0x020003B7 RID: 951
	[Token(Token = "0x20003B7")]
	[Serializable]
	public class QuickChatColorSet
	{
		// Token: 0x060013FD RID: 5117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013FD")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public QuickChatColorSet()
		{
		}

		// Token: 0x0400146F RID: 5231
		[Token(Token = "0x400146F")]
		[FieldOffset(Offset = "0x8")]
		public Color fillColor;

		// Token: 0x04001470 RID: 5232
		[Token(Token = "0x4001470")]
		[FieldOffset(Offset = "0x18")]
		public Color edgeColor;
	}

	// Token: 0x020003B8 RID: 952
	[Token(Token = "0x20003B8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass17_0
	{
		// Token: 0x060013FE RID: 5118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013FE")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass17_0()
		{
		}

		// Token: 0x060013FF RID: 5119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013FF")]
		[Address(RVA = "0x79A860", Offset = "0x799C60", VA = "0x1079A860")]
		internal void <Awake>b__0()
		{
		}

		// Token: 0x06001400 RID: 5120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001400")]
		[Address(RVA = "0x79A8A0", Offset = "0x799CA0", VA = "0x1079A8A0")]
		internal void <Awake>b__1()
		{
		}

		// Token: 0x06001401 RID: 5121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001401")]
		[Address(RVA = "0x79A8D0", Offset = "0x799CD0", VA = "0x1079A8D0")]
		internal void <Awake>b__2()
		{
		}

		// Token: 0x04001471 RID: 5233
		[Token(Token = "0x4001471")]
		[FieldOffset(Offset = "0x8")]
		public QuickChatMenuItem item;

		// Token: 0x04001472 RID: 5234
		[Token(Token = "0x4001472")]
		[FieldOffset(Offset = "0xC")]
		public QuickChatSubmenu <>4__this;
	}
}
