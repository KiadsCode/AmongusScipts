using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using PowerTools;
using UnityEngine;

// Token: 0x0200013E RID: 318
[Token(Token = "0x200013E")]
public class PbExileController : ExileController
{
	// Token: 0x06000760 RID: 1888 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000760")]
	[Address(RVA = "0x659850", Offset = "0x658C50", VA = "0x10659850", Slot = "4")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDF0B0", Offset = "0xDE4B0")]
	protected override IEnumerator Animate()
	{
		return null;
	}

	// Token: 0x06000761 RID: 1889 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000761")]
	[Address(RVA = "0x6598A0", Offset = "0x658CA0", VA = "0x106598A0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDF130", Offset = "0xDE530")]
	private IEnumerator HandleText()
	{
		return null;
	}

	// Token: 0x06000762 RID: 1890 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000762")]
	[Address(RVA = "0x6598F0", Offset = "0x658CF0", VA = "0x106598F0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDF1E0", Offset = "0xDE5E0")]
	private IEnumerator PlayerFall()
	{
		return null;
	}

	// Token: 0x06000763 RID: 1891 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000763")]
	[Address(RVA = "0x659940", Offset = "0x658D40", VA = "0x10659940")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDF260", Offset = "0xDE660")]
	private IEnumerator PlayerSpin()
	{
		return null;
	}

	// Token: 0x06000764 RID: 1892 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000764")]
	[Address(RVA = "0x659990", Offset = "0x658D90", VA = "0x10659990")]
	public PbExileController()
	{
	}

	// Token: 0x0400076B RID: 1899
	[Token(Token = "0x400076B")]
	[FieldOffset(Offset = "0x34")]
	public SpriteRenderer HandSlot;

	// Token: 0x0400076C RID: 1900
	[Token(Token = "0x400076C")]
	[FieldOffset(Offset = "0x38")]
	public Sprite BadHand;

	// Token: 0x0400076D RID: 1901
	[Token(Token = "0x400076D")]
	[FieldOffset(Offset = "0x3C")]
	public Sprite GoodHand;

	// Token: 0x0400076E RID: 1902
	[Token(Token = "0x400076E")]
	[FieldOffset(Offset = "0x40")]
	public AudioClip SplashSound;

	// Token: 0x0400076F RID: 1903
	[Token(Token = "0x400076F")]
	[FieldOffset(Offset = "0x44")]
	public SpriteAnim Sploosher;

	// Token: 0x04000770 RID: 1904
	[Token(Token = "0x4000770")]
	[FieldOffset(Offset = "0x48")]
	public AnimationClip Sploosh;

	// Token: 0x0200013F RID: 319
	[Token(Token = "0x200013F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <Animate>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000765 RID: 1893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000765")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <Animate>d__6(int <>1__state)
		{
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000766")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x00003EE8 File Offset: 0x000020E8
		[Token(Token = "0x6000767")]
		[Address(RVA = "0x78FD70", Offset = "0x78F170", VA = "0x1078FD70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000768 RID: 1896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000124")]
		private object Current
		{
			[Token(Token = "0x6000768")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000769")]
		[Address(RVA = "0x7901D0", Offset = "0x78F5D0", VA = "0x107901D0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x0600076A RID: 1898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000125")]
		private object Current
		{
			[Token(Token = "0x600076A")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000771 RID: 1905
		[Token(Token = "0x4000771")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000772 RID: 1906
		[Token(Token = "0x4000772")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000773 RID: 1907
		[Token(Token = "0x4000773")]
		[FieldOffset(Offset = "0x10")]
		public PbExileController <>4__this;
	}

	// Token: 0x02000140 RID: 320
	[Token(Token = "0x2000140")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <HandleText>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600076B RID: 1899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600076B")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <HandleText>d__7(int <>1__state)
		{
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600076C")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x00003F00 File Offset: 0x00002100
		[Token(Token = "0x600076D")]
		[Address(RVA = "0x7974B0", Offset = "0x7968B0", VA = "0x107974B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x0600076E RID: 1902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000126")]
		private object Current
		{
			[Token(Token = "0x600076E")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600076F")]
		[Address(RVA = "0x797740", Offset = "0x796B40", VA = "0x10797740", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000770 RID: 1904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000127")]
		private object Current
		{
			[Token(Token = "0x6000770")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000774 RID: 1908
		[Token(Token = "0x4000774")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000775 RID: 1909
		[Token(Token = "0x4000775")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000776 RID: 1910
		[Token(Token = "0x4000776")]
		[FieldOffset(Offset = "0x10")]
		public PbExileController <>4__this;

		// Token: 0x04000777 RID: 1911
		[Token(Token = "0x4000777")]
		[FieldOffset(Offset = "0x14")]
		private float <newDur>5__2;

		// Token: 0x04000778 RID: 1912
		[Token(Token = "0x4000778")]
		[FieldOffset(Offset = "0x18")]
		private float <t>5__3;
	}

	// Token: 0x02000141 RID: 321
	[Token(Token = "0x2000141")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <PlayerFall>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000771 RID: 1905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000771")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <PlayerFall>d__8(int <>1__state)
		{
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000772")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x00003F18 File Offset: 0x00002118
		[Token(Token = "0x6000773")]
		[Address(RVA = "0x797770", Offset = "0x796B70", VA = "0x10797770", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000774 RID: 1908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000128")]
		private object Current
		{
			[Token(Token = "0x6000774")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000775")]
		[Address(RVA = "0x797A90", Offset = "0x796E90", VA = "0x10797A90", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000776 RID: 1910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000129")]
		private object Current
		{
			[Token(Token = "0x6000776")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000779 RID: 1913
		[Token(Token = "0x4000779")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x0400077A RID: 1914
		[Token(Token = "0x400077A")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x0400077B RID: 1915
		[Token(Token = "0x400077B")]
		[FieldOffset(Offset = "0x10")]
		public PbExileController <>4__this;

		// Token: 0x0400077C RID: 1916
		[Token(Token = "0x400077C")]
		[FieldOffset(Offset = "0x14")]
		private Vector2 <top>5__2;

		// Token: 0x0400077D RID: 1917
		[Token(Token = "0x400077D")]
		[FieldOffset(Offset = "0x1C")]
		private Vector2 <bottom>5__3;

		// Token: 0x0400077E RID: 1918
		[Token(Token = "0x400077E")]
		[FieldOffset(Offset = "0x24")]
		private bool <started>5__4;

		// Token: 0x0400077F RID: 1919
		[Token(Token = "0x400077F")]
		[FieldOffset(Offset = "0x28")]
		private float <d1>5__5;

		// Token: 0x04000780 RID: 1920
		[Token(Token = "0x4000780")]
		[FieldOffset(Offset = "0x2C")]
		private float <t>5__6;
	}

	// Token: 0x02000142 RID: 322
	[Token(Token = "0x2000142")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass9_0
	{
		// Token: 0x06000777 RID: 1911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000777")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass9_0()
		{
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000778")]
		[Address(RVA = "0x79B030", Offset = "0x79A430", VA = "0x1079B030")]
		internal void <PlayerSpin>b__0(float p)
		{
		}

		// Token: 0x04000781 RID: 1921
		[Token(Token = "0x4000781")]
		[FieldOffset(Offset = "0x8")]
		public PbExileController <>4__this;

		// Token: 0x04000782 RID: 1922
		[Token(Token = "0x4000782")]
		[FieldOffset(Offset = "0xC")]
		public Vector2 bottom;

		// Token: 0x04000783 RID: 1923
		[Token(Token = "0x4000783")]
		[FieldOffset(Offset = "0x14")]
		public Vector2 top;
	}

	// Token: 0x02000143 RID: 323
	[Token(Token = "0x2000143")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <PlayerSpin>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000779 RID: 1913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000779")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <PlayerSpin>d__9(int <>1__state)
		{
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600077A")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x00003F30 File Offset: 0x00002130
		[Token(Token = "0x600077B")]
		[Address(RVA = "0x797D80", Offset = "0x797180", VA = "0x10797D80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x0600077C RID: 1916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700012A")]
		private object Current
		{
			[Token(Token = "0x600077C")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600077D")]
		[Address(RVA = "0x7983E0", Offset = "0x7977E0", VA = "0x107983E0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x0600077E RID: 1918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700012B")]
		private object Current
		{
			[Token(Token = "0x600077E")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000784 RID: 1924
		[Token(Token = "0x4000784")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000785 RID: 1925
		[Token(Token = "0x4000785")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000786 RID: 1926
		[Token(Token = "0x4000786")]
		[FieldOffset(Offset = "0x10")]
		public PbExileController <>4__this;

		// Token: 0x04000787 RID: 1927
		[Token(Token = "0x4000787")]
		[FieldOffset(Offset = "0x14")]
		private PbExileController.<>c__DisplayClass9_0 <>8__1;

		// Token: 0x04000788 RID: 1928
		[Token(Token = "0x4000788")]
		[FieldOffset(Offset = "0x18")]
		private float <d1>5__2;

		// Token: 0x04000789 RID: 1929
		[Token(Token = "0x4000789")]
		[FieldOffset(Offset = "0x1C")]
		private float <d3>5__3;

		// Token: 0x0400078A RID: 1930
		[Token(Token = "0x400078A")]
		[FieldOffset(Offset = "0x20")]
		private float <t>5__4;
	}
}
