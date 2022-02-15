using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x02000589 RID: 1417
	[Token(Token = "0x2000589")]
	[Attribute(Name = "AddComponentMenu", RVA = "0xE2DC0", Offset = "0xE21C0")]
	public class CustomSlider : Slider, ICustomSelectable, ICancelHandler, IEventSystemHandler
	{
		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x060022C6 RID: 8902 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060022C7 RID: 8903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700071A")]
		public Sprite disabledHighlightedSprite
		{
			[Token(Token = "0x60022C6")]
			[Address(RVA = "0x5C17C0", Offset = "0x5C0BC0", VA = "0x105C17C0", Slot = "56")]
			get
			{
				return null;
			}
			[Token(Token = "0x60022C7")]
			[Address(RVA = "0x5C18F0", Offset = "0x5C0CF0", VA = "0x105C18F0", Slot = "57")]
			set
			{
			}
		}

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x060022C8 RID: 8904 RVA: 0x0000A968 File Offset: 0x00008B68
		// (set) Token: 0x060022C9 RID: 8905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700071B")]
		public Color disabledHighlightedColor
		{
			[Token(Token = "0x60022C8")]
			[Address(RVA = "0x5C17A0", Offset = "0x5C0BA0", VA = "0x105C17A0", Slot = "58")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60022C9")]
			[Address(RVA = "0x5C18D0", Offset = "0x5C0CD0", VA = "0x105C18D0", Slot = "59")]
			set
			{
			}
		}

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x060022CA RID: 8906 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060022CB RID: 8907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700071C")]
		public string disabledHighlightedTrigger
		{
			[Token(Token = "0x60022CA")]
			[Address(RVA = "0x504840", Offset = "0x503C40", VA = "0x10504840", Slot = "60")]
			get
			{
				return null;
			}
			[Token(Token = "0x60022CB")]
			[Address(RVA = "0x5048C0", Offset = "0x503CC0", VA = "0x105048C0", Slot = "61")]
			set
			{
			}
		}

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x060022CC RID: 8908 RVA: 0x0000A980 File Offset: 0x00008B80
		// (set) Token: 0x060022CD RID: 8909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700071D")]
		public bool autoNavUp
		{
			[Token(Token = "0x60022CC")]
			[Address(RVA = "0x5C1790", Offset = "0x5C0B90", VA = "0x105C1790", Slot = "62")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60022CD")]
			[Address(RVA = "0x5C18B0", Offset = "0x5C0CB0", VA = "0x105C18B0", Slot = "63")]
			set
			{
			}
		}

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x060022CE RID: 8910 RVA: 0x0000A998 File Offset: 0x00008B98
		// (set) Token: 0x060022CF RID: 8911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700071E")]
		public bool autoNavDown
		{
			[Token(Token = "0x60022CE")]
			[Address(RVA = "0x5C1760", Offset = "0x5C0B60", VA = "0x105C1760", Slot = "64")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60022CF")]
			[Address(RVA = "0x5C1850", Offset = "0x5C0C50", VA = "0x105C1850", Slot = "65")]
			set
			{
			}
		}

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x060022D0 RID: 8912 RVA: 0x0000A9B0 File Offset: 0x00008BB0
		// (set) Token: 0x060022D1 RID: 8913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700071F")]
		public bool autoNavLeft
		{
			[Token(Token = "0x60022D0")]
			[Address(RVA = "0x5C1770", Offset = "0x5C0B70", VA = "0x105C1770", Slot = "66")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60022D1")]
			[Address(RVA = "0x5C1870", Offset = "0x5C0C70", VA = "0x105C1870", Slot = "67")]
			set
			{
			}
		}

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x060022D2 RID: 8914 RVA: 0x0000A9C8 File Offset: 0x00008BC8
		// (set) Token: 0x060022D3 RID: 8915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000720")]
		public bool autoNavRight
		{
			[Token(Token = "0x60022D2")]
			[Address(RVA = "0x5C1780", Offset = "0x5C0B80", VA = "0x105C1780", Slot = "68")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60022D3")]
			[Address(RVA = "0x5C1890", Offset = "0x5C0C90", VA = "0x105C1890", Slot = "69")]
			set
			{
			}
		}

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x060022D4 RID: 8916 RVA: 0x0000A9E0 File Offset: 0x00008BE0
		[Token(Token = "0x17000721")]
		private bool isDisabled
		{
			[Token(Token = "0x60022D4")]
			[Address(RVA = "0x5BE590", Offset = "0x5BD990", VA = "0x105BE590")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x060022D5 RID: 8917 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060022D6 RID: 8918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000012")]
		private event UnityAction _CancelEvent
		{
			[Token(Token = "0x60022D5")]
			[Address(RVA = "0x5C16E0", Offset = "0x5C0AE0", VA = "0x105C16E0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			add
			{
			}
			[Token(Token = "0x60022D6")]
			[Address(RVA = "0x5C17D0", Offset = "0x5C0BD0", VA = "0x105C17D0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			remove
			{
			}
		}

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x060022D7 RID: 8919 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060022D8 RID: 8920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000013")]
		public event UnityAction CancelEvent
		{
			[Token(Token = "0x60022D7")]
			[Address(RVA = "0x5C16E0", Offset = "0x5C0AE0", VA = "0x105C16E0", Slot = "70")]
			add
			{
			}
			[Token(Token = "0x60022D8")]
			[Address(RVA = "0x5C17D0", Offset = "0x5C0BD0", VA = "0x105C17D0", Slot = "71")]
			remove
			{
			}
		}

		// Token: 0x060022D9 RID: 8921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022D9")]
		[Address(RVA = "0x5C1040", Offset = "0x5C0440", VA = "0x105C1040", Slot = "27")]
		public override Selectable FindSelectableOnLeft()
		{
			return null;
		}

		// Token: 0x060022DA RID: 8922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022DA")]
		[Address(RVA = "0x5C1100", Offset = "0x5C0500", VA = "0x105C1100", Slot = "28")]
		public override Selectable FindSelectableOnRight()
		{
			return null;
		}

		// Token: 0x060022DB RID: 8923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022DB")]
		[Address(RVA = "0x5C11C0", Offset = "0x5C05C0", VA = "0x105C11C0", Slot = "29")]
		public override Selectable FindSelectableOnUp()
		{
			return null;
		}

		// Token: 0x060022DC RID: 8924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022DC")]
		[Address(RVA = "0x5C0F80", Offset = "0x5C0380", VA = "0x105C0F80", Slot = "30")]
		public override Selectable FindSelectableOnDown()
		{
			return null;
		}

		// Token: 0x060022DD RID: 8925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022DD")]
		[Address(RVA = "0x5C12A0", Offset = "0x5C06A0", VA = "0x105C12A0", Slot = "14")]
		protected override void OnCanvasGroupChanged()
		{
		}

		// Token: 0x060022DE RID: 8926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022DE")]
		[Address(RVA = "0x5C0B50", Offset = "0x5BFF50", VA = "0x105C0B50", Slot = "26")]
		protected override void DoStateTransition(Selectable.SelectionState state, bool instant)
		{
		}

		// Token: 0x060022DF RID: 8927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022DF")]
		[Address(RVA = "0x5C1480", Offset = "0x5C0880", VA = "0x105C1480")]
		private void StartColorTween(Color targetColor, bool instant)
		{
		}

		// Token: 0x060022E0 RID: 8928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022E0")]
		[Address(RVA = "0x5C0AC0", Offset = "0x5BFEC0", VA = "0x105C0AC0")]
		private void DoSpriteSwap(Sprite newSprite)
		{
		}

		// Token: 0x060022E1 RID: 8929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022E1")]
		[Address(RVA = "0x5C1560", Offset = "0x5C0960", VA = "0x105C1560")]
		private void TriggerAnimation(string triggername)
		{
		}

		// Token: 0x060022E2 RID: 8930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022E2")]
		[Address(RVA = "0x5C1430", Offset = "0x5C0830", VA = "0x105C1430", Slot = "36")]
		public override void OnSelect(BaseEventData eventData)
		{
		}

		// Token: 0x060022E3 RID: 8931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022E3")]
		[Address(RVA = "0x5C13C0", Offset = "0x5C07C0", VA = "0x105C13C0", Slot = "37")]
		public override void OnDeselect(BaseEventData eventData)
		{
		}

		// Token: 0x060022E4 RID: 8932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022E4")]
		[Address(RVA = "0x5C0EE0", Offset = "0x5C02E0", VA = "0x105C0EE0")]
		private void EvaluateHightlightDisabled(bool isSelected)
		{
		}

		// Token: 0x060022E5 RID: 8933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022E5")]
		[Address(RVA = "0x5C1280", Offset = "0x5C0680", VA = "0x105C1280", Slot = "72")]
		public void OnCancel(BaseEventData eventData)
		{
		}

		// Token: 0x060022E6 RID: 8934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022E6")]
		[Address(RVA = "0x5C16C0", Offset = "0x5C0AC0", VA = "0x105C16C0")]
		public CustomSlider()
		{
		}

		// Token: 0x04002373 RID: 9075
		[Token(Token = "0x4002373")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private Sprite _disabledHighlightedSprite;

		// Token: 0x04002374 RID: 9076
		[Token(Token = "0x4002374")]
		[FieldOffset(Offset = "0xF4")]
		[SerializeField]
		private Color _disabledHighlightedColor;

		// Token: 0x04002375 RID: 9077
		[Token(Token = "0x4002375")]
		[FieldOffset(Offset = "0x104")]
		[SerializeField]
		private string _disabledHighlightedTrigger;

		// Token: 0x04002376 RID: 9078
		[Token(Token = "0x4002376")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private bool _autoNavUp;

		// Token: 0x04002377 RID: 9079
		[Token(Token = "0x4002377")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private bool _autoNavDown;

		// Token: 0x04002378 RID: 9080
		[Token(Token = "0x4002378")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private bool _autoNavLeft;

		// Token: 0x04002379 RID: 9081
		[Token(Token = "0x4002379")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private bool _autoNavRight;

		// Token: 0x0400237A RID: 9082
		[Token(Token = "0x400237A")]
		[FieldOffset(Offset = "0x0")]
		private bool isHighlightDisabled;
	}
}
