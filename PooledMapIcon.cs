using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000210 RID: 528
[Token(Token = "0x2000210")]
public class PooledMapIcon : PoolableBehavior
{
	// Token: 0x06000BCA RID: 3018 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BCA")]
	[Address(RVA = "0x50D150", Offset = "0x50C550", VA = "0x1050D150")]
	public void Update()
	{
	}

	// Token: 0x06000BCB RID: 3019 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BCB")]
	[Address(RVA = "0x50D0D0", Offset = "0x50C4D0", VA = "0x1050D0D0", Slot = "4")]
	public override void Reset()
	{
	}

	// Token: 0x06000BCC RID: 3020 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BCC")]
	[Address(RVA = "0x50D240", Offset = "0x50C640", VA = "0x1050D240")]
	public PooledMapIcon()
	{
	}

	// Token: 0x04000BCC RID: 3020
	[Token(Token = "0x4000BCC")]
	[FieldOffset(Offset = "0x14")]
	public float NormalSize;

	// Token: 0x04000BCD RID: 3021
	[Token(Token = "0x4000BCD")]
	[FieldOffset(Offset = "0x18")]
	public int lastMapTaskStep;

	// Token: 0x04000BCE RID: 3022
	[Token(Token = "0x4000BCE")]
	[FieldOffset(Offset = "0x1C")]
	public SpriteRenderer rend;

	// Token: 0x04000BCF RID: 3023
	[Token(Token = "0x4000BCF")]
	[FieldOffset(Offset = "0x20")]
	public AlphaPulse alphaPulse;
}
