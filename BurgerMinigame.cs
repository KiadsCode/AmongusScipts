using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000082 RID: 130
[Token(Token = "0x2000082")]
public class BurgerMinigame : Minigame
{
	// Token: 0x0600033D RID: 829 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600033D")]
	[Address(RVA = "0x82A240", Offset = "0x829640", VA = "0x1082A240", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x0600033E RID: 830 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600033E")]
	[Address(RVA = "0x82A640", Offset = "0x829A40", VA = "0x1082A640")]
	private void SelectTopping(BurgerTopping topping)
	{
	}

	// Token: 0x0600033F RID: 831 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600033F")]
	[Address(RVA = "0x82A7A0", Offset = "0x829BA0", VA = "0x1082A7A0")]
	public void Update()
	{
	}

	// Token: 0x06000340 RID: 832 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000340")]
	[Address(RVA = "0x82A780", Offset = "0x829B80", VA = "0x1082A780")]
	public void TogglePaper()
	{
	}

	// Token: 0x06000341 RID: 833 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000341")]
	[Address(RVA = "0x82B8D0", Offset = "0x82ACD0", VA = "0x1082B8D0")]
	public BurgerMinigame()
	{
	}

	// Token: 0x04000309 RID: 777
	[Token(Token = "0x4000309")]
	[FieldOffset(Offset = "0x30")]
	public BurgerTopping Plate;

	// Token: 0x0400030A RID: 778
	[Token(Token = "0x400030A")]
	[FieldOffset(Offset = "0x34")]
	public BurgerTopping[] Toppings;

	// Token: 0x0400030B RID: 779
	[Token(Token = "0x400030B")]
	[FieldOffset(Offset = "0x38")]
	public Sprite[] PaperToppings;

	// Token: 0x0400030C RID: 780
	[Token(Token = "0x400030C")]
	[FieldOffset(Offset = "0x3C")]
	public SpriteRenderer[] PaperSlots;

	// Token: 0x0400030D RID: 781
	[Token(Token = "0x400030D")]
	[FieldOffset(Offset = "0x40")]
	private BurgerToppingTypes[] ExpectedToppings;

	// Token: 0x0400030E RID: 782
	[Token(Token = "0x400030E")]
	[FieldOffset(Offset = "0x44")]
	private Stack<BurgerTopping> burger;

	// Token: 0x0400030F RID: 783
	[Token(Token = "0x400030F")]
	[FieldOffset(Offset = "0x48")]
	private Controller controller;

	// Token: 0x04000310 RID: 784
	[Token(Token = "0x4000310")]
	[FieldOffset(Offset = "0x4C")]
	public Transform Paper;

	// Token: 0x04000311 RID: 785
	[Token(Token = "0x4000311")]
	private const float PaperOpenedY = 0f;

	// Token: 0x04000312 RID: 786
	[Token(Token = "0x4000312")]
	private const float PaperClosedY = 4.8f;

	// Token: 0x04000313 RID: 787
	[Token(Token = "0x4000313")]
	[FieldOffset(Offset = "0x50")]
	private bool PaperClosed;

	// Token: 0x04000314 RID: 788
	[Token(Token = "0x4000314")]
	[FieldOffset(Offset = "0x54")]
	public SpriteRenderer Shadow;

	// Token: 0x04000315 RID: 789
	[Token(Token = "0x4000315")]
	[FieldOffset(Offset = "0x58")]
	public Transform stickCursor;

	// Token: 0x04000316 RID: 790
	[Token(Token = "0x4000316")]
	[FieldOffset(Offset = "0x5C")]
	public SpriteRenderer handSprite;

	// Token: 0x04000317 RID: 791
	[Token(Token = "0x4000317")]
	[FieldOffset(Offset = "0x60")]
	public BoxCollider2D stickSelectionCenterPoint;

	// Token: 0x04000318 RID: 792
	[Token(Token = "0x4000318")]
	[FieldOffset(Offset = "0x64")]
	private Vector3 selectionCenterStart;

	// Token: 0x04000319 RID: 793
	[Token(Token = "0x4000319")]
	[FieldOffset(Offset = "0x70")]
	private BurgerTopping stickSelectedTopping;

	// Token: 0x0400031A RID: 794
	[Token(Token = "0x400031A")]
	[FieldOffset(Offset = "0x74")]
	private bool grabbedTopping;

	// Token: 0x0400031B RID: 795
	[Token(Token = "0x400031B")]
	[FieldOffset(Offset = "0x78")]
	private Vector3 internalCursorPos;

	// Token: 0x0400031C RID: 796
	[Token(Token = "0x400031C")]
	[FieldOffset(Offset = "0x84")]
	public float cursorLerpSpeed;

	// Token: 0x0400031D RID: 797
	[Token(Token = "0x400031D")]
	[FieldOffset(Offset = "0x88")]
	public float cursorHoverLerpSpeed;

	// Token: 0x0400031E RID: 798
	[Token(Token = "0x400031E")]
	[FieldOffset(Offset = "0x8C")]
	private float stackHeight;

	// Token: 0x02000083 RID: 131
	[Token(Token = "0x2000083")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass12_0
	{
		// Token: 0x06000342 RID: 834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000342")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass12_0()
		{
		}

		// Token: 0x06000343 RID: 835 RVA: 0x000029A0 File Offset: 0x00000BA0
		[Token(Token = "0x6000343")]
		[Address(RVA = "0x3CA2C0", Offset = "0x3C96C0", VA = "0x103CA2C0")]
		internal bool <Begin>b__0(BurgerToppingTypes t)
		{
			return default(bool);
		}

		// Token: 0x0400031F RID: 799
		[Token(Token = "0x400031F")]
		[FieldOffset(Offset = "0x8")]
		public BurgerToppingTypes top;
	}

	// Token: 0x02000084 RID: 132
	[Token(Token = "0x2000084")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000345 RID: 837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000345")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x06000346 RID: 838 RVA: 0x000029B8 File Offset: 0x00000BB8
		[Token(Token = "0x6000346")]
		[Address(RVA = "0x3CA2A0", Offset = "0x3C96A0", VA = "0x103CA2A0")]
		internal float <Update>b__24_0(BurgerTopping s)
		{
			return 0f;
		}

		// Token: 0x06000347 RID: 839 RVA: 0x000029D0 File Offset: 0x00000BD0
		[Token(Token = "0x6000347")]
		[Address(RVA = "0x370890", Offset = "0x36FC90", VA = "0x10370890")]
		internal BurgerToppingTypes <Update>b__24_1(BurgerTopping tt)
		{
			return BurgerToppingTypes.TopBun;
		}

		// Token: 0x04000320 RID: 800
		[Token(Token = "0x4000320")]
		[FieldOffset(Offset = "0x0")]
		public static readonly BurgerMinigame.<>c <>9;

		// Token: 0x04000321 RID: 801
		[Token(Token = "0x4000321")]
		[FieldOffset(Offset = "0x4")]
		public static Func<BurgerTopping, float> <>9__24_0;

		// Token: 0x04000322 RID: 802
		[Token(Token = "0x4000322")]
		[FieldOffset(Offset = "0x8")]
		public static Func<BurgerTopping, BurgerToppingTypes> <>9__24_1;
	}
}
