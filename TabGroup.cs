using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002EA RID: 746
[Token(Token = "0x20002EA")]
public class TabGroup : MonoBehaviour
{
	// Token: 0x06001077 RID: 4215 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001077")]
	[Address(RVA = "0x766E80", Offset = "0x766280", VA = "0x10766E80")]
	internal void Close()
	{
	}

	// Token: 0x06001078 RID: 4216 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001078")]
	[Address(RVA = "0x766F10", Offset = "0x766310", VA = "0x10766F10")]
	internal void Open()
	{
	}

	// Token: 0x06001079 RID: 4217 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001079")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public TabGroup()
	{
	}

	// Token: 0x0400102A RID: 4138
	[Token(Token = "0x400102A")]
	[FieldOffset(Offset = "0xC")]
	public SpriteRenderer Button;

	// Token: 0x0400102B RID: 4139
	[Token(Token = "0x400102B")]
	[FieldOffset(Offset = "0x10")]
	public ButtonRolloverHandler Rollover;

	// Token: 0x0400102C RID: 4140
	[Token(Token = "0x400102C")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Content;
}
