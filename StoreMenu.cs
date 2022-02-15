using System;
using System.Collections.Generic;
using Assets.InnerNet;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Purchasing;

// Token: 0x0200030A RID: 778
[Token(Token = "0x200030A")]
public class StoreMenu : DestroyableSingleton<StoreMenu>
{
	// Token: 0x06001102 RID: 4354 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001102")]
	[Address(RVA = "0x75E050", Offset = "0x75D450", VA = "0x1075E050")]
	public void CloseConfirm()
	{
	}

	// Token: 0x06001103 RID: 4355 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001103")]
	[Address(RVA = "0x75E160", Offset = "0x75D560", VA = "0x1075E160")]
	public void CloseWaitModal()
	{
	}

	// Token: 0x06001104 RID: 4356 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001104")]
	[Address(RVA = "0x75E520", Offset = "0x75D920", VA = "0x1075E520")]
	public void DisplayFailed(string error)
	{
	}

	// Token: 0x06001105 RID: 4357 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001105")]
	[Address(RVA = "0x75E550", Offset = "0x75D950", VA = "0x1075E550")]
	public void DisplaySuccess()
	{
	}

	// Token: 0x06001106 RID: 4358 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001106")]
	[Address(RVA = "0x762800", Offset = "0x761C00", VA = "0x10762800")]
	public void UpdateStarDisplay()
	{
	}

	// Token: 0x1700028E RID: 654
	// (get) Token: 0x06001107 RID: 4359 RVA: 0x00005FD0 File Offset: 0x000041D0
	// (set) Token: 0x06001108 RID: 4360 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700028E")]
	public PurchaseStates PurchaseState
	{
		[Token(Token = "0x6001107")]
		[Address(RVA = "0x6D8770", Offset = "0x6D7B70", VA = "0x106D8770")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return PurchaseStates.NotStarted;
		}
		[Token(Token = "0x6001108")]
		[Address(RVA = "0x762B00", Offset = "0x761F00", VA = "0x10762B00")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private set
		{
		}
	}

	// Token: 0x1700028F RID: 655
	// (get) Token: 0x06001109 RID: 4361 RVA: 0x00005FE8 File Offset: 0x000041E8
	[Token(Token = "0x1700028F")]
	public bool Initialized
	{
		[Token(Token = "0x6001109")]
		[Address(RVA = "0x5C1790", Offset = "0x5C0B90", VA = "0x105C1790")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600110A RID: 4362 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600110A")]
	[Address(RVA = "0x762660", Offset = "0x761A60", VA = "0x10762660")]
	public void Start()
	{
	}

	// Token: 0x0600110B RID: 4363 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600110B")]
	[Address(RVA = "0x75FD90", Offset = "0x75F190", VA = "0x1075FD90")]
	public void OpenTab(int index)
	{
	}

	// Token: 0x0600110C RID: 4364 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600110C")]
	[Address(RVA = "0x7612C0", Offset = "0x7606C0", VA = "0x107612C0")]
	public void ShowConfirm(PurchaseButton butt)
	{
	}

	// Token: 0x0600110D RID: 4365 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600110D")]
	[Address(RVA = "0x75E160", Offset = "0x75D560", VA = "0x1075E160")]
	public void StarPurchaseFinished()
	{
	}

	// Token: 0x0600110E RID: 4366 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600110E")]
	[Address(RVA = "0x75E6C0", Offset = "0x75DAC0", VA = "0x1075E6C0")]
	public void Initialize()
	{
	}

	// Token: 0x0600110F RID: 4367 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600110F")]
	[Address(RVA = "0x762880", Offset = "0x761C80", VA = "0x10762880")]
	public void Update()
	{
	}

	// Token: 0x06001110 RID: 4368 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001110")]
	[Address(RVA = "0x760060", Offset = "0x75F460", VA = "0x10760060")]
	public void Open()
	{
	}

	// Token: 0x06001111 RID: 4369 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001111")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680")]
	public void OpenGeneralShop()
	{
	}

	// Token: 0x06001112 RID: 4370 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001112")]
	[Address(RVA = "0x75E400", Offset = "0x75D800", VA = "0x1075E400")]
	private void DestroySliderObjects()
	{
	}

	// Token: 0x06001113 RID: 4371 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001113")]
	[Address(RVA = "0x7602D0", Offset = "0x75F6D0", VA = "0x107602D0")]
	public void PreviewItem(StoreChip storeChip, CosmeticData product)
	{
	}

	// Token: 0x06001114 RID: 4372 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001114")]
	[Address(RVA = "0x7603C0", Offset = "0x75F7C0", VA = "0x107603C0")]
	public void SetProduct(PurchaseButton button)
	{
	}

	// Token: 0x06001115 RID: 4373 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001115")]
	[Address(RVA = "0x75E300", Offset = "0x75D700", VA = "0x1075E300")]
	private void DeselectAllItems()
	{
	}

	// Token: 0x06001116 RID: 4374 RVA: 0x00006000 File Offset: 0x00004200
	[Token(Token = "0x6001116")]
	[Address(RVA = "0x75E5A0", Offset = "0x75D9A0", VA = "0x1075E5A0")]
	public LimitedTimeStartEnd GetCurrentProductLimitedTime()
	{
		return default(LimitedTimeStartEnd);
	}

	// Token: 0x06001117 RID: 4375 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001117")]
	[Address(RVA = "0x75DCA0", Offset = "0x75D0A0", VA = "0x1075DCA0")]
	public void BuyProduct()
	{
	}

	// Token: 0x06001118 RID: 4376 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001118")]
	[Address(RVA = "0x75E190", Offset = "0x75D590", VA = "0x1075E190")]
	public void Close()
	{
	}

	// Token: 0x06001119 RID: 4377 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001119")]
	[Address(RVA = "0x75E110", Offset = "0x75D510", VA = "0x1075E110")]
	public void CloseEntirely()
	{
	}

	// Token: 0x0600111A RID: 4378 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600111A")]
	[Address(RVA = "0x75EE40", Offset = "0x75E240", VA = "0x1075EE40")]
	private void LoadCosmeticData()
	{
	}

	// Token: 0x0600111B RID: 4379 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600111B")]
	[Address(RVA = "0x7617D0", Offset = "0x760BD0", VA = "0x107617D0")]
	private void ShowTab()
	{
	}

	// Token: 0x0600111C RID: 4380 RVA: 0x00006018 File Offset: 0x00004218
	[Token(Token = "0x600111C")]
	[Address(RVA = "0x75DB50", Offset = "0x75CF50", VA = "0x1075DB50")]
	private Vector3 AddProductFromList(Vector3 position, IBuyable[] products, List<PurchaseButton> allBtns, float yOffset)
	{
		return default(Vector3);
	}

	// Token: 0x0600111D RID: 4381 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600111D")]
	[Address(RVA = "0x75E870", Offset = "0x75DC70", VA = "0x1075E870")]
	private PurchaseButton InsertProduct(Vector3 position, IBuyable item)
	{
		return null;
	}

	// Token: 0x0600111E RID: 4382 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600111E")]
	[Address(RVA = "0x75DEC0", Offset = "0x75D2C0", VA = "0x1075DEC0")]
	public void BuyStars()
	{
	}

	// Token: 0x0600111F RID: 4383 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600111F")]
	[Address(RVA = "0x7603A0", Offset = "0x75F7A0", VA = "0x107603A0")]
	public void ResetPurchaseState()
	{
	}

	// Token: 0x06001120 RID: 4384 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001120")]
	[Address(RVA = "0x762A00", Offset = "0x761E00", VA = "0x10762A00")]
	public StoreMenu()
	{
	}

	// Token: 0x06001121 RID: 4385 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001121")]
	[Address(RVA = "0x762700", Offset = "0x761B00", VA = "0x10762700")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private void <BuyProduct>b__90_0(ResponseState cb, Response<ResponsePurchase> response)
	{
	}

	// Token: 0x040010B7 RID: 4279
	[Token(Token = "0x40010B7")]
	private const float MaxItemsPerRow = 4f;

	// Token: 0x040010B8 RID: 4280
	[Token(Token = "0x40010B8")]
	private const float NumRowsVisible = 2f;

	// Token: 0x040010B9 RID: 4281
	[Token(Token = "0x40010B9")]
	private const float DefaultAspectRatio = 1.7777778f;

	// Token: 0x040010BA RID: 4282
	[Token(Token = "0x40010BA")]
	[FieldOffset(Offset = "0x10")]
	private HatBehaviour[] allHats;

	// Token: 0x040010BB RID: 4283
	[Token(Token = "0x40010BB")]
	[FieldOffset(Offset = "0x14")]
	private SkinData[] allSkins;

	// Token: 0x040010BC RID: 4284
	[Token(Token = "0x40010BC")]
	[FieldOffset(Offset = "0x18")]
	private VisorData[] allVisors;

	// Token: 0x040010BD RID: 4285
	[Token(Token = "0x40010BD")]
	[FieldOffset(Offset = "0x1C")]
	private NamePlateData[] allPlates;

	// Token: 0x040010BE RID: 4286
	[Token(Token = "0x40010BE")]
	[FieldOffset(Offset = "0x20")]
	private BundleData[] allBundles;

	// Token: 0x040010BF RID: 4287
	[Token(Token = "0x40010BF")]
	[FieldOffset(Offset = "0x24")]
	private CosmicubeData[] allCubes;

	// Token: 0x040010C0 RID: 4288
	[Token(Token = "0x40010C0")]
	[FieldOffset(Offset = "0x28")]
	private PetData[] allPets;

	// Token: 0x040010C1 RID: 4289
	[Token(Token = "0x40010C1")]
	[FieldOffset(Offset = "0x2C")]
	private StarBundle[] allStars;

	// Token: 0x040010C2 RID: 4290
	[Token(Token = "0x40010C2")]
	[FieldOffset(Offset = "0x30")]
	private Product[] allProducts;

	// Token: 0x040010C3 RID: 4291
	[Token(Token = "0x40010C3")]
	[FieldOffset(Offset = "0x34")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xE6D10", Offset = "0xE6110")]
	public StoreTabButton[] Tabs;

	// Token: 0x040010C4 RID: 4292
	[Token(Token = "0x40010C4")]
	[FieldOffset(Offset = "0x38")]
	public GameObject normalMenu;

	// Token: 0x040010C5 RID: 4293
	[Token(Token = "0x40010C5")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject featuredMenu;

	// Token: 0x040010C6 RID: 4294
	[Token(Token = "0x40010C6")]
	[FieldOffset(Offset = "0x40")]
	public TextMeshPro LoadingText;

	// Token: 0x040010C7 RID: 4295
	[Token(Token = "0x40010C7")]
	[FieldOffset(Offset = "0x44")]
	public TextMeshPro RestorePurchasesButton;

	// Token: 0x040010C8 RID: 4296
	[Token(Token = "0x40010C8")]
	[FieldOffset(Offset = "0x48")]
	public GameObject RestorePurchasesObj;

	// Token: 0x040010C9 RID: 4297
	[Token(Token = "0x40010C9")]
	[FieldOffset(Offset = "0x4C")]
	public UiElement OpenAllInEShopButton;

	// Token: 0x040010CA RID: 4298
	[Token(Token = "0x40010CA")]
	public const string BoughtAdsProductId = "bought_ads";

	// Token: 0x040010CB RID: 4299
	[Token(Token = "0x40010CB")]
	[FieldOffset(Offset = "0x50")]
	public PurchaseButton PurchasablePrefab;

	// Token: 0x040010CC RID: 4300
	[Token(Token = "0x40010CC")]
	[FieldOffset(Offset = "0x54")]
	public TextMeshPro beanAmount;

	// Token: 0x040010CD RID: 4301
	[Token(Token = "0x40010CD")]
	[FieldOffset(Offset = "0x58")]
	public TextMeshPro starAmount;

	// Token: 0x040010CE RID: 4302
	[Token(Token = "0x40010CE")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject comingSoonText;

	// Token: 0x040010CF RID: 4303
	[Token(Token = "0x40010CF")]
	[FieldOffset(Offset = "0x60")]
	public TextMeshPro tabHeader;

	// Token: 0x040010D0 RID: 4304
	[Token(Token = "0x40010D0")]
	[FieldOffset(Offset = "0x64")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xE6D40", Offset = "0xE6140")]
	public PurchasePopUp plsWaitModal;

	// Token: 0x040010D1 RID: 4305
	[Token(Token = "0x40010D1")]
	[FieldOffset(Offset = "0x68")]
	public GameObject playerPreviewArea;

	// Token: 0x040010D2 RID: 4306
	[Token(Token = "0x40010D2")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject confirmMenu;

	// Token: 0x040010D3 RID: 4307
	[Token(Token = "0x40010D3")]
	[FieldOffset(Offset = "0x70")]
	public ControllerButtonBehavior confirmPurchaseButton;

	// Token: 0x040010D4 RID: 4308
	[Token(Token = "0x40010D4")]
	[FieldOffset(Offset = "0x74")]
	public CubeCellPurchaseButton priceButton;

	// Token: 0x040010D5 RID: 4309
	[Token(Token = "0x40010D5")]
	[FieldOffset(Offset = "0x78")]
	public GameObject starConfirmMenu;

	// Token: 0x040010D6 RID: 4310
	[Token(Token = "0x40010D6")]
	[FieldOffset(Offset = "0x7C")]
	public TextMeshPro StarBundleName;

	// Token: 0x040010D7 RID: 4311
	[Token(Token = "0x40010D7")]
	[FieldOffset(Offset = "0x80")]
	public TextMeshPro StarPriceText;

	// Token: 0x040010D8 RID: 4312
	[Token(Token = "0x40010D8")]
	[FieldOffset(Offset = "0x84")]
	public PassiveButton starBuyButton;

	// Token: 0x040010D9 RID: 4313
	[Token(Token = "0x40010D9")]
	[FieldOffset(Offset = "0x88")]
	public TextMeshPro limitedTimeText;

	// Token: 0x040010DA RID: 4314
	[Token(Token = "0x40010DA")]
	[FieldOffset(Offset = "0x8C")]
	public SpriteRenderer starPreviewImage;

	// Token: 0x040010DB RID: 4315
	[Token(Token = "0x40010DB")]
	[FieldOffset(Offset = "0x90")]
	public CosmicubeMenu cosmicubePreviewMenu;

	// Token: 0x040010DC RID: 4316
	[Token(Token = "0x40010DC")]
	[FieldOffset(Offset = "0x94")]
	public PoolablePlayer dressMeUp;

	// Token: 0x040010DD RID: 4317
	[Token(Token = "0x40010DD")]
	[FieldOffset(Offset = "0x98")]
	public TextMeshPro ItemName;

	// Token: 0x040010DE RID: 4318
	[Token(Token = "0x40010DE")]
	[FieldOffset(Offset = "0x9C")]
	public TextMeshPro BundleName;

	// Token: 0x040010DF RID: 4319
	[Token(Token = "0x40010DF")]
	[FieldOffset(Offset = "0xA0")]
	public TextMeshPro CosmicubeName;

	// Token: 0x040010E0 RID: 4320
	[Token(Token = "0x40010E0")]
	[FieldOffset(Offset = "0xA4")]
	public SpriteRenderer PurchaseBackground;

	// Token: 0x040010E1 RID: 4321
	[Token(Token = "0x40010E1")]
	[FieldOffset(Offset = "0xA8")]
	public TextMeshPro PriceText;

	// Token: 0x040010E2 RID: 4322
	[Token(Token = "0x40010E2")]
	[FieldOffset(Offset = "0xAC")]
	public StoreChip PreviewPrefab;

	// Token: 0x040010E3 RID: 4323
	[Token(Token = "0x40010E3")]
	[FieldOffset(Offset = "0xB0")]
	public Scroller ConfirmMenuScroller;

	// Token: 0x040010E4 RID: 4324
	[Token(Token = "0x40010E4")]
	[FieldOffset(Offset = "0xB4")]
	public FloatRange XRange;

	// Token: 0x040010E5 RID: 4325
	[Token(Token = "0x40010E5")]
	[FieldOffset(Offset = "0xB8")]
	public float YStart;

	// Token: 0x040010E6 RID: 4326
	[Token(Token = "0x40010E6")]
	[FieldOffset(Offset = "0xBC")]
	public float YOffset;

	// Token: 0x040010E7 RID: 4327
	[Token(Token = "0x40010E7")]
	[FieldOffset(Offset = "0xC0")]
	public int NumPerRow;

	// Token: 0x040010E8 RID: 4328
	[Token(Token = "0x40010E8")]
	[FieldOffset(Offset = "0xC4")]
	public Vector3 ConfirmCosmeticPosition;

	// Token: 0x040010E9 RID: 4329
	[Token(Token = "0x40010E9")]
	[FieldOffset(Offset = "0xD0")]
	public Sprite starIcon;

	// Token: 0x040010EA RID: 4330
	[Token(Token = "0x40010EA")]
	[FieldOffset(Offset = "0xD4")]
	public Sprite beanIcon;

	// Token: 0x040010EB RID: 4331
	[Token(Token = "0x40010EB")]
	[FieldOffset(Offset = "0xD8")]
	[HideInInspector]
	public List<ColorChip> ColorChips;

	// Token: 0x040010EC RID: 4332
	[Token(Token = "0x40010EC")]
	[FieldOffset(Offset = "0xDC")]
	private int selectedTabIndex;

	// Token: 0x040010ED RID: 4333
	[Token(Token = "0x40010ED")]
	[FieldOffset(Offset = "0xE0")]
	private StoreTabButton selectedTabObject;

	// Token: 0x040010EE RID: 4334
	[Token(Token = "0x40010EE")]
	private const float NormalHeight = -1.95f;

	// Token: 0x040010EF RID: 4335
	[Token(Token = "0x40010EF")]
	private const float BoxHeight = -1.95f;

	// Token: 0x040010F0 RID: 4336
	[Token(Token = "0x40010F0")]
	[FieldOffset(Offset = "0xE4")]
	public TextMeshPro starDisclaimerText;

	// Token: 0x040010F1 RID: 4337
	[Token(Token = "0x40010F1")]
	[FieldOffset(Offset = "0xE8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private PurchaseStates <PurchaseState>k__BackingField;

	// Token: 0x040010F2 RID: 4338
	[Token(Token = "0x40010F2")]
	[FieldOffset(Offset = "0xEC")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xE6D10", Offset = "0xE6110")]
	public Scroller Scroller;

	// Token: 0x040010F3 RID: 4339
	[Token(Token = "0x40010F3")]
	[FieldOffset(Offset = "0xF0")]
	public Scroller FeatureTabScroller;

	// Token: 0x040010F4 RID: 4340
	[Token(Token = "0x40010F4")]
	[FieldOffset(Offset = "0xF4")]
	private PurchaseButton CurrentButton;

	// Token: 0x040010F5 RID: 4341
	[Token(Token = "0x40010F5")]
	[FieldOffset(Offset = "0xF8")]
	private List<GameObject> AllObjects;

	// Token: 0x040010F6 RID: 4342
	[Token(Token = "0x40010F6")]
	[FieldOffset(Offset = "0xFC")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xDD8F0", Offset = "0xDCCF0")]
	private ControllerNavMenu controllerNavMenu;

	// Token: 0x040010F7 RID: 4343
	[Token(Token = "0x40010F7")]
	[FieldOffset(Offset = "0x100")]
	public GameObject glyphL;

	// Token: 0x040010F8 RID: 4344
	[Token(Token = "0x40010F8")]
	[FieldOffset(Offset = "0x104")]
	public GameObject glyphR;

	// Token: 0x040010F9 RID: 4345
	[Token(Token = "0x40010F9")]
	[FieldOffset(Offset = "0x108")]
	private bool initialized;

	// Token: 0x0200030B RID: 779
	[Token(Token = "0x200030B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass87_0
	{
		// Token: 0x06001122 RID: 4386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001122")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass87_0()
		{
		}

		// Token: 0x06001123 RID: 4387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001123")]
		[Address(RVA = "0x371760", Offset = "0x370B60", VA = "0x10371760")]
		internal void <SetProduct>b__0()
		{
		}

		// Token: 0x040010FA RID: 4346
		[Token(Token = "0x40010FA")]
		[FieldOffset(Offset = "0x8")]
		public StoreChip chip;

		// Token: 0x040010FB RID: 4347
		[Token(Token = "0x40010FB")]
		[FieldOffset(Offset = "0xC")]
		public CosmeticData prod;

		// Token: 0x040010FC RID: 4348
		[Token(Token = "0x40010FC")]
		[FieldOffset(Offset = "0x10")]
		public StoreMenu <>4__this;
	}

	// Token: 0x0200030C RID: 780
	[Token(Token = "0x200030C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass87_1
	{
		// Token: 0x06001124 RID: 4388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001124")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass87_1()
		{
		}

		// Token: 0x06001125 RID: 4389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001125")]
		[Address(RVA = "0x371790", Offset = "0x370B90", VA = "0x10371790")]
		internal void <SetProduct>b__1()
		{
		}

		// Token: 0x040010FD RID: 4349
		[Token(Token = "0x40010FD")]
		[FieldOffset(Offset = "0x8")]
		public StoreChip chip;

		// Token: 0x040010FE RID: 4350
		[Token(Token = "0x40010FE")]
		[FieldOffset(Offset = "0xC")]
		public CosmeticData cosmeticData;

		// Token: 0x040010FF RID: 4351
		[Token(Token = "0x40010FF")]
		[FieldOffset(Offset = "0x10")]
		public StoreMenu <>4__this;
	}

	// Token: 0x0200030D RID: 781
	[Token(Token = "0x200030D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06001127 RID: 4391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001127")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x06001128 RID: 4392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001128")]
		[Address(RVA = "0x370160", Offset = "0x36F560", VA = "0x10370160")]
		internal void <DeselectAllItems>b__88_0(ColorChip c)
		{
		}

		// Token: 0x06001129 RID: 4393 RVA: 0x00006030 File Offset: 0x00004230
		[Token(Token = "0x6001129")]
		[Address(RVA = "0x370220", Offset = "0x36F620", VA = "0x10370220")]
		internal bool <LoadCosmeticData>b__93_0(HatBehaviour h)
		{
			return default(bool);
		}

		// Token: 0x0600112A RID: 4394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600112A")]
		[Address(RVA = "0x370320", Offset = "0x36F720", VA = "0x10370320")]
		internal string <LoadCosmeticData>b__93_1(HatBehaviour p)
		{
			return null;
		}

		// Token: 0x0600112B RID: 4395 RVA: 0x00006048 File Offset: 0x00004248
		[Token(Token = "0x600112B")]
		[Address(RVA = "0x370340", Offset = "0x36F740", VA = "0x10370340")]
		internal bool <LoadCosmeticData>b__93_2(SkinData h)
		{
			return default(bool);
		}

		// Token: 0x0600112C RID: 4396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600112C")]
		[Address(RVA = "0x370380", Offset = "0x36F780", VA = "0x10370380")]
		internal string <LoadCosmeticData>b__93_3(SkinData p)
		{
			return null;
		}

		// Token: 0x0600112D RID: 4397 RVA: 0x00006060 File Offset: 0x00004260
		[Token(Token = "0x600112D")]
		[Address(RVA = "0x3703A0", Offset = "0x36F7A0", VA = "0x103703A0")]
		internal bool <LoadCosmeticData>b__93_4(VisorData h)
		{
			return default(bool);
		}

		// Token: 0x0600112E RID: 4398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600112E")]
		[Address(RVA = "0x3703D0", Offset = "0x36F7D0", VA = "0x103703D0")]
		internal string <LoadCosmeticData>b__93_5(VisorData p)
		{
			return null;
		}

		// Token: 0x0600112F RID: 4399 RVA: 0x00006078 File Offset: 0x00004278
		[Token(Token = "0x600112F")]
		[Address(RVA = "0x3703F0", Offset = "0x36F7F0", VA = "0x103703F0")]
		internal bool <LoadCosmeticData>b__93_6(NamePlateData h)
		{
			return default(bool);
		}

		// Token: 0x06001130 RID: 4400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001130")]
		[Address(RVA = "0x3703D0", Offset = "0x36F7D0", VA = "0x103703D0")]
		internal string <LoadCosmeticData>b__93_7(NamePlateData p)
		{
			return null;
		}

		// Token: 0x06001131 RID: 4401 RVA: 0x00006090 File Offset: 0x00004290
		[Token(Token = "0x6001131")]
		[Address(RVA = "0x370420", Offset = "0x36F820", VA = "0x10370420")]
		internal bool <LoadCosmeticData>b__93_8(PetData h)
		{
			return default(bool);
		}

		// Token: 0x06001132 RID: 4402 RVA: 0x000060A8 File Offset: 0x000042A8
		[Token(Token = "0x6001132")]
		[Address(RVA = "0x370450", Offset = "0x36F850", VA = "0x10370450")]
		internal StringNames <LoadCosmeticData>b__93_9(PetData p)
		{
			return StringNames.ExitButton;
		}

		// Token: 0x06001133 RID: 4403 RVA: 0x000060C0 File Offset: 0x000042C0
		[Token(Token = "0x6001133")]
		[Address(RVA = "0x370250", Offset = "0x36F650", VA = "0x10370250")]
		internal bool <LoadCosmeticData>b__93_10(Cosmicube x)
		{
			return default(bool);
		}

		// Token: 0x06001134 RID: 4404 RVA: 0x000060D8 File Offset: 0x000042D8
		[Token(Token = "0x6001134")]
		[Address(RVA = "0x3702A0", Offset = "0x36F6A0", VA = "0x103702A0")]
		internal bool <LoadCosmeticData>b__93_11(Cosmicube h)
		{
			return default(bool);
		}

		// Token: 0x06001135 RID: 4405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001135")]
		[Address(RVA = "0x3702D0", Offset = "0x36F6D0", VA = "0x103702D0")]
		internal string <LoadCosmeticData>b__93_12(Cosmicube p)
		{
			return null;
		}

		// Token: 0x06001136 RID: 4406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001136")]
		[Address(RVA = "0x3700E0", Offset = "0x36F4E0", VA = "0x103700E0")]
		internal CosmicubeData <LoadCosmeticData>b__93_13(Cosmicube c)
		{
			return null;
		}

		// Token: 0x06001137 RID: 4407 RVA: 0x000060F0 File Offset: 0x000042F0
		[Token(Token = "0x6001137")]
		[Address(RVA = "0x3702F0", Offset = "0x36F6F0", VA = "0x103702F0")]
		internal bool <LoadCosmeticData>b__93_14(BundleData h)
		{
			return default(bool);
		}

		// Token: 0x04001100 RID: 4352
		[Token(Token = "0x4001100")]
		[FieldOffset(Offset = "0x0")]
		public static readonly StoreMenu.<>c <>9;

		// Token: 0x04001101 RID: 4353
		[Token(Token = "0x4001101")]
		[FieldOffset(Offset = "0x4")]
		public static Action<ColorChip> <>9__88_0;

		// Token: 0x04001102 RID: 4354
		[Token(Token = "0x4001102")]
		[FieldOffset(Offset = "0x8")]
		public static Func<HatBehaviour, bool> <>9__93_0;

		// Token: 0x04001103 RID: 4355
		[Token(Token = "0x4001103")]
		[FieldOffset(Offset = "0xC")]
		public static Func<HatBehaviour, string> <>9__93_1;

		// Token: 0x04001104 RID: 4356
		[Token(Token = "0x4001104")]
		[FieldOffset(Offset = "0x10")]
		public static Func<SkinData, bool> <>9__93_2;

		// Token: 0x04001105 RID: 4357
		[Token(Token = "0x4001105")]
		[FieldOffset(Offset = "0x14")]
		public static Func<SkinData, string> <>9__93_3;

		// Token: 0x04001106 RID: 4358
		[Token(Token = "0x4001106")]
		[FieldOffset(Offset = "0x18")]
		public static Func<VisorData, bool> <>9__93_4;

		// Token: 0x04001107 RID: 4359
		[Token(Token = "0x4001107")]
		[FieldOffset(Offset = "0x1C")]
		public static Func<VisorData, string> <>9__93_5;

		// Token: 0x04001108 RID: 4360
		[Token(Token = "0x4001108")]
		[FieldOffset(Offset = "0x20")]
		public static Func<NamePlateData, bool> <>9__93_6;

		// Token: 0x04001109 RID: 4361
		[Token(Token = "0x4001109")]
		[FieldOffset(Offset = "0x24")]
		public static Func<NamePlateData, string> <>9__93_7;

		// Token: 0x0400110A RID: 4362
		[Token(Token = "0x400110A")]
		[FieldOffset(Offset = "0x28")]
		public static Func<PetData, bool> <>9__93_8;

		// Token: 0x0400110B RID: 4363
		[Token(Token = "0x400110B")]
		[FieldOffset(Offset = "0x2C")]
		public static Func<PetData, StringNames> <>9__93_9;

		// Token: 0x0400110C RID: 4364
		[Token(Token = "0x400110C")]
		[FieldOffset(Offset = "0x30")]
		public static Func<Cosmicube, bool> <>9__93_10;

		// Token: 0x0400110D RID: 4365
		[Token(Token = "0x400110D")]
		[FieldOffset(Offset = "0x34")]
		public static Func<Cosmicube, bool> <>9__93_11;

		// Token: 0x0400110E RID: 4366
		[Token(Token = "0x400110E")]
		[FieldOffset(Offset = "0x38")]
		public static Func<Cosmicube, string> <>9__93_12;

		// Token: 0x0400110F RID: 4367
		[Token(Token = "0x400110F")]
		[FieldOffset(Offset = "0x3C")]
		public static Func<Cosmicube, CosmicubeData> <>9__93_13;

		// Token: 0x04001110 RID: 4368
		[Token(Token = "0x4001110")]
		[FieldOffset(Offset = "0x40")]
		public static Func<BundleData, bool> <>9__93_14;
	}
}
