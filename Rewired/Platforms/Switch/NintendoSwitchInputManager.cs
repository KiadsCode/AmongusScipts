using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Rewired.Utils.Interfaces;
using UnityEngine;

namespace Rewired.Platforms.Switch
{
	// Token: 0x02000543 RID: 1347
	[Token(Token = "0x2000543")]
	[Attribute(Name = "RequireComponent", RVA = "0xE1860", Offset = "0xE0C60")]
	[Attribute(Name = "AddComponentMenu", RVA = "0xE1860", Offset = "0xE0C60")]
	public sealed class NintendoSwitchInputManager : MonoBehaviour, IExternalInputManager
	{
		// Token: 0x06001E41 RID: 7745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E41")]
		[Address(RVA = "0x394F70", Offset = "0x394370", VA = "0x10394F70", Slot = "4")]
		private object Initialize(Platform platform, object configVars)
		{
			return null;
		}

		// Token: 0x06001E42 RID: 7746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E42")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		private void Deinitialize()
		{
		}

		// Token: 0x06001E43 RID: 7747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E43")]
		[Address(RVA = "0x777C70", Offset = "0x777070", VA = "0x10777C70")]
		public NintendoSwitchInputManager()
		{
		}

		// Token: 0x0400218D RID: 8589
		[Token(Token = "0x400218D")]
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		private NintendoSwitchInputManager.UserData _userData;

		// Token: 0x02000544 RID: 1348
		[Token(Token = "0x2000544")]
		[Serializable]
		private class UserData : IKeyedData<int>
		{
			// Token: 0x1700060A RID: 1546
			// (get) Token: 0x06001E44 RID: 7748 RVA: 0x00008D48 File Offset: 0x00006F48
			// (set) Token: 0x06001E45 RID: 7749 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700060A")]
			public int allowedNpadStyles
			{
				[Token(Token = "0x6001E44")]
				[Address(RVA = "0x273EB0", Offset = "0x2732B0", VA = "0x10273EB0")]
				get
				{
					return 0;
				}
				[Token(Token = "0x6001E45")]
				[Address(RVA = "0x273EF0", Offset = "0x2732F0", VA = "0x10273EF0")]
				set
				{
				}
			}

			// Token: 0x1700060B RID: 1547
			// (get) Token: 0x06001E46 RID: 7750 RVA: 0x00008D60 File Offset: 0x00006F60
			// (set) Token: 0x06001E47 RID: 7751 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700060B")]
			public int joyConGripStyle
			{
				[Token(Token = "0x6001E46")]
				[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90")]
				get
				{
					return 0;
				}
				[Token(Token = "0x6001E47")]
				[Address(RVA = "0x273ED0", Offset = "0x2732D0", VA = "0x10273ED0")]
				set
				{
				}
			}

			// Token: 0x1700060C RID: 1548
			// (get) Token: 0x06001E48 RID: 7752 RVA: 0x00008D78 File Offset: 0x00006F78
			// (set) Token: 0x06001E49 RID: 7753 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700060C")]
			public bool adjustIMUsForGripStyle
			{
				[Token(Token = "0x6001E48")]
				[Address(RVA = "0x274CF0", Offset = "0x2740F0", VA = "0x10274CF0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6001E49")]
				[Address(RVA = "0x274D00", Offset = "0x274100", VA = "0x10274D00")]
				set
				{
				}
			}

			// Token: 0x1700060D RID: 1549
			// (get) Token: 0x06001E4A RID: 7754 RVA: 0x00008D90 File Offset: 0x00006F90
			// (set) Token: 0x06001E4B RID: 7755 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700060D")]
			public int handheldActivationMode
			{
				[Token(Token = "0x6001E4A")]
				[Address(RVA = "0x273EA0", Offset = "0x2732A0", VA = "0x10273EA0")]
				get
				{
					return 0;
				}
				[Token(Token = "0x6001E4B")]
				[Address(RVA = "0x273EE0", Offset = "0x2732E0", VA = "0x10273EE0")]
				set
				{
				}
			}

			// Token: 0x1700060E RID: 1550
			// (get) Token: 0x06001E4C RID: 7756 RVA: 0x00008DA8 File Offset: 0x00006FA8
			// (set) Token: 0x06001E4D RID: 7757 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700060E")]
			public bool assignJoysticksByNpadId
			{
				[Token(Token = "0x6001E4C")]
				[Address(RVA = "0x280880", Offset = "0x27FC80", VA = "0x10280880")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6001E4D")]
				[Address(RVA = "0x280890", Offset = "0x27FC90", VA = "0x10280890")]
				set
				{
				}
			}

			// Token: 0x1700060F RID: 1551
			// (get) Token: 0x06001E4E RID: 7758 RVA: 0x00008DC0 File Offset: 0x00006FC0
			// (set) Token: 0x06001E4F RID: 7759 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700060F")]
			public bool useVibrationThread
			{
				[Token(Token = "0x6001E4E")]
				[Address(RVA = "0x4F2E80", Offset = "0x4F2280", VA = "0x104F2E80")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6001E4F")]
				[Address(RVA = "0x39BA70", Offset = "0x39AE70", VA = "0x1039BA70")]
				set
				{
				}
			}

			// Token: 0x17000610 RID: 1552
			// (get) Token: 0x06001E50 RID: 7760 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000610")]
			private NintendoSwitchInputManager.NpadSettings_Internal npadNo1
			{
				[Token(Token = "0x6001E50")]
				[Address(RVA = "0x277A40", Offset = "0x276E40", VA = "0x10277A40")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000611 RID: 1553
			// (get) Token: 0x06001E51 RID: 7761 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000611")]
			private NintendoSwitchInputManager.NpadSettings_Internal npadNo2
			{
				[Token(Token = "0x6001E51")]
				[Address(RVA = "0x287A00", Offset = "0x286E00", VA = "0x10287A00")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000612 RID: 1554
			// (get) Token: 0x06001E52 RID: 7762 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000612")]
			private NintendoSwitchInputManager.NpadSettings_Internal npadNo3
			{
				[Token(Token = "0x6001E52")]
				[Address(RVA = "0x292AA0", Offset = "0x291EA0", VA = "0x10292AA0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000613 RID: 1555
			// (get) Token: 0x06001E53 RID: 7763 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000613")]
			private NintendoSwitchInputManager.NpadSettings_Internal npadNo4
			{
				[Token(Token = "0x6001E53")]
				[Address(RVA = "0x2D5F80", Offset = "0x2D5380", VA = "0x102D5F80")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000614 RID: 1556
			// (get) Token: 0x06001E54 RID: 7764 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000614")]
			private NintendoSwitchInputManager.NpadSettings_Internal npadNo5
			{
				[Token(Token = "0x6001E54")]
				[Address(RVA = "0x2D8D90", Offset = "0x2D8190", VA = "0x102D8D90")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000615 RID: 1557
			// (get) Token: 0x06001E55 RID: 7765 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000615")]
			private NintendoSwitchInputManager.NpadSettings_Internal npadNo6
			{
				[Token(Token = "0x6001E55")]
				[Address(RVA = "0x298EF0", Offset = "0x2982F0", VA = "0x10298EF0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000616 RID: 1558
			// (get) Token: 0x06001E56 RID: 7766 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000616")]
			private NintendoSwitchInputManager.NpadSettings_Internal npadNo7
			{
				[Token(Token = "0x6001E56")]
				[Address(RVA = "0x328160", Offset = "0x327560", VA = "0x10328160")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000617 RID: 1559
			// (get) Token: 0x06001E57 RID: 7767 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000617")]
			private NintendoSwitchInputManager.NpadSettings_Internal npadNo8
			{
				[Token(Token = "0x6001E57")]
				[Address(RVA = "0x278060", Offset = "0x277460", VA = "0x10278060")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000618 RID: 1560
			// (get) Token: 0x06001E58 RID: 7768 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000618")]
			private NintendoSwitchInputManager.NpadSettings_Internal npadHandheld
			{
				[Token(Token = "0x6001E58")]
				[Address(RVA = "0x328190", Offset = "0x327590", VA = "0x10328190")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000619 RID: 1561
			// (get) Token: 0x06001E59 RID: 7769 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000619")]
			public NintendoSwitchInputManager.DebugPadSettings_Internal debugPad
			{
				[Token(Token = "0x6001E59")]
				[Address(RVA = "0x2786E0", Offset = "0x277AE0", VA = "0x102786E0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700061A RID: 1562
			// (get) Token: 0x06001E5A RID: 7770 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700061A")]
			private Dictionary<int, object[]> delegates
			{
				[Token(Token = "0x6001E5A")]
				[Address(RVA = "0x79CDA0", Offset = "0x79C1A0", VA = "0x1079CDA0")]
				get
				{
					return null;
				}
			}

			// Token: 0x06001E5B RID: 7771 RVA: 0x00008DD8 File Offset: 0x00006FD8
			[Token(Token = "0x6001E5B")]
			private bool TryGetValue<T>(int key, out T value)
			{
				return default(bool);
			}

			// Token: 0x06001E5C RID: 7772 RVA: 0x00008DF0 File Offset: 0x00006FF0
			[Token(Token = "0x6001E5C")]
			private bool TrySetValue<T>(int key, T value)
			{
				return default(bool);
			}

			// Token: 0x06001E5D RID: 7773 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001E5D")]
			[Address(RVA = "0x79CBA0", Offset = "0x79BFA0", VA = "0x1079CBA0")]
			public UserData()
			{
			}

			// Token: 0x06001E5E RID: 7774 RVA: 0x00008E08 File Offset: 0x00007008
			[Token(Token = "0x6001E5E")]
			[Address(RVA = "0x273EB0", Offset = "0x2732B0", VA = "0x10273EB0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private int <get_delegates>b__56_0()
			{
				return 0;
			}

			// Token: 0x06001E5F RID: 7775 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001E5F")]
			[Address(RVA = "0x273EF0", Offset = "0x2732F0", VA = "0x10273EF0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private void <get_delegates>b__56_1(int x)
			{
			}

			// Token: 0x06001E60 RID: 7776 RVA: 0x00008E20 File Offset: 0x00007020
			[Token(Token = "0x6001E60")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private int <get_delegates>b__56_2()
			{
				return 0;
			}

			// Token: 0x06001E61 RID: 7777 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001E61")]
			[Address(RVA = "0x273ED0", Offset = "0x2732D0", VA = "0x10273ED0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private void <get_delegates>b__56_3(int x)
			{
			}

			// Token: 0x06001E62 RID: 7778 RVA: 0x00008E38 File Offset: 0x00007038
			[Token(Token = "0x6001E62")]
			[Address(RVA = "0x274CF0", Offset = "0x2740F0", VA = "0x10274CF0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private bool <get_delegates>b__56_4()
			{
				return default(bool);
			}

			// Token: 0x06001E63 RID: 7779 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001E63")]
			[Address(RVA = "0x274D00", Offset = "0x274100", VA = "0x10274D00")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private void <get_delegates>b__56_5(bool x)
			{
			}

			// Token: 0x06001E64 RID: 7780 RVA: 0x00008E50 File Offset: 0x00007050
			[Token(Token = "0x6001E64")]
			[Address(RVA = "0x273EA0", Offset = "0x2732A0", VA = "0x10273EA0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private int <get_delegates>b__56_6()
			{
				return 0;
			}

			// Token: 0x06001E65 RID: 7781 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001E65")]
			[Address(RVA = "0x273EE0", Offset = "0x2732E0", VA = "0x10273EE0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private void <get_delegates>b__56_7(int x)
			{
			}

			// Token: 0x06001E66 RID: 7782 RVA: 0x00008E68 File Offset: 0x00007068
			[Token(Token = "0x6001E66")]
			[Address(RVA = "0x280880", Offset = "0x27FC80", VA = "0x10280880")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private bool <get_delegates>b__56_8()
			{
				return default(bool);
			}

			// Token: 0x06001E67 RID: 7783 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001E67")]
			[Address(RVA = "0x280890", Offset = "0x27FC90", VA = "0x10280890")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private void <get_delegates>b__56_9(bool x)
			{
			}

			// Token: 0x06001E68 RID: 7784 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001E68")]
			[Address(RVA = "0x277A40", Offset = "0x276E40", VA = "0x10277A40")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private object <get_delegates>b__56_10()
			{
				return null;
			}

			// Token: 0x06001E69 RID: 7785 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001E69")]
			[Address(RVA = "0x287A00", Offset = "0x286E00", VA = "0x10287A00")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private object <get_delegates>b__56_11()
			{
				return null;
			}

			// Token: 0x06001E6A RID: 7786 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001E6A")]
			[Address(RVA = "0x292AA0", Offset = "0x291EA0", VA = "0x10292AA0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private object <get_delegates>b__56_12()
			{
				return null;
			}

			// Token: 0x06001E6B RID: 7787 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001E6B")]
			[Address(RVA = "0x2D5F80", Offset = "0x2D5380", VA = "0x102D5F80")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private object <get_delegates>b__56_13()
			{
				return null;
			}

			// Token: 0x06001E6C RID: 7788 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001E6C")]
			[Address(RVA = "0x2D8D90", Offset = "0x2D8190", VA = "0x102D8D90")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private object <get_delegates>b__56_14()
			{
				return null;
			}

			// Token: 0x06001E6D RID: 7789 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001E6D")]
			[Address(RVA = "0x298EF0", Offset = "0x2982F0", VA = "0x10298EF0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private object <get_delegates>b__56_15()
			{
				return null;
			}

			// Token: 0x06001E6E RID: 7790 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001E6E")]
			[Address(RVA = "0x328160", Offset = "0x327560", VA = "0x10328160")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private object <get_delegates>b__56_16()
			{
				return null;
			}

			// Token: 0x06001E6F RID: 7791 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001E6F")]
			[Address(RVA = "0x278060", Offset = "0x277460", VA = "0x10278060")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private object <get_delegates>b__56_17()
			{
				return null;
			}

			// Token: 0x06001E70 RID: 7792 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001E70")]
			[Address(RVA = "0x328190", Offset = "0x327590", VA = "0x10328190")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private object <get_delegates>b__56_18()
			{
				return null;
			}

			// Token: 0x06001E71 RID: 7793 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001E71")]
			[Address(RVA = "0x2786E0", Offset = "0x277AE0", VA = "0x102786E0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private object <get_delegates>b__56_19()
			{
				return null;
			}

			// Token: 0x06001E72 RID: 7794 RVA: 0x00008E80 File Offset: 0x00007080
			[Token(Token = "0x6001E72")]
			[Address(RVA = "0x4F2E80", Offset = "0x4F2280", VA = "0x104F2E80")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private bool <get_delegates>b__56_20()
			{
				return default(bool);
			}

			// Token: 0x06001E73 RID: 7795 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001E73")]
			[Address(RVA = "0x39BA70", Offset = "0x39AE70", VA = "0x1039BA70")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private void <get_delegates>b__56_21(bool x)
			{
			}

			// Token: 0x0400218E RID: 8590
			[Token(Token = "0x400218E")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			private int _allowedNpadStyles;

			// Token: 0x0400218F RID: 8591
			[Token(Token = "0x400218F")]
			[FieldOffset(Offset = "0xC")]
			[SerializeField]
			private int _joyConGripStyle;

			// Token: 0x04002190 RID: 8592
			[Token(Token = "0x4002190")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private bool _adjustIMUsForGripStyle;

			// Token: 0x04002191 RID: 8593
			[Token(Token = "0x4002191")]
			[FieldOffset(Offset = "0x14")]
			[SerializeField]
			private int _handheldActivationMode;

			// Token: 0x04002192 RID: 8594
			[Token(Token = "0x4002192")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private bool _assignJoysticksByNpadId;

			// Token: 0x04002193 RID: 8595
			[Token(Token = "0x4002193")]
			[FieldOffset(Offset = "0x19")]
			[SerializeField]
			private bool _useVibrationThread;

			// Token: 0x04002194 RID: 8596
			[Token(Token = "0x4002194")]
			[FieldOffset(Offset = "0x1C")]
			[SerializeField]
			private NintendoSwitchInputManager.NpadSettings_Internal _npadNo1;

			// Token: 0x04002195 RID: 8597
			[Token(Token = "0x4002195")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private NintendoSwitchInputManager.NpadSettings_Internal _npadNo2;

			// Token: 0x04002196 RID: 8598
			[Token(Token = "0x4002196")]
			[FieldOffset(Offset = "0x24")]
			[SerializeField]
			private NintendoSwitchInputManager.NpadSettings_Internal _npadNo3;

			// Token: 0x04002197 RID: 8599
			[Token(Token = "0x4002197")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private NintendoSwitchInputManager.NpadSettings_Internal _npadNo4;

			// Token: 0x04002198 RID: 8600
			[Token(Token = "0x4002198")]
			[FieldOffset(Offset = "0x2C")]
			[SerializeField]
			private NintendoSwitchInputManager.NpadSettings_Internal _npadNo5;

			// Token: 0x04002199 RID: 8601
			[Token(Token = "0x4002199")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private NintendoSwitchInputManager.NpadSettings_Internal _npadNo6;

			// Token: 0x0400219A RID: 8602
			[Token(Token = "0x400219A")]
			[FieldOffset(Offset = "0x34")]
			[SerializeField]
			private NintendoSwitchInputManager.NpadSettings_Internal _npadNo7;

			// Token: 0x0400219B RID: 8603
			[Token(Token = "0x400219B")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			private NintendoSwitchInputManager.NpadSettings_Internal _npadNo8;

			// Token: 0x0400219C RID: 8604
			[Token(Token = "0x400219C")]
			[FieldOffset(Offset = "0x3C")]
			[SerializeField]
			private NintendoSwitchInputManager.NpadSettings_Internal _npadHandheld;

			// Token: 0x0400219D RID: 8605
			[Token(Token = "0x400219D")]
			[FieldOffset(Offset = "0x40")]
			[SerializeField]
			private NintendoSwitchInputManager.DebugPadSettings_Internal _debugPad;

			// Token: 0x0400219E RID: 8606
			[Token(Token = "0x400219E")]
			[FieldOffset(Offset = "0x44")]
			private Dictionary<int, object[]> __delegates;
		}

		// Token: 0x02000545 RID: 1349
		[Token(Token = "0x2000545")]
		[Serializable]
		private sealed class NpadSettings_Internal : IKeyedData<int>
		{
			// Token: 0x1700061B RID: 1563
			// (get) Token: 0x06001E74 RID: 7796 RVA: 0x00008E98 File Offset: 0x00007098
			// (set) Token: 0x06001E75 RID: 7797 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700061B")]
			private bool isAllowed
			{
				[Token(Token = "0x6001E74")]
				[Address(RVA = "0x28A630", Offset = "0x289A30", VA = "0x1028A630")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6001E75")]
				[Address(RVA = "0x28A640", Offset = "0x289A40", VA = "0x1028A640")]
				set
				{
				}
			}

			// Token: 0x1700061C RID: 1564
			// (get) Token: 0x06001E76 RID: 7798 RVA: 0x00008EB0 File Offset: 0x000070B0
			// (set) Token: 0x06001E77 RID: 7799 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700061C")]
			private int rewiredPlayerId
			{
				[Token(Token = "0x6001E76")]
				[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90")]
				get
				{
					return 0;
				}
				[Token(Token = "0x6001E77")]
				[Address(RVA = "0x273ED0", Offset = "0x2732D0", VA = "0x10273ED0")]
				set
				{
				}
			}

			// Token: 0x1700061D RID: 1565
			// (get) Token: 0x06001E78 RID: 7800 RVA: 0x00008EC8 File Offset: 0x000070C8
			// (set) Token: 0x06001E79 RID: 7801 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700061D")]
			private int joyConAssignmentMode
			{
				[Token(Token = "0x6001E78")]
				[Address(RVA = "0x273EC0", Offset = "0x2732C0", VA = "0x10273EC0")]
				get
				{
					return 0;
				}
				[Token(Token = "0x6001E79")]
				[Address(RVA = "0x273100", Offset = "0x272500", VA = "0x10273100")]
				set
				{
				}
			}

			// Token: 0x06001E7A RID: 7802 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001E7A")]
			[Address(RVA = "0x78EBD0", Offset = "0x78DFD0", VA = "0x1078EBD0")]
			internal NpadSettings_Internal(int playerId)
			{
			}

			// Token: 0x1700061E RID: 1566
			// (get) Token: 0x06001E7B RID: 7803 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700061E")]
			private Dictionary<int, object[]> delegates
			{
				[Token(Token = "0x6001E7B")]
				[Address(RVA = "0x78EC00", Offset = "0x78E000", VA = "0x1078EC00")]
				get
				{
					return null;
				}
			}

			// Token: 0x06001E7C RID: 7804 RVA: 0x00008EE0 File Offset: 0x000070E0
			[Token(Token = "0x6001E7C")]
			private bool TryGetValue<T>(int key, out T value)
			{
				return default(bool);
			}

			// Token: 0x06001E7D RID: 7805 RVA: 0x00008EF8 File Offset: 0x000070F8
			[Token(Token = "0x6001E7D")]
			private bool TrySetValue<T>(int key, T value)
			{
				return default(bool);
			}

			// Token: 0x06001E7E RID: 7806 RVA: 0x00008F10 File Offset: 0x00007110
			[Token(Token = "0x6001E7E")]
			[Address(RVA = "0x28A630", Offset = "0x289A30", VA = "0x1028A630")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private bool <get_delegates>b__15_0()
			{
				return default(bool);
			}

			// Token: 0x06001E7F RID: 7807 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001E7F")]
			[Address(RVA = "0x28A640", Offset = "0x289A40", VA = "0x1028A640")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private void <get_delegates>b__15_1(bool x)
			{
			}

			// Token: 0x06001E80 RID: 7808 RVA: 0x00008F28 File Offset: 0x00007128
			[Token(Token = "0x6001E80")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private int <get_delegates>b__15_2()
			{
				return 0;
			}

			// Token: 0x06001E81 RID: 7809 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001E81")]
			[Address(RVA = "0x273ED0", Offset = "0x2732D0", VA = "0x10273ED0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private void <get_delegates>b__15_3(int x)
			{
			}

			// Token: 0x06001E82 RID: 7810 RVA: 0x00008F40 File Offset: 0x00007140
			[Token(Token = "0x6001E82")]
			[Address(RVA = "0x273EC0", Offset = "0x2732C0", VA = "0x10273EC0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private int <get_delegates>b__15_4()
			{
				return 0;
			}

			// Token: 0x06001E83 RID: 7811 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001E83")]
			[Address(RVA = "0x273100", Offset = "0x272500", VA = "0x10273100")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private void <get_delegates>b__15_5(int x)
			{
			}

			// Token: 0x0400219F RID: 8607
			[Token(Token = "0x400219F")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			[Attribute(Name = "TooltipAttribute", RVA = "0xE1AD0", Offset = "0xE0ED0")]
			private bool _isAllowed;

			// Token: 0x040021A0 RID: 8608
			[Token(Token = "0x40021A0")]
			[FieldOffset(Offset = "0xC")]
			[Attribute(Name = "TooltipAttribute", RVA = "0xE1B60", Offset = "0xE0F60")]
			[SerializeField]
			private int _rewiredPlayerId;

			// Token: 0x040021A1 RID: 8609
			[Token(Token = "0x40021A1")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "TooltipAttribute", RVA = "0xE1BA0", Offset = "0xE0FA0")]
			[SerializeField]
			private int _joyConAssignmentMode;

			// Token: 0x040021A2 RID: 8610
			[Token(Token = "0x40021A2")]
			[FieldOffset(Offset = "0x14")]
			private Dictionary<int, object[]> __delegates;
		}

		// Token: 0x02000546 RID: 1350
		[Token(Token = "0x2000546")]
		[Serializable]
		private sealed class DebugPadSettings_Internal : IKeyedData<int>
		{
			// Token: 0x1700061F RID: 1567
			// (get) Token: 0x06001E84 RID: 7812 RVA: 0x00008F58 File Offset: 0x00007158
			// (set) Token: 0x06001E85 RID: 7813 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700061F")]
			private int rewiredPlayerId
			{
				[Token(Token = "0x6001E84")]
				[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90")]
				get
				{
					return 0;
				}
				[Token(Token = "0x6001E85")]
				[Address(RVA = "0x273ED0", Offset = "0x2732D0", VA = "0x10273ED0")]
				set
				{
				}
			}

			// Token: 0x17000620 RID: 1568
			// (get) Token: 0x06001E86 RID: 7814 RVA: 0x00008F70 File Offset: 0x00007170
			// (set) Token: 0x06001E87 RID: 7815 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000620")]
			private bool enabled
			{
				[Token(Token = "0x6001E86")]
				[Address(RVA = "0x28A630", Offset = "0x289A30", VA = "0x1028A630")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6001E87")]
				[Address(RVA = "0x28A640", Offset = "0x289A40", VA = "0x1028A640")]
				set
				{
				}
			}

			// Token: 0x06001E88 RID: 7816 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001E88")]
			[Address(RVA = "0x58E690", Offset = "0x58DA90", VA = "0x1058E690")]
			internal DebugPadSettings_Internal(int playerId)
			{
			}

			// Token: 0x17000621 RID: 1569
			// (get) Token: 0x06001E89 RID: 7817 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000621")]
			private Dictionary<int, object[]> delegates
			{
				[Token(Token = "0x6001E89")]
				[Address(RVA = "0x78E620", Offset = "0x78DA20", VA = "0x1078E620")]
				get
				{
					return null;
				}
			}

			// Token: 0x06001E8A RID: 7818 RVA: 0x00008F88 File Offset: 0x00007188
			[Token(Token = "0x6001E8A")]
			private bool TryGetValue<T>(int key, out T value)
			{
				return default(bool);
			}

			// Token: 0x06001E8B RID: 7819 RVA: 0x00008FA0 File Offset: 0x000071A0
			[Token(Token = "0x6001E8B")]
			private bool TrySetValue<T>(int key, T value)
			{
				return default(bool);
			}

			// Token: 0x06001E8C RID: 7820 RVA: 0x00008FB8 File Offset: 0x000071B8
			[Token(Token = "0x6001E8C")]
			[Address(RVA = "0x28A630", Offset = "0x289A30", VA = "0x1028A630")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private bool <get_delegates>b__11_0()
			{
				return default(bool);
			}

			// Token: 0x06001E8D RID: 7821 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001E8D")]
			[Address(RVA = "0x28A640", Offset = "0x289A40", VA = "0x1028A640")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private void <get_delegates>b__11_1(bool x)
			{
			}

			// Token: 0x06001E8E RID: 7822 RVA: 0x00008FD0 File Offset: 0x000071D0
			[Token(Token = "0x6001E8E")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private int <get_delegates>b__11_2()
			{
				return 0;
			}

			// Token: 0x06001E8F RID: 7823 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001E8F")]
			[Address(RVA = "0x273ED0", Offset = "0x2732D0", VA = "0x10273ED0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private void <get_delegates>b__11_3(int x)
			{
			}

			// Token: 0x040021A3 RID: 8611
			[Token(Token = "0x40021A3")]
			[FieldOffset(Offset = "0x8")]
			[Attribute(Name = "TooltipAttribute", RVA = "0xE1DC0", Offset = "0xE11C0")]
			[SerializeField]
			private bool _enabled;

			// Token: 0x040021A4 RID: 8612
			[Token(Token = "0x40021A4")]
			[FieldOffset(Offset = "0xC")]
			[Attribute(Name = "TooltipAttribute", RVA = "0xE1E50", Offset = "0xE1250")]
			[SerializeField]
			private int _rewiredPlayerId;

			// Token: 0x040021A5 RID: 8613
			[Token(Token = "0x40021A5")]
			[FieldOffset(Offset = "0x10")]
			private Dictionary<int, object[]> __delegates;
		}
	}
}
