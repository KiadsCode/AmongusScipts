using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000065 RID: 101
[Token(Token = "0x2000065")]
public class AirshipStatus : ShipStatus
{
	// Token: 0x060002AA RID: 682 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002AA")]
	[Address(RVA = "0x544EF0", Offset = "0x5442F0", VA = "0x10544EF0", Slot = "11")]
	protected override void OnEnable()
	{
	}

	// Token: 0x060002AB RID: 683 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002AB")]
	[Address(RVA = "0x5453F0", Offset = "0x5447F0", VA = "0x105453F0", Slot = "12")]
	public override void RepairGameOverSystems()
	{
	}

	// Token: 0x060002AC RID: 684 RVA: 0x000026E8 File Offset: 0x000008E8
	[Token(Token = "0x60002AC")]
	[Address(RVA = "0x544DA0", Offset = "0x5441A0", VA = "0x10544DA0", Slot = "17")]
	public override float CalculateLightRadius(GameData.PlayerInfo player)
	{
		return 0f;
	}

	// Token: 0x060002AD RID: 685 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002AD")]
	[Address(RVA = "0x545370", Offset = "0x544770", VA = "0x10545370", Slot = "15")]
	public override void OnMeetingCalled()
	{
	}

	// Token: 0x060002AE RID: 686 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002AE")]
	[Address(RVA = "0x5454D0", Offset = "0x5448D0", VA = "0x105454D0", Slot = "14")]
	public override void SpawnPlayer(PlayerControl player, int numPlayers, bool initialSpawn)
	{
	}

	// Token: 0x060002AF RID: 687 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002AF")]
	[Address(RVA = "0x5453A0", Offset = "0x5447A0", VA = "0x105453A0", Slot = "16")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE5070", Offset = "0xE4470")]
	public override IEnumerator PrespawnStep()
	{
		return null;
	}

	// Token: 0x060002B0 RID: 688 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002B0")]
	[Address(RVA = "0x50C320", Offset = "0x50B720", VA = "0x1050C320")]
	public AirshipStatus()
	{
	}

	// Token: 0x04000263 RID: 611
	[Token(Token = "0x4000263")]
	[FieldOffset(Offset = "0xF4")]
	public Ladder[] Ladders;

	// Token: 0x04000264 RID: 612
	[Token(Token = "0x4000264")]
	[FieldOffset(Offset = "0xF8")]
	public SpawnInMinigame SpawnInGame;

	// Token: 0x04000265 RID: 613
	[Token(Token = "0x4000265")]
	[FieldOffset(Offset = "0xFC")]
	public MovingPlatformBehaviour GapPlatform;

	// Token: 0x04000266 RID: 614
	[Token(Token = "0x4000266")]
	[FieldOffset(Offset = "0x100")]
	public ParticleSystem ShowerParticles;

	// Token: 0x04000267 RID: 615
	[Token(Token = "0x4000267")]
	[FieldOffset(Offset = "0x104")]
	public LightAffector[] LightAffectors;

	// Token: 0x02000066 RID: 102
	[Token(Token = "0x2000066")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060002B2 RID: 690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00002700 File Offset: 0x00000900
		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x3CA1F0", Offset = "0x3C95F0", VA = "0x103CA1F0")]
		internal bool <OnEnable>b__5_0(ISystemType i)
		{
			return default(bool);
		}

		// Token: 0x04000268 RID: 616
		[Token(Token = "0x4000268")]
		[FieldOffset(Offset = "0x0")]
		public static readonly AirshipStatus.<>c <>9;

		// Token: 0x04000269 RID: 617
		[Token(Token = "0x4000269")]
		[FieldOffset(Offset = "0x4")]
		public static Func<ISystemType, bool> <>9__5_0;
	}

	// Token: 0x02000067 RID: 103
	[Token(Token = "0x2000067")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <PrespawnStep>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060002B4 RID: 692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <PrespawnStep>d__10(int <>1__state)
		{
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00002718 File Offset: 0x00000918
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x3C94B0", Offset = "0x3C88B0", VA = "0x103C94B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060002B7 RID: 695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000064")]
		private object Current
		{
			[Token(Token = "0x60002B7")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x3C9610", Offset = "0x3C8A10", VA = "0x103C9610", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060002B9 RID: 697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000065")]
		private object Current
		{
			[Token(Token = "0x60002B9")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400026A RID: 618
		[Token(Token = "0x400026A")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x0400026B RID: 619
		[Token(Token = "0x400026B")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x0400026C RID: 620
		[Token(Token = "0x400026C")]
		[FieldOffset(Offset = "0x10")]
		public AirshipStatus <>4__this;
	}
}
