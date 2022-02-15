using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000173 RID: 371
[Token(Token = "0x2000173")]
public class ProgressionScreen : MonoBehaviour
{
	// Token: 0x06000880 RID: 2176 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000880")]
	[Address(RVA = "0x511B10", Offset = "0x510F10", VA = "0x10511B10")]
	public void Activate()
	{
	}

	// Token: 0x06000881 RID: 2177 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000881")]
	[Address(RVA = "0x5126F0", Offset = "0x511AF0", VA = "0x105126F0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDFF20", Offset = "0xDF320")]
	private IEnumerator DoAnimations(ProgressionManager.XpGrantResult xpGainedResult)
	{
		return null;
	}

	// Token: 0x06000882 RID: 2178 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000882")]
	[Address(RVA = "0x512620", Offset = "0x511A20", VA = "0x10512620")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDFF70", Offset = "0xDF370")]
	private IEnumerator AnimateXpAndLevelUp(ProgressionManager.XpGrantResult xpGainedResult)
	{
		return null;
	}

	// Token: 0x06000883 RID: 2179 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000883")]
	[Address(RVA = "0x512680", Offset = "0x511A80", VA = "0x10512680")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDFFC0", Offset = "0xDF3C0")]
	private IEnumerator AnimateXpBarFill(uint oldXpAmount, ulong newXpAmount)
	{
		return null;
	}

	// Token: 0x06000884 RID: 2180 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000884")]
	[Address(RVA = "0x5125D0", Offset = "0x5119D0", VA = "0x105125D0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE0010", Offset = "0xDF410")]
	private IEnumerator AnimatePodsAndBeans()
	{
		return null;
	}

	// Token: 0x06000885 RID: 2181 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000885")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public ProgressionScreen()
	{
	}

	// Token: 0x06000886 RID: 2182 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000886")]
	[Address(RVA = "0x512750", Offset = "0x511B50", VA = "0x10512750")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private void <AnimateXpAndLevelUp>b__15_0(float t)
	{
	}

	// Token: 0x06000887 RID: 2183 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000887")]
	[Address(RVA = "0x5127C0", Offset = "0x511BC0", VA = "0x105127C0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private void <AnimateXpAndLevelUp>b__15_1(float t)
	{
	}

	// Token: 0x06000888 RID: 2184 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000888")]
	[Address(RVA = "0x512930", Offset = "0x511D30", VA = "0x10512930")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private void <AnimateXpAndLevelUp>b__15_2(float t)
	{
	}

	// Token: 0x0400088A RID: 2186
	[Token(Token = "0x400088A")]
	private const float TimeToFillSeconds = 0.5f;

	// Token: 0x0400088B RID: 2187
	[Token(Token = "0x400088B")]
	private const float TimeToGlowSeconds = 0.75f;

	// Token: 0x0400088C RID: 2188
	[Token(Token = "0x400088C")]
	[FieldOffset(Offset = "0xC")]
	public PoolablePlayer Player;

	// Token: 0x0400088D RID: 2189
	[Token(Token = "0x400088D")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xDFE90", Offset = "0xDF290")]
	public AudioClip XpSound;

	// Token: 0x0400088E RID: 2190
	[Token(Token = "0x400088E")]
	[FieldOffset(Offset = "0x14")]
	public AudioClip LevelUpSound;

	// Token: 0x0400088F RID: 2191
	[Token(Token = "0x400088F")]
	[FieldOffset(Offset = "0x18")]
	public ProgressBar XpBar;

	// Token: 0x04000890 RID: 2192
	[Token(Token = "0x4000890")]
	[FieldOffset(Offset = "0x1C")]
	public TextMeshPro XpEarnedNowText;

	// Token: 0x04000891 RID: 2193
	[Token(Token = "0x4000891")]
	[FieldOffset(Offset = "0x20")]
	public AnimationCurve XpEarnedNowCurve;

	// Token: 0x04000892 RID: 2194
	[Token(Token = "0x4000892")]
	[FieldOffset(Offset = "0x24")]
	public TextMeshPro LevelText;

	// Token: 0x04000893 RID: 2195
	[Token(Token = "0x4000893")]
	[FieldOffset(Offset = "0x28")]
	public Transform LevelCircle;

	// Token: 0x04000894 RID: 2196
	[Token(Token = "0x4000894")]
	[FieldOffset(Offset = "0x2C")]
	public TextMeshPro FutureLevelText;

	// Token: 0x04000895 RID: 2197
	[Token(Token = "0x4000895")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xDFEC0", Offset = "0xDF2C0")]
	public CurrencyEarned PodsEarned;

	// Token: 0x04000896 RID: 2198
	[Token(Token = "0x4000896")]
	[FieldOffset(Offset = "0x34")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xDFEF0", Offset = "0xDF2F0")]
	public CurrencyEarned BeansEarned;

	// Token: 0x02000174 RID: 372
	[Token(Token = "0x2000174")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <DoAnimations>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000889 RID: 2185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000889")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <DoAnimations>d__14(int <>1__state)
		{
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600088A")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x00004290 File Offset: 0x00002490
		[Token(Token = "0x600088B")]
		[Address(RVA = "0x796AA0", Offset = "0x795EA0", VA = "0x10796AA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x0600088C RID: 2188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700014B")]
		private object Current
		{
			[Token(Token = "0x600088C")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600088D")]
		[Address(RVA = "0x796C00", Offset = "0x796000", VA = "0x10796C00", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x0600088E RID: 2190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700014C")]
		private object Current
		{
			[Token(Token = "0x600088E")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000897 RID: 2199
		[Token(Token = "0x4000897")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000898 RID: 2200
		[Token(Token = "0x4000898")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000899 RID: 2201
		[Token(Token = "0x4000899")]
		[FieldOffset(Offset = "0x10")]
		public ProgressionManager.XpGrantResult xpGainedResult;

		// Token: 0x0400089A RID: 2202
		[Token(Token = "0x400089A")]
		[FieldOffset(Offset = "0x14")]
		public ProgressionScreen <>4__this;
	}

	// Token: 0x02000175 RID: 373
	[Token(Token = "0x2000175")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <AnimateXpAndLevelUp>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600088F RID: 2191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600088F")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <AnimateXpAndLevelUp>d__15(int <>1__state)
		{
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000890")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x000042A8 File Offset: 0x000024A8
		[Token(Token = "0x6000891")]
		[Address(RVA = "0x790200", Offset = "0x78F600", VA = "0x10790200", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000892 RID: 2194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700014D")]
		private object Current
		{
			[Token(Token = "0x6000892")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000893")]
		[Address(RVA = "0x790BD0", Offset = "0x78FFD0", VA = "0x10790BD0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000894 RID: 2196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700014E")]
		private object Current
		{
			[Token(Token = "0x6000894")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400089B RID: 2203
		[Token(Token = "0x400089B")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x0400089C RID: 2204
		[Token(Token = "0x400089C")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x0400089D RID: 2205
		[Token(Token = "0x400089D")]
		[FieldOffset(Offset = "0x10")]
		public ProgressionManager.XpGrantResult xpGainedResult;

		// Token: 0x0400089E RID: 2206
		[Token(Token = "0x400089E")]
		[FieldOffset(Offset = "0x14")]
		public ProgressionScreen <>4__this;

		// Token: 0x0400089F RID: 2207
		[Token(Token = "0x400089F")]
		[FieldOffset(Offset = "0x18")]
		private ulong <newXpAmount>5__2;
	}

	// Token: 0x02000176 RID: 374
	[Token(Token = "0x2000176")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <AnimateXpBarFill>d__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000895 RID: 2197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000895")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <AnimateXpBarFill>d__16(int <>1__state)
		{
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000896")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x000042C0 File Offset: 0x000024C0
		[Token(Token = "0x6000897")]
		[Address(RVA = "0x790C00", Offset = "0x790000", VA = "0x10790C00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000898 RID: 2200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700014F")]
		private object Current
		{
			[Token(Token = "0x6000898")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000899")]
		[Address(RVA = "0x791010", Offset = "0x790410", VA = "0x10791010", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x0600089A RID: 2202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000150")]
		private object Current
		{
			[Token(Token = "0x600089A")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040008A0 RID: 2208
		[Token(Token = "0x40008A0")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040008A1 RID: 2209
		[Token(Token = "0x40008A1")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040008A2 RID: 2210
		[Token(Token = "0x40008A2")]
		[FieldOffset(Offset = "0x10")]
		public ProgressionScreen <>4__this;

		// Token: 0x040008A3 RID: 2211
		[Token(Token = "0x40008A3")]
		[FieldOffset(Offset = "0x14")]
		public uint oldXpAmount;

		// Token: 0x040008A4 RID: 2212
		[Token(Token = "0x40008A4")]
		[FieldOffset(Offset = "0x18")]
		public ulong newXpAmount;

		// Token: 0x040008A5 RID: 2213
		[Token(Token = "0x40008A5")]
		[FieldOffset(Offset = "0x20")]
		private float <startTime>5__2;
	}

	// Token: 0x02000177 RID: 375
	[Token(Token = "0x2000177")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <AnimatePodsAndBeans>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600089B RID: 2203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600089B")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <AnimatePodsAndBeans>d__17(int <>1__state)
		{
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600089C")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x000042D8 File Offset: 0x000024D8
		[Token(Token = "0x600089D")]
		[Address(RVA = "0x78F4B0", Offset = "0x78E8B0", VA = "0x1078F4B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x0600089E RID: 2206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000151")]
		private object Current
		{
			[Token(Token = "0x600089E")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600089F")]
		[Address(RVA = "0x78F770", Offset = "0x78EB70", VA = "0x1078F770", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060008A0 RID: 2208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000152")]
		private object Current
		{
			[Token(Token = "0x60008A0")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040008A6 RID: 2214
		[Token(Token = "0x40008A6")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040008A7 RID: 2215
		[Token(Token = "0x40008A7")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040008A8 RID: 2216
		[Token(Token = "0x40008A8")]
		[FieldOffset(Offset = "0x10")]
		public ProgressionScreen <>4__this;
	}
}
