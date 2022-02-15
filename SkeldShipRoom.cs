using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004B8 RID: 1208
[Token(Token = "0x20004B8")]
public class SkeldShipRoom : PlainShipRoom, IStepWatcher
{
	// Token: 0x170003B9 RID: 953
	// (get) Token: 0x060019B9 RID: 6585 RVA: 0x000081D8 File Offset: 0x000063D8
	[Token(Token = "0x170003B9")]
	public int Priority
	{
		[Token(Token = "0x60019B9")]
		[Address(RVA = "0x2D8D90", Offset = "0x2D8190", VA = "0x102D8D90", Slot = "4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x060019BA RID: 6586 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019BA")]
	[Address(RVA = "0x49ECB0", Offset = "0x49E0B0", VA = "0x1049ECB0")]
	public void Start()
	{
	}

	// Token: 0x060019BB RID: 6587 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019BB")]
	[Address(RVA = "0x49EBD0", Offset = "0x49DFD0", VA = "0x1049EBD0", Slot = "5")]
	public SoundGroup MakeFootstep(PlayerControl player)
	{
		return null;
	}

	// Token: 0x060019BC RID: 6588 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019BC")]
	[Address(RVA = "0x49E920", Offset = "0x49DD20", VA = "0x1049E920")]
	private void GetAmbientSoundVolume(AudioSource player, float dt)
	{
	}

	// Token: 0x060019BD RID: 6589 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019BD")]
	[Address(RVA = "0x49EE60", Offset = "0x49E260", VA = "0x1049EE60")]
	public SkeldShipRoom()
	{
	}

	// Token: 0x060019BE RID: 6590 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019BE")]
	[Address(RVA = "0x49EE40", Offset = "0x49E240", VA = "0x1049EE40")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private void <Start>b__8_0(AudioSource player, float dt)
	{
	}

	// Token: 0x040019C8 RID: 6600
	[Token(Token = "0x40019C8")]
	[FieldOffset(Offset = "0x18")]
	public AudioClip AmbientSound;

	// Token: 0x040019C9 RID: 6601
	[Token(Token = "0x40019C9")]
	[FieldOffset(Offset = "0x1C")]
	public float AmbientVolume;

	// Token: 0x040019CA RID: 6602
	[Token(Token = "0x40019CA")]
	[FieldOffset(Offset = "0x20")]
	public float AmbientMaxDist;

	// Token: 0x040019CB RID: 6603
	[Token(Token = "0x40019CB")]
	[FieldOffset(Offset = "0x24")]
	public Vector2 AmbientOffset;

	// Token: 0x040019CC RID: 6604
	[Token(Token = "0x40019CC")]
	[FieldOffset(Offset = "0x2C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private readonly int <Priority>k__BackingField;

	// Token: 0x040019CD RID: 6605
	[Token(Token = "0x40019CD")]
	[FieldOffset(Offset = "0x30")]
	public SoundGroup FootStepSounds;

	// Token: 0x040019CE RID: 6606
	[Token(Token = "0x40019CE")]
	[FieldOffset(Offset = "0x34")]
	private RaycastHit2D[] volumeBuffer;
}
