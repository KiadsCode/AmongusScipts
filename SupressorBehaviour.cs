using System;
using Il2CppDummyDll;
using PowerTools;
using UnityEngine;

// Token: 0x02000331 RID: 817
[Token(Token = "0x2000331")]
public class SupressorBehaviour : MonoBehaviour
{
	// Token: 0x060011DB RID: 4571 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011DB")]
	[Address(RVA = "0x764600", Offset = "0x763A00", VA = "0x10764600")]
	public void Activate()
	{
	}

	// Token: 0x060011DC RID: 4572 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011DC")]
	[Address(RVA = "0x764660", Offset = "0x763A60", VA = "0x10764660")]
	public void Deactivate()
	{
	}

	// Token: 0x060011DD RID: 4573 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011DD")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public SupressorBehaviour()
	{
	}

	// Token: 0x040011C0 RID: 4544
	[Token(Token = "0x40011C0")]
	[FieldOffset(Offset = "0xC")]
	public Sprite ActiveBase;

	// Token: 0x040011C1 RID: 4545
	[Token(Token = "0x40011C1")]
	[FieldOffset(Offset = "0x10")]
	public Sprite InactiveBase;

	// Token: 0x040011C2 RID: 4546
	[Token(Token = "0x40011C2")]
	[FieldOffset(Offset = "0x14")]
	public SpriteRenderer BaseImage;

	// Token: 0x040011C3 RID: 4547
	[Token(Token = "0x40011C3")]
	[FieldOffset(Offset = "0x18")]
	public AnimationClip ElectricActive;

	// Token: 0x040011C4 RID: 4548
	[Token(Token = "0x40011C4")]
	[FieldOffset(Offset = "0x1C")]
	public AnimationClip ElectricInactive;

	// Token: 0x040011C5 RID: 4549
	[Token(Token = "0x40011C5")]
	[FieldOffset(Offset = "0x20")]
	public SpriteAnim Electric;

	// Token: 0x040011C6 RID: 4550
	[Token(Token = "0x40011C6")]
	[FieldOffset(Offset = "0x24")]
	public AnimationClip LightsActive;

	// Token: 0x040011C7 RID: 4551
	[Token(Token = "0x40011C7")]
	[FieldOffset(Offset = "0x28")]
	public AnimationClip LightsInactive;

	// Token: 0x040011C8 RID: 4552
	[Token(Token = "0x40011C8")]
	[FieldOffset(Offset = "0x2C")]
	public SpriteAnim Lights;
}
