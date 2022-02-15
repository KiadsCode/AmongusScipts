using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000492 RID: 1170
[Token(Token = "0x2000492")]
public class EmergencyMinigame : Minigame
{
	// Token: 0x060018E9 RID: 6377 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018E9")]
	[Address(RVA = "0x477580", Offset = "0x476980", VA = "0x10477580")]
	private void OnDisable()
	{
	}

	// Token: 0x060018EA RID: 6378 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018EA")]
	[Address(RVA = "0x477210", Offset = "0x476610", VA = "0x10477210", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x060018EB RID: 6379 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018EB")]
	[Address(RVA = "0x4775F0", Offset = "0x4769F0", VA = "0x104775F0")]
	public void Update()
	{
	}

	// Token: 0x060018EC RID: 6380 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018EC")]
	[Address(RVA = "0x4772A0", Offset = "0x4766A0", VA = "0x104772A0")]
	public void CallMeeting()
	{
	}

	// Token: 0x060018ED RID: 6381 RVA: 0x00007CB0 File Offset: 0x00005EB0
	[Token(Token = "0x60018ED")]
	[Address(RVA = "0x477BB0", Offset = "0x476FB0", VA = "0x10477BB0")]
	private float easeOutElastic(float t)
	{
		return 0f;
	}

	// Token: 0x060018EE RID: 6382 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018EE")]
	[Address(RVA = "0x477530", Offset = "0x476930", VA = "0x10477530", Slot = "6")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE0650", Offset = "0xDFA50")]
	protected override IEnumerator CoAnimateOpen()
	{
		return null;
	}

	// Token: 0x060018EF RID: 6383 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018EF")]
	[Address(RVA = "0x477B90", Offset = "0x476F90", VA = "0x10477B90")]
	public EmergencyMinigame()
	{
	}

	// Token: 0x04001900 RID: 6400
	[Token(Token = "0x4001900")]
	[FieldOffset(Offset = "0x30")]
	public SpriteRenderer ClosedLid;

	// Token: 0x04001901 RID: 6401
	[Token(Token = "0x4001901")]
	[FieldOffset(Offset = "0x34")]
	public SpriteRenderer OpenLid;

	// Token: 0x04001902 RID: 6402
	[Token(Token = "0x4001902")]
	[FieldOffset(Offset = "0x38")]
	public Transform meetingButton;

	// Token: 0x04001903 RID: 6403
	[Token(Token = "0x4001903")]
	[FieldOffset(Offset = "0x3C")]
	public TextMeshPro StatusText;

	// Token: 0x04001904 RID: 6404
	[Token(Token = "0x4001904")]
	[FieldOffset(Offset = "0x40")]
	public TextMeshPro NumberText;

	// Token: 0x04001905 RID: 6405
	[Token(Token = "0x4001905")]
	[FieldOffset(Offset = "0x44")]
	public bool ButtonActive;

	// Token: 0x04001906 RID: 6406
	[Token(Token = "0x4001906")]
	[FieldOffset(Offset = "0x48")]
	public AudioClip ButtonSound;

	// Token: 0x04001907 RID: 6407
	[Token(Token = "0x4001907")]
	[FieldOffset(Offset = "0x4C")]
	private int state;

	// Token: 0x04001908 RID: 6408
	[Token(Token = "0x4001908")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xDD8F0", Offset = "0xDCCF0")]
	public UiElement BackButton;

	// Token: 0x04001909 RID: 6409
	[Token(Token = "0x4001909")]
	[FieldOffset(Offset = "0x54")]
	public UiElement DefaultButtonSelected;

	// Token: 0x0400190A RID: 6410
	[Token(Token = "0x400190A")]
	public const int MinEmergencyTime = 15;

	// Token: 0x02000493 RID: 1171
	[Token(Token = "0x2000493")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoAnimateOpen>d__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060018F0 RID: 6384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018F0")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoAnimateOpen>d__16(int <>1__state)
		{
		}

		// Token: 0x060018F1 RID: 6385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018F1")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060018F2 RID: 6386 RVA: 0x00007CC8 File Offset: 0x00005EC8
		[Token(Token = "0x60018F2")]
		[Address(RVA = "0x783AB0", Offset = "0x782EB0", VA = "0x10783AB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x060018F3 RID: 6387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000389")]
		private object Current
		{
			[Token(Token = "0x60018F3")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060018F4 RID: 6388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018F4")]
		[Address(RVA = "0x783D40", Offset = "0x783140", VA = "0x10783D40", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x060018F5 RID: 6389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700038A")]
		private object Current
		{
			[Token(Token = "0x60018F5")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400190B RID: 6411
		[Token(Token = "0x400190B")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x0400190C RID: 6412
		[Token(Token = "0x400190C")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x0400190D RID: 6413
		[Token(Token = "0x400190D")]
		[FieldOffset(Offset = "0x10")]
		public EmergencyMinigame <>4__this;

		// Token: 0x0400190E RID: 6414
		[Token(Token = "0x400190E")]
		[FieldOffset(Offset = "0x14")]
		private Vector3 <meetingPos>5__2;

		// Token: 0x0400190F RID: 6415
		[Token(Token = "0x400190F")]
		[FieldOffset(Offset = "0x20")]
		private float <timer>5__3;
	}
}
