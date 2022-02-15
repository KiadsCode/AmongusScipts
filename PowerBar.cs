using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000093 RID: 147
[Token(Token = "0x2000093")]
public class PowerBar : MonoBehaviour
{
	// Token: 0x1700008B RID: 139
	// (get) Token: 0x06000396 RID: 918 RVA: 0x00002AD8 File Offset: 0x00000CD8
	[Token(Token = "0x1700008B")]
	public int NumSegments
	{
		[Token(Token = "0x6000396")]
		[Address(RVA = "0x50D930", Offset = "0x50CD30", VA = "0x1050D930")]
		get
		{
			return 0;
		}
	}

	// Token: 0x06000397 RID: 919 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000397")]
	[Address(RVA = "0x50D5D0", Offset = "0x50C9D0", VA = "0x1050D5D0")]
	public void Awake()
	{
	}

	// Token: 0x06000398 RID: 920 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000398")]
	[Address(RVA = "0x50D7A0", Offset = "0x50CBA0", VA = "0x1050D7A0")]
	public void SetValue(float value)
	{
	}

	// Token: 0x06000399 RID: 921 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000399")]
	[Address(RVA = "0x50D7C0", Offset = "0x50CBC0", VA = "0x1050D7C0")]
	public void Update()
	{
	}

	// Token: 0x0600039A RID: 922 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600039A")]
	[Address(RVA = "0x50D8F0", Offset = "0x50CCF0", VA = "0x1050D8F0")]
	public PowerBar()
	{
	}

	// Token: 0x0400038A RID: 906
	[Token(Token = "0x400038A")]
	[FieldOffset(Offset = "0xC")]
	public SpriteRenderer SegmentPrefab;

	// Token: 0x0400038B RID: 907
	[Token(Token = "0x400038B")]
	[FieldOffset(Offset = "0x10")]
	public Sprite greenImage;

	// Token: 0x0400038C RID: 908
	[Token(Token = "0x400038C")]
	[FieldOffset(Offset = "0x14")]
	public Sprite yellowImage;

	// Token: 0x0400038D RID: 909
	[Token(Token = "0x400038D")]
	[FieldOffset(Offset = "0x18")]
	public Sprite redImage;

	// Token: 0x0400038E RID: 910
	[Token(Token = "0x400038E")]
	[FieldOffset(Offset = "0x1C")]
	public Sprite greenEmptyImage;

	// Token: 0x0400038F RID: 911
	[Token(Token = "0x400038F")]
	[FieldOffset(Offset = "0x20")]
	public Sprite yellowEmptyImage;

	// Token: 0x04000390 RID: 912
	[Token(Token = "0x4000390")]
	[FieldOffset(Offset = "0x24")]
	public Sprite redEmptyImage;

	// Token: 0x04000391 RID: 913
	[Token(Token = "0x4000391")]
	[FieldOffset(Offset = "0x28")]
	public int numberGreen;

	// Token: 0x04000392 RID: 914
	[Token(Token = "0x4000392")]
	[FieldOffset(Offset = "0x2C")]
	public int numberYellow;

	// Token: 0x04000393 RID: 915
	[Token(Token = "0x4000393")]
	[FieldOffset(Offset = "0x30")]
	public int numberRed;

	// Token: 0x04000394 RID: 916
	[Token(Token = "0x4000394")]
	[FieldOffset(Offset = "0x34")]
	public float Width;

	// Token: 0x04000395 RID: 917
	[Token(Token = "0x4000395")]
	[FieldOffset(Offset = "0x38")]
	private float value;

	// Token: 0x04000396 RID: 918
	[Token(Token = "0x4000396")]
	[FieldOffset(Offset = "0x3C")]
	private SpriteRenderer[] Segments;
}
