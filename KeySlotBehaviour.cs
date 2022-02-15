using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200033E RID: 830
[Token(Token = "0x200033E")]
public class KeySlotBehaviour : MonoBehaviour
{
	// Token: 0x0600121F RID: 4639 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600121F")]
	[Address(RVA = "0x6D5030", Offset = "0x6D4430", VA = "0x106D5030")]
	internal void SetFinished()
	{
	}

	// Token: 0x06001220 RID: 4640 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001220")]
	[Address(RVA = "0x6D50D0", Offset = "0x6D44D0", VA = "0x106D50D0")]
	internal void SetInserted()
	{
	}

	// Token: 0x06001221 RID: 4641 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001221")]
	[Address(RVA = "0x6D50A0", Offset = "0x6D44A0", VA = "0x106D50A0")]
	internal void SetHighlight()
	{
	}

	// Token: 0x06001222 RID: 4642 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001222")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public KeySlotBehaviour()
	{
	}

	// Token: 0x04001233 RID: 4659
	[Token(Token = "0x4001233")]
	[FieldOffset(Offset = "0xC")]
	public Sprite Highlit;

	// Token: 0x04001234 RID: 4660
	[Token(Token = "0x4001234")]
	[FieldOffset(Offset = "0x10")]
	public Sprite Inserted;

	// Token: 0x04001235 RID: 4661
	[Token(Token = "0x4001235")]
	[FieldOffset(Offset = "0x14")]
	public Sprite Finished;

	// Token: 0x04001236 RID: 4662
	[Token(Token = "0x4001236")]
	[FieldOffset(Offset = "0x18")]
	public SpriteRenderer Image;

	// Token: 0x04001237 RID: 4663
	[Token(Token = "0x4001237")]
	[FieldOffset(Offset = "0x1C")]
	public BoxCollider2D Hitbox;
}
