using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using PowerTools;
using UnityEngine;

// Token: 0x020001B9 RID: 441
[Token(Token = "0x20001B9")]
public class PlayerAnimator : MonoBehaviour
{
	// Token: 0x060009FE RID: 2558 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009FE")]
	[Address(RVA = "0x6607E0", Offset = "0x65FBE0", VA = "0x106607E0")]
	private void Start()
	{
	}

	// Token: 0x060009FF RID: 2559 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009FF")]
	[Address(RVA = "0x660600", Offset = "0x65FA00", VA = "0x10660600")]
	public void FixedUpdate()
	{
	}

	// Token: 0x06000A00 RID: 2560 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A00")]
	[Address(RVA = "0x6606B0", Offset = "0x65FAB0", VA = "0x106606B0")]
	public void LateUpdate()
	{
	}

	// Token: 0x06000A01 RID: 2561 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A01")]
	[Address(RVA = "0x6609C0", Offset = "0x65FDC0", VA = "0x106609C0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE0D70", Offset = "0xE0170")]
	public IEnumerator WalkPlayerTo(Vector2 worldPos, bool relax, float tolerance = 0.01f)
	{
		return null;
	}

	// Token: 0x06000A02 RID: 2562 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A02")]
	[Address(RVA = "0x660A40", Offset = "0x65FE40", VA = "0x10660A40")]
	public PlayerAnimator()
	{
	}

	// Token: 0x04000A19 RID: 2585
	[Token(Token = "0x4000A19")]
	[FieldOffset(Offset = "0xC")]
	public float Speed;

	// Token: 0x04000A1A RID: 2586
	[Token(Token = "0x4000A1A")]
	[FieldOffset(Offset = "0x10")]
	public VirtualJoystick joystick;

	// Token: 0x04000A1B RID: 2587
	[Token(Token = "0x4000A1B")]
	[FieldOffset(Offset = "0x14")]
	public SpriteRenderer UseButton;

	// Token: 0x04000A1C RID: 2588
	[Token(Token = "0x4000A1C")]
	[FieldOffset(Offset = "0x18")]
	public FingerBehaviour finger;

	// Token: 0x04000A1D RID: 2589
	[Token(Token = "0x4000A1D")]
	[FieldOffset(Offset = "0x1C")]
	public AnimationClip RunAnim;

	// Token: 0x04000A1E RID: 2590
	[Token(Token = "0x4000A1E")]
	[FieldOffset(Offset = "0x20")]
	public AnimationClip IdleAnim;

	// Token: 0x04000A1F RID: 2591
	[Token(Token = "0x4000A1F")]
	[FieldOffset(Offset = "0x24")]
	private Vector2 velocity;

	// Token: 0x04000A20 RID: 2592
	[Token(Token = "0x4000A20")]
	[FieldOffset(Offset = "0x2C")]
	[HideInInspector]
	private SpriteAnim Animator;

	// Token: 0x04000A21 RID: 2593
	[Token(Token = "0x4000A21")]
	[FieldOffset(Offset = "0x30")]
	[HideInInspector]
	private SpriteRenderer rend;

	// Token: 0x04000A22 RID: 2594
	[Token(Token = "0x4000A22")]
	[FieldOffset(Offset = "0x34")]
	public int NearbyConsoles;

	// Token: 0x020001BA RID: 442
	[Token(Token = "0x20001BA")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <WalkPlayerTo>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000A03 RID: 2563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A03")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <WalkPlayerTo>d__13(int <>1__state)
		{
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A04")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x00004770 File Offset: 0x00002970
		[Token(Token = "0x6000A05")]
		[Address(RVA = "0x79C060", Offset = "0x79B460", VA = "0x1079C060", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000A06 RID: 2566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000188")]
		private object Current
		{
			[Token(Token = "0x6000A06")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A07")]
		[Address(RVA = "0x79C2F0", Offset = "0x79B6F0", VA = "0x1079C2F0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000A08 RID: 2568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000189")]
		private object Current
		{
			[Token(Token = "0x6000A08")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000A23 RID: 2595
		[Token(Token = "0x4000A23")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000A24 RID: 2596
		[Token(Token = "0x4000A24")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000A25 RID: 2597
		[Token(Token = "0x4000A25")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 worldPos;

		// Token: 0x04000A26 RID: 2598
		[Token(Token = "0x4000A26")]
		[FieldOffset(Offset = "0x18")]
		public PlayerAnimator <>4__this;

		// Token: 0x04000A27 RID: 2599
		[Token(Token = "0x4000A27")]
		[FieldOffset(Offset = "0x1C")]
		public float tolerance;

		// Token: 0x04000A28 RID: 2600
		[Token(Token = "0x4000A28")]
		[FieldOffset(Offset = "0x20")]
		public bool relax;
	}
}
