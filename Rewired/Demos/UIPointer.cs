using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Rewired.Demos
{
	// Token: 0x020005CF RID: 1487
	[Token(Token = "0x20005CF")]
	[Attribute(Name = "AddComponentMenu", RVA = "0xE7440", Offset = "0xE6840")]
	[Attribute(Name = "RequireComponent", RVA = "0xE7440", Offset = "0xE6840")]
	public sealed class UIPointer : UIBehaviour
	{
		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x06002584 RID: 9604 RVA: 0x0000B2E0 File Offset: 0x000094E0
		// (set) Token: 0x06002585 RID: 9605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007F6")]
		public bool autoSort
		{
			[Token(Token = "0x6002584")]
			[Address(RVA = "0x2D4E30", Offset = "0x2D4230", VA = "0x102D4E30")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002585")]
			[Address(RVA = "0x4B5550", Offset = "0x4B4950", VA = "0x104B5550")]
			set
			{
			}
		}

		// Token: 0x06002586 RID: 9606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002586")]
		[Address(RVA = "0x4B5140", Offset = "0x4B4540", VA = "0x104B5140", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06002587 RID: 9607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002587")]
		[Address(RVA = "0x4B54B0", Offset = "0x4B48B0", VA = "0x104B54B0")]
		private void Update()
		{
		}

		// Token: 0x06002588 RID: 9608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002588")]
		[Address(RVA = "0x4B52D0", Offset = "0x4B46D0", VA = "0x104B52D0", Slot = "12")]
		protected override void OnTransformParentChanged()
		{
		}

		// Token: 0x06002589 RID: 9609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002589")]
		[Address(RVA = "0x4B52D0", Offset = "0x4B46D0", VA = "0x104B52D0", Slot = "14")]
		protected override void OnCanvasGroupChanged()
		{
		}

		// Token: 0x0600258A RID: 9610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600258A")]
		[Address(RVA = "0x4B52F0", Offset = "0x4B46F0", VA = "0x104B52F0")]
		public void OnScreenPositionChanged(Vector2 screenPosition)
		{
		}

		// Token: 0x0600258B RID: 9611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600258B")]
		[Address(RVA = "0x4B5270", Offset = "0x4B4670", VA = "0x104B5270")]
		private void GetDependencies()
		{
		}

		// Token: 0x0600258C RID: 9612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600258C")]
		[Address(RVA = "0x4B5530", Offset = "0x4B4930", VA = "0x104B5530")]
		public UIPointer()
		{
		}

		// Token: 0x0400250D RID: 9485
		[Token(Token = "0x400250D")]
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE74B0", Offset = "0xE68B0")]
		private bool _hideHardwarePointer;

		// Token: 0x0400250E RID: 9486
		[Token(Token = "0x400250E")]
		[FieldOffset(Offset = "0xD")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE74F0", Offset = "0xE68F0")]
		private bool _autoSort;

		// Token: 0x0400250F RID: 9487
		[Token(Token = "0x400250F")]
		[FieldOffset(Offset = "0x10")]
		private Canvas _canvas;
	}
}
