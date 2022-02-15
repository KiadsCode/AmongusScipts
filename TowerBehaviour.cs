using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000053 RID: 83
[Token(Token = "0x2000053")]
public class TowerBehaviour : MonoBehaviour
{
	// Token: 0x0600025A RID: 602 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600025A")]
	[Address(RVA = "0x4B1790", Offset = "0x4B0B90", VA = "0x104B1790")]
	public void Update()
	{
	}

	// Token: 0x0600025B RID: 603 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600025B")]
	[Address(RVA = "0x4B19B0", Offset = "0x4B0DB0", VA = "0x104B19B0")]
	public TowerBehaviour()
	{
	}

	// Token: 0x040001EE RID: 494
	[Token(Token = "0x40001EE")]
	[FieldOffset(Offset = "0xC")]
	public float timer;

	// Token: 0x040001EF RID: 495
	[Token(Token = "0x40001EF")]
	[FieldOffset(Offset = "0x10")]
	public float frameTime;

	// Token: 0x040001F0 RID: 496
	[Token(Token = "0x40001F0")]
	[FieldOffset(Offset = "0x14")]
	public SpriteRenderer circle;

	// Token: 0x040001F1 RID: 497
	[Token(Token = "0x40001F1")]
	[FieldOffset(Offset = "0x18")]
	public SpriteRenderer middle1;

	// Token: 0x040001F2 RID: 498
	[Token(Token = "0x40001F2")]
	[FieldOffset(Offset = "0x1C")]
	public SpriteRenderer middle2;

	// Token: 0x040001F3 RID: 499
	[Token(Token = "0x40001F3")]
	[FieldOffset(Offset = "0x20")]
	public SpriteRenderer outer1;

	// Token: 0x040001F4 RID: 500
	[Token(Token = "0x40001F4")]
	[FieldOffset(Offset = "0x24")]
	public SpriteRenderer outer2;
}
