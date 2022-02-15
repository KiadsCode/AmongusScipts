using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000171 RID: 369
[Token(Token = "0x2000171")]
public class ProgressBar : MonoBehaviour
{
	// Token: 0x17000148 RID: 328
	// (get) Token: 0x06000870 RID: 2160 RVA: 0x00004260 File Offset: 0x00002460
	// (set) Token: 0x06000871 RID: 2161 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000148")]
	public float GlowAlpha
	{
		[Token(Token = "0x6000870")]
		[Address(RVA = "0x511220", Offset = "0x510620", VA = "0x10511220")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000871")]
		[Address(RVA = "0x511260", Offset = "0x510660", VA = "0x10511260")]
		set
		{
		}
	}

	// Token: 0x06000872 RID: 2162 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000872")]
	[Address(RVA = "0x510BE0", Offset = "0x50FFE0", VA = "0x10510BE0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDFE40", Offset = "0xDF240")]
	public IEnumerator ScaleDownY(float duration)
	{
		return null;
	}

	// Token: 0x06000873 RID: 2163 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000873")]
	[Address(RVA = "0x510B80", Offset = "0x50FF80", VA = "0x10510B80")]
	public void ResetScale()
	{
	}

	// Token: 0x06000874 RID: 2164 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000874")]
	[Address(RVA = "0x510A00", Offset = "0x50FE00", VA = "0x10510A00")]
	private void Update()
	{
	}

	// Token: 0x06000875 RID: 2165 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000875")]
	[Address(RVA = "0x510EB0", Offset = "0x5102B0", VA = "0x10510EB0")]
	private void SetFillWidth(float xScale)
	{
	}

	// Token: 0x06000876 RID: 2166 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000876")]
	[Address(RVA = "0x510C40", Offset = "0x510040", VA = "0x10510C40")]
	private void SetCapWidth(float xScale)
	{
	}

	// Token: 0x06000877 RID: 2167 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000877")]
	[Address(RVA = "0x510A00", Offset = "0x50FE00", VA = "0x10510A00")]
	private void OnValidate()
	{
	}

	// Token: 0x06000878 RID: 2168 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000878")]
	[Address(RVA = "0x5111D0", Offset = "0x5105D0", VA = "0x105111D0")]
	public ProgressBar()
	{
	}

	// Token: 0x06000879 RID: 2169 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000879")]
	[Address(RVA = "0x510FF0", Offset = "0x5103F0", VA = "0x10510FF0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private void <ScaleDownY>b__15_0(float t)
	{
	}

	// Token: 0x0400087A RID: 2170
	[Token(Token = "0x400087A")]
	private const float CurrentCapScale = 1f;

	// Token: 0x0400087B RID: 2171
	[Token(Token = "0x400087B")]
	[FieldOffset(Offset = "0xC")]
	public float Value;

	// Token: 0x0400087C RID: 2172
	[Token(Token = "0x400087C")]
	[FieldOffset(Offset = "0x10")]
	public float CapValue;

	// Token: 0x0400087D RID: 2173
	[Token(Token = "0x400087D")]
	[FieldOffset(Offset = "0x14")]
	public float MaxValue;

	// Token: 0x0400087E RID: 2174
	[Token(Token = "0x400087E")]
	[FieldOffset(Offset = "0x18")]
	public float maskScale;

	// Token: 0x0400087F RID: 2175
	[Token(Token = "0x400087F")]
	[FieldOffset(Offset = "0x1C")]
	public SpriteRenderer Mask;

	// Token: 0x04000880 RID: 2176
	[Token(Token = "0x4000880")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xDFE10", Offset = "0xDF210")]
	public SpriteRenderer cap;

	// Token: 0x04000881 RID: 2177
	[Token(Token = "0x4000881")]
	[FieldOffset(Offset = "0x24")]
	public SpriteRenderer capGlow;

	// Token: 0x04000882 RID: 2178
	[Token(Token = "0x4000882")]
	[FieldOffset(Offset = "0x28")]
	public float capScale;

	// Token: 0x04000883 RID: 2179
	[Token(Token = "0x4000883")]
	[FieldOffset(Offset = "0x2C")]
	public float capGlowSizePadding;

	// Token: 0x04000884 RID: 2180
	[Token(Token = "0x4000884")]
	[FieldOffset(Offset = "0x30")]
	private float lastValue;

	// Token: 0x04000885 RID: 2181
	[Token(Token = "0x4000885")]
	[FieldOffset(Offset = "0x34")]
	private float lastCapDiff;

	// Token: 0x02000172 RID: 370
	[Token(Token = "0x2000172")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <ScaleDownY>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600087A RID: 2170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600087A")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <ScaleDownY>d__15(int <>1__state)
		{
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600087B")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x00004278 File Offset: 0x00002478
		[Token(Token = "0x600087C")]
		[Address(RVA = "0x798580", Offset = "0x797980", VA = "0x10798580", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x0600087D RID: 2173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000149")]
		private object Current
		{
			[Token(Token = "0x600087D")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600087E")]
		[Address(RVA = "0x7986D0", Offset = "0x797AD0", VA = "0x107986D0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x0600087F RID: 2175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700014A")]
		private object Current
		{
			[Token(Token = "0x600087F")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000886 RID: 2182
		[Token(Token = "0x4000886")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000887 RID: 2183
		[Token(Token = "0x4000887")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000888 RID: 2184
		[Token(Token = "0x4000888")]
		[FieldOffset(Offset = "0x10")]
		public float duration;

		// Token: 0x04000889 RID: 2185
		[Token(Token = "0x4000889")]
		[FieldOffset(Offset = "0x14")]
		public ProgressBar <>4__this;
	}
}
