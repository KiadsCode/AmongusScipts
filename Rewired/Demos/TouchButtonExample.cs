using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Rewired.Demos
{
	// Token: 0x020005C6 RID: 1478
	[Token(Token = "0x20005C6")]
	[Attribute(Name = "AddComponentMenu", RVA = "0xE6ED0", Offset = "0xE62D0")]
	[Attribute(Name = "RequireComponent", RVA = "0xE6ED0", Offset = "0xE62D0")]
	public class TouchButtonExample : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x0600253F RID: 9535 RVA: 0x0000B268 File Offset: 0x00009468
		// (set) Token: 0x06002540 RID: 9536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007F3")]
		public bool isPressed
		{
			[Token(Token = "0x600253F")]
			[Address(RVA = "0x2D4E30", Offset = "0x2D4230", VA = "0x102D4E30")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002540")]
			[Address(RVA = "0x2D4E50", Offset = "0x2D4250", VA = "0x102D4E50")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private set
			{
			}
		}

		// Token: 0x06002541 RID: 9537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002541")]
		[Address(RVA = "0x4AF680", Offset = "0x4AEA80", VA = "0x104AF680")]
		private void Awake()
		{
		}

		// Token: 0x06002542 RID: 9538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002542")]
		[Address(RVA = "0x4AF6C0", Offset = "0x4AEAC0", VA = "0x104AF6C0")]
		private void Restart()
		{
		}

		// Token: 0x06002543 RID: 9539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002543")]
		[Address(RVA = "0x4AF6D0", Offset = "0x4AEAD0", VA = "0x104AF6D0", Slot = "4")]
		private void OnPointerDown(PointerEventData eventData)
		{
		}

		// Token: 0x06002544 RID: 9540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002544")]
		[Address(RVA = "0x4AF710", Offset = "0x4AEB10", VA = "0x104AF710", Slot = "5")]
		private void OnPointerUp(PointerEventData eventData)
		{
		}

		// Token: 0x06002545 RID: 9541 RVA: 0x0000B280 File Offset: 0x00009480
		[Token(Token = "0x6002545")]
		[Address(RVA = "0x4AF6A0", Offset = "0x4AEAA0", VA = "0x104AF6A0")]
		private static bool IsMousePointerId(int id)
		{
			return default(bool);
		}

		// Token: 0x06002546 RID: 9542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002546")]
		[Address(RVA = "0x3E8790", Offset = "0x3E7B90", VA = "0x103E8790")]
		public TouchButtonExample()
		{
		}

		// Token: 0x040024D5 RID: 9429
		[Token(Token = "0x40024D5")]
		[FieldOffset(Offset = "0xC")]
		public bool allowMouseControl;

		// Token: 0x040024D6 RID: 9430
		[Token(Token = "0x40024D6")]
		[FieldOffset(Offset = "0xD")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private bool <isPressed>k__BackingField;
	}
}
