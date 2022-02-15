using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000332 RID: 818
[Token(Token = "0x2000332")]
public class BoardPassGame : Minigame
{
	// Token: 0x060011DE RID: 4574 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011DE")]
	[Address(RVA = "0x828F90", Offset = "0x828390", VA = "0x10828F90")]
	public void Start()
	{
	}

	// Token: 0x060011DF RID: 4575 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011DF")]
	[Address(RVA = "0x829380", Offset = "0x828780", VA = "0x10829380")]
	public void Update()
	{
	}

	// Token: 0x060011E0 RID: 4576 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011E0")]
	[Address(RVA = "0x828E30", Offset = "0x828230", VA = "0x10828E30")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE7840", Offset = "0xE6C40")]
	private IEnumerator CoRunBlinky()
	{
		return null;
	}

	// Token: 0x060011E1 RID: 4577 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011E1")]
	[Address(RVA = "0x828F30", Offset = "0x828330", VA = "0x10828F30")]
	public void PullPass()
	{
	}

	// Token: 0x060011E2 RID: 4578 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011E2")]
	[Address(RVA = "0x828DE0", Offset = "0x8281E0", VA = "0x10828DE0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE7940", Offset = "0xE6D40")]
	private IEnumerator CoPullPass()
	{
		return null;
	}

	// Token: 0x060011E3 RID: 4579 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011E3")]
	[Address(RVA = "0x828EE0", Offset = "0x8282E0", VA = "0x10828EE0")]
	public void Grab()
	{
	}

	// Token: 0x060011E4 RID: 4580 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011E4")]
	[Address(RVA = "0x828E80", Offset = "0x828280", VA = "0x10828E80")]
	public void FlipPass()
	{
	}

	// Token: 0x060011E5 RID: 4581 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011E5")]
	[Address(RVA = "0x828D90", Offset = "0x828190", VA = "0x10828D90")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE7990", Offset = "0xE6D90")]
	private IEnumerator CoFlipPass()
	{
		return null;
	}

	// Token: 0x060011E6 RID: 4582 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011E6")]
	[Address(RVA = "0x3AC2A0", Offset = "0x3AB6A0", VA = "0x103AC2A0")]
	public BoardPassGame()
	{
	}

	// Token: 0x060011E8 RID: 4584 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011E8")]
	[Address(RVA = "0x829260", Offset = "0x828660", VA = "0x10829260")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private void <CoFlipPass>b__35_0(float t)
	{
	}

	// Token: 0x060011E9 RID: 4585 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011E9")]
	[Address(RVA = "0x8292F0", Offset = "0x8286F0", VA = "0x108292F0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private void <CoFlipPass>b__35_1(float t)
	{
	}

	// Token: 0x040011C9 RID: 4553
	[Token(Token = "0x40011C9")]
	[FieldOffset(Offset = "0x0")]
	private static Color[] BgColors;

	// Token: 0x040011CA RID: 4554
	[Token(Token = "0x40011CA")]
	[FieldOffset(Offset = "0x30")]
	public SpriteRenderer renderer;

	// Token: 0x040011CB RID: 4555
	[Token(Token = "0x40011CB")]
	[FieldOffset(Offset = "0x34")]
	public SpriteRenderer pass;

	// Token: 0x040011CC RID: 4556
	[Token(Token = "0x40011CC")]
	[FieldOffset(Offset = "0x38")]
	public Sprite passBack;

	// Token: 0x040011CD RID: 4557
	[Token(Token = "0x40011CD")]
	[FieldOffset(Offset = "0x3C")]
	public TextMeshPro NameText;

	// Token: 0x040011CE RID: 4558
	[Token(Token = "0x40011CE")]
	[FieldOffset(Offset = "0x40")]
	public SpriteRenderer ImageBg;

	// Token: 0x040011CF RID: 4559
	[Token(Token = "0x40011CF")]
	[FieldOffset(Offset = "0x44")]
	public SpriteRenderer Image;

	// Token: 0x040011D0 RID: 4560
	[Token(Token = "0x40011D0")]
	[FieldOffset(Offset = "0x48")]
	public Sprite[] Photos;

	// Token: 0x040011D1 RID: 4561
	[Token(Token = "0x40011D1")]
	[FieldOffset(Offset = "0x4C")]
	public PassiveButton pullButton;

	// Token: 0x040011D2 RID: 4562
	[Token(Token = "0x40011D2")]
	[FieldOffset(Offset = "0x50")]
	public PassiveButton flipButton;

	// Token: 0x040011D3 RID: 4563
	[Token(Token = "0x40011D3")]
	[FieldOffset(Offset = "0x54")]
	public SpriteRenderer Scanner;

	// Token: 0x040011D4 RID: 4564
	[Token(Token = "0x40011D4")]
	[FieldOffset(Offset = "0x58")]
	public Sprite ScannerAccept;

	// Token: 0x040011D5 RID: 4565
	[Token(Token = "0x40011D5")]
	[FieldOffset(Offset = "0x5C")]
	public Sprite ScannerScanning;

	// Token: 0x040011D6 RID: 4566
	[Token(Token = "0x40011D6")]
	[FieldOffset(Offset = "0x60")]
	public Sprite ScannerWaiting;

	// Token: 0x040011D7 RID: 4567
	[Token(Token = "0x40011D7")]
	[FieldOffset(Offset = "0x64")]
	public Collider2D Sensor;

	// Token: 0x040011D8 RID: 4568
	[Token(Token = "0x40011D8")]
	[FieldOffset(Offset = "0x68")]
	public Collider2D BarCode;

	// Token: 0x040011D9 RID: 4569
	[Token(Token = "0x40011D9")]
	[FieldOffset(Offset = "0x6C")]
	public AudioClip slideinSound;

	// Token: 0x040011DA RID: 4570
	[Token(Token = "0x40011DA")]
	[FieldOffset(Offset = "0x70")]
	public AudioClip flipSound;

	// Token: 0x040011DB RID: 4571
	[Token(Token = "0x40011DB")]
	[FieldOffset(Offset = "0x74")]
	public AudioClip scanStartSound;

	// Token: 0x040011DC RID: 4572
	[Token(Token = "0x40011DC")]
	[FieldOffset(Offset = "0x78")]
	public AudioClip scanSound;

	// Token: 0x040011DD RID: 4573
	[Token(Token = "0x40011DD")]
	[FieldOffset(Offset = "0x7C")]
	private Coroutine blinky;

	// Token: 0x040011DE RID: 4574
	[Token(Token = "0x40011DE")]
	[FieldOffset(Offset = "0x80")]
	private Controller controller;

	// Token: 0x040011DF RID: 4575
	[Token(Token = "0x40011DF")]
	[FieldOffset(Offset = "0x84")]
	private TouchpadBehavior touchpad;

	// Token: 0x040011E0 RID: 4576
	[Token(Token = "0x40011E0")]
	[FieldOffset(Offset = "0x88")]
	private bool prevHadInput;

	// Token: 0x040011E1 RID: 4577
	[Token(Token = "0x40011E1")]
	[FieldOffset(Offset = "0x8C")]
	private float rotateAngle;

	// Token: 0x040011E2 RID: 4578
	[Token(Token = "0x40011E2")]
	[FieldOffset(Offset = "0x90")]
	private Vector2 prevStickDir;

	// Token: 0x040011E3 RID: 4579
	[Token(Token = "0x40011E3")]
	[FieldOffset(Offset = "0x98")]
	private bool enableControllerPassMovement;

	// Token: 0x040011E4 RID: 4580
	[Token(Token = "0x40011E4")]
	[FieldOffset(Offset = "0x99")]
	private bool grabbed;

	// Token: 0x02000333 RID: 819
	[Token(Token = "0x2000333")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoRunBlinky>d__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060011EA RID: 4586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011EA")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoRunBlinky>d__29(int <>1__state)
		{
		}

		// Token: 0x060011EB RID: 4587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011EB")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060011EC RID: 4588 RVA: 0x00006300 File Offset: 0x00004500
		[Token(Token = "0x60011EC")]
		[Address(RVA = "0x3C5900", Offset = "0x3C4D00", VA = "0x103C5900", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x060011ED RID: 4589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002AD")]
		private object Current
		{
			[Token(Token = "0x60011ED")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060011EE RID: 4590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011EE")]
		[Address(RVA = "0x3C5BA0", Offset = "0x3C4FA0", VA = "0x103C5BA0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x060011EF RID: 4591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002AE")]
		private object Current
		{
			[Token(Token = "0x60011EF")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040011E5 RID: 4581
		[Token(Token = "0x40011E5")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040011E6 RID: 4582
		[Token(Token = "0x40011E6")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040011E7 RID: 4583
		[Token(Token = "0x40011E7")]
		[FieldOffset(Offset = "0x10")]
		public BoardPassGame <>4__this;

		// Token: 0x040011E8 RID: 4584
		[Token(Token = "0x40011E8")]
		[FieldOffset(Offset = "0x14")]
		private int <i>5__2;
	}

	// Token: 0x02000334 RID: 820
	[Token(Token = "0x2000334")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoPullPass>d__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060011F0 RID: 4592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011F0")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoPullPass>d__31(int <>1__state)
		{
		}

		// Token: 0x060011F1 RID: 4593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011F1")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060011F2 RID: 4594 RVA: 0x00006318 File Offset: 0x00004518
		[Token(Token = "0x60011F2")]
		[Address(RVA = "0x3C5710", Offset = "0x3C4B10", VA = "0x103C5710", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x060011F3 RID: 4595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002AF")]
		private object Current
		{
			[Token(Token = "0x60011F3")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060011F4 RID: 4596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011F4")]
		[Address(RVA = "0x3C58D0", Offset = "0x3C4CD0", VA = "0x103C58D0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x060011F5 RID: 4597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002B0")]
		private object Current
		{
			[Token(Token = "0x60011F5")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040011E9 RID: 4585
		[Token(Token = "0x40011E9")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040011EA RID: 4586
		[Token(Token = "0x40011EA")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040011EB RID: 4587
		[Token(Token = "0x40011EB")]
		[FieldOffset(Offset = "0x10")]
		public BoardPassGame <>4__this;
	}

	// Token: 0x02000335 RID: 821
	[Token(Token = "0x2000335")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoFlipPass>d__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060011F6 RID: 4598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011F6")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoFlipPass>d__35(int <>1__state)
		{
		}

		// Token: 0x060011F7 RID: 4599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011F7")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060011F8 RID: 4600 RVA: 0x00006330 File Offset: 0x00004530
		[Token(Token = "0x60011F8")]
		[Address(RVA = "0x3C46E0", Offset = "0x3C3AE0", VA = "0x103C46E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x060011F9 RID: 4601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002B1")]
		private object Current
		{
			[Token(Token = "0x60011F9")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060011FA RID: 4602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011FA")]
		[Address(RVA = "0x3C4A70", Offset = "0x3C3E70", VA = "0x103C4A70", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x060011FB RID: 4603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002B2")]
		private object Current
		{
			[Token(Token = "0x60011FB")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040011EC RID: 4588
		[Token(Token = "0x40011EC")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040011ED RID: 4589
		[Token(Token = "0x40011ED")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040011EE RID: 4590
		[Token(Token = "0x40011EE")]
		[FieldOffset(Offset = "0x10")]
		public BoardPassGame <>4__this;
	}
}
