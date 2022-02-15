using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002FB RID: 763
[Token(Token = "0x20002FB")]
public class BoughtAdsBuyable : UnityEngine.Object, IBuyable
{
	// Token: 0x17000279 RID: 633
	// (get) Token: 0x060010C0 RID: 4288 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000279")]
	public string ProdId
	{
		[Token(Token = "0x60010C0")]
		[Address(RVA = "0x829D30", Offset = "0x829130", VA = "0x10829D30", Slot = "4")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700027A RID: 634
	// (get) Token: 0x060010C1 RID: 4289 RVA: 0x00005E20 File Offset: 0x00004020
	[Token(Token = "0x1700027A")]
	public int BeanCost
	{
		[Token(Token = "0x60010C1")]
		[Address(RVA = "0x394F70", Offset = "0x394370", VA = "0x10394F70", Slot = "5")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700027B RID: 635
	// (get) Token: 0x060010C2 RID: 4290 RVA: 0x00005E38 File Offset: 0x00004038
	[Token(Token = "0x1700027B")]
	public int StarCost
	{
		[Token(Token = "0x60010C2")]
		[Address(RVA = "0x394F70", Offset = "0x394370", VA = "0x10394F70", Slot = "6")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700027C RID: 636
	// (get) Token: 0x060010C3 RID: 4291 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700027C")]
	public string EpicId
	{
		[Token(Token = "0x60010C3")]
		[Address(RVA = "0x829D00", Offset = "0x829100", VA = "0x10829D00")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700027D RID: 637
	// (get) Token: 0x060010C4 RID: 4292 RVA: 0x00005E50 File Offset: 0x00004050
	[Token(Token = "0x1700027D")]
	public bool PaidOnMobile
	{
		[Token(Token = "0x60010C4")]
		[Address(RVA = "0x2EDC10", Offset = "0x2ED010", VA = "0x102EDC10", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700027E RID: 638
	// (get) Token: 0x060010C5 RID: 4293 RVA: 0x00005E68 File Offset: 0x00004068
	[Token(Token = "0x1700027E")]
	public LimitedTimeStartEnd LimitedTimeAvailable
	{
		[Token(Token = "0x60010C5")]
		[Address(RVA = "0x3E2CE0", Offset = "0x3E20E0", VA = "0x103E2CE0", Slot = "8")]
		get
		{
			return default(LimitedTimeStartEnd);
		}
	}

	// Token: 0x060010C6 RID: 4294 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010C6")]
	[Address(RVA = "0x829CB0", Offset = "0x8290B0", VA = "0x10829CB0")]
	public BoughtAdsBuyable()
	{
	}
}
