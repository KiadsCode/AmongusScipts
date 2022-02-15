using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000379 RID: 889
[Token(Token = "0x2000379")]
public class ControllerNavMenu : MonoBehaviour
{
	// Token: 0x06001333 RID: 4915 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001333")]
	[Address(RVA = "0x7FB2A0", Offset = "0x7FA6A0", VA = "0x107FB2A0")]
	private void Start()
	{
	}

	// Token: 0x06001334 RID: 4916 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001334")]
	[Address(RVA = "0x7FAE10", Offset = "0x7FA210", VA = "0x107FAE10")]
	private void OnEnable()
	{
	}

	// Token: 0x06001335 RID: 4917 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001335")]
	[Address(RVA = "0x7FAFB0", Offset = "0x7FA3B0", VA = "0x107FAFB0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDDC10", Offset = "0xDD010")]
	private IEnumerator OpenCoroutine()
	{
		return null;
	}

	// Token: 0x06001336 RID: 4918 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001336")]
	[Address(RVA = "0x7FAD70", Offset = "0x7FA170", VA = "0x107FAD70")]
	private void OnDisable()
	{
	}

	// Token: 0x06001337 RID: 4919 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001337")]
	[Address(RVA = "0x7FB000", Offset = "0x7FA400", VA = "0x107FB000")]
	public void OpenMenu(bool force = false)
	{
	}

	// Token: 0x06001338 RID: 4920 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001338")]
	[Address(RVA = "0x7FACE0", Offset = "0x7FA0E0", VA = "0x107FACE0")]
	public void CloseMenu()
	{
	}

	// Token: 0x06001339 RID: 4921 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001339")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public ControllerNavMenu()
	{
	}

	// Token: 0x04001372 RID: 4978
	[Token(Token = "0x4001372")]
	[FieldOffset(Offset = "0xC")]
	public bool openInOnEnable;

	// Token: 0x04001373 RID: 4979
	[Token(Token = "0x4001373")]
	[FieldOffset(Offset = "0xD")]
	public bool gridNavigation;

	// Token: 0x04001374 RID: 4980
	[Token(Token = "0x4001374")]
	[FieldOffset(Offset = "0xE")]
	public bool trySelectAny;

	// Token: 0x04001375 RID: 4981
	[Token(Token = "0x4001375")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xDD8F0", Offset = "0xDCCF0")]
	public UiElement BackButton;

	// Token: 0x04001376 RID: 4982
	[Token(Token = "0x4001376")]
	[FieldOffset(Offset = "0x14")]
	public UiElement DefaultButtonSelected;

	// Token: 0x04001377 RID: 4983
	[Token(Token = "0x4001377")]
	[FieldOffset(Offset = "0x18")]
	public List<UiElement> ControllerSelectable;

	// Token: 0x04001378 RID: 4984
	[Token(Token = "0x4001378")]
	[FieldOffset(Offset = "0x1C")]
	private bool isOpen;

	// Token: 0x0200037A RID: 890
	[Token(Token = "0x200037A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <OpenCoroutine>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600133A RID: 4922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600133A")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <OpenCoroutine>d__9(int <>1__state)
		{
		}

		// Token: 0x0600133B RID: 4923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600133B")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600133C RID: 4924 RVA: 0x000066C0 File Offset: 0x000048C0
		[Token(Token = "0x600133C")]
		[Address(RVA = "0x788FF0", Offset = "0x7883F0", VA = "0x10788FF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x0600133D RID: 4925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002D0")]
		private object Current
		{
			[Token(Token = "0x600133D")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600133E RID: 4926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600133E")]
		[Address(RVA = "0x789040", Offset = "0x788440", VA = "0x10789040", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x0600133F RID: 4927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002D1")]
		private object Current
		{
			[Token(Token = "0x600133F")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04001379 RID: 4985
		[Token(Token = "0x4001379")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x0400137A RID: 4986
		[Token(Token = "0x400137A")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x0400137B RID: 4987
		[Token(Token = "0x400137B")]
		[FieldOffset(Offset = "0x10")]
		public ControllerNavMenu <>4__this;
	}
}
