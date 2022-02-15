using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000EA RID: 234
[Token(Token = "0x20000EA")]
public class ObjectPoolBehavior : IObjectPool
{
	// Token: 0x170000E4 RID: 228
	// (get) Token: 0x060005B1 RID: 1457 RVA: 0x00003510 File Offset: 0x00001710
	[Token(Token = "0x170000E4")]
	public override int InUse
	{
		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x77CAF0", Offset = "0x77BEF0", VA = "0x1077CAF0", Slot = "6")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170000E5 RID: 229
	// (get) Token: 0x060005B2 RID: 1458 RVA: 0x00003528 File Offset: 0x00001728
	[Token(Token = "0x170000E5")]
	public override int NotInUse
	{
		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x77CB30", Offset = "0x77BF30", VA = "0x1077CB30", Slot = "7")]
		get
		{
			return 0;
		}
	}

	// Token: 0x060005B3 RID: 1459 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005B3")]
	[Address(RVA = "0x77C4A0", Offset = "0x77B8A0", VA = "0x1077C4A0", Slot = "8")]
	public virtual void Awake()
	{
	}

	// Token: 0x060005B4 RID: 1460 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005B4")]
	[Address(RVA = "0x77C5A0", Offset = "0x77B9A0", VA = "0x1077C5A0")]
	public void InitPool(PoolableBehavior prefab)
	{
	}

	// Token: 0x060005B5 RID: 1461 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005B5")]
	[Address(RVA = "0x77C4C0", Offset = "0x77B8C0", VA = "0x1077C4C0")]
	private void CreateOneInactive(PoolableBehavior prefab)
	{
	}

	// Token: 0x060005B6 RID: 1462 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005B6")]
	[Address(RVA = "0x77C740", Offset = "0x77BB40", VA = "0x1077C740")]
	public void ReclaimOldest()
	{
	}

	// Token: 0x060005B7 RID: 1463 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005B7")]
	[Address(RVA = "0x77C6A0", Offset = "0x77BAA0", VA = "0x1077C6A0")]
	public void ReclaimAll()
	{
	}

	// Token: 0x060005B8 RID: 1464 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005B8")]
	public override T Get<T>()
	{
		return null;
	}

	// Token: 0x060005B9 RID: 1465 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005B9")]
	[Address(RVA = "0x77C7C0", Offset = "0x77BBC0", VA = "0x1077C7C0", Slot = "5")]
	public override void Reclaim(PoolableBehavior obj)
	{
	}

	// Token: 0x060005BA RID: 1466 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005BA")]
	[Address(RVA = "0x77CA70", Offset = "0x77BE70", VA = "0x1077CA70")]
	public ObjectPoolBehavior()
	{
	}

	// Token: 0x040005C6 RID: 1478
	[Token(Token = "0x40005C6")]
	[FieldOffset(Offset = "0xC")]
	public int poolSize;

	// Token: 0x040005C7 RID: 1479
	[Token(Token = "0x40005C7")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private List<PoolableBehavior> inactiveChildren;

	// Token: 0x040005C8 RID: 1480
	[Token(Token = "0x40005C8")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public List<PoolableBehavior> activeChildren;

	// Token: 0x040005C9 RID: 1481
	[Token(Token = "0x40005C9")]
	[FieldOffset(Offset = "0x18")]
	public PoolableBehavior Prefab;

	// Token: 0x040005CA RID: 1482
	[Token(Token = "0x40005CA")]
	[FieldOffset(Offset = "0x1C")]
	public bool AutoInit;

	// Token: 0x040005CB RID: 1483
	[Token(Token = "0x40005CB")]
	[FieldOffset(Offset = "0x1D")]
	public bool DetachOnGet;

	// Token: 0x040005CC RID: 1484
	[Token(Token = "0x40005CC")]
	[FieldOffset(Offset = "0x20")]
	private int childIndex;
}
