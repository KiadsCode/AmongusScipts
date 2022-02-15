using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200033F RID: 831
[Token(Token = "0x200033F")]
public class MonitorOxyMinigame : Minigame
{
	// Token: 0x06001223 RID: 4643 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001223")]
	[Address(RVA = "0x773680", Offset = "0x772A80", VA = "0x10773680", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x06001224 RID: 4644 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001224")]
	[Address(RVA = "0x7738A0", Offset = "0x772CA0", VA = "0x107738A0")]
	public void Update()
	{
	}

	// Token: 0x06001225 RID: 4645 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001225")]
	[Address(RVA = "0x773820", Offset = "0x772C20", VA = "0x10773820", Slot = "5")]
	public override void Close()
	{
	}

	// Token: 0x06001226 RID: 4646 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001226")]
	[Address(RVA = "0x774570", Offset = "0x773970", VA = "0x10774570")]
	public MonitorOxyMinigame()
	{
	}

	// Token: 0x04001238 RID: 4664
	[Token(Token = "0x4001238")]
	[FieldOffset(Offset = "0x30")]
	public SpriteRenderer[] Targets;

	// Token: 0x04001239 RID: 4665
	[Token(Token = "0x4001239")]
	[FieldOffset(Offset = "0x34")]
	public BoxCollider2D[] Sliders;

	// Token: 0x0400123A RID: 4666
	[Token(Token = "0x400123A")]
	[FieldOffset(Offset = "0x38")]
	public VerticalSpriteGauge[] Fills;

	// Token: 0x0400123B RID: 4667
	[Token(Token = "0x400123B")]
	[FieldOffset(Offset = "0x3C")]
	public FloatRange YRange;

	// Token: 0x0400123C RID: 4668
	[Token(Token = "0x400123C")]
	[FieldOffset(Offset = "0x40")]
	public FloatRange[] RandomRanges;

	// Token: 0x0400123D RID: 4669
	[Token(Token = "0x400123D")]
	[FieldOffset(Offset = "0x44")]
	private Controller controller;

	// Token: 0x0400123E RID: 4670
	[Token(Token = "0x400123E")]
	[FieldOffset(Offset = "0x48")]
	public AudioClip[] DragSounds;

	// Token: 0x0400123F RID: 4671
	[Token(Token = "0x400123F")]
	[FieldOffset(Offset = "0x4C")]
	private AudioSource ActiveSound;

	// Token: 0x04001240 RID: 4672
	[Token(Token = "0x4001240")]
	[FieldOffset(Offset = "0x50")]
	public Transform selectorObject;

	// Token: 0x04001241 RID: 4673
	[Token(Token = "0x4001241")]
	[FieldOffset(Offset = "0x54")]
	private TouchpadBehavior touchpad;

	// Token: 0x04001242 RID: 4674
	[Token(Token = "0x4001242")]
	[FieldOffset(Offset = "0x58")]
	private float initialY;

	// Token: 0x04001243 RID: 4675
	[Token(Token = "0x4001243")]
	[FieldOffset(Offset = "0x5C")]
	private int selectedIndex;

	// Token: 0x04001244 RID: 4676
	[Token(Token = "0x4001244")]
	[FieldOffset(Offset = "0x60")]
	private bool prevHadInput;

	// Token: 0x04001245 RID: 4677
	[Token(Token = "0x4001245")]
	[FieldOffset(Offset = "0x64")]
	private float selectCooldown;

	// Token: 0x04001246 RID: 4678
	[Token(Token = "0x4001246")]
	[FieldOffset(Offset = "0x68")]
	private bool isTouchInput;

	// Token: 0x02000340 RID: 832
	[Token(Token = "0x2000340")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06001228 RID: 4648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001228")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x06001229 RID: 4649 RVA: 0x000063A8 File Offset: 0x000045A8
		[Token(Token = "0x6001229")]
		[Address(RVA = "0x799D10", Offset = "0x799110", VA = "0x10799D10")]
		internal bool <Update>b__16_0(BoxCollider2D s)
		{
			return default(bool);
		}

		// Token: 0x0600122A RID: 4650 RVA: 0x000063C0 File Offset: 0x000045C0
		[Token(Token = "0x600122A")]
		[Address(RVA = "0x799D10", Offset = "0x799110", VA = "0x10799D10")]
		internal bool <Update>b__16_1(BoxCollider2D s)
		{
			return default(bool);
		}

		// Token: 0x04001247 RID: 4679
		[Token(Token = "0x4001247")]
		[FieldOffset(Offset = "0x0")]
		public static readonly MonitorOxyMinigame.<>c <>9;

		// Token: 0x04001248 RID: 4680
		[Token(Token = "0x4001248")]
		[FieldOffset(Offset = "0x4")]
		public static Func<BoxCollider2D, bool> <>9__16_0;

		// Token: 0x04001249 RID: 4681
		[Token(Token = "0x4001249")]
		[FieldOffset(Offset = "0x8")]
		public static Func<BoxCollider2D, bool> <>9__16_1;
	}
}
