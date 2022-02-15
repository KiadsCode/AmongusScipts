using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.Demos.GamepadTemplateUI
{
	// Token: 0x020005E1 RID: 1505
	[Token(Token = "0x20005E1")]
	[Attribute(Name = "RequireComponent", RVA = "0xE77F0", Offset = "0xE6BF0")]
	public class ControllerUIEffect : MonoBehaviour
	{
		// Token: 0x060025E4 RID: 9700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025E4")]
		[Address(RVA = "0x7FBD40", Offset = "0x7FB140", VA = "0x107FBD40")]
		private void Awake()
		{
		}

		// Token: 0x060025E5 RID: 9701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025E5")]
		[Address(RVA = "0x7FBC80", Offset = "0x7FB080", VA = "0x107FBC80")]
		public void Activate(float amount)
		{
		}

		// Token: 0x060025E6 RID: 9702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025E6")]
		[Address(RVA = "0x7FBDB0", Offset = "0x7FB1B0", VA = "0x107FBDB0")]
		public void Deactivate()
		{
		}

		// Token: 0x060025E7 RID: 9703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025E7")]
		[Address(RVA = "0x7FBE20", Offset = "0x7FB220", VA = "0x107FBE20")]
		private void RedrawImage()
		{
		}

		// Token: 0x060025E8 RID: 9704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025E8")]
		[Address(RVA = "0x7FBE70", Offset = "0x7FB270", VA = "0x107FBE70")]
		public ControllerUIEffect()
		{
		}

		// Token: 0x04002562 RID: 9570
		[Token(Token = "0x4002562")]
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		private Color _highlightColor;

		// Token: 0x04002563 RID: 9571
		[Token(Token = "0x4002563")]
		[FieldOffset(Offset = "0x1C")]
		private Image _image;

		// Token: 0x04002564 RID: 9572
		[Token(Token = "0x4002564")]
		[FieldOffset(Offset = "0x20")]
		private Color _color;

		// Token: 0x04002565 RID: 9573
		[Token(Token = "0x4002565")]
		[FieldOffset(Offset = "0x30")]
		private Color _origColor;

		// Token: 0x04002566 RID: 9574
		[Token(Token = "0x4002566")]
		[FieldOffset(Offset = "0x40")]
		private bool _isActive;

		// Token: 0x04002567 RID: 9575
		[Token(Token = "0x4002567")]
		[FieldOffset(Offset = "0x44")]
		private float _highlightAmount;
	}
}
