using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x02000382 RID: 898
[Token(Token = "0x2000382")]
public class DelayedFunctionCall : MonoBehaviour
{
	// Token: 0x0600134B RID: 4939 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600134B")]
	[Address(RVA = "0x5C5B90", Offset = "0x5C4F90", VA = "0x105C5B90")]
	private void Update()
	{
	}

	// Token: 0x0600134C RID: 4940 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600134C")]
	[Address(RVA = "0x512B90", Offset = "0x511F90", VA = "0x10512B90")]
	public DelayedFunctionCall()
	{
	}

	// Token: 0x04001394 RID: 5012
	[Token(Token = "0x4001394")]
	[FieldOffset(Offset = "0xC")]
	public UnityEvent onTimerElapsed;

	// Token: 0x04001395 RID: 5013
	[Token(Token = "0x4001395")]
	[FieldOffset(Offset = "0x10")]
	public float delayDuration;

	// Token: 0x04001396 RID: 5014
	[Token(Token = "0x4001396")]
	[FieldOffset(Offset = "0x14")]
	private float t;
}
