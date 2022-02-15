using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000528 RID: 1320
[Token(Token = "0x2000528")]
public class Asteroid : PoolableBehavior
{
	// Token: 0x17000408 RID: 1032
	// (get) Token: 0x06001BF3 RID: 7155 RVA: 0x00008C88 File Offset: 0x00006E88
	// (set) Token: 0x06001BF4 RID: 7156 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000408")]
	public Vector3 TargetPosition
	{
		[Token(Token = "0x6001BF3")]
		[Address(RVA = "0x54D6B0", Offset = "0x54CAB0", VA = "0x1054D6B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6001BF4")]
		[Address(RVA = "0x54D6D0", Offset = "0x54CAD0", VA = "0x1054D6D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		internal set
		{
		}
	}

	// Token: 0x06001BF5 RID: 7157 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BF5")]
	[Address(RVA = "0x54D130", Offset = "0x54C530", VA = "0x1054D130")]
	public void FixedUpdate()
	{
	}

	// Token: 0x06001BF6 RID: 7158 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BF6")]
	[Address(RVA = "0x54D3B0", Offset = "0x54C7B0", VA = "0x1054D3B0", Slot = "4")]
	public override void Reset()
	{
	}

	// Token: 0x06001BF7 RID: 7159 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BF7")]
	[Address(RVA = "0x54D0E0", Offset = "0x54C4E0", VA = "0x1054D0E0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE1410", Offset = "0xE0810")]
	public IEnumerator CoBreakApart()
	{
		return null;
	}

	// Token: 0x06001BF8 RID: 7160 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BF8")]
	[Address(RVA = "0x54D620", Offset = "0x54CA20", VA = "0x1054D620")]
	public Asteroid()
	{
	}

	// Token: 0x06001BF9 RID: 7161 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BF9")]
	[Address(RVA = "0x54D550", Offset = "0x54C950", VA = "0x1054D550")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private void <CoBreakApart>b__12_0(float t)
	{
	}

	// Token: 0x06001BFA RID: 7162 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BFA")]
	[Address(RVA = "0x54D5B0", Offset = "0x54C9B0", VA = "0x1054D5B0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private void <CoBreakApart>b__12_1(float t)
	{
	}

	// Token: 0x04001FAD RID: 8109
	[Token(Token = "0x4001FAD")]
	[FieldOffset(Offset = "0x14")]
	public Sprite[] AsteroidImages;

	// Token: 0x04001FAE RID: 8110
	[Token(Token = "0x4001FAE")]
	[FieldOffset(Offset = "0x18")]
	public Sprite[] BrokenImages;

	// Token: 0x04001FAF RID: 8111
	[Token(Token = "0x4001FAF")]
	[FieldOffset(Offset = "0x1C")]
	private int imgIdx;

	// Token: 0x04001FB0 RID: 8112
	[Token(Token = "0x4001FB0")]
	[FieldOffset(Offset = "0x20")]
	public FloatRange MoveSpeed;

	// Token: 0x04001FB1 RID: 8113
	[Token(Token = "0x4001FB1")]
	[FieldOffset(Offset = "0x24")]
	public FloatRange RotateSpeed;

	// Token: 0x04001FB2 RID: 8114
	[Token(Token = "0x4001FB2")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private Vector3 <TargetPosition>k__BackingField;

	// Token: 0x04001FB3 RID: 8115
	[Token(Token = "0x4001FB3")]
	[FieldOffset(Offset = "0x34")]
	public SpriteRenderer Explosion;

	// Token: 0x02000529 RID: 1321
	[Token(Token = "0x2000529")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoBreakApart>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001BFB RID: 7163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BFB")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoBreakApart>d__12(int <>1__state)
		{
		}

		// Token: 0x06001BFC RID: 7164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BFC")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001BFD RID: 7165 RVA: 0x00008CA0 File Offset: 0x00006EA0
		[Token(Token = "0x6001BFD")]
		[Address(RVA = "0x3C2FD0", Offset = "0x3C23D0", VA = "0x103C2FD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06001BFE RID: 7166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000409")]
		private object Current
		{
			[Token(Token = "0x6001BFE")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001BFF RID: 7167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BFF")]
		[Address(RVA = "0x3C32E0", Offset = "0x3C26E0", VA = "0x103C32E0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06001C00 RID: 7168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700040A")]
		private object Current
		{
			[Token(Token = "0x6001C00")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04001FB4 RID: 8116
		[Token(Token = "0x4001FB4")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04001FB5 RID: 8117
		[Token(Token = "0x4001FB5")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04001FB6 RID: 8118
		[Token(Token = "0x4001FB6")]
		[FieldOffset(Offset = "0x10")]
		public Asteroid <>4__this;

		// Token: 0x04001FB7 RID: 8119
		[Token(Token = "0x4001FB7")]
		[FieldOffset(Offset = "0x14")]
		private SpriteRenderer <rend>5__2;
	}
}
