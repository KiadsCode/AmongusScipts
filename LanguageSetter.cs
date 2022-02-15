using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000466 RID: 1126
[Token(Token = "0x2000466")]
public class LanguageSetter : MonoBehaviour
{
	// Token: 0x06001805 RID: 6149 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001805")]
	[Address(RVA = "0x6D8920", Offset = "0x6D7D20", VA = "0x106D8920")]
	private void OnEnable()
	{
	}

	// Token: 0x06001806 RID: 6150 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001806")]
	[Address(RVA = "0x6D88A0", Offset = "0x6D7CA0", VA = "0x106D88A0")]
	private void OnDisable()
	{
	}

	// Token: 0x06001807 RID: 6151 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001807")]
	[Address(RVA = "0x6D8BF0", Offset = "0x6D7FF0", VA = "0x106D8BF0")]
	public void Start()
	{
	}

	// Token: 0x06001808 RID: 6152 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001808")]
	[Address(RVA = "0x6D8A80", Offset = "0x6D7E80", VA = "0x106D8A80")]
	public void SetLanguage(LanguageButton selected)
	{
	}

	// Token: 0x06001809 RID: 6153 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001809")]
	[Address(RVA = "0x499D70", Offset = "0x499170", VA = "0x10499D70")]
	public void Open()
	{
	}

	// Token: 0x0600180A RID: 6154 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600180A")]
	[Address(RVA = "0x499D40", Offset = "0x499140", VA = "0x10499D40")]
	public void Close()
	{
	}

	// Token: 0x0600180B RID: 6155 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600180B")]
	[Address(RVA = "0x6D90F0", Offset = "0x6D84F0", VA = "0x106D90F0")]
	public LanguageSetter()
	{
	}

	// Token: 0x0400181B RID: 6171
	[Token(Token = "0x400181B")]
	[FieldOffset(Offset = "0xC")]
	public LanguageButton ButtonPrefab;

	// Token: 0x0400181C RID: 6172
	[Token(Token = "0x400181C")]
	[FieldOffset(Offset = "0x10")]
	public Scroller ButtonParent;

	// Token: 0x0400181D RID: 6173
	[Token(Token = "0x400181D")]
	[FieldOffset(Offset = "0x14")]
	public float ButtonStart;

	// Token: 0x0400181E RID: 6174
	[Token(Token = "0x400181E")]
	[FieldOffset(Offset = "0x18")]
	public float ButtonHeight;

	// Token: 0x0400181F RID: 6175
	[Token(Token = "0x400181F")]
	[FieldOffset(Offset = "0x1C")]
	private LanguageButton[] AllButtons;

	// Token: 0x04001820 RID: 6176
	[Token(Token = "0x4001820")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshPro parentLangButton;

	// Token: 0x04001821 RID: 6177
	[Token(Token = "0x4001821")]
	[FieldOffset(Offset = "0x24")]
	private List<UiElement> selectableButtons;

	// Token: 0x04001822 RID: 6178
	[Token(Token = "0x4001822")]
	[FieldOffset(Offset = "0x28")]
	public UiElement backButton;

	// Token: 0x02000467 RID: 1127
	[Token(Token = "0x2000467")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass10_0
	{
		// Token: 0x0600180C RID: 6156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600180C")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass10_0()
		{
		}

		// Token: 0x0600180D RID: 6157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600180D")]
		[Address(RVA = "0x5B4FC0", Offset = "0x5B43C0", VA = "0x105B4FC0")]
		internal void <Start>b__0()
		{
		}

		// Token: 0x04001823 RID: 6179
		[Token(Token = "0x4001823")]
		[FieldOffset(Offset = "0x8")]
		public LanguageButton button;

		// Token: 0x04001824 RID: 6180
		[Token(Token = "0x4001824")]
		[FieldOffset(Offset = "0xC")]
		public LanguageSetter <>4__this;
	}
}
