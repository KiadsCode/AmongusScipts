using System;
using Il2CppDummyDll;

// Token: 0x02000309 RID: 777
[Token(Token = "0x2000309")]
[Serializable]
public class StoreTabButton : TabButton
{
	// Token: 0x06001101 RID: 4353 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001101")]
	[Address(RVA = "0x762B20", Offset = "0x761F20", VA = "0x10762B20")]
	public StoreTabButton()
	{
	}

	// Token: 0x040010B3 RID: 4275
	[Token(Token = "0x40010B3")]
	[FieldOffset(Offset = "0x14")]
	public float ItemListStartY;

	// Token: 0x040010B4 RID: 4276
	[Token(Token = "0x40010B4")]
	[FieldOffset(Offset = "0x18")]
	public FloatRange XRange;

	// Token: 0x040010B5 RID: 4277
	[Token(Token = "0x40010B5")]
	[FieldOffset(Offset = "0x1C")]
	public int NumPerRow;

	// Token: 0x040010B6 RID: 4278
	[Token(Token = "0x40010B6")]
	[FieldOffset(Offset = "0x20")]
	public StoreTab storeTab;
}
