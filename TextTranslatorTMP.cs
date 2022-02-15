using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x02000508 RID: 1288
[Token(Token = "0x2000508")]
public class TextTranslatorTMP : MonoBehaviour, ITranslatedText
{
	// Token: 0x06001B67 RID: 7015 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B67")]
	[Address(RVA = "0x4ACCF0", Offset = "0x4AC0F0", VA = "0x104ACCF0", Slot = "4")]
	public void ResetText()
	{
	}

	// Token: 0x06001B68 RID: 7016 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B68")]
	[Address(RVA = "0x4ACE80", Offset = "0x4AC280", VA = "0x104ACE80")]
	public void Start()
	{
	}

	// Token: 0x06001B69 RID: 7017 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B69")]
	[Address(RVA = "0x4ACBF0", Offset = "0x4ABFF0", VA = "0x104ACBF0")]
	public void OnDestroy()
	{
	}

	// Token: 0x06001B6A RID: 7018 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B6A")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public TextTranslatorTMP()
	{
	}

	// Token: 0x04001F24 RID: 7972
	[Token(Token = "0x4001F24")]
	[FieldOffset(Offset = "0xC")]
	public StringNames TargetText;

	// Token: 0x04001F25 RID: 7973
	[Token(Token = "0x4001F25")]
	[FieldOffset(Offset = "0x10")]
	public string defaultStr;

	// Token: 0x04001F26 RID: 7974
	[Token(Token = "0x4001F26")]
	[FieldOffset(Offset = "0x14")]
	public bool ToUpper;

	// Token: 0x04001F27 RID: 7975
	[Token(Token = "0x4001F27")]
	[FieldOffset(Offset = "0x15")]
	public bool ResetOnlyWhenNoDefault;

	// Token: 0x04001F28 RID: 7976
	[Token(Token = "0x4001F28")]
	[FieldOffset(Offset = "0x18")]
	public UnityEvent OnTranslate;
}
