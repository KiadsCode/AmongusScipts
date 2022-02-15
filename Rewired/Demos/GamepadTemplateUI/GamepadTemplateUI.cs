using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.Demos.GamepadTemplateUI
{
	// Token: 0x020005E3 RID: 1507
	[Token(Token = "0x20005E3")]
	public class GamepadTemplateUI : MonoBehaviour
	{
		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x060025F1 RID: 9713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000804")]
		private Player player
		{
			[Token(Token = "0x60025F1")]
			[Address(RVA = "0x3B5E40", Offset = "0x3B5240", VA = "0x103B5E40")]
			get
			{
				return null;
			}
		}

		// Token: 0x060025F2 RID: 9714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025F2")]
		[Address(RVA = "0x3B45D0", Offset = "0x3B39D0", VA = "0x103B45D0")]
		private void Awake()
		{
		}

		// Token: 0x060025F3 RID: 9715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025F3")]
		[Address(RVA = "0x3B5C70", Offset = "0x3B5070", VA = "0x103B5C70")]
		private void Start()
		{
		}

		// Token: 0x060025F4 RID: 9716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025F4")]
		[Address(RVA = "0x3B5BA0", Offset = "0x3B4FA0", VA = "0x103B5BA0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060025F5 RID: 9717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025F5")]
		[Address(RVA = "0x3B5D10", Offset = "0x3B5110", VA = "0x103B5D10")]
		private void Update()
		{
		}

		// Token: 0x060025F6 RID: 9718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025F6")]
		[Address(RVA = "0x3B5110", Offset = "0x3B4510", VA = "0x103B5110")]
		private void DrawActiveElements()
		{
		}

		// Token: 0x060025F7 RID: 9719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025F7")]
		[Address(RVA = "0x3B42D0", Offset = "0x3B36D0", VA = "0x103B42D0")]
		private void ActivateElements(Player player, int actionId)
		{
		}

		// Token: 0x060025F8 RID: 9720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025F8")]
		[Address(RVA = "0x3B56E0", Offset = "0x3B4AE0", VA = "0x103B56E0")]
		private void DrawLabels()
		{
		}

		// Token: 0x060025F9 RID: 9721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025F9")]
		[Address(RVA = "0x3B5920", Offset = "0x3B4D20", VA = "0x103B5920")]
		private void DrawLabels(Player player, InputAction action)
		{
		}

		// Token: 0x060025FA RID: 9722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025FA")]
		[Address(RVA = "0x3B53C0", Offset = "0x3B47C0", VA = "0x103B53C0")]
		private void DrawLabel(ControllerUIElement uiElement, InputAction action, ControllerMap controllerMap, IControllerTemplate template, IControllerTemplateElement element)
		{
		}

		// Token: 0x060025FB RID: 9723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025FB")]
		[Address(RVA = "0x3B5AF0", Offset = "0x3B4EF0", VA = "0x103B5AF0")]
		private GamepadTemplateUI.Stick GetStick(int elementId)
		{
			return null;
		}

		// Token: 0x060025FC RID: 9724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025FC")]
		[Address(RVA = "0x3B5B80", Offset = "0x3B4F80", VA = "0x103B5B80")]
		private void OnControllerConnected(ControllerStatusChangedEventArgs args)
		{
		}

		// Token: 0x060025FD RID: 9725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025FD")]
		[Address(RVA = "0x3B5B80", Offset = "0x3B4F80", VA = "0x103B5B80")]
		private void OnControllerDisconnected(ControllerStatusChangedEventArgs args)
		{
		}

		// Token: 0x060025FE RID: 9726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025FE")]
		[Address(RVA = "0x3B5DB0", Offset = "0x3B51B0", VA = "0x103B5DB0")]
		public GamepadTemplateUI()
		{
		}

		// Token: 0x04002574 RID: 9588
		[Token(Token = "0x4002574")]
		private const float stickRadius = 20f;

		// Token: 0x04002575 RID: 9589
		[Token(Token = "0x4002575")]
		[FieldOffset(Offset = "0xC")]
		public int playerId;

		// Token: 0x04002576 RID: 9590
		[Token(Token = "0x4002576")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private RectTransform leftStick;

		// Token: 0x04002577 RID: 9591
		[Token(Token = "0x4002577")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private RectTransform rightStick;

		// Token: 0x04002578 RID: 9592
		[Token(Token = "0x4002578")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ControllerUIElement leftStickX;

		// Token: 0x04002579 RID: 9593
		[Token(Token = "0x4002579")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private ControllerUIElement leftStickY;

		// Token: 0x0400257A RID: 9594
		[Token(Token = "0x400257A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ControllerUIElement leftStickButton;

		// Token: 0x0400257B RID: 9595
		[Token(Token = "0x400257B")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private ControllerUIElement rightStickX;

		// Token: 0x0400257C RID: 9596
		[Token(Token = "0x400257C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ControllerUIElement rightStickY;

		// Token: 0x0400257D RID: 9597
		[Token(Token = "0x400257D")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private ControllerUIElement rightStickButton;

		// Token: 0x0400257E RID: 9598
		[Token(Token = "0x400257E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ControllerUIElement actionBottomRow1;

		// Token: 0x0400257F RID: 9599
		[Token(Token = "0x400257F")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private ControllerUIElement actionBottomRow2;

		// Token: 0x04002580 RID: 9600
		[Token(Token = "0x4002580")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ControllerUIElement actionBottomRow3;

		// Token: 0x04002581 RID: 9601
		[Token(Token = "0x4002581")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private ControllerUIElement actionTopRow1;

		// Token: 0x04002582 RID: 9602
		[Token(Token = "0x4002582")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ControllerUIElement actionTopRow2;

		// Token: 0x04002583 RID: 9603
		[Token(Token = "0x4002583")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private ControllerUIElement actionTopRow3;

		// Token: 0x04002584 RID: 9604
		[Token(Token = "0x4002584")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ControllerUIElement leftShoulder;

		// Token: 0x04002585 RID: 9605
		[Token(Token = "0x4002585")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private ControllerUIElement leftTrigger;

		// Token: 0x04002586 RID: 9606
		[Token(Token = "0x4002586")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ControllerUIElement rightShoulder;

		// Token: 0x04002587 RID: 9607
		[Token(Token = "0x4002587")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private ControllerUIElement rightTrigger;

		// Token: 0x04002588 RID: 9608
		[Token(Token = "0x4002588")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ControllerUIElement center1;

		// Token: 0x04002589 RID: 9609
		[Token(Token = "0x4002589")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private ControllerUIElement center2;

		// Token: 0x0400258A RID: 9610
		[Token(Token = "0x400258A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private ControllerUIElement center3;

		// Token: 0x0400258B RID: 9611
		[Token(Token = "0x400258B")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private ControllerUIElement dPadUp;

		// Token: 0x0400258C RID: 9612
		[Token(Token = "0x400258C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private ControllerUIElement dPadRight;

		// Token: 0x0400258D RID: 9613
		[Token(Token = "0x400258D")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private ControllerUIElement dPadDown;

		// Token: 0x0400258E RID: 9614
		[Token(Token = "0x400258E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ControllerUIElement dPadLeft;

		// Token: 0x0400258F RID: 9615
		[Token(Token = "0x400258F")]
		[FieldOffset(Offset = "0x74")]
		private GamepadTemplateUI.UIElement[] _uiElementsArray;

		// Token: 0x04002590 RID: 9616
		[Token(Token = "0x4002590")]
		[FieldOffset(Offset = "0x78")]
		private Dictionary<int, ControllerUIElement> _uiElements;

		// Token: 0x04002591 RID: 9617
		[Token(Token = "0x4002591")]
		[FieldOffset(Offset = "0x7C")]
		private IList<ControllerTemplateElementTarget> _tempTargetList;

		// Token: 0x04002592 RID: 9618
		[Token(Token = "0x4002592")]
		[FieldOffset(Offset = "0x80")]
		private GamepadTemplateUI.Stick[] _sticks;

		// Token: 0x020005E4 RID: 1508
		[Token(Token = "0x20005E4")]
		private class Stick
		{
			// Token: 0x17000805 RID: 2053
			// (get) Token: 0x060025FF RID: 9727 RVA: 0x0000B388 File Offset: 0x00009588
			// (set) Token: 0x06002600 RID: 9728 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000805")]
			public Vector2 position
			{
				[Token(Token = "0x60025FF")]
				[Address(RVA = "0x5A82D0", Offset = "0x5A76D0", VA = "0x105A82D0")]
				get
				{
					return default(Vector2);
				}
				[Token(Token = "0x6002600")]
				[Address(RVA = "0x5A8390", Offset = "0x5A7790", VA = "0x105A8390")]
				set
				{
				}
			}

			// Token: 0x06002601 RID: 9729 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002601")]
			[Address(RVA = "0x5A8210", Offset = "0x5A7610", VA = "0x105A8210")]
			public Stick(RectTransform transform, int xAxisElementId, int yAxisElementId)
			{
			}

			// Token: 0x06002602 RID: 9730 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002602")]
			[Address(RVA = "0x5A7FB0", Offset = "0x5A73B0", VA = "0x105A7FB0")]
			public void Reset()
			{
			}

			// Token: 0x06002603 RID: 9731 RVA: 0x0000B3A0 File Offset: 0x000095A0
			[Token(Token = "0x6002603")]
			[Address(RVA = "0x5A7F30", Offset = "0x5A7330", VA = "0x105A7F30")]
			public bool ContainsElement(int elementId)
			{
				return default(bool);
			}

			// Token: 0x06002604 RID: 9732 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002604")]
			[Address(RVA = "0x5A8050", Offset = "0x5A7450", VA = "0x105A8050")]
			public void SetAxisPosition(int elementId, float value)
			{
			}

			// Token: 0x04002593 RID: 9619
			[Token(Token = "0x4002593")]
			[FieldOffset(Offset = "0x8")]
			private RectTransform _transform;

			// Token: 0x04002594 RID: 9620
			[Token(Token = "0x4002594")]
			[FieldOffset(Offset = "0xC")]
			private Vector2 _origPosition;

			// Token: 0x04002595 RID: 9621
			[Token(Token = "0x4002595")]
			[FieldOffset(Offset = "0x14")]
			private int _xAxisElementId;

			// Token: 0x04002596 RID: 9622
			[Token(Token = "0x4002596")]
			[FieldOffset(Offset = "0x18")]
			private int _yAxisElementId;
		}

		// Token: 0x020005E5 RID: 1509
		[Token(Token = "0x20005E5")]
		private class UIElement
		{
			// Token: 0x06002605 RID: 9733 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002605")]
			[Address(RVA = "0x399E90", Offset = "0x399290", VA = "0x10399E90")]
			public UIElement(int id, ControllerUIElement element)
			{
			}

			// Token: 0x04002597 RID: 9623
			[Token(Token = "0x4002597")]
			[FieldOffset(Offset = "0x8")]
			public int id;

			// Token: 0x04002598 RID: 9624
			[Token(Token = "0x4002598")]
			[FieldOffset(Offset = "0xC")]
			public ControllerUIElement element;
		}
	}
}
