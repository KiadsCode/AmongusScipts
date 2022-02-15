using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x0200037D RID: 893
[Token(Token = "0x200037D")]
public class CrossplayChangedEvent : MonoBehaviour
{
	// Token: 0x06001341 RID: 4929 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001341")]
	[Address(RVA = "0x5B9DD0", Offset = "0x5B91D0", VA = "0x105B9DD0")]
	private void Awake()
	{
	}

	// Token: 0x06001342 RID: 4930 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001342")]
	[Address(RVA = "0x5B9E70", Offset = "0x5B9270", VA = "0x105B9E70")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001343 RID: 4931 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001343")]
	[Address(RVA = "0x4B6E00", Offset = "0x4B6200", VA = "0x104B6E00")]
	private void InvokeSelfCrossplayChanged()
	{
	}

	// Token: 0x06001344 RID: 4932 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001344")]
	[Address(RVA = "0x3E8790", Offset = "0x3E7B90", VA = "0x103E8790")]
	public CrossplayChangedEvent()
	{
	}

	// Token: 0x04001385 RID: 4997
	[Token(Token = "0x4001385")]
	[FieldOffset(Offset = "0xC")]
	public bool onlyOnPlayStation;

	// Token: 0x04001386 RID: 4998
	[Token(Token = "0x4001386")]
	[FieldOffset(Offset = "0x10")]
	public UnityEvent OnCrossplayChanged;
}
