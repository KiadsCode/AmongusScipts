using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Il2CppDummyDll;
using Steamworks;
using UnityEngine.Purchasing;
using UnityEngine.Purchasing.Extension;

// Token: 0x020002FE RID: 766
[Token(Token = "0x20002FE")]
internal class SteamPurchasingModule : IPurchasingModule, IStore
{
	// Token: 0x060010D8 RID: 4312 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010D8")]
	[Address(RVA = "0x75B0A0", Offset = "0x75A4A0", VA = "0x1075B0A0", Slot = "4")]
	public void Configure(IPurchasingBinder binder)
	{
	}

	// Token: 0x060010D9 RID: 4313 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010D9")]
	[Address(RVA = "0x75B140", Offset = "0x75A540", VA = "0x1075B140", Slot = "8")]
	public void FinishTransaction(ProductDefinition product, string transactionId)
	{
	}

	// Token: 0x060010DA RID: 4314 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010DA")]
	[Address(RVA = "0x75B1C0", Offset = "0x75A5C0", VA = "0x1075B1C0", Slot = "5")]
	public void Initialize(IStoreCallback callback)
	{
	}

	// Token: 0x060010DB RID: 4315 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010DB")]
	[Address(RVA = "0x75B9B0", Offset = "0x75ADB0", VA = "0x1075B9B0", Slot = "6")]
	public void RetrieveProducts(ReadOnlyCollection<ProductDefinition> products)
	{
	}

	// Token: 0x060010DC RID: 4316 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010DC")]
	[Address(RVA = "0x75B1A0", Offset = "0x75A5A0", VA = "0x1075B1A0")]
	private void HandleOverlayActivate(GameOverlayActivated_t param)
	{
	}

	// Token: 0x060010DD RID: 4317 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010DD")]
	[Address(RVA = "0x75B530", Offset = "0x75A930", VA = "0x1075B530", Slot = "7")]
	public void Purchase(ProductDefinition product, string developerPayload)
	{
	}

	// Token: 0x060010DE RID: 4318 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010DE")]
	[Address(RVA = "0x75B300", Offset = "0x75A700", VA = "0x1075B300")]
	private void OnSteamMicroTxnAuth(MicroTxnAuthorizationResponse_t pCallback)
	{
	}

	// Token: 0x060010DF RID: 4319 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010DF")]
	[Address(RVA = "0x75BDD0", Offset = "0x75B1D0", VA = "0x1075BDD0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE6BD0", Offset = "0xE5FD0")]
	private IEnumerator WaitForPurchase(ProductDefinition product)
	{
		return null;
	}

	// Token: 0x060010E0 RID: 4320 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010E0")]
	[Address(RVA = "0x75BE30", Offset = "0x75B230", VA = "0x1075BE30")]
	public SteamPurchasingModule()
	{
	}

	// Token: 0x04001088 RID: 4232
	[Token(Token = "0x4001088")]
	private const string Name = "Steam";

	// Token: 0x04001089 RID: 4233
	[Token(Token = "0x4001089")]
	[FieldOffset(Offset = "0x8")]
	private IStoreCallback storeCallback;

	// Token: 0x0400108A RID: 4234
	[Token(Token = "0x400108A")]
	[FieldOffset(Offset = "0xC")]
	private bool steamOverlayOpen;

	// Token: 0x0400108B RID: 4235
	[Token(Token = "0x400108B")]
	[FieldOffset(Offset = "0x10")]
	private uint steamAppId;

	// Token: 0x0400108C RID: 4236
	[Token(Token = "0x400108C")]
	[FieldOffset(Offset = "0x14")]
	private Callback<GameOverlayActivated_t> m_GameOverlayActivated;

	// Token: 0x0400108D RID: 4237
	[Token(Token = "0x400108D")]
	[FieldOffset(Offset = "0x18")]
	private CompletionToken<PurchaseStates> initializeQueryDone;

	// Token: 0x0400108E RID: 4238
	[Token(Token = "0x400108E")]
	[FieldOffset(Offset = "0x1C")]
	private CompletionToken<PurchaseStates> finalizeQueryDone;

	// Token: 0x020002FF RID: 767
	[Token(Token = "0x20002FF")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass10_0
	{
		// Token: 0x060010E1 RID: 4321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010E1")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass10_0()
		{
		}

		// Token: 0x060010E2 RID: 4322 RVA: 0x00005F40 File Offset: 0x00004140
		[Token(Token = "0x60010E2")]
		[Address(RVA = "0x370D30", Offset = "0x370130", VA = "0x10370D30")]
		internal bool <RetrieveProducts>b__0(BundleData x)
		{
			return default(bool);
		}

		// Token: 0x060010E3 RID: 4323 RVA: 0x00005F58 File Offset: 0x00004158
		[Token(Token = "0x60010E3")]
		[Address(RVA = "0x370D60", Offset = "0x370160", VA = "0x10370D60")]
		internal bool <RetrieveProducts>b__1(StarBundle x)
		{
			return default(bool);
		}

		// Token: 0x0400108F RID: 4239
		[Token(Token = "0x400108F")]
		[FieldOffset(Offset = "0x8")]
		public ProductDefinition product;
	}

	// Token: 0x02000300 RID: 768
	[Token(Token = "0x2000300")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <WaitForPurchase>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060010E4 RID: 4324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010E4")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <WaitForPurchase>d__14(int <>1__state)
		{
		}

		// Token: 0x060010E5 RID: 4325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010E5")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060010E6 RID: 4326 RVA: 0x00005F70 File Offset: 0x00004170
		[Token(Token = "0x60010E6")]
		[Address(RVA = "0x372560", Offset = "0x371960", VA = "0x10372560", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x060010E7 RID: 4327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700028A")]
		private object Current
		{
			[Token(Token = "0x60010E7")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060010E8 RID: 4328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010E8")]
		[Address(RVA = "0x3728A0", Offset = "0x371CA0", VA = "0x103728A0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x060010E9 RID: 4329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700028B")]
		private object Current
		{
			[Token(Token = "0x60010E9")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04001090 RID: 4240
		[Token(Token = "0x4001090")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04001091 RID: 4241
		[Token(Token = "0x4001091")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04001092 RID: 4242
		[Token(Token = "0x4001092")]
		[FieldOffset(Offset = "0x10")]
		public SteamPurchasingModule <>4__this;

		// Token: 0x04001093 RID: 4243
		[Token(Token = "0x4001093")]
		[FieldOffset(Offset = "0x14")]
		public ProductDefinition product;
	}
}
