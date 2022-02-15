using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000162 RID: 354
[Token(Token = "0x2000162")]
public class WireMinigame : Minigame
{
	// Token: 0x06000818 RID: 2072 RVA: 0x00004110 File Offset: 0x00002310
	[Token(Token = "0x6000818")]
	[Address(RVA = "0x3CCA10", Offset = "0x3CBE10", VA = "0x103CCA10")]
	private bool TaskIsForThisPanel()
	{
		return default(bool);
	}

	// Token: 0x06000819 RID: 2073 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000819")]
	[Address(RVA = "0x3CC6A0", Offset = "0x3CBAA0", VA = "0x103CC6A0", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x0600081A RID: 2074 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600081A")]
	[Address(RVA = "0x3CCC70", Offset = "0x3CC070", VA = "0x103CCC70")]
	public void Update()
	{
	}

	// Token: 0x0600081B RID: 2075 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600081B")]
	[Address(RVA = "0x3CCA90", Offset = "0x3CBE90", VA = "0x103CCA90")]
	private void UpdateLights()
	{
	}

	// Token: 0x0600081C RID: 2076 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600081C")]
	[Address(RVA = "0x3CC900", Offset = "0x3CBD00", VA = "0x103CC900")]
	private WireNode CheckRightSide(Vector2 pos)
	{
		return null;
	}

	// Token: 0x0600081D RID: 2077 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600081D")]
	[Address(RVA = "0x3CC990", Offset = "0x3CBD90", VA = "0x103CC990")]
	private void CheckTask()
	{
	}

	// Token: 0x0600081E RID: 2078 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600081E")]
	[Address(RVA = "0x3CDC40", Offset = "0x3CD040", VA = "0x103CDC40")]
	public WireMinigame()
	{
	}

	// Token: 0x04000817 RID: 2071
	[Token(Token = "0x4000817")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Color[] colors;

	// Token: 0x04000818 RID: 2072
	[Token(Token = "0x4000818")]
	[FieldOffset(Offset = "0x30")]
	public Sprite[] Symbols;

	// Token: 0x04000819 RID: 2073
	[Token(Token = "0x4000819")]
	[FieldOffset(Offset = "0x34")]
	public Wire[] LeftNodes;

	// Token: 0x0400081A RID: 2074
	[Token(Token = "0x400081A")]
	[FieldOffset(Offset = "0x38")]
	public WireNode[] RightNodes;

	// Token: 0x0400081B RID: 2075
	[Token(Token = "0x400081B")]
	[FieldOffset(Offset = "0x3C")]
	public SpriteRenderer[] LeftLights;

	// Token: 0x0400081C RID: 2076
	[Token(Token = "0x400081C")]
	[FieldOffset(Offset = "0x40")]
	public SpriteRenderer[] RightLights;

	// Token: 0x0400081D RID: 2077
	[Token(Token = "0x400081D")]
	[FieldOffset(Offset = "0x44")]
	private Controller myController;

	// Token: 0x0400081E RID: 2078
	[Token(Token = "0x400081E")]
	[FieldOffset(Offset = "0x48")]
	private sbyte[] ExpectedWires;

	// Token: 0x0400081F RID: 2079
	[Token(Token = "0x400081F")]
	[FieldOffset(Offset = "0x4C")]
	private sbyte[] ActualWires;

	// Token: 0x04000820 RID: 2080
	[Token(Token = "0x4000820")]
	[FieldOffset(Offset = "0x50")]
	public AudioClip[] WireSounds;

	// Token: 0x04000821 RID: 2081
	[Token(Token = "0x4000821")]
	[FieldOffset(Offset = "0x54")]
	private int prevSelectedWireIndex;

	// Token: 0x04000822 RID: 2082
	[Token(Token = "0x4000822")]
	[FieldOffset(Offset = "0x58")]
	private int selectedWireIndex;

	// Token: 0x04000823 RID: 2083
	[Token(Token = "0x4000823")]
	[FieldOffset(Offset = "0x5C")]
	private bool prevButtonDown;

	// Token: 0x04000824 RID: 2084
	[Token(Token = "0x4000824")]
	[FieldOffset(Offset = "0x60")]
	private float inputCooldown;

	// Token: 0x04000825 RID: 2085
	[Token(Token = "0x4000825")]
	[FieldOffset(Offset = "0x64")]
	public Vector2 controllerWirePos;

	// Token: 0x04000826 RID: 2086
	[Token(Token = "0x4000826")]
	private const float controllerWireSpeed = 7f;

	// Token: 0x04000827 RID: 2087
	[Token(Token = "0x4000827")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject[] selectingWireGlyphs;

	// Token: 0x04000828 RID: 2088
	[Token(Token = "0x4000828")]
	[FieldOffset(Offset = "0x70")]
	public GameObject[] movingWireGlyphs;

	// Token: 0x04000829 RID: 2089
	[Token(Token = "0x4000829")]
	[FieldOffset(Offset = "0x74")]
	public Transform selectedWireUI;
}
