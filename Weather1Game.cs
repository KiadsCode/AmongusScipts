using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Tilemaps;

// Token: 0x02000352 RID: 850
[Token(Token = "0x2000352")]
public class Weather1Game : Minigame
{
	// Token: 0x06001286 RID: 4742 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001286")]
	[Address(RVA = "0x7B8CD0", Offset = "0x7B80D0", VA = "0x107B8CD0")]
	public void Start()
	{
	}

	// Token: 0x06001287 RID: 4743 RVA: 0x000064B0 File Offset: 0x000046B0
	[Token(Token = "0x6001287")]
	[Address(RVA = "0x7B8A40", Offset = "0x7B7E40", VA = "0x107B8A40")]
	private bool SolveMaze(Vector3Int curPos, HashSet<Vector3Int> solution)
	{
		return default(bool);
	}

	// Token: 0x06001288 RID: 4744 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001288")]
	[Address(RVA = "0x7B9020", Offset = "0x7B8420", VA = "0x107B9020")]
	public void Update()
	{
	}

	// Token: 0x06001289 RID: 4745 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001289")]
	[Address(RVA = "0x7B8790", Offset = "0x7B7B90", VA = "0x107B8790")]
	private void FillLine(Vector3Int controlTilePos, Vector3Int touchCellPos)
	{
	}

	// Token: 0x0600128A RID: 4746 RVA: 0x000064C8 File Offset: 0x000046C8
	[Token(Token = "0x600128A")]
	[Address(RVA = "0x7B8500", Offset = "0x7B7900", VA = "0x107B8500")]
	private bool AnythingBetween(Vector3Int controlTilePos, Vector3Int touchCellPos)
	{
		return default(bool);
	}

	// Token: 0x0600128B RID: 4747 RVA: 0x000064E0 File Offset: 0x000046E0
	[Token(Token = "0x600128B")]
	[Address(RVA = "0x7B89A0", Offset = "0x7B7DA0", VA = "0x107B89A0")]
	private bool PointIsValid(Vector3Int touchCellPos)
	{
		return default(bool);
	}

	// Token: 0x0600128C RID: 4748 RVA: 0x000064F8 File Offset: 0x000046F8
	[Token(Token = "0x600128C")]
	private bool Contains<T>(T[] self, T item) where T : IComparable
	{
		return default(bool);
	}

	// Token: 0x0600128D RID: 4749 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600128D")]
	[Address(RVA = "0x7B9E90", Offset = "0x7B9290", VA = "0x107B9E90")]
	public Weather1Game()
	{
	}

	// Token: 0x040012C1 RID: 4801
	[Token(Token = "0x40012C1")]
	[FieldOffset(Offset = "0x0")]
	private static int[] BarrierValidX;

	// Token: 0x040012C2 RID: 4802
	[Token(Token = "0x40012C2")]
	[FieldOffset(Offset = "0x4")]
	private static int[] BarrierValidY;

	// Token: 0x040012C3 RID: 4803
	[Token(Token = "0x40012C3")]
	private const int MinX = -10;

	// Token: 0x040012C4 RID: 4804
	[Token(Token = "0x40012C4")]
	private const int MaxX = 8;

	// Token: 0x040012C5 RID: 4805
	[Token(Token = "0x40012C5")]
	private const int MinY = -3;

	// Token: 0x040012C6 RID: 4806
	[Token(Token = "0x40012C6")]
	private const int MaxY = 3;

	// Token: 0x040012C7 RID: 4807
	[Token(Token = "0x40012C7")]
	[FieldOffset(Offset = "0x30")]
	public Tilemap BarrierMap;

	// Token: 0x040012C8 RID: 4808
	[Token(Token = "0x40012C8")]
	[FieldOffset(Offset = "0x34")]
	public Tile fillTile;

	// Token: 0x040012C9 RID: 4809
	[Token(Token = "0x40012C9")]
	[FieldOffset(Offset = "0x38")]
	public Tile controlTile;

	// Token: 0x040012CA RID: 4810
	[Token(Token = "0x40012CA")]
	[FieldOffset(Offset = "0x3C")]
	public Tile barrierTile;

	// Token: 0x040012CB RID: 4811
	[Token(Token = "0x40012CB")]
	[FieldOffset(Offset = "0x40")]
	public SpriteRenderer pulseCircle1;

	// Token: 0x040012CC RID: 4812
	[Token(Token = "0x40012CC")]
	[FieldOffset(Offset = "0x44")]
	public SpriteRenderer pulseCircle2;

	// Token: 0x040012CD RID: 4813
	[Token(Token = "0x40012CD")]
	[FieldOffset(Offset = "0x48")]
	public AudioClip NodeMove;

	// Token: 0x040012CE RID: 4814
	[Token(Token = "0x40012CE")]
	[FieldOffset(Offset = "0x4C")]
	private Controller control;

	// Token: 0x040012CF RID: 4815
	[Token(Token = "0x40012CF")]
	[FieldOffset(Offset = "0x50")]
	private bool inControl;

	// Token: 0x040012D0 RID: 4816
	[Token(Token = "0x40012D0")]
	[FieldOffset(Offset = "0x54")]
	private Vector3Int controlTilePos;

	// Token: 0x040012D1 RID: 4817
	[Token(Token = "0x40012D1")]
	[FieldOffset(Offset = "0x8")]
	private static Vector3Int[] Directions;

	// Token: 0x040012D2 RID: 4818
	[Token(Token = "0x40012D2")]
	[FieldOffset(Offset = "0x60")]
	private float moveCooldown;
}
