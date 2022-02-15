using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000068 RID: 104
[Token(Token = "0x2000068")]
public class AirshipAuthGame : Minigame
{
	// Token: 0x060002BA RID: 698 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002BA")]
	[Address(RVA = "0x543B60", Offset = "0x542F60", VA = "0x10543B60", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x060002BB RID: 699 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002BB")]
	[Address(RVA = "0x543F00", Offset = "0x543300", VA = "0x10543F00", Slot = "5")]
	public override void Close()
	{
	}

	// Token: 0x060002BC RID: 700 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002BC")]
	[Address(RVA = "0x544030", Offset = "0x543430", VA = "0x10544030")]
	public void Update()
	{
	}

	// Token: 0x060002BD RID: 701 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002BD")]
	[Address(RVA = "0x543DD0", Offset = "0x5431D0", VA = "0x10543DD0")]
	public void ClickNumber(int i)
	{
	}

	// Token: 0x060002BE RID: 702 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002BE")]
	[Address(RVA = "0x543CD0", Offset = "0x5430D0", VA = "0x10543CD0")]
	public void ClearEntry()
	{
	}

	// Token: 0x060002BF RID: 703 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002BF")]
	[Address(RVA = "0x543FC0", Offset = "0x5433C0", VA = "0x10543FC0")]
	public void Enter()
	{
	}

	// Token: 0x060002C0 RID: 704 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002C0")]
	[Address(RVA = "0x543B10", Offset = "0x542F10", VA = "0x10543B10")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE5110", Offset = "0xE4510")]
	private IEnumerator Animate()
	{
		return null;
	}

	// Token: 0x060002C1 RID: 705 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002C1")]
	[Address(RVA = "0x544480", Offset = "0x543880", VA = "0x10544480")]
	public AirshipAuthGame()
	{
	}

	// Token: 0x0400026D RID: 621
	[Token(Token = "0x400026D")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshPro TargetText;

	// Token: 0x0400026E RID: 622
	[Token(Token = "0x400026E")]
	[FieldOffset(Offset = "0x34")]
	public TextMeshPro NumberText;

	// Token: 0x0400026F RID: 623
	[Token(Token = "0x400026F")]
	[FieldOffset(Offset = "0x38")]
	public TextMeshPro OtherStatusText;

	// Token: 0x04000270 RID: 624
	[Token(Token = "0x4000270")]
	[FieldOffset(Offset = "0x3C")]
	public int number;

	// Token: 0x04000271 RID: 625
	[Token(Token = "0x4000271")]
	[FieldOffset(Offset = "0x40")]
	public string numString;

	// Token: 0x04000272 RID: 626
	[Token(Token = "0x4000272")]
	[FieldOffset(Offset = "0x44")]
	private bool animating;

	// Token: 0x04000273 RID: 627
	[Token(Token = "0x4000273")]
	[FieldOffset(Offset = "0x48")]
	private HeliSabotageSystem system;

	// Token: 0x04000274 RID: 628
	[Token(Token = "0x4000274")]
	[FieldOffset(Offset = "0x4C")]
	public SpriteRenderer OurLight;

	// Token: 0x04000275 RID: 629
	[Token(Token = "0x4000275")]
	[FieldOffset(Offset = "0x50")]
	public SpriteRenderer TheirLight;

	// Token: 0x04000276 RID: 630
	[Token(Token = "0x4000276")]
	[FieldOffset(Offset = "0x54")]
	public SpriteRenderer TimeBar;

	// Token: 0x04000277 RID: 631
	[Token(Token = "0x4000277")]
	[FieldOffset(Offset = "0x58")]
	public AudioClip ButtonSound;

	// Token: 0x04000278 RID: 632
	[Token(Token = "0x4000278")]
	[FieldOffset(Offset = "0x5C")]
	public AudioClip AcceptSound;

	// Token: 0x04000279 RID: 633
	[Token(Token = "0x4000279")]
	[FieldOffset(Offset = "0x60")]
	public AudioClip RejectSound;

	// Token: 0x0400027A RID: 634
	[Token(Token = "0x400027A")]
	[FieldOffset(Offset = "0x64")]
	private int OtherConsoleId;

	// Token: 0x0400027B RID: 635
	[Token(Token = "0x400027B")]
	[FieldOffset(Offset = "0x68")]
	private bool evenColor;

	// Token: 0x0400027C RID: 636
	[Token(Token = "0x400027C")]
	[FieldOffset(Offset = "0x6C")]
	public UiElement defaultSelection;

	// Token: 0x0400027D RID: 637
	[Token(Token = "0x400027D")]
	[FieldOffset(Offset = "0x70")]
	public UiElement closeButton;

	// Token: 0x0400027E RID: 638
	[Token(Token = "0x400027E")]
	[FieldOffset(Offset = "0x74")]
	public List<UiElement> selectableButtons;

	// Token: 0x02000069 RID: 105
	[Token(Token = "0x2000069")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <Animate>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060002C2 RID: 706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <Animate>d__24(int <>1__state)
		{
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00002730 File Offset: 0x00000930
		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x3C1810", Offset = "0x3C0C10", VA = "0x103C1810", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060002C5 RID: 709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000066")]
		private object Current
		{
			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x3C1ED0", Offset = "0x3C12D0", VA = "0x103C1ED0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060002C7 RID: 711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000067")]
		private object Current
		{
			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400027F RID: 639
		[Token(Token = "0x400027F")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000280 RID: 640
		[Token(Token = "0x4000280")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000281 RID: 641
		[Token(Token = "0x4000281")]
		[FieldOffset(Offset = "0x10")]
		public AirshipAuthGame <>4__this;

		// Token: 0x04000282 RID: 642
		[Token(Token = "0x4000282")]
		[FieldOffset(Offset = "0x14")]
		private WaitForSeconds <wait>5__2;
	}
}
