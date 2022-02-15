using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003F2 RID: 1010
[Token(Token = "0x20003F2")]
public abstract class OverlayAnimation : MonoBehaviour
{
	// Token: 0x060014DE RID: 5342
	[Token(Token = "0x60014DE")]
	public abstract IEnumerator CoShow(KillOverlay parent);

	// Token: 0x060014DF RID: 5343 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014DF")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	protected OverlayAnimation()
	{
	}

	// Token: 0x04001584 RID: 5508
	[Token(Token = "0x4001584")]
	protected const float TwoFramesDelay = 0.083333336f;
}
