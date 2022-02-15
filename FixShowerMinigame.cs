using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000091 RID: 145
[Token(Token = "0x2000091")]
public class FixShowerMinigame : Minigame
{
	// Token: 0x17000088 RID: 136
	// (get) Token: 0x06000389 RID: 905 RVA: 0x00002AA8 File Offset: 0x00000CA8
	[Token(Token = "0x17000088")]
	private float Power
	{
		[Token(Token = "0x6000389")]
		[Address(RVA = "0x3A7920", Offset = "0x3A6D20", VA = "0x103A7920")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x0600038A RID: 906 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600038A")]
	[Address(RVA = "0x3A71E0", Offset = "0x3A65E0", VA = "0x103A71E0")]
	public void Start()
	{
	}

	// Token: 0x0600038B RID: 907 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600038B")]
	[Address(RVA = "0x3A7410", Offset = "0x3A6810", VA = "0x103A7410")]
	public void Update()
	{
	}

	// Token: 0x0600038C RID: 908 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600038C")]
	[Address(RVA = "0x3A7100", Offset = "0x3A6500", VA = "0x103A7100")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE59D0", Offset = "0xE4DD0")]
	public IEnumerator Bash(float power)
	{
		return null;
	}

	// Token: 0x0600038D RID: 909 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600038D")]
	[Address(RVA = "0x3A7160", Offset = "0x3A6560", VA = "0x103A7160", Slot = "5")]
	public override void Close()
	{
	}

	// Token: 0x0600038E RID: 910 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600038E")]
	[Address(RVA = "0x3A7870", Offset = "0x3A6C70", VA = "0x103A7870")]
	public FixShowerMinigame()
	{
	}

	// Token: 0x0600038F RID: 911 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600038F")]
	[Address(RVA = "0x3A7320", Offset = "0x3A6720", VA = "0x103A7320")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private void <Bash>b__22_0(float t)
	{
	}

	// Token: 0x04000374 RID: 884
	[Token(Token = "0x4000374")]
	private const float PowerRatio = 0.32f;

	// Token: 0x04000375 RID: 885
	[Token(Token = "0x4000375")]
	private const float BasePower = 0.04f;

	// Token: 0x04000376 RID: 886
	[Token(Token = "0x4000376")]
	private const float CompleteTolerance = 0.07f;

	// Token: 0x04000377 RID: 887
	[Token(Token = "0x4000377")]
	[FieldOffset(Offset = "0x30")]
	private FloatRange hammerAngles;

	// Token: 0x04000378 RID: 888
	[Token(Token = "0x4000378")]
	[FieldOffset(Offset = "0x34")]
	private FloatRange showerAngles;

	// Token: 0x04000379 RID: 889
	[Token(Token = "0x4000379")]
	[FieldOffset(Offset = "0x38")]
	private float showerPos;

	// Token: 0x0400037A RID: 890
	[Token(Token = "0x400037A")]
	[FieldOffset(Offset = "0x3C")]
	public SpriteRenderer mallet;

	// Token: 0x0400037B RID: 891
	[Token(Token = "0x400037B")]
	[FieldOffset(Offset = "0x40")]
	public Collider2D showerHead;

	// Token: 0x0400037C RID: 892
	[Token(Token = "0x400037C")]
	[FieldOffset(Offset = "0x44")]
	public AnimationCurve hammerAnim;

	// Token: 0x0400037D RID: 893
	[Token(Token = "0x400037D")]
	[FieldOffset(Offset = "0x48")]
	private Controller controller;

	// Token: 0x0400037E RID: 894
	[Token(Token = "0x400037E")]
	[FieldOffset(Offset = "0x4C")]
	private float powerTime;

	// Token: 0x0400037F RID: 895
	[Token(Token = "0x400037F")]
	[FieldOffset(Offset = "0x50")]
	public PowerBar powerBar;

	// Token: 0x04000380 RID: 896
	[Token(Token = "0x4000380")]
	[FieldOffset(Offset = "0x54")]
	public AudioClip[] bashSounds;

	// Token: 0x04000381 RID: 897
	[Token(Token = "0x4000381")]
	[FieldOffset(Offset = "0x58")]
	public AudioClip swingSound;

	// Token: 0x04000382 RID: 898
	[Token(Token = "0x4000382")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject leftGlyph;

	// Token: 0x04000383 RID: 899
	[Token(Token = "0x4000383")]
	[FieldOffset(Offset = "0x60")]
	public GameObject rightGlyph;

	// Token: 0x04000384 RID: 900
	[Token(Token = "0x4000384")]
	[FieldOffset(Offset = "0x64")]
	private bool prevButtonHeld;

	// Token: 0x04000385 RID: 901
	[Token(Token = "0x4000385")]
	[FieldOffset(Offset = "0x65")]
	private bool animating;

	// Token: 0x02000092 RID: 146
	[Token(Token = "0x2000092")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <Bash>d__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000390 RID: 912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000390")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <Bash>d__22(int <>1__state)
		{
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000391")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00002AC0 File Offset: 0x00000CC0
		[Token(Token = "0x6000392")]
		[Address(RVA = "0x782EF0", Offset = "0x7822F0", VA = "0x10782EF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000393 RID: 915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000089")]
		private object Current
		{
			[Token(Token = "0x6000393")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000394")]
		[Address(RVA = "0x7834A0", Offset = "0x7828A0", VA = "0x107834A0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000395 RID: 917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700008A")]
		private object Current
		{
			[Token(Token = "0x6000395")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000386 RID: 902
		[Token(Token = "0x4000386")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000387 RID: 903
		[Token(Token = "0x4000387")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000388 RID: 904
		[Token(Token = "0x4000388")]
		[FieldOffset(Offset = "0x10")]
		public FixShowerMinigame <>4__this;

		// Token: 0x04000389 RID: 905
		[Token(Token = "0x4000389")]
		[FieldOffset(Offset = "0x14")]
		public float power;
	}
}
