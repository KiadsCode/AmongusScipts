using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Rewired.Components;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Rewired.Integration.UnityUI
{
	// Token: 0x0200055A RID: 1370
	[Token(Token = "0x200055A")]
	[Attribute(Name = "AddComponentMenu", RVA = "0xE2370", Offset = "0xE1770")]
	public sealed class RewiredStandaloneInputModule : RewiredPointerInputModule
	{
		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06001FA4 RID: 8100 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001FA5 RID: 8101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700064C")]
		public InputManager_Base RewiredInputManager
		{
			[Token(Token = "0x6001FA4")]
			[Address(RVA = "0x278060", Offset = "0x277460", VA = "0x10278060")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FA5")]
			[Address(RVA = "0x2780B0", Offset = "0x2774B0", VA = "0x102780B0")]
			set
			{
			}
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x06001FA6 RID: 8102 RVA: 0x00009A38 File Offset: 0x00007C38
		// (set) Token: 0x06001FA7 RID: 8103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700064D")]
		public bool UseAllRewiredGamePlayers
		{
			[Token(Token = "0x6001FA6")]
			[Address(RVA = "0x437E60", Offset = "0x437260", VA = "0x10437E60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001FA7")]
			[Address(RVA = "0x500980", Offset = "0x4FFD80", VA = "0x10500980")]
			set
			{
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06001FA8 RID: 8104 RVA: 0x00009A50 File Offset: 0x00007C50
		// (set) Token: 0x06001FA9 RID: 8105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700064E")]
		public bool UseRewiredSystemPlayer
		{
			[Token(Token = "0x6001FA8")]
			[Address(RVA = "0x437F90", Offset = "0x437390", VA = "0x10437F90")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001FA9")]
			[Address(RVA = "0x5009B0", Offset = "0x4FFDB0", VA = "0x105009B0")]
			set
			{
			}
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06001FAA RID: 8106 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001FAB RID: 8107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700064F")]
		public int[] RewiredPlayerIds
		{
			[Token(Token = "0x6001FAA")]
			[Address(RVA = "0x500220", Offset = "0x4FF620", VA = "0x10500220")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FAB")]
			[Address(RVA = "0x500780", Offset = "0x4FFB80", VA = "0x10500780")]
			set
			{
			}
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x06001FAC RID: 8108 RVA: 0x00009A68 File Offset: 0x00007C68
		// (set) Token: 0x06001FAD RID: 8109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000650")]
		public bool UsePlayingPlayersOnly
		{
			[Token(Token = "0x6001FAC")]
			[Address(RVA = "0x5002A0", Offset = "0x4FF6A0", VA = "0x105002A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001FAD")]
			[Address(RVA = "0x5009A0", Offset = "0x4FFDA0", VA = "0x105009A0")]
			set
			{
			}
		}

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x06001FAE RID: 8110 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001FAF RID: 8111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000651")]
		public List<PlayerMouse> PlayerMice
		{
			[Token(Token = "0x6001FAE")]
			[Address(RVA = "0x5001C0", Offset = "0x4FF5C0", VA = "0x105001C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FAF")]
			[Address(RVA = "0x5006E0", Offset = "0x4FFAE0", VA = "0x105006E0")]
			set
			{
			}
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x06001FB0 RID: 8112 RVA: 0x00009A80 File Offset: 0x00007C80
		// (set) Token: 0x06001FB1 RID: 8113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000652")]
		public bool MoveOneElementPerAxisPress
		{
			[Token(Token = "0x6001FB0")]
			[Address(RVA = "0x5001B0", Offset = "0x4FF5B0", VA = "0x105001B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001FB1")]
			[Address(RVA = "0x5006D0", Offset = "0x4FFAD0", VA = "0x105006D0")]
			set
			{
			}
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06001FB2 RID: 8114 RVA: 0x00009A98 File Offset: 0x00007C98
		// (set) Token: 0x06001FB3 RID: 8115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000653")]
		public bool allowMouseInput
		{
			[Token(Token = "0x6001FB2")]
			[Address(RVA = "0x3F6740", Offset = "0x3F5B40", VA = "0x103F6740")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001FB3")]
			[Address(RVA = "0x3F67D0", Offset = "0x3F5BD0", VA = "0x103F67D0")]
			set
			{
			}
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06001FB4 RID: 8116 RVA: 0x00009AB0 File Offset: 0x00007CB0
		// (set) Token: 0x06001FB5 RID: 8117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000654")]
		public bool allowMouseInputIfTouchSupported
		{
			[Token(Token = "0x6001FB4")]
			[Address(RVA = "0x5002C0", Offset = "0x4FF6C0", VA = "0x105002C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001FB5")]
			[Address(RVA = "0x500B30", Offset = "0x4FFF30", VA = "0x10500B30")]
			set
			{
			}
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06001FB6 RID: 8118 RVA: 0x00009AC8 File Offset: 0x00007CC8
		// (set) Token: 0x06001FB7 RID: 8119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000655")]
		public bool allowTouchInput
		{
			[Token(Token = "0x6001FB6")]
			[Address(RVA = "0x5002D0", Offset = "0x4FF6D0", VA = "0x105002D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001FB7")]
			[Address(RVA = "0x500B40", Offset = "0x4FFF40", VA = "0x10500B40")]
			set
			{
			}
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06001FB8 RID: 8120 RVA: 0x00009AE0 File Offset: 0x00007CE0
		// (set) Token: 0x06001FB9 RID: 8121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000656")]
		public bool deselectIfBackgroundClicked
		{
			[Token(Token = "0x6001FB8")]
			[Address(RVA = "0x5002E0", Offset = "0x4FF6E0", VA = "0x105002E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001FB9")]
			[Address(RVA = "0x500C40", Offset = "0x500040", VA = "0x10500C40")]
			set
			{
			}
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06001FBA RID: 8122 RVA: 0x00009AF8 File Offset: 0x00007CF8
		// (set) Token: 0x06001FBB RID: 8123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000657")]
		private bool deselectBeforeSelecting
		{
			[Token(Token = "0x6001FBA")]
			[Address(RVA = "0x4CD5C0", Offset = "0x4CC9C0", VA = "0x104CD5C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001FBB")]
			[Address(RVA = "0x4CD610", Offset = "0x4CCA10", VA = "0x104CD610")]
			set
			{
			}
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06001FBC RID: 8124 RVA: 0x00009B10 File Offset: 0x00007D10
		// (set) Token: 0x06001FBD RID: 8125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000658")]
		public bool SetActionsById
		{
			[Token(Token = "0x6001FBC")]
			[Address(RVA = "0x500290", Offset = "0x4FF690", VA = "0x10500290")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001FBD")]
			[Address(RVA = "0x500810", Offset = "0x4FFC10", VA = "0x10500810")]
			set
			{
			}
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06001FBE RID: 8126 RVA: 0x00009B28 File Offset: 0x00007D28
		// (set) Token: 0x06001FBF RID: 8127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000659")]
		public int HorizontalActionId
		{
			[Token(Token = "0x6001FBE")]
			[Address(RVA = "0x3C1650", Offset = "0x3C0A50", VA = "0x103C1650")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001FBF")]
			[Address(RVA = "0x500580", Offset = "0x4FF980", VA = "0x10500580")]
			set
			{
			}
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06001FC0 RID: 8128 RVA: 0x00009B40 File Offset: 0x00007D40
		// (set) Token: 0x06001FC1 RID: 8129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700065A")]
		public int VerticalActionId
		{
			[Token(Token = "0x6001FC0")]
			[Address(RVA = "0x3C1700", Offset = "0x3C0B00", VA = "0x103C1700")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001FC1")]
			[Address(RVA = "0x5009D0", Offset = "0x4FFDD0", VA = "0x105009D0")]
			set
			{
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06001FC2 RID: 8130 RVA: 0x00009B58 File Offset: 0x00007D58
		// (set) Token: 0x06001FC3 RID: 8131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700065B")]
		public int SubmitActionId
		{
			[Token(Token = "0x6001FC2")]
			[Address(RVA = "0x3C1630", Offset = "0x3C0A30", VA = "0x103C1630")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001FC3")]
			[Address(RVA = "0x500830", Offset = "0x4FFC30", VA = "0x10500830")]
			set
			{
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06001FC4 RID: 8132 RVA: 0x00009B70 File Offset: 0x00007D70
		// (set) Token: 0x06001FC5 RID: 8133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700065C")]
		public int CancelActionId
		{
			[Token(Token = "0x6001FC4")]
			[Address(RVA = "0x3C1640", Offset = "0x3C0A40", VA = "0x103C1640")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001FC5")]
			[Address(RVA = "0x500430", Offset = "0x4FF830", VA = "0x10500430")]
			set
			{
			}
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x06001FC6 RID: 8134 RVA: 0x00009B88 File Offset: 0x00007D88
		[Token(Token = "0x1700065D")]
		protected override bool isMouseSupported
		{
			[Token(Token = "0x6001FC6")]
			[Address(RVA = "0x5002F0", Offset = "0x4FF6F0", VA = "0x105002F0", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x06001FC7 RID: 8135 RVA: 0x00009BA0 File Offset: 0x00007DA0
		[Token(Token = "0x1700065E")]
		private bool isTouchAllowed
		{
			[Token(Token = "0x6001FC7")]
			[Address(RVA = "0x5002D0", Offset = "0x4FF6D0", VA = "0x105002D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06001FC8 RID: 8136 RVA: 0x00009BB8 File Offset: 0x00007DB8
		// (set) Token: 0x06001FC9 RID: 8137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700065F")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0xE2D60", Offset = "0xE2160")]
		public bool allowActivationOnMobileDevice
		{
			[Token(Token = "0x6001FC8")]
			[Address(RVA = "0x5002B0", Offset = "0x4FF6B0", VA = "0x105002B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001FC9")]
			[Address(RVA = "0x500B20", Offset = "0x4FFF20", VA = "0x10500B20")]
			set
			{
			}
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06001FCA RID: 8138 RVA: 0x00009BD0 File Offset: 0x00007DD0
		// (set) Token: 0x06001FCB RID: 8139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000660")]
		public bool forceModuleActive
		{
			[Token(Token = "0x6001FCA")]
			[Address(RVA = "0x5002B0", Offset = "0x4FF6B0", VA = "0x105002B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001FCB")]
			[Address(RVA = "0x500B20", Offset = "0x4FFF20", VA = "0x10500B20")]
			set
			{
			}
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x06001FCC RID: 8140 RVA: 0x00009BE8 File Offset: 0x00007DE8
		// (set) Token: 0x06001FCD RID: 8141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000661")]
		public float inputActionsPerSecond
		{
			[Token(Token = "0x6001FCC")]
			[Address(RVA = "0x437920", Offset = "0x436D20", VA = "0x10437920")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001FCD")]
			[Address(RVA = "0x438390", Offset = "0x437790", VA = "0x10438390")]
			set
			{
			}
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x06001FCE RID: 8142 RVA: 0x00009C00 File Offset: 0x00007E00
		// (set) Token: 0x06001FCF RID: 8143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000662")]
		public float repeatDelay
		{
			[Token(Token = "0x6001FCE")]
			[Address(RVA = "0x437E00", Offset = "0x437200", VA = "0x10437E00")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001FCF")]
			[Address(RVA = "0x438840", Offset = "0x437C40", VA = "0x10438840")]
			set
			{
			}
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x06001FD0 RID: 8144 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001FD1 RID: 8145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000663")]
		public string horizontalAxis
		{
			[Token(Token = "0x6001FD0")]
			[Address(RVA = "0x3C1670", Offset = "0x3C0A70", VA = "0x103C1670")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FD1")]
			[Address(RVA = "0x500C50", Offset = "0x500050", VA = "0x10500C50")]
			set
			{
			}
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x06001FD2 RID: 8146 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001FD3 RID: 8147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000664")]
		public string verticalAxis
		{
			[Token(Token = "0x6001FD2")]
			[Address(RVA = "0x3C1710", Offset = "0x3C0B10", VA = "0x103C1710")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FD3")]
			[Address(RVA = "0x500E30", Offset = "0x500230", VA = "0x10500E30")]
			set
			{
			}
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06001FD4 RID: 8148 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001FD5 RID: 8149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000665")]
		public string submitButton
		{
			[Token(Token = "0x6001FD4")]
			[Address(RVA = "0x3C1660", Offset = "0x3C0A60", VA = "0x103C1660")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FD5")]
			[Address(RVA = "0x500D40", Offset = "0x500140", VA = "0x10500D40")]
			set
			{
			}
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x06001FD6 RID: 8150 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001FD7 RID: 8151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000666")]
		public string cancelButton
		{
			[Token(Token = "0x6001FD6")]
			[Address(RVA = "0x3C1680", Offset = "0x3C0A80", VA = "0x103C1680")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FD7")]
			[Address(RVA = "0x500B50", Offset = "0x4FFF50", VA = "0x10500B50")]
			set
			{
			}
		}

		// Token: 0x06001FD8 RID: 8152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FD8")]
		[Address(RVA = "0x500020", Offset = "0x4FF420", VA = "0x10500020")]
		private RewiredStandaloneInputModule()
		{
		}

		// Token: 0x06001FD9 RID: 8153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FD9")]
		[Address(RVA = "0x4FB420", Offset = "0x4FA820", VA = "0x104FB420", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06001FDA RID: 8154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FDA")]
		[Address(RVA = "0x4FFEC0", Offset = "0x4FF2C0", VA = "0x104FFEC0", Slot = "24")]
		public override void UpdateModule()
		{
		}

		// Token: 0x06001FDB RID: 8155 RVA: 0x00009C18 File Offset: 0x00007E18
		[Token(Token = "0x6001FDB")]
		[Address(RVA = "0x2EDC10", Offset = "0x2ED010", VA = "0x102EDC10", Slot = "25")]
		public override bool IsModuleSupported()
		{
			return default(bool);
		}

		// Token: 0x06001FDC RID: 8156 RVA: 0x00009C30 File Offset: 0x00007E30
		[Token(Token = "0x6001FDC")]
		[Address(RVA = "0x4FF6D0", Offset = "0x4FEAD0", VA = "0x104FF6D0", Slot = "21")]
		public override bool ShouldActivateModule()
		{
			return default(bool);
		}

		// Token: 0x06001FDD RID: 8157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FDD")]
		[Address(RVA = "0x4FB360", Offset = "0x4FA760", VA = "0x104FB360", Slot = "23")]
		public override void ActivateModule()
		{
		}

		// Token: 0x06001FDE RID: 8158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FDE")]
		[Address(RVA = "0x4FB810", Offset = "0x4FAC10", VA = "0x104FB810", Slot = "22")]
		public override void DeactivateModule()
		{
		}

		// Token: 0x06001FDF RID: 8159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FDF")]
		[Address(RVA = "0x4FE200", Offset = "0x4FD600", VA = "0x104FE200", Slot = "17")]
		public override void Process()
		{
		}

		// Token: 0x06001FE0 RID: 8160 RVA: 0x00009C48 File Offset: 0x00007E48
		[Token(Token = "0x6001FE0")]
		[Address(RVA = "0x4FD100", Offset = "0x4FC500", VA = "0x104FD100")]
		private bool ProcessTouchEvents()
		{
			return default(bool);
		}

		// Token: 0x06001FE1 RID: 8161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FE1")]
		[Address(RVA = "0x4FDAF0", Offset = "0x4FCEF0", VA = "0x104FDAF0")]
		private void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released)
		{
		}

		// Token: 0x06001FE2 RID: 8162 RVA: 0x00009C60 File Offset: 0x00007E60
		[Token(Token = "0x6001FE2")]
		[Address(RVA = "0x4FE8E0", Offset = "0x4FDCE0", VA = "0x104FE8E0")]
		private bool SendSubmitEventToSelectedObject()
		{
			return default(bool);
		}

		// Token: 0x06001FE3 RID: 8163 RVA: 0x00009C78 File Offset: 0x00007E78
		[Token(Token = "0x6001FE3")]
		[Address(RVA = "0x4FBC00", Offset = "0x4FB000", VA = "0x104FBC00")]
		private Vector2 GetRawMoveVector()
		{
			return default(Vector2);
		}

		// Token: 0x06001FE4 RID: 8164 RVA: 0x00009C90 File Offset: 0x00007E90
		[Token(Token = "0x6001FE4")]
		[Address(RVA = "0x4FE590", Offset = "0x4FD990", VA = "0x104FE590")]
		private bool SendMoveEventToSelectedObject()
		{
			return default(bool);
		}

		// Token: 0x06001FE5 RID: 8165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FE5")]
		[Address(RVA = "0x4FB590", Offset = "0x4FA990", VA = "0x104FB590")]
		private void CheckButtonOrKeyMovement(out bool downHorizontal, out bool downVertical)
		{
		}

		// Token: 0x06001FE6 RID: 8166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FE6")]
		[Address(RVA = "0x4FCA00", Offset = "0x4FBE00", VA = "0x104FCA00")]
		private void ProcessMouseEvents()
		{
		}

		// Token: 0x06001FE7 RID: 8167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FE7")]
		[Address(RVA = "0x4FC670", Offset = "0x4FBA70", VA = "0x104FC670")]
		private void ProcessMouseEvent(int playerId, int pointerIndex)
		{
		}

		// Token: 0x06001FE8 RID: 8168 RVA: 0x00009CA8 File Offset: 0x00007EA8
		[Token(Token = "0x6001FE8")]
		[Address(RVA = "0x4FEB10", Offset = "0x4FDF10", VA = "0x104FEB10")]
		private bool SendUpdateEventToSelectedObject()
		{
			return default(bool);
		}

		// Token: 0x06001FE9 RID: 8169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FE9")]
		[Address(RVA = "0x4FCB20", Offset = "0x4FBF20", VA = "0x104FCB20")]
		private void ProcessMousePress(RewiredPointerInputModule.MouseButtonEventData data)
		{
		}

		// Token: 0x06001FEA RID: 8170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FEA")]
		[Address(RVA = "0x4FBF90", Offset = "0x4FB390", VA = "0x104FBF90")]
		private void HandleMouseTouchDeselectionOnSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent)
		{
		}

		// Token: 0x06001FEB RID: 8171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FEB")]
		[Address(RVA = "0x4FC520", Offset = "0x4FB920", VA = "0x104FC520")]
		private void OnApplicationFocus(bool hasFocus)
		{
		}

		// Token: 0x06001FEC RID: 8172 RVA: 0x00009CC0 File Offset: 0x00007EC0
		[Token(Token = "0x6001FEC")]
		[Address(RVA = "0x4FFDF0", Offset = "0x4FF1F0", VA = "0x104FFDF0")]
		private bool ShouldIgnoreEventsOnNoFocus()
		{
			return default(bool);
		}

		// Token: 0x06001FED RID: 8173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FED")]
		[Address(RVA = "0x4FC540", Offset = "0x4FB940", VA = "0x104FC540", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06001FEE RID: 8174 RVA: 0x00009CD8 File Offset: 0x00007ED8
		[Token(Token = "0x6001FEE")]
		[Address(RVA = "0x4FC380", Offset = "0x4FB780", VA = "0x104FC380", Slot = "27")]
		protected override bool IsDefaultPlayer(int playerId)
		{
			return default(bool);
		}

		// Token: 0x06001FEF RID: 8175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FEF")]
		[Address(RVA = "0x4FC1C0", Offset = "0x4FB5C0", VA = "0x104FC1C0")]
		private void InitializeRewired()
		{
		}

		// Token: 0x06001FF0 RID: 8176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FF0")]
		[Address(RVA = "0x4FF0B0", Offset = "0x4FE4B0", VA = "0x104FF0B0")]
		private void SetupRewiredVars()
		{
		}

		// Token: 0x06001FF1 RID: 8177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FF1")]
		[Address(RVA = "0x4FEF10", Offset = "0x4FE310", VA = "0x104FEF10")]
		private void SetUpRewiredPlayerMice()
		{
		}

		// Token: 0x06001FF2 RID: 8178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FF2")]
		[Address(RVA = "0x4FEC50", Offset = "0x4FE050", VA = "0x104FEC50")]
		private void SetUpRewiredActions()
		{
		}

		// Token: 0x06001FF3 RID: 8179 RVA: 0x00009CF0 File Offset: 0x00007EF0
		[Token(Token = "0x6001FF3")]
		[Address(RVA = "0x4FBA10", Offset = "0x4FAE10", VA = "0x104FBA10")]
		private bool GetButton(Player player, int actionId)
		{
			return default(bool);
		}

		// Token: 0x06001FF4 RID: 8180 RVA: 0x00009D08 File Offset: 0x00007F08
		[Token(Token = "0x6001FF4")]
		[Address(RVA = "0x4FB9E0", Offset = "0x4FADE0", VA = "0x104FB9E0")]
		private bool GetButtonDown(Player player, int actionId)
		{
			return default(bool);
		}

		// Token: 0x06001FF5 RID: 8181 RVA: 0x00009D20 File Offset: 0x00007F20
		[Token(Token = "0x6001FF5")]
		[Address(RVA = "0x4FBBD0", Offset = "0x4FAFD0", VA = "0x104FBBD0")]
		private bool GetNegativeButton(Player player, int actionId)
		{
			return default(bool);
		}

		// Token: 0x06001FF6 RID: 8182 RVA: 0x00009D38 File Offset: 0x00007F38
		[Token(Token = "0x6001FF6")]
		[Address(RVA = "0x4FBBA0", Offset = "0x4FAFA0", VA = "0x104FBBA0")]
		private bool GetNegativeButtonDown(Player player, int actionId)
		{
			return default(bool);
		}

		// Token: 0x06001FF7 RID: 8183 RVA: 0x00009D50 File Offset: 0x00007F50
		[Token(Token = "0x6001FF7")]
		[Address(RVA = "0x4FB9B0", Offset = "0x4FADB0", VA = "0x104FB9B0")]
		private float GetAxis(Player player, int actionId)
		{
			return 0f;
		}

		// Token: 0x06001FF8 RID: 8184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FF8")]
		[Address(RVA = "0x4FB700", Offset = "0x4FAB00", VA = "0x104FB700")]
		private void CheckEditorRecompile()
		{
		}

		// Token: 0x06001FF9 RID: 8185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FF9")]
		[Address(RVA = "0x4FC630", Offset = "0x4FBA30", VA = "0x104FC630")]
		private void OnEditorRecompile()
		{
		}

		// Token: 0x06001FFA RID: 8186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FFA")]
		[Address(RVA = "0x4FB7B0", Offset = "0x4FABB0", VA = "0x104FB7B0")]
		private void ClearRewiredVars()
		{
		}

		// Token: 0x06001FFB RID: 8187 RVA: 0x00009D68 File Offset: 0x00007F68
		[Token(Token = "0x6001FFB")]
		[Address(RVA = "0x4FB830", Offset = "0x4FAC30", VA = "0x104FB830")]
		private bool DidAnyMouseMove()
		{
			return default(bool);
		}

		// Token: 0x06001FFC RID: 8188 RVA: 0x00009D80 File Offset: 0x00007F80
		[Token(Token = "0x6001FFC")]
		[Address(RVA = "0x4FBA40", Offset = "0x4FAE40", VA = "0x104FBA40")]
		private bool GetMouseButtonDownOnAnyMouse(int buttonIndex)
		{
			return default(bool);
		}

		// Token: 0x06001FFD RID: 8189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FFD")]
		[Address(RVA = "0x4FC650", Offset = "0x4FBA50", VA = "0x104FC650")]
		private void OnRewiredInitialized()
		{
		}

		// Token: 0x06001FFE RID: 8190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FFE")]
		[Address(RVA = "0x4FC660", Offset = "0x4FBA60", VA = "0x104FC660")]
		private void OnRewiredShutDown()
		{
		}

		// Token: 0x040021EE RID: 8686
		[Token(Token = "0x40021EE")]
		private const string DEFAULT_ACTION_MOVE_HORIZONTAL = "UIHorizontal";

		// Token: 0x040021EF RID: 8687
		[Token(Token = "0x40021EF")]
		private const string DEFAULT_ACTION_MOVE_VERTICAL = "UIVertical";

		// Token: 0x040021F0 RID: 8688
		[Token(Token = "0x40021F0")]
		private const string DEFAULT_ACTION_SUBMIT = "UISubmit";

		// Token: 0x040021F1 RID: 8689
		[Token(Token = "0x40021F1")]
		private const string DEFAULT_ACTION_CANCEL = "UICancel";

		// Token: 0x040021F2 RID: 8690
		[Token(Token = "0x40021F2")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE23A0", Offset = "0xE17A0")]
		[SerializeField]
		private InputManager_Base rewiredInputManager;

		// Token: 0x040021F3 RID: 8691
		[Token(Token = "0x40021F3")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE23E0", Offset = "0xE17E0")]
		private bool useAllRewiredGamePlayers;

		// Token: 0x040021F4 RID: 8692
		[Token(Token = "0x40021F4")]
		[FieldOffset(Offset = "0x3D")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE2420", Offset = "0xE1820")]
		private bool useRewiredSystemPlayer;

		// Token: 0x040021F5 RID: 8693
		[Token(Token = "0x40021F5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE2460", Offset = "0xE1860")]
		private int[] rewiredPlayerIds;

		// Token: 0x040021F6 RID: 8694
		[Token(Token = "0x40021F6")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE24A0", Offset = "0xE18A0")]
		[SerializeField]
		private bool usePlayingPlayersOnly;

		// Token: 0x040021F7 RID: 8695
		[Token(Token = "0x40021F7")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE24E0", Offset = "0xE18E0")]
		private List<PlayerMouse> playerMice;

		// Token: 0x040021F8 RID: 8696
		[Token(Token = "0x40021F8")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE2570", Offset = "0xE1970")]
		private bool moveOneElementPerAxisPress;

		// Token: 0x040021F9 RID: 8697
		[Token(Token = "0x40021F9")]
		[FieldOffset(Offset = "0x4D")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE25B0", Offset = "0xE19B0")]
		private bool setActionsById;

		// Token: 0x040021FA RID: 8698
		[Token(Token = "0x40021FA")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE2640", Offset = "0xE1A40")]
		[SerializeField]
		private int horizontalActionId;

		// Token: 0x040021FB RID: 8699
		[Token(Token = "0x40021FB")]
		[FieldOffset(Offset = "0x54")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE2680", Offset = "0xE1A80")]
		[SerializeField]
		private int verticalActionId;

		// Token: 0x040021FC RID: 8700
		[Token(Token = "0x40021FC")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE26C0", Offset = "0xE1AC0")]
		[SerializeField]
		private int submitActionId;

		// Token: 0x040021FD RID: 8701
		[Token(Token = "0x40021FD")]
		[FieldOffset(Offset = "0x5C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE2700", Offset = "0xE1B00")]
		[SerializeField]
		private int cancelActionId;

		// Token: 0x040021FE RID: 8702
		[Token(Token = "0x40021FE")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE2790", Offset = "0xE1B90")]
		private string m_HorizontalAxis;

		// Token: 0x040021FF RID: 8703
		[Token(Token = "0x40021FF")]
		[FieldOffset(Offset = "0x64")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE27D0", Offset = "0xE1BD0")]
		[SerializeField]
		private string m_VerticalAxis;

		// Token: 0x04002200 RID: 8704
		[Token(Token = "0x4002200")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE2810", Offset = "0xE1C10")]
		[SerializeField]
		private string m_SubmitButton;

		// Token: 0x04002201 RID: 8705
		[Token(Token = "0x4002201")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE2850", Offset = "0xE1C50")]
		private string m_CancelButton;

		// Token: 0x04002202 RID: 8706
		[Token(Token = "0x4002202")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE2890", Offset = "0xE1C90")]
		[SerializeField]
		private float m_InputActionsPerSecond;

		// Token: 0x04002203 RID: 8707
		[Token(Token = "0x4002203")]
		[FieldOffset(Offset = "0x74")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE2920", Offset = "0xE1D20")]
		[SerializeField]
		private float m_RepeatDelay;

		// Token: 0x04002204 RID: 8708
		[Token(Token = "0x4002204")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE29B0", Offset = "0xE1DB0")]
		[SerializeField]
		private bool m_allowMouseInput;

		// Token: 0x04002205 RID: 8709
		[Token(Token = "0x4002205")]
		[FieldOffset(Offset = "0x79")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE2A40", Offset = "0xE1E40")]
		[SerializeField]
		private bool m_allowMouseInputIfTouchSupported;

		// Token: 0x04002206 RID: 8710
		[Token(Token = "0x4002206")]
		[FieldOffset(Offset = "0x7A")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE2AD0", Offset = "0xE1ED0")]
		[SerializeField]
		private bool m_allowTouchInput;

		// Token: 0x04002207 RID: 8711
		[Token(Token = "0x4002207")]
		[FieldOffset(Offset = "0x7B")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE2B60", Offset = "0xE1F60")]
		[SerializeField]
		private bool m_deselectIfBackgroundClicked;

		// Token: 0x04002208 RID: 8712
		[Token(Token = "0x4002208")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE2BF0", Offset = "0xE1FF0")]
		private bool m_deselectBeforeSelecting;

		// Token: 0x04002209 RID: 8713
		[Token(Token = "0x4002209")]
		[FieldOffset(Offset = "0x7D")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE2C30", Offset = "0xE2030")]
		[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0xE2C30", Offset = "0xE2030")]
		[SerializeField]
		private bool m_ForceModuleActive;

		// Token: 0x0400220A RID: 8714
		[Token(Token = "0x400220A")]
		[FieldOffset(Offset = "0x80")]
		[NonSerialized]
		private int[] playerIds;

		// Token: 0x0400220B RID: 8715
		[Token(Token = "0x400220B")]
		[FieldOffset(Offset = "0x84")]
		private bool recompiling;

		// Token: 0x0400220C RID: 8716
		[Token(Token = "0x400220C")]
		[FieldOffset(Offset = "0x85")]
		[NonSerialized]
		private bool isTouchSupported;

		// Token: 0x0400220D RID: 8717
		[Token(Token = "0x400220D")]
		[FieldOffset(Offset = "0x88")]
		[NonSerialized]
		private double m_PrevActionTime;

		// Token: 0x0400220E RID: 8718
		[Token(Token = "0x400220E")]
		[FieldOffset(Offset = "0x90")]
		[NonSerialized]
		private Vector2 m_LastMoveVector;

		// Token: 0x0400220F RID: 8719
		[Token(Token = "0x400220F")]
		[FieldOffset(Offset = "0x98")]
		[NonSerialized]
		private int m_ConsecutiveMoveCount;

		// Token: 0x04002210 RID: 8720
		[Token(Token = "0x4002210")]
		[FieldOffset(Offset = "0x9C")]
		[NonSerialized]
		private bool m_HasFocus;

		// Token: 0x0200055B RID: 1371
		[Token(Token = "0x200055B")]
		[Serializable]
		public class PlayerSetting
		{
			// Token: 0x06001FFF RID: 8191 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001FFF")]
			[Address(RVA = "0x364D30", Offset = "0x364130", VA = "0x10364D30")]
			public PlayerSetting()
			{
			}

			// Token: 0x06002000 RID: 8192 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002000")]
			[Address(RVA = "0x364D90", Offset = "0x364190", VA = "0x10364D90")]
			private PlayerSetting(RewiredStandaloneInputModule.PlayerSetting other)
			{
			}

			// Token: 0x06002001 RID: 8193 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002001")]
			[Address(RVA = "0x364CE0", Offset = "0x3640E0", VA = "0x10364CE0")]
			public RewiredStandaloneInputModule.PlayerSetting Clone()
			{
				return null;
			}

			// Token: 0x04002211 RID: 8721
			[Token(Token = "0x4002211")]
			[FieldOffset(Offset = "0x8")]
			public int playerId;

			// Token: 0x04002212 RID: 8722
			[Token(Token = "0x4002212")]
			[FieldOffset(Offset = "0xC")]
			public List<PlayerMouse> playerMice;
		}
	}
}
