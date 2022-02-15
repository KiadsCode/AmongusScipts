using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using PowerTools;
using TMPro;
using UnityEngine;

// Token: 0x02000192 RID: 402
[Token(Token = "0x2000192")]
public class GooglePlayAssetHandler : MonoBehaviour
{
	// Token: 0x06000934 RID: 2356 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000934")]
	[Address(RVA = "0x3B7CF0", Offset = "0x3B70F0", VA = "0x103B7CF0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE0420", Offset = "0xDF820")]
	public IEnumerator PromptUser()
	{
		return null;
	}

	// Token: 0x06000935 RID: 2357 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000935")]
	[Address(RVA = "0x3B7C30", Offset = "0x3B7030", VA = "0x103B7C30")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE0470", Offset = "0xDF870")]
	public IEnumerator DownloadAssetPacks()
	{
		return null;
	}

	// Token: 0x06000936 RID: 2358 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000936")]
	[Address(RVA = "0x3B7D40", Offset = "0x3B7140", VA = "0x103B7D40")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE04C0", Offset = "0xDF8C0")]
	public IEnumerator ShowError()
	{
		return null;
	}

	// Token: 0x06000937 RID: 2359 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000937")]
	[Address(RVA = "0x3B7CB0", Offset = "0x3B70B0", VA = "0x103B7CB0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE0510", Offset = "0xDF910")]
	private IEnumerator LoadAssetPackCoroutine(string assetPackName)
	{
		return null;
	}

	// Token: 0x06000938 RID: 2360 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000938")]
	[Address(RVA = "0x3B7C70", Offset = "0x3B7070", VA = "0x103B7C70")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE05B0", Offset = "0xDF9B0")]
	public IEnumerator GetDownloadSize(List<string> packs)
	{
		return null;
	}

	// Token: 0x06000939 RID: 2361 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000939")]
	[Address(RVA = "0x3B7BE0", Offset = "0x3B6FE0", VA = "0x103B7BE0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE0600", Offset = "0xDFA00")]
	private IEnumerator DoRun()
	{
		return null;
	}

	// Token: 0x0600093A RID: 2362 RVA: 0x000044E8 File Offset: 0x000026E8
	[Token(Token = "0x600093A")]
	[Address(RVA = "0x3B7D30", Offset = "0x3B7130", VA = "0x103B7D30")]
	public bool RejectedDownload()
	{
		return default(bool);
	}

	// Token: 0x0600093B RID: 2363 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600093B")]
	[Address(RVA = "0x3B7BA0", Offset = "0x3B6FA0", VA = "0x103B7BA0")]
	public void ClickDownloadButton(bool accept)
	{
	}

	// Token: 0x0600093C RID: 2364 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600093C")]
	[Address(RVA = "0x3B7BC0", Offset = "0x3B6FC0", VA = "0x103B7BC0")]
	public void CloseErrorPopUp(bool retry)
	{
	}

	// Token: 0x0600093D RID: 2365 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600093D")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public GooglePlayAssetHandler()
	{
	}

	// Token: 0x04000933 RID: 2355
	[Token(Token = "0x4000933")]
	[FieldOffset(Offset = "0xC")]
	public TextMeshPro text;

	// Token: 0x04000934 RID: 2356
	[Token(Token = "0x4000934")]
	[FieldOffset(Offset = "0x10")]
	public GameObject popup;

	// Token: 0x04000935 RID: 2357
	[Token(Token = "0x4000935")]
	[FieldOffset(Offset = "0x14")]
	public GameObject confirmPopUp;

	// Token: 0x04000936 RID: 2358
	[Token(Token = "0x4000936")]
	[FieldOffset(Offset = "0x18")]
	public TextMeshPro downloadSizeText;

	// Token: 0x04000937 RID: 2359
	[Token(Token = "0x4000937")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject errorPopUp;

	// Token: 0x04000938 RID: 2360
	[Token(Token = "0x4000938")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshPro errorText;

	// Token: 0x04000939 RID: 2361
	[Token(Token = "0x4000939")]
	[FieldOffset(Offset = "0x24")]
	public HorizontalGauge Gauge;

	// Token: 0x0400093A RID: 2362
	[Token(Token = "0x400093A")]
	[FieldOffset(Offset = "0x28")]
	public SpriteRenderer Runner;

	// Token: 0x0400093B RID: 2363
	[Token(Token = "0x400093B")]
	[FieldOffset(Offset = "0x2C")]
	public SpriteAnim LeftFolder;

	// Token: 0x0400093C RID: 2364
	[Token(Token = "0x400093C")]
	[FieldOffset(Offset = "0x30")]
	public SpriteAnim RightFolder;

	// Token: 0x0400093D RID: 2365
	[Token(Token = "0x400093D")]
	[FieldOffset(Offset = "0x34")]
	public AnimationClip FolderOpen;

	// Token: 0x0400093E RID: 2366
	[Token(Token = "0x400093E")]
	[FieldOffset(Offset = "0x38")]
	public AnimationClip FolderClose;

	// Token: 0x0400093F RID: 2367
	[Token(Token = "0x400093F")]
	[FieldOffset(Offset = "0x3C")]
	public bool downloading;

	// Token: 0x04000940 RID: 2368
	[Token(Token = "0x4000940")]
	[FieldOffset(Offset = "0x40")]
	private string downloadError;

	// Token: 0x04000941 RID: 2369
	[Token(Token = "0x4000941")]
	[FieldOffset(Offset = "0x48")]
	private long spaceNeeded;

	// Token: 0x04000942 RID: 2370
	[Token(Token = "0x4000942")]
	[FieldOffset(Offset = "0x50")]
	private List<string> packsToDownload;

	// Token: 0x04000943 RID: 2371
	[Token(Token = "0x4000943")]
	[FieldOffset(Offset = "0x54")]
	private GooglePlayAssetHandler.ConfirmationStatus confirmationStatus;

	// Token: 0x04000944 RID: 2372
	[Token(Token = "0x4000944")]
	[FieldOffset(Offset = "0x58")]
	private GooglePlayAssetHandler.ErrorConfirmationStatus errorConfirmationStatus;

	// Token: 0x02000193 RID: 403
	[Token(Token = "0x2000193")]
	private enum ConfirmationStatus
	{
		// Token: 0x04000946 RID: 2374
		[Token(Token = "0x4000946")]
		Waiting,
		// Token: 0x04000947 RID: 2375
		[Token(Token = "0x4000947")]
		Accept,
		// Token: 0x04000948 RID: 2376
		[Token(Token = "0x4000948")]
		Decline
	}

	// Token: 0x02000194 RID: 404
	[Token(Token = "0x2000194")]
	private enum ErrorConfirmationStatus
	{
		// Token: 0x0400094A RID: 2378
		[Token(Token = "0x400094A")]
		Waiting,
		// Token: 0x0400094B RID: 2379
		[Token(Token = "0x400094B")]
		Retry,
		// Token: 0x0400094C RID: 2380
		[Token(Token = "0x400094C")]
		Decline
	}

	// Token: 0x02000195 RID: 405
	[Token(Token = "0x2000195")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <PromptUser>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600093E RID: 2366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600093E")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <PromptUser>d__20(int <>1__state)
		{
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600093F")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x00004500 File Offset: 0x00002700
		[Token(Token = "0x6000940")]
		[Address(RVA = "0x5AFC10", Offset = "0x5AF010", VA = "0x105AFC10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000941 RID: 2369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000163")]
		private object Current
		{
			[Token(Token = "0x6000941")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000942")]
		[Address(RVA = "0x5B2FE0", Offset = "0x5B23E0", VA = "0x105B2FE0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000943 RID: 2371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000164")]
		private object Current
		{
			[Token(Token = "0x6000943")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400094D RID: 2381
		[Token(Token = "0x400094D")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x0400094E RID: 2382
		[Token(Token = "0x400094E")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;
	}

	// Token: 0x02000196 RID: 406
	[Token(Token = "0x2000196")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <DownloadAssetPacks>d__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000944 RID: 2372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000944")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <DownloadAssetPacks>d__21(int <>1__state)
		{
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000945")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x00004518 File Offset: 0x00002718
		[Token(Token = "0x6000946")]
		[Address(RVA = "0x5AFC10", Offset = "0x5AF010", VA = "0x105AFC10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000947 RID: 2375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000165")]
		private object Current
		{
			[Token(Token = "0x6000947")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000948")]
		[Address(RVA = "0x5B01A0", Offset = "0x5AF5A0", VA = "0x105B01A0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000949 RID: 2377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000166")]
		private object Current
		{
			[Token(Token = "0x6000949")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400094F RID: 2383
		[Token(Token = "0x400094F")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000950 RID: 2384
		[Token(Token = "0x4000950")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;
	}

	// Token: 0x02000197 RID: 407
	[Token(Token = "0x2000197")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <ShowError>d__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600094A RID: 2378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600094A")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <ShowError>d__22(int <>1__state)
		{
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600094B")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x00004530 File Offset: 0x00002730
		[Token(Token = "0x600094C")]
		[Address(RVA = "0x5B4280", Offset = "0x5B3680", VA = "0x105B4280", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x0600094D RID: 2381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000167")]
		private object Current
		{
			[Token(Token = "0x600094D")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600094E")]
		[Address(RVA = "0x5B43E0", Offset = "0x5B37E0", VA = "0x105B43E0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x0600094F RID: 2383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000168")]
		private object Current
		{
			[Token(Token = "0x600094F")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000951 RID: 2385
		[Token(Token = "0x4000951")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000952 RID: 2386
		[Token(Token = "0x4000952")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000953 RID: 2387
		[Token(Token = "0x4000953")]
		[FieldOffset(Offset = "0x10")]
		public GooglePlayAssetHandler <>4__this;
	}

	// Token: 0x02000198 RID: 408
	[Token(Token = "0x2000198")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <LoadAssetPackCoroutine>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000950 RID: 2384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000950")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <LoadAssetPackCoroutine>d__23(int <>1__state)
		{
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000951")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x00004548 File Offset: 0x00002748
		[Token(Token = "0x6000952")]
		[Address(RVA = "0x5AFC10", Offset = "0x5AF010", VA = "0x105AFC10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000953 RID: 2387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000169")]
		private object Current
		{
			[Token(Token = "0x6000953")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000954")]
		[Address(RVA = "0x5B2C70", Offset = "0x5B2070", VA = "0x105B2C70", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000955 RID: 2389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700016A")]
		private object Current
		{
			[Token(Token = "0x6000955")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000954 RID: 2388
		[Token(Token = "0x4000954")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000955 RID: 2389
		[Token(Token = "0x4000955")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;
	}

	// Token: 0x02000199 RID: 409
	[Token(Token = "0x2000199")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <GetDownloadSize>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000956 RID: 2390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000956")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <GetDownloadSize>d__24(int <>1__state)
		{
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000957")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x00004560 File Offset: 0x00002760
		[Token(Token = "0x6000958")]
		[Address(RVA = "0x5AFC10", Offset = "0x5AF010", VA = "0x105AFC10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000959 RID: 2393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700016B")]
		private object Current
		{
			[Token(Token = "0x6000959")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600095A")]
		[Address(RVA = "0x5B0FC0", Offset = "0x5B03C0", VA = "0x105B0FC0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x0600095B RID: 2395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700016C")]
		private object Current
		{
			[Token(Token = "0x600095B")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000956 RID: 2390
		[Token(Token = "0x4000956")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000957 RID: 2391
		[Token(Token = "0x4000957")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;
	}

	// Token: 0x0200019A RID: 410
	[Token(Token = "0x200019A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass25_0
	{
		// Token: 0x0600095C RID: 2396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600095C")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass25_0()
		{
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600095D")]
		[Address(RVA = "0x5B55A0", Offset = "0x5B49A0", VA = "0x105B55A0")]
		internal void <DoRun>b__0(float t)
		{
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600095E")]
		[Address(RVA = "0x5B5620", Offset = "0x5B4A20", VA = "0x105B5620")]
		internal void <DoRun>b__1(float t)
		{
		}

		// Token: 0x04000958 RID: 2392
		[Token(Token = "0x4000958")]
		[FieldOffset(Offset = "0x8")]
		public Vector3 pos;

		// Token: 0x04000959 RID: 2393
		[Token(Token = "0x4000959")]
		[FieldOffset(Offset = "0x14")]
		public GooglePlayAssetHandler <>4__this;
	}

	// Token: 0x0200019B RID: 411
	[Token(Token = "0x200019B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <DoRun>d__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600095F RID: 2399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600095F")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <DoRun>d__25(int <>1__state)
		{
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000960")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x00004578 File Offset: 0x00002778
		[Token(Token = "0x6000961")]
		[Address(RVA = "0x5AFEE0", Offset = "0x5AF2E0", VA = "0x105AFEE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000962 RID: 2402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700016D")]
		private object Current
		{
			[Token(Token = "0x6000962")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000963")]
		[Address(RVA = "0x5B0170", Offset = "0x5AF570", VA = "0x105B0170", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000964 RID: 2404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700016E")]
		private object Current
		{
			[Token(Token = "0x6000964")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400095A RID: 2394
		[Token(Token = "0x400095A")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x0400095B RID: 2395
		[Token(Token = "0x400095B")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x0400095C RID: 2396
		[Token(Token = "0x400095C")]
		[FieldOffset(Offset = "0x10")]
		public GooglePlayAssetHandler <>4__this;

		// Token: 0x0400095D RID: 2397
		[Token(Token = "0x400095D")]
		[FieldOffset(Offset = "0x14")]
		private GooglePlayAssetHandler.<>c__DisplayClass25_0 <>8__1;
	}
}
