using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000060 RID: 96
[Token(Token = "0x2000060")]
public class NumberButton : PoolableBehavior
{
	// Token: 0x0600029A RID: 666 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600029A")]
	[Address(RVA = "0x77B010", Offset = "0x77A410", VA = "0x1077B010")]
	public void SetSelected(bool selected)
	{
	}

	// Token: 0x0600029B RID: 667 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600029B")]
	[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00", Slot = "4")]
	public override void Reset()
	{
	}

	// Token: 0x0600029C RID: 668 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600029C")]
	[Address(RVA = "0x77B0A0", Offset = "0x77A4A0", VA = "0x1077B0A0")]
	public NumberButton()
	{
	}

	// Token: 0x0400024A RID: 586
	[Token(Token = "0x400024A")]
	[FieldOffset(Offset = "0x14")]
	public TextMeshPro Text;

	// Token: 0x0400024B RID: 587
	[Token(Token = "0x400024B")]
	[FieldOffset(Offset = "0x18")]
	public PassiveButton Button;

	// Token: 0x0400024C RID: 588
	[Token(Token = "0x400024C")]
	[FieldOffset(Offset = "0x1C")]
	public SpriteRenderer Background;

	// Token: 0x0400024D RID: 589
	[Token(Token = "0x400024D")]
	[FieldOffset(Offset = "0x20")]
	public int monthNum;
}
