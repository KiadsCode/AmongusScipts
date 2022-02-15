using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000425 RID: 1061
[Token(Token = "0x2000425")]
public class UnlockManifoldsMinigame : Minigame
{
	// Token: 0x06001655 RID: 5717 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001655")]
	[Address(RVA = "0x4B84D0", Offset = "0x4B78D0", VA = "0x104B84D0")]
	private void OnDisable()
	{
	}

	// Token: 0x06001656 RID: 5718 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001656")]
	[Address(RVA = "0x4B8070", Offset = "0x4B7470", VA = "0x104B8070", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x06001657 RID: 5719 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001657")]
	[Address(RVA = "0x4B82A0", Offset = "0x4B76A0", VA = "0x104B82A0")]
	public void HitButton(int idx)
	{
	}

	// Token: 0x06001658 RID: 5720 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001658")]
	[Address(RVA = "0x4B8540", Offset = "0x4B7940", VA = "0x104B8540")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDFA70", Offset = "0xDEE70")]
	private IEnumerator ResetAll()
	{
		return null;
	}

	// Token: 0x06001659 RID: 5721 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001659")]
	[Address(RVA = "0x3AC2A0", Offset = "0x3AB6A0", VA = "0x103AC2A0")]
	public UnlockManifoldsMinigame()
	{
	}

	// Token: 0x040016BA RID: 5818
	[Token(Token = "0x40016BA")]
	[FieldOffset(Offset = "0x30")]
	public SpriteRenderer[] Buttons;

	// Token: 0x040016BB RID: 5819
	[Token(Token = "0x40016BB")]
	[FieldOffset(Offset = "0x34")]
	public byte SystemId;

	// Token: 0x040016BC RID: 5820
	[Token(Token = "0x40016BC")]
	[FieldOffset(Offset = "0x38")]
	private int buttonCounter;

	// Token: 0x040016BD RID: 5821
	[Token(Token = "0x40016BD")]
	[FieldOffset(Offset = "0x3C")]
	private bool animating;

	// Token: 0x040016BE RID: 5822
	[Token(Token = "0x40016BE")]
	[FieldOffset(Offset = "0x40")]
	public AudioClip PressButtonSound;

	// Token: 0x040016BF RID: 5823
	[Token(Token = "0x40016BF")]
	[FieldOffset(Offset = "0x44")]
	public AudioClip FailSound;

	// Token: 0x040016C0 RID: 5824
	[Token(Token = "0x40016C0")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xDD8F0", Offset = "0xDCCF0")]
	public UiElement BackButton;

	// Token: 0x040016C1 RID: 5825
	[Token(Token = "0x40016C1")]
	[FieldOffset(Offset = "0x4C")]
	public UiElement DefaultButtonSelected;

	// Token: 0x040016C2 RID: 5826
	[Token(Token = "0x40016C2")]
	[FieldOffset(Offset = "0x50")]
	public List<UiElement> ControllerSelectable;

	// Token: 0x02000426 RID: 1062
	[Token(Token = "0x2000426")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <ResetAll>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600165A RID: 5722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600165A")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <ResetAll>d__12(int <>1__state)
		{
		}

		// Token: 0x0600165B RID: 5723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600165B")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600165C RID: 5724 RVA: 0x000070F8 File Offset: 0x000052F8
		[Token(Token = "0x600165C")]
		[Address(RVA = "0x1300B30", Offset = "0x12FFF30", VA = "0x11300B30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x0600165D RID: 5725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000326")]
		private object Current
		{
			[Token(Token = "0x600165D")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600165E RID: 5726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600165E")]
		[Address(RVA = "0x1300EA0", Offset = "0x13002A0", VA = "0x11300EA0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x0600165F RID: 5727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000327")]
		private object Current
		{
			[Token(Token = "0x600165F")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040016C3 RID: 5827
		[Token(Token = "0x40016C3")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040016C4 RID: 5828
		[Token(Token = "0x40016C4")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040016C5 RID: 5829
		[Token(Token = "0x40016C5")]
		[FieldOffset(Offset = "0x10")]
		public UnlockManifoldsMinigame <>4__this;
	}
}
