using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004D4 RID: 1236
[Token(Token = "0x20004D4")]
public class SpinAnimator : MonoBehaviour
{
	// Token: 0x06001A4A RID: 6730 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A4A")]
	[Address(RVA = "0x4A6470", Offset = "0x4A5870", VA = "0x104A6470")]
	private void Update()
	{
	}

	// Token: 0x06001A4B RID: 6731 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A4B")]
	[Address(RVA = "0x4A61B0", Offset = "0x4A55B0", VA = "0x104A61B0")]
	public void Appear()
	{
	}

	// Token: 0x06001A4C RID: 6732 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A4C")]
	[Address(RVA = "0x4A62E0", Offset = "0x4A56E0", VA = "0x104A62E0")]
	public void Disappear()
	{
	}

	// Token: 0x06001A4D RID: 6733 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A4D")]
	[Address(RVA = "0x4A6290", Offset = "0x4A5690", VA = "0x104A6290")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE0C80", Offset = "0xE0080")]
	private IEnumerator CoDisappear()
	{
		return null;
	}

	// Token: 0x06001A4E RID: 6734 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A4E")]
	[Address(RVA = "0x4A6390", Offset = "0x4A5790", VA = "0x104A6390")]
	public void StartPulse()
	{
	}

	// Token: 0x06001A4F RID: 6735 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A4F")]
	[Address(RVA = "0x4A6360", Offset = "0x4A5760", VA = "0x104A6360")]
	internal void Play()
	{
	}

	// Token: 0x06001A50 RID: 6736 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A50")]
	[Address(RVA = "0x4A64E0", Offset = "0x4A58E0", VA = "0x104A64E0")]
	public SpinAnimator()
	{
	}

	// Token: 0x04001A77 RID: 6775
	[Token(Token = "0x4001A77")]
	[FieldOffset(Offset = "0xC")]
	public float Speed;

	// Token: 0x04001A78 RID: 6776
	[Token(Token = "0x4001A78")]
	[FieldOffset(Offset = "0x10")]
	public GameObject inputGlyph;

	// Token: 0x04001A79 RID: 6777
	[Token(Token = "0x4001A79")]
	[FieldOffset(Offset = "0x14")]
	private SpinAnimator.States curState;

	// Token: 0x020004D5 RID: 1237
	[Token(Token = "0x20004D5")]
	private enum States
	{
		// Token: 0x04001A7B RID: 6779
		[Token(Token = "0x4001A7B")]
		Visible,
		// Token: 0x04001A7C RID: 6780
		[Token(Token = "0x4001A7C")]
		Invisible,
		// Token: 0x04001A7D RID: 6781
		[Token(Token = "0x4001A7D")]
		Spinning,
		// Token: 0x04001A7E RID: 6782
		[Token(Token = "0x4001A7E")]
		Pulsing
	}

	// Token: 0x020004D6 RID: 1238
	[Token(Token = "0x20004D6")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoDisappear>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001A51 RID: 6737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A51")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoDisappear>d__7(int <>1__state)
		{
		}

		// Token: 0x06001A52 RID: 6738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A52")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001A53 RID: 6739 RVA: 0x00008328 File Offset: 0x00006528
		[Token(Token = "0x6001A53")]
		[Address(RVA = "0x367F60", Offset = "0x367360", VA = "0x10367F60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06001A54 RID: 6740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003CC")]
		private object Current
		{
			[Token(Token = "0x6001A54")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001A55 RID: 6741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A55")]
		[Address(RVA = "0x368050", Offset = "0x367450", VA = "0x10368050", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06001A56 RID: 6742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003CD")]
		private object Current
		{
			[Token(Token = "0x6001A56")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04001A7F RID: 6783
		[Token(Token = "0x4001A7F")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04001A80 RID: 6784
		[Token(Token = "0x4001A80")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04001A81 RID: 6785
		[Token(Token = "0x4001A81")]
		[FieldOffset(Offset = "0x10")]
		public SpinAnimator <>4__this;
	}
}
