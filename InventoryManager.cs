using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Assets.InnerNet;
using Epic.OnlineServices.Inventory;
using Epic.OnlineServices.Platform;
using Il2CppDummyDll;
using UnityEngine.Networking;

// Token: 0x0200001D RID: 29
[Token(Token = "0x200001D")]
public class InventoryManager : DestroyableSingleton<InventoryManager>
{
	// Token: 0x06000105 RID: 261 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000105")]
	[Address(RVA = "0x3FB9D0", Offset = "0x3FADD0", VA = "0x103FB9D0")]
	public void AddOutsideStarPurchase(string starPurchase)
	{
	}

	// Token: 0x06000106 RID: 262 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000106")]
	[Address(RVA = "0x3FCC20", Offset = "0x3FC020", VA = "0x103FCC20")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE28D0", Offset = "0xE1CD0")]
	public IEnumerator CoPurchaseItem(string productId, CurrencyTypes currency, Action<ResponseState, Response<ResponsePurchase>> resultCallback)
	{
		return null;
	}

	// Token: 0x06000107 RID: 263 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000107")]
	[Address(RVA = "0x3FDCA0", Offset = "0x3FD0A0", VA = "0x103FDCA0")]
	public void UnlockCubeItem(string productId, string cubeName, Action<ResponseState, Response<ResponsePurchase>> resultCallback)
	{
	}

	// Token: 0x06000108 RID: 264 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000108")]
	[Address(RVA = "0x3FD790", Offset = "0x3FCB90", VA = "0x103FD790")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE2960", Offset = "0xE1D60")]
	private IEnumerator RequestPurchaseCo(Request<RedeemCurrency> requestData, Action<ResponseState, Response<ResponsePurchase>> resultCallback, string productId)
	{
		return null;
	}

	// Token: 0x06000109 RID: 265 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000109")]
	[Address(RVA = "0x3FE010", Offset = "0x3FD410", VA = "0x103FE010")]
	public void ValidatePreviousReceipts()
	{
	}

	// Token: 0x0600010A RID: 266 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600010A")]
	[Address(RVA = "0x3FE380", Offset = "0x3FD780", VA = "0x103FE380")]
	public void WaitForRedemptionCompletion(CompletionToken<PurchaseStates> completionToken)
	{
	}

	// Token: 0x0600010B RID: 267 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600010B")]
	[Address(RVA = "0x3FCDB0", Offset = "0x3FC1B0", VA = "0x103FCDB0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE29F0", Offset = "0xE1DF0")]
	public IEnumerator CoWaitForRedemptionCompletion(CompletionToken<PurchaseStates> completionToken)
	{
		return null;
	}

	// Token: 0x0600010C RID: 268 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600010C")]
	[Address(RVA = "0x3FDEE0", Offset = "0x3FD2E0", VA = "0x103FDEE0")]
	public void ValidateIapReceipt(string receiptData, CompletionToken<PurchaseStates> queryDone)
	{
	}

	// Token: 0x0600010D RID: 269 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600010D")]
	[Address(RVA = "0x3FDF30", Offset = "0x3FD330", VA = "0x103FDF30")]
	public void ValidateIapReceipt(List<string> receiptData, CompletionToken<PurchaseStates> queryDone)
	{
	}

	// Token: 0x0600010E RID: 270 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600010E")]
	[Address(RVA = "0x3FDE00", Offset = "0x3FD200", VA = "0x103FDE00")]
	public void ValidateDlcReceipt(string receiptData, CompletionToken<PurchaseStates> queryDone)
	{
	}

	// Token: 0x0600010F RID: 271 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600010F")]
	[Address(RVA = "0x3FDE50", Offset = "0x3FD250", VA = "0x103FDE50")]
	public void ValidateDlcReceipt(List<string> receiptData, CompletionToken<PurchaseStates> queryDone)
	{
	}

	// Token: 0x06000110 RID: 272 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000110")]
	[Address(RVA = "0x3FDFC0", Offset = "0x3FD3C0", VA = "0x103FDFC0")]
	public void ValidateInnerslothReceipt(string receiptData, CompletionToken<PurchaseStates> queryDone)
	{
	}

	// Token: 0x06000111 RID: 273 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000111")]
	[Address(RVA = "0x3FCD50", Offset = "0x3FC150", VA = "0x103FCD50")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE2A80", Offset = "0xE1E80")]
	public IEnumerator CoValidateTrustedReceipt(string[] productIds, CompletionToken<PurchaseStates> queryDone)
	{
		return null;
	}

	// Token: 0x06000112 RID: 274 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000112")]
	[Address(RVA = "0x3FE130", Offset = "0x3FD530", VA = "0x103FE130")]
	private void ValidateReceiptCall(Request<ValidateReceiptBatch> requestData, CompletionToken<PurchaseStates> queryDone)
	{
	}

	// Token: 0x06000113 RID: 275 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000113")]
	[Address(RVA = "0x3FE230", Offset = "0x3FD630", VA = "0x103FE230")]
	private void ValidateReceiptCall(Request<ValidateReceipt> requestData, CompletionToken<PurchaseStates> queryDone)
	{
	}

	// Token: 0x06000114 RID: 276 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000114")]
	[Address(RVA = "0x3FCCF0", Offset = "0x3FC0F0", VA = "0x103FCCF0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE2B10", Offset = "0xE1F10")]
	private IEnumerator CoValidateReceipt(string requestJson, string requestEndpoint, CompletionToken<PurchaseStates> queryDone)
	{
		return null;
	}

	// Token: 0x06000115 RID: 277 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000115")]
	[Address(RVA = "0x3FCFE0", Offset = "0x3FC3E0", VA = "0x103FCFE0")]
	public void InitSteamMicroTxn(Request<SteamTxnInit> initTxn, CompletionToken<PurchaseStates> queryDone)
	{
	}

	// Token: 0x06000116 RID: 278 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000116")]
	[Address(RVA = "0x3FCE00", Offset = "0x3FC200", VA = "0x103FCE00")]
	public void FinalizeSteamMicroTxn(Request<SteamTxnFin> finTxn, CompletionToken<PurchaseStates> queryDone)
	{
	}

	// Token: 0x06000117 RID: 279 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000117")]
	[Address(RVA = "0x3FCC90", Offset = "0x3FC090", VA = "0x103FCC90")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE2BA0", Offset = "0xE1FA0")]
	private IEnumerator CoSteamPurchaseStars(string requestJson, string requestEndpoint, CompletionToken<PurchaseStates> queryDone)
	{
		return null;
	}

	// Token: 0x06000118 RID: 280 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000118")]
	[Address(RVA = "0x3FCBC0", Offset = "0x3FBFC0", VA = "0x103FCBC0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE2C90", Offset = "0xE2090")]
	public IEnumerator CoFlushConsumableReceipts(Action<ResponseState, string> resultCallback)
	{
		return null;
	}

	// Token: 0x06000119 RID: 281 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000119")]
	[Address(RVA = "0x3FCF00", Offset = "0x3FC300", VA = "0x103FCF00")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE2D10", Offset = "0xE2110")]
	public IEnumerator FlushConsumableReceiptsCo(string requestJson, string requestEndpoint, Action<ResponseState, string> resultCallback)
	{
		return null;
	}

	// Token: 0x17000025 RID: 37
	// (get) Token: 0x0600011A RID: 282 RVA: 0x00002298 File Offset: 0x00000498
	// (set) Token: 0x0600011B RID: 283 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000025")]
	public UpdateState InventoryLoadState
	{
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x277A40", Offset = "0x276E40", VA = "0x10277A40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return UpdateState.Connecting;
		}
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x277A60", Offset = "0x276E60", VA = "0x10277A60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private set
		{
		}
	}

	// Token: 0x17000026 RID: 38
	// (get) Token: 0x0600011C RID: 284 RVA: 0x000022B0 File Offset: 0x000004B0
	// (set) Token: 0x0600011D RID: 285 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000026")]
	public int UnusedBeans
	{
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x287A00", Offset = "0x286E00", VA = "0x10287A00")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600011D")]
		[Address(RVA = "0x287920", Offset = "0x286D20", VA = "0x10287920")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		set
		{
		}
	}

	// Token: 0x17000027 RID: 39
	// (get) Token: 0x0600011E RID: 286 RVA: 0x000022C8 File Offset: 0x000004C8
	// (set) Token: 0x0600011F RID: 287 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000027")]
	public int UnusedStars
	{
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x292AA0", Offset = "0x291EA0", VA = "0x10292AA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600011F")]
		[Address(RVA = "0x292AB0", Offset = "0x291EB0", VA = "0x10292AB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private set
		{
		}
	}

	// Token: 0x06000120 RID: 288 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000120")]
	[Address(RVA = "0x3FD590", Offset = "0x3FC990", VA = "0x103FD590")]
	public void RefreshAll(PlatformInterface platformInterface)
	{
	}

	// Token: 0x06000121 RID: 289 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000121")]
	[Address(RVA = "0x3FD0E0", Offset = "0x3FC4E0", VA = "0x103FD0E0")]
	private void OnInventoryOpenCallback(OnOpenCompleteCallbackInfo data)
	{
	}

	// Token: 0x06000122 RID: 290 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000122")]
	[Address(RVA = "0x3FBB20", Offset = "0x3FAF20", VA = "0x103FBB20")]
	private void CheckBeans(InventoryItem rootItem)
	{
	}

	// Token: 0x06000123 RID: 291 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000123")]
	[Address(RVA = "0x3FC840", Offset = "0x3FBC40", VA = "0x103FC840")]
	private void CheckStars(InventoryItem rootItem)
	{
	}

	// Token: 0x06000124 RID: 292 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000124")]
	[Address(RVA = "0x3FC250", Offset = "0x3FB650", VA = "0x103FC250")]
	private void CheckExpAndLevel(InventoryItem rootItem)
	{
	}

	// Token: 0x06000125 RID: 293 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000125")]
	[Address(RVA = "0x3FC4D0", Offset = "0x3FB8D0", VA = "0x103FC4D0")]
	private void CheckPods(InventoryItem rootItem)
	{
	}

	// Token: 0x06000126 RID: 294 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000126")]
	[Address(RVA = "0x3FC930", Offset = "0x3FBD30", VA = "0x103FC930")]
	private static void CheckUnlockedItems(InventoryItem rootItem, string path)
	{
	}

	// Token: 0x06000127 RID: 295 RVA: 0x000022E0 File Offset: 0x000004E0
	[Token(Token = "0x6000127")]
	[Address(RVA = "0x3FD9F0", Offset = "0x3FCDF0", VA = "0x103FD9F0")]
	private static bool TryFollowPath(InventoryItem rootHandle, string path, out InventoryItem targetHandle)
	{
		return default(bool);
	}

	// Token: 0x06000128 RID: 296 RVA: 0x000022F8 File Offset: 0x000004F8
	[Token(Token = "0x6000128")]
	[Address(RVA = "0x3FCF60", Offset = "0x3FC360", VA = "0x103FCF60")]
	public int GetPodCount(string podType)
	{
		return 0;
	}

	// Token: 0x06000129 RID: 297 RVA: 0x00002310 File Offset: 0x00000510
	[Token(Token = "0x6000129")]
	[Address(RVA = "0x3FBA50", Offset = "0x3FAE50", VA = "0x103FBA50")]
	public int ChangePodCount(string podType, int podDelta)
	{
		return 0;
	}

	// Token: 0x0600012A RID: 298 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600012A")]
	[Address(RVA = "0x3FE330", Offset = "0x3FD730", VA = "0x103FE330")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE2F00", Offset = "0xE2300")]
	public IEnumerator WaitForInventoryLoad()
	{
		return null;
	}

	// Token: 0x0600012B RID: 299 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600012B")]
	[Address(RVA = "0x3FD800", Offset = "0x3FCC00", VA = "0x103FD800")]
	private void ResetInventory()
	{
	}

	// Token: 0x0600012C RID: 300 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600012C")]
	[Address(RVA = "0x3FBBF0", Offset = "0x3FAFF0", VA = "0x103FBBF0")]
	private void CheckEquipped()
	{
	}

	// Token: 0x0600012D RID: 301 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600012D")]
	[Address(RVA = "0x3FDDB0", Offset = "0x3FD1B0", VA = "0x103FDDB0")]
	public void UpdateStarCount(int starsToAdd)
	{
	}

	// Token: 0x0600012E RID: 302 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600012E")]
	[Address(RVA = "0x3FE6A0", Offset = "0x3FDAA0", VA = "0x103FE6A0")]
	public InventoryManager()
	{
	}

	// Token: 0x06000130 RID: 304 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000130")]
	[Address(RVA = "0x3FDB80", Offset = "0x3FCF80", VA = "0x103FDB80")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private void <ValidatePreviousReceipts>b__5_0()
	{
	}

	// Token: 0x040000C0 RID: 192
	[Token(Token = "0x40000C0")]
	[FieldOffset(Offset = "0x10")]
	private List<string> outsideStarPurchases;

	// Token: 0x040000C1 RID: 193
	[Token(Token = "0x40000C1")]
	[FieldOffset(Offset = "0x14")]
	private InventoryInterface inventoryInterface;

	// Token: 0x040000C2 RID: 194
	[Token(Token = "0x40000C2")]
	private const string InventoryName = "profile";

	// Token: 0x040000C3 RID: 195
	[Token(Token = "0x40000C3")]
	private const string PodsFolder = "pods";

	// Token: 0x040000C4 RID: 196
	[Token(Token = "0x40000C4")]
	private const string PlayerXpPath = "player/xp";

	// Token: 0x040000C5 RID: 197
	[Token(Token = "0x40000C5")]
	private const string PlayerRequiredXpPath = "player/xp_required_for_next_level";

	// Token: 0x040000C6 RID: 198
	[Token(Token = "0x40000C6")]
	private const string PlayerLevelPath = "player/level";

	// Token: 0x040000C7 RID: 199
	[Token(Token = "0x40000C7")]
	private const string StarsPath = "stars/normal";

	// Token: 0x040000C8 RID: 200
	[Token(Token = "0x40000C8")]
	private const string StarsSwitchPath = "stars/switch";

	// Token: 0x040000C9 RID: 201
	[Token(Token = "0x40000C9")]
	private const string BeansPath = "beans/normal";

	// Token: 0x040000CA RID: 202
	[Token(Token = "0x40000CA")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string[] AllItemContainers;

	// Token: 0x040000CB RID: 203
	[Token(Token = "0x40000CB")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<string, int> podCounts;

	// Token: 0x040000CC RID: 204
	[Token(Token = "0x40000CC")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private UpdateState <InventoryLoadState>k__BackingField;

	// Token: 0x040000CD RID: 205
	[Token(Token = "0x40000CD")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private int <UnusedBeans>k__BackingField;

	// Token: 0x040000CE RID: 206
	[Token(Token = "0x40000CE")]
	[FieldOffset(Offset = "0x24")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private int <UnusedStars>k__BackingField;

	// Token: 0x0200001E RID: 30
	[Token(Token = "0x200001E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoPurchaseItem>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000131 RID: 305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000131")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoPurchaseItem>d__2(int <>1__state)
		{
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000132")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00002328 File Offset: 0x00000528
		[Token(Token = "0x6000133")]
		[Address(RVA = "0x5ABAB0", Offset = "0x5AAEB0", VA = "0x105ABAB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000134 RID: 308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000028")]
		private object Current
		{
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000135")]
		[Address(RVA = "0x5ABB20", Offset = "0x5AAF20", VA = "0x105ABB20", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000136 RID: 310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000029")]
		private object Current
		{
			[Token(Token = "0x6000136")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040000CF RID: 207
		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040000D0 RID: 208
		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040000D1 RID: 209
		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0x10")]
		public InventoryManager <>4__this;

		// Token: 0x040000D2 RID: 210
		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0x14")]
		public string productId;

		// Token: 0x040000D3 RID: 211
		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x18")]
		public CurrencyTypes currency;

		// Token: 0x040000D4 RID: 212
		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x1C")]
		public Action<ResponseState, Response<ResponsePurchase>> resultCallback;
	}

	// Token: 0x0200001F RID: 31
	[Token(Token = "0x200001F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass3_0
	{
		// Token: 0x06000137 RID: 311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass3_0()
		{
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x5B57C0", Offset = "0x5B4BC0", VA = "0x105B57C0")]
		internal void <UnlockCubeItem>b__0(ResponseState cb, Response<ResponsePurchase> response)
		{
		}

		// Token: 0x040000D5 RID: 213
		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x8")]
		public Action<ResponseState, Response<ResponsePurchase>> resultCallback;

		// Token: 0x040000D6 RID: 214
		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0xC")]
		public string productId;
	}

	// Token: 0x02000020 RID: 32
	[Token(Token = "0x2000020")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x0600013A RID: 314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x5B4790", Offset = "0x5B3B90", VA = "0x105B4790")]
		internal string <RequestPurchaseCo>b__4_0(ResponseError s)
		{
			return null;
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x5B4DC0", Offset = "0x5B41C0", VA = "0x105B4DC0")]
		internal void <ValidatePreviousReceipts>b__5_1()
		{
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x5B4790", Offset = "0x5B3B90", VA = "0x105B4790")]
		internal string <CoValidateReceipt>b__16_0(ResponseError s)
		{
			return null;
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00002340 File Offset: 0x00000540
		[Token(Token = "0x600013E")]
		[Address(RVA = "0x5B47C0", Offset = "0x5B3BC0", VA = "0x105B47C0")]
		internal bool <CoValidateReceipt>b__16_1(ResponseError x)
		{
			return default(bool);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00002358 File Offset: 0x00000558
		[Token(Token = "0x600013F")]
		[Address(RVA = "0x5B47C0", Offset = "0x5B3BC0", VA = "0x105B47C0")]
		internal bool <CoValidateReceipt>b__16_2(ResponseError x)
		{
			return default(bool);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000140")]
		[Address(RVA = "0x5B4790", Offset = "0x5B3B90", VA = "0x105B4790")]
		internal string <CoSteamPurchaseStars>b__19_0(ResponseError s)
		{
			return null;
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000141")]
		[Address(RVA = "0x5B4AE0", Offset = "0x5B3EE0", VA = "0x105B4AE0")]
		internal void <OnInventoryOpenCallback>b__46_0(OnCloseCompleteCallbackInfo _)
		{
		}

		// Token: 0x040000D7 RID: 215
		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0x0")]
		public static readonly InventoryManager.<>c <>9;

		// Token: 0x040000D8 RID: 216
		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0x4")]
		public static Func<ResponseError, string> <>9__4_0;

		// Token: 0x040000D9 RID: 217
		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0x8")]
		public static Action <>9__5_1;

		// Token: 0x040000DA RID: 218
		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0xC")]
		public static Func<ResponseError, string> <>9__16_0;

		// Token: 0x040000DB RID: 219
		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x10")]
		public static Func<ResponseError, bool> <>9__16_1;

		// Token: 0x040000DC RID: 220
		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0x14")]
		public static Func<ResponseError, bool> <>9__16_2;

		// Token: 0x040000DD RID: 221
		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0x18")]
		public static Func<ResponseError, string> <>9__19_0;

		// Token: 0x040000DE RID: 222
		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0x1C")]
		public static OnCloseCompleteCallback <>9__46_0;
	}

	// Token: 0x02000021 RID: 33
	[Token(Token = "0x2000021")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <RequestPurchaseCo>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000142 RID: 322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <RequestPurchaseCo>d__4(int <>1__state)
		{
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00002370 File Offset: 0x00000570
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x5B3010", Offset = "0x5B2410", VA = "0x105B3010", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000145 RID: 325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002A")]
		private object Current
		{
			[Token(Token = "0x6000145")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x5B38D0", Offset = "0x5B2CD0", VA = "0x105B38D0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000147 RID: 327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002B")]
		private object Current
		{
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040000DF RID: 223
		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040000E0 RID: 224
		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040000E1 RID: 225
		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0x10")]
		public Request<RedeemCurrency> requestData;

		// Token: 0x040000E2 RID: 226
		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x14")]
		public Action<ResponseState, Response<ResponsePurchase>> resultCallback;

		// Token: 0x040000E3 RID: 227
		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x18")]
		public InventoryManager <>4__this;

		// Token: 0x040000E4 RID: 228
		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x1C")]
		public string productId;

		// Token: 0x040000E5 RID: 229
		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x20")]
		private UnityWebRequest <request>5__2;
	}

	// Token: 0x02000022 RID: 34
	[Token(Token = "0x2000022")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoWaitForRedemptionCompletion>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000148 RID: 328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000148")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoWaitForRedemptionCompletion>d__7(int <>1__state)
		{
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000149")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00002388 File Offset: 0x00000588
		[Token(Token = "0x600014A")]
		[Address(RVA = "0x5AFAF0", Offset = "0x5AEEF0", VA = "0x105AFAF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600014B RID: 331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002C")]
		private object Current
		{
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x5AFBE0", Offset = "0x5AEFE0", VA = "0x105AFBE0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600014D RID: 333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002D")]
		private object Current
		{
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040000E6 RID: 230
		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040000E7 RID: 231
		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040000E8 RID: 232
		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x10")]
		public CompletionToken<PurchaseStates> completionToken;
	}

	// Token: 0x02000023 RID: 35
	[Token(Token = "0x2000023")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoValidateTrustedReceipt>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600014E RID: 334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600014E")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoValidateTrustedReceipt>d__13(int <>1__state)
		{
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000150 RID: 336 RVA: 0x000023A0 File Offset: 0x000005A0
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x5AF8C0", Offset = "0x5AECC0", VA = "0x105AF8C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000151 RID: 337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002E")]
		private object Current
		{
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x5AFAC0", Offset = "0x5AEEC0", VA = "0x105AFAC0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000153 RID: 339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002F")]
		private object Current
		{
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040000E9 RID: 233
		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040000EA RID: 234
		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040000EB RID: 235
		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x10")]
		public string[] productIds;

		// Token: 0x040000EC RID: 236
		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x14")]
		public InventoryManager <>4__this;

		// Token: 0x040000ED RID: 237
		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x18")]
		public CompletionToken<PurchaseStates> queryDone;
	}

	// Token: 0x02000024 RID: 36
	[Token(Token = "0x2000024")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoValidateReceipt>d__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000154 RID: 340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000154")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoValidateReceipt>d__16(int <>1__state)
		{
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000155")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000156 RID: 342 RVA: 0x000023B8 File Offset: 0x000005B8
		[Token(Token = "0x6000156")]
		[Address(RVA = "0x5AE9C0", Offset = "0x5ADDC0", VA = "0x105AE9C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000157 RID: 343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000030")]
		private object Current
		{
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x5AF890", Offset = "0x5AEC90", VA = "0x105AF890", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000159 RID: 345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000031")]
		private object Current
		{
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040000EE RID: 238
		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040000EF RID: 239
		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040000F0 RID: 240
		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x10")]
		public string requestEndpoint;

		// Token: 0x040000F1 RID: 241
		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x14")]
		public string requestJson;

		// Token: 0x040000F2 RID: 242
		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x18")]
		public CompletionToken<PurchaseStates> queryDone;

		// Token: 0x040000F3 RID: 243
		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x1C")]
		private UnityWebRequest <request>5__2;
	}

	// Token: 0x02000025 RID: 37
	[Token(Token = "0x2000025")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoSteamPurchaseStars>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600015A RID: 346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoSteamPurchaseStars>d__19(int <>1__state)
		{
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600015B")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600015C RID: 348 RVA: 0x000023D0 File Offset: 0x000005D0
		[Token(Token = "0x600015C")]
		[Address(RVA = "0x5ADD80", Offset = "0x5AD180", VA = "0x105ADD80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600015D RID: 349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000032")]
		private object Current
		{
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600015E")]
		[Address(RVA = "0x5AE6C0", Offset = "0x5ADAC0", VA = "0x105AE6C0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600015F RID: 351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000033")]
		private object Current
		{
			[Token(Token = "0x600015F")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040000F4 RID: 244
		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040000F5 RID: 245
		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040000F6 RID: 246
		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x10")]
		public string requestEndpoint;

		// Token: 0x040000F7 RID: 247
		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x14")]
		public string requestJson;

		// Token: 0x040000F8 RID: 248
		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x18")]
		public CompletionToken<PurchaseStates> queryDone;

		// Token: 0x040000F9 RID: 249
		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x1C")]
		private UnityWebRequest <request>5__2;
	}

	// Token: 0x02000026 RID: 38
	[Token(Token = "0x2000026")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoFlushConsumableReceipts>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000160 RID: 352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000160")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoFlushConsumableReceipts>d__20(int <>1__state)
		{
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000161")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000162 RID: 354 RVA: 0x000023E8 File Offset: 0x000005E8
		[Token(Token = "0x6000162")]
		[Address(RVA = "0x5AA940", Offset = "0x5A9D40", VA = "0x105AA940", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000163 RID: 355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000034")]
		private object Current
		{
			[Token(Token = "0x6000163")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000164")]
		[Address(RVA = "0x5AAA10", Offset = "0x5A9E10", VA = "0x105AAA10", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000165 RID: 357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000035")]
		private object Current
		{
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040000FA RID: 250
		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040000FB RID: 251
		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040000FC RID: 252
		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x10")]
		public InventoryManager <>4__this;

		// Token: 0x040000FD RID: 253
		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0x14")]
		public Action<ResponseState, string> resultCallback;
	}

	// Token: 0x02000027 RID: 39
	[Token(Token = "0x2000027")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <FlushConsumableReceiptsCo>d__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000166 RID: 358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000166")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <FlushConsumableReceiptsCo>d__21(int <>1__state)
		{
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000167")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00002400 File Offset: 0x00000600
		[Token(Token = "0x6000168")]
		[Address(RVA = "0x5B0A40", Offset = "0x5AFE40", VA = "0x105B0A40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000169 RID: 361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000036")]
		private object Current
		{
			[Token(Token = "0x6000169")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600016A")]
		[Address(RVA = "0x5B0F90", Offset = "0x5B0390", VA = "0x105B0F90", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600016B RID: 363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000037")]
		private object Current
		{
			[Token(Token = "0x600016B")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040000FE RID: 254
		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040000FF RID: 255
		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000100 RID: 256
		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0x10")]
		public string requestEndpoint;

		// Token: 0x04000101 RID: 257
		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0x14")]
		public string requestJson;

		// Token: 0x04000102 RID: 258
		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0x18")]
		public Action<ResponseState, string> resultCallback;

		// Token: 0x04000103 RID: 259
		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0x1C")]
		private UnityWebRequest <request>5__2;
	}

	// Token: 0x02000028 RID: 40
	[Token(Token = "0x2000028")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <WaitForInventoryLoad>d__55 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600016C RID: 364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600016C")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <WaitForInventoryLoad>d__55(int <>1__state)
		{
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600016D")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00002418 File Offset: 0x00000618
		[Token(Token = "0x600016E")]
		[Address(RVA = "0x5B60B0", Offset = "0x5B54B0", VA = "0x105B60B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600016F RID: 367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000038")]
		private object Current
		{
			[Token(Token = "0x600016F")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000170")]
		[Address(RVA = "0x5B6100", Offset = "0x5B5500", VA = "0x105B6100", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000171 RID: 369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000039")]
		private object Current
		{
			[Token(Token = "0x6000171")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000104 RID: 260
		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000105 RID: 261
		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000106 RID: 262
		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0x10")]
		public InventoryManager <>4__this;
	}
}
