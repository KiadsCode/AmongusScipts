using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x0200058A RID: 1418
	[Token(Token = "0x200058A")]
	[Attribute(Name = "AddComponentMenu", RVA = "0xE2DC0", Offset = "0xE21C0")]
	public class CustomToggle : Toggle, ICustomSelectable, ICancelHandler, IEventSystemHandler
	{
		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x060022E7 RID: 8935 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060022E8 RID: 8936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000722")]
		public Sprite disabledHighlightedSprite
		{
			[Token(Token = "0x60022E7")]
			[Address(RVA = "0x5C2610", Offset = "0x5C1A10", VA = "0x105C2610", Slot = "51")]
			get
			{
				return null;
			}
			[Token(Token = "0x60022E8")]
			[Address(RVA = "0x5C2750", Offset = "0x5C1B50", VA = "0x105C2750", Slot = "52")]
			set
			{
			}
		}

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x060022E9 RID: 8937 RVA: 0x0000A9F8 File Offset: 0x00008BF8
		// (set) Token: 0x060022EA RID: 8938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000723")]
		public Color disabledHighlightedColor
		{
			[Token(Token = "0x60022E9")]
			[Address(RVA = "0x5C25F0", Offset = "0x5C19F0", VA = "0x105C25F0", Slot = "53")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60022EA")]
			[Address(RVA = "0x5C2730", Offset = "0x5C1B30", VA = "0x105C2730", Slot = "54")]
			set
			{
			}
		}

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x060022EB RID: 8939 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060022EC RID: 8940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000724")]
		public string disabledHighlightedTrigger
		{
			[Token(Token = "0x60022EB")]
			[Address(RVA = "0x5C2620", Offset = "0x5C1A20", VA = "0x105C2620", Slot = "55")]
			get
			{
				return null;
			}
			[Token(Token = "0x60022EC")]
			[Address(RVA = "0x5C2770", Offset = "0x5C1B70", VA = "0x105C2770", Slot = "56")]
			set
			{
			}
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x060022ED RID: 8941 RVA: 0x0000AA10 File Offset: 0x00008C10
		// (set) Token: 0x060022EE RID: 8942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000725")]
		public bool autoNavUp
		{
			[Token(Token = "0x60022ED")]
			[Address(RVA = "0x5C25E0", Offset = "0x5C19E0", VA = "0x105C25E0", Slot = "57")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60022EE")]
			[Address(RVA = "0x5C2710", Offset = "0x5C1B10", VA = "0x105C2710", Slot = "58")]
			set
			{
			}
		}

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x060022EF RID: 8943 RVA: 0x0000AA28 File Offset: 0x00008C28
		// (set) Token: 0x060022F0 RID: 8944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000726")]
		public bool autoNavDown
		{
			[Token(Token = "0x60022EF")]
			[Address(RVA = "0x5C25B0", Offset = "0x5C19B0", VA = "0x105C25B0", Slot = "59")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60022F0")]
			[Address(RVA = "0x5C26B0", Offset = "0x5C1AB0", VA = "0x105C26B0", Slot = "60")]
			set
			{
			}
		}

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x060022F1 RID: 8945 RVA: 0x0000AA40 File Offset: 0x00008C40
		// (set) Token: 0x060022F2 RID: 8946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000727")]
		public bool autoNavLeft
		{
			[Token(Token = "0x60022F1")]
			[Address(RVA = "0x5C25C0", Offset = "0x5C19C0", VA = "0x105C25C0", Slot = "61")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60022F2")]
			[Address(RVA = "0x5C26D0", Offset = "0x5C1AD0", VA = "0x105C26D0", Slot = "62")]
			set
			{
			}
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x060022F3 RID: 8947 RVA: 0x0000AA58 File Offset: 0x00008C58
		// (set) Token: 0x060022F4 RID: 8948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000728")]
		public bool autoNavRight
		{
			[Token(Token = "0x60022F3")]
			[Address(RVA = "0x5C25D0", Offset = "0x5C19D0", VA = "0x105C25D0", Slot = "63")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60022F4")]
			[Address(RVA = "0x5C26F0", Offset = "0x5C1AF0", VA = "0x105C26F0", Slot = "64")]
			set
			{
			}
		}

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x060022F5 RID: 8949 RVA: 0x0000AA70 File Offset: 0x00008C70
		[Token(Token = "0x17000729")]
		private bool isDisabled
		{
			[Token(Token = "0x60022F5")]
			[Address(RVA = "0x5BE590", Offset = "0x5BD990", VA = "0x105BE590")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x060022F6 RID: 8950 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060022F7 RID: 8951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000014")]
		private event UnityAction _CancelEvent
		{
			[Token(Token = "0x60022F6")]
			[Address(RVA = "0x5C2530", Offset = "0x5C1930", VA = "0x105C2530")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			add
			{
			}
			[Token(Token = "0x60022F7")]
			[Address(RVA = "0x5C2630", Offset = "0x5C1A30", VA = "0x105C2630")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			remove
			{
			}
		}

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x060022F8 RID: 8952 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060022F9 RID: 8953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000015")]
		public event UnityAction CancelEvent
		{
			[Token(Token = "0x60022F8")]
			[Address(RVA = "0x5C2530", Offset = "0x5C1930", VA = "0x105C2530", Slot = "65")]
			add
			{
			}
			[Token(Token = "0x60022F9")]
			[Address(RVA = "0x5C2630", Offset = "0x5C1A30", VA = "0x105C2630", Slot = "66")]
			remove
			{
			}
		}

		// Token: 0x060022FA RID: 8954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022FA")]
		[Address(RVA = "0x5C1E90", Offset = "0x5C1290", VA = "0x105C1E90", Slot = "27")]
		public override Selectable FindSelectableOnLeft()
		{
			return null;
		}

		// Token: 0x060022FB RID: 8955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022FB")]
		[Address(RVA = "0x5C1F50", Offset = "0x5C1350", VA = "0x105C1F50", Slot = "28")]
		public override Selectable FindSelectableOnRight()
		{
			return null;
		}

		// Token: 0x060022FC RID: 8956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022FC")]
		[Address(RVA = "0x5C2010", Offset = "0x5C1410", VA = "0x105C2010", Slot = "29")]
		public override Selectable FindSelectableOnUp()
		{
			return null;
		}

		// Token: 0x060022FD RID: 8957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022FD")]
		[Address(RVA = "0x5C1DD0", Offset = "0x5C11D0", VA = "0x105C1DD0", Slot = "30")]
		public override Selectable FindSelectableOnDown()
		{
			return null;
		}

		// Token: 0x060022FE RID: 8958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022FE")]
		[Address(RVA = "0x5C20F0", Offset = "0x5C14F0", VA = "0x105C20F0", Slot = "14")]
		protected override void OnCanvasGroupChanged()
		{
		}

		// Token: 0x060022FF RID: 8959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022FF")]
		[Address(RVA = "0x5C19A0", Offset = "0x5C0DA0", VA = "0x105C19A0", Slot = "26")]
		protected override void DoStateTransition(Selectable.SelectionState state, bool instant)
		{
		}

		// Token: 0x06002300 RID: 8960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002300")]
		[Address(RVA = "0x5C22D0", Offset = "0x5C16D0", VA = "0x105C22D0")]
		private void StartColorTween(Color targetColor, bool instant)
		{
		}

		// Token: 0x06002301 RID: 8961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002301")]
		[Address(RVA = "0x5C1910", Offset = "0x5C0D10", VA = "0x105C1910")]
		private void DoSpriteSwap(Sprite newSprite)
		{
		}

		// Token: 0x06002302 RID: 8962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002302")]
		[Address(RVA = "0x5C23B0", Offset = "0x5C17B0", VA = "0x105C23B0")]
		private void TriggerAnimation(string triggername)
		{
		}

		// Token: 0x06002303 RID: 8963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002303")]
		[Address(RVA = "0x5C2280", Offset = "0x5C1680", VA = "0x105C2280", Slot = "36")]
		public override void OnSelect(BaseEventData eventData)
		{
		}

		// Token: 0x06002304 RID: 8964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002304")]
		[Address(RVA = "0x5C2210", Offset = "0x5C1610", VA = "0x105C2210", Slot = "37")]
		public override void OnDeselect(BaseEventData eventData)
		{
		}

		// Token: 0x06002305 RID: 8965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002305")]
		[Address(RVA = "0x5C1D30", Offset = "0x5C1130", VA = "0x105C1D30")]
		private void EvaluateHightlightDisabled(bool isSelected)
		{
		}

		// Token: 0x06002306 RID: 8966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002306")]
		[Address(RVA = "0x5C20D0", Offset = "0x5C14D0", VA = "0x105C20D0", Slot = "67")]
		public void OnCancel(BaseEventData eventData)
		{
		}

		// Token: 0x06002307 RID: 8967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002307")]
		[Address(RVA = "0x5C2510", Offset = "0x5C1910", VA = "0x105C2510")]
		public CustomToggle()
		{
		}

		// Token: 0x0400237C RID: 9084
		[Token(Token = "0x400237C")]
		[FieldOffset(Offset = "0xC4")]
		[SerializeField]
		private Sprite _disabledHighlightedSprite;

		// Token: 0x0400237D RID: 9085
		[Token(Token = "0x400237D")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Color _disabledHighlightedColor;

		// Token: 0x0400237E RID: 9086
		[Token(Token = "0x400237E")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private string _disabledHighlightedTrigger;

		// Token: 0x0400237F RID: 9087
		[Token(Token = "0x400237F")]
		[FieldOffset(Offset = "0xDC")]
		[SerializeField]
		private bool _autoNavUp;

		// Token: 0x04002380 RID: 9088
		[Token(Token = "0x4002380")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private bool _autoNavDown;

		// Token: 0x04002381 RID: 9089
		[Token(Token = "0x4002381")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private bool _autoNavLeft;

		// Token: 0x04002382 RID: 9090
		[Token(Token = "0x4002382")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private bool _autoNavRight;

		// Token: 0x04002383 RID: 9091
		[Token(Token = "0x4002383")]
		[FieldOffset(Offset = "0x0")]
		private bool isHighlightDisabled;
	}
}
