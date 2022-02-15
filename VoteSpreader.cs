using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200022E RID: 558
[Token(Token = "0x200022E")]
public class VoteSpreader : MonoBehaviour
{
	// Token: 0x06000C83 RID: 3203 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C83")]
	[Address(RVA = "0x7B47B0", Offset = "0x7B3BB0", VA = "0x107B47B0")]
	private void Update()
	{
	}

	// Token: 0x06000C84 RID: 3204 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C84")]
	[Address(RVA = "0x7B4700", Offset = "0x7B3B00", VA = "0x107B4700")]
	public void AddVote(SpriteRenderer newVote)
	{
	}

	// Token: 0x06000C85 RID: 3205 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C85")]
	[Address(RVA = "0x7B4A40", Offset = "0x7B3E40", VA = "0x107B4A40")]
	public VoteSpreader()
	{
	}

	// Token: 0x04000C79 RID: 3193
	[Token(Token = "0x4000C79")]
	[FieldOffset(Offset = "0xC")]
	public List<SpriteRenderer> Votes;

	// Token: 0x04000C7A RID: 3194
	[Token(Token = "0x4000C7A")]
	[FieldOffset(Offset = "0x10")]
	public FloatRange VoteRange;

	// Token: 0x04000C7B RID: 3195
	[Token(Token = "0x4000C7B")]
	[FieldOffset(Offset = "0x14")]
	public int maxVotesBeforeSmoosh;

	// Token: 0x04000C7C RID: 3196
	[Token(Token = "0x4000C7C")]
	[FieldOffset(Offset = "0x18")]
	public float CounterY;

	// Token: 0x04000C7D RID: 3197
	[Token(Token = "0x4000C7D")]
	[FieldOffset(Offset = "0x1C")]
	public float adjustRate;

	// Token: 0x0200022F RID: 559
	[Token(Token = "0x200022F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000C87 RID: 3207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C87")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x06000C88 RID: 3208 RVA: 0x00004F38 File Offset: 0x00003138
		[Token(Token = "0x6000C88")]
		[Address(RVA = "0x1302110", Offset = "0x1301510", VA = "0x11302110")]
		internal bool <Update>b__5_0(SpriteRenderer v)
		{
			return default(bool);
		}

		// Token: 0x04000C7E RID: 3198
		[Token(Token = "0x4000C7E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly VoteSpreader.<>c <>9;

		// Token: 0x04000C7F RID: 3199
		[Token(Token = "0x4000C7F")]
		[FieldOffset(Offset = "0x4")]
		public static Func<SpriteRenderer, bool> <>9__5_0;
	}
}
