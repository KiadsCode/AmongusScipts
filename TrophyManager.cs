using System;
using Il2CppDummyDll;

// Token: 0x02000395 RID: 917
[Token(Token = "0x2000395")]
public class TrophyManager : DestroyableSingleton<TrophyManager>
{
	// Token: 0x0600139F RID: 5023 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600139F")]
	[Address(RVA = "0x4B2E30", Offset = "0x4B2230", VA = "0x104B2E30")]
	public TrophyManager()
	{
	}

	// Token: 0x040013DF RID: 5087
	[Token(Token = "0x40013DF")]
	[FieldOffset(Offset = "0x0")]
	public new static TrophyManager Instance;

	// Token: 0x040013E0 RID: 5088
	[Token(Token = "0x40013E0")]
	[FieldOffset(Offset = "0x4")]
	private static int UserID;
}
