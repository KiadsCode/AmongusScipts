using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

// Token: 0x020000F7 RID: 247
[Token(Token = "0x20000F7")]
[Serializable]
public class FloatRange
{
	// Token: 0x170000E6 RID: 230
	// (get) Token: 0x060005ED RID: 1517 RVA: 0x00003720 File Offset: 0x00001920
	// (set) Token: 0x060005EE RID: 1518 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170000E6")]
	public float Last
	{
		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x273A10", Offset = "0x272E10", VA = "0x10273A10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x273A30", Offset = "0x272E30", VA = "0x10273A30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private set
		{
		}
	}

	// Token: 0x170000E7 RID: 231
	// (get) Token: 0x060005EF RID: 1519 RVA: 0x00003738 File Offset: 0x00001938
	[Token(Token = "0x170000E7")]
	public float Width
	{
		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x3A93A0", Offset = "0x3A87A0", VA = "0x103A93A0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x060005F0 RID: 1520 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005F0")]
	[Address(RVA = "0x3A9370", Offset = "0x3A8770", VA = "0x103A9370")]
	public FloatRange(float min, float max)
	{
	}

	// Token: 0x060005F1 RID: 1521 RVA: 0x00003750 File Offset: 0x00001950
	[Token(Token = "0x60005F1")]
	[Address(RVA = "0x3A8B00", Offset = "0x3A7F00", VA = "0x103A8B00")]
	public float ChangeRange(float y, float min, float max)
	{
		return 0f;
	}

	// Token: 0x060005F2 RID: 1522 RVA: 0x00003768 File Offset: 0x00001968
	[Token(Token = "0x60005F2")]
	[Address(RVA = "0x3A8B50", Offset = "0x3A7F50", VA = "0x103A8B50")]
	public float Clamp(float value)
	{
		return 0f;
	}

	// Token: 0x060005F3 RID: 1523 RVA: 0x00003780 File Offset: 0x00001980
	[Token(Token = "0x60005F3")]
	[Address(RVA = "0x3A8B90", Offset = "0x3A7F90", VA = "0x103A8B90")]
	public bool Contains(float t)
	{
		return default(bool);
	}

	// Token: 0x060005F4 RID: 1524 RVA: 0x00003798 File Offset: 0x00001998
	[Token(Token = "0x60005F4")]
	[Address(RVA = "0x3A8BC0", Offset = "0x3A7FC0", VA = "0x103A8BC0")]
	public float CubicLerp(float v)
	{
		return 0f;
	}

	// Token: 0x060005F5 RID: 1525 RVA: 0x000037B0 File Offset: 0x000019B0
	[Token(Token = "0x60005F5")]
	[Address(RVA = "0x3A8C40", Offset = "0x3A8040", VA = "0x103A8C40")]
	public float EitherOr()
	{
		return 0f;
	}

	// Token: 0x060005F6 RID: 1526 RVA: 0x000037C8 File Offset: 0x000019C8
	[Token(Token = "0x60005F6")]
	[Address(RVA = "0x3A8D30", Offset = "0x3A8130", VA = "0x103A8D30")]
	public float LerpUnclamped(float v)
	{
		return 0f;
	}

	// Token: 0x060005F7 RID: 1527 RVA: 0x000037E0 File Offset: 0x000019E0
	[Token(Token = "0x60005F7")]
	[Address(RVA = "0x3A8D70", Offset = "0x3A8170", VA = "0x103A8D70")]
	public float Lerp(float v)
	{
		return 0f;
	}

	// Token: 0x060005F8 RID: 1528 RVA: 0x000037F8 File Offset: 0x000019F8
	[Token(Token = "0x60005F8")]
	[Address(RVA = "0x3A8C70", Offset = "0x3A8070", VA = "0x103A8C70")]
	public float ExpOutLerp(float v)
	{
		return 0f;
	}

	// Token: 0x060005F9 RID: 1529 RVA: 0x00003810 File Offset: 0x00001A10
	[Token(Token = "0x60005F9")]
	[Address(RVA = "0x3A8CD0", Offset = "0x3A80D0", VA = "0x103A8CD0")]
	public static float ExpOutLerp(float v, float min, float max)
	{
		return 0f;
	}

	// Token: 0x060005FA RID: 1530 RVA: 0x00003828 File Offset: 0x00001A28
	[Token(Token = "0x60005FA")]
	[Address(RVA = "0x3A8EC0", Offset = "0x3A82C0", VA = "0x103A8EC0")]
	public static float Next(float min, float max)
	{
		return 0f;
	}

	// Token: 0x060005FB RID: 1531 RVA: 0x00003840 File Offset: 0x00001A40
	[Token(Token = "0x60005FB")]
	[Address(RVA = "0x3A8E80", Offset = "0x3A8280", VA = "0x103A8E80")]
	public float Next()
	{
		return 0f;
	}

	// Token: 0x060005FC RID: 1532 RVA: 0x00003858 File Offset: 0x00001A58
	[Token(Token = "0x60005FC")]
	[Address(RVA = "0x3A8DB0", Offset = "0x3A81B0", VA = "0x103A8DB0")]
	public float NextMinDistance(float center, float minDistance)
	{
		return 0f;
	}

	// Token: 0x060005FD RID: 1533 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005FD")]
	[Address(RVA = "0x3A8F50", Offset = "0x3A8350", VA = "0x103A8F50")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE7D80", Offset = "0xE7180")]
	public IEnumerable<float> Range(int numStops)
	{
		return null;
	}

	// Token: 0x060005FE RID: 1534 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005FE")]
	[Address(RVA = "0x3A8EF0", Offset = "0x3A82F0", VA = "0x103A8EF0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE7E10", Offset = "0xE7210")]
	public IEnumerable<float> RandomRange(int numStops)
	{
		return null;
	}

	// Token: 0x060005FF RID: 1535 RVA: 0x00003870 File Offset: 0x00001A70
	[Token(Token = "0x60005FF")]
	[Address(RVA = "0x3A9010", Offset = "0x3A8410", VA = "0x103A9010")]
	internal float ReverseLerp(float t)
	{
		return 0f;
	}

	// Token: 0x06000600 RID: 1536 RVA: 0x00003888 File Offset: 0x00001A88
	[Token(Token = "0x6000600")]
	[Address(RVA = "0x3A8FB0", Offset = "0x3A83B0", VA = "0x103A8FB0")]
	public static float ReverseLerp(float t, float min, float max)
	{
		return 0f;
	}

	// Token: 0x06000601 RID: 1537 RVA: 0x000038A0 File Offset: 0x00001AA0
	[Token(Token = "0x6000601")]
	[Address(RVA = "0x3A91B0", Offset = "0x3A85B0", VA = "0x103A91B0")]
	public float SpreadToEdges(int idx, int stops)
	{
		return 0f;
	}

	// Token: 0x06000602 RID: 1538 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000602")]
	[Address(RVA = "0x3A9220", Offset = "0x3A8620", VA = "0x103A9220")]
	public IEnumerable<float> SpreadToEdges(int stops)
	{
		return null;
	}

	// Token: 0x06000603 RID: 1539 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000603")]
	[Address(RVA = "0x3A9070", Offset = "0x3A8470", VA = "0x103A9070")]
	public IEnumerable<float> SpreadEvenly(int stops)
	{
		return null;
	}

	// Token: 0x06000604 RID: 1540 RVA: 0x000038B8 File Offset: 0x00001AB8
	[Token(Token = "0x6000604")]
	[Address(RVA = "0x3A9310", Offset = "0x3A8710", VA = "0x103A9310")]
	public static float SpreadToEdges(float min, float max, int i, int stops)
	{
		return 0f;
	}

	// Token: 0x06000605 RID: 1541 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000605")]
	[Address(RVA = "0x3A92A0", Offset = "0x3A86A0", VA = "0x103A92A0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE7EA0", Offset = "0xE72A0")]
	public static IEnumerable<float> SpreadToEdges(float min, float max, int stops)
	{
		return null;
	}

	// Token: 0x06000606 RID: 1542 RVA: 0x000038D0 File Offset: 0x00001AD0
	[Token(Token = "0x6000606")]
	[Address(RVA = "0x3A9160", Offset = "0x3A8560", VA = "0x103A9160")]
	public static float SpreadEvenly(float min, float max, int i, int stops)
	{
		return 0f;
	}

	// Token: 0x06000607 RID: 1543 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000607")]
	[Address(RVA = "0x3A90F0", Offset = "0x3A84F0", VA = "0x103A90F0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE7F70", Offset = "0xE7370")]
	public static IEnumerable<float> SpreadEvenly(float min, float max, int stops)
	{
		return null;
	}

	// Token: 0x04000600 RID: 1536
	[Token(Token = "0x4000600")]
	[FieldOffset(Offset = "0x8")]
	public float min;

	// Token: 0x04000601 RID: 1537
	[Token(Token = "0x4000601")]
	[FieldOffset(Offset = "0xC")]
	public float max;

	// Token: 0x04000602 RID: 1538
	[Token(Token = "0x4000602")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private float <Last>k__BackingField;

	// Token: 0x020000F8 RID: 248
	[Token(Token = "0x20000F8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <Range>d__21 : IEnumerable<float>, IEnumerable, IEnumerator<float>, IEnumerator, IDisposable
	{
		// Token: 0x06000608 RID: 1544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000608")]
		[Address(RVA = "0x5B1500", Offset = "0x5B0900", VA = "0x105B1500")]
		[DebuggerHidden]
		public <Range>d__21(int <>1__state)
		{
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000609")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "7")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x000038E8 File Offset: 0x00001AE8
		[Token(Token = "0x600060A")]
		[Address(RVA = "0x789C80", Offset = "0x789080", VA = "0x10789C80", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x0600060B RID: 1547 RVA: 0x00003900 File Offset: 0x00001B00
		[Token(Token = "0x170000E8")]
		private float Current
		{
			[Token(Token = "0x600060B")]
			[Address(RVA = "0x273770", Offset = "0x272B70", VA = "0x10273770", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600060C")]
		[Address(RVA = "0x789DA0", Offset = "0x7891A0", VA = "0x10789DA0", Slot = "10")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x0600060D RID: 1549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000E9")]
		private object Current
		{
			[Token(Token = "0x600060D")]
			[Address(RVA = "0x789DD0", Offset = "0x7891D0", VA = "0x10789DD0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600060E")]
		[Address(RVA = "0x789D10", Offset = "0x789110", VA = "0x10789D10", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<float> GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600060F")]
		[Address(RVA = "0x789D10", Offset = "0x789110", VA = "0x10789D10", Slot = "5")]
		[DebuggerHidden]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x04000603 RID: 1539
		[Token(Token = "0x4000603")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000604 RID: 1540
		[Token(Token = "0x4000604")]
		[FieldOffset(Offset = "0xC")]
		private float <>2__current;

		// Token: 0x04000605 RID: 1541
		[Token(Token = "0x4000605")]
		[FieldOffset(Offset = "0x10")]
		private int <>l__initialThreadId;

		// Token: 0x04000606 RID: 1542
		[Token(Token = "0x4000606")]
		[FieldOffset(Offset = "0x14")]
		public FloatRange <>4__this;

		// Token: 0x04000607 RID: 1543
		[Token(Token = "0x4000607")]
		[FieldOffset(Offset = "0x18")]
		private int numStops;

		// Token: 0x04000608 RID: 1544
		[Token(Token = "0x4000608")]
		[FieldOffset(Offset = "0x1C")]
		public int <>3__numStops;

		// Token: 0x04000609 RID: 1545
		[Token(Token = "0x4000609")]
		[FieldOffset(Offset = "0x20")]
		private float <i>5__2;
	}

	// Token: 0x020000F9 RID: 249
	[Token(Token = "0x20000F9")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <RandomRange>d__22 : IEnumerable<float>, IEnumerable, IEnumerator<float>, IEnumerator, IDisposable
	{
		// Token: 0x06000610 RID: 1552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000610")]
		[Address(RVA = "0x5B1500", Offset = "0x5B0900", VA = "0x105B1500")]
		[DebuggerHidden]
		public <RandomRange>d__22(int <>1__state)
		{
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000611")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "7")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x00003918 File Offset: 0x00001B18
		[Token(Token = "0x6000612")]
		[Address(RVA = "0x789B00", Offset = "0x788F00", VA = "0x10789B00", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000613 RID: 1555 RVA: 0x00003930 File Offset: 0x00001B30
		[Token(Token = "0x170000EA")]
		private float Current
		{
			[Token(Token = "0x6000613")]
			[Address(RVA = "0x273770", Offset = "0x272B70", VA = "0x10273770", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000614")]
		[Address(RVA = "0x789C00", Offset = "0x789000", VA = "0x10789C00", Slot = "10")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000615 RID: 1557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000EB")]
		private object Current
		{
			[Token(Token = "0x6000615")]
			[Address(RVA = "0x789C30", Offset = "0x789030", VA = "0x10789C30", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000616")]
		[Address(RVA = "0x789B70", Offset = "0x788F70", VA = "0x10789B70", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<float> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000617")]
		[Address(RVA = "0x789B70", Offset = "0x788F70", VA = "0x10789B70", Slot = "5")]
		[DebuggerHidden]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x0400060A RID: 1546
		[Token(Token = "0x400060A")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x0400060B RID: 1547
		[Token(Token = "0x400060B")]
		[FieldOffset(Offset = "0xC")]
		private float <>2__current;

		// Token: 0x0400060C RID: 1548
		[Token(Token = "0x400060C")]
		[FieldOffset(Offset = "0x10")]
		private int <>l__initialThreadId;

		// Token: 0x0400060D RID: 1549
		[Token(Token = "0x400060D")]
		[FieldOffset(Offset = "0x14")]
		public FloatRange <>4__this;

		// Token: 0x0400060E RID: 1550
		[Token(Token = "0x400060E")]
		[FieldOffset(Offset = "0x18")]
		private int numStops;

		// Token: 0x0400060F RID: 1551
		[Token(Token = "0x400060F")]
		[FieldOffset(Offset = "0x1C")]
		public int <>3__numStops;

		// Token: 0x04000610 RID: 1552
		[Token(Token = "0x4000610")]
		[FieldOffset(Offset = "0x20")]
		private float <i>5__2;
	}

	// Token: 0x020000FA RID: 250
	[Token(Token = "0x20000FA")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <SpreadToEdges>d__29 : IEnumerable<float>, IEnumerable, IEnumerator<float>, IEnumerator, IDisposable
	{
		// Token: 0x06000618 RID: 1560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000618")]
		[Address(RVA = "0x5B1500", Offset = "0x5B0900", VA = "0x105B1500")]
		[DebuggerHidden]
		public <SpreadToEdges>d__29(int <>1__state)
		{
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000619")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "7")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x00003948 File Offset: 0x00001B48
		[Token(Token = "0x600061A")]
		[Address(RVA = "0x78CCD0", Offset = "0x78C0D0", VA = "0x1078CCD0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x0600061B RID: 1563 RVA: 0x00003960 File Offset: 0x00001B60
		[Token(Token = "0x170000EC")]
		private float Current
		{
			[Token(Token = "0x600061B")]
			[Address(RVA = "0x273770", Offset = "0x272B70", VA = "0x10273770", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600061C")]
		[Address(RVA = "0x78CE10", Offset = "0x78C210", VA = "0x1078CE10", Slot = "10")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x0600061D RID: 1565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000ED")]
		private object Current
		{
			[Token(Token = "0x600061D")]
			[Address(RVA = "0x78CE40", Offset = "0x78C240", VA = "0x1078CE40", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600061E")]
		[Address(RVA = "0x78CD70", Offset = "0x78C170", VA = "0x1078CD70", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<float> GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600061F")]
		[Address(RVA = "0x78CD70", Offset = "0x78C170", VA = "0x1078CD70", Slot = "5")]
		[DebuggerHidden]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x04000611 RID: 1553
		[Token(Token = "0x4000611")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000612 RID: 1554
		[Token(Token = "0x4000612")]
		[FieldOffset(Offset = "0xC")]
		private float <>2__current;

		// Token: 0x04000613 RID: 1555
		[Token(Token = "0x4000613")]
		[FieldOffset(Offset = "0x10")]
		private int <>l__initialThreadId;

		// Token: 0x04000614 RID: 1556
		[Token(Token = "0x4000614")]
		[FieldOffset(Offset = "0x14")]
		private int stops;

		// Token: 0x04000615 RID: 1557
		[Token(Token = "0x4000615")]
		[FieldOffset(Offset = "0x18")]
		public int <>3__stops;

		// Token: 0x04000616 RID: 1558
		[Token(Token = "0x4000616")]
		[FieldOffset(Offset = "0x1C")]
		private float min;

		// Token: 0x04000617 RID: 1559
		[Token(Token = "0x4000617")]
		[FieldOffset(Offset = "0x20")]
		public float <>3__min;

		// Token: 0x04000618 RID: 1560
		[Token(Token = "0x4000618")]
		[FieldOffset(Offset = "0x24")]
		private float max;

		// Token: 0x04000619 RID: 1561
		[Token(Token = "0x4000619")]
		[FieldOffset(Offset = "0x28")]
		public float <>3__max;

		// Token: 0x0400061A RID: 1562
		[Token(Token = "0x400061A")]
		[FieldOffset(Offset = "0x2C")]
		private int <i>5__2;
	}

	// Token: 0x020000FB RID: 251
	[Token(Token = "0x20000FB")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <SpreadEvenly>d__31 : IEnumerable<float>, IEnumerable, IEnumerator<float>, IEnumerator, IDisposable
	{
		// Token: 0x06000620 RID: 1568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000620")]
		[Address(RVA = "0x5B1500", Offset = "0x5B0900", VA = "0x105B1500")]
		[DebuggerHidden]
		public <SpreadEvenly>d__31(int <>1__state)
		{
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000621")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "7")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x00003978 File Offset: 0x00001B78
		[Token(Token = "0x6000622")]
		[Address(RVA = "0x78CB20", Offset = "0x78BF20", VA = "0x1078CB20", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000623 RID: 1571 RVA: 0x00003990 File Offset: 0x00001B90
		[Token(Token = "0x170000EE")]
		private float Current
		{
			[Token(Token = "0x6000623")]
			[Address(RVA = "0x273770", Offset = "0x272B70", VA = "0x10273770", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000624")]
		[Address(RVA = "0x78CC50", Offset = "0x78C050", VA = "0x1078CC50", Slot = "10")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000625 RID: 1573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000EF")]
		private object Current
		{
			[Token(Token = "0x6000625")]
			[Address(RVA = "0x78CC80", Offset = "0x78C080", VA = "0x1078CC80", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000626")]
		[Address(RVA = "0x78CBB0", Offset = "0x78BFB0", VA = "0x1078CBB0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<float> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000627")]
		[Address(RVA = "0x78CBB0", Offset = "0x78BFB0", VA = "0x1078CBB0", Slot = "5")]
		[DebuggerHidden]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x0400061B RID: 1563
		[Token(Token = "0x400061B")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x0400061C RID: 1564
		[Token(Token = "0x400061C")]
		[FieldOffset(Offset = "0xC")]
		private float <>2__current;

		// Token: 0x0400061D RID: 1565
		[Token(Token = "0x400061D")]
		[FieldOffset(Offset = "0x10")]
		private int <>l__initialThreadId;

		// Token: 0x0400061E RID: 1566
		[Token(Token = "0x400061E")]
		[FieldOffset(Offset = "0x14")]
		private int stops;

		// Token: 0x0400061F RID: 1567
		[Token(Token = "0x400061F")]
		[FieldOffset(Offset = "0x18")]
		public int <>3__stops;

		// Token: 0x04000620 RID: 1568
		[Token(Token = "0x4000620")]
		[FieldOffset(Offset = "0x1C")]
		private float min;

		// Token: 0x04000621 RID: 1569
		[Token(Token = "0x4000621")]
		[FieldOffset(Offset = "0x20")]
		public float <>3__min;

		// Token: 0x04000622 RID: 1570
		[Token(Token = "0x4000622")]
		[FieldOffset(Offset = "0x24")]
		private float max;

		// Token: 0x04000623 RID: 1571
		[Token(Token = "0x4000623")]
		[FieldOffset(Offset = "0x28")]
		public float <>3__max;

		// Token: 0x04000624 RID: 1572
		[Token(Token = "0x4000624")]
		[FieldOffset(Offset = "0x2C")]
		private float <step>5__2;

		// Token: 0x04000625 RID: 1573
		[Token(Token = "0x4000625")]
		[FieldOffset(Offset = "0x30")]
		private float <i>5__3;
	}
}
