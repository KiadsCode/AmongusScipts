using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000460 RID: 1120
[Token(Token = "0x2000460")]
public class CreateOptionsPicker : MonoBehaviour
{
	// Token: 0x060017D8 RID: 6104 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017D8")]
	[Address(RVA = "0x5B8840", Offset = "0x5B7C40", VA = "0x105B8840")]
	public void Start()
	{
	}

	// Token: 0x060017D9 RID: 6105 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017D9")]
	[Address(RVA = "0x5B8320", Offset = "0x5B7720", VA = "0x105B8320")]
	public GameOptionsData GetTargetOptions()
	{
		return null;
	}

	// Token: 0x060017DA RID: 6106 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017DA")]
	[Address(RVA = "0x5B87C0", Offset = "0x5B7BC0", VA = "0x105B87C0")]
	private void SetTargetOptions(GameOptionsData data)
	{
	}

	// Token: 0x060017DB RID: 6107 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017DB")]
	[Address(RVA = "0x5B86D0", Offset = "0x5B7AD0", VA = "0x105B86D0")]
	public void SetMaxPlayersButtons(int maxPlayers)
	{
	}

	// Token: 0x060017DC RID: 6108 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017DC")]
	[Address(RVA = "0x5B9080", Offset = "0x5B8480", VA = "0x105B9080")]
	private void UpdateMaxPlayersButtons(GameOptionsData opts)
	{
	}

	// Token: 0x060017DD RID: 6109 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017DD")]
	[Address(RVA = "0x5B83F0", Offset = "0x5B77F0", VA = "0x105B83F0")]
	public void SetImpostorButtons(int numImpostors)
	{
	}

	// Token: 0x060017DE RID: 6110 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017DE")]
	[Address(RVA = "0x5B8BC0", Offset = "0x5B7FC0", VA = "0x105B8BC0")]
	private void UpdateImpostorsButtons(int numImpostors)
	{
	}

	// Token: 0x060017DF RID: 6111 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017DF")]
	[Address(RVA = "0x5B8620", Offset = "0x5B7A20", VA = "0x105B8620")]
	public void SetMap(int mapid)
	{
	}

	// Token: 0x060017E0 RID: 6112 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017E0")]
	[Address(RVA = "0x5B8D90", Offset = "0x5B8190", VA = "0x105B8D90")]
	private void UpdateMapButtons(int mapid)
	{
	}

	// Token: 0x060017E1 RID: 6113 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017E1")]
	[Address(RVA = "0x5B8580", Offset = "0x5B7980", VA = "0x105B8580")]
	public void SetLanguageFilter(uint keyword)
	{
	}

	// Token: 0x060017E2 RID: 6114 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017E2")]
	[Address(RVA = "0x5B8C60", Offset = "0x5B8060", VA = "0x105B8C60")]
	private void UpdateLanguageButton(uint flag)
	{
	}

	// Token: 0x060017E3 RID: 6115 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017E3")]
	[Address(RVA = "0x5B92A0", Offset = "0x5B86A0", VA = "0x105B92A0")]
	public CreateOptionsPicker()
	{
	}

	// Token: 0x040017DB RID: 6107
	[Token(Token = "0x40017DB")]
	private const float MaxPlayerButtonWidth = 0.5f;

	// Token: 0x040017DC RID: 6108
	[Token(Token = "0x40017DC")]
	[FieldOffset(Offset = "0xC")]
	public SpriteRenderer MaxPlayerButtonPrefab;

	// Token: 0x040017DD RID: 6109
	[Token(Token = "0x40017DD")]
	[FieldOffset(Offset = "0x10")]
	private List<SpriteRenderer> MaxPlayerButtons;

	// Token: 0x040017DE RID: 6110
	[Token(Token = "0x40017DE")]
	[FieldOffset(Offset = "0x14")]
	public Transform MaxPlayersRoot;

	// Token: 0x040017DF RID: 6111
	[Token(Token = "0x40017DF")]
	[FieldOffset(Offset = "0x18")]
	public SpriteRenderer[] ImpostorButtons;

	// Token: 0x040017E0 RID: 6112
	[Token(Token = "0x40017E0")]
	[FieldOffset(Offset = "0x1C")]
	public TextMeshPro LanguageButton;

	// Token: 0x040017E1 RID: 6113
	[Token(Token = "0x40017E1")]
	[FieldOffset(Offset = "0x20")]
	public SpriteRenderer[] MapButtons;

	// Token: 0x040017E2 RID: 6114
	[Token(Token = "0x40017E2")]
	[FieldOffset(Offset = "0x24")]
	public SettingsMode mode;

	// Token: 0x040017E3 RID: 6115
	[Token(Token = "0x40017E3")]
	[FieldOffset(Offset = "0x28")]
	public CrewVisualizer CrewArea;

	// Token: 0x040017E4 RID: 6116
	[Token(Token = "0x40017E4")]
	[FieldOffset(Offset = "0x2C")]
	public CreateGameOptions optionsMenu;

	// Token: 0x02000461 RID: 1121
	[Token(Token = "0x2000461")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass10_0
	{
		// Token: 0x060017E4 RID: 6116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017E4")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass10_0()
		{
		}

		// Token: 0x060017E5 RID: 6117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017E5")]
		[Address(RVA = "0x78D6F0", Offset = "0x78CAF0", VA = "0x1078D6F0")]
		internal void <Start>b__0()
		{
		}

		// Token: 0x040017E5 RID: 6117
		[Token(Token = "0x40017E5")]
		[FieldOffset(Offset = "0x8")]
		public int numPlayers;

		// Token: 0x040017E6 RID: 6118
		[Token(Token = "0x40017E6")]
		[FieldOffset(Offset = "0xC")]
		public CreateOptionsPicker <>4__this;
	}
}
