using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000BA RID: 186
[Token(Token = "0x20000BA")]
public class ConditionalHide : MonoBehaviour
{
	// Token: 0x06000460 RID: 1120 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000460")]
	[Address(RVA = "0x420800", Offset = "0x41FC00", VA = "0x10420800")]
	private void Awake()
	{
	}

	// Token: 0x06000461 RID: 1121 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000461")]
	[Address(RVA = "0x420800", Offset = "0x41FC00", VA = "0x10420800")]
	public void Hide()
	{
	}

	// Token: 0x06000462 RID: 1122 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000462")]
	[Address(RVA = "0x420900", Offset = "0x41FD00", VA = "0x10420900")]
	public ConditionalHide()
	{
	}

	// Token: 0x040004CD RID: 1229
	[Token(Token = "0x40004CD")]
	[FieldOffset(Offset = "0xC")]
	public RuntimePlatform[] HideForPlatforms;

	// Token: 0x040004CE RID: 1230
	[Token(Token = "0x40004CE")]
	[FieldOffset(Offset = "0x10")]
	public RuntimePlatform[] OnlyShowForPlatforms;

	// Token: 0x040004CF RID: 1231
	[Token(Token = "0x40004CF")]
	[FieldOffset(Offset = "0x14")]
	public bool ShowIfXboxTouchEnabled;
}
