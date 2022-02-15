using System;
using Il2CppDummyDll;
using Rewired;
using UnityEngine;

// Token: 0x02000373 RID: 883
[Token(Token = "0x2000373")]
public class ControllerHeldButtonBehaviour : MonoBehaviour
{
	// Token: 0x060012FF RID: 4863 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012FF")]
	[Address(RVA = "0x7F5B50", Offset = "0x7F4F50", VA = "0x107F5B50")]
	private void Start()
	{
	}

	// Token: 0x06001300 RID: 4864 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001300")]
	[Address(RVA = "0x7F5BC0", Offset = "0x7F4FC0", VA = "0x107F5BC0")]
	private void Update()
	{
	}

	// Token: 0x06001301 RID: 4865 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001301")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public ControllerHeldButtonBehaviour()
	{
	}

	// Token: 0x04001349 RID: 4937
	[Token(Token = "0x4001349")]
	[FieldOffset(Offset = "0xC")]
	public RewiredConstsEnum.Action Action;

	// Token: 0x0400134A RID: 4938
	[Token(Token = "0x400134A")]
	[FieldOffset(Offset = "0x10")]
	private Player player;

	// Token: 0x0400134B RID: 4939
	[Token(Token = "0x400134B")]
	[FieldOffset(Offset = "0x14")]
	public SpriteRenderer targetCooldownSprite;

	// Token: 0x0400134C RID: 4940
	[Token(Token = "0x400134C")]
	[FieldOffset(Offset = "0x18")]
	public float holdDuration;

	// Token: 0x0400134D RID: 4941
	[Token(Token = "0x400134D")]
	[FieldOffset(Offset = "0x1C")]
	private float holdTimer;

	// Token: 0x0400134E RID: 4942
	[Token(Token = "0x400134E")]
	[FieldOffset(Offset = "0x20")]
	private bool alreadyPressed;
}
