using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

// Token: 0x0200007F RID: 127
[Token(Token = "0x200007F")]
public class AutoMultistageMinigame : Minigame
{
	// Token: 0x06000333 RID: 819 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000333")]
	[Address(RVA = "0x54ED70", Offset = "0x54E170", VA = "0x1054ED70", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x06000334 RID: 820 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000334")]
	[Address(RVA = "0x54EFC0", Offset = "0x54E3C0", VA = "0x1054EFC0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE5520", Offset = "0xE4920")]
	private IEnumerator Run()
	{
		return null;
	}

	// Token: 0x06000335 RID: 821 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000335")]
	[Address(RVA = "0x54EF20", Offset = "0x54E320", VA = "0x1054EF20", Slot = "5")]
	public override void Close()
	{
	}

	// Token: 0x06000336 RID: 822 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000336")]
	[Address(RVA = "0x3AC2A0", Offset = "0x3AB6A0", VA = "0x103AC2A0")]
	public AutoMultistageMinigame()
	{
	}

	// Token: 0x040002FC RID: 764
	[Token(Token = "0x40002FC")]
	[FieldOffset(Offset = "0x30")]
	public Minigame[] Stages;

	// Token: 0x040002FD RID: 765
	[Token(Token = "0x40002FD")]
	[FieldOffset(Offset = "0x34")]
	private Minigame stage;

	// Token: 0x02000080 RID: 128
	[Token(Token = "0x2000080")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <Run>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000337 RID: 823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000337")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <Run>d__3(int <>1__state)
		{
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000338")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00002988 File Offset: 0x00000B88
		[Token(Token = "0x6000339")]
		[Address(RVA = "0x3C9A10", Offset = "0x3C8E10", VA = "0x103C9A10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600033A RID: 826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007A")]
		private object Current
		{
			[Token(Token = "0x600033A")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600033B")]
		[Address(RVA = "0x3C9AC0", Offset = "0x3C8EC0", VA = "0x103C9AC0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600033C RID: 828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007B")]
		private object Current
		{
			[Token(Token = "0x600033C")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040002FE RID: 766
		[Token(Token = "0x40002FE")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040002FF RID: 767
		[Token(Token = "0x40002FF")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000300 RID: 768
		[Token(Token = "0x4000300")]
		[FieldOffset(Offset = "0x10")]
		public AutoMultistageMinigame <>4__this;
	}
}
