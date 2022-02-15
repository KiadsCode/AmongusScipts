using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using PowerTools;
using UnityEngine;

// Token: 0x020002C3 RID: 707
[Token(Token = "0x20002C3")]
public class HostLocalGameButton : MonoBehaviour, IConnectButton
{
	// Token: 0x06000FA5 RID: 4005 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FA5")]
	[Address(RVA = "0x3E9000", Offset = "0x3E8400", VA = "0x103E9000")]
	public void Start()
	{
	}

	// Token: 0x06000FA6 RID: 4006 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FA6")]
	[Address(RVA = "0x3E8D90", Offset = "0x3E8190", VA = "0x103E8D90")]
	public void OnClick()
	{
	}

	// Token: 0x06000FA7 RID: 4007 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FA7")]
	[Address(RVA = "0x3E8F80", Offset = "0x3E8380", VA = "0x103E8F80", Slot = "4")]
	public void StartIcon()
	{
	}

	// Token: 0x06000FA8 RID: 4008 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FA8")]
	[Address(RVA = "0x3E9060", Offset = "0x3E8460", VA = "0x103E9060", Slot = "5")]
	public void StopIcon()
	{
	}

	// Token: 0x06000FA9 RID: 4009 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FA9")]
	[Address(RVA = "0x3E8D40", Offset = "0x3E8140", VA = "0x103E8D40")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE5F00", Offset = "0xE5300")]
	private IEnumerator CoStartGame()
	{
		return null;
	}

	// Token: 0x06000FAA RID: 4010 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FAA")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public HostLocalGameButton()
	{
	}

	// Token: 0x04000F7E RID: 3966
	[Token(Token = "0x4000F7E")]
	[FieldOffset(Offset = "0xC")]
	public AudioClip IntroMusic;

	// Token: 0x04000F7F RID: 3967
	[Token(Token = "0x4000F7F")]
	[FieldOffset(Offset = "0x10")]
	public SpriteRenderer FillScreen;

	// Token: 0x04000F80 RID: 3968
	[Token(Token = "0x4000F80")]
	[FieldOffset(Offset = "0x14")]
	public SpriteAnim connectIcon;

	// Token: 0x04000F81 RID: 3969
	[Token(Token = "0x4000F81")]
	[FieldOffset(Offset = "0x18")]
	public AnimationClip connectClip;

	// Token: 0x04000F82 RID: 3970
	[Token(Token = "0x4000F82")]
	[FieldOffset(Offset = "0x1C")]
	public GameModes GameMode;

	// Token: 0x020002C4 RID: 708
	[Token(Token = "0x20002C4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoStartGame>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000FAB RID: 4011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FAB")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoStartGame>d__9(int <>1__state)
		{
		}

		// Token: 0x06000FAC RID: 4012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FAC")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000FAD RID: 4013 RVA: 0x00005B20 File Offset: 0x00003D20
		[Token(Token = "0x6000FAD")]
		[Address(RVA = "0x5AD560", Offset = "0x5AC960", VA = "0x105AD560", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000FAE RID: 4014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700025F")]
		private object Current
		{
			[Token(Token = "0x6000FAE")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000FAF RID: 4015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FAF")]
		[Address(RVA = "0x5ADD50", Offset = "0x5AD150", VA = "0x105ADD50", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000FB0 RID: 4016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000260")]
		private object Current
		{
			[Token(Token = "0x6000FB0")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000F83 RID: 3971
		[Token(Token = "0x4000F83")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000F84 RID: 3972
		[Token(Token = "0x4000F84")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000F85 RID: 3973
		[Token(Token = "0x4000F85")]
		[FieldOffset(Offset = "0x10")]
		public HostLocalGameButton <>4__this;

		// Token: 0x04000F86 RID: 3974
		[Token(Token = "0x4000F86")]
		[FieldOffset(Offset = "0x14")]
		private float <time>5__2;
	}
}
