using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004C7 RID: 1223
[Token(Token = "0x20004C7")]
public class CrossFader : ISoundPlayer
{
	// Token: 0x170003C3 RID: 963
	// (get) Token: 0x060019FF RID: 6655 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001A00 RID: 6656 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003C3")]
	public string Name
	{
		[Token(Token = "0x60019FF")]
		[Address(RVA = "0x273EB0", Offset = "0x2732B0", VA = "0x10273EB0", Slot = "4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001A00")]
		[Address(RVA = "0x273EF0", Offset = "0x2732F0", VA = "0x10273EF0", Slot = "5")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		set
		{
		}
	}

	// Token: 0x170003C4 RID: 964
	// (get) Token: 0x06001A01 RID: 6657 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001A02 RID: 6658 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003C4")]
	public AudioSource Player
	{
		[Token(Token = "0x6001A01")]
		[Address(RVA = "0x273EC0", Offset = "0x2732C0", VA = "0x10273EC0", Slot = "6")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001A02")]
		[Address(RVA = "0x273100", Offset = "0x272500", VA = "0x10273100", Slot = "7")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		set
		{
		}
	}

	// Token: 0x06001A03 RID: 6659 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A03")]
	[Address(RVA = "0x5B9C50", Offset = "0x5B9050", VA = "0x105B9C50", Slot = "8")]
	public void Update(float dt)
	{
	}

	// Token: 0x06001A04 RID: 6660 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A04")]
	[Address(RVA = "0x5B9B30", Offset = "0x5B8F30", VA = "0x105B9B30")]
	public void SetTarget(AudioClip clip)
	{
	}

	// Token: 0x06001A05 RID: 6661 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A05")]
	[Address(RVA = "0x5B9DA0", Offset = "0x5B91A0", VA = "0x105B9DA0")]
	public CrossFader()
	{
	}

	// Token: 0x04001A36 RID: 6710
	[Token(Token = "0x4001A36")]
	[FieldOffset(Offset = "0x8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private string <Name>k__BackingField;

	// Token: 0x04001A37 RID: 6711
	[Token(Token = "0x4001A37")]
	[FieldOffset(Offset = "0xC")]
	public float MaxVolume;

	// Token: 0x04001A38 RID: 6712
	[Token(Token = "0x4001A38")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private AudioSource <Player>k__BackingField;

	// Token: 0x04001A39 RID: 6713
	[Token(Token = "0x4001A39")]
	[FieldOffset(Offset = "0x14")]
	public AudioClip target;

	// Token: 0x04001A3A RID: 6714
	[Token(Token = "0x4001A3A")]
	[FieldOffset(Offset = "0x18")]
	public float Duration;

	// Token: 0x04001A3B RID: 6715
	[Token(Token = "0x4001A3B")]
	[FieldOffset(Offset = "0x1C")]
	private float timer;

	// Token: 0x04001A3C RID: 6716
	[Token(Token = "0x4001A3C")]
	[FieldOffset(Offset = "0x20")]
	private bool didSwitch;
}
