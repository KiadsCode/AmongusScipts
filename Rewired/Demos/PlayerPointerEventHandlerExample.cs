using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Rewired.Integration.UnityUI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Rewired.Demos
{
	// Token: 0x020005CE RID: 1486
	[Token(Token = "0x20005CE")]
	[Attribute(Name = "AddComponentMenu", RVA = "0xE2DC0", Offset = "0xE21C0")]
	public sealed class PlayerPointerEventHandlerExample : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerUpHandler, IPointerDownHandler, IPointerClickHandler, IScrollHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
	{
		// Token: 0x06002577 RID: 9591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002577")]
		[Address(RVA = "0x504AA0", Offset = "0x503EA0", VA = "0x10504AA0")]
		private void Log(string o)
		{
		}

		// Token: 0x06002578 RID: 9592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002578")]
		[Address(RVA = "0x5075B0", Offset = "0x5069B0", VA = "0x105075B0")]
		private void Update()
		{
		}

		// Token: 0x06002579 RID: 9593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002579")]
		[Address(RVA = "0x506470", Offset = "0x505870", VA = "0x10506470", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		// Token: 0x0600257A RID: 9594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600257A")]
		[Address(RVA = "0x506880", Offset = "0x505C80", VA = "0x10506880", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		// Token: 0x0600257B RID: 9595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600257B")]
		[Address(RVA = "0x506C90", Offset = "0x506090", VA = "0x10506C90", Slot = "6")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		// Token: 0x0600257C RID: 9596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600257C")]
		[Address(RVA = "0x505F60", Offset = "0x505360", VA = "0x10505F60", Slot = "7")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		// Token: 0x0600257D RID: 9597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600257D")]
		[Address(RVA = "0x505A50", Offset = "0x504E50", VA = "0x10505A50", Slot = "8")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x0600257E RID: 9598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600257E")]
		[Address(RVA = "0x5071A0", Offset = "0x5065A0", VA = "0x105071A0", Slot = "9")]
		public void OnScroll(PointerEventData eventData)
		{
		}

		// Token: 0x0600257F RID: 9599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600257F")]
		[Address(RVA = "0x504B20", Offset = "0x503F20", VA = "0x10504B20", Slot = "10")]
		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		// Token: 0x06002580 RID: 9600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002580")]
		[Address(RVA = "0x505030", Offset = "0x504430", VA = "0x10505030", Slot = "11")]
		public void OnDrag(PointerEventData eventData)
		{
		}

		// Token: 0x06002581 RID: 9601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002581")]
		[Address(RVA = "0x505540", Offset = "0x504940", VA = "0x10505540", Slot = "12")]
		public void OnEndDrag(PointerEventData eventData)
		{
		}

		// Token: 0x06002582 RID: 9602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002582")]
		[Address(RVA = "0x504940", Offset = "0x503D40", VA = "0x10504940")]
		private static string GetSourceName(PlayerPointerEventData playerEventData)
		{
			return null;
		}

		// Token: 0x06002583 RID: 9603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002583")]
		[Address(RVA = "0x507770", Offset = "0x506B70", VA = "0x10507770")]
		public PlayerPointerEventHandlerExample()
		{
		}

		// Token: 0x0400250A RID: 9482
		[Token(Token = "0x400250A")]
		[FieldOffset(Offset = "0xC")]
		public Text text;

		// Token: 0x0400250B RID: 9483
		[Token(Token = "0x400250B")]
		private const int logLength = 10;

		// Token: 0x0400250C RID: 9484
		[Token(Token = "0x400250C")]
		[FieldOffset(Offset = "0x10")]
		private List<string> log;
	}
}
