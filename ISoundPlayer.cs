using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004C8 RID: 1224
[Token(Token = "0x20004C8")]
public interface ISoundPlayer
{
	// Token: 0x170003C5 RID: 965
	// (get) Token: 0x06001A06 RID: 6662
	// (set) Token: 0x06001A07 RID: 6663
	[Token(Token = "0x170003C5")]
	string Name { [Token(Token = "0x6001A06")] get; [Token(Token = "0x6001A07")] set; }

	// Token: 0x170003C6 RID: 966
	// (get) Token: 0x06001A08 RID: 6664
	// (set) Token: 0x06001A09 RID: 6665
	[Token(Token = "0x170003C6")]
	AudioSource Player { [Token(Token = "0x6001A08")] get; [Token(Token = "0x6001A09")] set; }

	// Token: 0x06001A0A RID: 6666
	[Token(Token = "0x6001A0A")]
	void Update(float dt);
}
