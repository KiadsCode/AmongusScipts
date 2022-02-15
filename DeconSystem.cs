using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Hazel;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001A1 RID: 417
[Token(Token = "0x20001A1")]
public class DeconSystem : MonoBehaviour, ISystemType
{
	// Token: 0x17000174 RID: 372
	// (get) Token: 0x06000981 RID: 2433 RVA: 0x00004620 File Offset: 0x00002820
	// (set) Token: 0x06000982 RID: 2434 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000174")]
	public DeconSystem.States CurState
	{
		[Token(Token = "0x6000981")]
		[Address(RVA = "0x31AB20", Offset = "0x319F20", VA = "0x1031AB20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return DeconSystem.States.Idle;
		}
		[Token(Token = "0x6000982")]
		[Address(RVA = "0x31AB30", Offset = "0x319F30", VA = "0x1031AB30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private set
		{
		}
	}

	// Token: 0x17000175 RID: 373
	// (get) Token: 0x06000983 RID: 2435 RVA: 0x00004638 File Offset: 0x00002838
	// (set) Token: 0x06000984 RID: 2436 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000175")]
	public bool IsDirty
	{
		[Token(Token = "0x6000983")]
		[Address(RVA = "0x5C4E70", Offset = "0x5C4270", VA = "0x105C4E70", Slot = "4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000984")]
		[Address(RVA = "0x5C4E80", Offset = "0x5C4280", VA = "0x105C4E80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private set
		{
		}
	}

	// Token: 0x06000985 RID: 2437 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000985")]
	[Address(RVA = "0x5C4440", Offset = "0x5C3840", VA = "0x105C4440", Slot = "5")]
	public void Detoriorate(float dt)
	{
	}

	// Token: 0x06000986 RID: 2438 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000986")]
	[Address(RVA = "0x5C43A0", Offset = "0x5C37A0", VA = "0x105C43A0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE0810", Offset = "0xDFC10")]
	private IEnumerator CoRunSprayers()
	{
		return null;
	}

	// Token: 0x06000987 RID: 2439 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000987")]
	[Address(RVA = "0x5C47F0", Offset = "0x5C3BF0", VA = "0x105C47F0")]
	private void SoundDynamics(AudioSource source, float dt)
	{
	}

	// Token: 0x06000988 RID: 2440 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000988")]
	[Address(RVA = "0x5C4680", Offset = "0x5C3A80", VA = "0x105C4680")]
	public void OpenDoor(bool upper)
	{
	}

	// Token: 0x06000989 RID: 2441 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000989")]
	[Address(RVA = "0x5C46E0", Offset = "0x5C3AE0", VA = "0x105C46E0")]
	public void OpenFromInside(bool upper)
	{
	}

	// Token: 0x0600098A RID: 2442 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600098A")]
	[Address(RVA = "0x5C4740", Offset = "0x5C3B40", VA = "0x105C4740", Slot = "6")]
	public void RepairDamage(PlayerControl player, byte amount)
	{
	}

	// Token: 0x0600098B RID: 2443 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600098B")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "7")]
	public void UpdateSystem(PlayerControl player, MessageReader msgReader)
	{
	}

	// Token: 0x0600098C RID: 2444 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600098C")]
	[Address(RVA = "0x5C47A0", Offset = "0x5C3BA0", VA = "0x105C47A0", Slot = "8")]
	public void Serialize(MessageWriter writer, bool initialState)
	{
	}

	// Token: 0x0600098D RID: 2445 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600098D")]
	[Address(RVA = "0x5C43F0", Offset = "0x5C37F0", VA = "0x105C43F0", Slot = "9")]
	public void Deserialize(MessageReader reader, bool initialState)
	{
	}

	// Token: 0x0600098E RID: 2446 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600098E")]
	[Address(RVA = "0x5C4A00", Offset = "0x5C3E00", VA = "0x105C4A00")]
	private void UpdateDoorsViaState()
	{
	}

	// Token: 0x0600098F RID: 2447 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600098F")]
	[Address(RVA = "0x5C4E40", Offset = "0x5C4240", VA = "0x105C4E40")]
	public DeconSystem()
	{
	}

	// Token: 0x04000994 RID: 2452
	[Token(Token = "0x4000994")]
	private const byte HeadUpCmd = 1;

	// Token: 0x04000995 RID: 2453
	[Token(Token = "0x4000995")]
	private const byte HeadDownCmd = 2;

	// Token: 0x04000996 RID: 2454
	[Token(Token = "0x4000996")]
	private const byte HeadUpInsideCmd = 3;

	// Token: 0x04000997 RID: 2455
	[Token(Token = "0x4000997")]
	private const byte HeadDownInsideCmd = 4;

	// Token: 0x04000998 RID: 2456
	[Token(Token = "0x4000998")]
	[FieldOffset(Offset = "0xC")]
	public SomeKindaDoor UpperDoor;

	// Token: 0x04000999 RID: 2457
	[Token(Token = "0x4000999")]
	[FieldOffset(Offset = "0x10")]
	public SomeKindaDoor LowerDoor;

	// Token: 0x0400099A RID: 2458
	[Token(Token = "0x400099A")]
	[FieldOffset(Offset = "0x14")]
	public float DoorOpenTime;

	// Token: 0x0400099B RID: 2459
	[Token(Token = "0x400099B")]
	[FieldOffset(Offset = "0x18")]
	public float DeconTime;

	// Token: 0x0400099C RID: 2460
	[Token(Token = "0x400099C")]
	[FieldOffset(Offset = "0x1C")]
	public AudioClip SpraySound;

	// Token: 0x0400099D RID: 2461
	[Token(Token = "0x400099D")]
	[FieldOffset(Offset = "0x20")]
	public ParticleSystem[] Particles;

	// Token: 0x0400099E RID: 2462
	[Token(Token = "0x400099E")]
	[FieldOffset(Offset = "0x24")]
	public SystemTypes TargetSystem;

	// Token: 0x0400099F RID: 2463
	[Token(Token = "0x400099F")]
	[FieldOffset(Offset = "0x25")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private DeconSystem.States <CurState>k__BackingField;

	// Token: 0x040009A0 RID: 2464
	[Token(Token = "0x40009A0")]
	[FieldOffset(Offset = "0x28")]
	private float timer;

	// Token: 0x040009A1 RID: 2465
	[Token(Token = "0x40009A1")]
	[FieldOffset(Offset = "0x2C")]
	public Collider2D RoomArea;

	// Token: 0x040009A2 RID: 2466
	[Token(Token = "0x40009A2")]
	[FieldOffset(Offset = "0x30")]
	public DecontamNumController FloorText;

	// Token: 0x040009A3 RID: 2467
	[Token(Token = "0x40009A3")]
	[FieldOffset(Offset = "0x34")]
	private Coroutine sprayers;

	// Token: 0x040009A4 RID: 2468
	[Token(Token = "0x40009A4")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private bool <IsDirty>k__BackingField;

	// Token: 0x020001A2 RID: 418
	[Token(Token = "0x20001A2")]
	[Flags]
	public enum States : byte
	{
		// Token: 0x040009A6 RID: 2470
		[Token(Token = "0x40009A6")]
		Idle = 0,
		// Token: 0x040009A7 RID: 2471
		[Token(Token = "0x40009A7")]
		Enter = 1,
		// Token: 0x040009A8 RID: 2472
		[Token(Token = "0x40009A8")]
		Closed = 2,
		// Token: 0x040009A9 RID: 2473
		[Token(Token = "0x40009A9")]
		Exit = 4,
		// Token: 0x040009AA RID: 2474
		[Token(Token = "0x40009AA")]
		HeadingUp = 8
	}

	// Token: 0x020001A3 RID: 419
	[Token(Token = "0x20001A3")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000991 RID: 2449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000991")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000992")]
		[Address(RVA = "0x78D320", Offset = "0x78C720", VA = "0x1078D320")]
		internal void <CoRunSprayers>b__25_0(ParticleSystem p)
		{
		}

		// Token: 0x040009AB RID: 2475
		[Token(Token = "0x40009AB")]
		[FieldOffset(Offset = "0x0")]
		public static readonly DeconSystem.<>c <>9;

		// Token: 0x040009AC RID: 2476
		[Token(Token = "0x40009AC")]
		[FieldOffset(Offset = "0x4")]
		public static Action<ParticleSystem> <>9__25_0;
	}

	// Token: 0x020001A4 RID: 420
	[Token(Token = "0x20001A4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoRunSprayers>d__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000993 RID: 2451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000993")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoRunSprayers>d__25(int <>1__state)
		{
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000994")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x00004650 File Offset: 0x00002850
		[Token(Token = "0x6000995")]
		[Address(RVA = "0x786230", Offset = "0x785630", VA = "0x10786230", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000996 RID: 2454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000176")]
		private object Current
		{
			[Token(Token = "0x6000996")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000997")]
		[Address(RVA = "0x7864C0", Offset = "0x7858C0", VA = "0x107864C0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000998 RID: 2456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000177")]
		private object Current
		{
			[Token(Token = "0x6000998")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040009AD RID: 2477
		[Token(Token = "0x40009AD")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040009AE RID: 2478
		[Token(Token = "0x40009AE")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040009AF RID: 2479
		[Token(Token = "0x40009AF")]
		[FieldOffset(Offset = "0x10")]
		public DeconSystem <>4__this;
	}
}
