using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x0200024B RID: 587
[Token(Token = "0x200024B")]
public class DiscussBehaviour : MonoBehaviour
{
	// Token: 0x06000D16 RID: 3350 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D16")]
	[Address(RVA = "0x5C9330", Offset = "0x5C8730", VA = "0x105C9330")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE2FA0", Offset = "0xE23A0")]
	public IEnumerator PlayAnimation()
	{
		return null;
	}

	// Token: 0x06000D17 RID: 3351 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D17")]
	[Address(RVA = "0x5C93F0", Offset = "0x5C87F0", VA = "0x105C93F0")]
	public void Update()
	{
	}

	// Token: 0x06000D18 RID: 3352 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D18")]
	[Address(RVA = "0x5C92E0", Offset = "0x5C86E0", VA = "0x105C92E0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE3000", Offset = "0xE2400")]
	private IEnumerator AnimateText()
	{
		return null;
	}

	// Token: 0x06000D19 RID: 3353 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D19")]
	[Address(RVA = "0x5C9380", Offset = "0x5C8780", VA = "0x105C9380")]
	private void UpdateText(ref Vector3 vec, float p)
	{
	}

	// Token: 0x06000D1A RID: 3354 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D1A")]
	[Address(RVA = "0x5C9560", Offset = "0x5C8960", VA = "0x105C9560")]
	public DiscussBehaviour()
	{
	}

	// Token: 0x04000CF1 RID: 3313
	[Token(Token = "0x4000CF1")]
	[FieldOffset(Offset = "0xC")]
	public SpriteRenderer LeftPlayer;

	// Token: 0x04000CF2 RID: 3314
	[Token(Token = "0x4000CF2")]
	[FieldOffset(Offset = "0x10")]
	public SpriteRenderer RightPlayer;

	// Token: 0x04000CF3 RID: 3315
	[Token(Token = "0x4000CF3")]
	[FieldOffset(Offset = "0x14")]
	public TextMeshPro Text;

	// Token: 0x04000CF4 RID: 3316
	[Token(Token = "0x4000CF4")]
	[FieldOffset(Offset = "0x18")]
	public FloatRange RotateRange;

	// Token: 0x04000CF5 RID: 3317
	[Token(Token = "0x4000CF5")]
	[FieldOffset(Offset = "0x1C")]
	public Vector2Range TextTarget;

	// Token: 0x04000CF6 RID: 3318
	[Token(Token = "0x4000CF6")]
	[FieldOffset(Offset = "0x2C")]
	public AnimationCurve TextEasing;

	// Token: 0x04000CF7 RID: 3319
	[Token(Token = "0x4000CF7")]
	[FieldOffset(Offset = "0x30")]
	public float Delay;

	// Token: 0x04000CF8 RID: 3320
	[Token(Token = "0x4000CF8")]
	[FieldOffset(Offset = "0x34")]
	public float TextDuration;

	// Token: 0x04000CF9 RID: 3321
	[Token(Token = "0x4000CF9")]
	[FieldOffset(Offset = "0x38")]
	public float HoldDuration;

	// Token: 0x04000CFA RID: 3322
	[Token(Token = "0x4000CFA")]
	[FieldOffset(Offset = "0x3C")]
	private Vector3 vec;

	// Token: 0x0200024C RID: 588
	[Token(Token = "0x200024C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <PlayAnimation>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000D1B RID: 3355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D1B")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <PlayAnimation>d__10(int <>1__state)
		{
		}

		// Token: 0x06000D1C RID: 3356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D1C")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000D1D RID: 3357 RVA: 0x00005250 File Offset: 0x00003450
		[Token(Token = "0x6000D1D")]
		[Address(RVA = "0x789290", Offset = "0x788690", VA = "0x10789290", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000D1E RID: 3358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001EF")]
		private object Current
		{
			[Token(Token = "0x6000D1E")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000D1F RID: 3359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D1F")]
		[Address(RVA = "0x789380", Offset = "0x788780", VA = "0x10789380", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000D20 RID: 3360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001F0")]
		private object Current
		{
			[Token(Token = "0x6000D20")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000CFB RID: 3323
		[Token(Token = "0x4000CFB")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000CFC RID: 3324
		[Token(Token = "0x4000CFC")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000CFD RID: 3325
		[Token(Token = "0x4000CFD")]
		[FieldOffset(Offset = "0x10")]
		public DiscussBehaviour <>4__this;
	}

	// Token: 0x0200024D RID: 589
	[Token(Token = "0x200024D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <AnimateText>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000D21 RID: 3361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D21")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <AnimateText>d__12(int <>1__state)
		{
		}

		// Token: 0x06000D22 RID: 3362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D22")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x00005268 File Offset: 0x00003468
		[Token(Token = "0x6000D23")]
		[Address(RVA = "0x781D60", Offset = "0x781160", VA = "0x10781D60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000D24 RID: 3364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001F1")]
		private object Current
		{
			[Token(Token = "0x6000D24")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000D25 RID: 3365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D25")]
		[Address(RVA = "0x781EA0", Offset = "0x7812A0", VA = "0x10781EA0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000D26 RID: 3366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001F2")]
		private object Current
		{
			[Token(Token = "0x6000D26")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000CFE RID: 3326
		[Token(Token = "0x4000CFE")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000CFF RID: 3327
		[Token(Token = "0x4000CFF")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000D00 RID: 3328
		[Token(Token = "0x4000D00")]
		[FieldOffset(Offset = "0x10")]
		public DiscussBehaviour <>4__this;

		// Token: 0x04000D01 RID: 3329
		[Token(Token = "0x4000D01")]
		[FieldOffset(Offset = "0x14")]
		private Vector3 <vec>5__2;

		// Token: 0x04000D02 RID: 3330
		[Token(Token = "0x4000D02")]
		[FieldOffset(Offset = "0x20")]
		private float <t>5__3;
	}
}
