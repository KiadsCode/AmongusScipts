using System;
using Il2CppDummyDll;

// Token: 0x0200049C RID: 1180
[Token(Token = "0x200049C")]
public interface IStepWatcher
{
	// Token: 0x17000396 RID: 918
	// (get) Token: 0x06001918 RID: 6424
	[Token(Token = "0x17000396")]
	int Priority { [Token(Token = "0x6001918")] get; }

	// Token: 0x06001919 RID: 6425
	[Token(Token = "0x6001919")]
	SoundGroup MakeFootstep(PlayerControl player);
}
