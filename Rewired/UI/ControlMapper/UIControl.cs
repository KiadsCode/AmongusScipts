using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x020005A7 RID: 1447
	[Token(Token = "0x20005A7")]
	[Attribute(Name = "AddComponentMenu", RVA = "0xE2DC0", Offset = "0xE21C0")]
	public class UIControl : MonoBehaviour
	{
		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x06002438 RID: 9272 RVA: 0x0000ADB8 File Offset: 0x00008FB8
		[Token(Token = "0x170007C2")]
		public int id
		{
			[Token(Token = "0x6002438")]
			[Address(RVA = "0x273EC0", Offset = "0x2732C0", VA = "0x10273EC0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06002439 RID: 9273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002439")]
		[Address(RVA = "0x4B4B20", Offset = "0x4B3F20", VA = "0x104B4B20")]
		private void Awake()
		{
		}

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x0600243A RID: 9274 RVA: 0x0000ADD0 File Offset: 0x00008FD0
		// (set) Token: 0x0600243B RID: 9275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007C3")]
		public bool showTitle
		{
			[Token(Token = "0x600243A")]
			[Address(RVA = "0x27F3C0", Offset = "0x27E7C0", VA = "0x1027F3C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600243B")]
			[Address(RVA = "0x4B4BC0", Offset = "0x4B3FC0", VA = "0x104B4BC0")]
			set
			{
			}
		}

		// Token: 0x0600243C RID: 9276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600243C")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "4")]
		public virtual void SetCancelCallback(Action cancelCallback)
		{
		}

		// Token: 0x0600243D RID: 9277 RVA: 0x0000ADE8 File Offset: 0x00008FE8
		[Token(Token = "0x600243D")]
		[Address(RVA = "0x4B4B70", Offset = "0x4B3F70", VA = "0x104B4B70")]
		private static int GetNextUid()
		{
			return 0;
		}

		// Token: 0x0600243E RID: 9278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600243E")]
		[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
		public UIControl()
		{
		}

		// Token: 0x0400243B RID: 9275
		[Token(Token = "0x400243B")]
		[FieldOffset(Offset = "0xC")]
		public TMP_Text title;

		// Token: 0x0400243C RID: 9276
		[Token(Token = "0x400243C")]
		[FieldOffset(Offset = "0x10")]
		private int _id;

		// Token: 0x0400243D RID: 9277
		[Token(Token = "0x400243D")]
		[FieldOffset(Offset = "0x14")]
		private bool _showTitle;

		// Token: 0x0400243E RID: 9278
		[Token(Token = "0x400243E")]
		[FieldOffset(Offset = "0x0")]
		private static int _uidCounter;
	}
}
