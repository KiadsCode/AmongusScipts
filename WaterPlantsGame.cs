using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020004E0 RID: 1248
[Token(Token = "0x20004E0")]
public class WaterPlantsGame : Minigame
{
	// Token: 0x06001AA6 RID: 6822 RVA: 0x00008598 File Offset: 0x00006798
	[Token(Token = "0x6001AA6")]
	[Address(RVA = "0x7B5C00", Offset = "0x7B5000", VA = "0x107B5C00")]
	private bool Watered(int x)
	{
		return default(bool);
	}

	// Token: 0x06001AA7 RID: 6823 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AA7")]
	[Address(RVA = "0x7B5C40", Offset = "0x7B5040", VA = "0x107B5C40")]
	private void Watered(int x, bool b)
	{
	}

	// Token: 0x06001AA8 RID: 6824 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AA8")]
	[Address(RVA = "0x7B5170", Offset = "0x7B4570", VA = "0x107B5170", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x06001AA9 RID: 6825 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AA9")]
	[Address(RVA = "0x7B57E0", Offset = "0x7B4BE0", VA = "0x107B57E0")]
	private void Update()
	{
	}

	// Token: 0x06001AAA RID: 6826 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AAA")]
	[Address(RVA = "0x7B5690", Offset = "0x7B4A90", VA = "0x107B5690")]
	public void PickWaterCan()
	{
	}

	// Token: 0x06001AAB RID: 6827 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AAB")]
	[Address(RVA = "0x7B5640", Offset = "0x7B4A40", VA = "0x107B5640")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE0E60", Offset = "0xE0260")]
	private IEnumerator CoPickWaterCan()
	{
		return null;
	}

	// Token: 0x06001AAC RID: 6828 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AAC")]
	[Address(RVA = "0x7B59A0", Offset = "0x7B4DA0", VA = "0x107B59A0")]
	public void WaterPlant(int num)
	{
	}

	// Token: 0x06001AAD RID: 6829 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AAD")]
	[Address(RVA = "0x7B55E0", Offset = "0x7B49E0", VA = "0x107B55E0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE0F00", Offset = "0xE0300")]
	private IEnumerator CoGrowPlant(int num)
	{
		return null;
	}

	// Token: 0x06001AAE RID: 6830 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AAE")]
	[Address(RVA = "0x7B5C80", Offset = "0x7B5080", VA = "0x107B5C80")]
	public WaterPlantsGame()
	{
	}

	// Token: 0x04001AC4 RID: 6852
	[Token(Token = "0x4001AC4")]
	[FieldOffset(Offset = "0x30")]
	public GameObject stage1;

	// Token: 0x04001AC5 RID: 6853
	[Token(Token = "0x4001AC5")]
	[FieldOffset(Offset = "0x34")]
	public GameObject stage2;

	// Token: 0x04001AC6 RID: 6854
	[Token(Token = "0x4001AC6")]
	[FieldOffset(Offset = "0x38")]
	public AudioClip CanGrabSound;

	// Token: 0x04001AC7 RID: 6855
	[Token(Token = "0x4001AC7")]
	[FieldOffset(Offset = "0x3C")]
	public PassiveButton WaterCan;

	// Token: 0x04001AC8 RID: 6856
	[Token(Token = "0x4001AC8")]
	[FieldOffset(Offset = "0x40")]
	public SpriteRenderer[] Plants;

	// Token: 0x04001AC9 RID: 6857
	[Token(Token = "0x4001AC9")]
	[FieldOffset(Offset = "0x44")]
	public AudioClip WaterPlantSound;

	// Token: 0x04001ACA RID: 6858
	[Token(Token = "0x4001ACA")]
	[FieldOffset(Offset = "0x48")]
	public AudioClip[] PlantGrowSounds;

	// Token: 0x04001ACB RID: 6859
	[Token(Token = "0x4001ACB")]
	[FieldOffset(Offset = "0x4C")]
	public AudioClip[] PlantFinishedSounds;

	// Token: 0x04001ACC RID: 6860
	[Token(Token = "0x4001ACC")]
	[FieldOffset(Offset = "0x50")]
	public TextMeshPro FloatText;

	// Token: 0x04001ACD RID: 6861
	[Token(Token = "0x4001ACD")]
	[FieldOffset(Offset = "0x54")]
	public Transform[] Locations;

	// Token: 0x04001ACE RID: 6862
	[Token(Token = "0x4001ACE")]
	[FieldOffset(Offset = "0x58")]
	public Transform selectorObject;

	// Token: 0x04001ACF RID: 6863
	[Token(Token = "0x4001ACF")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject grabCanSubObject;

	// Token: 0x04001AD0 RID: 6864
	[Token(Token = "0x4001AD0")]
	[FieldOffset(Offset = "0x60")]
	public GameObject holdingCanSubObject;

	// Token: 0x04001AD1 RID: 6865
	[Token(Token = "0x4001AD1")]
	[FieldOffset(Offset = "0x64")]
	public GameObject waterPlantsSubObject;

	// Token: 0x04001AD2 RID: 6866
	[Token(Token = "0x4001AD2")]
	[FieldOffset(Offset = "0x68")]
	private Controller c;

	// Token: 0x04001AD3 RID: 6867
	[Token(Token = "0x4001AD3")]
	[FieldOffset(Offset = "0x6C")]
	public SpriteRenderer[] playerHandObjects;

	// Token: 0x04001AD4 RID: 6868
	[Token(Token = "0x4001AD4")]
	[FieldOffset(Offset = "0x70")]
	public ParticleSystem waterParticles;

	// Token: 0x020004E1 RID: 1249
	[Token(Token = "0x20004E1")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoPickWaterCan>d__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001AAF RID: 6831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AAF")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoPickWaterCan>d__22(int <>1__state)
		{
		}

		// Token: 0x06001AB0 RID: 6832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AB0")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001AB1 RID: 6833 RVA: 0x000085B0 File Offset: 0x000067B0
		[Token(Token = "0x6001AB1")]
		[Address(RVA = "0x12FF090", Offset = "0x12FE490", VA = "0x112FF090", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06001AB2 RID: 6834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003E4")]
		private object Current
		{
			[Token(Token = "0x6001AB2")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001AB3 RID: 6835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AB3")]
		[Address(RVA = "0x12FF4D0", Offset = "0x12FE8D0", VA = "0x112FF4D0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06001AB4 RID: 6836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003E5")]
		private object Current
		{
			[Token(Token = "0x6001AB4")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04001AD5 RID: 6869
		[Token(Token = "0x4001AD5")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04001AD6 RID: 6870
		[Token(Token = "0x4001AD6")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04001AD7 RID: 6871
		[Token(Token = "0x4001AD7")]
		[FieldOffset(Offset = "0x10")]
		public WaterPlantsGame <>4__this;
	}

	// Token: 0x020004E2 RID: 1250
	[Token(Token = "0x20004E2")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoGrowPlant>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001AB5 RID: 6837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AB5")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoGrowPlant>d__24(int <>1__state)
		{
		}

		// Token: 0x06001AB6 RID: 6838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AB6")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001AB7 RID: 6839 RVA: 0x000085C8 File Offset: 0x000067C8
		[Token(Token = "0x6001AB7")]
		[Address(RVA = "0x12FE8E0", Offset = "0x12FDCE0", VA = "0x112FE8E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06001AB8 RID: 6840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003E6")]
		private object Current
		{
			[Token(Token = "0x6001AB8")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001AB9 RID: 6841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AB9")]
		[Address(RVA = "0x12FEED0", Offset = "0x12FE2D0", VA = "0x112FEED0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06001ABA RID: 6842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003E7")]
		private object Current
		{
			[Token(Token = "0x6001ABA")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04001AD8 RID: 6872
		[Token(Token = "0x4001AD8")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04001AD9 RID: 6873
		[Token(Token = "0x4001AD9")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04001ADA RID: 6874
		[Token(Token = "0x4001ADA")]
		[FieldOffset(Offset = "0x10")]
		public WaterPlantsGame <>4__this;

		// Token: 0x04001ADB RID: 6875
		[Token(Token = "0x4001ADB")]
		[FieldOffset(Offset = "0x14")]
		public int num;

		// Token: 0x04001ADC RID: 6876
		[Token(Token = "0x4001ADC")]
		[FieldOffset(Offset = "0x18")]
		private SpriteRenderer <plant>5__2;

		// Token: 0x04001ADD RID: 6877
		[Token(Token = "0x4001ADD")]
		[FieldOffset(Offset = "0x1C")]
		private float <timer>5__3;
	}
}
