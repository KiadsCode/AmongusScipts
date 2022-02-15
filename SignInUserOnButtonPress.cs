using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GameCore;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003DE RID: 990
[Token(Token = "0x20003DE")]
public class SignInUserOnButtonPress : MonoBehaviour
{
	// Token: 0x06001481 RID: 5249 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001481")]
	[Address(RVA = "0x49A1A0", Offset = "0x4995A0", VA = "0x1049A1A0")]
	private void OnEnable()
	{
	}

	// Token: 0x06001482 RID: 5250 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001482")]
	[Address(RVA = "0x49A0E0", Offset = "0x4994E0", VA = "0x1049A0E0")]
	private void OnDisable()
	{
	}

	// Token: 0x06001483 RID: 5251 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001483")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680")]
	private void Update()
	{
	}

	// Token: 0x06001484 RID: 5252 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001484")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680")]
	public void AddUserWithUI()
	{
	}

	// Token: 0x06001485 RID: 5253 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001485")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680")]
	private void AddUserCompleted(UserManager.UserOpResult result)
	{
	}

	// Token: 0x06001486 RID: 5254 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001486")]
	[Address(RVA = "0x49A060", Offset = "0x499460", VA = "0x1049A060")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDE9F0", Offset = "0xDDDF0")]
	private IEnumerator ContinueToNextScene()
	{
		return null;
	}

	// Token: 0x06001487 RID: 5255 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001487")]
	[Address(RVA = "0x49A0B0", Offset = "0x4994B0", VA = "0x1049A0B0")]
	public void HandleInvite(string connectionString)
	{
	}

	// Token: 0x06001488 RID: 5256 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001488")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public SignInUserOnButtonPress()
	{
	}

	// Token: 0x0400152F RID: 5423
	[Token(Token = "0x400152F")]
	[FieldOffset(Offset = "0xC")]
	public Action OnButtonPress;

	// Token: 0x04001530 RID: 5424
	[Token(Token = "0x4001530")]
	[FieldOffset(Offset = "0x10")]
	public SceneChanger SceneChanger;

	// Token: 0x04001531 RID: 5425
	[Token(Token = "0x4001531")]
	[FieldOffset(Offset = "0x14")]
	public TextTranslatorTMP Text;

	// Token: 0x04001532 RID: 5426
	[Token(Token = "0x4001532")]
	[FieldOffset(Offset = "0x18")]
	private bool inviteReceived;

	// Token: 0x020003DF RID: 991
	[Token(Token = "0x20003DF")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <ContinueToNextScene>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001489 RID: 5257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001489")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <ContinueToNextScene>d__9(int <>1__state)
		{
		}

		// Token: 0x0600148A RID: 5258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600148A")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600148B RID: 5259 RVA: 0x00006978 File Offset: 0x00004B78
		[Token(Token = "0x600148B")]
		[Address(RVA = "0x36A970", Offset = "0x369D70", VA = "0x1036A970", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x0600148C RID: 5260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E2")]
		private object Current
		{
			[Token(Token = "0x600148C")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600148D RID: 5261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600148D")]
		[Address(RVA = "0x36A9C0", Offset = "0x369DC0", VA = "0x1036A9C0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x0600148E RID: 5262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E3")]
		private object Current
		{
			[Token(Token = "0x600148E")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04001533 RID: 5427
		[Token(Token = "0x4001533")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04001534 RID: 5428
		[Token(Token = "0x4001534")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04001535 RID: 5429
		[Token(Token = "0x4001535")]
		[FieldOffset(Offset = "0x10")]
		public SignInUserOnButtonPress <>4__this;
	}
}
