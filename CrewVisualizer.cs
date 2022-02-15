using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002BC RID: 700
[Token(Token = "0x20002BC")]
public class CrewVisualizer : MonoBehaviour
{
	// Token: 0x06000F8B RID: 3979 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F8B")]
	[Address(RVA = "0x5B94B0", Offset = "0x5B88B0", VA = "0x105B94B0")]
	public void SetCrewSize(int numPlayers, int numImpostors)
	{
	}

	// Token: 0x06000F8C RID: 3980 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F8C")]
	[Address(RVA = "0x5B9850", Offset = "0x5B8C50", VA = "0x105B9850")]
	public void SetMap(int mapid)
	{
	}

	// Token: 0x06000F8D RID: 3981 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F8D")]
	[Address(RVA = "0x5B98A0", Offset = "0x5B8CA0", VA = "0x105B98A0")]
	public CrewVisualizer()
	{
	}

	// Token: 0x04000F60 RID: 3936
	[Token(Token = "0x4000F60")]
	[FieldOffset(Offset = "0xC")]
	public ObjectPoolBehavior CrewPool;

	// Token: 0x04000F61 RID: 3937
	[Token(Token = "0x4000F61")]
	[FieldOffset(Offset = "0x10")]
	public SpriteRenderer Background;

	// Token: 0x04000F62 RID: 3938
	[Token(Token = "0x4000F62")]
	[FieldOffset(Offset = "0x14")]
	public Sprite[] MapBackgrounds;

	// Token: 0x04000F63 RID: 3939
	[Token(Token = "0x4000F63")]
	[FieldOffset(Offset = "0x18")]
	public float yOffset;

	// Token: 0x04000F64 RID: 3940
	[Token(Token = "0x4000F64")]
	[FieldOffset(Offset = "0x1C")]
	public FloatRange BgWidth;
}
