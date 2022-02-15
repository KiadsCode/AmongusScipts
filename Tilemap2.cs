using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000351 RID: 849
[Token(Token = "0x2000351")]
public class Tilemap2 : MonoBehaviour
{
	// Token: 0x06001281 RID: 4737 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001281")]
	[Address(RVA = "0x4AE0B0", Offset = "0x4AD4B0", VA = "0x104AE0B0")]
	internal void SetTile(Vector3Int vec, int tileId)
	{
	}

	// Token: 0x06001282 RID: 4738 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001282")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680")]
	internal void SetTransformMatrix(Vector3Int vec, Matrix4x4 rot90)
	{
	}

	// Token: 0x06001283 RID: 4739 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001283")]
	[Address(RVA = "0x4AE080", Offset = "0x4AD480", VA = "0x104AE080")]
	internal MonoBehaviour GetTile(Vector3Int touchCellPos)
	{
		return null;
	}

	// Token: 0x06001284 RID: 4740 RVA: 0x00006498 File Offset: 0x00004698
	[Token(Token = "0x6001284")]
	[Address(RVA = "0x4AE110", Offset = "0x4AD510", VA = "0x104AE110")]
	internal Vector3Int WorldToCell(Vector2 worldPos)
	{
		return default(Vector3Int);
	}

	// Token: 0x06001285 RID: 4741 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001285")]
	[Address(RVA = "0x4AE1E0", Offset = "0x4AD5E0", VA = "0x104AE1E0")]
	public Tilemap2()
	{
	}

	// Token: 0x040012BC RID: 4796
	[Token(Token = "0x40012BC")]
	[FieldOffset(Offset = "0xC")]
	public Sprite[] sprites;

	// Token: 0x040012BD RID: 4797
	[Token(Token = "0x40012BD")]
	[FieldOffset(Offset = "0x10")]
	private Tile2[] tileData;

	// Token: 0x040012BE RID: 4798
	[Token(Token = "0x40012BE")]
	[FieldOffset(Offset = "0x14")]
	public int Width;

	// Token: 0x040012BF RID: 4799
	[Token(Token = "0x40012BF")]
	[FieldOffset(Offset = "0x18")]
	public int Height;

	// Token: 0x040012C0 RID: 4800
	[Token(Token = "0x40012C0")]
	[FieldOffset(Offset = "0x1C")]
	private bool dirty;
}
