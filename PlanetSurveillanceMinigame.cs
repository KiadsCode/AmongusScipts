using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000341 RID: 833
[Token(Token = "0x2000341")]
public class PlanetSurveillanceMinigame : Minigame
{
	// Token: 0x0600122B RID: 4651 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600122B")]
	[Address(RVA = "0x65D960", Offset = "0x65CD60", VA = "0x1065D960", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x0600122C RID: 4652 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600122C")]
	[Address(RVA = "0x65E270", Offset = "0x65D670", VA = "0x1065E270")]
	public void Update()
	{
	}

	// Token: 0x0600122D RID: 4653 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600122D")]
	[Address(RVA = "0x65DE20", Offset = "0x65D220", VA = "0x1065DE20")]
	public void NextCamera(int direction)
	{
	}

	// Token: 0x0600122E RID: 4654 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600122E")]
	[Address(RVA = "0x65E220", Offset = "0x65D620", VA = "0x1065E220")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE7A90", Offset = "0xE6E90")]
	private IEnumerator PulseStatic()
	{
		return null;
	}

	// Token: 0x0600122F RID: 4655 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600122F")]
	[Address(RVA = "0x65DD80", Offset = "0x65D180", VA = "0x1065DD80", Slot = "6")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE7AE0", Offset = "0xE6EE0")]
	protected override IEnumerator CoAnimateOpen()
	{
		return null;
	}

	// Token: 0x06001230 RID: 4656 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001230")]
	[Address(RVA = "0x65DD30", Offset = "0x65D130", VA = "0x1065DD30")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE7B30", Offset = "0xE6F30")]
	private IEnumerator CoAnimateClose()
	{
		return null;
	}

	// Token: 0x06001231 RID: 4657 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001231")]
	[Address(RVA = "0x65DDD0", Offset = "0x65D1D0", VA = "0x1065DDD0", Slot = "7")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE7B80", Offset = "0xE6F80")]
	protected override IEnumerator CoDestroySelf()
	{
		return null;
	}

	// Token: 0x06001232 RID: 4658 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001232")]
	[Address(RVA = "0x65DCE0", Offset = "0x65D0E0", VA = "0x1065DCE0", Slot = "5")]
	public override void Close()
	{
	}

	// Token: 0x06001233 RID: 4659 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001233")]
	[Address(RVA = "0x65E1F0", Offset = "0x65D5F0", VA = "0x1065E1F0")]
	public void OnDestroy()
	{
	}

	// Token: 0x06001234 RID: 4660 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001234")]
	[Address(RVA = "0x3AC2A0", Offset = "0x3AB6A0", VA = "0x103AC2A0")]
	public PlanetSurveillanceMinigame()
	{
	}

	// Token: 0x0400124A RID: 4682
	[Token(Token = "0x400124A")]
	[FieldOffset(Offset = "0x30")]
	public Camera Camera;

	// Token: 0x0400124B RID: 4683
	[Token(Token = "0x400124B")]
	[FieldOffset(Offset = "0x34")]
	public GameObject Viewables;

	// Token: 0x0400124C RID: 4684
	[Token(Token = "0x400124C")]
	[FieldOffset(Offset = "0x38")]
	public MeshRenderer ViewPort;

	// Token: 0x0400124D RID: 4685
	[Token(Token = "0x400124D")]
	[FieldOffset(Offset = "0x3C")]
	public TextMeshPro LocationName;

	// Token: 0x0400124E RID: 4686
	[Token(Token = "0x400124E")]
	[FieldOffset(Offset = "0x40")]
	public TextMeshPro SabText;

	// Token: 0x0400124F RID: 4687
	[Token(Token = "0x400124F")]
	[FieldOffset(Offset = "0x44")]
	private RenderTexture texture;

	// Token: 0x04001250 RID: 4688
	[Token(Token = "0x4001250")]
	[FieldOffset(Offset = "0x48")]
	public MeshRenderer FillQuad;

	// Token: 0x04001251 RID: 4689
	[Token(Token = "0x4001251")]
	[FieldOffset(Offset = "0x4C")]
	public Material DefaultMaterial;

	// Token: 0x04001252 RID: 4690
	[Token(Token = "0x4001252")]
	[FieldOffset(Offset = "0x50")]
	public Material StaticMaterial;

	// Token: 0x04001253 RID: 4691
	[Token(Token = "0x4001253")]
	[FieldOffset(Offset = "0x54")]
	private bool isStatic;

	// Token: 0x04001254 RID: 4692
	[Token(Token = "0x4001254")]
	[FieldOffset(Offset = "0x58")]
	private SurvCamera[] survCameras;

	// Token: 0x04001255 RID: 4693
	[Token(Token = "0x4001255")]
	[FieldOffset(Offset = "0x5C")]
	public Transform DotParent;

	// Token: 0x04001256 RID: 4694
	[Token(Token = "0x4001256")]
	[FieldOffset(Offset = "0x60")]
	private SpriteRenderer[] Dots;

	// Token: 0x04001257 RID: 4695
	[Token(Token = "0x4001257")]
	[FieldOffset(Offset = "0x64")]
	public Sprite DotEnabled;

	// Token: 0x04001258 RID: 4696
	[Token(Token = "0x4001258")]
	[FieldOffset(Offset = "0x68")]
	public Sprite DotDisabled;

	// Token: 0x04001259 RID: 4697
	[Token(Token = "0x4001259")]
	[FieldOffset(Offset = "0x6C")]
	private int currentCamera;

	// Token: 0x0400125A RID: 4698
	[Token(Token = "0x400125A")]
	[FieldOffset(Offset = "0x70")]
	public AudioClip ChangeSound;

	// Token: 0x02000342 RID: 834
	[Token(Token = "0x2000342")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <PulseStatic>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001235 RID: 4661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001235")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <PulseStatic>d__20(int <>1__state)
		{
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001236")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x000063D8 File Offset: 0x000045D8
		[Token(Token = "0x6001237")]
		[Address(RVA = "0x798410", Offset = "0x797810", VA = "0x10798410", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06001238 RID: 4664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002B5")]
		private object Current
		{
			[Token(Token = "0x6001238")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001239 RID: 4665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001239")]
		[Address(RVA = "0x798550", Offset = "0x797950", VA = "0x10798550", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x0600123A RID: 4666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002B6")]
		private object Current
		{
			[Token(Token = "0x600123A")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400125B RID: 4699
		[Token(Token = "0x400125B")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x0400125C RID: 4700
		[Token(Token = "0x400125C")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x0400125D RID: 4701
		[Token(Token = "0x400125D")]
		[FieldOffset(Offset = "0x10")]
		public PlanetSurveillanceMinigame <>4__this;
	}

	// Token: 0x02000343 RID: 835
	[Token(Token = "0x2000343")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoAnimateOpen>d__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600123B RID: 4667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600123B")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoAnimateOpen>d__21(int <>1__state)
		{
		}

		// Token: 0x0600123C RID: 4668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600123C")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600123D RID: 4669 RVA: 0x000063F0 File Offset: 0x000045F0
		[Token(Token = "0x600123D")]
		[Address(RVA = "0x791500", Offset = "0x790900", VA = "0x10791500", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x0600123E RID: 4670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002B7")]
		private object Current
		{
			[Token(Token = "0x600123E")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600123F RID: 4671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600123F")]
		[Address(RVA = "0x791920", Offset = "0x790D20", VA = "0x10791920", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06001240 RID: 4672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002B8")]
		private object Current
		{
			[Token(Token = "0x6001240")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400125E RID: 4702
		[Token(Token = "0x400125E")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x0400125F RID: 4703
		[Token(Token = "0x400125F")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04001260 RID: 4704
		[Token(Token = "0x4001260")]
		[FieldOffset(Offset = "0x10")]
		public PlanetSurveillanceMinigame <>4__this;

		// Token: 0x04001261 RID: 4705
		[Token(Token = "0x4001261")]
		[FieldOffset(Offset = "0x14")]
		private float <timer>5__2;
	}

	// Token: 0x02000344 RID: 836
	[Token(Token = "0x2000344")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoAnimateClose>d__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001241 RID: 4673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001241")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoAnimateClose>d__22(int <>1__state)
		{
		}

		// Token: 0x06001242 RID: 4674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001242")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001243 RID: 4675 RVA: 0x00006408 File Offset: 0x00004608
		[Token(Token = "0x6001243")]
		[Address(RVA = "0x791260", Offset = "0x790660", VA = "0x10791260", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06001244 RID: 4676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002B9")]
		private object Current
		{
			[Token(Token = "0x6001244")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001245 RID: 4677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001245")]
		[Address(RVA = "0x7914D0", Offset = "0x7908D0", VA = "0x107914D0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06001246 RID: 4678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002BA")]
		private object Current
		{
			[Token(Token = "0x6001246")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04001262 RID: 4706
		[Token(Token = "0x4001262")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04001263 RID: 4707
		[Token(Token = "0x4001263")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04001264 RID: 4708
		[Token(Token = "0x4001264")]
		[FieldOffset(Offset = "0x10")]
		public PlanetSurveillanceMinigame <>4__this;

		// Token: 0x04001265 RID: 4709
		[Token(Token = "0x4001265")]
		[FieldOffset(Offset = "0x14")]
		private float <timer>5__2;
	}

	// Token: 0x02000345 RID: 837
	[Token(Token = "0x2000345")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoDestroySelf>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001247 RID: 4679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001247")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoDestroySelf>d__23(int <>1__state)
		{
		}

		// Token: 0x06001248 RID: 4680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001248")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001249 RID: 4681 RVA: 0x00006420 File Offset: 0x00004620
		[Token(Token = "0x6001249")]
		[Address(RVA = "0x792840", Offset = "0x791C40", VA = "0x10792840", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x0600124A RID: 4682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002BB")]
		private object Current
		{
			[Token(Token = "0x600124A")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600124B RID: 4683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600124B")]
		[Address(RVA = "0x792910", Offset = "0x791D10", VA = "0x10792910", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x0600124C RID: 4684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002BC")]
		private object Current
		{
			[Token(Token = "0x600124C")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04001266 RID: 4710
		[Token(Token = "0x4001266")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04001267 RID: 4711
		[Token(Token = "0x4001267")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04001268 RID: 4712
		[Token(Token = "0x4001268")]
		[FieldOffset(Offset = "0x10")]
		public PlanetSurveillanceMinigame <>4__this;
	}
}
