using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200051B RID: 1307
[Token(Token = "0x200051B")]
public class VentCleaningMinigame : Minigame
{
	// Token: 0x17000402 RID: 1026
	// (get) Token: 0x06001BB9 RID: 7097 RVA: 0x00008BF8 File Offset: 0x00006DF8
	[Token(Token = "0x17000402")]
	private int VentId
	{
		[Token(Token = "0x6001BB9")]
		[Address(RVA = "0x7AB1C0", Offset = "0x7AA5C0", VA = "0x107AB1C0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x06001BBA RID: 7098 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BBA")]
	[Address(RVA = "0x7AA0C0", Offset = "0x7A94C0", VA = "0x107AA0C0", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x06001BBB RID: 7099 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BBB")]
	[Address(RVA = "0x7AA7C0", Offset = "0x7A9BC0", VA = "0x107AA7C0", Slot = "5")]
	public override void Close()
	{
	}

	// Token: 0x06001BBC RID: 7100 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BBC")]
	[Address(RVA = "0x7AADA0", Offset = "0x7AA1A0", VA = "0x107AADA0")]
	public void OpenVent()
	{
	}

	// Token: 0x06001BBD RID: 7101 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BBD")]
	[Address(RVA = "0x7AA840", Offset = "0x7A9C40", VA = "0x107AA840")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06001BBE RID: 7102 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BBE")]
	[Address(RVA = "0x7AAA30", Offset = "0x7A9E30", VA = "0x107AAA30")]
	private void HandleJoystick()
	{
	}

	// Token: 0x06001BBF RID: 7103 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BBF")]
	[Address(RVA = "0x7AA7F0", Offset = "0x7A9BF0", VA = "0x107AA7F0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE1320", Offset = "0xE0720")]
	private IEnumerator CoOpenVent()
	{
		return null;
	}

	// Token: 0x06001BC0 RID: 7104 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BC0")]
	[Address(RVA = "0x7AA4B0", Offset = "0x7A98B0", VA = "0x107AA4B0")]
	private void CleanUp(VentDirt ventDirt)
	{
	}

	// Token: 0x06001BC1 RID: 7105 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BC1")]
	[Address(RVA = "0x7AAE10", Offset = "0x7AA210", VA = "0x107AAE10")]
	private void SpawnDirt()
	{
	}

	// Token: 0x06001BC2 RID: 7106 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BC2")]
	[Address(RVA = "0x7AB130", Offset = "0x7AA530", VA = "0x107AB130")]
	public VentCleaningMinigame()
	{
	}

	// Token: 0x06001BC3 RID: 7107 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BC3")]
	[Address(RVA = "0x7AAFF0", Offset = "0x7AA3F0", VA = "0x107AAFF0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private void <CoOpenVent>b__24_0(float t)
	{
	}

	// Token: 0x04001F77 RID: 8055
	[Token(Token = "0x4001F77")]
	[FieldOffset(Offset = "0x30")]
	public FloatRange XSpan;

	// Token: 0x04001F78 RID: 8056
	[Token(Token = "0x4001F78")]
	[FieldOffset(Offset = "0x34")]
	public FloatRange YSpan;

	// Token: 0x04001F79 RID: 8057
	[Token(Token = "0x4001F79")]
	[FieldOffset(Offset = "0x38")]
	public ObjectPoolBehavior dirtPool;

	// Token: 0x04001F7A RID: 8058
	[Token(Token = "0x4001F7A")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject ventLidClosed;

	// Token: 0x04001F7B RID: 8059
	[Token(Token = "0x4001F7B")]
	[FieldOffset(Offset = "0x40")]
	public GameObject ventLidOpened;

	// Token: 0x04001F7C RID: 8060
	[Token(Token = "0x4001F7C")]
	[FieldOffset(Offset = "0x44")]
	public UiElement backButton;

	// Token: 0x04001F7D RID: 8061
	[Token(Token = "0x4001F7D")]
	[FieldOffset(Offset = "0x48")]
	public AudioClip VentOpenSound;

	// Token: 0x04001F7E RID: 8062
	[Token(Token = "0x4001F7E")]
	[FieldOffset(Offset = "0x4C")]
	public AudioClip ImpostorDiscoveredSound;

	// Token: 0x04001F7F RID: 8063
	[Token(Token = "0x4001F7F")]
	[FieldOffset(Offset = "0x50")]
	public AudioClip CleanedSound;

	// Token: 0x04001F80 RID: 8064
	[Token(Token = "0x4001F80")]
	[FieldOffset(Offset = "0x54")]
	public SpriteRenderer[] SpiderWebs;

	// Token: 0x04001F81 RID: 8065
	[Token(Token = "0x4001F81")]
	[FieldOffset(Offset = "0x58")]
	public float cleaningDistanceThreshold;

	// Token: 0x04001F82 RID: 8066
	[Token(Token = "0x4001F82")]
	[FieldOffset(Offset = "0x5C")]
	public Transform selectorObject;

	// Token: 0x04001F83 RID: 8067
	[Token(Token = "0x4001F83")]
	[FieldOffset(Offset = "0x60")]
	public SpriteRenderer selectorHand;

	// Token: 0x04001F84 RID: 8068
	[Token(Token = "0x4001F84")]
	[FieldOffset(Offset = "0x64")]
	private int numberOfDirts;

	// Token: 0x04001F85 RID: 8069
	[Token(Token = "0x4001F85")]
	[FieldOffset(Offset = "0x68")]
	private int numberOfDirtsCleanedUp;

	// Token: 0x04001F86 RID: 8070
	[Token(Token = "0x4001F86")]
	[FieldOffset(Offset = "0x6C")]
	private bool ventOpen;

	// Token: 0x04001F87 RID: 8071
	[Token(Token = "0x4001F87")]
	[FieldOffset(Offset = "0x70")]
	private VentilationSystem ventSystem;

	// Token: 0x0200051C RID: 1308
	[Token(Token = "0x200051C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06001BC5 RID: 7109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BC5")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x06001BC6 RID: 7110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BC6")]
		[Address(RVA = "0x1301FA0", Offset = "0x13013A0", VA = "0x11301FA0")]
		internal void <Begin>b__19_0(SpriteRenderer s)
		{
		}

		// Token: 0x06001BC7 RID: 7111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BC7")]
		[Address(RVA = "0x1301FD0", Offset = "0x13013D0", VA = "0x11301FD0")]
		internal void <Begin>b__19_1(SpriteRenderer s)
		{
		}

		// Token: 0x04001F88 RID: 8072
		[Token(Token = "0x4001F88")]
		[FieldOffset(Offset = "0x0")]
		public static readonly VentCleaningMinigame.<>c <>9;

		// Token: 0x04001F89 RID: 8073
		[Token(Token = "0x4001F89")]
		[FieldOffset(Offset = "0x4")]
		public static Action<SpriteRenderer> <>9__19_0;

		// Token: 0x04001F8A RID: 8074
		[Token(Token = "0x4001F8A")]
		[FieldOffset(Offset = "0x8")]
		public static Action<SpriteRenderer> <>9__19_1;
	}

	// Token: 0x0200051D RID: 1309
	[Token(Token = "0x200051D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoOpenVent>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001BC8 RID: 7112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BC8")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoOpenVent>d__24(int <>1__state)
		{
		}

		// Token: 0x06001BC9 RID: 7113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BC9")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001BCA RID: 7114 RVA: 0x00008C10 File Offset: 0x00006E10
		[Token(Token = "0x6001BCA")]
		[Address(RVA = "0x12FEF00", Offset = "0x12FE300", VA = "0x112FEF00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06001BCB RID: 7115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000403")]
		private object Current
		{
			[Token(Token = "0x6001BCB")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001BCC RID: 7116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BCC")]
		[Address(RVA = "0x12FF060", Offset = "0x12FE460", VA = "0x112FF060", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06001BCD RID: 7117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000404")]
		private object Current
		{
			[Token(Token = "0x6001BCD")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04001F8B RID: 8075
		[Token(Token = "0x4001F8B")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04001F8C RID: 8076
		[Token(Token = "0x4001F8C")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04001F8D RID: 8077
		[Token(Token = "0x4001F8D")]
		[FieldOffset(Offset = "0x10")]
		public VentCleaningMinigame <>4__this;
	}

	// Token: 0x0200051E RID: 1310
	[Token(Token = "0x200051E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass26_0
	{
		// Token: 0x06001BCE RID: 7118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BCE")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass26_0()
		{
		}

		// Token: 0x06001BCF RID: 7119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BCF")]
		[Address(RVA = "0x1302580", Offset = "0x1301980", VA = "0x11302580")]
		internal void <SpawnDirt>b__0()
		{
		}

		// Token: 0x04001F8E RID: 8078
		[Token(Token = "0x4001F8E")]
		[FieldOffset(Offset = "0x8")]
		public VentCleaningMinigame <>4__this;

		// Token: 0x04001F8F RID: 8079
		[Token(Token = "0x4001F8F")]
		[FieldOffset(Offset = "0xC")]
		public VentDirt dirt;
	}
}
