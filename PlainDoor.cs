using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Hazel;
using Il2CppDummyDll;
using PowerTools;
using UnityEngine;

// Token: 0x0200048F RID: 1167
[Token(Token = "0x200048F")]
public class PlainDoor : SomeKindaDoor
{
	// Token: 0x060018D7 RID: 6359 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018D7")]
	[Address(RVA = "0x65D8E0", Offset = "0x65CCE0", VA = "0x1065D8E0")]
	private void Start()
	{
	}

	// Token: 0x060018D8 RID: 6360 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018D8")]
	[Address(RVA = "0x65D580", Offset = "0x65C980", VA = "0x1065D580", Slot = "4")]
	public override void SetDoorway(bool open)
	{
	}

	// Token: 0x060018D9 RID: 6361 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018D9")]
	[Address(RVA = "0x65D2E0", Offset = "0x65C6E0", VA = "0x1065D2E0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE0560", Offset = "0xDF960")]
	private IEnumerator CoCloseDoorway(bool isHort)
	{
		return null;
	}

	// Token: 0x060018DA RID: 6362 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018DA")]
	[Address(RVA = "0x65D380", Offset = "0x65C780", VA = "0x1065D380")]
	private void DoorDynamics(AudioSource source, float dt)
	{
	}

	// Token: 0x060018DB RID: 6363 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018DB")]
	[Address(RVA = "0x65D550", Offset = "0x65C950", VA = "0x1065D550", Slot = "5")]
	public virtual void Serialize(MessageWriter writer)
	{
	}

	// Token: 0x060018DC RID: 6364 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018DC")]
	[Address(RVA = "0x65D340", Offset = "0x65C740", VA = "0x1065D340", Slot = "6")]
	public virtual void Deserialize(MessageReader reader)
	{
	}

	// Token: 0x060018DD RID: 6365 RVA: 0x00007C68 File Offset: 0x00005E68
	[Token(Token = "0x60018DD")]
	[Address(RVA = "0x2D7E70", Offset = "0x2D7270", VA = "0x102D7E70", Slot = "7")]
	public virtual bool DoUpdate(float dt)
	{
		return default(bool);
	}

	// Token: 0x060018DE RID: 6366 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018DE")]
	[Address(RVA = "0x3AC2A0", Offset = "0x3AB6A0", VA = "0x103AC2A0")]
	public PlainDoor()
	{
	}

	// Token: 0x040018ED RID: 6381
	[Token(Token = "0x40018ED")]
	[FieldOffset(Offset = "0xC")]
	public SystemTypes Room;

	// Token: 0x040018EE RID: 6382
	[Token(Token = "0x40018EE")]
	[FieldOffset(Offset = "0x10")]
	public int Id;

	// Token: 0x040018EF RID: 6383
	[Token(Token = "0x40018EF")]
	[FieldOffset(Offset = "0x14")]
	public bool Open;

	// Token: 0x040018F0 RID: 6384
	[Token(Token = "0x40018F0")]
	[FieldOffset(Offset = "0x18")]
	public BoxCollider2D myCollider;

	// Token: 0x040018F1 RID: 6385
	[Token(Token = "0x40018F1")]
	[FieldOffset(Offset = "0x1C")]
	public SpriteAnim animator;

	// Token: 0x040018F2 RID: 6386
	[Token(Token = "0x40018F2")]
	[FieldOffset(Offset = "0x20")]
	public AnimationClip OpenDoorAnim;

	// Token: 0x040018F3 RID: 6387
	[Token(Token = "0x40018F3")]
	[FieldOffset(Offset = "0x24")]
	public AnimationClip CloseDoorAnim;

	// Token: 0x040018F4 RID: 6388
	[Token(Token = "0x40018F4")]
	[FieldOffset(Offset = "0x28")]
	public AudioClip OpenSound;

	// Token: 0x040018F5 RID: 6389
	[Token(Token = "0x40018F5")]
	[FieldOffset(Offset = "0x2C")]
	public AudioClip CloseSound;

	// Token: 0x040018F6 RID: 6390
	[Token(Token = "0x40018F6")]
	[FieldOffset(Offset = "0x30")]
	private float size;

	// Token: 0x02000490 RID: 1168
	[Token(Token = "0x2000490")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoCloseDoorway>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060018DF RID: 6367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018DF")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoCloseDoorway>d__12(int <>1__state)
		{
		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018E0")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x00007C80 File Offset: 0x00005E80
		[Token(Token = "0x60018E1")]
		[Address(RVA = "0x792610", Offset = "0x791A10", VA = "0x10792610", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x060018E2 RID: 6370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000386")]
		private object Current
		{
			[Token(Token = "0x60018E2")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060018E3 RID: 6371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018E3")]
		[Address(RVA = "0x792810", Offset = "0x791C10", VA = "0x10792810", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x060018E4 RID: 6372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000387")]
		private object Current
		{
			[Token(Token = "0x60018E4")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040018F7 RID: 6391
		[Token(Token = "0x40018F7")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040018F8 RID: 6392
		[Token(Token = "0x40018F8")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040018F9 RID: 6393
		[Token(Token = "0x40018F9")]
		[FieldOffset(Offset = "0x10")]
		public PlainDoor <>4__this;

		// Token: 0x040018FA RID: 6394
		[Token(Token = "0x40018FA")]
		[FieldOffset(Offset = "0x14")]
		public bool isHort;

		// Token: 0x040018FB RID: 6395
		[Token(Token = "0x40018FB")]
		[FieldOffset(Offset = "0x18")]
		private Vector2 <s>5__2;

		// Token: 0x040018FC RID: 6396
		[Token(Token = "0x40018FC")]
		[FieldOffset(Offset = "0x20")]
		private float <i>5__3;
	}
}
