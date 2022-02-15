using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Assets.InnerNet;
using Epic.OnlineServices.Connect;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x0200002B RID: 43
[Token(Token = "0x200002B")]
public class LinkExistingAccountPopup : MonoBehaviour
{
	// Token: 0x0600017D RID: 381 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600017D")]
	[Address(RVA = "0x6E13A0", Offset = "0x6E07A0", VA = "0x106E13A0")]
	public void Close()
	{
	}

	// Token: 0x0600017E RID: 382 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600017E")]
	[Address(RVA = "0x6E1AE0", Offset = "0x6E0EE0", VA = "0x106E1AE0")]
	public void StartLinkProcess()
	{
	}

	// Token: 0x0600017F RID: 383 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600017F")]
	[Address(RVA = "0x6E1440", Offset = "0x6E0840", VA = "0x106E1440")]
	public void ConfirmLinkProcess()
	{
	}

	// Token: 0x06000180 RID: 384 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000180")]
	[Address(RVA = "0x6E1830", Offset = "0x6E0C30", VA = "0x106E1830")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE3880", Offset = "0xE2C80")]
	private IEnumerator DelayShowingButton()
	{
		return null;
	}

	// Token: 0x06000181 RID: 385 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000181")]
	[Address(RVA = "0x6E19A0", Offset = "0x6E0DA0", VA = "0x106E19A0")]
	private void PrepareForResettingAccount()
	{
	}

	// Token: 0x06000182 RID: 386 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000182")]
	[Address(RVA = "0x6E1880", Offset = "0x6E0C80", VA = "0x106E1880")]
	private void FlushReceiptsWJ()
	{
	}

	// Token: 0x06000183 RID: 387 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000183")]
	[Address(RVA = "0x6E11C0", Offset = "0x6E05C0", VA = "0x106E11C0")]
	public void ActuallyLinkExistingAccounts(bool hasSucceeded = true)
	{
	}

	// Token: 0x06000184 RID: 388 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000184")]
	[Address(RVA = "0x6E2400", Offset = "0x6E1800", VA = "0x106E2400")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE3910", Offset = "0xE2D10")]
	private IEnumerator WaitingText(string str)
	{
		return null;
	}

	// Token: 0x06000185 RID: 389 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000185")]
	[Address(RVA = "0x6E2300", Offset = "0x6E1700", VA = "0x106E2300")]
	public void Update()
	{
	}

	// Token: 0x06000186 RID: 390 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000186")]
	[Address(RVA = "0x6E17F0", Offset = "0x6E0BF0", VA = "0x106E17F0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE39A0", Offset = "0xE2DA0")]
	private IEnumerator ConsumeConsumables()
	{
		return null;
	}

	// Token: 0x06000187 RID: 391 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000187")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public LinkExistingAccountPopup()
	{
	}

	// Token: 0x06000188 RID: 392 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000188")]
	[Address(RVA = "0x6E2090", Offset = "0x6E1490", VA = "0x106E2090")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private void <FlushReceiptsWJ>b__14_0(ResponseState response, string responseStr)
	{
	}

	// Token: 0x06000189 RID: 393 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000189")]
	[Address(RVA = "0x6E1F60", Offset = "0x6E1360", VA = "0x106E1F60")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private void <ActuallyLinkExistingAccounts>b__15_0(UnlinkAccountCallbackInfo result)
	{
	}

	// Token: 0x04000112 RID: 274
	[Token(Token = "0x4000112")]
	[FieldOffset(Offset = "0xC")]
	public SpriteRenderer background;

	// Token: 0x04000113 RID: 275
	[Token(Token = "0x4000113")]
	[FieldOffset(Offset = "0x10")]
	public TextMeshPro titleText;

	// Token: 0x04000114 RID: 276
	[Token(Token = "0x4000114")]
	[FieldOffset(Offset = "0x14")]
	public TextMeshPro bodyText;

	// Token: 0x04000115 RID: 277
	[Token(Token = "0x4000115")]
	[FieldOffset(Offset = "0x18")]
	public TextMeshPro button1Text;

	// Token: 0x04000116 RID: 278
	[Token(Token = "0x4000116")]
	[FieldOffset(Offset = "0x1C")]
	public TextMeshPro button2Text;

	// Token: 0x04000117 RID: 279
	[Token(Token = "0x4000117")]
	[FieldOffset(Offset = "0x20")]
	public PassiveButton button1;

	// Token: 0x04000118 RID: 280
	[Token(Token = "0x4000118")]
	[FieldOffset(Offset = "0x24")]
	public PassiveButton button2;

	// Token: 0x04000119 RID: 281
	[Token(Token = "0x4000119")]
	[FieldOffset(Offset = "0x28")]
	public Transform button1Pos;

	// Token: 0x0400011A RID: 282
	[Token(Token = "0x400011A")]
	[FieldOffset(Offset = "0x2C")]
	private Vector3 prevButton1Pos;

	// Token: 0x0400011B RID: 283
	[Token(Token = "0x400011B")]
	[FieldOffset(Offset = "0x38")]
	private bool runText;

	// Token: 0x0200002C RID: 44
	[Token(Token = "0x200002C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <DelayShowingButton>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600018A RID: 394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600018A")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <DelayShowingButton>d__12(int <>1__state)
		{
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600018B")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00002430 File Offset: 0x00000630
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x5AFC70", Offset = "0x5AF070", VA = "0x105AFC70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600018D RID: 397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003A")]
		private object Current
		{
			[Token(Token = "0x600018D")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600018E")]
		[Address(RVA = "0x5AFEB0", Offset = "0x5AF2B0", VA = "0x105AFEB0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600018F RID: 399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003B")]
		private object Current
		{
			[Token(Token = "0x600018F")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400011C RID: 284
		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x0400011D RID: 285
		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x0400011E RID: 286
		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x10")]
		public LinkExistingAccountPopup <>4__this;

		// Token: 0x0400011F RID: 287
		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0x14")]
		private SpriteRenderer <sprite>5__2;

		// Token: 0x04000120 RID: 288
		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0x18")]
		private ButtonRolloverHandler <rollover>5__3;
	}

	// Token: 0x0200002D RID: 45
	[Token(Token = "0x200002D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <WaitingText>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000190 RID: 400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <WaitingText>d__17(int <>1__state)
		{
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000191")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00002448 File Offset: 0x00000648
		[Token(Token = "0x6000192")]
		[Address(RVA = "0x5B6270", Offset = "0x5B5670", VA = "0x105B6270", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000193 RID: 403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003C")]
		private object Current
		{
			[Token(Token = "0x6000193")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x5B63A0", Offset = "0x5B57A0", VA = "0x105B63A0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000195 RID: 405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003D")]
		private object Current
		{
			[Token(Token = "0x6000195")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000121 RID: 289
		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000122 RID: 290
		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000123 RID: 291
		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x10")]
		public LinkExistingAccountPopup <>4__this;

		// Token: 0x04000124 RID: 292
		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x14")]
		public string str;

		// Token: 0x04000125 RID: 293
		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x18")]
		private int <count>5__2;
	}

	// Token: 0x0200002E RID: 46
	[Token(Token = "0x200002E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <ConsumeConsumables>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000196 RID: 406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <ConsumeConsumables>d__19(int <>1__state)
		{
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000197")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00002460 File Offset: 0x00000660
		[Token(Token = "0x6000198")]
		[Address(RVA = "0x5AFC10", Offset = "0x5AF010", VA = "0x105AFC10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000199 RID: 409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003E")]
		private object Current
		{
			[Token(Token = "0x6000199")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600019A")]
		[Address(RVA = "0x5AFC40", Offset = "0x5AF040", VA = "0x105AFC40", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600019B RID: 411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003F")]
		private object Current
		{
			[Token(Token = "0x600019B")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000126 RID: 294
		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000127 RID: 295
		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;
	}
}
