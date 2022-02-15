using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000296 RID: 662
[Token(Token = "0x2000296")]
public class AgeGateScreen : MonoBehaviour
{
	// Token: 0x06000EA8 RID: 3752 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EA8")]
	[Address(RVA = "0x543940", Offset = "0x542D40", VA = "0x10543940")]
	private void OnDisable()
	{
	}

	// Token: 0x06000EA9 RID: 3753 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EA9")]
	[Address(RVA = "0x543AC0", Offset = "0x542EC0", VA = "0x10543AC0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE51B0", Offset = "0xE45B0")]
	public IEnumerator Show()
	{
		return null;
	}

	// Token: 0x06000EAA RID: 3754 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EAA")]
	[Address(RVA = "0x543750", Offset = "0x542B50", VA = "0x10543750")]
	public void Close()
	{
	}

	// Token: 0x06000EAB RID: 3755 RVA: 0x00005940 File Offset: 0x00003B40
	[Token(Token = "0x6000EAB")]
	[Address(RVA = "0x5439B0", Offset = "0x542DB0", VA = "0x105439B0")]
	public bool ShakeIfInvalid()
	{
		return default(bool);
	}

	// Token: 0x06000EAC RID: 3756 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EAC")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public AgeGateScreen()
	{
	}

	// Token: 0x04000EBF RID: 3775
	[Token(Token = "0x4000EBF")]
	[FieldOffset(Offset = "0xC")]
	public TextMeshPro monthText;

	// Token: 0x04000EC0 RID: 3776
	[Token(Token = "0x4000EC0")]
	[FieldOffset(Offset = "0x10")]
	public TextMeshPro dayText;

	// Token: 0x04000EC1 RID: 3777
	[Token(Token = "0x4000EC1")]
	[FieldOffset(Offset = "0x14")]
	public TextMeshPro yearText;

	// Token: 0x04000EC2 RID: 3778
	[Token(Token = "0x4000EC2")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xDD8F0", Offset = "0xDCCF0")]
	public UiElement BackButton;

	// Token: 0x04000EC3 RID: 3779
	[Token(Token = "0x4000EC3")]
	[FieldOffset(Offset = "0x1C")]
	public UiElement DefaultSelection;

	// Token: 0x04000EC4 RID: 3780
	[Token(Token = "0x4000EC4")]
	[FieldOffset(Offset = "0x20")]
	public List<UiElement> selectableObjects;

	// Token: 0x02000297 RID: 663
	[Token(Token = "0x2000297")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <Show>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000EAD RID: 3757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EAD")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <Show>d__7(int <>1__state)
		{
		}

		// Token: 0x06000EAE RID: 3758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EAE")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000EAF RID: 3759 RVA: 0x00005958 File Offset: 0x00003B58
		[Token(Token = "0x6000EAF")]
		[Address(RVA = "0x3C9E00", Offset = "0x3C9200", VA = "0x103C9E00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000EB0 RID: 3760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000239")]
		private object Current
		{
			[Token(Token = "0x6000EB0")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000EB1 RID: 3761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EB1")]
		[Address(RVA = "0x3CA000", Offset = "0x3C9400", VA = "0x103CA000", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000EB2 RID: 3762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700023A")]
		private object Current
		{
			[Token(Token = "0x6000EB2")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000EC5 RID: 3781
		[Token(Token = "0x4000EC5")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000EC6 RID: 3782
		[Token(Token = "0x4000EC6")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000EC7 RID: 3783
		[Token(Token = "0x4000EC7")]
		[FieldOffset(Offset = "0x10")]
		public AgeGateScreen <>4__this;
	}
}
