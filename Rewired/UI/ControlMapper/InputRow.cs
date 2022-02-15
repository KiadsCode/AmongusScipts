using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x02000592 RID: 1426
	[Token(Token = "0x2000592")]
	[Attribute(Name = "AddComponentMenu", RVA = "0xE2DC0", Offset = "0xE21C0")]
	public class InputRow : MonoBehaviour
	{
		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x0600233E RID: 9022 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600233F RID: 9023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000738")]
		public ButtonInfo[] buttons
		{
			[Token(Token = "0x600233E")]
			[Address(RVA = "0x273EC0", Offset = "0x2732C0", VA = "0x10273EC0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600233F")]
			[Address(RVA = "0x273100", Offset = "0x272500", VA = "0x10273100")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private set
			{
			}
		}

		// Token: 0x06002340 RID: 9024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002340")]
		[Address(RVA = "0x3FA960", Offset = "0x3F9D60", VA = "0x103FA960")]
		public void Initialize(int rowIndex, string label, Action<int, ButtonInfo> inputFieldActivatedCallback)
		{
		}

		// Token: 0x06002341 RID: 9025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002341")]
		[Address(RVA = "0x3FA9E0", Offset = "0x3F9DE0", VA = "0x103FA9E0")]
		public void OnButtonActivated(ButtonInfo buttonInfo)
		{
		}

		// Token: 0x06002342 RID: 9026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002342")]
		[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
		public InputRow()
		{
		}

		// Token: 0x040023A5 RID: 9125
		[Token(Token = "0x40023A5")]
		[FieldOffset(Offset = "0xC")]
		public TMP_Text label;

		// Token: 0x040023A6 RID: 9126
		[Token(Token = "0x40023A6")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private ButtonInfo[] <buttons>k__BackingField;

		// Token: 0x040023A7 RID: 9127
		[Token(Token = "0x40023A7")]
		[FieldOffset(Offset = "0x14")]
		private int rowIndex;

		// Token: 0x040023A8 RID: 9128
		[Token(Token = "0x40023A8")]
		[FieldOffset(Offset = "0x18")]
		private Action<int, ButtonInfo> inputFieldActivatedCallback;
	}
}
