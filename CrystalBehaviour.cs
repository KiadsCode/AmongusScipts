using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000283 RID: 643
[Token(Token = "0x2000283")]
public class CrystalBehaviour : UiElement
{
	// Token: 0x06000E49 RID: 3657 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E49")]
	[Address(RVA = "0x5BA780", Offset = "0x5B9B80", VA = "0x105BA780")]
	private void Update()
	{
	}

	// Token: 0x06000E4A RID: 3658 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E4A")]
	[Address(RVA = "0x5BA6A0", Offset = "0x5B9AA0", VA = "0x105BA6A0")]
	public void Flash(float delay = 0f)
	{
	}

	// Token: 0x06000E4B RID: 3659 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E4B")]
	[Address(RVA = "0x5BA720", Offset = "0x5B9B20", VA = "0x105BA720")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE4DF0", Offset = "0xE41F0")]
	private static IEnumerator Flash(CrystalBehaviour c, float delay)
	{
		return null;
	}

	// Token: 0x06000E4C RID: 3660 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E4C")]
	[Address(RVA = "0x5BAA80", Offset = "0x5B9E80", VA = "0x105BAA80")]
	public CrystalBehaviour()
	{
	}

	// Token: 0x04000E40 RID: 3648
	[Token(Token = "0x4000E40")]
	[FieldOffset(Offset = "0x28")]
	public Transform TargetPosition;

	// Token: 0x04000E41 RID: 3649
	[Token(Token = "0x4000E41")]
	[FieldOffset(Offset = "0x2C")]
	public SpriteRenderer Renderer;

	// Token: 0x04000E42 RID: 3650
	[Token(Token = "0x4000E42")]
	[FieldOffset(Offset = "0x30")]
	public BoxCollider2D Collider;

	// Token: 0x04000E43 RID: 3651
	[Token(Token = "0x4000E43")]
	[FieldOffset(Offset = "0x34")]
	public bool CanMove;

	// Token: 0x04000E44 RID: 3652
	[Token(Token = "0x4000E44")]
	[FieldOffset(Offset = "0x38")]
	public FloatRange Padding;

	// Token: 0x04000E45 RID: 3653
	[Token(Token = "0x4000E45")]
	private const float Speed = 15f;

	// Token: 0x04000E46 RID: 3654
	[Token(Token = "0x4000E46")]
	[FieldOffset(Offset = "0x3C")]
	public float XFloatMag;

	// Token: 0x04000E47 RID: 3655
	[Token(Token = "0x4000E47")]
	private const float FloatMag = 0.05f;

	// Token: 0x04000E48 RID: 3656
	[Token(Token = "0x4000E48")]
	private const float FloatSpeed = 0.35f;

	// Token: 0x04000E49 RID: 3657
	[Token(Token = "0x4000E49")]
	[FieldOffset(Offset = "0x40")]
	public float PieceIndex;

	// Token: 0x02000284 RID: 644
	[Token(Token = "0x2000284")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <Flash>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000E4D RID: 3661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E4D")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <Flash>d__12(int <>1__state)
		{
		}

		// Token: 0x06000E4E RID: 3662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E4E")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000E4F RID: 3663 RVA: 0x00005868 File Offset: 0x00003A68
		[Token(Token = "0x6000E4F")]
		[Address(RVA = "0x788560", Offset = "0x787960", VA = "0x10788560", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000E50 RID: 3664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700022B")]
		private object Current
		{
			[Token(Token = "0x6000E50")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000E51 RID: 3665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E51")]
		[Address(RVA = "0x788820", Offset = "0x787C20", VA = "0x10788820", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000E52 RID: 3666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700022C")]
		private object Current
		{
			[Token(Token = "0x6000E52")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000E4A RID: 3658
		[Token(Token = "0x4000E4A")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000E4B RID: 3659
		[Token(Token = "0x4000E4B")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000E4C RID: 3660
		[Token(Token = "0x4000E4C")]
		[FieldOffset(Offset = "0x10")]
		public float delay;

		// Token: 0x04000E4D RID: 3661
		[Token(Token = "0x4000E4D")]
		[FieldOffset(Offset = "0x14")]
		public CrystalBehaviour c;

		// Token: 0x04000E4E RID: 3662
		[Token(Token = "0x4000E4E")]
		[FieldOffset(Offset = "0x18")]
		private Color <col>5__2;

		// Token: 0x04000E4F RID: 3663
		[Token(Token = "0x4000E4F")]
		[FieldOffset(Offset = "0x28")]
		private float <time>5__3;
	}
}
