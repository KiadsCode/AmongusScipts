using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000182 RID: 386
[Token(Token = "0x2000182")]
public class FollowerCamera : MonoBehaviour
{
	// Token: 0x060008CB RID: 2251 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008CB")]
	[Address(RVA = "0x3A9630", Offset = "0x3A8A30", VA = "0x103A9630")]
	public void Update()
	{
	}

	// Token: 0x060008CC RID: 2252 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008CC")]
	[Address(RVA = "0x3A94F0", Offset = "0x3A88F0", VA = "0x103A94F0")]
	public void ShakeScreen(float duration, float severity)
	{
	}

	// Token: 0x060008CD RID: 2253 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008CD")]
	[Address(RVA = "0x3A93B0", Offset = "0x3A87B0", VA = "0x103A93B0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE02B0", Offset = "0xDF6B0")]
	private IEnumerator CoShakeScreen(float duration, float severity)
	{
		return null;
	}

	// Token: 0x060008CE RID: 2254 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008CE")]
	[Address(RVA = "0x3A9420", Offset = "0x3A8820", VA = "0x103A9420")]
	internal void SetTarget(MonoBehaviour target)
	{
	}

	// Token: 0x060008CF RID: 2255 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008CF")]
	[Address(RVA = "0x3A9560", Offset = "0x3A8960", VA = "0x103A9560")]
	public void SnapToTarget()
	{
	}

	// Token: 0x060008D0 RID: 2256 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008D0")]
	[Address(RVA = "0x3A9880", Offset = "0x3A8C80", VA = "0x103A9880")]
	public FollowerCamera()
	{
	}

	// Token: 0x040008D7 RID: 2263
	[Token(Token = "0x40008D7")]
	[FieldOffset(Offset = "0xC")]
	public MonoBehaviour Target;

	// Token: 0x040008D8 RID: 2264
	[Token(Token = "0x40008D8")]
	[FieldOffset(Offset = "0x10")]
	public Vector2 Offset;

	// Token: 0x040008D9 RID: 2265
	[Token(Token = "0x40008D9")]
	[FieldOffset(Offset = "0x18")]
	public bool Locked;

	// Token: 0x040008DA RID: 2266
	[Token(Token = "0x40008DA")]
	[FieldOffset(Offset = "0x1C")]
	public float shakeAmount;

	// Token: 0x040008DB RID: 2267
	[Token(Token = "0x40008DB")]
	[FieldOffset(Offset = "0x20")]
	public float shakePeriod;

	// Token: 0x040008DC RID: 2268
	[Token(Token = "0x40008DC")]
	[FieldOffset(Offset = "0x24")]
	private Vector2 centerPosition;

	// Token: 0x02000183 RID: 387
	[Token(Token = "0x2000183")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoShakeScreen>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060008D1 RID: 2257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoShakeScreen>d__8(int <>1__state)
		{
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x00004380 File Offset: 0x00002580
		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x7864F0", Offset = "0x7858F0", VA = "0x107864F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x060008D4 RID: 2260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000157")]
		private object Current
		{
			[Token(Token = "0x60008D4")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x786630", Offset = "0x785A30", VA = "0x10786630", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060008D6 RID: 2262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000158")]
		private object Current
		{
			[Token(Token = "0x60008D6")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040008DD RID: 2269
		[Token(Token = "0x40008DD")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040008DE RID: 2270
		[Token(Token = "0x40008DE")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040008DF RID: 2271
		[Token(Token = "0x40008DF")]
		[FieldOffset(Offset = "0x10")]
		public float duration;

		// Token: 0x040008E0 RID: 2272
		[Token(Token = "0x40008E0")]
		[FieldOffset(Offset = "0x14")]
		public FollowerCamera <>4__this;

		// Token: 0x040008E1 RID: 2273
		[Token(Token = "0x40008E1")]
		[FieldOffset(Offset = "0x18")]
		public float severity;

		// Token: 0x040008E2 RID: 2274
		[Token(Token = "0x40008E2")]
		[FieldOffset(Offset = "0x1C")]
		private WaitForFixedUpdate <wait>5__2;

		// Token: 0x040008E3 RID: 2275
		[Token(Token = "0x40008E3")]
		[FieldOffset(Offset = "0x20")]
		private float <t>5__3;
	}
}
