using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using PowerTools;
using UnityEngine;

// Token: 0x0200017D RID: 381
[Token(Token = "0x200017D")]
public class SteamBehaviour : MonoBehaviour
{
	// Token: 0x060008B8 RID: 2232 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008B8")]
	[Address(RVA = "0x75A660", Offset = "0x759A60", VA = "0x1075A660")]
	public void OnEnable()
	{
	}

	// Token: 0x060008B9 RID: 2233 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008B9")]
	[Address(RVA = "0x75A6C0", Offset = "0x759AC0", VA = "0x1075A6C0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE0260", Offset = "0xDF660")]
	private IEnumerator Run()
	{
		return null;
	}

	// Token: 0x060008BA RID: 2234 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008BA")]
	[Address(RVA = "0x75A710", Offset = "0x759B10", VA = "0x1075A710")]
	public SteamBehaviour()
	{
	}

	// Token: 0x040008C0 RID: 2240
	[Token(Token = "0x40008C0")]
	[FieldOffset(Offset = "0xC")]
	public SpriteAnim anim;

	// Token: 0x040008C1 RID: 2241
	[Token(Token = "0x40008C1")]
	[FieldOffset(Offset = "0x10")]
	public FloatRange PlayRate;

	// Token: 0x0200017E RID: 382
	[Token(Token = "0x200017E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <Run>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060008BB RID: 2235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008BB")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <Run>d__3(int <>1__state)
		{
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008BC")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x00004368 File Offset: 0x00002568
		[Token(Token = "0x60008BD")]
		[Address(RVA = "0x36ED00", Offset = "0x36E100", VA = "0x1036ED00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060008BE RID: 2238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000155")]
		private object Current
		{
			[Token(Token = "0x60008BE")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008BF")]
		[Address(RVA = "0x36EDF0", Offset = "0x36E1F0", VA = "0x1036EDF0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060008C0 RID: 2240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000156")]
		private object Current
		{
			[Token(Token = "0x60008C0")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040008C2 RID: 2242
		[Token(Token = "0x40008C2")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040008C3 RID: 2243
		[Token(Token = "0x40008C3")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040008C4 RID: 2244
		[Token(Token = "0x40008C4")]
		[FieldOffset(Offset = "0x10")]
		public SteamBehaviour <>4__this;

		// Token: 0x040008C5 RID: 2245
		[Token(Token = "0x40008C5")]
		[FieldOffset(Offset = "0x14")]
		private float <time>5__2;
	}
}
