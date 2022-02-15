using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000A3 RID: 163
[Token(Token = "0x20000A3")]
public class StowArms : Minigame
{
	// Token: 0x060003F1 RID: 1009 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003F1")]
	[Address(RVA = "0x762B90", Offset = "0x761F90", VA = "0x10762B90", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x17000094 RID: 148
	// (get) Token: 0x060003F2 RID: 1010 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000094")]
	private AudioClip PickupSound
	{
		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x763B70", Offset = "0x762F70", VA = "0x10763B70")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000095 RID: 149
	// (get) Token: 0x060003F3 RID: 1011 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000095")]
	private AudioClip PlaceSound
	{
		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x763BA0", Offset = "0x762FA0", VA = "0x10763BA0")]
		get
		{
			return null;
		}
	}

	// Token: 0x060003F4 RID: 1012 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003F4")]
	[Address(RVA = "0x7635B0", Offset = "0x7629B0", VA = "0x107635B0")]
	public void Update()
	{
	}

	// Token: 0x060003F5 RID: 1013 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003F5")]
	[Address(RVA = "0x762E30", Offset = "0x762230", VA = "0x10762E30")]
	private void DoUpdate(Collider2D[] colliders, DragSlot[] slots)
	{
	}

	// Token: 0x060003F6 RID: 1014 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003F6")]
	[Address(RVA = "0x762CC0", Offset = "0x7620C0", VA = "0x10762CC0")]
	private void CheckForWin(Collider2D[] colliders, DragSlot[] slots)
	{
	}

	// Token: 0x060003F7 RID: 1015 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003F7")]
	[Address(RVA = "0x763B20", Offset = "0x762F20", VA = "0x10763B20")]
	public StowArms()
	{
	}

	// Token: 0x060003F8 RID: 1016 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003F8")]
	[Address(RVA = "0x763550", Offset = "0x762950", VA = "0x10763550")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	internal static void <Update>g__ValidateSelectorActive|21_0(GameObject selector, bool shouldBeActive)
	{
	}

	// Token: 0x04000418 RID: 1048
	[Token(Token = "0x4000418")]
	[FieldOffset(Offset = "0x30")]
	public GameObject GunContent;

	// Token: 0x04000419 RID: 1049
	[Token(Token = "0x4000419")]
	[FieldOffset(Offset = "0x34")]
	public GameObject RifleContent;

	// Token: 0x0400041A RID: 1050
	[Token(Token = "0x400041A")]
	[FieldOffset(Offset = "0x38")]
	public Transform selectorObject;

	// Token: 0x0400041B RID: 1051
	[Token(Token = "0x400041B")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject[] selectorSubobjects;

	// Token: 0x0400041C RID: 1052
	[Token(Token = "0x400041C")]
	[FieldOffset(Offset = "0x40")]
	public SpriteRenderer[] handSprites;

	// Token: 0x0400041D RID: 1053
	[Token(Token = "0x400041D")]
	[FieldOffset(Offset = "0x44")]
	public AudioClip pickupGun;

	// Token: 0x0400041E RID: 1054
	[Token(Token = "0x400041E")]
	[FieldOffset(Offset = "0x48")]
	public AudioClip placeGun;

	// Token: 0x0400041F RID: 1055
	[Token(Token = "0x400041F")]
	[FieldOffset(Offset = "0x4C")]
	public Collider2D[] GunColliders;

	// Token: 0x04000420 RID: 1056
	[Token(Token = "0x4000420")]
	[FieldOffset(Offset = "0x50")]
	public DragSlot[] GunsSlots;

	// Token: 0x04000421 RID: 1057
	[Token(Token = "0x4000421")]
	[FieldOffset(Offset = "0x54")]
	public AudioClip pickupRifle;

	// Token: 0x04000422 RID: 1058
	[Token(Token = "0x4000422")]
	[FieldOffset(Offset = "0x58")]
	public AudioClip placeRifle;

	// Token: 0x04000423 RID: 1059
	[Token(Token = "0x4000423")]
	[FieldOffset(Offset = "0x5C")]
	public Collider2D[] RifleColliders;

	// Token: 0x04000424 RID: 1060
	[Token(Token = "0x4000424")]
	[FieldOffset(Offset = "0x60")]
	public DragSlot[] RifleSlots;

	// Token: 0x04000425 RID: 1061
	[Token(Token = "0x4000425")]
	[FieldOffset(Offset = "0x64")]
	private Controller cont;

	// Token: 0x04000426 RID: 1062
	[Token(Token = "0x4000426")]
	[FieldOffset(Offset = "0x68")]
	private Collider2D currentGrabbedObject;

	// Token: 0x04000427 RID: 1063
	[Token(Token = "0x4000427")]
	[FieldOffset(Offset = "0x6C")]
	private Vector3 grabOffset;
}
