using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000336 RID: 822
[Token(Token = "0x2000336")]
public class DoorBreakerGame : Minigame, IDoorMinigame
{
	// Token: 0x060011FC RID: 4604 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011FC")]
	[Address(RVA = "0x2996E0", Offset = "0x298AE0", VA = "0x102996E0", Slot = "8")]
	public void SetDoor(PlainDoor door)
	{
	}

	// Token: 0x060011FD RID: 4605 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011FD")]
	[Address(RVA = "0x5CAEF0", Offset = "0x5CA2F0", VA = "0x105CAEF0")]
	public void Start()
	{
	}

	// Token: 0x060011FE RID: 4606 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011FE")]
	[Address(RVA = "0x5CACA0", Offset = "0x5CA0A0", VA = "0x105CACA0")]
	public void FlipSwitch(SpriteRenderer button)
	{
	}

	// Token: 0x060011FF RID: 4607 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011FF")]
	[Address(RVA = "0x3AC2A0", Offset = "0x3AB6A0", VA = "0x103AC2A0")]
	public DoorBreakerGame()
	{
	}

	// Token: 0x040011EF RID: 4591
	[Token(Token = "0x40011EF")]
	[FieldOffset(Offset = "0x30")]
	public PlainDoor MyDoor;

	// Token: 0x040011F0 RID: 4592
	[Token(Token = "0x40011F0")]
	[FieldOffset(Offset = "0x34")]
	public SpriteRenderer[] Buttons;

	// Token: 0x040011F1 RID: 4593
	[Token(Token = "0x40011F1")]
	[FieldOffset(Offset = "0x38")]
	public AudioClip FlipSound;

	// Token: 0x02000337 RID: 823
	[Token(Token = "0x2000337")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06001201 RID: 4609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001201")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x06001202 RID: 4610 RVA: 0x00006348 File Offset: 0x00004548
		[Token(Token = "0x6001202")]
		[Address(RVA = "0x78D400", Offset = "0x78C800", VA = "0x1078D400")]
		internal bool <FlipSwitch>b__5_0(SpriteRenderer s)
		{
			return default(bool);
		}

		// Token: 0x040011F2 RID: 4594
		[Token(Token = "0x40011F2")]
		[FieldOffset(Offset = "0x0")]
		public static readonly DoorBreakerGame.<>c <>9;

		// Token: 0x040011F3 RID: 4595
		[Token(Token = "0x40011F3")]
		[FieldOffset(Offset = "0x4")]
		public static Func<SpriteRenderer, bool> <>9__5_0;
	}
}
