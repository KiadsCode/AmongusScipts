using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000323 RID: 803
[Token(Token = "0x2000323")]
public class NavigationMinigame : Minigame
{
	// Token: 0x060011A5 RID: 4517 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011A5")]
	[Address(RVA = "0x776DA0", Offset = "0x7761A0", VA = "0x10776DA0", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x060011A6 RID: 4518 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011A6")]
	[Address(RVA = "0x777010", Offset = "0x776410", VA = "0x10777010")]
	public void FixedUpdate()
	{
	}

	// Token: 0x060011A7 RID: 4519 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011A7")]
	[Address(RVA = "0x776FC0", Offset = "0x7763C0", VA = "0x10776FC0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE7660", Offset = "0xE6A60")]
	private IEnumerator CompleteGame()
	{
		return null;
	}

	// Token: 0x060011A8 RID: 4520 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011A8")]
	[Address(RVA = "0x777B30", Offset = "0x776F30", VA = "0x10777B30")]
	public NavigationMinigame()
	{
	}

	// Token: 0x04001193 RID: 4499
	[Token(Token = "0x4001193")]
	[FieldOffset(Offset = "0x30")]
	public MeshRenderer TwoAxisImage;

	// Token: 0x04001194 RID: 4500
	[Token(Token = "0x4001194")]
	[FieldOffset(Offset = "0x34")]
	public SpriteRenderer CrossHairImage;

	// Token: 0x04001195 RID: 4501
	[Token(Token = "0x4001195")]
	[FieldOffset(Offset = "0x38")]
	public Collider2D hitbox;

	// Token: 0x04001196 RID: 4502
	[Token(Token = "0x4001196")]
	[FieldOffset(Offset = "0x3C")]
	private Controller myController;

	// Token: 0x04001197 RID: 4503
	[Token(Token = "0x4001197")]
	[FieldOffset(Offset = "0x40")]
	private Vector2 crossHair;

	// Token: 0x04001198 RID: 4504
	[Token(Token = "0x4001198")]
	[FieldOffset(Offset = "0x48")]
	private Vector2 half;

	// Token: 0x04001199 RID: 4505
	[Token(Token = "0x4001199")]
	[FieldOffset(Offset = "0x50")]
	private Vector2 initialPos;

	// Token: 0x0400119A RID: 4506
	[Token(Token = "0x400119A")]
	[FieldOffset(Offset = "0x58")]
	private TouchpadBehavior touchpad;

	// Token: 0x0400119B RID: 4507
	[Token(Token = "0x400119B")]
	[FieldOffset(Offset = "0x5C")]
	private bool prevHadInput;

	// Token: 0x02000324 RID: 804
	[Token(Token = "0x2000324")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CompleteGame>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060011A9 RID: 4521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011A9")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CompleteGame>d__11(int <>1__state)
		{
		}

		// Token: 0x060011AA RID: 4522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011AA")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060011AB RID: 4523 RVA: 0x00006288 File Offset: 0x00004488
		[Token(Token = "0x60011AB")]
		[Address(RVA = "0x7965A0", Offset = "0x7959A0", VA = "0x107965A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x060011AC RID: 4524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002A7")]
		private object Current
		{
			[Token(Token = "0x60011AC")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060011AD RID: 4525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011AD")]
		[Address(RVA = "0x796A70", Offset = "0x795E70", VA = "0x10796A70", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x060011AE RID: 4526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002A8")]
		private object Current
		{
			[Token(Token = "0x60011AE")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400119C RID: 4508
		[Token(Token = "0x400119C")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x0400119D RID: 4509
		[Token(Token = "0x400119D")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x0400119E RID: 4510
		[Token(Token = "0x400119E")]
		[FieldOffset(Offset = "0x10")]
		public NavigationMinigame <>4__this;

		// Token: 0x0400119F RID: 4511
		[Token(Token = "0x400119F")]
		[FieldOffset(Offset = "0x14")]
		private WaitForSeconds <wait>5__2;

		// Token: 0x040011A0 RID: 4512
		[Token(Token = "0x40011A0")]
		[FieldOffset(Offset = "0x18")]
		private Color <green>5__3;

		// Token: 0x040011A1 RID: 4513
		[Token(Token = "0x40011A1")]
		[FieldOffset(Offset = "0x28")]
		private Color32 <yellow>5__4;
	}
}
