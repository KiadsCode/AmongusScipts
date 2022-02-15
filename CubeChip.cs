using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x0200012E RID: 302
[Token(Token = "0x200012E")]
public class CubeChip : ColorChip
{
	// Token: 0x06000707 RID: 1799 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000707")]
	[Address(RVA = "0x5BC060", Offset = "0x5BB460", VA = "0x105BC060")]
	public void SetUp(Cosmicube cube, int maskLayer)
	{
	}

	// Token: 0x06000708 RID: 1800 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000708")]
	[Address(RVA = "0x3AC2A0", Offset = "0x3AB6A0", VA = "0x103AC2A0")]
	public CubeChip()
	{
	}

	// Token: 0x04000700 RID: 1792
	[Token(Token = "0x4000700")]
	[FieldOffset(Offset = "0x24")]
	public SpriteRenderer image;

	// Token: 0x04000701 RID: 1793
	[Token(Token = "0x4000701")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshPro cubeTitle;

	// Token: 0x04000702 RID: 1794
	[Token(Token = "0x4000702")]
	[FieldOffset(Offset = "0x2C")]
	public TextMeshPro percentCompleteText;

	// Token: 0x04000703 RID: 1795
	[Token(Token = "0x4000703")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshPro podAmount;

	// Token: 0x04000704 RID: 1796
	[Token(Token = "0x4000704")]
	[FieldOffset(Offset = "0x34")]
	public SpriteRenderer ImageMask;

	// Token: 0x04000705 RID: 1797
	[Token(Token = "0x4000705")]
	[FieldOffset(Offset = "0x38")]
	public SpriteRenderer podIcon;
}
