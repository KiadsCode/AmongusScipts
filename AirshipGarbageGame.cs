using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200007C RID: 124
[Token(Token = "0x200007C")]
public class AirshipGarbageGame : Minigame
{
	// Token: 0x06000329 RID: 809 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000329")]
	[Address(RVA = "0x5446C0", Offset = "0x543AC0", VA = "0x105446C0", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x0600032A RID: 810 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600032A")]
	[Address(RVA = "0x544800", Offset = "0x543C00", VA = "0x10544800")]
	private void Update()
	{
	}

	// Token: 0x0600032B RID: 811 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600032B")]
	[Address(RVA = "0x544D50", Offset = "0x544150", VA = "0x10544D50")]
	public AirshipGarbageGame()
	{
	}

	// Token: 0x040002EB RID: 747
	[Token(Token = "0x40002EB")]
	[FieldOffset(Offset = "0x30")]
	public GarbageCanBehaviour[] GarbagePrefabs;

	// Token: 0x040002EC RID: 748
	[Token(Token = "0x40002EC")]
	[FieldOffset(Offset = "0x34")]
	public Sprite RelaxeHandle;

	// Token: 0x040002ED RID: 749
	[Token(Token = "0x40002ED")]
	[FieldOffset(Offset = "0x38")]
	public Sprite PulledHandle;

	// Token: 0x040002EE RID: 750
	[Token(Token = "0x40002EE")]
	[FieldOffset(Offset = "0x3C")]
	private GarbageCanBehaviour can;

	// Token: 0x040002EF RID: 751
	[Token(Token = "0x40002EF")]
	[FieldOffset(Offset = "0x40")]
	public AudioClip grabSound;

	// Token: 0x040002F0 RID: 752
	[Token(Token = "0x40002F0")]
	[FieldOffset(Offset = "0x44")]
	public Controller controller;

	// Token: 0x040002F1 RID: 753
	[Token(Token = "0x40002F1")]
	[FieldOffset(Offset = "0x48")]
	public Transform handCursorObject;

	// Token: 0x040002F2 RID: 754
	[Token(Token = "0x40002F2")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject waitingHands;

	// Token: 0x040002F3 RID: 755
	[Token(Token = "0x40002F3")]
	[FieldOffset(Offset = "0x50")]
	public GameObject grabbedHands;

	// Token: 0x040002F4 RID: 756
	[Token(Token = "0x40002F4")]
	[FieldOffset(Offset = "0x54")]
	public SpriteRenderer[] handSprites;

	// Token: 0x040002F5 RID: 757
	[Token(Token = "0x40002F5")]
	[FieldOffset(Offset = "0x58")]
	private bool prevHadLeftInput;

	// Token: 0x040002F6 RID: 758
	[Token(Token = "0x40002F6")]
	private const float stickVelocityMagnitude = 6f;
}
