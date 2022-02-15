using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000347 RID: 839
[Token(Token = "0x2000347")]
public class TelescopeGame : Minigame
{
	// Token: 0x06001251 RID: 4689 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001251")]
	[Address(RVA = "0x4A97D0", Offset = "0x4A8BD0", VA = "0x104A97D0")]
	public void Start()
	{
	}

	// Token: 0x06001252 RID: 4690 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001252")]
	[Address(RVA = "0x4A9780", Offset = "0x4A8B80", VA = "0x104A9780")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE7BD0", Offset = "0xE6FD0")]
	private IEnumerator RunBlipSound()
	{
		return null;
	}

	// Token: 0x06001253 RID: 4691 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001253")]
	[Address(RVA = "0x4A9900", Offset = "0x4A8D00", VA = "0x104A9900")]
	public void Update()
	{
	}

	// Token: 0x06001254 RID: 4692 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001254")]
	[Address(RVA = "0x4A9710", Offset = "0x4A8B10", VA = "0x104A9710")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE7C20", Offset = "0xE7020")]
	private IEnumerator CoBlinky()
	{
		return null;
	}

	// Token: 0x06001255 RID: 4693 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001255")]
	[Address(RVA = "0x4A9760", Offset = "0x4A8B60", VA = "0x104A9760")]
	public void Grab()
	{
	}

	// Token: 0x06001256 RID: 4694 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001256")]
	[Address(RVA = "0x4A9E70", Offset = "0x4A9270", VA = "0x104A9E70")]
	public TelescopeGame()
	{
	}

	// Token: 0x04001273 RID: 4723
	[Token(Token = "0x4001273")]
	[FieldOffset(Offset = "0x30")]
	private bool grabbed;

	// Token: 0x04001274 RID: 4724
	[Token(Token = "0x4001274")]
	[FieldOffset(Offset = "0x34")]
	public Transform Background;

	// Token: 0x04001275 RID: 4725
	[Token(Token = "0x4001275")]
	[FieldOffset(Offset = "0x38")]
	public SpriteRenderer ItemDisplay;

	// Token: 0x04001276 RID: 4726
	[Token(Token = "0x4001276")]
	[FieldOffset(Offset = "0x3C")]
	public BoxCollider2D[] Items;

	// Token: 0x04001277 RID: 4727
	[Token(Token = "0x4001277")]
	[FieldOffset(Offset = "0x40")]
	private BoxCollider2D TargetItem;

	// Token: 0x04001278 RID: 4728
	[Token(Token = "0x4001278")]
	[FieldOffset(Offset = "0x44")]
	public BoxCollider2D Reticle;

	// Token: 0x04001279 RID: 4729
	[Token(Token = "0x4001279")]
	[FieldOffset(Offset = "0x48")]
	public SpriteRenderer ReticleImage;

	// Token: 0x0400127A RID: 4730
	[Token(Token = "0x400127A")]
	[FieldOffset(Offset = "0x4C")]
	private Coroutine blinky;

	// Token: 0x0400127B RID: 4731
	[Token(Token = "0x400127B")]
	[FieldOffset(Offset = "0x50")]
	public AudioClip BlipSound;

	// Token: 0x0400127C RID: 4732
	[Token(Token = "0x400127C")]
	[FieldOffset(Offset = "0x54")]
	public FloatRange BlipDelay;

	// Token: 0x0400127D RID: 4733
	[Token(Token = "0x400127D")]
	[FieldOffset(Offset = "0x58")]
	private TouchpadBehavior touchpad;

	// Token: 0x0400127E RID: 4734
	[Token(Token = "0x400127E")]
	[FieldOffset(Offset = "0x5C")]
	private Vector3 initialPos;

	// Token: 0x02000348 RID: 840
	[Token(Token = "0x2000348")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <RunBlipSound>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001257 RID: 4695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001257")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <RunBlipSound>d__13(int <>1__state)
		{
		}

		// Token: 0x06001258 RID: 4696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001258")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001259 RID: 4697 RVA: 0x00006438 File Offset: 0x00004638
		[Token(Token = "0x6001259")]
		[Address(RVA = "0x36DBD0", Offset = "0x36CFD0", VA = "0x1036DBD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x0600125A RID: 4698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002BD")]
		private object Current
		{
			[Token(Token = "0x600125A")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600125B RID: 4699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600125B")]
		[Address(RVA = "0x36DE60", Offset = "0x36D260", VA = "0x1036DE60", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x0600125C RID: 4700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002BE")]
		private object Current
		{
			[Token(Token = "0x600125C")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400127F RID: 4735
		[Token(Token = "0x400127F")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04001280 RID: 4736
		[Token(Token = "0x4001280")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04001281 RID: 4737
		[Token(Token = "0x4001281")]
		[FieldOffset(Offset = "0x10")]
		public TelescopeGame <>4__this;

		// Token: 0x04001282 RID: 4738
		[Token(Token = "0x4001282")]
		[FieldOffset(Offset = "0x14")]
		private float <time>5__2;
	}

	// Token: 0x02000349 RID: 841
	[Token(Token = "0x2000349")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoBlinky>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600125D RID: 4701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600125D")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoBlinky>d__15(int <>1__state)
		{
		}

		// Token: 0x0600125E RID: 4702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600125E")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x00006450 File Offset: 0x00004650
		[Token(Token = "0x600125F")]
		[Address(RVA = "0x367A60", Offset = "0x366E60", VA = "0x10367A60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06001260 RID: 4704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002BF")]
		private object Current
		{
			[Token(Token = "0x6001260")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001261")]
		[Address(RVA = "0x367C50", Offset = "0x367050", VA = "0x10367C50", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06001262 RID: 4706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002C0")]
		private object Current
		{
			[Token(Token = "0x6001262")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04001283 RID: 4739
		[Token(Token = "0x4001283")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04001284 RID: 4740
		[Token(Token = "0x4001284")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04001285 RID: 4741
		[Token(Token = "0x4001285")]
		[FieldOffset(Offset = "0x10")]
		public TelescopeGame <>4__this;

		// Token: 0x04001286 RID: 4742
		[Token(Token = "0x4001286")]
		[FieldOffset(Offset = "0x14")]
		private int <i>5__2;
	}
}
