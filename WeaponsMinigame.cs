using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x0200052A RID: 1322
[Token(Token = "0x200052A")]
public class WeaponsMinigame : Minigame
{
	// Token: 0x06001C01 RID: 7169 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C01")]
	[Address(RVA = "0x7B7280", Offset = "0x7B6680", VA = "0x107B7280", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x06001C02 RID: 7170 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C02")]
	[Address(RVA = "0x7B7890", Offset = "0x7B6C90", VA = "0x107B7890", Slot = "6")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE1500", Offset = "0xE0900")]
	protected override IEnumerator CoAnimateOpen()
	{
		return null;
	}

	// Token: 0x06001C03 RID: 7171 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C03")]
	[Address(RVA = "0x7B78E0", Offset = "0x7B6CE0", VA = "0x107B78E0", Slot = "7")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE15A0", Offset = "0xE09A0")]
	protected override IEnumerator CoDestroySelf()
	{
		return null;
	}

	// Token: 0x06001C04 RID: 7172 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C04")]
	[Address(RVA = "0x7B7930", Offset = "0x7B6D30", VA = "0x107B7930")]
	public void FixedUpdate()
	{
	}

	// Token: 0x06001C05 RID: 7173 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C05")]
	[Address(RVA = "0x7B73C0", Offset = "0x7B67C0", VA = "0x107B73C0")]
	public void BreakApart(Asteroid ast)
	{
	}

	// Token: 0x06001C06 RID: 7174 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C06")]
	[Address(RVA = "0x7B8450", Offset = "0x7B7850", VA = "0x107B8450")]
	public WeaponsMinigame()
	{
	}

	// Token: 0x04001FB8 RID: 8120
	[Token(Token = "0x4001FB8")]
	[FieldOffset(Offset = "0x30")]
	public FloatRange XSpan;

	// Token: 0x04001FB9 RID: 8121
	[Token(Token = "0x4001FB9")]
	[FieldOffset(Offset = "0x34")]
	public FloatRange YSpan;

	// Token: 0x04001FBA RID: 8122
	[Token(Token = "0x4001FBA")]
	[FieldOffset(Offset = "0x38")]
	public FloatRange TimeToSpawn;

	// Token: 0x04001FBB RID: 8123
	[Token(Token = "0x4001FBB")]
	[FieldOffset(Offset = "0x3C")]
	public ObjectPoolBehavior asteroidPool;

	// Token: 0x04001FBC RID: 8124
	[Token(Token = "0x4001FBC")]
	[FieldOffset(Offset = "0x40")]
	public TextMeshPro ScoreText;

	// Token: 0x04001FBD RID: 8125
	[Token(Token = "0x4001FBD")]
	[FieldOffset(Offset = "0x44")]
	public SpriteRenderer TargetReticle;

	// Token: 0x04001FBE RID: 8126
	[Token(Token = "0x4001FBE")]
	[FieldOffset(Offset = "0x48")]
	public LineRenderer TargetLines;

	// Token: 0x04001FBF RID: 8127
	[Token(Token = "0x4001FBF")]
	[FieldOffset(Offset = "0x4C")]
	private Vector3 TargetCenter;

	// Token: 0x04001FC0 RID: 8128
	[Token(Token = "0x4001FC0")]
	[FieldOffset(Offset = "0x58")]
	public Collider2D BackgroundCol;

	// Token: 0x04001FC1 RID: 8129
	[Token(Token = "0x4001FC1")]
	[FieldOffset(Offset = "0x5C")]
	public SpriteRenderer Background;

	// Token: 0x04001FC2 RID: 8130
	[Token(Token = "0x4001FC2")]
	[FieldOffset(Offset = "0x60")]
	public Controller myController;

	// Token: 0x04001FC3 RID: 8131
	[Token(Token = "0x4001FC3")]
	[FieldOffset(Offset = "0x64")]
	private float Timer;

	// Token: 0x04001FC4 RID: 8132
	[Token(Token = "0x4001FC4")]
	[FieldOffset(Offset = "0x68")]
	public AudioClip ShootSound;

	// Token: 0x04001FC5 RID: 8133
	[Token(Token = "0x4001FC5")]
	[FieldOffset(Offset = "0x6C")]
	public AudioClip[] ExplodeSounds;

	// Token: 0x0200052B RID: 1323
	[Token(Token = "0x200052B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoAnimateOpen>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001C07 RID: 7175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C07")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoAnimateOpen>d__15(int <>1__state)
		{
		}

		// Token: 0x06001C08 RID: 7176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C08")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001C09 RID: 7177 RVA: 0x00008CB8 File Offset: 0x00006EB8
		[Token(Token = "0x6001C09")]
		[Address(RVA = "0x12FD2E0", Offset = "0x12FC6E0", VA = "0x112FD2E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06001C0A RID: 7178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700040B")]
		private object Current
		{
			[Token(Token = "0x6001C0A")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C0B RID: 7179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C0B")]
		[Address(RVA = "0x12FD4E0", Offset = "0x12FC8E0", VA = "0x112FD4E0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06001C0C RID: 7180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700040C")]
		private object Current
		{
			[Token(Token = "0x6001C0C")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04001FC6 RID: 8134
		[Token(Token = "0x4001FC6")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04001FC7 RID: 8135
		[Token(Token = "0x4001FC7")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04001FC8 RID: 8136
		[Token(Token = "0x4001FC8")]
		[FieldOffset(Offset = "0x10")]
		public WeaponsMinigame <>4__this;

		// Token: 0x04001FC9 RID: 8137
		[Token(Token = "0x4001FC9")]
		[FieldOffset(Offset = "0x14")]
		private float <timer>5__2;
	}

	// Token: 0x0200052C RID: 1324
	[Token(Token = "0x200052C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoDestroySelf>d__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001C0D RID: 7181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C0D")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoDestroySelf>d__16(int <>1__state)
		{
		}

		// Token: 0x06001C0E RID: 7182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C0E")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001C0F RID: 7183 RVA: 0x00008CD0 File Offset: 0x00006ED0
		[Token(Token = "0x6001C0F")]
		[Address(RVA = "0x12FDED0", Offset = "0x12FD2D0", VA = "0x112FDED0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06001C10 RID: 7184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700040D")]
		private object Current
		{
			[Token(Token = "0x6001C10")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C11 RID: 7185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C11")]
		[Address(RVA = "0x12FE0E0", Offset = "0x12FD4E0", VA = "0x112FE0E0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06001C12 RID: 7186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700040E")]
		private object Current
		{
			[Token(Token = "0x6001C12")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04001FCA RID: 8138
		[Token(Token = "0x4001FCA")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04001FCB RID: 8139
		[Token(Token = "0x4001FCB")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04001FCC RID: 8140
		[Token(Token = "0x4001FCC")]
		[FieldOffset(Offset = "0x10")]
		public WeaponsMinigame <>4__this;

		// Token: 0x04001FCD RID: 8141
		[Token(Token = "0x4001FCD")]
		[FieldOffset(Offset = "0x14")]
		private float <timer>5__2;
	}

	// Token: 0x0200052D RID: 1325
	[Token(Token = "0x200052D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass17_0
	{
		// Token: 0x06001C13 RID: 7187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C13")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass17_0()
		{
		}

		// Token: 0x06001C14 RID: 7188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C14")]
		[Address(RVA = "0x1302320", Offset = "0x1301720", VA = "0x11302320")]
		internal void <FixedUpdate>b__0()
		{
		}

		// Token: 0x04001FCE RID: 8142
		[Token(Token = "0x4001FCE")]
		[FieldOffset(Offset = "0x8")]
		public WeaponsMinigame <>4__this;

		// Token: 0x04001FCF RID: 8143
		[Token(Token = "0x4001FCF")]
		[FieldOffset(Offset = "0xC")]
		public Asteroid ast;
	}
}
