using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x020005AA RID: 1450
	[Token(Token = "0x20005AA")]
	[Attribute(Name = "AddComponentMenu", RVA = "0xE2DC0", Offset = "0xE21C0")]
	public abstract class UIElementInfo : MonoBehaviour, ISelectHandler, IEventSystemHandler
	{
		// Token: 0x14000017 RID: 23
		// (add) Token: 0x06002447 RID: 9287 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002448 RID: 9288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000017")]
		public event Action<GameObject> OnSelectedEvent
		{
			[Token(Token = "0x6002447")]
			[Address(RVA = "0x4B4CA0", Offset = "0x4B40A0", VA = "0x104B4CA0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			add
			{
			}
			[Token(Token = "0x6002448")]
			[Address(RVA = "0x4B4D20", Offset = "0x4B4120", VA = "0x104B4D20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			remove
			{
			}
		}

		// Token: 0x06002449 RID: 9289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002449")]
		[Address(RVA = "0x4B4C50", Offset = "0x4B4050", VA = "0x104B4C50", Slot = "4")]
		public void OnSelect(BaseEventData eventData)
		{
		}

		// Token: 0x0600244A RID: 9290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600244A")]
		[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
		protected UIElementInfo()
		{
		}

		// Token: 0x04002444 RID: 9284
		[Token(Token = "0x4002444")]
		[FieldOffset(Offset = "0xC")]
		public string identifier;

		// Token: 0x04002445 RID: 9285
		[Token(Token = "0x4002445")]
		[FieldOffset(Offset = "0x10")]
		public int intData;

		// Token: 0x04002446 RID: 9286
		[Token(Token = "0x4002446")]
		[FieldOffset(Offset = "0x14")]
		public TMP_Text text;
	}
}
