using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000353 RID: 851
[Token(Token = "0x2000353")]
public class WeatherControl : MonoBehaviour
{
	// Token: 0x0600128F RID: 4751 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600128F")]
	[Address(RVA = "0x7BA010", Offset = "0x7B9410", VA = "0x107BA010")]
	internal void SetInactive()
	{
	}

	// Token: 0x06001290 RID: 4752 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001290")]
	[Address(RVA = "0x7B9F50", Offset = "0x7B9350", VA = "0x107B9F50")]
	public void SetActive()
	{
	}

	// Token: 0x06001291 RID: 4753 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001291")]
	[Address(RVA = "0x7B9F00", Offset = "0x7B9300", VA = "0x107B9F00")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE7CF0", Offset = "0xE70F0")]
	private IEnumerator Run()
	{
		return null;
	}

	// Token: 0x06001292 RID: 4754 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001292")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public WeatherControl()
	{
	}

	// Token: 0x040012D3 RID: 4819
	[Token(Token = "0x40012D3")]
	[FieldOffset(Offset = "0xC")]
	public Sprite backgroundLight;

	// Token: 0x040012D4 RID: 4820
	[Token(Token = "0x40012D4")]
	[FieldOffset(Offset = "0x10")]
	public Sprite backgroundDark;

	// Token: 0x040012D5 RID: 4821
	[Token(Token = "0x40012D5")]
	[FieldOffset(Offset = "0x14")]
	public Sprite lightOff;

	// Token: 0x040012D6 RID: 4822
	[Token(Token = "0x40012D6")]
	[FieldOffset(Offset = "0x18")]
	public Sprite lightOn;

	// Token: 0x040012D7 RID: 4823
	[Token(Token = "0x40012D7")]
	[FieldOffset(Offset = "0x1C")]
	public SpriteRenderer Background;

	// Token: 0x040012D8 RID: 4824
	[Token(Token = "0x40012D8")]
	[FieldOffset(Offset = "0x20")]
	public SpriteRenderer Switch;

	// Token: 0x040012D9 RID: 4825
	[Token(Token = "0x40012D9")]
	[FieldOffset(Offset = "0x24")]
	public SpriteRenderer Light;

	// Token: 0x040012DA RID: 4826
	[Token(Token = "0x40012DA")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshPro Label;

	// Token: 0x02000354 RID: 852
	[Token(Token = "0x2000354")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <Run>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001293 RID: 4755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001293")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <Run>d__10(int <>1__state)
		{
		}

		// Token: 0x06001294 RID: 4756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001294")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001295 RID: 4757 RVA: 0x00006510 File Offset: 0x00004710
		[Token(Token = "0x6001295")]
		[Address(RVA = "0x1301710", Offset = "0x1300B10", VA = "0x11301710", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06001296 RID: 4758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002C4")]
		private object Current
		{
			[Token(Token = "0x6001296")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001297 RID: 4759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001297")]
		[Address(RVA = "0x1301820", Offset = "0x1300C20", VA = "0x11301820", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06001298 RID: 4760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002C5")]
		private object Current
		{
			[Token(Token = "0x6001298")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040012DB RID: 4827
		[Token(Token = "0x40012DB")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040012DC RID: 4828
		[Token(Token = "0x40012DC")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040012DD RID: 4829
		[Token(Token = "0x40012DD")]
		[FieldOffset(Offset = "0x10")]
		public WeatherControl <>4__this;
	}
}
