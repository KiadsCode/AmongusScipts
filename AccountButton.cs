using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000003 RID: 3
[Token(Token = "0x2000003")]
public class AccountButton : PoolableBehavior
{
	// Token: 0x06000007 RID: 7 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000007")]
	[Address(RVA = "0x53C790", Offset = "0x53BB90", VA = "0x1053C790")]
	public void SetSelected(bool selected)
	{
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000008")]
	[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00", Slot = "4")]
	public override void Reset()
	{
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000009")]
	[Address(RVA = "0x3AC2A0", Offset = "0x3AB6A0", VA = "0x103AC2A0")]
	public AccountButton()
	{
	}

	// Token: 0x04000003 RID: 3
	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x14")]
	public TextMeshPro Text;

	// Token: 0x04000004 RID: 4
	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x18")]
	public PassiveButton Button;

	// Token: 0x04000005 RID: 5
	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x1C")]
	public SpriteRenderer Background;
}
