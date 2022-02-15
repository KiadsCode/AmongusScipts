using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000219 RID: 537
[Token(Token = "0x2000219")]
public class MeetingCalledAnimation : OverlayAnimation
{
	// Token: 0x06000BFB RID: 3067 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BFB")]
	[Address(RVA = "0x76D860", Offset = "0x76CC60", VA = "0x1076D860")]
	public void Initialize(GameData.PlayerInfo reportInfo)
	{
	}

	// Token: 0x06000BFC RID: 3068 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BFC")]
	[Address(RVA = "0x76D810", Offset = "0x76CC10", VA = "0x1076D810", Slot = "4")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE2130", Offset = "0xE1530")]
	public override IEnumerator CoShow(KillOverlay parent)
	{
		return null;
	}

	// Token: 0x06000BFD RID: 3069 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BFD")]
	[Address(RVA = "0x76D890", Offset = "0x76CC90", VA = "0x1076D890")]
	public MeetingCalledAnimation()
	{
	}

	// Token: 0x04000BF7 RID: 3063
	[Token(Token = "0x4000BF7")]
	[FieldOffset(Offset = "0xC")]
	public AspectPosition emergencyText;

	// Token: 0x04000BF8 RID: 3064
	[Token(Token = "0x4000BF8")]
	[FieldOffset(Offset = "0x10")]
	public PoolablePlayer playerParts;

	// Token: 0x04000BF9 RID: 3065
	[Token(Token = "0x4000BF9")]
	[FieldOffset(Offset = "0x14")]
	public AudioClip Stinger;

	// Token: 0x04000BFA RID: 3066
	[Token(Token = "0x4000BFA")]
	[FieldOffset(Offset = "0x18")]
	public float StingerVolume;

	// Token: 0x04000BFB RID: 3067
	[Token(Token = "0x4000BFB")]
	[FieldOffset(Offset = "0x1C")]
	public AnimationCurve CrewmateSlide;

	// Token: 0x0200021A RID: 538
	[Token(Token = "0x200021A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass6_0
	{
		// Token: 0x06000BFE RID: 3070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BFE")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass6_0()
		{
		}

		// Token: 0x06000BFF RID: 3071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BFF")]
		[Address(RVA = "0x79AEE0", Offset = "0x79A2E0", VA = "0x1079AEE0")]
		internal void <CoShow>b__0(float t)
		{
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C00")]
		[Address(RVA = "0x79AF40", Offset = "0x79A340", VA = "0x1079AF40")]
		internal void <CoShow>b__1(float t)
		{
		}

		// Token: 0x04000BFC RID: 3068
		[Token(Token = "0x4000BFC")]
		[FieldOffset(Offset = "0x8")]
		public MeetingCalledAnimation <>4__this;

		// Token: 0x04000BFD RID: 3069
		[Token(Token = "0x4000BFD")]
		[FieldOffset(Offset = "0xC")]
		public AspectPosition playerTransform;
	}

	// Token: 0x0200021B RID: 539
	[Token(Token = "0x200021B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoShow>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000C01 RID: 3073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C01")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoShow>d__6(int <>1__state)
		{
		}

		// Token: 0x06000C02 RID: 3074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C02")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x00004CF8 File Offset: 0x00002EF8
		[Token(Token = "0x6000C03")]
		[Address(RVA = "0x794DB0", Offset = "0x7941B0", VA = "0x10794DB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000C04 RID: 3076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001C8")]
		private object Current
		{
			[Token(Token = "0x6000C04")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000C05 RID: 3077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C05")]
		[Address(RVA = "0x7950C0", Offset = "0x7944C0", VA = "0x107950C0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000C06 RID: 3078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001C9")]
		private object Current
		{
			[Token(Token = "0x6000C06")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000BFE RID: 3070
		[Token(Token = "0x4000BFE")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000BFF RID: 3071
		[Token(Token = "0x4000BFF")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000C00 RID: 3072
		[Token(Token = "0x4000C00")]
		[FieldOffset(Offset = "0x10")]
		public MeetingCalledAnimation <>4__this;
	}
}
