using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x02000563 RID: 1379
	[Token(Token = "0x2000563")]
	[Attribute(Name = "AddComponentMenu", RVA = "0xE2DC0", Offset = "0xE21C0")]
	public class ControlMapper : MonoBehaviour
	{
		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600202F RID: 8239 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002030 RID: 8240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000004")]
		public event Action ScreenClosedEvent
		{
			[Token(Token = "0x600202F")]
			[Address(RVA = "0x437710", Offset = "0x436B10", VA = "0x10437710")]
			add
			{
			}
			[Token(Token = "0x6002030")]
			[Address(RVA = "0x438140", Offset = "0x437540", VA = "0x10438140")]
			remove
			{
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06002031 RID: 8241 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002032 RID: 8242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000005")]
		public event Action ScreenOpenedEvent
		{
			[Token(Token = "0x6002031")]
			[Address(RVA = "0x437770", Offset = "0x436B70", VA = "0x10437770")]
			add
			{
			}
			[Token(Token = "0x6002032")]
			[Address(RVA = "0x4381A0", Offset = "0x4375A0", VA = "0x104381A0")]
			remove
			{
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06002033 RID: 8243 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002034 RID: 8244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000006")]
		public event Action PopupWindowClosedEvent
		{
			[Token(Token = "0x6002033")]
			[Address(RVA = "0x437650", Offset = "0x436A50", VA = "0x10437650")]
			add
			{
			}
			[Token(Token = "0x6002034")]
			[Address(RVA = "0x438080", Offset = "0x437480", VA = "0x10438080")]
			remove
			{
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06002035 RID: 8245 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002036 RID: 8246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000007")]
		public event Action PopupWindowOpenedEvent
		{
			[Token(Token = "0x6002035")]
			[Address(RVA = "0x4376B0", Offset = "0x436AB0", VA = "0x104376B0")]
			add
			{
			}
			[Token(Token = "0x6002036")]
			[Address(RVA = "0x4380E0", Offset = "0x4374E0", VA = "0x104380E0")]
			remove
			{
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06002037 RID: 8247 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002038 RID: 8248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000008")]
		public event Action InputPollingStartedEvent
		{
			[Token(Token = "0x6002037")]
			[Address(RVA = "0x4375F0", Offset = "0x4369F0", VA = "0x104375F0")]
			add
			{
			}
			[Token(Token = "0x6002038")]
			[Address(RVA = "0x438020", Offset = "0x437420", VA = "0x10438020")]
			remove
			{
			}
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06002039 RID: 8249 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600203A RID: 8250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000009")]
		public event Action InputPollingEndedEvent
		{
			[Token(Token = "0x6002039")]
			[Address(RVA = "0x437590", Offset = "0x436990", VA = "0x10437590")]
			add
			{
			}
			[Token(Token = "0x600203A")]
			[Address(RVA = "0x437FC0", Offset = "0x4373C0", VA = "0x10437FC0")]
			remove
			{
			}
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x0600203B RID: 8251 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600203C RID: 8252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400000A")]
		public event UnityAction onScreenClosed
		{
			[Token(Token = "0x600203B")]
			[Address(RVA = "0x437890", Offset = "0x436C90", VA = "0x10437890")]
			add
			{
			}
			[Token(Token = "0x600203C")]
			[Address(RVA = "0x4382C0", Offset = "0x4376C0", VA = "0x104382C0")]
			remove
			{
			}
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x0600203D RID: 8253 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600203E RID: 8254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400000B")]
		public event UnityAction onScreenOpened
		{
			[Token(Token = "0x600203D")]
			[Address(RVA = "0x4378C0", Offset = "0x436CC0", VA = "0x104378C0")]
			add
			{
			}
			[Token(Token = "0x600203E")]
			[Address(RVA = "0x4382F0", Offset = "0x4376F0", VA = "0x104382F0")]
			remove
			{
			}
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x0600203F RID: 8255 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002040 RID: 8256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400000C")]
		public event UnityAction onPopupWindowClosed
		{
			[Token(Token = "0x600203F")]
			[Address(RVA = "0x437830", Offset = "0x436C30", VA = "0x10437830")]
			add
			{
			}
			[Token(Token = "0x6002040")]
			[Address(RVA = "0x438260", Offset = "0x437660", VA = "0x10438260")]
			remove
			{
			}
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06002041 RID: 8257 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002042 RID: 8258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400000D")]
		public event UnityAction onPopupWindowOpened
		{
			[Token(Token = "0x6002041")]
			[Address(RVA = "0x437860", Offset = "0x436C60", VA = "0x10437860")]
			add
			{
			}
			[Token(Token = "0x6002042")]
			[Address(RVA = "0x438290", Offset = "0x437690", VA = "0x10438290")]
			remove
			{
			}
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x06002043 RID: 8259 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002044 RID: 8260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400000E")]
		public event UnityAction onInputPollingStarted
		{
			[Token(Token = "0x6002043")]
			[Address(RVA = "0x437800", Offset = "0x436C00", VA = "0x10437800")]
			add
			{
			}
			[Token(Token = "0x6002044")]
			[Address(RVA = "0x438230", Offset = "0x437630", VA = "0x10438230")]
			remove
			{
			}
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x06002045 RID: 8261 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002046 RID: 8262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400000F")]
		public event UnityAction onInputPollingEnded
		{
			[Token(Token = "0x6002045")]
			[Address(RVA = "0x4377D0", Offset = "0x436BD0", VA = "0x104377D0")]
			add
			{
			}
			[Token(Token = "0x6002046")]
			[Address(RVA = "0x438200", Offset = "0x437600", VA = "0x10438200")]
			remove
			{
			}
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x06002047 RID: 8263 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002048 RID: 8264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000669")]
		public InputManager rewiredInputManager
		{
			[Token(Token = "0x6002047")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002048")]
			[Address(RVA = "0x438880", Offset = "0x437C80", VA = "0x10438880")]
			set
			{
			}
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x06002049 RID: 8265 RVA: 0x00009DF8 File Offset: 0x00007FF8
		// (set) Token: 0x0600204A RID: 8266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700066A")]
		public bool dontDestroyOnLoad
		{
			[Token(Token = "0x6002049")]
			[Address(RVA = "0x274CF0", Offset = "0x2740F0", VA = "0x10274CF0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600204A")]
			[Address(RVA = "0x438470", Offset = "0x437870", VA = "0x10438470")]
			set
			{
			}
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x0600204B RID: 8267 RVA: 0x00009E10 File Offset: 0x00008010
		// (set) Token: 0x0600204C RID: 8268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700066B")]
		public int keyboardMapDefaultLayout
		{
			[Token(Token = "0x600204B")]
			[Address(RVA = "0x273EA0", Offset = "0x2732A0", VA = "0x10273EA0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600204C")]
			[Address(RVA = "0x4386B0", Offset = "0x437AB0", VA = "0x104386B0")]
			set
			{
			}
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x0600204D RID: 8269 RVA: 0x00009E28 File Offset: 0x00008028
		// (set) Token: 0x0600204E RID: 8270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700066C")]
		public int mouseMapDefaultLayout
		{
			[Token(Token = "0x600204D")]
			[Address(RVA = "0x277A30", Offset = "0x276E30", VA = "0x10277A30")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600204E")]
			[Address(RVA = "0x438810", Offset = "0x437C10", VA = "0x10438810")]
			set
			{
			}
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x0600204F RID: 8271 RVA: 0x00009E40 File Offset: 0x00008040
		// (set) Token: 0x06002050 RID: 8272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700066D")]
		public int joystickMapDefaultLayout
		{
			[Token(Token = "0x600204F")]
			[Address(RVA = "0x277A40", Offset = "0x276E40", VA = "0x10277A40")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002050")]
			[Address(RVA = "0x438620", Offset = "0x437A20", VA = "0x10438620")]
			set
			{
			}
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x06002051 RID: 8273 RVA: 0x00009E58 File Offset: 0x00008058
		// (set) Token: 0x06002052 RID: 8274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700066E")]
		public bool showPlayers
		{
			[Token(Token = "0x6002051")]
			[Address(RVA = "0x437EE0", Offset = "0x4372E0", VA = "0x10437EE0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002052")]
			[Address(RVA = "0x438AF0", Offset = "0x437EF0", VA = "0x10438AF0")]
			set
			{
			}
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06002053 RID: 8275 RVA: 0x00009E70 File Offset: 0x00008070
		// (set) Token: 0x06002054 RID: 8276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700066F")]
		public bool showControllers
		{
			[Token(Token = "0x6002053")]
			[Address(RVA = "0x31AB20", Offset = "0x319F20", VA = "0x1031AB20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002054")]
			[Address(RVA = "0x4389A0", Offset = "0x437DA0", VA = "0x104389A0")]
			set
			{
			}
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x06002055 RID: 8277 RVA: 0x00009E88 File Offset: 0x00008088
		// (set) Token: 0x06002056 RID: 8278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000670")]
		public bool showKeyboard
		{
			[Token(Token = "0x6002055")]
			[Address(RVA = "0x437E80", Offset = "0x437280", VA = "0x10437E80")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002056")]
			[Address(RVA = "0x438A30", Offset = "0x437E30", VA = "0x10438A30")]
			set
			{
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x06002057 RID: 8279 RVA: 0x00009EA0 File Offset: 0x000080A0
		// (set) Token: 0x06002058 RID: 8280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000671")]
		public bool showMouse
		{
			[Token(Token = "0x6002057")]
			[Address(RVA = "0x437EC0", Offset = "0x4372C0", VA = "0x10437EC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002058")]
			[Address(RVA = "0x438A90", Offset = "0x437E90", VA = "0x10438A90")]
			set
			{
			}
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x06002059 RID: 8281 RVA: 0x00009EB8 File Offset: 0x000080B8
		// (set) Token: 0x0600205A RID: 8282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000672")]
		public int maxControllersPerPlayer
		{
			[Token(Token = "0x6002059")]
			[Address(RVA = "0x2D5F80", Offset = "0x2D5380", VA = "0x102D5F80")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600205A")]
			[Address(RVA = "0x438780", Offset = "0x437B80", VA = "0x10438780")]
			set
			{
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x0600205B RID: 8283 RVA: 0x00009ED0 File Offset: 0x000080D0
		// (set) Token: 0x0600205C RID: 8284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000673")]
		public bool showActionCategoryLabels
		{
			[Token(Token = "0x600205B")]
			[Address(RVA = "0x2E9910", Offset = "0x2E8D10", VA = "0x102E9910")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600205C")]
			[Address(RVA = "0x4388B0", Offset = "0x437CB0", VA = "0x104388B0")]
			set
			{
			}
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x0600205D RID: 8285 RVA: 0x00009EE8 File Offset: 0x000080E8
		// (set) Token: 0x0600205E RID: 8286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000674")]
		public int keyboardInputFieldCount
		{
			[Token(Token = "0x600205D")]
			[Address(RVA = "0x298EF0", Offset = "0x2982F0", VA = "0x10298EF0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600205E")]
			[Address(RVA = "0x438680", Offset = "0x437A80", VA = "0x10438680")]
			set
			{
			}
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x0600205F RID: 8287 RVA: 0x00009F00 File Offset: 0x00008100
		// (set) Token: 0x06002060 RID: 8288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000675")]
		public int mouseInputFieldCount
		{
			[Token(Token = "0x600205F")]
			[Address(RVA = "0x328160", Offset = "0x327560", VA = "0x10328160")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002060")]
			[Address(RVA = "0x4387E0", Offset = "0x437BE0", VA = "0x104387E0")]
			set
			{
			}
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x06002061 RID: 8289 RVA: 0x00009F18 File Offset: 0x00008118
		// (set) Token: 0x06002062 RID: 8290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000676")]
		public int controllerInputFieldCount
		{
			[Token(Token = "0x6002061")]
			[Address(RVA = "0x278060", Offset = "0x277460", VA = "0x10278060")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002062")]
			[Address(RVA = "0x4383E0", Offset = "0x4377E0", VA = "0x104383E0")]
			set
			{
			}
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06002063 RID: 8291 RVA: 0x00009F30 File Offset: 0x00008130
		// (set) Token: 0x06002064 RID: 8292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000677")]
		public bool showFullAxisInputFields
		{
			[Token(Token = "0x6002063")]
			[Address(RVA = "0x437E60", Offset = "0x437260", VA = "0x10437E60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002064")]
			[Address(RVA = "0x4389D0", Offset = "0x437DD0", VA = "0x104389D0")]
			set
			{
			}
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x06002065 RID: 8293 RVA: 0x00009F48 File Offset: 0x00008148
		// (set) Token: 0x06002066 RID: 8294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000678")]
		public bool showSplitAxisInputFields
		{
			[Token(Token = "0x6002065")]
			[Address(RVA = "0x437F90", Offset = "0x437390", VA = "0x10437F90")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002066")]
			[Address(RVA = "0x438B50", Offset = "0x437F50", VA = "0x10438B50")]
			set
			{
			}
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06002067 RID: 8295 RVA: 0x00009F60 File Offset: 0x00008160
		// (set) Token: 0x06002068 RID: 8296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000679")]
		public bool allowElementAssignmentConflicts
		{
			[Token(Token = "0x6002067")]
			[Address(RVA = "0x4378F0", Offset = "0x436CF0", VA = "0x104378F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002068")]
			[Address(RVA = "0x438350", Offset = "0x437750", VA = "0x10438350")]
			set
			{
			}
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06002069 RID: 8297 RVA: 0x00009F78 File Offset: 0x00008178
		// (set) Token: 0x0600206A RID: 8298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700067A")]
		public bool allowElementAssignmentSwap
		{
			[Token(Token = "0x6002069")]
			[Address(RVA = "0x437900", Offset = "0x436D00", VA = "0x10437900")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600206A")]
			[Address(RVA = "0x438360", Offset = "0x437760", VA = "0x10438360")]
			set
			{
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x0600206B RID: 8299 RVA: 0x00009F90 File Offset: 0x00008190
		// (set) Token: 0x0600206C RID: 8300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700067B")]
		public int actionLabelWidth
		{
			[Token(Token = "0x600206B")]
			[Address(RVA = "0x2786E0", Offset = "0x277AE0", VA = "0x102786E0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600206C")]
			[Address(RVA = "0x438320", Offset = "0x437720", VA = "0x10438320")]
			set
			{
			}
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x0600206D RID: 8301 RVA: 0x00009FA8 File Offset: 0x000081A8
		// (set) Token: 0x0600206E RID: 8302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700067C")]
		public int keyboardColMaxWidth
		{
			[Token(Token = "0x600206D")]
			[Address(RVA = "0x27B280", Offset = "0x27A680", VA = "0x1027B280")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600206E")]
			[Address(RVA = "0x438650", Offset = "0x437A50", VA = "0x10438650")]
			set
			{
			}
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x0600206F RID: 8303 RVA: 0x00009FC0 File Offset: 0x000081C0
		// (set) Token: 0x06002070 RID: 8304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700067D")]
		public int mouseColMaxWidth
		{
			[Token(Token = "0x600206F")]
			[Address(RVA = "0x3C16E0", Offset = "0x3C0AE0", VA = "0x103C16E0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002070")]
			[Address(RVA = "0x4387B0", Offset = "0x437BB0", VA = "0x104387B0")]
			set
			{
			}
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06002071 RID: 8305 RVA: 0x00009FD8 File Offset: 0x000081D8
		// (set) Token: 0x06002072 RID: 8306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700067E")]
		public int controllerColMaxWidth
		{
			[Token(Token = "0x6002071")]
			[Address(RVA = "0x3C0AA0", Offset = "0x3BFEA0", VA = "0x103C0AA0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002072")]
			[Address(RVA = "0x4383B0", Offset = "0x4377B0", VA = "0x104383B0")]
			set
			{
			}
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x06002073 RID: 8307 RVA: 0x00009FF0 File Offset: 0x000081F0
		// (set) Token: 0x06002074 RID: 8308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700067F")]
		public int inputRowHeight
		{
			[Token(Token = "0x6002073")]
			[Address(RVA = "0x3C1650", Offset = "0x3C0A50", VA = "0x103C1650")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002074")]
			[Address(RVA = "0x4385C0", Offset = "0x4379C0", VA = "0x104385C0")]
			set
			{
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06002075 RID: 8309 RVA: 0x0000A008 File Offset: 0x00008208
		// (set) Token: 0x06002076 RID: 8310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000680")]
		public int inputColumnSpacing
		{
			[Token(Token = "0x6002075")]
			[Address(RVA = "0x3C1640", Offset = "0x3C0A40", VA = "0x103C1640")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002076")]
			[Address(RVA = "0x438560", Offset = "0x437960", VA = "0x10438560")]
			set
			{
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06002077 RID: 8311 RVA: 0x0000A020 File Offset: 0x00008220
		// (set) Token: 0x06002078 RID: 8312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000681")]
		public int inputRowCategorySpacing
		{
			[Token(Token = "0x6002077")]
			[Address(RVA = "0x3C1670", Offset = "0x3C0A70", VA = "0x103C1670")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002078")]
			[Address(RVA = "0x438590", Offset = "0x437990", VA = "0x10438590")]
			set
			{
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06002079 RID: 8313 RVA: 0x0000A038 File Offset: 0x00008238
		// (set) Token: 0x0600207A RID: 8314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000682")]
		public int invertToggleWidth
		{
			[Token(Token = "0x6002079")]
			[Address(RVA = "0x3C1710", Offset = "0x3C0B10", VA = "0x103C1710")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600207A")]
			[Address(RVA = "0x4385F0", Offset = "0x4379F0", VA = "0x104385F0")]
			set
			{
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x0600207B RID: 8315 RVA: 0x0000A050 File Offset: 0x00008250
		// (set) Token: 0x0600207C RID: 8316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000683")]
		public int defaultWindowWidth
		{
			[Token(Token = "0x600207B")]
			[Address(RVA = "0x3C1660", Offset = "0x3C0A60", VA = "0x103C1660")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600207C")]
			[Address(RVA = "0x438440", Offset = "0x437840", VA = "0x10438440")]
			set
			{
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x0600207D RID: 8317 RVA: 0x0000A068 File Offset: 0x00008268
		// (set) Token: 0x0600207E RID: 8318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000684")]
		public int defaultWindowHeight
		{
			[Token(Token = "0x600207D")]
			[Address(RVA = "0x3C1680", Offset = "0x3C0A80", VA = "0x103C1680")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600207E")]
			[Address(RVA = "0x438410", Offset = "0x437810", VA = "0x10438410")]
			set
			{
			}
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x0600207F RID: 8319 RVA: 0x0000A080 File Offset: 0x00008280
		// (set) Token: 0x06002080 RID: 8320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000685")]
		public float controllerAssignmentTimeout
		{
			[Token(Token = "0x600207F")]
			[Address(RVA = "0x437920", Offset = "0x436D20", VA = "0x10437920")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002080")]
			[Address(RVA = "0x438390", Offset = "0x437790", VA = "0x10438390")]
			set
			{
			}
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06002081 RID: 8321 RVA: 0x0000A098 File Offset: 0x00008298
		// (set) Token: 0x06002082 RID: 8322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000686")]
		public float preInputAssignmentTimeout
		{
			[Token(Token = "0x6002081")]
			[Address(RVA = "0x437E00", Offset = "0x437200", VA = "0x10437E00")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002082")]
			[Address(RVA = "0x438840", Offset = "0x437C40", VA = "0x10438840")]
			set
			{
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06002083 RID: 8323 RVA: 0x0000A0B0 File Offset: 0x000082B0
		// (set) Token: 0x06002084 RID: 8324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000687")]
		public float inputAssignmentTimeout
		{
			[Token(Token = "0x6002083")]
			[Address(RVA = "0x437C10", Offset = "0x437010", VA = "0x10437C10")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002084")]
			[Address(RVA = "0x438540", Offset = "0x437940", VA = "0x10438540")]
			set
			{
			}
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x06002085 RID: 8325 RVA: 0x0000A0C8 File Offset: 0x000082C8
		// (set) Token: 0x06002086 RID: 8326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000688")]
		public float axisCalibrationTimeout
		{
			[Token(Token = "0x6002085")]
			[Address(RVA = "0x437910", Offset = "0x436D10", VA = "0x10437910")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002086")]
			[Address(RVA = "0x438370", Offset = "0x437770", VA = "0x10438370")]
			set
			{
			}
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x06002087 RID: 8327 RVA: 0x0000A0E0 File Offset: 0x000082E0
		// (set) Token: 0x06002088 RID: 8328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000689")]
		public bool ignoreMouseXAxisAssignment
		{
			[Token(Token = "0x6002087")]
			[Address(RVA = "0x437BB0", Offset = "0x436FB0", VA = "0x10437BB0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002088")]
			[Address(RVA = "0x438500", Offset = "0x437900", VA = "0x10438500")]
			set
			{
			}
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x06002089 RID: 8329 RVA: 0x0000A0F8 File Offset: 0x000082F8
		// (set) Token: 0x0600208A RID: 8330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700068A")]
		public bool ignoreMouseYAxisAssignment
		{
			[Token(Token = "0x6002089")]
			[Address(RVA = "0x437BC0", Offset = "0x436FC0", VA = "0x10437BC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600208A")]
			[Address(RVA = "0x438520", Offset = "0x437920", VA = "0x10438520")]
			set
			{
			}
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x0600208B RID: 8331 RVA: 0x0000A110 File Offset: 0x00008310
		// (set) Token: 0x0600208C RID: 8332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700068B")]
		public bool universalCancelClosesScreen
		{
			[Token(Token = "0x600208B")]
			[Address(RVA = "0x437FA0", Offset = "0x4373A0", VA = "0x10437FA0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600208C")]
			[Address(RVA = "0x438B80", Offset = "0x437F80", VA = "0x10438B80")]
			set
			{
			}
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x0600208D RID: 8333 RVA: 0x0000A128 File Offset: 0x00008328
		// (set) Token: 0x0600208E RID: 8334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700068C")]
		public bool showInputBehaviorSettings
		{
			[Token(Token = "0x600208D")]
			[Address(RVA = "0x437E70", Offset = "0x437270", VA = "0x10437E70")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600208E")]
			[Address(RVA = "0x438A00", Offset = "0x437E00", VA = "0x10438A00")]
			set
			{
			}
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x0600208F RID: 8335 RVA: 0x0000A140 File Offset: 0x00008340
		// (set) Token: 0x06002090 RID: 8336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700068D")]
		public bool useThemeSettings
		{
			[Token(Token = "0x600208F")]
			[Address(RVA = "0x437FB0", Offset = "0x4373B0", VA = "0x10437FB0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002090")]
			[Address(RVA = "0x438BA0", Offset = "0x437FA0", VA = "0x10438BA0")]
			set
			{
			}
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x06002091 RID: 8337 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002092 RID: 8338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700068E")]
		public LanguageDataBase language
		{
			[Token(Token = "0x6002091")]
			[Address(RVA = "0x437DF0", Offset = "0x4371F0", VA = "0x10437DF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002092")]
			[Address(RVA = "0x4386E0", Offset = "0x437AE0", VA = "0x104386E0")]
			set
			{
			}
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x06002093 RID: 8339 RVA: 0x0000A158 File Offset: 0x00008358
		// (set) Token: 0x06002094 RID: 8340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700068F")]
		public bool showPlayersGroupLabel
		{
			[Token(Token = "0x6002093")]
			[Address(RVA = "0x437ED0", Offset = "0x4372D0", VA = "0x10437ED0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002094")]
			[Address(RVA = "0x438AC0", Offset = "0x437EC0", VA = "0x10438AC0")]
			set
			{
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x06002095 RID: 8341 RVA: 0x0000A170 File Offset: 0x00008370
		// (set) Token: 0x06002096 RID: 8342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000690")]
		public bool showControllerGroupLabel
		{
			[Token(Token = "0x6002095")]
			[Address(RVA = "0x437E40", Offset = "0x437240", VA = "0x10437E40")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002096")]
			[Address(RVA = "0x438940", Offset = "0x437D40", VA = "0x10438940")]
			set
			{
			}
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06002097 RID: 8343 RVA: 0x0000A188 File Offset: 0x00008388
		// (set) Token: 0x06002098 RID: 8344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000691")]
		public bool showAssignedControllersGroupLabel
		{
			[Token(Token = "0x6002097")]
			[Address(RVA = "0x437E20", Offset = "0x437220", VA = "0x10437E20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002098")]
			[Address(RVA = "0x4388E0", Offset = "0x437CE0", VA = "0x104388E0")]
			set
			{
			}
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x06002099 RID: 8345 RVA: 0x0000A1A0 File Offset: 0x000083A0
		// (set) Token: 0x0600209A RID: 8346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000692")]
		public bool showSettingsGroupLabel
		{
			[Token(Token = "0x6002099")]
			[Address(RVA = "0x437F50", Offset = "0x437350", VA = "0x10437F50")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600209A")]
			[Address(RVA = "0x438B20", Offset = "0x437F20", VA = "0x10438B20")]
			set
			{
			}
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x0600209B RID: 8347 RVA: 0x0000A1B8 File Offset: 0x000083B8
		// (set) Token: 0x0600209C RID: 8348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000693")]
		public bool showMapCategoriesGroupLabel
		{
			[Token(Token = "0x600209B")]
			[Address(RVA = "0x437E90", Offset = "0x437290", VA = "0x10437E90")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600209C")]
			[Address(RVA = "0x438A60", Offset = "0x437E60", VA = "0x10438A60")]
			set
			{
			}
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x0600209D RID: 8349 RVA: 0x0000A1D0 File Offset: 0x000083D0
		// (set) Token: 0x0600209E RID: 8350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000694")]
		public bool showControllerNameLabel
		{
			[Token(Token = "0x600209D")]
			[Address(RVA = "0x437E50", Offset = "0x437250", VA = "0x10437E50")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600209E")]
			[Address(RVA = "0x438970", Offset = "0x437D70", VA = "0x10438970")]
			set
			{
			}
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x0600209F RID: 8351 RVA: 0x0000A1E8 File Offset: 0x000083E8
		// (set) Token: 0x060020A0 RID: 8352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000695")]
		public bool showAssignedControllers
		{
			[Token(Token = "0x600209F")]
			[Address(RVA = "0x437E30", Offset = "0x437230", VA = "0x10437E30")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60020A0")]
			[Address(RVA = "0x438910", Offset = "0x437D10", VA = "0x10438910")]
			set
			{
			}
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x060020A1 RID: 8353 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060020A2 RID: 8354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000696")]
		public Action restoreDefaultsDelegate
		{
			[Token(Token = "0x60020A1")]
			[Address(RVA = "0x437E10", Offset = "0x437210", VA = "0x10437E10")]
			get
			{
				return null;
			}
			[Token(Token = "0x60020A2")]
			[Address(RVA = "0x438860", Offset = "0x437C60", VA = "0x10438860")]
			set
			{
			}
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x060020A3 RID: 8355 RVA: 0x0000A200 File Offset: 0x00008400
		[Token(Token = "0x17000697")]
		public bool isOpen
		{
			[Token(Token = "0x60020A3")]
			[Address(RVA = "0x437D20", Offset = "0x437120", VA = "0x10437D20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x060020A4 RID: 8356 RVA: 0x0000A218 File Offset: 0x00008418
		[Token(Token = "0x17000698")]
		private bool isFocused
		{
			[Token(Token = "0x60020A4")]
			[Address(RVA = "0x437CC0", Offset = "0x4370C0", VA = "0x10437CC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x060020A5 RID: 8357 RVA: 0x0000A230 File Offset: 0x00008430
		[Token(Token = "0x17000699")]
		private bool inputAllowed
		{
			[Token(Token = "0x60020A5")]
			[Address(RVA = "0x437BD0", Offset = "0x436FD0", VA = "0x10437BD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x060020A6 RID: 8358 RVA: 0x0000A248 File Offset: 0x00008448
		[Token(Token = "0x1700069A")]
		private int inputGridColumnCount
		{
			[Token(Token = "0x60020A6")]
			[Address(RVA = "0x437C20", Offset = "0x437020", VA = "0x10437C20")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x060020A7 RID: 8359 RVA: 0x0000A260 File Offset: 0x00008460
		[Token(Token = "0x1700069B")]
		private int inputGridWidth
		{
			[Token(Token = "0x60020A7")]
			[Address(RVA = "0x437C50", Offset = "0x437050", VA = "0x10437C50")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x060020A8 RID: 8360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700069C")]
		private Player currentPlayer
		{
			[Token(Token = "0x60020A8")]
			[Address(RVA = "0x437A80", Offset = "0x436E80", VA = "0x10437A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x060020A9 RID: 8361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700069D")]
		private InputCategory currentMapCategory
		{
			[Token(Token = "0x60020A9")]
			[Address(RVA = "0x4379A0", Offset = "0x436DA0", VA = "0x104379A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x060020AA RID: 8362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700069E")]
		private ControlMapper.MappingSet currentMappingSet
		{
			[Token(Token = "0x60020AA")]
			[Address(RVA = "0x437A10", Offset = "0x436E10", VA = "0x10437A10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x060020AB RID: 8363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700069F")]
		private Joystick currentJoystick
		{
			[Token(Token = "0x60020AB")]
			[Address(RVA = "0x437930", Offset = "0x436D30", VA = "0x10437930")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x060020AC RID: 8364 RVA: 0x0000A278 File Offset: 0x00008478
		[Token(Token = "0x170006A0")]
		private bool isJoystickSelected
		{
			[Token(Token = "0x60020AC")]
			[Address(RVA = "0x437D00", Offset = "0x437100", VA = "0x10437D00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x060020AD RID: 8365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006A1")]
		private GameObject currentUISelection
		{
			[Token(Token = "0x60020AD")]
			[Address(RVA = "0x437AF0", Offset = "0x436EF0", VA = "0x10437AF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x060020AE RID: 8366 RVA: 0x0000A290 File Offset: 0x00008490
		[Token(Token = "0x170006A2")]
		private bool showSettings
		{
			[Token(Token = "0x60020AE")]
			[Address(RVA = "0x437F60", Offset = "0x437360", VA = "0x10437F60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x060020AF RID: 8367 RVA: 0x0000A2A8 File Offset: 0x000084A8
		[Token(Token = "0x170006A3")]
		private bool showMapCategories
		{
			[Token(Token = "0x60020AF")]
			[Address(RVA = "0x437EA0", Offset = "0x4372A0", VA = "0x10437EA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060020B0 RID: 8368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020B0")]
		[Address(RVA = "0x426B20", Offset = "0x425F20", VA = "0x10426B20")]
		private void Awake()
		{
		}

		// Token: 0x060020B1 RID: 8369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020B1")]
		[Address(RVA = "0x4369F0", Offset = "0x435DF0", VA = "0x104369F0")]
		private void Start()
		{
		}

		// Token: 0x060020B2 RID: 8370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020B2")]
		[Address(RVA = "0x437310", Offset = "0x436710", VA = "0x10437310")]
		private void Update()
		{
		}

		// Token: 0x060020B3 RID: 8371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020B3")]
		[Address(RVA = "0x42DCD0", Offset = "0x42D0D0", VA = "0x1042DCD0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060020B4 RID: 8372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020B4")]
		[Address(RVA = "0x4310B0", Offset = "0x4304B0", VA = "0x104310B0")]
		private void PreInitialize()
		{
		}

		// Token: 0x060020B5 RID: 8373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020B5")]
		[Address(RVA = "0x42BE20", Offset = "0x42B220", VA = "0x1042BE20")]
		private void Initialize()
		{
		}

		// Token: 0x060020B6 RID: 8374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020B6")]
		[Address(RVA = "0x42EAD0", Offset = "0x42DED0", VA = "0x1042EAD0")]
		private void OnJoystickConnected(ControllerStatusChangedEventArgs args)
		{
		}

		// Token: 0x060020B7 RID: 8375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020B7")]
		[Address(RVA = "0x42EAD0", Offset = "0x42DED0", VA = "0x1042EAD0")]
		private void OnJoystickDisconnected(ControllerStatusChangedEventArgs args)
		{
		}

		// Token: 0x060020B8 RID: 8376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020B8")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680")]
		private void OnJoystickPreDisconnect(ControllerStatusChangedEventArgs args)
		{
		}

		// Token: 0x060020B9 RID: 8377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020B9")]
		[Address(RVA = "0x42D4B0", Offset = "0x42C8B0", VA = "0x1042D4B0")]
		public void OnButtonActivated(ButtonInfo buttonInfo)
		{
		}

		// Token: 0x060020BA RID: 8378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020BA")]
		[Address(RVA = "0x42E770", Offset = "0x42DB70", VA = "0x1042E770")]
		public void OnInputFieldActivated(InputFieldInfo fieldInfo)
		{
		}

		// Token: 0x060020BB RID: 8379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020BB")]
		[Address(RVA = "0x42E9E0", Offset = "0x42DDE0", VA = "0x1042E9E0")]
		public void OnInputFieldInvertToggleStateChanged(ToggleInfo toggleInfo, bool newState)
		{
		}

		// Token: 0x060020BC RID: 8380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020BC")]
		[Address(RVA = "0x42F870", Offset = "0x42EC70", VA = "0x1042F870")]
		private void OnPlayerSelected(int playerId, bool redraw)
		{
		}

		// Token: 0x060020BD RID: 8381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020BD")]
		[Address(RVA = "0x42DCA0", Offset = "0x42D0A0", VA = "0x1042DCA0")]
		private void OnControllerSelected(int joystickId)
		{
		}

		// Token: 0x060020BE RID: 8382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020BE")]
		[Address(RVA = "0x42F8C0", Offset = "0x42ECC0", VA = "0x1042F8C0")]
		private void OnRemoveCurrentController()
		{
		}

		// Token: 0x060020BF RID: 8383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020BF")]
		[Address(RVA = "0x42F0F0", Offset = "0x42E4F0", VA = "0x1042F0F0")]
		private void OnMapCategorySelected(int id, bool redraw)
		{
		}

		// Token: 0x060020C0 RID: 8384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020C0")]
		[Address(RVA = "0x42FBD0", Offset = "0x42EFD0", VA = "0x1042FBD0")]
		private void OnRestoreDefaults()
		{
		}

		// Token: 0x060020C1 RID: 8385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020C1")]
		[Address(RVA = "0x42FDB0", Offset = "0x42F1B0", VA = "0x1042FDB0")]
		private void OnScreenToggleActionPressed(InputActionEventData data)
		{
		}

		// Token: 0x060020C2 RID: 8386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020C2")]
		[Address(RVA = "0x42FD90", Offset = "0x42F190", VA = "0x1042FD90")]
		private void OnScreenOpenActionPressed(InputActionEventData data)
		{
		}

		// Token: 0x060020C3 RID: 8387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020C3")]
		[Address(RVA = "0x42FD30", Offset = "0x42F130", VA = "0x1042FD30")]
		private void OnScreenCloseActionPressed(InputActionEventData data)
		{
		}

		// Token: 0x060020C4 RID: 8388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020C4")]
		[Address(RVA = "0x42FE40", Offset = "0x42F240", VA = "0x1042FE40")]
		private void OnUniversalCancelActionPressed(InputActionEventData data)
		{
		}

		// Token: 0x060020C5 RID: 8389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020C5")]
		[Address(RVA = "0x42FEB0", Offset = "0x42F2B0", VA = "0x1042FEB0")]
		private void OnWindowCancel(int windowId)
		{
		}

		// Token: 0x060020C6 RID: 8390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020C6")]
		[Address(RVA = "0x42F920", Offset = "0x42ED20", VA = "0x1042F920")]
		private void OnRemoveElementAssignment(int windowId, ControllerMap map, ActionElementMap aem)
		{
		}

		// Token: 0x060020C7 RID: 8391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020C7")]
		[Address(RVA = "0x42D3A0", Offset = "0x42C7A0", VA = "0x1042D3A0")]
		private void OnBeginElementAssignment(InputFieldInfo fieldInfo, ControllerMap map, ActionElementMap aem, string actionName)
		{
		}

		// Token: 0x060020C8 RID: 8392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020C8")]
		[Address(RVA = "0x42DC60", Offset = "0x42D060", VA = "0x1042DC60")]
		private void OnControllerAssignmentConfirmed(int windowId, Player player, int controllerId)
		{
		}

		// Token: 0x060020C9 RID: 8393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020C9")]
		[Address(RVA = "0x42F130", Offset = "0x42E530", VA = "0x1042F130")]
		private void OnMouseAssignmentConfirmed(int windowId, Player player)
		{
		}

		// Token: 0x060020CA RID: 8394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020CA")]
		[Address(RVA = "0x42DF40", Offset = "0x42D340", VA = "0x1042DF40")]
		private void OnElementAssignmentConflictReplaceConfirmed(int windowId, ControlMapper.InputMapping mapping, ElementAssignment assignment, bool skipOtherPlayers, bool allowSwap)
		{
		}

		// Token: 0x060020CB RID: 8395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020CB")]
		[Address(RVA = "0x42DEE0", Offset = "0x42D2E0", VA = "0x1042DEE0")]
		private void OnElementAssignmentAddConfirmed(int windowId, ControlMapper.InputMapping mapping, ElementAssignment assignment)
		{
		}

		// Token: 0x060020CC RID: 8396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020CC")]
		[Address(RVA = "0x42F960", Offset = "0x42ED60", VA = "0x1042F960")]
		private void OnRestoreDefaultsConfirmed(int windowId)
		{
		}

		// Token: 0x060020CD RID: 8397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020CD")]
		[Address(RVA = "0x42D160", Offset = "0x42C560", VA = "0x1042D160")]
		private void OnAssignControllerWindowUpdate(int windowId)
		{
		}

		// Token: 0x060020CE RID: 8398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020CE")]
		[Address(RVA = "0x42E510", Offset = "0x42D910", VA = "0x1042E510")]
		private void OnElementAssignmentPrePollingWindowUpdate(int windowId)
		{
		}

		// Token: 0x060020CF RID: 8399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020CF")]
		[Address(RVA = "0x42EB00", Offset = "0x42DF00", VA = "0x1042EB00")]
		private void OnJoystickElementAssignmentPollingWindowUpdate(int windowId)
		{
		}

		// Token: 0x060020D0 RID: 8400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020D0")]
		[Address(RVA = "0x42EE20", Offset = "0x42E220", VA = "0x1042EE20")]
		private void OnKeyboardElementAssignmentPollingWindowUpdate(int windowId)
		{
		}

		// Token: 0x060020D1 RID: 8401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020D1")]
		[Address(RVA = "0x42F330", Offset = "0x42E730", VA = "0x1042F330")]
		private void OnMouseElementAssignmentPollingWindowUpdate(int windowId)
		{
		}

		// Token: 0x060020D2 RID: 8402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020D2")]
		[Address(RVA = "0x42D940", Offset = "0x42CD40", VA = "0x1042D940")]
		private void OnCalibrateAxisStep1WindowUpdate(int windowId)
		{
		}

		// Token: 0x060020D3 RID: 8403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020D3")]
		[Address(RVA = "0x42DAC0", Offset = "0x42CEC0", VA = "0x1042DAC0")]
		private void OnCalibrateAxisStep2WindowUpdate(int windowId)
		{
		}

		// Token: 0x060020D4 RID: 8404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020D4")]
		[Address(RVA = "0x432FA0", Offset = "0x4323A0", VA = "0x10432FA0")]
		private void ShowAssignControllerWindow()
		{
		}

		// Token: 0x060020D5 RID: 8405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020D5")]
		[Address(RVA = "0x4340D0", Offset = "0x4334D0", VA = "0x104340D0")]
		private void ShowControllerAssignmentConflictWindow(int controllerId)
		{
		}

		// Token: 0x060020D6 RID: 8406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020D6")]
		[Address(RVA = "0x4332A0", Offset = "0x4326A0", VA = "0x104332A0")]
		private void ShowBeginElementAssignmentReplacementWindow(InputFieldInfo fieldInfo, InputAction action, ControllerMap map, ActionElementMap aem, string actionName)
		{
		}

		// Token: 0x060020D7 RID: 8407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020D7")]
		[Address(RVA = "0x4346B0", Offset = "0x433AB0", VA = "0x104346B0")]
		private void ShowCreateNewElementAssignmentWindow(InputFieldInfo fieldInfo, InputAction action, ControllerMap map, string actionName)
		{
		}

		// Token: 0x060020D8 RID: 8408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020D8")]
		[Address(RVA = "0x435130", Offset = "0x434530", VA = "0x10435130")]
		private void ShowElementAssignmentPrePollingWindow()
		{
		}

		// Token: 0x060020D9 RID: 8409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020D9")]
		[Address(RVA = "0x435080", Offset = "0x434480", VA = "0x10435080")]
		private void ShowElementAssignmentPollingWindow()
		{
		}

		// Token: 0x060020DA RID: 8410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020DA")]
		[Address(RVA = "0x435410", Offset = "0x434810", VA = "0x10435410")]
		private void ShowJoystickElementAssignmentPollingWindow()
		{
		}

		// Token: 0x060020DB RID: 8411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020DB")]
		[Address(RVA = "0x4356B0", Offset = "0x434AB0", VA = "0x104356B0")]
		private void ShowKeyboardElementAssignmentPollingWindow()
		{
		}

		// Token: 0x060020DC RID: 8412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020DC")]
		[Address(RVA = "0x435EB0", Offset = "0x4352B0", VA = "0x10435EB0")]
		private void ShowMouseElementAssignmentPollingWindow()
		{
		}

		// Token: 0x060020DD RID: 8413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020DD")]
		[Address(RVA = "0x434A20", Offset = "0x433E20", VA = "0x10434A20")]
		private void ShowElementAssignmentConflictWindow(ElementAssignment assignment, bool skipOtherPlayers)
		{
		}

		// Token: 0x060020DE RID: 8414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020DE")]
		[Address(RVA = "0x4359A0", Offset = "0x434DA0", VA = "0x104359A0")]
		private void ShowMouseAssignmentConflictWindow()
		{
		}

		// Token: 0x060020DF RID: 8415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020DF")]
		[Address(RVA = "0x433E50", Offset = "0x433250", VA = "0x10433E50")]
		private void ShowCalibrateControllerWindow()
		{
		}

		// Token: 0x060020E0 RID: 8416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020E0")]
		[Address(RVA = "0x433710", Offset = "0x432B10", VA = "0x10433710")]
		private void ShowCalibrateAxisStep1Window()
		{
		}

		// Token: 0x060020E1 RID: 8417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020E1")]
		[Address(RVA = "0x433AB0", Offset = "0x432EB0", VA = "0x10433AB0")]
		private void ShowCalibrateAxisStep2Window()
		{
		}

		// Token: 0x060020E2 RID: 8418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020E2")]
		[Address(RVA = "0x434800", Offset = "0x433C00", VA = "0x10434800")]
		private void ShowEditInputBehaviorsWindow()
		{
		}

		// Token: 0x060020E3 RID: 8419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020E3")]
		[Address(RVA = "0x436150", Offset = "0x435550", VA = "0x10436150")]
		private void ShowRestoreDefaultsWindow()
		{
		}

		// Token: 0x060020E4 RID: 8420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020E4")]
		[Address(RVA = "0x429350", Offset = "0x428750", VA = "0x10429350")]
		private void CreateInputGrid()
		{
		}

		// Token: 0x060020E5 RID: 8421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020E5")]
		[Address(RVA = "0x42B630", Offset = "0x42AA30", VA = "0x1042B630")]
		private void InitializeInputGrid()
		{
		}

		// Token: 0x060020E6 RID: 8422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020E6")]
		[Address(RVA = "0x432540", Offset = "0x431940", VA = "0x10432540")]
		private void RefreshInputGridStructure()
		{
		}

		// Token: 0x060020E7 RID: 8423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020E7")]
		[Address(RVA = "0x427A10", Offset = "0x426E10", VA = "0x10427A10")]
		private void CreateHeaderLabels()
		{
		}

		// Token: 0x060020E8 RID: 8424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020E8")]
		[Address(RVA = "0x427720", Offset = "0x426B20", VA = "0x10427720")]
		private void CreateActionLabelColumn()
		{
		}

		// Token: 0x060020E9 RID: 8425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020E9")]
		[Address(RVA = "0x4295D0", Offset = "0x4289D0", VA = "0x104295D0")]
		private void CreateKeyboardInputFieldColumn()
		{
		}

		// Token: 0x060020EA RID: 8426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020EA")]
		[Address(RVA = "0x429A00", Offset = "0x428E00", VA = "0x10429A00")]
		private void CreateMouseInputFieldColumn()
		{
		}

		// Token: 0x060020EB RID: 8427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020EB")]
		[Address(RVA = "0x427900", Offset = "0x426D00", VA = "0x10427900")]
		private void CreateControllerInputFieldColumn()
		{
		}

		// Token: 0x060020EC RID: 8428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020EC")]
		[Address(RVA = "0x428820", Offset = "0x427C20", VA = "0x10428820")]
		private void CreateInputFieldColumn(string name, ControllerType controllerType, int maxWidth, int cols, bool disableFullAxis)
		{
		}

		// Token: 0x060020ED RID: 8429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020ED")]
		[Address(RVA = "0x427D40", Offset = "0x427140", VA = "0x10427D40")]
		private void CreateInputActionLabels()
		{
		}

		// Token: 0x060020EE RID: 8430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020EE")]
		[Address(RVA = "0x428D50", Offset = "0x428150", VA = "0x10428D50")]
		private void CreateInputFields()
		{
		}

		// Token: 0x060020EF RID: 8431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020EF")]
		[Address(RVA = "0x428DE0", Offset = "0x4281E0", VA = "0x10428DE0")]
		private void CreateInputFields(Transform columnXform, ControllerType controllerType, int maxWidth, int cols, bool disableFullAxis)
		{
		}

		// Token: 0x060020F0 RID: 8432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020F0")]
		[Address(RVA = "0x4288D0", Offset = "0x427CD0", VA = "0x104288D0")]
		private void CreateInputFieldSet(Transform parent, int mapCategoryId, InputAction action, AxisRange axisRange, ControllerType controllerType, int cols, int fieldWidth, ref int yPos, bool disableFullAxis)
		{
		}

		// Token: 0x060020F1 RID: 8433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020F1")]
		[Address(RVA = "0x430DA0", Offset = "0x4301A0", VA = "0x10430DA0")]
		private void PopulateInputFields()
		{
		}

		// Token: 0x060020F2 RID: 8434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020F2")]
		[Address(RVA = "0x4309C0", Offset = "0x42FDC0", VA = "0x104309C0")]
		private void PopulateInputFieldGroup(ControlMapper.InputActionSet actionSet, ControllerMap controllerMap, ControllerType controllerType, int controllerId, int maxFields)
		{
		}

		// Token: 0x060020F3 RID: 8435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020F3")]
		[Address(RVA = "0x429D70", Offset = "0x429170", VA = "0x10429D70")]
		private void DisableInputFieldGroup(ControlMapper.InputActionSet actionSet, ControllerType controllerType, int fieldCount)
		{
		}

		// Token: 0x060020F4 RID: 8436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020F4")]
		[Address(RVA = "0x432830", Offset = "0x431C30", VA = "0x10432830")]
		private void ResetInputGridScrollBar()
		{
		}

		// Token: 0x060020F5 RID: 8437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020F5")]
		[Address(RVA = "0x4297C0", Offset = "0x428BC0", VA = "0x104297C0")]
		private void CreateLayout()
		{
		}

		// Token: 0x060020F6 RID: 8438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020F6")]
		[Address(RVA = "0x42AAD0", Offset = "0x429ED0", VA = "0x1042AAD0")]
		private void Draw()
		{
		}

		// Token: 0x060020F7 RID: 8439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020F7")]
		[Address(RVA = "0x42A4C0", Offset = "0x4298C0", VA = "0x1042A4C0")]
		private void DrawPlayersGroup()
		{
		}

		// Token: 0x060020F8 RID: 8440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020F8")]
		[Address(RVA = "0x429DD0", Offset = "0x4291D0", VA = "0x10429DD0")]
		private void DrawControllersGroup()
		{
		}

		// Token: 0x060020F9 RID: 8441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020F9")]
		[Address(RVA = "0x42A7C0", Offset = "0x429BC0", VA = "0x1042A7C0")]
		private void DrawSettingsGroup()
		{
		}

		// Token: 0x060020FA RID: 8442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020FA")]
		[Address(RVA = "0x42A1A0", Offset = "0x4295A0", VA = "0x1042A1A0")]
		private void DrawMapCategoriesGroup()
		{
		}

		// Token: 0x060020FB RID: 8443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020FB")]
		[Address(RVA = "0x42A9D0", Offset = "0x429DD0", VA = "0x1042A9D0")]
		private void DrawWindowButtonsGroup()
		{
		}

		// Token: 0x060020FC RID: 8444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020FC")]
		[Address(RVA = "0x432150", Offset = "0x431550", VA = "0x10432150")]
		private void Redraw(bool listsChanged, bool playTransitions)
		{
		}

		// Token: 0x060020FD RID: 8445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020FD")]
		[Address(RVA = "0x432030", Offset = "0x431430", VA = "0x10432030")]
		private void RedrawPlayerGroup(bool playTransitions)
		{
		}

		// Token: 0x060020FE RID: 8446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020FE")]
		[Address(RVA = "0x4312B0", Offset = "0x4306B0", VA = "0x104312B0")]
		private void RedrawControllerGroup()
		{
		}

		// Token: 0x060020FF RID: 8447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020FF")]
		[Address(RVA = "0x431F10", Offset = "0x431310", VA = "0x10431F10")]
		private void RedrawMapCategoriesGroup(bool playTransitions)
		{
		}

		// Token: 0x06002100 RID: 8448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002100")]
		[Address(RVA = "0x431DF0", Offset = "0x4311F0", VA = "0x10431DF0")]
		private void RedrawInputGrid(bool listsChanged)
		{
		}

		// Token: 0x06002101 RID: 8449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002101")]
		[Address(RVA = "0x42ACC0", Offset = "0x42A0C0", VA = "0x1042ACC0")]
		private void ForceRefresh()
		{
		}

		// Token: 0x06002102 RID: 8450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002102")]
		[Address(RVA = "0x428780", Offset = "0x427B80", VA = "0x10428780")]
		private void CreateInputCategoryRow(ref int rowCount, InputCategory category)
		{
		}

		// Token: 0x06002103 RID: 8451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002103")]
		[Address(RVA = "0x429780", Offset = "0x428B80", VA = "0x10429780")]
		private ControlMapper.GUILabel CreateLabel(string labelText, Transform parent, Vector2 offset)
		{
			return null;
		}

		// Token: 0x06002104 RID: 8452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002104")]
		[Address(RVA = "0x429640", Offset = "0x428A40", VA = "0x10429640")]
		private ControlMapper.GUILabel CreateLabel(GameObject prefab, string labelText, Transform parent, Vector2 offset)
		{
			return null;
		}

		// Token: 0x06002105 RID: 8453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002105")]
		[Address(RVA = "0x427790", Offset = "0x426B90", VA = "0x10427790")]
		private ControlMapper.GUIButton CreateButton(string labelText, Transform parent, Vector2 offset)
		{
			return null;
		}

		// Token: 0x06002106 RID: 8454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002106")]
		[Address(RVA = "0x427980", Offset = "0x426D80", VA = "0x10427980")]
		private ControlMapper.GUIButton CreateFitButton(string labelText, Transform parent, Vector2 offset)
		{
			return null;
		}

		// Token: 0x06002107 RID: 8455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002107")]
		[Address(RVA = "0x428BB0", Offset = "0x427FB0", VA = "0x10428BB0")]
		private ControlMapper.GUIInputField CreateInputField(Transform parent, Vector2 offset, string label, int actionId, AxisRange axisRange, ControllerType controllerType, int fieldIndex)
		{
			return null;
		}

		// Token: 0x06002108 RID: 8456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002108")]
		[Address(RVA = "0x428CE0", Offset = "0x4280E0", VA = "0x10428CE0")]
		private ControlMapper.GUIInputField CreateInputField(Transform parent, Vector2 offset)
		{
			return null;
		}

		// Token: 0x06002109 RID: 8457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002109")]
		[Address(RVA = "0x429C70", Offset = "0x429070", VA = "0x10429C70")]
		private ControlMapper.GUIToggle CreateToggle(GameObject prefab, Transform parent, Vector2 offset, string label, int actionId, AxisRange axisRange, ControllerType controllerType, int fieldIndex)
		{
			return null;
		}

		// Token: 0x0600210A RID: 8458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600210A")]
		[Address(RVA = "0x429C10", Offset = "0x429010", VA = "0x10429C10")]
		private ControlMapper.GUIToggle CreateToggle(GameObject prefab, Transform parent, Vector2 offset)
		{
			return null;
		}

		// Token: 0x0600210B RID: 8459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600210B")]
		[Address(RVA = "0x42CAE0", Offset = "0x42BEE0", VA = "0x1042CAE0")]
		private GameObject InstantiateGUIObject(GameObject prefab, Transform parent, Vector2 offset)
		{
			return null;
		}

		// Token: 0x0600210C RID: 8460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600210C")]
		[Address(RVA = "0x429B90", Offset = "0x428F90", VA = "0x10429B90")]
		private GameObject CreateNewGUIObject(string name, Transform parent, Vector2 offset)
		{
			return null;
		}

		// Token: 0x0600210D RID: 8461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600210D")]
		[Address(RVA = "0x42BC70", Offset = "0x42B070", VA = "0x1042BC70")]
		private GameObject InitializeNewGUIGameObject(GameObject gameObject, Transform parent, Vector2 offset)
		{
			return null;
		}

		// Token: 0x0600210E RID: 8462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600210E")]
		[Address(RVA = "0x429A80", Offset = "0x428E80", VA = "0x10429A80")]
		private GameObject CreateNewColumnGroup(string name, Transform parent, int maxWidth)
		{
			return null;
		}

		// Token: 0x0600210F RID: 8463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600210F")]
		[Address(RVA = "0x430260", Offset = "0x42F660", VA = "0x10430260")]
		private Window OpenWindow(bool closeOthers)
		{
			return null;
		}

		// Token: 0x06002110 RID: 8464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002110")]
		[Address(RVA = "0x4301B0", Offset = "0x42F5B0", VA = "0x104301B0")]
		private Window OpenWindow(string name, bool closeOthers)
		{
			return null;
		}

		// Token: 0x06002111 RID: 8465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002111")]
		[Address(RVA = "0x430340", Offset = "0x42F740", VA = "0x10430340")]
		private Window OpenWindow(GameObject windowPrefab, bool closeOthers)
		{
			return null;
		}

		// Token: 0x06002112 RID: 8466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002112")]
		[Address(RVA = "0x430380", Offset = "0x42F780", VA = "0x10430380")]
		private Window OpenWindow(GameObject windowPrefab, string name, bool closeOthers)
		{
			return null;
		}

		// Token: 0x06002113 RID: 8467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002113")]
		[Address(RVA = "0x42FEE0", Offset = "0x42F2E0", VA = "0x1042FEE0")]
		private void OpenModal(string title, string message, string confirmText, Action<int> confirmAction, string cancelText, Action<int> cancelAction, bool closeOthers)
		{
		}

		// Token: 0x06002114 RID: 8468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002114")]
		[Address(RVA = "0x4275B0", Offset = "0x4269B0", VA = "0x104275B0")]
		private void CloseWindow(int windowId)
		{
		}

		// Token: 0x06002115 RID: 8469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002115")]
		[Address(RVA = "0x427560", Offset = "0x426960", VA = "0x10427560")]
		private void CloseTopWindow()
		{
		}

		// Token: 0x06002116 RID: 8470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002116")]
		[Address(RVA = "0x4274D0", Offset = "0x4268D0", VA = "0x104274D0")]
		private void CloseAllWindows()
		{
		}

		// Token: 0x06002117 RID: 8471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002117")]
		[Address(RVA = "0x426D20", Offset = "0x426120", VA = "0x10426D20")]
		private void ChildWindowOpened()
		{
		}

		// Token: 0x06002118 RID: 8472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002118")]
		[Address(RVA = "0x426C70", Offset = "0x426070", VA = "0x10426C70")]
		private void ChildWindowClosed()
		{
		}

		// Token: 0x06002119 RID: 8473 RVA: 0x0000A2C0 File Offset: 0x000084C0
		[Token(Token = "0x6002119")]
		[Address(RVA = "0x42B450", Offset = "0x42A850", VA = "0x1042B450")]
		private bool HasElementAssignmentConflicts(Player player, ControlMapper.InputMapping mapping, ElementAssignment assignment, bool skipOtherPlayers)
		{
			return default(bool);
		}

		// Token: 0x0600211A RID: 8474 RVA: 0x0000A2D8 File Offset: 0x000084D8
		[Token(Token = "0x600211A")]
		[Address(RVA = "0x42CC00", Offset = "0x42C000", VA = "0x1042CC00")]
		private bool IsBlockingAssignmentConflict(ControlMapper.InputMapping mapping, ElementAssignment assignment, bool skipOtherPlayers)
		{
			return default(bool);
		}

		// Token: 0x0600211B RID: 8475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600211B")]
		[Address(RVA = "0x42AC00", Offset = "0x42A000", VA = "0x1042AC00")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE45D0", Offset = "0xE39D0")]
		private IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(Player player, ControlMapper.InputMapping mapping, ElementAssignment assignment, bool skipOtherPlayers)
		{
			return null;
		}

		// Token: 0x0600211C RID: 8476 RVA: 0x0000A2F0 File Offset: 0x000084F0
		[Token(Token = "0x600211C")]
		[Address(RVA = "0x427820", Offset = "0x426C20", VA = "0x10427820")]
		private bool CreateConflictCheck(ControlMapper.InputMapping mapping, ElementAssignment assignment, out ElementAssignmentConflictCheck conflictCheck)
		{
			return default(bool);
		}

		// Token: 0x0600211D RID: 8477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600211D")]
		[Address(RVA = "0x430510", Offset = "0x42F910", VA = "0x10430510")]
		private void PollKeyboardForAssignment(out ControllerPollingInfo pollingInfo, out bool modifierKeyPressed, out ModifierKeyFlags modifierFlags, out string label)
		{
		}

		// Token: 0x0600211E RID: 8478 RVA: 0x0000A308 File Offset: 0x00008508
		[Token(Token = "0x600211E")]
		[Address(RVA = "0x42B1B0", Offset = "0x42A5B0", VA = "0x1042B1B0")]
		private bool GetFirstElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, out ElementAssignmentConflictInfo conflict, bool skipOtherPlayers)
		{
			return default(bool);
		}

		// Token: 0x0600211F RID: 8479 RVA: 0x0000A320 File Offset: 0x00008520
		[Token(Token = "0x600211F")]
		[Address(RVA = "0x42AFB0", Offset = "0x42A3B0", VA = "0x1042AFB0")]
		private bool GetFirstElementAssignmentConflict(Player player, ElementAssignmentConflictCheck conflictCheck, out ElementAssignmentConflictInfo conflict)
		{
			return default(bool);
		}

		// Token: 0x06002120 RID: 8480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002120")]
		[Address(RVA = "0x436930", Offset = "0x435D30", VA = "0x10436930")]
		private void StartAxisCalibration(int axisIndex)
		{
		}

		// Token: 0x06002121 RID: 8481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002121")]
		[Address(RVA = "0x42AC90", Offset = "0x42A090", VA = "0x1042AC90")]
		private void EndAxisCalibration()
		{
		}

		// Token: 0x06002122 RID: 8482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002122")]
		[Address(RVA = "0x432EC0", Offset = "0x4322C0", VA = "0x10432EC0")]
		private void SetUISelection(GameObject selection)
		{
		}

		// Token: 0x06002123 RID: 8483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002123")]
		[Address(RVA = "0x432A00", Offset = "0x431E00", VA = "0x10432A00")]
		private void RestoreLastUISelection()
		{
		}

		// Token: 0x06002124 RID: 8484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002124")]
		[Address(RVA = "0x432DB0", Offset = "0x4321B0", VA = "0x10432DB0")]
		private void SetDefaultUISelection()
		{
		}

		// Token: 0x06002125 RID: 8485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002125")]
		[Address(RVA = "0x432AA0", Offset = "0x431EA0", VA = "0x10432AA0")]
		private void SelectDefaultMapCategory(bool redraw)
		{
		}

		// Token: 0x06002126 RID: 8486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002126")]
		[Address(RVA = "0x426BD0", Offset = "0x425FD0", VA = "0x10426BD0")]
		private void CheckUISelection()
		{
		}

		// Token: 0x06002127 RID: 8487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002127")]
		[Address(RVA = "0x42FE20", Offset = "0x42F220", VA = "0x1042FE20")]
		private void OnUIElementSelected(GameObject selectedObject)
		{
		}

		// Token: 0x06002128 RID: 8488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002128")]
		[Address(RVA = "0x432E60", Offset = "0x432260", VA = "0x10432E60")]
		private void SetIsFocused(bool state)
		{
		}

		// Token: 0x06002129 RID: 8489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002129")]
		[Address(RVA = "0x436F30", Offset = "0x436330", VA = "0x10436F30")]
		public void Toggle()
		{
		}

		// Token: 0x0600212A RID: 8490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600212A")]
		[Address(RVA = "0x42FD90", Offset = "0x42F190", VA = "0x1042FD90")]
		public void Open()
		{
		}

		// Token: 0x0600212B RID: 8491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600212B")]
		[Address(RVA = "0x430430", Offset = "0x42F830", VA = "0x10430430")]
		private void Open(bool force)
		{
		}

		// Token: 0x0600212C RID: 8492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600212C")]
		[Address(RVA = "0x427600", Offset = "0x426A00", VA = "0x10427600")]
		public void Close(bool save)
		{
		}

		// Token: 0x0600212D RID: 8493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600212D")]
		[Address(RVA = "0x427440", Offset = "0x426840", VA = "0x10427440")]
		private void Clear()
		{
		}

		// Token: 0x0600212E RID: 8494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600212E")]
		[Address(RVA = "0x426E80", Offset = "0x426280", VA = "0x10426E80")]
		private void ClearCompletely()
		{
		}

		// Token: 0x0600212F RID: 8495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600212F")]
		[Address(RVA = "0x426F80", Offset = "0x426380", VA = "0x10426F80")]
		private void ClearSpawnedObjects()
		{
		}

		// Token: 0x06002130 RID: 8496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002130")]
		[Address(RVA = "0x427420", Offset = "0x426820", VA = "0x10427420")]
		private void ClearVarsOnPlayerChange()
		{
		}

		// Token: 0x06002131 RID: 8497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002131")]
		[Address(RVA = "0x427420", Offset = "0x426820", VA = "0x10427420")]
		private void ClearVarsOnJoystickChange()
		{
		}

		// Token: 0x06002132 RID: 8498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002132")]
		[Address(RVA = "0x426DA0", Offset = "0x4261A0", VA = "0x10426DA0")]
		private void ClearAllVars()
		{
		}

		// Token: 0x06002133 RID: 8499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002133")]
		[Address(RVA = "0x4328E0", Offset = "0x431CE0", VA = "0x104328E0")]
		public void Reset()
		{
		}

		// Token: 0x06002134 RID: 8500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002134")]
		[Address(RVA = "0x432D10", Offset = "0x432110", VA = "0x10432D10")]
		private void SetActionAxisInverted(bool state, ControllerType controllerType, int actionElementMapId)
		{
		}

		// Token: 0x06002135 RID: 8501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002135")]
		[Address(RVA = "0x42AE00", Offset = "0x42A200", VA = "0x1042AE00")]
		private ControllerMap GetControllerMap(ControllerType type)
		{
			return null;
		}

		// Token: 0x06002136 RID: 8502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002136")]
		[Address(RVA = "0x42AD70", Offset = "0x42A170", VA = "0x1042AD70")]
		private ControllerMap GetControllerMapOrCreateNew(ControllerType controllerType, int controllerId, int layoutId)
		{
			return null;
		}

		// Token: 0x06002137 RID: 8503 RVA: 0x0000A338 File Offset: 0x00008538
		[Token(Token = "0x6002137")]
		private int CountIEnumerable<T>(IEnumerable<T> enumerable)
		{
			return 0;
		}

		// Token: 0x06002138 RID: 8504 RVA: 0x0000A350 File Offset: 0x00008550
		[Token(Token = "0x6002138")]
		[Address(RVA = "0x42AEE0", Offset = "0x42A2E0", VA = "0x1042AEE0")]
		private int GetDefaultMapCategoryId()
		{
			return 0;
		}

		// Token: 0x06002139 RID: 8505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002139")]
		[Address(RVA = "0x436A10", Offset = "0x435E10", VA = "0x10436A10")]
		private void SubscribeFixedUISelectionEvents()
		{
		}

		// Token: 0x0600213A RID: 8506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600213A")]
		[Address(RVA = "0x436B70", Offset = "0x435F70", VA = "0x10436B70")]
		private void SubscribeMenuControlInputEvents()
		{
		}

		// Token: 0x0600213B RID: 8507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600213B")]
		[Address(RVA = "0x436F70", Offset = "0x436370", VA = "0x10436F70")]
		private void UnsubscribeMenuControlInputEvents()
		{
		}

		// Token: 0x0600213C RID: 8508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600213C")]
		[Address(RVA = "0x436CA0", Offset = "0x4360A0", VA = "0x10436CA0")]
		private void SubscribeRewiredInputEventAllPlayers(int actionId, Action<InputActionEventData> callback)
		{
		}

		// Token: 0x0600213D RID: 8509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600213D")]
		[Address(RVA = "0x4370A0", Offset = "0x4364A0", VA = "0x104370A0")]
		private void UnsubscribeRewiredInputEventAllPlayers(int actionId, Action<InputActionEventData> callback)
		{
		}

		// Token: 0x0600213E RID: 8510 RVA: 0x0000A368 File Offset: 0x00008568
		[Token(Token = "0x600213E")]
		[Address(RVA = "0x42B410", Offset = "0x42A810", VA = "0x1042B410")]
		private int GetMaxControllersPerPlayer()
		{
			return 0;
		}

		// Token: 0x0600213F RID: 8511 RVA: 0x0000A380 File Offset: 0x00008580
		[Token(Token = "0x600213F")]
		[Address(RVA = "0x433250", Offset = "0x432650", VA = "0x10433250")]
		private bool ShowAssignedControllers()
		{
			return default(bool);
		}

		// Token: 0x06002140 RID: 8512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002140")]
		[Address(RVA = "0x42C9C0", Offset = "0x42BDC0", VA = "0x1042C9C0")]
		private void InspectorPropertyChanged(bool reset = false)
		{
		}

		// Token: 0x06002141 RID: 8513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002141")]
		[Address(RVA = "0x426760", Offset = "0x425B60", VA = "0x10426760")]
		private void AssignController(Player player, int controllerId)
		{
		}

		// Token: 0x06002142 RID: 8514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002142")]
		[Address(RVA = "0x432630", Offset = "0x431A30", VA = "0x10432630")]
		private void RemoveAllControllers(Player player)
		{
		}

		// Token: 0x06002143 RID: 8515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002143")]
		[Address(RVA = "0x432730", Offset = "0x431B30", VA = "0x10432730")]
		private void RemoveController(Player player, int controllerId)
		{
		}

		// Token: 0x06002144 RID: 8516 RVA: 0x0000A398 File Offset: 0x00008598
		[Token(Token = "0x6002144")]
		[Address(RVA = "0x42CBD0", Offset = "0x42BFD0", VA = "0x1042CBD0")]
		private bool IsAllowedAssignment(ControlMapper.InputMapping pendingInputMapping, ControllerPollingInfo pollingInfo)
		{
			return default(bool);
		}

		// Token: 0x06002145 RID: 8517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002145")]
		[Address(RVA = "0x42C920", Offset = "0x42BD20", VA = "0x1042C920")]
		private void InputPollingStarted()
		{
		}

		// Token: 0x06002146 RID: 8518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002146")]
		[Address(RVA = "0x42C970", Offset = "0x42BD70", VA = "0x1042C970")]
		private void InputPollingStopped()
		{
		}

		// Token: 0x06002147 RID: 8519 RVA: 0x0000A3B0 File Offset: 0x000085B0
		[Token(Token = "0x6002147")]
		[Address(RVA = "0x42AD10", Offset = "0x42A110", VA = "0x1042AD10")]
		private int GetControllerInputFieldCount(ControllerType controllerType)
		{
			return 0;
		}

		// Token: 0x06002148 RID: 8520 RVA: 0x0000A3C8 File Offset: 0x000085C8
		[Token(Token = "0x6002148")]
		[Address(RVA = "0x4362A0", Offset = "0x4356A0", VA = "0x104362A0")]
		private bool ShowSwapButton(int windowId, ControlMapper.InputMapping mapping, ElementAssignment assignment, bool skipOtherPlayers)
		{
			return default(bool);
		}

		// Token: 0x06002149 RID: 8521 RVA: 0x0000A3E0 File Offset: 0x000085E0
		[Token(Token = "0x6002149")]
		[Address(RVA = "0x436EE0", Offset = "0x4362E0", VA = "0x10436EE0")]
		private bool SwapIsSameInputRange(ControllerElementType origElementType, AxisRange origAxisRange, Pole origAxisContribution, ControllerElementType conflictElementType, AxisRange conflictAxisRange, Pole conflictAxisContribution)
		{
			return default(bool);
		}

		// Token: 0x0600214A RID: 8522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600214A")]
		[Address(RVA = "0x426680", Offset = "0x425A80", VA = "0x10426680")]
		public static void ApplyTheme(ThemedElement.ElementInfo[] elementInfo)
		{
		}

		// Token: 0x0600214B RID: 8523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600214B")]
		[Address(RVA = "0x42B390", Offset = "0x42A790", VA = "0x1042B390")]
		public static LanguageDataBase GetLanguage()
		{
			return null;
		}

		// Token: 0x0600214C RID: 8524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600214C")]
		[Address(RVA = "0x4373D0", Offset = "0x4367D0", VA = "0x104373D0")]
		public ControlMapper()
		{
		}

		// Token: 0x04002247 RID: 8775
		[Token(Token = "0x4002247")]
		public const int versionMajor = 1;

		// Token: 0x04002248 RID: 8776
		[Token(Token = "0x4002248")]
		public const int versionMinor = 1;

		// Token: 0x04002249 RID: 8777
		[Token(Token = "0x4002249")]
		public const bool usesTMPro = true;

		// Token: 0x0400224A RID: 8778
		[Token(Token = "0x400224A")]
		private const float blockInputOnFocusTimeout = 0.1f;

		// Token: 0x0400224B RID: 8779
		[Token(Token = "0x400224B")]
		private const string buttonIdentifier_playerSelection = "PlayerSelection";

		// Token: 0x0400224C RID: 8780
		[Token(Token = "0x400224C")]
		private const string buttonIdentifier_removeController = "RemoveController";

		// Token: 0x0400224D RID: 8781
		[Token(Token = "0x400224D")]
		private const string buttonIdentifier_assignController = "AssignController";

		// Token: 0x0400224E RID: 8782
		[Token(Token = "0x400224E")]
		private const string buttonIdentifier_calibrateController = "CalibrateController";

		// Token: 0x0400224F RID: 8783
		[Token(Token = "0x400224F")]
		private const string buttonIdentifier_editInputBehaviors = "EditInputBehaviors";

		// Token: 0x04002250 RID: 8784
		[Token(Token = "0x4002250")]
		private const string buttonIdentifier_mapCategorySelection = "MapCategorySelection";

		// Token: 0x04002251 RID: 8785
		[Token(Token = "0x4002251")]
		private const string buttonIdentifier_assignedControllerSelection = "AssignedControllerSelection";

		// Token: 0x04002252 RID: 8786
		[Token(Token = "0x4002252")]
		private const string buttonIdentifier_done = "Done";

		// Token: 0x04002253 RID: 8787
		[Token(Token = "0x4002253")]
		private const string buttonIdentifier_restoreDefaults = "RestoreDefaults";

		// Token: 0x04002254 RID: 8788
		[Token(Token = "0x4002254")]
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE30A0", Offset = "0xE24A0")]
		private InputManager _rewiredInputManager;

		// Token: 0x04002255 RID: 8789
		[Token(Token = "0x4002255")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE30E0", Offset = "0xE24E0")]
		private bool _dontDestroyOnLoad;

		// Token: 0x04002256 RID: 8790
		[Token(Token = "0x4002256")]
		[FieldOffset(Offset = "0x11")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE3120", Offset = "0xE2520")]
		private bool _openOnStart;

		// Token: 0x04002257 RID: 8791
		[Token(Token = "0x4002257")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE31B0", Offset = "0xE25B0")]
		private int _keyboardMapDefaultLayout;

		// Token: 0x04002258 RID: 8792
		[Token(Token = "0x4002258")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE3240", Offset = "0xE2640")]
		private int _mouseMapDefaultLayout;

		// Token: 0x04002259 RID: 8793
		[Token(Token = "0x4002259")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE3240", Offset = "0xE2640")]
		private int _joystickMapDefaultLayout;

		// Token: 0x0400225A RID: 8794
		[Token(Token = "0x400225A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ControlMapper.MappingSet[] _mappingSets;

		// Token: 0x0400225B RID: 8795
		[Token(Token = "0x400225B")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE3320", Offset = "0xE2720")]
		private bool _showPlayers;

		// Token: 0x0400225C RID: 8796
		[Token(Token = "0x400225C")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE3360", Offset = "0xE2760")]
		private bool _showControllers;

		// Token: 0x0400225D RID: 8797
		[Token(Token = "0x400225D")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE33A0", Offset = "0xE27A0")]
		[SerializeField]
		private bool _showKeyboard;

		// Token: 0x0400225E RID: 8798
		[Token(Token = "0x400225E")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE33E0", Offset = "0xE27E0")]
		private bool _showMouse;

		// Token: 0x0400225F RID: 8799
		[Token(Token = "0x400225F")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE3420", Offset = "0xE2820")]
		private int _maxControllersPerPlayer;

		// Token: 0x04002260 RID: 8800
		[Token(Token = "0x4002260")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE3460", Offset = "0xE2860")]
		private bool _showActionCategoryLabels;

		// Token: 0x04002261 RID: 8801
		[Token(Token = "0x4002261")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE34A0", Offset = "0xE28A0")]
		private int _keyboardInputFieldCount;

		// Token: 0x04002262 RID: 8802
		[Token(Token = "0x4002262")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE34E0", Offset = "0xE28E0")]
		[SerializeField]
		private int _mouseInputFieldCount;

		// Token: 0x04002263 RID: 8803
		[Token(Token = "0x4002263")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE3520", Offset = "0xE2920")]
		private int _controllerInputFieldCount;

		// Token: 0x04002264 RID: 8804
		[Token(Token = "0x4002264")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE3560", Offset = "0xE2960")]
		[SerializeField]
		private bool _showFullAxisInputFields;

		// Token: 0x04002265 RID: 8805
		[Token(Token = "0x4002265")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE35A0", Offset = "0xE29A0")]
		private bool _showSplitAxisInputFields;

		// Token: 0x04002266 RID: 8806
		[Token(Token = "0x4002266")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE35E0", Offset = "0xE29E0")]
		[SerializeField]
		private bool _allowElementAssignmentConflicts;

		// Token: 0x04002267 RID: 8807
		[Token(Token = "0x4002267")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE3620", Offset = "0xE2A20")]
		[SerializeField]
		private bool _allowElementAssignmentSwap;

		// Token: 0x04002268 RID: 8808
		[Token(Token = "0x4002268")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE3660", Offset = "0xE2A60")]
		[SerializeField]
		private int _actionLabelWidth;

		// Token: 0x04002269 RID: 8809
		[Token(Token = "0x4002269")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE36A0", Offset = "0xE2AA0")]
		private int _keyboardColMaxWidth;

		// Token: 0x0400226A RID: 8810
		[Token(Token = "0x400226A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE36E0", Offset = "0xE2AE0")]
		private int _mouseColMaxWidth;

		// Token: 0x0400226B RID: 8811
		[Token(Token = "0x400226B")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE3770", Offset = "0xE2B70")]
		private int _controllerColMaxWidth;

		// Token: 0x0400226C RID: 8812
		[Token(Token = "0x400226C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE3800", Offset = "0xE2C00")]
		private int _inputRowHeight;

		// Token: 0x0400226D RID: 8813
		[Token(Token = "0x400226D")]
		[FieldOffset(Offset = "0x54")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE3840", Offset = "0xE2C40")]
		[SerializeField]
		private RectOffset _inputRowPadding;

		// Token: 0x0400226E RID: 8814
		[Token(Token = "0x400226E")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE38D0", Offset = "0xE2CD0")]
		[SerializeField]
		private int _inputRowFieldSpacing;

		// Token: 0x0400226F RID: 8815
		[Token(Token = "0x400226F")]
		[FieldOffset(Offset = "0x5C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE3960", Offset = "0xE2D60")]
		[SerializeField]
		private int _inputColumnSpacing;

		// Token: 0x04002270 RID: 8816
		[Token(Token = "0x4002270")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE39F0", Offset = "0xE2DF0")]
		[SerializeField]
		private int _inputRowCategorySpacing;

		// Token: 0x04002271 RID: 8817
		[Token(Token = "0x4002271")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE3A30", Offset = "0xE2E30")]
		private int _invertToggleWidth;

		// Token: 0x04002272 RID: 8818
		[Token(Token = "0x4002272")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE3A70", Offset = "0xE2E70")]
		[SerializeField]
		private int _defaultWindowWidth;

		// Token: 0x04002273 RID: 8819
		[Token(Token = "0x4002273")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE3AB0", Offset = "0xE2EB0")]
		private int _defaultWindowHeight;

		// Token: 0x04002274 RID: 8820
		[Token(Token = "0x4002274")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE3AF0", Offset = "0xE2EF0")]
		[SerializeField]
		private float _controllerAssignmentTimeout;

		// Token: 0x04002275 RID: 8821
		[Token(Token = "0x4002275")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE3BB0", Offset = "0xE2FB0")]
		private float _preInputAssignmentTimeout;

		// Token: 0x04002276 RID: 8822
		[Token(Token = "0x4002276")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE3BF0", Offset = "0xE2FF0")]
		private float _inputAssignmentTimeout;

		// Token: 0x04002277 RID: 8823
		[Token(Token = "0x4002277")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE3C50", Offset = "0xE3050")]
		private float _axisCalibrationTimeout;

		// Token: 0x04002278 RID: 8824
		[Token(Token = "0x4002278")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE3C90", Offset = "0xE3090")]
		private bool _ignoreMouseXAxisAssignment;

		// Token: 0x04002279 RID: 8825
		[Token(Token = "0x4002279")]
		[FieldOffset(Offset = "0x81")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE3D20", Offset = "0xE3120")]
		[SerializeField]
		private bool _ignoreMouseYAxisAssignment;

		// Token: 0x0400227A RID: 8826
		[Token(Token = "0x400227A")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE3D60", Offset = "0xE3160")]
		private int _screenToggleAction;

		// Token: 0x0400227B RID: 8827
		[Token(Token = "0x400227B")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE3DA0", Offset = "0xE31A0")]
		[SerializeField]
		private int _screenOpenAction;

		// Token: 0x0400227C RID: 8828
		[Token(Token = "0x400227C")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE3DE0", Offset = "0xE31E0")]
		private int _screenCloseAction;

		// Token: 0x0400227D RID: 8829
		[Token(Token = "0x400227D")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE3E20", Offset = "0xE3220")]
		private int _universalCancelAction;

		// Token: 0x0400227E RID: 8830
		[Token(Token = "0x400227E")]
		[FieldOffset(Offset = "0x94")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE3EB0", Offset = "0xE32B0")]
		[SerializeField]
		private bool _universalCancelClosesScreen;

		// Token: 0x0400227F RID: 8831
		[Token(Token = "0x400227F")]
		[FieldOffset(Offset = "0x95")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE3F40", Offset = "0xE3340")]
		[SerializeField]
		private bool _showInputBehaviorSettings;

		// Token: 0x04002280 RID: 8832
		[Token(Token = "0x4002280")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE3F80", Offset = "0xE3380")]
		private ControlMapper.InputBehaviorSettings[] _inputBehaviorSettings;

		// Token: 0x04002281 RID: 8833
		[Token(Token = "0x4002281")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE3FC0", Offset = "0xE33C0")]
		private bool _useThemeSettings;

		// Token: 0x04002282 RID: 8834
		[Token(Token = "0x4002282")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE4050", Offset = "0xE3450")]
		private ThemeSettings _themeSettings;

		// Token: 0x04002283 RID: 8835
		[Token(Token = "0x4002283")]
		[FieldOffset(Offset = "0xA4")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE40E0", Offset = "0xE34E0")]
		private LanguageDataBase _language;

		// Token: 0x04002284 RID: 8836
		[Token(Token = "0x4002284")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE4120", Offset = "0xE3520")]
		private ControlMapper.Prefabs prefabs;

		// Token: 0x04002285 RID: 8837
		[Token(Token = "0x4002285")]
		[FieldOffset(Offset = "0xAC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE4160", Offset = "0xE3560")]
		[SerializeField]
		private ControlMapper.References references;

		// Token: 0x04002286 RID: 8838
		[Token(Token = "0x4002286")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE41A0", Offset = "0xE35A0")]
		private bool _showPlayersGroupLabel;

		// Token: 0x04002287 RID: 8839
		[Token(Token = "0x4002287")]
		[FieldOffset(Offset = "0xB1")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE41E0", Offset = "0xE35E0")]
		private bool _showControllerGroupLabel;

		// Token: 0x04002288 RID: 8840
		[Token(Token = "0x4002288")]
		[FieldOffset(Offset = "0xB2")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE4220", Offset = "0xE3620")]
		private bool _showAssignedControllersGroupLabel;

		// Token: 0x04002289 RID: 8841
		[Token(Token = "0x4002289")]
		[FieldOffset(Offset = "0xB3")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE4260", Offset = "0xE3660")]
		[SerializeField]
		private bool _showSettingsGroupLabel;

		// Token: 0x0400228A RID: 8842
		[Token(Token = "0x400228A")]
		[FieldOffset(Offset = "0xB4")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE42A0", Offset = "0xE36A0")]
		private bool _showMapCategoriesGroupLabel;

		// Token: 0x0400228B RID: 8843
		[Token(Token = "0x400228B")]
		[FieldOffset(Offset = "0xB5")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE4380", Offset = "0xE3780")]
		[SerializeField]
		private bool _showControllerNameLabel;

		// Token: 0x0400228C RID: 8844
		[Token(Token = "0x400228C")]
		[FieldOffset(Offset = "0xB6")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE43C0", Offset = "0xE37C0")]
		[SerializeField]
		private bool _showAssignedControllers;

		// Token: 0x0400228D RID: 8845
		[Token(Token = "0x400228D")]
		[FieldOffset(Offset = "0xB8")]
		private Action _ScreenClosedEvent;

		// Token: 0x0400228E RID: 8846
		[Token(Token = "0x400228E")]
		[FieldOffset(Offset = "0xBC")]
		private Action _ScreenOpenedEvent;

		// Token: 0x0400228F RID: 8847
		[Token(Token = "0x400228F")]
		[FieldOffset(Offset = "0xC0")]
		private Action _PopupWindowOpenedEvent;

		// Token: 0x04002290 RID: 8848
		[Token(Token = "0x4002290")]
		[FieldOffset(Offset = "0xC4")]
		private Action _PopupWindowClosedEvent;

		// Token: 0x04002291 RID: 8849
		[Token(Token = "0x4002291")]
		[FieldOffset(Offset = "0xC8")]
		private Action _InputPollingStartedEvent;

		// Token: 0x04002292 RID: 8850
		[Token(Token = "0x4002292")]
		[FieldOffset(Offset = "0xCC")]
		private Action _InputPollingEndedEvent;

		// Token: 0x04002293 RID: 8851
		[Token(Token = "0x4002293")]
		[FieldOffset(Offset = "0xD0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE4450", Offset = "0xE3850")]
		[SerializeField]
		private UnityEvent _onScreenClosed;

		// Token: 0x04002294 RID: 8852
		[Token(Token = "0x4002294")]
		[FieldOffset(Offset = "0xD4")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE4490", Offset = "0xE3890")]
		private UnityEvent _onScreenOpened;

		// Token: 0x04002295 RID: 8853
		[Token(Token = "0x4002295")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE44D0", Offset = "0xE38D0")]
		private UnityEvent _onPopupWindowClosed;

		// Token: 0x04002296 RID: 8854
		[Token(Token = "0x4002296")]
		[FieldOffset(Offset = "0xDC")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE4510", Offset = "0xE3910")]
		private UnityEvent _onPopupWindowOpened;

		// Token: 0x04002297 RID: 8855
		[Token(Token = "0x4002297")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE4550", Offset = "0xE3950")]
		private UnityEvent _onInputPollingStarted;

		// Token: 0x04002298 RID: 8856
		[Token(Token = "0x4002298")]
		[FieldOffset(Offset = "0xE4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE4590", Offset = "0xE3990")]
		[SerializeField]
		private UnityEvent _onInputPollingEnded;

		// Token: 0x04002299 RID: 8857
		[Token(Token = "0x4002299")]
		[FieldOffset(Offset = "0x0")]
		private static ControlMapper Instance;

		// Token: 0x0400229A RID: 8858
		[Token(Token = "0x400229A")]
		[FieldOffset(Offset = "0xE8")]
		private bool initialized;

		// Token: 0x0400229B RID: 8859
		[Token(Token = "0x400229B")]
		[FieldOffset(Offset = "0xEC")]
		private int playerCount;

		// Token: 0x0400229C RID: 8860
		[Token(Token = "0x400229C")]
		[FieldOffset(Offset = "0xF0")]
		private ControlMapper.InputGrid inputGrid;

		// Token: 0x0400229D RID: 8861
		[Token(Token = "0x400229D")]
		[FieldOffset(Offset = "0xF4")]
		private ControlMapper.WindowManager windowManager;

		// Token: 0x0400229E RID: 8862
		[Token(Token = "0x400229E")]
		[FieldOffset(Offset = "0xF8")]
		private int currentPlayerId;

		// Token: 0x0400229F RID: 8863
		[Token(Token = "0x400229F")]
		[FieldOffset(Offset = "0xFC")]
		private int currentMapCategoryId;

		// Token: 0x040022A0 RID: 8864
		[Token(Token = "0x40022A0")]
		[FieldOffset(Offset = "0x100")]
		private List<ControlMapper.GUIButton> playerButtons;

		// Token: 0x040022A1 RID: 8865
		[Token(Token = "0x40022A1")]
		[FieldOffset(Offset = "0x104")]
		private List<ControlMapper.GUIButton> mapCategoryButtons;

		// Token: 0x040022A2 RID: 8866
		[Token(Token = "0x40022A2")]
		[FieldOffset(Offset = "0x108")]
		private List<ControlMapper.GUIButton> assignedControllerButtons;

		// Token: 0x040022A3 RID: 8867
		[Token(Token = "0x40022A3")]
		[FieldOffset(Offset = "0x10C")]
		private ControlMapper.GUIButton assignedControllerButtonsPlaceholder;

		// Token: 0x040022A4 RID: 8868
		[Token(Token = "0x40022A4")]
		[FieldOffset(Offset = "0x110")]
		private List<GameObject> miscInstantiatedObjects;

		// Token: 0x040022A5 RID: 8869
		[Token(Token = "0x40022A5")]
		[FieldOffset(Offset = "0x114")]
		private GameObject canvas;

		// Token: 0x040022A6 RID: 8870
		[Token(Token = "0x40022A6")]
		[FieldOffset(Offset = "0x118")]
		private GameObject lastUISelection;

		// Token: 0x040022A7 RID: 8871
		[Token(Token = "0x40022A7")]
		[FieldOffset(Offset = "0x11C")]
		private int currentJoystickId;

		// Token: 0x040022A8 RID: 8872
		[Token(Token = "0x40022A8")]
		[FieldOffset(Offset = "0x120")]
		private float blockInputOnFocusEndTime;

		// Token: 0x040022A9 RID: 8873
		[Token(Token = "0x40022A9")]
		[FieldOffset(Offset = "0x124")]
		private bool isPollingForInput;

		// Token: 0x040022AA RID: 8874
		[Token(Token = "0x40022AA")]
		[FieldOffset(Offset = "0x128")]
		private ControlMapper.InputMapping pendingInputMapping;

		// Token: 0x040022AB RID: 8875
		[Token(Token = "0x40022AB")]
		[FieldOffset(Offset = "0x12C")]
		private ControlMapper.AxisCalibrator pendingAxisCalibration;

		// Token: 0x040022AC RID: 8876
		[Token(Token = "0x40022AC")]
		[FieldOffset(Offset = "0x130")]
		private Action<InputFieldInfo> inputFieldActivatedDelegate;

		// Token: 0x040022AD RID: 8877
		[Token(Token = "0x40022AD")]
		[FieldOffset(Offset = "0x134")]
		private Action<ToggleInfo, bool> inputFieldInvertToggleStateChangedDelegate;

		// Token: 0x040022AE RID: 8878
		[Token(Token = "0x40022AE")]
		[FieldOffset(Offset = "0x138")]
		private Action _restoreDefaultsDelegate;

		// Token: 0x02000564 RID: 1380
		[Token(Token = "0x2000564")]
		private abstract class GUIElement
		{
			// Token: 0x170006A4 RID: 1700
			// (get) Token: 0x0600214D RID: 8525 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600214E RID: 8526 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170006A4")]
			public RectTransform rectTransform
			{
				[Token(Token = "0x600214D")]
				[Address(RVA = "0x287A00", Offset = "0x286E00", VA = "0x10287A00")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
				get
				{
					return null;
				}
				[Token(Token = "0x600214E")]
				[Address(RVA = "0x287920", Offset = "0x286D20", VA = "0x10287920")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
				private set
				{
				}
			}

			// Token: 0x0600214F RID: 8527 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600214F")]
			[Address(RVA = "0x3BD3F0", Offset = "0x3BC7F0", VA = "0x103BD3F0")]
			public GUIElement(GameObject gameObject)
			{
			}

			// Token: 0x06002150 RID: 8528 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002150")]
			[Address(RVA = "0x3BD5F0", Offset = "0x3BC9F0", VA = "0x103BD5F0")]
			public GUIElement(Selectable selectable, TMP_Text label)
			{
			}

			// Token: 0x06002151 RID: 8529 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002151")]
			[Address(RVA = "0x3BD230", Offset = "0x3BC630", VA = "0x103BD230", Slot = "4")]
			public virtual void SetInteractible(bool state, bool playTransition)
			{
			}

			// Token: 0x06002152 RID: 8530 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002152")]
			[Address(RVA = "0x3BD0F0", Offset = "0x3BC4F0", VA = "0x103BD0F0", Slot = "5")]
			public virtual void SetInteractible(bool state, bool playTransition, bool permanent)
			{
			}

			// Token: 0x06002153 RID: 8531 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002153")]
			[Address(RVA = "0x3BD2E0", Offset = "0x3BC6E0", VA = "0x103BD2E0", Slot = "6")]
			public virtual void SetTextWidth(int value)
			{
			}

			// Token: 0x06002154 RID: 8532 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002154")]
			[Address(RVA = "0x3BCF80", Offset = "0x3BC380", VA = "0x103BCF80", Slot = "7")]
			public virtual void SetFirstChildObjectWidth(ControlMapper.LayoutElementSizeType type, int value)
			{
			}

			// Token: 0x06002155 RID: 8533 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002155")]
			[Address(RVA = "0x3BD260", Offset = "0x3BC660", VA = "0x103BD260", Slot = "8")]
			public virtual void SetLabel(string label)
			{
			}

			// Token: 0x06002156 RID: 8534 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002156")]
			[Address(RVA = "0x3BCBB0", Offset = "0x3BBFB0", VA = "0x103BCBB0", Slot = "9")]
			public virtual string GetLabel()
			{
				return null;
			}

			// Token: 0x06002157 RID: 8535 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002157")]
			[Address(RVA = "0x3BCB60", Offset = "0x3BBF60", VA = "0x103BCB60", Slot = "10")]
			public virtual void AddChild(ControlMapper.GUIElement child)
			{
			}

			// Token: 0x06002158 RID: 8536 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002158")]
			[Address(RVA = "0x3BCF00", Offset = "0x3BC300", VA = "0x103BCF00")]
			public void SetElementInfoData(string identifier, int intData)
			{
			}

			// Token: 0x06002159 RID: 8537 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002159")]
			[Address(RVA = "0x3BCE80", Offset = "0x3BC280", VA = "0x103BCE80", Slot = "11")]
			public virtual void SetActive(bool state)
			{
			}

			// Token: 0x0600215A RID: 8538 RVA: 0x0000A3F8 File Offset: 0x000085F8
			[Token(Token = "0x600215A")]
			[Address(RVA = "0x3BCC50", Offset = "0x3BC050", VA = "0x103BCC50", Slot = "12")]
			protected virtual bool Init()
			{
				return default(bool);
			}

			// Token: 0x040022AF RID: 8879
			[Token(Token = "0x40022AF")]
			[FieldOffset(Offset = "0x8")]
			public readonly GameObject gameObject;

			// Token: 0x040022B0 RID: 8880
			[Token(Token = "0x40022B0")]
			[FieldOffset(Offset = "0xC")]
			protected readonly TMP_Text text;

			// Token: 0x040022B1 RID: 8881
			[Token(Token = "0x40022B1")]
			[FieldOffset(Offset = "0x10")]
			public readonly Selectable selectable;

			// Token: 0x040022B2 RID: 8882
			[Token(Token = "0x40022B2")]
			[FieldOffset(Offset = "0x14")]
			protected readonly UIElementInfo uiElementInfo;

			// Token: 0x040022B3 RID: 8883
			[Token(Token = "0x40022B3")]
			[FieldOffset(Offset = "0x18")]
			protected bool permanentStateSet;

			// Token: 0x040022B4 RID: 8884
			[Token(Token = "0x40022B4")]
			[FieldOffset(Offset = "0x1C")]
			protected readonly List<ControlMapper.GUIElement> children;

			// Token: 0x040022B5 RID: 8885
			[Token(Token = "0x40022B5")]
			[FieldOffset(Offset = "0x20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private RectTransform <rectTransform>k__BackingField;
		}

		// Token: 0x02000565 RID: 1381
		[Token(Token = "0x2000565")]
		private class GUIButton : ControlMapper.GUIElement
		{
			// Token: 0x170006A5 RID: 1701
			// (get) Token: 0x0600215B RID: 8539 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006A5")]
			protected Button button
			{
				[Token(Token = "0x600215B")]
				[Address(RVA = "0x3BCAF0", Offset = "0x3BBEF0", VA = "0x103BCAF0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006A6 RID: 1702
			// (get) Token: 0x0600215C RID: 8540 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006A6")]
			public ButtonInfo buttonInfo
			{
				[Token(Token = "0x600215C")]
				[Address(RVA = "0x3BCA80", Offset = "0x3BBE80", VA = "0x103BCA80")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600215D RID: 8541 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600215D")]
			[Address(RVA = "0x3BCA50", Offset = "0x3BBE50", VA = "0x103BCA50")]
			public GUIButton(GameObject gameObject)
			{
			}

			// Token: 0x0600215E RID: 8542 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600215E")]
			[Address(RVA = "0x3BCA20", Offset = "0x3BBE20", VA = "0x103BCA20")]
			public GUIButton(Button button, TMP_Text label)
			{
			}

			// Token: 0x0600215F RID: 8543 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600215F")]
			[Address(RVA = "0x3BC910", Offset = "0x3BBD10", VA = "0x103BC910")]
			public void SetButtonInfoData(string identifier, int intData)
			{
			}

			// Token: 0x06002160 RID: 8544 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002160")]
			[Address(RVA = "0x3BC920", Offset = "0x3BBD20", VA = "0x103BC920")]
			public void SetOnClickCallback(Action<ButtonInfo> callback)
			{
			}

			// Token: 0x02000566 RID: 1382
			[Token(Token = "0x2000566")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private sealed class <>c__DisplayClass7_0
			{
				// Token: 0x06002161 RID: 8545 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6002161")]
				[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
				public <>c__DisplayClass7_0()
				{
				}

				// Token: 0x06002162 RID: 8546 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6002162")]
				[Address(RVA = "0x1302950", Offset = "0x1301D50", VA = "0x11302950")]
				internal void <SetOnClickCallback>b__0()
				{
				}

				// Token: 0x040022B6 RID: 8886
				[Token(Token = "0x40022B6")]
				[FieldOffset(Offset = "0x8")]
				public Action<ButtonInfo> callback;

				// Token: 0x040022B7 RID: 8887
				[Token(Token = "0x40022B7")]
				[FieldOffset(Offset = "0xC")]
				public ControlMapper.GUIButton <>4__this;
			}
		}

		// Token: 0x02000567 RID: 1383
		[Token(Token = "0x2000567")]
		private class GUIInputField : ControlMapper.GUIElement
		{
			// Token: 0x170006A7 RID: 1703
			// (get) Token: 0x06002163 RID: 8547 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006A7")]
			protected Button button
			{
				[Token(Token = "0x6002163")]
				[Address(RVA = "0x3BDB30", Offset = "0x3BCF30", VA = "0x103BDB30")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006A8 RID: 1704
			// (get) Token: 0x06002164 RID: 8548 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006A8")]
			public InputFieldInfo fieldInfo
			{
				[Token(Token = "0x6002164")]
				[Address(RVA = "0x3BDC30", Offset = "0x3BD030", VA = "0x103BDC30")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006A9 RID: 1705
			// (get) Token: 0x06002165 RID: 8549 RVA: 0x0000A410 File Offset: 0x00008610
			[Token(Token = "0x170006A9")]
			public bool hasToggle
			{
				[Token(Token = "0x6002165")]
				[Address(RVA = "0x3BDCA0", Offset = "0x3BD0A0", VA = "0x103BDCA0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170006AA RID: 1706
			// (get) Token: 0x06002166 RID: 8550 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06002167 RID: 8551 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170006AA")]
			public ControlMapper.GUIToggle toggle
			{
				[Token(Token = "0x6002166")]
				[Address(RVA = "0x292AA0", Offset = "0x291EA0", VA = "0x10292AA0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6002167")]
				[Address(RVA = "0x292AB0", Offset = "0x291EB0", VA = "0x10292AB0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
				private set
				{
				}
			}

			// Token: 0x170006AB RID: 1707
			// (get) Token: 0x06002168 RID: 8552 RVA: 0x0000A428 File Offset: 0x00008628
			// (set) Token: 0x06002169 RID: 8553 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170006AB")]
			public int actionElementMapId
			{
				[Token(Token = "0x6002168")]
				[Address(RVA = "0x3BDAA0", Offset = "0x3BCEA0", VA = "0x103BDAA0")]
				get
				{
					return 0;
				}
				[Token(Token = "0x6002169")]
				[Address(RVA = "0x3BDCB0", Offset = "0x3BD0B0", VA = "0x103BDCB0")]
				set
				{
				}
			}

			// Token: 0x170006AC RID: 1708
			// (get) Token: 0x0600216A RID: 8554 RVA: 0x0000A440 File Offset: 0x00008640
			// (set) Token: 0x0600216B RID: 8555 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170006AC")]
			public int controllerId
			{
				[Token(Token = "0x600216A")]
				[Address(RVA = "0x3BDBA0", Offset = "0x3BCFA0", VA = "0x103BDBA0")]
				get
				{
					return 0;
				}
				[Token(Token = "0x600216B")]
				[Address(RVA = "0x3BDD30", Offset = "0x3BD130", VA = "0x103BDD30")]
				set
				{
				}
			}

			// Token: 0x0600216C RID: 8556 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600216C")]
			[Address(RVA = "0x3BCA50", Offset = "0x3BBE50", VA = "0x103BCA50")]
			public GUIInputField(GameObject gameObject)
			{
			}

			// Token: 0x0600216D RID: 8557 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600216D")]
			[Address(RVA = "0x3BCA20", Offset = "0x3BBE20", VA = "0x103BCA20")]
			public GUIInputField(Button button, TMP_Text label)
			{
			}

			// Token: 0x0600216E RID: 8558 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600216E")]
			[Address(RVA = "0x3BD760", Offset = "0x3BCB60", VA = "0x103BD760")]
			public void SetFieldInfoData(int actionId, AxisRange axisRange, ControllerType controllerType, int intData)
			{
			}

			// Token: 0x0600216F RID: 8559 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600216F")]
			[Address(RVA = "0x3BD9A0", Offset = "0x3BCDA0", VA = "0x103BD9A0")]
			public void SetOnClickCallback(Action<InputFieldInfo> callback)
			{
			}

			// Token: 0x06002170 RID: 8560 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002170")]
			[Address(RVA = "0x3BD830", Offset = "0x3BCC30", VA = "0x103BD830", Slot = "13")]
			public virtual void SetInteractable(bool state, bool playTransition, bool permanent)
			{
			}

			// Token: 0x06002171 RID: 8561 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002171")]
			[Address(RVA = "0x3BD740", Offset = "0x3BCB40", VA = "0x103BD740")]
			public void AddToggle(ControlMapper.GUIToggle toggle)
			{
			}

			// Token: 0x040022B8 RID: 8888
			[Token(Token = "0x40022B8")]
			[FieldOffset(Offset = "0x24")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private ControlMapper.GUIToggle <toggle>k__BackingField;

			// Token: 0x02000568 RID: 1384
			[Token(Token = "0x2000568")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private sealed class <>c__DisplayClass19_0
			{
				// Token: 0x06002172 RID: 8562 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6002172")]
				[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
				public <>c__DisplayClass19_0()
				{
				}

				// Token: 0x06002173 RID: 8563 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6002173")]
				[Address(RVA = "0x1302350", Offset = "0x1301750", VA = "0x11302350")]
				internal void <SetOnClickCallback>b__0()
				{
				}

				// Token: 0x040022B9 RID: 8889
				[Token(Token = "0x40022B9")]
				[FieldOffset(Offset = "0x8")]
				public Action<InputFieldInfo> callback;

				// Token: 0x040022BA RID: 8890
				[Token(Token = "0x40022BA")]
				[FieldOffset(Offset = "0xC")]
				public ControlMapper.GUIInputField <>4__this;
			}
		}

		// Token: 0x02000569 RID: 1385
		[Token(Token = "0x2000569")]
		private class GUIToggle : ControlMapper.GUIElement
		{
			// Token: 0x170006AD RID: 1709
			// (get) Token: 0x06002174 RID: 8564 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006AD")]
			protected Toggle toggle
			{
				[Token(Token = "0x6002174")]
				[Address(RVA = "0x3BE8F0", Offset = "0x3BDCF0", VA = "0x103BE8F0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006AE RID: 1710
			// (get) Token: 0x06002175 RID: 8565 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006AE")]
			public ToggleInfo toggleInfo
			{
				[Token(Token = "0x6002175")]
				[Address(RVA = "0x3BE880", Offset = "0x3BDC80", VA = "0x103BE880")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006AF RID: 1711
			// (get) Token: 0x06002176 RID: 8566 RVA: 0x0000A458 File Offset: 0x00008658
			// (set) Token: 0x06002177 RID: 8567 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170006AF")]
			public int actionElementMapId
			{
				[Token(Token = "0x6002176")]
				[Address(RVA = "0x3BE7F0", Offset = "0x3BDBF0", VA = "0x103BE7F0")]
				get
				{
					return 0;
				}
				[Token(Token = "0x6002177")]
				[Address(RVA = "0x3BE960", Offset = "0x3BDD60", VA = "0x103BE960")]
				set
				{
				}
			}

			// Token: 0x06002178 RID: 8568 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002178")]
			[Address(RVA = "0x3BCA50", Offset = "0x3BBE50", VA = "0x103BCA50")]
			public GUIToggle(GameObject gameObject)
			{
			}

			// Token: 0x06002179 RID: 8569 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002179")]
			[Address(RVA = "0x3BCA20", Offset = "0x3BBE20", VA = "0x103BCA20")]
			public GUIToggle(Toggle toggle, TMP_Text label)
			{
			}

			// Token: 0x0600217A RID: 8570 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600217A")]
			[Address(RVA = "0x3BE690", Offset = "0x3BDA90", VA = "0x103BE690")]
			public void SetToggleInfoData(int actionId, AxisRange axisRange, ControllerType controllerType, int intData)
			{
			}

			// Token: 0x0600217B RID: 8571 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600217B")]
			[Address(RVA = "0x3BE3A0", Offset = "0x3BD7A0", VA = "0x103BE3A0")]
			public void SetOnSubmitCallback(Action<ToggleInfo, bool> callback)
			{
			}

			// Token: 0x0600217C RID: 8572 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600217C")]
			[Address(RVA = "0x3BE760", Offset = "0x3BDB60", VA = "0x103BE760")]
			public void SetToggleState(bool state)
			{
			}

			// Token: 0x0200056A RID: 1386
			[Token(Token = "0x200056A")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private sealed class <>c__DisplayClass10_0
			{
				// Token: 0x0600217D RID: 8573 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600217D")]
				[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
				public <>c__DisplayClass10_0()
				{
				}

				// Token: 0x0600217E RID: 8574 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600217E")]
				[Address(RVA = "0x13021C0", Offset = "0x13015C0", VA = "0x113021C0")]
				internal void <SetOnSubmitCallback>b__0(BaseEventData data)
				{
				}

				// Token: 0x040022BB RID: 8891
				[Token(Token = "0x40022BB")]
				[FieldOffset(Offset = "0x8")]
				public Action<ToggleInfo, bool> callback;

				// Token: 0x040022BC RID: 8892
				[Token(Token = "0x40022BC")]
				[FieldOffset(Offset = "0xC")]
				public ControlMapper.GUIToggle <>4__this;
			}
		}

		// Token: 0x0200056B RID: 1387
		[Token(Token = "0x200056B")]
		private class GUILabel
		{
			// Token: 0x170006B0 RID: 1712
			// (get) Token: 0x0600217F RID: 8575 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06002180 RID: 8576 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170006B0")]
			public GameObject gameObject
			{
				[Token(Token = "0x600217F")]
				[Address(RVA = "0x273EB0", Offset = "0x2732B0", VA = "0x10273EB0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6002180")]
				[Address(RVA = "0x273EF0", Offset = "0x2732F0", VA = "0x10273EF0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
				private set
				{
				}
			}

			// Token: 0x170006B1 RID: 1713
			// (get) Token: 0x06002181 RID: 8577 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06002182 RID: 8578 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170006B1")]
			private TMP_Text text
			{
				[Token(Token = "0x6002181")]
				[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6002182")]
				[Address(RVA = "0x273ED0", Offset = "0x2732D0", VA = "0x10273ED0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
				set
				{
				}
			}

			// Token: 0x170006B2 RID: 1714
			// (get) Token: 0x06002183 RID: 8579 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06002184 RID: 8580 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170006B2")]
			public RectTransform rectTransform
			{
				[Token(Token = "0x6002183")]
				[Address(RVA = "0x273EC0", Offset = "0x2732C0", VA = "0x10273EC0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6002184")]
				[Address(RVA = "0x273100", Offset = "0x272500", VA = "0x10273100")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
				private set
				{
				}
			}

			// Token: 0x06002185 RID: 8581 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002185")]
			[Address(RVA = "0x3BE2A0", Offset = "0x3BD6A0", VA = "0x103BE2A0")]
			public GUILabel(GameObject gameObject)
			{
			}

			// Token: 0x06002186 RID: 8582 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002186")]
			[Address(RVA = "0x3BE270", Offset = "0x3BD670", VA = "0x103BE270")]
			public GUILabel(TMP_Text label)
			{
			}

			// Token: 0x06002187 RID: 8583 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002187")]
			[Address(RVA = "0x3BE0B0", Offset = "0x3BD4B0", VA = "0x103BE0B0")]
			public void SetSize(int width, int height)
			{
			}

			// Token: 0x06002188 RID: 8584 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002188")]
			[Address(RVA = "0x3BE1E0", Offset = "0x3BD5E0", VA = "0x103BE1E0")]
			public void SetWidth(int width)
			{
			}

			// Token: 0x06002189 RID: 8585 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002189")]
			[Address(RVA = "0x3BDFA0", Offset = "0x3BD3A0", VA = "0x103BDFA0")]
			public void SetHeight(int height)
			{
			}

			// Token: 0x0600218A RID: 8586 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600218A")]
			[Address(RVA = "0x3BE030", Offset = "0x3BD430", VA = "0x103BE030")]
			public void SetLabel(string label)
			{
			}

			// Token: 0x0600218B RID: 8587 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600218B")]
			[Address(RVA = "0x3BDF20", Offset = "0x3BD320", VA = "0x103BDF20")]
			public void SetFontStyle(FontStyles style)
			{
			}

			// Token: 0x0600218C RID: 8588 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600218C")]
			[Address(RVA = "0x3BE160", Offset = "0x3BD560", VA = "0x103BE160")]
			public void SetTextAlignment(TextAlignmentOptions alignment)
			{
			}

			// Token: 0x0600218D RID: 8589 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600218D")]
			[Address(RVA = "0x3BDEA0", Offset = "0x3BD2A0", VA = "0x103BDEA0")]
			public void SetActive(bool state)
			{
			}

			// Token: 0x0600218E RID: 8590 RVA: 0x0000A470 File Offset: 0x00008670
			[Token(Token = "0x600218E")]
			[Address(RVA = "0x3BDDB0", Offset = "0x3BD1B0", VA = "0x103BDDB0")]
			private bool Check()
			{
				return default(bool);
			}

			// Token: 0x040022BD RID: 8893
			[Token(Token = "0x40022BD")]
			[FieldOffset(Offset = "0x8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private GameObject <gameObject>k__BackingField;

			// Token: 0x040022BE RID: 8894
			[Token(Token = "0x40022BE")]
			[FieldOffset(Offset = "0xC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private TMP_Text <text>k__BackingField;

			// Token: 0x040022BF RID: 8895
			[Token(Token = "0x40022BF")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private RectTransform <rectTransform>k__BackingField;
		}

		// Token: 0x0200056C RID: 1388
		[Token(Token = "0x200056C")]
		[Serializable]
		public class MappingSet
		{
			// Token: 0x170006B3 RID: 1715
			// (get) Token: 0x0600218F RID: 8591 RVA: 0x0000A488 File Offset: 0x00008688
			[Token(Token = "0x170006B3")]
			public int mapCategoryId
			{
				[Token(Token = "0x600218F")]
				[Address(RVA = "0x273EB0", Offset = "0x2732B0", VA = "0x10273EB0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170006B4 RID: 1716
			// (get) Token: 0x06002190 RID: 8592 RVA: 0x0000A4A0 File Offset: 0x000086A0
			[Token(Token = "0x170006B4")]
			public ControlMapper.MappingSet.ActionListMode actionListMode
			{
				[Token(Token = "0x6002190")]
				[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90")]
				get
				{
					return ControlMapper.MappingSet.ActionListMode.ActionCategory;
				}
			}

			// Token: 0x170006B5 RID: 1717
			// (get) Token: 0x06002191 RID: 8593 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006B5")]
			public IList<int> actionCategoryIds
			{
				[Token(Token = "0x6002191")]
				[Address(RVA = "0x3C0CC0", Offset = "0x3C00C0", VA = "0x103C0CC0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006B6 RID: 1718
			// (get) Token: 0x06002192 RID: 8594 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006B6")]
			public IList<int> actionIds
			{
				[Token(Token = "0x6002192")]
				[Address(RVA = "0x3C0D30", Offset = "0x3C0130", VA = "0x103C0D30")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006B7 RID: 1719
			// (get) Token: 0x06002193 RID: 8595 RVA: 0x0000A4B8 File Offset: 0x000086B8
			[Token(Token = "0x170006B7")]
			public bool isValid
			{
				[Token(Token = "0x6002193")]
				[Address(RVA = "0x3C0DA0", Offset = "0x3C01A0", VA = "0x103C0DA0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06002194 RID: 8596 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002194")]
			[Address(RVA = "0x3C0BB0", Offset = "0x3BFFB0", VA = "0x103C0BB0")]
			public MappingSet()
			{
			}

			// Token: 0x06002195 RID: 8597 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002195")]
			[Address(RVA = "0x3C0C10", Offset = "0x3C0010", VA = "0x103C0C10")]
			private MappingSet(int mapCategoryId, ControlMapper.MappingSet.ActionListMode actionListMode, int[] actionCategoryIds, int[] actionIds)
			{
			}

			// Token: 0x170006B8 RID: 1720
			// (get) Token: 0x06002196 RID: 8598 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006B8")]
			public static ControlMapper.MappingSet Default
			{
				[Token(Token = "0x6002196")]
				[Address(RVA = "0x3C0C40", Offset = "0x3C0040", VA = "0x103C0C40")]
				get
				{
					return null;
				}
			}

			// Token: 0x040022C0 RID: 8896
			[Token(Token = "0x40022C0")]
			[FieldOffset(Offset = "0x8")]
			[Attribute(Name = "TooltipAttribute", RVA = "0xE46C0", Offset = "0xE3AC0")]
			[SerializeField]
			private int _mapCategoryId;

			// Token: 0x040022C1 RID: 8897
			[Token(Token = "0x40022C1")]
			[FieldOffset(Offset = "0xC")]
			[Attribute(Name = "TooltipAttribute", RVA = "0xE4700", Offset = "0xE3B00")]
			[SerializeField]
			private ControlMapper.MappingSet.ActionListMode _actionListMode;

			// Token: 0x040022C2 RID: 8898
			[Token(Token = "0x40022C2")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private int[] _actionCategoryIds;

			// Token: 0x040022C3 RID: 8899
			[Token(Token = "0x40022C3")]
			[FieldOffset(Offset = "0x14")]
			[SerializeField]
			private int[] _actionIds;

			// Token: 0x040022C4 RID: 8900
			[Token(Token = "0x40022C4")]
			[FieldOffset(Offset = "0x18")]
			private IList<int> _actionCategoryIdsReadOnly;

			// Token: 0x040022C5 RID: 8901
			[Token(Token = "0x40022C5")]
			[FieldOffset(Offset = "0x1C")]
			private IList<int> _actionIdsReadOnly;

			// Token: 0x0200056D RID: 1389
			[Token(Token = "0x200056D")]
			public enum ActionListMode
			{
				// Token: 0x040022C7 RID: 8903
				[Token(Token = "0x40022C7")]
				ActionCategory,
				// Token: 0x040022C8 RID: 8904
				[Token(Token = "0x40022C8")]
				Action
			}
		}

		// Token: 0x0200056E RID: 1390
		[Token(Token = "0x200056E")]
		[Serializable]
		public class InputBehaviorSettings
		{
			// Token: 0x170006B9 RID: 1721
			// (get) Token: 0x06002197 RID: 8599 RVA: 0x0000A4D0 File Offset: 0x000086D0
			[Token(Token = "0x170006B9")]
			public int inputBehaviorId
			{
				[Token(Token = "0x6002197")]
				[Address(RVA = "0x273EB0", Offset = "0x2732B0", VA = "0x10273EB0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170006BA RID: 1722
			// (get) Token: 0x06002198 RID: 8600 RVA: 0x0000A4E8 File Offset: 0x000086E8
			[Token(Token = "0x170006BA")]
			public bool showJoystickAxisSensitivity
			{
				[Token(Token = "0x6002198")]
				[Address(RVA = "0x2D4E40", Offset = "0x2D4240", VA = "0x102D4E40")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170006BB RID: 1723
			// (get) Token: 0x06002199 RID: 8601 RVA: 0x0000A500 File Offset: 0x00008700
			[Token(Token = "0x170006BB")]
			public bool showMouseXYAxisSensitivity
			{
				[Token(Token = "0x6002199")]
				[Address(RVA = "0x2D4E30", Offset = "0x2D4230", VA = "0x102D4E30")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170006BC RID: 1724
			// (get) Token: 0x0600219A RID: 8602 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006BC")]
			public string labelLanguageKey
			{
				[Token(Token = "0x600219A")]
				[Address(RVA = "0x273EC0", Offset = "0x2732C0", VA = "0x10273EC0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006BD RID: 1725
			// (get) Token: 0x0600219B RID: 8603 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006BD")]
			public string joystickAxisSensitivityLabelLanguageKey
			{
				[Token(Token = "0x600219B")]
				[Address(RVA = "0x273EA0", Offset = "0x2732A0", VA = "0x10273EA0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006BE RID: 1726
			// (get) Token: 0x0600219C RID: 8604 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006BE")]
			public string mouseXYAxisSensitivityLabelLanguageKey
			{
				[Token(Token = "0x600219C")]
				[Address(RVA = "0x277A30", Offset = "0x276E30", VA = "0x10277A30")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006BF RID: 1727
			// (get) Token: 0x0600219D RID: 8605 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006BF")]
			public Sprite joystickAxisSensitivityIcon
			{
				[Token(Token = "0x600219D")]
				[Address(RVA = "0x277A40", Offset = "0x276E40", VA = "0x10277A40")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006C0 RID: 1728
			// (get) Token: 0x0600219E RID: 8606 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006C0")]
			public Sprite mouseXYAxisSensitivityIcon
			{
				[Token(Token = "0x600219E")]
				[Address(RVA = "0x287A00", Offset = "0x286E00", VA = "0x10287A00")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006C1 RID: 1729
			// (get) Token: 0x0600219F RID: 8607 RVA: 0x0000A518 File Offset: 0x00008718
			[Token(Token = "0x170006C1")]
			public float joystickAxisSensitivityMin
			{
				[Token(Token = "0x600219F")]
				[Address(RVA = "0x365CC0", Offset = "0x3650C0", VA = "0x10365CC0")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x170006C2 RID: 1730
			// (get) Token: 0x060021A0 RID: 8608 RVA: 0x0000A530 File Offset: 0x00008730
			[Token(Token = "0x170006C2")]
			public float joystickAxisSensitivityMax
			{
				[Token(Token = "0x60021A0")]
				[Address(RVA = "0x328150", Offset = "0x327550", VA = "0x10328150")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x170006C3 RID: 1731
			// (get) Token: 0x060021A1 RID: 8609 RVA: 0x0000A548 File Offset: 0x00008748
			[Token(Token = "0x170006C3")]
			public float mouseXYAxisSensitivityMin
			{
				[Token(Token = "0x60021A1")]
				[Address(RVA = "0x328170", Offset = "0x327570", VA = "0x10328170")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x170006C4 RID: 1732
			// (get) Token: 0x060021A2 RID: 8610 RVA: 0x0000A560 File Offset: 0x00008760
			[Token(Token = "0x170006C4")]
			public float mouseXYAxisSensitivityMax
			{
				[Token(Token = "0x60021A2")]
				[Address(RVA = "0x3BEE50", Offset = "0x3BE250", VA = "0x103BEE50")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x170006C5 RID: 1733
			// (get) Token: 0x060021A3 RID: 8611 RVA: 0x0000A578 File Offset: 0x00008778
			[Token(Token = "0x170006C5")]
			public bool isValid
			{
				[Token(Token = "0x60021A3")]
				[Address(RVA = "0x3BEE30", Offset = "0x3BE230", VA = "0x103BEE30")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060021A4 RID: 8612 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60021A4")]
			[Address(RVA = "0x3BEDB0", Offset = "0x3BE1B0", VA = "0x103BEDB0")]
			public InputBehaviorSettings()
			{
			}

			// Token: 0x040022C9 RID: 8905
			[Token(Token = "0x40022C9")]
			[FieldOffset(Offset = "0x8")]
			[Attribute(Name = "TooltipAttribute", RVA = "0xE4790", Offset = "0xE3B90")]
			[SerializeField]
			private int _inputBehaviorId;

			// Token: 0x040022CA RID: 8906
			[Token(Token = "0x40022CA")]
			[FieldOffset(Offset = "0xC")]
			[Attribute(Name = "TooltipAttribute", RVA = "0xE4820", Offset = "0xE3C20")]
			[SerializeField]
			private bool _showJoystickAxisSensitivity;

			// Token: 0x040022CB RID: 8907
			[Token(Token = "0x40022CB")]
			[FieldOffset(Offset = "0xD")]
			[SerializeField]
			[Attribute(Name = "TooltipAttribute", RVA = "0xE4860", Offset = "0xE3C60")]
			private bool _showMouseXYAxisSensitivity;

			// Token: 0x040022CC RID: 8908
			[Token(Token = "0x40022CC")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "TooltipAttribute", RVA = "0xE4920", Offset = "0xE3D20")]
			[SerializeField]
			private string _labelLanguageKey;

			// Token: 0x040022CD RID: 8909
			[Token(Token = "0x40022CD")]
			[FieldOffset(Offset = "0x14")]
			[Attribute(Name = "TooltipAttribute", RVA = "0xE4960", Offset = "0xE3D60")]
			[SerializeField]
			private string _joystickAxisSensitivityLabelLanguageKey;

			// Token: 0x040022CE RID: 8910
			[Token(Token = "0x40022CE")]
			[FieldOffset(Offset = "0x18")]
			[Attribute(Name = "TooltipAttribute", RVA = "0xE49F0", Offset = "0xE3DF0")]
			[SerializeField]
			private string _mouseXYAxisSensitivityLabelLanguageKey;

			// Token: 0x040022CF RID: 8911
			[Token(Token = "0x40022CF")]
			[FieldOffset(Offset = "0x1C")]
			[Attribute(Name = "TooltipAttribute", RVA = "0xE4A30", Offset = "0xE3E30")]
			[SerializeField]
			private Sprite _joystickAxisSensitivityIcon;

			// Token: 0x040022D0 RID: 8912
			[Token(Token = "0x40022D0")]
			[FieldOffset(Offset = "0x20")]
			[Attribute(Name = "TooltipAttribute", RVA = "0xE4A30", Offset = "0xE3E30")]
			[SerializeField]
			private Sprite _mouseXYAxisSensitivityIcon;

			// Token: 0x040022D1 RID: 8913
			[Token(Token = "0x40022D1")]
			[FieldOffset(Offset = "0x24")]
			[Attribute(Name = "TooltipAttribute", RVA = "0xE4A70", Offset = "0xE3E70")]
			[SerializeField]
			private float _joystickAxisSensitivityMin;

			// Token: 0x040022D2 RID: 8914
			[Token(Token = "0x40022D2")]
			[FieldOffset(Offset = "0x28")]
			[Attribute(Name = "TooltipAttribute", RVA = "0xE4AB0", Offset = "0xE3EB0")]
			[SerializeField]
			private float _joystickAxisSensitivityMax;

			// Token: 0x040022D3 RID: 8915
			[Token(Token = "0x40022D3")]
			[FieldOffset(Offset = "0x2C")]
			[SerializeField]
			[Attribute(Name = "TooltipAttribute", RVA = "0xE4AF0", Offset = "0xE3EF0")]
			private float _mouseXYAxisSensitivityMin;

			// Token: 0x040022D4 RID: 8916
			[Token(Token = "0x40022D4")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			[Attribute(Name = "TooltipAttribute", RVA = "0xE4B80", Offset = "0xE3F80")]
			private float _mouseXYAxisSensitivityMax;
		}

		// Token: 0x0200056F RID: 1391
		[Token(Token = "0x200056F")]
		[Serializable]
		private class Prefabs
		{
			// Token: 0x170006C6 RID: 1734
			// (get) Token: 0x060021A5 RID: 8613 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006C6")]
			public GameObject button
			{
				[Token(Token = "0x60021A5")]
				[Address(RVA = "0x273EB0", Offset = "0x2732B0", VA = "0x10273EB0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006C7 RID: 1735
			// (get) Token: 0x060021A6 RID: 8614 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006C7")]
			public GameObject fitButton
			{
				[Token(Token = "0x60021A6")]
				[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006C8 RID: 1736
			// (get) Token: 0x060021A7 RID: 8615 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006C8")]
			public GameObject inputGridLabel
			{
				[Token(Token = "0x60021A7")]
				[Address(RVA = "0x273EC0", Offset = "0x2732C0", VA = "0x10273EC0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006C9 RID: 1737
			// (get) Token: 0x060021A8 RID: 8616 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006C9")]
			public GameObject inputGridHeaderLabel
			{
				[Token(Token = "0x60021A8")]
				[Address(RVA = "0x273EA0", Offset = "0x2732A0", VA = "0x10273EA0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006CA RID: 1738
			// (get) Token: 0x060021A9 RID: 8617 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006CA")]
			public GameObject inputGridFieldButton
			{
				[Token(Token = "0x60021A9")]
				[Address(RVA = "0x277A30", Offset = "0x276E30", VA = "0x10277A30")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006CB RID: 1739
			// (get) Token: 0x060021AA RID: 8618 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006CB")]
			public GameObject inputGridFieldInvertToggle
			{
				[Token(Token = "0x60021AA")]
				[Address(RVA = "0x277A40", Offset = "0x276E40", VA = "0x10277A40")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006CC RID: 1740
			// (get) Token: 0x060021AB RID: 8619 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006CC")]
			public GameObject window
			{
				[Token(Token = "0x60021AB")]
				[Address(RVA = "0x287A00", Offset = "0x286E00", VA = "0x10287A00")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006CD RID: 1741
			// (get) Token: 0x060021AC RID: 8620 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006CD")]
			public GameObject windowTitleText
			{
				[Token(Token = "0x60021AC")]
				[Address(RVA = "0x292AA0", Offset = "0x291EA0", VA = "0x10292AA0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006CE RID: 1742
			// (get) Token: 0x060021AD RID: 8621 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006CE")]
			public GameObject windowContentText
			{
				[Token(Token = "0x60021AD")]
				[Address(RVA = "0x2D5F80", Offset = "0x2D5380", VA = "0x102D5F80")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006CF RID: 1743
			// (get) Token: 0x060021AE RID: 8622 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006CF")]
			public GameObject fader
			{
				[Token(Token = "0x60021AE")]
				[Address(RVA = "0x2D8D90", Offset = "0x2D8190", VA = "0x102D8D90")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006D0 RID: 1744
			// (get) Token: 0x060021AF RID: 8623 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006D0")]
			public GameObject calibrationWindow
			{
				[Token(Token = "0x60021AF")]
				[Address(RVA = "0x298EF0", Offset = "0x2982F0", VA = "0x10298EF0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006D1 RID: 1745
			// (get) Token: 0x060021B0 RID: 8624 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006D1")]
			public GameObject inputBehaviorsWindow
			{
				[Token(Token = "0x60021B0")]
				[Address(RVA = "0x328160", Offset = "0x327560", VA = "0x10328160")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006D2 RID: 1746
			// (get) Token: 0x060021B1 RID: 8625 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006D2")]
			public GameObject centerStickGraphic
			{
				[Token(Token = "0x60021B1")]
				[Address(RVA = "0x278060", Offset = "0x277460", VA = "0x10278060")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006D3 RID: 1747
			// (get) Token: 0x060021B2 RID: 8626 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006D3")]
			public GameObject moveStickGraphic
			{
				[Token(Token = "0x60021B2")]
				[Address(RVA = "0x328190", Offset = "0x327590", VA = "0x10328190")]
				get
				{
					return null;
				}
			}

			// Token: 0x060021B3 RID: 8627 RVA: 0x0000A590 File Offset: 0x00008790
			[Token(Token = "0x60021B3")]
			[Address(RVA = "0x3C0E20", Offset = "0x3C0220", VA = "0x103C0E20")]
			public bool Check()
			{
				return default(bool);
			}

			// Token: 0x060021B4 RID: 8628 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60021B4")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public Prefabs()
			{
			}

			// Token: 0x040022D5 RID: 8917
			[Token(Token = "0x40022D5")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			private GameObject _button;

			// Token: 0x040022D6 RID: 8918
			[Token(Token = "0x40022D6")]
			[FieldOffset(Offset = "0xC")]
			[SerializeField]
			private GameObject _fitButton;

			// Token: 0x040022D7 RID: 8919
			[Token(Token = "0x40022D7")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private GameObject _inputGridLabel;

			// Token: 0x040022D8 RID: 8920
			[Token(Token = "0x40022D8")]
			[FieldOffset(Offset = "0x14")]
			[SerializeField]
			private GameObject _inputGridHeaderLabel;

			// Token: 0x040022D9 RID: 8921
			[Token(Token = "0x40022D9")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private GameObject _inputGridFieldButton;

			// Token: 0x040022DA RID: 8922
			[Token(Token = "0x40022DA")]
			[FieldOffset(Offset = "0x1C")]
			[SerializeField]
			private GameObject _inputGridFieldInvertToggle;

			// Token: 0x040022DB RID: 8923
			[Token(Token = "0x40022DB")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private GameObject _window;

			// Token: 0x040022DC RID: 8924
			[Token(Token = "0x40022DC")]
			[FieldOffset(Offset = "0x24")]
			[SerializeField]
			private GameObject _windowTitleText;

			// Token: 0x040022DD RID: 8925
			[Token(Token = "0x40022DD")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private GameObject _windowContentText;

			// Token: 0x040022DE RID: 8926
			[Token(Token = "0x40022DE")]
			[FieldOffset(Offset = "0x2C")]
			[SerializeField]
			private GameObject _fader;

			// Token: 0x040022DF RID: 8927
			[Token(Token = "0x40022DF")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private GameObject _calibrationWindow;

			// Token: 0x040022E0 RID: 8928
			[Token(Token = "0x40022E0")]
			[FieldOffset(Offset = "0x34")]
			[SerializeField]
			private GameObject _inputBehaviorsWindow;

			// Token: 0x040022E1 RID: 8929
			[Token(Token = "0x40022E1")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			private GameObject _centerStickGraphic;

			// Token: 0x040022E2 RID: 8930
			[Token(Token = "0x40022E2")]
			[FieldOffset(Offset = "0x3C")]
			[SerializeField]
			private GameObject _moveStickGraphic;
		}

		// Token: 0x02000570 RID: 1392
		[Token(Token = "0x2000570")]
		[Serializable]
		private class References
		{
			// Token: 0x170006D4 RID: 1748
			// (get) Token: 0x060021B5 RID: 8629 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006D4")]
			public Canvas canvas
			{
				[Token(Token = "0x60021B5")]
				[Address(RVA = "0x273EB0", Offset = "0x2732B0", VA = "0x10273EB0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006D5 RID: 1749
			// (get) Token: 0x060021B6 RID: 8630 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006D5")]
			public CanvasGroup mainCanvasGroup
			{
				[Token(Token = "0x60021B6")]
				[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006D6 RID: 1750
			// (get) Token: 0x060021B7 RID: 8631 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006D6")]
			public Transform mainContent
			{
				[Token(Token = "0x60021B7")]
				[Address(RVA = "0x273EC0", Offset = "0x2732C0", VA = "0x10273EC0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006D7 RID: 1751
			// (get) Token: 0x060021B8 RID: 8632 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006D7")]
			public Transform mainContentInner
			{
				[Token(Token = "0x60021B8")]
				[Address(RVA = "0x273EA0", Offset = "0x2732A0", VA = "0x10273EA0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006D8 RID: 1752
			// (get) Token: 0x060021B9 RID: 8633 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006D8")]
			public UIGroup playersGroup
			{
				[Token(Token = "0x60021B9")]
				[Address(RVA = "0x277A30", Offset = "0x276E30", VA = "0x10277A30")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006D9 RID: 1753
			// (get) Token: 0x060021BA RID: 8634 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006D9")]
			public Transform controllerGroup
			{
				[Token(Token = "0x60021BA")]
				[Address(RVA = "0x277A40", Offset = "0x276E40", VA = "0x10277A40")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006DA RID: 1754
			// (get) Token: 0x060021BB RID: 8635 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006DA")]
			public Transform controllerGroupLabelGroup
			{
				[Token(Token = "0x60021BB")]
				[Address(RVA = "0x287A00", Offset = "0x286E00", VA = "0x10287A00")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006DB RID: 1755
			// (get) Token: 0x060021BC RID: 8636 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006DB")]
			public UIGroup controllerSettingsGroup
			{
				[Token(Token = "0x60021BC")]
				[Address(RVA = "0x292AA0", Offset = "0x291EA0", VA = "0x10292AA0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006DC RID: 1756
			// (get) Token: 0x060021BD RID: 8637 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006DC")]
			public UIGroup assignedControllersGroup
			{
				[Token(Token = "0x60021BD")]
				[Address(RVA = "0x2D5F80", Offset = "0x2D5380", VA = "0x102D5F80")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006DD RID: 1757
			// (get) Token: 0x060021BE RID: 8638 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006DD")]
			public Transform settingsAndMapCategoriesGroup
			{
				[Token(Token = "0x60021BE")]
				[Address(RVA = "0x2D8D90", Offset = "0x2D8190", VA = "0x102D8D90")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006DE RID: 1758
			// (get) Token: 0x060021BF RID: 8639 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006DE")]
			public UIGroup settingsGroup
			{
				[Token(Token = "0x60021BF")]
				[Address(RVA = "0x298EF0", Offset = "0x2982F0", VA = "0x10298EF0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006DF RID: 1759
			// (get) Token: 0x060021C0 RID: 8640 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006DF")]
			public UIGroup mapCategoriesGroup
			{
				[Token(Token = "0x60021C0")]
				[Address(RVA = "0x328160", Offset = "0x327560", VA = "0x10328160")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006E0 RID: 1760
			// (get) Token: 0x060021C1 RID: 8641 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006E0")]
			public Transform inputGridGroup
			{
				[Token(Token = "0x60021C1")]
				[Address(RVA = "0x278060", Offset = "0x277460", VA = "0x10278060")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006E1 RID: 1761
			// (get) Token: 0x060021C2 RID: 8642 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006E1")]
			public Transform inputGridContainer
			{
				[Token(Token = "0x60021C2")]
				[Address(RVA = "0x328190", Offset = "0x327590", VA = "0x10328190")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006E2 RID: 1762
			// (get) Token: 0x060021C3 RID: 8643 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006E2")]
			public Transform inputGridHeadersGroup
			{
				[Token(Token = "0x60021C3")]
				[Address(RVA = "0x2786E0", Offset = "0x277AE0", VA = "0x102786E0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006E3 RID: 1763
			// (get) Token: 0x060021C4 RID: 8644 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006E3")]
			public UnityEngine.UI.Scrollbar inputGridVScrollbar
			{
				[Token(Token = "0x60021C4")]
				[Address(RVA = "0x27B280", Offset = "0x27A680", VA = "0x1027B280")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006E4 RID: 1764
			// (get) Token: 0x060021C5 RID: 8645 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006E4")]
			public ScrollRect inputGridScrollRect
			{
				[Token(Token = "0x60021C5")]
				[Address(RVA = "0x3C16E0", Offset = "0x3C0AE0", VA = "0x103C16E0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006E5 RID: 1765
			// (get) Token: 0x060021C6 RID: 8646 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006E5")]
			public Transform inputGridInnerGroup
			{
				[Token(Token = "0x60021C6")]
				[Address(RVA = "0x3C0AA0", Offset = "0x3BFEA0", VA = "0x103C0AA0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006E6 RID: 1766
			// (get) Token: 0x060021C7 RID: 8647 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006E6")]
			public TMP_Text controllerNameLabel
			{
				[Token(Token = "0x60021C7")]
				[Address(RVA = "0x3C1650", Offset = "0x3C0A50", VA = "0x103C1650")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006E7 RID: 1767
			// (get) Token: 0x060021C8 RID: 8648 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006E7")]
			public Button removeControllerButton
			{
				[Token(Token = "0x60021C8")]
				[Address(RVA = "0x3C1700", Offset = "0x3C0B00", VA = "0x103C1700")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006E8 RID: 1768
			// (get) Token: 0x060021C9 RID: 8649 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006E8")]
			public Button assignControllerButton
			{
				[Token(Token = "0x60021C9")]
				[Address(RVA = "0x3C1630", Offset = "0x3C0A30", VA = "0x103C1630")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006E9 RID: 1769
			// (get) Token: 0x060021CA RID: 8650 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006E9")]
			public Button calibrateControllerButton
			{
				[Token(Token = "0x60021CA")]
				[Address(RVA = "0x3C1640", Offset = "0x3C0A40", VA = "0x103C1640")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006EA RID: 1770
			// (get) Token: 0x060021CB RID: 8651 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006EA")]
			public Button doneButton
			{
				[Token(Token = "0x60021CB")]
				[Address(RVA = "0x3C1670", Offset = "0x3C0A70", VA = "0x103C1670")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006EB RID: 1771
			// (get) Token: 0x060021CC RID: 8652 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006EB")]
			public Button restoreDefaultsButton
			{
				[Token(Token = "0x60021CC")]
				[Address(RVA = "0x3C1710", Offset = "0x3C0B10", VA = "0x103C1710")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006EC RID: 1772
			// (get) Token: 0x060021CD RID: 8653 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006EC")]
			public Selectable defaultSelection
			{
				[Token(Token = "0x60021CD")]
				[Address(RVA = "0x3C1660", Offset = "0x3C0A60", VA = "0x103C1660")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006ED RID: 1773
			// (get) Token: 0x060021CE RID: 8654 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006ED")]
			public GameObject[] fixedSelectableUIElements
			{
				[Token(Token = "0x60021CE")]
				[Address(RVA = "0x3C1680", Offset = "0x3C0A80", VA = "0x103C1680")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006EE RID: 1774
			// (get) Token: 0x060021CF RID: 8655 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006EE")]
			public Image mainBackgroundImage
			{
				[Token(Token = "0x60021CF")]
				[Address(RVA = "0x3C16F0", Offset = "0x3C0AF0", VA = "0x103C16F0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006EF RID: 1775
			// (get) Token: 0x060021D0 RID: 8656 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060021D1 RID: 8657 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170006EF")]
			public LayoutElement inputGridLayoutElement
			{
				[Token(Token = "0x60021D0")]
				[Address(RVA = "0x3C16C0", Offset = "0x3C0AC0", VA = "0x103C16C0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
				get
				{
					return null;
				}
				[Token(Token = "0x60021D1")]
				[Address(RVA = "0x3C17E0", Offset = "0x3C0BE0", VA = "0x103C17E0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
				set
				{
				}
			}

			// Token: 0x170006F0 RID: 1776
			// (get) Token: 0x060021D2 RID: 8658 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060021D3 RID: 8659 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170006F0")]
			public Transform inputGridActionColumn
			{
				[Token(Token = "0x60021D2")]
				[Address(RVA = "0x3C1690", Offset = "0x3C0A90", VA = "0x103C1690")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
				get
				{
					return null;
				}
				[Token(Token = "0x60021D3")]
				[Address(RVA = "0x3C1720", Offset = "0x3C0B20", VA = "0x103C1720")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
				set
				{
				}
			}

			// Token: 0x170006F1 RID: 1777
			// (get) Token: 0x060021D4 RID: 8660 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060021D5 RID: 8661 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170006F1")]
			public Transform inputGridKeyboardColumn
			{
				[Token(Token = "0x60021D4")]
				[Address(RVA = "0x3C16B0", Offset = "0x3C0AB0", VA = "0x103C16B0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
				get
				{
					return null;
				}
				[Token(Token = "0x60021D5")]
				[Address(RVA = "0x3C17D0", Offset = "0x3C0BD0", VA = "0x103C17D0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
				set
				{
				}
			}

			// Token: 0x170006F2 RID: 1778
			// (get) Token: 0x060021D6 RID: 8662 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060021D7 RID: 8663 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170006F2")]
			public Transform inputGridMouseColumn
			{
				[Token(Token = "0x60021D6")]
				[Address(RVA = "0x3C16D0", Offset = "0x3C0AD0", VA = "0x103C16D0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
				get
				{
					return null;
				}
				[Token(Token = "0x60021D7")]
				[Address(RVA = "0x3C17F0", Offset = "0x3C0BF0", VA = "0x103C17F0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
				set
				{
				}
			}

			// Token: 0x170006F3 RID: 1779
			// (get) Token: 0x060021D8 RID: 8664 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060021D9 RID: 8665 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170006F3")]
			public Transform inputGridControllerColumn
			{
				[Token(Token = "0x60021D8")]
				[Address(RVA = "0x3C16A0", Offset = "0x3C0AA0", VA = "0x103C16A0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
				get
				{
					return null;
				}
				[Token(Token = "0x60021D9")]
				[Address(RVA = "0x3C1730", Offset = "0x3C0B30", VA = "0x103C1730")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
				set
				{
				}
			}

			// Token: 0x170006F4 RID: 1780
			// (get) Token: 0x060021DA RID: 8666 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060021DB RID: 8667 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170006F4")]
			public Transform inputGridHeader1
			{
				[Token(Token = "0x60021DA")]
				[Address(RVA = "0x3658F0", Offset = "0x364CF0", VA = "0x103658F0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
				get
				{
					return null;
				}
				[Token(Token = "0x60021DB")]
				[Address(RVA = "0x3C1750", Offset = "0x3C0B50", VA = "0x103C1750")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
				set
				{
				}
			}

			// Token: 0x170006F5 RID: 1781
			// (get) Token: 0x060021DC RID: 8668 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060021DD RID: 8669 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170006F5")]
			public Transform inputGridHeader2
			{
				[Token(Token = "0x60021DC")]
				[Address(RVA = "0x365380", Offset = "0x364780", VA = "0x10365380")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
				get
				{
					return null;
				}
				[Token(Token = "0x60021DD")]
				[Address(RVA = "0x3C1770", Offset = "0x3C0B70", VA = "0x103C1770")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
				set
				{
				}
			}

			// Token: 0x170006F6 RID: 1782
			// (get) Token: 0x060021DE RID: 8670 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060021DF RID: 8671 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170006F6")]
			public Transform inputGridHeader3
			{
				[Token(Token = "0x60021DE")]
				[Address(RVA = "0x365370", Offset = "0x364770", VA = "0x10365370")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
				get
				{
					return null;
				}
				[Token(Token = "0x60021DF")]
				[Address(RVA = "0x3C1790", Offset = "0x3C0B90", VA = "0x103C1790")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
				set
				{
				}
			}

			// Token: 0x170006F7 RID: 1783
			// (get) Token: 0x060021E0 RID: 8672 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060021E1 RID: 8673 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170006F7")]
			public Transform inputGridHeader4
			{
				[Token(Token = "0x60021E0")]
				[Address(RVA = "0x365BF0", Offset = "0x364FF0", VA = "0x10365BF0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
				get
				{
					return null;
				}
				[Token(Token = "0x60021E1")]
				[Address(RVA = "0x3C17B0", Offset = "0x3C0BB0", VA = "0x103C17B0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
				set
				{
				}
			}

			// Token: 0x060021E2 RID: 8674 RVA: 0x0000A5A8 File Offset: 0x000087A8
			[Token(Token = "0x60021E2")]
			[Address(RVA = "0x3C10D0", Offset = "0x3C04D0", VA = "0x103C10D0")]
			public bool Check()
			{
				return default(bool);
			}

			// Token: 0x060021E3 RID: 8675 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60021E3")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public References()
			{
			}

			// Token: 0x040022E3 RID: 8931
			[Token(Token = "0x40022E3")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			private Canvas _canvas;

			// Token: 0x040022E4 RID: 8932
			[Token(Token = "0x40022E4")]
			[FieldOffset(Offset = "0xC")]
			[SerializeField]
			private CanvasGroup _mainCanvasGroup;

			// Token: 0x040022E5 RID: 8933
			[Token(Token = "0x40022E5")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private Transform _mainContent;

			// Token: 0x040022E6 RID: 8934
			[Token(Token = "0x40022E6")]
			[FieldOffset(Offset = "0x14")]
			[SerializeField]
			private Transform _mainContentInner;

			// Token: 0x040022E7 RID: 8935
			[Token(Token = "0x40022E7")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private UIGroup _playersGroup;

			// Token: 0x040022E8 RID: 8936
			[Token(Token = "0x40022E8")]
			[FieldOffset(Offset = "0x1C")]
			[SerializeField]
			private Transform _controllerGroup;

			// Token: 0x040022E9 RID: 8937
			[Token(Token = "0x40022E9")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Transform _controllerGroupLabelGroup;

			// Token: 0x040022EA RID: 8938
			[Token(Token = "0x40022EA")]
			[FieldOffset(Offset = "0x24")]
			[SerializeField]
			private UIGroup _controllerSettingsGroup;

			// Token: 0x040022EB RID: 8939
			[Token(Token = "0x40022EB")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private UIGroup _assignedControllersGroup;

			// Token: 0x040022EC RID: 8940
			[Token(Token = "0x40022EC")]
			[FieldOffset(Offset = "0x2C")]
			[SerializeField]
			private Transform _settingsAndMapCategoriesGroup;

			// Token: 0x040022ED RID: 8941
			[Token(Token = "0x40022ED")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private UIGroup _settingsGroup;

			// Token: 0x040022EE RID: 8942
			[Token(Token = "0x40022EE")]
			[FieldOffset(Offset = "0x34")]
			[SerializeField]
			private UIGroup _mapCategoriesGroup;

			// Token: 0x040022EF RID: 8943
			[Token(Token = "0x40022EF")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			private Transform _inputGridGroup;

			// Token: 0x040022F0 RID: 8944
			[Token(Token = "0x40022F0")]
			[FieldOffset(Offset = "0x3C")]
			[SerializeField]
			private Transform _inputGridContainer;

			// Token: 0x040022F1 RID: 8945
			[Token(Token = "0x40022F1")]
			[FieldOffset(Offset = "0x40")]
			[SerializeField]
			private Transform _inputGridHeadersGroup;

			// Token: 0x040022F2 RID: 8946
			[Token(Token = "0x40022F2")]
			[FieldOffset(Offset = "0x44")]
			[SerializeField]
			private UnityEngine.UI.Scrollbar _inputGridVScrollbar;

			// Token: 0x040022F3 RID: 8947
			[Token(Token = "0x40022F3")]
			[FieldOffset(Offset = "0x48")]
			[SerializeField]
			private ScrollRect _inputGridScrollRect;

			// Token: 0x040022F4 RID: 8948
			[Token(Token = "0x40022F4")]
			[FieldOffset(Offset = "0x4C")]
			[SerializeField]
			private Transform _inputGridInnerGroup;

			// Token: 0x040022F5 RID: 8949
			[Token(Token = "0x40022F5")]
			[FieldOffset(Offset = "0x50")]
			[SerializeField]
			private TMP_Text _controllerNameLabel;

			// Token: 0x040022F6 RID: 8950
			[Token(Token = "0x40022F6")]
			[FieldOffset(Offset = "0x54")]
			[SerializeField]
			private Button _removeControllerButton;

			// Token: 0x040022F7 RID: 8951
			[Token(Token = "0x40022F7")]
			[FieldOffset(Offset = "0x58")]
			[SerializeField]
			private Button _assignControllerButton;

			// Token: 0x040022F8 RID: 8952
			[Token(Token = "0x40022F8")]
			[FieldOffset(Offset = "0x5C")]
			[SerializeField]
			private Button _calibrateControllerButton;

			// Token: 0x040022F9 RID: 8953
			[Token(Token = "0x40022F9")]
			[FieldOffset(Offset = "0x60")]
			[SerializeField]
			private Button _doneButton;

			// Token: 0x040022FA RID: 8954
			[Token(Token = "0x40022FA")]
			[FieldOffset(Offset = "0x64")]
			[SerializeField]
			private Button _restoreDefaultsButton;

			// Token: 0x040022FB RID: 8955
			[Token(Token = "0x40022FB")]
			[FieldOffset(Offset = "0x68")]
			[SerializeField]
			private Selectable _defaultSelection;

			// Token: 0x040022FC RID: 8956
			[Token(Token = "0x40022FC")]
			[FieldOffset(Offset = "0x6C")]
			[SerializeField]
			private GameObject[] _fixedSelectableUIElements;

			// Token: 0x040022FD RID: 8957
			[Token(Token = "0x40022FD")]
			[FieldOffset(Offset = "0x70")]
			[SerializeField]
			private Image _mainBackgroundImage;

			// Token: 0x040022FE RID: 8958
			[Token(Token = "0x40022FE")]
			[FieldOffset(Offset = "0x74")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private LayoutElement <inputGridLayoutElement>k__BackingField;

			// Token: 0x040022FF RID: 8959
			[Token(Token = "0x40022FF")]
			[FieldOffset(Offset = "0x78")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private Transform <inputGridActionColumn>k__BackingField;

			// Token: 0x04002300 RID: 8960
			[Token(Token = "0x4002300")]
			[FieldOffset(Offset = "0x7C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private Transform <inputGridKeyboardColumn>k__BackingField;

			// Token: 0x04002301 RID: 8961
			[Token(Token = "0x4002301")]
			[FieldOffset(Offset = "0x80")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private Transform <inputGridMouseColumn>k__BackingField;

			// Token: 0x04002302 RID: 8962
			[Token(Token = "0x4002302")]
			[FieldOffset(Offset = "0x84")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private Transform <inputGridControllerColumn>k__BackingField;

			// Token: 0x04002303 RID: 8963
			[Token(Token = "0x4002303")]
			[FieldOffset(Offset = "0x88")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private Transform <inputGridHeader1>k__BackingField;

			// Token: 0x04002304 RID: 8964
			[Token(Token = "0x4002304")]
			[FieldOffset(Offset = "0x8C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private Transform <inputGridHeader2>k__BackingField;

			// Token: 0x04002305 RID: 8965
			[Token(Token = "0x4002305")]
			[FieldOffset(Offset = "0x90")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private Transform <inputGridHeader3>k__BackingField;

			// Token: 0x04002306 RID: 8966
			[Token(Token = "0x4002306")]
			[FieldOffset(Offset = "0x94")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private Transform <inputGridHeader4>k__BackingField;
		}

		// Token: 0x02000571 RID: 1393
		[Token(Token = "0x2000571")]
		private class InputActionSet
		{
			// Token: 0x170006F8 RID: 1784
			// (get) Token: 0x060021E4 RID: 8676 RVA: 0x0000A5C0 File Offset: 0x000087C0
			[Token(Token = "0x170006F8")]
			public int actionId
			{
				[Token(Token = "0x60021E4")]
				[Address(RVA = "0x273EB0", Offset = "0x2732B0", VA = "0x10273EB0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170006F9 RID: 1785
			// (get) Token: 0x060021E5 RID: 8677 RVA: 0x0000A5D8 File Offset: 0x000087D8
			[Token(Token = "0x170006F9")]
			public AxisRange axisRange
			{
				[Token(Token = "0x60021E5")]
				[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90")]
				get
				{
					return AxisRange.Full;
				}
			}

			// Token: 0x060021E6 RID: 8678 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60021E6")]
			[Address(RVA = "0x399E90", Offset = "0x399290", VA = "0x10399E90")]
			public InputActionSet(int actionId, AxisRange axisRange)
			{
			}

			// Token: 0x04002307 RID: 8967
			[Token(Token = "0x4002307")]
			[FieldOffset(Offset = "0x8")]
			private int _actionId;

			// Token: 0x04002308 RID: 8968
			[Token(Token = "0x4002308")]
			[FieldOffset(Offset = "0xC")]
			private AxisRange _axisRange;
		}

		// Token: 0x02000572 RID: 1394
		[Token(Token = "0x2000572")]
		private class InputMapping
		{
			// Token: 0x170006FA RID: 1786
			// (get) Token: 0x060021E7 RID: 8679 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060021E8 RID: 8680 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170006FA")]
			public string actionName
			{
				[Token(Token = "0x60021E7")]
				[Address(RVA = "0x273EB0", Offset = "0x2732B0", VA = "0x10273EB0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
				get
				{
					return null;
				}
				[Token(Token = "0x60021E8")]
				[Address(RVA = "0x273EF0", Offset = "0x2732F0", VA = "0x10273EF0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
				private set
				{
				}
			}

			// Token: 0x170006FB RID: 1787
			// (get) Token: 0x060021E9 RID: 8681 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060021EA RID: 8682 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170006FB")]
			public InputFieldInfo fieldInfo
			{
				[Token(Token = "0x60021E9")]
				[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
				get
				{
					return null;
				}
				[Token(Token = "0x60021EA")]
				[Address(RVA = "0x273ED0", Offset = "0x2732D0", VA = "0x10273ED0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
				private set
				{
				}
			}

			// Token: 0x170006FC RID: 1788
			// (get) Token: 0x060021EB RID: 8683 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060021EC RID: 8684 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170006FC")]
			public ControllerMap map
			{
				[Token(Token = "0x60021EB")]
				[Address(RVA = "0x273EC0", Offset = "0x2732C0", VA = "0x10273EC0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
				get
				{
					return null;
				}
				[Token(Token = "0x60021EC")]
				[Address(RVA = "0x273100", Offset = "0x272500", VA = "0x10273100")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
				private set
				{
				}
			}

			// Token: 0x170006FD RID: 1789
			// (get) Token: 0x060021ED RID: 8685 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060021EE RID: 8686 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170006FD")]
			public ActionElementMap aem
			{
				[Token(Token = "0x60021ED")]
				[Address(RVA = "0x273EA0", Offset = "0x2732A0", VA = "0x10273EA0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
				get
				{
					return null;
				}
				[Token(Token = "0x60021EE")]
				[Address(RVA = "0x273EE0", Offset = "0x2732E0", VA = "0x10273EE0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
				private set
				{
				}
			}

			// Token: 0x170006FE RID: 1790
			// (get) Token: 0x060021EF RID: 8687 RVA: 0x0000A5F0 File Offset: 0x000087F0
			// (set) Token: 0x060021F0 RID: 8688 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170006FE")]
			public ControllerType controllerType
			{
				[Token(Token = "0x60021EF")]
				[Address(RVA = "0x277A30", Offset = "0x276E30", VA = "0x10277A30")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
				get
				{
					return ControllerType.Keyboard;
				}
				[Token(Token = "0x60021F0")]
				[Address(RVA = "0x277A50", Offset = "0x276E50", VA = "0x10277A50")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
				private set
				{
				}
			}

			// Token: 0x170006FF RID: 1791
			// (get) Token: 0x060021F1 RID: 8689 RVA: 0x0000A608 File Offset: 0x00008808
			// (set) Token: 0x060021F2 RID: 8690 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170006FF")]
			public int controllerId
			{
				[Token(Token = "0x60021F1")]
				[Address(RVA = "0x277A40", Offset = "0x276E40", VA = "0x10277A40")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
				get
				{
					return 0;
				}
				[Token(Token = "0x60021F2")]
				[Address(RVA = "0x277A60", Offset = "0x276E60", VA = "0x10277A60")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
				private set
				{
				}
			}

			// Token: 0x17000700 RID: 1792
			// (get) Token: 0x060021F3 RID: 8691 RVA: 0x0000A620 File Offset: 0x00008820
			// (set) Token: 0x060021F4 RID: 8692 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000700")]
			public ControllerPollingInfo pollingInfo
			{
				[Token(Token = "0x60021F3")]
				[Address(RVA = "0x3C0AB0", Offset = "0x3BFEB0", VA = "0x103C0AB0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
				get
				{
					return default(ControllerPollingInfo);
				}
				[Token(Token = "0x60021F4")]
				[Address(RVA = "0x3C0AF0", Offset = "0x3BFEF0", VA = "0x103C0AF0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
				set
				{
				}
			}

			// Token: 0x17000701 RID: 1793
			// (get) Token: 0x060021F5 RID: 8693 RVA: 0x0000A638 File Offset: 0x00008838
			// (set) Token: 0x060021F6 RID: 8694 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000701")]
			public ModifierKeyFlags modifierKeyFlags
			{
				[Token(Token = "0x60021F5")]
				[Address(RVA = "0x3C0AA0", Offset = "0x3BFEA0", VA = "0x103C0AA0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
				get
				{
					return ModifierKeyFlags.None;
				}
				[Token(Token = "0x60021F6")]
				[Address(RVA = "0x3C0AE0", Offset = "0x3BFEE0", VA = "0x103C0AE0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
				set
				{
				}
			}

			// Token: 0x17000702 RID: 1794
			// (get) Token: 0x060021F7 RID: 8695 RVA: 0x0000A650 File Offset: 0x00008850
			[Token(Token = "0x17000702")]
			public AxisRange axisRange
			{
				[Token(Token = "0x60021F7")]
				[Address(RVA = "0x3C0910", Offset = "0x3BFD10", VA = "0x103C0910")]
				get
				{
					return AxisRange.Full;
				}
			}

			// Token: 0x17000703 RID: 1795
			// (get) Token: 0x060021F8 RID: 8696 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000703")]
			public string elementName
			{
				[Token(Token = "0x60021F8")]
				[Address(RVA = "0x3C0980", Offset = "0x3BFD80", VA = "0x103C0980")]
				get
				{
					return null;
				}
			}

			// Token: 0x060021F9 RID: 8697 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60021F9")]
			[Address(RVA = "0x3C08D0", Offset = "0x3BFCD0", VA = "0x103C08D0")]
			public InputMapping(string actionName, InputFieldInfo fieldInfo, ControllerMap map, ActionElementMap aem, ControllerType controllerType, int controllerId)
			{
			}

			// Token: 0x060021FA RID: 8698 RVA: 0x0000A668 File Offset: 0x00008868
			[Token(Token = "0x60021FA")]
			[Address(RVA = "0x3C06E0", Offset = "0x3BFAE0", VA = "0x103C06E0")]
			public ElementAssignment ToElementAssignment(ControllerPollingInfo pollingInfo)
			{
				return default(ElementAssignment);
			}

			// Token: 0x060021FB RID: 8699 RVA: 0x0000A680 File Offset: 0x00008880
			[Token(Token = "0x60021FB")]
			[Address(RVA = "0x3C0870", Offset = "0x3BFC70", VA = "0x103C0870")]
			public ElementAssignment ToElementAssignment(ControllerPollingInfo pollingInfo, ModifierKeyFlags modifierKeyFlags)
			{
				return default(ElementAssignment);
			}

			// Token: 0x060021FC RID: 8700 RVA: 0x0000A698 File Offset: 0x00008898
			[Token(Token = "0x60021FC")]
			[Address(RVA = "0x3C0730", Offset = "0x3BFB30", VA = "0x103C0730")]
			public ElementAssignment ToElementAssignment()
			{
				return default(ElementAssignment);
			}

			// Token: 0x04002309 RID: 8969
			[Token(Token = "0x4002309")]
			[FieldOffset(Offset = "0x8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private string <actionName>k__BackingField;

			// Token: 0x0400230A RID: 8970
			[Token(Token = "0x400230A")]
			[FieldOffset(Offset = "0xC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private InputFieldInfo <fieldInfo>k__BackingField;

			// Token: 0x0400230B RID: 8971
			[Token(Token = "0x400230B")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private ControllerMap <map>k__BackingField;

			// Token: 0x0400230C RID: 8972
			[Token(Token = "0x400230C")]
			[FieldOffset(Offset = "0x14")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private ActionElementMap <aem>k__BackingField;

			// Token: 0x0400230D RID: 8973
			[Token(Token = "0x400230D")]
			[FieldOffset(Offset = "0x18")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private ControllerType <controllerType>k__BackingField;

			// Token: 0x0400230E RID: 8974
			[Token(Token = "0x400230E")]
			[FieldOffset(Offset = "0x1C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private int <controllerId>k__BackingField;

			// Token: 0x0400230F RID: 8975
			[Token(Token = "0x400230F")]
			[FieldOffset(Offset = "0x20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private ControllerPollingInfo <pollingInfo>k__BackingField;

			// Token: 0x04002310 RID: 8976
			[Token(Token = "0x4002310")]
			[FieldOffset(Offset = "0x4C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private ModifierKeyFlags <modifierKeyFlags>k__BackingField;
		}

		// Token: 0x02000573 RID: 1395
		[Token(Token = "0x2000573")]
		private class AxisCalibrator
		{
			// Token: 0x17000704 RID: 1796
			// (get) Token: 0x060021FD RID: 8701 RVA: 0x0000A6B0 File Offset: 0x000088B0
			[Token(Token = "0x17000704")]
			public bool isValid
			{
				[Token(Token = "0x60021FD")]
				[Address(RVA = "0x3BC900", Offset = "0x3BBD00", VA = "0x103BC900")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060021FE RID: 8702 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60021FE")]
			[Address(RVA = "0x3BC7A0", Offset = "0x3BBBA0", VA = "0x103BC7A0")]
			public AxisCalibrator(Joystick joystick, int axisIndex)
			{
			}

			// Token: 0x060021FF RID: 8703 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60021FF")]
			[Address(RVA = "0x3BC730", Offset = "0x3BBB30", VA = "0x103BC730")]
			public void RecordMinMax()
			{
			}

			// Token: 0x06002200 RID: 8704 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002200")]
			[Address(RVA = "0x3BC780", Offset = "0x3BBB80", VA = "0x103BC780")]
			public void RecordZero()
			{
			}

			// Token: 0x06002201 RID: 8705 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002201")]
			[Address(RVA = "0x3BC690", Offset = "0x3BBA90", VA = "0x103BC690")]
			public void Commit()
			{
			}

			// Token: 0x04002311 RID: 8977
			[Token(Token = "0x4002311")]
			[FieldOffset(Offset = "0x8")]
			public AxisCalibrationData data;

			// Token: 0x04002312 RID: 8978
			[Token(Token = "0x4002312")]
			[FieldOffset(Offset = "0x34")]
			public readonly Joystick joystick;

			// Token: 0x04002313 RID: 8979
			[Token(Token = "0x4002313")]
			[FieldOffset(Offset = "0x38")]
			public readonly int axisIndex;

			// Token: 0x04002314 RID: 8980
			[Token(Token = "0x4002314")]
			[FieldOffset(Offset = "0x3C")]
			private Controller.Axis axis;

			// Token: 0x04002315 RID: 8981
			[Token(Token = "0x4002315")]
			[FieldOffset(Offset = "0x40")]
			private bool firstRun;
		}

		// Token: 0x02000574 RID: 1396
		[Token(Token = "0x2000574")]
		[Attribute(Name = "DefaultMemberAttribute", RVA = "0xDF8F0", Offset = "0xDECF0")]
		private class IndexedDictionary<TKey, TValue>
		{
			// Token: 0x17000705 RID: 1797
			// (get) Token: 0x06002202 RID: 8706 RVA: 0x0000A6C8 File Offset: 0x000088C8
			[Token(Token = "0x17000705")]
			public int Count
			{
				[Token(Token = "0x6002202")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06002203 RID: 8707 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002203")]
			public IndexedDictionary()
			{
			}

			// Token: 0x17000706 RID: 1798
			// (get) Token: 0x06002204 RID: 8708 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000706")]
			public TValue Item
			{
				[Token(Token = "0x6002204")]
				get
				{
					return null;
				}
			}

			// Token: 0x06002205 RID: 8709 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002205")]
			public TValue Get(TKey key)
			{
				return null;
			}

			// Token: 0x06002206 RID: 8710 RVA: 0x0000A6E0 File Offset: 0x000088E0
			[Token(Token = "0x6002206")]
			public bool TryGet(TKey key, out TValue value)
			{
				return default(bool);
			}

			// Token: 0x06002207 RID: 8711 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002207")]
			public void Add(TKey key, TValue value)
			{
			}

			// Token: 0x06002208 RID: 8712 RVA: 0x0000A6F8 File Offset: 0x000088F8
			[Token(Token = "0x6002208")]
			public int IndexOfKey(TKey key)
			{
				return 0;
			}

			// Token: 0x06002209 RID: 8713 RVA: 0x0000A710 File Offset: 0x00008910
			[Token(Token = "0x6002209")]
			public bool ContainsKey(TKey key)
			{
				return default(bool);
			}

			// Token: 0x0600220A RID: 8714 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600220A")]
			public void Clear()
			{
			}

			// Token: 0x04002316 RID: 8982
			[Token(Token = "0x4002316")]
			[FieldOffset(Offset = "0x0")]
			private List<ControlMapper.IndexedDictionary<TKey, TValue>.Entry> list;

			// Token: 0x02000575 RID: 1397
			[Token(Token = "0x2000575")]
			private class Entry
			{
				// Token: 0x0600220B RID: 8715 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600220B")]
				public Entry(TKey key, TValue value)
				{
				}

				// Token: 0x04002317 RID: 8983
				[Token(Token = "0x4002317")]
				[FieldOffset(Offset = "0x0")]
				public TKey key;

				// Token: 0x04002318 RID: 8984
				[Token(Token = "0x4002318")]
				[FieldOffset(Offset = "0x0")]
				public TValue value;
			}
		}

		// Token: 0x02000576 RID: 1398
		[Token(Token = "0x2000576")]
		private enum LayoutElementSizeType
		{
			// Token: 0x0400231A RID: 8986
			[Token(Token = "0x400231A")]
			MinSize,
			// Token: 0x0400231B RID: 8987
			[Token(Token = "0x400231B")]
			PreferredSize
		}

		// Token: 0x02000577 RID: 1399
		[Token(Token = "0x2000577")]
		private enum WindowType
		{
			// Token: 0x0400231D RID: 8989
			[Token(Token = "0x400231D")]
			None,
			// Token: 0x0400231E RID: 8990
			[Token(Token = "0x400231E")]
			ChooseJoystick,
			// Token: 0x0400231F RID: 8991
			[Token(Token = "0x400231F")]
			JoystickAssignmentConflict,
			// Token: 0x04002320 RID: 8992
			[Token(Token = "0x4002320")]
			ElementAssignment,
			// Token: 0x04002321 RID: 8993
			[Token(Token = "0x4002321")]
			ElementAssignmentPrePolling,
			// Token: 0x04002322 RID: 8994
			[Token(Token = "0x4002322")]
			ElementAssignmentPolling,
			// Token: 0x04002323 RID: 8995
			[Token(Token = "0x4002323")]
			ElementAssignmentResult,
			// Token: 0x04002324 RID: 8996
			[Token(Token = "0x4002324")]
			ElementAssignmentConflict,
			// Token: 0x04002325 RID: 8997
			[Token(Token = "0x4002325")]
			Calibration,
			// Token: 0x04002326 RID: 8998
			[Token(Token = "0x4002326")]
			CalibrateStep1,
			// Token: 0x04002327 RID: 8999
			[Token(Token = "0x4002327")]
			CalibrateStep2
		}

		// Token: 0x02000578 RID: 1400
		[Token(Token = "0x2000578")]
		private class InputGrid
		{
			// Token: 0x0600220C RID: 8716 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600220C")]
			[Address(RVA = "0x3C0610", Offset = "0x3BFA10", VA = "0x103C0610")]
			public InputGrid()
			{
			}

			// Token: 0x0600220D RID: 8717 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600220D")]
			[Address(RVA = "0x3BFCC0", Offset = "0x3BF0C0", VA = "0x103BFCC0")]
			public void AddMapCategory(int mapCategoryId)
			{
			}

			// Token: 0x0600220E RID: 8718 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600220E")]
			[Address(RVA = "0x3BFB50", Offset = "0x3BEF50", VA = "0x103BFB50")]
			public void AddAction(int mapCategoryId, InputAction action, AxisRange axisRange)
			{
			}

			// Token: 0x0600220F RID: 8719 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600220F")]
			[Address(RVA = "0x3BFA50", Offset = "0x3BEE50", VA = "0x103BFA50")]
			public void AddActionCategory(int mapCategoryId, int actionCategoryId)
			{
			}

			// Token: 0x06002210 RID: 8720 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002210")]
			[Address(RVA = "0x3BFC20", Offset = "0x3BF020", VA = "0x103BFC20")]
			public void AddInputFieldSet(int mapCategoryId, InputAction action, AxisRange axisRange, ControllerType controllerType, GameObject fieldSetContainer)
			{
			}

			// Token: 0x06002211 RID: 8721 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002211")]
			[Address(RVA = "0x3BFC70", Offset = "0x3BF070", VA = "0x103BFC70")]
			public void AddInputField(int mapCategoryId, InputAction action, AxisRange axisRange, ControllerType controllerType, int fieldIndex, ControlMapper.GUIInputField inputField)
			{
			}

			// Token: 0x06002212 RID: 8722 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002212")]
			[Address(RVA = "0x3BFBD0", Offset = "0x3BEFD0", VA = "0x103BFBD0")]
			public void AddGroup(GameObject group)
			{
			}

			// Token: 0x06002213 RID: 8723 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002213")]
			[Address(RVA = "0x3BFAD0", Offset = "0x3BEED0", VA = "0x103BFAD0")]
			public void AddActionLabel(int mapCategoryId, int actionId, AxisRange axisRange, ControlMapper.GUILabel label)
			{
			}

			// Token: 0x06002214 RID: 8724 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002214")]
			[Address(RVA = "0x3BF9D0", Offset = "0x3BEDD0", VA = "0x103BF9D0")]
			public void AddActionCategoryLabel(int mapCategoryId, int actionCategoryId, ControlMapper.GUILabel label)
			{
			}

			// Token: 0x06002215 RID: 8725 RVA: 0x0000A728 File Offset: 0x00008928
			[Token(Token = "0x6002215")]
			[Address(RVA = "0x3C00A0", Offset = "0x3BF4A0", VA = "0x103C00A0")]
			public bool Contains(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int fieldIndex)
			{
				return default(bool);
			}

			// Token: 0x06002216 RID: 8726 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002216")]
			[Address(RVA = "0x3C01D0", Offset = "0x3BF5D0", VA = "0x103C01D0")]
			public ControlMapper.GUIInputField GetGUIInputField(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int fieldIndex)
			{
				return null;
			}

			// Token: 0x06002217 RID: 8727 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002217")]
			[Address(RVA = "0x3C00F0", Offset = "0x3BF4F0", VA = "0x103C00F0")]
			public IEnumerable<ControlMapper.InputActionSet> GetActionSets(int mapCategoryId)
			{
				return null;
			}

			// Token: 0x06002218 RID: 8728 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002218")]
			[Address(RVA = "0x3C03E0", Offset = "0x3BF7E0", VA = "0x103C03E0")]
			public void SetColumnHeight(int mapCategoryId, float height)
			{
			}

			// Token: 0x06002219 RID: 8729 RVA: 0x0000A740 File Offset: 0x00008940
			[Token(Token = "0x6002219")]
			[Address(RVA = "0x3C0150", Offset = "0x3BF550", VA = "0x103C0150")]
			public float GetColumnHeight(int mapCategoryId)
			{
				return 0f;
			}

			// Token: 0x0600221A RID: 8730 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600221A")]
			[Address(RVA = "0x3C0490", Offset = "0x3BF890", VA = "0x103C0490")]
			public void SetFieldsActive(int mapCategoryId, bool state)
			{
			}

			// Token: 0x0600221B RID: 8731 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600221B")]
			[Address(RVA = "0x3C0450", Offset = "0x3BF850", VA = "0x103C0450")]
			public void SetFieldLabel(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int index, string label)
			{
			}

			// Token: 0x0600221C RID: 8732 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600221C")]
			[Address(RVA = "0x3C0390", Offset = "0x3BF790", VA = "0x103C0390")]
			public void PopulateField(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int controllerId, int index, int actionElementMapId, string label, bool invert)
			{
			}

			// Token: 0x0600221D RID: 8733 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600221D")]
			[Address(RVA = "0x3C0560", Offset = "0x3BF960", VA = "0x103C0560")]
			public void SetFixedFieldData(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int controllerId)
			{
			}

			// Token: 0x0600221E RID: 8734 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600221E")]
			[Address(RVA = "0x3C02C0", Offset = "0x3BF6C0", VA = "0x103C02C0")]
			public void InitializeFields(int mapCategoryId)
			{
			}

			// Token: 0x0600221F RID: 8735 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600221F")]
			[Address(RVA = "0x3C05A0", Offset = "0x3BF9A0", VA = "0x103C05A0")]
			public void Show(int mapCategoryId)
			{
			}

			// Token: 0x06002220 RID: 8736 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002220")]
			[Address(RVA = "0x3C0220", Offset = "0x3BF620", VA = "0x103C0220")]
			public void HideAll()
			{
			}

			// Token: 0x06002221 RID: 8737 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002221")]
			[Address(RVA = "0x3BFFD0", Offset = "0x3BF3D0", VA = "0x103BFFD0")]
			public void ClearLabels(int mapCategoryId)
			{
			}

			// Token: 0x06002222 RID: 8738 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002222")]
			[Address(RVA = "0x3BFEC0", Offset = "0x3BF2C0", VA = "0x103BFEC0")]
			private void ClearGroups()
			{
			}

			// Token: 0x06002223 RID: 8739 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002223")]
			[Address(RVA = "0x3BFD70", Offset = "0x3BF170", VA = "0x103BFD70")]
			public void ClearAll()
			{
			}

			// Token: 0x04002328 RID: 9000
			[Token(Token = "0x4002328")]
			[FieldOffset(Offset = "0x8")]
			private ControlMapper.InputGridEntryList list;

			// Token: 0x04002329 RID: 9001
			[Token(Token = "0x4002329")]
			[FieldOffset(Offset = "0xC")]
			private List<GameObject> groups;
		}

		// Token: 0x02000579 RID: 1401
		[Token(Token = "0x2000579")]
		private class InputGridEntryList
		{
			// Token: 0x06002224 RID: 8740 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002224")]
			[Address(RVA = "0x3BF970", Offset = "0x3BED70", VA = "0x103BF970")]
			public InputGridEntryList()
			{
			}

			// Token: 0x06002225 RID: 8741 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002225")]
			[Address(RVA = "0x3BF1D0", Offset = "0x3BE5D0", VA = "0x103BF1D0")]
			public void AddMapCategory(int mapCategoryId)
			{
			}

			// Token: 0x06002226 RID: 8742 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002226")]
			[Address(RVA = "0x3BF0D0", Offset = "0x3BE4D0", VA = "0x103BF0D0")]
			public void AddAction(int mapCategoryId, InputAction action, AxisRange axisRange)
			{
			}

			// Token: 0x06002227 RID: 8743 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002227")]
			[Address(RVA = "0x3BEFD0", Offset = "0x3BE3D0", VA = "0x103BEFD0")]
			private ControlMapper.InputGridEntryList.ActionEntry AddActionEntry(int mapCategoryId, InputAction action, AxisRange axisRange)
			{
				return null;
			}

			// Token: 0x06002228 RID: 8744 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002228")]
			[Address(RVA = "0x3BF050", Offset = "0x3BE450", VA = "0x103BF050")]
			public void AddActionLabel(int mapCategoryId, int actionId, AxisRange axisRange, ControlMapper.GUILabel label)
			{
			}

			// Token: 0x06002229 RID: 8745 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002229")]
			[Address(RVA = "0x3BEF60", Offset = "0x3BE360", VA = "0x103BEF60")]
			public void AddActionCategory(int mapCategoryId, int actionCategoryId)
			{
			}

			// Token: 0x0600222A RID: 8746 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600222A")]
			[Address(RVA = "0x3BEE60", Offset = "0x3BE260", VA = "0x103BEE60")]
			private ControlMapper.InputGridEntryList.ActionCategoryEntry AddActionCategoryEntry(int mapCategoryId, int actionCategoryId)
			{
				return null;
			}

			// Token: 0x0600222B RID: 8747 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600222B")]
			[Address(RVA = "0x3BEEE0", Offset = "0x3BE2E0", VA = "0x103BEEE0")]
			public void AddActionCategoryLabel(int mapCategoryId, int actionCategoryId, ControlMapper.GUILabel label)
			{
			}

			// Token: 0x0600222C RID: 8748 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600222C")]
			[Address(RVA = "0x3BF150", Offset = "0x3BE550", VA = "0x103BF150")]
			public void AddInputFieldSet(int mapCategoryId, InputAction action, AxisRange axisRange, ControllerType controllerType, GameObject fieldSetContainer)
			{
			}

			// Token: 0x0600222D RID: 8749 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600222D")]
			[Address(RVA = "0x3BF190", Offset = "0x3BE590", VA = "0x103BF190")]
			public void AddInputField(int mapCategoryId, InputAction action, AxisRange axisRange, ControllerType controllerType, int fieldIndex, ControlMapper.GUIInputField inputField)
			{
			}

			// Token: 0x0600222E RID: 8750 RVA: 0x0000A758 File Offset: 0x00008958
			[Token(Token = "0x600222E")]
			[Address(RVA = "0x3BF380", Offset = "0x3BE780", VA = "0x103BF380")]
			public bool Contains(int mapCategoryId, int actionId, AxisRange axisRange)
			{
				return default(bool);
			}

			// Token: 0x0600222F RID: 8751 RVA: 0x0000A770 File Offset: 0x00008970
			[Token(Token = "0x600222F")]
			[Address(RVA = "0x3BF3A0", Offset = "0x3BE7A0", VA = "0x103BF3A0")]
			public bool Contains(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int fieldIndex)
			{
				return default(bool);
			}

			// Token: 0x06002230 RID: 8752 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002230")]
			[Address(RVA = "0x3BF750", Offset = "0x3BEB50", VA = "0x103BF750")]
			public void SetColumnHeight(int mapCategoryId, float height)
			{
			}

			// Token: 0x06002231 RID: 8753 RVA: 0x0000A788 File Offset: 0x00008988
			[Token(Token = "0x6002231")]
			[Address(RVA = "0x3BF4F0", Offset = "0x3BE8F0", VA = "0x103BF4F0")]
			public float GetColumnHeight(int mapCategoryId)
			{
				return 0f;
			}

			// Token: 0x06002232 RID: 8754 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002232")]
			[Address(RVA = "0x3BF560", Offset = "0x3BE960", VA = "0x103BF560")]
			public ControlMapper.GUIInputField GetGUIInputField(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int fieldIndex)
			{
				return null;
			}

			// Token: 0x06002233 RID: 8755 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002233")]
			[Address(RVA = "0x3BF3E0", Offset = "0x3BE7E0", VA = "0x103BF3E0")]
			private ControlMapper.InputGridEntryList.ActionEntry GetActionEntry(int mapCategoryId, int actionId, AxisRange axisRange)
			{
				return null;
			}

			// Token: 0x06002234 RID: 8756 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002234")]
			[Address(RVA = "0x3BF460", Offset = "0x3BE860", VA = "0x103BF460")]
			private ControlMapper.InputGridEntryList.ActionEntry GetActionEntry(int mapCategoryId, InputAction action, AxisRange axisRange)
			{
				return null;
			}

			// Token: 0x06002235 RID: 8757 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002235")]
			[Address(RVA = "0x3BF490", Offset = "0x3BE890", VA = "0x103BF490")]
			[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE5160", Offset = "0xE4560")]
			public IEnumerable<ControlMapper.InputActionSet> GetActionSets(int mapCategoryId)
			{
				return null;
			}

			// Token: 0x06002236 RID: 8758 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002236")]
			[Address(RVA = "0x3BF7C0", Offset = "0x3BEBC0", VA = "0x103BF7C0")]
			public void SetFieldsActive(int mapCategoryId, bool state)
			{
			}

			// Token: 0x06002237 RID: 8759 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002237")]
			[Address(RVA = "0x3BF8C0", Offset = "0x3BECC0", VA = "0x103BF8C0")]
			public void SetLabel(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int index, string label)
			{
			}

			// Token: 0x06002238 RID: 8760 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002238")]
			[Address(RVA = "0x3BF710", Offset = "0x3BEB10", VA = "0x103BF710")]
			public void PopulateField(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int controllerId, int index, int actionElementMapId, string label, bool invert)
			{
			}

			// Token: 0x06002239 RID: 8761 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002239")]
			[Address(RVA = "0x3BF890", Offset = "0x3BEC90", VA = "0x103BF890")]
			public void SetFixedFieldData(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int controllerId)
			{
			}

			// Token: 0x0600223A RID: 8762 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600223A")]
			[Address(RVA = "0x3BF640", Offset = "0x3BEA40", VA = "0x103BF640")]
			public void InitializeFields(int mapCategoryId)
			{
			}

			// Token: 0x0600223B RID: 8763 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600223B")]
			[Address(RVA = "0x3BF900", Offset = "0x3BED00", VA = "0x103BF900")]
			public void Show(int mapCategoryId)
			{
			}

			// Token: 0x0600223C RID: 8764 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600223C")]
			[Address(RVA = "0x3BF5A0", Offset = "0x3BE9A0", VA = "0x103BF5A0")]
			public void HideAll()
			{
			}

			// Token: 0x0600223D RID: 8765 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600223D")]
			[Address(RVA = "0x3BF270", Offset = "0x3BE670", VA = "0x103BF270")]
			public void ClearLabels(int mapCategoryId)
			{
			}

			// Token: 0x0600223E RID: 8766 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600223E")]
			[Address(RVA = "0x3BF340", Offset = "0x3BE740", VA = "0x103BF340")]
			public void Clear()
			{
			}

			// Token: 0x0400232A RID: 9002
			[Token(Token = "0x400232A")]
			[FieldOffset(Offset = "0x8")]
			private ControlMapper.IndexedDictionary<int, ControlMapper.InputGridEntryList.MapCategoryEntry> entries;

			// Token: 0x0200057A RID: 1402
			[Token(Token = "0x200057A")]
			private class MapCategoryEntry
			{
				// Token: 0x17000707 RID: 1799
				// (get) Token: 0x0600223F RID: 8767 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000707")]
				public List<ControlMapper.InputGridEntryList.ActionEntry> actionList
				{
					[Token(Token = "0x600223F")]
					[Address(RVA = "0x273EB0", Offset = "0x2732B0", VA = "0x10273EB0")]
					get
					{
						return null;
					}
				}

				// Token: 0x17000708 RID: 1800
				// (get) Token: 0x06002240 RID: 8768 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000708")]
				public ControlMapper.IndexedDictionary<int, ControlMapper.InputGridEntryList.ActionCategoryEntry> actionCategoryList
				{
					[Token(Token = "0x6002240")]
					[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90")]
					get
					{
						return null;
					}
				}

				// Token: 0x17000709 RID: 1801
				// (get) Token: 0x06002241 RID: 8769 RVA: 0x0000A7A0 File Offset: 0x000089A0
				// (set) Token: 0x06002242 RID: 8770 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x17000709")]
				public float columnHeight
				{
					[Token(Token = "0x6002241")]
					[Address(RVA = "0x273A10", Offset = "0x272E10", VA = "0x10273A10")]
					get
					{
						return 0f;
					}
					[Token(Token = "0x6002242")]
					[Address(RVA = "0x273A30", Offset = "0x272E30", VA = "0x10273A30")]
					set
					{
					}
				}

				// Token: 0x06002243 RID: 8771 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6002243")]
				[Address(RVA = "0x12FC9C0", Offset = "0x12FBDC0", VA = "0x112FC9C0")]
				public MapCategoryEntry()
				{
				}

				// Token: 0x06002244 RID: 8772 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6002244")]
				[Address(RVA = "0x12FC6D0", Offset = "0x12FBAD0", VA = "0x112FC6D0")]
				public ControlMapper.InputGridEntryList.ActionEntry GetActionEntry(int actionId, AxisRange axisRange)
				{
					return null;
				}

				// Token: 0x06002245 RID: 8773 RVA: 0x0000A7B8 File Offset: 0x000089B8
				[Token(Token = "0x6002245")]
				[Address(RVA = "0x12FC740", Offset = "0x12FBB40", VA = "0x112FC740")]
				public int IndexOfActionEntry(int actionId, AxisRange axisRange)
				{
					return 0;
				}

				// Token: 0x06002246 RID: 8774 RVA: 0x0000A7D0 File Offset: 0x000089D0
				[Token(Token = "0x6002246")]
				[Address(RVA = "0x12FC630", Offset = "0x12FBA30", VA = "0x112FC630")]
				public bool ContainsActionEntry(int actionId, AxisRange axisRange)
				{
					return default(bool);
				}

				// Token: 0x06002247 RID: 8775 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6002247")]
				[Address(RVA = "0x12FC4D0", Offset = "0x12FB8D0", VA = "0x112FC4D0")]
				public ControlMapper.InputGridEntryList.ActionEntry AddAction(InputAction action, AxisRange axisRange)
				{
					return null;
				}

				// Token: 0x06002248 RID: 8776 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6002248")]
				[Address(RVA = "0x12FC650", Offset = "0x12FBA50", VA = "0x112FC650")]
				public ControlMapper.InputGridEntryList.ActionCategoryEntry GetActionCategoryEntry(int actionCategoryId)
				{
					return null;
				}

				// Token: 0x06002249 RID: 8777 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6002249")]
				[Address(RVA = "0x12FC400", Offset = "0x12FB800", VA = "0x112FC400")]
				public ControlMapper.InputGridEntryList.ActionCategoryEntry AddActionCategory(int actionCategoryId)
				{
					return null;
				}

				// Token: 0x0600224A RID: 8778 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600224A")]
				[Address(RVA = "0x12FC7F0", Offset = "0x12FBBF0", VA = "0x112FC7F0")]
				public void SetAllActive(bool state)
				{
				}

				// Token: 0x0400232B RID: 9003
				[Token(Token = "0x400232B")]
				[FieldOffset(Offset = "0x8")]
				private List<ControlMapper.InputGridEntryList.ActionEntry> _actionList;

				// Token: 0x0400232C RID: 9004
				[Token(Token = "0x400232C")]
				[FieldOffset(Offset = "0xC")]
				private ControlMapper.IndexedDictionary<int, ControlMapper.InputGridEntryList.ActionCategoryEntry> _actionCategoryList;

				// Token: 0x0400232D RID: 9005
				[Token(Token = "0x400232D")]
				[FieldOffset(Offset = "0x10")]
				private float _columnHeight;
			}

			// Token: 0x0200057B RID: 1403
			[Token(Token = "0x200057B")]
			private class ActionEntry
			{
				// Token: 0x0600224B RID: 8779 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600224B")]
				[Address(RVA = "0x12FBB00", Offset = "0x12FAF00", VA = "0x112FBB00")]
				public ActionEntry(InputAction action, AxisRange axisRange)
				{
				}

				// Token: 0x0600224C RID: 8780 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600224C")]
				[Address(RVA = "0x273ED0", Offset = "0x2732D0", VA = "0x10273ED0")]
				public void SetLabel(ControlMapper.GUILabel label)
				{
				}

				// Token: 0x0600224D RID: 8781 RVA: 0x0000A7E8 File Offset: 0x000089E8
				[Token(Token = "0x600224D")]
				[Address(RVA = "0x12FB550", Offset = "0x12FA950", VA = "0x112FB550")]
				public bool Matches(int actionId, AxisRange axisRange)
				{
					return default(bool);
				}

				// Token: 0x0600224E RID: 8782 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600224E")]
				[Address(RVA = "0x12FAF60", Offset = "0x12FA360", VA = "0x112FAF60")]
				public void AddInputFieldSet(ControllerType controllerType, GameObject fieldSetContainer)
				{
				}

				// Token: 0x0600224F RID: 8783 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600224F")]
				[Address(RVA = "0x12FB050", Offset = "0x12FA450", VA = "0x112FB050")]
				public void AddInputField(ControllerType controllerType, int fieldIndex, ControlMapper.GUIInputField inputField)
				{
				}

				// Token: 0x06002250 RID: 8784 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6002250")]
				[Address(RVA = "0x12FB2C0", Offset = "0x12FA6C0", VA = "0x112FB2C0")]
				public ControlMapper.GUIInputField GetGUIInputField(ControllerType controllerType, int fieldIndex)
				{
					return null;
				}

				// Token: 0x06002251 RID: 8785 RVA: 0x0000A800 File Offset: 0x00008A00
				[Token(Token = "0x6002251")]
				[Address(RVA = "0x12FB220", Offset = "0x12FA620", VA = "0x112FB220")]
				public bool Contains(ControllerType controllerType, int fieldId)
				{
					return default(bool);
				}

				// Token: 0x06002252 RID: 8786 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6002252")]
				[Address(RVA = "0x12FB7C0", Offset = "0x12FABC0", VA = "0x112FB7C0")]
				public void SetFieldLabel(ControllerType controllerType, int index, string label)
				{
				}

				// Token: 0x06002253 RID: 8787 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6002253")]
				[Address(RVA = "0x12FB580", Offset = "0x12FA980", VA = "0x112FB580")]
				public void PopulateField(ControllerType controllerType, int controllerId, int index, int actionElementMapId, string label, bool invert)
				{
				}

				// Token: 0x06002254 RID: 8788 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6002254")]
				[Address(RVA = "0x12FBA20", Offset = "0x12FAE20", VA = "0x112FBA20")]
				public void SetFixedFieldData(ControllerType controllerType, int controllerId)
				{
				}

				// Token: 0x06002255 RID: 8789 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6002255")]
				[Address(RVA = "0x12FB3B0", Offset = "0x12FA7B0", VA = "0x112FB3B0")]
				public void Initialize()
				{
				}

				// Token: 0x06002256 RID: 8790 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6002256")]
				[Address(RVA = "0x12FB710", Offset = "0x12FAB10", VA = "0x112FB710")]
				public void SetActive(bool state)
				{
				}

				// Token: 0x06002257 RID: 8791 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6002257")]
				[Address(RVA = "0x12FB110", Offset = "0x12FA510", VA = "0x112FB110")]
				public void ClearLabels()
				{
				}

				// Token: 0x06002258 RID: 8792 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6002258")]
				[Address(RVA = "0x12FB8C0", Offset = "0x12FACC0", VA = "0x112FB8C0")]
				public void SetFieldsActive(bool state)
				{
				}

				// Token: 0x0400232E RID: 9006
				[Token(Token = "0x400232E")]
				[FieldOffset(Offset = "0x8")]
				private ControlMapper.IndexedDictionary<int, ControlMapper.InputGridEntryList.FieldSet> fieldSets;

				// Token: 0x0400232F RID: 9007
				[Token(Token = "0x400232F")]
				[FieldOffset(Offset = "0xC")]
				public ControlMapper.GUILabel label;

				// Token: 0x04002330 RID: 9008
				[Token(Token = "0x4002330")]
				[FieldOffset(Offset = "0x10")]
				public readonly InputAction action;

				// Token: 0x04002331 RID: 9009
				[Token(Token = "0x4002331")]
				[FieldOffset(Offset = "0x14")]
				public readonly AxisRange axisRange;

				// Token: 0x04002332 RID: 9010
				[Token(Token = "0x4002332")]
				[FieldOffset(Offset = "0x18")]
				public readonly ControlMapper.InputActionSet actionSet;
			}

			// Token: 0x0200057C RID: 1404
			[Token(Token = "0x200057C")]
			private class FieldSet
			{
				// Token: 0x06002259 RID: 8793 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6002259")]
				[Address(RVA = "0x12FC030", Offset = "0x12FB430", VA = "0x112FC030")]
				public FieldSet(GameObject groupContainer)
				{
				}

				// Token: 0x04002333 RID: 9011
				[Token(Token = "0x4002333")]
				[FieldOffset(Offset = "0x8")]
				public readonly GameObject groupContainer;

				// Token: 0x04002334 RID: 9012
				[Token(Token = "0x4002334")]
				[FieldOffset(Offset = "0xC")]
				public readonly ControlMapper.IndexedDictionary<int, ControlMapper.GUIInputField> fields;
			}

			// Token: 0x0200057D RID: 1405
			[Token(Token = "0x200057D")]
			private class ActionCategoryEntry
			{
				// Token: 0x0600225A RID: 8794 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600225A")]
				[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
				public ActionCategoryEntry(int actionCategoryId)
				{
				}

				// Token: 0x0600225B RID: 8795 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600225B")]
				[Address(RVA = "0x273ED0", Offset = "0x2732D0", VA = "0x10273ED0")]
				public void SetLabel(ControlMapper.GUILabel label)
				{
				}

				// Token: 0x0600225C RID: 8796 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600225C")]
				[Address(RVA = "0x12FAF40", Offset = "0x12FA340", VA = "0x112FAF40")]
				public void SetActive(bool state)
				{
				}

				// Token: 0x04002335 RID: 9013
				[Token(Token = "0x4002335")]
				[FieldOffset(Offset = "0x8")]
				public readonly int actionCategoryId;

				// Token: 0x04002336 RID: 9014
				[Token(Token = "0x4002336")]
				[FieldOffset(Offset = "0xC")]
				public ControlMapper.GUILabel label;
			}

			// Token: 0x0200057E RID: 1406
			[Token(Token = "0x200057E")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private sealed class <GetActionSets>d__18 : IEnumerable<ControlMapper.InputActionSet>, IEnumerable, IEnumerator<ControlMapper.InputActionSet>, IEnumerator, IDisposable
			{
				// Token: 0x0600225D RID: 8797 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600225D")]
				[Address(RVA = "0x5B1500", Offset = "0x5B0900", VA = "0x105B1500")]
				[DebuggerHidden]
				public <GetActionSets>d__18(int <>1__state)
				{
				}

				// Token: 0x0600225E RID: 8798 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600225E")]
				[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "7")]
				[DebuggerHidden]
				private void Dispose()
				{
				}

				// Token: 0x0600225F RID: 8799 RVA: 0x0000A818 File Offset: 0x00008A18
				[Token(Token = "0x600225F")]
				[Address(RVA = "0x1300200", Offset = "0x12FF600", VA = "0x11300200", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				// Token: 0x1700070A RID: 1802
				// (get) Token: 0x06002260 RID: 8800 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x1700070A")]
				private ControlMapper.InputActionSet Current
				{
					[Token(Token = "0x6002260")]
					[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				// Token: 0x06002261 RID: 8801 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6002261")]
				[Address(RVA = "0x13003A0", Offset = "0x12FF7A0", VA = "0x113003A0", Slot = "10")]
				[DebuggerHidden]
				private void Reset()
				{
				}

				// Token: 0x1700070B RID: 1803
				// (get) Token: 0x06002262 RID: 8802 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x1700070B")]
				private object Current
				{
					[Token(Token = "0x6002262")]
					[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				// Token: 0x06002263 RID: 8803 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6002263")]
				[Address(RVA = "0x1300310", Offset = "0x12FF710", VA = "0x11300310", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<ControlMapper.InputActionSet> GetEnumerator()
				{
					return null;
				}

				// Token: 0x06002264 RID: 8804 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6002264")]
				[Address(RVA = "0x1300310", Offset = "0x12FF710", VA = "0x11300310", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator GetEnumerator()
				{
					return null;
				}

				// Token: 0x04002337 RID: 9015
				[Token(Token = "0x4002337")]
				[FieldOffset(Offset = "0x8")]
				private int <>1__state;

				// Token: 0x04002338 RID: 9016
				[Token(Token = "0x4002338")]
				[FieldOffset(Offset = "0xC")]
				private ControlMapper.InputActionSet <>2__current;

				// Token: 0x04002339 RID: 9017
				[Token(Token = "0x4002339")]
				[FieldOffset(Offset = "0x10")]
				private int <>l__initialThreadId;

				// Token: 0x0400233A RID: 9018
				[Token(Token = "0x400233A")]
				[FieldOffset(Offset = "0x14")]
				public ControlMapper.InputGridEntryList <>4__this;

				// Token: 0x0400233B RID: 9019
				[Token(Token = "0x400233B")]
				[FieldOffset(Offset = "0x18")]
				private int mapCategoryId;

				// Token: 0x0400233C RID: 9020
				[Token(Token = "0x400233C")]
				[FieldOffset(Offset = "0x1C")]
				public int <>3__mapCategoryId;

				// Token: 0x0400233D RID: 9021
				[Token(Token = "0x400233D")]
				[FieldOffset(Offset = "0x20")]
				private List<ControlMapper.InputGridEntryList.ActionEntry> <list>5__2;

				// Token: 0x0400233E RID: 9022
				[Token(Token = "0x400233E")]
				[FieldOffset(Offset = "0x24")]
				private int <count>5__3;

				// Token: 0x0400233F RID: 9023
				[Token(Token = "0x400233F")]
				[FieldOffset(Offset = "0x28")]
				private int <i>5__4;
			}
		}

		// Token: 0x0200057F RID: 1407
		[Token(Token = "0x200057F")]
		private class WindowManager
		{
			// Token: 0x1700070C RID: 1804
			// (get) Token: 0x06002265 RID: 8805 RVA: 0x0000A830 File Offset: 0x00008A30
			[Token(Token = "0x1700070C")]
			public bool isWindowOpen
			{
				[Token(Token = "0x6002265")]
				[Address(RVA = "0x3CC500", Offset = "0x3CB900", VA = "0x103CC500")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700070D RID: 1805
			// (get) Token: 0x06002266 RID: 8806 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700070D")]
			public Window topWindow
			{
				[Token(Token = "0x6002266")]
				[Address(RVA = "0x3CC5C0", Offset = "0x3CB9C0", VA = "0x103CC5C0")]
				get
				{
					return null;
				}
			}

			// Token: 0x06002267 RID: 8807 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002267")]
			[Address(RVA = "0x3CC390", Offset = "0x3CB790", VA = "0x103CC390")]
			public WindowManager(GameObject windowPrefab, GameObject faderPrefab, Transform parent)
			{
			}

			// Token: 0x06002268 RID: 8808 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002268")]
			[Address(RVA = "0x3CC1E0", Offset = "0x3CB5E0", VA = "0x103CC1E0")]
			public Window OpenWindow(string name, int width, int height)
			{
				return null;
			}

			// Token: 0x06002269 RID: 8809 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002269")]
			[Address(RVA = "0x3CC120", Offset = "0x3CB520", VA = "0x103CC120")]
			public Window OpenWindow(GameObject windowPrefab, string name)
			{
				return null;
			}

			// Token: 0x0600226A RID: 8810 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600226A")]
			[Address(RVA = "0x3CB410", Offset = "0x3CA810", VA = "0x103CB410")]
			public void CloseTop()
			{
			}

			// Token: 0x0600226B RID: 8811 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600226B")]
			[Address(RVA = "0x3CB7A0", Offset = "0x3CABA0", VA = "0x103CB7A0")]
			public void CloseWindow(int windowId)
			{
			}

			// Token: 0x0600226C RID: 8812 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600226C")]
			[Address(RVA = "0x3CB550", Offset = "0x3CA950", VA = "0x103CB550")]
			public void CloseWindow(Window window)
			{
			}

			// Token: 0x0600226D RID: 8813 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600226D")]
			[Address(RVA = "0x3CB2D0", Offset = "0x3CA6D0", VA = "0x103CB2D0")]
			public void CloseAll()
			{
			}

			// Token: 0x0600226E RID: 8814 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600226E")]
			[Address(RVA = "0x3CB120", Offset = "0x3CA520", VA = "0x103CB120")]
			public void CancelAll()
			{
			}

			// Token: 0x0600226F RID: 8815 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600226F")]
			[Address(RVA = "0x3CBC20", Offset = "0x3CB020", VA = "0x103CBC20")]
			public Window GetWindow(int windowId)
			{
				return null;
			}

			// Token: 0x06002270 RID: 8816 RVA: 0x0000A848 File Offset: 0x00008A48
			[Token(Token = "0x6002270")]
			[Address(RVA = "0x3CC090", Offset = "0x3CB490", VA = "0x103CC090")]
			public bool IsFocused(int windowId)
			{
				return default(bool);
			}

			// Token: 0x06002271 RID: 8817 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002271")]
			[Address(RVA = "0x3CBBD0", Offset = "0x3CAFD0", VA = "0x103CBBD0")]
			public void Focus(int windowId)
			{
			}

			// Token: 0x06002272 RID: 8818 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002272")]
			[Address(RVA = "0x3CBA30", Offset = "0x3CAE30", VA = "0x103CBA30")]
			public void Focus(Window window)
			{
			}

			// Token: 0x06002273 RID: 8819 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002273")]
			[Address(RVA = "0x3CB7D0", Offset = "0x3CABD0", VA = "0x103CB7D0")]
			private void DefocusOtherWindows(int focusedWindowId)
			{
			}

			// Token: 0x06002274 RID: 8820 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002274")]
			[Address(RVA = "0x3CC240", Offset = "0x3CB640", VA = "0x103CC240")]
			private void UpdateFader()
			{
			}

			// Token: 0x06002275 RID: 8821 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002275")]
			[Address(RVA = "0x3CB9A0", Offset = "0x3CADA0", VA = "0x103CB9A0")]
			private void FocusTopWindow()
			{
			}

			// Token: 0x06002276 RID: 8822 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002276")]
			[Address(RVA = "0x3CC210", Offset = "0x3CB610", VA = "0x103CC210")]
			private void SetFaderActive(bool state)
			{
			}

			// Token: 0x06002277 RID: 8823 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002277")]
			[Address(RVA = "0x3CBD30", Offset = "0x3CB130", VA = "0x103CBD30")]
			private Window InstantiateWindow(string name, int width, int height)
			{
				return null;
			}

			// Token: 0x06002278 RID: 8824 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002278")]
			[Address(RVA = "0x3CBED0", Offset = "0x3CB2D0", VA = "0x103CBED0")]
			private Window InstantiateWindow(string name, GameObject windowPrefab)
			{
				return null;
			}

			// Token: 0x06002279 RID: 8825 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002279")]
			[Address(RVA = "0x3CB900", Offset = "0x3CAD00", VA = "0x103CB900")]
			private void DestroyWindow(Window window)
			{
			}

			// Token: 0x0600227A RID: 8826 RVA: 0x0000A860 File Offset: 0x00008A60
			[Token(Token = "0x600227A")]
			[Address(RVA = "0x3CBC00", Offset = "0x3CB000", VA = "0x103CBC00")]
			private int GetNewId()
			{
				return 0;
			}

			// Token: 0x0600227B RID: 8827 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600227B")]
			[Address(RVA = "0x3CB240", Offset = "0x3CA640", VA = "0x103CB240")]
			public void ClearCompletely()
			{
			}

			// Token: 0x04002340 RID: 9024
			[Token(Token = "0x4002340")]
			[FieldOffset(Offset = "0x8")]
			private List<Window> windows;

			// Token: 0x04002341 RID: 9025
			[Token(Token = "0x4002341")]
			[FieldOffset(Offset = "0xC")]
			private GameObject windowPrefab;

			// Token: 0x04002342 RID: 9026
			[Token(Token = "0x4002342")]
			[FieldOffset(Offset = "0x10")]
			private Transform parent;

			// Token: 0x04002343 RID: 9027
			[Token(Token = "0x4002343")]
			[FieldOffset(Offset = "0x14")]
			private GameObject fader;

			// Token: 0x04002344 RID: 9028
			[Token(Token = "0x4002344")]
			[FieldOffset(Offset = "0x18")]
			private int idCounter;
		}

		// Token: 0x02000580 RID: 1408
		[Token(Token = "0x2000580")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private sealed class <>c__DisplayClass341_0
		{
			// Token: 0x0600227C RID: 8828 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600227C")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public <>c__DisplayClass341_0()
			{
			}

			// Token: 0x0600227D RID: 8829 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600227D")]
			[Address(RVA = "0x3CA390", Offset = "0x3C9790", VA = "0x103CA390")]
			internal void <ShowControllerAssignmentConflictWindow>b__0()
			{
			}

			// Token: 0x0600227E RID: 8830 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600227E")]
			[Address(RVA = "0x3CA3C0", Offset = "0x3C97C0", VA = "0x103CA3C0")]
			internal void <ShowControllerAssignmentConflictWindow>b__1()
			{
			}

			// Token: 0x04002345 RID: 9029
			[Token(Token = "0x4002345")]
			[FieldOffset(Offset = "0x8")]
			public ControlMapper <>4__this;

			// Token: 0x04002346 RID: 9030
			[Token(Token = "0x4002346")]
			[FieldOffset(Offset = "0xC")]
			public Window window;

			// Token: 0x04002347 RID: 9031
			[Token(Token = "0x4002347")]
			[FieldOffset(Offset = "0x10")]
			public int controllerId;
		}

		// Token: 0x02000581 RID: 1409
		[Token(Token = "0x2000581")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private sealed class <>c__DisplayClass342_0
		{
			// Token: 0x0600227F RID: 8831 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600227F")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public <>c__DisplayClass342_0()
			{
			}

			// Token: 0x06002280 RID: 8832 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002280")]
			[Address(RVA = "0x3CA390", Offset = "0x3C9790", VA = "0x103CA390")]
			internal void <ShowBeginElementAssignmentReplacementWindow>b__0()
			{
			}

			// Token: 0x06002281 RID: 8833 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002281")]
			[Address(RVA = "0x3CA400", Offset = "0x3C9800", VA = "0x103CA400")]
			internal void <ShowBeginElementAssignmentReplacementWindow>b__1()
			{
			}

			// Token: 0x06002282 RID: 8834 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002282")]
			[Address(RVA = "0x3CA430", Offset = "0x3C9830", VA = "0x103CA430")]
			internal void <ShowBeginElementAssignmentReplacementWindow>b__2()
			{
			}

			// Token: 0x04002348 RID: 9032
			[Token(Token = "0x4002348")]
			[FieldOffset(Offset = "0x8")]
			public ControlMapper <>4__this;

			// Token: 0x04002349 RID: 9033
			[Token(Token = "0x4002349")]
			[FieldOffset(Offset = "0xC")]
			public Window window;

			// Token: 0x0400234A RID: 9034
			[Token(Token = "0x400234A")]
			[FieldOffset(Offset = "0x10")]
			public InputFieldInfo fieldInfo;

			// Token: 0x0400234B RID: 9035
			[Token(Token = "0x400234B")]
			[FieldOffset(Offset = "0x14")]
			public ControllerMap map;

			// Token: 0x0400234C RID: 9036
			[Token(Token = "0x400234C")]
			[FieldOffset(Offset = "0x18")]
			public ActionElementMap aem;

			// Token: 0x0400234D RID: 9037
			[Token(Token = "0x400234D")]
			[FieldOffset(Offset = "0x1C")]
			public string actionName;
		}

		// Token: 0x02000582 RID: 1410
		[Token(Token = "0x2000582")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private sealed class <>c__DisplayClass349_0
		{
			// Token: 0x06002283 RID: 8835 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002283")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public <>c__DisplayClass349_0()
			{
			}

			// Token: 0x06002284 RID: 8836 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002284")]
			[Address(RVA = "0x3CA390", Offset = "0x3C9790", VA = "0x103CA390")]
			internal void <ShowElementAssignmentConflictWindow>b__0()
			{
			}

			// Token: 0x06002285 RID: 8837 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002285")]
			[Address(RVA = "0x3CA460", Offset = "0x3C9860", VA = "0x103CA460")]
			internal void <ShowElementAssignmentConflictWindow>b__1()
			{
			}

			// Token: 0x06002286 RID: 8838 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002286")]
			[Address(RVA = "0x3CA4C0", Offset = "0x3C98C0", VA = "0x103CA4C0")]
			internal void <ShowElementAssignmentConflictWindow>b__2()
			{
			}

			// Token: 0x06002287 RID: 8839 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002287")]
			[Address(RVA = "0x3CA510", Offset = "0x3C9910", VA = "0x103CA510")]
			internal void <ShowElementAssignmentConflictWindow>b__3()
			{
			}

			// Token: 0x0400234E RID: 9038
			[Token(Token = "0x400234E")]
			[FieldOffset(Offset = "0x8")]
			public ControlMapper <>4__this;

			// Token: 0x0400234F RID: 9039
			[Token(Token = "0x400234F")]
			[FieldOffset(Offset = "0xC")]
			public Window window;

			// Token: 0x04002350 RID: 9040
			[Token(Token = "0x4002350")]
			[FieldOffset(Offset = "0x10")]
			public ElementAssignment assignment;

			// Token: 0x04002351 RID: 9041
			[Token(Token = "0x4002351")]
			[FieldOffset(Offset = "0x34")]
			public bool skipOtherPlayers;
		}

		// Token: 0x02000583 RID: 1411
		[Token(Token = "0x2000583")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private sealed class <>c__DisplayClass350_0
		{
			// Token: 0x06002288 RID: 8840 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002288")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public <>c__DisplayClass350_0()
			{
			}

			// Token: 0x06002289 RID: 8841 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002289")]
			[Address(RVA = "0x3CA390", Offset = "0x3C9790", VA = "0x103CA390")]
			internal void <ShowMouseAssignmentConflictWindow>b__0()
			{
			}

			// Token: 0x0600228A RID: 8842 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600228A")]
			[Address(RVA = "0x3CA570", Offset = "0x3C9970", VA = "0x103CA570")]
			internal void <ShowMouseAssignmentConflictWindow>b__1()
			{
			}

			// Token: 0x04002352 RID: 9042
			[Token(Token = "0x4002352")]
			[FieldOffset(Offset = "0x8")]
			public ControlMapper <>4__this;

			// Token: 0x04002353 RID: 9043
			[Token(Token = "0x4002353")]
			[FieldOffset(Offset = "0xC")]
			public Window window;
		}

		// Token: 0x02000584 RID: 1412
		[Token(Token = "0x2000584")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private sealed class <>c__DisplayClass403_0
		{
			// Token: 0x0600228B RID: 8843 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600228B")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public <>c__DisplayClass403_0()
			{
			}

			// Token: 0x0600228C RID: 8844 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600228C")]
			[Address(RVA = "0x3CA390", Offset = "0x3C9790", VA = "0x103CA390")]
			internal void <OpenModal>b__0()
			{
			}

			// Token: 0x0600228D RID: 8845 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600228D")]
			[Address(RVA = "0x3CA5B0", Offset = "0x3C99B0", VA = "0x103CA5B0")]
			internal void <OpenModal>b__1()
			{
			}

			// Token: 0x04002354 RID: 9044
			[Token(Token = "0x4002354")]
			[FieldOffset(Offset = "0x8")]
			public ControlMapper <>4__this;

			// Token: 0x04002355 RID: 9045
			[Token(Token = "0x4002355")]
			[FieldOffset(Offset = "0xC")]
			public Window window;
		}

		// Token: 0x02000585 RID: 1413
		[Token(Token = "0x2000585")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private sealed class <ElementAssignmentConflicts>d__411 : IEnumerable<ElementAssignmentConflictInfo>, IEnumerable, IEnumerator<ElementAssignmentConflictInfo>, IEnumerator, IDisposable
		{
			// Token: 0x0600228E RID: 8846 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600228E")]
			[Address(RVA = "0x3C7A40", Offset = "0x3C6E40", VA = "0x103C7A40")]
			[DebuggerHidden]
			public <ElementAssignmentConflicts>d__411(int <>1__state)
			{
			}

			// Token: 0x0600228F RID: 8847 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600228F")]
			[Address(RVA = "0x3C78E0", Offset = "0x3C6CE0", VA = "0x103C78E0", Slot = "7")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06002290 RID: 8848 RVA: 0x0000A878 File Offset: 0x00008A78
			[Token(Token = "0x6002290")]
			[Address(RVA = "0x3C7210", Offset = "0x3C6610", VA = "0x103C7210", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x06002291 RID: 8849 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002291")]
			[Address(RVA = "0x3C7950", Offset = "0x3C6D50", VA = "0x103C7950")]
			private void <>m__Finally1()
			{
			}

			// Token: 0x06002292 RID: 8850 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002292")]
			[Address(RVA = "0x3C79A0", Offset = "0x3C6DA0", VA = "0x103C79A0")]
			private void <>m__Finally2()
			{
			}

			// Token: 0x06002293 RID: 8851 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002293")]
			[Address(RVA = "0x3C79F0", Offset = "0x3C6DF0", VA = "0x103C79F0")]
			private void <>m__Finally3()
			{
			}

			// Token: 0x1700070E RID: 1806
			// (get) Token: 0x06002294 RID: 8852 RVA: 0x0000A890 File Offset: 0x00008A90
			[Token(Token = "0x1700070E")]
			private ElementAssignmentConflictInfo Current
			{
				[Token(Token = "0x6002294")]
				[Address(RVA = "0x3C7820", Offset = "0x3C6C20", VA = "0x103C7820", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(ElementAssignmentConflictInfo);
				}
			}

			// Token: 0x06002295 RID: 8853 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002295")]
			[Address(RVA = "0x3C7850", Offset = "0x3C6C50", VA = "0x103C7850", Slot = "10")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x1700070F RID: 1807
			// (get) Token: 0x06002296 RID: 8854 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700070F")]
			private object Current
			{
				[Token(Token = "0x6002296")]
				[Address(RVA = "0x3C7880", Offset = "0x3C6C80", VA = "0x103C7880", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06002297 RID: 8855 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002297")]
			[Address(RVA = "0x3C7760", Offset = "0x3C6B60", VA = "0x103C7760", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<ElementAssignmentConflictInfo> GetEnumerator()
			{
				return null;
			}

			// Token: 0x06002298 RID: 8856 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002298")]
			[Address(RVA = "0x3C7760", Offset = "0x3C6B60", VA = "0x103C7760", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x04002356 RID: 9046
			[Token(Token = "0x4002356")]
			[FieldOffset(Offset = "0x8")]
			private int <>1__state;

			// Token: 0x04002357 RID: 9047
			[Token(Token = "0x4002357")]
			[FieldOffset(Offset = "0xC")]
			private ElementAssignmentConflictInfo <>2__current;

			// Token: 0x04002358 RID: 9048
			[Token(Token = "0x4002358")]
			[FieldOffset(Offset = "0x38")]
			private int <>l__initialThreadId;

			// Token: 0x04002359 RID: 9049
			[Token(Token = "0x4002359")]
			[FieldOffset(Offset = "0x3C")]
			private Player player;

			// Token: 0x0400235A RID: 9050
			[Token(Token = "0x400235A")]
			[FieldOffset(Offset = "0x40")]
			public Player <>3__player;

			// Token: 0x0400235B RID: 9051
			[Token(Token = "0x400235B")]
			[FieldOffset(Offset = "0x44")]
			private ControlMapper.InputMapping mapping;

			// Token: 0x0400235C RID: 9052
			[Token(Token = "0x400235C")]
			[FieldOffset(Offset = "0x48")]
			public ControlMapper.InputMapping <>3__mapping;

			// Token: 0x0400235D RID: 9053
			[Token(Token = "0x400235D")]
			[FieldOffset(Offset = "0x4C")]
			public ControlMapper <>4__this;

			// Token: 0x0400235E RID: 9054
			[Token(Token = "0x400235E")]
			[FieldOffset(Offset = "0x50")]
			private ElementAssignment assignment;

			// Token: 0x0400235F RID: 9055
			[Token(Token = "0x400235F")]
			[FieldOffset(Offset = "0x74")]
			public ElementAssignment <>3__assignment;

			// Token: 0x04002360 RID: 9056
			[Token(Token = "0x4002360")]
			[FieldOffset(Offset = "0x98")]
			private bool skipOtherPlayers;

			// Token: 0x04002361 RID: 9057
			[Token(Token = "0x4002361")]
			[FieldOffset(Offset = "0x99")]
			public bool <>3__skipOtherPlayers;

			// Token: 0x04002362 RID: 9058
			[Token(Token = "0x4002362")]
			[FieldOffset(Offset = "0x9C")]
			private ElementAssignmentConflictCheck <conflictCheck>5__2;

			// Token: 0x04002363 RID: 9059
			[Token(Token = "0x4002363")]
			[FieldOffset(Offset = "0xD4")]
			private IEnumerator<ElementAssignmentConflictInfo> <>7__wrap2;
		}

		// Token: 0x02000586 RID: 1414
		[Token(Token = "0x2000586")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private sealed class <>c__DisplayClass456_0
		{
			// Token: 0x06002299 RID: 8857 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002299")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public <>c__DisplayClass456_0()
			{
			}

			// Token: 0x0600229A RID: 8858 RVA: 0x0000A8A8 File Offset: 0x00008AA8
			[Token(Token = "0x600229A")]
			[Address(RVA = "0x3CA640", Offset = "0x3C9A40", VA = "0x103CA640")]
			internal bool <ShowSwapButton>b__0(ElementAssignmentConflictInfo x)
			{
				return default(bool);
			}

			// Token: 0x04002364 RID: 9060
			[Token(Token = "0x4002364")]
			[FieldOffset(Offset = "0x8")]
			public ActionElementMap aem;
		}
	}
}
