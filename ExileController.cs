using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000135 RID: 309
[Token(Token = "0x2000135")]
public class ExileController : MonoBehaviour
{
	// Token: 0x0600072D RID: 1837 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600072D")]
	[Address(RVA = "0x47C000", Offset = "0x47B400", VA = "0x1047C000")]
	private void Awake()
	{
	}

	// Token: 0x0600072E RID: 1838 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600072E")]
	[Address(RVA = "0x47C040", Offset = "0x47B440", VA = "0x1047C040")]
	public void Begin(GameData.PlayerInfo exiled, bool tie)
	{
	}

	// Token: 0x0600072F RID: 1839 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600072F")]
	[Address(RVA = "0x47BFA0", Offset = "0x47B3A0", VA = "0x1047BFA0", Slot = "4")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDEC70", Offset = "0xDE070")]
	protected virtual IEnumerator Animate()
	{
		return null;
	}

	// Token: 0x06000730 RID: 1840 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000730")]
	[Address(RVA = "0x47CBD0", Offset = "0x47BFD0", VA = "0x1047CBD0")]
	protected void WrapUp()
	{
	}

	// Token: 0x06000731 RID: 1841 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000731")]
	[Address(RVA = "0x47C9A0", Offset = "0x47BDA0", VA = "0x1047C9A0")]
	protected void ReEnableGameplay()
	{
	}

	// Token: 0x06000732 RID: 1842 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000732")]
	[Address(RVA = "0x47CB80", Offset = "0x47BF80", VA = "0x1047CB80")]
	private void SoundDynamics(AudioSource source, float dt)
	{
	}

	// Token: 0x06000733 RID: 1843 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000733")]
	[Address(RVA = "0x47CCF0", Offset = "0x47C0F0", VA = "0x1047CCF0")]
	public ExileController()
	{
	}

	// Token: 0x0400072B RID: 1835
	[Token(Token = "0x400072B")]
	[FieldOffset(Offset = "0x0")]
	public static ExileController Instance;

	// Token: 0x0400072C RID: 1836
	[Token(Token = "0x400072C")]
	[FieldOffset(Offset = "0xC")]
	public TextMeshPro ImpostorText;

	// Token: 0x0400072D RID: 1837
	[Token(Token = "0x400072D")]
	[FieldOffset(Offset = "0x10")]
	public TextMeshPro Text;

	// Token: 0x0400072E RID: 1838
	[Token(Token = "0x400072E")]
	[FieldOffset(Offset = "0x14")]
	public PoolablePlayer Player;

	// Token: 0x0400072F RID: 1839
	[Token(Token = "0x400072F")]
	[FieldOffset(Offset = "0x18")]
	public AnimationCurve LerpCurve;

	// Token: 0x04000730 RID: 1840
	[Token(Token = "0x4000730")]
	[FieldOffset(Offset = "0x1C")]
	public float Duration;

	// Token: 0x04000731 RID: 1841
	[Token(Token = "0x4000731")]
	[FieldOffset(Offset = "0x20")]
	public AudioClip TextSound;

	// Token: 0x04000732 RID: 1842
	[Token(Token = "0x4000732")]
	[FieldOffset(Offset = "0x24")]
	public AudioClip EjectSound;

	// Token: 0x04000733 RID: 1843
	[Token(Token = "0x4000733")]
	[FieldOffset(Offset = "0x28")]
	protected string completeString;

	// Token: 0x04000734 RID: 1844
	[Token(Token = "0x4000734")]
	[FieldOffset(Offset = "0x2C")]
	protected GameData.PlayerInfo exiled;

	// Token: 0x04000735 RID: 1845
	[Token(Token = "0x4000735")]
	[FieldOffset(Offset = "0x30")]
	private SpecialInputHandler specialInputHandler;

	// Token: 0x02000136 RID: 310
	[Token(Token = "0x2000136")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000735 RID: 1845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000735")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x00003E40 File Offset: 0x00002040
		[Token(Token = "0x6000736")]
		[Address(RVA = "0x78D1B0", Offset = "0x78C5B0", VA = "0x1078D1B0")]
		internal bool <Begin>b__12_0(GameData.PlayerInfo p)
		{
			return default(bool);
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x00003E58 File Offset: 0x00002058
		[Token(Token = "0x6000737")]
		[Address(RVA = "0x3CA230", Offset = "0x3C9630", VA = "0x103CA230")]
		internal bool <Begin>b__12_1(GameData.PlayerInfo p)
		{
			return default(bool);
		}

		// Token: 0x04000736 RID: 1846
		[Token(Token = "0x4000736")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ExileController.<>c <>9;

		// Token: 0x04000737 RID: 1847
		[Token(Token = "0x4000737")]
		[FieldOffset(Offset = "0x4")]
		public static Func<GameData.PlayerInfo, bool> <>9__12_0;

		// Token: 0x04000738 RID: 1848
		[Token(Token = "0x4000738")]
		[FieldOffset(Offset = "0x8")]
		public static Func<GameData.PlayerInfo, bool> <>9__12_1;
	}

	// Token: 0x02000137 RID: 311
	[Token(Token = "0x2000137")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <Animate>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000738 RID: 1848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000738")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <Animate>d__13(int <>1__state)
		{
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000739")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x00003E70 File Offset: 0x00002070
		[Token(Token = "0x600073A")]
		[Address(RVA = "0x781ED0", Offset = "0x7812D0", VA = "0x10781ED0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600073B RID: 1851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700011A")]
		private object Current
		{
			[Token(Token = "0x600073B")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600073C")]
		[Address(RVA = "0x7826E0", Offset = "0x781AE0", VA = "0x107826E0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x0600073D RID: 1853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700011B")]
		private object Current
		{
			[Token(Token = "0x600073D")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000739 RID: 1849
		[Token(Token = "0x4000739")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x0400073A RID: 1850
		[Token(Token = "0x400073A")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x0400073B RID: 1851
		[Token(Token = "0x400073B")]
		[FieldOffset(Offset = "0x10")]
		public ExileController <>4__this;

		// Token: 0x0400073C RID: 1852
		[Token(Token = "0x400073C")]
		[FieldOffset(Offset = "0x14")]
		private Vector2 <left>5__2;

		// Token: 0x0400073D RID: 1853
		[Token(Token = "0x400073D")]
		[FieldOffset(Offset = "0x1C")]
		private Vector2 <right>5__3;

		// Token: 0x0400073E RID: 1854
		[Token(Token = "0x400073E")]
		[FieldOffset(Offset = "0x24")]
		private float <t>5__4;
	}
}
