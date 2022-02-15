using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004C9 RID: 1225
[Token(Token = "0x20004C9")]
public class DynamicSound : ISoundPlayer
{
	// Token: 0x170003C7 RID: 967
	// (get) Token: 0x06001A0B RID: 6667 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001A0C RID: 6668 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003C7")]
	public string Name
	{
		[Token(Token = "0x6001A0B")]
		[Address(RVA = "0x273EB0", Offset = "0x2732B0", VA = "0x10273EB0", Slot = "4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001A0C")]
		[Address(RVA = "0x273EF0", Offset = "0x2732F0", VA = "0x10273EF0", Slot = "5")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		set
		{
		}
	}

	// Token: 0x170003C8 RID: 968
	// (get) Token: 0x06001A0D RID: 6669 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001A0E RID: 6670 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003C8")]
	public AudioSource Player
	{
		[Token(Token = "0x6001A0D")]
		[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "6")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001A0E")]
		[Address(RVA = "0x273ED0", Offset = "0x2732D0", VA = "0x10273ED0", Slot = "7")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		set
		{
		}
	}

	// Token: 0x06001A0F RID: 6671 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A0F")]
	[Address(RVA = "0x46E6A0", Offset = "0x46DAA0", VA = "0x1046E6A0", Slot = "8")]
	public void Update(float dt)
	{
	}

	// Token: 0x06001A10 RID: 6672 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A10")]
	[Address(RVA = "0x46E640", Offset = "0x46DA40", VA = "0x1046E640")]
	public void SetTarget(AudioClip clip, DynamicSound.GetDynamicsFunction volumeFunc)
	{
	}

	// Token: 0x06001A11 RID: 6673 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A11")]
	[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
	public DynamicSound()
	{
	}

	// Token: 0x04001A3D RID: 6717
	[Token(Token = "0x4001A3D")]
	[FieldOffset(Offset = "0x8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private string <Name>k__BackingField;

	// Token: 0x04001A3E RID: 6718
	[Token(Token = "0x4001A3E")]
	[FieldOffset(Offset = "0xC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private AudioSource <Player>k__BackingField;

	// Token: 0x04001A3F RID: 6719
	[Token(Token = "0x4001A3F")]
	[FieldOffset(Offset = "0x10")]
	public DynamicSound.GetDynamicsFunction volumeFunc;

	// Token: 0x020004CA RID: 1226
	// (Invoke) Token: 0x06001A13 RID: 6675
	[Token(Token = "0x20004CA")]
	public delegate void GetDynamicsFunction(AudioSource source, float dt);
}
