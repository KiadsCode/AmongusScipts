using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x0200019E RID: 414
[Token(Token = "0x200019E")]
public class AuthGame : Minigame
{
	// Token: 0x0600096A RID: 2410 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600096A")]
	[Address(RVA = "0x54DBA0", Offset = "0x54CFA0", VA = "0x1054DBA0")]
	private void OnDisable()
	{
	}

	// Token: 0x0600096B RID: 2411 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600096B")]
	[Address(RVA = "0x54D740", Offset = "0x54CB40", VA = "0x1054D740", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x0600096C RID: 2412 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600096C")]
	[Address(RVA = "0x54DAD0", Offset = "0x54CED0", VA = "0x1054DAD0", Slot = "5")]
	public override void Close()
	{
	}

	// Token: 0x0600096D RID: 2413 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600096D")]
	[Address(RVA = "0x54DC10", Offset = "0x54D010", VA = "0x1054DC10")]
	public void Update()
	{
	}

	// Token: 0x0600096E RID: 2414 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600096E")]
	[Address(RVA = "0x54D9A0", Offset = "0x54CDA0", VA = "0x1054D9A0")]
	public void ClickNumber(int i)
	{
	}

	// Token: 0x0600096F RID: 2415 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600096F")]
	[Address(RVA = "0x54D8A0", Offset = "0x54CCA0", VA = "0x1054D8A0")]
	public void ClearEntry()
	{
	}

	// Token: 0x06000970 RID: 2416 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000970")]
	[Address(RVA = "0x54DB30", Offset = "0x54CF30", VA = "0x1054DB30")]
	public void Enter()
	{
	}

	// Token: 0x06000971 RID: 2417 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000971")]
	[Address(RVA = "0x54D6F0", Offset = "0x54CAF0", VA = "0x1054D6F0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE07C0", Offset = "0xDFBC0")]
	private IEnumerator Animate()
	{
		return null;
	}

	// Token: 0x06000972 RID: 2418 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000972")]
	[Address(RVA = "0x54E060", Offset = "0x54D460", VA = "0x1054E060")]
	public AuthGame()
	{
	}

	// Token: 0x04000977 RID: 2423
	[Token(Token = "0x4000977")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshPro TargetText;

	// Token: 0x04000978 RID: 2424
	[Token(Token = "0x4000978")]
	[FieldOffset(Offset = "0x34")]
	public TextMeshPro NumberText;

	// Token: 0x04000979 RID: 2425
	[Token(Token = "0x4000979")]
	[FieldOffset(Offset = "0x38")]
	public TextMeshPro OtherStatusText;

	// Token: 0x0400097A RID: 2426
	[Token(Token = "0x400097A")]
	[FieldOffset(Offset = "0x3C")]
	public int number;

	// Token: 0x0400097B RID: 2427
	[Token(Token = "0x400097B")]
	[FieldOffset(Offset = "0x40")]
	public string numString;

	// Token: 0x0400097C RID: 2428
	[Token(Token = "0x400097C")]
	[FieldOffset(Offset = "0x44")]
	private bool animating;

	// Token: 0x0400097D RID: 2429
	[Token(Token = "0x400097D")]
	[FieldOffset(Offset = "0x48")]
	private HqHudSystemType system;

	// Token: 0x0400097E RID: 2430
	[Token(Token = "0x400097E")]
	[FieldOffset(Offset = "0x4C")]
	public SpriteRenderer OurLight;

	// Token: 0x0400097F RID: 2431
	[Token(Token = "0x400097F")]
	[FieldOffset(Offset = "0x50")]
	public SpriteRenderer TheirLight;

	// Token: 0x04000980 RID: 2432
	[Token(Token = "0x4000980")]
	[FieldOffset(Offset = "0x54")]
	public SpriteRenderer TimeBar;

	// Token: 0x04000981 RID: 2433
	[Token(Token = "0x4000981")]
	[FieldOffset(Offset = "0x58")]
	public AudioClip ButtonSound;

	// Token: 0x04000982 RID: 2434
	[Token(Token = "0x4000982")]
	[FieldOffset(Offset = "0x5C")]
	public AudioClip AcceptSound;

	// Token: 0x04000983 RID: 2435
	[Token(Token = "0x4000983")]
	[FieldOffset(Offset = "0x60")]
	public AudioClip RejectSound;

	// Token: 0x04000984 RID: 2436
	[Token(Token = "0x4000984")]
	[FieldOffset(Offset = "0x64")]
	private int OtherConsoleId;

	// Token: 0x04000985 RID: 2437
	[Token(Token = "0x4000985")]
	[FieldOffset(Offset = "0x68")]
	private bool evenColor;

	// Token: 0x04000986 RID: 2438
	[Token(Token = "0x4000986")]
	[FieldOffset(Offset = "0x6C")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xDD8F0", Offset = "0xDCCF0")]
	public UiElement BackButton;

	// Token: 0x04000987 RID: 2439
	[Token(Token = "0x4000987")]
	[FieldOffset(Offset = "0x70")]
	public UiElement DefaultButtonSelected;

	// Token: 0x04000988 RID: 2440
	[Token(Token = "0x4000988")]
	[FieldOffset(Offset = "0x74")]
	public List<UiElement> ControllerSelectable;

	// Token: 0x0200019F RID: 415
	[Token(Token = "0x200019F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <Animate>d__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000973 RID: 2419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000973")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <Animate>d__25(int <>1__state)
		{
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000974")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x000045A8 File Offset: 0x000027A8
		[Token(Token = "0x6000975")]
		[Address(RVA = "0x3C1F00", Offset = "0x3C1300", VA = "0x103C1F00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000976 RID: 2422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700016F")]
		private object Current
		{
			[Token(Token = "0x6000976")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000977")]
		[Address(RVA = "0x3C25C0", Offset = "0x3C19C0", VA = "0x103C25C0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000978 RID: 2424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000170")]
		private object Current
		{
			[Token(Token = "0x6000978")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000989 RID: 2441
		[Token(Token = "0x4000989")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x0400098A RID: 2442
		[Token(Token = "0x400098A")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x0400098B RID: 2443
		[Token(Token = "0x400098B")]
		[FieldOffset(Offset = "0x10")]
		public AuthGame <>4__this;

		// Token: 0x0400098C RID: 2444
		[Token(Token = "0x400098C")]
		[FieldOffset(Offset = "0x14")]
		private WaitForSeconds <wait>5__2;
	}
}
