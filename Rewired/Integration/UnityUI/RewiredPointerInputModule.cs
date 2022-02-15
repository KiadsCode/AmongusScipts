using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Rewired.UI;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Rewired.Integration.UnityUI
{
	// Token: 0x02000554 RID: 1364
	[Token(Token = "0x2000554")]
	public abstract class RewiredPointerInputModule : BaseInputModule
	{
		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x06001F68 RID: 8040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700063C")]
		private RewiredPointerInputModule.UnityInputSource defaultInputSource
		{
			[Token(Token = "0x6001F68")]
			[Address(RVA = "0x4FB1F0", Offset = "0x4FA5F0", VA = "0x104FB1F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06001F69 RID: 8041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700063D")]
		private IMouseInputSource defaultMouseInputSource
		{
			[Token(Token = "0x6001F69")]
			[Address(RVA = "0x4FB1F0", Offset = "0x4FA5F0", VA = "0x104FB1F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x06001F6A RID: 8042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700063E")]
		protected ITouchInputSource defaultTouchInputSource
		{
			[Token(Token = "0x6001F6A")]
			[Address(RVA = "0x4FB1F0", Offset = "0x4FA5F0", VA = "0x104FB1F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001F6B RID: 8043 RVA: 0x000097B0 File Offset: 0x000079B0
		[Token(Token = "0x6001F6B")]
		[Address(RVA = "0x4FA430", Offset = "0x4F9830", VA = "0x104FA430")]
		protected bool IsDefaultMouse(IMouseInputSource mouse)
		{
			return default(bool);
		}

		// Token: 0x06001F6C RID: 8044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F6C")]
		[Address(RVA = "0x4F93F0", Offset = "0x4F87F0", VA = "0x104F93F0")]
		public IMouseInputSource GetMouseInputSource(int playerId, int mouseIndex)
		{
			return null;
		}

		// Token: 0x06001F6D RID: 8045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F6D")]
		[Address(RVA = "0x4FAB10", Offset = "0x4F9F10", VA = "0x104FAB10")]
		public void RemoveMouseInputSource(IMouseInputSource source)
		{
		}

		// Token: 0x06001F6E RID: 8046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F6E")]
		[Address(RVA = "0x4F8A00", Offset = "0x4F7E00", VA = "0x104F8A00")]
		public void AddMouseInputSource(IMouseInputSource source)
		{
		}

		// Token: 0x06001F6F RID: 8047 RVA: 0x000097C8 File Offset: 0x000079C8
		[Token(Token = "0x6001F6F")]
		[Address(RVA = "0x4F92B0", Offset = "0x4F86B0", VA = "0x104F92B0")]
		public int GetMouseInputSourceCount(int playerId)
		{
			return 0;
		}

		// Token: 0x06001F70 RID: 8048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F70")]
		[Address(RVA = "0x4FA120", Offset = "0x4F9520", VA = "0x104FA120")]
		public ITouchInputSource GetTouchInputSource(int playerId, int sourceIndex)
		{
			return null;
		}

		// Token: 0x06001F71 RID: 8049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F71")]
		[Address(RVA = "0x4FAC40", Offset = "0x4FA040", VA = "0x104FAC40")]
		public void RemoveTouchInputSource(ITouchInputSource source)
		{
		}

		// Token: 0x06001F72 RID: 8050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F72")]
		[Address(RVA = "0x4F8AD0", Offset = "0x4F7ED0", VA = "0x104F8AD0")]
		public void AddTouchInputSource(ITouchInputSource source)
		{
		}

		// Token: 0x06001F73 RID: 8051 RVA: 0x000097E0 File Offset: 0x000079E0
		[Token(Token = "0x6001F73")]
		[Address(RVA = "0x4FA0F0", Offset = "0x4F94F0", VA = "0x104FA0F0")]
		public int GetTouchInputSourceCount(int playerId)
		{
			return 0;
		}

		// Token: 0x06001F74 RID: 8052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F74")]
		[Address(RVA = "0x4F8B80", Offset = "0x4F7F80", VA = "0x104F8B80")]
		protected void ClearMouseInputSources()
		{
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x06001F75 RID: 8053 RVA: 0x000097F8 File Offset: 0x000079F8
		[Token(Token = "0x1700063F")]
		protected virtual bool isMouseSupported
		{
			[Token(Token = "0x6001F75")]
			[Address(RVA = "0x4FB240", Offset = "0x4FA640", VA = "0x104FB240", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001F76 RID: 8054
		[Token(Token = "0x6001F76")]
		protected abstract bool IsDefaultPlayer(int playerId);

		// Token: 0x06001F77 RID: 8055 RVA: 0x00009810 File Offset: 0x00007A10
		[Token(Token = "0x6001F77")]
		[Address(RVA = "0x4F9CC0", Offset = "0x4F90C0", VA = "0x104F9CC0")]
		protected bool GetPointerData(int playerId, int pointerIndex, int pointerTypeId, out PlayerPointerEventData data, bool create, PointerEventType pointerEventType)
		{
			return default(bool);
		}

		// Token: 0x06001F78 RID: 8056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F78")]
		[Address(RVA = "0x4F8EE0", Offset = "0x4F82E0", VA = "0x104F8EE0")]
		private PlayerPointerEventData CreatePointerEventData(int playerId, int pointerIndex, int pointerTypeId, PointerEventType pointerEventType)
		{
			return null;
		}

		// Token: 0x06001F79 RID: 8057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F79")]
		[Address(RVA = "0x4FABA0", Offset = "0x4F9FA0", VA = "0x104FABA0")]
		protected void RemovePointerData(PlayerPointerEventData data)
		{
		}

		// Token: 0x06001F7A RID: 8058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F7A")]
		[Address(RVA = "0x4FA1D0", Offset = "0x4F95D0", VA = "0x104FA1D0")]
		protected PlayerPointerEventData GetTouchPointerEventData(int playerId, int touchDeviceIndex, Touch input, out bool pressed, out bool released)
		{
			return null;
		}

		// Token: 0x06001F7B RID: 8059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F7B")]
		[Address(RVA = "0x4F9590", Offset = "0x4F8990", VA = "0x104F9590", Slot = "28")]
		protected virtual RewiredPointerInputModule.MouseState GetMousePointerEventData(int playerId, int mouseIndex)
		{
			return null;
		}

		// Token: 0x06001F7C RID: 8060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F7C")]
		[Address(RVA = "0x4F90B0", Offset = "0x4F84B0", VA = "0x104F90B0")]
		protected PlayerPointerEventData GetLastPointerEventData(int playerId, int pointerIndex, int pointerTypeId, bool ignorePointerTypeId, PointerEventType pointerEventType)
		{
			return null;
		}

		// Token: 0x06001F7D RID: 8061 RVA: 0x00009828 File Offset: 0x00007A28
		[Token(Token = "0x6001F7D")]
		[Address(RVA = "0x4FACA0", Offset = "0x4FA0A0", VA = "0x104FACA0")]
		private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold)
		{
			return default(bool);
		}

		// Token: 0x06001F7E RID: 8062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F7E")]
		[Address(RVA = "0x4FA9E0", Offset = "0x4F9DE0", VA = "0x104FA9E0", Slot = "29")]
		protected virtual void ProcessMove(PlayerPointerEventData pointerEvent)
		{
		}

		// Token: 0x06001F7F RID: 8063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F7F")]
		[Address(RVA = "0x4FA6B0", Offset = "0x4F9AB0", VA = "0x104FA6B0", Slot = "30")]
		protected virtual void ProcessDrag(PlayerPointerEventData pointerEvent)
		{
		}

		// Token: 0x06001F80 RID: 8064 RVA: 0x00009840 File Offset: 0x00007A40
		[Token(Token = "0x6001F80")]
		[Address(RVA = "0x4FA490", Offset = "0x4F9890", VA = "0x104FA490", Slot = "20")]
		public override bool IsPointerOverGameObject(int pointerTypeId)
		{
			return default(bool);
		}

		// Token: 0x06001F81 RID: 8065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F81")]
		[Address(RVA = "0x4F8BC0", Offset = "0x4F7FC0", VA = "0x104F8BC0")]
		protected void ClearSelection()
		{
		}

		// Token: 0x06001F82 RID: 8066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F82")]
		[Address(RVA = "0x4FAD90", Offset = "0x4FA190", VA = "0x104FAD90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001F83 RID: 8067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F83")]
		[Address(RVA = "0x4F8FE0", Offset = "0x4F83E0", VA = "0x104F8FE0")]
		protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent)
		{
		}

		// Token: 0x06001F84 RID: 8068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F84")]
		[Address(RVA = "0x4F8E30", Offset = "0x4F8230", VA = "0x104F8E30")]
		protected void CopyFromTo(PointerEventData from, PointerEventData to)
		{
		}

		// Token: 0x06001F85 RID: 8069 RVA: 0x00009858 File Offset: 0x00007A58
		[Token(Token = "0x6001F85")]
		[Address(RVA = "0x4FAD00", Offset = "0x4FA100", VA = "0x104FAD00")]
		protected PointerEventData.FramePressState StateForMouseButton(int playerId, int mouseIndex, int buttonId)
		{
			return PointerEventData.FramePressState.Pressed;
		}

		// Token: 0x06001F86 RID: 8070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F86")]
		[Address(RVA = "0x4FB140", Offset = "0x4FA540", VA = "0x104FB140")]
		protected RewiredPointerInputModule()
		{
		}

		// Token: 0x040021D7 RID: 8663
		[Token(Token = "0x40021D7")]
		public const int kMouseLeftId = -1;

		// Token: 0x040021D8 RID: 8664
		[Token(Token = "0x40021D8")]
		public const int kMouseRightId = -2;

		// Token: 0x040021D9 RID: 8665
		[Token(Token = "0x40021D9")]
		public const int kMouseMiddleId = -3;

		// Token: 0x040021DA RID: 8666
		[Token(Token = "0x40021DA")]
		public const int kFakeTouchesId = -4;

		// Token: 0x040021DB RID: 8667
		[Token(Token = "0x40021DB")]
		private const int customButtonsStartingId = -2147483520;

		// Token: 0x040021DC RID: 8668
		[Token(Token = "0x40021DC")]
		private const int customButtonsMaxCount = 128;

		// Token: 0x040021DD RID: 8669
		[Token(Token = "0x40021DD")]
		private const int customButtonsLastId = -2147483392;

		// Token: 0x040021DE RID: 8670
		[Token(Token = "0x40021DE")]
		[FieldOffset(Offset = "0x24")]
		private readonly List<IMouseInputSource> m_MouseInputSourcesList;

		// Token: 0x040021DF RID: 8671
		[Token(Token = "0x40021DF")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<int, Dictionary<int, PlayerPointerEventData>[]> m_PlayerPointerData;

		// Token: 0x040021E0 RID: 8672
		[Token(Token = "0x40021E0")]
		[FieldOffset(Offset = "0x2C")]
		private ITouchInputSource m_UserDefaultTouchInputSource;

		// Token: 0x040021E1 RID: 8673
		[Token(Token = "0x40021E1")]
		[FieldOffset(Offset = "0x30")]
		private RewiredPointerInputModule.UnityInputSource __m_DefaultInputSource;

		// Token: 0x040021E2 RID: 8674
		[Token(Token = "0x40021E2")]
		[FieldOffset(Offset = "0x34")]
		private readonly RewiredPointerInputModule.MouseState m_MouseState;

		// Token: 0x02000555 RID: 1365
		[Token(Token = "0x2000555")]
		protected class MouseState
		{
			// Token: 0x06001F87 RID: 8071 RVA: 0x00009870 File Offset: 0x00007A70
			[Token(Token = "0x6001F87")]
			[Address(RVA = "0x3648C0", Offset = "0x363CC0", VA = "0x103648C0")]
			public bool AnyPressesThisFrame()
			{
				return default(bool);
			}

			// Token: 0x06001F88 RID: 8072 RVA: 0x00009888 File Offset: 0x00007A88
			[Token(Token = "0x6001F88")]
			[Address(RVA = "0x364960", Offset = "0x363D60", VA = "0x10364960")]
			public bool AnyReleasesThisFrame()
			{
				return default(bool);
			}

			// Token: 0x06001F89 RID: 8073 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001F89")]
			[Address(RVA = "0x364A00", Offset = "0x363E00", VA = "0x10364A00")]
			public RewiredPointerInputModule.ButtonState GetButtonState(int button)
			{
				return null;
			}

			// Token: 0x06001F8A RID: 8074 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001F8A")]
			[Address(RVA = "0x364B30", Offset = "0x363F30", VA = "0x10364B30")]
			public void SetButtonState(int button, PointerEventData.FramePressState stateForMouseButton, PlayerPointerEventData data)
			{
			}

			// Token: 0x06001F8B RID: 8075 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001F8B")]
			[Address(RVA = "0x364C80", Offset = "0x364080", VA = "0x10364C80")]
			public MouseState()
			{
			}

			// Token: 0x040021E3 RID: 8675
			[Token(Token = "0x40021E3")]
			[FieldOffset(Offset = "0x8")]
			private List<RewiredPointerInputModule.ButtonState> m_TrackedButtons;
		}

		// Token: 0x02000556 RID: 1366
		[Token(Token = "0x2000556")]
		public class MouseButtonEventData
		{
			// Token: 0x06001F8C RID: 8076 RVA: 0x000098A0 File Offset: 0x00007AA0
			[Token(Token = "0x6001F8C")]
			[Address(RVA = "0x364880", Offset = "0x363C80", VA = "0x10364880")]
			public bool PressedThisFrame()
			{
				return default(bool);
			}

			// Token: 0x06001F8D RID: 8077 RVA: 0x000098B8 File Offset: 0x00007AB8
			[Token(Token = "0x6001F8D")]
			[Address(RVA = "0x3648A0", Offset = "0x363CA0", VA = "0x103648A0")]
			public bool ReleasedThisFrame()
			{
				return default(bool);
			}

			// Token: 0x06001F8E RID: 8078 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001F8E")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public MouseButtonEventData()
			{
			}

			// Token: 0x040021E4 RID: 8676
			[Token(Token = "0x40021E4")]
			[FieldOffset(Offset = "0x8")]
			public PointerEventData.FramePressState buttonState;

			// Token: 0x040021E5 RID: 8677
			[Token(Token = "0x40021E5")]
			[FieldOffset(Offset = "0xC")]
			public PlayerPointerEventData buttonData;
		}

		// Token: 0x02000557 RID: 1367
		[Token(Token = "0x2000557")]
		protected class ButtonState
		{
			// Token: 0x17000640 RID: 1600
			// (get) Token: 0x06001F8F RID: 8079 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06001F90 RID: 8080 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000640")]
			public RewiredPointerInputModule.MouseButtonEventData eventData
			{
				[Token(Token = "0x6001F8F")]
				[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90")]
				get
				{
					return null;
				}
				[Token(Token = "0x6001F90")]
				[Address(RVA = "0x273ED0", Offset = "0x2732D0", VA = "0x10273ED0")]
				set
				{
				}
			}

			// Token: 0x17000641 RID: 1601
			// (get) Token: 0x06001F91 RID: 8081 RVA: 0x000098D0 File Offset: 0x00007AD0
			// (set) Token: 0x06001F92 RID: 8082 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000641")]
			public int button
			{
				[Token(Token = "0x6001F91")]
				[Address(RVA = "0x273EB0", Offset = "0x2732B0", VA = "0x10273EB0")]
				get
				{
					return 0;
				}
				[Token(Token = "0x6001F92")]
				[Address(RVA = "0x273EF0", Offset = "0x2732F0", VA = "0x10273EF0")]
				set
				{
				}
			}

			// Token: 0x06001F93 RID: 8083 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001F93")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public ButtonState()
			{
			}

			// Token: 0x040021E6 RID: 8678
			[Token(Token = "0x40021E6")]
			[FieldOffset(Offset = "0x8")]
			private int m_Button;

			// Token: 0x040021E7 RID: 8679
			[Token(Token = "0x40021E7")]
			[FieldOffset(Offset = "0xC")]
			private RewiredPointerInputModule.MouseButtonEventData m_EventData;
		}

		// Token: 0x02000558 RID: 1368
		[Token(Token = "0x2000558")]
		private sealed class UnityInputSource : IMouseInputSource, ITouchInputSource
		{
			// Token: 0x17000642 RID: 1602
			// (get) Token: 0x06001F94 RID: 8084 RVA: 0x000098E8 File Offset: 0x00007AE8
			[Token(Token = "0x17000642")]
			private int playerId
			{
				[Token(Token = "0x6001F94")]
				[Address(RVA = "0x372DA0", Offset = "0x3721A0", VA = "0x10372DA0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000643 RID: 1603
			// (get) Token: 0x06001F95 RID: 8085 RVA: 0x00009900 File Offset: 0x00007B00
			[Token(Token = "0x17000643")]
			private int playerId
			{
				[Token(Token = "0x6001F95")]
				[Address(RVA = "0x372DA0", Offset = "0x3721A0", VA = "0x10372DA0", Slot = "14")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000644 RID: 1604
			// (get) Token: 0x06001F96 RID: 8086 RVA: 0x00009918 File Offset: 0x00007B18
			[Token(Token = "0x17000644")]
			private bool enabled
			{
				[Token(Token = "0x6001F96")]
				[Address(RVA = "0x372CA0", Offset = "0x3720A0", VA = "0x10372CA0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000645 RID: 1605
			// (get) Token: 0x06001F97 RID: 8087 RVA: 0x00009930 File Offset: 0x00007B30
			[Token(Token = "0x17000645")]
			private bool locked
			{
				[Token(Token = "0x6001F97")]
				[Address(RVA = "0x372D20", Offset = "0x372120", VA = "0x10372D20", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000646 RID: 1606
			// (get) Token: 0x06001F98 RID: 8088 RVA: 0x00009948 File Offset: 0x00007B48
			[Token(Token = "0x17000646")]
			private int buttonCount
			{
				[Token(Token = "0x6001F98")]
				[Address(RVA = "0x372C20", Offset = "0x372020", VA = "0x10372C20", Slot = "7")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06001F99 RID: 8089 RVA: 0x00009960 File Offset: 0x00007B60
			[Token(Token = "0x6001F99")]
			[Address(RVA = "0x372AA0", Offset = "0x371EA0", VA = "0x10372AA0", Slot = "8")]
			private bool GetButtonDown(int button)
			{
				return default(bool);
			}

			// Token: 0x06001F9A RID: 8090 RVA: 0x00009978 File Offset: 0x00007B78
			[Token(Token = "0x6001F9A")]
			[Address(RVA = "0x372B20", Offset = "0x371F20", VA = "0x10372B20", Slot = "9")]
			private bool GetButtonUp(int button)
			{
				return default(bool);
			}

			// Token: 0x06001F9B RID: 8091 RVA: 0x00009990 File Offset: 0x00007B90
			[Token(Token = "0x6001F9B")]
			[Address(RVA = "0x372BA0", Offset = "0x371FA0", VA = "0x10372BA0", Slot = "10")]
			private bool GetButton(int button)
			{
				return default(bool);
			}

			// Token: 0x17000647 RID: 1607
			// (get) Token: 0x06001F9C RID: 8092 RVA: 0x000099A8 File Offset: 0x00007BA8
			[Token(Token = "0x17000647")]
			private Vector2 screenPosition
			{
				[Token(Token = "0x6001F9C")]
				[Address(RVA = "0x372EC0", Offset = "0x3722C0", VA = "0x10372EC0", Slot = "11")]
				get
				{
					return default(Vector2);
				}
			}

			// Token: 0x17000648 RID: 1608
			// (get) Token: 0x06001F9D RID: 8093 RVA: 0x000099C0 File Offset: 0x00007BC0
			[Token(Token = "0x17000648")]
			private Vector2 screenPositionDelta
			{
				[Token(Token = "0x6001F9D")]
				[Address(RVA = "0x372E20", Offset = "0x372220", VA = "0x10372E20", Slot = "12")]
				get
				{
					return default(Vector2);
				}
			}

			// Token: 0x17000649 RID: 1609
			// (get) Token: 0x06001F9E RID: 8094 RVA: 0x000099D8 File Offset: 0x00007BD8
			[Token(Token = "0x17000649")]
			private Vector2 wheelDelta
			{
				[Token(Token = "0x6001F9E")]
				[Address(RVA = "0x372F70", Offset = "0x372370", VA = "0x10372F70", Slot = "13")]
				get
				{
					return default(Vector2);
				}
			}

			// Token: 0x1700064A RID: 1610
			// (get) Token: 0x06001F9F RID: 8095 RVA: 0x000099F0 File Offset: 0x00007BF0
			[Token(Token = "0x1700064A")]
			private bool touchSupported
			{
				[Token(Token = "0x6001F9F")]
				[Address(RVA = "0x373120", Offset = "0x372520", VA = "0x10373120", Slot = "15")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700064B RID: 1611
			// (get) Token: 0x06001FA0 RID: 8096 RVA: 0x00009A08 File Offset: 0x00007C08
			[Token(Token = "0x1700064B")]
			private int touchCount
			{
				[Token(Token = "0x6001FA0")]
				[Address(RVA = "0x3730A0", Offset = "0x3724A0", VA = "0x103730A0", Slot = "16")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06001FA1 RID: 8097 RVA: 0x00009A20 File Offset: 0x00007C20
			[Token(Token = "0x6001FA1")]
			[Address(RVA = "0x372FF0", Offset = "0x3723F0", VA = "0x10372FF0", Slot = "17")]
			private Touch GetTouch(int index)
			{
				return default(Touch);
			}

			// Token: 0x06001FA2 RID: 8098 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001FA2")]
			[Address(RVA = "0x3731A0", Offset = "0x3725A0", VA = "0x103731A0")]
			private void TryUpdate()
			{
			}

			// Token: 0x06001FA3 RID: 8099 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001FA3")]
			[Address(RVA = "0x373210", Offset = "0x372610", VA = "0x10373210")]
			public UnityInputSource()
			{
			}

			// Token: 0x040021E8 RID: 8680
			[Token(Token = "0x40021E8")]
			[FieldOffset(Offset = "0x8")]
			private Vector2 m_MousePosition;

			// Token: 0x040021E9 RID: 8681
			[Token(Token = "0x40021E9")]
			[FieldOffset(Offset = "0x10")]
			private Vector2 m_MousePositionPrev;

			// Token: 0x040021EA RID: 8682
			[Token(Token = "0x40021EA")]
			[FieldOffset(Offset = "0x18")]
			private int m_LastUpdatedFrame;
		}
	}
}
