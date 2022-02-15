using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000A4 RID: 164
[Token(Token = "0x20000A4")]
public class ToiletMinigame : Minigame
{
	// Token: 0x060003F9 RID: 1017 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003F9")]
	[Address(RVA = "0x4AED90", Offset = "0x4AE190", VA = "0x104AED90", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x060003FA RID: 1018 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003FA")]
	[Address(RVA = "0x4AEEF0", Offset = "0x4AE2F0", VA = "0x104AEEF0")]
	public void Update()
	{
	}

	// Token: 0x060003FB RID: 1019 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003FB")]
	[Address(RVA = "0x4AEEA0", Offset = "0x4AE2A0", VA = "0x104AEEA0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE5F50", Offset = "0xE5350")]
	private IEnumerator Finish()
	{
		return null;
	}

	// Token: 0x060003FC RID: 1020 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003FC")]
	[Address(RVA = "0x4AEE20", Offset = "0x4AE220", VA = "0x104AEE20", Slot = "5")]
	public override void Close()
	{
	}

	// Token: 0x060003FD RID: 1021 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003FD")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE9E0", VA = "0x104AF5E0")]
	public ToiletMinigame()
	{
	}

	// Token: 0x04000428 RID: 1064
	[Token(Token = "0x4000428")]
	[FieldOffset(Offset = "0x30")]
	public SpriteRenderer Needle;

	// Token: 0x04000429 RID: 1065
	[Token(Token = "0x4000429")]
	[FieldOffset(Offset = "0x34")]
	public SpriteRenderer Pipes;

	// Token: 0x0400042A RID: 1066
	[Token(Token = "0x400042A")]
	public const float StickDown = -0.75f;

	// Token: 0x0400042B RID: 1067
	[Token(Token = "0x400042B")]
	[FieldOffset(Offset = "0x38")]
	public FloatRange StickRange;

	// Token: 0x0400042C RID: 1068
	[Token(Token = "0x400042C")]
	[FieldOffset(Offset = "0x3C")]
	public Collider2D Stick;

	// Token: 0x0400042D RID: 1069
	[Token(Token = "0x400042D")]
	[FieldOffset(Offset = "0x40")]
	public SpriteRenderer Plunger;

	// Token: 0x0400042E RID: 1070
	[Token(Token = "0x400042E")]
	[FieldOffset(Offset = "0x44")]
	public Sprite PlungerUp;

	// Token: 0x0400042F RID: 1071
	[Token(Token = "0x400042F")]
	[FieldOffset(Offset = "0x48")]
	public Sprite PlungerDown;

	// Token: 0x04000430 RID: 1072
	[Token(Token = "0x4000430")]
	[FieldOffset(Offset = "0x4C")]
	private float pressure;

	// Token: 0x04000431 RID: 1073
	[Token(Token = "0x4000431")]
	[FieldOffset(Offset = "0x50")]
	public Controller controller;

	// Token: 0x04000432 RID: 1074
	[Token(Token = "0x4000432")]
	[FieldOffset(Offset = "0x54")]
	public float lastY;

	// Token: 0x04000433 RID: 1075
	[Token(Token = "0x4000433")]
	[FieldOffset(Offset = "0x58")]
	public float plungeScale;

	// Token: 0x04000434 RID: 1076
	[Token(Token = "0x4000434")]
	[FieldOffset(Offset = "0x5C")]
	public AudioClip flushSound;

	// Token: 0x04000435 RID: 1077
	[Token(Token = "0x4000435")]
	[FieldOffset(Offset = "0x60")]
	public AudioClip[] plungeSounds;

	// Token: 0x04000436 RID: 1078
	[Token(Token = "0x4000436")]
	[FieldOffset(Offset = "0x64")]
	private AudioSource plungerSource;

	// Token: 0x04000437 RID: 1079
	[Token(Token = "0x4000437")]
	[FieldOffset(Offset = "0x68")]
	private float controllerStickPos;

	// Token: 0x04000438 RID: 1080
	[Token(Token = "0x4000438")]
	private const float controllerPlungeSpeed = 30f;

	// Token: 0x020000A5 RID: 165
	[Token(Token = "0x20000A5")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <Finish>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060003FE RID: 1022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <Finish>d__19(int <>1__state)
		{
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00002C58 File Offset: 0x00000E58
		[Token(Token = "0x6000400")]
		[Address(RVA = "0x36C6A0", Offset = "0x36BAA0", VA = "0x1036C6A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000401 RID: 1025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000096")]
		private object Current
		{
			[Token(Token = "0x6000401")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000402")]
		[Address(RVA = "0x36C960", Offset = "0x36BD60", VA = "0x1036C960", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000403 RID: 1027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000097")]
		private object Current
		{
			[Token(Token = "0x6000403")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000439 RID: 1081
		[Token(Token = "0x4000439")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x0400043A RID: 1082
		[Token(Token = "0x400043A")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x0400043B RID: 1083
		[Token(Token = "0x400043B")]
		[FieldOffset(Offset = "0x10")]
		public ToiletMinigame <>4__this;
	}
}
