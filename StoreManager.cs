using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine.Purchasing;

// Token: 0x02000301 RID: 769
[Token(Token = "0x2000301")]
public class StoreManager : DestroyableSingleton<StoreManager>, IStoreListener
{
	// Token: 0x060010EA RID: 4330 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010EA")]
	[Address(RVA = "0x75C5B0", Offset = "0x75B9B0", VA = "0x1075C5B0")]
	public void Initialize()
	{
	}

	// Token: 0x060010EB RID: 4331 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010EB")]
	[Address(RVA = "0x75CB30", Offset = "0x75BF30", VA = "0x1075CB30", Slot = "9")]
	public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
	{
	}

	// Token: 0x060010EC RID: 4332 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010EC")]
	[Address(RVA = "0x75CD30", Offset = "0x75C130", VA = "0x1075CD30")]
	public void ProcessOldReceiptsRestore()
	{
	}

	// Token: 0x060010ED RID: 4333 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010ED")]
	[Address(RVA = "0x75CD40", Offset = "0x75C140", VA = "0x1075CD40")]
	public void ProcessOldReceipts()
	{
	}

	// Token: 0x060010EE RID: 4334 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010EE")]
	[Address(RVA = "0x75C820", Offset = "0x75BC20", VA = "0x1075C820")]
	public void InitiateStorePurchaseStar(PurchaseButton button)
	{
	}

	// Token: 0x060010EF RID: 4335 RVA: 0x00005F88 File Offset: 0x00004188
	[Token(Token = "0x60010EF")]
	[Address(RVA = "0x75D230", Offset = "0x75C630", VA = "0x1075D230", Slot = "7")]
	public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs e)
	{
		return PurchaseProcessingResult.Complete;
	}

	// Token: 0x060010F0 RID: 4336 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010F0")]
	[Address(RVA = "0x75C550", Offset = "0x75B950", VA = "0x1075C550")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE6CC0", Offset = "0xE60C0")]
	private IEnumerator CoWaitForStarPurchaseValidation(CompletionToken<PurchaseStates> queryDone, PurchaseButton button)
	{
		return null;
	}

	// Token: 0x060010F1 RID: 4337 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010F1")]
	[Address(RVA = "0x75CBB0", Offset = "0x75BFB0", VA = "0x1075CBB0", Slot = "8")]
	public void OnPurchaseFailed(Product i, PurchaseFailureReason error)
	{
	}

	// Token: 0x060010F2 RID: 4338 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010F2")]
	[Address(RVA = "0x75CA60", Offset = "0x75BE60", VA = "0x1075CA60", Slot = "6")]
	public void OnInitializeFailed(InitializationFailureReason error)
	{
	}

	// Token: 0x060010F3 RID: 4339 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010F3")]
	[Address(RVA = "0x75D4B0", Offset = "0x75C8B0", VA = "0x1075D4B0")]
	public StoreManager()
	{
	}

	// Token: 0x04001094 RID: 4244
	[Token(Token = "0x4001094")]
	[FieldOffset(Offset = "0x10")]
	public CompletionToken<PurchaseStates> starPurchaseStateQuery;

	// Token: 0x04001095 RID: 4245
	[Token(Token = "0x4001095")]
	[FieldOffset(Offset = "0x14")]
	private Product[] allProducts;

	// Token: 0x04001096 RID: 4246
	[Token(Token = "0x4001096")]
	[FieldOffset(Offset = "0x18")]
	private IStoreController controller;

	// Token: 0x04001097 RID: 4247
	[Token(Token = "0x4001097")]
	[FieldOffset(Offset = "0x1C")]
	private IExtensionProvider extensions;

	// Token: 0x04001098 RID: 4248
	[Token(Token = "0x4001098")]
	[FieldOffset(Offset = "0x20")]
	private bool initialized;

	// Token: 0x02000302 RID: 770
	[Token(Token = "0x2000302")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass8_0
	{
		// Token: 0x060010F4 RID: 4340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010F4")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass8_0()
		{
		}

		// Token: 0x060010F5 RID: 4341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010F5")]
		[Address(RVA = "0x3719A0", Offset = "0x370DA0", VA = "0x103719A0")]
		internal void <ProcessOldReceipts>b__0()
		{
		}

		// Token: 0x04001099 RID: 4249
		[Token(Token = "0x4001099")]
		[FieldOffset(Offset = "0x8")]
		public List<string> receipts;

		// Token: 0x0400109A RID: 4250
		[Token(Token = "0x400109A")]
		[FieldOffset(Offset = "0xC")]
		public CompletionToken<PurchaseStates> queryDone;
	}

	// Token: 0x02000303 RID: 771
	[Token(Token = "0x2000303")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060010F7 RID: 4343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010F7")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x060010F8 RID: 4344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010F8")]
		[Address(RVA = "0x3707D0", Offset = "0x36FBD0", VA = "0x103707D0")]
		internal void <ProcessOldReceipts>b__8_1()
		{
		}

		// Token: 0x0400109B RID: 4251
		[Token(Token = "0x400109B")]
		[FieldOffset(Offset = "0x0")]
		public static readonly StoreManager.<>c <>9;

		// Token: 0x0400109C RID: 4252
		[Token(Token = "0x400109C")]
		[FieldOffset(Offset = "0x4")]
		public static Action <>9__8_1;
	}

	// Token: 0x02000304 RID: 772
	[Token(Token = "0x2000304")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass11_0
	{
		// Token: 0x060010F9 RID: 4345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010F9")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass11_0()
		{
		}

		// Token: 0x060010FA RID: 4346 RVA: 0x00005FA0 File Offset: 0x000041A0
		[Token(Token = "0x60010FA")]
		[Address(RVA = "0x370DB0", Offset = "0x3701B0", VA = "0x10370DB0")]
		internal bool <CoWaitForStarPurchaseValidation>b__0(Product x)
		{
			return default(bool);
		}

		// Token: 0x0400109D RID: 4253
		[Token(Token = "0x400109D")]
		[FieldOffset(Offset = "0x8")]
		public StarBundle starBundle;
	}

	// Token: 0x02000305 RID: 773
	[Token(Token = "0x2000305")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoWaitForStarPurchaseValidation>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060010FB RID: 4347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010FB")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoWaitForStarPurchaseValidation>d__11(int <>1__state)
		{
		}

		// Token: 0x060010FC RID: 4348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010FC")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060010FD RID: 4349 RVA: 0x00005FB8 File Offset: 0x000041B8
		[Token(Token = "0x60010FD")]
		[Address(RVA = "0x36A530", Offset = "0x369930", VA = "0x1036A530", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x060010FE RID: 4350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700028C")]
		private object Current
		{
			[Token(Token = "0x60010FE")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060010FF RID: 4351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010FF")]
		[Address(RVA = "0x36A940", Offset = "0x369D40", VA = "0x1036A940", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06001100 RID: 4352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700028D")]
		private object Current
		{
			[Token(Token = "0x6001100")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400109E RID: 4254
		[Token(Token = "0x400109E")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x0400109F RID: 4255
		[Token(Token = "0x400109F")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040010A0 RID: 4256
		[Token(Token = "0x40010A0")]
		[FieldOffset(Offset = "0x10")]
		public CompletionToken<PurchaseStates> queryDone;

		// Token: 0x040010A1 RID: 4257
		[Token(Token = "0x40010A1")]
		[FieldOffset(Offset = "0x14")]
		public PurchaseButton button;

		// Token: 0x040010A2 RID: 4258
		[Token(Token = "0x40010A2")]
		[FieldOffset(Offset = "0x18")]
		public StoreManager <>4__this;
	}
}
