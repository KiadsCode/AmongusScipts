using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Rewired;
using UnityEngine;

// Token: 0x0200036D RID: 877
[Token(Token = "0x200036D")]
public class ControllerButtonBehavior : MonoBehaviour
{
	// Token: 0x060012F2 RID: 4850 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012F2")]
	[Address(RVA = "0x7F5050", Offset = "0x7F4450", VA = "0x107F5050")]
	private void Start()
	{
	}

	// Token: 0x060012F3 RID: 4851 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012F3")]
	[Address(RVA = "0x7F5130", Offset = "0x7F4530", VA = "0x107F5130")]
	private void Update()
	{
	}

	// Token: 0x060012F4 RID: 4852 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012F4")]
	[Address(RVA = "0x7F5310", Offset = "0x7F4710", VA = "0x107F5310")]
	public ControllerButtonBehavior()
	{
	}

	// Token: 0x04001332 RID: 4914
	[Token(Token = "0x4001332")]
	[FieldOffset(Offset = "0xC")]
	public RewiredConstsEnum.Action Action;

	// Token: 0x04001333 RID: 4915
	[Token(Token = "0x4001333")]
	[FieldOffset(Offset = "0x10")]
	public GameObject requiredMenuObject;

	// Token: 0x04001334 RID: 4916
	[Token(Token = "0x4001334")]
	[FieldOffset(Offset = "0x14")]
	public List<string> requiredMenuNames;

	// Token: 0x04001335 RID: 4917
	[Token(Token = "0x4001335")]
	[FieldOffset(Offset = "0x18")]
	private Player player;
}
