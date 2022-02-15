using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000398 RID: 920
[Token(Token = "0x2000398")]
[Attribute(Name = "DefaultExecutionOrder", RVA = "0xDE100", Offset = "0xDD500")]
public class PSManager : DestroyableSingleton<PSManager>
{
	// Token: 0x060013A1 RID: 5025 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013A1")]
	[Address(RVA = "0x6559D0", Offset = "0x654DD0", VA = "0x106559D0")]
	public string GetSessionName()
	{
		return null;
	}

	// Token: 0x060013A2 RID: 5026 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013A2")]
	[Address(RVA = "0x655F50", Offset = "0x655350", VA = "0x10655F50")]
	public PSManager()
	{
	}

	// Token: 0x040013E7 RID: 5095
	[Token(Token = "0x40013E7")]
	[FieldOffset(Offset = "0x10")]
	public Texture2D ps4SessionImage;

	// Token: 0x040013E8 RID: 5096
	[Token(Token = "0x40013E8")]
	[FieldOffset(Offset = "0x14")]
	[NonSerialized]
	public byte[] ps4SessionImageAsPNG;

	// Token: 0x040013E9 RID: 5097
	[Token(Token = "0x40013E9")]
	[FieldOffset(Offset = "0x18")]
	public JoinSessionSource joinSessionSource;

	// Token: 0x040013EA RID: 5098
	[Token(Token = "0x40013EA")]
	[FieldOffset(Offset = "0x1C")]
	public bool gameplayStarted;
}
