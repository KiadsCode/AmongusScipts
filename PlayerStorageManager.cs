using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Epic.OnlineServices;
using Epic.OnlineServices.Platform;
using Epic.OnlineServices.PlayerDataStorage;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000031 RID: 49
[Token(Token = "0x2000031")]
public class PlayerStorageManager : DestroyableSingleton<PlayerStorageManager>
{
	// Token: 0x17000040 RID: 64
	// (get) Token: 0x060001A4 RID: 420 RVA: 0x00002478 File Offset: 0x00000678
	// (set) Token: 0x060001A5 RID: 421 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000040")]
	public PlayerStorageManager.CloudPlayerPrefs PlayerPrefs
	{
		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x44AFB0", Offset = "0x44A3B0", VA = "0x1044AFB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return default(PlayerStorageManager.CloudPlayerPrefs);
		}
		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x46E120", Offset = "0x46D520", VA = "0x1046E120")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private set
		{
		}
	}

	// Token: 0x17000041 RID: 65
	// (get) Token: 0x060001A6 RID: 422 RVA: 0x00002490 File Offset: 0x00000690
	// (set) Token: 0x060001A7 RID: 423 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000041")]
	public UpdateState PlayerStorageLoadState
	{
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x287A00", Offset = "0x286E00", VA = "0x10287A00")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return UpdateState.Connecting;
		}
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x287920", Offset = "0x286D20", VA = "0x10287920")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private set
		{
		}
	}

	// Token: 0x060001A8 RID: 424 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x508110", Offset = "0x507510", VA = "0x10508110")]
	public void RefreshAll(PlatformInterface platformInterface)
	{
	}

	// Token: 0x060001A9 RID: 425 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x508320", Offset = "0x507720", VA = "0x10508320")]
	public void SaveChanges(PlayerStorageManager.CloudPlayerPrefs newPrefs)
	{
	}

	// Token: 0x060001AA RID: 426 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x5077D0", Offset = "0x506BD0", VA = "0x105077D0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE4000", Offset = "0xE3400")]
	private IEnumerator CoSaveChanges()
	{
		return null;
	}

	// Token: 0x060001AB RID: 427 RVA: 0x000024A8 File Offset: 0x000006A8
	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x507DD0", Offset = "0x5071D0", VA = "0x10507DD0")]
	private WriteResult OnWriteChunkToEOS(WriteFileDataCallbackInfo data, out byte[] outDataBuffer)
	{
		return (WriteResult)0;
	}

	// Token: 0x060001AC RID: 428 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x507F80", Offset = "0x507380", VA = "0x10507F80")]
	private void OnWriteFileComplete(WriteFileCallbackInfo data)
	{
	}

	// Token: 0x060001AD RID: 429 RVA: 0x000024C0 File Offset: 0x000006C0
	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x507910", Offset = "0x506D10", VA = "0x10507910")]
	private ReadResult OnReadChunkFromEOS(ReadFileDataCallbackInfo data)
	{
		return (ReadResult)0;
	}

	// Token: 0x060001AE RID: 430 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x507CB0", Offset = "0x5070B0", VA = "0x10507CB0")]
	private void OnReadPlayerPrefsComplete(ReadFileCallbackInfo data)
	{
	}

	// Token: 0x060001AF RID: 431 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x5079E0", Offset = "0x506DE0", VA = "0x105079E0")]
	private void OnReadPlayerPrefsCompleteInternal(MemoryStream stream, Result resultCode)
	{
	}

	// Token: 0x060001B0 RID: 432 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x508390", Offset = "0x507790", VA = "0x10508390")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE4090", Offset = "0xE3490")]
	public IEnumerator WaitForLoad()
	{
		return null;
	}

	// Token: 0x060001B1 RID: 433 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x507820", Offset = "0x506C20", VA = "0x10507820")]
	private static MemoryStream ObjectToStream(object dataToStream)
	{
		return null;
	}

	// Token: 0x060001B2 RID: 434 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x5083E0", Offset = "0x5077E0", VA = "0x105083E0")]
	public PlayerStorageManager()
	{
	}

	// Token: 0x0400012E RID: 302
	[Token(Token = "0x400012E")]
	private const int MaxEOSChunkLength = 40960;

	// Token: 0x0400012F RID: 303
	[Token(Token = "0x400012F")]
	private const string PlayerPrefsFilename = "player.prefs";

	// Token: 0x04000130 RID: 304
	[Token(Token = "0x4000130")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private PlayerStorageManager.CloudPlayerPrefs <PlayerPrefs>k__BackingField;

	// Token: 0x04000131 RID: 305
	[Token(Token = "0x4000131")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private UpdateState <PlayerStorageLoadState>k__BackingField;

	// Token: 0x04000132 RID: 306
	[Token(Token = "0x4000132")]
	[FieldOffset(Offset = "0x24")]
	private PlayerDataStorageInterface playerStorage;

	// Token: 0x04000133 RID: 307
	[Token(Token = "0x4000133")]
	[FieldOffset(Offset = "0x28")]
	private Coroutine saveRoutine;

	// Token: 0x02000032 RID: 50
	[Token(Token = "0x2000032")]
	public struct CloudPlayerPrefs
	{
		// Token: 0x04000134 RID: 308
		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0x0")]
		public string ActivePodType;

		// Token: 0x04000135 RID: 309
		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0x4")]
		public string receiptRedemptionAccounts;

		// Token: 0x04000136 RID: 310
		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0x8")]
		public uint PlatformsLimitedItemsValidated;

		// Token: 0x04000137 RID: 311
		[Token(Token = "0x4000137")]
		[FieldOffset(Offset = "0xC")]
		public uint HasStartedAccountResetProcess;
	}

	// Token: 0x02000033 RID: 51
	[Token(Token = "0x2000033")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoSaveChanges>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060001B3 RID: 435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoSaveChanges>d__14(int <>1__state)
		{
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x000024D8 File Offset: 0x000006D8
		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x7941A0", Offset = "0x7935A0", VA = "0x107941A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000042")]
		private object Current
		{
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x794370", Offset = "0x793770", VA = "0x10794370", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000043")]
		private object Current
		{
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000138 RID: 312
		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000139 RID: 313
		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x0400013A RID: 314
		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0x10")]
		public PlayerStorageManager <>4__this;
	}

	// Token: 0x02000034 RID: 52
	[Token(Token = "0x2000034")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <WaitForLoad>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060001B9 RID: 441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <WaitForLoad>d__20(int <>1__state)
		{
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060001BB RID: 443 RVA: 0x000024F0 File Offset: 0x000006F0
		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x372970", Offset = "0x371D70", VA = "0x10372970", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060001BC RID: 444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000044")]
		private object Current
		{
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x79C030", Offset = "0x79B430", VA = "0x1079C030", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060001BE RID: 446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000045")]
		private object Current
		{
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400013B RID: 315
		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x0400013C RID: 316
		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x0400013D RID: 317
		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0x10")]
		public PlayerStorageManager <>4__this;
	}
}
