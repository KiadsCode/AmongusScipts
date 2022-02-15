using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

// Token: 0x0200029C RID: 668
[Token(Token = "0x200029C")]
[Attribute(Name = "DefaultExecutionOrder", RVA = "0xE5320", Offset = "0xE4720")]
public class MainMenuManager : MonoBehaviour
{
	// Token: 0x06000ED1 RID: 3793 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ED1")]
	[Address(RVA = "0x6E3830", Offset = "0x6E2C30", VA = "0x106E3830")]
	private void Awake()
	{
	}

	// Token: 0x06000ED2 RID: 3794 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ED2")]
	[Address(RVA = "0x6E3A50", Offset = "0x6E2E50", VA = "0x106E3A50")]
	public void Start()
	{
	}

	// Token: 0x06000ED3 RID: 3795 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000ED3")]
	[Address(RVA = "0x6E3A00", Offset = "0x6E2E00", VA = "0x106E3A00")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE5340", Offset = "0xE4740")]
	private IEnumerator RunStartUp()
	{
		return null;
	}

	// Token: 0x06000ED4 RID: 3796 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ED4")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680")]
	private void CheckAddOns()
	{
	}

	// Token: 0x06000ED5 RID: 3797 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ED5")]
	[Address(RVA = "0x6E38B0", Offset = "0x6E2CB0", VA = "0x106E38B0")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000ED6 RID: 3798 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ED6")]
	[Address(RVA = "0x6E3B50", Offset = "0x6E2F50", VA = "0x106E3B50")]
	public void TransitionToInventory()
	{
	}

	// Token: 0x06000ED7 RID: 3799 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ED7")]
	[Address(RVA = "0x6E3C80", Offset = "0x6E3080", VA = "0x106E3C80")]
	public MainMenuManager()
	{
	}

	// Token: 0x04000EDD RID: 3805
	[Token(Token = "0x4000EDD")]
	[FieldOffset(Offset = "0xC")]
	public AdDataCollectScreen AdsPolicy;

	// Token: 0x04000EDE RID: 3806
	[Token(Token = "0x4000EDE")]
	[FieldOffset(Offset = "0x10")]
	public AnnouncementPopUp Announcement;

	// Token: 0x04000EDF RID: 3807
	[Token(Token = "0x4000EDF")]
	[FieldOffset(Offset = "0x14")]
	public GooglePlayAssetHandler googlePlayAssetHandler;

	// Token: 0x04000EE0 RID: 3808
	[Token(Token = "0x4000EE0")]
	[FieldOffset(Offset = "0x18")]
	public AssetReference HatManagerRef;

	// Token: 0x04000EE1 RID: 3809
	[Token(Token = "0x4000EE1")]
	[FieldOffset(Offset = "0x1C")]
	public AssetReference CosmicubeManagerRef;

	// Token: 0x04000EE2 RID: 3810
	[Token(Token = "0x4000EE2")]
	[FieldOffset(Offset = "0x20")]
	public PlayerCustomizationMenu playerCustomizationPrefab;

	// Token: 0x04000EE3 RID: 3811
	[Token(Token = "0x4000EE3")]
	[FieldOffset(Offset = "0x24")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xDD8F0", Offset = "0xDCCF0")]
	public UiElement DefaultButtonSelected;

	// Token: 0x04000EE4 RID: 3812
	[Token(Token = "0x4000EE4")]
	[FieldOffset(Offset = "0x28")]
	public List<UiElement> ControllerSelectable;

	// Token: 0x04000EE5 RID: 3813
	[Token(Token = "0x4000EE5")]
	[FieldOffset(Offset = "0x2C")]
	public List<PassiveButton> disableOnStartup;

	// Token: 0x0200029D RID: 669
	[Token(Token = "0x200029D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000ED9 RID: 3801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000ED9")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x06000EDA RID: 3802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EDA")]
		[Address(RVA = "0x5B4B20", Offset = "0x5B3F20", VA = "0x105B4B20")]
		internal void <RunStartUp>b__11_0()
		{
		}

		// Token: 0x04000EE6 RID: 3814
		[Token(Token = "0x4000EE6")]
		[FieldOffset(Offset = "0x0")]
		public static readonly MainMenuManager.<>c <>9;

		// Token: 0x04000EE7 RID: 3815
		[Token(Token = "0x4000EE7")]
		[FieldOffset(Offset = "0x4")]
		public static Action <>9__11_0;
	}

	// Token: 0x0200029E RID: 670
	[Token(Token = "0x200029E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <RunStartUp>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000EDB RID: 3803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EDB")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <RunStartUp>d__11(int <>1__state)
		{
		}

		// Token: 0x06000EDC RID: 3804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EDC")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000EDD RID: 3805 RVA: 0x000059B8 File Offset: 0x00003BB8
		[Token(Token = "0x6000EDD")]
		[Address(RVA = "0x5B3AD0", Offset = "0x5B2ED0", VA = "0x105B3AD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000EDE RID: 3806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700023F")]
		private object Current
		{
			[Token(Token = "0x6000EDE")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000EDF RID: 3807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EDF")]
		[Address(RVA = "0x5B4000", Offset = "0x5B3400", VA = "0x105B4000", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000EE0 RID: 3808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000240")]
		private object Current
		{
			[Token(Token = "0x6000EE0")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000EE8 RID: 3816
		[Token(Token = "0x4000EE8")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000EE9 RID: 3817
		[Token(Token = "0x4000EE9")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000EEA RID: 3818
		[Token(Token = "0x4000EEA")]
		[FieldOffset(Offset = "0x10")]
		public MainMenuManager <>4__this;

		// Token: 0x04000EEB RID: 3819
		[Token(Token = "0x4000EEB")]
		[FieldOffset(Offset = "0x14")]
		private AsyncOperationHandle<GameObject> <hatManager>5__2;

		// Token: 0x04000EEC RID: 3820
		[Token(Token = "0x4000EEC")]
		[FieldOffset(Offset = "0x20")]
		private AsyncOperationHandle<GameObject> <cosmicubeManager>5__3;
	}
}
