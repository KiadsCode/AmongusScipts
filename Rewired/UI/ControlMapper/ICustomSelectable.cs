using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x0200058B RID: 1419
	[Token(Token = "0x200058B")]
	public interface ICustomSelectable : ICancelHandler, IEventSystemHandler
	{
		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x06002308 RID: 8968
		// (set) Token: 0x06002309 RID: 8969
		[Token(Token = "0x1700072A")]
		Sprite disabledHighlightedSprite { [Token(Token = "0x6002308")] get; [Token(Token = "0x6002309")] set; }

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x0600230A RID: 8970
		// (set) Token: 0x0600230B RID: 8971
		[Token(Token = "0x1700072B")]
		Color disabledHighlightedColor { [Token(Token = "0x600230A")] get; [Token(Token = "0x600230B")] set; }

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x0600230C RID: 8972
		// (set) Token: 0x0600230D RID: 8973
		[Token(Token = "0x1700072C")]
		string disabledHighlightedTrigger { [Token(Token = "0x600230C")] get; [Token(Token = "0x600230D")] set; }

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x0600230E RID: 8974
		// (set) Token: 0x0600230F RID: 8975
		[Token(Token = "0x1700072D")]
		bool autoNavUp { [Token(Token = "0x600230E")] get; [Token(Token = "0x600230F")] set; }

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x06002310 RID: 8976
		// (set) Token: 0x06002311 RID: 8977
		[Token(Token = "0x1700072E")]
		bool autoNavDown { [Token(Token = "0x6002310")] get; [Token(Token = "0x6002311")] set; }

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x06002312 RID: 8978
		// (set) Token: 0x06002313 RID: 8979
		[Token(Token = "0x1700072F")]
		bool autoNavLeft { [Token(Token = "0x6002312")] get; [Token(Token = "0x6002313")] set; }

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x06002314 RID: 8980
		// (set) Token: 0x06002315 RID: 8981
		[Token(Token = "0x17000730")]
		bool autoNavRight { [Token(Token = "0x6002314")] get; [Token(Token = "0x6002315")] set; }

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x06002316 RID: 8982
		// (remove) Token: 0x06002317 RID: 8983
		[Token(Token = "0x14000016")]
		event UnityAction CancelEvent;
	}
}
