using System;
using Il2CppDummyDll;
using PowerTools;
using UnityEngine;

// Token: 0x020004A9 RID: 1193
[Token(Token = "0x20004A9")]
public class ReactorRoomWire : MonoBehaviour
{
	// Token: 0x06001959 RID: 6489 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001959")]
	[Address(RVA = "0x4F1BC0", Offset = "0x4F0FC0", VA = "0x104F1BC0")]
	public void Update()
	{
	}

	// Token: 0x0600195A RID: 6490 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600195A")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public ReactorRoomWire()
	{
	}

	// Token: 0x04001956 RID: 6486
	[Token(Token = "0x4001956")]
	[FieldOffset(Offset = "0xC")]
	public global::Console myConsole;

	// Token: 0x04001957 RID: 6487
	[Token(Token = "0x4001957")]
	[FieldOffset(Offset = "0x10")]
	public SpriteAnim Image;

	// Token: 0x04001958 RID: 6488
	[Token(Token = "0x4001958")]
	[FieldOffset(Offset = "0x14")]
	public AnimationClip Normal;

	// Token: 0x04001959 RID: 6489
	[Token(Token = "0x4001959")]
	[FieldOffset(Offset = "0x18")]
	public AnimationClip MeltdownNeed;

	// Token: 0x0400195A RID: 6490
	[Token(Token = "0x400195A")]
	[FieldOffset(Offset = "0x1C")]
	public AnimationClip MeltdownReady;

	// Token: 0x0400195B RID: 6491
	[Token(Token = "0x400195B")]
	[FieldOffset(Offset = "0x20")]
	private ReactorSystemType reactor;
}
