using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000155 RID: 341
[Token(Token = "0x2000155")]
public class EdgeTransition : MonoBehaviour
{
	// Token: 0x060007D2 RID: 2002 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007D2")]
	[Address(RVA = "0x473F70", Offset = "0x473370", VA = "0x10473F70")]
	public void Awake()
	{
	}

	// Token: 0x060007D3 RID: 2003 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007D3")]
	[Address(RVA = "0x474100", Offset = "0x473500", VA = "0x10474100")]
	public void Open()
	{
	}

	// Token: 0x060007D4 RID: 2004 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007D4")]
	[Address(RVA = "0x4740B0", Offset = "0x4734B0", VA = "0x104740B0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDF780", Offset = "0xDEB80")]
	private IEnumerator CoOpen()
	{
		return null;
	}

	// Token: 0x060007D5 RID: 2005 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007D5")]
	[Address(RVA = "0x473FE0", Offset = "0x4733E0", VA = "0x10473FE0")]
	public void Close()
	{
	}

	// Token: 0x060007D6 RID: 2006 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007D6")]
	[Address(RVA = "0x474060", Offset = "0x473460", VA = "0x10474060")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDF7D0", Offset = "0xDEBD0")]
	private IEnumerator CoClose()
	{
		return null;
	}

	// Token: 0x060007D7 RID: 2007 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007D7")]
	[Address(RVA = "0x474180", Offset = "0x473580", VA = "0x10474180")]
	public EdgeTransition()
	{
	}

	// Token: 0x040007B4 RID: 1972
	[Token(Token = "0x40007B4")]
	[FieldOffset(Offset = "0xC")]
	public float Duration;

	// Token: 0x040007B5 RID: 1973
	[Token(Token = "0x40007B5")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 OpenPosition;

	// Token: 0x040007B6 RID: 1974
	[Token(Token = "0x40007B6")]
	[FieldOffset(Offset = "0x1C")]
	public Vector3 ClosedPosition;

	// Token: 0x040007B7 RID: 1975
	[Token(Token = "0x40007B7")]
	[FieldOffset(Offset = "0x28")]
	public AspectPosition.EdgeAlignments Alignment;

	// Token: 0x040007B8 RID: 1976
	[Token(Token = "0x40007B8")]
	[FieldOffset(Offset = "0x2C")]
	public Button.ButtonClickedEvent OnClose;

	// Token: 0x02000156 RID: 342
	[Token(Token = "0x2000156")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoOpen>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060007D8 RID: 2008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoOpen>d__7(int <>1__state)
		{
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x00004020 File Offset: 0x00002220
		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x7854B0", Offset = "0x7848B0", VA = "0x107854B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060007DB RID: 2011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000130")]
		private object Current
		{
			[Token(Token = "0x60007DB")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x785690", Offset = "0x784A90", VA = "0x10785690", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060007DD RID: 2013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000131")]
		private object Current
		{
			[Token(Token = "0x60007DD")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040007B9 RID: 1977
		[Token(Token = "0x40007B9")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040007BA RID: 1978
		[Token(Token = "0x40007BA")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040007BB RID: 1979
		[Token(Token = "0x40007BB")]
		[FieldOffset(Offset = "0x10")]
		public EdgeTransition <>4__this;

		// Token: 0x040007BC RID: 1980
		[Token(Token = "0x40007BC")]
		[FieldOffset(Offset = "0x14")]
		private Vector3 <sourcePos>5__2;

		// Token: 0x040007BD RID: 1981
		[Token(Token = "0x40007BD")]
		[FieldOffset(Offset = "0x20")]
		private Vector3 <targetPos>5__3;

		// Token: 0x040007BE RID: 1982
		[Token(Token = "0x40007BE")]
		[FieldOffset(Offset = "0x2C")]
		private float <timer>5__4;
	}

	// Token: 0x02000157 RID: 343
	[Token(Token = "0x2000157")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoClose>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060007DE RID: 2014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoClose>d__9(int <>1__state)
		{
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x00004038 File Offset: 0x00002238
		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x784520", Offset = "0x783920", VA = "0x10784520", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060007E1 RID: 2017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000132")]
		private object Current
		{
			[Token(Token = "0x60007E1")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x784710", Offset = "0x783B10", VA = "0x10784710", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060007E3 RID: 2019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000133")]
		private object Current
		{
			[Token(Token = "0x60007E3")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040007BF RID: 1983
		[Token(Token = "0x40007BF")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040007C0 RID: 1984
		[Token(Token = "0x40007C0")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040007C1 RID: 1985
		[Token(Token = "0x40007C1")]
		[FieldOffset(Offset = "0x10")]
		public EdgeTransition <>4__this;

		// Token: 0x040007C2 RID: 1986
		[Token(Token = "0x40007C2")]
		[FieldOffset(Offset = "0x14")]
		private Vector3 <sourcePos>5__2;

		// Token: 0x040007C3 RID: 1987
		[Token(Token = "0x40007C3")]
		[FieldOffset(Offset = "0x20")]
		private Vector3 <targetPos>5__3;

		// Token: 0x040007C4 RID: 1988
		[Token(Token = "0x40007C4")]
		[FieldOffset(Offset = "0x2C")]
		private float <timer>5__4;
	}
}
