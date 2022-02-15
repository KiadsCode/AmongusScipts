using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using PowerTools;
using TMPro;
using UnityEngine;

// Token: 0x02000164 RID: 356
[Token(Token = "0x2000164")]
public class CurrencyEarned : MonoBehaviour
{
	// Token: 0x06000822 RID: 2082 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000822")]
	[Address(RVA = "0x5BD250", Offset = "0x5BC650", VA = "0x105BD250")]
	public void Initialize(ProgressionManager.CurrencyGrantResult grantResult)
	{
	}

	// Token: 0x06000823 RID: 2083 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000823")]
	[Address(RVA = "0x5BD500", Offset = "0x5BC900", VA = "0x105BD500")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDF980", Offset = "0xDED80")]
	public IEnumerator ShowAmount()
	{
		return null;
	}

	// Token: 0x06000824 RID: 2084 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000824")]
	[Address(RVA = "0x5BD550", Offset = "0x5BC950", VA = "0x105BD550")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDF9D0", Offset = "0xDEDD0")]
	public IEnumerator ShowMultiplier()
	{
		return null;
	}

	// Token: 0x06000825 RID: 2085 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000825")]
	[Address(RVA = "0x5BD200", Offset = "0x5BC600", VA = "0x105BD200")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDFA20", Offset = "0xDEE20")]
	public IEnumerator EnterWallet()
	{
		return null;
	}

	// Token: 0x06000826 RID: 2086 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000826")]
	[Address(RVA = "0x5BD490", Offset = "0x5BC890", VA = "0x105BD490")]
	private void OnDisable()
	{
	}

	// Token: 0x06000827 RID: 2087 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000827")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public CurrencyEarned()
	{
	}

	// Token: 0x06000829 RID: 2089 RVA: 0x00004128 File Offset: 0x00002328
	[Token(Token = "0x6000829")]
	[Address(RVA = "0x5BD5A0", Offset = "0x5BC9A0", VA = "0x105BD5A0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private bool <ShowMultiplier>b__18_0(float m)
	{
		return default(bool);
	}

	// Token: 0x0400082E RID: 2094
	[Token(Token = "0x400082E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly float[] PotentialMultipliers;

	// Token: 0x0400082F RID: 2095
	[Token(Token = "0x400082F")]
	[FieldOffset(Offset = "0xC")]
	public Sprite BeansIcon;

	// Token: 0x04000830 RID: 2096
	[Token(Token = "0x4000830")]
	[FieldOffset(Offset = "0x10")]
	public SpriteRenderer Icon;

	// Token: 0x04000831 RID: 2097
	[Token(Token = "0x4000831")]
	[FieldOffset(Offset = "0x14")]
	public TextMeshPro AmountEarnedNowText;

	// Token: 0x04000832 RID: 2098
	[Token(Token = "0x4000832")]
	[FieldOffset(Offset = "0x18")]
	public TextMeshPro WalletCountText;

	// Token: 0x04000833 RID: 2099
	[Token(Token = "0x4000833")]
	[FieldOffset(Offset = "0x1C")]
	public TextMeshPro NameText;

	// Token: 0x04000834 RID: 2100
	[Token(Token = "0x4000834")]
	[FieldOffset(Offset = "0x20")]
	public GameObject MultiplierContainer;

	// Token: 0x04000835 RID: 2101
	[Token(Token = "0x4000835")]
	[FieldOffset(Offset = "0x24")]
	public TextMeshPro[] MultiplierTexts;

	// Token: 0x04000836 RID: 2102
	[Token(Token = "0x4000836")]
	[FieldOffset(Offset = "0x28")]
	public SpriteAnim Animator;

	// Token: 0x04000837 RID: 2103
	[Token(Token = "0x4000837")]
	[FieldOffset(Offset = "0x2C")]
	public AnimationClip ShowAmountAnimation;

	// Token: 0x04000838 RID: 2104
	[Token(Token = "0x4000838")]
	[FieldOffset(Offset = "0x30")]
	public AnimationClip EnterWalletAnimation;

	// Token: 0x04000839 RID: 2105
	[Token(Token = "0x4000839")]
	[FieldOffset(Offset = "0x34")]
	public AudioClip ShowAmountSound;

	// Token: 0x0400083A RID: 2106
	[Token(Token = "0x400083A")]
	[FieldOffset(Offset = "0x38")]
	public AudioClip EnterWalletSound;

	// Token: 0x0400083B RID: 2107
	[Token(Token = "0x400083B")]
	[FieldOffset(Offset = "0x3C")]
	public AudioClip MultiplierLoopSound;

	// Token: 0x0400083C RID: 2108
	[Token(Token = "0x400083C")]
	[FieldOffset(Offset = "0x40")]
	public AudioClip MultiplierEndSound;

	// Token: 0x0400083D RID: 2109
	[Token(Token = "0x400083D")]
	[FieldOffset(Offset = "0x44")]
	private ProgressionManager.CurrencyGrantResult grantResult;

	// Token: 0x02000165 RID: 357
	[Token(Token = "0x2000165")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <ShowAmount>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600082A RID: 2090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600082A")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <ShowAmount>d__17(int <>1__state)
		{
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600082B")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x00004140 File Offset: 0x00002340
		[Token(Token = "0x600082C")]
		[Address(RVA = "0x78B9F0", Offset = "0x78ADF0", VA = "0x1078B9F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x0600082D RID: 2093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700013A")]
		private object Current
		{
			[Token(Token = "0x600082D")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600082E")]
		[Address(RVA = "0x78BB40", Offset = "0x78AF40", VA = "0x1078BB40", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x0600082F RID: 2095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700013B")]
		private object Current
		{
			[Token(Token = "0x600082F")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400083E RID: 2110
		[Token(Token = "0x400083E")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x0400083F RID: 2111
		[Token(Token = "0x400083F")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000840 RID: 2112
		[Token(Token = "0x4000840")]
		[FieldOffset(Offset = "0x10")]
		public CurrencyEarned <>4__this;
	}

	// Token: 0x02000166 RID: 358
	[Token(Token = "0x2000166")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <ShowMultiplier>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000830 RID: 2096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000830")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <ShowMultiplier>d__18(int <>1__state)
		{
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000831")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x00004158 File Offset: 0x00002358
		[Token(Token = "0x6000832")]
		[Address(RVA = "0x78BB70", Offset = "0x78AF70", VA = "0x1078BB70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000833 RID: 2099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700013C")]
		private object Current
		{
			[Token(Token = "0x6000833")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000834")]
		[Address(RVA = "0x78C440", Offset = "0x78B840", VA = "0x1078C440", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000835 RID: 2101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700013D")]
		private object Current
		{
			[Token(Token = "0x6000835")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000841 RID: 2113
		[Token(Token = "0x4000841")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000842 RID: 2114
		[Token(Token = "0x4000842")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000843 RID: 2115
		[Token(Token = "0x4000843")]
		[FieldOffset(Offset = "0x10")]
		public CurrencyEarned <>4__this;

		// Token: 0x04000844 RID: 2116
		[Token(Token = "0x4000844")]
		[FieldOffset(Offset = "0x14")]
		private int <desiredIndex>5__2;

		// Token: 0x04000845 RID: 2117
		[Token(Token = "0x4000845")]
		[FieldOffset(Offset = "0x18")]
		private float <timeToSpin>5__3;

		// Token: 0x04000846 RID: 2118
		[Token(Token = "0x4000846")]
		[FieldOffset(Offset = "0x1C")]
		private float <t>5__4;
	}

	// Token: 0x02000167 RID: 359
	[Token(Token = "0x2000167")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <EnterWallet>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000836 RID: 2102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000836")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <EnterWallet>d__19(int <>1__state)
		{
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000837")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x00004170 File Offset: 0x00002370
		[Token(Token = "0x6000838")]
		[Address(RVA = "0x787E90", Offset = "0x787290", VA = "0x10787E90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000839 RID: 2105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700013E")]
		private object Current
		{
			[Token(Token = "0x6000839")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600083A")]
		[Address(RVA = "0x787FE0", Offset = "0x7873E0", VA = "0x10787FE0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x0600083B RID: 2107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700013F")]
		private object Current
		{
			[Token(Token = "0x600083B")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000847 RID: 2119
		[Token(Token = "0x4000847")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000848 RID: 2120
		[Token(Token = "0x4000848")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000849 RID: 2121
		[Token(Token = "0x4000849")]
		[FieldOffset(Offset = "0x10")]
		public CurrencyEarned <>4__this;
	}
}
