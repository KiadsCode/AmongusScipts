using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Rewired.UI.ControlMapper;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.Demos
{
	// Token: 0x020005DF RID: 1503
	[Token(Token = "0x20005DF")]
	[Attribute(Name = "AddComponentMenu", RVA = "0xE2DC0", Offset = "0xE21C0")]
	public class ControlMapperDemoMessage : MonoBehaviour
	{
		// Token: 0x060025D7 RID: 9687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025D7")]
		[Address(RVA = "0x7ED9B0", Offset = "0x7ECDB0", VA = "0x107ED9B0")]
		private void Awake()
		{
		}

		// Token: 0x060025D8 RID: 9688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025D8")]
		[Address(RVA = "0x7EDB70", Offset = "0x7ECF70", VA = "0x107EDB70")]
		private void Start()
		{
		}

		// Token: 0x060025D9 RID: 9689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025D9")]
		[Address(RVA = "0x7EDAA0", Offset = "0x7ECEA0", VA = "0x107EDAA0")]
		private void OnControlMapperClosed()
		{
		}

		// Token: 0x060025DA RID: 9690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025DA")]
		[Address(RVA = "0x499D40", Offset = "0x499140", VA = "0x10499D40")]
		private void OnControlMapperOpened()
		{
		}

		// Token: 0x060025DB RID: 9691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025DB")]
		[Address(RVA = "0x7EDB70", Offset = "0x7ECF70", VA = "0x107EDB70")]
		private void SelectDefault()
		{
		}

		// Token: 0x060025DC RID: 9692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025DC")]
		[Address(RVA = "0x7EDB20", Offset = "0x7ECF20", VA = "0x107EDB20")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE7750", Offset = "0xE6B50")]
		private IEnumerator SelectDefaultDeferred()
		{
			return null;
		}

		// Token: 0x060025DD RID: 9693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025DD")]
		[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
		public ControlMapperDemoMessage()
		{
		}

		// Token: 0x0400255D RID: 9565
		[Token(Token = "0x400255D")]
		[FieldOffset(Offset = "0xC")]
		public ControlMapper controlMapper;

		// Token: 0x0400255E RID: 9566
		[Token(Token = "0x400255E")]
		[FieldOffset(Offset = "0x10")]
		public Selectable defaultSelectable;

		// Token: 0x020005E0 RID: 1504
		[Token(Token = "0x20005E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private sealed class <SelectDefaultDeferred>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060025DE RID: 9694 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60025DE")]
			[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
			[DebuggerHidden]
			public <SelectDefaultDeferred>d__7(int <>1__state)
			{
			}

			// Token: 0x060025DF RID: 9695 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60025DF")]
			[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060025E0 RID: 9696 RVA: 0x0000B358 File Offset: 0x00009558
			[Token(Token = "0x60025E0")]
			[Address(RVA = "0x78B5D0", Offset = "0x78A9D0", VA = "0x1078B5D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000801 RID: 2049
			// (get) Token: 0x060025E1 RID: 9697 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000801")]
			private object Current
			{
				[Token(Token = "0x60025E1")]
				[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060025E2 RID: 9698 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60025E2")]
			[Address(RVA = "0x78B620", Offset = "0x78AA20", VA = "0x1078B620", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000802 RID: 2050
			// (get) Token: 0x060025E3 RID: 9699 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000802")]
			private object Current
			{
				[Token(Token = "0x60025E3")]
				[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400255F RID: 9567
			[Token(Token = "0x400255F")]
			[FieldOffset(Offset = "0x8")]
			private int <>1__state;

			// Token: 0x04002560 RID: 9568
			[Token(Token = "0x4002560")]
			[FieldOffset(Offset = "0xC")]
			private object <>2__current;

			// Token: 0x04002561 RID: 9569
			[Token(Token = "0x4002561")]
			[FieldOffset(Offset = "0x10")]
			public ControlMapperDemoMessage <>4__this;
		}
	}
}
