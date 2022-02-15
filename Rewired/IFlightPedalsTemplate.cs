using System;
using Il2CppDummyDll;

namespace Rewired
{
	// Token: 0x0200053A RID: 1338
	[Token(Token = "0x200053A")]
	public interface IFlightPedalsTemplate : IControllerTemplate
	{
		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06001D03 RID: 7427
		[Token(Token = "0x170004E2")]
		IControllerTemplateAxis leftPedal { [Token(Token = "0x6001D03")] get; }

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06001D04 RID: 7428
		[Token(Token = "0x170004E3")]
		IControllerTemplateAxis rightPedal { [Token(Token = "0x6001D04")] get; }

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06001D05 RID: 7429
		[Token(Token = "0x170004E4")]
		IControllerTemplateAxis slide { [Token(Token = "0x6001D05")] get; }
	}
}
