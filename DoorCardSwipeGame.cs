using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020000A9 RID: 169
[Token(Token = "0x20000A9")]
public class DoorCardSwipeGame : Minigame, IDoorMinigame
{
	// Token: 0x06000410 RID: 1040 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000410")]
	[Address(RVA = "0x5CB080", Offset = "0x5CA480", VA = "0x105CB080", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x06000411 RID: 1041 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000411")]
	[Address(RVA = "0x5CB1C0", Offset = "0x5CA5C0", VA = "0x105CB1C0")]
	public void Update()
	{
	}

	// Token: 0x06000412 RID: 1042 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000412")]
	[Address(RVA = "0x5CB170", Offset = "0x5CA570", VA = "0x105CB170")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE5FA0", Offset = "0xE53A0")]
	private IEnumerator PutCardBack()
	{
		return null;
	}

	// Token: 0x06000413 RID: 1043 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000413")]
	[Address(RVA = "0x5CB120", Offset = "0x5CA520", VA = "0x105CB120")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE60C0", Offset = "0xE54C0")]
	private IEnumerator InsertCard()
	{
		return null;
	}

	// Token: 0x06000414 RID: 1044 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000414")]
	[Address(RVA = "0x4992F0", Offset = "0x4986F0", VA = "0x104992F0", Slot = "8")]
	public void SetDoor(PlainDoor door)
	{
	}

	// Token: 0x06000415 RID: 1045 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000415")]
	[Address(RVA = "0x5CC050", Offset = "0x5CB450", VA = "0x105CC050")]
	public DoorCardSwipeGame()
	{
	}

	// Token: 0x04000468 RID: 1128
	[Token(Token = "0x4000468")]
	[FieldOffset(Offset = "0x30")]
	private Color gray;

	// Token: 0x04000469 RID: 1129
	[Token(Token = "0x4000469")]
	[FieldOffset(Offset = "0x40")]
	private Color green;

	// Token: 0x0400046A RID: 1130
	[Token(Token = "0x400046A")]
	[FieldOffset(Offset = "0x50")]
	private DoorCardSwipeGame.TaskStages State;

	// Token: 0x0400046B RID: 1131
	[Token(Token = "0x400046B")]
	[FieldOffset(Offset = "0x54")]
	private Controller myController;

	// Token: 0x0400046C RID: 1132
	[Token(Token = "0x400046C")]
	[FieldOffset(Offset = "0x58")]
	private FloatRange YRange;

	// Token: 0x0400046D RID: 1133
	[Token(Token = "0x400046D")]
	[FieldOffset(Offset = "0x5C")]
	public float minAcceptedTime;

	// Token: 0x0400046E RID: 1134
	[Token(Token = "0x400046E")]
	[FieldOffset(Offset = "0x60")]
	public Collider2D col;

	// Token: 0x0400046F RID: 1135
	[Token(Token = "0x400046F")]
	[FieldOffset(Offset = "0x64")]
	public SpriteRenderer confirmSymbol;

	// Token: 0x04000470 RID: 1136
	[Token(Token = "0x4000470")]
	[FieldOffset(Offset = "0x68")]
	public Sprite AcceptSymbol;

	// Token: 0x04000471 RID: 1137
	[Token(Token = "0x4000471")]
	[FieldOffset(Offset = "0x6C")]
	public Sprite RejectSymbol;

	// Token: 0x04000472 RID: 1138
	[Token(Token = "0x4000472")]
	[FieldOffset(Offset = "0x70")]
	public TextMeshPro StatusText;

	// Token: 0x04000473 RID: 1139
	[Token(Token = "0x4000473")]
	[FieldOffset(Offset = "0x74")]
	public AudioClip AcceptSound;

	// Token: 0x04000474 RID: 1140
	[Token(Token = "0x4000474")]
	[FieldOffset(Offset = "0x78")]
	public AudioClip DenySound;

	// Token: 0x04000475 RID: 1141
	[Token(Token = "0x4000475")]
	[FieldOffset(Offset = "0x7C")]
	public AudioClip[] CardMove;

	// Token: 0x04000476 RID: 1142
	[Token(Token = "0x4000476")]
	[FieldOffset(Offset = "0x80")]
	public AudioClip WalletOut;

	// Token: 0x04000477 RID: 1143
	[Token(Token = "0x4000477")]
	[FieldOffset(Offset = "0x84")]
	public float dragTime;

	// Token: 0x04000478 RID: 1144
	[Token(Token = "0x4000478")]
	[FieldOffset(Offset = "0x88")]
	private bool moving;

	// Token: 0x04000479 RID: 1145
	[Token(Token = "0x4000479")]
	[FieldOffset(Offset = "0x8C")]
	private Vector2 prevStickInput;

	// Token: 0x0400047A RID: 1146
	[Token(Token = "0x400047A")]
	[FieldOffset(Offset = "0x94")]
	private bool hadPrev;

	// Token: 0x0400047B RID: 1147
	[Token(Token = "0x400047B")]
	[FieldOffset(Offset = "0x98")]
	private PlainDoor MyDoor;

	// Token: 0x020000AA RID: 170
	[Token(Token = "0x20000AA")]
	private enum TaskStages
	{
		// Token: 0x0400047D RID: 1149
		[Token(Token = "0x400047D")]
		Before,
		// Token: 0x0400047E RID: 1150
		[Token(Token = "0x400047E")]
		Animating,
		// Token: 0x0400047F RID: 1151
		[Token(Token = "0x400047F")]
		Inserted,
		// Token: 0x04000480 RID: 1152
		[Token(Token = "0x4000480")]
		After
	}

	// Token: 0x020000AB RID: 171
	[Token(Token = "0x20000AB")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <PutCardBack>d__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000416 RID: 1046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000416")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <PutCardBack>d__22(int <>1__state)
		{
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000417")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00002C70 File Offset: 0x00000E70
		[Token(Token = "0x6000418")]
		[Address(RVA = "0x7897A0", Offset = "0x788BA0", VA = "0x107897A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000419 RID: 1049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000098")]
		private object Current
		{
			[Token(Token = "0x6000419")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600041A")]
		[Address(RVA = "0x789AD0", Offset = "0x788ED0", VA = "0x10789AD0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600041B RID: 1051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000099")]
		private object Current
		{
			[Token(Token = "0x600041B")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000481 RID: 1153
		[Token(Token = "0x4000481")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000482 RID: 1154
		[Token(Token = "0x4000482")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000483 RID: 1155
		[Token(Token = "0x4000483")]
		[FieldOffset(Offset = "0x10")]
		public DoorCardSwipeGame <>4__this;
	}

	// Token: 0x020000AC RID: 172
	[Token(Token = "0x20000AC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <InsertCard>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600041C RID: 1052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600041C")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <InsertCard>d__23(int <>1__state)
		{
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600041D")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00002C88 File Offset: 0x00000E88
		[Token(Token = "0x600041E")]
		[Address(RVA = "0x788850", Offset = "0x787C50", VA = "0x10788850", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600041F RID: 1055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700009A")]
		private object Current
		{
			[Token(Token = "0x600041F")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000420")]
		[Address(RVA = "0x788B90", Offset = "0x787F90", VA = "0x10788B90", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000421 RID: 1057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700009B")]
		private object Current
		{
			[Token(Token = "0x6000421")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000484 RID: 1156
		[Token(Token = "0x4000484")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000485 RID: 1157
		[Token(Token = "0x4000485")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000486 RID: 1158
		[Token(Token = "0x4000486")]
		[FieldOffset(Offset = "0x10")]
		public DoorCardSwipeGame <>4__this;
	}
}
