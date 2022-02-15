using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Hazel;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200048D RID: 1165
[Token(Token = "0x200048D")]
public class ManualDoor : SomeKindaDoor
{
	// Token: 0x060018C9 RID: 6345 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018C9")]
	[Address(RVA = "0x6E3EA0", Offset = "0x6E32A0", VA = "0x106E3EA0")]
	private void Awake()
	{
	}

	// Token: 0x060018CA RID: 6346 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018CA")]
	[Address(RVA = "0x6E44B0", Offset = "0x6E38B0", VA = "0x106E44B0")]
	private void Update()
	{
	}

	// Token: 0x060018CB RID: 6347 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018CB")]
	[Address(RVA = "0x6E4170", Offset = "0x6E3570", VA = "0x106E4170", Slot = "4")]
	public override void SetDoorway(bool open)
	{
	}

	// Token: 0x060018CC RID: 6348 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018CC")]
	[Address(RVA = "0x6E3F70", Offset = "0x6E3370", VA = "0x106E3F70")]
	private void DoorDynamics(AudioSource source, float dt)
	{
	}

	// Token: 0x060018CD RID: 6349 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018CD")]
	[Address(RVA = "0x6E3F10", Offset = "0x6E3310", VA = "0x106E3F10")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE03D0", Offset = "0xDF7D0")]
	private IEnumerator CoCloseDoorway(bool isHort)
	{
		return null;
	}

	// Token: 0x060018CE RID: 6350 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018CE")]
	[Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x106E4140", Slot = "5")]
	public virtual void Serialize(MessageWriter writer)
	{
	}

	// Token: 0x060018CF RID: 6351 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018CF")]
	[Address(RVA = "0x65D340", Offset = "0x65C740", VA = "0x1065D340", Slot = "6")]
	public virtual void Deserialize(MessageReader reader)
	{
	}

	// Token: 0x060018D0 RID: 6352 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018D0")]
	[Address(RVA = "0x6E45A0", Offset = "0x6E39A0", VA = "0x106E45A0")]
	public ManualDoor()
	{
	}

	// Token: 0x040018DF RID: 6367
	[Token(Token = "0x40018DF")]
	[FieldOffset(Offset = "0xC")]
	public bool Opening;

	// Token: 0x040018E0 RID: 6368
	[Token(Token = "0x40018E0")]
	[FieldOffset(Offset = "0x10")]
	public BoxCollider2D myCollider;

	// Token: 0x040018E1 RID: 6369
	[Token(Token = "0x40018E1")]
	[FieldOffset(Offset = "0x14")]
	public SpriteRenderer image;

	// Token: 0x040018E2 RID: 6370
	[Token(Token = "0x40018E2")]
	[FieldOffset(Offset = "0x18")]
	private float size;

	// Token: 0x040018E3 RID: 6371
	[Token(Token = "0x40018E3")]
	[FieldOffset(Offset = "0x1C")]
	public float OpenDuration;

	// Token: 0x040018E4 RID: 6372
	[Token(Token = "0x40018E4")]
	[FieldOffset(Offset = "0x20")]
	private float openTimer;

	// Token: 0x040018E5 RID: 6373
	[Token(Token = "0x40018E5")]
	[FieldOffset(Offset = "0x24")]
	public AudioClip OpenSound;

	// Token: 0x040018E6 RID: 6374
	[Token(Token = "0x40018E6")]
	[FieldOffset(Offset = "0x28")]
	public AudioClip CloseSound;

	// Token: 0x0200048E RID: 1166
	[Token(Token = "0x200048E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoCloseDoorway>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060018D1 RID: 6353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018D1")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoCloseDoorway>d__12(int <>1__state)
		{
		}

		// Token: 0x060018D2 RID: 6354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018D2")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060018D3 RID: 6355 RVA: 0x00007C50 File Offset: 0x00005E50
		[Token(Token = "0x60018D3")]
		[Address(RVA = "0x5A95E0", Offset = "0x5A89E0", VA = "0x105A95E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x060018D4 RID: 6356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000384")]
		private object Current
		{
			[Token(Token = "0x60018D4")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060018D5 RID: 6357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018D5")]
		[Address(RVA = "0x5A97E0", Offset = "0x5A8BE0", VA = "0x105A97E0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x060018D6 RID: 6358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000385")]
		private object Current
		{
			[Token(Token = "0x60018D6")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040018E7 RID: 6375
		[Token(Token = "0x40018E7")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040018E8 RID: 6376
		[Token(Token = "0x40018E8")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040018E9 RID: 6377
		[Token(Token = "0x40018E9")]
		[FieldOffset(Offset = "0x10")]
		public ManualDoor <>4__this;

		// Token: 0x040018EA RID: 6378
		[Token(Token = "0x40018EA")]
		[FieldOffset(Offset = "0x14")]
		public bool isHort;

		// Token: 0x040018EB RID: 6379
		[Token(Token = "0x40018EB")]
		[FieldOffset(Offset = "0x18")]
		private Vector2 <s>5__2;

		// Token: 0x040018EC RID: 6380
		[Token(Token = "0x40018EC")]
		[FieldOffset(Offset = "0x20")]
		private float <i>5__3;
	}
}
