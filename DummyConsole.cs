using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001B3 RID: 435
[Token(Token = "0x20001B3")]
public class DummyConsole : MonoBehaviour
{
	// Token: 0x060009E1 RID: 2529 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009E1")]
	[Address(RVA = "0x46E600", Offset = "0x46DA00", VA = "0x1046E600")]
	public void Start()
	{
	}

	// Token: 0x060009E2 RID: 2530 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009E2")]
	[Address(RVA = "0x46E320", Offset = "0x46D720", VA = "0x1046E320")]
	public void FixedUpdate()
	{
	}

	// Token: 0x060009E3 RID: 2531 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009E3")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public DummyConsole()
	{
	}

	// Token: 0x040009FC RID: 2556
	[Token(Token = "0x40009FC")]
	[FieldOffset(Offset = "0xC")]
	public int ConsoleId;

	// Token: 0x040009FD RID: 2557
	[Token(Token = "0x40009FD")]
	[FieldOffset(Offset = "0x10")]
	public PlayerAnimator[] Players;

	// Token: 0x040009FE RID: 2558
	[Token(Token = "0x40009FE")]
	[FieldOffset(Offset = "0x14")]
	public float UseDistance;

	// Token: 0x040009FF RID: 2559
	[Token(Token = "0x40009FF")]
	[FieldOffset(Offset = "0x18")]
	[HideInInspector]
	private SpriteRenderer rend;
}
