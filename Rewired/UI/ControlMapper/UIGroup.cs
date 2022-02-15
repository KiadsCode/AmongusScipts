using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x020005AB RID: 1451
	[Token(Token = "0x20005AB")]
	[Attribute(Name = "AddComponentMenu", RVA = "0xE2DC0", Offset = "0xE21C0")]
	public class UIGroup : MonoBehaviour
	{
		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x0600244B RID: 9291 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600244C RID: 9292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007C5")]
		public string labelText
		{
			[Token(Token = "0x600244B")]
			[Address(RVA = "0x4B4E30", Offset = "0x4B4230", VA = "0x104B4E30")]
			get
			{
				return null;
			}
			[Token(Token = "0x600244C")]
			[Address(RVA = "0x4B4ED0", Offset = "0x4B42D0", VA = "0x104B4ED0")]
			set
			{
			}
		}

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x0600244D RID: 9293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007C6")]
		public Transform content
		{
			[Token(Token = "0x600244D")]
			[Address(RVA = "0x273EC0", Offset = "0x2732C0", VA = "0x10273EC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600244E RID: 9294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600244E")]
		[Address(RVA = "0x4B4DA0", Offset = "0x4B41A0", VA = "0x104B4DA0")]
		public void SetLabelActive(bool state)
		{
		}

		// Token: 0x0600244F RID: 9295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600244F")]
		[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
		public UIGroup()
		{
		}

		// Token: 0x04002448 RID: 9288
		[Token(Token = "0x4002448")]
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		private TMP_Text _label;

		// Token: 0x04002449 RID: 9289
		[Token(Token = "0x4002449")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Transform _content;
	}
}
