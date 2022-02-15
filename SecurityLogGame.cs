using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020001A8 RID: 424
[Token(Token = "0x20001A8")]
public class SecurityLogGame : Minigame
{
	// Token: 0x0600099E RID: 2462 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600099E")]
	[Address(RVA = "0x58EF50", Offset = "0x58E350", VA = "0x1058EF50")]
	public void Awake()
	{
	}

	// Token: 0x0600099F RID: 2463 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600099F")]
	[Address(RVA = "0x58F5E0", Offset = "0x58E9E0", VA = "0x1058F5E0")]
	public void Update()
	{
	}

	// Token: 0x060009A0 RID: 2464 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009A0")]
	[Address(RVA = "0x58F040", Offset = "0x58E440", VA = "0x1058F040")]
	private void RefreshScreen()
	{
	}

	// Token: 0x060009A1 RID: 2465 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009A1")]
	[Address(RVA = "0x58F710", Offset = "0x58EB10", VA = "0x1058F710")]
	public SecurityLogGame()
	{
	}

	// Token: 0x040009B5 RID: 2485
	[Token(Token = "0x40009B5")]
	[FieldOffset(Offset = "0x30")]
	private SecurityLogBehaviour Logger;

	// Token: 0x040009B6 RID: 2486
	[Token(Token = "0x40009B6")]
	[FieldOffset(Offset = "0x34")]
	public ObjectPoolBehavior EntryPool;

	// Token: 0x040009B7 RID: 2487
	[Token(Token = "0x40009B7")]
	[FieldOffset(Offset = "0x38")]
	public Scroller scroller;

	// Token: 0x040009B8 RID: 2488
	[Token(Token = "0x40009B8")]
	[FieldOffset(Offset = "0x3C")]
	public float ScreenHeight;

	// Token: 0x040009B9 RID: 2489
	[Token(Token = "0x40009B9")]
	[FieldOffset(Offset = "0x40")]
	public float EntryHeight;

	// Token: 0x040009BA RID: 2490
	[Token(Token = "0x40009BA")]
	[FieldOffset(Offset = "0x44")]
	public Sprite[] LocationBgs;

	// Token: 0x040009BB RID: 2491
	[Token(Token = "0x40009BB")]
	[FieldOffset(Offset = "0x48")]
	public TextMeshPro SabText;
}
