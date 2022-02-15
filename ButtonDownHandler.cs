using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000233 RID: 563
[Token(Token = "0x2000233")]
public class ButtonDownHandler : MonoBehaviour
{
	// Token: 0x06000C96 RID: 3222 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C96")]
	[Address(RVA = "0x82C050", Offset = "0x82B450", VA = "0x1082C050")]
	public void Start()
	{
	}

	// Token: 0x06000C97 RID: 3223 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C97")]
	[Address(RVA = "0x82BF90", Offset = "0x82B390", VA = "0x1082BF90")]
	public void OnDisable()
	{
	}

	// Token: 0x06000C98 RID: 3224 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C98")]
	[Address(RVA = "0x82BFE0", Offset = "0x82B3E0", VA = "0x1082BFE0")]
	private void StartDown()
	{
	}

	// Token: 0x06000C99 RID: 3225 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C99")]
	[Address(RVA = "0x82BF40", Offset = "0x82B340", VA = "0x1082BF40")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE2740", Offset = "0xE1B40")]
	private IEnumerator CoRunDown()
	{
		return null;
	}

	// Token: 0x06000C9A RID: 3226 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C9A")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public ButtonDownHandler()
	{
	}

	// Token: 0x04000C90 RID: 3216
	[Token(Token = "0x4000C90")]
	[FieldOffset(Offset = "0xC")]
	private Coroutine downState;

	// Token: 0x04000C91 RID: 3217
	[Token(Token = "0x4000C91")]
	[FieldOffset(Offset = "0x10")]
	public SpriteRenderer Target;

	// Token: 0x04000C92 RID: 3218
	[Token(Token = "0x4000C92")]
	[FieldOffset(Offset = "0x14")]
	public Sprite UpSprite;

	// Token: 0x04000C93 RID: 3219
	[Token(Token = "0x4000C93")]
	[FieldOffset(Offset = "0x18")]
	public Sprite DownSprite;

	// Token: 0x02000234 RID: 564
	[Token(Token = "0x2000234")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoRunDown>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000C9B RID: 3227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C9B")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoRunDown>d__7(int <>1__state)
		{
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C9C")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000C9D RID: 3229 RVA: 0x00004F80 File Offset: 0x00003180
		[Token(Token = "0x6000C9D")]
		[Address(RVA = "0x3C5BD0", Offset = "0x3C4FD0", VA = "0x103C5BD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000C9E RID: 3230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001D6")]
		private object Current
		{
			[Token(Token = "0x6000C9E")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000C9F RID: 3231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C9F")]
		[Address(RVA = "0x3C5CA0", Offset = "0x3C50A0", VA = "0x103C5CA0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000CA0 RID: 3232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001D7")]
		private object Current
		{
			[Token(Token = "0x6000CA0")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000C94 RID: 3220
		[Token(Token = "0x4000C94")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000C95 RID: 3221
		[Token(Token = "0x4000C95")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000C96 RID: 3222
		[Token(Token = "0x4000C96")]
		[FieldOffset(Offset = "0x10")]
		public ButtonDownHandler <>4__this;
	}
}
