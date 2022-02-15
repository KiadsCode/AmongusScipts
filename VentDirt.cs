using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200051F RID: 1311
[Token(Token = "0x200051F")]
public class VentDirt : PoolableBehavior
{
	// Token: 0x06001BD0 RID: 7120 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BD0")]
	[Address(RVA = "0x7AB220", Offset = "0x7AA620", VA = "0x107AB220", Slot = "4")]
	public override void Reset()
	{
	}

	// Token: 0x06001BD1 RID: 7121 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BD1")]
	[Address(RVA = "0x7AB1D0", Offset = "0x7AA5D0", VA = "0x107AB1D0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE13C0", Offset = "0xE07C0")]
	public IEnumerator CoDisappear()
	{
		return null;
	}

	// Token: 0x06001BD2 RID: 7122 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BD2")]
	[Address(RVA = "0x3AC2A0", Offset = "0x3AB6A0", VA = "0x103AC2A0")]
	public VentDirt()
	{
	}

	// Token: 0x04001F90 RID: 8080
	[Token(Token = "0x4001F90")]
	[FieldOffset(Offset = "0x14")]
	public Sprite[] DirtImages;

	// Token: 0x04001F91 RID: 8081
	[Token(Token = "0x4001F91")]
	[FieldOffset(Offset = "0x18")]
	public ParticleSystem CleanedEffect;

	// Token: 0x04001F92 RID: 8082
	[Token(Token = "0x4001F92")]
	[FieldOffset(Offset = "0x1C")]
	private int imgIdx;

	// Token: 0x02000520 RID: 1312
	[Token(Token = "0x2000520")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass4_0
	{
		// Token: 0x06001BD3 RID: 7123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BD3")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass4_0()
		{
		}

		// Token: 0x06001BD4 RID: 7124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BD4")]
		[Address(RVA = "0x1302800", Offset = "0x1301C00", VA = "0x11302800")]
		internal void <CoDisappear>b__0(float t)
		{
		}

		// Token: 0x04001F93 RID: 8083
		[Token(Token = "0x4001F93")]
		[FieldOffset(Offset = "0x8")]
		public SpriteRenderer rend;
	}

	// Token: 0x02000521 RID: 1313
	[Token(Token = "0x2000521")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoDisappear>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001BD5 RID: 7125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BD5")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoDisappear>d__4(int <>1__state)
		{
		}

		// Token: 0x06001BD6 RID: 7126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BD6")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001BD7 RID: 7127 RVA: 0x00008C28 File Offset: 0x00006E28
		[Token(Token = "0x6001BD7")]
		[Address(RVA = "0x12FE110", Offset = "0x12FD510", VA = "0x112FE110", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06001BD8 RID: 7128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000405")]
		private object Current
		{
			[Token(Token = "0x6001BD8")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001BD9 RID: 7129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BD9")]
		[Address(RVA = "0x12FE390", Offset = "0x12FD790", VA = "0x112FE390", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06001BDA RID: 7130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000406")]
		private object Current
		{
			[Token(Token = "0x6001BDA")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04001F94 RID: 8084
		[Token(Token = "0x4001F94")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04001F95 RID: 8085
		[Token(Token = "0x4001F95")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04001F96 RID: 8086
		[Token(Token = "0x4001F96")]
		[FieldOffset(Offset = "0x10")]
		public VentDirt <>4__this;

		// Token: 0x04001F97 RID: 8087
		[Token(Token = "0x4001F97")]
		[FieldOffset(Offset = "0x14")]
		private VentDirt.<>c__DisplayClass4_0 <>8__1;
	}
}
