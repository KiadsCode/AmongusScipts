using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002FD RID: 765
[Token(Token = "0x20002FD")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x952B0", Offset = "0x946B0")]
public class StarBundle : ScriptableObject, IBuyable
{
	// Token: 0x17000284 RID: 644
	// (get) Token: 0x060010CF RID: 4303 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000284")]
	public string ProdId
	{
		[Token(Token = "0x60010CF")]
		[Address(RVA = "0x273EC0", Offset = "0x2732C0", VA = "0x10273EC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000285 RID: 645
	// (get) Token: 0x060010D0 RID: 4304 RVA: 0x00005EE0 File Offset: 0x000040E0
	[Token(Token = "0x17000285")]
	public int BeanCost
	{
		[Token(Token = "0x60010D0")]
		[Address(RVA = "0x394F70", Offset = "0x394370", VA = "0x10394F70", Slot = "5")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000286 RID: 646
	// (get) Token: 0x060010D1 RID: 4305 RVA: 0x00005EF8 File Offset: 0x000040F8
	[Token(Token = "0x17000286")]
	public int StarCost
	{
		[Token(Token = "0x60010D1")]
		[Address(RVA = "0x394F70", Offset = "0x394370", VA = "0x10394F70", Slot = "6")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000287 RID: 647
	// (get) Token: 0x060010D2 RID: 4306 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000287")]
	public string EpicId
	{
		[Token(Token = "0x60010D2")]
		[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000288 RID: 648
	// (get) Token: 0x060010D3 RID: 4307 RVA: 0x00005F10 File Offset: 0x00004110
	[Token(Token = "0x17000288")]
	public bool PaidOnMobile
	{
		[Token(Token = "0x60010D3")]
		[Address(RVA = "0x2D7E70", Offset = "0x2D7270", VA = "0x102D7E70", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000289 RID: 649
	// (get) Token: 0x060010D4 RID: 4308 RVA: 0x00005F28 File Offset: 0x00004128
	[Token(Token = "0x17000289")]
	public LimitedTimeStartEnd LimitedTimeAvailable
	{
		[Token(Token = "0x60010D4")]
		[Address(RVA = "0x3E2CE0", Offset = "0x3E20E0", VA = "0x103E2CE0", Slot = "8")]
		get
		{
			return default(LimitedTimeStartEnd);
		}
	}

	// Token: 0x060010D5 RID: 4309 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010D5")]
	[Address(RVA = "0x755F80", Offset = "0x755380", VA = "0x10755F80")]
	public string GetItemName()
	{
		return null;
	}

	// Token: 0x060010D6 RID: 4310 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010D6")]
	[Address(RVA = "0x273EA0", Offset = "0x2732A0", VA = "0x10273EA0")]
	public string GetPurchasingProductId()
	{
		return null;
	}

	// Token: 0x060010D7 RID: 4311 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010D7")]
	[Address(RVA = "0x7560B0", Offset = "0x7554B0", VA = "0x107560B0")]
	public StarBundle()
	{
	}

	// Token: 0x0400107F RID: 4223
	[Token(Token = "0x400107F")]
	public const string TranslationPrefix = "Bundle.";

	// Token: 0x04001080 RID: 4224
	[Token(Token = "0x4001080")]
	[FieldOffset(Offset = "0xC")]
	public string epicId;

	// Token: 0x04001081 RID: 4225
	[Token(Token = "0x4001081")]
	[FieldOffset(Offset = "0x10")]
	public string productId;

	// Token: 0x04001082 RID: 4226
	[Token(Token = "0x4001082")]
	[FieldOffset(Offset = "0x14")]
	public string SteamAppId;

	// Token: 0x04001083 RID: 4227
	[Token(Token = "0x4001083")]
	[FieldOffset(Offset = "0x18")]
	public string SteamPrice;

	// Token: 0x04001084 RID: 4228
	[Token(Token = "0x4001084")]
	[FieldOffset(Offset = "0x1C")]
	public float price;

	// Token: 0x04001085 RID: 4229
	[Token(Token = "0x4001085")]
	[FieldOffset(Offset = "0x20")]
	public int starAmount;

	// Token: 0x04001086 RID: 4230
	[Token(Token = "0x4001086")]
	[FieldOffset(Offset = "0x24")]
	public Sprite StoreImage;

	// Token: 0x04001087 RID: 4231
	[Token(Token = "0x4001087")]
	[FieldOffset(Offset = "0x28")]
	public Sprite StoreBackImage;
}
