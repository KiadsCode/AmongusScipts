using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000445 RID: 1093
[Token(Token = "0x2000445")]
public class ShapeshifterMinigame : Minigame
{
	// Token: 0x06001701 RID: 5889 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001701")]
	[Address(RVA = "0x493470", Offset = "0x492870", VA = "0x10493470", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x06001702 RID: 5890 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001702")]
	[Address(RVA = "0x493AC0", Offset = "0x492EC0", VA = "0x10493AC0")]
	private void Shapeshift(PlayerControl player)
	{
	}

	// Token: 0x06001703 RID: 5891 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001703")]
	[Address(RVA = "0x493A50", Offset = "0x492E50", VA = "0x10493A50")]
	private void OnDisable()
	{
	}

	// Token: 0x06001704 RID: 5892 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001704")]
	[Address(RVA = "0x493B80", Offset = "0x492F80", VA = "0x10493B80")]
	public ShapeshifterMinigame()
	{
	}

	// Token: 0x04001749 RID: 5961
	[Token(Token = "0x4001749")]
	[FieldOffset(Offset = "0x30")]
	public ShapeshifterPanel PanelPrefab;

	// Token: 0x0400174A RID: 5962
	[Token(Token = "0x400174A")]
	[FieldOffset(Offset = "0x34")]
	public float XStart;

	// Token: 0x0400174B RID: 5963
	[Token(Token = "0x400174B")]
	[FieldOffset(Offset = "0x38")]
	public float YStart;

	// Token: 0x0400174C RID: 5964
	[Token(Token = "0x400174C")]
	[FieldOffset(Offset = "0x3C")]
	public float XOffset;

	// Token: 0x0400174D RID: 5965
	[Token(Token = "0x400174D")]
	[FieldOffset(Offset = "0x40")]
	public float YOffset;

	// Token: 0x0400174E RID: 5966
	[Token(Token = "0x400174E")]
	[FieldOffset(Offset = "0x44")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xDD8F0", Offset = "0xDCCF0")]
	public UiElement BackButton;

	// Token: 0x0400174F RID: 5967
	[Token(Token = "0x400174F")]
	[FieldOffset(Offset = "0x48")]
	public UiElement DefaultButtonSelected;

	// Token: 0x04001750 RID: 5968
	[Token(Token = "0x4001750")]
	[FieldOffset(Offset = "0x4C")]
	private List<ShapeshifterPanel> potentialVictims;

	// Token: 0x02000446 RID: 1094
	[Token(Token = "0x2000446")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass8_0
	{
		// Token: 0x06001705 RID: 5893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001705")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass8_0()
		{
		}

		// Token: 0x06001706 RID: 5894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001706")]
		[Address(RVA = "0x371820", Offset = "0x370C20", VA = "0x10371820")]
		internal void <Begin>b__0(DeadBody body)
		{
		}

		// Token: 0x06001707 RID: 5895 RVA: 0x000074B8 File Offset: 0x000056B8
		[Token(Token = "0x6001707")]
		[Address(RVA = "0x371870", Offset = "0x370C70", VA = "0x10371870")]
		internal bool <Begin>b__1(PlayerControl p)
		{
			return default(bool);
		}

		// Token: 0x04001751 RID: 5969
		[Token(Token = "0x4001751")]
		[FieldOffset(Offset = "0x8")]
		public List<byte> bodies;

		// Token: 0x04001752 RID: 5970
		[Token(Token = "0x4001752")]
		[FieldOffset(Offset = "0xC")]
		public ShapeshifterMinigame <>4__this;
	}

	// Token: 0x02000447 RID: 1095
	[Token(Token = "0x2000447")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass8_1
	{
		// Token: 0x06001708 RID: 5896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001708")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass8_1()
		{
		}

		// Token: 0x06001709 RID: 5897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001709")]
		[Address(RVA = "0x371A10", Offset = "0x370E10", VA = "0x10371A10")]
		internal void <Begin>b__2()
		{
		}

		// Token: 0x04001753 RID: 5971
		[Token(Token = "0x4001753")]
		[FieldOffset(Offset = "0x8")]
		public PlayerControl player;

		// Token: 0x04001754 RID: 5972
		[Token(Token = "0x4001754")]
		[FieldOffset(Offset = "0xC")]
		public ShapeshifterMinigame.<>c__DisplayClass8_0 CS$<>8__locals1;
	}
}
