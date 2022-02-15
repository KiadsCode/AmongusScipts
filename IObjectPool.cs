using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000E5 RID: 229
[Token(Token = "0x20000E5")]
public abstract class IObjectPool : MonoBehaviour
{
	// Token: 0x060005A0 RID: 1440
	[Token(Token = "0x60005A0")]
	public abstract T Get<T>() where T : PoolableBehavior;

	// Token: 0x060005A1 RID: 1441
	[Token(Token = "0x60005A1")]
	public abstract void Reclaim(PoolableBehavior obj);

	// Token: 0x170000E2 RID: 226
	// (get) Token: 0x060005A2 RID: 1442
	[Token(Token = "0x170000E2")]
	public abstract int InUse { [Token(Token = "0x60005A2")] get; }

	// Token: 0x170000E3 RID: 227
	// (get) Token: 0x060005A3 RID: 1443
	[Token(Token = "0x170000E3")]
	public abstract int NotInUse { [Token(Token = "0x60005A3")] get; }

	// Token: 0x060005A4 RID: 1444 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005A4")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	protected IObjectPool()
	{
	}
}
