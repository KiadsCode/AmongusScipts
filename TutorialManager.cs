using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

// Token: 0x02000514 RID: 1300
[Token(Token = "0x2000514")]
public class TutorialManager : DestroyableSingleton<TutorialManager>
{
	// Token: 0x06001B9F RID: 7071 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B9F")]
	[Address(RVA = "0x4B3870", Offset = "0x4B2C70", VA = "0x104B3870", Slot = "4")]
	public override void Awake()
	{
	}

	// Token: 0x06001BA0 RID: 7072 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BA0")]
	[Address(RVA = "0x4B3990", Offset = "0x4B2D90", VA = "0x104B3990", Slot = "5")]
	public override void OnDestroy()
	{
	}

	// Token: 0x06001BA1 RID: 7073 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BA1")]
	[Address(RVA = "0x4B3A10", Offset = "0x4B2E10", VA = "0x104B3A10")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE1190", Offset = "0xE0590")]
	private IEnumerator RunTutorial()
	{
		return null;
	}

	// Token: 0x06001BA2 RID: 7074 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BA2")]
	[Address(RVA = "0x4B3A60", Offset = "0x4B2E60", VA = "0x104B3A60")]
	public TutorialManager()
	{
	}

	// Token: 0x04001F6D RID: 8045
	[Token(Token = "0x4001F6D")]
	[FieldOffset(Offset = "0x10")]
	public PlayerControl PlayerPrefab;

	// Token: 0x02000515 RID: 1301
	[Token(Token = "0x2000515")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <RunTutorial>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001BA3 RID: 7075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BA3")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <RunTutorial>d__3(int <>1__state)
		{
		}

		// Token: 0x06001BA4 RID: 7076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BA4")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001BA5 RID: 7077 RVA: 0x00008BC8 File Offset: 0x00006DC8
		[Token(Token = "0x6001BA5")]
		[Address(RVA = "0x36E250", Offset = "0x36D650", VA = "0x1036E250", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06001BA6 RID: 7078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003FE")]
		private object Current
		{
			[Token(Token = "0x6001BA6")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001BA7 RID: 7079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BA7")]
		[Address(RVA = "0x36E820", Offset = "0x36DC20", VA = "0x1036E820", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06001BA8 RID: 7080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003FF")]
		private object Current
		{
			[Token(Token = "0x6001BA8")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04001F6E RID: 8046
		[Token(Token = "0x4001F6E")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04001F6F RID: 8047
		[Token(Token = "0x4001F6F")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04001F70 RID: 8048
		[Token(Token = "0x4001F70")]
		[FieldOffset(Offset = "0x10")]
		public TutorialManager <>4__this;
	}
}
