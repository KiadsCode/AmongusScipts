using System;
using Il2CppDummyDll;
using PowerTools;
using UnityEngine;

// Token: 0x020004AA RID: 1194
[Token(Token = "0x20004AA")]
public class ReactorShipRoom : SkeldShipRoom
{
	// Token: 0x0600195B RID: 6491 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600195B")]
	[Address(RVA = "0x4F1E80", Offset = "0x4F1280", VA = "0x104F1E80")]
	public void StartMeltdown()
	{
	}

	// Token: 0x0600195C RID: 6492 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600195C")]
	[Address(RVA = "0x4F2300", Offset = "0x4F1700", VA = "0x104F2300")]
	public void StopMeltdown()
	{
	}

	// Token: 0x0600195D RID: 6493 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600195D")]
	[Address(RVA = "0x4F2780", Offset = "0x4F1B80", VA = "0x104F2780")]
	public ReactorShipRoom()
	{
	}

	// Token: 0x0400195C RID: 6492
	[Token(Token = "0x400195C")]
	[FieldOffset(Offset = "0x38")]
	public Sprite normalManifolds;

	// Token: 0x0400195D RID: 6493
	[Token(Token = "0x400195D")]
	[FieldOffset(Offset = "0x3C")]
	public Sprite meltdownManifolds;

	// Token: 0x0400195E RID: 6494
	[Token(Token = "0x400195E")]
	[FieldOffset(Offset = "0x40")]
	public SpriteRenderer Manifolds;

	// Token: 0x0400195F RID: 6495
	[Token(Token = "0x400195F")]
	[FieldOffset(Offset = "0x44")]
	public AnimationClip normalReactor;

	// Token: 0x04001960 RID: 6496
	[Token(Token = "0x4001960")]
	[FieldOffset(Offset = "0x48")]
	public AnimationClip meltdownReactor;

	// Token: 0x04001961 RID: 6497
	[Token(Token = "0x4001961")]
	[FieldOffset(Offset = "0x4C")]
	public SpriteAnim Reactor;

	// Token: 0x04001962 RID: 6498
	[Token(Token = "0x4001962")]
	[FieldOffset(Offset = "0x50")]
	public AnimationClip normalHighFloor;

	// Token: 0x04001963 RID: 6499
	[Token(Token = "0x4001963")]
	[FieldOffset(Offset = "0x54")]
	public AnimationClip meltdownHighFloor;

	// Token: 0x04001964 RID: 6500
	[Token(Token = "0x4001964")]
	[FieldOffset(Offset = "0x58")]
	public SpriteAnim HighFloor;

	// Token: 0x04001965 RID: 6501
	[Token(Token = "0x4001965")]
	[FieldOffset(Offset = "0x5C")]
	public AnimationClip normalMidFloor;

	// Token: 0x04001966 RID: 6502
	[Token(Token = "0x4001966")]
	[FieldOffset(Offset = "0x60")]
	public AnimationClip meltdownMidFloor;

	// Token: 0x04001967 RID: 6503
	[Token(Token = "0x4001967")]
	[FieldOffset(Offset = "0x64")]
	public SpriteAnim MidFloor1;

	// Token: 0x04001968 RID: 6504
	[Token(Token = "0x4001968")]
	[FieldOffset(Offset = "0x68")]
	public SpriteAnim MidFloor2;

	// Token: 0x04001969 RID: 6505
	[Token(Token = "0x4001969")]
	[FieldOffset(Offset = "0x6C")]
	public AnimationClip normalLowFloor;

	// Token: 0x0400196A RID: 6506
	[Token(Token = "0x400196A")]
	[FieldOffset(Offset = "0x70")]
	public AnimationClip meltdownLowFloor;

	// Token: 0x0400196B RID: 6507
	[Token(Token = "0x400196B")]
	[FieldOffset(Offset = "0x74")]
	public SpriteAnim LowFloor;

	// Token: 0x0400196C RID: 6508
	[Token(Token = "0x400196C")]
	[FieldOffset(Offset = "0x78")]
	public AnimationClip[] normalPipes;

	// Token: 0x0400196D RID: 6509
	[Token(Token = "0x400196D")]
	[FieldOffset(Offset = "0x7C")]
	public AnimationClip[] meltdownPipes;

	// Token: 0x0400196E RID: 6510
	[Token(Token = "0x400196E")]
	[FieldOffset(Offset = "0x80")]
	public SpriteAnim[] Pipes;

	// Token: 0x0400196F RID: 6511
	[Token(Token = "0x400196F")]
	[FieldOffset(Offset = "0x84")]
	public SupressorBehaviour[] Supressors;

	// Token: 0x04001970 RID: 6512
	[Token(Token = "0x4001970")]
	[FieldOffset(Offset = "0x88")]
	public MeshRenderer Orb;

	// Token: 0x04001971 RID: 6513
	[Token(Token = "0x4001971")]
	[FieldOffset(Offset = "0x8C")]
	public Rotater OrbGlass;

	// Token: 0x04001972 RID: 6514
	[Token(Token = "0x4001972")]
	[FieldOffset(Offset = "0x90")]
	public ChainBehaviour[] Arms;
}
