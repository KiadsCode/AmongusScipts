using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000104 RID: 260
[Token(Token = "0x2000104")]
[Serializable]
public class FontData
{
	// Token: 0x0600064A RID: 1610 RVA: 0x00003A20 File Offset: 0x00001C20
	[Token(Token = "0x600064A")]
	[Address(RVA = "0x3A98A0", Offset = "0x3A8CA0", VA = "0x103A98A0")]
	public float GetKerning(int last, int cur)
	{
		return 0f;
	}

	// Token: 0x0600064B RID: 1611 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600064B")]
	[Address(RVA = "0x3A9940", Offset = "0x3A8D40", VA = "0x103A9940")]
	public FontData()
	{
	}

	// Token: 0x0400063F RID: 1599
	[Token(Token = "0x400063F")]
	[FieldOffset(Offset = "0x8")]
	public Vector2 TextureSize;

	// Token: 0x04000640 RID: 1600
	[Token(Token = "0x4000640")]
	[FieldOffset(Offset = "0x10")]
	public List<Vector4> bounds;

	// Token: 0x04000641 RID: 1601
	[Token(Token = "0x4000641")]
	[FieldOffset(Offset = "0x14")]
	public List<Vector3> offsets;

	// Token: 0x04000642 RID: 1602
	[Token(Token = "0x4000642")]
	[FieldOffset(Offset = "0x18")]
	public List<Vector4> Channels;

	// Token: 0x04000643 RID: 1603
	[Token(Token = "0x4000643")]
	[FieldOffset(Offset = "0x1C")]
	public Dictionary<int, int> charMap;

	// Token: 0x04000644 RID: 1604
	[Token(Token = "0x4000644")]
	[FieldOffset(Offset = "0x20")]
	public float LineHeight;

	// Token: 0x04000645 RID: 1605
	[Token(Token = "0x4000645")]
	[FieldOffset(Offset = "0x24")]
	public Dictionary<int, Dictionary<int, float>> kernings;
}
