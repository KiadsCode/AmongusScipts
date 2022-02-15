using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace PowerTools
{
	// Token: 0x020005EB RID: 1515
	[Token(Token = "0x20005EB")]
	public class WaitForAnimationFinish : IEnumerator
	{
		// Token: 0x06002638 RID: 9784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002638")]
		[Address(RVA = "0x7B4BF0", Offset = "0x7B3FF0", VA = "0x107B4BF0")]
		public WaitForAnimationFinish(SpriteAnim animator, AnimationClip clip)
		{
		}

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x06002639 RID: 9785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700080D")]
		public object Current
		{
			[Token(Token = "0x6002639")]
			[Address(RVA = "0x394F70", Offset = "0x394370", VA = "0x10394F70", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600263A RID: 9786 RVA: 0x0000B568 File Offset: 0x00009768
		[Token(Token = "0x600263A")]
		[Address(RVA = "0x7B4AF0", Offset = "0x7B3EF0", VA = "0x107B4AF0", Slot = "4")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x0600263B RID: 9787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600263B")]
		[Address(RVA = "0x7B4BC0", Offset = "0x7B3FC0", VA = "0x107B4BC0", Slot = "6")]
		public void Reset()
		{
		}

		// Token: 0x040025C6 RID: 9670
		[Token(Token = "0x40025C6")]
		[FieldOffset(Offset = "0x8")]
		private SpriteAnim animator;

		// Token: 0x040025C7 RID: 9671
		[Token(Token = "0x40025C7")]
		[FieldOffset(Offset = "0xC")]
		private AnimationClip clip;

		// Token: 0x040025C8 RID: 9672
		[Token(Token = "0x40025C8")]
		[FieldOffset(Offset = "0x10")]
		private bool first;
	}
}
