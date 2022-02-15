using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000483 RID: 1155
[Token(Token = "0x2000483")]
public class CounterArea : MonoBehaviour
{
	// Token: 0x0600189C RID: 6300 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600189C")]
	[Address(RVA = "0x8028E0", Offset = "0x801CE0", VA = "0x108028E0")]
	public void UpdateCount(int cnt)
	{
	}

	// Token: 0x0600189D RID: 6301 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600189D")]
	[Address(RVA = "0x802BB0", Offset = "0x801FB0", VA = "0x10802BB0")]
	public CounterArea()
	{
	}

	// Token: 0x040018C6 RID: 6342
	[Token(Token = "0x40018C6")]
	[FieldOffset(Offset = "0xC")]
	public SystemTypes RoomType;

	// Token: 0x040018C7 RID: 6343
	[Token(Token = "0x40018C7")]
	[FieldOffset(Offset = "0x10")]
	public ObjectPoolBehavior pool;

	// Token: 0x040018C8 RID: 6344
	[Token(Token = "0x40018C8")]
	[FieldOffset(Offset = "0x14")]
	private List<PoolableBehavior> myIcons;

	// Token: 0x040018C9 RID: 6345
	[Token(Token = "0x40018C9")]
	[FieldOffset(Offset = "0x18")]
	public float XOffset;

	// Token: 0x040018CA RID: 6346
	[Token(Token = "0x40018CA")]
	[FieldOffset(Offset = "0x1C")]
	public float YOffset;

	// Token: 0x040018CB RID: 6347
	[Token(Token = "0x40018CB")]
	[FieldOffset(Offset = "0x20")]
	public int MaxWidth;
}
