using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Hazel;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000073 RID: 115
[Token(Token = "0x2000073")]
public class MovingPlatformBehaviour : MonoBehaviour, ISystemType
{
	// Token: 0x17000072 RID: 114
	// (get) Token: 0x060002F3 RID: 755 RVA: 0x000028B0 File Offset: 0x00000AB0
	[Token(Token = "0x17000072")]
	public bool InUse
	{
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x775670", Offset = "0x774A70", VA = "0x10775670")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000073 RID: 115
	// (get) Token: 0x060002F4 RID: 756 RVA: 0x000028C8 File Offset: 0x00000AC8
	// (set) Token: 0x060002F5 RID: 757 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000073")]
	public bool IsDirty
	{
		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x6074F0", Offset = "0x6068F0", VA = "0x106074F0", Slot = "4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x6075E0", Offset = "0x6069E0", VA = "0x106075E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private set
		{
		}
	}

	// Token: 0x060002F6 RID: 758 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002F6")]
	[Address(RVA = "0x775610", Offset = "0x774A10", VA = "0x10775610")]
	public void Use()
	{
	}

	// Token: 0x060002F7 RID: 759 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002F7")]
	[Address(RVA = "0x7754C0", Offset = "0x7748C0", VA = "0x107754C0")]
	public void Use(PlayerControl player)
	{
	}

	// Token: 0x060002F8 RID: 760 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002F8")]
	[Address(RVA = "0x775400", Offset = "0x774800", VA = "0x10775400")]
	public void Start()
	{
	}

	// Token: 0x060002F9 RID: 761 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002F9")]
	[Address(RVA = "0x775080", Offset = "0x774480", VA = "0x10775080")]
	private void SetSide(bool isLeft)
	{
	}

	// Token: 0x060002FA RID: 762 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002FA")]
	[Address(RVA = "0x7750E0", Offset = "0x7744E0", VA = "0x107750E0")]
	private void SetTarget(uint playerNetId, bool isLeft)
	{
	}

	// Token: 0x060002FB RID: 763 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002FB")]
	[Address(RVA = "0x775460", Offset = "0x774860", VA = "0x10775460")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE52D0", Offset = "0xE46D0")]
	private IEnumerator UsePlatform(PlayerControl target)
	{
		return null;
	}

	// Token: 0x060002FC RID: 764 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002FC")]
	[Address(RVA = "0x7751E0", Offset = "0x7745E0", VA = "0x107751E0")]
	private void SoundDynamics(AudioSource source, float dt)
	{
	}

	// Token: 0x060002FD RID: 765 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002FD")]
	[Address(RVA = "0x774E40", Offset = "0x774240", VA = "0x10774E40")]
	public void MeetingCalled()
	{
	}

	// Token: 0x060002FE RID: 766 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002FE")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
	public void Detoriorate(float deltaTime)
	{
	}

	// Token: 0x060002FF RID: 767 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002FF")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "6")]
	public void RepairDamage(PlayerControl player, byte amount)
	{
	}

	// Token: 0x06000300 RID: 768 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000300")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "7")]
	public void UpdateSystem(PlayerControl player, MessageReader msgReader)
	{
	}

	// Token: 0x06000301 RID: 769 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000301")]
	[Address(RVA = "0x775020", Offset = "0x774420", VA = "0x10775020", Slot = "8")]
	public void Serialize(MessageWriter writer, bool initialState)
	{
	}

	// Token: 0x06000302 RID: 770 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000302")]
	[Address(RVA = "0x774D90", Offset = "0x774190", VA = "0x10774D90", Slot = "9")]
	public void Deserialize(MessageReader reader, bool initialState)
	{
	}

	// Token: 0x06000303 RID: 771 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000303")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public MovingPlatformBehaviour()
	{
	}

	// Token: 0x040002AA RID: 682
	[Token(Token = "0x40002AA")]
	[FieldOffset(Offset = "0xC")]
	public Vector3 LeftPosition;

	// Token: 0x040002AB RID: 683
	[Token(Token = "0x40002AB")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 RightPosition;

	// Token: 0x040002AC RID: 684
	[Token(Token = "0x40002AC")]
	[FieldOffset(Offset = "0x24")]
	public Vector3 LeftUsePosition;

	// Token: 0x040002AD RID: 685
	[Token(Token = "0x40002AD")]
	[FieldOffset(Offset = "0x30")]
	public Vector3 RightUsePosition;

	// Token: 0x040002AE RID: 686
	[Token(Token = "0x40002AE")]
	[FieldOffset(Offset = "0x3C")]
	public AudioClip MovingSound;

	// Token: 0x040002AF RID: 687
	[Token(Token = "0x40002AF")]
	[FieldOffset(Offset = "0x40")]
	private bool IsLeft;

	// Token: 0x040002B0 RID: 688
	[Token(Token = "0x40002B0")]
	[FieldOffset(Offset = "0x44")]
	private PlayerControl Target;

	// Token: 0x040002B1 RID: 689
	[Token(Token = "0x40002B1")]
	[FieldOffset(Offset = "0x48")]
	private byte useId;

	// Token: 0x040002B2 RID: 690
	[Token(Token = "0x40002B2")]
	[FieldOffset(Offset = "0x49")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private bool <IsDirty>k__BackingField;

	// Token: 0x02000074 RID: 116
	[Token(Token = "0x2000074")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <UsePlatform>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000304 RID: 772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000304")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <UsePlatform>d__19(int <>1__state)
		{
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000305")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000306 RID: 774 RVA: 0x000028E0 File Offset: 0x00000AE0
		[Token(Token = "0x6000306")]
		[Address(RVA = "0x79B430", Offset = "0x79A830", VA = "0x1079B430", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000307 RID: 775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000074")]
		private object Current
		{
			[Token(Token = "0x6000307")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000308")]
		[Address(RVA = "0x79BE90", Offset = "0x79B290", VA = "0x1079BE90", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000309 RID: 777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000075")]
		private object Current
		{
			[Token(Token = "0x6000309")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040002B3 RID: 691
		[Token(Token = "0x40002B3")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040002B4 RID: 692
		[Token(Token = "0x40002B4")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040002B5 RID: 693
		[Token(Token = "0x40002B5")]
		[FieldOffset(Offset = "0x10")]
		public MovingPlatformBehaviour <>4__this;

		// Token: 0x040002B6 RID: 694
		[Token(Token = "0x40002B6")]
		[FieldOffset(Offset = "0x14")]
		public PlayerControl target;

		// Token: 0x040002B7 RID: 695
		[Token(Token = "0x40002B7")]
		[FieldOffset(Offset = "0x18")]
		private Vector3 <sourcePos>5__2;

		// Token: 0x040002B8 RID: 696
		[Token(Token = "0x40002B8")]
		[FieldOffset(Offset = "0x24")]
		private Vector3 <targetPos>5__3;

		// Token: 0x040002B9 RID: 697
		[Token(Token = "0x40002B9")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 <worldUseTargetPos>5__4;

		// Token: 0x040002BA RID: 698
		[Token(Token = "0x40002BA")]
		[FieldOffset(Offset = "0x3C")]
		private Vector3 <worldSourcePos>5__5;

		// Token: 0x040002BB RID: 699
		[Token(Token = "0x40002BB")]
		[FieldOffset(Offset = "0x48")]
		private Vector3 <worldTargetPos>5__6;
	}
}
