using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000089 RID: 137
[Token(Token = "0x2000089")]
public class ElecLeverGame : Minigame
{
	// Token: 0x06000351 RID: 849 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000351")]
	[Address(RVA = "0x4756A0", Offset = "0x474AA0", VA = "0x104756A0", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x06000352 RID: 850 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000352")]
	[Address(RVA = "0x475880", Offset = "0x474C80", VA = "0x10475880")]
	private void ResetLights()
	{
	}

	// Token: 0x06000353 RID: 851 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000353")]
	[Address(RVA = "0x475910", Offset = "0x474D10", VA = "0x10475910")]
	private void SetLights(bool on)
	{
	}

	// Token: 0x06000354 RID: 852 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000354")]
	[Address(RVA = "0x4759C0", Offset = "0x474DC0", VA = "0x104759C0")]
	private void Update()
	{
	}

	// Token: 0x06000355 RID: 853 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000355")]
	[Address(RVA = "0x475830", Offset = "0x474C30", VA = "0x10475830")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE5750", Offset = "0xE4B50")]
	private IEnumerator FinishUp()
	{
		return null;
	}

	// Token: 0x06000356 RID: 854 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000356")]
	[Address(RVA = "0x476350", Offset = "0x475750", VA = "0x10476350")]
	public ElecLeverGame()
	{
	}

	// Token: 0x06000357 RID: 855 RVA: 0x000029E8 File Offset: 0x00000BE8
	[Token(Token = "0x6000357")]
	[Address(RVA = "0x4759A0", Offset = "0x474DA0", VA = "0x104759A0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private bool <Begin>b__12_0(byte b)
	{
		return default(bool);
	}

	// Token: 0x04000346 RID: 838
	[Token(Token = "0x4000346")]
	[FieldOffset(Offset = "0x30")]
	public Sprite[] NumberIcons;

	// Token: 0x04000347 RID: 839
	[Token(Token = "0x4000347")]
	[FieldOffset(Offset = "0x34")]
	public SpriteRenderer NumberImage;

	// Token: 0x04000348 RID: 840
	[Token(Token = "0x4000348")]
	[FieldOffset(Offset = "0x38")]
	public SpriteRenderer[] Lights;

	// Token: 0x04000349 RID: 841
	[Token(Token = "0x4000349")]
	[FieldOffset(Offset = "0x3C")]
	public Sprite LightOn;

	// Token: 0x0400034A RID: 842
	[Token(Token = "0x400034A")]
	[FieldOffset(Offset = "0x40")]
	public Sprite LightOff;

	// Token: 0x0400034B RID: 843
	[Token(Token = "0x400034B")]
	[FieldOffset(Offset = "0x44")]
	public Collider2D Handle;

	// Token: 0x0400034C RID: 844
	[Token(Token = "0x400034C")]
	[FieldOffset(Offset = "0x48")]
	public SpriteRenderer Bars;

	// Token: 0x0400034D RID: 845
	[Token(Token = "0x400034D")]
	[FieldOffset(Offset = "0x4C")]
	private FloatRange HandleRange;

	// Token: 0x0400034E RID: 846
	[Token(Token = "0x400034E")]
	[FieldOffset(Offset = "0x50")]
	private bool finished;

	// Token: 0x0400034F RID: 847
	[Token(Token = "0x400034F")]
	[FieldOffset(Offset = "0x54")]
	private Controller controller;

	// Token: 0x04000350 RID: 848
	[Token(Token = "0x4000350")]
	[FieldOffset(Offset = "0x58")]
	public AudioClip correctSound;

	// Token: 0x04000351 RID: 849
	[Token(Token = "0x4000351")]
	[FieldOffset(Offset = "0x5C")]
	public AudioClip incorrectSound;

	// Token: 0x0200008A RID: 138
	[Token(Token = "0x200008A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <FinishUp>d__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000358 RID: 856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000358")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <FinishUp>d__16(int <>1__state)
		{
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000359")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00002A00 File Offset: 0x00000C00
		[Token(Token = "0x600035A")]
		[Address(RVA = "0x788010", Offset = "0x787410", VA = "0x10788010", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600035B RID: 859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007C")]
		private object Current
		{
			[Token(Token = "0x600035B")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600035C")]
		[Address(RVA = "0x788530", Offset = "0x787930", VA = "0x10788530", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600035D RID: 861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007D")]
		private object Current
		{
			[Token(Token = "0x600035D")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000352 RID: 850
		[Token(Token = "0x4000352")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000353 RID: 851
		[Token(Token = "0x4000353")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000354 RID: 852
		[Token(Token = "0x4000354")]
		[FieldOffset(Offset = "0x10")]
		public ElecLeverGame <>4__this;
	}
}
