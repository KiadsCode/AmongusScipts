using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004CE RID: 1230
[Token(Token = "0x20004CE")]
public class SoundStarter : MonoBehaviour
{
	// Token: 0x06001A33 RID: 6707 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A33")]
	[Address(RVA = "0x4A43A0", Offset = "0x4A37A0", VA = "0x104A43A0")]
	public void Awake()
	{
	}

	// Token: 0x06001A34 RID: 6708 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A34")]
	[Address(RVA = "0x4A4460", Offset = "0x4A3860", VA = "0x104A4460")]
	public SoundStarter()
	{
	}

	// Token: 0x04001A52 RID: 6738
	[Token(Token = "0x4001A52")]
	[FieldOffset(Offset = "0xC")]
	public string Name;

	// Token: 0x04001A53 RID: 6739
	[Token(Token = "0x4001A53")]
	[FieldOffset(Offset = "0x10")]
	public AudioClip SoundToPlay;

	// Token: 0x04001A54 RID: 6740
	[Token(Token = "0x4001A54")]
	[FieldOffset(Offset = "0x14")]
	public bool StopAll;

	// Token: 0x04001A55 RID: 6741
	[Token(Token = "0x4001A55")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "RangeAttribute", RVA = "0xDF920", Offset = "0xDED20")]
	public float Volume;
}
