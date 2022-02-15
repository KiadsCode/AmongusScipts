using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000158 RID: 344
[Token(Token = "0x2000158")]
public class AcceptDivertPowerGame : Minigame
{
	// Token: 0x060007E4 RID: 2020 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007E4")]
	[Address(RVA = "0x53C190", Offset = "0x53B590", VA = "0x1053C190")]
	public void Start()
	{
	}

	// Token: 0x060007E5 RID: 2021 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007E5")]
	[Address(RVA = "0x53C090", Offset = "0x53B490", VA = "0x1053C090")]
	public void DoSwitch()
	{
	}

	// Token: 0x060007E6 RID: 2022 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007E6")]
	[Address(RVA = "0x53C040", Offset = "0x53B440", VA = "0x1053C040")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDF820", Offset = "0xDEC20")]
	private IEnumerator CoDoSwitch()
	{
		return null;
	}

	// Token: 0x060007E7 RID: 2023 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007E7")]
	[Address(RVA = "0x53C340", Offset = "0x53B740", VA = "0x1053C340")]
	public void Update()
	{
	}

	// Token: 0x060007E8 RID: 2024 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007E8")]
	[Address(RVA = "0x3AC2A0", Offset = "0x3AB6A0", VA = "0x103AC2A0")]
	public AcceptDivertPowerGame()
	{
	}

	// Token: 0x060007E9 RID: 2025 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007E9")]
	[Address(RVA = "0x53C2B0", Offset = "0x53B6B0", VA = "0x1053C2B0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private void <CoDoSwitch>b__9_0(float t)
	{
	}

	// Token: 0x040007C5 RID: 1989
	[Token(Token = "0x40007C5")]
	[FieldOffset(Offset = "0x30")]
	private LineRenderer[] LeftWires;

	// Token: 0x040007C6 RID: 1990
	[Token(Token = "0x40007C6")]
	[FieldOffset(Offset = "0x34")]
	private LineRenderer[] RightWires;

	// Token: 0x040007C7 RID: 1991
	[Token(Token = "0x40007C7")]
	[FieldOffset(Offset = "0x38")]
	public GameObject RightWireParent;

	// Token: 0x040007C8 RID: 1992
	[Token(Token = "0x40007C8")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject LeftWireParent;

	// Token: 0x040007C9 RID: 1993
	[Token(Token = "0x40007C9")]
	[FieldOffset(Offset = "0x40")]
	public SpriteRenderer Switch;

	// Token: 0x040007CA RID: 1994
	[Token(Token = "0x40007CA")]
	[FieldOffset(Offset = "0x44")]
	public AudioClip SwitchSound;

	// Token: 0x040007CB RID: 1995
	[Token(Token = "0x40007CB")]
	[FieldOffset(Offset = "0x48")]
	private bool done;

	// Token: 0x040007CC RID: 1996
	[Token(Token = "0x40007CC")]
	[FieldOffset(Offset = "0x49")]
	private bool prevHadInput;

	// Token: 0x040007CD RID: 1997
	[Token(Token = "0x40007CD")]
	[FieldOffset(Offset = "0x4C")]
	private float rotateAngle;

	// Token: 0x040007CE RID: 1998
	[Token(Token = "0x40007CE")]
	[FieldOffset(Offset = "0x50")]
	private Vector2 prevStickDir;

	// Token: 0x02000159 RID: 345
	[Token(Token = "0x2000159")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoDoSwitch>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060007EA RID: 2026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoDoSwitch>d__9(int <>1__state)
		{
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x00004050 File Offset: 0x00002250
		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x3C4020", Offset = "0x3C3420", VA = "0x103C4020", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060007ED RID: 2029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000134")]
		private object Current
		{
			[Token(Token = "0x60007ED")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x3C4300", Offset = "0x3C3700", VA = "0x103C4300", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060007EF RID: 2031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000135")]
		private object Current
		{
			[Token(Token = "0x60007EF")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040007CF RID: 1999
		[Token(Token = "0x40007CF")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040007D0 RID: 2000
		[Token(Token = "0x40007D0")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040007D1 RID: 2001
		[Token(Token = "0x40007D1")]
		[FieldOffset(Offset = "0x10")]
		public AcceptDivertPowerGame <>4__this;
	}
}
