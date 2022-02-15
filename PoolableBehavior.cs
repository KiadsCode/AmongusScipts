using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000ED RID: 237
[Token(Token = "0x20000ED")]
public class PoolableBehavior : MonoBehaviour
{
	// Token: 0x060005C5 RID: 1477 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005C5")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "4")]
	public virtual void Reset()
	{
	}

	// Token: 0x060005C6 RID: 1478 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005C6")]
	[Address(RVA = "0x50C330", Offset = "0x50B730", VA = "0x1050C330")]
	public void Awake()
	{
	}

	// Token: 0x060005C7 RID: 1479 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005C7")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public PoolableBehavior()
	{
	}

	// Token: 0x040005EE RID: 1518
	[Token(Token = "0x40005EE")]
	[FieldOffset(Offset = "0xC")]
	[HideInInspector]
	public IObjectPool OwnerPool;

	// Token: 0x040005EF RID: 1519
	[Token(Token = "0x40005EF")]
	[FieldOffset(Offset = "0x10")]
	[HideInInspector]
	public int PoolIndex;
}
