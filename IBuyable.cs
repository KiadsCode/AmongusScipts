using System;
using Il2CppDummyDll;

// Token: 0x020003EC RID: 1004
[Token(Token = "0x20003EC")]
public interface IBuyable
{
	// Token: 0x170002EA RID: 746
	// (get) Token: 0x060014CA RID: 5322
	[Token(Token = "0x170002EA")]
	string ProdId { [Token(Token = "0x60014CA")] get; }

	// Token: 0x170002EB RID: 747
	// (get) Token: 0x060014CB RID: 5323
	[Token(Token = "0x170002EB")]
	int BeanCost { [Token(Token = "0x60014CB")] get; }

	// Token: 0x170002EC RID: 748
	// (get) Token: 0x060014CC RID: 5324
	[Token(Token = "0x170002EC")]
	int StarCost { [Token(Token = "0x60014CC")] get; }

	// Token: 0x170002ED RID: 749
	// (get) Token: 0x060014CD RID: 5325
	[Token(Token = "0x170002ED")]
	bool PaidOnMobile { [Token(Token = "0x60014CD")] get; }

	// Token: 0x170002EE RID: 750
	// (get) Token: 0x060014CE RID: 5326
	[Token(Token = "0x170002EE")]
	LimitedTimeStartEnd LimitedTimeAvailable { [Token(Token = "0x60014CE")] get; }
}
