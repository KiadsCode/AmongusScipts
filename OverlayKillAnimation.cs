using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using PowerTools;
using UnityEngine;

// Token: 0x020003F3 RID: 1011
[Token(Token = "0x20003F3")]
public class OverlayKillAnimation : OverlayAnimation
{
	// Token: 0x060014E0 RID: 5344 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014E0")]
	[Address(RVA = "0x77ECE0", Offset = "0x77E0E0", VA = "0x1077ECE0")]
	public void Initialize(GameData.PlayerInfo kInfo, GameData.PlayerInfo vInfo)
	{
	}

	// Token: 0x060014E1 RID: 5345 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014E1")]
	[Address(RVA = "0x77F920", Offset = "0x77ED20", VA = "0x1077F920")]
	public void SetHatFloor()
	{
	}

	// Token: 0x060014E2 RID: 5346 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014E2")]
	[Address(RVA = "0x77F7D0", Offset = "0x77EBD0", VA = "0x1077F7D0")]
	public void PlayKillSound()
	{
	}

	// Token: 0x060014E3 RID: 5347 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014E3")]
	[Address(RVA = "0x77EC80", Offset = "0x77E080", VA = "0x1077EC80", Slot = "4")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDEBD0", Offset = "0xDDFD0")]
	public override IEnumerator CoShow(KillOverlay parent)
	{
		return null;
	}

	// Token: 0x060014E4 RID: 5348 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014E4")]
	[Address(RVA = "0x77FA00", Offset = "0x77EE00", VA = "0x1077FA00")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDEC20", Offset = "0xDE020")]
	private IEnumerator WaitForFinish()
	{
		return null;
	}

	// Token: 0x060014E5 RID: 5349 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014E5")]
	[Address(RVA = "0x77FA50", Offset = "0x77EE50", VA = "0x1077FA50")]
	public OverlayKillAnimation()
	{
	}

	// Token: 0x04001585 RID: 5509
	[Token(Token = "0x4001585")]
	[FieldOffset(Offset = "0xC")]
	public KillAnimType KillType;

	// Token: 0x04001586 RID: 5510
	[Token(Token = "0x4001586")]
	[FieldOffset(Offset = "0x10")]
	public PoolablePlayer killerParts;

	// Token: 0x04001587 RID: 5511
	[Token(Token = "0x4001587")]
	[FieldOffset(Offset = "0x14")]
	public Vector3 KillerPetPosition;

	// Token: 0x04001588 RID: 5512
	[Token(Token = "0x4001588")]
	[FieldOffset(Offset = "0x20")]
	public PoolablePlayer victimParts;

	// Token: 0x04001589 RID: 5513
	[Token(Token = "0x4001589")]
	[FieldOffset(Offset = "0x24")]
	public Vector3 VictimPetPosition;

	// Token: 0x0400158A RID: 5514
	[Token(Token = "0x400158A")]
	[FieldOffset(Offset = "0x30")]
	private string victimHat;

	// Token: 0x0400158B RID: 5515
	[Token(Token = "0x400158B")]
	[FieldOffset(Offset = "0x34")]
	public AudioClip Stinger;

	// Token: 0x0400158C RID: 5516
	[Token(Token = "0x400158C")]
	[FieldOffset(Offset = "0x38")]
	public AudioClip Sfx;

	// Token: 0x0400158D RID: 5517
	[Token(Token = "0x400158D")]
	[FieldOffset(Offset = "0x3C")]
	public float StingerVolume;

	// Token: 0x020003F4 RID: 1012
	[Token(Token = "0x20003F4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass9_0
	{
		// Token: 0x060014E6 RID: 5350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014E6")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass9_0()
		{
		}

		// Token: 0x060014E7 RID: 5351 RVA: 0x00006B40 File Offset: 0x00004D40
		[Token(Token = "0x60014E7")]
		[Address(RVA = "0x79AFD0", Offset = "0x79A3D0", VA = "0x1079AFD0")]
		internal bool <Initialize>b__0(PlayerControl p)
		{
			return default(bool);
		}

		// Token: 0x060014E8 RID: 5352 RVA: 0x00006B58 File Offset: 0x00004D58
		[Token(Token = "0x60014E8")]
		[Address(RVA = "0x79B000", Offset = "0x79A400", VA = "0x1079B000")]
		internal bool <Initialize>b__1(PlayerControl p)
		{
			return default(bool);
		}

		// Token: 0x0400158E RID: 5518
		[Token(Token = "0x400158E")]
		[FieldOffset(Offset = "0x8")]
		public GameData.PlayerInfo kInfo;

		// Token: 0x0400158F RID: 5519
		[Token(Token = "0x400158F")]
		[FieldOffset(Offset = "0xC")]
		public GameData.PlayerInfo vInfo;
	}

	// Token: 0x020003F5 RID: 1013
	[Token(Token = "0x20003F5")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass12_0
	{
		// Token: 0x060014E9 RID: 5353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014E9")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass12_0()
		{
		}

		// Token: 0x060014EA RID: 5354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014EA")]
		[Address(RVA = "0x799FD0", Offset = "0x7993D0", VA = "0x10799FD0")]
		internal void <CoShow>b__0(float t)
		{
		}

		// Token: 0x04001590 RID: 5520
		[Token(Token = "0x4001590")]
		[FieldOffset(Offset = "0x8")]
		public KillOverlay parent;
	}

	// Token: 0x020003F6 RID: 1014
	[Token(Token = "0x20003F6")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoShow>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060014EB RID: 5355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014EB")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoShow>d__12(int <>1__state)
		{
		}

		// Token: 0x060014EC RID: 5356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014EC")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060014ED RID: 5357 RVA: 0x00006B70 File Offset: 0x00004D70
		[Token(Token = "0x60014ED")]
		[Address(RVA = "0x794730", Offset = "0x793B30", VA = "0x10794730", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x060014EE RID: 5358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002F1")]
		private object Current
		{
			[Token(Token = "0x60014EE")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060014EF RID: 5359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014EF")]
		[Address(RVA = "0x794D80", Offset = "0x794180", VA = "0x10794D80", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x060014F0 RID: 5360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002F2")]
		private object Current
		{
			[Token(Token = "0x60014F0")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04001591 RID: 5521
		[Token(Token = "0x4001591")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04001592 RID: 5522
		[Token(Token = "0x4001592")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04001593 RID: 5523
		[Token(Token = "0x4001593")]
		[FieldOffset(Offset = "0x10")]
		public KillOverlay parent;

		// Token: 0x04001594 RID: 5524
		[Token(Token = "0x4001594")]
		[FieldOffset(Offset = "0x14")]
		public OverlayKillAnimation <>4__this;

		// Token: 0x04001595 RID: 5525
		[Token(Token = "0x4001595")]
		[FieldOffset(Offset = "0x18")]
		private OverlayKillAnimation.<>c__DisplayClass12_0 <>8__1;
	}

	// Token: 0x020003F7 RID: 1015
	[Token(Token = "0x20003F7")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <WaitForFinish>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060014F1 RID: 5361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014F1")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <WaitForFinish>d__13(int <>1__state)
		{
		}

		// Token: 0x060014F2 RID: 5362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014F2")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060014F3 RID: 5363 RVA: 0x00006B88 File Offset: 0x00004D88
		[Token(Token = "0x60014F3")]
		[Address(RVA = "0x79BEC0", Offset = "0x79B2C0", VA = "0x1079BEC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x060014F4 RID: 5364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002F3")]
		private object Current
		{
			[Token(Token = "0x60014F4")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060014F5 RID: 5365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014F5")]
		[Address(RVA = "0x79C000", Offset = "0x79B400", VA = "0x1079C000", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x060014F6 RID: 5366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002F4")]
		private object Current
		{
			[Token(Token = "0x60014F6")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04001596 RID: 5526
		[Token(Token = "0x4001596")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04001597 RID: 5527
		[Token(Token = "0x4001597")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04001598 RID: 5528
		[Token(Token = "0x4001598")]
		[FieldOffset(Offset = "0x10")]
		public OverlayKillAnimation <>4__this;

		// Token: 0x04001599 RID: 5529
		[Token(Token = "0x4001599")]
		[FieldOffset(Offset = "0x14")]
		private SpriteAnim[] <anims>5__2;
	}
}
