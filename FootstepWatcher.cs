using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000494 RID: 1172
[Token(Token = "0x2000494")]
internal class FootstepWatcher : MonoBehaviour, IStepWatcher
{
	// Token: 0x1700038B RID: 907
	// (get) Token: 0x060018F6 RID: 6390 RVA: 0x00007CE0 File Offset: 0x00005EE0
	[Token(Token = "0x1700038B")]
	public int Priority
	{
		[Token(Token = "0x60018F6")]
		[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
		get
		{
			return 0;
		}
	}

	// Token: 0x060018F7 RID: 6391 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018F7")]
	[Address(RVA = "0x3AA9D0", Offset = "0x3A9DD0", VA = "0x103AA9D0", Slot = "5")]
	public SoundGroup MakeFootstep(PlayerControl player)
	{
		return null;
	}

	// Token: 0x060018F8 RID: 6392 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018F8")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public FootstepWatcher()
	{
	}

	// Token: 0x04001910 RID: 6416
	[Token(Token = "0x4001910")]
	[FieldOffset(Offset = "0xC")]
	public int priority;

	// Token: 0x04001911 RID: 6417
	[Token(Token = "0x4001911")]
	[FieldOffset(Offset = "0x10")]
	public Collider2D Area;

	// Token: 0x04001912 RID: 6418
	[Token(Token = "0x4001912")]
	[FieldOffset(Offset = "0x14")]
	public SoundGroup Sounds;
}
