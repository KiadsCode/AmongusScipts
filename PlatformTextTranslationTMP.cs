using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000506 RID: 1286
[Token(Token = "0x2000506")]
[Attribute(Name = "RequireComponent", RVA = "0xE10F0", Offset = "0xE04F0")]
public class PlatformTextTranslationTMP : MonoBehaviour, ITranslatedText
{
	// Token: 0x06001B63 RID: 7011 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B63")]
	[Address(RVA = "0x65F3C0", Offset = "0x65E7C0", VA = "0x1065F3C0", Slot = "4")]
	public void ResetText()
	{
	}

	// Token: 0x06001B64 RID: 7012 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B64")]
	[Address(RVA = "0x65F480", Offset = "0x65E880", VA = "0x1065F480")]
	public void Start()
	{
	}

	// Token: 0x06001B65 RID: 7013 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B65")]
	[Address(RVA = "0x65F2C0", Offset = "0x65E6C0", VA = "0x1065F2C0")]
	public void OnDestroy()
	{
	}

	// Token: 0x06001B66 RID: 7014 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B66")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public PlatformTextTranslationTMP()
	{
	}

	// Token: 0x04001BAD RID: 7085
	[Token(Token = "0x4001BAD")]
	[FieldOffset(Offset = "0xC")]
	public StringNames DefaultTargetText;

	// Token: 0x04001BAE RID: 7086
	[Token(Token = "0x4001BAE")]
	[FieldOffset(Offset = "0x10")]
	public StringNames SwitchTargetText;

	// Token: 0x04001BAF RID: 7087
	[Token(Token = "0x4001BAF")]
	[FieldOffset(Offset = "0x14")]
	public StringNames XboxTargetText;

	// Token: 0x04001BB0 RID: 7088
	[Token(Token = "0x4001BB0")]
	[FieldOffset(Offset = "0x18")]
	public StringNames PlaystationTargetText;
}
