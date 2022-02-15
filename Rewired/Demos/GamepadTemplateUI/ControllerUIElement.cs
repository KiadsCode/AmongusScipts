using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.Demos.GamepadTemplateUI
{
	// Token: 0x020005E2 RID: 1506
	[Token(Token = "0x20005E2")]
	[Attribute(Name = "RequireComponent", RVA = "0xE78F0", Offset = "0xE6CF0")]
	public class ControllerUIElement : MonoBehaviour
	{
		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x060025E9 RID: 9705 RVA: 0x0000B370 File Offset: 0x00009570
		[Token(Token = "0x17000803")]
		private bool hasEffects
		{
			[Token(Token = "0x60025E9")]
			[Address(RVA = "0x7FC7C0", Offset = "0x7FBBC0", VA = "0x107FC7C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060025EA RID: 9706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025EA")]
		[Address(RVA = "0x7FC1B0", Offset = "0x7FB5B0", VA = "0x107FC1B0")]
		private void Awake()
		{
		}

		// Token: 0x060025EB RID: 9707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025EB")]
		[Address(RVA = "0x7FBEA0", Offset = "0x7FB2A0", VA = "0x107FBEA0")]
		public void Activate(float amount)
		{
		}

		// Token: 0x060025EC RID: 9708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025EC")]
		[Address(RVA = "0x7FC420", Offset = "0x7FB820", VA = "0x107FC420")]
		public void Deactivate()
		{
		}

		// Token: 0x060025ED RID: 9709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025ED")]
		[Address(RVA = "0x7FC600", Offset = "0x7FBA00", VA = "0x107FC600")]
		public void SetLabel(string text, AxisRange labelType)
		{
		}

		// Token: 0x060025EE RID: 9710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025EE")]
		[Address(RVA = "0x7FC230", Offset = "0x7FB630", VA = "0x107FC230")]
		public void ClearLabels()
		{
		}

		// Token: 0x060025EF RID: 9711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025EF")]
		[Address(RVA = "0x7FC5C0", Offset = "0x7FB9C0", VA = "0x107FC5C0")]
		private void RedrawImage()
		{
		}

		// Token: 0x060025F0 RID: 9712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025F0")]
		[Address(RVA = "0x7FC760", Offset = "0x7FBB60", VA = "0x107FC760")]
		public ControllerUIElement()
		{
		}

		// Token: 0x04002568 RID: 9576
		[Token(Token = "0x4002568")]
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		private Color _highlightColor;

		// Token: 0x04002569 RID: 9577
		[Token(Token = "0x4002569")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private ControllerUIEffect _positiveUIEffect;

		// Token: 0x0400256A RID: 9578
		[Token(Token = "0x400256A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ControllerUIEffect _negativeUIEffect;

		// Token: 0x0400256B RID: 9579
		[Token(Token = "0x400256B")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Text _label;

		// Token: 0x0400256C RID: 9580
		[Token(Token = "0x400256C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _positiveLabel;

		// Token: 0x0400256D RID: 9581
		[Token(Token = "0x400256D")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Text _negativeLabel;

		// Token: 0x0400256E RID: 9582
		[Token(Token = "0x400256E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ControllerUIElement[] _childElements;

		// Token: 0x0400256F RID: 9583
		[Token(Token = "0x400256F")]
		[FieldOffset(Offset = "0x34")]
		private Image _image;

		// Token: 0x04002570 RID: 9584
		[Token(Token = "0x4002570")]
		[FieldOffset(Offset = "0x38")]
		private Color _color;

		// Token: 0x04002571 RID: 9585
		[Token(Token = "0x4002571")]
		[FieldOffset(Offset = "0x48")]
		private Color _origColor;

		// Token: 0x04002572 RID: 9586
		[Token(Token = "0x4002572")]
		[FieldOffset(Offset = "0x58")]
		private bool _isActive;

		// Token: 0x04002573 RID: 9587
		[Token(Token = "0x4002573")]
		[FieldOffset(Offset = "0x5C")]
		private float _highlightAmount;
	}
}
