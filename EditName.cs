using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000019 RID: 25
[Token(Token = "0x2000019")]
public class EditName : MonoBehaviour
{
	// Token: 0x060000EE RID: 238 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x4742A0", Offset = "0x4736A0", VA = "0x104742A0")]
	private void OnEnable()
	{
	}

	// Token: 0x060000EF RID: 239 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x474230", Offset = "0x473630", VA = "0x10474230")]
	private void OnDisable()
	{
	}

	// Token: 0x060000F0 RID: 240 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x4743A0", Offset = "0x4737A0", VA = "0x104743A0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE25F0", Offset = "0xE19F0")]
	public IEnumerator Show()
	{
		return null;
	}

	// Token: 0x060000F1 RID: 241 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x4741E0", Offset = "0x4735E0", VA = "0x104741E0")]
	public void Close()
	{
	}

	// Token: 0x060000F2 RID: 242 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x4743F0", Offset = "0x4737F0", VA = "0x104743F0")]
	public void UpdateName()
	{
	}

	// Token: 0x060000F3 RID: 243 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x474320", Offset = "0x473720", VA = "0x10474320")]
	public void RandomizeName()
	{
	}

	// Token: 0x060000F4 RID: 244 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public EditName()
	{
	}

	// Token: 0x040000AB RID: 171
	[Token(Token = "0x40000AB")]
	[FieldOffset(Offset = "0xC")]
	public NameTextBehaviour nameText;

	// Token: 0x040000AC RID: 172
	[Token(Token = "0x40000AC")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xDD8F0", Offset = "0xDCCF0")]
	public UiElement BackButton;

	// Token: 0x040000AD RID: 173
	[Token(Token = "0x40000AD")]
	[FieldOffset(Offset = "0x14")]
	public UiElement DefaultSelection;

	// Token: 0x040000AE RID: 174
	[Token(Token = "0x40000AE")]
	[FieldOffset(Offset = "0x18")]
	public List<UiElement> selectableObjects;

	// Token: 0x0200001A RID: 26
	[Token(Token = "0x200001A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <Show>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060000F5 RID: 245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <Show>d__6(int <>1__state)
		{
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00002280 File Offset: 0x00000480
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x78C560", Offset = "0x78B960", VA = "0x1078C560", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000023")]
		private object Current
		{
			[Token(Token = "0x60000F8")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x78C5F0", Offset = "0x78B9F0", VA = "0x1078C5F0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000FA RID: 250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000024")]
		private object Current
		{
			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040000AF RID: 175
		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040000B0 RID: 176
		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040000B1 RID: 177
		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x10")]
		public EditName <>4__this;
	}
}
