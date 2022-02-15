using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000EC RID: 236
[Token(Token = "0x20000EC")]
public static class PhysicsHelpers
{
	// Token: 0x060005BE RID: 1470 RVA: 0x00003558 File Offset: 0x00001758
	[Token(Token = "0x60005BE")]
	[Address(RVA = "0x65CF60", Offset = "0x65C360", VA = "0x1065CF60")]
	public static bool CircleContains(Vector2 source, float radius, int layerMask)
	{
		return default(bool);
	}

	// Token: 0x060005BF RID: 1471 RVA: 0x00003570 File Offset: 0x00001770
	[Token(Token = "0x60005BF")]
	[Address(RVA = "0x65C7B0", Offset = "0x65BBB0", VA = "0x1065C7B0")]
	public static bool AnyEdgeTriggerBetween(Vector2 source, Vector2 target, int layerMask)
	{
		return default(bool);
	}

	// Token: 0x060005C0 RID: 1472 RVA: 0x00003588 File Offset: 0x00001788
	[Token(Token = "0x60005C0")]
	[Address(RVA = "0x65CE10", Offset = "0x65C210", VA = "0x1065CE10")]
	public static bool AnythingBetween(Vector2 source, Vector2 target, int layerMask, bool useTriggers)
	{
		return default(bool);
	}

	// Token: 0x060005C1 RID: 1473 RVA: 0x000035A0 File Offset: 0x000017A0
	[Token(Token = "0x60005C1")]
	[Address(RVA = "0x65CCE0", Offset = "0x65C0E0", VA = "0x1065CCE0")]
	public static bool AnythingBetween(Collider2D castObject, Vector2 source, Vector2 target, int layerMask, bool useTriggers)
	{
		return default(bool);
	}

	// Token: 0x060005C2 RID: 1474 RVA: 0x000035B8 File Offset: 0x000017B8
	[Token(Token = "0x60005C2")]
	[Address(RVA = "0x65C960", Offset = "0x65BD60", VA = "0x1065C960")]
	public static bool AnyNonTriggersBetween(Vector2 source, Vector2 dirNorm, float mag, int layerMask)
	{
		return default(bool);
	}

	// Token: 0x060005C3 RID: 1475 RVA: 0x000035D0 File Offset: 0x000017D0
	[Token(Token = "0x60005C3")]
	[Address(RVA = "0x65CA70", Offset = "0x65BE70", VA = "0x1065CA70")]
	public static bool AnythingBetween(Vector2 source, Vector2 target, int layerMask, bool useTriggers, Collider2D itemToIgnore, Transform objectToIgnore)
	{
		return default(bool);
	}

	// Token: 0x040005EA RID: 1514
	[Token(Token = "0x40005EA")]
	[FieldOffset(Offset = "0x0")]
	private static Collider2D[] colliderHits;

	// Token: 0x040005EB RID: 1515
	[Token(Token = "0x40005EB")]
	[FieldOffset(Offset = "0x4")]
	private static RaycastHit2D[] castHits;

	// Token: 0x040005EC RID: 1516
	[Token(Token = "0x40005EC")]
	[FieldOffset(Offset = "0x8")]
	private static Vector2 temp;

	// Token: 0x040005ED RID: 1517
	[Token(Token = "0x40005ED")]
	[FieldOffset(Offset = "0x10")]
	private static ContactFilter2D filter;
}
