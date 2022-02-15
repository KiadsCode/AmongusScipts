using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003E1 RID: 993
[Token(Token = "0x20003E1")]
public class DummyBehaviour : MonoBehaviour
{
	// Token: 0x06001492 RID: 5266 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001492")]
	[Address(RVA = "0x46E180", Offset = "0x46D580", VA = "0x1046E180")]
	public void Start()
	{
	}

	// Token: 0x06001493 RID: 5267 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001493")]
	[Address(RVA = "0x46E1C0", Offset = "0x46D5C0", VA = "0x1046E1C0")]
	public void Update()
	{
	}

	// Token: 0x06001494 RID: 5268 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001494")]
	[Address(RVA = "0x46E130", Offset = "0x46D530", VA = "0x1046E130")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDEB30", Offset = "0xDDF30")]
	private IEnumerator DoVote()
	{
		return null;
	}

	// Token: 0x06001495 RID: 5269 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001495")]
	[Address(RVA = "0x46E2B0", Offset = "0x46D6B0", VA = "0x1046E2B0")]
	public DummyBehaviour()
	{
	}

	// Token: 0x0400153B RID: 5435
	[Token(Token = "0x400153B")]
	[FieldOffset(Offset = "0xC")]
	private PlayerControl myPlayer;

	// Token: 0x0400153C RID: 5436
	[Token(Token = "0x400153C")]
	[FieldOffset(Offset = "0x10")]
	private FloatRange voteTime;

	// Token: 0x0400153D RID: 5437
	[Token(Token = "0x400153D")]
	[FieldOffset(Offset = "0x14")]
	private bool voted;

	// Token: 0x020003E2 RID: 994
	[Token(Token = "0x20003E2")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <DoVote>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001496 RID: 5270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001496")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <DoVote>d__5(int <>1__state)
		{
		}

		// Token: 0x06001497 RID: 5271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001497")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001498 RID: 5272 RVA: 0x000069A8 File Offset: 0x00004BA8
		[Token(Token = "0x6001498")]
		[Address(RVA = "0x787CB0", Offset = "0x7870B0", VA = "0x10787CB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06001499 RID: 5273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E5")]
		private object Current
		{
			[Token(Token = "0x6001499")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600149A RID: 5274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600149A")]
		[Address(RVA = "0x787E60", Offset = "0x787260", VA = "0x10787E60", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x0600149B RID: 5275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E6")]
		private object Current
		{
			[Token(Token = "0x600149B")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400153E RID: 5438
		[Token(Token = "0x400153E")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x0400153F RID: 5439
		[Token(Token = "0x400153F")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04001540 RID: 5440
		[Token(Token = "0x4001540")]
		[FieldOffset(Offset = "0x10")]
		public DummyBehaviour <>4__this;
	}
}
