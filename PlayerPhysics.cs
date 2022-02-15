using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Hazel;
using Il2CppDummyDll;
using InnerNet;
using PowerTools;
using UnityEngine;

// Token: 0x0200040A RID: 1034
[Token(Token = "0x200040A")]
public class PlayerPhysics : InnerNetObject
{
	// Token: 0x060015AA RID: 5546 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015AA")]
	[Address(RVA = "0x504020", Offset = "0x503420", VA = "0x10504020")]
	public void RpcClimbLadder(Ladder source)
	{
	}

	// Token: 0x060015AB RID: 5547 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015AB")]
	[Address(RVA = "0x5040E0", Offset = "0x5034E0", VA = "0x105040E0")]
	public void RpcEnterVent(int id)
	{
	}

	// Token: 0x060015AC RID: 5548 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015AC")]
	[Address(RVA = "0x504190", Offset = "0x503590", VA = "0x10504190")]
	public void RpcExitVent(int id)
	{
	}

	// Token: 0x060015AD RID: 5549 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015AD")]
	[Address(RVA = "0x503F80", Offset = "0x503380", VA = "0x10503F80")]
	public void RpcBootFromVent(int ventId)
	{
	}

	// Token: 0x060015AE RID: 5550 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015AE")]
	[Address(RVA = "0x503770", Offset = "0x502B70", VA = "0x10503770", Slot = "8")]
	public override void HandleRpc(byte callId, MessageReader reader)
	{
	}

	// Token: 0x17000307 RID: 775
	// (get) Token: 0x060015AF RID: 5551 RVA: 0x00006E58 File Offset: 0x00005058
	[Token(Token = "0x17000307")]
	public float TrueSpeed
	{
		[Token(Token = "0x60015AF")]
		[Address(RVA = "0x504550", Offset = "0x503950", VA = "0x10504550")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000308 RID: 776
	// (get) Token: 0x060015B0 RID: 5552 RVA: 0x00006E70 File Offset: 0x00005070
	[Token(Token = "0x17000308")]
	public float TrueGhostSpeed
	{
		[Token(Token = "0x60015B0")]
		[Address(RVA = "0x5044E0", Offset = "0x5038E0", VA = "0x105044E0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x060015B1 RID: 5553 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015B1")]
	[Address(RVA = "0x502960", Offset = "0x501D60", VA = "0x10502960")]
	public void Awake()
	{
	}

	// Token: 0x060015B2 RID: 5554 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015B2")]
	[Address(RVA = "0x502E90", Offset = "0x502290", VA = "0x10502E90")]
	public void EnableInterpolation()
	{
	}

	// Token: 0x060015B3 RID: 5555 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015B3")]
	[Address(RVA = "0x502FB0", Offset = "0x5023B0", VA = "0x10502FB0")]
	private void FixedUpdate()
	{
	}

	// Token: 0x060015B4 RID: 5556 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015B4")]
	[Address(RVA = "0x503980", Offset = "0x502D80", VA = "0x10503980")]
	private void LateUpdate()
	{
	}

	// Token: 0x060015B5 RID: 5557 RVA: 0x00006E88 File Offset: 0x00005088
	[Token(Token = "0x60015B5")]
	[Address(RVA = "0x504400", Offset = "0x503800", VA = "0x10504400")]
	public Vector3 Vec2ToPosition(Vector2 pos)
	{
		return default(Vector3);
	}

	// Token: 0x060015B6 RID: 5558 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015B6")]
	[Address(RVA = "0x504240", Offset = "0x503640", VA = "0x10504240")]
	public void SetSkin(string skinId)
	{
	}

	// Token: 0x060015B7 RID: 5559 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015B7")]
	[Address(RVA = "0x5042F0", Offset = "0x5036F0", VA = "0x105042F0")]
	private void StartClimb(bool down)
	{
	}

	// Token: 0x060015B8 RID: 5560 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015B8")]
	[Address(RVA = "0x502C80", Offset = "0x502080", VA = "0x10502C80")]
	private void ClimbLadder(Ladder source, byte climbLadderSid)
	{
	}

	// Token: 0x060015B9 RID: 5561 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015B9")]
	[Address(RVA = "0x502D10", Offset = "0x502110", VA = "0x10502D10")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDF5A0", Offset = "0xDE9A0")]
	private IEnumerator CoClimbLadder(Ladder source, byte climbLadderSid)
	{
		return null;
	}

	// Token: 0x060015BA RID: 5562 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015BA")]
	[Address(RVA = "0x503C90", Offset = "0x503090", VA = "0x10503C90")]
	public void ResetMoveState(bool stopCoroutines = true)
	{
	}

	// Token: 0x060015BB RID: 5563 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015BB")]
	[Address(RVA = "0x503A10", Offset = "0x502E10", VA = "0x10503A10")]
	public void ResetAnimState()
	{
	}

	// Token: 0x060015BC RID: 5564 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015BC")]
	[Address(RVA = "0x503220", Offset = "0x502620", VA = "0x10503220")]
	private void HandleAnimation(bool amDead)
	{
	}

	// Token: 0x060015BD RID: 5565 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015BD")]
	[Address(RVA = "0x502E30", Offset = "0x502230", VA = "0x10502E30")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDF5F0", Offset = "0xDE9F0")]
	public IEnumerator CoSpawnPlayer(LobbyBehaviour lobby)
	{
		return null;
	}

	// Token: 0x060015BE RID: 5566 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015BE")]
	[Address(RVA = "0x502EC0", Offset = "0x5022C0", VA = "0x10502EC0")]
	public void ExitAllVents()
	{
	}

	// Token: 0x060015BF RID: 5567 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015BF")]
	[Address(RVA = "0x502D70", Offset = "0x502170", VA = "0x10502D70")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDF640", Offset = "0xDEA40")]
	private IEnumerator CoEnterVent(int id)
	{
		return null;
	}

	// Token: 0x060015C0 RID: 5568 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015C0")]
	[Address(RVA = "0x502DD0", Offset = "0x5021D0", VA = "0x10502DD0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDF690", Offset = "0xDEA90")]
	private IEnumerator CoExitVent(int id)
	{
		return null;
	}

	// Token: 0x060015C1 RID: 5569 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015C1")]
	[Address(RVA = "0x504430", Offset = "0x503830", VA = "0x10504430")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDF730", Offset = "0xDEB30")]
	public IEnumerator WalkPlayerTo(Vector2 worldPos, float tolerance = 0.01f, float speedMul = 1f)
	{
		return null;
	}

	// Token: 0x060015C2 RID: 5570 RVA: 0x00006EA0 File Offset: 0x000050A0
	[Token(Token = "0x60015C2")]
	[Address(RVA = "0x2D7E70", Offset = "0x2D7270", VA = "0x102D7E70", Slot = "9")]
	public override bool Serialize(MessageWriter writer, bool initialState)
	{
		return default(bool);
	}

	// Token: 0x060015C3 RID: 5571 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015C3")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "10")]
	public override void Deserialize(MessageReader reader, bool initialState)
	{
	}

	// Token: 0x060015C4 RID: 5572 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015C4")]
	[Address(RVA = "0x502A50", Offset = "0x501E50", VA = "0x10502A50")]
	private void BootFromVent(int ventId)
	{
	}

	// Token: 0x060015C5 RID: 5573 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015C5")]
	[Address(RVA = "0x5044B0", Offset = "0x5038B0", VA = "0x105044B0")]
	public PlayerPhysics()
	{
	}

	// Token: 0x0400160C RID: 5644
	[Token(Token = "0x400160C")]
	[FieldOffset(Offset = "0x24")]
	private byte lastClimbLadderSid;

	// Token: 0x0400160D RID: 5645
	[Token(Token = "0x400160D")]
	[FieldOffset(Offset = "0x28")]
	public float Speed;

	// Token: 0x0400160E RID: 5646
	[Token(Token = "0x400160E")]
	[FieldOffset(Offset = "0x2C")]
	public float GhostSpeed;

	// Token: 0x0400160F RID: 5647
	[Token(Token = "0x400160F")]
	[FieldOffset(Offset = "0x30")]
	[HideInInspector]
	private Rigidbody2D body;

	// Token: 0x04001610 RID: 5648
	[Token(Token = "0x4001610")]
	[FieldOffset(Offset = "0x34")]
	[HideInInspector]
	private PlayerControl myPlayer;

	// Token: 0x04001611 RID: 5649
	[Token(Token = "0x4001611")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private SpriteAnim Animator;

	// Token: 0x04001612 RID: 5650
	[Token(Token = "0x4001612")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private SpriteAnim GlowAnimator;

	// Token: 0x04001613 RID: 5651
	[Token(Token = "0x4001613")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private SpriteRenderer rend;

	// Token: 0x04001614 RID: 5652
	[Token(Token = "0x4001614")]
	[FieldOffset(Offset = "0x44")]
	public AnimationClip RunAnim;

	// Token: 0x04001615 RID: 5653
	[Token(Token = "0x4001615")]
	[FieldOffset(Offset = "0x48")]
	public AnimationClip IdleAnim;

	// Token: 0x04001616 RID: 5654
	[Token(Token = "0x4001616")]
	[FieldOffset(Offset = "0x4C")]
	public AnimationClip GhostIdleAnim;

	// Token: 0x04001617 RID: 5655
	[Token(Token = "0x4001617")]
	[FieldOffset(Offset = "0x50")]
	public AnimationClip EnterVentAnim;

	// Token: 0x04001618 RID: 5656
	[Token(Token = "0x4001618")]
	[FieldOffset(Offset = "0x54")]
	public AnimationClip ExitVentAnim;

	// Token: 0x04001619 RID: 5657
	[Token(Token = "0x4001619")]
	[FieldOffset(Offset = "0x58")]
	public AnimationClip SpawnAnim;

	// Token: 0x0400161A RID: 5658
	[Token(Token = "0x400161A")]
	[FieldOffset(Offset = "0x5C")]
	public AnimationClip SpawnGlowAnim;

	// Token: 0x0400161B RID: 5659
	[Token(Token = "0x400161B")]
	[FieldOffset(Offset = "0x60")]
	public AnimationClip ClimbAnim;

	// Token: 0x0400161C RID: 5660
	[Token(Token = "0x400161C")]
	[FieldOffset(Offset = "0x64")]
	public AnimationClip ClimbDownAnim;

	// Token: 0x0400161D RID: 5661
	[Token(Token = "0x400161D")]
	[FieldOffset(Offset = "0x68")]
	public AnimationClip GhostGuardianAngelAnim;

	// Token: 0x0400161E RID: 5662
	[Token(Token = "0x400161E")]
	[FieldOffset(Offset = "0x6C")]
	public SkinLayer Skin;

	// Token: 0x0400161F RID: 5663
	[Token(Token = "0x400161F")]
	[FieldOffset(Offset = "0x70")]
	public AudioClip ImpostorDiscoveredSound;

	// Token: 0x04001620 RID: 5664
	[Token(Token = "0x4001620")]
	[FieldOffset(Offset = "0x74")]
	[NonSerialized]
	public SpecialInputHandler inputHandler;

	// Token: 0x0200040B RID: 1035
	[Token(Token = "0x200040B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass5_0
	{
		// Token: 0x060015C6 RID: 5574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015C6")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass5_0()
		{
		}

		// Token: 0x060015C7 RID: 5575 RVA: 0x00006EB8 File Offset: 0x000050B8
		[Token(Token = "0x60015C7")]
		[Address(RVA = "0x79AE20", Offset = "0x79A220", VA = "0x1079AE20")]
		internal bool <HandleRpc>b__0(Ladder f)
		{
			return default(bool);
		}

		// Token: 0x04001621 RID: 5665
		[Token(Token = "0x4001621")]
		[FieldOffset(Offset = "0x8")]
		public byte ladderId;
	}

	// Token: 0x0200040C RID: 1036
	[Token(Token = "0x200040C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoClimbLadder>d__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060015C8 RID: 5576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015C8")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoClimbLadder>d__38(int <>1__state)
		{
		}

		// Token: 0x060015C9 RID: 5577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015C9")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060015CA RID: 5578 RVA: 0x00006ED0 File Offset: 0x000050D0
		[Token(Token = "0x60015CA")]
		[Address(RVA = "0x7920E0", Offset = "0x7914E0", VA = "0x107920E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x060015CB RID: 5579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000309")]
		private object Current
		{
			[Token(Token = "0x60015CB")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060015CC RID: 5580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015CC")]
		[Address(RVA = "0x7925E0", Offset = "0x7919E0", VA = "0x107925E0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x060015CD RID: 5581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700030A")]
		private object Current
		{
			[Token(Token = "0x60015CD")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04001622 RID: 5666
		[Token(Token = "0x4001622")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04001623 RID: 5667
		[Token(Token = "0x4001623")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04001624 RID: 5668
		[Token(Token = "0x4001624")]
		[FieldOffset(Offset = "0x10")]
		public PlayerPhysics <>4__this;

		// Token: 0x04001625 RID: 5669
		[Token(Token = "0x4001625")]
		[FieldOffset(Offset = "0x14")]
		public Ladder source;
	}

	// Token: 0x0200040D RID: 1037
	[Token(Token = "0x200040D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoSpawnPlayer>d__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060015CE RID: 5582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015CE")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoSpawnPlayer>d__42(int <>1__state)
		{
		}

		// Token: 0x060015CF RID: 5583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015CF")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060015D0 RID: 5584 RVA: 0x00006EE8 File Offset: 0x000050E8
		[Token(Token = "0x60015D0")]
		[Address(RVA = "0x7950F0", Offset = "0x7944F0", VA = "0x107950F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x060015D1 RID: 5585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700030B")]
		private object Current
		{
			[Token(Token = "0x60015D1")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060015D2 RID: 5586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015D2")]
		[Address(RVA = "0x795740", Offset = "0x794B40", VA = "0x10795740", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x060015D3 RID: 5587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700030C")]
		private object Current
		{
			[Token(Token = "0x60015D3")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04001626 RID: 5670
		[Token(Token = "0x4001626")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04001627 RID: 5671
		[Token(Token = "0x4001627")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04001628 RID: 5672
		[Token(Token = "0x4001628")]
		[FieldOffset(Offset = "0x10")]
		public LobbyBehaviour lobby;

		// Token: 0x04001629 RID: 5673
		[Token(Token = "0x4001629")]
		[FieldOffset(Offset = "0x14")]
		public PlayerPhysics <>4__this;

		// Token: 0x0400162A RID: 5674
		[Token(Token = "0x400162A")]
		[FieldOffset(Offset = "0x18")]
		private int <spawnSeatId>5__2;

		// Token: 0x0400162B RID: 5675
		[Token(Token = "0x400162B")]
		[FieldOffset(Offset = "0x1C")]
		private Vector3 <spawnPos>5__3;

		// Token: 0x0400162C RID: 5676
		[Token(Token = "0x400162C")]
		[FieldOffset(Offset = "0x28")]
		private bool <amFlipped>5__4;
	}

	// Token: 0x0200040E RID: 1038
	[Token(Token = "0x200040E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass44_0
	{
		// Token: 0x060015D4 RID: 5588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015D4")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass44_0()
		{
		}

		// Token: 0x060015D5 RID: 5589 RVA: 0x00006F00 File Offset: 0x00005100
		[Token(Token = "0x60015D5")]
		[Address(RVA = "0x5B57A0", Offset = "0x5B4BA0", VA = "0x105B57A0")]
		internal bool <CoEnterVent>b__0(Vent v)
		{
			return default(bool);
		}

		// Token: 0x0400162D RID: 5677
		[Token(Token = "0x400162D")]
		[FieldOffset(Offset = "0x8")]
		public int id;
	}

	// Token: 0x0200040F RID: 1039
	[Token(Token = "0x200040F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060015D7 RID: 5591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015D7")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x060015D8 RID: 5592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015D8")]
		[Address(RVA = "0x799680", Offset = "0x798A80", VA = "0x10799680")]
		internal void <CoEnterVent>b__44_1(RoleEffectAnimation an)
		{
		}

		// Token: 0x060015D9 RID: 5593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015D9")]
		[Address(RVA = "0x7996B0", Offset = "0x798AB0", VA = "0x107996B0")]
		internal void <CoExitVent>b__45_1(RoleEffectAnimation an)
		{
		}

		// Token: 0x060015DA RID: 5594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015DA")]
		[Address(RVA = "0x799620", Offset = "0x798A20", VA = "0x10799620")]
		internal void <BootFromVent>b__49_0(Vent v)
		{
		}

		// Token: 0x0400162E RID: 5678
		[Token(Token = "0x400162E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly PlayerPhysics.<>c <>9;

		// Token: 0x0400162F RID: 5679
		[Token(Token = "0x400162F")]
		[FieldOffset(Offset = "0x4")]
		public static Action<RoleEffectAnimation> <>9__44_1;

		// Token: 0x04001630 RID: 5680
		[Token(Token = "0x4001630")]
		[FieldOffset(Offset = "0x8")]
		public static Action<RoleEffectAnimation> <>9__45_1;

		// Token: 0x04001631 RID: 5681
		[Token(Token = "0x4001631")]
		[FieldOffset(Offset = "0xC")]
		public static Action<Vent> <>9__49_0;
	}

	// Token: 0x02000410 RID: 1040
	[Token(Token = "0x2000410")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoEnterVent>d__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060015DB RID: 5595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015DB")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoEnterVent>d__44(int <>1__state)
		{
		}

		// Token: 0x060015DC RID: 5596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015DC")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060015DD RID: 5597 RVA: 0x00006F18 File Offset: 0x00005118
		[Token(Token = "0x60015DD")]
		[Address(RVA = "0x792F60", Offset = "0x792360", VA = "0x10792F60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x060015DE RID: 5598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700030D")]
		private object Current
		{
			[Token(Token = "0x60015DE")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060015DF RID: 5599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015DF")]
		[Address(RVA = "0x7933D0", Offset = "0x7927D0", VA = "0x107933D0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x060015E0 RID: 5600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700030E")]
		private object Current
		{
			[Token(Token = "0x60015E0")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04001632 RID: 5682
		[Token(Token = "0x4001632")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04001633 RID: 5683
		[Token(Token = "0x4001633")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04001634 RID: 5684
		[Token(Token = "0x4001634")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		// Token: 0x04001635 RID: 5685
		[Token(Token = "0x4001635")]
		[FieldOffset(Offset = "0x14")]
		public PlayerPhysics <>4__this;

		// Token: 0x04001636 RID: 5686
		[Token(Token = "0x4001636")]
		[FieldOffset(Offset = "0x18")]
		private PlayerPhysics.<>c__DisplayClass44_0 <>8__1;

		// Token: 0x04001637 RID: 5687
		[Token(Token = "0x4001637")]
		[FieldOffset(Offset = "0x1C")]
		private Vent <vent>5__2;
	}

	// Token: 0x02000411 RID: 1041
	[Token(Token = "0x2000411")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass45_0
	{
		// Token: 0x060015E1 RID: 5601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015E1")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass45_0()
		{
		}

		// Token: 0x060015E2 RID: 5602 RVA: 0x00006F30 File Offset: 0x00005130
		[Token(Token = "0x60015E2")]
		[Address(RVA = "0x5B57A0", Offset = "0x5B4BA0", VA = "0x105B57A0")]
		internal bool <CoExitVent>b__0(Vent v)
		{
			return default(bool);
		}

		// Token: 0x04001638 RID: 5688
		[Token(Token = "0x4001638")]
		[FieldOffset(Offset = "0x8")]
		public int id;
	}

	// Token: 0x02000412 RID: 1042
	[Token(Token = "0x2000412")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoExitVent>d__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060015E3 RID: 5603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015E3")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoExitVent>d__45(int <>1__state)
		{
		}

		// Token: 0x060015E4 RID: 5604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015E4")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060015E5 RID: 5605 RVA: 0x00006F48 File Offset: 0x00005148
		[Token(Token = "0x60015E5")]
		[Address(RVA = "0x793400", Offset = "0x792800", VA = "0x10793400", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x060015E6 RID: 5606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700030F")]
		private object Current
		{
			[Token(Token = "0x60015E6")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060015E7 RID: 5607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015E7")]
		[Address(RVA = "0x7937D0", Offset = "0x792BD0", VA = "0x107937D0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x060015E8 RID: 5608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000310")]
		private object Current
		{
			[Token(Token = "0x60015E8")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04001639 RID: 5689
		[Token(Token = "0x4001639")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x0400163A RID: 5690
		[Token(Token = "0x400163A")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x0400163B RID: 5691
		[Token(Token = "0x400163B")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		// Token: 0x0400163C RID: 5692
		[Token(Token = "0x400163C")]
		[FieldOffset(Offset = "0x14")]
		public PlayerPhysics <>4__this;
	}

	// Token: 0x02000413 RID: 1043
	[Token(Token = "0x2000413")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <WalkPlayerTo>d__46 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060015E9 RID: 5609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015E9")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <WalkPlayerTo>d__46(int <>1__state)
		{
		}

		// Token: 0x060015EA RID: 5610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015EA")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060015EB RID: 5611 RVA: 0x00006F60 File Offset: 0x00005160
		[Token(Token = "0x60015EB")]
		[Address(RVA = "0x79C320", Offset = "0x79B720", VA = "0x1079C320", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x060015EC RID: 5612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000311")]
		private object Current
		{
			[Token(Token = "0x60015EC")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060015ED RID: 5613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015ED")]
		[Address(RVA = "0x79C610", Offset = "0x79BA10", VA = "0x1079C610", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x060015EE RID: 5614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000312")]
		private object Current
		{
			[Token(Token = "0x60015EE")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400163D RID: 5693
		[Token(Token = "0x400163D")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x0400163E RID: 5694
		[Token(Token = "0x400163E")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x0400163F RID: 5695
		[Token(Token = "0x400163F")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 worldPos;

		// Token: 0x04001640 RID: 5696
		[Token(Token = "0x4001640")]
		[FieldOffset(Offset = "0x18")]
		public PlayerPhysics <>4__this;

		// Token: 0x04001641 RID: 5697
		[Token(Token = "0x4001641")]
		[FieldOffset(Offset = "0x1C")]
		public float speedMul;

		// Token: 0x04001642 RID: 5698
		[Token(Token = "0x4001642")]
		[FieldOffset(Offset = "0x20")]
		public float tolerance;

		// Token: 0x04001643 RID: 5699
		[Token(Token = "0x4001643")]
		[FieldOffset(Offset = "0x24")]
		private Rigidbody2D <body>5__2;

		// Token: 0x04001644 RID: 5700
		[Token(Token = "0x4001644")]
		[FieldOffset(Offset = "0x28")]
		private Vector2 <del>5__3;
	}
}
