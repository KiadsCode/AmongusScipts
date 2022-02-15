using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200039E RID: 926
[Token(Token = "0x200039E")]
public class QuickChatFavoritesMenu : MonoBehaviour
{
	// Token: 0x060013B3 RID: 5043 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013B3")]
	[Address(RVA = "0x5156F0", Offset = "0x514AF0", VA = "0x105156F0")]
	private void OnEnable()
	{
	}

	// Token: 0x060013B4 RID: 5044 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013B4")]
	[Address(RVA = "0x5157E0", Offset = "0x514BE0", VA = "0x105157E0")]
	public void Start()
	{
	}

	// Token: 0x060013B5 RID: 5045 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013B5")]
	[Address(RVA = "0x515BB0", Offset = "0x514FB0", VA = "0x10515BB0")]
	public void UpdateQuickChatFavorite(int which)
	{
	}

	// Token: 0x060013B6 RID: 5046 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013B6")]
	[Address(RVA = "0x515CE0", Offset = "0x5150E0", VA = "0x10515CE0")]
	public QuickChatFavoritesMenu()
	{
	}

	// Token: 0x040013F9 RID: 5113
	[Token(Token = "0x40013F9")]
	[FieldOffset(Offset = "0xC")]
	public PassiveButton ButtonPrefab;

	// Token: 0x040013FA RID: 5114
	[Token(Token = "0x40013FA")]
	[FieldOffset(Offset = "0x10")]
	public Scroller ButtonParent;

	// Token: 0x040013FB RID: 5115
	[Token(Token = "0x40013FB")]
	[FieldOffset(Offset = "0x14")]
	public float ButtonStart;

	// Token: 0x040013FC RID: 5116
	[Token(Token = "0x40013FC")]
	[FieldOffset(Offset = "0x18")]
	public float ButtonHeight;

	// Token: 0x040013FD RID: 5117
	[Token(Token = "0x40013FD")]
	[FieldOffset(Offset = "0x1C")]
	private PassiveButton[] AllButtons;

	// Token: 0x040013FE RID: 5118
	[Token(Token = "0x40013FE")]
	[FieldOffset(Offset = "0x20")]
	private TextBoxTMP[] AllTextBoxes;

	// Token: 0x0200039F RID: 927
	[Token(Token = "0x200039F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass7_0
	{
		// Token: 0x060013B7 RID: 5047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013B7")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass7_0()
		{
		}

		// Token: 0x060013B8 RID: 5048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013B8")]
		[Address(RVA = "0x79AFA0", Offset = "0x79A3A0", VA = "0x1079AFA0")]
		internal void <Start>b__0()
		{
		}

		// Token: 0x040013FF RID: 5119
		[Token(Token = "0x40013FF")]
		[FieldOffset(Offset = "0x8")]
		public int tempIndex;

		// Token: 0x04001400 RID: 5120
		[Token(Token = "0x4001400")]
		[FieldOffset(Offset = "0xC")]
		public QuickChatFavoritesMenu <>4__this;
	}
}
