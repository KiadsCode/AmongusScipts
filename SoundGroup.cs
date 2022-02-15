using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000100 RID: 256
[Token(Token = "0x2000100")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x952B0", Offset = "0x946B0")]
public class SoundGroup : ScriptableObject
{
	// Token: 0x06000641 RID: 1601 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000641")]
	[Address(RVA = "0x4A2900", Offset = "0x4A1D00", VA = "0x104A2900")]
	public AudioClip Random()
	{
		return null;
	}

	// Token: 0x06000642 RID: 1602 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000642")]
	[Address(RVA = "0x4A2960", Offset = "0x4A1D60", VA = "0x104A2960")]
	public SoundGroup()
	{
	}

	// Token: 0x0400062F RID: 1583
	[Token(Token = "0x400062F")]
	[FieldOffset(Offset = "0xC")]
	public AudioClip[] Clips;
}
