using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x02000597 RID: 1431
	[Token(Token = "0x2000597")]
	[Attribute(Name = "AddComponentMenu", RVA = "0xE6000", Offset = "0xE5400")]
	[Attribute(Name = "RequireComponent", RVA = "0xE6000", Offset = "0xE5400")]
	public class ScrollRectSelectableChild : MonoBehaviour, ISelectHandler, IEventSystemHandler
	{
		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x060023D1 RID: 9169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700078F")]
		private RectTransform parentScrollRectContentTransform
		{
			[Token(Token = "0x60023D1")]
			[Address(RVA = "0x58BDD0", Offset = "0x58B1D0", VA = "0x1058BDD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x060023D2 RID: 9170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000790")]
		private Selectable selectable
		{
			[Token(Token = "0x60023D2")]
			[Address(RVA = "0x58BE40", Offset = "0x58B240", VA = "0x1058BE40")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x060023D3 RID: 9171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000791")]
		private RectTransform rectTransform
		{
			[Token(Token = "0x60023D3")]
			[Address(RVA = "0x58BDF0", Offset = "0x58B1F0", VA = "0x1058BDF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060023D4 RID: 9172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023D4")]
		[Address(RVA = "0x58BCE0", Offset = "0x58B0E0", VA = "0x1058BCE0")]
		private void Start()
		{
		}

		// Token: 0x060023D5 RID: 9173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023D5")]
		[Address(RVA = "0x58B8D0", Offset = "0x58ACD0", VA = "0x1058B8D0", Slot = "4")]
		public void OnSelect(BaseEventData eventData)
		{
		}

		// Token: 0x060023D6 RID: 9174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023D6")]
		[Address(RVA = "0x58BDB0", Offset = "0x58B1B0", VA = "0x1058BDB0")]
		public ScrollRectSelectableChild()
		{
		}

		// Token: 0x040023EC RID: 9196
		[Token(Token = "0x40023EC")]
		[FieldOffset(Offset = "0xC")]
		public bool useCustomEdgePadding;

		// Token: 0x040023ED RID: 9197
		[Token(Token = "0x40023ED")]
		[FieldOffset(Offset = "0x10")]
		public float customEdgePadding;

		// Token: 0x040023EE RID: 9198
		[Token(Token = "0x40023EE")]
		[FieldOffset(Offset = "0x14")]
		private ScrollRect parentScrollRect;

		// Token: 0x040023EF RID: 9199
		[Token(Token = "0x40023EF")]
		[FieldOffset(Offset = "0x18")]
		private Selectable _selectable;
	}
}
