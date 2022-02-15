using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Rewired;
using UnityEngine;

// Token: 0x0200033A RID: 826
[Token(Token = "0x200033A")]
public class FillCanistersGame : Minigame
{
	// Token: 0x0600120B RID: 4619 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600120B")]
	[Address(RVA = "0x3A5DC0", Offset = "0x3A51C0", VA = "0x103A5DC0")]
	public void Start()
	{
	}

	// Token: 0x0600120C RID: 4620 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600120C")]
	[Address(RVA = "0x3A5D00", Offset = "0x3A5100", VA = "0x103A5D00", Slot = "5")]
	public override void Close()
	{
	}

	// Token: 0x0600120D RID: 4621 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600120D")]
	[Address(RVA = "0x3A5D70", Offset = "0x3A5170", VA = "0x103A5D70")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE79E0", Offset = "0xE6DE0")]
	private IEnumerator Run()
	{
		return null;
	}

	// Token: 0x0600120E RID: 4622 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600120E")]
	[Address(RVA = "0x3A5E90", Offset = "0x3A5290", VA = "0x103A5E90")]
	public FillCanistersGame()
	{
	}

	// Token: 0x0600120F RID: 4623 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600120F")]
	[Address(RVA = "0x3A5E60", Offset = "0x3A5260", VA = "0x103A5E60")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private void <Run>b__17_0(float t)
	{
	}

	// Token: 0x04001200 RID: 4608
	[Token(Token = "0x4001200")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 CanisterAppearPosition;

	// Token: 0x04001201 RID: 4609
	[Token(Token = "0x4001201")]
	[FieldOffset(Offset = "0x3C")]
	private Vector3 CanisterStartPosition;

	// Token: 0x04001202 RID: 4610
	[Token(Token = "0x4001202")]
	[FieldOffset(Offset = "0x48")]
	private Vector3 CanisterDragPosition;

	// Token: 0x04001203 RID: 4611
	[Token(Token = "0x4001203")]
	[FieldOffset(Offset = "0x54")]
	private Vector3 CanisterSnapPosition;

	// Token: 0x04001204 RID: 4612
	[Token(Token = "0x4001204")]
	[FieldOffset(Offset = "0x60")]
	private Vector3 CanisterAwayPosition;

	// Token: 0x04001205 RID: 4613
	[Token(Token = "0x4001205")]
	[FieldOffset(Offset = "0x6C")]
	public float FillTime;

	// Token: 0x04001206 RID: 4614
	[Token(Token = "0x4001206")]
	[FieldOffset(Offset = "0x70")]
	public CanisterBehaviour Canister;

	// Token: 0x04001207 RID: 4615
	[Token(Token = "0x4001207")]
	[FieldOffset(Offset = "0x74")]
	private global::Controller controller;

	// Token: 0x04001208 RID: 4616
	[Token(Token = "0x4001208")]
	[FieldOffset(Offset = "0x78")]
	public AudioClip FillLoop;

	// Token: 0x04001209 RID: 4617
	[Token(Token = "0x4001209")]
	[FieldOffset(Offset = "0x7C")]
	public AudioClip DropSound;

	// Token: 0x0400120A RID: 4618
	[Token(Token = "0x400120A")]
	[FieldOffset(Offset = "0x80")]
	public AudioClip GrabSound;

	// Token: 0x0400120B RID: 4619
	[Token(Token = "0x400120B")]
	[FieldOffset(Offset = "0x84")]
	public AudioClip PlugInSound;

	// Token: 0x0400120C RID: 4620
	[Token(Token = "0x400120C")]
	[FieldOffset(Offset = "0x88")]
	public AudioClip PlugOutSound;

	// Token: 0x0400120D RID: 4621
	[Token(Token = "0x400120D")]
	[FieldOffset(Offset = "0x8C")]
	private TouchpadBehavior touchpad;

	// Token: 0x0400120E RID: 4622
	[Token(Token = "0x400120E")]
	[FieldOffset(Offset = "0x90")]
	private bool prevHadInput;

	// Token: 0x0200033B RID: 827
	[Token(Token = "0x200033B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <Run>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001210 RID: 4624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001210")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <Run>d__17(int <>1__state)
		{
		}

		// Token: 0x06001211 RID: 4625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001211")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001212 RID: 4626 RVA: 0x00006390 File Offset: 0x00004590
		[Token(Token = "0x6001212")]
		[Address(RVA = "0x78A260", Offset = "0x789660", VA = "0x1078A260", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06001213 RID: 4627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002B3")]
		private object Current
		{
			[Token(Token = "0x6001213")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001214 RID: 4628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001214")]
		[Address(RVA = "0x78B0A0", Offset = "0x78A4A0", VA = "0x1078B0A0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06001215 RID: 4629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002B4")]
		private object Current
		{
			[Token(Token = "0x6001215")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400120F RID: 4623
		[Token(Token = "0x400120F")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04001210 RID: 4624
		[Token(Token = "0x4001210")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04001211 RID: 4625
		[Token(Token = "0x4001211")]
		[FieldOffset(Offset = "0x10")]
		public FillCanistersGame <>4__this;

		// Token: 0x04001212 RID: 4626
		[Token(Token = "0x4001212")]
		[FieldOffset(Offset = "0x14")]
		private AudioSource <fillSound>5__2;

		// Token: 0x04001213 RID: 4627
		[Token(Token = "0x4001213")]
		[FieldOffset(Offset = "0x18")]
		private Player <player>5__3;

		// Token: 0x04001214 RID: 4628
		[Token(Token = "0x4001214")]
		[FieldOffset(Offset = "0x1C")]
		private float <stickInput>5__4;

		// Token: 0x04001215 RID: 4629
		[Token(Token = "0x4001215")]
		[FieldOffset(Offset = "0x20")]
		private bool <hasNoRemoveInput>5__5;
	}
}
