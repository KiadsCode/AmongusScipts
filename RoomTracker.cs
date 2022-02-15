using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000248 RID: 584
[Token(Token = "0x2000248")]
public class RoomTracker : MonoBehaviour
{
	// Token: 0x06000D03 RID: 3331 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D03")]
	[Address(RVA = "0x57E3E0", Offset = "0x57D7E0", VA = "0x1057E3E0")]
	public void Awake()
	{
	}

	// Token: 0x06000D04 RID: 3332 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D04")]
	[Address(RVA = "0x57E9D0", Offset = "0x57DDD0", VA = "0x1057E9D0")]
	public void OnDisable()
	{
	}

	// Token: 0x06000D05 RID: 3333 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D05")]
	[Address(RVA = "0x57E620", Offset = "0x57DA20", VA = "0x1057E620")]
	public void FixedUpdate()
	{
	}

	// Token: 0x06000D06 RID: 3334 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D06")]
	[Address(RVA = "0x57E5C0", Offset = "0x57D9C0", VA = "0x1057E5C0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE2EB0", Offset = "0xE22B0")]
	private IEnumerator CoSlideIn(SystemTypes newRoom)
	{
		return null;
	}

	// Token: 0x06000D07 RID: 3335 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D07")]
	[Address(RVA = "0x57EA60", Offset = "0x57DE60", VA = "0x1057EA60")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE2F50", Offset = "0xE2350")]
	private IEnumerator SlideOut()
	{
		return null;
	}

	// Token: 0x06000D08 RID: 3336 RVA: 0x00005208 File Offset: 0x00003408
	[Token(Token = "0x6000D08")]
	[Address(RVA = "0x57E460", Offset = "0x57D860", VA = "0x1057E460")]
	private static bool CheckHitsForPlayer(Collider2D[] buffer, int hitCount)
	{
		return default(bool);
	}

	// Token: 0x06000D09 RID: 3337 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D09")]
	[Address(RVA = "0x57EAB0", Offset = "0x57DEB0", VA = "0x1057EAB0")]
	public RoomTracker()
	{
	}

	// Token: 0x04000CDC RID: 3292
	[Token(Token = "0x4000CDC")]
	[FieldOffset(Offset = "0xC")]
	public TextMeshPro text;

	// Token: 0x04000CDD RID: 3293
	[Token(Token = "0x4000CDD")]
	[FieldOffset(Offset = "0x10")]
	public float SourceY;

	// Token: 0x04000CDE RID: 3294
	[Token(Token = "0x4000CDE")]
	[FieldOffset(Offset = "0x14")]
	public float TargetY;

	// Token: 0x04000CDF RID: 3295
	[Token(Token = "0x4000CDF")]
	[FieldOffset(Offset = "0x18")]
	private Collider2D playerCollider;

	// Token: 0x04000CE0 RID: 3296
	[Token(Token = "0x4000CE0")]
	[FieldOffset(Offset = "0x1C")]
	private ContactFilter2D filter;

	// Token: 0x04000CE1 RID: 3297
	[Token(Token = "0x4000CE1")]
	[FieldOffset(Offset = "0x38")]
	private Collider2D[] buffer;

	// Token: 0x04000CE2 RID: 3298
	[Token(Token = "0x4000CE2")]
	[FieldOffset(Offset = "0x3C")]
	public PlainShipRoom LastRoom;

	// Token: 0x04000CE3 RID: 3299
	[Token(Token = "0x4000CE3")]
	[FieldOffset(Offset = "0x40")]
	private Coroutine slideInRoutine;

	// Token: 0x02000249 RID: 585
	[Token(Token = "0x2000249")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoSlideIn>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000D0A RID: 3338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D0A")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoSlideIn>d__11(int <>1__state)
		{
		}

		// Token: 0x06000D0B RID: 3339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D0B")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000D0C RID: 3340 RVA: 0x00005220 File Offset: 0x00003420
		[Token(Token = "0x6000D0C")]
		[Address(RVA = "0x36A0B0", Offset = "0x3694B0", VA = "0x1036A0B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000D0D RID: 3341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001EB")]
		private object Current
		{
			[Token(Token = "0x6000D0D")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000D0E RID: 3342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D0E")]
		[Address(RVA = "0x36A330", Offset = "0x369730", VA = "0x1036A330", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000D0F RID: 3343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001EC")]
		private object Current
		{
			[Token(Token = "0x6000D0F")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000CE4 RID: 3300
		[Token(Token = "0x4000CE4")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000CE5 RID: 3301
		[Token(Token = "0x4000CE5")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000CE6 RID: 3302
		[Token(Token = "0x4000CE6")]
		[FieldOffset(Offset = "0x10")]
		public RoomTracker <>4__this;

		// Token: 0x04000CE7 RID: 3303
		[Token(Token = "0x4000CE7")]
		[FieldOffset(Offset = "0x14")]
		public SystemTypes newRoom;

		// Token: 0x04000CE8 RID: 3304
		[Token(Token = "0x4000CE8")]
		[FieldOffset(Offset = "0x18")]
		private Vector3 <tempPos>5__2;

		// Token: 0x04000CE9 RID: 3305
		[Token(Token = "0x4000CE9")]
		[FieldOffset(Offset = "0x24")]
		private Color <tempColor>5__3;

		// Token: 0x04000CEA RID: 3306
		[Token(Token = "0x4000CEA")]
		[FieldOffset(Offset = "0x34")]
		private float <timer>5__4;
	}

	// Token: 0x0200024A RID: 586
	[Token(Token = "0x200024A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <SlideOut>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000D10 RID: 3344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D10")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <SlideOut>d__12(int <>1__state)
		{
		}

		// Token: 0x06000D11 RID: 3345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D11")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000D12 RID: 3346 RVA: 0x00005238 File Offset: 0x00003438
		[Token(Token = "0x6000D12")]
		[Address(RVA = "0x36F7C0", Offset = "0x36EBC0", VA = "0x1036F7C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000D13 RID: 3347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001ED")]
		private object Current
		{
			[Token(Token = "0x6000D13")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000D14 RID: 3348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D14")]
		[Address(RVA = "0x36F9D0", Offset = "0x36EDD0", VA = "0x1036F9D0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000D15 RID: 3349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001EE")]
		private object Current
		{
			[Token(Token = "0x6000D15")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000CEB RID: 3307
		[Token(Token = "0x4000CEB")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000CEC RID: 3308
		[Token(Token = "0x4000CEC")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000CED RID: 3309
		[Token(Token = "0x4000CED")]
		[FieldOffset(Offset = "0x10")]
		public RoomTracker <>4__this;

		// Token: 0x04000CEE RID: 3310
		[Token(Token = "0x4000CEE")]
		[FieldOffset(Offset = "0x14")]
		private Vector3 <tempPos>5__2;

		// Token: 0x04000CEF RID: 3311
		[Token(Token = "0x4000CEF")]
		[FieldOffset(Offset = "0x20")]
		private Color <tempColor>5__3;

		// Token: 0x04000CF0 RID: 3312
		[Token(Token = "0x4000CF0")]
		[FieldOffset(Offset = "0x30")]
		private float <timer>5__4;
	}
}
