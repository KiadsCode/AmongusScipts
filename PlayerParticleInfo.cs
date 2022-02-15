using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002A0 RID: 672
[Token(Token = "0x20002A0")]
[Serializable]
public class PlayerParticleInfo
{
	// Token: 0x06000EE4 RID: 3812 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EE4")]
	[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
	public PlayerParticleInfo()
	{
	}

	// Token: 0x04000EEF RID: 3823
	[Token(Token = "0x4000EEF")]
	[FieldOffset(Offset = "0x8")]
	public Sprite image;

	// Token: 0x04000EF0 RID: 3824
	[Token(Token = "0x4000EF0")]
	[FieldOffset(Offset = "0xC")]
	public FloatRange angularVel;

	// Token: 0x04000EF1 RID: 3825
	[Token(Token = "0x4000EF1")]
	[FieldOffset(Offset = "0x10")]
	public bool alignToVel;
}
