using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using PowerTools;
using UnityEngine;

// Token: 0x02000152 RID: 338
[Token(Token = "0x2000152")]
public class DripBehaviour : MonoBehaviour
{
	// Token: 0x060007C7 RID: 1991 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007C7")]
	[Address(RVA = "0x46BF30", Offset = "0x46B330", VA = "0x1046BF30")]
	public void Start()
	{
	}

	// Token: 0x060007C8 RID: 1992 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007C8")]
	[Address(RVA = "0x46BEE0", Offset = "0x46B2E0", VA = "0x1046BEE0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDF6E0", Offset = "0xDEAE0")]
	private IEnumerator Run()
	{
		return null;
	}

	// Token: 0x060007C9 RID: 1993 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007C9")]
	[Address(RVA = "0x46BF90", Offset = "0x46B390", VA = "0x1046BF90")]
	public DripBehaviour()
	{
	}

	// Token: 0x040007AA RID: 1962
	[Token(Token = "0x40007AA")]
	[FieldOffset(Offset = "0xC")]
	public Vector2Range SpawnArea;

	// Token: 0x040007AB RID: 1963
	[Token(Token = "0x40007AB")]
	[FieldOffset(Offset = "0x1C")]
	public FloatRange FirstWait;

	// Token: 0x040007AC RID: 1964
	[Token(Token = "0x40007AC")]
	[FieldOffset(Offset = "0x20")]
	public FloatRange Frequency;

	// Token: 0x040007AD RID: 1965
	[Token(Token = "0x40007AD")]
	[FieldOffset(Offset = "0x24")]
	public SpriteAnim myAnim;

	// Token: 0x040007AE RID: 1966
	[Token(Token = "0x40007AE")]
	[FieldOffset(Offset = "0x28")]
	public Collider2D[] IgnoreAreas;

	// Token: 0x040007AF RID: 1967
	[Token(Token = "0x40007AF")]
	[FieldOffset(Offset = "0x2C")]
	public bool FixDepth;

	// Token: 0x02000153 RID: 339
	[Token(Token = "0x2000153")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass7_0
	{
		// Token: 0x060007CA RID: 1994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass7_0()
		{
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x00003FF0 File Offset: 0x000021F0
		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x78D990", Offset = "0x78CD90", VA = "0x1078D990")]
		internal bool <Run>b__0(Collider2D i)
		{
			return default(bool);
		}

		// Token: 0x040007B0 RID: 1968
		[Token(Token = "0x40007B0")]
		[FieldOffset(Offset = "0x8")]
		public Vector3 pos;
	}

	// Token: 0x02000154 RID: 340
	[Token(Token = "0x2000154")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <Run>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060007CC RID: 1996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <Run>d__7(int <>1__state)
		{
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x00004008 File Offset: 0x00002208
		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x78B0D0", Offset = "0x78A4D0", VA = "0x1078B0D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060007CF RID: 1999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700012E")]
		private object Current
		{
			[Token(Token = "0x60007CF")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x78B3F0", Offset = "0x78A7F0", VA = "0x1078B3F0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060007D1 RID: 2001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700012F")]
		private object Current
		{
			[Token(Token = "0x60007D1")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040007B1 RID: 1969
		[Token(Token = "0x40007B1")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040007B2 RID: 1970
		[Token(Token = "0x40007B2")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040007B3 RID: 1971
		[Token(Token = "0x40007B3")]
		[FieldOffset(Offset = "0x10")]
		public DripBehaviour <>4__this;
	}
}
