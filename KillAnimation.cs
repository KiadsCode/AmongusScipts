using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using PowerTools;
using UnityEngine;

// Token: 0x020003EF RID: 1007
[Token(Token = "0x20003EF")]
public class KillAnimation : MonoBehaviour
{
	// Token: 0x060014D5 RID: 5333 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014D5")]
	[Address(RVA = "0x6D6790", Offset = "0x6D5B90", VA = "0x106D6790")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDEB80", Offset = "0xDDF80")]
	public IEnumerator CoPerformKill(PlayerControl source, PlayerControl target)
	{
		return null;
	}

	// Token: 0x060014D6 RID: 5334 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014D6")]
	[Address(RVA = "0x6D67F0", Offset = "0x6D5BF0", VA = "0x106D67F0")]
	public static void SetMovement(PlayerControl source, bool canMove)
	{
	}

	// Token: 0x060014D7 RID: 5335 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014D7")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public KillAnimation()
	{
	}

	// Token: 0x04001570 RID: 5488
	[Token(Token = "0x4001570")]
	[FieldOffset(Offset = "0xC")]
	public AnimationClip BlurAnim;

	// Token: 0x04001571 RID: 5489
	[Token(Token = "0x4001571")]
	[FieldOffset(Offset = "0x10")]
	public DeadBody bodyPrefab;

	// Token: 0x04001572 RID: 5490
	[Token(Token = "0x4001572")]
	[FieldOffset(Offset = "0x14")]
	public Vector3 BodyOffset;

	// Token: 0x020003F0 RID: 1008
	[Token(Token = "0x20003F0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoPerformKill>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060014D8 RID: 5336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014D8")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoPerformKill>d__3(int <>1__state)
		{
		}

		// Token: 0x060014D9 RID: 5337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014D9")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060014DA RID: 5338 RVA: 0x00006B28 File Offset: 0x00004D28
		[Token(Token = "0x60014DA")]
		[Address(RVA = "0x5AB510", Offset = "0x5AA910", VA = "0x105AB510", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x060014DB RID: 5339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002EF")]
		private object Current
		{
			[Token(Token = "0x60014DB")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060014DC RID: 5340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014DC")]
		[Address(RVA = "0x5ABA80", Offset = "0x5AAE80", VA = "0x105ABA80", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x060014DD RID: 5341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002F0")]
		private object Current
		{
			[Token(Token = "0x60014DD")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04001573 RID: 5491
		[Token(Token = "0x4001573")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04001574 RID: 5492
		[Token(Token = "0x4001574")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04001575 RID: 5493
		[Token(Token = "0x4001575")]
		[FieldOffset(Offset = "0x10")]
		public PlayerControl source;

		// Token: 0x04001576 RID: 5494
		[Token(Token = "0x4001576")]
		[FieldOffset(Offset = "0x14")]
		public PlayerControl target;

		// Token: 0x04001577 RID: 5495
		[Token(Token = "0x4001577")]
		[FieldOffset(Offset = "0x18")]
		public KillAnimation <>4__this;

		// Token: 0x04001578 RID: 5496
		[Token(Token = "0x4001578")]
		[FieldOffset(Offset = "0x1C")]
		private FollowerCamera <cam>5__2;

		// Token: 0x04001579 RID: 5497
		[Token(Token = "0x4001579")]
		[FieldOffset(Offset = "0x20")]
		private bool <isParticipant>5__3;

		// Token: 0x0400157A RID: 5498
		[Token(Token = "0x400157A")]
		[FieldOffset(Offset = "0x24")]
		private PlayerPhysics <sourcePhys>5__4;

		// Token: 0x0400157B RID: 5499
		[Token(Token = "0x400157B")]
		[FieldOffset(Offset = "0x28")]
		private DeadBody <deadBody>5__5;

		// Token: 0x0400157C RID: 5500
		[Token(Token = "0x400157C")]
		[FieldOffset(Offset = "0x2C")]
		private SpriteAnim <sourceAnim>5__6;
	}
}
