using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200032F RID: 815
[Token(Token = "0x200032F")]
public class SnowManager : MonoBehaviour
{
	// Token: 0x060011D1 RID: 4561 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011D1")]
	[Address(RVA = "0x4A1790", Offset = "0x4A0B90", VA = "0x104A1790")]
	private void Start()
	{
	}

	// Token: 0x060011D2 RID: 4562 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011D2")]
	[Address(RVA = "0x4A16A0", Offset = "0x4A0AA0", VA = "0x104A16A0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE77A0", Offset = "0xE6BA0")]
	private IEnumerator Run()
	{
		return null;
	}

	// Token: 0x060011D3 RID: 4563 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011D3")]
	[Address(RVA = "0x4A16F0", Offset = "0x4A0AF0", VA = "0x104A16F0")]
	private void SetPartAlpha()
	{
	}

	// Token: 0x060011D4 RID: 4564 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011D4")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public SnowManager()
	{
	}

	// Token: 0x040011B7 RID: 4535
	[Token(Token = "0x40011B7")]
	[FieldOffset(Offset = "0xC")]
	public ParticleSystem particles;

	// Token: 0x040011B8 RID: 4536
	[Token(Token = "0x40011B8")]
	[FieldOffset(Offset = "0x10")]
	private ParticleSystemRenderer rend;

	// Token: 0x040011B9 RID: 4537
	[Token(Token = "0x40011B9")]
	[FieldOffset(Offset = "0x14")]
	private float timer;

	// Token: 0x02000330 RID: 816
	[Token(Token = "0x2000330")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <Run>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060011D5 RID: 4565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011D5")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <Run>d__4(int <>1__state)
		{
		}

		// Token: 0x060011D6 RID: 4566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011D6")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060011D7 RID: 4567 RVA: 0x000062E8 File Offset: 0x000044E8
		[Token(Token = "0x60011D7")]
		[Address(RVA = "0x36EE20", Offset = "0x36E220", VA = "0x1036EE20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x060011D8 RID: 4568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002AB")]
		private object Current
		{
			[Token(Token = "0x60011D8")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060011D9 RID: 4569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011D9")]
		[Address(RVA = "0x36F390", Offset = "0x36E790", VA = "0x1036F390", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x060011DA RID: 4570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002AC")]
		private object Current
		{
			[Token(Token = "0x60011DA")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040011BA RID: 4538
		[Token(Token = "0x40011BA")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040011BB RID: 4539
		[Token(Token = "0x40011BB")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040011BC RID: 4540
		[Token(Token = "0x40011BC")]
		[FieldOffset(Offset = "0x10")]
		public SnowManager <>4__this;

		// Token: 0x040011BD RID: 4541
		[Token(Token = "0x40011BD")]
		[FieldOffset(Offset = "0x14")]
		private ContactFilter2D <filter>5__2;

		// Token: 0x040011BE RID: 4542
		[Token(Token = "0x40011BE")]
		[FieldOffset(Offset = "0x30")]
		private Collider2D[] <buffer>5__3;

		// Token: 0x040011BF RID: 4543
		[Token(Token = "0x40011BF")]
		[FieldOffset(Offset = "0x34")]
		private WaitForSeconds <wait>5__4;
	}
}
