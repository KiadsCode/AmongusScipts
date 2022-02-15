using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020001A7 RID: 423
[Token(Token = "0x20001A7")]
public class LogEntryBubble : PoolableBehavior
{
	// Token: 0x0600099D RID: 2461 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600099D")]
	[Address(RVA = "0x3AC2A0", Offset = "0x3AB6A0", VA = "0x103AC2A0")]
	public LogEntryBubble()
	{
	}

	// Token: 0x040009B2 RID: 2482
	[Token(Token = "0x40009B2")]
	[FieldOffset(Offset = "0x14")]
	public SpriteRenderer HeadImage;

	// Token: 0x040009B3 RID: 2483
	[Token(Token = "0x40009B3")]
	[FieldOffset(Offset = "0x18")]
	public SpriteRenderer Background;

	// Token: 0x040009B4 RID: 2484
	[Token(Token = "0x40009B4")]
	[FieldOffset(Offset = "0x1C")]
	public TextMeshPro Text;
}
