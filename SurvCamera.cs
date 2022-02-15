using System;
using Il2CppDummyDll;
using PowerTools;
using UnityEngine;

// Token: 0x020004BB RID: 1211
[Token(Token = "0x20004BB")]
public class SurvCamera : MonoBehaviour
{
	// Token: 0x060019C4 RID: 6596 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019C4")]
	[Address(RVA = "0x7646C0", Offset = "0x763AC0", VA = "0x107646C0")]
	public void Awake()
	{
	}

	// Token: 0x060019C5 RID: 6597 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019C5")]
	[Address(RVA = "0x764710", Offset = "0x763B10", VA = "0x10764710", Slot = "4")]
	public virtual void SetAnimation(bool on)
	{
	}

	// Token: 0x060019C6 RID: 6598 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019C6")]
	[Address(RVA = "0x764790", Offset = "0x763B90", VA = "0x10764790")]
	public SurvCamera()
	{
	}

	// Token: 0x040019D3 RID: 6611
	[Token(Token = "0x40019D3")]
	[FieldOffset(Offset = "0xC")]
	public string CamName;

	// Token: 0x040019D4 RID: 6612
	[Token(Token = "0x40019D4")]
	[FieldOffset(Offset = "0x10")]
	public StringNames NewName;

	// Token: 0x040019D5 RID: 6613
	[Token(Token = "0x40019D5")]
	[FieldOffset(Offset = "0x14")]
	public SpriteAnim[] Images;

	// Token: 0x040019D6 RID: 6614
	[Token(Token = "0x40019D6")]
	[FieldOffset(Offset = "0x18")]
	public float CamSize;

	// Token: 0x040019D7 RID: 6615
	[Token(Token = "0x40019D7")]
	[FieldOffset(Offset = "0x1C")]
	public float CamAspect;

	// Token: 0x040019D8 RID: 6616
	[Token(Token = "0x40019D8")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 Offset;

	// Token: 0x040019D9 RID: 6617
	[Token(Token = "0x40019D9")]
	[FieldOffset(Offset = "0x2C")]
	public AnimationClip OnAnim;

	// Token: 0x040019DA RID: 6618
	[Token(Token = "0x40019DA")]
	[FieldOffset(Offset = "0x30")]
	public AnimationClip OffAnim;

	// Token: 0x040019DB RID: 6619
	[Token(Token = "0x40019DB")]
	[FieldOffset(Offset = "0x34")]
	public StringNames camNameString;
}
