using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020002A2 RID: 674
[Token(Token = "0x20002A2")]
public class PrivacyPolicyScreen : MonoBehaviour
{
	// Token: 0x17000241 RID: 577
	// (get) Token: 0x06000EE9 RID: 3817 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000241")]
	public OpenHyperlinks HyperLinkText
	{
		[Token(Token = "0x6000EE9")]
		[Address(RVA = "0x273EA0", Offset = "0x2732A0", VA = "0x10273EA0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000EEA RID: 3818 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EEA")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680")]
	public void Start()
	{
	}

	// Token: 0x06000EEB RID: 3819 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EEB")]
	[Address(RVA = "0x50F240", Offset = "0x50E640", VA = "0x1050F240")]
	private void OnDisable()
	{
	}

	// Token: 0x06000EEC RID: 3820 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EEC")]
	[Address(RVA = "0x50F860", Offset = "0x50EC60", VA = "0x1050F860")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE5480", Offset = "0xE4880")]
	public IEnumerator Show()
	{
		return null;
	}

	// Token: 0x06000EED RID: 3821 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EED")]
	[Address(RVA = "0x50F0C0", Offset = "0x50E4C0", VA = "0x1050F0C0")]
	private void DestroyGOs(ControllerUiElementsState menu)
	{
	}

	// Token: 0x06000EEE RID: 3822 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EEE")]
	[Address(RVA = "0x50EEB0", Offset = "0x50E2B0", VA = "0x1050EEB0")]
	private void DecomposePrivacyPolicyText(string text)
	{
	}

	// Token: 0x06000EEF RID: 3823 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EEF")]
	[Address(RVA = "0x50F2E0", Offset = "0x50E6E0", VA = "0x1050F2E0")]
	private void OnNewSelection()
	{
	}

	// Token: 0x06000EF0 RID: 3824 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EF0")]
	[Address(RVA = "0x50F330", Offset = "0x50E730", VA = "0x1050F330")]
	public void RecomposePrivacyPolicyText()
	{
	}

	// Token: 0x06000EF1 RID: 3825 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EF1")]
	[Address(RVA = "0x50F2F0", Offset = "0x50E6F0", VA = "0x1050F2F0")]
	public void OnTextUpdated()
	{
	}

	// Token: 0x06000EF2 RID: 3826 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EF2")]
	[Address(RVA = "0x50EE30", Offset = "0x50E230", VA = "0x1050EE30")]
	public void Close()
	{
	}

	// Token: 0x06000EF3 RID: 3827 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EF3")]
	[Address(RVA = "0x50F8B0", Offset = "0x50ECB0", VA = "0x1050F8B0")]
	public PrivacyPolicyScreen()
	{
	}

	// Token: 0x04000EF9 RID: 3833
	[Token(Token = "0x4000EF9")]
	[FieldOffset(Offset = "0xC")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xDD8F0", Offset = "0xDCCF0")]
	public UiElement BackButton;

	// Token: 0x04000EFA RID: 3834
	[Token(Token = "0x4000EFA")]
	[FieldOffset(Offset = "0x10")]
	public UiElement ManageDataButton;

	// Token: 0x04000EFB RID: 3835
	[Token(Token = "0x4000EFB")]
	[FieldOffset(Offset = "0x14")]
	public OpenHyperlinks DefaultHyperlinkText;

	// Token: 0x04000EFC RID: 3836
	[Token(Token = "0x4000EFC")]
	[FieldOffset(Offset = "0x18")]
	public OpenHyperlinks PlayStationHyperlinkText;

	// Token: 0x04000EFD RID: 3837
	[Token(Token = "0x4000EFD")]
	[FieldOffset(Offset = "0x1C")]
	public TextMeshPro PlayStationEULAText;

	// Token: 0x04000EFE RID: 3838
	[Token(Token = "0x4000EFE")]
	[FieldOffset(Offset = "0x20")]
	private List<ITextPart> textConstituents;

	// Token: 0x04000EFF RID: 3839
	[Token(Token = "0x4000EFF")]
	[FieldOffset(Offset = "0x24")]
	private List<SelectableHyperLink> selectableHyperLinks;

	// Token: 0x020002A3 RID: 675
	[Token(Token = "0x20002A3")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <Show>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000EF4 RID: 3828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EF4")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <Show>d__11(int <>1__state)
		{
		}

		// Token: 0x06000EF5 RID: 3829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EF5")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000EF6 RID: 3830 RVA: 0x000059D0 File Offset: 0x00003BD0
		[Token(Token = "0x6000EF6")]
		[Address(RVA = "0x798AB0", Offset = "0x797EB0", VA = "0x10798AB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000EF7 RID: 3831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000242")]
		private object Current
		{
			[Token(Token = "0x6000EF7")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000EF8 RID: 3832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EF8")]
		[Address(RVA = "0x798D80", Offset = "0x798180", VA = "0x10798D80", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000EF9 RID: 3833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000243")]
		private object Current
		{
			[Token(Token = "0x6000EF9")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000F00 RID: 3840
		[Token(Token = "0x4000F00")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000F01 RID: 3841
		[Token(Token = "0x4000F01")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000F02 RID: 3842
		[Token(Token = "0x4000F02")]
		[FieldOffset(Offset = "0x10")]
		public PrivacyPolicyScreen <>4__this;
	}
}
