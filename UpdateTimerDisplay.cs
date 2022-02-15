using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x0200030E RID: 782
[Token(Token = "0x200030E")]
public class UpdateTimerDisplay : MonoBehaviour
{
	// Token: 0x06001138 RID: 4408 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001138")]
	[Address(RVA = "0x4B8840", Offset = "0x4B7C40", VA = "0x104B8840")]
	private void OnEnable()
	{
	}

	// Token: 0x06001139 RID: 4409 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001139")]
	[Address(RVA = "0x4B88E0", Offset = "0x4B7CE0", VA = "0x104B88E0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE6D70", Offset = "0xE6170")]
	private IEnumerator TimeLimitCountdown()
	{
		return null;
	}

	// Token: 0x0600113A RID: 4410 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600113A")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public UpdateTimerDisplay()
	{
	}

	// Token: 0x04001111 RID: 4369
	[Token(Token = "0x4001111")]
	[FieldOffset(Offset = "0xC")]
	public TextMeshPro tmp;

	// Token: 0x0200030F RID: 783
	[Token(Token = "0x200030F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <TimeLimitCountdown>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600113B RID: 4411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600113B")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <TimeLimitCountdown>d__2(int <>1__state)
		{
		}

		// Token: 0x0600113C RID: 4412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600113C")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600113D RID: 4413 RVA: 0x00006108 File Offset: 0x00004308
		[Token(Token = "0x600113D")]
		[Address(RVA = "0x1301C30", Offset = "0x1301030", VA = "0x11301C30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x0600113E RID: 4414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000290")]
		private object Current
		{
			[Token(Token = "0x600113E")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600113F RID: 4415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600113F")]
		[Address(RVA = "0x1301D80", Offset = "0x1301180", VA = "0x11301D80", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06001140 RID: 4416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000291")]
		private object Current
		{
			[Token(Token = "0x6001140")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04001112 RID: 4370
		[Token(Token = "0x4001112")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04001113 RID: 4371
		[Token(Token = "0x4001113")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04001114 RID: 4372
		[Token(Token = "0x4001114")]
		[FieldOffset(Offset = "0x10")]
		public UpdateTimerDisplay <>4__this;
	}
}
