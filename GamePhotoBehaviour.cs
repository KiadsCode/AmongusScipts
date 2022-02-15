using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000094 RID: 148
[Token(Token = "0x2000094")]
public class GamePhotoBehaviour : MonoBehaviour
{
	// Token: 0x0600039B RID: 923 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600039B")]
	[Address(RVA = "0x3B1E70", Offset = "0x3B1270", VA = "0x103B1E70")]
	public void Start()
	{
	}

	// Token: 0x0600039C RID: 924 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600039C")]
	[Address(RVA = "0x3B1E20", Offset = "0x3B1220", VA = "0x103B1E20")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE5B20", Offset = "0xE4F20")]
	internal IEnumerator Pickup()
	{
		return null;
	}

	// Token: 0x0600039D RID: 925 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600039D")]
	[Address(RVA = "0x3B1DC0", Offset = "0x3B11C0", VA = "0x103B1DC0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE5BB0", Offset = "0xE4FB0")]
	internal IEnumerator Drop(bool inWater)
	{
		return null;
	}

	// Token: 0x0600039E RID: 926 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600039E")]
	[Address(RVA = "0x3B2050", Offset = "0x3B1450", VA = "0x103B2050")]
	public GamePhotoBehaviour()
	{
	}

	// Token: 0x060003A0 RID: 928 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003A0")]
	[Address(RVA = "0x3B1EF0", Offset = "0x3B12F0", VA = "0x103B1EF0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private void <Pickup>b__7_0(float t)
	{
	}

	// Token: 0x060003A1 RID: 929 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003A1")]
	[Address(RVA = "0x3B1F70", Offset = "0x3B1370", VA = "0x103B1F70")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private void <Pickup>b__7_1()
	{
	}

	// Token: 0x04000397 RID: 919
	[Token(Token = "0x4000397")]
	[FieldOffset(Offset = "0x0")]
	public static readonly Color InWaterPink;

	// Token: 0x04000398 RID: 920
	[Token(Token = "0x4000398")]
	[FieldOffset(Offset = "0xC")]
	public float zOffset;

	// Token: 0x04000399 RID: 921
	[Token(Token = "0x4000399")]
	[FieldOffset(Offset = "0x10")]
	public SpriteRenderer Frame;

	// Token: 0x0400039A RID: 922
	[Token(Token = "0x400039A")]
	[FieldOffset(Offset = "0x14")]
	public SpriteRenderer Image;

	// Token: 0x0400039B RID: 923
	[Token(Token = "0x400039B")]
	[FieldOffset(Offset = "0x18")]
	public Collider2D Hitbox;

	// Token: 0x0400039C RID: 924
	[Token(Token = "0x400039C")]
	[FieldOffset(Offset = "0x1C")]
	public Color TargetColor;

	// Token: 0x02000095 RID: 149
	[Token(Token = "0x2000095")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <Pickup>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060003A2 RID: 930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <Pickup>d__7(int <>1__state)
		{
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00002AF0 File Offset: 0x00000CF0
		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x5B2CA0", Offset = "0x5B20A0", VA = "0x105B2CA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060003A5 RID: 933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700008C")]
		private object Current
		{
			[Token(Token = "0x60003A5")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x5B2FB0", Offset = "0x5B23B0", VA = "0x105B2FB0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060003A7 RID: 935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700008D")]
		private object Current
		{
			[Token(Token = "0x60003A7")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400039D RID: 925
		[Token(Token = "0x400039D")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x0400039E RID: 926
		[Token(Token = "0x400039E")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x0400039F RID: 927
		[Token(Token = "0x400039F")]
		[FieldOffset(Offset = "0x10")]
		public GamePhotoBehaviour <>4__this;
	}

	// Token: 0x02000096 RID: 150
	[Token(Token = "0x2000096")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass8_0
	{
		// Token: 0x060003A8 RID: 936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass8_0()
		{
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x5B5850", Offset = "0x5B4C50", VA = "0x105B5850")]
		internal void <Drop>b__0(float t)
		{
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x5B58A0", Offset = "0x5B4CA0", VA = "0x105B58A0")]
		internal void <Drop>b__1()
		{
		}

		// Token: 0x040003A0 RID: 928
		[Token(Token = "0x40003A0")]
		[FieldOffset(Offset = "0x8")]
		public GamePhotoBehaviour <>4__this;

		// Token: 0x040003A1 RID: 929
		[Token(Token = "0x40003A1")]
		[FieldOffset(Offset = "0xC")]
		public bool inWater;
	}

	// Token: 0x02000097 RID: 151
	[Token(Token = "0x2000097")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <Drop>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060003AB RID: 939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <Drop>d__8(int <>1__state)
		{
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00002B08 File Offset: 0x00000D08
		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x5B01D0", Offset = "0x5AF5D0", VA = "0x105B01D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060003AE RID: 942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700008E")]
		private object Current
		{
			[Token(Token = "0x60003AE")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x5B0520", Offset = "0x5AF920", VA = "0x105B0520", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060003B0 RID: 944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700008F")]
		private object Current
		{
			[Token(Token = "0x60003B0")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040003A2 RID: 930
		[Token(Token = "0x40003A2")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040003A3 RID: 931
		[Token(Token = "0x40003A3")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040003A4 RID: 932
		[Token(Token = "0x40003A4")]
		[FieldOffset(Offset = "0x10")]
		public GamePhotoBehaviour <>4__this;

		// Token: 0x040003A5 RID: 933
		[Token(Token = "0x40003A5")]
		[FieldOffset(Offset = "0x14")]
		public bool inWater;
	}
}
