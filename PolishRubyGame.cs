using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200009B RID: 155
[Token(Token = "0x200009B")]
public class PolishRubyGame : Minigame
{
	// Token: 0x060003C6 RID: 966 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003C6")]
	[Address(RVA = "0x50AD20", Offset = "0x50A120", VA = "0x1050AD20")]
	public void Start()
	{
	}

	// Token: 0x060003C7 RID: 967 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003C7")]
	[Address(RVA = "0x50B080", Offset = "0x50A480", VA = "0x1050B080")]
	private void UpdateSpriteColor(bool cursorOverlapsSmudge)
	{
	}

	// Token: 0x060003C8 RID: 968 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003C8")]
	[Address(RVA = "0x50AC70", Offset = "0x50A070", VA = "0x1050AC70")]
	public void PlaySparkleSound()
	{
	}

	// Token: 0x060003C9 RID: 969 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003C9")]
	[Address(RVA = "0x50B120", Offset = "0x50A520", VA = "0x1050B120")]
	public void Update()
	{
	}

	// Token: 0x060003CA RID: 970 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003CA")]
	[Address(RVA = "0x50BD00", Offset = "0x50B100", VA = "0x1050BD00")]
	public PolishRubyGame()
	{
	}

	// Token: 0x040003B3 RID: 947
	[Token(Token = "0x40003B3")]
	[FieldOffset(Offset = "0x30")]
	public PassiveButton[] Buttons;

	// Token: 0x040003B4 RID: 948
	[Token(Token = "0x40003B4")]
	[FieldOffset(Offset = "0x34")]
	public SpriteRenderer[] Sparkles;

	// Token: 0x040003B5 RID: 949
	[Token(Token = "0x40003B5")]
	[FieldOffset(Offset = "0x38")]
	public int[] swipes;

	// Token: 0x040003B6 RID: 950
	[Token(Token = "0x40003B6")]
	[FieldOffset(Offset = "0x3C")]
	public Vector2[] directions;

	// Token: 0x040003B7 RID: 951
	[Token(Token = "0x40003B7")]
	[FieldOffset(Offset = "0x40")]
	public int swipesToClean;

	// Token: 0x040003B8 RID: 952
	[Token(Token = "0x40003B8")]
	[FieldOffset(Offset = "0x44")]
	public AudioClip[] rubSounds;

	// Token: 0x040003B9 RID: 953
	[Token(Token = "0x40003B9")]
	[FieldOffset(Offset = "0x48")]
	public AudioClip sparkleSound;

	// Token: 0x040003BA RID: 954
	[Token(Token = "0x40003BA")]
	[FieldOffset(Offset = "0x4C")]
	public Transform cursorObject;

	// Token: 0x040003BB RID: 955
	[Token(Token = "0x40003BB")]
	[FieldOffset(Offset = "0x50")]
	public Transform handWipeObject;

	// Token: 0x040003BC RID: 956
	[Token(Token = "0x40003BC")]
	[FieldOffset(Offset = "0x54")]
	public SpriteRenderer[] handSprites;

	// Token: 0x040003BD RID: 957
	[Token(Token = "0x40003BD")]
	[FieldOffset(Offset = "0x58")]
	public BoxCollider2D rubyCursorBounds;

	// Token: 0x040003BE RID: 958
	[Token(Token = "0x40003BE")]
	[FieldOffset(Offset = "0x5C")]
	private Controller cont;

	// Token: 0x040003BF RID: 959
	[Token(Token = "0x40003BF")]
	[FieldOffset(Offset = "0x60")]
	private bool oldCursorOverlapsSmudge;

	// Token: 0x0200009C RID: 156
	[Token(Token = "0x200009C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060003CC RID: 972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x060003CD RID: 973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x78D5B0", Offset = "0x78C9B0", VA = "0x1078D5B0")]
		internal void <Start>b__12_0(PassiveButton b)
		{
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00002B98 File Offset: 0x00000D98
		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x799C20", Offset = "0x799020", VA = "0x10799C20")]
		internal bool <Start>b__12_1(PassiveButton t)
		{
			return default(bool);
		}

		// Token: 0x040003C0 RID: 960
		[Token(Token = "0x40003C0")]
		[FieldOffset(Offset = "0x0")]
		public static readonly PolishRubyGame.<>c <>9;

		// Token: 0x040003C1 RID: 961
		[Token(Token = "0x40003C1")]
		[FieldOffset(Offset = "0x4")]
		public static Action<PassiveButton> <>9__12_0;

		// Token: 0x040003C2 RID: 962
		[Token(Token = "0x40003C2")]
		[FieldOffset(Offset = "0x8")]
		public static Func<PassiveButton, bool> <>9__12_1;
	}
}
